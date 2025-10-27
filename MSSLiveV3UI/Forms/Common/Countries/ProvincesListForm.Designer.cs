using MISLiveMed.Models.Models.Common.Countries;

namespace MISLiveMed.UI.Forms.Common.Countries
{
    partial class ProvincesListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvincesListForm));
			this.rcProvinces = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.rpProvinces = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.gcProvinces = new DevExpress.XtraGrid.GridControl();
			this.bsProvinces = new System.Windows.Forms.BindingSource(this.components);
			this.gvProvinces = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMainRegionId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCountries = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.chkActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.repMemberCategories = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repGridDepartmentList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.repUsersList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repSalesList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repMembersList = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.repPOLPortCodeList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repPODPortCodeList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.chkJobActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.rcProvinces)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcProvinces)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsProvinces)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvProvinces)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCountries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkActive)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repMemberCategories)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repGridDepartmentList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsersList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSalesList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repMembersList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repPOLPortCodeList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repPODPortCodeList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkJobActive)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// rcProvinces
			// 
			this.rcProvinces.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcProvinces.ExpandCollapseItem.Id = 0;
			this.rcProvinces.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcProvinces.ExpandCollapseItem,
            this.btnNew,
            this.btnDelete,
            this.btnEdit,
            this.btnPrint,
            this.btnRefresh,
            this.btnClose,
            this.btnResetGridStyle});
			this.rcProvinces.Location = new System.Drawing.Point(0, 0);
			this.rcProvinces.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcProvinces.MaxItemId = 42;
			this.rcProvinces.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.rcProvinces.Name = "rcProvinces";
			this.rcProvinces.OptionsMenuMinWidth = 385;
			this.rcProvinces.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpProvinces,
            this.rpViewSettings});
			this.rcProvinces.Size = new System.Drawing.Size(1409, 193);
			this.rcProvinces.StatusBar = this.ribbonStatusBar1;
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
			this.btnResetGridStyle.Id = 41;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			this.btnResetGridStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetGridStyle_ItemClick);
			// 
			// rpProvinces
			// 
			this.rpProvinces.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup11});
			this.rpProvinces.Name = "rpProvinces";
			this.rpProvinces.Text = "PROVINCES";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.AllowTextClipping = false;
			this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup1.ItemLinks.Add(this.btnNew);
			this.ribbonPageGroup1.MergeOrder = 0;
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "New";
			// 
			// ribbonPageGroup6
			// 
			this.ribbonPageGroup6.AllowTextClipping = false;
			this.ribbonPageGroup6.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup6.ItemLinks.Add(this.btnEdit);
			this.ribbonPageGroup6.ItemLinks.Add(this.btnRefresh);
			this.ribbonPageGroup6.ItemLinks.Add(this.btnPrint);
			this.ribbonPageGroup6.MergeOrder = 1;
			this.ribbonPageGroup6.Name = "ribbonPageGroup6";
			this.ribbonPageGroup6.Text = "Actions";
			// 
			// ribbonPageGroup8
			// 
			this.ribbonPageGroup8.AllowTextClipping = false;
			this.ribbonPageGroup8.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup8.ItemLinks.Add(this.btnDelete);
			this.ribbonPageGroup8.MergeOrder = 2;
			this.ribbonPageGroup8.Name = "ribbonPageGroup8";
			this.ribbonPageGroup8.Text = "Delete";
			// 
			// ribbonPageGroup11
			// 
			this.ribbonPageGroup11.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
			this.ribbonPageGroup11.ItemLinks.Add(this.btnClose);
			this.ribbonPageGroup11.Name = "ribbonPageGroup11";
			this.ribbonPageGroup11.Text = "Close View";
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
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 759);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcProvinces;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1409, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.gcProvinces);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1409, 566);
			this.mainLayout.TabIndex = 5;
			this.mainLayout.Text = "layoutControl1";
			// 
			// gcProvinces
			// 
			this.gcProvinces.DataSource = this.bsProvinces;
			this.gcProvinces.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcProvinces.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcProvinces.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcProvinces.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcProvinces.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcProvinces.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcProvinces.Location = new System.Drawing.Point(12, 12);
			this.gcProvinces.MainView = this.gvProvinces;
			this.gcProvinces.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcProvinces.Name = "gcProvinces";
			this.gcProvinces.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repMemberCategories,
            this.repGridDepartmentList,
            this.repositoryItemDateEdit1,
            this.repUsersList,
            this.repSalesList,
            this.repMembersList,
            this.repPOLPortCodeList,
            this.repPODPortCodeList,
            this.chkActive,
            this.chkJobActive,
            this.repCountries});
			this.gcProvinces.Size = new System.Drawing.Size(1385, 542);
			this.gcProvinces.TabIndex = 7;
			this.gcProvinces.UseEmbeddedNavigator = true;
			this.gcProvinces.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProvinces});
			this.gcProvinces.DoubleClick += new System.EventHandler(this.gcProvinces_DoubleClick);
			// 
			// bsProvinces
			// 
			this.bsProvinces.DataSource = typeof(ProvinceModel);
			// 
			// gvProvinces
			// 
			this.gvProvinces.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colMainRegionId,
            this.colActive,
            this.colNotes});
			this.gvProvinces.DetailHeight = 458;
			this.gvProvinces.GridControl = this.gcProvinces;
			this.gvProvinces.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", null, "")});
			this.gvProvinces.Name = "gvProvinces";
			this.gvProvinces.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.gvProvinces.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gvProvinces.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvProvinces.OptionsBehavior.Editable = false;
			this.gvProvinces.OptionsDetail.EnableMasterViewMode = false;
			this.gvProvinces.OptionsFind.AlwaysVisible = true;
			this.gvProvinces.OptionsPrint.AutoWidth = false;
			this.gvProvinces.OptionsPrint.PrintHorzLines = false;
			this.gvProvinces.OptionsPrint.PrintVertLines = false;
			this.gvProvinces.OptionsView.ColumnAutoWidth = false;
			this.gvProvinces.OptionsView.ShowFooter = true;
			this.gvProvinces.OptionsView.ShowGroupedColumns = true;
			this.gvProvinces.OptionsView.ShowGroupPanel = false;
			this.gvProvinces.OptionsView.ShowIndicator = false;
			this.gvProvinces.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
			this.gvProvinces.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvProvinces_RowCellStyle);
			// 
			// colId
			// 
			this.colId.Caption = "Id";
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 94;
			// 
			// colName
			// 
			this.colName.Caption = "Province Name";
			this.colName.FieldName = "Name";
			this.colName.MinWidth = 25;
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 1;
			this.colName.Width = 344;
			// 
			// colMainRegionId
			// 
			this.colMainRegionId.Caption = "Country";
			this.colMainRegionId.ColumnEdit = this.repCountries;
			this.colMainRegionId.FieldName = "CountryId";
			this.colMainRegionId.MinWidth = 25;
			this.colMainRegionId.Name = "colMainRegionId";
			this.colMainRegionId.Visible = true;
			this.colMainRegionId.VisibleIndex = 2;
			this.colMainRegionId.Width = 296;
			// 
			// repCountries
			// 
			this.repCountries.AutoHeight = false;
			this.repCountries.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCountries.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountryName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repCountries.DisplayMember = "CountryName";
			this.repCountries.Name = "repCountries";
			this.repCountries.NullText = "";
			this.repCountries.ValueMember = "Id";
			// 
			// colActive
			// 
			this.colActive.Caption = "Active";
			this.colActive.ColumnEdit = this.chkActive;
			this.colActive.FieldName = "Active";
			this.colActive.MinWidth = 25;
			this.colActive.Name = "colActive";
			this.colActive.Visible = true;
			this.colActive.VisibleIndex = 4;
			this.colActive.Width = 79;
			// 
			// chkActive
			// 
			this.chkActive.AutoHeight = false;
			this.chkActive.Name = "chkActive";
			// 
			// colNotes
			// 
			this.colNotes.Caption = "Notes";
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 3;
			this.colNotes.Width = 533;
			// 
			// repositoryItemImageComboBox1
			// 
			this.repositoryItemImageComboBox1.AutoHeight = false;
			this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
			// 
			// repMemberCategories
			// 
			this.repMemberCategories.AutoHeight = false;
			this.repMemberCategories.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repMemberCategories.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MemberCategoryName", "Name", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MemberCategoryCode", "Code", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repMemberCategories.DisplayMember = "MemberCategoryName";
			this.repMemberCategories.Name = "repMemberCategories";
			this.repMemberCategories.NullText = "";
			this.repMemberCategories.ValueMember = "Id";
			// 
			// repGridDepartmentList
			// 
			this.repGridDepartmentList.AutoHeight = false;
			this.repGridDepartmentList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repGridDepartmentList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "Name", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repGridDepartmentList.DisplayMember = "DepartmentName";
			this.repGridDepartmentList.Name = "repGridDepartmentList";
			this.repGridDepartmentList.NullText = "";
			this.repGridDepartmentList.ValueMember = "Id";
			// 
			// repositoryItemDateEdit1
			// 
			this.repositoryItemDateEdit1.AutoHeight = false;
			this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
			// 
			// repUsersList
			// 
			this.repUsersList.AutoHeight = false;
			this.repUsersList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repUsersList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserId", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "Name", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repUsersList.DisplayMember = "UserName";
			this.repUsersList.Name = "repUsersList";
			this.repUsersList.NullText = "";
			this.repUsersList.ValueMember = "UserId";
			// 
			// repSalesList
			// 
			this.repSalesList.AutoHeight = false;
			this.repSalesList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repSalesList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserId", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "Name", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repSalesList.DisplayMember = "UserName";
			this.repSalesList.Name = "repSalesList";
			this.repSalesList.NullText = "";
			this.repSalesList.ValueMember = "UserId";
			// 
			// repMembersList
			// 
			this.repMembersList.AutoHeight = false;
			this.repMembersList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repMembersList.DisplayMember = "MemberName";
			this.repMembersList.Name = "repMembersList";
			this.repMembersList.NullText = "";
			this.repMembersList.PopupView = this.gridView1;
			this.repMembersList.ValueMember = "Id";
			// 
			// gridView1
			// 
			this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// repPOLPortCodeList
			// 
			this.repPOLPortCodeList.AutoHeight = false;
			this.repPOLPortCodeList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repPOLPortCodeList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PortCode", "Name", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repPOLPortCodeList.DisplayMember = "PortCode";
			this.repPOLPortCodeList.Name = "repPOLPortCodeList";
			this.repPOLPortCodeList.NullText = "";
			this.repPOLPortCodeList.ValueMember = "Id";
			// 
			// repPODPortCodeList
			// 
			this.repPODPortCodeList.AutoHeight = false;
			this.repPODPortCodeList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repPODPortCodeList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PortCode", "Name", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repPODPortCodeList.DisplayMember = "PortCode";
			this.repPODPortCodeList.Name = "repPODPortCodeList";
			this.repPODPortCodeList.NullText = "";
			this.repPODPortCodeList.ValueMember = "Id";
			// 
			// chkJobActive
			// 
			this.chkJobActive.AutoHeight = false;
			this.chkJobActive.Name = "chkJobActive";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1409, 566);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcProvinces;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1389, 546);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// ProvincesListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1409, 789);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcProvinces);
			this.Name = "ProvincesListForm";
			this.Ribbon = this.rcProvinces;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Provinces List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProvincesListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.rcProvinces)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcProvinces)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsProvinces)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvProvinces)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCountries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkActive)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repMemberCategories)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repGridDepartmentList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsersList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSalesList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repMembersList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repPOLPortCodeList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repPODPortCodeList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkJobActive)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.Ribbon.RibbonControl rcProvinces;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpProvinces;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraGrid.GridControl gcProvinces;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProvinces;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colMainRegionId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCountries;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkActive;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repMemberCategories;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repGridDepartmentList;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repUsersList;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repSalesList;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repMembersList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repPOLPortCodeList;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repPODPortCodeList;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkJobActive;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bsProvinces;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
	}
}