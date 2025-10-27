using MISLiveMed.Models.Models.Common.Countries.Ports;

namespace MISLiveMed.UI.Forms.Common.Countries.Ports
{
    partial class LandFreightPortEditForm
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
			this.bsLandFreightPort = new System.Windows.Forms.BindingSource(this.components);
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.txtCode = new DevExpress.XtraEditors.TextEdit();
			this.cboCities = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboCountries = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblCountries = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblCode = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblCities = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.bsLandFreightPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCities.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCountries.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
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
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCountries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCities)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			this.SuspendLayout();
			// 
			// bsLandFreightPort
			// 
			this.bsLandFreightPort.DataSource = typeof(LandFreightPortModel);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.txtCode);
			this.mainLayout.Controls.Add(this.cboCities);
			this.mainLayout.Controls.Add(this.cboCountries);
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
			this.mainLayout.Size = new System.Drawing.Size(598, 401);
			this.mainLayout.TabIndex = 11;
			this.mainLayout.Text = "layoutControl1";
			// 
			// txtCode
			// 
			this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsLandFreightPort, "Code", true));
			this.txtCode.Location = new System.Drawing.Point(80, 78);
			this.txtCode.Name = "txtCode";
			this.txtCode.Properties.MaxLength = 3;
			this.txtCode.Properties.ReadOnly = true;
			this.txtCode.Size = new System.Drawing.Size(217, 22);
			this.txtCode.StyleController = this.mainLayout;
			this.txtCode.TabIndex = 17;
			// 
			// cboCities
			// 
			this.cboCities.Location = new System.Drawing.Point(80, 140);
			this.cboCities.Name = "cboCities";
			this.cboCities.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCities.Properties.DisplayMember = "CityName";
			this.cboCities.Properties.NullText = "";
			this.cboCities.Properties.PopupView = this.searchLookUpEdit2View;
			this.cboCities.Properties.ReadOnly = true;
			this.cboCities.Properties.ShowAddNewButton = true;
			this.cboCities.Properties.ValueMember = "Id";
			this.cboCities.Size = new System.Drawing.Size(217, 22);
			this.cboCities.StyleController = this.mainLayout;
			this.cboCities.TabIndex = 16;
			this.cboCities.AddNewValue += new DevExpress.XtraEditors.Controls.AddNewValueEventHandler(this.cboCities_AddNewValue);
			// 
			// searchLookUpEdit2View
			// 
			this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn4});
			this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
			this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Id";
			this.gridColumn3.FieldName = "Id";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 0;
			this.gridColumn3.Width = 50;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Code";
			this.gridColumn1.FieldName = "CityCode";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 1;
			this.gridColumn1.Width = 50;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "Name";
			this.gridColumn4.FieldName = "CityName";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 2;
			this.gridColumn4.Width = 272;
			// 
			// cboCountries
			// 
			this.cboCountries.Location = new System.Drawing.Point(80, 166);
			this.cboCountries.Name = "cboCountries";
			this.cboCountries.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCountries.Properties.DisplayMember = "CountryName";
			this.cboCountries.Properties.NullText = "";
			this.cboCountries.Properties.PopupView = this.searchLookUpEdit1View;
			this.cboCountries.Properties.ReadOnly = true;
			this.cboCountries.Properties.ShowAddNewButton = true;
			this.cboCountries.Properties.ValueMember = "Id";
			this.cboCountries.Size = new System.Drawing.Size(217, 22);
			this.cboCountries.StyleController = this.mainLayout;
			this.cboCountries.TabIndex = 14;
			this.cboCountries.AddNewValue += new DevExpress.XtraEditors.Controls.AddNewValueEventHandler(this.cboCountries_AddNewValue);
			// 
			// searchLookUpEdit1View
			// 
			this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.gridColumn2,
            this.colName});
			this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
			this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// colId
			// 
			this.colId.Caption = "Id";
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 96;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Code";
			this.gridColumn2.FieldName = "CountryCode";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			this.gridColumn2.Width = 103;
			// 
			// colName
			// 
			this.colName.Caption = "Country";
			this.colName.FieldName = "CountryName";
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 2;
			this.colName.Width = 723;
			// 
			// chkActive
			// 
			this.chkActive.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsLandFreightPort, "Active", true));
			this.chkActive.Enabled = false;
			this.chkActive.Location = new System.Drawing.Point(479, 50);
			this.chkActive.Name = "chkActive";
			this.chkActive.Properties.Caption = "Active";
			this.chkActive.Size = new System.Drawing.Size(95, 24);
			this.chkActive.StyleController = this.mainLayout;
			this.chkActive.TabIndex = 13;
			// 
			// txtNotes
			// 
			this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsLandFreightPort, "Notes", true));
			this.txtNotes.Location = new System.Drawing.Point(24, 242);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Properties.ReadOnly = true;
			this.txtNotes.Size = new System.Drawing.Size(550, 91);
			this.txtNotes.StyleController = this.mainLayout;
			this.txtNotes.TabIndex = 11;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(464, 362);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(122, 27);
			this.btnCancel.StyleController = this.mainLayout;
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(353, 362);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(107, 27);
			this.btnSave.StyleController = this.mainLayout;
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtId
			// 
			this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsLandFreightPort, "Id", true));
			this.txtId.Location = new System.Drawing.Point(80, 50);
			this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtId.Name = "txtId";
			this.txtId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtId.Properties.MaxLength = 3;
			this.txtId.Properties.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(217, 22);
			this.txtId.StyleController = this.mainLayout;
			this.txtId.TabIndex = 4;
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsLandFreightPort, "Name", true));
			this.txtName.Location = new System.Drawing.Point(80, 104);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtName.Name = "txtName";
			this.txtName.Properties.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(494, 22);
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
			this.layoutControlGroup1.Size = new System.Drawing.Size(598, 401);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 337);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(578, 13);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 350);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(341, 31);
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.btnSave;
			this.layoutControlItem4.Location = new System.Drawing.Point(341, 350);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(111, 31);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.btnCancel;
			this.layoutControlItem5.Location = new System.Drawing.Point(452, 350);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(126, 31);
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
            this.layoutControlItem1,
            this.lblCountries,
            this.emptySpaceItem6,
            this.lblCode,
            this.emptySpaceItem7,
            this.lblCities,
            this.emptySpaceItem5,
            this.emptySpaceItem4});
			this.grpInfo.Location = new System.Drawing.Point(0, 0);
			this.grpInfo.Name = "grpInfo";
			this.grpInfo.Size = new System.Drawing.Size(578, 192);
			this.grpInfo.Text = "Land Freight Port Info";
			// 
			// lblMainRegionId
			// 
			this.lblMainRegionId.Control = this.txtId;
			this.lblMainRegionId.Location = new System.Drawing.Point(0, 0);
			this.lblMainRegionId.Name = "lblMainRegionId";
			this.lblMainRegionId.Size = new System.Drawing.Size(277, 28);
			this.lblMainRegionId.Text = "Id";
			this.lblMainRegionId.TextSize = new System.Drawing.Size(44, 16);
			// 
			// lblName
			// 
			this.lblName.Control = this.txtName;
			this.lblName.Location = new System.Drawing.Point(0, 54);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(554, 26);
			this.lblName.Text = "Name";
			this.lblName.TextSize = new System.Drawing.Size(44, 16);
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.AllowHotTrack = false;
			this.emptySpaceItem3.Location = new System.Drawing.Point(277, 0);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(178, 28);
			this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.chkActive;
			this.layoutControlItem1.Location = new System.Drawing.Point(455, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(99, 28);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// lblCountries
			// 
			this.lblCountries.Control = this.cboCountries;
			this.lblCountries.Location = new System.Drawing.Point(0, 116);
			this.lblCountries.Name = "lblCountries";
			this.lblCountries.Size = new System.Drawing.Size(277, 26);
			this.lblCountries.Text = "Country";
			this.lblCountries.TextSize = new System.Drawing.Size(44, 16);
			// 
			// emptySpaceItem6
			// 
			this.emptySpaceItem6.AllowHotTrack = false;
			this.emptySpaceItem6.Location = new System.Drawing.Point(277, 116);
			this.emptySpaceItem6.Name = "emptySpaceItem6";
			this.emptySpaceItem6.Size = new System.Drawing.Size(277, 26);
			this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
			// 
			// lblCode
			// 
			this.lblCode.Control = this.txtCode;
			this.lblCode.Location = new System.Drawing.Point(0, 28);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(277, 26);
			this.lblCode.Text = "Code";
			this.lblCode.TextSize = new System.Drawing.Size(44, 16);
			// 
			// emptySpaceItem7
			// 
			this.emptySpaceItem7.AllowHotTrack = false;
			this.emptySpaceItem7.Location = new System.Drawing.Point(277, 28);
			this.emptySpaceItem7.Name = "emptySpaceItem7";
			this.emptySpaceItem7.Size = new System.Drawing.Size(277, 26);
			this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
			// 
			// lblCities
			// 
			this.lblCities.Control = this.cboCities;
			this.lblCities.Location = new System.Drawing.Point(0, 90);
			this.lblCities.Name = "lblCities";
			this.lblCities.Size = new System.Drawing.Size(277, 26);
			this.lblCities.Text = "City";
			this.lblCities.TextSize = new System.Drawing.Size(44, 16);
			// 
			// emptySpaceItem5
			// 
			this.emptySpaceItem5.AllowHotTrack = false;
			this.emptySpaceItem5.Location = new System.Drawing.Point(277, 90);
			this.emptySpaceItem5.Name = "emptySpaceItem5";
			this.emptySpaceItem5.Size = new System.Drawing.Size(277, 26);
			this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem4
			// 
			this.emptySpaceItem4.AllowHotTrack = false;
			this.emptySpaceItem4.Location = new System.Drawing.Point(0, 80);
			this.emptySpaceItem4.Name = "emptySpaceItem4";
			this.emptySpaceItem4.Size = new System.Drawing.Size(554, 10);
			this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlGroup4
			// 
			this.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
			this.layoutControlGroup4.Location = new System.Drawing.Point(0, 192);
			this.layoutControlGroup4.Name = "layoutControlGroup4";
			this.layoutControlGroup4.Size = new System.Drawing.Size(578, 145);
			this.layoutControlGroup4.Text = "Notes";
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.txtNotes;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(554, 95);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// LandFreightPortEditForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(598, 401);
			this.Controls.Add(this.mainLayout);
			this.MaximizeBox = false;
			this.Name = "LandFreightPortEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Land Freight Port";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LandFreightPortEditForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.bsLandFreightPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCities.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCountries.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
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
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCountries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCities)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsLandFreightPort;
		private DevExpress.XtraLayout.LayoutControl mainLayout;
		private DevExpress.XtraEditors.TextEdit txtCode;
		private DevExpress.XtraEditors.SearchLookUpEdit cboCities;
		private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraEditors.SearchLookUpEdit cboCountries;
		private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
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
		private DevExpress.XtraLayout.LayoutControlItem lblCountries;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
		private DevExpress.XtraLayout.LayoutControlItem lblCode;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
		private DevExpress.XtraLayout.LayoutControlItem lblCities;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
	}
}