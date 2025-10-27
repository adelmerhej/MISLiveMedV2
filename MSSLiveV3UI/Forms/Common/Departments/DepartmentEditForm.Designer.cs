using MISLiveMed.Models.Models.Common.Departments;

namespace MISLiveMed.UI.Forms.Common.Departments
{
	partial class DepartmentEditForm
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
			this.bsDepartments = new System.Windows.Forms.BindingSource(this.components);
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.chkProtected = new DevExpress.XtraEditors.CheckEdit();
			this.chkInJobActive = new DevExpress.XtraEditors.CheckEdit();
			this.txtStartingNo = new DevExpress.XtraEditors.TextEdit();
			this.txtPrefix = new DevExpress.XtraEditors.TextEdit();
			this.txtCode = new DevExpress.XtraEditors.TextEdit();
			this.chkActive = new DevExpress.XtraEditors.CheckEdit();
			this.txtNotes = new DevExpress.XtraEditors.MemoEdit();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.txtId = new DevExpress.XtraEditors.TextEdit();
			this.txtName = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.grpInfo = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblMainRegionId = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblName = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblCode = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblPrefix = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblStartingNo = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.bsDepartments)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chkProtected.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkInJobActive.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtStartingNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPrefix.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMainRegionId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPrefix)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblStartingNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			this.SuspendLayout();
			// 
			// bsDepartments
			// 
			this.bsDepartments.DataSource = typeof(DepartmentModel);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.chkProtected);
			this.mainLayout.Controls.Add(this.chkInJobActive);
			this.mainLayout.Controls.Add(this.txtStartingNo);
			this.mainLayout.Controls.Add(this.txtPrefix);
			this.mainLayout.Controls.Add(this.txtCode);
			this.mainLayout.Controls.Add(this.chkActive);
			this.mainLayout.Controls.Add(this.txtNotes);
			this.mainLayout.Controls.Add(this.btnCancel);
			this.mainLayout.Controls.Add(this.btnSave);
			this.mainLayout.Controls.Add(this.txtId);
			this.mainLayout.Controls.Add(this.txtName);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 0);
			this.mainLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(738, 385, 450, 350);
			this.mainLayout.Root = this.layoutControlGroup1;
			this.mainLayout.Size = new System.Drawing.Size(693, 437);
			this.mainLayout.TabIndex = 15;
			this.mainLayout.Text = "layoutControl1";
			// 
			// chkProtected
			// 
			this.chkProtected.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDepartments, "IsProtected", true));
			this.chkProtected.Enabled = false;
			this.chkProtected.Location = new System.Drawing.Point(24, 202);
			this.chkProtected.Name = "chkProtected";
			this.chkProtected.Properties.Caption = "Protected";
			this.chkProtected.Size = new System.Drawing.Size(328, 24);
			this.chkProtected.StyleController = this.mainLayout;
			this.chkProtected.TabIndex = 24;
			this.chkProtected.Visible = false;
			// 
			// chkInJobActive
			// 
			this.chkInJobActive.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDepartments, "JobActive", true));
			this.chkInJobActive.Enabled = false;
			this.chkInJobActive.Location = new System.Drawing.Point(356, 202);
			this.chkInJobActive.Name = "chkInJobActive";
			this.chkInJobActive.Properties.Caption = "In Job Active";
			this.chkInJobActive.Size = new System.Drawing.Size(181, 24);
			this.chkInJobActive.StyleController = this.mainLayout;
			this.chkInJobActive.TabIndex = 23;
			// 
			// txtStartingNo
			// 
			this.txtStartingNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDepartments, "StartingNo", true));
			this.txtStartingNo.Location = new System.Drawing.Point(100, 164);
			this.txtStartingNo.Name = "txtStartingNo";
			this.txtStartingNo.Properties.ReadOnly = true;
			this.txtStartingNo.Size = new System.Drawing.Size(244, 22);
			this.txtStartingNo.StyleController = this.mainLayout;
			this.txtStartingNo.TabIndex = 22;
			// 
			// txtPrefix
			// 
			this.txtPrefix.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDepartments, "Prefix", true));
			this.txtPrefix.Location = new System.Drawing.Point(100, 138);
			this.txtPrefix.Name = "txtPrefix";
			this.txtPrefix.Properties.ReadOnly = true;
			this.txtPrefix.Size = new System.Drawing.Size(244, 22);
			this.txtPrefix.StyleController = this.mainLayout;
			this.txtPrefix.TabIndex = 21;
			// 
			// txtCode
			// 
			this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDepartments, "ShortCode", true));
			this.txtCode.Location = new System.Drawing.Point(100, 76);
			this.txtCode.Name = "txtCode";
			this.txtCode.Properties.MaxLength = 3;
			this.txtCode.Properties.ReadOnly = true;
			this.txtCode.Size = new System.Drawing.Size(244, 22);
			this.txtCode.StyleController = this.mainLayout;
			this.txtCode.TabIndex = 17;
			// 
			// chkActive
			// 
			this.chkActive.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDepartments, "Active", true));
			this.chkActive.Enabled = false;
			this.chkActive.Location = new System.Drawing.Point(541, 202);
			this.chkActive.Name = "chkActive";
			this.chkActive.Properties.Caption = "Active";
			this.chkActive.Size = new System.Drawing.Size(128, 24);
			this.chkActive.StyleController = this.mainLayout;
			this.chkActive.TabIndex = 13;
			// 
			// txtNotes
			// 
			this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDepartments, "Notes", true));
			this.txtNotes.Location = new System.Drawing.Point(24, 280);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Properties.ReadOnly = true;
			this.txtNotes.Size = new System.Drawing.Size(645, 92);
			this.txtNotes.StyleController = this.mainLayout;
			this.txtNotes.TabIndex = 11;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(539, 398);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(142, 27);
			this.btnCancel.StyleController = this.mainLayout;
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(409, 398);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(126, 27);
			this.btnSave.StyleController = this.mainLayout;
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtId
			// 
			this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDepartments, "Id", true));
			this.txtId.Location = new System.Drawing.Point(100, 50);
			this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtId.Name = "txtId";
			this.txtId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtId.Properties.MaxLength = 3;
			this.txtId.Properties.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(244, 22);
			this.txtId.StyleController = this.mainLayout;
			this.txtId.TabIndex = 4;
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDepartments, "DepartmentName", true));
			this.txtName.Location = new System.Drawing.Point(100, 102);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtName.Name = "txtName";
			this.txtName.Properties.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(569, 22);
			this.txtName.StyleController = this.mainLayout;
			this.txtName.TabIndex = 5;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "Root";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.grpInfo,
            this.layoutControlGroup4});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(693, 437);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 376);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(673, 10);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 386);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(397, 31);
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.btnSave;
			this.layoutControlItem4.Location = new System.Drawing.Point(397, 386);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(130, 31);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.btnCancel;
			this.layoutControlItem5.Location = new System.Drawing.Point(527, 386);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(146, 31);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// grpInfo
			// 
			this.grpInfo.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblMainRegionId,
            this.lblName,
            this.emptySpaceItem3,
            this.emptySpaceItem6,
            this.lblCode,
            this.emptySpaceItem7,
            this.emptySpaceItem8,
            this.lblPrefix,
            this.lblStartingNo,
            this.layoutControlItem2,
            this.emptySpaceItem5,
            this.layoutControlItem1,
            this.layoutControlItem3});
			this.grpInfo.Location = new System.Drawing.Point(0, 0);
			this.grpInfo.Name = "grpInfo";
			this.grpInfo.Size = new System.Drawing.Size(673, 230);
			this.grpInfo.Text = "Department Info";
			// 
			// lblMainRegionId
			// 
			this.lblMainRegionId.Control = this.txtId;
			this.lblMainRegionId.Location = new System.Drawing.Point(0, 0);
			this.lblMainRegionId.Name = "lblMainRegionId";
			this.lblMainRegionId.Size = new System.Drawing.Size(324, 26);
			this.lblMainRegionId.Text = "Id";
			this.lblMainRegionId.TextSize = new System.Drawing.Size(64, 16);
			// 
			// lblName
			// 
			this.lblName.Control = this.txtName;
			this.lblName.Location = new System.Drawing.Point(0, 52);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(649, 26);
			this.lblName.Text = "Name";
			this.lblName.TextSize = new System.Drawing.Size(64, 16);
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.AllowHotTrack = false;
			this.emptySpaceItem3.Location = new System.Drawing.Point(324, 0);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(325, 26);
			this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem6
			// 
			this.emptySpaceItem6.AllowHotTrack = false;
			this.emptySpaceItem6.Location = new System.Drawing.Point(324, 88);
			this.emptySpaceItem6.Name = "emptySpaceItem6";
			this.emptySpaceItem6.Size = new System.Drawing.Size(325, 52);
			this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
			// 
			// lblCode
			// 
			this.lblCode.Control = this.txtCode;
			this.lblCode.Location = new System.Drawing.Point(0, 26);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(324, 26);
			this.lblCode.Text = "Short Code";
			this.lblCode.TextSize = new System.Drawing.Size(64, 16);
			// 
			// emptySpaceItem7
			// 
			this.emptySpaceItem7.AllowHotTrack = false;
			this.emptySpaceItem7.Location = new System.Drawing.Point(324, 26);
			this.emptySpaceItem7.Name = "emptySpaceItem7";
			this.emptySpaceItem7.Size = new System.Drawing.Size(325, 26);
			this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem8
			// 
			this.emptySpaceItem8.AllowHotTrack = false;
			this.emptySpaceItem8.Location = new System.Drawing.Point(0, 78);
			this.emptySpaceItem8.Name = "emptySpaceItem8";
			this.emptySpaceItem8.Size = new System.Drawing.Size(649, 10);
			this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
			// 
			// lblPrefix
			// 
			this.lblPrefix.Control = this.txtPrefix;
			this.lblPrefix.Location = new System.Drawing.Point(0, 88);
			this.lblPrefix.Name = "lblPrefix";
			this.lblPrefix.Size = new System.Drawing.Size(324, 26);
			this.lblPrefix.Text = "Prefix";
			this.lblPrefix.TextSize = new System.Drawing.Size(64, 16);
			// 
			// lblStartingNo
			// 
			this.lblStartingNo.Control = this.txtStartingNo;
			this.lblStartingNo.Location = new System.Drawing.Point(0, 114);
			this.lblStartingNo.Name = "lblStartingNo";
			this.lblStartingNo.Size = new System.Drawing.Size(324, 26);
			this.lblStartingNo.Text = "Starting No";
			this.lblStartingNo.TextSize = new System.Drawing.Size(64, 16);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.chkInJobActive;
			this.layoutControlItem2.Location = new System.Drawing.Point(332, 152);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(185, 28);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// emptySpaceItem5
			// 
			this.emptySpaceItem5.AllowHotTrack = false;
			this.emptySpaceItem5.Location = new System.Drawing.Point(0, 140);
			this.emptySpaceItem5.Name = "emptySpaceItem5";
			this.emptySpaceItem5.Size = new System.Drawing.Size(649, 12);
			this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.chkActive;
			this.layoutControlItem1.Enabled = false;
			this.layoutControlItem1.Location = new System.Drawing.Point(517, 152);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(132, 28);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.chkProtected;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 152);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(332, 28);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// layoutControlGroup4
			// 
			this.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
			this.layoutControlGroup4.Location = new System.Drawing.Point(0, 230);
			this.layoutControlGroup4.Name = "layoutControlGroup4";
			this.layoutControlGroup4.Size = new System.Drawing.Size(673, 146);
			this.layoutControlGroup4.Text = "Notes";
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.txtNotes;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(649, 96);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// DepartmentEditForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(693, 437);
			this.Controls.Add(this.mainLayout);
			this.MaximizeBox = false;
			this.Name = "DepartmentEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Department";
			((System.ComponentModel.ISupportInitialize)(this.bsDepartments)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chkProtected.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkInJobActive.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtStartingNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPrefix.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMainRegionId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPrefix)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblStartingNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource bsDepartments;
		private DevExpress.XtraLayout.LayoutControl mainLayout;
		private DevExpress.XtraEditors.CheckEdit chkProtected;
		private DevExpress.XtraEditors.CheckEdit chkInJobActive;
		private DevExpress.XtraEditors.TextEdit txtStartingNo;
		private DevExpress.XtraEditors.TextEdit txtPrefix;
		private DevExpress.XtraEditors.TextEdit txtCode;
		private DevExpress.XtraEditors.CheckEdit chkActive;
		private DevExpress.XtraEditors.MemoEdit txtNotes;
		private DevExpress.XtraEditors.SimpleButton btnCancel;
		private DevExpress.XtraEditors.SimpleButton btnSave;
		private DevExpress.XtraEditors.TextEdit txtId;
		private DevExpress.XtraEditors.TextEdit txtName;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlGroup grpInfo;
		private DevExpress.XtraLayout.LayoutControlItem lblMainRegionId;
		private DevExpress.XtraLayout.LayoutControlItem lblName;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
		private DevExpress.XtraLayout.LayoutControlItem lblCode;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
		private DevExpress.XtraLayout.LayoutControlItem lblPrefix;
		private DevExpress.XtraLayout.LayoutControlItem lblStartingNo;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
	}
}