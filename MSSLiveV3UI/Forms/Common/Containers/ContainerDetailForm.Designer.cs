namespace MISLiveMed.UI.Forms.Common.Containers
{
    partial class ContainerDetailForm
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
			this.chkActive = new DevExpress.XtraEditors.CheckEdit();
			this.cboCntrTareList = new DevExpress.XtraEditors.LookUpEdit();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.txtSealNumber = new DevExpress.XtraEditors.TextEdit();
			this.txtCntrTareValue = new DevExpress.XtraEditors.TextEdit();
			this.cboCntrTypeList = new DevExpress.XtraEditors.LookUpEdit();
			this.cboCntrTeuList = new DevExpress.XtraEditors.LookUpEdit();
			this.txtCntrNumber = new DevExpress.XtraEditors.TextEdit();
			this.txtCntrPrefix = new DevExpress.XtraEditors.TextEdit();
			this.cboMasterContainer = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblMasterContainer = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItemPrefix = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItemNumber = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItemSeal = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItemSize = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItemContainerType = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItemContTare = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItemTare = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCntrTareList.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSealNumber.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCntrTareValue.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCntrTypeList.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCntrTeuList.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCntrNumber.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCntrPrefix.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboMasterContainer.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMasterContainer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPrefix)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItemContainerType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItemContTare)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTare)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.chkActive);
			this.mainLayout.Controls.Add(this.cboCntrTareList);
			this.mainLayout.Controls.Add(this.btnCancel);
			this.mainLayout.Controls.Add(this.btnSave);
			this.mainLayout.Controls.Add(this.txtSealNumber);
			this.mainLayout.Controls.Add(this.txtCntrTareValue);
			this.mainLayout.Controls.Add(this.cboCntrTypeList);
			this.mainLayout.Controls.Add(this.cboCntrTeuList);
			this.mainLayout.Controls.Add(this.txtCntrNumber);
			this.mainLayout.Controls.Add(this.txtCntrPrefix);
			this.mainLayout.Controls.Add(this.cboMasterContainer);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 0);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.layoutControlGroup1;
			this.mainLayout.Size = new System.Drawing.Size(621, 354);
			this.mainLayout.TabIndex = 2;
			this.mainLayout.Text = "layoutControl1";
			// 
			// chkActive
			// 
			this.chkActive.Enabled = false;
			this.chkActive.Location = new System.Drawing.Point(12, 242);
			this.chkActive.Name = "chkActive";
			this.chkActive.Properties.Caption = "Active";
			this.chkActive.Size = new System.Drawing.Size(597, 24);
			this.chkActive.StyleController = this.mainLayout;
			this.chkActive.TabIndex = 14;
			// 
			// cboCntrTareList
			// 
			this.cboCntrTareList.Location = new System.Drawing.Point(134, 204);
			this.cboCntrTareList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.cboCntrTareList.Name = "cboCntrTareList";
			this.cboCntrTareList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCntrTareList.Properties.NullText = "";
			this.cboCntrTareList.Properties.ReadOnly = true;
			this.cboCntrTareList.Size = new System.Drawing.Size(172, 22);
			this.cboCntrTareList.StyleController = this.mainLayout;
			this.cboCntrTareList.TabIndex = 12;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(454, 315);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(155, 27);
			this.btnCancel.StyleController = this.mainLayout;
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(305, 315);
			this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(145, 27);
			this.btnSave.StyleController = this.mainLayout;
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "Save";
			// 
			// txtSealNumber
			// 
			this.txtSealNumber.Location = new System.Drawing.Point(134, 102);
			this.txtSealNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtSealNumber.Name = "txtSealNumber";
			this.txtSealNumber.Properties.ReadOnly = true;
			this.txtSealNumber.Size = new System.Drawing.Size(463, 22);
			this.txtSealNumber.StyleController = this.mainLayout;
			this.txtSealNumber.TabIndex = 9;
			// 
			// txtCntrTareValue
			// 
			this.txtCntrTareValue.Location = new System.Drawing.Point(420, 204);
			this.txtCntrTareValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtCntrTareValue.Name = "txtCntrTareValue";
			this.txtCntrTareValue.Properties.ReadOnly = true;
			this.txtCntrTareValue.Size = new System.Drawing.Size(177, 22);
			this.txtCntrTareValue.StyleController = this.mainLayout;
			this.txtCntrTareValue.TabIndex = 8;
			// 
			// cboCntrTypeList
			// 
			this.cboCntrTypeList.Location = new System.Drawing.Point(420, 178);
			this.cboCntrTypeList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.cboCntrTypeList.Name = "cboCntrTypeList";
			this.cboCntrTypeList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCntrTypeList.Properties.NullText = "";
			this.cboCntrTypeList.Properties.ReadOnly = true;
			this.cboCntrTypeList.Size = new System.Drawing.Size(177, 22);
			this.cboCntrTypeList.StyleController = this.mainLayout;
			this.cboCntrTypeList.TabIndex = 7;
			// 
			// cboCntrTeuList
			// 
			this.cboCntrTeuList.Location = new System.Drawing.Point(134, 178);
			this.cboCntrTeuList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.cboCntrTeuList.Name = "cboCntrTeuList";
			this.cboCntrTeuList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCntrTeuList.Properties.NullText = "";
			this.cboCntrTeuList.Properties.ReadOnly = true;
			this.cboCntrTeuList.Size = new System.Drawing.Size(172, 22);
			this.cboCntrTeuList.StyleController = this.mainLayout;
			this.cboCntrTeuList.TabIndex = 6;
			// 
			// txtCntrNumber
			// 
			this.txtCntrNumber.Location = new System.Drawing.Point(420, 76);
			this.txtCntrNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtCntrNumber.Name = "txtCntrNumber";
			this.txtCntrNumber.Properties.ReadOnly = true;
			this.txtCntrNumber.Size = new System.Drawing.Size(177, 22);
			this.txtCntrNumber.StyleController = this.mainLayout;
			this.txtCntrNumber.TabIndex = 5;
			// 
			// txtCntrPrefix
			// 
			this.txtCntrPrefix.Location = new System.Drawing.Point(134, 76);
			this.txtCntrPrefix.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtCntrPrefix.Name = "txtCntrPrefix";
			this.txtCntrPrefix.Properties.ReadOnly = true;
			this.txtCntrPrefix.Size = new System.Drawing.Size(172, 22);
			this.txtCntrPrefix.StyleController = this.mainLayout;
			this.txtCntrPrefix.TabIndex = 4;
			// 
			// cboMasterContainer
			// 
			this.cboMasterContainer.Location = new System.Drawing.Point(134, 50);
			this.cboMasterContainer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.cboMasterContainer.Name = "cboMasterContainer";
			this.cboMasterContainer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboMasterContainer.Properties.NullText = "";
			this.cboMasterContainer.Properties.PopupView = this.searchLookUpEdit1View;
			this.cboMasterContainer.Properties.ReadOnly = true;
			this.cboMasterContainer.Properties.ShowAddNewButton = true;
			this.cboMasterContainer.Size = new System.Drawing.Size(463, 22);
			this.cboMasterContainer.StyleController = this.mainLayout;
			this.cboMasterContainer.TabIndex = 13;
			// 
			// searchLookUpEdit1View
			// 
			this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
			this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.layoutControlItem1});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(621, 354);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.Control = this.btnSave;
			this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
			this.layoutControlItem7.Location = new System.Drawing.Point(293, 303);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(149, 31);
			this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem7.TextVisible = false;
			// 
			// layoutControlItem8
			// 
			this.layoutControlItem8.Control = this.btnCancel;
			this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
			this.layoutControlItem8.Location = new System.Drawing.Point(442, 303);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(159, 31);
			this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem8.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblMasterContainer,
            this.layoutControlItemPrefix,
            this.layoutControlItemNumber,
            this.layoutControlItemSeal});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(601, 128);
			this.layoutControlGroup2.Text = "Container Detail";
			// 
			// lblMasterContainer
			// 
			this.lblMasterContainer.Control = this.cboMasterContainer;
			this.lblMasterContainer.CustomizationFormText = "MasterContainer";
			this.lblMasterContainer.Location = new System.Drawing.Point(0, 0);
			this.lblMasterContainer.Name = "lblMasterContainer";
			this.lblMasterContainer.Size = new System.Drawing.Size(577, 26);
			this.lblMasterContainer.Text = "Master Container";
			this.lblMasterContainer.TextSize = new System.Drawing.Size(98, 16);
			// 
			// layoutControlItemPrefix
			// 
			this.layoutControlItemPrefix.Control = this.txtCntrPrefix;
			this.layoutControlItemPrefix.CustomizationFormText = "Prefix";
			this.layoutControlItemPrefix.Location = new System.Drawing.Point(0, 26);
			this.layoutControlItemPrefix.Name = "layoutControlItemPrefix";
			this.layoutControlItemPrefix.Size = new System.Drawing.Size(286, 26);
			this.layoutControlItemPrefix.Text = "Prefix";
			this.layoutControlItemPrefix.TextSize = new System.Drawing.Size(98, 16);
			// 
			// layoutControlItemNumber
			// 
			this.layoutControlItemNumber.Control = this.txtCntrNumber;
			this.layoutControlItemNumber.CustomizationFormText = "Number";
			this.layoutControlItemNumber.Location = new System.Drawing.Point(286, 26);
			this.layoutControlItemNumber.Name = "layoutControlItemNumber";
			this.layoutControlItemNumber.Size = new System.Drawing.Size(291, 26);
			this.layoutControlItemNumber.Text = "Number";
			this.layoutControlItemNumber.TextSize = new System.Drawing.Size(98, 16);
			// 
			// layoutControlItemSeal
			// 
			this.layoutControlItemSeal.Control = this.txtSealNumber;
			this.layoutControlItemSeal.CustomizationFormText = "Seal";
			this.layoutControlItemSeal.Location = new System.Drawing.Point(0, 52);
			this.layoutControlItemSeal.Name = "layoutControlItemSeal";
			this.layoutControlItemSeal.Size = new System.Drawing.Size(577, 26);
			this.layoutControlItemSeal.Text = "Seal";
			this.layoutControlItemSeal.TextSize = new System.Drawing.Size(98, 16);
			// 
			// layoutControlGroup3
			// 
			this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemSize,
            this.layoutControlItemContainerType,
            this.layoutControlItemContTare,
            this.layoutControlItemTare});
			this.layoutControlGroup3.Location = new System.Drawing.Point(0, 128);
			this.layoutControlGroup3.Name = "layoutControlGroup3";
			this.layoutControlGroup3.Size = new System.Drawing.Size(601, 102);
			this.layoutControlGroup3.Text = "Container Characteristic";
			// 
			// layoutControlItemSize
			// 
			this.layoutControlItemSize.Control = this.cboCntrTeuList;
			this.layoutControlItemSize.CustomizationFormText = "TEU";
			this.layoutControlItemSize.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItemSize.Name = "layoutControlItemSize";
			this.layoutControlItemSize.Size = new System.Drawing.Size(286, 26);
			this.layoutControlItemSize.Text = "TEU";
			this.layoutControlItemSize.TextSize = new System.Drawing.Size(98, 16);
			// 
			// layoutControlItemContainerType
			// 
			this.layoutControlItemContainerType.Control = this.cboCntrTypeList;
			this.layoutControlItemContainerType.CustomizationFormText = "Type";
			this.layoutControlItemContainerType.Location = new System.Drawing.Point(286, 0);
			this.layoutControlItemContainerType.Name = "layoutControlItemContainerType";
			this.layoutControlItemContainerType.Size = new System.Drawing.Size(291, 26);
			this.layoutControlItemContainerType.Text = "Type";
			this.layoutControlItemContainerType.TextSize = new System.Drawing.Size(98, 16);
			// 
			// layoutControlItemContTare
			// 
			this.layoutControlItemContTare.Control = this.cboCntrTareList;
			this.layoutControlItemContTare.CustomizationFormText = "Tare";
			this.layoutControlItemContTare.Location = new System.Drawing.Point(0, 26);
			this.layoutControlItemContTare.Name = "layoutControlItemContTare";
			this.layoutControlItemContTare.Size = new System.Drawing.Size(286, 26);
			this.layoutControlItemContTare.Text = "Tare";
			this.layoutControlItemContTare.TextSize = new System.Drawing.Size(98, 16);
			// 
			// layoutControlItemTare
			// 
			this.layoutControlItemTare.Control = this.txtCntrTareValue;
			this.layoutControlItemTare.CustomizationFormText = "Tare";
			this.layoutControlItemTare.Location = new System.Drawing.Point(286, 26);
			this.layoutControlItemTare.Name = "layoutControlItemTare";
			this.layoutControlItemTare.Size = new System.Drawing.Size(291, 26);
			this.layoutControlItemTare.Text = "Value";
			this.layoutControlItemTare.TextSize = new System.Drawing.Size(98, 16);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 303);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(293, 31);
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 258);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(601, 45);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.chkActive;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 230);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(601, 28);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// ContainerDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 354);
			this.Controls.Add(this.mainLayout);
			this.MaximizeBox = false;
			this.Name = "ContainerDetailForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Container Detail";
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCntrTareList.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSealNumber.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCntrTareValue.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCntrTypeList.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCntrTeuList.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCntrNumber.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCntrPrefix.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboMasterContainer.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMasterContainer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPrefix)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItemContainerType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItemContTare)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTare)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private DevExpress.XtraLayout.LayoutControl mainLayout;
		private DevExpress.XtraEditors.CheckEdit chkActive;
		private DevExpress.XtraEditors.LookUpEdit cboCntrTareList;
		private DevExpress.XtraEditors.SimpleButton btnCancel;
		private DevExpress.XtraEditors.SimpleButton btnSave;
		private DevExpress.XtraEditors.TextEdit txtSealNumber;
		private DevExpress.XtraEditors.TextEdit txtCntrTareValue;
		private DevExpress.XtraEditors.LookUpEdit cboCntrTypeList;
		private DevExpress.XtraEditors.LookUpEdit cboCntrTeuList;
		private DevExpress.XtraEditors.TextEdit txtCntrNumber;
		private DevExpress.XtraEditors.TextEdit txtCntrPrefix;
		private DevExpress.XtraEditors.SearchLookUpEdit cboMasterContainer;
		private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem lblMasterContainer;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItemPrefix;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItemNumber;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSeal;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSize;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItemContainerType;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItemContTare;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItemTare;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
	}
}