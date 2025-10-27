using MISLiveMed.Models.Models.Common.Countries;

namespace MISLiveMed.UI.Forms.Common.Countries
{
    partial class CountriesListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountriesListForm));
			this.rcCountriesList = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.rpCountriesList = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.gcCountries = new DevExpress.XtraGrid.GridControl();
			this.bsCountries = new System.Windows.Forms.BindingSource(this.components);
			this.gvCountries = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCountryCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNationality = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSurfaceArea = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repNumeric = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colIndependentYear = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPopulation = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLifeExpectancy = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGNP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGNPOld = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLocalName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGovernmentForm = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHeadOfState = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCapital = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colContinentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repContinents = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colRegionId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repRegions = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repChecbox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.rcCountriesList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcCountries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCountries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCountries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repContinents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repRegions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repChecbox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// rcCountriesList
			// 
			this.rcCountriesList.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcCountriesList.ExpandCollapseItem.Id = 0;
			this.rcCountriesList.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcCountriesList.ExpandCollapseItem,
            this.btnNew,
            this.btnDelete,
            this.btnEdit,
            this.btnPrint,
            this.btnRefresh,
            this.btnClose,
            this.btnResetGridStyle});
			this.rcCountriesList.Location = new System.Drawing.Point(0, 0);
			this.rcCountriesList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcCountriesList.MaxItemId = 42;
			this.rcCountriesList.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.rcCountriesList.Name = "rcCountriesList";
			this.rcCountriesList.OptionsMenuMinWidth = 385;
			this.rcCountriesList.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpCountriesList,
            this.rpViewSettings});
			this.rcCountriesList.Size = new System.Drawing.Size(1402, 193);
			this.rcCountriesList.StatusBar = this.ribbonStatusBar1;
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
			// rpCountriesList
			// 
			this.rpCountriesList.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup11});
			this.rpCountriesList.Name = "rpCountriesList";
			this.rpCountriesList.Text = "COUNTRIES";
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
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 734);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcCountriesList;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1402, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.gcCountries);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1402, 541);
			this.mainLayout.TabIndex = 4;
			this.mainLayout.Text = "layoutControl1";
			// 
			// gcCountries
			// 
			this.gcCountries.DataSource = this.bsCountries;
			this.gcCountries.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcCountries.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcCountries.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcCountries.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcCountries.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcCountries.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcCountries.Location = new System.Drawing.Point(12, 12);
			this.gcCountries.MainView = this.gvCountries;
			this.gcCountries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcCountries.Name = "gcCountries";
			this.gcCountries.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repNumeric,
            this.repChecbox,
            this.repRegions,
            this.repContinents});
			this.gcCountries.Size = new System.Drawing.Size(1378, 517);
			this.gcCountries.TabIndex = 7;
			this.gcCountries.UseEmbeddedNavigator = true;
			this.gcCountries.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCountries});
			this.gcCountries.DoubleClick += new System.EventHandler(this.gcCountries_DoubleClick);
			// 
			// bsCountries
			// 
			this.bsCountries.DataSource = typeof(CountryModel);
			// 
			// gvCountries
			// 
			this.gvCountries.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCode2,
            this.colCountryCode,
            this.colCountryName,
            this.colNationality,
            this.colSurfaceArea,
            this.colIndependentYear,
            this.colPopulation,
            this.colLifeExpectancy,
            this.colGNP,
            this.colGNPOld,
            this.colLocalName,
            this.colGovernmentForm,
            this.colHeadOfState,
            this.colCapital,
            this.colContinentId,
            this.colRegionId,
            this.colNotes,
            this.colActive});
			this.gvCountries.DetailHeight = 458;
			this.gvCountries.GridControl = this.gcCountries;
			this.gvCountries.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", null, "")});
			this.gvCountries.Name = "gvCountries";
			this.gvCountries.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.gvCountries.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gvCountries.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvCountries.OptionsBehavior.Editable = false;
			this.gvCountries.OptionsDetail.EnableMasterViewMode = false;
			this.gvCountries.OptionsFind.AlwaysVisible = true;
			this.gvCountries.OptionsPrint.AutoWidth = false;
			this.gvCountries.OptionsPrint.PrintHorzLines = false;
			this.gvCountries.OptionsPrint.PrintVertLines = false;
			this.gvCountries.OptionsView.ColumnAutoWidth = false;
			this.gvCountries.OptionsView.ShowFooter = true;
			this.gvCountries.OptionsView.ShowGroupedColumns = true;
			this.gvCountries.OptionsView.ShowGroupPanel = false;
			this.gvCountries.OptionsView.ShowIndicator = false;
			this.gvCountries.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
			this.gvCountries.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvCountries_RowCellStyle);
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 94;
			// 
			// colCode2
			// 
			this.colCode2.FieldName = "Code2";
			this.colCode2.MinWidth = 25;
			this.colCode2.Name = "colCode2";
			this.colCode2.Visible = true;
			this.colCode2.VisibleIndex = 1;
			this.colCode2.Width = 73;
			// 
			// colCountryCode
			// 
			this.colCountryCode.FieldName = "CountryCode";
			this.colCountryCode.MinWidth = 25;
			this.colCountryCode.Name = "colCountryCode";
			this.colCountryCode.Visible = true;
			this.colCountryCode.VisibleIndex = 2;
			this.colCountryCode.Width = 110;
			// 
			// colCountryName
			// 
			this.colCountryName.FieldName = "CountryName";
			this.colCountryName.MinWidth = 25;
			this.colCountryName.Name = "colCountryName";
			this.colCountryName.Visible = true;
			this.colCountryName.VisibleIndex = 3;
			this.colCountryName.Width = 178;
			// 
			// colNationality
			// 
			this.colNationality.FieldName = "Nationality";
			this.colNationality.MinWidth = 25;
			this.colNationality.Name = "colNationality";
			this.colNationality.Visible = true;
			this.colNationality.VisibleIndex = 4;
			this.colNationality.Width = 149;
			// 
			// colSurfaceArea
			// 
			this.colSurfaceArea.ColumnEdit = this.repNumeric;
			this.colSurfaceArea.FieldName = "SurfaceArea";
			this.colSurfaceArea.MinWidth = 25;
			this.colSurfaceArea.Name = "colSurfaceArea";
			this.colSurfaceArea.Visible = true;
			this.colSurfaceArea.VisibleIndex = 5;
			this.colSurfaceArea.Width = 94;
			// 
			// repNumeric
			// 
			this.repNumeric.AutoHeight = false;
			this.repNumeric.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.repNumeric.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
			this.repNumeric.MaskSettings.Set("mask", "###,###");
			this.repNumeric.Name = "repNumeric";
			this.repNumeric.UseMaskAsDisplayFormat = true;
			// 
			// colIndependentYear
			// 
			this.colIndependentYear.FieldName = "IndependentYear";
			this.colIndependentYear.MinWidth = 25;
			this.colIndependentYear.Name = "colIndependentYear";
			this.colIndependentYear.Visible = true;
			this.colIndependentYear.VisibleIndex = 6;
			this.colIndependentYear.Width = 125;
			// 
			// colPopulation
			// 
			this.colPopulation.ColumnEdit = this.repNumeric;
			this.colPopulation.FieldName = "Population";
			this.colPopulation.MinWidth = 25;
			this.colPopulation.Name = "colPopulation";
			this.colPopulation.Visible = true;
			this.colPopulation.VisibleIndex = 7;
			this.colPopulation.Width = 113;
			// 
			// colLifeExpectancy
			// 
			this.colLifeExpectancy.FieldName = "LifeExpectancy";
			this.colLifeExpectancy.MinWidth = 25;
			this.colLifeExpectancy.Name = "colLifeExpectancy";
			this.colLifeExpectancy.Visible = true;
			this.colLifeExpectancy.VisibleIndex = 8;
			this.colLifeExpectancy.Width = 94;
			// 
			// colGNP
			// 
			this.colGNP.ColumnEdit = this.repNumeric;
			this.colGNP.FieldName = "GNP";
			this.colGNP.MinWidth = 25;
			this.colGNP.Name = "colGNP";
			this.colGNP.Visible = true;
			this.colGNP.VisibleIndex = 9;
			this.colGNP.Width = 94;
			// 
			// colGNPOld
			// 
			this.colGNPOld.ColumnEdit = this.repNumeric;
			this.colGNPOld.FieldName = "GNPOld";
			this.colGNPOld.MinWidth = 25;
			this.colGNPOld.Name = "colGNPOld";
			this.colGNPOld.Visible = true;
			this.colGNPOld.VisibleIndex = 10;
			this.colGNPOld.Width = 101;
			// 
			// colLocalName
			// 
			this.colLocalName.FieldName = "LocalName";
			this.colLocalName.MinWidth = 25;
			this.colLocalName.Name = "colLocalName";
			this.colLocalName.Visible = true;
			this.colLocalName.VisibleIndex = 11;
			this.colLocalName.Width = 132;
			// 
			// colGovernmentForm
			// 
			this.colGovernmentForm.FieldName = "GovernmentForm";
			this.colGovernmentForm.MinWidth = 25;
			this.colGovernmentForm.Name = "colGovernmentForm";
			this.colGovernmentForm.Visible = true;
			this.colGovernmentForm.VisibleIndex = 12;
			this.colGovernmentForm.Width = 178;
			// 
			// colHeadOfState
			// 
			this.colHeadOfState.FieldName = "HeadOfState";
			this.colHeadOfState.MinWidth = 25;
			this.colHeadOfState.Name = "colHeadOfState";
			this.colHeadOfState.Visible = true;
			this.colHeadOfState.VisibleIndex = 13;
			this.colHeadOfState.Width = 137;
			// 
			// colCapital
			// 
			this.colCapital.ColumnEdit = this.repNumeric;
			this.colCapital.FieldName = "Capital";
			this.colCapital.MinWidth = 25;
			this.colCapital.Name = "colCapital";
			this.colCapital.Visible = true;
			this.colCapital.VisibleIndex = 14;
			this.colCapital.Width = 122;
			// 
			// colContinentId
			// 
			this.colContinentId.Caption = "Continent";
			this.colContinentId.ColumnEdit = this.repContinents;
			this.colContinentId.FieldName = "ContinentId";
			this.colContinentId.MinWidth = 25;
			this.colContinentId.Name = "colContinentId";
			this.colContinentId.Visible = true;
			this.colContinentId.VisibleIndex = 15;
			this.colContinentId.Width = 131;
			// 
			// repContinents
			// 
			this.repContinents.AutoHeight = false;
			this.repContinents.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repContinents.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repContinents.DisplayMember = "Name";
			this.repContinents.Name = "repContinents";
			this.repContinents.NullText = "";
			this.repContinents.ValueMember = "Id";
			// 
			// colRegionId
			// 
			this.colRegionId.Caption = "Region";
			this.colRegionId.ColumnEdit = this.repRegions;
			this.colRegionId.FieldName = "RegionId";
			this.colRegionId.MinWidth = 25;
			this.colRegionId.Name = "colRegionId";
			this.colRegionId.Visible = true;
			this.colRegionId.VisibleIndex = 16;
			this.colRegionId.Width = 144;
			// 
			// repRegions
			// 
			this.repRegions.AutoHeight = false;
			this.repRegions.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repRegions.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repRegions.DisplayMember = "Name";
			this.repRegions.Name = "repRegions";
			this.repRegions.NullText = "";
			this.repRegions.ValueMember = "Id";
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 17;
			this.colNotes.Width = 345;
			// 
			// colActive
			// 
			this.colActive.ColumnEdit = this.repChecbox;
			this.colActive.FieldName = "Active";
			this.colActive.MinWidth = 25;
			this.colActive.Name = "colActive";
			this.colActive.Visible = true;
			this.colActive.VisibleIndex = 18;
			this.colActive.Width = 94;
			// 
			// repChecbox
			// 
			this.repChecbox.AutoHeight = false;
			this.repChecbox.Name = "repChecbox";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1402, 541);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcCountries;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1382, 521);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
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
			// btnResetGridStyle
			// 
			this.btnResetGridStyle.Caption = "Reset Grid Style";
			this.btnResetGridStyle.Id = 41;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			this.btnResetGridStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetGridStyle_ItemClick);
			// 
			// CountriesListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1402, 764);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcCountriesList);
			this.Name = "CountriesListForm";
			this.Ribbon = this.rcCountriesList;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Countries List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CountriesListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.rcCountriesList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcCountries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCountries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCountries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repContinents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repRegions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repChecbox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraBars.Ribbon.RibbonControl rcCountriesList;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCountriesList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource bsCountries;
		private DevExpress.XtraGrid.GridControl gcCountries;
		private DevExpress.XtraGrid.Views.Grid.GridView gvCountries;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colCode2;
		private DevExpress.XtraGrid.Columns.GridColumn colCountryCode;
		private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
		private DevExpress.XtraGrid.Columns.GridColumn colNationality;
		private DevExpress.XtraGrid.Columns.GridColumn colSurfaceArea;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repNumeric;
		private DevExpress.XtraGrid.Columns.GridColumn colIndependentYear;
		private DevExpress.XtraGrid.Columns.GridColumn colPopulation;
		private DevExpress.XtraGrid.Columns.GridColumn colLifeExpectancy;
		private DevExpress.XtraGrid.Columns.GridColumn colGNP;
		private DevExpress.XtraGrid.Columns.GridColumn colGNPOld;
		private DevExpress.XtraGrid.Columns.GridColumn colLocalName;
		private DevExpress.XtraGrid.Columns.GridColumn colGovernmentForm;
		private DevExpress.XtraGrid.Columns.GridColumn colHeadOfState;
		private DevExpress.XtraGrid.Columns.GridColumn colCapital;
		private DevExpress.XtraGrid.Columns.GridColumn colContinentId;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repContinents;
		private DevExpress.XtraGrid.Columns.GridColumn colRegionId;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repRegions;
		private DevExpress.XtraGrid.Columns.GridColumn colNotes;
		private DevExpress.XtraGrid.Columns.GridColumn colActive;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repChecbox;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
	}
}