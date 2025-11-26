namespace MISLiveMed.UI.Main.Administration.Settings
{
	partial class GeneralSettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralSettingsForm));
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.GeneralSettingsTabs = new DevExpress.XtraTab.XtraTabControl();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.tabAppSettings = new DevExpress.XtraTab.XtraTabPage();
			this.tabLiveUpdateSettings = new DevExpress.XtraTab.XtraTabPage();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GeneralSettingsTabs)).BeginInit();
			this.GeneralSettingsTabs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.btnSave);
			this.mainLayout.Controls.Add(this.btnCancel);
			this.mainLayout.Controls.Add(this.GeneralSettingsTabs);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 0);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(906, 561);
			this.mainLayout.TabIndex = 0;
			this.mainLayout.Text = "layoutControl1";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(906, 561);
			this.Root.TextVisible = false;
			// 
			// GeneralSettingsTabs
			// 
			this.GeneralSettingsTabs.Location = new System.Drawing.Point(14, 14);
			this.GeneralSettingsTabs.Name = "GeneralSettingsTabs";
			this.GeneralSettingsTabs.SelectedTabPage = this.tabAppSettings;
			this.GeneralSettingsTabs.Size = new System.Drawing.Size(878, 492);
			this.GeneralSettingsTabs.TabIndex = 4;
			this.GeneralSettingsTabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabAppSettings,
            this.tabLiveUpdateSettings});
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.GeneralSettingsTabs;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(882, 496);
			this.layoutControlItem1.Text = "General Settings";
			this.layoutControlItem1.TextVisible = false;
			// 
			// tabAppSettings
			// 
			this.tabAppSettings.Name = "tabAppSettings";
			this.tabAppSettings.Size = new System.Drawing.Size(876, 462);
			this.tabAppSettings.Text = "Application Settings";
			// 
			// tabLiveUpdateSettings
			// 
			this.tabLiveUpdateSettings.Name = "tabLiveUpdateSettings";
			this.tabLiveUpdateSettings.Size = new System.Drawing.Size(876, 498);
			this.tabLiveUpdateSettings.Text = "Live Update Settings";
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 506);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(552, 31);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(727, 520);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(165, 27);
			this.btnCancel.StyleController = this.mainLayout;
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.btnCancel;
			this.layoutControlItem2.Location = new System.Drawing.Point(713, 506);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(169, 31);
			this.layoutControlItem2.TextVisible = false;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(566, 520);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(157, 27);
			this.btnSave.StyleController = this.mainLayout;
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "&Save";
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.btnSave;
			this.layoutControlItem3.Location = new System.Drawing.Point(552, 506);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(161, 31);
			this.layoutControlItem3.TextVisible = false;
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 496);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(882, 10);
			// 
			// GeneralSettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(906, 561);
			this.Controls.Add(this.mainLayout);
			this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GeneralSettingsForm.IconOptions.SvgImage")));
			this.MaximizeBox = false;
			this.Name = "GeneralSettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "General Settings";
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GeneralSettingsTabs)).EndInit();
			this.GeneralSettingsTabs.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl mainLayout;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraTab.XtraTabControl GeneralSettingsTabs;
		private DevExpress.XtraTab.XtraTabPage tabAppSettings;
		private DevExpress.XtraTab.XtraTabPage tabLiveUpdateSettings;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraEditors.SimpleButton btnSave;
		private DevExpress.XtraEditors.SimpleButton btnCancel;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
	}
}