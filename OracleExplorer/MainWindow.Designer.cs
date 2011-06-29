namespace OracleExplorer
{
  partial class MainWindow
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      this.treeConnections = new System.Windows.Forms.TreeView();
      this.imageList = new System.Windows.Forms.ImageList(this.components);
      this.txtQuery = new System.Windows.Forms.TextBox();
      this.lblConn = new System.Windows.Forms.Label();
      this.gridOutput = new System.Windows.Forms.DataGridView();
      this.bnHelp = new System.Windows.Forms.Button();
      this.bnEdit = new System.Windows.Forms.Button();
      this.bnDelete = new System.Windows.Forms.Button();
      this.bnNew = new System.Windows.Forms.Button();
      this.bnExecute = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.gridOutput)).BeginInit();
      this.SuspendLayout();
      // 
      // treeConnections
      // 
      this.treeConnections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)));
      this.treeConnections.ImageIndex = 0;
      this.treeConnections.ImageList = this.imageList;
      this.treeConnections.Location = new System.Drawing.Point(8, 40);
      this.treeConnections.Name = "treeConnections";
      this.treeConnections.SelectedImageIndex = 0;
      this.treeConnections.Size = new System.Drawing.Size(232, 408);
      this.treeConnections.TabIndex = 3;
      this.treeConnections.DoubleClick += new System.EventHandler(this.treeConnections_DoubleClick);
      this.treeConnections.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeConnections_AfterExpand);
      // 
      // imageList
      // 
      this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
      this.imageList.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList.Images.SetKeyName(0, "");
      this.imageList.Images.SetKeyName(1, "");
      this.imageList.Images.SetKeyName(2, "");
      this.imageList.Images.SetKeyName(3, "table.png");
      this.imageList.Images.SetKeyName(4, "view.png");
      this.imageList.Images.SetKeyName(5, "");
      // 
      // txtQuery
      // 
      this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtQuery.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtQuery.Location = new System.Drawing.Point(248, 40);
      this.txtQuery.Multiline = true;
      this.txtQuery.Name = "txtQuery";
      this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtQuery.Size = new System.Drawing.Size(504, 64);
      this.txtQuery.TabIndex = 5;
      // 
      // lblConn
      // 
      this.lblConn.AutoSize = true;
      this.lblConn.Location = new System.Drawing.Point(352, 16);
      this.lblConn.Name = "lblConn";
      this.lblConn.Size = new System.Drawing.Size(64, 13);
      this.lblConn.TabIndex = 2;
      this.lblConn.Text = "Connection:";
      // 
      // gridOutput
      // 
      this.gridOutput.AllowUserToAddRows = false;
      this.gridOutput.AllowUserToDeleteRows = false;
      this.gridOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.gridOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridOutput.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.gridOutput.Location = new System.Drawing.Point(248, 112);
      this.gridOutput.Name = "gridOutput";
      this.gridOutput.Size = new System.Drawing.Size(504, 336);
      this.gridOutput.TabIndex = 6;
      // 
      // bnHelp
      // 
      this.bnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.bnHelp.Image = global::OracleExplorer.Properties.Resources.help;
      this.bnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.bnHelp.Location = new System.Drawing.Point(696, 8);
      this.bnHelp.Name = "bnHelp";
      this.bnHelp.Size = new System.Drawing.Size(56, 24);
      this.bnHelp.TabIndex = 7;
      this.bnHelp.Text = "Help";
      this.bnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.bnHelp.UseVisualStyleBackColor = true;
      this.bnHelp.Click += new System.EventHandler(this.bnHelp_Click);
      // 
      // bnEdit
      // 
      this.bnEdit.Image = global::OracleExplorer.Properties.Resources.edit;
      this.bnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.bnEdit.Location = new System.Drawing.Point(144, 8);
      this.bnEdit.Name = "bnEdit";
      this.bnEdit.Size = new System.Drawing.Size(48, 24);
      this.bnEdit.TabIndex = 2;
      this.bnEdit.Text = "Edit";
      this.bnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.bnEdit.UseVisualStyleBackColor = true;
      this.bnEdit.Click += new System.EventHandler(this.bnEdit_Click);
      // 
      // bnDelete
      // 
      this.bnDelete.Image = global::OracleExplorer.Properties.Resources.db_remove;
      this.bnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.bnDelete.Location = new System.Drawing.Point(72, 8);
      this.bnDelete.Name = "bnDelete";
      this.bnDelete.Size = new System.Drawing.Size(64, 24);
      this.bnDelete.TabIndex = 1;
      this.bnDelete.Text = "Delete";
      this.bnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.bnDelete.UseVisualStyleBackColor = true;
      this.bnDelete.Click += new System.EventHandler(this.bnDelete_Click);
      // 
      // bnNew
      // 
      this.bnNew.Image = global::OracleExplorer.Properties.Resources.db_add;
      this.bnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.bnNew.Location = new System.Drawing.Point(8, 8);
      this.bnNew.Name = "bnNew";
      this.bnNew.Size = new System.Drawing.Size(56, 24);
      this.bnNew.TabIndex = 0;
      this.bnNew.Text = "New";
      this.bnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.bnNew.UseVisualStyleBackColor = true;
      this.bnNew.Click += new System.EventHandler(this.bnNew_Click);
      // 
      // bnExecute
      // 
      this.bnExecute.Image = global::OracleExplorer.Properties.Resources.control_play_blue;
      this.bnExecute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.bnExecute.Location = new System.Drawing.Point(248, 8);
      this.bnExecute.Name = "bnExecute";
      this.bnExecute.Size = new System.Drawing.Size(96, 24);
      this.bnExecute.TabIndex = 4;
      this.bnExecute.Text = "Execute SQL";
      this.bnExecute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.bnExecute.UseVisualStyleBackColor = true;
      this.bnExecute.Click += new System.EventHandler(this.bnExecute_Click);
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 457);
      this.Controls.Add(this.bnHelp);
      this.Controls.Add(this.bnEdit);
      this.Controls.Add(this.bnDelete);
      this.Controls.Add(this.bnNew);
      this.Controls.Add(this.bnExecute);
      this.Controls.Add(this.gridOutput);
      this.Controls.Add(this.lblConn);
      this.Controls.Add(this.txtQuery);
      this.Controls.Add(this.treeConnections);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(558, 217);
      this.Name = "MainWindow";
      this.Text = "Oracle Explorer";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
      this.Load += new System.EventHandler(this.MainWindow_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridOutput)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TreeView treeConnections;
    private System.Windows.Forms.ImageList imageList;
    private System.Windows.Forms.TextBox txtQuery;
    private System.Windows.Forms.Label lblConn;
    private System.Windows.Forms.DataGridView gridOutput;
    private System.Windows.Forms.Button bnExecute;
    private System.Windows.Forms.Button bnNew;
    private System.Windows.Forms.Button bnDelete;
    private System.Windows.Forms.Button bnEdit;
    private System.Windows.Forms.Button bnHelp;
  }
}

