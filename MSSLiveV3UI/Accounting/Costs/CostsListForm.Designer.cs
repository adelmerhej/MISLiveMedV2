using MISLiveMed.Models.Models.Accounting.CostSheets;

namespace MISLiveMed.UI.Accounting.Costs
{
    partial class CostsListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostsListForm));
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges1 = new DevExpress.Skins.SkinPaddingEdges();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges2 = new DevExpress.Skins.SkinPaddingEdges();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges3 = new DevExpress.Skins.SkinPaddingEdges();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges4 = new DevExpress.Skins.SkinPaddingEdges();
			this.bsCosts = new System.Windows.Forms.BindingSource(this.components);
			this.rcCosts = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.rgFilterReports = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
			this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.cboDepartments = new DevExpress.XtraBars.BarEditItem();
			this.cboSalesList = new DevExpress.XtraBars.BarEditItem();
			this.cboStatus = new DevExpress.XtraBars.BarEditItem();
			this.chkShowProfit = new DevExpress.XtraBars.BarCheckItem();
			this.chkSortByBookedDate = new DevExpress.XtraBars.BarCheckItem();
			this.barCheckItem8 = new DevExpress.XtraBars.BarCheckItem();
			this.rgSortByReports = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.rpCosts = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgPermissions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.gcCosts = new DevExpress.XtraGrid.GridControl();
			this.gvCosts = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSheetNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJobId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOperationTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMemberId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPaymentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrencyRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colInvoiceRef = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDisplayProvisionColumns = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProvisionTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLProvisionTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFProvisionTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPaid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLocked = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPosted = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colClosed = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colClosedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCanceled = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCanceledDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJvId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLastModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLastModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsProtected = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsDefault = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.repMemberCategories = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repGridDepartmentList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.repUsersList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repSalesList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repMembersList = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.repPOLPortCodeList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repPODPortCodeList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.chkActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.chkJobActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.repMainRegionsList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repContinents = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.bsCosts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rcCosts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcCosts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCosts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repMemberCategories)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repGridDepartmentList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsersList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSalesList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repMembersList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repPOLPortCodeList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repPODPortCodeList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkActive)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkJobActive)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repMainRegionsList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repContinents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// bsCosts
			// 
			this.bsCosts.DataSource = typeof(CostModel);
			// 
			// rcCosts
			// 
			this.rcCosts.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcCosts.ExpandCollapseItem.Id = 0;
			this.rcCosts.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcCosts.ExpandCollapseItem,
            this.btnNew,
            this.btnDelete,
            this.btnEdit,
            this.btnPrint,
            this.rgFilterReports,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barHeaderItem1,
            this.btnRefresh,
            this.btnClose,
            this.cboDepartments,
            this.cboSalesList,
            this.cboStatus,
            this.chkShowProfit,
            this.chkSortByBookedDate,
            this.barCheckItem8,
            this.rgSortByReports,
            this.btnResetGridStyle});
			this.rcCosts.Location = new System.Drawing.Point(0, 0);
			this.rcCosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcCosts.MaxItemId = 59;
			this.rcCosts.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.rcCosts.Name = "rcCosts";
			this.rcCosts.OptionsMenuMinWidth = 385;
			this.rcCosts.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpCosts,
            this.rpViewSettings});
			this.rcCosts.Size = new System.Drawing.Size(1436, 193);
			this.rcCosts.StatusBar = this.ribbonStatusBar1;
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
			this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick_1);
			// 
			// btnDelete
			// 
			this.btnDelete.Caption = "Cancel";
			this.btnDelete.Enabled = false;
			this.btnDelete.Id = 3;
			this.btnDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnDelete.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg";
			this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick_1);
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
			this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick_1);
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
			this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick_1);
			// 
			// rgFilterReports
			// 
			this.rgFilterReports.Caption = "Quick Reports";
			// 
			// 
			// 
			this.rgFilterReports.Gallery.ColumnCount = 2;
			this.rgFilterReports.Gallery.DrawImageBackground = false;
			galleryItemGroup1.Caption = "FilterGroup";
			galleryItem1.Caption = "Booked Quotations";
			galleryItem1.Checked = true;
			galleryItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
			galleryItem1.Value = "showBooked";
			galleryItem2.Caption = "Cancelled Quotations";
			galleryItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
			galleryItem2.Value = "showCancelled";
			galleryItem3.Caption = "Lost Quotations";
			galleryItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
			galleryItem3.Value = "showLost";
			galleryItem4.Caption = "All";
			galleryItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage3")));
			galleryItem4.Value = "showAll";
			galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4});
			this.rgFilterReports.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
			this.rgFilterReports.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck;
			this.rgFilterReports.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
			skinPaddingEdges1.Bottom = -4;
			skinPaddingEdges1.Top = -4;
			this.rgFilterReports.Gallery.ItemImagePadding = skinPaddingEdges1;
			skinPaddingEdges2.Bottom = -1;
			skinPaddingEdges2.Top = -1;
			this.rgFilterReports.Gallery.ItemTextPadding = skinPaddingEdges2;
			this.rgFilterReports.Gallery.ShowItemText = true;
			this.rgFilterReports.Id = 17;
			this.rgFilterReports.Name = "rgFilterReports";
			// 
			// barButtonItem11
			// 
			this.barButtonItem11.Caption = "View Settings";
			this.barButtonItem11.Id = 22;
			this.barButtonItem11.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem11.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ViewSetting.svg";
			this.barButtonItem11.Name = "barButtonItem11";
			// 
			// barButtonItem12
			// 
			this.barButtonItem12.Caption = "Reset View";
			this.barButtonItem12.Id = 23;
			this.barButtonItem12.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem12.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ResetView.svg";
			this.barButtonItem12.Name = "barButtonItem12";
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
			this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick_1);
			// 
			// btnClose
			// 
			this.btnClose.Caption = "Close";
			this.btnClose.Id = 38;
			this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
			this.btnClose.Name = "btnClose";
			this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick_1);
			// 
			// cboDepartments
			// 
			this.cboDepartments.Caption = "By Departments";
			this.cboDepartments.CaptionToEditorIndent = 6;
			this.cboDepartments.Edit = null;
			this.cboDepartments.EditWidth = 150;
			this.cboDepartments.Id = 39;
			this.cboDepartments.Name = "cboDepartments";
			// 
			// cboSalesList
			// 
			this.cboSalesList.Caption = "By Sales";
			this.cboSalesList.CaptionToEditorIndent = 40;
			this.cboSalesList.Edit = null;
			this.cboSalesList.EditWidth = 150;
			this.cboSalesList.Id = 40;
			this.cboSalesList.Name = "cboSalesList";
			// 
			// cboStatus
			// 
			this.cboStatus.Caption = "By Status";
			this.cboStatus.CaptionToEditorIndent = 37;
			this.cboStatus.Edit = null;
			this.cboStatus.EditWidth = 150;
			this.cboStatus.Id = 44;
			this.cboStatus.Name = "cboStatus";
			// 
			// chkShowProfit
			// 
			this.chkShowProfit.Caption = "Show Profit";
			this.chkShowProfit.Enabled = false;
			this.chkShowProfit.Id = 45;
			this.chkShowProfit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("chkShowProfit.ImageOptions.SvgImage")));
			this.chkShowProfit.Name = "chkShowProfit";
			this.chkShowProfit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			// 
			// chkSortByBookedDate
			// 
			this.chkSortByBookedDate.Caption = "Sort By Booked Date";
			this.chkSortByBookedDate.Id = 51;
			this.chkSortByBookedDate.Name = "chkSortByBookedDate";
			// 
			// barCheckItem8
			// 
			this.barCheckItem8.Caption = "Sort By Followup Date";
			this.barCheckItem8.Id = 52;
			this.barCheckItem8.Name = "barCheckItem8";
			// 
			// rgSortByReports
			// 
			this.rgSortByReports.Caption = "SortBy Reports";
			// 
			// 
			// 
			this.rgSortByReports.Gallery.ColumnCount = 1;
			this.rgSortByReports.Gallery.DrawImageBackground = false;
			galleryItemGroup2.Caption = "groupSortingBy";
			galleryItem5.Caption = "Sort By Booked Date";
			galleryItem5.Checked = true;
			galleryItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage4")));
			galleryItem5.Value = "SortByBookedDate";
			galleryItem6.Caption = "Sort By Follow";
			galleryItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage5")));
			galleryItem6.Value = "SortByFollowingDate";
			galleryItemGroup2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem5,
            galleryItem6});
			this.rgSortByReports.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup2});
			this.rgSortByReports.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck;
			this.rgSortByReports.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
			skinPaddingEdges3.Bottom = -4;
			skinPaddingEdges3.Top = -4;
			this.rgSortByReports.Gallery.ItemImagePadding = skinPaddingEdges3;
			skinPaddingEdges4.Bottom = -1;
			skinPaddingEdges4.Top = -1;
			this.rgSortByReports.Gallery.ItemTextPadding = skinPaddingEdges4;
			this.rgSortByReports.Gallery.ShowItemText = true;
			this.rgSortByReports.Id = 57;
			this.rgSortByReports.Name = "rgSortByReports";
			// 
			// btnResetGridStyle
			// 
			this.btnResetGridStyle.Caption = "Reset Grid Style";
			this.btnResetGridStyle.Id = 58;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			this.btnResetGridStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetGridStyle_ItemClick);
			// 
			// rpCosts
			// 
			this.rpCosts.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup2,
            this.rpgPermissions,
            this.ribbonPageGroup11});
			this.rpCosts.Name = "rpCosts";
			this.rpCosts.Text = "COSTSHEETS";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.AllowTextClipping = false;
			this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup1.ItemLinks.Add(this.btnNew);
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
			this.ribbonPageGroup6.Name = "ribbonPageGroup6";
			this.ribbonPageGroup6.Text = "Actions";
			// 
			// ribbonPageGroup8
			// 
			this.ribbonPageGroup8.AllowTextClipping = false;
			this.ribbonPageGroup8.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup8.ItemLinks.Add(this.btnDelete);
			this.ribbonPageGroup8.Name = "ribbonPageGroup8";
			this.ribbonPageGroup8.Text = "Delete";
			// 
			// ribbonPageGroup9
			// 
			this.ribbonPageGroup9.AllowTextClipping = false;
			this.ribbonPageGroup9.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup9.ItemLinks.Add(this.rgFilterReports);
			this.ribbonPageGroup9.Name = "ribbonPageGroup9";
			this.ribbonPageGroup9.Text = "Filter Reports";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.AllowTextClipping = false;
			this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup2.ItemLinks.Add(this.rgSortByReports);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "SortBy Reports";
			// 
			// rpgPermissions
			// 
			this.rpgPermissions.ItemLinks.Add(this.chkShowProfit);
			this.rpgPermissions.Name = "rpgPermissions";
			this.rpgPermissions.Text = "Permissions";
			this.rpgPermissions.Visible = false;
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
            this.ribbonPageGroup3});
			this.rpViewSettings.Name = "rpViewSettings";
			this.rpViewSettings.Text = "VIEW SETTINGS";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.btnResetGridStyle);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.Text = "Grid Settings";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 761);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcCosts;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1436, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.gcCosts);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1436, 568);
			this.mainLayout.TabIndex = 12;
			this.mainLayout.Text = "layoutControl1";
			// 
			// gcCosts
			// 
			this.gcCosts.DataSource = this.bsCosts;
			this.gcCosts.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcCosts.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcCosts.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcCosts.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcCosts.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcCosts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcCosts.Location = new System.Drawing.Point(12, 12);
			this.gcCosts.MainView = this.gvCosts;
			this.gcCosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcCosts.Name = "gcCosts";
			this.gcCosts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
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
            this.repMainRegionsList,
            this.repContinents});
			this.gcCosts.Size = new System.Drawing.Size(1412, 544);
			this.gcCosts.TabIndex = 5;
			this.gcCosts.UseEmbeddedNavigator = true;
			this.gcCosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCosts});
			this.gcCosts.DoubleClick += new System.EventHandler(this.gcCosts_DoubleClick);
			// 
			// gvCosts
			// 
			this.gvCosts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSheetNo,
            this.colCostDate,
            this.colDepartmentId,
            this.colJobId,
            this.colOperationTypeId,
            this.colMemberId,
            this.colPaymentId,
            this.colCurrencyId,
            this.colCurrencyRate,
            this.colInvoiceNo,
            this.colInvoiceDate,
            this.colInvoiceRef,
            this.colTotalAmount,
            this.colLTotalAmount,
            this.colFTotalAmount,
            this.colDisplayProvisionColumns,
            this.colProvisionTotalAmount,
            this.colLProvisionTotalAmount,
            this.colFProvisionTotalAmount,
            this.colPaid,
            this.colLocked,
            this.colPosted,
            this.colClosed,
            this.colClosedDate,
            this.colCanceled,
            this.colCanceledDate,
            this.colJvId,
            this.colCompanyId,
            this.colNotes,
            this.colCreatedBy,
            this.colCreatedDate,
            this.colLastModifiedBy,
            this.colLastModifiedDate,
            this.colIsProtected,
            this.colIsDefault,
            this.colActive,
            this.colDeleted});
			this.gvCosts.DetailHeight = 458;
			this.gvCosts.GridControl = this.gcCosts;
			this.gvCosts.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", null, "")});
			this.gvCosts.Name = "gvCosts";
			this.gvCosts.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.gvCosts.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvCosts.OptionsBehavior.Editable = false;
			this.gvCosts.OptionsFind.AlwaysVisible = true;
			this.gvCosts.OptionsPrint.AutoWidth = false;
			this.gvCosts.OptionsPrint.PrintHorzLines = false;
			this.gvCosts.OptionsPrint.PrintVertLines = false;
			this.gvCosts.OptionsView.ColumnAutoWidth = false;
			this.gvCosts.OptionsView.ShowFooter = true;
			this.gvCosts.OptionsView.ShowGroupedColumns = true;
			this.gvCosts.OptionsView.ShowGroupPanel = false;
			this.gvCosts.OptionsView.ShowIndicator = false;
			this.gvCosts.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
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
			// colSheetNo
			// 
			this.colSheetNo.FieldName = "SheetNo";
			this.colSheetNo.MinWidth = 25;
			this.colSheetNo.Name = "colSheetNo";
			this.colSheetNo.Visible = true;
			this.colSheetNo.VisibleIndex = 1;
			this.colSheetNo.Width = 94;
			// 
			// colCostDate
			// 
			this.colCostDate.FieldName = "CostDate";
			this.colCostDate.MinWidth = 25;
			this.colCostDate.Name = "colCostDate";
			this.colCostDate.Visible = true;
			this.colCostDate.VisibleIndex = 2;
			this.colCostDate.Width = 94;
			// 
			// colDepartmentId
			// 
			this.colDepartmentId.FieldName = "DepartmentId";
			this.colDepartmentId.MinWidth = 25;
			this.colDepartmentId.Name = "colDepartmentId";
			this.colDepartmentId.Visible = true;
			this.colDepartmentId.VisibleIndex = 3;
			this.colDepartmentId.Width = 94;
			// 
			// colJobId
			// 
			this.colJobId.FieldName = "JobId";
			this.colJobId.MinWidth = 25;
			this.colJobId.Name = "colJobId";
			this.colJobId.Visible = true;
			this.colJobId.VisibleIndex = 4;
			this.colJobId.Width = 94;
			// 
			// colOperationTypeId
			// 
			this.colOperationTypeId.FieldName = "OperationTypeId";
			this.colOperationTypeId.MinWidth = 25;
			this.colOperationTypeId.Name = "colOperationTypeId";
			this.colOperationTypeId.Visible = true;
			this.colOperationTypeId.VisibleIndex = 5;
			this.colOperationTypeId.Width = 94;
			// 
			// colMemberId
			// 
			this.colMemberId.FieldName = "MemberId";
			this.colMemberId.MinWidth = 25;
			this.colMemberId.Name = "colMemberId";
			this.colMemberId.Visible = true;
			this.colMemberId.VisibleIndex = 6;
			this.colMemberId.Width = 94;
			// 
			// colPaymentId
			// 
			this.colPaymentId.FieldName = "PaymentId";
			this.colPaymentId.MinWidth = 25;
			this.colPaymentId.Name = "colPaymentId";
			this.colPaymentId.Visible = true;
			this.colPaymentId.VisibleIndex = 7;
			this.colPaymentId.Width = 94;
			// 
			// colCurrencyId
			// 
			this.colCurrencyId.FieldName = "CurrencyId";
			this.colCurrencyId.MinWidth = 25;
			this.colCurrencyId.Name = "colCurrencyId";
			this.colCurrencyId.Visible = true;
			this.colCurrencyId.VisibleIndex = 8;
			this.colCurrencyId.Width = 94;
			// 
			// colCurrencyRate
			// 
			this.colCurrencyRate.FieldName = "CurrencyRate";
			this.colCurrencyRate.MinWidth = 25;
			this.colCurrencyRate.Name = "colCurrencyRate";
			this.colCurrencyRate.Visible = true;
			this.colCurrencyRate.VisibleIndex = 9;
			this.colCurrencyRate.Width = 94;
			// 
			// colInvoiceNo
			// 
			this.colInvoiceNo.FieldName = "InvoiceNo";
			this.colInvoiceNo.MinWidth = 25;
			this.colInvoiceNo.Name = "colInvoiceNo";
			this.colInvoiceNo.Visible = true;
			this.colInvoiceNo.VisibleIndex = 10;
			this.colInvoiceNo.Width = 94;
			// 
			// colInvoiceDate
			// 
			this.colInvoiceDate.FieldName = "InvoiceDate";
			this.colInvoiceDate.MinWidth = 25;
			this.colInvoiceDate.Name = "colInvoiceDate";
			this.colInvoiceDate.Visible = true;
			this.colInvoiceDate.VisibleIndex = 11;
			this.colInvoiceDate.Width = 94;
			// 
			// colInvoiceRef
			// 
			this.colInvoiceRef.FieldName = "InvoiceRef";
			this.colInvoiceRef.MinWidth = 25;
			this.colInvoiceRef.Name = "colInvoiceRef";
			this.colInvoiceRef.Visible = true;
			this.colInvoiceRef.VisibleIndex = 12;
			this.colInvoiceRef.Width = 94;
			// 
			// colTotalAmount
			// 
			this.colTotalAmount.FieldName = "TotalAmount";
			this.colTotalAmount.MinWidth = 25;
			this.colTotalAmount.Name = "colTotalAmount";
			this.colTotalAmount.Visible = true;
			this.colTotalAmount.VisibleIndex = 13;
			this.colTotalAmount.Width = 94;
			// 
			// colLTotalAmount
			// 
			this.colLTotalAmount.FieldName = "LTotalAmount";
			this.colLTotalAmount.MinWidth = 25;
			this.colLTotalAmount.Name = "colLTotalAmount";
			this.colLTotalAmount.Visible = true;
			this.colLTotalAmount.VisibleIndex = 14;
			this.colLTotalAmount.Width = 94;
			// 
			// colFTotalAmount
			// 
			this.colFTotalAmount.FieldName = "FTotalAmount";
			this.colFTotalAmount.MinWidth = 25;
			this.colFTotalAmount.Name = "colFTotalAmount";
			this.colFTotalAmount.Visible = true;
			this.colFTotalAmount.VisibleIndex = 15;
			this.colFTotalAmount.Width = 94;
			// 
			// colDisplayProvisionColumns
			// 
			this.colDisplayProvisionColumns.FieldName = "DisplayProvisionColumns";
			this.colDisplayProvisionColumns.MinWidth = 25;
			this.colDisplayProvisionColumns.Name = "colDisplayProvisionColumns";
			this.colDisplayProvisionColumns.Visible = true;
			this.colDisplayProvisionColumns.VisibleIndex = 16;
			this.colDisplayProvisionColumns.Width = 94;
			// 
			// colProvisionTotalAmount
			// 
			this.colProvisionTotalAmount.FieldName = "ProvisionTotalAmount";
			this.colProvisionTotalAmount.MinWidth = 25;
			this.colProvisionTotalAmount.Name = "colProvisionTotalAmount";
			this.colProvisionTotalAmount.Visible = true;
			this.colProvisionTotalAmount.VisibleIndex = 17;
			this.colProvisionTotalAmount.Width = 94;
			// 
			// colLProvisionTotalAmount
			// 
			this.colLProvisionTotalAmount.FieldName = "LProvisionTotalAmount";
			this.colLProvisionTotalAmount.MinWidth = 25;
			this.colLProvisionTotalAmount.Name = "colLProvisionTotalAmount";
			this.colLProvisionTotalAmount.Visible = true;
			this.colLProvisionTotalAmount.VisibleIndex = 18;
			this.colLProvisionTotalAmount.Width = 94;
			// 
			// colFProvisionTotalAmount
			// 
			this.colFProvisionTotalAmount.FieldName = "FProvisionTotalAmount";
			this.colFProvisionTotalAmount.MinWidth = 25;
			this.colFProvisionTotalAmount.Name = "colFProvisionTotalAmount";
			this.colFProvisionTotalAmount.Visible = true;
			this.colFProvisionTotalAmount.VisibleIndex = 19;
			this.colFProvisionTotalAmount.Width = 94;
			// 
			// colPaid
			// 
			this.colPaid.FieldName = "Paid";
			this.colPaid.MinWidth = 25;
			this.colPaid.Name = "colPaid";
			this.colPaid.Visible = true;
			this.colPaid.VisibleIndex = 20;
			this.colPaid.Width = 94;
			// 
			// colLocked
			// 
			this.colLocked.FieldName = "Locked";
			this.colLocked.MinWidth = 25;
			this.colLocked.Name = "colLocked";
			this.colLocked.Visible = true;
			this.colLocked.VisibleIndex = 21;
			this.colLocked.Width = 94;
			// 
			// colPosted
			// 
			this.colPosted.FieldName = "Posted";
			this.colPosted.MinWidth = 25;
			this.colPosted.Name = "colPosted";
			this.colPosted.Visible = true;
			this.colPosted.VisibleIndex = 22;
			this.colPosted.Width = 94;
			// 
			// colClosed
			// 
			this.colClosed.FieldName = "Closed";
			this.colClosed.MinWidth = 25;
			this.colClosed.Name = "colClosed";
			this.colClosed.Visible = true;
			this.colClosed.VisibleIndex = 23;
			this.colClosed.Width = 94;
			// 
			// colClosedDate
			// 
			this.colClosedDate.FieldName = "ClosedDate";
			this.colClosedDate.MinWidth = 25;
			this.colClosedDate.Name = "colClosedDate";
			this.colClosedDate.Visible = true;
			this.colClosedDate.VisibleIndex = 24;
			this.colClosedDate.Width = 94;
			// 
			// colCanceled
			// 
			this.colCanceled.FieldName = "Canceled";
			this.colCanceled.MinWidth = 25;
			this.colCanceled.Name = "colCanceled";
			this.colCanceled.Visible = true;
			this.colCanceled.VisibleIndex = 25;
			this.colCanceled.Width = 94;
			// 
			// colCanceledDate
			// 
			this.colCanceledDate.FieldName = "CanceledDate";
			this.colCanceledDate.MinWidth = 25;
			this.colCanceledDate.Name = "colCanceledDate";
			this.colCanceledDate.Visible = true;
			this.colCanceledDate.VisibleIndex = 26;
			this.colCanceledDate.Width = 94;
			// 
			// colJvId
			// 
			this.colJvId.FieldName = "JvId";
			this.colJvId.MinWidth = 25;
			this.colJvId.Name = "colJvId";
			this.colJvId.Visible = true;
			this.colJvId.VisibleIndex = 27;
			this.colJvId.Width = 94;
			// 
			// colCompanyId
			// 
			this.colCompanyId.FieldName = "CompanyId";
			this.colCompanyId.MinWidth = 25;
			this.colCompanyId.Name = "colCompanyId";
			this.colCompanyId.Visible = true;
			this.colCompanyId.VisibleIndex = 28;
			this.colCompanyId.Width = 94;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 29;
			this.colNotes.Width = 94;
			// 
			// colCreatedBy
			// 
			this.colCreatedBy.FieldName = "CreatedBy";
			this.colCreatedBy.MinWidth = 25;
			this.colCreatedBy.Name = "colCreatedBy";
			this.colCreatedBy.Visible = true;
			this.colCreatedBy.VisibleIndex = 30;
			this.colCreatedBy.Width = 94;
			// 
			// colCreatedDate
			// 
			this.colCreatedDate.FieldName = "CreatedDate";
			this.colCreatedDate.MinWidth = 25;
			this.colCreatedDate.Name = "colCreatedDate";
			this.colCreatedDate.Visible = true;
			this.colCreatedDate.VisibleIndex = 31;
			this.colCreatedDate.Width = 94;
			// 
			// colLastModifiedBy
			// 
			this.colLastModifiedBy.FieldName = "LastModifiedBy";
			this.colLastModifiedBy.MinWidth = 25;
			this.colLastModifiedBy.Name = "colLastModifiedBy";
			this.colLastModifiedBy.Visible = true;
			this.colLastModifiedBy.VisibleIndex = 32;
			this.colLastModifiedBy.Width = 94;
			// 
			// colLastModifiedDate
			// 
			this.colLastModifiedDate.FieldName = "LastModifiedDate";
			this.colLastModifiedDate.MinWidth = 25;
			this.colLastModifiedDate.Name = "colLastModifiedDate";
			this.colLastModifiedDate.Visible = true;
			this.colLastModifiedDate.VisibleIndex = 33;
			this.colLastModifiedDate.Width = 94;
			// 
			// colIsProtected
			// 
			this.colIsProtected.FieldName = "IsProtected";
			this.colIsProtected.MinWidth = 25;
			this.colIsProtected.Name = "colIsProtected";
			this.colIsProtected.Visible = true;
			this.colIsProtected.VisibleIndex = 34;
			this.colIsProtected.Width = 94;
			// 
			// colIsDefault
			// 
			this.colIsDefault.FieldName = "IsDefault";
			this.colIsDefault.MinWidth = 25;
			this.colIsDefault.Name = "colIsDefault";
			this.colIsDefault.Visible = true;
			this.colIsDefault.VisibleIndex = 35;
			this.colIsDefault.Width = 94;
			// 
			// colActive
			// 
			this.colActive.FieldName = "Active";
			this.colActive.MinWidth = 25;
			this.colActive.Name = "colActive";
			this.colActive.Visible = true;
			this.colActive.VisibleIndex = 36;
			this.colActive.Width = 94;
			// 
			// colDeleted
			// 
			this.colDeleted.FieldName = "Deleted";
			this.colDeleted.MinWidth = 25;
			this.colDeleted.Name = "colDeleted";
			this.colDeleted.Visible = true;
			this.colDeleted.VisibleIndex = 37;
			this.colDeleted.Width = 94;
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
			this.repMembersList.ValueMember = "Id";
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
			// chkActive
			// 
			this.chkActive.AutoHeight = false;
			this.chkActive.Name = "chkActive";
			// 
			// chkJobActive
			// 
			this.chkJobActive.AutoHeight = false;
			this.chkJobActive.Name = "chkJobActive";
			// 
			// repMainRegionsList
			// 
			this.repMainRegionsList.AutoHeight = false;
			this.repMainRegionsList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repMainRegionsList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repMainRegionsList.DisplayMember = "Name";
			this.repMainRegionsList.Name = "repMainRegionsList";
			this.repMainRegionsList.NullText = "";
			this.repMainRegionsList.ValueMember = "Id";
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
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1436, 568);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcCosts;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1416, 548);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// CostsListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1436, 791);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcCosts);
			this.Name = "CostsListForm";
			this.Ribbon = this.rcCosts;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Costs List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CostsListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.bsCosts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rcCosts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcCosts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCosts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repMemberCategories)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repGridDepartmentList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsersList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSalesList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repMembersList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repPOLPortCodeList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repPODPortCodeList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkActive)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkJobActive)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repMainRegionsList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repContinents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsCosts;
        public DevExpress.XtraBars.Ribbon.RibbonControl rcCosts;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgFilterReports;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarEditItem cboDepartments;
        private DevExpress.XtraBars.BarEditItem cboSalesList;
        private DevExpress.XtraBars.BarEditItem cboStatus;
        private DevExpress.XtraBars.BarCheckItem chkShowProfit;
        private DevExpress.XtraBars.BarCheckItem chkSortByBookedDate;
        private DevExpress.XtraBars.BarCheckItem barCheckItem8;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgSortByReports;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCosts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPermissions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraGrid.GridControl gcCosts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCosts;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repMemberCategories;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repGridDepartmentList;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repUsersList;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repSalesList;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repMembersList;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repPOLPortCodeList;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repPODPortCodeList;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkJobActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repMainRegionsList;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repContinents;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSheetNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCostDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colJobId;
        private DevExpress.XtraGrid.Columns.GridColumn colOperationTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberId;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentId;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyId;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyRate;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceRef;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colLTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colFTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayProvisionColumns;
        private DevExpress.XtraGrid.Columns.GridColumn colProvisionTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colLProvisionTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colFProvisionTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colLocked;
        private DevExpress.XtraGrid.Columns.GridColumn colPosted;
        private DevExpress.XtraGrid.Columns.GridColumn colClosed;
        private DevExpress.XtraGrid.Columns.GridColumn colClosedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCanceled;
        private DevExpress.XtraGrid.Columns.GridColumn colCanceledDate;
        private DevExpress.XtraGrid.Columns.GridColumn colJvId;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsProtected;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDefault;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
	}
}