namespace MISLiveMed.UI.Accounting.Costs
{
    partial class CostEditForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostEditForm));
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem8 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem9 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem10 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem11 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem12 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnSave = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.btnSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.rgJobStatusAction = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.rpMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			this.layoutTotals = new DevExpress.XtraLayout.LayoutControl();
			this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			this.txtGrandTotal = new DevExpress.XtraEditors.TextEdit();
			this.txtTotalVAT = new DevExpress.XtraEditors.TextEdit();
			this.txtItemVAT = new DevExpress.XtraEditors.TextEdit();
			this.txtItemNoVAT = new DevExpress.XtraEditors.TextEdit();
			this.txtSubTotal = new DevExpress.XtraEditors.TextEdit();
			this.lblGrandTotal = new DevExpress.XtraEditors.LabelControl();
			this.lblTotalVat = new DevExpress.XtraEditors.LabelControl();
			this.lblItemVAT = new DevExpress.XtraEditors.LabelControl();
			this.lblItemNoVAT = new DevExpress.XtraEditors.LabelControl();
			this.lblSubTotal = new DevExpress.XtraEditors.LabelControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.gcCostDetails = new DevExpress.XtraGrid.GridControl();
			this.gvCostDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSheetId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReference = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProvisionAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLProvisionAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFProvisionAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsProtected = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLocked = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCurrencies = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.xtraTabInfo = new DevExpress.XtraTab.XtraTabControl();
			this.tabCostInfo = new DevExpress.XtraTab.XtraTabPage();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.tablePanelCostInfo = new DevExpress.Utils.Layout.TablePanel();
			this.supplierInfoLayout = new DevExpress.XtraLayout.LayoutControl();
			this.txtSupplierInvoiceNo = new DevExpress.XtraEditors.TextEdit();
			this.txtSupplierInvocieReference = new DevExpress.XtraEditors.TextEdit();
			this.txtAmountSettled = new DevExpress.XtraEditors.TextEdit();
			this.dtDateOfPayment = new DevExpress.XtraEditors.DateEdit();
			this.dtDateOfInvoice = new DevExpress.XtraEditors.DateEdit();
			this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.grpSupplierInfo = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblDateOfInvoice = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblDateOfPayment = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblSupplierInvoiceNo = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblSupplierInvocieReference = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblAmountSettled = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.costInfoLayout = new DevExpress.XtraLayout.LayoutControl();
			this.lblRateInfo = new DevExpress.XtraEditors.LabelControl();
			this.txtRate = new DevExpress.XtraEditors.TextEdit();
			this.cboCurrencies = new DevExpress.XtraEditors.LookUpEdit();
			this.cboPaymentMethod = new DevExpress.XtraEditors.LookUpEdit();
			this.cboMembers = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.dtCostDate = new DevExpress.XtraEditors.DateEdit();
			this.txtCostNo = new DevExpress.XtraEditors.TextEdit();
			this.cboOperationType = new DevExpress.XtraEditors.LookUpEdit();
			this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.grCostInfo = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblCostNo = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblCostDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblToTheOrderOf = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblMembers = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblPaymentMethod = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem14 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblCurrency = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblRate = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblRateInfoControl = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem13 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.tabFileDetails = new DevExpress.XtraTab.XtraTabPage();
			this.fileDetailsLayout = new DevExpress.XtraLayout.LayoutControl();
			this.tablePanelFileDetails = new DevExpress.Utils.Layout.TablePanel();
			this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
			this.cboModifiedBy = new DevExpress.XtraEditors.LookUpEdit();
			this.cboCreatedBy = new DevExpress.XtraEditors.LookUpEdit();
			this.chkPosted = new DevExpress.XtraEditors.CheckEdit();
			this.chkProtected = new DevExpress.XtraEditors.CheckEdit();
			this.cboDepartments = new DevExpress.XtraEditors.LookUpEdit();
			this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblCreatedBy = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblModifiedBy = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblDepartment = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
			this.txtJvNo = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup8 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlGroup9 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblJvNo = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
			this.tablePanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutTotals)).BeginInit();
			this.layoutTotals.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
			this.tablePanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtGrandTotal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalVAT.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtItemVAT.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtItemNoVAT.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcCostDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCostDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCurrencies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabInfo)).BeginInit();
			this.xtraTabInfo.SuspendLayout();
			this.tabCostInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablePanelCostInfo)).BeginInit();
			this.tablePanelCostInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.supplierInfoLayout)).BeginInit();
			this.supplierInfoLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtSupplierInvoiceNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSupplierInvocieReference.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAmountSettled.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDateOfPayment.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDateOfPayment.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDateOfInvoice.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDateOfInvoice.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpSupplierInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDateOfInvoice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDateOfPayment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSupplierInvoiceNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSupplierInvocieReference)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAmountSettled)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.costInfoLayout)).BeginInit();
			this.costInfoLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCurrencies.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboPaymentMethod.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboMembers.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtCostDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtCostDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCostNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboOperationType.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grCostInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCostNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCostDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblToTheOrderOf)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMembers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPaymentMethod)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCurrency)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblRateInfoControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			this.tabFileDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileDetailsLayout)).BeginInit();
			this.fileDetailsLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablePanelFileDetails)).BeginInit();
			this.tablePanelFileDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
			this.layoutControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboModifiedBy.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCreatedBy.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkPosted.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkProtected.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboDepartments.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCreatedBy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblModifiedBy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDepartment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
			this.layoutControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtJvNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJvNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.btnPrint,
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
			this.ribbonControl.Size = new System.Drawing.Size(1447, 197);
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
			this.rgJobStatusAction.Caption = "Actions";
			// 
			// 
			// 
			this.rgJobStatusAction.Gallery.ColumnCount = 3;
			this.rgJobStatusAction.Gallery.DrawImageBackground = false;
			galleryItemGroup2.Caption = "ActionGroup";
			galleryItem7.Caption = "Normal Mod";
			galleryItem7.Checked = true;
			galleryItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
			galleryItem7.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem7.Value = 0;
			galleryItem8.Caption = "Close current Job";
			galleryItem8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
			galleryItem8.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem8.Value = 1;
			galleryItem9.Caption = "Edit closed Job";
			galleryItem9.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
			galleryItem9.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem9.Value = 2;
			galleryItem10.Caption = "Cancel current File";
			galleryItem10.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage3")));
			galleryItem10.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem10.Value = 3;
			galleryItem11.Caption = "ReOpen canceled File";
			galleryItem11.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage4")));
			galleryItem11.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem11.Value = 4;
			galleryItem12.Caption = "N/A";
			galleryItem12.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage5")));
			galleryItem12.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem12.Value = 5;
			galleryItemGroup2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem7,
            galleryItem8,
            galleryItem9,
            galleryItem10,
            galleryItem11,
            galleryItem12});
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
            this.ribbonPageGroup7,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup3,
            this.ribbonPageGroup9});
			this.rpMain.Name = "rpMain";
			this.rpMain.Text = "COSTSHEET";
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
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 760);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.ribbonControl;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1447, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.tablePanel1);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 197);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1447, 563);
			this.mainLayout.TabIndex = 23;
			this.mainLayout.Text = "layoutControl1";
			// 
			// tablePanel1
			// 
			this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 69.74F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30.26F)});
			this.tablePanel1.Controls.Add(this.layoutTotals);
			this.tablePanel1.Controls.Add(this.gcCostDetails);
			this.tablePanel1.Controls.Add(this.xtraTabInfo);
			this.tablePanel1.Location = new System.Drawing.Point(14, 14);
			this.tablePanel1.Name = "tablePanel1";
			this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 281.1998F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 56.40025F)});
			this.tablePanel1.Size = new System.Drawing.Size(1419, 535);
			this.tablePanel1.TabIndex = 4;
			this.tablePanel1.UseSkinIndents = true;
			// 
			// layoutTotals
			// 
			this.tablePanel1.SetColumn(this.layoutTotals, 1);
			this.layoutTotals.Controls.Add(this.tablePanel2);
			this.layoutTotals.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutTotals.Location = new System.Drawing.Point(986, 14);
			this.layoutTotals.Name = "layoutTotals";
			this.layoutTotals.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 135, 812, 500);
			this.layoutTotals.Root = this.layoutControlGroup1;
			this.tablePanel1.SetRow(this.layoutTotals, 0);
			this.layoutTotals.Size = new System.Drawing.Size(418, 277);
			this.layoutTotals.TabIndex = 3;
			this.layoutTotals.Text = "layoutControl2";
			// 
			// tablePanel2
			// 
			this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 36.56F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 63.44F)});
			this.tablePanel2.Controls.Add(this.txtGrandTotal);
			this.tablePanel2.Controls.Add(this.txtTotalVAT);
			this.tablePanel2.Controls.Add(this.txtItemVAT);
			this.tablePanel2.Controls.Add(this.txtItemNoVAT);
			this.tablePanel2.Controls.Add(this.txtSubTotal);
			this.tablePanel2.Controls.Add(this.lblGrandTotal);
			this.tablePanel2.Controls.Add(this.lblTotalVat);
			this.tablePanel2.Controls.Add(this.lblItemVAT);
			this.tablePanel2.Controls.Add(this.lblItemNoVAT);
			this.tablePanel2.Controls.Add(this.lblSubTotal);
			this.tablePanel2.Location = new System.Drawing.Point(14, 14);
			this.tablePanel2.Name = "tablePanel2";
			this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F)});
			this.tablePanel2.Size = new System.Drawing.Size(390, 249);
			this.tablePanel2.TabIndex = 4;
			this.tablePanel2.UseSkinIndents = true;
			// 
			// txtGrandTotal
			// 
			this.tablePanel2.SetColumn(this.txtGrandTotal, 1);
			this.txtGrandTotal.Location = new System.Drawing.Point(148, 172);
			this.txtGrandTotal.MenuManager = this.ribbonControl;
			this.txtGrandTotal.Name = "txtGrandTotal";
			this.txtGrandTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGrandTotal.Properties.Appearance.Options.UseFont = true;
			this.txtGrandTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtGrandTotal.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
			this.txtGrandTotal.Properties.MaskSettings.Set("mask", "n");
			this.txtGrandTotal.Properties.ReadOnly = true;
			this.txtGrandTotal.Properties.UseMaskAsDisplayFormat = true;
			this.tablePanel2.SetRow(this.txtGrandTotal, 4);
			this.txtGrandTotal.Size = new System.Drawing.Size(227, 24);
			this.txtGrandTotal.TabIndex = 9;
			this.txtGrandTotal.TabStop = false;
			// 
			// txtTotalVAT
			// 
			this.tablePanel2.SetColumn(this.txtTotalVAT, 1);
			this.txtTotalVAT.Location = new System.Drawing.Point(148, 106);
			this.txtTotalVAT.MenuManager = this.ribbonControl;
			this.txtTotalVAT.Name = "txtTotalVAT";
			this.txtTotalVAT.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtTotalVAT.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
			this.txtTotalVAT.Properties.MaskSettings.Set("mask", "n");
			this.txtTotalVAT.Properties.ReadOnly = true;
			this.txtTotalVAT.Properties.UseMaskAsDisplayFormat = true;
			this.tablePanel2.SetRow(this.txtTotalVAT, 3);
			this.txtTotalVAT.Size = new System.Drawing.Size(227, 22);
			this.txtTotalVAT.TabIndex = 8;
			this.txtTotalVAT.TabStop = false;
			// 
			// txtItemVAT
			// 
			this.tablePanel2.SetColumn(this.txtItemVAT, 1);
			this.txtItemVAT.Location = new System.Drawing.Point(148, 76);
			this.txtItemVAT.MenuManager = this.ribbonControl;
			this.txtItemVAT.Name = "txtItemVAT";
			this.txtItemVAT.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtItemVAT.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
			this.txtItemVAT.Properties.MaskSettings.Set("mask", "n");
			this.txtItemVAT.Properties.ReadOnly = true;
			this.txtItemVAT.Properties.UseMaskAsDisplayFormat = true;
			this.tablePanel2.SetRow(this.txtItemVAT, 2);
			this.txtItemVAT.Size = new System.Drawing.Size(227, 22);
			this.txtItemVAT.TabIndex = 7;
			this.txtItemVAT.TabStop = false;
			// 
			// txtItemNoVAT
			// 
			this.tablePanel2.SetColumn(this.txtItemNoVAT, 1);
			this.txtItemNoVAT.Location = new System.Drawing.Point(148, 46);
			this.txtItemNoVAT.MenuManager = this.ribbonControl;
			this.txtItemNoVAT.Name = "txtItemNoVAT";
			this.txtItemNoVAT.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtItemNoVAT.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
			this.txtItemNoVAT.Properties.MaskSettings.Set("mask", "n");
			this.txtItemNoVAT.Properties.ReadOnly = true;
			this.txtItemNoVAT.Properties.UseMaskAsDisplayFormat = true;
			this.tablePanel2.SetRow(this.txtItemNoVAT, 1);
			this.txtItemNoVAT.Size = new System.Drawing.Size(227, 22);
			this.txtItemNoVAT.TabIndex = 6;
			this.txtItemNoVAT.TabStop = false;
			// 
			// txtSubTotal
			// 
			this.tablePanel2.SetColumn(this.txtSubTotal, 1);
			this.txtSubTotal.Location = new System.Drawing.Point(148, 16);
			this.txtSubTotal.MenuManager = this.ribbonControl;
			this.txtSubTotal.Name = "txtSubTotal";
			this.txtSubTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtSubTotal.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
			this.txtSubTotal.Properties.MaskSettings.Set("mask", "n");
			this.txtSubTotal.Properties.ReadOnly = true;
			this.txtSubTotal.Properties.UseMaskAsDisplayFormat = true;
			this.tablePanel2.SetRow(this.txtSubTotal, 0);
			this.txtSubTotal.Size = new System.Drawing.Size(227, 22);
			this.txtSubTotal.TabIndex = 5;
			this.txtSubTotal.TabStop = false;
			// 
			// lblGrandTotal
			// 
			this.lblGrandTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGrandTotal.Appearance.Options.UseFont = true;
			this.tablePanel2.SetColumn(this.lblGrandTotal, 0);
			this.lblGrandTotal.Location = new System.Drawing.Point(15, 175);
			this.lblGrandTotal.Name = "lblGrandTotal";
			this.tablePanel2.SetRow(this.lblGrandTotal, 4);
			this.lblGrandTotal.Size = new System.Drawing.Size(87, 18);
			this.lblGrandTotal.TabIndex = 4;
			this.lblGrandTotal.Text = "Grand Total";
			// 
			// lblTotalVat
			// 
			this.tablePanel2.SetColumn(this.lblTotalVat, 0);
			this.lblTotalVat.Location = new System.Drawing.Point(15, 109);
			this.lblTotalVat.Name = "lblTotalVat";
			this.tablePanel2.SetRow(this.lblTotalVat, 3);
			this.lblTotalVat.Size = new System.Drawing.Size(57, 16);
			this.lblTotalVat.TabIndex = 3;
			this.lblTotalVat.Text = "Total VAT";
			// 
			// lblItemVAT
			// 
			this.tablePanel2.SetColumn(this.lblItemVAT, 0);
			this.lblItemVAT.Location = new System.Drawing.Point(15, 79);
			this.lblItemVAT.Name = "lblItemVAT";
			this.tablePanel2.SetRow(this.lblItemVAT, 2);
			this.lblItemVAT.Size = new System.Drawing.Size(60, 16);
			this.lblItemVAT.TabIndex = 2;
			this.lblItemVAT.Text = "Items VAT";
			// 
			// lblItemNoVAT
			// 
			this.tablePanel2.SetColumn(this.lblItemNoVAT, 0);
			this.lblItemNoVAT.Location = new System.Drawing.Point(15, 49);
			this.lblItemNoVAT.Name = "lblItemNoVAT";
			this.tablePanel2.SetRow(this.lblItemNoVAT, 1);
			this.lblItemNoVAT.Size = new System.Drawing.Size(86, 16);
			this.lblItemNoVAT.TabIndex = 1;
			this.lblItemNoVAT.Text = "Items Non VAT";
			// 
			// lblSubTotal
			// 
			this.tablePanel2.SetColumn(this.lblSubTotal, 0);
			this.lblSubTotal.Location = new System.Drawing.Point(15, 19);
			this.lblSubTotal.Name = "lblSubTotal";
			this.tablePanel2.SetRow(this.lblSubTotal, 0);
			this.lblSubTotal.Size = new System.Drawing.Size(55, 16);
			this.lblSubTotal.TabIndex = 0;
			this.lblSubTotal.Text = "Sub Total";
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(418, 277);
			this.layoutControlGroup1.Text = "Totals";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.tablePanel2;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(394, 253);
			this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem3.TextVisible = false;
			// 
			// gcCostDetails
			// 
			this.tablePanel1.SetColumn(this.gcCostDetails, 0);
			this.tablePanel1.SetColumnSpan(this.gcCostDetails, 2);
			this.gcCostDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcCostDetails.Location = new System.Drawing.Point(15, 295);
			this.gcCostDetails.MainView = this.gvCostDetails;
			this.gcCostDetails.MenuManager = this.ribbonControl;
			this.gcCostDetails.Name = "gcCostDetails";
			this.gcCostDetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCurrencies,
            this.repCheckBox});
			this.tablePanel1.SetRow(this.gcCostDetails, 1);
			this.gcCostDetails.Size = new System.Drawing.Size(1389, 225);
			this.gcCostDetails.TabIndex = 0;
			this.gcCostDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCostDetails});
			// 
			// gvCostDetails
			// 
			this.gvCostDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSheetId,
            this.colReference,
            this.colItemId,
            this.colDescription,
            this.colAmount,
            this.colLAmount,
            this.colFAmount,
            this.colProvisionAmount,
            this.colLProvisionAmount,
            this.colFProvisionAmount,
            this.colNotes,
            this.colIsProtected,
            this.colActive,
            this.colLocked});
			this.gvCostDetails.GridControl = this.gcCostDetails;
			this.gvCostDetails.Name = "gvCostDetails";
			this.gvCostDetails.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
			this.gvCostDetails.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
			this.gvCostDetails.OptionsNavigation.AutoFocusNewRow = true;
			this.gvCostDetails.OptionsNavigation.EnterMoveNextColumn = true;
			this.gvCostDetails.OptionsPrint.AutoWidth = false;
			this.gvCostDetails.OptionsView.ColumnAutoWidth = false;
			this.gvCostDetails.OptionsView.ShowGroupPanel = false;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Width = 52;
			// 
			// colSheetId
			// 
			this.colSheetId.FieldName = "SheetId";
			this.colSheetId.MinWidth = 25;
			this.colSheetId.Name = "colSheetId";
			this.colSheetId.Width = 70;
			// 
			// colReference
			// 
			this.colReference.FieldName = "Reference";
			this.colReference.MinWidth = 25;
			this.colReference.Name = "colReference";
			this.colReference.Visible = true;
			this.colReference.VisibleIndex = 0;
			this.colReference.Width = 300;
			// 
			// colItemId
			// 
			this.colItemId.Caption = "Item Code";
			this.colItemId.FieldName = "ItemId";
			this.colItemId.MinWidth = 25;
			this.colItemId.Name = "colItemId";
			this.colItemId.Visible = true;
			this.colItemId.VisibleIndex = 1;
			this.colItemId.Width = 100;
			// 
			// colDescription
			// 
			this.colDescription.FieldName = "Description";
			this.colDescription.MinWidth = 25;
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 2;
			this.colDescription.Width = 300;
			// 
			// colAmount
			// 
			this.colAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colAmount.FieldName = "Amount";
			this.colAmount.GroupFormat.FormatString = "{0:n2}";
			this.colAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colAmount.MinWidth = 25;
			this.colAmount.Name = "colAmount";
			this.colAmount.Visible = true;
			this.colAmount.VisibleIndex = 3;
			this.colAmount.Width = 150;
			// 
			// colLAmount
			// 
			this.colLAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colLAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colLAmount.FieldName = "LAmount";
			this.colLAmount.GroupFormat.FormatString = "{0:n2}";
			this.colLAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colLAmount.MinWidth = 25;
			this.colLAmount.Name = "colLAmount";
			this.colLAmount.Visible = true;
			this.colLAmount.VisibleIndex = 4;
			this.colLAmount.Width = 150;
			// 
			// colFAmount
			// 
			this.colFAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colFAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colFAmount.FieldName = "FAmount";
			this.colFAmount.GroupFormat.FormatString = "{0:n2}";
			this.colFAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colFAmount.MinWidth = 25;
			this.colFAmount.Name = "colFAmount";
			this.colFAmount.Visible = true;
			this.colFAmount.VisibleIndex = 5;
			this.colFAmount.Width = 150;
			// 
			// colProvisionAmount
			// 
			this.colProvisionAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colProvisionAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colProvisionAmount.FieldName = "ProvisionAmount";
			this.colProvisionAmount.GroupFormat.FormatString = "{0:n2}";
			this.colProvisionAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colProvisionAmount.MinWidth = 25;
			this.colProvisionAmount.Name = "colProvisionAmount";
			this.colProvisionAmount.Width = 150;
			// 
			// colLProvisionAmount
			// 
			this.colLProvisionAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colLProvisionAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colLProvisionAmount.FieldName = "LProvisionAmount";
			this.colLProvisionAmount.GroupFormat.FormatString = "{0:n2}";
			this.colLProvisionAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colLProvisionAmount.MinWidth = 25;
			this.colLProvisionAmount.Name = "colLProvisionAmount";
			this.colLProvisionAmount.Width = 150;
			// 
			// colFProvisionAmount
			// 
			this.colFProvisionAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colFProvisionAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colFProvisionAmount.FieldName = "FProvisionAmount";
			this.colFProvisionAmount.GroupFormat.FormatString = "{0:n2}";
			this.colFProvisionAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colFProvisionAmount.MinWidth = 25;
			this.colFProvisionAmount.Name = "colFProvisionAmount";
			this.colFProvisionAmount.Width = 150;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 6;
			this.colNotes.Width = 300;
			// 
			// colIsProtected
			// 
			this.colIsProtected.ColumnEdit = this.repCheckBox;
			this.colIsProtected.FieldName = "IsProtected";
			this.colIsProtected.MinWidth = 25;
			this.colIsProtected.Name = "colIsProtected";
			this.colIsProtected.Visible = true;
			this.colIsProtected.VisibleIndex = 7;
			this.colIsProtected.Width = 94;
			// 
			// repCheckBox
			// 
			this.repCheckBox.AutoHeight = false;
			this.repCheckBox.Name = "repCheckBox";
			// 
			// colActive
			// 
			this.colActive.ColumnEdit = this.repCheckBox;
			this.colActive.FieldName = "Active";
			this.colActive.MinWidth = 25;
			this.colActive.Name = "colActive";
			this.colActive.Visible = true;
			this.colActive.VisibleIndex = 8;
			this.colActive.Width = 94;
			// 
			// colLocked
			// 
			this.colLocked.ColumnEdit = this.repCheckBox;
			this.colLocked.FieldName = "Locked";
			this.colLocked.MinWidth = 25;
			this.colLocked.Name = "colLocked";
			this.colLocked.Visible = true;
			this.colLocked.VisibleIndex = 9;
			this.colLocked.Width = 94;
			// 
			// repCurrencies
			// 
			this.repCurrencies.AutoHeight = false;
			this.repCurrencies.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCurrencies.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCode", "Currency", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repCurrencies.DisplayMember = "CurrencyCode";
			this.repCurrencies.Name = "repCurrencies";
			this.repCurrencies.NullText = "";
			this.repCurrencies.ValueMember = "Id";
			// 
			// xtraTabInfo
			// 
			this.tablePanel1.SetColumn(this.xtraTabInfo, 0);
			this.xtraTabInfo.Location = new System.Drawing.Point(15, 14);
			this.xtraTabInfo.Name = "xtraTabInfo";
			this.tablePanel1.SetRow(this.xtraTabInfo, 0);
			this.xtraTabInfo.SelectedTabPage = this.tabCostInfo;
			this.xtraTabInfo.Size = new System.Drawing.Size(967, 277);
			this.xtraTabInfo.TabIndex = 1;
			this.xtraTabInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabCostInfo,
            this.tabFileDetails});
			// 
			// tabCostInfo
			// 
			this.tabCostInfo.Controls.Add(this.layoutControl1);
			this.tabCostInfo.Name = "tabCostInfo";
			this.tabCostInfo.Size = new System.Drawing.Size(965, 247);
			this.tabCostInfo.Text = "Cost Info";
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.tablePanelCostInfo);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup2;
			this.layoutControl1.Size = new System.Drawing.Size(965, 247);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// tablePanelCostInfo
			// 
			this.tablePanelCostInfo.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 67.71F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.29F)});
			this.tablePanelCostInfo.Controls.Add(this.supplierInfoLayout);
			this.tablePanelCostInfo.Controls.Add(this.costInfoLayout);
			this.tablePanelCostInfo.Location = new System.Drawing.Point(14, 14);
			this.tablePanelCostInfo.Margin = new System.Windows.Forms.Padding(1);
			this.tablePanelCostInfo.Name = "tablePanelCostInfo";
			this.tablePanelCostInfo.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 124.0001F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 32F)});
			this.tablePanelCostInfo.Size = new System.Drawing.Size(937, 219);
			this.tablePanelCostInfo.TabIndex = 13;
			// 
			// supplierInfoLayout
			// 
			this.tablePanelCostInfo.SetColumn(this.supplierInfoLayout, 1);
			this.supplierInfoLayout.Controls.Add(this.txtSupplierInvoiceNo);
			this.supplierInfoLayout.Controls.Add(this.txtSupplierInvocieReference);
			this.supplierInfoLayout.Controls.Add(this.txtAmountSettled);
			this.supplierInfoLayout.Controls.Add(this.dtDateOfPayment);
			this.supplierInfoLayout.Controls.Add(this.dtDateOfInvoice);
			this.supplierInfoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.supplierInfoLayout.Location = new System.Drawing.Point(637, 3);
			this.supplierInfoLayout.Name = "supplierInfoLayout";
			this.supplierInfoLayout.Root = this.layoutControlGroup4;
			this.tablePanelCostInfo.SetRow(this.supplierInfoLayout, 0);
			this.tablePanelCostInfo.SetRowSpan(this.supplierInfoLayout, 2);
			this.supplierInfoLayout.Size = new System.Drawing.Size(297, 213);
			this.supplierInfoLayout.TabIndex = 1;
			this.supplierInfoLayout.Text = "layoutControl2";
			// 
			// txtSupplierInvoiceNo
			// 
			this.txtSupplierInvoiceNo.Location = new System.Drawing.Point(137, 114);
			this.txtSupplierInvoiceNo.MenuManager = this.ribbonControl;
			this.txtSupplierInvoiceNo.Name = "txtSupplierInvoiceNo";
			this.txtSupplierInvoiceNo.Size = new System.Drawing.Size(145, 22);
			this.txtSupplierInvoiceNo.StyleController = this.supplierInfoLayout;
			this.txtSupplierInvoiceNo.TabIndex = 8;
			// 
			// txtSupplierInvocieReference
			// 
			this.txtSupplierInvocieReference.Location = new System.Drawing.Point(137, 140);
			this.txtSupplierInvocieReference.MenuManager = this.ribbonControl;
			this.txtSupplierInvocieReference.Name = "txtSupplierInvocieReference";
			this.txtSupplierInvocieReference.Size = new System.Drawing.Size(145, 22);
			this.txtSupplierInvocieReference.StyleController = this.supplierInfoLayout;
			this.txtSupplierInvocieReference.TabIndex = 7;
			// 
			// txtAmountSettled
			// 
			this.txtAmountSettled.Location = new System.Drawing.Point(137, 166);
			this.txtAmountSettled.MenuManager = this.ribbonControl;
			this.txtAmountSettled.Name = "txtAmountSettled";
			this.txtAmountSettled.Size = new System.Drawing.Size(145, 22);
			this.txtAmountSettled.StyleController = this.supplierInfoLayout;
			this.txtAmountSettled.TabIndex = 6;
			// 
			// dtDateOfPayment
			// 
			this.dtDateOfPayment.EditValue = null;
			this.dtDateOfPayment.Location = new System.Drawing.Point(137, 67);
			this.dtDateOfPayment.MenuManager = this.ribbonControl;
			this.dtDateOfPayment.Name = "dtDateOfPayment";
			this.dtDateOfPayment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtDateOfPayment.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtDateOfPayment.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtDateOfPayment.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtDateOfPayment.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtDateOfPayment.Properties.UseMaskAsDisplayFormat = true;
			this.dtDateOfPayment.Size = new System.Drawing.Size(145, 22);
			this.dtDateOfPayment.StyleController = this.supplierInfoLayout;
			this.dtDateOfPayment.TabIndex = 5;
			// 
			// dtDateOfInvoice
			// 
			this.dtDateOfInvoice.EditValue = null;
			this.dtDateOfInvoice.Location = new System.Drawing.Point(137, 41);
			this.dtDateOfInvoice.MenuManager = this.ribbonControl;
			this.dtDateOfInvoice.Name = "dtDateOfInvoice";
			this.dtDateOfInvoice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtDateOfInvoice.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtDateOfInvoice.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtDateOfInvoice.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtDateOfInvoice.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtDateOfInvoice.Properties.UseMaskAsDisplayFormat = true;
			this.dtDateOfInvoice.Size = new System.Drawing.Size(145, 22);
			this.dtDateOfInvoice.StyleController = this.supplierInfoLayout;
			this.dtDateOfInvoice.TabIndex = 4;
			// 
			// layoutControlGroup4
			// 
			this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup4.GroupBordersVisible = false;
			this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.grpSupplierInfo,
            this.emptySpaceItem3});
			this.layoutControlGroup4.Name = "layoutControlGroup4";
			this.layoutControlGroup4.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
			this.layoutControlGroup4.Size = new System.Drawing.Size(297, 213);
			this.layoutControlGroup4.TextVisible = false;
			// 
			// grpSupplierInfo
			// 
			this.grpSupplierInfo.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpSupplierInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblDateOfInvoice,
            this.lblDateOfPayment,
            this.lblSupplierInvoiceNo,
            this.lblSupplierInvocieReference,
            this.lblAmountSettled,
            this.emptySpaceItem2});
			this.grpSupplierInfo.Location = new System.Drawing.Point(0, 0);
			this.grpSupplierInfo.Name = "grpSupplierInfo";
			this.grpSupplierInfo.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
			this.grpSupplierInfo.Size = new System.Drawing.Size(295, 201);
			this.grpSupplierInfo.Text = "Supplier Info";
			// 
			// lblDateOfInvoice
			// 
			this.lblDateOfInvoice.Control = this.dtDateOfInvoice;
			this.lblDateOfInvoice.Location = new System.Drawing.Point(0, 0);
			this.lblDateOfInvoice.Name = "lblDateOfInvoice";
			this.lblDateOfInvoice.Size = new System.Drawing.Size(271, 26);
			this.lblDateOfInvoice.Text = "Date of Invoice";
			this.lblDateOfInvoice.TextSize = new System.Drawing.Size(110, 16);
			// 
			// lblDateOfPayment
			// 
			this.lblDateOfPayment.Control = this.dtDateOfPayment;
			this.lblDateOfPayment.Location = new System.Drawing.Point(0, 26);
			this.lblDateOfPayment.Name = "lblDateOfPayment";
			this.lblDateOfPayment.Size = new System.Drawing.Size(271, 26);
			this.lblDateOfPayment.Text = "Date of Payment";
			this.lblDateOfPayment.TextSize = new System.Drawing.Size(110, 16);
			// 
			// lblSupplierInvoiceNo
			// 
			this.lblSupplierInvoiceNo.Control = this.txtSupplierInvoiceNo;
			this.lblSupplierInvoiceNo.Location = new System.Drawing.Point(0, 73);
			this.lblSupplierInvoiceNo.Name = "lblSupplierInvoiceNo";
			this.lblSupplierInvoiceNo.Size = new System.Drawing.Size(271, 26);
			this.lblSupplierInvoiceNo.Text = "Supplier Invoice No";
			this.lblSupplierInvoiceNo.TextSize = new System.Drawing.Size(110, 16);
			// 
			// lblSupplierInvocieReference
			// 
			this.lblSupplierInvocieReference.Control = this.txtSupplierInvocieReference;
			this.lblSupplierInvocieReference.Location = new System.Drawing.Point(0, 99);
			this.lblSupplierInvocieReference.Name = "lblSupplierInvocieReference";
			this.lblSupplierInvocieReference.Size = new System.Drawing.Size(271, 26);
			this.lblSupplierInvocieReference.Text = "Reference";
			this.lblSupplierInvocieReference.TextSize = new System.Drawing.Size(110, 16);
			// 
			// lblAmountSettled
			// 
			this.lblAmountSettled.Control = this.txtAmountSettled;
			this.lblAmountSettled.Location = new System.Drawing.Point(0, 125);
			this.lblAmountSettled.Name = "lblAmountSettled";
			this.lblAmountSettled.Size = new System.Drawing.Size(271, 26);
			this.lblAmountSettled.Text = "Amount Settled";
			this.lblAmountSettled.TextSize = new System.Drawing.Size(110, 16);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 52);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(271, 21);
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.Location = new System.Drawing.Point(0, 201);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(295, 10);
			// 
			// costInfoLayout
			// 
			this.tablePanelCostInfo.SetColumn(this.costInfoLayout, 0);
			this.costInfoLayout.Controls.Add(this.lblRateInfo);
			this.costInfoLayout.Controls.Add(this.txtRate);
			this.costInfoLayout.Controls.Add(this.cboCurrencies);
			this.costInfoLayout.Controls.Add(this.cboPaymentMethod);
			this.costInfoLayout.Controls.Add(this.cboMembers);
			this.costInfoLayout.Controls.Add(this.dtCostDate);
			this.costInfoLayout.Controls.Add(this.txtCostNo);
			this.costInfoLayout.Controls.Add(this.cboOperationType);
			this.costInfoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.costInfoLayout.Location = new System.Drawing.Point(3, 3);
			this.costInfoLayout.Name = "costInfoLayout";
			this.costInfoLayout.Root = this.layoutControlGroup3;
			this.tablePanelCostInfo.SetRow(this.costInfoLayout, 0);
			this.tablePanelCostInfo.SetRowSpan(this.costInfoLayout, 2);
			this.costInfoLayout.Size = new System.Drawing.Size(628, 213);
			this.costInfoLayout.TabIndex = 0;
			this.costInfoLayout.Text = "layoutControl2";
			// 
			// lblRateInfo
			// 
			this.lblRateInfo.Location = new System.Drawing.Point(315, 184);
			this.lblRateInfo.Name = "lblRateInfo";
			this.lblRateInfo.Size = new System.Drawing.Size(99, 16);
			this.lblRateInfo.StyleController = this.costInfoLayout;
			this.lblRateInfo.TabIndex = 15;
			this.lblRateInfo.Text = "Rate updated on:";
			// 
			// txtRate
			// 
			this.txtRate.Location = new System.Drawing.Point(111, 178);
			this.txtRate.MenuManager = this.ribbonControl;
			this.txtRate.Name = "txtRate";
			this.txtRate.Properties.ReadOnly = true;
			this.txtRate.Size = new System.Drawing.Size(200, 22);
			this.txtRate.StyleController = this.costInfoLayout;
			this.txtRate.TabIndex = 14;
			// 
			// cboCurrencies
			// 
			this.cboCurrencies.Location = new System.Drawing.Point(111, 152);
			this.cboCurrencies.MenuManager = this.ribbonControl;
			this.cboCurrencies.Name = "cboCurrencies";
			this.cboCurrencies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCurrencies.Size = new System.Drawing.Size(200, 22);
			this.cboCurrencies.StyleController = this.costInfoLayout;
			this.cboCurrencies.TabIndex = 13;
			// 
			// cboPaymentMethod
			// 
			this.cboPaymentMethod.Location = new System.Drawing.Point(123, 104);
			this.cboPaymentMethod.MenuManager = this.ribbonControl;
			this.cboPaymentMethod.Name = "cboPaymentMethod";
			this.cboPaymentMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboPaymentMethod.Size = new System.Drawing.Size(188, 22);
			this.cboPaymentMethod.StyleController = this.costInfoLayout;
			this.cboPaymentMethod.TabIndex = 12;
			// 
			// cboMembers
			// 
			this.cboMembers.Location = new System.Drawing.Point(315, 78);
			this.cboMembers.MenuManager = this.ribbonControl;
			this.cboMembers.Name = "cboMembers";
			this.cboMembers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboMembers.Properties.PopupView = this.gridView1;
			this.cboMembers.Size = new System.Drawing.Size(298, 22);
			this.cboMembers.StyleController = this.costInfoLayout;
			this.cboMembers.TabIndex = 11;
			// 
			// gridView1
			// 
			this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// dtCostDate
			// 
			this.dtCostDate.EditValue = null;
			this.dtCostDate.Location = new System.Drawing.Point(423, 41);
			this.dtCostDate.MenuManager = this.ribbonControl;
			this.dtCostDate.Name = "dtCostDate";
			this.dtCostDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtCostDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtCostDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtCostDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtCostDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtCostDate.Properties.ReadOnly = true;
			this.dtCostDate.Properties.UseMaskAsDisplayFormat = true;
			this.dtCostDate.Size = new System.Drawing.Size(190, 22);
			this.dtCostDate.StyleController = this.costInfoLayout;
			this.dtCostDate.TabIndex = 8;
			// 
			// txtCostNo
			// 
			this.txtCostNo.Location = new System.Drawing.Point(123, 41);
			this.txtCostNo.MenuManager = this.ribbonControl;
			this.txtCostNo.Name = "txtCostNo";
			this.txtCostNo.Properties.ReadOnly = true;
			this.txtCostNo.Size = new System.Drawing.Size(188, 22);
			this.txtCostNo.StyleController = this.costInfoLayout;
			this.txtCostNo.TabIndex = 4;
			// 
			// cboOperationType
			// 
			this.cboOperationType.Location = new System.Drawing.Point(123, 78);
			this.cboOperationType.MenuManager = this.ribbonControl;
			this.cboOperationType.Name = "cboOperationType";
			this.cboOperationType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboOperationType.Size = new System.Drawing.Size(188, 22);
			this.cboOperationType.StyleController = this.costInfoLayout;
			this.cboOperationType.TabIndex = 10;
			// 
			// layoutControlGroup3
			// 
			this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup3.GroupBordersVisible = false;
			this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.grCostInfo,
            this.lblCurrency,
            this.lblRate,
            this.emptySpaceItem11,
            this.emptySpaceItem1,
            this.lblRateInfoControl,
            this.emptySpaceItem12,
            this.emptySpaceItem13});
			this.layoutControlGroup3.Name = "layoutControlGroup3";
			this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
			this.layoutControlGroup3.Size = new System.Drawing.Size(628, 213);
			this.layoutControlGroup3.TextVisible = false;
			// 
			// grCostInfo
			// 
			this.grCostInfo.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grCostInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblCostNo,
            this.lblCostDate,
            this.emptySpaceItem4,
            this.lblToTheOrderOf,
            this.lblMembers,
            this.lblPaymentMethod,
            this.emptySpaceItem14});
			this.grCostInfo.Location = new System.Drawing.Point(0, 0);
			this.grCostInfo.Name = "grCostInfo";
			this.grCostInfo.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
			this.grCostInfo.Size = new System.Drawing.Size(626, 139);
			this.grCostInfo.Text = "Cost Info";
			// 
			// lblCostNo
			// 
			this.lblCostNo.Control = this.txtCostNo;
			this.lblCostNo.Location = new System.Drawing.Point(0, 0);
			this.lblCostNo.Name = "lblCostNo";
			this.lblCostNo.Size = new System.Drawing.Size(300, 26);
			this.lblCostNo.Text = "Cost No";
			this.lblCostNo.TextSize = new System.Drawing.Size(96, 16);
			// 
			// lblCostDate
			// 
			this.lblCostDate.Control = this.dtCostDate;
			this.lblCostDate.Location = new System.Drawing.Point(300, 0);
			this.lblCostDate.Name = "lblCostDate";
			this.lblCostDate.Size = new System.Drawing.Size(302, 26);
			this.lblCostDate.Text = "Cost Date";
			this.lblCostDate.TextSize = new System.Drawing.Size(96, 16);
			// 
			// emptySpaceItem4
			// 
			this.emptySpaceItem4.Location = new System.Drawing.Point(0, 26);
			this.emptySpaceItem4.Name = "emptySpaceItem4";
			this.emptySpaceItem4.Size = new System.Drawing.Size(602, 11);
			// 
			// lblToTheOrderOf
			// 
			this.lblToTheOrderOf.Control = this.cboOperationType;
			this.lblToTheOrderOf.Location = new System.Drawing.Point(0, 37);
			this.lblToTheOrderOf.Name = "lblToTheOrderOf";
			this.lblToTheOrderOf.Size = new System.Drawing.Size(300, 26);
			this.lblToTheOrderOf.Text = "To The Order Of";
			this.lblToTheOrderOf.TextSize = new System.Drawing.Size(96, 16);
			// 
			// lblMembers
			// 
			this.lblMembers.Control = this.cboMembers;
			this.lblMembers.Location = new System.Drawing.Point(300, 37);
			this.lblMembers.Name = "lblMembers";
			this.lblMembers.Size = new System.Drawing.Size(302, 26);
			this.lblMembers.Text = "Members";
			this.lblMembers.TextVisible = false;
			// 
			// lblPaymentMethod
			// 
			this.lblPaymentMethod.Control = this.cboPaymentMethod;
			this.lblPaymentMethod.Location = new System.Drawing.Point(0, 63);
			this.lblPaymentMethod.Name = "lblPaymentMethod";
			this.lblPaymentMethod.Size = new System.Drawing.Size(300, 26);
			this.lblPaymentMethod.Text = "Payment Method";
			this.lblPaymentMethod.TextSize = new System.Drawing.Size(96, 16);
			// 
			// emptySpaceItem14
			// 
			this.emptySpaceItem14.Location = new System.Drawing.Point(300, 63);
			this.emptySpaceItem14.Name = "emptySpaceItem14";
			this.emptySpaceItem14.Size = new System.Drawing.Size(302, 26);
			// 
			// lblCurrency
			// 
			this.lblCurrency.Control = this.cboCurrencies;
			this.lblCurrency.Location = new System.Drawing.Point(0, 149);
			this.lblCurrency.Name = "lblCurrency";
			this.lblCurrency.Size = new System.Drawing.Size(312, 26);
			this.lblCurrency.Text = "Currency";
			this.lblCurrency.TextSize = new System.Drawing.Size(96, 16);
			// 
			// lblRate
			// 
			this.lblRate.Control = this.txtRate;
			this.lblRate.Location = new System.Drawing.Point(0, 175);
			this.lblRate.Name = "lblRate";
			this.lblRate.Size = new System.Drawing.Size(312, 26);
			this.lblRate.Text = "Rate";
			this.lblRate.TextSize = new System.Drawing.Size(96, 16);
			// 
			// emptySpaceItem11
			// 
			this.emptySpaceItem11.Location = new System.Drawing.Point(312, 149);
			this.emptySpaceItem11.Name = "emptySpaceItem11";
			this.emptySpaceItem11.Size = new System.Drawing.Size(314, 32);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 201);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(626, 10);
			// 
			// lblRateInfoControl
			// 
			this.lblRateInfoControl.Control = this.lblRateInfo;
			this.lblRateInfoControl.Location = new System.Drawing.Point(312, 181);
			this.lblRateInfoControl.Name = "lblRateInfoControl";
			this.lblRateInfoControl.Size = new System.Drawing.Size(103, 20);
			this.lblRateInfoControl.TextVisible = false;
			// 
			// emptySpaceItem12
			// 
			this.emptySpaceItem12.Location = new System.Drawing.Point(0, 139);
			this.emptySpaceItem12.Name = "emptySpaceItem12";
			this.emptySpaceItem12.Size = new System.Drawing.Size(626, 10);
			// 
			// emptySpaceItem13
			// 
			this.emptySpaceItem13.Location = new System.Drawing.Point(415, 181);
			this.emptySpaceItem13.Name = "emptySpaceItem13";
			this.emptySpaceItem13.Size = new System.Drawing.Size(211, 20);
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup2.GroupBordersVisible = false;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(965, 247);
			this.layoutControlGroup2.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.tablePanelCostInfo;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(941, 223);
			this.layoutControlItem2.TextVisible = false;
			// 
			// tabFileDetails
			// 
			this.tabFileDetails.Controls.Add(this.fileDetailsLayout);
			this.tabFileDetails.Name = "tabFileDetails";
			this.tabFileDetails.Size = new System.Drawing.Size(968, 247);
			this.tabFileDetails.Text = "File Details";
			// 
			// fileDetailsLayout
			// 
			this.fileDetailsLayout.Controls.Add(this.tablePanelFileDetails);
			this.fileDetailsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fileDetailsLayout.Location = new System.Drawing.Point(0, 0);
			this.fileDetailsLayout.Name = "fileDetailsLayout";
			this.fileDetailsLayout.Root = this.layoutControlGroup5;
			this.fileDetailsLayout.Size = new System.Drawing.Size(968, 247);
			this.fileDetailsLayout.TabIndex = 0;
			this.fileDetailsLayout.Text = "layoutControl2";
			// 
			// tablePanelFileDetails
			// 
			this.tablePanelFileDetails.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 67.71F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.29F)});
			this.tablePanelFileDetails.Controls.Add(this.layoutControl2);
			this.tablePanelFileDetails.Controls.Add(this.layoutControl3);
			this.tablePanelFileDetails.Location = new System.Drawing.Point(12, 12);
			this.tablePanelFileDetails.Margin = new System.Windows.Forms.Padding(1);
			this.tablePanelFileDetails.Name = "tablePanelFileDetails";
			this.tablePanelFileDetails.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 124.0001F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 32F)});
			this.tablePanelFileDetails.Size = new System.Drawing.Size(944, 223);
			this.tablePanelFileDetails.TabIndex = 14;
			// 
			// layoutControl2
			// 
			this.tablePanelFileDetails.SetColumn(this.layoutControl2, 1);
			this.layoutControl2.Controls.Add(this.cboModifiedBy);
			this.layoutControl2.Controls.Add(this.cboCreatedBy);
			this.layoutControl2.Controls.Add(this.chkPosted);
			this.layoutControl2.Controls.Add(this.chkProtected);
			this.layoutControl2.Controls.Add(this.cboDepartments);
			this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl2.Location = new System.Drawing.Point(642, 3);
			this.layoutControl2.Name = "layoutControl2";
			this.layoutControl2.Root = this.layoutControlGroup6;
			this.tablePanelFileDetails.SetRow(this.layoutControl2, 0);
			this.tablePanelFileDetails.SetRowSpan(this.layoutControl2, 2);
			this.layoutControl2.Size = new System.Drawing.Size(299, 217);
			this.layoutControl2.TabIndex = 1;
			this.layoutControl2.Text = "layoutControl2";
			// 
			// cboModifiedBy
			// 
			this.cboModifiedBy.Location = new System.Drawing.Point(94, 93);
			this.cboModifiedBy.MenuManager = this.ribbonControl;
			this.cboModifiedBy.Name = "cboModifiedBy";
			this.cboModifiedBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboModifiedBy.Properties.ReadOnly = true;
			this.cboModifiedBy.Size = new System.Drawing.Size(190, 22);
			this.cboModifiedBy.StyleController = this.layoutControl2;
			this.cboModifiedBy.TabIndex = 13;
			// 
			// cboCreatedBy
			// 
			this.cboCreatedBy.Location = new System.Drawing.Point(94, 67);
			this.cboCreatedBy.MenuManager = this.ribbonControl;
			this.cboCreatedBy.Name = "cboCreatedBy";
			this.cboCreatedBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCreatedBy.Properties.ReadOnly = true;
			this.cboCreatedBy.Size = new System.Drawing.Size(190, 22);
			this.cboCreatedBy.StyleController = this.layoutControl2;
			this.cboCreatedBy.TabIndex = 12;
			// 
			// chkPosted
			// 
			this.chkPosted.Location = new System.Drawing.Point(15, 130);
			this.chkPosted.MenuManager = this.ribbonControl;
			this.chkPosted.Name = "chkPosted";
			this.chkPosted.Properties.Caption = "Posted";
			this.chkPosted.Size = new System.Drawing.Size(163, 24);
			this.chkPosted.StyleController = this.layoutControl2;
			this.chkPosted.TabIndex = 10;
			// 
			// chkProtected
			// 
			this.chkProtected.Location = new System.Drawing.Point(182, 130);
			this.chkProtected.MenuManager = this.ribbonControl;
			this.chkProtected.Name = "chkProtected";
			this.chkProtected.Properties.Caption = "Protected";
			this.chkProtected.Size = new System.Drawing.Size(102, 24);
			this.chkProtected.StyleController = this.layoutControl2;
			this.chkProtected.TabIndex = 9;
			// 
			// cboDepartments
			// 
			this.cboDepartments.Location = new System.Drawing.Point(94, 41);
			this.cboDepartments.MenuManager = this.ribbonControl;
			this.cboDepartments.Name = "cboDepartments";
			this.cboDepartments.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboDepartments.Properties.ReadOnly = true;
			this.cboDepartments.Size = new System.Drawing.Size(190, 22);
			this.cboDepartments.StyleController = this.layoutControl2;
			this.cboDepartments.TabIndex = 14;
			// 
			// layoutControlGroup6
			// 
			this.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup6.GroupBordersVisible = false;
			this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup7,
            this.emptySpaceItem6});
			this.layoutControlGroup6.Name = "layoutControlGroup4";
			this.layoutControlGroup6.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
			this.layoutControlGroup6.Size = new System.Drawing.Size(299, 217);
			this.layoutControlGroup6.TextVisible = false;
			// 
			// layoutControlGroup7
			// 
			this.layoutControlGroup7.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem5,
            this.lblCreatedBy,
            this.lblModifiedBy,
            this.lblDepartment,
            this.layoutControlItem5,
            this.layoutControlItem12,
            this.emptySpaceItem9});
			this.layoutControlGroup7.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup7.Name = "grpSupplierInfo";
			this.layoutControlGroup7.Size = new System.Drawing.Size(297, 205);
			this.layoutControlGroup7.Text = "File Info";
			// 
			// emptySpaceItem5
			// 
			this.emptySpaceItem5.Location = new System.Drawing.Point(0, 117);
			this.emptySpaceItem5.Name = "emptySpaceItem2";
			this.emptySpaceItem5.Size = new System.Drawing.Size(273, 38);
			// 
			// lblCreatedBy
			// 
			this.lblCreatedBy.Control = this.cboCreatedBy;
			this.lblCreatedBy.Location = new System.Drawing.Point(0, 26);
			this.lblCreatedBy.Name = "lblCreatedBy";
			this.lblCreatedBy.Size = new System.Drawing.Size(273, 26);
			this.lblCreatedBy.Text = "Created By";
			this.lblCreatedBy.TextSize = new System.Drawing.Size(67, 16);
			// 
			// lblModifiedBy
			// 
			this.lblModifiedBy.Control = this.cboModifiedBy;
			this.lblModifiedBy.Location = new System.Drawing.Point(0, 52);
			this.lblModifiedBy.Name = "lblModifiedBy";
			this.lblModifiedBy.Size = new System.Drawing.Size(273, 26);
			this.lblModifiedBy.Text = "Modified By";
			this.lblModifiedBy.TextSize = new System.Drawing.Size(67, 16);
			// 
			// lblDepartment
			// 
			this.lblDepartment.Control = this.cboDepartments;
			this.lblDepartment.Location = new System.Drawing.Point(0, 0);
			this.lblDepartment.Name = "lblDepartment";
			this.lblDepartment.Size = new System.Drawing.Size(273, 26);
			this.lblDepartment.Text = "Department";
			this.lblDepartment.TextSize = new System.Drawing.Size(67, 16);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.chkPosted;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 89);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(167, 28);
			this.layoutControlItem5.TextVisible = false;
			// 
			// layoutControlItem12
			// 
			this.layoutControlItem12.Control = this.chkProtected;
			this.layoutControlItem12.Location = new System.Drawing.Point(167, 89);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Size = new System.Drawing.Size(106, 28);
			this.layoutControlItem12.TextVisible = false;
			// 
			// emptySpaceItem9
			// 
			this.emptySpaceItem9.Location = new System.Drawing.Point(0, 78);
			this.emptySpaceItem9.Name = "emptySpaceItem9";
			this.emptySpaceItem9.Size = new System.Drawing.Size(273, 11);
			// 
			// emptySpaceItem6
			// 
			this.emptySpaceItem6.Location = new System.Drawing.Point(0, 205);
			this.emptySpaceItem6.Name = "emptySpaceItem3";
			this.emptySpaceItem6.Size = new System.Drawing.Size(297, 10);
			// 
			// layoutControl3
			// 
			this.tablePanelFileDetails.SetColumn(this.layoutControl3, 0);
			this.layoutControl3.Controls.Add(this.txtJvNo);
			this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl3.Location = new System.Drawing.Point(3, 3);
			this.layoutControl3.Name = "layoutControl3";
			this.layoutControl3.Root = this.layoutControlGroup8;
			this.tablePanelFileDetails.SetRow(this.layoutControl3, 0);
			this.tablePanelFileDetails.SetRowSpan(this.layoutControl3, 2);
			this.layoutControl3.Size = new System.Drawing.Size(633, 217);
			this.layoutControl3.TabIndex = 0;
			this.layoutControl3.Text = "layoutControl2";
			// 
			// txtJvNo
			// 
			this.txtJvNo.Location = new System.Drawing.Point(59, 41);
			this.txtJvNo.MenuManager = this.ribbonControl;
			this.txtJvNo.Name = "txtJvNo";
			this.txtJvNo.Properties.ReadOnly = true;
			this.txtJvNo.Size = new System.Drawing.Size(176, 22);
			this.txtJvNo.StyleController = this.layoutControl3;
			this.txtJvNo.TabIndex = 4;
			// 
			// layoutControlGroup8
			// 
			this.layoutControlGroup8.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup8.GroupBordersVisible = false;
			this.layoutControlGroup8.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem7,
            this.layoutControlGroup9});
			this.layoutControlGroup8.Name = "layoutControlGroup3";
			this.layoutControlGroup8.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
			this.layoutControlGroup8.Size = new System.Drawing.Size(633, 217);
			this.layoutControlGroup8.TextVisible = false;
			// 
			// emptySpaceItem7
			// 
			this.emptySpaceItem7.Location = new System.Drawing.Point(0, 151);
			this.emptySpaceItem7.Name = "emptySpaceItem1";
			this.emptySpaceItem7.Size = new System.Drawing.Size(631, 64);
			// 
			// layoutControlGroup9
			// 
			this.layoutControlGroup9.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.layoutControlGroup9.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblJvNo,
            this.emptySpaceItem8,
            this.emptySpaceItem10});
			this.layoutControlGroup9.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup9.Name = "grCostInfo";
			this.layoutControlGroup9.Size = new System.Drawing.Size(631, 151);
			this.layoutControlGroup9.Text = "Accounting Info";
			// 
			// lblJvNo
			// 
			this.lblJvNo.Control = this.txtJvNo;
			this.lblJvNo.Location = new System.Drawing.Point(0, 0);
			this.lblJvNo.Name = "lblJvNo";
			this.lblJvNo.Size = new System.Drawing.Size(224, 26);
			this.lblJvNo.Text = "JV No";
			this.lblJvNo.TextSize = new System.Drawing.Size(32, 16);
			// 
			// emptySpaceItem8
			// 
			this.emptySpaceItem8.Location = new System.Drawing.Point(0, 26);
			this.emptySpaceItem8.Name = "emptySpaceItem4";
			this.emptySpaceItem8.Size = new System.Drawing.Size(607, 75);
			// 
			// emptySpaceItem10
			// 
			this.emptySpaceItem10.Location = new System.Drawing.Point(224, 0);
			this.emptySpaceItem10.Name = "emptySpaceItem10";
			this.emptySpaceItem10.Size = new System.Drawing.Size(383, 26);
			// 
			// layoutControlGroup5
			// 
			this.layoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup5.GroupBordersVisible = false;
			this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem17});
			this.layoutControlGroup5.Name = "layoutControlGroup5";
			this.layoutControlGroup5.Size = new System.Drawing.Size(968, 247);
			this.layoutControlGroup5.TextVisible = false;
			// 
			// layoutControlItem17
			// 
			this.layoutControlItem17.Control = this.tablePanelFileDetails;
			this.layoutControlItem17.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Size = new System.Drawing.Size(948, 227);
			this.layoutControlItem17.TextVisible = false;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1447, 563);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.tablePanel1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1423, 539);
			this.layoutControlItem1.TextVisible = false;
			// 
			// CostEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1447, 790);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.ribbonControl);
			this.Name = "CostEditForm";
			this.Ribbon = this.ribbonControl;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Edit Cost";
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
			this.tablePanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutTotals)).EndInit();
			this.layoutTotals.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
			this.tablePanel2.ResumeLayout(false);
			this.tablePanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtGrandTotal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalVAT.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtItemVAT.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtItemNoVAT.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcCostDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCostDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCurrencies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabInfo)).EndInit();
			this.xtraTabInfo.ResumeLayout(false);
			this.tabCostInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tablePanelCostInfo)).EndInit();
			this.tablePanelCostInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.supplierInfoLayout)).EndInit();
			this.supplierInfoLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtSupplierInvoiceNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSupplierInvocieReference.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAmountSettled.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDateOfPayment.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDateOfPayment.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDateOfInvoice.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtDateOfInvoice.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpSupplierInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDateOfInvoice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDateOfPayment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSupplierInvoiceNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSupplierInvocieReference)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAmountSettled)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.costInfoLayout)).EndInit();
			this.costInfoLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCurrencies.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboPaymentMethod.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboMembers.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtCostDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtCostDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCostNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboOperationType.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grCostInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCostNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCostDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblToTheOrderOf)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMembers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPaymentMethod)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCurrency)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblRateInfoControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			this.tabFileDetails.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fileDetailsLayout)).EndInit();
			this.fileDetailsLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tablePanelFileDetails)).EndInit();
			this.tablePanelFileDetails.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
			this.layoutControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cboModifiedBy.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCreatedBy.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkPosted.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkProtected.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboDepartments.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCreatedBy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblModifiedBy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDepartment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
			this.layoutControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtJvNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJvNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarButtonItem btnSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgJobStatusAction;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraLayout.LayoutControl mainLayout;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.XtraLayout.LayoutControl layoutTotals;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
		private DevExpress.XtraEditors.TextEdit txtGrandTotal;
		private DevExpress.XtraEditors.TextEdit txtTotalVAT;
		private DevExpress.XtraEditors.TextEdit txtItemVAT;
		private DevExpress.XtraEditors.TextEdit txtItemNoVAT;
		private DevExpress.XtraEditors.TextEdit txtSubTotal;
		private DevExpress.XtraEditors.LabelControl lblGrandTotal;
		private DevExpress.XtraEditors.LabelControl lblTotalVat;
		private DevExpress.XtraEditors.LabelControl lblItemVAT;
		private DevExpress.XtraEditors.LabelControl lblItemNoVAT;
		private DevExpress.XtraEditors.LabelControl lblSubTotal;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraGrid.GridControl gcCostDetails;
		private DevExpress.XtraGrid.Views.Grid.GridView gvCostDetails;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colSheetId;
		private DevExpress.XtraGrid.Columns.GridColumn colReference;
		private DevExpress.XtraGrid.Columns.GridColumn colItemId;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colLAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colFAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colProvisionAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colLProvisionAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colFProvisionAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colNotes;
		private DevExpress.XtraGrid.Columns.GridColumn colIsProtected;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckBox;
		private DevExpress.XtraGrid.Columns.GridColumn colActive;
		private DevExpress.XtraGrid.Columns.GridColumn colLocked;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCurrencies;
		private DevExpress.XtraTab.XtraTabControl xtraTabInfo;
		private DevExpress.XtraTab.XtraTabPage tabCostInfo;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.Utils.Layout.TablePanel tablePanelCostInfo;
		private DevExpress.XtraLayout.LayoutControl supplierInfoLayout;
		private DevExpress.XtraEditors.TextEdit txtSupplierInvoiceNo;
		private DevExpress.XtraEditors.TextEdit txtSupplierInvocieReference;
		private DevExpress.XtraEditors.TextEdit txtAmountSettled;
		private DevExpress.XtraEditors.DateEdit dtDateOfPayment;
		private DevExpress.XtraEditors.DateEdit dtDateOfInvoice;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
		private DevExpress.XtraLayout.LayoutControlGroup grpSupplierInfo;
		private DevExpress.XtraLayout.LayoutControlItem lblDateOfInvoice;
		private DevExpress.XtraLayout.LayoutControlItem lblDateOfPayment;
		private DevExpress.XtraLayout.LayoutControlItem lblSupplierInvoiceNo;
		private DevExpress.XtraLayout.LayoutControlItem lblSupplierInvocieReference;
		private DevExpress.XtraLayout.LayoutControlItem lblAmountSettled;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.LayoutControl costInfoLayout;
		private DevExpress.XtraEditors.LabelControl lblRateInfo;
		private DevExpress.XtraEditors.TextEdit txtRate;
		private DevExpress.XtraEditors.LookUpEdit cboCurrencies;
		private DevExpress.XtraEditors.LookUpEdit cboPaymentMethod;
		private DevExpress.XtraEditors.SearchLookUpEdit cboMembers;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.DateEdit dtCostDate;
		private DevExpress.XtraEditors.TextEdit txtCostNo;
		private DevExpress.XtraEditors.LookUpEdit cboOperationType;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
		private DevExpress.XtraLayout.LayoutControlGroup grCostInfo;
		private DevExpress.XtraLayout.LayoutControlItem lblCostNo;
		private DevExpress.XtraLayout.LayoutControlItem lblCostDate;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
		private DevExpress.XtraLayout.LayoutControlItem lblToTheOrderOf;
		private DevExpress.XtraLayout.LayoutControlItem lblMembers;
		private DevExpress.XtraLayout.LayoutControlItem lblPaymentMethod;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem14;
		private DevExpress.XtraLayout.LayoutControlItem lblCurrency;
		private DevExpress.XtraLayout.LayoutControlItem lblRate;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem lblRateInfoControl;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem12;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem13;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraTab.XtraTabPage tabFileDetails;
		private DevExpress.XtraLayout.LayoutControl fileDetailsLayout;
		private DevExpress.Utils.Layout.TablePanel tablePanelFileDetails;
		private DevExpress.XtraLayout.LayoutControl layoutControl2;
		private DevExpress.XtraEditors.LookUpEdit cboModifiedBy;
		private DevExpress.XtraEditors.LookUpEdit cboCreatedBy;
		private DevExpress.XtraEditors.CheckEdit chkPosted;
		private DevExpress.XtraEditors.CheckEdit chkProtected;
		private DevExpress.XtraEditors.LookUpEdit cboDepartments;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
		private DevExpress.XtraLayout.LayoutControlItem lblCreatedBy;
		private DevExpress.XtraLayout.LayoutControlItem lblModifiedBy;
		private DevExpress.XtraLayout.LayoutControlItem lblDepartment;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
		private DevExpress.XtraLayout.LayoutControl layoutControl3;
		private DevExpress.XtraEditors.TextEdit txtJvNo;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup8;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup9;
		private DevExpress.XtraLayout.LayoutControlItem lblJvNo;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
	}
}