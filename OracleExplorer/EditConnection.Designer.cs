namespace OracleExplorer
{
  partial class EditConnection
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditConnection));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.rbSid = new System.Windows.Forms.RadioButton();
      this.rbService = new System.Windows.Forms.RadioButton();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtUser = new System.Windows.Forms.TextBox();
      this.txtPass = new System.Windows.Forms.TextBox();
      this.txtHost = new System.Windows.Forms.TextBox();
      this.txtSid = new System.Windows.Forms.TextBox();
      this.txtService = new System.Windows.Forms.TextBox();
      this.bnOk = new System.Windows.Forms.Button();
      this.bnCancel = new System.Windows.Forms.Button();
      this.txtPort = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(64, 56);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Connection Name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(64, 88);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(55, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Username";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(64, 112);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Password";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(64, 144);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Host";
      // 
      // rbSid
      // 
      this.rbSid.AutoSize = true;
      this.rbSid.Location = new System.Drawing.Point(64, 192);
      this.rbSid.Name = "rbSid";
      this.rbSid.Size = new System.Drawing.Size(43, 17);
      this.rbSid.TabIndex = 4;
      this.rbSid.TabStop = true;
      this.rbSid.Text = "SID";
      this.rbSid.UseVisualStyleBackColor = true;
      this.rbSid.CheckedChanged += new System.EventHandler(this.rbSid_CheckedChanged);
      // 
      // rbService
      // 
      this.rbService.AutoSize = true;
      this.rbService.Location = new System.Drawing.Point(64, 216);
      this.rbService.Name = "rbService";
      this.rbService.Size = new System.Drawing.Size(92, 17);
      this.rbService.TabIndex = 6;
      this.rbService.TabStop = true;
      this.rbService.Text = "Service Name";
      this.rbService.UseVisualStyleBackColor = true;
      this.rbService.CheckedChanged += new System.EventHandler(this.rbService_CheckedChanged);
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(176, 56);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(240, 20);
      this.txtName.TabIndex = 0;
      this.txtName.Text = "New Connection";
      // 
      // txtUser
      // 
      this.txtUser.Location = new System.Drawing.Point(176, 88);
      this.txtUser.Name = "txtUser";
      this.txtUser.Size = new System.Drawing.Size(240, 20);
      this.txtUser.TabIndex = 1;
      // 
      // txtPass
      // 
      this.txtPass.Location = new System.Drawing.Point(176, 112);
      this.txtPass.Name = "txtPass";
      this.txtPass.Size = new System.Drawing.Size(240, 20);
      this.txtPass.TabIndex = 2;
      // 
      // txtHost
      // 
      this.txtHost.Location = new System.Drawing.Point(176, 144);
      this.txtHost.Name = "txtHost";
      this.txtHost.Size = new System.Drawing.Size(240, 20);
      this.txtHost.TabIndex = 3;
      // 
      // txtSid
      // 
      this.txtSid.Location = new System.Drawing.Point(176, 192);
      this.txtSid.Name = "txtSid";
      this.txtSid.Size = new System.Drawing.Size(240, 20);
      this.txtSid.TabIndex = 5;
      // 
      // txtService
      // 
      this.txtService.Location = new System.Drawing.Point(176, 216);
      this.txtService.Name = "txtService";
      this.txtService.Size = new System.Drawing.Size(240, 20);
      this.txtService.TabIndex = 6;
      // 
      // bnOk
      // 
      this.bnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bnOk.Location = new System.Drawing.Point(264, 256);
      this.bnOk.Name = "bnOk";
      this.bnOk.Size = new System.Drawing.Size(75, 23);
      this.bnOk.TabIndex = 7;
      this.bnOk.Text = "Ok";
      this.bnOk.UseVisualStyleBackColor = true;
      // 
      // bnCancel
      // 
      this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bnCancel.Location = new System.Drawing.Point(344, 256);
      this.bnCancel.Name = "bnCancel";
      this.bnCancel.Size = new System.Drawing.Size(75, 23);
      this.bnCancel.TabIndex = 8;
      this.bnCancel.Text = "Cancel";
      this.bnCancel.UseVisualStyleBackColor = true;
      // 
      // txtPort
      // 
      this.txtPort.Location = new System.Drawing.Point(176, 168);
      this.txtPort.Name = "txtPort";
      this.txtPort.Size = new System.Drawing.Size(240, 20);
      this.txtPort.TabIndex = 4;
      this.txtPort.Text = "1521";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(64, 168);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(26, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "Port";
      // 
      // EditConnection
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(505, 328);
      this.Controls.Add(this.txtPort);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.bnCancel);
      this.Controls.Add(this.bnOk);
      this.Controls.Add(this.txtService);
      this.Controls.Add(this.txtSid);
      this.Controls.Add(this.txtHost);
      this.Controls.Add(this.txtPass);
      this.Controls.Add(this.txtUser);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.rbService);
      this.Controls.Add(this.rbSid);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "EditConnection";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Connection";
      this.Load += new System.EventHandler(this.EditConnection_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.RadioButton rbSid;
    private System.Windows.Forms.RadioButton rbService;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtUser;
    private System.Windows.Forms.TextBox txtPass;
    private System.Windows.Forms.TextBox txtHost;
    private System.Windows.Forms.TextBox txtSid;
    private System.Windows.Forms.TextBox txtService;
    private System.Windows.Forms.Button bnOk;
    private System.Windows.Forms.Button bnCancel;
    private System.Windows.Forms.TextBox txtPort;
    private System.Windows.Forms.Label label5;
  }
}