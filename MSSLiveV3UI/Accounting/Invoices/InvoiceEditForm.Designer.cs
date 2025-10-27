using MISLiveMed.Models.Models.Accounting.Invoices;

namespace MISLiveMed.UI.Accounting.Invoices
{
    partial class InvoiceEditForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceEditForm));
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges1 = new DevExpress.Skins.SkinPaddingEdges();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges2 = new DevExpress.Skins.SkinPaddingEdges();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnSave = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.btnSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.biMailMerge = new DevExpress.XtraBars.BarButtonItem();
			this.biMeeting = new DevExpress.XtraBars.BarButtonItem();
			this.bmiPrintProfile = new DevExpress.XtraBars.BarButtonItem();
			this.bmiPrintSummary = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.bmiPrintDirectory = new DevExpress.XtraBars.BarButtonItem();
			this.bmiPrintTaskList = new DevExpress.XtraBars.BarButtonItem();
			this.galleryQuickLetters = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.biShowMap = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.rgJobStatusAction = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.rpMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.bsInvoice = new System.Windows.Forms.BindingSource(this.components);
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.txtNotes = new DevExpress.XtraEditors.MemoEdit();
			this.txtRate = new DevExpress.XtraEditors.TextEdit();
			this.cboCurrencies = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCurrenciesId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrenciesCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrenciesName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtAttention = new DevExpress.XtraEditors.TextEdit();
			this.cboCustomers = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCustomersId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCustomersName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtJobCode = new DevExpress.XtraEditors.TextEdit();
			this.cboJobs = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colJobId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJobCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJobJobName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtReference = new DevExpress.XtraEditors.TextEdit();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.gcInvoiceDetails = new DevExpress.XtraGrid.GridControl();
			this.gvInvoiceDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colInvoiceId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemId1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repItems = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVAT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVATRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVATValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAllowEdit = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLocked = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.dtInvoiceDate = new DevExpress.XtraEditors.DateEdit();
			this.txtTotalCommission = new DevExpress.XtraEditors.TextEdit();
			this.txtTotalCostVat = new DevExpress.XtraEditors.TextEdit();
			this.txtTotalCostUSD = new DevExpress.XtraEditors.TextEdit();
			this.txtInvocieNo = new DevExpress.XtraEditors.TextEdit();
			this.cboIssuers = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colIssuerId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIssuerCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIssuerName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.grpTotals = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblSubTotal = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblTotalCostVat = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblTotalCommission = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblNotes = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblInvocieNo = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblIssuers = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblInvoiceDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblReference = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblJobCode = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblJobs = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblCustomers = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblAttention = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblCurrencies = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblRate = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsInvoice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCurrencies.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAttention.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCustomers.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtJobCode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboJobs.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcInvoiceDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvInvoiceDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalCommission.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalCostVat.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalCostUSD.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtInvocieNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboIssuers.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpTotals)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSubTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalCostVat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalCommission)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNotes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblInvocieNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblIssuers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblInvoiceDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblReference)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJobCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJobs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAttention)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCurrencies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl
			// 
			this.ribbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnSave,
            this.btnClose,
            this.btnSaveAndClose,
            this.btnDelete,
            this.biMailMerge,
            this.biMeeting,
            this.bmiPrintProfile,
            this.bmiPrintSummary,
            this.btnPrint,
            this.bmiPrintDirectory,
            this.bmiPrintTaskList,
            this.galleryQuickLetters,
            this.biShowMap,
            this.btnRefresh,
            this.btnNew,
            this.rgJobStatusAction,
            this.btnResetGridStyle});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ribbonControl.MaxItemId = 25;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.OptionsMenuMinWidth = 385;
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpMain,
            this.rpViewSettings});
			this.ribbonControl.Size = new System.Drawing.Size(1431, 197);
			this.ribbonControl.StatusBar = this.ribbonStatusBar1;
			// 
			// btnSave
			// 
			this.btnSave.Caption = "Save";
			this.btnSave.Enabled = false;
			this.btnSave.Id = 1;
			this.btnSave.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnSave.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Save.svg";
			this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
			this.btnSave.Name = "btnSave";
			this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
			// 
			// btnClose
			// 
			this.btnClose.Caption = "Close";
			this.btnClose.Id = 2;
			this.btnClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnClose.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg";
			this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
			this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape);
			this.btnClose.Name = "btnClose";
			this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
			// 
			// btnSaveAndClose
			// 
			this.btnSaveAndClose.Caption = "Save && Close";
			this.btnSaveAndClose.Enabled = false;
			this.btnSaveAndClose.Id = 3;
			this.btnSaveAndClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnSaveAndClose.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SaveAndClose.svg";
			this.btnSaveAndClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveAndClose.ImageOptions.SvgImage")));
			this.btnSaveAndClose.Name = "btnSaveAndClose";
			this.btnSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAndClose_ItemClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Caption = "Delete";
			this.btnDelete.Enabled = false;
			this.btnDelete.Id = 4;
			this.btnDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnDelete.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg";
			this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
			// 
			// biMailMerge
			// 
			this.biMailMerge.Caption = "Mail Merge";
			this.biMailMerge.Id = 5;
			this.biMailMerge.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.biMailMerge.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.MailMerge.svg";
			this.biMailMerge.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biMailMerge.ImageOptions.SvgImage")));
			this.biMailMerge.Name = "biMailMerge";
			this.biMailMerge.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			this.biMailMerge.VisibleInSearchMenu = false;
			// 
			// biMeeting
			// 
			this.biMeeting.Caption = "Meeting";
			this.biMeeting.Id = 6;
			this.biMeeting.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.biMeeting.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Meeting.svg";
			this.biMeeting.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biMeeting.ImageOptions.SvgImage")));
			this.biMeeting.Name = "biMeeting";
			this.biMeeting.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			this.biMeeting.VisibleInSearchMenu = false;
			// 
			// bmiPrintProfile
			// 
			this.bmiPrintProfile.Caption = "Employee Profile";
			this.bmiPrintProfile.Id = 9;
			this.bmiPrintProfile.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.bmiPrintProfile.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.EmployeeCard.svg?Size=16x16";
			this.bmiPrintProfile.Name = "bmiPrintProfile";
			// 
			// bmiPrintSummary
			// 
			this.bmiPrintSummary.Caption = "Summary Report";
			this.bmiPrintSummary.Id = 10;
			this.bmiPrintSummary.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.bmiPrintSummary.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Summary.svg?Size=16x16";
			this.bmiPrintSummary.Name = "bmiPrintSummary";
			// 
			// btnPrint
			// 
			this.btnPrint.Caption = "Print";
			this.btnPrint.Enabled = false;
			this.btnPrint.Id = 11;
			this.btnPrint.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Task.svg";
			this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
			// 
			// bmiPrintDirectory
			// 
			this.bmiPrintDirectory.Caption = "Directory";
			this.bmiPrintDirectory.Id = 12;
			this.bmiPrintDirectory.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.bmiPrintDirectory.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.EmployeeDirectory.svg?Size=16x16";
			this.bmiPrintDirectory.Name = "bmiPrintDirectory";
			// 
			// bmiPrintTaskList
			// 
			this.bmiPrintTaskList.Caption = "Task List";
			this.bmiPrintTaskList.Id = 13;
			this.bmiPrintTaskList.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.bmiPrintTaskList.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.TaskList.svg?Size=16x16";
			this.bmiPrintTaskList.Name = "bmiPrintTaskList";
			// 
			// galleryQuickLetters
			// 
			this.galleryQuickLetters.Caption = "Quick Letters";
			// 
			// 
			// 
			this.galleryQuickLetters.Gallery.ColumnCount = 2;
			this.galleryQuickLetters.Gallery.DrawImageBackground = false;
			galleryItemGroup1.Caption = "Group1";
			this.galleryQuickLetters.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
			this.galleryQuickLetters.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
			skinPaddingEdges1.Bottom = -4;
			skinPaddingEdges1.Top = -4;
			this.galleryQuickLetters.Gallery.ItemImagePadding = skinPaddingEdges1;
			skinPaddingEdges2.Bottom = -1;
			skinPaddingEdges2.Top = -1;
			this.galleryQuickLetters.Gallery.ItemTextPadding = skinPaddingEdges2;
			this.galleryQuickLetters.Gallery.ShowItemText = true;
			this.galleryQuickLetters.Id = 14;
			this.galleryQuickLetters.Name = "galleryQuickLetters";
			// 
			// biShowMap
			// 
			this.biShowMap.Caption = "Map It";
			this.biShowMap.Id = 15;
			this.biShowMap.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.biShowMap.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Mapit.svg";
			this.biShowMap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biShowMap.ImageOptions.SvgImage")));
			this.biShowMap.Name = "biShowMap";
			this.biShowMap.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			this.biShowMap.VisibleInSearchMenu = false;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Caption = "Refresh";
			this.btnRefresh.Id = 17;
			this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
			// 
			// btnNew
			// 
			this.btnNew.Caption = "Add New";
			this.btnNew.Enabled = false;
			this.btnNew.Id = 18;
			this.btnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNew.ImageOptions.SvgImage")));
			this.btnNew.Name = "btnNew";
			this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
			// 
			// rgJobStatusAction
			// 
			// 
			// 
			// 
			this.rgJobStatusAction.Gallery.ColumnCount = 3;
			this.rgJobStatusAction.Gallery.DrawImageBackground = false;
			galleryItemGroup2.Caption = "ActionGroup";
			galleryItem1.Caption = "Normal Mod";
			galleryItem1.Checked = true;
			galleryItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
			galleryItem1.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem1.Value = 0;
			galleryItem2.Caption = "Close current Job";
			galleryItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
			galleryItem2.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem2.Value = 1;
			galleryItem3.Caption = "Edit closed Job";
			galleryItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
			galleryItem3.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem3.Value = 2;
			galleryItem4.Caption = "Cancel current File";
			galleryItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage3")));
			galleryItem4.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem4.Value = 3;
			galleryItem5.Caption = "ReOpen canceled File";
			galleryItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage4")));
			galleryItem5.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem5.Value = 4;
			galleryItem6.Caption = "N/A";
			galleryItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage5")));
			galleryItem6.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem6.Value = 5;
			galleryItemGroup2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4,
            galleryItem5,
            galleryItem6});
			this.rgJobStatusAction.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup2});
			this.rgJobStatusAction.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck;
			this.rgJobStatusAction.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
			this.rgJobStatusAction.Gallery.ShowItemText = true;
			this.rgJobStatusAction.Id = 23;
			this.rgJobStatusAction.Name = "rgJobStatusAction";
			// 
			// btnResetGridStyle
			// 
			this.btnResetGridStyle.Caption = "Reset Grid Style";
			this.btnResetGridStyle.Id = 24;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			// 
			// rpMain
			// 
			this.rpMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup3,
            this.ribbonPageGroup9});
			this.rpMain.Name = "rpMain";
			this.rpMain.Text = "INVOICE";
			// 
			// ribbonPageGroup8
			// 
			this.ribbonPageGroup8.ItemLinks.Add(this.btnNew);
			this.ribbonPageGroup8.Name = "ribbonPageGroup8";
			this.ribbonPageGroup8.Text = "New";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnSaveAndClose);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh, true);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Save";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.AllowTextClipping = false;
			this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup2.ItemLinks.Add(this.btnDelete);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "Delete";
			// 
			// ribbonPageGroup4
			// 
			this.ribbonPageGroup4.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup4.ItemLinks.Add(this.btnPrint);
			this.ribbonPageGroup4.Name = "ribbonPageGroup4";
			this.ribbonPageGroup4.Text = "Quick Reports";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
			this.ribbonPageGroup3.AllowTextClipping = false;
			this.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup3.ItemLinks.Add(this.btnClose);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.Text = "Close";
			// 
			// ribbonPageGroup9
			// 
			this.ribbonPageGroup9.ItemLinks.Add(this.rgJobStatusAction);
			this.ribbonPageGroup9.Name = "ribbonPageGroup9";
			this.ribbonPageGroup9.Text = "Actions";
			// 
			// rpViewSettings
			// 
			this.rpViewSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
			this.rpViewSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("rpViewSettings.ImageOptions.SvgImage")));
			this.rpViewSettings.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			this.rpViewSettings.Name = "rpViewSettings";
			this.rpViewSettings.Text = "VIEW SETTINGS";
			// 
			// ribbonPageGroup6
			// 
			this.ribbonPageGroup6.ItemLinks.Add(this.btnResetGridStyle);
			this.ribbonPageGroup6.Name = "ribbonPageGroup6";
			this.ribbonPageGroup6.Text = "Grid Settings";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 754);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.ribbonControl;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1431, 30);
			// 
			// bsInvoice
			// 
			this.bsInvoice.DataSource = typeof(InvoiceModel);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.txtNotes);
			this.mainLayout.Controls.Add(this.txtRate);
			this.mainLayout.Controls.Add(this.cboCurrencies);
			this.mainLayout.Controls.Add(this.txtAttention);
			this.mainLayout.Controls.Add(this.cboCustomers);
			this.mainLayout.Controls.Add(this.txtJobCode);
			this.mainLayout.Controls.Add(this.cboJobs);
			this.mainLayout.Controls.Add(this.txtReference);
			this.mainLayout.Controls.Add(this.layoutControl1);
			this.mainLayout.Controls.Add(this.dtInvoiceDate);
			this.mainLayout.Controls.Add(this.txtTotalCommission);
			this.mainLayout.Controls.Add(this.txtTotalCostVat);
			this.mainLayout.Controls.Add(this.txtTotalCostUSD);
			this.mainLayout.Controls.Add(this.txtInvocieNo);
			this.mainLayout.Controls.Add(this.cboIssuers);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 197);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1431, 557);
			this.mainLayout.TabIndex = 15;
			this.mainLayout.Text = "layoutControl1";
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(917, 145);
			this.txtNotes.MenuManager = this.ribbonControl;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Properties.ReadOnly = true;
			this.txtNotes.Size = new System.Drawing.Size(490, 103);
			this.txtNotes.StyleController = this.mainLayout;
			this.txtNotes.TabIndex = 37;
			// 
			// txtRate
			// 
			this.txtRate.Location = new System.Drawing.Point(457, 128);
			this.txtRate.MenuManager = this.ribbonControl;
			this.txtRate.Name = "txtRate";
			this.txtRate.Properties.ReadOnly = true;
			this.txtRate.Size = new System.Drawing.Size(323, 22);
			this.txtRate.StyleController = this.mainLayout;
			this.txtRate.TabIndex = 36;
			// 
			// cboCurrencies
			// 
			this.cboCurrencies.Location = new System.Drawing.Point(123, 128);
			this.cboCurrencies.MenuManager = this.ribbonControl;
			this.cboCurrencies.Name = "cboCurrencies";
			this.cboCurrencies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCurrencies.Properties.DisplayMember = "CurrencyName";
			this.cboCurrencies.Properties.NullText = "";
			this.cboCurrencies.Properties.PopupView = this.searchLookUpEdit1View;
			this.cboCurrencies.Properties.ReadOnly = true;
			this.cboCurrencies.Properties.ValueMember = "Id";
			this.cboCurrencies.Size = new System.Drawing.Size(231, 22);
			this.cboCurrencies.StyleController = this.mainLayout;
			this.cboCurrencies.TabIndex = 35;
			// 
			// searchLookUpEdit1View
			// 
			this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCurrenciesId,
            this.colCurrenciesCode,
            this.colCurrenciesName});
			this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
			this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// colCurrenciesId
			// 
			this.colCurrenciesId.Caption = "Id";
			this.colCurrenciesId.FieldName = "Id";
			this.colCurrenciesId.Name = "colCurrenciesId";
			this.colCurrenciesId.Width = 72;
			// 
			// colCurrenciesCode
			// 
			this.colCurrenciesCode.Caption = "Code";
			this.colCurrenciesCode.FieldName = "CurrencyCode";
			this.colCurrenciesCode.Name = "colCurrenciesCode";
			this.colCurrenciesCode.Visible = true;
			this.colCurrenciesCode.VisibleIndex = 0;
			this.colCurrenciesCode.Width = 125;
			// 
			// colCurrenciesName
			// 
			this.colCurrenciesName.Caption = "Name";
			this.colCurrenciesName.FieldName = "CurrencyName";
			this.colCurrenciesName.Name = "colCurrenciesName";
			this.colCurrenciesName.Visible = true;
			this.colCurrenciesName.VisibleIndex = 1;
			this.colCurrenciesName.Width = 1083;
			// 
			// txtAttention
			// 
			this.txtAttention.Location = new System.Drawing.Point(123, 226);
			this.txtAttention.MenuManager = this.ribbonControl;
			this.txtAttention.Name = "txtAttention";
			this.txtAttention.Properties.ReadOnly = true;
			this.txtAttention.Size = new System.Drawing.Size(657, 22);
			this.txtAttention.StyleController = this.mainLayout;
			this.txtAttention.TabIndex = 34;
			// 
			// cboCustomers
			// 
			this.cboCustomers.Location = new System.Drawing.Point(123, 200);
			this.cboCustomers.MenuManager = this.ribbonControl;
			this.cboCustomers.Name = "cboCustomers";
			this.cboCustomers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCustomers.Properties.DisplayMember = "CustomerName";
			this.cboCustomers.Properties.NullText = "";
			this.cboCustomers.Properties.PopupView = this.gridView4;
			this.cboCustomers.Properties.ReadOnly = true;
			this.cboCustomers.Properties.ValueMember = "Id";
			this.cboCustomers.Size = new System.Drawing.Size(657, 22);
			this.cboCustomers.StyleController = this.mainLayout;
			this.cboCustomers.TabIndex = 33;
			// 
			// gridView4
			// 
			this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomersId,
            this.colCustomersName});
			this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView4.Name = "gridView4";
			this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView4.OptionsView.ShowGroupPanel = false;
			// 
			// colCustomersId
			// 
			this.colCustomersId.Caption = "Id";
			this.colCustomersId.FieldName = "Id";
			this.colCustomersId.Name = "colCustomersId";
			this.colCustomersId.Visible = true;
			this.colCustomersId.VisibleIndex = 0;
			this.colCustomersId.Width = 72;
			// 
			// colCustomersName
			// 
			this.colCustomersName.Caption = "Name";
			this.colCustomersName.FieldName = "CustomerName";
			this.colCustomersName.Name = "colCustomersName";
			this.colCustomersName.Visible = true;
			this.colCustomersName.VisibleIndex = 1;
			this.colCustomersName.Width = 1136;
			// 
			// txtJobCode
			// 
			this.txtJobCode.Location = new System.Drawing.Point(457, 102);
			this.txtJobCode.MenuManager = this.ribbonControl;
			this.txtJobCode.Name = "txtJobCode";
			this.txtJobCode.Properties.ReadOnly = true;
			this.txtJobCode.Size = new System.Drawing.Size(323, 22);
			this.txtJobCode.StyleController = this.mainLayout;
			this.txtJobCode.TabIndex = 32;
			// 
			// cboJobs
			// 
			this.cboJobs.Location = new System.Drawing.Point(123, 102);
			this.cboJobs.MenuManager = this.ribbonControl;
			this.cboJobs.Name = "cboJobs";
			this.cboJobs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboJobs.Properties.DisplayMember = "JobName";
			this.cboJobs.Properties.NullText = "";
			this.cboJobs.Properties.PopupView = this.gridView2;
			this.cboJobs.Properties.ReadOnly = true;
			this.cboJobs.Size = new System.Drawing.Size(231, 22);
			this.cboJobs.StyleController = this.mainLayout;
			this.cboJobs.TabIndex = 31;
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJobId,
            this.colJobCode,
            this.colJobJobName});
			this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView2.OptionsView.ShowGroupPanel = false;
			// 
			// colJobId
			// 
			this.colJobId.Caption = "Id";
			this.colJobId.FieldName = "Id";
			this.colJobId.Name = "colJobId";
			this.colJobId.Width = 84;
			// 
			// colJobCode
			// 
			this.colJobCode.Caption = "Code";
			this.colJobCode.FieldName = "Code";
			this.colJobCode.Name = "colJobCode";
			this.colJobCode.Visible = true;
			this.colJobCode.VisibleIndex = 0;
			this.colJobCode.Width = 141;
			// 
			// colJobJobName
			// 
			this.colJobJobName.Caption = "Job Name";
			this.colJobJobName.FieldName = "JobName";
			this.colJobJobName.Name = "colJobJobName";
			this.colJobJobName.Visible = true;
			this.colJobJobName.VisibleIndex = 1;
			this.colJobJobName.Width = 983;
			// 
			// txtReference
			// 
			this.txtReference.Location = new System.Drawing.Point(123, 76);
			this.txtReference.MenuManager = this.ribbonControl;
			this.txtReference.Name = "txtReference";
			this.txtReference.Properties.ReadOnly = true;
			this.txtReference.Size = new System.Drawing.Size(231, 22);
			this.txtReference.StyleController = this.mainLayout;
			this.txtReference.TabIndex = 30;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.gcInvoiceDetails);
			this.layoutControl1.Location = new System.Drawing.Point(12, 274);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(1407, 271);
			this.layoutControl1.TabIndex = 29;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// gcInvoiceDetails
			// 
			this.gcInvoiceDetails.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcInvoiceDetails.Location = new System.Drawing.Point(12, 12);
			this.gcInvoiceDetails.MainView = this.gvInvoiceDetails;
			this.gcInvoiceDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcInvoiceDetails.Name = "gcInvoiceDetails";
			this.gcInvoiceDetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItems,
            this.repositoryItemTextEdit1});
			this.gcInvoiceDetails.Size = new System.Drawing.Size(1383, 247);
			this.gcInvoiceDetails.TabIndex = 5;
			this.gcInvoiceDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInvoiceDetails});
			// 
			// gvInvoiceDetails
			// 
			this.gvInvoiceDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colInvoiceId,
            this.colItemId1,
            this.colDescription,
            this.colCurrencyId,
            this.colRate,
            this.colAmount,
            this.colLAmount,
            this.colFAmount,
            this.colVAT,
            this.colVATRate,
            this.colVATValue,
            this.colNotes,
            this.colAllowEdit,
            this.colLocked,
            this.colDeleted});
			this.gvInvoiceDetails.DetailHeight = 431;
			this.gvInvoiceDetails.GridControl = this.gcInvoiceDetails;
			this.gvInvoiceDetails.Name = "gvInvoiceDetails";
			this.gvInvoiceDetails.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
			this.gvInvoiceDetails.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
			this.gvInvoiceDetails.OptionsNavigation.AutoFocusNewRow = true;
			this.gvInvoiceDetails.OptionsNavigation.EnterMoveNextColumn = true;
			this.gvInvoiceDetails.OptionsPrint.AutoWidth = false;
			this.gvInvoiceDetails.OptionsView.ColumnAutoWidth = false;
			this.gvInvoiceDetails.OptionsView.ShowGroupPanel = false;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Width = 79;
			// 
			// colInvoiceId
			// 
			this.colInvoiceId.FieldName = "InvoiceId";
			this.colInvoiceId.MinWidth = 25;
			this.colInvoiceId.Name = "colInvoiceId";
			this.colInvoiceId.Width = 94;
			// 
			// colItemId1
			// 
			this.colItemId1.Caption = "Item";
			this.colItemId1.ColumnEdit = this.repItems;
			this.colItemId1.FieldName = "ItemId";
			this.colItemId1.MinWidth = 25;
			this.colItemId1.Name = "colItemId1";
			this.colItemId1.Visible = true;
			this.colItemId1.VisibleIndex = 0;
			this.colItemId1.Width = 77;
			// 
			// repItems
			// 
			this.repItems.AutoHeight = false;
			this.repItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repItems.DisplayMember = "ItemCode";
			this.repItems.Name = "repItems";
			this.repItems.NullText = "";
			this.repItems.PopupView = this.gridView1;
			this.repItems.ValueMember = "Id";
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnCode,
            this.gridColumnDescription});
			this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumnId
			// 
			this.gridColumnId.Caption = "Id";
			this.gridColumnId.FieldName = "Id";
			this.gridColumnId.Name = "gridColumnId";
			this.gridColumnId.Width = 104;
			// 
			// gridColumnCode
			// 
			this.gridColumnCode.Caption = "Code";
			this.gridColumnCode.FieldName = "ItemCode";
			this.gridColumnCode.Name = "gridColumnCode";
			this.gridColumnCode.Visible = true;
			this.gridColumnCode.VisibleIndex = 0;
			this.gridColumnCode.Width = 126;
			// 
			// gridColumnDescription
			// 
			this.gridColumnDescription.Caption = "Description";
			this.gridColumnDescription.FieldName = "Description";
			this.gridColumnDescription.Name = "gridColumnDescription";
			this.gridColumnDescription.Visible = true;
			this.gridColumnDescription.VisibleIndex = 1;
			this.gridColumnDescription.Width = 978;
			// 
			// colDescription
			// 
			this.colDescription.FieldName = "Description";
			this.colDescription.MinWidth = 25;
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 1;
			this.colDescription.Width = 189;
			// 
			// colCurrencyId
			// 
			this.colCurrencyId.Caption = "Currency";
			this.colCurrencyId.FieldName = "CurrencyId";
			this.colCurrencyId.MinWidth = 25;
			this.colCurrencyId.Name = "colCurrencyId";
			this.colCurrencyId.Visible = true;
			this.colCurrencyId.VisibleIndex = 2;
			this.colCurrencyId.Width = 104;
			// 
			// colRate
			// 
			this.colRate.FieldName = "Rate";
			this.colRate.MinWidth = 25;
			this.colRate.Name = "colRate";
			this.colRate.Visible = true;
			this.colRate.VisibleIndex = 3;
			this.colRate.Width = 94;
			// 
			// colAmount
			// 
			this.colAmount.FieldName = "Amount";
			this.colAmount.MinWidth = 25;
			this.colAmount.Name = "colAmount";
			this.colAmount.Visible = true;
			this.colAmount.VisibleIndex = 4;
			this.colAmount.Width = 94;
			// 
			// colLAmount
			// 
			this.colLAmount.Caption = "Amount LL";
			this.colLAmount.DisplayFormat.FormatString = "n";
			this.colLAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colLAmount.FieldName = "LAmount";
			this.colLAmount.MinWidth = 25;
			this.colLAmount.Name = "colLAmount";
			this.colLAmount.Visible = true;
			this.colLAmount.VisibleIndex = 5;
			this.colLAmount.Width = 94;
			// 
			// colFAmount
			// 
			this.colFAmount.Caption = "Amount USD";
			this.colFAmount.FieldName = "FAmount";
			this.colFAmount.MinWidth = 25;
			this.colFAmount.Name = "colFAmount";
			this.colFAmount.Visible = true;
			this.colFAmount.VisibleIndex = 6;
			this.colFAmount.Width = 94;
			// 
			// colVAT
			// 
			this.colVAT.FieldName = "VAT";
			this.colVAT.MinWidth = 25;
			this.colVAT.Name = "colVAT";
			this.colVAT.Visible = true;
			this.colVAT.VisibleIndex = 7;
			this.colVAT.Width = 94;
			// 
			// colVATRate
			// 
			this.colVATRate.FieldName = "VATRate";
			this.colVATRate.MinWidth = 25;
			this.colVATRate.Name = "colVATRate";
			this.colVATRate.Visible = true;
			this.colVATRate.VisibleIndex = 8;
			this.colVATRate.Width = 94;
			// 
			// colVATValue
			// 
			this.colVATValue.FieldName = "VATValue";
			this.colVATValue.MinWidth = 25;
			this.colVATValue.Name = "colVATValue";
			this.colVATValue.Visible = true;
			this.colVATValue.VisibleIndex = 9;
			this.colVATValue.Width = 94;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 10;
			this.colNotes.Width = 252;
			// 
			// colAllowEdit
			// 
			this.colAllowEdit.FieldName = "AllowEdit";
			this.colAllowEdit.MinWidth = 25;
			this.colAllowEdit.Name = "colAllowEdit";
			this.colAllowEdit.Width = 94;
			// 
			// colLocked
			// 
			this.colLocked.FieldName = "Locked";
			this.colLocked.MinWidth = 25;
			this.colLocked.Name = "colLocked";
			this.colLocked.Width = 94;
			// 
			// colDeleted
			// 
			this.colDeleted.FieldName = "Deleted";
			this.colDeleted.MinWidth = 25;
			this.colDeleted.Name = "colDeleted";
			this.colDeleted.Width = 94;
			// 
			// repositoryItemTextEdit1
			// 
			this.repositoryItemTextEdit1.AutoHeight = false;
			this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(1407, 271);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.gcInvoiceDetails;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(1387, 251);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// dtInvoiceDate
			// 
			this.dtInvoiceDate.EditValue = null;
			this.dtInvoiceDate.Location = new System.Drawing.Point(457, 76);
			this.dtInvoiceDate.MenuManager = this.ribbonControl;
			this.dtInvoiceDate.Name = "dtInvoiceDate";
			this.dtInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtInvoiceDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtInvoiceDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtInvoiceDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtInvoiceDate.Properties.ReadOnly = true;
			this.dtInvoiceDate.Properties.UseMaskAsDisplayFormat = true;
			this.dtInvoiceDate.Size = new System.Drawing.Size(323, 22);
			this.dtInvoiceDate.StyleController = this.mainLayout;
			this.dtInvoiceDate.TabIndex = 26;
			// 
			// txtTotalCommission
			// 
			this.txtTotalCommission.Location = new System.Drawing.Point(917, 102);
			this.txtTotalCommission.MenuManager = this.ribbonControl;
			this.txtTotalCommission.Name = "txtTotalCommission";
			this.txtTotalCommission.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtTotalCommission.Properties.MaskSettings.Set("mask", "n");
			this.txtTotalCommission.Properties.ReadOnly = true;
			this.txtTotalCommission.Size = new System.Drawing.Size(207, 22);
			this.txtTotalCommission.StyleController = this.mainLayout;
			this.txtTotalCommission.TabIndex = 24;
			// 
			// txtTotalCostVat
			// 
			this.txtTotalCostVat.Location = new System.Drawing.Point(917, 76);
			this.txtTotalCostVat.MenuManager = this.ribbonControl;
			this.txtTotalCostVat.Name = "txtTotalCostVat";
			this.txtTotalCostVat.Properties.DisplayFormat.FormatString = "{0:n2}";
			this.txtTotalCostVat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtTotalCostVat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtTotalCostVat.Properties.MaskSettings.Set("mask", "n");
			this.txtTotalCostVat.Properties.ReadOnly = true;
			this.txtTotalCostVat.Properties.UseMaskAsDisplayFormat = true;
			this.txtTotalCostVat.Size = new System.Drawing.Size(207, 22);
			this.txtTotalCostVat.StyleController = this.mainLayout;
			this.txtTotalCostVat.TabIndex = 17;
			this.txtTotalCostVat.TabStop = false;
			// 
			// txtTotalCostUSD
			// 
			this.txtTotalCostUSD.Location = new System.Drawing.Point(917, 50);
			this.txtTotalCostUSD.MenuManager = this.ribbonControl;
			this.txtTotalCostUSD.Name = "txtTotalCostUSD";
			this.txtTotalCostUSD.Properties.DisplayFormat.FormatString = "{0:n2}";
			this.txtTotalCostUSD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtTotalCostUSD.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtTotalCostUSD.Properties.MaskSettings.Set("mask", "n");
			this.txtTotalCostUSD.Properties.ReadOnly = true;
			this.txtTotalCostUSD.Properties.UseMaskAsDisplayFormat = true;
			this.txtTotalCostUSD.Size = new System.Drawing.Size(207, 22);
			this.txtTotalCostUSD.StyleController = this.mainLayout;
			this.txtTotalCostUSD.TabIndex = 16;
			this.txtTotalCostUSD.TabStop = false;
			// 
			// txtInvocieNo
			// 
			this.txtInvocieNo.Location = new System.Drawing.Point(123, 50);
			this.txtInvocieNo.MenuManager = this.ribbonControl;
			this.txtInvocieNo.Name = "txtInvocieNo";
			this.txtInvocieNo.Properties.ReadOnly = true;
			this.txtInvocieNo.Size = new System.Drawing.Size(231, 22);
			this.txtInvocieNo.StyleController = this.mainLayout;
			this.txtInvocieNo.TabIndex = 0;
			this.txtInvocieNo.TabStop = false;
			// 
			// cboIssuers
			// 
			this.cboIssuers.Location = new System.Drawing.Point(123, 174);
			this.cboIssuers.MenuManager = this.ribbonControl;
			this.cboIssuers.Name = "cboIssuers";
			this.cboIssuers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboIssuers.Properties.DisplayMember = "Name";
			this.cboIssuers.Properties.NullText = "";
			this.cboIssuers.Properties.PopupView = this.gridView3;
			this.cboIssuers.Properties.ReadOnly = true;
			this.cboIssuers.Properties.ValueMember = "Id";
			this.cboIssuers.Size = new System.Drawing.Size(657, 22);
			this.cboIssuers.StyleController = this.mainLayout;
			this.cboIssuers.TabIndex = 3;
			this.cboIssuers.TabStop = false;
			// 
			// gridView3
			// 
			this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIssuerId,
            this.colIssuerCode,
            this.colIssuerName});
			this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView3.Name = "gridView3";
			this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView3.OptionsView.ShowGroupPanel = false;
			// 
			// colIssuerId
			// 
			this.colIssuerId.Caption = "Id";
			this.colIssuerId.FieldName = "Id";
			this.colIssuerId.Name = "colIssuerId";
			this.colIssuerId.Width = 106;
			// 
			// colIssuerCode
			// 
			this.colIssuerCode.Caption = "Code";
			this.colIssuerCode.FieldName = "Code";
			this.colIssuerCode.Name = "colIssuerCode";
			this.colIssuerCode.Visible = true;
			this.colIssuerCode.VisibleIndex = 0;
			this.colIssuerCode.Width = 143;
			// 
			// colIssuerName
			// 
			this.colIssuerName.Caption = "Name";
			this.colIssuerName.FieldName = "Name";
			this.colIssuerName.Name = "colIssuerName";
			this.colIssuerName.Visible = true;
			this.colIssuerName.VisibleIndex = 1;
			this.colIssuerName.Width = 1065;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.grpTotals,
            this.emptySpaceItem1,
            this.layoutControlGroup2,
            this.layoutControlItem2,
            this.emptySpaceItem5});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1431, 557);
			this.Root.TextVisible = false;
			// 
			// grpTotals
			// 
			this.grpTotals.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpTotals.AppearanceGroup.Options.UseFont = true;
			this.grpTotals.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpTotals.AppearanceItemCaption.Options.UseFont = true;
			this.grpTotals.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpTotals.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblSubTotal,
            this.lblTotalCostVat,
            this.lblTotalCommission,
            this.lblNotes,
            this.emptySpaceItem3,
            this.emptySpaceItem6});
			this.grpTotals.Location = new System.Drawing.Point(794, 0);
			this.grpTotals.Name = "grpTotals";
			this.grpTotals.Size = new System.Drawing.Size(617, 252);
			this.grpTotals.Text = "Totals";
			// 
			// lblSubTotal
			// 
			this.lblSubTotal.Control = this.txtTotalCostUSD;
			this.lblSubTotal.Location = new System.Drawing.Point(0, 0);
			this.lblSubTotal.Name = "lblSubTotal";
			this.lblSubTotal.Size = new System.Drawing.Size(310, 26);
			this.lblSubTotal.Text = "Sub Total";
			// 
			// lblTotalCostVat
			// 
			this.lblTotalCostVat.Control = this.txtTotalCostVat;
			this.lblTotalCostVat.Location = new System.Drawing.Point(0, 26);
			this.lblTotalCostVat.Name = "lblTotalCostVat";
			this.lblTotalCostVat.Size = new System.Drawing.Size(310, 26);
			this.lblTotalCostVat.Text = "Total Vat";
			// 
			// lblTotalCommission
			// 
			this.lblTotalCommission.Control = this.txtTotalCommission;
			this.lblTotalCommission.Location = new System.Drawing.Point(0, 52);
			this.lblTotalCommission.Name = "lblTotalCommission";
			this.lblTotalCommission.Size = new System.Drawing.Size(310, 26);
			this.lblTotalCommission.Text = "Grand Total";
			// 
			// lblNotes
			// 
			this.lblNotes.AppearanceItemCaption.Options.UseFont = true;
			this.lblNotes.AppearanceItemCaptionDisabled.Options.UseFont = true;
			this.lblNotes.Control = this.txtNotes;
			this.lblNotes.Location = new System.Drawing.Point(0, 95);
			this.lblNotes.Name = "lblNotes";
			this.lblNotes.Size = new System.Drawing.Size(593, 107);
			this.lblNotes.Text = "Notes";
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.Location = new System.Drawing.Point(0, 78);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(593, 17);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.Location = new System.Drawing.Point(784, 0);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(10, 252);
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
			this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblInvocieNo,
            this.lblIssuers,
            this.lblInvoiceDate,
            this.emptySpaceItem9,
            this.lblReference,
            this.lblJobCode,
            this.lblJobs,
            this.lblCustomers,
            this.lblAttention,
            this.emptySpaceItem2,
            this.lblCurrencies,
            this.lblRate});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(784, 252);
			this.layoutControlGroup2.Text = "Selling Info";
			// 
			// lblInvocieNo
			// 
			this.lblInvocieNo.Control = this.txtInvocieNo;
			this.lblInvocieNo.Location = new System.Drawing.Point(0, 0);
			this.lblInvocieNo.Name = "lblInvocieNo";
			this.lblInvocieNo.Size = new System.Drawing.Size(334, 26);
			this.lblInvocieNo.Text = "Invocie No";
			// 
			// lblIssuers
			// 
			this.lblIssuers.Control = this.cboIssuers;
			this.lblIssuers.Location = new System.Drawing.Point(0, 124);
			this.lblIssuers.Name = "lblIssuers";
			this.lblIssuers.Size = new System.Drawing.Size(760, 26);
			this.lblIssuers.Text = "Issuer";
			// 
			// lblInvoiceDate
			// 
			this.lblInvoiceDate.Control = this.dtInvoiceDate;
			this.lblInvoiceDate.Location = new System.Drawing.Point(334, 26);
			this.lblInvoiceDate.Name = "lblInvoiceDate";
			this.lblInvoiceDate.Size = new System.Drawing.Size(426, 26);
			this.lblInvoiceDate.Text = "Invoice Date";
			// 
			// emptySpaceItem9
			// 
			this.emptySpaceItem9.Location = new System.Drawing.Point(334, 0);
			this.emptySpaceItem9.Name = "emptySpaceItem9";
			this.emptySpaceItem9.Size = new System.Drawing.Size(426, 26);
			// 
			// lblReference
			// 
			this.lblReference.Control = this.txtReference;
			this.lblReference.Location = new System.Drawing.Point(0, 26);
			this.lblReference.Name = "lblReference";
			this.lblReference.Size = new System.Drawing.Size(334, 26);
			this.lblReference.Text = "Reference";
			// 
			// lblJobCode
			// 
			this.lblJobCode.Control = this.txtJobCode;
			this.lblJobCode.Location = new System.Drawing.Point(334, 52);
			this.lblJobCode.Name = "lblJobCode";
			this.lblJobCode.Size = new System.Drawing.Size(426, 26);
			this.lblJobCode.Text = "Job Code";
			// 
			// lblJobs
			// 
			this.lblJobs.Control = this.cboJobs;
			this.lblJobs.Location = new System.Drawing.Point(0, 52);
			this.lblJobs.Name = "lblJobs";
			this.lblJobs.Size = new System.Drawing.Size(334, 26);
			this.lblJobs.Text = "File#";
			// 
			// lblCustomers
			// 
			this.lblCustomers.Control = this.cboCustomers;
			this.lblCustomers.Location = new System.Drawing.Point(0, 150);
			this.lblCustomers.Name = "lblCustomers";
			this.lblCustomers.Size = new System.Drawing.Size(760, 26);
			this.lblCustomers.Text = "Customer";
			// 
			// lblAttention
			// 
			this.lblAttention.Control = this.txtAttention;
			this.lblAttention.Location = new System.Drawing.Point(0, 176);
			this.lblAttention.Name = "lblAttention";
			this.lblAttention.Size = new System.Drawing.Size(760, 26);
			this.lblAttention.Text = "Attention";
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 104);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(760, 20);
			// 
			// lblCurrencies
			// 
			this.lblCurrencies.Control = this.cboCurrencies;
			this.lblCurrencies.Location = new System.Drawing.Point(0, 78);
			this.lblCurrencies.Name = "lblCurrencies";
			this.lblCurrencies.Size = new System.Drawing.Size(334, 26);
			this.lblCurrencies.Text = "Currency";
			// 
			// lblRate
			// 
			this.lblRate.Control = this.txtRate;
			this.lblRate.Location = new System.Drawing.Point(334, 78);
			this.lblRate.Name = "lblRate";
			this.lblRate.Size = new System.Drawing.Size(426, 26);
			this.lblRate.Text = "Rate";
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.layoutControl1;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 262);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(1411, 275);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// emptySpaceItem5
			// 
			this.emptySpaceItem5.Location = new System.Drawing.Point(0, 252);
			this.emptySpaceItem5.Name = "emptySpaceItem5";
			this.emptySpaceItem5.Size = new System.Drawing.Size(1411, 10);
			// 
			// emptySpaceItem6
			// 
			this.emptySpaceItem6.Location = new System.Drawing.Point(310, 0);
			this.emptySpaceItem6.Name = "emptySpaceItem6";
			this.emptySpaceItem6.Size = new System.Drawing.Size(283, 78);
			// 
			// InvoiceEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1431, 784);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.ribbonControl);
			this.Name = "InvoiceEditForm";
			this.Ribbon = this.ribbonControl;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Edit Invoice";
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsInvoice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCurrencies.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAttention.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCustomers.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtJobCode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboJobs.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcInvoiceDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvInvoiceDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalCommission.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalCostVat.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalCostUSD.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtInvocieNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboIssuers.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpTotals)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSubTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalCostVat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalCommission)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNotes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblInvocieNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblIssuers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblInvoiceDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblReference)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJobCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJobs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAttention)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCurrencies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarButtonItem btnSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem biMailMerge;
        private DevExpress.XtraBars.BarButtonItem biMeeting;
        private DevExpress.XtraBars.BarButtonItem bmiPrintProfile;
        private DevExpress.XtraBars.BarButtonItem bmiPrintSummary;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem bmiPrintDirectory;
        private DevExpress.XtraBars.BarButtonItem bmiPrintTaskList;
        private DevExpress.XtraBars.RibbonGalleryBarItem galleryQuickLetters;
        private DevExpress.XtraBars.BarButtonItem biShowMap;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgJobStatusAction;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
		private System.Windows.Forms.BindingSource bsInvoice;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraLayout.LayoutControl mainLayout;
		private DevExpress.XtraEditors.MemoEdit txtNotes;
		private DevExpress.XtraEditors.TextEdit txtRate;
		private DevExpress.XtraEditors.SearchLookUpEdit cboCurrencies;
		private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
		private DevExpress.XtraGrid.Columns.GridColumn colCurrenciesId;
		private DevExpress.XtraGrid.Columns.GridColumn colCurrenciesCode;
		private DevExpress.XtraGrid.Columns.GridColumn colCurrenciesName;
		private DevExpress.XtraEditors.TextEdit txtAttention;
		private DevExpress.XtraEditors.SearchLookUpEdit cboCustomers;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
		private DevExpress.XtraGrid.Columns.GridColumn colCustomersId;
		private DevExpress.XtraGrid.Columns.GridColumn colCustomersName;
		private DevExpress.XtraEditors.TextEdit txtJobCode;
		private DevExpress.XtraEditors.SearchLookUpEdit cboJobs;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.Columns.GridColumn colJobId;
		private DevExpress.XtraGrid.Columns.GridColumn colJobCode;
		private DevExpress.XtraGrid.Columns.GridColumn colJobJobName;
		private DevExpress.XtraEditors.TextEdit txtReference;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraGrid.GridControl gcInvoiceDetails;
		private DevExpress.XtraGrid.Views.Grid.GridView gvInvoiceDetails;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colInvoiceId;
		private DevExpress.XtraGrid.Columns.GridColumn colItemId1;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repItems;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumnCode;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colCurrencyId;
		private DevExpress.XtraGrid.Columns.GridColumn colRate;
		private DevExpress.XtraGrid.Columns.GridColumn colAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colLAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colFAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colVAT;
		private DevExpress.XtraGrid.Columns.GridColumn colVATRate;
		private DevExpress.XtraGrid.Columns.GridColumn colVATValue;
		private DevExpress.XtraGrid.Columns.GridColumn colNotes;
		private DevExpress.XtraGrid.Columns.GridColumn colAllowEdit;
		private DevExpress.XtraGrid.Columns.GridColumn colLocked;
		private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraEditors.DateEdit dtInvoiceDate;
		private DevExpress.XtraEditors.TextEdit txtTotalCommission;
		private DevExpress.XtraEditors.TextEdit txtTotalCostVat;
		private DevExpress.XtraEditors.TextEdit txtTotalCostUSD;
		private DevExpress.XtraEditors.TextEdit txtInvocieNo;
		private DevExpress.XtraEditors.SearchLookUpEdit cboIssuers;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
		private DevExpress.XtraGrid.Columns.GridColumn colIssuerId;
		private DevExpress.XtraGrid.Columns.GridColumn colIssuerCode;
		private DevExpress.XtraGrid.Columns.GridColumn colIssuerName;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlGroup grpTotals;
		private DevExpress.XtraLayout.LayoutControlItem lblSubTotal;
		private DevExpress.XtraLayout.LayoutControlItem lblTotalCostVat;
		private DevExpress.XtraLayout.LayoutControlItem lblTotalCommission;
		private DevExpress.XtraLayout.LayoutControlItem lblNotes;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem lblInvocieNo;
		private DevExpress.XtraLayout.LayoutControlItem lblIssuers;
		private DevExpress.XtraLayout.LayoutControlItem lblInvoiceDate;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
		private DevExpress.XtraLayout.LayoutControlItem lblReference;
		private DevExpress.XtraLayout.LayoutControlItem lblJobCode;
		private DevExpress.XtraLayout.LayoutControlItem lblJobs;
		private DevExpress.XtraLayout.LayoutControlItem lblCustomers;
		private DevExpress.XtraLayout.LayoutControlItem lblAttention;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.LayoutControlItem lblCurrencies;
		private DevExpress.XtraLayout.LayoutControlItem lblRate;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
	}
}