namespace MISLiveMed.UI.Main.Administration.Configuration
{
	partial class SuperAdminConnectionForm
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
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.txtFirebaseConnectionString = new DevExpress.XtraEditors.MemoEdit();
			this.txtProjectId = new DevExpress.XtraEditors.TextEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblProjectId = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblFirebaseConnectionString = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtFirebaseConnectionString.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProjectId.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProjectId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblFirebaseConnectionString)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
			this.SuspendLayout();
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.btnSave);
			this.mainLayout.Controls.Add(this.btnCancel);
			this.mainLayout.Controls.Add(this.txtFirebaseConnectionString);
			this.mainLayout.Controls.Add(this.txtProjectId);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 0);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(732, 463);
			this.mainLayout.TabIndex = 1;
			this.mainLayout.Text = "layoutControl1";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(432, 424);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(130, 27);
			this.btnSave.StyleController = this.mainLayout;
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "&Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(566, 424);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(154, 27);
			this.btnCancel.StyleController = this.mainLayout;
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtFirebaseConnectionString
			// 
			this.txtFirebaseConnectionString.Location = new System.Drawing.Point(12, 77);
			this.txtFirebaseConnectionString.Name = "txtFirebaseConnectionString";
			this.txtFirebaseConnectionString.Size = new System.Drawing.Size(708, 320);
			this.txtFirebaseConnectionString.StyleController = this.mainLayout;
			this.txtFirebaseConnectionString.TabIndex = 5;
			// 
			// txtProjectId
			// 
			this.txtProjectId.Location = new System.Drawing.Point(178, 12);
			this.txtProjectId.Name = "txtProjectId";
			this.txtProjectId.Size = new System.Drawing.Size(384, 22);
			this.txtProjectId.StyleController = this.mainLayout;
			this.txtProjectId.TabIndex = 4;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblProjectId,
            this.lblFirebaseConnectionString,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.emptySpaceItem4});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(732, 463);
			this.Root.TextVisible = false;
			// 
			// lblProjectId
			// 
			this.lblProjectId.Control = this.txtProjectId;
			this.lblProjectId.Location = new System.Drawing.Point(0, 0);
			this.lblProjectId.Name = "lblProjectId";
			this.lblProjectId.Size = new System.Drawing.Size(554, 26);
			this.lblProjectId.Text = "Project Id";
			// 
			// lblFirebaseConnectionString
			// 
			this.lblFirebaseConnectionString.Control = this.txtFirebaseConnectionString;
			this.lblFirebaseConnectionString.Location = new System.Drawing.Point(0, 46);
			this.lblFirebaseConnectionString.Name = "lblFirebaseConnectionString";
			this.lblFirebaseConnectionString.Size = new System.Drawing.Size(712, 343);
			this.lblFirebaseConnectionString.Text = "Firebase Connection String";
			this.lblFirebaseConnectionString.TextLocation = DevExpress.Utils.Locations.Top;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.btnCancel;
			this.layoutControlItem1.Location = new System.Drawing.Point(554, 412);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(158, 31);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.btnSave;
			this.layoutControlItem2.Location = new System.Drawing.Point(420, 412);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(134, 31);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 412);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(420, 31);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 26);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(712, 20);
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.Location = new System.Drawing.Point(0, 389);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(712, 23);
			// 
			// emptySpaceItem4
			// 
			this.emptySpaceItem4.Location = new System.Drawing.Point(554, 0);
			this.emptySpaceItem4.Name = "emptySpaceItem4";
			this.emptySpaceItem4.Size = new System.Drawing.Size(158, 26);
			// 
			// SuperAdminConnectionForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(732, 463);
			this.Controls.Add(this.mainLayout);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SuperAdminConnectionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Firebase Configuration";
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtFirebaseConnectionString.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProjectId.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProjectId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblFirebaseConnectionString)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl mainLayout;
		private DevExpress.XtraEditors.SimpleButton btnSave;
		private DevExpress.XtraEditors.SimpleButton btnCancel;
		private DevExpress.XtraEditors.MemoEdit txtFirebaseConnectionString;
		private DevExpress.XtraEditors.TextEdit txtProjectId;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem lblProjectId;
		private DevExpress.XtraLayout.LayoutControlItem lblFirebaseConnectionString;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
	}
}