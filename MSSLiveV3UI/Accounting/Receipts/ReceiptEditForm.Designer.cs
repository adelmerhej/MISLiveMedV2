using MISLiveMed.Models.Models.Accounting.Payments;

namespace MISLiveMed.UI.Accounting.Receipts
{
    partial class ReceiptEditForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptEditForm));
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges5 = new DevExpress.Skins.SkinPaddingEdges();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges6 = new DevExpress.Skins.SkinPaddingEdges();
			this.bsPaymentDetails = new System.Windows.Forms.BindingSource(this.components);
			this.bsPayment = new System.Windows.Forms.BindingSource(this.components);
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
			this.btnSchedule = new DevExpress.XtraBars.BarButtonItem();
			this.btnActionPay = new DevExpress.XtraBars.BarButtonItem();
			this.btnUndoPayment = new DevExpress.XtraBars.BarCheckItem();
			this.msgBarText = new DevExpress.XtraBars.BarStaticItem();
			this.btnApprove = new DevExpress.XtraBars.BarCheckItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.txtRate = new DevExpress.XtraEditors.TextEdit();
			this.cboCurrencies = new DevExpress.XtraEditors.LookUpEdit();
			this.txtTotalAmount = new DevExpress.XtraEditors.TextEdit();
			this.chkProtected = new DevExpress.XtraEditors.CheckEdit();
			this.chkPosted = new DevExpress.XtraEditors.CheckEdit();
			this.chkPaid = new DevExpress.XtraEditors.CheckEdit();
			this.txtReference = new DevExpress.XtraEditors.TextEdit();
			this.txtJobNo = new DevExpress.XtraEditors.TextEdit();
			this.txtId = new DevExpress.XtraEditors.TextEdit();
			this.gcReceiptDetail = new DevExpress.XtraGrid.GridControl();
			this.gvReceiptDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPaymentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.colTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repTypes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colReferenceId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCurrencies = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colLAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colFAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colApprovedDetail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colApprovedDateDetail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.colApprovedByDetail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repPaidByusers = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colPaidDetail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colPaidByDetail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.cboDepartments = new DevExpress.XtraEditors.LookUpEdit();
			this.cboPaymentTypes = new DevExpress.XtraEditors.LookUpEdit();
			this.cboMemberTypes = new DevExpress.XtraEditors.LookUpEdit();
			this.cboMembers = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMemberId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMemberName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtTotalAmountUSD = new DevExpress.XtraEditors.TextEdit();
			this.txtTotalAmountLL = new DevExpress.XtraEditors.TextEdit();
			this.txtTotalPaidAmount = new DevExpress.XtraEditors.TextEdit();
			this.txtTotalPaidAmountLL = new DevExpress.XtraEditors.TextEdit();
			this.txtTotalPaidAmountUSD = new DevExpress.XtraEditors.TextEdit();
			this.txtRemainingAmount = new DevExpress.XtraEditors.TextEdit();
			this.txtRemainingAmountLL = new DevExpress.XtraEditors.TextEdit();
			this.txtRemainingAmountUSD = new DevExpress.XtraEditors.TextEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.grpPaymentType = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblId = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblPaymentType = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblCurrencies = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblRate = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.grpTransactionInfo = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblDepartment = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblJobNo = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblMember = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblMemberType = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblReference = new DevExpress.XtraLayout.LayoutControlItem();
			this.grpStatus = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.grpTotals = new DevExpress.XtraLayout.LayoutControlGroup();
			this.TotalAmountUSD = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblTotalAmountLL = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblTotalAmount = new DevExpress.XtraLayout.LayoutControlItem();
			this.grpTotalPayment = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblTotalVATUSD = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblTotalVATLL = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblGrossCommission = new DevExpress.XtraLayout.LayoutControlItem();
			this.grpRemainingAmounts = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblTotalVATUSD1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblTotalVATLL1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblGrossCommission1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.bsPaymentDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsPayment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCurrencies.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkProtected.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkPosted.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkPaid.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtJobNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcReceiptDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvReceiptDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repTypes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCurrencies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repPaidByusers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboDepartments.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboPaymentTypes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboMemberTypes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboMembers.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalAmountUSD.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalAmountLL.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalPaidAmount.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalPaidAmountLL.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalPaidAmountUSD.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRemainingAmount.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRemainingAmountLL.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRemainingAmountUSD.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpPaymentType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPaymentType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCurrencies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpTransactionInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDepartment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJobNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMember)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMemberType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblReference)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpTotals)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalAmountUSD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalAmountLL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpTotalPayment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalVATUSD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalVATLL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblGrossCommission)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpRemainingAmounts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalVATUSD1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalVATLL1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblGrossCommission1)).BeginInit();
			this.SuspendLayout();
			// 
			// bsPaymentDetails
			// 
			this.bsPaymentDetails.DataSource = typeof(PaymentDetailModel);
			// 
			// bsPayment
			// 
			this.bsPayment.DataSource = typeof(PaymentModel);
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
            this.btnSchedule,
            this.btnActionPay,
            this.btnUndoPayment,
            this.msgBarText,
            this.btnApprove,
            this.btnResetGridStyle});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ribbonControl.MaxItemId = 28;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.OptionsMenuMinWidth = 385;
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.rpViewSettings});
			this.ribbonControl.Size = new System.Drawing.Size(1529, 193);
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
			galleryItemGroup3.Caption = "Group1";
			this.galleryQuickLetters.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup3});
			this.galleryQuickLetters.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
			skinPaddingEdges5.Bottom = -4;
			skinPaddingEdges5.Top = -4;
			this.galleryQuickLetters.Gallery.ItemImagePadding = skinPaddingEdges5;
			skinPaddingEdges6.Bottom = -1;
			skinPaddingEdges6.Top = -1;
			this.galleryQuickLetters.Gallery.ItemTextPadding = skinPaddingEdges6;
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
			this.btnRefresh.Caption = "Reset Changes";
			this.btnRefresh.Id = 17;
			this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
			this.btnRefresh.Name = "btnRefresh";
			// 
			// btnNew
			// 
			this.btnNew.Caption = "Add New";
			this.btnNew.Enabled = false;
			this.btnNew.Id = 18;
			this.btnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNew.ImageOptions.SvgImage")));
			this.btnNew.Name = "btnNew";
			// 
			// btnSchedule
			// 
			this.btnSchedule.Caption = "Reminder";
			this.btnSchedule.Enabled = false;
			this.btnSchedule.Id = 21;
			this.btnSchedule.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSchedule.ImageOptions.SvgImage")));
			this.btnSchedule.Name = "btnSchedule";
			// 
			// btnActionPay
			// 
			this.btnActionPay.Caption = "Pay Voucher";
			this.btnActionPay.Enabled = false;
			this.btnActionPay.Id = 22;
			this.btnActionPay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnActionPay.ImageOptions.SvgImage")));
			this.btnActionPay.Name = "btnActionPay";
			// 
			// btnUndoPayment
			// 
			this.btnUndoPayment.Caption = "Undo Payment";
			this.btnUndoPayment.Enabled = false;
			this.btnUndoPayment.Id = 23;
			this.btnUndoPayment.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndoPayment.ImageOptions.SvgImage")));
			this.btnUndoPayment.Name = "btnUndoPayment";
			this.btnUndoPayment.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			// 
			// msgBarText
			// 
			this.msgBarText.Id = 25;
			this.msgBarText.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msgBarText.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
			this.msgBarText.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
			this.msgBarText.ItemAppearance.Normal.Options.UseFont = true;
			this.msgBarText.ItemAppearance.Normal.Options.UseForeColor = true;
			this.msgBarText.Name = "msgBarText";
			// 
			// btnApprove
			// 
			this.btnApprove.Caption = "Approve";
			this.btnApprove.Enabled = false;
			this.btnApprove.Id = 26;
			this.btnApprove.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnApprove.ImageOptions.SvgImage")));
			this.btnApprove.Name = "btnApprove";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8,
            this.ribbonPageGroup1,
            this.ribbonPageGroup7,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup3,
            this.ribbonPageGroup6,
            this.rpgActions,
            this.ribbonPageGroup9});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "RECEIPT DETAILS";
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
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Save";
			// 
			// ribbonPageGroup7
			// 
			this.ribbonPageGroup7.AllowTextClipping = false;
			this.ribbonPageGroup7.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup7.ItemLinks.Add(this.btnRefresh);
			this.ribbonPageGroup7.Name = "ribbonPageGroup7";
			this.ribbonPageGroup7.Text = "Edit";
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
			// ribbonPageGroup6
			// 
			this.ribbonPageGroup6.ItemLinks.Add(this.btnSchedule);
			this.ribbonPageGroup6.Name = "ribbonPageGroup6";
			this.ribbonPageGroup6.Text = "Follow-up";
			// 
			// rpgActions
			// 
			this.rpgActions.ItemLinks.Add(this.btnApprove);
			this.rpgActions.ItemLinks.Add(this.btnActionPay, true);
			this.rpgActions.ItemLinks.Add(this.btnUndoPayment, true);
			this.rpgActions.Name = "rpgActions";
			this.rpgActions.Text = "Actions";
			// 
			// ribbonPageGroup9
			// 
			this.ribbonPageGroup9.ItemLinks.Add(this.msgBarText);
			this.ribbonPageGroup9.Name = "ribbonPageGroup9";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 865);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.ribbonControl;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1529, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.txtRate);
			this.mainLayout.Controls.Add(this.cboCurrencies);
			this.mainLayout.Controls.Add(this.txtTotalAmount);
			this.mainLayout.Controls.Add(this.chkProtected);
			this.mainLayout.Controls.Add(this.chkPosted);
			this.mainLayout.Controls.Add(this.chkPaid);
			this.mainLayout.Controls.Add(this.txtReference);
			this.mainLayout.Controls.Add(this.txtJobNo);
			this.mainLayout.Controls.Add(this.txtId);
			this.mainLayout.Controls.Add(this.gcReceiptDetail);
			this.mainLayout.Controls.Add(this.cboDepartments);
			this.mainLayout.Controls.Add(this.cboPaymentTypes);
			this.mainLayout.Controls.Add(this.cboMemberTypes);
			this.mainLayout.Controls.Add(this.cboMembers);
			this.mainLayout.Controls.Add(this.txtTotalAmountUSD);
			this.mainLayout.Controls.Add(this.txtTotalAmountLL);
			this.mainLayout.Controls.Add(this.txtTotalPaidAmount);
			this.mainLayout.Controls.Add(this.txtTotalPaidAmountLL);
			this.mainLayout.Controls.Add(this.txtTotalPaidAmountUSD);
			this.mainLayout.Controls.Add(this.txtRemainingAmount);
			this.mainLayout.Controls.Add(this.txtRemainingAmountLL);
			this.mainLayout.Controls.Add(this.txtRemainingAmountUSD);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 408, 812, 500);
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1529, 672);
			this.mainLayout.TabIndex = 13;
			this.mainLayout.Text = "layoutControl1";
			// 
			// txtRate
			// 
			this.txtRate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "Rate", true));
			this.txtRate.Location = new System.Drawing.Point(415, 113);
			this.txtRate.MenuManager = this.ribbonControl;
			this.txtRate.Name = "txtRate";
			this.txtRate.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtRate.Properties.MaskSettings.Set("mask", "n");
			this.txtRate.Properties.ReadOnly = true;
			this.txtRate.Properties.UseMaskAsDisplayFormat = true;
			this.txtRate.Size = new System.Drawing.Size(179, 22);
			this.txtRate.StyleController = this.mainLayout;
			this.txtRate.TabIndex = 28;
			// 
			// cboCurrencies
			// 
			this.cboCurrencies.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "CurrencyId", true));
			this.cboCurrencies.Location = new System.Drawing.Point(128, 113);
			this.cboCurrencies.MenuManager = this.ribbonControl;
			this.cboCurrencies.Name = "cboCurrencies";
			this.cboCurrencies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCurrencies.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCode", "Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.cboCurrencies.Properties.DisplayMember = "CurrencyCode";
			this.cboCurrencies.Properties.NullText = "";
			this.cboCurrencies.Properties.ReadOnly = true;
			this.cboCurrencies.Properties.ValueMember = "Id";
			this.cboCurrencies.Size = new System.Drawing.Size(179, 22);
			this.cboCurrencies.StyleController = this.mainLayout;
			this.cboCurrencies.TabIndex = 27;
			// 
			// txtTotalAmount
			// 
			this.txtTotalAmount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "Amount", true));
			this.txtTotalAmount.Location = new System.Drawing.Point(736, 61);
			this.txtTotalAmount.MenuManager = this.ribbonControl;
			this.txtTotalAmount.Name = "txtTotalAmount";
			this.txtTotalAmount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtTotalAmount.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
			this.txtTotalAmount.Properties.MaskSettings.Set("mask", "n");
			this.txtTotalAmount.Properties.ReadOnly = true;
			this.txtTotalAmount.Properties.UseMaskAsDisplayFormat = true;
			this.txtTotalAmount.Size = new System.Drawing.Size(184, 22);
			this.txtTotalAmount.StyleController = this.mainLayout;
			this.txtTotalAmount.TabIndex = 26;
			// 
			// chkProtected
			// 
			this.chkProtected.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "Protected", true));
			this.chkProtected.Location = new System.Drawing.Point(1209, 290);
			this.chkProtected.MenuManager = this.ribbonControl;
			this.chkProtected.Name = "chkProtected";
			this.chkProtected.Properties.Caption = "Protected";
			this.chkProtected.Properties.ReadOnly = true;
			this.chkProtected.Size = new System.Drawing.Size(296, 24);
			this.chkProtected.StyleController = this.mainLayout;
			this.chkProtected.TabIndex = 18;
			// 
			// chkPosted
			// 
			this.chkPosted.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "Posted", true));
			this.chkPosted.Location = new System.Drawing.Point(1107, 290);
			this.chkPosted.MenuManager = this.ribbonControl;
			this.chkPosted.Name = "chkPosted";
			this.chkPosted.Properties.Caption = "Posted";
			this.chkPosted.Properties.ReadOnly = true;
			this.chkPosted.Size = new System.Drawing.Size(98, 24);
			this.chkPosted.StyleController = this.mainLayout;
			this.chkPosted.TabIndex = 17;
			// 
			// chkPaid
			// 
			this.chkPaid.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "Paid", true));
			this.chkPaid.Location = new System.Drawing.Point(632, 290);
			this.chkPaid.MenuManager = this.ribbonControl;
			this.chkPaid.Name = "chkPaid";
			this.chkPaid.Properties.Caption = "Paid";
			this.chkPaid.Properties.ReadOnly = true;
			this.chkPaid.Size = new System.Drawing.Size(471, 24);
			this.chkPaid.StyleController = this.mainLayout;
			this.chkPaid.TabIndex = 16;
			// 
			// txtReference
			// 
			this.txtReference.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "ReferenceId", true));
			this.txtReference.Location = new System.Drawing.Point(387, 230);
			this.txtReference.MenuManager = this.ribbonControl;
			this.txtReference.Name = "txtReference";
			this.txtReference.Properties.ReadOnly = true;
			this.txtReference.Size = new System.Drawing.Size(207, 22);
			this.txtReference.StyleController = this.mainLayout;
			this.txtReference.TabIndex = 9;
			// 
			// txtJobNo
			// 
			this.txtJobNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "JobId", true));
			this.txtJobNo.Location = new System.Drawing.Point(128, 230);
			this.txtJobNo.MenuManager = this.ribbonControl;
			this.txtJobNo.Name = "txtJobNo";
			this.txtJobNo.Properties.ReadOnly = true;
			this.txtJobNo.Size = new System.Drawing.Size(151, 22);
			this.txtJobNo.StyleController = this.mainLayout;
			this.txtJobNo.TabIndex = 7;
			// 
			// txtId
			// 
			this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "Id", true));
			this.txtId.Location = new System.Drawing.Point(128, 61);
			this.txtId.MenuManager = this.ribbonControl;
			this.txtId.Name = "txtId";
			this.txtId.Properties.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(179, 22);
			this.txtId.StyleController = this.mainLayout;
			this.txtId.TabIndex = 5;
			this.txtId.TabStop = false;
			// 
			// gcReceiptDetail
			// 
			this.gcReceiptDetail.DataSource = this.bsPaymentDetails;
			this.gcReceiptDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcReceiptDetail.Location = new System.Drawing.Point(12, 350);
			this.gcReceiptDetail.MainView = this.gvReceiptDetail;
			this.gcReceiptDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcReceiptDetail.Name = "gcReceiptDetail";
			this.gcReceiptDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repCurrencies,
            this.repTypes,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4,
            this.repositoryItemTextEdit5,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemDateEdit2,
            this.repositoryItemCheckEdit3,
            this.repPaidByusers});
			this.gcReceiptDetail.Size = new System.Drawing.Size(1505, 310);
			this.gcReceiptDetail.TabIndex = 4;
			this.gcReceiptDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReceiptDetail});
			// 
			// gvReceiptDetail
			// 
			this.gvReceiptDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPaymentId,
            this.colPaymentDate,
            this.colTypeId,
            this.colReferenceId,
            this.colCurrencyId,
            this.colRate,
            this.colAmount,
            this.colLAmount,
            this.colFAmount,
            this.colDiscount,
            this.colApprovedDetail,
            this.colApprovedDateDetail,
            this.colApprovedByDetail,
            this.colPaidDetail,
            this.colPaidByDetail,
            this.colNotes,
            this.colDeleted});
			this.gvReceiptDetail.DetailHeight = 431;
			this.gvReceiptDetail.GridControl = this.gcReceiptDetail;
			this.gvReceiptDetail.Name = "gvReceiptDetail";
			this.gvReceiptDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
			this.gvReceiptDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
			this.gvReceiptDetail.OptionsNavigation.AutoFocusNewRow = true;
			this.gvReceiptDetail.OptionsNavigation.EnterMoveNextColumn = true;
			this.gvReceiptDetail.OptionsPrint.AutoWidth = false;
			this.gvReceiptDetail.OptionsView.ColumnAutoWidth = false;
			this.gvReceiptDetail.OptionsView.ShowFooter = true;
			this.gvReceiptDetail.OptionsView.ShowGroupPanel = false;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Width = 94;
			// 
			// colPaymentId
			// 
			this.colPaymentId.FieldName = "PaymentId";
			this.colPaymentId.MinWidth = 25;
			this.colPaymentId.Name = "colPaymentId";
			this.colPaymentId.Width = 94;
			// 
			// colPaymentDate
			// 
			this.colPaymentDate.ColumnEdit = this.repositoryItemDateEdit1;
			this.colPaymentDate.FieldName = "PaymentDetailDate";
			this.colPaymentDate.MinWidth = 25;
			this.colPaymentDate.Name = "colPaymentDate";
			this.colPaymentDate.OptionsColumn.TabStop = false;
			this.colPaymentDate.Visible = true;
			this.colPaymentDate.VisibleIndex = 0;
			this.colPaymentDate.Width = 111;
			// 
			// repositoryItemDateEdit1
			// 
			this.repositoryItemDateEdit1.AutoHeight = false;
			this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit1.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repositoryItemDateEdit1.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.repositoryItemDateEdit1.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
			this.repositoryItemDateEdit1.UseMaskAsDisplayFormat = true;
			// 
			// colTypeId
			// 
			this.colTypeId.Caption = "Type";
			this.colTypeId.ColumnEdit = this.repTypes;
			this.colTypeId.FieldName = "TypeId";
			this.colTypeId.MinWidth = 25;
			this.colTypeId.Name = "colTypeId";
			this.colTypeId.OptionsColumn.TabStop = false;
			this.colTypeId.Visible = true;
			this.colTypeId.VisibleIndex = 1;
			this.colTypeId.Width = 128;
			// 
			// repTypes
			// 
			this.repTypes.AutoHeight = false;
			this.repTypes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repTypes.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentType", "Type", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repTypes.DisplayMember = "PaymentType";
			this.repTypes.Name = "repTypes";
			this.repTypes.NullText = "";
			this.repTypes.ValueMember = "Id";
			// 
			// colReferenceId
			// 
			this.colReferenceId.Caption = "Reference";
			this.colReferenceId.FieldName = "ReferenceId";
			this.colReferenceId.MinWidth = 25;
			this.colReferenceId.Name = "colReferenceId";
			this.colReferenceId.OptionsColumn.ReadOnly = true;
			this.colReferenceId.OptionsColumn.TabStop = false;
			this.colReferenceId.Visible = true;
			this.colReferenceId.VisibleIndex = 2;
			this.colReferenceId.Width = 96;
			// 
			// colCurrencyId
			// 
			this.colCurrencyId.Caption = "Currency";
			this.colCurrencyId.ColumnEdit = this.repCurrencies;
			this.colCurrencyId.FieldName = "CurrencyId";
			this.colCurrencyId.MinWidth = 25;
			this.colCurrencyId.Name = "colCurrencyId";
			this.colCurrencyId.OptionsColumn.TabStop = false;
			this.colCurrencyId.Visible = true;
			this.colCurrencyId.VisibleIndex = 3;
			this.colCurrencyId.Width = 117;
			// 
			// repCurrencies
			// 
			this.repCurrencies.AutoHeight = false;
			this.repCurrencies.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCurrencies.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCode", "Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "Currency", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repCurrencies.DisplayMember = "CurrencyCode";
			this.repCurrencies.Name = "repCurrencies";
			this.repCurrencies.NullText = "";
			this.repCurrencies.ValueMember = "Id";
			// 
			// colRate
			// 
			this.colRate.ColumnEdit = this.repositoryItemTextEdit1;
			this.colRate.FieldName = "Rate";
			this.colRate.MinWidth = 25;
			this.colRate.Name = "colRate";
			this.colRate.OptionsColumn.TabStop = false;
			this.colRate.Visible = true;
			this.colRate.VisibleIndex = 4;
			this.colRate.Width = 94;
			// 
			// repositoryItemTextEdit1
			// 
			this.repositoryItemTextEdit1.AutoHeight = false;
			this.repositoryItemTextEdit1.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.repositoryItemTextEdit1.MaskSettings.Set("mask", "n");
			this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
			this.repositoryItemTextEdit1.UseMaskAsDisplayFormat = true;
			// 
			// colAmount
			// 
			this.colAmount.ColumnEdit = this.repositoryItemTextEdit2;
			this.colAmount.FieldName = "Amount";
			this.colAmount.MinWidth = 25;
			this.colAmount.Name = "colAmount";
			this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Amount", "{0:n}", "1")});
			this.colAmount.Visible = true;
			this.colAmount.VisibleIndex = 5;
			this.colAmount.Width = 156;
			// 
			// repositoryItemTextEdit2
			// 
			this.repositoryItemTextEdit2.AutoHeight = false;
			this.repositoryItemTextEdit2.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.repositoryItemTextEdit2.MaskSettings.Set("mask", "n");
			this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
			this.repositoryItemTextEdit2.UseMaskAsDisplayFormat = true;
			// 
			// colLAmount
			// 
			this.colLAmount.ColumnEdit = this.repositoryItemTextEdit3;
			this.colLAmount.FieldName = "LAmount";
			this.colLAmount.MinWidth = 25;
			this.colLAmount.Name = "colLAmount";
			this.colLAmount.OptionsColumn.ReadOnly = true;
			this.colLAmount.OptionsColumn.TabStop = false;
			this.colLAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "LAmount", "{0:n}", "2")});
			this.colLAmount.Visible = true;
			this.colLAmount.VisibleIndex = 6;
			this.colLAmount.Width = 178;
			// 
			// repositoryItemTextEdit3
			// 
			this.repositoryItemTextEdit3.AutoHeight = false;
			this.repositoryItemTextEdit3.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.repositoryItemTextEdit3.MaskSettings.Set("mask", "n");
			this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
			this.repositoryItemTextEdit3.UseMaskAsDisplayFormat = true;
			// 
			// colFAmount
			// 
			this.colFAmount.ColumnEdit = this.repositoryItemTextEdit4;
			this.colFAmount.FieldName = "FAmount";
			this.colFAmount.MinWidth = 25;
			this.colFAmount.Name = "colFAmount";
			this.colFAmount.OptionsColumn.ReadOnly = true;
			this.colFAmount.OptionsColumn.TabStop = false;
			this.colFAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "FAmount", "{0:n}", "3")});
			this.colFAmount.Visible = true;
			this.colFAmount.VisibleIndex = 7;
			this.colFAmount.Width = 167;
			// 
			// repositoryItemTextEdit4
			// 
			this.repositoryItemTextEdit4.AutoHeight = false;
			this.repositoryItemTextEdit4.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.repositoryItemTextEdit4.MaskSettings.Set("mask", "n");
			this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
			this.repositoryItemTextEdit4.UseMaskAsDisplayFormat = true;
			// 
			// colDiscount
			// 
			this.colDiscount.ColumnEdit = this.repositoryItemTextEdit5;
			this.colDiscount.FieldName = "Discount";
			this.colDiscount.MinWidth = 25;
			this.colDiscount.Name = "colDiscount";
			this.colDiscount.OptionsColumn.TabStop = false;
			this.colDiscount.Width = 107;
			// 
			// repositoryItemTextEdit5
			// 
			this.repositoryItemTextEdit5.AutoHeight = false;
			this.repositoryItemTextEdit5.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.repositoryItemTextEdit5.MaskSettings.Set("mask", "n");
			this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
			this.repositoryItemTextEdit5.UseMaskAsDisplayFormat = true;
			// 
			// colApprovedDetail
			// 
			this.colApprovedDetail.Caption = "Approve";
			this.colApprovedDetail.ColumnEdit = this.repositoryItemCheckEdit2;
			this.colApprovedDetail.FieldName = "Approved";
			this.colApprovedDetail.MinWidth = 25;
			this.colApprovedDetail.Name = "colApprovedDetail";
			this.colApprovedDetail.Width = 95;
			// 
			// repositoryItemCheckEdit2
			// 
			this.repositoryItemCheckEdit2.AutoHeight = false;
			this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
			// 
			// colApprovedDateDetail
			// 
			this.colApprovedDateDetail.Caption = "Approved Date";
			this.colApprovedDateDetail.ColumnEdit = this.repositoryItemDateEdit2;
			this.colApprovedDateDetail.FieldName = "ApprovedDate";
			this.colApprovedDateDetail.MinWidth = 25;
			this.colApprovedDateDetail.Name = "colApprovedDateDetail";
			this.colApprovedDateDetail.OptionsColumn.TabStop = false;
			this.colApprovedDateDetail.Width = 118;
			// 
			// repositoryItemDateEdit2
			// 
			this.repositoryItemDateEdit2.AutoHeight = false;
			this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit2.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repositoryItemDateEdit2.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.repositoryItemDateEdit2.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
			this.repositoryItemDateEdit2.ReadOnly = true;
			this.repositoryItemDateEdit2.UseMaskAsDisplayFormat = true;
			// 
			// colApprovedByDetail
			// 
			this.colApprovedByDetail.Caption = "Approved By";
			this.colApprovedByDetail.ColumnEdit = this.repPaidByusers;
			this.colApprovedByDetail.FieldName = "ApprovedBy";
			this.colApprovedByDetail.MinWidth = 25;
			this.colApprovedByDetail.Name = "colApprovedByDetail";
			this.colApprovedByDetail.OptionsColumn.ReadOnly = true;
			this.colApprovedByDetail.OptionsColumn.TabStop = false;
			this.colApprovedByDetail.Width = 105;
			// 
			// repPaidByusers
			// 
			this.repPaidByusers.AutoHeight = false;
			this.repPaidByusers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repPaidByusers.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "User Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repPaidByusers.DisplayMember = "UserName";
			this.repPaidByusers.Name = "repPaidByusers";
			this.repPaidByusers.NullText = "";
			this.repPaidByusers.ReadOnly = true;
			this.repPaidByusers.ValueMember = "Id";
			// 
			// colPaidDetail
			// 
			this.colPaidDetail.Caption = "Paid";
			this.colPaidDetail.ColumnEdit = this.repositoryItemCheckEdit3;
			this.colPaidDetail.FieldName = "Paid";
			this.colPaidDetail.MinWidth = 25;
			this.colPaidDetail.Name = "colPaidDetail";
			this.colPaidDetail.Width = 94;
			// 
			// repositoryItemCheckEdit3
			// 
			this.repositoryItemCheckEdit3.AutoHeight = false;
			this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
			// 
			// colPaidByDetail
			// 
			this.colPaidByDetail.Caption = "Paid By";
			this.colPaidByDetail.ColumnEdit = this.repPaidByusers;
			this.colPaidByDetail.FieldName = "PaidBy";
			this.colPaidByDetail.MinWidth = 25;
			this.colPaidByDetail.Name = "colPaidByDetail";
			this.colPaidByDetail.OptionsColumn.TabStop = false;
			this.colPaidByDetail.Width = 117;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.OptionsColumn.TabStop = false;
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 8;
			this.colNotes.Width = 355;
			// 
			// colDeleted
			// 
			this.colDeleted.ColumnEdit = this.repositoryItemCheckEdit1;
			this.colDeleted.FieldName = "Deleted";
			this.colDeleted.MinWidth = 25;
			this.colDeleted.Name = "colDeleted";
			this.colDeleted.Width = 94;
			// 
			// repositoryItemCheckEdit1
			// 
			this.repositoryItemCheckEdit1.AutoHeight = false;
			this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
			// 
			// cboDepartments
			// 
			this.cboDepartments.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "DepartmentId", true));
			this.cboDepartments.Location = new System.Drawing.Point(128, 204);
			this.cboDepartments.MenuManager = this.ribbonControl;
			this.cboDepartments.Name = "cboDepartments";
			this.cboDepartments.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboDepartments.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "Department Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.cboDepartments.Properties.DisplayMember = "DepartmentName";
			this.cboDepartments.Properties.NullText = "";
			this.cboDepartments.Properties.ReadOnly = true;
			this.cboDepartments.Properties.ValueMember = "Id";
			this.cboDepartments.Size = new System.Drawing.Size(466, 22);
			this.cboDepartments.StyleController = this.mainLayout;
			this.cboDepartments.TabIndex = 8;
			// 
			// cboPaymentTypes
			// 
			this.cboPaymentTypes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "PaymentTypeId", true));
			this.cboPaymentTypes.Location = new System.Drawing.Point(128, 87);
			this.cboPaymentTypes.MenuManager = this.ribbonControl;
			this.cboPaymentTypes.Name = "cboPaymentTypes";
			this.cboPaymentTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboPaymentTypes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentType", "Payment Type", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.cboPaymentTypes.Properties.DisplayMember = "PaymentType";
			this.cboPaymentTypes.Properties.NullText = "";
			this.cboPaymentTypes.Properties.ReadOnly = true;
			this.cboPaymentTypes.Properties.ValueMember = "Id";
			this.cboPaymentTypes.Size = new System.Drawing.Size(466, 22);
			this.cboPaymentTypes.StyleController = this.mainLayout;
			this.cboPaymentTypes.TabIndex = 6;
			// 
			// cboMemberTypes
			// 
			this.cboMemberTypes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "MemberTypeId", true));
			this.cboMemberTypes.Location = new System.Drawing.Point(128, 256);
			this.cboMemberTypes.MenuManager = this.ribbonControl;
			this.cboMemberTypes.Name = "cboMemberTypes";
			this.cboMemberTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboMemberTypes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.cboMemberTypes.Properties.DisplayMember = "Name";
			this.cboMemberTypes.Properties.NullText = "";
			this.cboMemberTypes.Properties.ReadOnly = true;
			this.cboMemberTypes.Properties.ValueMember = "Id";
			this.cboMemberTypes.Size = new System.Drawing.Size(466, 22);
			this.cboMemberTypes.StyleController = this.mainLayout;
			this.cboMemberTypes.TabIndex = 10;
			// 
			// cboMembers
			// 
			this.cboMembers.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "MemberId", true));
			this.cboMembers.Location = new System.Drawing.Point(128, 282);
			this.cboMembers.MenuManager = this.ribbonControl;
			this.cboMembers.Name = "cboMembers";
			this.cboMembers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboMembers.Properties.DisplayMember = "MemberName";
			this.cboMembers.Properties.NullText = "";
			this.cboMembers.Properties.PopupView = this.searchLookUpEdit1View;
			this.cboMembers.Properties.ReadOnly = true;
			this.cboMembers.Properties.ValueMember = "Id";
			this.cboMembers.Size = new System.Drawing.Size(466, 22);
			this.cboMembers.StyleController = this.mainLayout;
			this.cboMembers.TabIndex = 11;
			// 
			// searchLookUpEdit1View
			// 
			this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMemberId,
            this.colMemberName});
			this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
			this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// colMemberId
			// 
			this.colMemberId.Caption = "Id";
			this.colMemberId.FieldName = "Id";
			this.colMemberId.Name = "colMemberId";
			this.colMemberId.Visible = true;
			this.colMemberId.VisibleIndex = 0;
			this.colMemberId.Width = 128;
			// 
			// colMemberName
			// 
			this.colMemberName.Caption = "Member Name";
			this.colMemberName.FieldName = "MemberName";
			this.colMemberName.Name = "colMemberName";
			this.colMemberName.Visible = true;
			this.colMemberName.VisibleIndex = 1;
			this.colMemberName.Width = 1009;
			// 
			// txtTotalAmountUSD
			// 
			this.txtTotalAmountUSD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "FAmount", true));
			this.txtTotalAmountUSD.Location = new System.Drawing.Point(736, 113);
			this.txtTotalAmountUSD.Name = "txtTotalAmountUSD";
			this.txtTotalAmountUSD.Properties.DisplayFormat.FormatString = "{0:n2}";
			this.txtTotalAmountUSD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtTotalAmountUSD.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtTotalAmountUSD.Properties.MaskSettings.Set("mask", "n");
			this.txtTotalAmountUSD.Properties.ReadOnly = true;
			this.txtTotalAmountUSD.Properties.UseMaskAsDisplayFormat = true;
			this.txtTotalAmountUSD.Size = new System.Drawing.Size(184, 22);
			this.txtTotalAmountUSD.StyleController = this.mainLayout;
			this.txtTotalAmountUSD.TabIndex = 17;
			this.txtTotalAmountUSD.TabStop = false;
			// 
			// txtTotalAmountLL
			// 
			this.txtTotalAmountLL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsPayment, "LAmount", true));
			this.txtTotalAmountLL.Location = new System.Drawing.Point(736, 87);
			this.txtTotalAmountLL.Name = "txtTotalAmountLL";
			this.txtTotalAmountLL.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtTotalAmountLL.Properties.MaskSettings.Set("mask", "n");
			this.txtTotalAmountLL.Properties.ReadOnly = true;
			this.txtTotalAmountLL.Properties.UseMaskAsDisplayFormat = true;
			this.txtTotalAmountLL.Size = new System.Drawing.Size(184, 22);
			this.txtTotalAmountLL.StyleController = this.mainLayout;
			this.txtTotalAmountLL.TabIndex = 24;
			// 
			// txtTotalPaidAmount
			// 
			this.txtTotalPaidAmount.Location = new System.Drawing.Point(948, 61);
			this.txtTotalPaidAmount.Name = "txtTotalPaidAmount";
			this.txtTotalPaidAmount.Properties.DisplayFormat.FormatString = "{0:n2}";
			this.txtTotalPaidAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtTotalPaidAmount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtTotalPaidAmount.Properties.MaskSettings.Set("mask", "n");
			this.txtTotalPaidAmount.Properties.ReadOnly = true;
			this.txtTotalPaidAmount.Properties.UseMaskAsDisplayFormat = true;
			this.txtTotalPaidAmount.Size = new System.Drawing.Size(258, 22);
			this.txtTotalPaidAmount.StyleController = this.mainLayout;
			this.txtTotalPaidAmount.TabIndex = 14;
			this.txtTotalPaidAmount.TabStop = false;
			// 
			// txtTotalPaidAmountLL
			// 
			this.txtTotalPaidAmountLL.Location = new System.Drawing.Point(948, 87);
			this.txtTotalPaidAmountLL.Name = "txtTotalPaidAmountLL";
			this.txtTotalPaidAmountLL.Properties.DisplayFormat.FormatString = "{0:n2}";
			this.txtTotalPaidAmountLL.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtTotalPaidAmountLL.Properties.EditFormat.FormatString = "{0:n2}";
			this.txtTotalPaidAmountLL.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtTotalPaidAmountLL.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtTotalPaidAmountLL.Properties.MaskSettings.Set("mask", "n");
			this.txtTotalPaidAmountLL.Properties.ReadOnly = true;
			this.txtTotalPaidAmountLL.Properties.UseMaskAsDisplayFormat = true;
			this.txtTotalPaidAmountLL.Size = new System.Drawing.Size(258, 22);
			this.txtTotalPaidAmountLL.StyleController = this.mainLayout;
			this.txtTotalPaidAmountLL.TabIndex = 15;
			this.txtTotalPaidAmountLL.TabStop = false;
			// 
			// txtTotalPaidAmountUSD
			// 
			this.txtTotalPaidAmountUSD.Location = new System.Drawing.Point(948, 113);
			this.txtTotalPaidAmountUSD.Name = "txtTotalPaidAmountUSD";
			this.txtTotalPaidAmountUSD.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtTotalPaidAmountUSD.Properties.MaskSettings.Set("mask", "n");
			this.txtTotalPaidAmountUSD.Properties.ReadOnly = true;
			this.txtTotalPaidAmountUSD.Properties.UseMaskAsDisplayFormat = true;
			this.txtTotalPaidAmountUSD.Size = new System.Drawing.Size(258, 22);
			this.txtTotalPaidAmountUSD.StyleController = this.mainLayout;
			this.txtTotalPaidAmountUSD.TabIndex = 25;
			// 
			// txtRemainingAmount
			// 
			this.txtRemainingAmount.Location = new System.Drawing.Point(1234, 61);
			this.txtRemainingAmount.Name = "txtRemainingAmount";
			this.txtRemainingAmount.Properties.DisplayFormat.FormatString = "{0:n2}";
			this.txtRemainingAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtRemainingAmount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtRemainingAmount.Properties.MaskSettings.Set("mask", "n");
			this.txtRemainingAmount.Properties.ReadOnly = true;
			this.txtRemainingAmount.Properties.UseMaskAsDisplayFormat = true;
			this.txtRemainingAmount.Size = new System.Drawing.Size(271, 22);
			this.txtRemainingAmount.StyleController = this.mainLayout;
			this.txtRemainingAmount.TabIndex = 14;
			this.txtRemainingAmount.TabStop = false;
			// 
			// txtRemainingAmountLL
			// 
			this.txtRemainingAmountLL.Location = new System.Drawing.Point(1234, 87);
			this.txtRemainingAmountLL.Name = "txtRemainingAmountLL";
			this.txtRemainingAmountLL.Properties.DisplayFormat.FormatString = "{0:n2}";
			this.txtRemainingAmountLL.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtRemainingAmountLL.Properties.EditFormat.FormatString = "{0:n2}";
			this.txtRemainingAmountLL.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtRemainingAmountLL.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtRemainingAmountLL.Properties.MaskSettings.Set("mask", "n");
			this.txtRemainingAmountLL.Properties.ReadOnly = true;
			this.txtRemainingAmountLL.Properties.UseMaskAsDisplayFormat = true;
			this.txtRemainingAmountLL.Size = new System.Drawing.Size(271, 22);
			this.txtRemainingAmountLL.StyleController = this.mainLayout;
			this.txtRemainingAmountLL.TabIndex = 15;
			this.txtRemainingAmountLL.TabStop = false;
			// 
			// txtRemainingAmountUSD
			// 
			this.txtRemainingAmountUSD.Location = new System.Drawing.Point(1234, 113);
			this.txtRemainingAmountUSD.Name = "txtRemainingAmountUSD";
			this.txtRemainingAmountUSD.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtRemainingAmountUSD.Properties.MaskSettings.Set("mask", "n");
			this.txtRemainingAmountUSD.Properties.ReadOnly = true;
			this.txtRemainingAmountUSD.Properties.UseMaskAsDisplayFormat = true;
			this.txtRemainingAmountUSD.Size = new System.Drawing.Size(271, 22);
			this.txtRemainingAmountUSD.StyleController = this.mainLayout;
			this.txtRemainingAmountUSD.TabIndex = 25;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem5,
            this.emptySpaceItem9,
            this.emptySpaceItem3,
            this.emptySpaceItem6,
            this.emptySpaceItem7,
            this.grpPaymentType,
            this.grpTransactionInfo,
            this.grpStatus,
            this.emptySpaceItem4,
            this.grpTotals,
            this.grpTotalPayment,
            this.grpRemainingAmounts});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1529, 672);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcReceiptDetail;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 338);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1509, 314);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(1509, 11);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem5
			// 
			this.emptySpaceItem5.AllowHotTrack = false;
			this.emptySpaceItem5.Location = new System.Drawing.Point(0, 139);
			this.emptySpaceItem5.Name = "emptySpaceItem5";
			this.emptySpaceItem5.Size = new System.Drawing.Size(598, 15);
			this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem9
			// 
			this.emptySpaceItem9.AllowHotTrack = false;
			this.emptySpaceItem9.Location = new System.Drawing.Point(598, 11);
			this.emptySpaceItem9.Name = "emptySpaceItem9";
			this.emptySpaceItem9.Size = new System.Drawing.Size(10, 297);
			this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.AllowHotTrack = false;
			this.emptySpaceItem3.Location = new System.Drawing.Point(0, 328);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(1509, 10);
			this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem6
			// 
			this.emptySpaceItem6.AllowHotTrack = false;
			this.emptySpaceItem6.Location = new System.Drawing.Point(0, 308);
			this.emptySpaceItem6.Name = "emptySpaceItem6";
			this.emptySpaceItem6.Size = new System.Drawing.Size(608, 10);
			this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem7
			// 
			this.emptySpaceItem7.AllowHotTrack = false;
			this.emptySpaceItem7.Location = new System.Drawing.Point(0, 318);
			this.emptySpaceItem7.Name = "emptySpaceItem7";
			this.emptySpaceItem7.Size = new System.Drawing.Size(1509, 10);
			this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
			// 
			// grpPaymentType
			// 
			this.grpPaymentType.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpPaymentType.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblId,
            this.lblPaymentType,
            this.lblCurrencies,
            this.lblRate,
            this.emptySpaceItem8});
			this.grpPaymentType.Location = new System.Drawing.Point(0, 11);
			this.grpPaymentType.Name = "grpPaymentType";
			this.grpPaymentType.Size = new System.Drawing.Size(598, 128);
			this.grpPaymentType.Text = "Payment Type";
			// 
			// lblId
			// 
			this.lblId.Control = this.txtId;
			this.lblId.Location = new System.Drawing.Point(0, 0);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(287, 26);
			this.lblId.Text = "Id";
			this.lblId.TextSize = new System.Drawing.Size(92, 16);
			// 
			// lblPaymentType
			// 
			this.lblPaymentType.Control = this.cboPaymentTypes;
			this.lblPaymentType.Location = new System.Drawing.Point(0, 26);
			this.lblPaymentType.Name = "lblPaymentType";
			this.lblPaymentType.Size = new System.Drawing.Size(574, 26);
			this.lblPaymentType.Text = "Payment Type";
			this.lblPaymentType.TextSize = new System.Drawing.Size(92, 16);
			// 
			// lblCurrencies
			// 
			this.lblCurrencies.Control = this.cboCurrencies;
			this.lblCurrencies.Location = new System.Drawing.Point(0, 52);
			this.lblCurrencies.Name = "lblCurrencies";
			this.lblCurrencies.Size = new System.Drawing.Size(287, 26);
			this.lblCurrencies.Text = "Currency";
			this.lblCurrencies.TextSize = new System.Drawing.Size(92, 16);
			// 
			// lblRate
			// 
			this.lblRate.Control = this.txtRate;
			this.lblRate.Location = new System.Drawing.Point(287, 52);
			this.lblRate.Name = "lblRate";
			this.lblRate.Size = new System.Drawing.Size(287, 26);
			this.lblRate.Text = "Rate";
			this.lblRate.TextSize = new System.Drawing.Size(92, 16);
			// 
			// emptySpaceItem8
			// 
			this.emptySpaceItem8.AllowHotTrack = false;
			this.emptySpaceItem8.Location = new System.Drawing.Point(287, 0);
			this.emptySpaceItem8.Name = "emptySpaceItem8";
			this.emptySpaceItem8.Size = new System.Drawing.Size(287, 26);
			this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
			// 
			// grpTransactionInfo
			// 
			this.grpTransactionInfo.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpTransactionInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblDepartment,
            this.lblJobNo,
            this.lblMember,
            this.lblMemberType,
            this.lblReference});
			this.grpTransactionInfo.Location = new System.Drawing.Point(0, 154);
			this.grpTransactionInfo.Name = "grpTransactionInfo";
			this.grpTransactionInfo.Size = new System.Drawing.Size(598, 154);
			this.grpTransactionInfo.Text = "Transaction Info";
			// 
			// lblDepartment
			// 
			this.lblDepartment.Control = this.cboDepartments;
			this.lblDepartment.Location = new System.Drawing.Point(0, 0);
			this.lblDepartment.Name = "lblDepartment";
			this.lblDepartment.Size = new System.Drawing.Size(574, 26);
			this.lblDepartment.Text = "Department";
			this.lblDepartment.TextSize = new System.Drawing.Size(92, 16);
			// 
			// lblJobNo
			// 
			this.lblJobNo.Control = this.txtJobNo;
			this.lblJobNo.Location = new System.Drawing.Point(0, 26);
			this.lblJobNo.Name = "lblJobNo";
			this.lblJobNo.Size = new System.Drawing.Size(259, 26);
			this.lblJobNo.Text = "Job No";
			this.lblJobNo.TextSize = new System.Drawing.Size(92, 16);
			// 
			// lblMember
			// 
			this.lblMember.Control = this.cboMembers;
			this.lblMember.Location = new System.Drawing.Point(0, 78);
			this.lblMember.Name = "lblMember";
			this.lblMember.Size = new System.Drawing.Size(574, 26);
			this.lblMember.Text = "Member";
			this.lblMember.TextSize = new System.Drawing.Size(92, 16);
			// 
			// lblMemberType
			// 
			this.lblMemberType.Control = this.cboMemberTypes;
			this.lblMemberType.Location = new System.Drawing.Point(0, 52);
			this.lblMemberType.Name = "lblMemberType";
			this.lblMemberType.Size = new System.Drawing.Size(574, 26);
			this.lblMemberType.Text = "Member Type";
			this.lblMemberType.TextSize = new System.Drawing.Size(92, 16);
			// 
			// lblReference
			// 
			this.lblReference.Control = this.txtReference;
			this.lblReference.Location = new System.Drawing.Point(259, 26);
			this.lblReference.Name = "lblReference";
			this.lblReference.Size = new System.Drawing.Size(315, 26);
			this.lblReference.Text = "Reference";
			this.lblReference.TextSize = new System.Drawing.Size(92, 16);
			// 
			// grpStatus
			// 
			this.grpStatus.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpStatus.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem2});
			this.grpStatus.Location = new System.Drawing.Point(608, 160);
			this.grpStatus.Name = "grpStatus";
			this.grpStatus.Size = new System.Drawing.Size(901, 158);
			this.grpStatus.Text = "Status";
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.chkPaid;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 80);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(475, 28);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.chkPosted;
			this.layoutControlItem3.Location = new System.Drawing.Point(475, 80);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(102, 28);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.chkProtected;
			this.layoutControlItem4.Location = new System.Drawing.Point(577, 80);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(300, 28);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(877, 80);
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem4
			// 
			this.emptySpaceItem4.AllowHotTrack = false;
			this.emptySpaceItem4.Location = new System.Drawing.Point(608, 139);
			this.emptySpaceItem4.Name = "emptySpaceItem4";
			this.emptySpaceItem4.Size = new System.Drawing.Size(901, 21);
			this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
			// 
			// grpTotals
			// 
			this.grpTotals.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.grpTotals.AppearanceGroup.Options.UseFont = true;
			this.grpTotals.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.grpTotals.AppearanceItemCaption.Options.UseFont = true;
			this.grpTotals.CustomizationFormText = "Total Cost";
			this.grpTotals.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpTotals.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.TotalAmountUSD,
            this.lblTotalAmountLL,
            this.lblTotalAmount});
			this.grpTotals.Location = new System.Drawing.Point(608, 11);
			this.grpTotals.Name = "grpTotals";
			this.grpTotals.OptionsItemText.TextToControlDistance = 3;
			this.grpTotals.Size = new System.Drawing.Size(316, 128);
			this.grpTotals.Text = "Posted Voucher";
			// 
			// TotalAmountUSD
			// 
			this.TotalAmountUSD.Control = this.txtTotalAmountUSD;
			this.TotalAmountUSD.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.TotalAmountUSD.CustomizationFormText = "Total Vat";
			this.TotalAmountUSD.Location = new System.Drawing.Point(0, 52);
			this.TotalAmountUSD.Name = "TotalAmountUSD";
			this.TotalAmountUSD.Size = new System.Drawing.Size(292, 26);
			this.TotalAmountUSD.Text = "Amount USD";
			this.TotalAmountUSD.TextSize = new System.Drawing.Size(92, 18);
			// 
			// lblTotalAmountLL
			// 
			this.lblTotalAmountLL.Control = this.txtTotalAmountLL;
			this.lblTotalAmountLL.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblTotalAmountLL.CustomizationFormText = "Commission";
			this.lblTotalAmountLL.Location = new System.Drawing.Point(0, 26);
			this.lblTotalAmountLL.Name = "lblTotalAmountLL";
			this.lblTotalAmountLL.Size = new System.Drawing.Size(292, 26);
			this.lblTotalAmountLL.Text = "Amount LL";
			this.lblTotalAmountLL.TextSize = new System.Drawing.Size(92, 18);
			// 
			// lblTotalAmount
			// 
			this.lblTotalAmount.Control = this.txtTotalAmount;
			this.lblTotalAmount.Location = new System.Drawing.Point(0, 0);
			this.lblTotalAmount.Name = "lblTotalAmount";
			this.lblTotalAmount.Size = new System.Drawing.Size(292, 26);
			this.lblTotalAmount.Text = "Amount";
			this.lblTotalAmount.TextSize = new System.Drawing.Size(92, 18);
			// 
			// grpTotalPayment
			// 
			this.grpTotalPayment.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.grpTotalPayment.AppearanceGroup.Options.UseFont = true;
			this.grpTotalPayment.CustomizationFormText = "Gross Profit";
			this.grpTotalPayment.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpTotalPayment.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblTotalVATUSD,
            this.lblTotalVATLL,
            this.lblGrossCommission});
			this.grpTotalPayment.Location = new System.Drawing.Point(924, 11);
			this.grpTotalPayment.Name = "grpTotalPayment";
			this.grpTotalPayment.OptionsItemText.TextToControlDistance = 3;
			this.grpTotalPayment.Size = new System.Drawing.Size(286, 128);
			this.grpTotalPayment.Text = "Total Payments";
			// 
			// lblTotalVATUSD
			// 
			this.lblTotalVATUSD.Control = this.txtTotalPaidAmount;
			this.lblTotalVATUSD.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblTotalVATUSD.CustomizationFormText = "Total VAT USD";
			this.lblTotalVATUSD.Location = new System.Drawing.Point(0, 0);
			this.lblTotalVATUSD.Name = "lblTotalVATUSD";
			this.lblTotalVATUSD.Size = new System.Drawing.Size(262, 26);
			this.lblTotalVATUSD.Text = "Total VAT USD";
			this.lblTotalVATUSD.TextSize = new System.Drawing.Size(0, 0);
			this.lblTotalVATUSD.TextVisible = false;
			// 
			// lblTotalVATLL
			// 
			this.lblTotalVATLL.Control = this.txtTotalPaidAmountLL;
			this.lblTotalVATLL.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblTotalVATLL.CustomizationFormText = "Total VAT LL";
			this.lblTotalVATLL.Location = new System.Drawing.Point(0, 26);
			this.lblTotalVATLL.Name = "lblTotalVATLL";
			this.lblTotalVATLL.Size = new System.Drawing.Size(262, 26);
			this.lblTotalVATLL.Text = "Total VAT LL";
			this.lblTotalVATLL.TextSize = new System.Drawing.Size(0, 0);
			this.lblTotalVATLL.TextVisible = false;
			// 
			// lblGrossCommission
			// 
			this.lblGrossCommission.Control = this.txtTotalPaidAmountUSD;
			this.lblGrossCommission.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblGrossCommission.CustomizationFormText = "Gross Commission";
			this.lblGrossCommission.Location = new System.Drawing.Point(0, 52);
			this.lblGrossCommission.Name = "lblGrossCommission";
			this.lblGrossCommission.Size = new System.Drawing.Size(262, 26);
			this.lblGrossCommission.Text = "Gross Commission";
			this.lblGrossCommission.TextSize = new System.Drawing.Size(0, 0);
			this.lblGrossCommission.TextVisible = false;
			// 
			// grpRemainingAmounts
			// 
			this.grpRemainingAmounts.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.grpRemainingAmounts.AppearanceGroup.Options.UseFont = true;
			this.grpRemainingAmounts.CustomizationFormText = "Gross Profit";
			this.grpRemainingAmounts.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpRemainingAmounts.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblTotalVATUSD1,
            this.lblTotalVATLL1,
            this.lblGrossCommission1});
			this.grpRemainingAmounts.Location = new System.Drawing.Point(1210, 11);
			this.grpRemainingAmounts.Name = "grpRemainingAmounts";
			this.grpRemainingAmounts.OptionsItemText.TextToControlDistance = 3;
			this.grpRemainingAmounts.Size = new System.Drawing.Size(299, 128);
			this.grpRemainingAmounts.Text = "Remaining Amount";
			// 
			// lblTotalVATUSD1
			// 
			this.lblTotalVATUSD1.Control = this.txtRemainingAmount;
			this.lblTotalVATUSD1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblTotalVATUSD1.CustomizationFormText = "Total VAT USD";
			this.lblTotalVATUSD1.Location = new System.Drawing.Point(0, 0);
			this.lblTotalVATUSD1.Name = "lblTotalVATUSD1";
			this.lblTotalVATUSD1.Size = new System.Drawing.Size(275, 26);
			this.lblTotalVATUSD1.Text = "Total VAT USD";
			this.lblTotalVATUSD1.TextSize = new System.Drawing.Size(0, 0);
			this.lblTotalVATUSD1.TextVisible = false;
			// 
			// lblTotalVATLL1
			// 
			this.lblTotalVATLL1.Control = this.txtRemainingAmountLL;
			this.lblTotalVATLL1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblTotalVATLL1.CustomizationFormText = "Total VAT LL";
			this.lblTotalVATLL1.Location = new System.Drawing.Point(0, 26);
			this.lblTotalVATLL1.Name = "lblTotalVATLL1";
			this.lblTotalVATLL1.Size = new System.Drawing.Size(275, 26);
			this.lblTotalVATLL1.Text = "Total VAT LL";
			this.lblTotalVATLL1.TextSize = new System.Drawing.Size(0, 0);
			this.lblTotalVATLL1.TextVisible = false;
			// 
			// lblGrossCommission1
			// 
			this.lblGrossCommission1.Control = this.txtRemainingAmountUSD;
			this.lblGrossCommission1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblGrossCommission1.CustomizationFormText = "Gross Commission";
			this.lblGrossCommission1.Location = new System.Drawing.Point(0, 52);
			this.lblGrossCommission1.Name = "lblGrossCommission1";
			this.lblGrossCommission1.Size = new System.Drawing.Size(275, 26);
			this.lblGrossCommission1.Text = "Gross Commission";
			this.lblGrossCommission1.TextSize = new System.Drawing.Size(0, 0);
			this.lblGrossCommission1.TextVisible = false;
			// 
			// rpViewSettings
			// 
			this.rpViewSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup10});
			this.rpViewSettings.Name = "rpViewSettings";
			this.rpViewSettings.Text = "VIEW SETTINGS";
			// 
			// ribbonPageGroup10
			// 
			this.ribbonPageGroup10.ItemLinks.Add(this.btnResetGridStyle);
			this.ribbonPageGroup10.Name = "ribbonPageGroup10";
			this.ribbonPageGroup10.Text = "Grid Settings";
			// 
			// btnResetGridStyle
			// 
			this.btnResetGridStyle.Caption = "Reset Grid Style";
			this.btnResetGridStyle.Id = 27;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			// 
			// ReceiptEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1529, 895);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.ribbonControl);
			this.Name = "ReceiptEditForm";
			this.Ribbon = this.ribbonControl;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Edit Receipt";
			((System.ComponentModel.ISupportInitialize)(this.bsPaymentDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsPayment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCurrencies.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkProtected.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkPosted.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkPaid.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtJobNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcReceiptDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvReceiptDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repTypes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCurrencies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repPaidByusers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboDepartments.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboPaymentTypes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboMemberTypes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboMembers.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalAmountUSD.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalAmountLL.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalPaidAmount.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalPaidAmountLL.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalPaidAmountUSD.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRemainingAmount.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRemainingAmountLL.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRemainingAmountUSD.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpPaymentType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPaymentType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCurrencies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpTransactionInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDepartment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJobNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMember)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMemberType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblReference)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpTotals)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TotalAmountUSD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalAmountLL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpTotalPayment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalVATUSD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalVATLL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblGrossCommission)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpRemainingAmounts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalVATUSD1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalVATLL1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblGrossCommission1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsPaymentDetails;
        private System.Windows.Forms.BindingSource bsPayment;
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
        private DevExpress.XtraBars.BarButtonItem btnSchedule;
        private DevExpress.XtraBars.BarButtonItem btnActionPay;
        private DevExpress.XtraBars.BarCheckItem btnUndoPayment;
        private DevExpress.XtraBars.BarStaticItem msgBarText;
        private DevExpress.XtraBars.BarCheckItem btnApprove;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgActions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraEditors.TextEdit txtRate;
        private DevExpress.XtraEditors.LookUpEdit cboCurrencies;
        private DevExpress.XtraEditors.TextEdit txtTotalAmount;
        private DevExpress.XtraEditors.CheckEdit chkProtected;
        private DevExpress.XtraEditors.CheckEdit chkPosted;
        private DevExpress.XtraEditors.CheckEdit chkPaid;
        private DevExpress.XtraEditors.TextEdit txtReference;
        private DevExpress.XtraEditors.TextEdit txtJobNo;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraGrid.GridControl gcReceiptDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReceiptDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentId;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTypes;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceId;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCurrencies;
        private DevExpress.XtraGrid.Columns.GridColumn colRate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colLAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colFAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovedDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovedDateDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovedByDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repPaidByusers;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidByDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.LookUpEdit cboDepartments;
        private DevExpress.XtraEditors.LookUpEdit cboPaymentTypes;
        private DevExpress.XtraEditors.LookUpEdit cboMemberTypes;
        private DevExpress.XtraEditors.SearchLookUpEdit cboMembers;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberId;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberName;
        private DevExpress.XtraEditors.TextEdit txtTotalAmountUSD;
        private DevExpress.XtraEditors.TextEdit txtTotalAmountLL;
        private DevExpress.XtraEditors.TextEdit txtTotalPaidAmount;
        private DevExpress.XtraEditors.TextEdit txtTotalPaidAmountLL;
        private DevExpress.XtraEditors.TextEdit txtTotalPaidAmountUSD;
        private DevExpress.XtraEditors.TextEdit txtRemainingAmount;
        private DevExpress.XtraEditors.TextEdit txtRemainingAmountLL;
        private DevExpress.XtraEditors.TextEdit txtRemainingAmountUSD;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.LayoutControlGroup grpPaymentType;
        private DevExpress.XtraLayout.LayoutControlItem lblId;
        private DevExpress.XtraLayout.LayoutControlItem lblPaymentType;
        private DevExpress.XtraLayout.LayoutControlItem lblCurrencies;
        private DevExpress.XtraLayout.LayoutControlItem lblRate;
        private DevExpress.XtraLayout.LayoutControlGroup grpTransactionInfo;
        private DevExpress.XtraLayout.LayoutControlItem lblDepartment;
        private DevExpress.XtraLayout.LayoutControlItem lblJobNo;
        private DevExpress.XtraLayout.LayoutControlItem lblMember;
        private DevExpress.XtraLayout.LayoutControlItem lblMemberType;
        private DevExpress.XtraLayout.LayoutControlItem lblReference;
        private DevExpress.XtraLayout.LayoutControlGroup grpStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlGroup grpTotals;
        private DevExpress.XtraLayout.LayoutControlItem TotalAmountUSD;
        private DevExpress.XtraLayout.LayoutControlItem lblTotalAmountLL;
        private DevExpress.XtraLayout.LayoutControlItem lblTotalAmount;
        private DevExpress.XtraLayout.LayoutControlGroup grpTotalPayment;
        private DevExpress.XtraLayout.LayoutControlItem lblTotalVATUSD;
        private DevExpress.XtraLayout.LayoutControlItem lblTotalVATLL;
        private DevExpress.XtraLayout.LayoutControlItem lblGrossCommission;
        private DevExpress.XtraLayout.LayoutControlGroup grpRemainingAmounts;
        private DevExpress.XtraLayout.LayoutControlItem lblTotalVATUSD1;
        private DevExpress.XtraLayout.LayoutControlItem lblTotalVATLL1;
        private DevExpress.XtraLayout.LayoutControlItem lblGrossCommission1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
	}
}