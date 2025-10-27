using MISLiveMed.Models.Models.Accounting.Invoices;

namespace MISLiveMed.UI.Accounting.Invoices
{
    partial class InvoicesListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesListForm));
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
			this.rcInvocies = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.rgFilterReports = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
			this.barCheckItem3 = new DevExpress.XtraBars.BarCheckItem();
			this.barCheckItem4 = new DevExpress.XtraBars.BarCheckItem();
			this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
			this.barCheckItem5 = new DevExpress.XtraBars.BarCheckItem();
			this.barCheckItem6 = new DevExpress.XtraBars.BarCheckItem();
			this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
			this.barCheckItem7 = new DevExpress.XtraBars.BarCheckItem();
			this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
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
			this.rpInvocies = new DevExpress.XtraBars.Ribbon.RibbonPage();
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
			this.gcContinents = new DevExpress.XtraGrid.GridControl();
			this.bsInvoices = new System.Windows.Forms.BindingSource(this.components);
			this.gvContinents = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colInvoiceRef = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJobId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMemberId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colToNotified = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotify = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAttn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSubject1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSubject2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSubject3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrencyRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsAgent = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSalesId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOperationDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPosted = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOriginal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colClosed = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colClosedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCanceled = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCanceledDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReason = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrintOriginalDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrintOriginalByUser = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLastPrintOrigDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLastPrintOrigByUser = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJVNO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDebitNote = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCreditNote = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRefNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSettledAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPaid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProtected = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
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
			((System.ComponentModel.ISupportInitialize)(this.rcInvocies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcContinents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsInvoices)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvContinents)).BeginInit();
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
			// rcInvocies
			// 
			this.rcInvocies.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcInvocies.ExpandCollapseItem.Id = 0;
			this.rcInvocies.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcInvocies.ExpandCollapseItem,
            this.btnNew,
            this.btnDelete,
            this.barButtonItem5,
            this.barButtonItem6,
            this.btnEdit,
            this.btnPrint,
            this.rgFilterReports,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barSubItem2,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barSubItem3,
            this.barCheckItem5,
            this.barCheckItem6,
            this.barButtonItem13,
            this.barCheckItem7,
            this.barButtonItem14,
            this.barCheckItem4,
            this.barCheckItem3,
            this.barButtonItem15,
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
			this.rcInvocies.Location = new System.Drawing.Point(0, 0);
			this.rcInvocies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcInvocies.MaxItemId = 59;
			this.rcInvocies.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.rcInvocies.Name = "rcInvocies";
			this.rcInvocies.OptionsMenuMinWidth = 385;
			this.rcInvocies.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpInvocies,
            this.rpViewSettings});
			this.rcInvocies.Size = new System.Drawing.Size(1428, 193);
			this.rcInvocies.StatusBar = this.ribbonStatusBar1;
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
			this.btnDelete.Caption = "Cancel";
			this.btnDelete.Enabled = false;
			this.btnDelete.Id = 3;
			this.btnDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnDelete.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg";
			this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
			// 
			// barButtonItem5
			// 
			this.barButtonItem5.Caption = "New Member Type";
			this.barButtonItem5.Id = 11;
			this.barButtonItem5.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewCustomer.svg?Size=16x16";
			this.barButtonItem5.Name = "barButtonItem5";
			// 
			// barButtonItem6
			// 
			this.barButtonItem6.Caption = "New Group";
			this.barButtonItem6.Id = 12;
			this.barButtonItem6.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewGroup.svg?Size=16x16";
			this.barButtonItem6.Name = "barButtonItem6";
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
			// barButtonItem8
			// 
			this.barButtonItem8.Caption = "Sales Summary";
			this.barButtonItem8.Id = 18;
			this.barButtonItem8.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem8.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesSummary2.svg?Size=16x16";
			this.barButtonItem8.Name = "barButtonItem8";
			// 
			// barButtonItem9
			// 
			this.barButtonItem9.Caption = "Member Type Profile";
			this.barButtonItem9.Id = 19;
			this.barButtonItem9.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem9.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ProfileReport.svg?Size=16x16";
			this.barButtonItem9.Name = "barButtonItem9";
			// 
			// barButtonItem10
			// 
			this.barButtonItem10.Caption = "Employees";
			this.barButtonItem10.Id = 20;
			this.barButtonItem10.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem10.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.EmployeeCard.svg?Size=16x16";
			this.barButtonItem10.Name = "barButtonItem10";
			// 
			// barSubItem2
			// 
			this.barSubItem2.Caption = "Change View";
			this.barSubItem2.Id = 21;
			this.barSubItem2.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barSubItem2.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ChangeView.svg";
			this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem4)});
			this.barSubItem2.Name = "barSubItem2";
			this.barSubItem2.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
			// 
			// barCheckItem3
			// 
			this.barCheckItem3.Caption = "List";
			this.barCheckItem3.Id = 33;
			this.barCheckItem3.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barCheckItem3.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.List.svg?Size=32x32";
			this.barCheckItem3.Name = "barCheckItem3";
			// 
			// barCheckItem4
			// 
			this.barCheckItem4.Caption = "Card";
			this.barCheckItem4.Id = 32;
			this.barCheckItem4.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barCheckItem4.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Card.svg";
			this.barCheckItem4.Name = "barCheckItem4";
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
			// barSubItem3
			// 
			this.barSubItem3.Caption = "Data Pane";
			this.barSubItem3.Id = 24;
			this.barSubItem3.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barSubItem3.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.DataPanel.svg";
			this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem6)});
			this.barSubItem3.Name = "barSubItem3";
			this.barSubItem3.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
			// 
			// barCheckItem5
			// 
			this.barCheckItem5.Caption = "Right";
			this.barCheckItem5.Id = 25;
			this.barCheckItem5.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barCheckItem5.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelRight.svg?Size=16x16";
			this.barCheckItem5.Name = "barCheckItem5";
			// 
			// barCheckItem6
			// 
			this.barCheckItem6.Caption = "Off";
			this.barCheckItem6.Id = 27;
			this.barCheckItem6.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barCheckItem6.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelOff.svg?Size=16x16";
			this.barCheckItem6.Name = "barCheckItem6";
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
			// barButtonItem15
			// 
			this.barButtonItem15.Caption = "Sales Detail";
			this.barButtonItem15.Id = 34;
			this.barButtonItem15.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem15.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesInvoise2.svg?Size=16x16";
			this.barButtonItem15.Name = "barButtonItem15";
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
			// rpInvocies
			// 
			this.rpInvocies.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup2,
            this.rpgPermissions,
            this.ribbonPageGroup11});
			this.rpInvocies.Name = "rpInvocies";
			this.rpInvocies.Text = "INVOICES";
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
			this.ribbonPageGroup6.ItemLinks.Add(this.btnPrint, true);
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
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 749);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcInvocies;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1428, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.gcContinents);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1428, 556);
			this.mainLayout.TabIndex = 7;
			this.mainLayout.Text = "layoutControl1";
			// 
			// gcContinents
			// 
			this.gcContinents.DataSource = this.bsInvoices;
			this.gcContinents.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcContinents.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcContinents.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcContinents.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcContinents.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcContinents.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcContinents.Location = new System.Drawing.Point(12, 12);
			this.gcContinents.MainView = this.gvContinents;
			this.gcContinents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcContinents.Name = "gcContinents";
			this.gcContinents.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
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
			this.gcContinents.Size = new System.Drawing.Size(1404, 532);
			this.gcContinents.TabIndex = 5;
			this.gcContinents.UseEmbeddedNavigator = true;
			this.gcContinents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContinents});
			this.gcContinents.DoubleClick += new System.EventHandler(this.gcContinents_DoubleClick);
			// 
			// bsInvoices
			// 
			this.bsInvoices.DataSource = typeof(InvoiceModel);
			// 
			// gvContinents
			// 
			this.gvContinents.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colInvoiceNo,
            this.colInvoiceRef,
            this.colJobId,
            this.colDepartmentId,
            this.colInvoiceDate,
            this.colMemberId,
            this.colToNotified,
            this.colNotify,
            this.colAttn,
            this.colSubject,
            this.colSubject1,
            this.colSubject2,
            this.colSubject3,
            this.colCurrencyId,
            this.colCurrencyRate,
            this.colAmount,
            this.colLAmount,
            this.colFAmount,
            this.colIsAgent,
            this.colSalesId,
            this.colUserId,
            this.colOperationDate,
            this.colModifyDate,
            this.colPosted,
            this.colOriginal,
            this.colClosed,
            this.colClosedDate,
            this.colCanceled,
            this.colCanceledDate,
            this.colReason,
            this.colPrintOriginalDate,
            this.colPrintOriginalByUser,
            this.colLastPrintOrigDate,
            this.colLastPrintOrigByUser,
            this.colJVNO,
            this.colDebitNote,
            this.colCreditNote,
            this.colDueDate,
            this.colRefNo,
            this.colSettledAmount,
            this.colPaid,
            this.colProtected,
            this.colNotes});
			this.gvContinents.DetailHeight = 458;
			this.gvContinents.GridControl = this.gcContinents;
			this.gvContinents.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", null, "")});
			this.gvContinents.Name = "gvContinents";
			this.gvContinents.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.gvContinents.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvContinents.OptionsBehavior.Editable = false;
			this.gvContinents.OptionsFind.AlwaysVisible = true;
			this.gvContinents.OptionsPrint.AutoWidth = false;
			this.gvContinents.OptionsPrint.PrintHorzLines = false;
			this.gvContinents.OptionsPrint.PrintVertLines = false;
			this.gvContinents.OptionsView.ColumnAutoWidth = false;
			this.gvContinents.OptionsView.ShowFooter = true;
			this.gvContinents.OptionsView.ShowGroupedColumns = true;
			this.gvContinents.OptionsView.ShowGroupPanel = false;
			this.gvContinents.OptionsView.ShowIndicator = false;
			this.gvContinents.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Width = 94;
			// 
			// colInvoiceNo
			// 
			this.colInvoiceNo.FieldName = "InvoiceNo";
			this.colInvoiceNo.MinWidth = 25;
			this.colInvoiceNo.Name = "colInvoiceNo";
			this.colInvoiceNo.Visible = true;
			this.colInvoiceNo.VisibleIndex = 0;
			this.colInvoiceNo.Width = 94;
			// 
			// colInvoiceRef
			// 
			this.colInvoiceRef.FieldName = "InvoiceRef";
			this.colInvoiceRef.MinWidth = 25;
			this.colInvoiceRef.Name = "colInvoiceRef";
			this.colInvoiceRef.Visible = true;
			this.colInvoiceRef.VisibleIndex = 1;
			this.colInvoiceRef.Width = 94;
			// 
			// colJobId
			// 
			this.colJobId.Caption = "Job No";
			this.colJobId.FieldName = "JobId";
			this.colJobId.MinWidth = 25;
			this.colJobId.Name = "colJobId";
			this.colJobId.Visible = true;
			this.colJobId.VisibleIndex = 2;
			this.colJobId.Width = 94;
			// 
			// colDepartmentId
			// 
			this.colDepartmentId.Caption = "Department";
			this.colDepartmentId.FieldName = "DepartmentId";
			this.colDepartmentId.MinWidth = 25;
			this.colDepartmentId.Name = "colDepartmentId";
			this.colDepartmentId.Visible = true;
			this.colDepartmentId.VisibleIndex = 3;
			this.colDepartmentId.Width = 94;
			// 
			// colInvoiceDate
			// 
			this.colInvoiceDate.FieldName = "InvoiceDate";
			this.colInvoiceDate.MinWidth = 25;
			this.colInvoiceDate.Name = "colInvoiceDate";
			this.colInvoiceDate.Visible = true;
			this.colInvoiceDate.VisibleIndex = 4;
			this.colInvoiceDate.Width = 94;
			// 
			// colMemberId
			// 
			this.colMemberId.Caption = "Customer";
			this.colMemberId.FieldName = "MemberId";
			this.colMemberId.MinWidth = 25;
			this.colMemberId.Name = "colMemberId";
			this.colMemberId.Visible = true;
			this.colMemberId.VisibleIndex = 5;
			this.colMemberId.Width = 94;
			// 
			// colToNotified
			// 
			this.colToNotified.FieldName = "ToNotified";
			this.colToNotified.MinWidth = 25;
			this.colToNotified.Name = "colToNotified";
			this.colToNotified.Visible = true;
			this.colToNotified.VisibleIndex = 6;
			this.colToNotified.Width = 94;
			// 
			// colNotify
			// 
			this.colNotify.FieldName = "Notify";
			this.colNotify.MinWidth = 25;
			this.colNotify.Name = "colNotify";
			this.colNotify.Visible = true;
			this.colNotify.VisibleIndex = 7;
			this.colNotify.Width = 94;
			// 
			// colAttn
			// 
			this.colAttn.FieldName = "Attn";
			this.colAttn.MinWidth = 25;
			this.colAttn.Name = "colAttn";
			this.colAttn.Visible = true;
			this.colAttn.VisibleIndex = 8;
			this.colAttn.Width = 94;
			// 
			// colSubject
			// 
			this.colSubject.FieldName = "Subject";
			this.colSubject.MinWidth = 25;
			this.colSubject.Name = "colSubject";
			this.colSubject.Visible = true;
			this.colSubject.VisibleIndex = 9;
			this.colSubject.Width = 94;
			// 
			// colSubject1
			// 
			this.colSubject1.FieldName = "Subject1";
			this.colSubject1.MinWidth = 25;
			this.colSubject1.Name = "colSubject1";
			this.colSubject1.Visible = true;
			this.colSubject1.VisibleIndex = 10;
			this.colSubject1.Width = 94;
			// 
			// colSubject2
			// 
			this.colSubject2.FieldName = "Subject2";
			this.colSubject2.MinWidth = 25;
			this.colSubject2.Name = "colSubject2";
			this.colSubject2.Visible = true;
			this.colSubject2.VisibleIndex = 11;
			this.colSubject2.Width = 94;
			// 
			// colSubject3
			// 
			this.colSubject3.FieldName = "Subject3";
			this.colSubject3.MinWidth = 25;
			this.colSubject3.Name = "colSubject3";
			this.colSubject3.Visible = true;
			this.colSubject3.VisibleIndex = 12;
			this.colSubject3.Width = 94;
			// 
			// colCurrencyId
			// 
			this.colCurrencyId.Caption = "Currency";
			this.colCurrencyId.FieldName = "CurrencyId";
			this.colCurrencyId.MinWidth = 25;
			this.colCurrencyId.Name = "colCurrencyId";
			this.colCurrencyId.Visible = true;
			this.colCurrencyId.VisibleIndex = 13;
			this.colCurrencyId.Width = 94;
			// 
			// colCurrencyRate
			// 
			this.colCurrencyRate.Caption = "Rate";
			this.colCurrencyRate.FieldName = "CurrencyRate";
			this.colCurrencyRate.MinWidth = 25;
			this.colCurrencyRate.Name = "colCurrencyRate";
			this.colCurrencyRate.Visible = true;
			this.colCurrencyRate.VisibleIndex = 14;
			this.colCurrencyRate.Width = 94;
			// 
			// colAmount
			// 
			this.colAmount.FieldName = "Amount";
			this.colAmount.MinWidth = 25;
			this.colAmount.Name = "colAmount";
			this.colAmount.Visible = true;
			this.colAmount.VisibleIndex = 15;
			this.colAmount.Width = 94;
			// 
			// colLAmount
			// 
			this.colLAmount.Caption = "Amount LL";
			this.colLAmount.FieldName = "LAmount";
			this.colLAmount.MinWidth = 25;
			this.colLAmount.Name = "colLAmount";
			this.colLAmount.Visible = true;
			this.colLAmount.VisibleIndex = 16;
			this.colLAmount.Width = 94;
			// 
			// colFAmount
			// 
			this.colFAmount.Caption = "Amount USD";
			this.colFAmount.FieldName = "FAmount";
			this.colFAmount.MinWidth = 25;
			this.colFAmount.Name = "colFAmount";
			this.colFAmount.Visible = true;
			this.colFAmount.VisibleIndex = 17;
			this.colFAmount.Width = 94;
			// 
			// colIsAgent
			// 
			this.colIsAgent.FieldName = "IsAgent";
			this.colIsAgent.MinWidth = 25;
			this.colIsAgent.Name = "colIsAgent";
			this.colIsAgent.Visible = true;
			this.colIsAgent.VisibleIndex = 18;
			this.colIsAgent.Width = 94;
			// 
			// colSalesId
			// 
			this.colSalesId.FieldName = "SalesId";
			this.colSalesId.MinWidth = 25;
			this.colSalesId.Name = "colSalesId";
			this.colSalesId.Visible = true;
			this.colSalesId.VisibleIndex = 19;
			this.colSalesId.Width = 94;
			// 
			// colUserId
			// 
			this.colUserId.FieldName = "UserId";
			this.colUserId.MinWidth = 25;
			this.colUserId.Name = "colUserId";
			this.colUserId.Visible = true;
			this.colUserId.VisibleIndex = 20;
			this.colUserId.Width = 94;
			// 
			// colOperationDate
			// 
			this.colOperationDate.FieldName = "OperationDate";
			this.colOperationDate.MinWidth = 25;
			this.colOperationDate.Name = "colOperationDate";
			this.colOperationDate.Visible = true;
			this.colOperationDate.VisibleIndex = 21;
			this.colOperationDate.Width = 94;
			// 
			// colModifyDate
			// 
			this.colModifyDate.FieldName = "ModifyDate";
			this.colModifyDate.MinWidth = 25;
			this.colModifyDate.Name = "colModifyDate";
			this.colModifyDate.Visible = true;
			this.colModifyDate.VisibleIndex = 22;
			this.colModifyDate.Width = 94;
			// 
			// colPosted
			// 
			this.colPosted.FieldName = "Posted";
			this.colPosted.MinWidth = 25;
			this.colPosted.Name = "colPosted";
			this.colPosted.Visible = true;
			this.colPosted.VisibleIndex = 23;
			this.colPosted.Width = 94;
			// 
			// colOriginal
			// 
			this.colOriginal.FieldName = "Original";
			this.colOriginal.MinWidth = 25;
			this.colOriginal.Name = "colOriginal";
			this.colOriginal.Visible = true;
			this.colOriginal.VisibleIndex = 24;
			this.colOriginal.Width = 94;
			// 
			// colClosed
			// 
			this.colClosed.FieldName = "Closed";
			this.colClosed.MinWidth = 25;
			this.colClosed.Name = "colClosed";
			this.colClosed.Visible = true;
			this.colClosed.VisibleIndex = 25;
			this.colClosed.Width = 94;
			// 
			// colClosedDate
			// 
			this.colClosedDate.FieldName = "ClosedDate";
			this.colClosedDate.MinWidth = 25;
			this.colClosedDate.Name = "colClosedDate";
			this.colClosedDate.Visible = true;
			this.colClosedDate.VisibleIndex = 26;
			this.colClosedDate.Width = 94;
			// 
			// colCanceled
			// 
			this.colCanceled.FieldName = "Canceled";
			this.colCanceled.MinWidth = 25;
			this.colCanceled.Name = "colCanceled";
			this.colCanceled.Visible = true;
			this.colCanceled.VisibleIndex = 27;
			this.colCanceled.Width = 94;
			// 
			// colCanceledDate
			// 
			this.colCanceledDate.FieldName = "CanceledDate";
			this.colCanceledDate.MinWidth = 25;
			this.colCanceledDate.Name = "colCanceledDate";
			this.colCanceledDate.Visible = true;
			this.colCanceledDate.VisibleIndex = 28;
			this.colCanceledDate.Width = 94;
			// 
			// colReason
			// 
			this.colReason.FieldName = "Reason";
			this.colReason.MinWidth = 25;
			this.colReason.Name = "colReason";
			this.colReason.Visible = true;
			this.colReason.VisibleIndex = 29;
			this.colReason.Width = 94;
			// 
			// colPrintOriginalDate
			// 
			this.colPrintOriginalDate.FieldName = "PrintOriginalDate";
			this.colPrintOriginalDate.MinWidth = 25;
			this.colPrintOriginalDate.Name = "colPrintOriginalDate";
			this.colPrintOriginalDate.Visible = true;
			this.colPrintOriginalDate.VisibleIndex = 30;
			this.colPrintOriginalDate.Width = 94;
			// 
			// colPrintOriginalByUser
			// 
			this.colPrintOriginalByUser.FieldName = "PrintOriginalByUser";
			this.colPrintOriginalByUser.MinWidth = 25;
			this.colPrintOriginalByUser.Name = "colPrintOriginalByUser";
			this.colPrintOriginalByUser.Visible = true;
			this.colPrintOriginalByUser.VisibleIndex = 31;
			this.colPrintOriginalByUser.Width = 94;
			// 
			// colLastPrintOrigDate
			// 
			this.colLastPrintOrigDate.FieldName = "LastPrintOrigDate";
			this.colLastPrintOrigDate.MinWidth = 25;
			this.colLastPrintOrigDate.Name = "colLastPrintOrigDate";
			this.colLastPrintOrigDate.Visible = true;
			this.colLastPrintOrigDate.VisibleIndex = 32;
			this.colLastPrintOrigDate.Width = 94;
			// 
			// colLastPrintOrigByUser
			// 
			this.colLastPrintOrigByUser.FieldName = "LastPrintOrigByUser";
			this.colLastPrintOrigByUser.MinWidth = 25;
			this.colLastPrintOrigByUser.Name = "colLastPrintOrigByUser";
			this.colLastPrintOrigByUser.Visible = true;
			this.colLastPrintOrigByUser.VisibleIndex = 33;
			this.colLastPrintOrigByUser.Width = 94;
			// 
			// colJVNO
			// 
			this.colJVNO.FieldName = "JVNO";
			this.colJVNO.MinWidth = 25;
			this.colJVNO.Name = "colJVNO";
			this.colJVNO.Visible = true;
			this.colJVNO.VisibleIndex = 34;
			this.colJVNO.Width = 94;
			// 
			// colDebitNote
			// 
			this.colDebitNote.FieldName = "DebitNote";
			this.colDebitNote.MinWidth = 25;
			this.colDebitNote.Name = "colDebitNote";
			this.colDebitNote.Visible = true;
			this.colDebitNote.VisibleIndex = 35;
			this.colDebitNote.Width = 94;
			// 
			// colCreditNote
			// 
			this.colCreditNote.FieldName = "CreditNote";
			this.colCreditNote.MinWidth = 25;
			this.colCreditNote.Name = "colCreditNote";
			this.colCreditNote.Visible = true;
			this.colCreditNote.VisibleIndex = 36;
			this.colCreditNote.Width = 94;
			// 
			// colDueDate
			// 
			this.colDueDate.FieldName = "DueDate";
			this.colDueDate.MinWidth = 25;
			this.colDueDate.Name = "colDueDate";
			this.colDueDate.Visible = true;
			this.colDueDate.VisibleIndex = 37;
			this.colDueDate.Width = 94;
			// 
			// colRefNo
			// 
			this.colRefNo.FieldName = "RefNo";
			this.colRefNo.MinWidth = 25;
			this.colRefNo.Name = "colRefNo";
			this.colRefNo.Visible = true;
			this.colRefNo.VisibleIndex = 38;
			this.colRefNo.Width = 94;
			// 
			// colSettledAmount
			// 
			this.colSettledAmount.FieldName = "SettledAmount";
			this.colSettledAmount.MinWidth = 25;
			this.colSettledAmount.Name = "colSettledAmount";
			this.colSettledAmount.Visible = true;
			this.colSettledAmount.VisibleIndex = 39;
			this.colSettledAmount.Width = 94;
			// 
			// colPaid
			// 
			this.colPaid.FieldName = "Paid";
			this.colPaid.MinWidth = 25;
			this.colPaid.Name = "colPaid";
			this.colPaid.Visible = true;
			this.colPaid.VisibleIndex = 40;
			this.colPaid.Width = 94;
			// 
			// colProtected
			// 
			this.colProtected.FieldName = "Protected";
			this.colProtected.MinWidth = 25;
			this.colProtected.Name = "colProtected";
			this.colProtected.Visible = true;
			this.colProtected.VisibleIndex = 41;
			this.colProtected.Width = 94;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 42;
			this.colNotes.Width = 94;
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
			this.Root.Size = new System.Drawing.Size(1428, 556);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcContinents;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1408, 536);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// InvoicesListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1428, 779);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcInvocies);
			this.Name = "InvoicesListForm";
			this.Ribbon = this.rcInvocies;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Invoices List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InvoicesListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.rcInvocies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcContinents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsInvoices)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvContinents)).EndInit();
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

        public DevExpress.XtraBars.Ribbon.RibbonControl rcInvocies;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgFilterReports;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarCheckItem barCheckItem3;
        private DevExpress.XtraBars.BarCheckItem barCheckItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarCheckItem barCheckItem5;
        private DevExpress.XtraBars.BarCheckItem barCheckItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarCheckItem barCheckItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
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
        private DevExpress.XtraBars.Ribbon.RibbonPage rpInvocies;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPermissions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraGrid.GridControl gcContinents;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContinents;
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
        private System.Windows.Forms.BindingSource bsInvoices;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceRef;
        private DevExpress.XtraGrid.Columns.GridColumn colJobId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberId;
        private DevExpress.XtraGrid.Columns.GridColumn colToNotified;
        private DevExpress.XtraGrid.Columns.GridColumn colNotify;
        private DevExpress.XtraGrid.Columns.GridColumn colAttn;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject2;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject3;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyId;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyRate;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colLAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colFAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAgent;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colOperationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPosted;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginal;
        private DevExpress.XtraGrid.Columns.GridColumn colClosed;
        private DevExpress.XtraGrid.Columns.GridColumn colClosedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCanceled;
        private DevExpress.XtraGrid.Columns.GridColumn colCanceledDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReason;
        private DevExpress.XtraGrid.Columns.GridColumn colPrintOriginalDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPrintOriginalByUser;
        private DevExpress.XtraGrid.Columns.GridColumn colLastPrintOrigDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastPrintOrigByUser;
        private DevExpress.XtraGrid.Columns.GridColumn colJVNO;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitNote;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditNote;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRefNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSettledAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colProtected;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
	}
}