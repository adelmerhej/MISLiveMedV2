using MISLiveMed.Models.Models.Common.Currencies;

namespace MISLiveMed.UI.Accounting.Currencies
{
    partial class CurrencyEditForm
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
			this.bsCurrency = new System.Windows.Forms.BindingSource(this.components);
			this.MainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.chkDivideByRateForeign = new DevExpress.XtraEditors.CheckEdit();
			this.chkDivByRateLocal = new DevExpress.XtraEditors.CheckEdit();
			this.txtCurrencySymbol = new DevExpress.XtraEditors.TextEdit();
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
			this.lblCurrencyName = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblCurrencyCode = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblCurrencySymbol = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MainLayout)).BeginInit();
			this.MainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chkDivideByRateForeign.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkDivByRateLocal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCurrencySymbol.Properties)).BeginInit();
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
			((System.ComponentModel.ISupportInitialize)(this.lblCurrencyName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCurrencyCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCurrencySymbol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			this.SuspendLayout();
			// 
			// bsCurrency
			// 
			this.bsCurrency.DataSource = typeof(CurrencyModel);
			// 
			// MainLayout
			// 
			this.MainLayout.Controls.Add(this.chkDivideByRateForeign);
			this.MainLayout.Controls.Add(this.chkDivByRateLocal);
			this.MainLayout.Controls.Add(this.txtCurrencySymbol);
			this.MainLayout.Controls.Add(this.txtCode);
			this.MainLayout.Controls.Add(this.chkActive);
			this.MainLayout.Controls.Add(this.txtNotes);
			this.MainLayout.Controls.Add(this.btnCancel);
			this.MainLayout.Controls.Add(this.btnSave);
			this.MainLayout.Controls.Add(this.txtId);
			this.MainLayout.Controls.Add(this.txtName);
			this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainLayout.Location = new System.Drawing.Point(0, 0);
			this.MainLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MainLayout.Name = "MainLayout";
			this.MainLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(738, 385, 450, 350);
			this.MainLayout.Root = this.layoutControlGroup1;
			this.MainLayout.Size = new System.Drawing.Size(693, 399);
			this.MainLayout.TabIndex = 7;
			this.MainLayout.Text = "layoutControl1";
			// 
			// chkDivideByRateForeign
			// 
			this.chkDivideByRateForeign.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCurrency, "DivideByForeignRate", true));
			this.chkDivideByRateForeign.Enabled = false;
			this.chkDivideByRateForeign.Location = new System.Drawing.Point(463, 130);
			this.chkDivideByRateForeign.Name = "chkDivideByRateForeign";
			this.chkDivideByRateForeign.Properties.Caption = "Divided By Foreign Rate";
			this.chkDivideByRateForeign.Size = new System.Drawing.Size(206, 24);
			this.chkDivideByRateForeign.StyleController = this.MainLayout;
			this.chkDivideByRateForeign.TabIndex = 7;
			// 
			// chkDivByRateLocal
			// 
			this.chkDivByRateLocal.Enabled = false;
			this.chkDivByRateLocal.Location = new System.Drawing.Point(132, 130);
			this.chkDivByRateLocal.Name = "chkDivByRateLocal";
			this.chkDivByRateLocal.Properties.Caption = "Divided By Local Rate";
			this.chkDivByRateLocal.Size = new System.Drawing.Size(181, 24);
			this.chkDivByRateLocal.StyleController = this.MainLayout;
			this.chkDivByRateLocal.TabIndex = 6;
			// 
			// txtCurrencySymbol
			// 
			this.txtCurrencySymbol.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCurrency, "CurrencySymbol", true));
			this.txtCurrencySymbol.Location = new System.Drawing.Point(457, 78);
			this.txtCurrencySymbol.Name = "txtCurrencySymbol";
			this.txtCurrencySymbol.Properties.ReadOnly = true;
			this.txtCurrencySymbol.Size = new System.Drawing.Size(212, 22);
			this.txtCurrencySymbol.StyleController = this.MainLayout;
			this.txtCurrencySymbol.TabIndex = 3;
			// 
			// txtCode
			// 
			this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCurrency, "CurrencyCode", true));
			this.txtCode.Location = new System.Drawing.Point(133, 78);
			this.txtCode.Name = "txtCode";
			this.txtCode.Properties.ReadOnly = true;
			this.txtCode.Size = new System.Drawing.Size(211, 22);
			this.txtCode.StyleController = this.MainLayout;
			this.txtCode.TabIndex = 2;
			// 
			// chkActive
			// 
			this.chkActive.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCurrency, "Active", true));
			this.chkActive.Enabled = false;
			this.chkActive.Location = new System.Drawing.Point(463, 50);
			this.chkActive.Name = "chkActive";
			this.chkActive.Properties.Caption = "Active";
			this.chkActive.Size = new System.Drawing.Size(206, 24);
			this.chkActive.StyleController = this.MainLayout;
			this.chkActive.TabIndex = 1;
			// 
			// txtNotes
			// 
			this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCurrency, "Notes", true));
			this.txtNotes.Location = new System.Drawing.Point(24, 208);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Properties.ReadOnly = true;
			this.txtNotes.Size = new System.Drawing.Size(645, 119);
			this.txtNotes.StyleController = this.MainLayout;
			this.txtNotes.TabIndex = 8;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(538, 360);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(143, 27);
			this.btnCancel.StyleController = this.MainLayout;
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(409, 360);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(125, 27);
			this.btnSave.StyleController = this.MainLayout;
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			// 
			// txtId
			// 
			this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCurrency, "Id", true));
			this.txtId.Location = new System.Drawing.Point(133, 50);
			this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtId.Name = "txtId";
			this.txtId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtId.Properties.MaxLength = 3;
			this.txtId.Properties.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(211, 22);
			this.txtId.StyleController = this.MainLayout;
			this.txtId.TabIndex = 0;
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCurrency, "CurrencyName", true));
			this.txtName.Location = new System.Drawing.Point(133, 104);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtName.Name = "txtName";
			this.txtName.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
			this.txtName.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
			this.txtName.Properties.MaskSettings.Set("mask", "\\p{Lu}\\p{Ll}*(\\s+\\p{Lu}\\p{Ll}*)*");
			this.txtName.Properties.MaskSettings.Set("showPlaceholders", false);
			this.txtName.Properties.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(536, 22);
			this.txtName.StyleController = this.MainLayout;
			this.txtName.TabIndex = 4;
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
			this.layoutControlGroup1.Size = new System.Drawing.Size(693, 399);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 331);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(673, 17);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 348);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(397, 31);
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.btnSave;
			this.layoutControlItem4.Location = new System.Drawing.Point(397, 348);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(129, 31);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.btnCancel;
			this.layoutControlItem5.Location = new System.Drawing.Point(526, 348);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(147, 31);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// grpInfo
			// 
			this.grpInfo.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblMainRegionId,
            this.lblCurrencyName,
            this.emptySpaceItem3,
            this.layoutControlItem1,
            this.lblCurrencyCode,
            this.lblCurrencySymbol,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5});
			this.grpInfo.Location = new System.Drawing.Point(0, 0);
			this.grpInfo.Name = "grpInfo";
			this.grpInfo.Size = new System.Drawing.Size(673, 158);
			this.grpInfo.Text = "Currency Info";
			// 
			// lblMainRegionId
			// 
			this.lblMainRegionId.Control = this.txtId;
			this.lblMainRegionId.Location = new System.Drawing.Point(0, 0);
			this.lblMainRegionId.Name = "lblMainRegionId";
			this.lblMainRegionId.Size = new System.Drawing.Size(324, 28);
			this.lblMainRegionId.Text = "Id";
			this.lblMainRegionId.TextSize = new System.Drawing.Size(97, 16);
			// 
			// lblCurrencyName
			// 
			this.lblCurrencyName.Control = this.txtName;
			this.lblCurrencyName.Location = new System.Drawing.Point(0, 54);
			this.lblCurrencyName.Name = "lblCurrencyName";
			this.lblCurrencyName.Size = new System.Drawing.Size(649, 26);
			this.lblCurrencyName.Text = "Currency Name";
			this.lblCurrencyName.TextSize = new System.Drawing.Size(97, 16);
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.AllowHotTrack = false;
			this.emptySpaceItem3.Location = new System.Drawing.Point(324, 0);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(115, 28);
			this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.chkActive;
			this.layoutControlItem1.Location = new System.Drawing.Point(439, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(210, 28);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// lblCurrencyCode
			// 
			this.lblCurrencyCode.Control = this.txtCode;
			this.lblCurrencyCode.Location = new System.Drawing.Point(0, 28);
			this.lblCurrencyCode.Name = "lblCurrencyCode";
			this.lblCurrencyCode.Size = new System.Drawing.Size(324, 26);
			this.lblCurrencyCode.Text = "Currency Code";
			this.lblCurrencyCode.TextSize = new System.Drawing.Size(97, 16);
			// 
			// lblCurrencySymbol
			// 
			this.lblCurrencySymbol.Control = this.txtCurrencySymbol;
			this.lblCurrencySymbol.Location = new System.Drawing.Point(324, 28);
			this.lblCurrencySymbol.Name = "lblCurrencySymbol";
			this.lblCurrencySymbol.Size = new System.Drawing.Size(325, 26);
			this.lblCurrencySymbol.Text = "Currency Symbol";
			this.lblCurrencySymbol.TextSize = new System.Drawing.Size(97, 16);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.chkDivByRateLocal;
			this.layoutControlItem2.Location = new System.Drawing.Point(108, 80);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(185, 28);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.chkDivideByRateForeign;
			this.layoutControlItem3.Location = new System.Drawing.Point(439, 80);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(210, 28);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// emptySpaceItem4
			// 
			this.emptySpaceItem4.AllowHotTrack = false;
			this.emptySpaceItem4.Location = new System.Drawing.Point(0, 80);
			this.emptySpaceItem4.Name = "emptySpaceItem4";
			this.emptySpaceItem4.Size = new System.Drawing.Size(108, 28);
			this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem5
			// 
			this.emptySpaceItem5.AllowHotTrack = false;
			this.emptySpaceItem5.Location = new System.Drawing.Point(293, 80);
			this.emptySpaceItem5.Name = "emptySpaceItem5";
			this.emptySpaceItem5.Size = new System.Drawing.Size(146, 28);
			this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlGroup4
			// 
			this.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
			this.layoutControlGroup4.Location = new System.Drawing.Point(0, 158);
			this.layoutControlGroup4.Name = "layoutControlGroup4";
			this.layoutControlGroup4.Size = new System.Drawing.Size(673, 173);
			this.layoutControlGroup4.Text = "Notes";
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.txtNotes;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(649, 123);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// CurrencyEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 399);
			this.Controls.Add(this.MainLayout);
			this.MaximizeBox = false;
			this.Name = "CurrencyEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Currency";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CurrencyEditForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MainLayout)).EndInit();
			this.MainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chkDivideByRateForeign.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkDivByRateLocal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCurrencySymbol.Properties)).EndInit();
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
			((System.ComponentModel.ISupportInitialize)(this.lblCurrencyName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCurrencyCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCurrencySymbol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsCurrency;
		private DevExpress.XtraLayout.LayoutControl MainLayout;
		private DevExpress.XtraEditors.CheckEdit chkDivideByRateForeign;
		private DevExpress.XtraEditors.CheckEdit chkDivByRateLocal;
		private DevExpress.XtraEditors.TextEdit txtCurrencySymbol;
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
		private DevExpress.XtraLayout.LayoutControlItem lblCurrencyName;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem lblCurrencyCode;
		private DevExpress.XtraLayout.LayoutControlItem lblCurrencySymbol;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
	}
}