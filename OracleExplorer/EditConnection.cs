using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OracleExplorer.Code;

namespace OracleExplorer
{
  public partial class EditConnection : Form
  {
    public EditConnection()
    {
      InitializeComponent();
    }

    private void EditConnection_Load(object sender, EventArgs e)
    {
      SetCheckboxes();
    }

    /// <summary>
    /// Choose the correct checkbox, given the current text in the textboxes
    /// </summary>
    private void SetCheckboxes()
    {
      if (txtSid.Text != "") rbSid.Checked = true;
      rbService.Checked = !rbSid.Checked;

      UpdateSidServiceTextboxes();
    }

    /// <summary>
    /// Enable the text boxes as dictated by the radio buttons
    /// </summary>
    private void UpdateSidServiceTextboxes()
    {
      txtSid.Enabled = rbSid.Checked;
      txtService.Enabled = rbService.Checked;
    }

    private void rbSid_CheckedChanged(object sender, EventArgs e)
    {
      UpdateSidServiceTextboxes();
    }

    private void rbService_CheckedChanged(object sender, EventArgs e)
    {
      UpdateSidServiceTextboxes();
    }

    /// <summary>
    /// Get the connection details from the dialog controls in the format of a connection class
    /// </summary>
    public void SaveConnection(Connection c)
    {
      c.Name = txtName.Text.Trim();
      c.User = txtUser.Text.Trim();
      c.Pass = txtPass.Text.Trim();
      c.Host = txtHost.Text.Trim();
      c.Port = txtPort.Text.Trim();
      c.Sid = txtSid.Enabled ? txtSid.Text.Trim() : "";
      c.Service = txtService.Enabled ? txtService.Text.Trim() : "";
    }

    /// <summary>
    /// Load the text boxes from the given conncetion
    /// </summary>
    public void LoadConnection(Connection c)
    {
      txtName.Text = c.Name; 
      txtUser.Text = c.User; 
      txtPass.Text = c.Pass; 
      txtHost.Text = c.Host;
      txtPort.Text = c.Port;
      txtSid.Text = c.Sid;
      txtService.Text = c.Service; 
    }
  }
}