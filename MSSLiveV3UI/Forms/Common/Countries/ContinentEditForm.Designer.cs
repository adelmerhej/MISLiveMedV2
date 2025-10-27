using MISLiveMed.Models.Models.Common.Countries;

namespace MISLiveMed.UI.Forms.Common.Countries
{
    partial class ContinentEditForm
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
			this.bsContinent = new System.Windows.Forms.BindingSource(this.components);
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
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsContinent)).BeginInit();
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
			this.mainLayout.Size = new System.Drawing.Size(550, 337);
			this.mainLayout.TabIndex = 8;
			this.mainLayout.Text = "layoutControl1";
			// 
			// chkActive
			// 
			this.chkActive.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsContinent, "Active", true));
			this.chkActive.Enabled = false;
			this.chkActive.Location = new System.Drawing.Point(406, 50);
			this.chkActive.Name = "chkActive";
			this.chkActive.Properties.Caption = "Active";
			this.chkActive.Size = new System.Drawing.Size(120, 24);
			this.chkActive.StyleController = this.mainLayout;
			this.chkActive.TabIndex = 3;
			// 
			// bsContinent
			// 
			this.bsContinent.DataSource = typeof(ContinentModel);
			// 
			// txtNotes
			// 
			this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsContinent, "Notes", true));
			this.txtNotes.Location = new System.Drawing.Point(24, 154);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Properties.ReadOnly = true;
			this.txtNotes.Size = new System.Drawing.Size(502, 107);
			this.txtNotes.StyleController = this.mainLayout;
			this.txtNotes.TabIndex = 2;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(427, 298);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(111, 27);
			this.btnCancel.StyleController = this.mainLayout;
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(325, 298);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(98, 27);
			this.btnSave.StyleController = this.mainLayout;
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtId
			// 
			this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsContinent, "Id", true));
			this.txtId.Location = new System.Drawing.Point(69, 50);
			this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtId.Name = "txtId";
			this.txtId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtId.Properties.MaxLength = 3;
			this.txtId.Properties.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(209, 22);
			this.txtId.StyleController = this.mainLayout;
			this.txtId.TabIndex = 0;
			this.txtId.TabStop = false;
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsContinent, "Name", true));
			this.txtName.Location = new System.Drawing.Point(69, 78);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtName.Name = "txtName";
			this.txtName.Properties.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(457, 22);
			this.txtName.StyleController = this.mainLayout;
			this.txtName.TabIndex = 1;
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
			this.layoutControlGroup1.Size = new System.Drawing.Size(550, 337);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 265);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(530, 21);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 286);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(313, 31);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.btnSave;
			this.layoutControlItem4.Location = new System.Drawing.Point(313, 286);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(102, 31);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.btnCancel;
			this.layoutControlItem5.Location = new System.Drawing.Point(415, 286);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(115, 31);
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
            this.layoutControlItem1});
			this.grpInfo.Location = new System.Drawing.Point(0, 0);
			this.grpInfo.Name = "grpInfo";
			this.grpInfo.Size = new System.Drawing.Size(530, 104);
			this.grpInfo.Text = "Continent Info";
			// 
			// lblMainRegionId
			// 
			this.lblMainRegionId.Control = this.txtId;
			this.lblMainRegionId.Location = new System.Drawing.Point(0, 0);
			this.lblMainRegionId.Name = "lblMainRegionId";
			this.lblMainRegionId.Size = new System.Drawing.Size(258, 28);
			this.lblMainRegionId.Text = "Id";
			// 
			// lblName
			// 
			this.lblName.Control = this.txtName;
			this.lblName.Location = new System.Drawing.Point(0, 28);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(506, 26);
			this.lblName.Text = "Name";
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.Location = new System.Drawing.Point(258, 0);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(124, 28);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.chkActive;
			this.layoutControlItem1.Location = new System.Drawing.Point(382, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(124, 28);
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
			this.layoutControlGroup4.Size = new System.Drawing.Size(530, 161);
			this.layoutControlGroup4.Text = "Notes";
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.txtNotes;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(506, 111);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// ContinentEditForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(550, 337);
			this.Controls.Add(this.mainLayout);
			this.MaximizeBox = false;
			this.Name = "ContinentEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Continent";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContinentEditForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsContinent)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlGroup grpInfo;
        private DevExpress.XtraLayout.LayoutControlItem lblMainRegionId;
        private DevExpress.XtraLayout.LayoutControlItem lblName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource bsContinent;
    }
}