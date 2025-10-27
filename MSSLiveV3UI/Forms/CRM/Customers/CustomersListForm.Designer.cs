using MISLiveMed.Models.Models.Members.Customers;

namespace MISLiveMed.UI.Forms.CRM.Customers
{
    partial class CustomersListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersListForm));
			this.rcCustomersList = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
			this.barCheckItem7 = new DevExpress.XtraBars.BarCheckItem();
			this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
			this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.cboSalesFilter = new DevExpress.XtraBars.BarEditItem();
			this.repSalesFilter = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.customersRating = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemRatingControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemRatingControl();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.rpCustomersList = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.gcCustomers = new DevExpress.XtraGrid.GridControl();
			this.gvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFollowupDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repDateFormat = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.colAddress1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPhoneNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPhoneNumber2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPhoneNumber3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmail1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFaxNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCountryId1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCountries = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colCityId1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCities = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colActivity1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colActiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colIsSales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMemberOfId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repMemberOf = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colMofNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colResponsibleId1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repUsers = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colSalesId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.rcCustomersList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSalesFilter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCountries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCities)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repMemberOf)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// rcCustomersList
			// 
			this.rcCustomersList.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcCustomersList.ExpandCollapseItem.Id = 0;
			this.rcCustomersList.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcCustomersList.ExpandCollapseItem,
            this.btnNew,
            this.btnDelete,
            this.btnEdit,
            this.btnPrint,
            this.barButtonItem13,
            this.barCheckItem7,
            this.barButtonItem14,
            this.barHeaderItem1,
            this.btnRefresh,
            this.btnClose,
            this.cboSalesFilter,
            this.customersRating,
            this.btnResetGridStyle});
			this.rcCustomersList.Location = new System.Drawing.Point(0, 0);
			this.rcCustomersList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcCustomersList.MaxItemId = 44;
			this.rcCustomersList.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.rcCustomersList.Name = "rcCustomersList";
			this.rcCustomersList.OptionsMenuMinWidth = 385;
			this.rcCustomersList.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpCustomersList,
            this.rpViewSettings});
			this.rcCustomersList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSalesFilter,
            this.repositoryItemRatingControl1});
			this.rcCustomersList.Size = new System.Drawing.Size(1448, 193);
			this.rcCustomersList.StatusBar = this.ribbonStatusBar1;
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
			// barButtonItem13
			// 
			this.barButtonItem13.Caption = "Reverse Sort";
			this.barButtonItem13.Id = 28;
			this.barButtonItem13.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem13.ImageOptions.ImageUri.Uri = "outlook%20inspired/reverssort;Size16x16";
			this.barButtonItem13.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			this.barButtonItem13.Name = "barButtonItem13";
			// 
			// barCheckItem7
			// 
			this.barCheckItem7.Caption = "Add Columns";
			this.barCheckItem7.Id = 30;
			this.barCheckItem7.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barCheckItem7.ImageOptions.ImageUri.Uri = "outlook%20inspired/addcolumn;Size16x16";
			this.barCheckItem7.Name = "barCheckItem7";
			// 
			// barButtonItem14
			// 
			this.barButtonItem14.Caption = "Expand/Collapse";
			this.barButtonItem14.Id = 31;
			this.barButtonItem14.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem14.ImageOptions.ImageUri.Uri = "outlook%20inspired/expandcollapse;Size16x16";
			this.barButtonItem14.Name = "barButtonItem14";
			// 
			// barHeaderItem1
			// 
			this.barHeaderItem1.Caption = "RECORDS: 0";
			this.barHeaderItem1.Id = 35;
			this.barHeaderItem1.Name = "barHeaderItem1";
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
			// cboSalesFilter
			// 
			this.cboSalesFilter.Caption = "By Sales";
			this.cboSalesFilter.CaptionToEditorIndent = 10;
			this.cboSalesFilter.Edit = this.repSalesFilter;
			this.cboSalesFilter.EditWidth = 150;
			this.cboSalesFilter.Id = 41;
			this.cboSalesFilter.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cboSalesFilter.ImageOptions.SvgImage")));
			this.cboSalesFilter.Name = "cboSalesFilter";
			this.cboSalesFilter.EditValueChanged += new System.EventHandler(this.cboSalesFilter_EditValueChanged);
			// 
			// repSalesFilter
			// 
			this.repSalesFilter.AutoHeight = false;
			this.repSalesFilter.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repSalesFilter.DisplayMember = "UserName";
			this.repSalesFilter.Name = "repSalesFilter";
			this.repSalesFilter.NullText = "";
			this.repSalesFilter.PopupView = this.repositoryItemSearchLookUpEdit1View;
			this.repSalesFilter.ValueMember = "Id";
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
			this.gridColumn1.Width = 77;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Sales Name";
			this.gridColumn2.FieldName = "UserName";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			this.gridColumn2.Width = 898;
			// 
			// customersRating
			// 
			this.customersRating.Caption = "By Rating";
			this.customersRating.Edit = this.repositoryItemRatingControl1;
			this.customersRating.Id = 42;
			this.customersRating.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("customersRating.ImageOptions.SvgImage")));
			this.customersRating.Name = "customersRating";
			this.customersRating.EditValueChanged += new System.EventHandler(this.customersRating_EditValueChanged);
			// 
			// repositoryItemRatingControl1
			// 
			this.repositoryItemRatingControl1.AutoHeight = false;
			this.repositoryItemRatingControl1.Name = "repositoryItemRatingControl1";
			// 
			// btnResetGridStyle
			// 
			this.btnResetGridStyle.Caption = "Reset Grid Style";
			this.btnResetGridStyle.Id = 43;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			this.btnResetGridStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetGridStyle_ItemClick);
			// 
			// rpCustomersList
			// 
			this.rpCustomersList.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup11,
            this.ribbonPageGroup3});
			this.rpCustomersList.Name = "rpCustomersList";
			this.rpCustomersList.Text = "CUSTOMERS LIST";
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
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.cboSalesFilter);
			this.ribbonPageGroup3.ItemLinks.Add(this.customersRating);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.Text = "Filters";
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
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 682);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcCustomersList;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1448, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.gcCustomers);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1448, 489);
			this.mainLayout.TabIndex = 16;
			this.mainLayout.Text = "layoutControl1";
			// 
			// gcCustomers
			// 
			this.gcCustomers.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcCustomers.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcCustomers.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcCustomers.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcCustomers.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcCustomers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcCustomers.Location = new System.Drawing.Point(12, 12);
			this.gcCustomers.MainView = this.gvCustomers;
			this.gcCustomers.Margin = new System.Windows.Forms.Padding(14, 16, 14, 16);
			this.gcCustomers.Name = "gcCustomers";
			this.gcCustomers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDateFormat,
            this.repCountries,
            this.repCities,
            this.repCheckBox,
            this.repUsers,
            this.repMemberOf});
			this.gcCustomers.ShowOnlyPredefinedDetails = true;
			this.gcCustomers.Size = new System.Drawing.Size(1424, 465);
			this.gcCustomers.TabIndex = 4;
			this.gcCustomers.UseEmbeddedNavigator = true;
			this.gcCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomers});
			this.gcCustomers.DoubleClick += new System.EventHandler(this.gcCustomers_DoubleClick);
			// 
			// gvCustomers
			// 
			this.gvCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCustomerName,
            this.colFollowupDate,
            this.colAddress1,
            this.colPhoneNumber1,
            this.colPhoneNumber2,
            this.colPhoneNumber3,
            this.colEmail1,
            this.colWebsite,
            this.colFaxNumber,
            this.colCountryId1,
            this.colCityId1,
            this.colActivity1,
            this.colActiveDate,
            this.colActive,
            this.colIsSales,
            this.colMemberOfId,
            this.colMofNo1,
            this.colResponsibleId1,
            this.colSalesId,
            this.colNotes});
			this.gvCustomers.DetailHeight = 458;
			this.gvCustomers.DetailVerticalIndent = 13;
			this.gvCustomers.GridControl = this.gcCustomers;
			this.gvCustomers.Name = "gvCustomers";
			this.gvCustomers.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvCustomers.OptionsBehavior.Editable = false;
			this.gvCustomers.OptionsBehavior.ReadOnly = true;
			this.gvCustomers.OptionsFind.AlwaysVisible = true;
			this.gvCustomers.OptionsSelection.MultiSelect = true;
			this.gvCustomers.OptionsView.ColumnAutoWidth = false;
			this.gvCustomers.OptionsView.ShowGroupPanel = false;
			this.gvCustomers.OptionsView.ShowIndicator = false;
			this.gvCustomers.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
			this.gvCustomers.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvCustomers_RowCellStyle);
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
			// colCustomerName
			// 
			this.colCustomerName.FieldName = "CustomerName";
			this.colCustomerName.MinWidth = 25;
			this.colCustomerName.Name = "colCustomerName";
			this.colCustomerName.Visible = true;
			this.colCustomerName.VisibleIndex = 1;
			this.colCustomerName.Width = 305;
			// 
			// colFollowupDate
			// 
			this.colFollowupDate.ColumnEdit = this.repDateFormat;
			this.colFollowupDate.FieldName = "FollowupDate";
			this.colFollowupDate.MinWidth = 25;
			this.colFollowupDate.Name = "colFollowupDate";
			this.colFollowupDate.Visible = true;
			this.colFollowupDate.VisibleIndex = 2;
			this.colFollowupDate.Width = 118;
			// 
			// repDateFormat
			// 
			this.repDateFormat.AutoHeight = false;
			this.repDateFormat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repDateFormat.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repDateFormat.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repDateFormat.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.repDateFormat.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repDateFormat.Name = "repDateFormat";
			this.repDateFormat.UseMaskAsDisplayFormat = true;
			// 
			// colAddress1
			// 
			this.colAddress1.FieldName = "Address";
			this.colAddress1.MinWidth = 25;
			this.colAddress1.Name = "colAddress1";
			this.colAddress1.Visible = true;
			this.colAddress1.VisibleIndex = 3;
			this.colAddress1.Width = 343;
			// 
			// colPhoneNumber1
			// 
			this.colPhoneNumber1.FieldName = "PhoneNumber1";
			this.colPhoneNumber1.MinWidth = 25;
			this.colPhoneNumber1.Name = "colPhoneNumber1";
			this.colPhoneNumber1.Visible = true;
			this.colPhoneNumber1.VisibleIndex = 4;
			this.colPhoneNumber1.Width = 115;
			// 
			// colPhoneNumber2
			// 
			this.colPhoneNumber2.FieldName = "PhoneNumber2";
			this.colPhoneNumber2.MinWidth = 25;
			this.colPhoneNumber2.Name = "colPhoneNumber2";
			this.colPhoneNumber2.Visible = true;
			this.colPhoneNumber2.VisibleIndex = 5;
			this.colPhoneNumber2.Width = 129;
			// 
			// colPhoneNumber3
			// 
			this.colPhoneNumber3.FieldName = "PhoneNumber3";
			this.colPhoneNumber3.MinWidth = 25;
			this.colPhoneNumber3.Name = "colPhoneNumber3";
			this.colPhoneNumber3.Visible = true;
			this.colPhoneNumber3.VisibleIndex = 6;
			this.colPhoneNumber3.Width = 128;
			// 
			// colEmail1
			// 
			this.colEmail1.FieldName = "Email";
			this.colEmail1.MinWidth = 25;
			this.colEmail1.Name = "colEmail1";
			this.colEmail1.Visible = true;
			this.colEmail1.VisibleIndex = 7;
			this.colEmail1.Width = 184;
			// 
			// colWebsite
			// 
			this.colWebsite.FieldName = "Website";
			this.colWebsite.MinWidth = 25;
			this.colWebsite.Name = "colWebsite";
			this.colWebsite.Visible = true;
			this.colWebsite.VisibleIndex = 8;
			this.colWebsite.Width = 155;
			// 
			// colFaxNumber
			// 
			this.colFaxNumber.FieldName = "FaxNumber";
			this.colFaxNumber.MinWidth = 25;
			this.colFaxNumber.Name = "colFaxNumber";
			this.colFaxNumber.Visible = true;
			this.colFaxNumber.VisibleIndex = 9;
			this.colFaxNumber.Width = 143;
			// 
			// colCountryId1
			// 
			this.colCountryId1.Caption = "Country";
			this.colCountryId1.ColumnEdit = this.repCountries;
			this.colCountryId1.FieldName = "CountryId";
			this.colCountryId1.MinWidth = 25;
			this.colCountryId1.Name = "colCountryId1";
			this.colCountryId1.Visible = true;
			this.colCountryId1.VisibleIndex = 10;
			this.colCountryId1.Width = 116;
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
			// colCityId1
			// 
			this.colCityId1.Caption = "City";
			this.colCityId1.ColumnEdit = this.repCities;
			this.colCityId1.FieldName = "CityId";
			this.colCityId1.MinWidth = 25;
			this.colCityId1.Name = "colCityId1";
			this.colCityId1.Visible = true;
			this.colCityId1.VisibleIndex = 11;
			this.colCityId1.Width = 133;
			// 
			// repCities
			// 
			this.repCities.AutoHeight = false;
			this.repCities.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCities.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CityName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repCities.DisplayMember = "CityName";
			this.repCities.Name = "repCities";
			this.repCities.NullText = "";
			this.repCities.ValueMember = "Id";
			// 
			// colActivity1
			// 
			this.colActivity1.FieldName = "Activity";
			this.colActivity1.MinWidth = 25;
			this.colActivity1.Name = "colActivity1";
			this.colActivity1.Visible = true;
			this.colActivity1.VisibleIndex = 12;
			this.colActivity1.Width = 223;
			// 
			// colActiveDate
			// 
			this.colActiveDate.ColumnEdit = this.repDateFormat;
			this.colActiveDate.FieldName = "ActiveDate";
			this.colActiveDate.MinWidth = 25;
			this.colActiveDate.Name = "colActiveDate";
			this.colActiveDate.Visible = true;
			this.colActiveDate.VisibleIndex = 13;
			this.colActiveDate.Width = 94;
			// 
			// colActive
			// 
			this.colActive.ColumnEdit = this.repCheckBox;
			this.colActive.FieldName = "Active";
			this.colActive.MinWidth = 25;
			this.colActive.Name = "colActive";
			this.colActive.Visible = true;
			this.colActive.VisibleIndex = 14;
			this.colActive.Width = 94;
			// 
			// repCheckBox
			// 
			this.repCheckBox.AutoHeight = false;
			this.repCheckBox.Name = "repCheckBox";
			// 
			// colIsSales
			// 
			this.colIsSales.ColumnEdit = this.repCheckBox;
			this.colIsSales.FieldName = "IsSales";
			this.colIsSales.MinWidth = 25;
			this.colIsSales.Name = "colIsSales";
			this.colIsSales.Visible = true;
			this.colIsSales.VisibleIndex = 15;
			this.colIsSales.Width = 94;
			// 
			// colMemberOfId
			// 
			this.colMemberOfId.Caption = "Member Of";
			this.colMemberOfId.ColumnEdit = this.repMemberOf;
			this.colMemberOfId.FieldName = "MemberOfId";
			this.colMemberOfId.MinWidth = 25;
			this.colMemberOfId.Name = "colMemberOfId";
			this.colMemberOfId.Visible = true;
			this.colMemberOfId.VisibleIndex = 16;
			this.colMemberOfId.Width = 99;
			// 
			// repMemberOf
			// 
			this.repMemberOf.AutoHeight = false;
			this.repMemberOf.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repMemberOf.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repMemberOf.DisplayMember = "CustomerName";
			this.repMemberOf.Name = "repMemberOf";
			this.repMemberOf.NullText = "";
			this.repMemberOf.ValueMember = "Id";
			// 
			// colMofNo1
			// 
			this.colMofNo1.FieldName = "MofNo";
			this.colMofNo1.MinWidth = 25;
			this.colMofNo1.Name = "colMofNo1";
			this.colMofNo1.Visible = true;
			this.colMofNo1.VisibleIndex = 17;
			this.colMofNo1.Width = 122;
			// 
			// colResponsibleId1
			// 
			this.colResponsibleId1.Caption = "Responsible";
			this.colResponsibleId1.ColumnEdit = this.repUsers;
			this.colResponsibleId1.FieldName = "ResponsibleId";
			this.colResponsibleId1.MinWidth = 25;
			this.colResponsibleId1.Name = "colResponsibleId1";
			this.colResponsibleId1.Visible = true;
			this.colResponsibleId1.VisibleIndex = 18;
			this.colResponsibleId1.Width = 94;
			// 
			// repUsers
			// 
			this.repUsers.AutoHeight = false;
			this.repUsers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repUsers.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repUsers.DisplayMember = "UserName";
			this.repUsers.Name = "repUsers";
			this.repUsers.NullText = "";
			this.repUsers.ValueMember = "Id";
			// 
			// colSalesId
			// 
			this.colSalesId.Caption = "Sales";
			this.colSalesId.ColumnEdit = this.repUsers;
			this.colSalesId.FieldName = "SalesId";
			this.colSalesId.MinWidth = 25;
			this.colSalesId.Name = "colSalesId";
			this.colSalesId.Visible = true;
			this.colSalesId.VisibleIndex = 19;
			this.colSalesId.Width = 94;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 20;
			this.colNotes.Width = 389;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1448, 489);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcCustomers;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1428, 469);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// bsCustomers
			// 
			this.bsCustomers.DataSource = typeof(CustomerModel);
			// 
			// CustomersListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1448, 712);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcCustomersList);
			this.Name = "CustomersListForm";
			this.Ribbon = this.rcCustomersList;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Customers List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomersListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.rcCustomersList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSalesFilter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCountries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCities)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repMemberOf)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.Ribbon.RibbonControl rcCustomersList;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarCheckItem barCheckItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCustomersList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraGrid.GridControl gcCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colFollowupDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDateFormat;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress1;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber1;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber2;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber3;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail1;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colFaxNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryId1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCountries;
        private DevExpress.XtraGrid.Columns.GridColumn colCityId1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCities;
        private DevExpress.XtraGrid.Columns.GridColumn colActivity1;
        private DevExpress.XtraGrid.Columns.GridColumn colActiveDate;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSales;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckBox;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberOfId;
        private DevExpress.XtraGrid.Columns.GridColumn colMofNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colResponsibleId1;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesId;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bsCustomers;
        private DevExpress.XtraBars.BarEditItem cboSalesFilter;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSalesFilter;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repUsers;
        private DevExpress.XtraBars.BarEditItem customersRating;
        private DevExpress.XtraEditors.Repository.RepositoryItemRatingControl repositoryItemRatingControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repMemberOf;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
	}
}