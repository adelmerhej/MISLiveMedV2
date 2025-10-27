using MISLiveMed.Models.Models.Common.Containers;

namespace MISLiveMed.UI.Forms.Common.Containers
{
	partial class MainContainerTypeForm
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
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.chkActive = new DevExpress.XtraEditors.CheckEdit();
			this.bsMainContainerType = new System.Windows.Forms.BindingSource(this.components);
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
			this.grpContainerTypeInfo = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblId = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblContainerTypeDescription = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsMainContainerType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpContainerTypeInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblContainerTypeDescription)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			this.SuspendLayout();
			// 
			// mainLayout
			// 
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
			this.mainLayout.Size = new System.Drawing.Size(564, 342);
			this.mainLayout.TabIndex = 6;
			this.mainLayout.Text = "layoutControl1";
			// 
			// chkActive
			// 
			this.chkActive.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMainContainerType, "Active", true));
			this.chkActive.Enabled = false;
			this.chkActive.Location = new System.Drawing.Point(373, 50);
			this.chkActive.Name = "chkActive";
			this.chkActive.Properties.Caption = "Active";
			this.chkActive.Size = new System.Drawing.Size(167, 24);
			this.chkActive.StyleController = this.mainLayout;
			this.chkActive.TabIndex = 13;
			// 
			// bsMainContainerType
			// 
			this.bsMainContainerType.DataSource = typeof(MainContainerTypeModel);
			// 
			// txtNotes
			// 
			this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMainContainerType, "Notes", true));
			this.txtNotes.Location = new System.Drawing.Point(24, 154);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Properties.ReadOnly = true;
			this.txtNotes.Size = new System.Drawing.Size(516, 118);
			this.txtNotes.StyleController = this.mainLayout;
			this.txtNotes.TabIndex = 11;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(437, 303);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(115, 27);
			this.btnCancel.StyleController = this.mainLayout;
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(332, 303);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(101, 27);
			this.btnSave.StyleController = this.mainLayout;
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save";
			// 
			// txtId
			// 
			this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMainContainerType, "Id", true));
			this.txtId.Location = new System.Drawing.Point(99, 50);
			this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtId.Name = "txtId";
			this.txtId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtId.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
			this.txtId.Properties.MaskSettings.Set("mask", "\\p{Lu}+");
			this.txtId.Properties.MaxLength = 3;
			this.txtId.Properties.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(100, 22);
			this.txtId.StyleController = this.mainLayout;
			this.txtId.TabIndex = 4;
			this.txtId.TabStop = false;
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMainContainerType, "Description", true));
			this.txtName.Location = new System.Drawing.Point(99, 78);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtName.Name = "txtName";
			this.txtName.Properties.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(441, 22);
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
            this.grpContainerTypeInfo,
            this.layoutControlGroup4});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(564, 342);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 276);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(544, 15);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 291);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(320, 31);
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.btnSave;
			this.layoutControlItem4.Location = new System.Drawing.Point(320, 291);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(105, 31);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			this.layoutControlItem4.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.btnCancel;
			this.layoutControlItem5.Location = new System.Drawing.Point(425, 291);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(119, 31);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// grpContainerTypeInfo
			// 
			this.grpContainerTypeInfo.CustomizationFormText = "Country Info";
			this.grpContainerTypeInfo.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpContainerTypeInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblId,
            this.lblContainerTypeDescription,
            this.emptySpaceItem3,
            this.layoutControlItem1});
			this.grpContainerTypeInfo.Location = new System.Drawing.Point(0, 0);
			this.grpContainerTypeInfo.Name = "grpContainerTypeInfo";
			this.grpContainerTypeInfo.Size = new System.Drawing.Size(544, 104);
			this.grpContainerTypeInfo.Text = "Main Container Type Info";
			// 
			// lblId
			// 
			this.lblId.Control = this.txtId;
			this.lblId.CustomizationFormText = "Caption:";
			this.lblId.Location = new System.Drawing.Point(0, 0);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(179, 28);
			this.lblId.Text = "Id";
			this.lblId.TextSize = new System.Drawing.Size(63, 16);
			// 
			// lblContainerTypeDescription
			// 
			this.lblContainerTypeDescription.Control = this.txtName;
			this.lblContainerTypeDescription.CustomizationFormText = "Group Name:";
			this.lblContainerTypeDescription.Location = new System.Drawing.Point(0, 28);
			this.lblContainerTypeDescription.Name = "lblContainerTypeDescription";
			this.lblContainerTypeDescription.Size = new System.Drawing.Size(520, 26);
			this.lblContainerTypeDescription.Text = "Description";
			this.lblContainerTypeDescription.TextSize = new System.Drawing.Size(63, 16);
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.AllowHotTrack = false;
			this.emptySpaceItem3.Location = new System.Drawing.Point(179, 0);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(170, 28);
			this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.chkActive;
			this.layoutControlItem1.Location = new System.Drawing.Point(349, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(171, 28);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlGroup4
			// 
			this.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
			this.layoutControlGroup4.Location = new System.Drawing.Point(0, 104);
			this.layoutControlGroup4.Name = "layoutControlGroup4";
			this.layoutControlGroup4.Size = new System.Drawing.Size(544, 172);
			this.layoutControlGroup4.Text = "Notes";
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.txtNotes;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(520, 122);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// MainContainerTypeForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(564, 342);
			this.Controls.Add(this.mainLayout);
			this.MaximizeBox = false;
			this.Name = "MainContainerTypeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Container Type";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainContainerTypeForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsMainContainerType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpContainerTypeInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblContainerTypeDescription)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl mainLayout;
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
		private DevExpress.XtraLayout.LayoutControlGroup grpContainerTypeInfo;
		private DevExpress.XtraLayout.LayoutControlItem lblId;
		private DevExpress.XtraLayout.LayoutControlItem lblContainerTypeDescription;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private System.Windows.Forms.BindingSource bsMainContainerType;
	}
}