using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OracleExplorer.Code;
using System.Data.OracleClient;

namespace OracleExplorer
{
  public partial class MainWindow : Form
  {
    List<Connection> connections = new List<Connection>();
    Connection selected_conn = null;
    Settings settings = null;
    const string loading = "...loading...";

    public MainWindow()
    {
      InitializeComponent();
    }

    /// <summary>
    /// This does the initial load of this form
    /// Firstly it checks that the oracle instant client DLLs are present
    /// Then it loads the settings from disk
    /// </summary>
    private void MainWindow_Load(object sender, EventArgs e)
    {
      bnHelp_Click(null, null);
            
      DbHelper h = new DbHelper();

      if (!h.OracleFilesPresent())
      {
        MessageBox.Show(
@"Oracle Driver files aren't all present:
oci.dll, orannzsbb*.dll, oraocci*.dll, oraociicus*.dll
This files must be in the same folder as the Oracle Explorer executable for the oracle connection to work.
These files can be obtained from the Oracle Instant Client from the oracle website");
      }

      // Load the settings
      if (settings == null)
      {
        settings = new Settings();
        settings.Load();

        connections = settings.Connections;
        foreach (Connection c in connections)
        {
          TreeNode n = new TreeNode(c.Name);
          n.ImageIndex = n.SelectedImageIndex = 1;
          n.Tag = c;
          n.Nodes.Add(loading);
          treeConnections.Nodes.Add(n);
        }
      }

      // initialise controls
      lblConn.Text = "";
      txtQuery.Enabled = false;
      gridOutput.Enabled = false;
      bnExecute.Enabled = false;
    }

    /// <summary>
    /// This saves to the database
    /// </summary>
    private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (settings != null)
      {
        settings.Connections = connections;
        settings.Save();
        settings = null;
      }
    }

    /// <summary>
    /// If the user expanded something with a '...loading...' under it, then load it
    /// </summary>
    private void treeConnections_AfterExpand(object sender, TreeViewEventArgs e)
    {
      // Allow it to display the 'loading' text
      Application.DoEvents();

      // Are we expanding something that has a 'loading' placeholder?
      if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == loading)
      {
        object tag = e.Node.Tag;

        if (tag is Connection) // Are we expanding a connection?
        {
          using (new CursorHelper(this)) // Display the hourglass
          {
            // Load it up
            e.Node.Nodes.Clear();
            foreach (Schema schema in ((Connection)tag).Schemas)
            {
              TreeNode n = new TreeNode(schema.Name);
              n.ImageIndex = n.SelectedImageIndex = 2;
              n.Tag = schema;
              n.Nodes.Add(loading);
              e.Node.Nodes.Add(n);
            }
          }
        }

        if (tag is Schema) // Are we expanding a schema?
        {
          using (new CursorHelper(this)) // Display the hourglass
          {
            e.Node.Nodes.Clear();
            foreach (Table table in ((Schema)tag).Tables)
            {
              TreeNode n = new TreeNode(table.Name);
              n.ImageIndex = n.SelectedImageIndex = table.View ? 4 : 3;
              n.Tag = table;
              n.ToolTipText = "Double-click to query this table";
              e.Node.Nodes.Add(n);
            }
          }
        }
      }
    }

    private void treeConnections_DoubleClick(object sender, EventArgs e)
    {
      // Did they double click anything important?
      TreeNode node = treeConnections.SelectedNode;
      if (node.Tag is Table)
      {
        // Open up the table in the query screen
        Table t = (Table)(node.Tag);
        txtQuery.Text = "select * from " + t.ParentSchema.Name + "." + t.Name;
        lblConn.Text = "Connection: " + t.ParentSchema.ParentConnection.Name;
        selected_conn = t.ParentSchema.ParentConnection;
        txtQuery.Enabled = true;
        gridOutput.Enabled = true;
        bnExecute.Enabled = true;
        Application.DoEvents(); // show the updates from above
        bnExecute_Click(null, null);
      }
    }

    private void bnExecute_Click(object sender, EventArgs e)
    {
      // Execute the given query for the first 1000 records it spits out
      try
      {
        using (new CursorHelper(this)) // Display the hourglass
        {
          using (OracleConnection conn = new OracleConnection(selected_conn.ConnectionString))
          {
            conn.Open();
            string sql = txtQuery.Text;
            using (OracleCommand comm = new OracleCommand(sql, conn))
            {
              using (OracleDataReader rdr = comm.ExecuteReader())
              {
                // Grab all the column names
                gridOutput.Rows.Clear();
                gridOutput.Columns.Clear();
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                  gridOutput.Columns.Add(i.ToString(), rdr.GetName(i));
                }

                // Read up to 1000 rows
                int rows = 0;
                while (rdr.Read() && rows < 1000)
                {
                  string[] objs = new string[rdr.FieldCount];
                  for (int f = 0; f < rdr.FieldCount; f++) objs[f] = rdr[f].ToString();
                  gridOutput.Rows.Add(objs);
                  rows++;
                }
              }
            }
            conn.Close();
          }
        }
      }
      catch (Exception ex) // Better catch in case they have bad sql
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void bnNew_Click(object sender, EventArgs e)
    {
      EditConnection ec = new EditConnection();
      if (ec.ShowDialog() == DialogResult.OK)
      {
        Connection c = new Connection();
        ec.SaveConnection(c);
        TreeNode n = new TreeNode(c.Name);
        n.ImageIndex = 1;
        n.SelectedImageIndex = 1;
        n.Tag = c;
        n.Nodes.Add(loading);
        treeConnections.Nodes.Add(n);
        connections.Add(c);
      }
    }

    private void bnDelete_Click(object sender, EventArgs e)
    {
      if (treeConnections.SelectedNode != null && treeConnections.SelectedNode.Tag is Connection)
      {
        Connection c = (Connection)treeConnections.SelectedNode.Tag;
        string prompt = "Are you sure you wish to delete " + c.Name + "?";
        if (MessageBox.Show(prompt, "Delete connection", MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
          connections.Remove(c);
          treeConnections.Nodes.Remove(treeConnections.SelectedNode);
        }
      }
      else
      {
        MessageBox.Show("You must click on a connection in the list below first, if you wish to delete it");
      }
    }

    private void bnEdit_Click(object sender, EventArgs e)
    {
      if (treeConnections.SelectedNode != null && treeConnections.SelectedNode.Tag is Connection)
      {
        // Edit the connection
        Connection c = (Connection)treeConnections.SelectedNode.Tag;
        EditConnection ec = new EditConnection();
        ec.LoadConnection(c);
        if (ec.ShowDialog() == DialogResult.OK)
        {
          // Since we can't update the tree node thing, we'll just delete and re-create it
          ec.SaveConnection(c);
          treeConnections.Nodes.Remove(treeConnections.SelectedNode);
          TreeNode n = new TreeNode(c.Name);
          n.ImageIndex = 1;
          n.SelectedImageIndex = 1;
          n.Tag = c;
          n.Nodes.Add(loading);
          treeConnections.Nodes.Add(n);
        }
      }
      else
      {
        MessageBox.Show("You must click on a connection in the list below first, if you wish to delete it");
      }
    }

    /// <summary>
    /// Welcome message
    /// </summary>
    private void bnHelp_Click(object sender, EventArgs e)
    {
      MessageBox.Show(@"Firstly you'll want to click on 'new' to create one or more new database connections.
Once you've done this, expand the connection to view users/schemas.
Expanding those will reveal tables/views.
When you double-click on a table or view, it will load the first 1000 rows from this table into a grid on the right.",
"Welcome to Oracle Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}