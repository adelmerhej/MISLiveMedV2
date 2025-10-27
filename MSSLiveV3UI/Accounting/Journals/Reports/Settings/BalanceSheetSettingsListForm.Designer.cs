using MISLiveMed.Models.Models.Accounting.Reports.Settings;

namespace MISLiveMed.UI.Accounting.Journals.Reports.Settings
{
	partial class BalanceSheetSettingsListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceSheetSettingsListForm));
			this.rcAccounts = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.cboBalanceHeaders = new DevExpress.XtraBars.BarEditItem();
			this.filterBalanceHeaders = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboBalanceGroup = new DevExpress.XtraBars.BarEditItem();
			this.filterBalanceGroup = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.rpAccounts = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.rpgActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.gcBalanceSheetSettings = new DevExpress.XtraGrid.GridControl();
			this.bsBalanceSheetSettings = new System.Windows.Forms.BindingSource(this.components);
			this.gvBalanceSheetSettings = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBalanceHeaderId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repBalanceHeaders = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colParentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colColumnFirst = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colColumnSecond = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOrderInList = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsTotals = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsGrandTotal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.colDbCr = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repDbCr = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
			((System.ComponentModel.ISupportInitialize)(this.rcAccounts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.filterBalanceHeaders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.filterBalanceGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcBalanceSheetSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsBalanceSheetSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvBalanceSheetSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repBalanceHeaders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repDbCr)).BeginInit();
			this.SuspendLayout();
			// 
			// rcAccounts
			// 
			this.rcAccounts.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcAccounts.ExpandCollapseItem.Id = 0;
			this.rcAccounts.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcAccounts.ExpandCollapseItem,
            this.btnNew,
            this.btnDelete,
            this.btnEdit,
            this.btnPrint,
            this.btnRefresh,
            this.btnClose,
            this.btnResetGridStyle,
            this.cboBalanceHeaders,
            this.cboBalanceGroup});
			this.rcAccounts.Location = new System.Drawing.Point(0, 0);
			this.rcAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcAccounts.MaxItemId = 49;
			this.rcAccounts.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.rcAccounts.Name = "rcAccounts";
			this.rcAccounts.OptionsMenuMinWidth = 385;
			this.rcAccounts.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpAccounts,
            this.rpViewSettings});
			this.rcAccounts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.filterBalanceHeaders,
            this.filterBalanceGroup});
			this.rcAccounts.Size = new System.Drawing.Size(1440, 193);
			this.rcAccounts.StatusBar = this.ribbonStatusBar1;
			// 
			// btnNew
			// 
			this.btnNew.Caption = "Add New";
			this.btnNew.Enabled = false;
			this.btnNew.Id = 1;
			this.btnNew.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnNew.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewCustomer.svg";
			this.btnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNew.ImageOptions.SvgImage")));
			this.btnNew.Name = "btnNew";
			this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Caption = "Delete";
			this.btnDelete.Enabled = false;
			this.btnDelete.Id = 3;
			this.btnDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnDelete.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg";
			this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
			// 
			// btnEdit
			// 
			this.btnEdit.Caption = "Edit";
			this.btnEdit.Enabled = false;
			this.btnEdit.Id = 13;
			this.btnEdit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnEdit.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Edit.svg";
			this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
			// 
			// btnPrint
			// 
			this.btnPrint.Caption = "Print View";
			this.btnPrint.Enabled = false;
			this.btnPrint.Id = 16;
			this.btnPrint.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnPrint.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesAnalysis.svg";
			this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Caption = "Refresh";
			this.btnRefresh.Id = 37;
			this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
			// 
			// btnClose
			// 
			this.btnClose.Caption = "Close";
			this.btnClose.Id = 38;
			this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
			this.btnClose.Name = "btnClose";
			this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
			// 
			// btnResetGridStyle
			// 
			this.btnResetGridStyle.Caption = "Reset Grid Style";
			this.btnResetGridStyle.Id = 40;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			this.btnResetGridStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetGridStyle_ItemClick);
			// 
			// cboBalanceHeaders
			// 
			this.cboBalanceHeaders.Caption = "Balance Header";
			this.cboBalanceHeaders.CaptionToEditorIndent = 45;
			this.cboBalanceHeaders.Edit = this.filterBalanceHeaders;
			this.cboBalanceHeaders.EditWidth = 150;
			this.cboBalanceHeaders.Id = 42;
			this.cboBalanceHeaders.Name = "cboBalanceHeaders";
			this.cboBalanceHeaders.EditValueChanged += new System.EventHandler(this.cboBalanceHeaders_EditValueChanged);
			// 
			// filterBalanceHeaders
			// 
			this.filterBalanceHeaders.AutoHeight = false;
			this.filterBalanceHeaders.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.filterBalanceHeaders.DisplayMember = "Description";
			this.filterBalanceHeaders.Name = "filterBalanceHeaders";
			this.filterBalanceHeaders.NullText = "";
			this.filterBalanceHeaders.PopupView = this.gridView1;
			this.filterBalanceHeaders.ValueMember = "Id";
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
			this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Id";
			this.gridColumn3.FieldName = "Id";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Width = 93;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "Description";
			this.gridColumn4.FieldName = "Description";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 0;
			this.gridColumn4.Width = 1115;
			// 
			// cboBalanceGroup
			// 
			this.cboBalanceGroup.Caption = "Balance Group";
			this.cboBalanceGroup.CaptionToEditorIndent = 50;
			this.cboBalanceGroup.Edit = this.filterBalanceGroup;
			this.cboBalanceGroup.EditWidth = 150;
			this.cboBalanceGroup.Id = 43;
			this.cboBalanceGroup.Name = "cboBalanceGroup";
			this.cboBalanceGroup.EditValueChanged += new System.EventHandler(this.cboBalanceGroup_EditValueChanged);
			// 
			// filterBalanceGroup
			// 
			this.filterBalanceGroup.AutoHeight = false;
			this.filterBalanceGroup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.filterBalanceGroup.DisplayMember = "Description";
			this.filterBalanceGroup.Name = "filterBalanceGroup";
			this.filterBalanceGroup.NullText = "";
			this.filterBalanceGroup.PopupView = this.repositoryItemSearchLookUpEdit1View;
			this.filterBalanceGroup.ValueMember = "Id";
			// 
			// repositoryItemSearchLookUpEdit1View
			// 
			this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
			this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
			this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Id";
			this.gridColumn1.FieldName = "Id";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			this.gridColumn1.Width = 62;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Description";
			this.gridColumn2.FieldName = "Description";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			this.gridColumn2.Width = 974;
			// 
			// rpAccounts
			// 
			this.rpAccounts.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgActions,
            this.ribbonPageGroup11,
            this.ribbonPageGroup3});
			this.rpAccounts.Name = "rpAccounts";
			this.rpAccounts.Text = "Balance / Income";
			// 
			// rpgActions
			// 
			this.rpgActions.AllowTextClipping = false;
			this.rpgActions.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.rpgActions.ItemLinks.Add(this.btnNew);
			this.rpgActions.ItemLinks.Add(this.btnEdit, true);
			this.rpgActions.ItemLinks.Add(this.btnRefresh);
			this.rpgActions.ItemLinks.Add(this.btnPrint, true);
			this.rpgActions.ItemLinks.Add(this.btnDelete, true);
			this.rpgActions.MergeOrder = 1;
			this.rpgActions.Name = "rpgActions";
			this.rpgActions.Text = "Actions";
			// 
			// ribbonPageGroup11
			// 
			this.ribbonPageGroup11.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
			this.ribbonPageGroup11.ItemLinks.Add(this.btnClose);
			this.ribbonPageGroup11.Name = "ribbonPageGroup11";
			this.ribbonPageGroup11.Text = "Close View";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.cboBalanceGroup);
			this.ribbonPageGroup3.ItemLinks.Add(this.cboBalanceHeaders);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.Text = "Filter";
			// 
			// rpViewSettings
			// 
			this.rpViewSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
			this.rpViewSettings.Name = "rpViewSettings";
			this.rpViewSettings.Text = "VIEW SETTINGS";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.btnResetGridStyle);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "Grid Settings";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 748);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcAccounts;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1440, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.AllowCustomization = false;
			this.mainLayout.Controls.Add(this.gcBalanceSheetSettings);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(717, 447, 450, 350);
			this.mainLayout.Root = this.layoutControlGroup1;
			this.mainLayout.Size = new System.Drawing.Size(1440, 555);
			this.mainLayout.TabIndex = 14;
			this.mainLayout.Text = "layoutControl1";
			// 
			// gcBalanceSheetSettings
			// 
			this.gcBalanceSheetSettings.DataSource = this.bsBalanceSheetSettings;
			this.gcBalanceSheetSettings.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcBalanceSheetSettings.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcBalanceSheetSettings.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcBalanceSheetSettings.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcBalanceSheetSettings.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcBalanceSheetSettings.Location = new System.Drawing.Point(9, 10);
			this.gcBalanceSheetSettings.MainView = this.gvBalanceSheetSettings;
			this.gcBalanceSheetSettings.Name = "gcBalanceSheetSettings";
			this.gcBalanceSheetSettings.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheckBox,
            this.repBalanceHeaders,
            this.repDbCr});
			this.gcBalanceSheetSettings.Size = new System.Drawing.Size(1422, 535);
			this.gcBalanceSheetSettings.TabIndex = 9;
			this.gcBalanceSheetSettings.UseEmbeddedNavigator = true;
			this.gcBalanceSheetSettings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBalanceSheetSettings});
			this.gcBalanceSheetSettings.DoubleClick += new System.EventHandler(this.gcAccountBalances_DoubleClick);
			// 
			// bsBalanceSheetSettings
			// 
			this.bsBalanceSheetSettings.DataSource = typeof(BalanceSheetSettingModel);
			// 
			// gvBalanceSheetSettings
			// 
			this.gvBalanceSheetSettings.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colBalanceHeaderId,
            this.colParentId,
            this.colAccountNumber,
            this.colDescription,
            this.colDbCr,
            this.colColumnFirst,
            this.colColumnSecond,
            this.colOrderInList,
            this.colIsTotals,
            this.colIsGrandTotal,
            this.colNotes,
            this.colActive});
			this.gvBalanceSheetSettings.GridControl = this.gcBalanceSheetSettings;
			this.gvBalanceSheetSettings.Name = "gvBalanceSheetSettings";
			this.gvBalanceSheetSettings.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.gvBalanceSheetSettings.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvBalanceSheetSettings.OptionsBehavior.Editable = false;
			this.gvBalanceSheetSettings.OptionsBehavior.ReadOnly = true;
			this.gvBalanceSheetSettings.OptionsDetail.EnableMasterViewMode = false;
			this.gvBalanceSheetSettings.OptionsFind.AlwaysVisible = true;
			this.gvBalanceSheetSettings.OptionsView.ColumnAutoWidth = false;
			this.gvBalanceSheetSettings.OptionsView.ShowGroupedColumns = true;
			this.gvBalanceSheetSettings.OptionsView.ShowGroupPanel = false;
			this.gvBalanceSheetSettings.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvBalanceSheetSettings_RowCellStyle);
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 69;
			// 
			// colBalanceHeaderId
			// 
			this.colBalanceHeaderId.ColumnEdit = this.repBalanceHeaders;
			this.colBalanceHeaderId.FieldName = "BalanceHeaderId";
			this.colBalanceHeaderId.MinWidth = 25;
			this.colBalanceHeaderId.Name = "colBalanceHeaderId";
			this.colBalanceHeaderId.Visible = true;
			this.colBalanceHeaderId.VisibleIndex = 1;
			this.colBalanceHeaderId.Width = 142;
			// 
			// repBalanceHeaders
			// 
			this.repBalanceHeaders.AutoHeight = false;
			this.repBalanceHeaders.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repBalanceHeaders.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repBalanceHeaders.DisplayMember = "Description";
			this.repBalanceHeaders.Name = "repBalanceHeaders";
			this.repBalanceHeaders.NullText = "";
			this.repBalanceHeaders.ValueMember = "Id";
			// 
			// colParentId
			// 
			this.colParentId.FieldName = "ParentId";
			this.colParentId.MinWidth = 25;
			this.colParentId.Name = "colParentId";
			this.colParentId.Visible = true;
			this.colParentId.VisibleIndex = 2;
			this.colParentId.Width = 136;
			// 
			// colAccountNumber
			// 
			this.colAccountNumber.FieldName = "AccountNumber";
			this.colAccountNumber.MinWidth = 25;
			this.colAccountNumber.Name = "colAccountNumber";
			this.colAccountNumber.Visible = true;
			this.colAccountNumber.VisibleIndex = 3;
			this.colAccountNumber.Width = 156;
			// 
			// colDescription
			// 
			this.colDescription.FieldName = "Description";
			this.colDescription.MinWidth = 25;
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 4;
			this.colDescription.Width = 324;
			// 
			// colColumnFirst
			// 
			this.colColumnFirst.ColumnEdit = this.repCheckBox;
			this.colColumnFirst.FieldName = "ColumnFirst";
			this.colColumnFirst.MinWidth = 25;
			this.colColumnFirst.Name = "colColumnFirst";
			this.colColumnFirst.Visible = true;
			this.colColumnFirst.VisibleIndex = 6;
			this.colColumnFirst.Width = 94;
			// 
			// repCheckBox
			// 
			this.repCheckBox.AutoHeight = false;
			this.repCheckBox.Name = "repCheckBox";
			// 
			// colColumnSecond
			// 
			this.colColumnSecond.ColumnEdit = this.repCheckBox;
			this.colColumnSecond.FieldName = "ColumnSecond";
			this.colColumnSecond.MinWidth = 25;
			this.colColumnSecond.Name = "colColumnSecond";
			this.colColumnSecond.Visible = true;
			this.colColumnSecond.VisibleIndex = 7;
			this.colColumnSecond.Width = 123;
			// 
			// colOrderInList
			// 
			this.colOrderInList.FieldName = "OrderInList";
			this.colOrderInList.MinWidth = 25;
			this.colOrderInList.Name = "colOrderInList";
			this.colOrderInList.Visible = true;
			this.colOrderInList.VisibleIndex = 8;
			this.colOrderInList.Width = 133;
			// 
			// colIsTotals
			// 
			this.colIsTotals.ColumnEdit = this.repCheckBox;
			this.colIsTotals.FieldName = "IsTotal";
			this.colIsTotals.MinWidth = 25;
			this.colIsTotals.Name = "colIsTotals";
			this.colIsTotals.Visible = true;
			this.colIsTotals.VisibleIndex = 9;
			this.colIsTotals.Width = 94;
			// 
			// colIsGrandTotal
			// 
			this.colIsGrandTotal.ColumnEdit = this.repCheckBox;
			this.colIsGrandTotal.FieldName = "IsGrandTotal";
			this.colIsGrandTotal.MinWidth = 25;
			this.colIsGrandTotal.Name = "colIsGrandTotal";
			this.colIsGrandTotal.Visible = true;
			this.colIsGrandTotal.VisibleIndex = 10;
			this.colIsGrandTotal.Width = 94;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 11;
			this.colNotes.Width = 294;
			// 
			// colActive
			// 
			this.colActive.ColumnEdit = this.repCheckBox;
			this.colActive.FieldName = "Active";
			this.colActive.MinWidth = 25;
			this.colActive.Name = "colActive";
			this.colActive.Visible = true;
			this.colActive.VisibleIndex = 12;
			this.colActive.Width = 94;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(7, 7, 8, 8);
			this.layoutControlGroup1.Size = new System.Drawing.Size(1440, 555);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcBalanceSheetSettings;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1426, 539);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// colDbCr
			// 
			this.colDbCr.ColumnEdit = this.repDbCr;
			this.colDbCr.FieldName = "DbCr";
			this.colDbCr.MinWidth = 25;
			this.colDbCr.Name = "colDbCr";
			this.colDbCr.Visible = true;
			this.colDbCr.VisibleIndex = 5;
			this.colDbCr.Width = 94;
			// 
			// repDbCr
			// 
			this.repDbCr.AutoHeight = false;
			this.repDbCr.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repDbCr.Items.AddRange(new object[] {
            "A",
            "D",
            "C"});
			this.repDbCr.Name = "repDbCr";
			// 
			// BalanceSheetSettingsListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1440, 778);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcAccounts);
			this.Name = "BalanceSheetSettingsListForm";
			this.Ribbon = this.rcAccounts;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Account Balance Settings";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountBalanceSettingsListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.rcAccounts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.filterBalanceHeaders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.filterBalanceGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcBalanceSheetSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsBalanceSheetSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvBalanceSheetSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repBalanceHeaders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repDbCr)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public DevExpress.XtraBars.Ribbon.RibbonControl rcAccounts;
		private DevExpress.XtraBars.BarButtonItem btnNew;
		private DevExpress.XtraBars.BarButtonItem btnDelete;
		private DevExpress.XtraBars.BarButtonItem btnEdit;
		private DevExpress.XtraBars.BarButtonItem btnPrint;
		private DevExpress.XtraBars.BarButtonItem btnRefresh;
		private DevExpress.XtraBars.BarButtonItem btnClose;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpAccounts;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgActions;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
		private DevExpress.XtraLayout.LayoutControl mainLayout;
		private DevExpress.XtraGrid.GridControl gcBalanceSheetSettings;
		private DevExpress.XtraGrid.Views.Grid.GridView gvBalanceSheetSettings;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckBox;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private System.Windows.Forms.BindingSource bsBalanceSheetSettings;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repBalanceHeaders;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private DevExpress.XtraBars.BarEditItem cboBalanceHeaders;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit filterBalanceHeaders;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraBars.BarEditItem cboBalanceGroup;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit filterBalanceGroup;
		private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colBalanceHeaderId;
		private DevExpress.XtraGrid.Columns.GridColumn colParentId;
		private DevExpress.XtraGrid.Columns.GridColumn colAccountNumber;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colColumnFirst;
		private DevExpress.XtraGrid.Columns.GridColumn colColumnSecond;
		private DevExpress.XtraGrid.Columns.GridColumn colOrderInList;
		private DevExpress.XtraGrid.Columns.GridColumn colNotes;
		private DevExpress.XtraGrid.Columns.GridColumn colActive;
		private DevExpress.XtraGrid.Columns.GridColumn colIsTotals;
		private DevExpress.XtraGrid.Columns.GridColumn colIsGrandTotal;
		private DevExpress.XtraGrid.Columns.GridColumn colDbCr;
		private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repDbCr;
	}
}