namespace MISLiveMed.UI.Main.Administration.Configuration
{
    partial class ServerConfigurationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerConfigurationForm));
			this.mainPanel = new DevExpress.XtraEditors.PanelControl();
			this.btnLogConfiguration = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.databasePanel = new DevExpress.XtraEditors.PanelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.lblDatabasePort = new DevExpress.XtraEditors.LabelControl();
			this.lblDatabasePassword = new DevExpress.XtraEditors.LabelControl();
			this.lblDatabaseUserName = new DevExpress.XtraEditors.LabelControl();
			this.lblDatabaseHost = new DevExpress.XtraEditors.LabelControl();
			this.lblDatabaseType = new DevExpress.XtraEditors.LabelControl();
			this.txtDatabaseName = new DevExpress.XtraEditors.TextEdit();
			this.txtPassword = new DevExpress.XtraEditors.TextEdit();
			this.txtUserName = new DevExpress.XtraEditors.TextEdit();
			this.txtDatabasePort = new DevExpress.XtraEditors.TextEdit();
			this.txtDatabaseHost = new DevExpress.XtraEditors.TextEdit();
			this.lblInfo = new DevExpress.XtraEditors.LabelControl();
			this.lblTitle = new DevExpress.XtraEditors.LabelControl();
			this.cboDatabaseType = new DevExpress.XtraEditors.LookUpEdit();
			this.infoPanel = new DevExpress.XtraEditors.PanelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.lblLogConfiguration = new DevExpress.XtraEditors.LabelControl();
			this.cboLevelFile = new DevExpress.XtraEditors.LookUpEdit();
			this.cboLevelNHibernate = new DevExpress.XtraEditors.LookUpEdit();
			((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.databasePanel)).BeginInit();
			this.databasePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDatabaseName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatabasePort.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatabaseHost.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboDatabaseType.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.infoPanel)).BeginInit();
			this.infoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboLevelFile.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboLevelNHibernate.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.btnLogConfiguration);
			this.mainPanel.Controls.Add(this.btnCancel);
			this.mainPanel.Controls.Add(this.btnSave);
			this.mainPanel.Controls.Add(this.databasePanel);
			this.mainPanel.Controls.Add(this.infoPanel);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(728, 370);
			this.mainPanel.TabIndex = 4;
			// 
			// btnLogConfiguration
			// 
			this.btnLogConfiguration.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnLogConfiguration.Appearance.Options.UseBackColor = true;
			this.btnLogConfiguration.ImageOptions.Image = global::MISLiveMed.UI.Properties.Resources.file_16_light;
			this.btnLogConfiguration.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
			this.btnLogConfiguration.Location = new System.Drawing.Point(12, 322);
			this.btnLogConfiguration.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnLogConfiguration.Name = "btnLogConfiguration";
			this.btnLogConfiguration.Size = new System.Drawing.Size(41, 30);
			this.btnLogConfiguration.TabIndex = 0;
			this.btnLogConfiguration.Click += new System.EventHandler(this.btnLogConfiguration_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(606, 322);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(101, 30);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(484, 322);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(101, 30);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// databasePanel
			// 
			this.databasePanel.Controls.Add(this.labelControl3);
			this.databasePanel.Controls.Add(this.lblDatabasePort);
			this.databasePanel.Controls.Add(this.lblDatabasePassword);
			this.databasePanel.Controls.Add(this.lblDatabaseUserName);
			this.databasePanel.Controls.Add(this.lblDatabaseHost);
			this.databasePanel.Controls.Add(this.lblDatabaseType);
			this.databasePanel.Controls.Add(this.txtDatabaseName);
			this.databasePanel.Controls.Add(this.txtPassword);
			this.databasePanel.Controls.Add(this.txtUserName);
			this.databasePanel.Controls.Add(this.txtDatabasePort);
			this.databasePanel.Controls.Add(this.txtDatabaseHost);
			this.databasePanel.Controls.Add(this.lblInfo);
			this.databasePanel.Controls.Add(this.lblTitle);
			this.databasePanel.Controls.Add(this.cboDatabaseType);
			this.databasePanel.Location = new System.Drawing.Point(12, 12);
			this.databasePanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.databasePanel.Name = "databasePanel";
			this.databasePanel.Size = new System.Drawing.Size(695, 294);
			this.databasePanel.TabIndex = 3;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(132, 244);
			this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(95, 16);
			this.labelControl3.TabIndex = 4;
			this.labelControl3.Text = "Database Name:";
			// 
			// lblDatabasePort
			// 
			this.lblDatabasePort.Location = new System.Drawing.Point(421, 152);
			this.lblDatabasePort.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.lblDatabasePort.Name = "lblDatabasePort";
			this.lblDatabasePort.Size = new System.Drawing.Size(85, 16);
			this.lblDatabasePort.TabIndex = 4;
			this.lblDatabasePort.Text = "Database Port:";
			// 
			// lblDatabasePassword
			// 
			this.lblDatabasePassword.Location = new System.Drawing.Point(421, 198);
			this.lblDatabasePassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.lblDatabasePassword.Name = "lblDatabasePassword";
			this.lblDatabasePassword.Size = new System.Drawing.Size(60, 16);
			this.lblDatabasePassword.TabIndex = 4;
			this.lblDatabasePassword.Text = "Password:";
			// 
			// lblDatabaseUserName
			// 
			this.lblDatabaseUserName.Location = new System.Drawing.Point(130, 200);
			this.lblDatabaseUserName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.lblDatabaseUserName.Name = "lblDatabaseUserName";
			this.lblDatabaseUserName.Size = new System.Drawing.Size(68, 16);
			this.lblDatabaseUserName.TabIndex = 4;
			this.lblDatabaseUserName.Text = "User Name:";
			// 
			// lblDatabaseHost
			// 
			this.lblDatabaseHost.Location = new System.Drawing.Point(132, 155);
			this.lblDatabaseHost.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.lblDatabaseHost.Name = "lblDatabaseHost";
			this.lblDatabaseHost.Size = new System.Drawing.Size(87, 16);
			this.lblDatabaseHost.TabIndex = 4;
			this.lblDatabaseHost.Text = "Database Host:";
			// 
			// lblDatabaseType
			// 
			this.lblDatabaseType.Location = new System.Drawing.Point(25, 111);
			this.lblDatabaseType.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.lblDatabaseType.Name = "lblDatabaseType";
			this.lblDatabaseType.Size = new System.Drawing.Size(85, 16);
			this.lblDatabaseType.TabIndex = 4;
			this.lblDatabaseType.Text = "Database Type";
			// 
			// txtDatabaseName
			// 
			this.txtDatabaseName.Location = new System.Drawing.Point(242, 241);
			this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtDatabaseName.Name = "txtDatabaseName";
			this.txtDatabaseName.Size = new System.Drawing.Size(134, 22);
			this.txtDatabaseName.TabIndex = 5;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(530, 194);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Properties.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(134, 22);
			this.txtPassword.TabIndex = 4;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(242, 198);
			this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(134, 22);
			this.txtUserName.TabIndex = 3;
			// 
			// txtDatabasePort
			// 
			this.txtDatabasePort.Location = new System.Drawing.Point(530, 149);
			this.txtDatabasePort.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtDatabasePort.Name = "txtDatabasePort";
			this.txtDatabasePort.Size = new System.Drawing.Size(134, 22);
			this.txtDatabasePort.TabIndex = 2;
			// 
			// txtDatabaseHost
			// 
			this.txtDatabaseHost.Location = new System.Drawing.Point(242, 152);
			this.txtDatabaseHost.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtDatabaseHost.Name = "txtDatabaseHost";
			this.txtDatabaseHost.Size = new System.Drawing.Size(134, 22);
			this.txtDatabaseHost.TabIndex = 1;
			// 
			// lblInfo
			// 
			this.lblInfo.Location = new System.Drawing.Point(22, 61);
			this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(332, 16);
			this.lblInfo.TabIndex = 1;
			this.lblInfo.Text = "Enter the connection credentials for your database server ";
			// 
			// lblTitle
			// 
			this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F);
			this.lblTitle.Appearance.Options.UseFont = true;
			this.lblTitle.Location = new System.Drawing.Point(22, 22);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(220, 21);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "DATABASE CONFIGURATION";
			// 
			// cboDatabaseType
			// 
			this.cboDatabaseType.Location = new System.Drawing.Point(132, 105);
			this.cboDatabaseType.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cboDatabaseType.Name = "cboDatabaseType";
			this.cboDatabaseType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboDatabaseType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 21, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 21, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.cboDatabaseType.Properties.DisplayMember = "Name";
			this.cboDatabaseType.Properties.NullText = "";
			this.cboDatabaseType.Properties.PopupSizeable = false;
			this.cboDatabaseType.Properties.ValueMember = "Value";
			this.cboDatabaseType.Size = new System.Drawing.Size(244, 22);
			this.cboDatabaseType.TabIndex = 0;
			// 
			// infoPanel
			// 
			this.infoPanel.Controls.Add(this.labelControl4);
			this.infoPanel.Controls.Add(this.labelControl2);
			this.infoPanel.Controls.Add(this.lblLogConfiguration);
			this.infoPanel.Controls.Add(this.cboLevelFile);
			this.infoPanel.Controls.Add(this.cboLevelNHibernate);
			this.infoPanel.Location = new System.Drawing.Point(12, 12);
			this.infoPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.infoPanel.Name = "infoPanel";
			this.infoPanel.Size = new System.Drawing.Size(695, 294);
			this.infoPanel.TabIndex = 5;
			this.infoPanel.Visible = false;
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(22, 134);
			this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(55, 16);
			this.labelControl4.TabIndex = 2;
			this.labelControl4.Text = "Hibernate";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(22, 90);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(62, 16);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Application";
			// 
			// lblLogConfiguration
			// 
			this.lblLogConfiguration.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F);
			this.lblLogConfiguration.Appearance.Options.UseFont = true;
			this.lblLogConfiguration.Location = new System.Drawing.Point(25, 28);
			this.lblLogConfiguration.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.lblLogConfiguration.Name = "lblLogConfiguration";
			this.lblLogConfiguration.Size = new System.Drawing.Size(167, 21);
			this.lblLogConfiguration.TabIndex = 0;
			this.lblLogConfiguration.Text = "LOG CONFIGURATION";
			// 
			// cboLevelFile
			// 
			this.cboLevelFile.Location = new System.Drawing.Point(112, 86);
			this.cboLevelFile.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cboLevelFile.Name = "cboLevelFile";
			this.cboLevelFile.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboLevelFile.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 21, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 21, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.cboLevelFile.Properties.DisplayMember = "Name";
			this.cboLevelFile.Properties.NullText = "";
			this.cboLevelFile.Properties.PopupSizeable = false;
			this.cboLevelFile.Properties.ValueMember = "Name";
			this.cboLevelFile.Size = new System.Drawing.Size(195, 22);
			this.cboLevelFile.TabIndex = 3;
			// 
			// cboLevelNHibernate
			// 
			this.cboLevelNHibernate.Location = new System.Drawing.Point(112, 134);
			this.cboLevelNHibernate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cboLevelNHibernate.Name = "cboLevelNHibernate";
			this.cboLevelNHibernate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboLevelNHibernate.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 21, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 21, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.cboLevelNHibernate.Properties.DisplayMember = "Name";
			this.cboLevelNHibernate.Properties.NullText = "";
			this.cboLevelNHibernate.Properties.PopupSizeable = false;
			this.cboLevelNHibernate.Properties.ValueMember = "Value";
			this.cboLevelNHibernate.Size = new System.Drawing.Size(195, 22);
			this.cboLevelNHibernate.TabIndex = 3;
			// 
			// ServerConfigurationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(728, 370);
			this.Controls.Add(this.mainPanel);
			this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ServerConfigurationForm.IconOptions.SvgImage")));
			this.MaximizeBox = false;
			this.Name = "ServerConfigurationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Database Configuration";
			((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.databasePanel)).EndInit();
			this.databasePanel.ResumeLayout(false);
			this.databasePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDatabaseName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatabasePort.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatabaseHost.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboDatabaseType.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.infoPanel)).EndInit();
			this.infoPanel.ResumeLayout(false);
			this.infoPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboLevelFile.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboLevelNHibernate.Properties)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl mainPanel;
        private DevExpress.XtraEditors.SimpleButton btnLogConfiguration;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl databasePanel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblDatabasePort;
        private DevExpress.XtraEditors.LabelControl lblDatabasePassword;
        private DevExpress.XtraEditors.LabelControl lblDatabaseUserName;
        private DevExpress.XtraEditors.LabelControl lblDatabaseHost;
        private DevExpress.XtraEditors.LabelControl lblDatabaseType;
        private DevExpress.XtraEditors.TextEdit txtDatabaseName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtDatabasePort;
        private DevExpress.XtraEditors.TextEdit txtDatabaseHost;
        private DevExpress.XtraEditors.LabelControl lblInfo;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.LookUpEdit cboDatabaseType;
        private DevExpress.XtraEditors.PanelControl infoPanel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblLogConfiguration;
        private DevExpress.XtraEditors.LookUpEdit cboLevelFile;
        private DevExpress.XtraEditors.LookUpEdit cboLevelNHibernate;
	}
}