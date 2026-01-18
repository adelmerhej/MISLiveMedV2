using MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs;

namespace MISLiveMed.UI.Forms.JobForms.SeaFreight.SeaImport
{
    partial class JobSeaImportListForm
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
			DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobSeaImportListForm));
			DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
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
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem8 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges5 = new DevExpress.Skins.SkinPaddingEdges();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges6 = new DevExpress.Skins.SkinPaddingEdges();
			this.gvSeaImportDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colDetailId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailJobNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailBOL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailOrigin = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDetailContNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gcSeaImport = new DevExpress.XtraGrid.GridControl();
			this.bsSeaImportJobs = new System.Windows.Forms.BindingSource(this.components);
			this.gvSeaImport = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRefNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJobNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJobDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repDateFormat = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.colMbol = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colContainerNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBookingNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCustomers = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMemberId1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMemberName1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colConsigneeId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAgentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repAgents = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colSeaportDeparture = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repPOLPortCodeList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colCountryDeparture = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSeaportDestination = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repPODPortCodeList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colCountryDestination = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJobType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repJobsType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colSideId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repSideId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colCommodity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantities = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPieces = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colValueOfGoods = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippedWithId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repAgentCategories = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colVesselId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFeederVesselId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDelivered = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDeliveredTo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDeliveredDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalInvoicesLl = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalInvoicesUsd = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalCostsLl = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalCostsUsd = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOperatingUserId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProject = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransit = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFullPaid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFullPaidDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colClearingAgentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colATD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colATA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colETD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colETA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCutOffDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDOL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPPCC = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBlstatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRTejrim = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRTejrimDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTejrim = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTejrimDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRClearance = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRClearanceDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIncoTerms = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIncoTermsFrom = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIncoTermsTo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAllInOrderToBeLoaded = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAllInOrderOnWater = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colContainerToCnee = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDtCntrToCnee = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmptyContainer = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDtEmptyCntr = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJobSCId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLocked = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colClosed = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colClosedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCanceledJob = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCanceledDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCanceledUser = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLastJobReopenedBy = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLastJobReopened = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostReady = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostReadyDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repUsersList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repSalesList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repCheckList = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.repNumberFormat = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
			this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
			this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
			this.barCheckItem7 = new DevExpress.XtraBars.BarCheckItem();
			this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
			this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
			this.chkSortByBookedDate = new DevExpress.XtraBars.BarCheckItem();
			this.barCheckItem8 = new DevExpress.XtraBars.BarCheckItem();
			this.rcJobSeaImport = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.rgFilterReports = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
			this.barCheckItem3 = new DevExpress.XtraBars.BarCheckItem();
			this.barCheckItem4 = new DevExpress.XtraBars.BarCheckItem();
			this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
			this.barCheckItem5 = new DevExpress.XtraBars.BarCheckItem();
			this.barCheckItem6 = new DevExpress.XtraBars.BarCheckItem();
			this.barButtonItem18 = new DevExpress.XtraBars.BarButtonItem();
			this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
			this.barButtonItem19 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem20 = new DevExpress.XtraBars.BarButtonItem();
			this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.cboOperatingUsers = new DevExpress.XtraBars.BarEditItem();
			this.repOperatingUsers = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboSales = new DevExpress.XtraBars.BarEditItem();
			this.repSales = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colSalesId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSalesName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboStatus = new DevExpress.XtraBars.BarEditItem();
			this.repStatusList = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.repositoryItemSearchLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.chkShowProtected = new DevExpress.XtraBars.BarCheckItem();
			this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
			this.barCheckItem9 = new DevExpress.XtraBars.BarCheckItem();
			this.rgSortByReports = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.rgOrderByReports = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.rpJobSeaImport = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgDepartments = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgPermissions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.mainLayout = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.gvSeaImportDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcSeaImport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsSeaImportJobs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvSeaImport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repAgents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repPOLPortCodeList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repPODPortCodeList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repJobsType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSideId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repAgentCategories)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsersList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSalesList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repNumberFormat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rcJobSeaImport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repOperatingUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repStatusList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// gvSeaImportDetails
			// 
			this.gvSeaImportDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDetailId,
            this.colDetailJobNo,
            this.colDetailBOL,
            this.colDetailOrigin,
            this.colDetailSupplier,
            this.colDetailContNo});
			this.gvSeaImportDetails.GridControl = this.gcSeaImport;
			this.gvSeaImportDetails.Name = "gvSeaImportDetails";
			// 
			// colDetailId
			// 
			this.colDetailId.Caption = "Id";
			this.colDetailId.FieldName = "Id";
			this.colDetailId.MinWidth = 25;
			this.colDetailId.Name = "colDetailId";
			this.colDetailId.Visible = true;
			this.colDetailId.VisibleIndex = 0;
			this.colDetailId.Width = 94;
			// 
			// colDetailJobNo
			// 
			this.colDetailJobNo.Caption = "Job#";
			this.colDetailJobNo.FieldName = "JobId";
			this.colDetailJobNo.MinWidth = 25;
			this.colDetailJobNo.Name = "colDetailJobNo";
			this.colDetailJobNo.Visible = true;
			this.colDetailJobNo.VisibleIndex = 1;
			this.colDetailJobNo.Width = 94;
			// 
			// colDetailBOL
			// 
			this.colDetailBOL.Caption = "HBL";
			this.colDetailBOL.FieldName = "Bol";
			this.colDetailBOL.MinWidth = 25;
			this.colDetailBOL.Name = "colDetailBOL";
			this.colDetailBOL.Visible = true;
			this.colDetailBOL.VisibleIndex = 2;
			this.colDetailBOL.Width = 94;
			// 
			// colDetailOrigin
			// 
			this.colDetailOrigin.Caption = "Origin";
			this.colDetailOrigin.FieldName = "Origin";
			this.colDetailOrigin.MinWidth = 25;
			this.colDetailOrigin.Name = "colDetailOrigin";
			this.colDetailOrigin.Visible = true;
			this.colDetailOrigin.VisibleIndex = 3;
			this.colDetailOrigin.Width = 94;
			// 
			// colDetailSupplier
			// 
			this.colDetailSupplier.Caption = "Supplier";
			this.colDetailSupplier.FieldName = "Supplier";
			this.colDetailSupplier.MinWidth = 25;
			this.colDetailSupplier.Name = "colDetailSupplier";
			this.colDetailSupplier.Visible = true;
			this.colDetailSupplier.VisibleIndex = 4;
			this.colDetailSupplier.Width = 94;
			// 
			// colDetailContNo
			// 
			this.colDetailContNo.Caption = "ContNo";
			this.colDetailContNo.FieldName = "ContNo";
			this.colDetailContNo.MinWidth = 25;
			this.colDetailContNo.Name = "colDetailContNo";
			this.colDetailContNo.Visible = true;
			this.colDetailContNo.VisibleIndex = 5;
			this.colDetailContNo.Width = 94;
			// 
			// gcSeaImport
			// 
			this.gcSeaImport.DataSource = this.bsSeaImportJobs;
			this.gcSeaImport.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcSeaImport.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcSeaImport.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcSeaImport.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcSeaImport.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcSeaImport.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			gridLevelNode1.LevelTemplate = this.gvSeaImportDetails;
			gridLevelNode1.RelationName = "FK_JobDetails";
			this.gcSeaImport.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.gcSeaImport.Location = new System.Drawing.Point(14, 14);
			this.gcSeaImport.MainView = this.gvSeaImport;
			this.gcSeaImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcSeaImport.Name = "gcSeaImport";
			this.gcSeaImport.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repUsersList,
            this.repSalesList,
            this.repCustomers,
            this.repPOLPortCodeList,
            this.repPODPortCodeList,
            this.repCheckList,
            this.repDateFormat,
            this.repAgents,
            this.repJobsType,
            this.repNumberFormat,
            this.repAgentCategories,
            this.repSideId});
			this.gcSeaImport.Size = new System.Drawing.Size(1413, 527);
			this.gcSeaImport.TabIndex = 5;
			this.gcSeaImport.UseEmbeddedNavigator = true;
			this.gcSeaImport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSeaImport,
            this.gvSeaImportDetails});
			this.gcSeaImport.DoubleClick += new System.EventHandler(this.gcSeaImports_DoubleClick);
			// 
			// bsSeaImportJobs
			// 
			this.bsSeaImportJobs.DataSource = typeof(MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs.JobSeaImportModel);
			// 
			// gvSeaImport
			// 
			this.gvSeaImport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colRefNo,
            this.gridColumn1,
            this.colJobNo,
            this.colJobDate,
            this.colMbol,
            this.colContainerNo,
            this.colBookingNo,
            this.colCustomerId,
            this.colConsigneeId,
            this.colAgentId,
            this.colSeaportDeparture,
            this.colCountryDeparture,
            this.colSeaportDestination,
            this.colCountryDestination,
            this.colJobType,
            this.colSideId,
            this.colCommodity,
            this.colQuantities,
            this.colPieces,
            this.colWeight,
            this.colValueOfGoods,
            this.colShippedWithId,
            this.colVesselId,
            this.colFeederVesselId,
            this.colDelivered,
            this.colDeliveredTo,
            this.colDeliveredDate,
            this.colCurrencyId,
            this.colTotalInvoicesLl,
            this.colTotalInvoicesUsd,
            this.colTotalCostsLl,
            this.colTotalCostsUsd,
            this.colOperatingUserId,
            this.colSales,
            this.colUserId,
            this.colProject,
            this.colTransit,
            this.colFullPaid,
            this.colFullPaidDate,
            this.colClearingAgentId,
            this.colATD,
            this.colATA,
            this.colETD,
            this.colETA,
            this.colCutOffDate,
            this.colDOL,
            this.colPPCC,
            this.colStatus,
            this.colBlstatus,
            this.colRTejrim,
            this.colRTejrimDate,
            this.colTejrim,
            this.colTejrimDate,
            this.colRClearance,
            this.colRClearanceDate,
            this.colIncoTerms,
            this.colIncoTermsFrom,
            this.colIncoTermsTo,
            this.colAllInOrderToBeLoaded,
            this.colAllInOrderOnWater,
            this.colContainerToCnee,
            this.colDtCntrToCnee,
            this.colEmptyContainer,
            this.colDtEmptyCntr,
            this.colJobSCId,
            this.colLocked,
            this.colClosed,
            this.colClosedDate,
            this.colCanceledJob,
            this.colCanceledDate,
            this.colCanceledUser,
            this.colLastJobReopenedBy,
            this.colLastJobReopened,
            this.colCostReady,
            this.colCostReadyDate,
            this.colNotes});
			this.gvSeaImport.DetailHeight = 458;
			this.gvSeaImport.GridControl = this.gcSeaImport;
			this.gvSeaImport.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", null, "")});
			this.gvSeaImport.Name = "gvSeaImport";
			this.gvSeaImport.OptionsBehavior.Editable = false;
			this.gvSeaImport.OptionsBehavior.ReadOnly = true;
			this.gvSeaImport.OptionsFind.AlwaysVisible = true;
			this.gvSeaImport.OptionsPrint.AutoWidth = false;
			this.gvSeaImport.OptionsPrint.PrintHorzLines = false;
			this.gvSeaImport.OptionsPrint.PrintVertLines = false;
			this.gvSeaImport.OptionsView.ColumnAutoWidth = false;
			this.gvSeaImport.OptionsView.ShowGroupedColumns = true;
			this.gvSeaImport.OptionsView.ShowGroupPanel = false;
			this.gvSeaImport.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvSeaImportList_RowCellStyle);
			this.gvSeaImport.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gvSeaImports_MasterRowEmpty);
			this.gvSeaImport.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gvSeaImports_MasterRowGetChildList);
			this.gvSeaImport.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvSeaImports_MasterRowGetRelationName);
			this.gvSeaImport.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gvSeaImports_MasterRowGetRelationCount);
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Width = 94;
			// 
			// colRefNo
			// 
			this.colRefNo.Caption = "XONO";
			this.colRefNo.FieldName = "ReferenceNo";
			this.colRefNo.MinWidth = 25;
			this.colRefNo.Name = "colRefNo";
			this.colRefNo.Visible = true;
			this.colRefNo.VisibleIndex = 0;
			this.colRefNo.Width = 121;
			// 
			// gridColumn1
			// 
			this.gridColumn1.FieldName = "DepartmentId";
			this.gridColumn1.MinWidth = 25;
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Width = 94;
			// 
			// colJobNo
			// 
			this.colJobNo.Caption = "Job#";
			this.colJobNo.FieldName = "JobNo";
			this.colJobNo.MinWidth = 25;
			this.colJobNo.Name = "colJobNo";
			this.colJobNo.Visible = true;
			this.colJobNo.VisibleIndex = 1;
			this.colJobNo.Width = 94;
			// 
			// colJobDate
			// 
			this.colJobDate.ColumnEdit = this.repDateFormat;
			this.colJobDate.FieldName = "JobDate";
			this.colJobDate.MinWidth = 25;
			this.colJobDate.Name = "colJobDate";
			this.colJobDate.Visible = true;
			this.colJobDate.VisibleIndex = 2;
			this.colJobDate.Width = 94;
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
			// colMbol
			// 
			this.colMbol.Caption = "MBL";
			this.colMbol.FieldName = "Mbl";
			this.colMbol.MinWidth = 25;
			this.colMbol.Name = "colMbol";
			this.colMbol.Visible = true;
			this.colMbol.VisibleIndex = 8;
			this.colMbol.Width = 152;
			// 
			// colContainerNo
			// 
			this.colContainerNo.Caption = "Container#";
			this.colContainerNo.FieldName = "ContainerNo";
			this.colContainerNo.MinWidth = 25;
			this.colContainerNo.Name = "colContainerNo";
			this.colContainerNo.Visible = true;
			this.colContainerNo.VisibleIndex = 9;
			this.colContainerNo.Width = 159;
			// 
			// colBookingNo
			// 
			this.colBookingNo.Caption = "Booking#";
			this.colBookingNo.FieldName = "BookingNo";
			this.colBookingNo.MinWidth = 25;
			this.colBookingNo.Name = "colBookingNo";
			this.colBookingNo.Visible = true;
			this.colBookingNo.VisibleIndex = 10;
			this.colBookingNo.Width = 136;
			// 
			// colCustomerId
			// 
			this.colCustomerId.Caption = "Customer";
			this.colCustomerId.ColumnEdit = this.repCustomers;
			this.colCustomerId.FieldName = "CustomerId";
			this.colCustomerId.MinWidth = 25;
			this.colCustomerId.Name = "colCustomerId";
			this.colCustomerId.Visible = true;
			this.colCustomerId.VisibleIndex = 3;
			this.colCustomerId.Width = 272;
			// 
			// repCustomers
			// 
			this.repCustomers.AutoHeight = false;
			this.repCustomers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCustomers.DisplayMember = "CustomerName";
			this.repCustomers.Name = "repCustomers";
			this.repCustomers.NullText = "";
			this.repCustomers.PopupView = this.gridView1;
			this.repCustomers.ValueMember = "Id";
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMemberId1,
            this.colMemberName1});
			this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// colMemberId1
			// 
			this.colMemberId1.Caption = "Id";
			this.colMemberId1.FieldName = "Id";
			this.colMemberId1.Name = "colMemberId1";
			this.colMemberId1.Visible = true;
			this.colMemberId1.VisibleIndex = 0;
			this.colMemberId1.Width = 175;
			// 
			// colMemberName1
			// 
			this.colMemberName1.Caption = "Customer Name";
			this.colMemberName1.FieldName = "CustomerName";
			this.colMemberName1.Name = "colMemberName1";
			this.colMemberName1.Visible = true;
			this.colMemberName1.VisibleIndex = 1;
			this.colMemberName1.Width = 892;
			// 
			// colConsigneeId
			// 
			this.colConsigneeId.Caption = "Consignee";
			this.colConsigneeId.ColumnEdit = this.repCustomers;
			this.colConsigneeId.FieldName = "ConsigneeId";
			this.colConsigneeId.MinWidth = 25;
			this.colConsigneeId.Name = "colConsigneeId";
			this.colConsigneeId.Visible = true;
			this.colConsigneeId.VisibleIndex = 4;
			this.colConsigneeId.Width = 215;
			// 
			// colAgentId
			// 
			this.colAgentId.Caption = "Agent";
			this.colAgentId.ColumnEdit = this.repAgents;
			this.colAgentId.FieldName = "AgentId";
			this.colAgentId.MinWidth = 25;
			this.colAgentId.Name = "colAgentId";
			this.colAgentId.Visible = true;
			this.colAgentId.VisibleIndex = 5;
			this.colAgentId.Width = 222;
			// 
			// repAgents
			// 
			this.repAgents.AutoHeight = false;
			this.repAgents.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repAgents.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AgentName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repAgents.DisplayMember = "AgentName";
			this.repAgents.Name = "repAgents";
			this.repAgents.NullText = "";
			this.repAgents.ValueMember = "Id";
			// 
			// colSeaportDeparture
			// 
			this.colSeaportDeparture.Caption = "POL";
			this.colSeaportDeparture.ColumnEdit = this.repPOLPortCodeList;
			this.colSeaportDeparture.FieldName = "SeaportDeparture";
			this.colSeaportDeparture.MinWidth = 25;
			this.colSeaportDeparture.Name = "colSeaportDeparture";
			this.colSeaportDeparture.Visible = true;
			this.colSeaportDeparture.VisibleIndex = 6;
			this.colSeaportDeparture.Width = 138;
			// 
			// repPOLPortCodeList
			// 
			this.repPOLPortCodeList.AutoHeight = false;
			this.repPOLPortCodeList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repPOLPortCodeList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repPOLPortCodeList.DisplayMember = "Name";
			this.repPOLPortCodeList.Name = "repPOLPortCodeList";
			this.repPOLPortCodeList.NullText = "";
			this.repPOLPortCodeList.ValueMember = "Id";
			// 
			// colCountryDeparture
			// 
			this.colCountryDeparture.FieldName = "CountryDeparture";
			this.colCountryDeparture.MinWidth = 25;
			this.colCountryDeparture.Name = "colCountryDeparture";
			this.colCountryDeparture.Width = 94;
			// 
			// colSeaportDestination
			// 
			this.colSeaportDestination.Caption = "POD";
			this.colSeaportDestination.ColumnEdit = this.repPODPortCodeList;
			this.colSeaportDestination.FieldName = "SeaportDestination";
			this.colSeaportDestination.MinWidth = 25;
			this.colSeaportDestination.Name = "colSeaportDestination";
			this.colSeaportDestination.Visible = true;
			this.colSeaportDestination.VisibleIndex = 7;
			this.colSeaportDestination.Width = 147;
			// 
			// repPODPortCodeList
			// 
			this.repPODPortCodeList.AutoHeight = false;
			this.repPODPortCodeList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repPODPortCodeList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repPODPortCodeList.DisplayMember = "Name";
			this.repPODPortCodeList.Name = "repPODPortCodeList";
			this.repPODPortCodeList.NullText = "";
			this.repPODPortCodeList.ValueMember = "Id";
			// 
			// colCountryDestination
			// 
			this.colCountryDestination.FieldName = "CountryDestination";
			this.colCountryDestination.MinWidth = 25;
			this.colCountryDestination.Name = "colCountryDestination";
			this.colCountryDestination.Width = 94;
			// 
			// colJobType
			// 
			this.colJobType.Caption = "Job Type";
			this.colJobType.ColumnEdit = this.repJobsType;
			this.colJobType.FieldName = "JobType";
			this.colJobType.MinWidth = 25;
			this.colJobType.Name = "colJobType";
			this.colJobType.Visible = true;
			this.colJobType.VisibleIndex = 11;
			this.colJobType.Width = 94;
			// 
			// repJobsType
			// 
			this.repJobsType.AutoHeight = false;
			this.repJobsType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repJobsType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repJobsType.DisplayMember = "Description";
			this.repJobsType.Name = "repJobsType";
			this.repJobsType.NullText = "";
			this.repJobsType.ValueMember = "Id";
			// 
			// colSideId
			// 
			this.colSideId.Caption = "Side";
			this.colSideId.ColumnEdit = this.repSideId;
			this.colSideId.FieldName = "SideId";
			this.colSideId.MinWidth = 25;
			this.colSideId.Name = "colSideId";
			this.colSideId.Visible = true;
			this.colSideId.VisibleIndex = 12;
			this.colSideId.Width = 267;
			// 
			// repSideId
			// 
			this.repSideId.AutoHeight = false;
			this.repSideId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repSideId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AgentName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repSideId.DisplayMember = "AgentName";
			this.repSideId.Name = "repSideId";
			this.repSideId.NullText = "";
			this.repSideId.ValueMember = "Id";
			// 
			// colCommodity
			// 
			this.colCommodity.FieldName = "NatureOfGoods";
			this.colCommodity.MinWidth = 25;
			this.colCommodity.Name = "colCommodity";
			this.colCommodity.Visible = true;
			this.colCommodity.VisibleIndex = 13;
			this.colCommodity.Width = 261;
			// 
			// colQuantities
			// 
			this.colQuantities.FieldName = "Quantities";
			this.colQuantities.MinWidth = 25;
			this.colQuantities.Name = "colQuantities";
			this.colQuantities.Visible = true;
			this.colQuantities.VisibleIndex = 14;
			this.colQuantities.Width = 94;
			// 
			// colPieces
			// 
			this.colPieces.FieldName = "Pieces";
			this.colPieces.MinWidth = 25;
			this.colPieces.Name = "colPieces";
			this.colPieces.Visible = true;
			this.colPieces.VisibleIndex = 15;
			this.colPieces.Width = 94;
			// 
			// colWeight
			// 
			this.colWeight.FieldName = "Weight";
			this.colWeight.MinWidth = 25;
			this.colWeight.Name = "colWeight";
			this.colWeight.Visible = true;
			this.colWeight.VisibleIndex = 16;
			this.colWeight.Width = 94;
			// 
			// colValueOfGoods
			// 
			this.colValueOfGoods.FieldName = "ValueOfGoods";
			this.colValueOfGoods.MinWidth = 25;
			this.colValueOfGoods.Name = "colValueOfGoods";
			this.colValueOfGoods.Visible = true;
			this.colValueOfGoods.VisibleIndex = 17;
			this.colValueOfGoods.Width = 133;
			// 
			// colShippedWithId
			// 
			this.colShippedWithId.Caption = "Shipped With";
			this.colShippedWithId.ColumnEdit = this.repAgentCategories;
			this.colShippedWithId.FieldName = "ShippedWithId";
			this.colShippedWithId.MinWidth = 25;
			this.colShippedWithId.Name = "colShippedWithId";
			this.colShippedWithId.Visible = true;
			this.colShippedWithId.VisibleIndex = 18;
			this.colShippedWithId.Width = 134;
			// 
			// repAgentCategories
			// 
			this.repAgentCategories.AutoHeight = false;
			this.repAgentCategories.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repAgentCategories.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repAgentCategories.DisplayMember = "Name";
			this.repAgentCategories.Name = "repAgentCategories";
			this.repAgentCategories.NullText = "";
			this.repAgentCategories.ValueMember = "Id";
			// 
			// colVesselId
			// 
			this.colVesselId.Caption = "Vessel";
			this.colVesselId.FieldName = "VesselId";
			this.colVesselId.MinWidth = 25;
			this.colVesselId.Name = "colVesselId";
			this.colVesselId.Visible = true;
			this.colVesselId.VisibleIndex = 19;
			this.colVesselId.Width = 139;
			// 
			// colFeederVesselId
			// 
			this.colFeederVesselId.Caption = "Feeder Vessel";
			this.colFeederVesselId.FieldName = "FeederVesselId";
			this.colFeederVesselId.MinWidth = 25;
			this.colFeederVesselId.Name = "colFeederVesselId";
			this.colFeederVesselId.Visible = true;
			this.colFeederVesselId.VisibleIndex = 20;
			this.colFeederVesselId.Width = 140;
			// 
			// colDelivered
			// 
			this.colDelivered.FieldName = "Delivered";
			this.colDelivered.MinWidth = 25;
			this.colDelivered.Name = "colDelivered";
			this.colDelivered.Visible = true;
			this.colDelivered.VisibleIndex = 21;
			this.colDelivered.Width = 94;
			// 
			// colDeliveredTo
			// 
			this.colDeliveredTo.FieldName = "DeliveredTo";
			this.colDeliveredTo.MinWidth = 25;
			this.colDeliveredTo.Name = "colDeliveredTo";
			this.colDeliveredTo.Visible = true;
			this.colDeliveredTo.VisibleIndex = 22;
			this.colDeliveredTo.Width = 117;
			// 
			// colDeliveredDate
			// 
			this.colDeliveredDate.ColumnEdit = this.repDateFormat;
			this.colDeliveredDate.FieldName = "DeliveredDate";
			this.colDeliveredDate.MinWidth = 25;
			this.colDeliveredDate.Name = "colDeliveredDate";
			this.colDeliveredDate.Visible = true;
			this.colDeliveredDate.VisibleIndex = 23;
			this.colDeliveredDate.Width = 121;
			// 
			// colCurrencyId
			// 
			this.colCurrencyId.Caption = "Currency";
			this.colCurrencyId.FieldName = "CurrencyId";
			this.colCurrencyId.MinWidth = 25;
			this.colCurrencyId.Name = "colCurrencyId";
			this.colCurrencyId.Visible = true;
			this.colCurrencyId.VisibleIndex = 24;
			this.colCurrencyId.Width = 117;
			// 
			// colTotalInvoicesLl
			// 
			this.colTotalInvoicesLl.DisplayFormat.FormatString = "{0:n2}";
			this.colTotalInvoicesLl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotalInvoicesLl.FieldName = "TotalInvoicesLl";
			this.colTotalInvoicesLl.MinWidth = 25;
			this.colTotalInvoicesLl.Name = "colTotalInvoicesLl";
			this.colTotalInvoicesLl.Visible = true;
			this.colTotalInvoicesLl.VisibleIndex = 25;
			this.colTotalInvoicesLl.Width = 94;
			// 
			// colTotalInvoicesUsd
			// 
			this.colTotalInvoicesUsd.DisplayFormat.FormatString = "{0:n2}";
			this.colTotalInvoicesUsd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotalInvoicesUsd.FieldName = "TotalInvoicesUsd";
			this.colTotalInvoicesUsd.MinWidth = 25;
			this.colTotalInvoicesUsd.Name = "colTotalInvoicesUsd";
			this.colTotalInvoicesUsd.Visible = true;
			this.colTotalInvoicesUsd.VisibleIndex = 26;
			this.colTotalInvoicesUsd.Width = 94;
			// 
			// colTotalCostsLl
			// 
			this.colTotalCostsLl.DisplayFormat.FormatString = "{0:n2}";
			this.colTotalCostsLl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotalCostsLl.FieldName = "TotalCostsLl";
			this.colTotalCostsLl.MinWidth = 25;
			this.colTotalCostsLl.Name = "colTotalCostsLl";
			this.colTotalCostsLl.Visible = true;
			this.colTotalCostsLl.VisibleIndex = 27;
			this.colTotalCostsLl.Width = 94;
			// 
			// colTotalCostsUsd
			// 
			this.colTotalCostsUsd.DisplayFormat.FormatString = "{0:n2}";
			this.colTotalCostsUsd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotalCostsUsd.FieldName = "TotalCostsUsd";
			this.colTotalCostsUsd.MinWidth = 25;
			this.colTotalCostsUsd.Name = "colTotalCostsUsd";
			this.colTotalCostsUsd.Visible = true;
			this.colTotalCostsUsd.VisibleIndex = 28;
			this.colTotalCostsUsd.Width = 94;
			// 
			// colOperatingUserId
			// 
			this.colOperatingUserId.Caption = "Operating User";
			this.colOperatingUserId.FieldName = "OperatingUserId";
			this.colOperatingUserId.MinWidth = 25;
			this.colOperatingUserId.Name = "colOperatingUserId";
			this.colOperatingUserId.Visible = true;
			this.colOperatingUserId.VisibleIndex = 29;
			this.colOperatingUserId.Width = 94;
			// 
			// colSales
			// 
			this.colSales.Caption = "Sales";
			this.colSales.FieldName = "SalesId";
			this.colSales.MinWidth = 25;
			this.colSales.Name = "colSales";
			this.colSales.Visible = true;
			this.colSales.VisibleIndex = 30;
			this.colSales.Width = 94;
			// 
			// colUserId
			// 
			this.colUserId.FieldName = "UserId";
			this.colUserId.MinWidth = 25;
			this.colUserId.Name = "colUserId";
			this.colUserId.Visible = true;
			this.colUserId.VisibleIndex = 31;
			this.colUserId.Width = 94;
			// 
			// colProject
			// 
			this.colProject.FieldName = "Project";
			this.colProject.MinWidth = 25;
			this.colProject.Name = "colProject";
			this.colProject.Visible = true;
			this.colProject.VisibleIndex = 32;
			this.colProject.Width = 94;
			// 
			// colTransit
			// 
			this.colTransit.FieldName = "Transit";
			this.colTransit.MinWidth = 25;
			this.colTransit.Name = "colTransit";
			this.colTransit.Visible = true;
			this.colTransit.VisibleIndex = 33;
			this.colTransit.Width = 94;
			// 
			// colFullPaid
			// 
			this.colFullPaid.FieldName = "FullPaid";
			this.colFullPaid.MinWidth = 25;
			this.colFullPaid.Name = "colFullPaid";
			this.colFullPaid.Visible = true;
			this.colFullPaid.VisibleIndex = 34;
			this.colFullPaid.Width = 94;
			// 
			// colFullPaidDate
			// 
			this.colFullPaidDate.ColumnEdit = this.repDateFormat;
			this.colFullPaidDate.FieldName = "FullPaidDate";
			this.colFullPaidDate.MinWidth = 25;
			this.colFullPaidDate.Name = "colFullPaidDate";
			this.colFullPaidDate.Visible = true;
			this.colFullPaidDate.VisibleIndex = 72;
			this.colFullPaidDate.Width = 94;
			// 
			// colClearingAgentId
			// 
			this.colClearingAgentId.Caption = "Clearing Agent";
			this.colClearingAgentId.FieldName = "ClearingAgentId";
			this.colClearingAgentId.MinWidth = 25;
			this.colClearingAgentId.Name = "colClearingAgentId";
			this.colClearingAgentId.Visible = true;
			this.colClearingAgentId.VisibleIndex = 35;
			this.colClearingAgentId.Width = 94;
			// 
			// colATD
			// 
			this.colATD.ColumnEdit = this.repDateFormat;
			this.colATD.FieldName = "Atd";
			this.colATD.MinWidth = 25;
			this.colATD.Name = "colATD";
			this.colATD.Visible = true;
			this.colATD.VisibleIndex = 36;
			this.colATD.Width = 94;
			// 
			// colATA
			// 
			this.colATA.ColumnEdit = this.repDateFormat;
			this.colATA.FieldName = "Ata";
			this.colATA.MinWidth = 25;
			this.colATA.Name = "colATA";
			this.colATA.Visible = true;
			this.colATA.VisibleIndex = 37;
			this.colATA.Width = 94;
			// 
			// colETD
			// 
			this.colETD.ColumnEdit = this.repDateFormat;
			this.colETD.FieldName = "Etd";
			this.colETD.MinWidth = 25;
			this.colETD.Name = "colETD";
			this.colETD.Visible = true;
			this.colETD.VisibleIndex = 38;
			this.colETD.Width = 94;
			// 
			// colETA
			// 
			this.colETA.ColumnEdit = this.repDateFormat;
			this.colETA.FieldName = "Eta";
			this.colETA.MinWidth = 25;
			this.colETA.Name = "colETA";
			this.colETA.Visible = true;
			this.colETA.VisibleIndex = 39;
			this.colETA.Width = 94;
			// 
			// colCutOffDate
			// 
			this.colCutOffDate.ColumnEdit = this.repDateFormat;
			this.colCutOffDate.FieldName = "CutOffDate";
			this.colCutOffDate.MinWidth = 25;
			this.colCutOffDate.Name = "colCutOffDate";
			this.colCutOffDate.Visible = true;
			this.colCutOffDate.VisibleIndex = 40;
			this.colCutOffDate.Width = 94;
			// 
			// colDOL
			// 
			this.colDOL.FieldName = "DateOfLoading";
			this.colDOL.MinWidth = 25;
			this.colDOL.Name = "colDOL";
			this.colDOL.Visible = true;
			this.colDOL.VisibleIndex = 41;
			this.colDOL.Width = 94;
			// 
			// colPPCC
			// 
			this.colPPCC.FieldName = "Ppcc";
			this.colPPCC.MinWidth = 25;
			this.colPPCC.Name = "colPPCC";
			this.colPPCC.Visible = true;
			this.colPPCC.VisibleIndex = 42;
			this.colPPCC.Width = 94;
			// 
			// colStatus
			// 
			this.colStatus.FieldName = "Status";
			this.colStatus.MinWidth = 25;
			this.colStatus.Name = "colStatus";
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 43;
			this.colStatus.Width = 94;
			// 
			// colBlstatus
			// 
			this.colBlstatus.FieldName = "Blstatus";
			this.colBlstatus.MinWidth = 25;
			this.colBlstatus.Name = "colBlstatus";
			this.colBlstatus.Visible = true;
			this.colBlstatus.VisibleIndex = 44;
			this.colBlstatus.Width = 94;
			// 
			// colRTejrim
			// 
			this.colRTejrim.FieldName = "RTejrim";
			this.colRTejrim.MinWidth = 25;
			this.colRTejrim.Name = "colRTejrim";
			this.colRTejrim.Visible = true;
			this.colRTejrim.VisibleIndex = 45;
			this.colRTejrim.Width = 94;
			// 
			// colRTejrimDate
			// 
			this.colRTejrimDate.ColumnEdit = this.repDateFormat;
			this.colRTejrimDate.FieldName = "RTejrimDate";
			this.colRTejrimDate.MinWidth = 25;
			this.colRTejrimDate.Name = "colRTejrimDate";
			this.colRTejrimDate.Visible = true;
			this.colRTejrimDate.VisibleIndex = 46;
			this.colRTejrimDate.Width = 94;
			// 
			// colTejrim
			// 
			this.colTejrim.FieldName = "Tejrim";
			this.colTejrim.MinWidth = 25;
			this.colTejrim.Name = "colTejrim";
			this.colTejrim.Visible = true;
			this.colTejrim.VisibleIndex = 47;
			this.colTejrim.Width = 94;
			// 
			// colTejrimDate
			// 
			this.colTejrimDate.ColumnEdit = this.repDateFormat;
			this.colTejrimDate.FieldName = "TejrimDate";
			this.colTejrimDate.MinWidth = 25;
			this.colTejrimDate.Name = "colTejrimDate";
			this.colTejrimDate.Visible = true;
			this.colTejrimDate.VisibleIndex = 48;
			this.colTejrimDate.Width = 94;
			// 
			// colRClearance
			// 
			this.colRClearance.FieldName = "RClearance";
			this.colRClearance.MinWidth = 25;
			this.colRClearance.Name = "colRClearance";
			this.colRClearance.Visible = true;
			this.colRClearance.VisibleIndex = 49;
			this.colRClearance.Width = 94;
			// 
			// colRClearanceDate
			// 
			this.colRClearanceDate.ColumnEdit = this.repDateFormat;
			this.colRClearanceDate.FieldName = "RClearanceDate";
			this.colRClearanceDate.MinWidth = 25;
			this.colRClearanceDate.Name = "colRClearanceDate";
			this.colRClearanceDate.Visible = true;
			this.colRClearanceDate.VisibleIndex = 50;
			this.colRClearanceDate.Width = 94;
			// 
			// colIncoTerms
			// 
			this.colIncoTerms.FieldName = "IncoTerms";
			this.colIncoTerms.MinWidth = 25;
			this.colIncoTerms.Name = "colIncoTerms";
			this.colIncoTerms.Visible = true;
			this.colIncoTerms.VisibleIndex = 51;
			this.colIncoTerms.Width = 94;
			// 
			// colIncoTermsFrom
			// 
			this.colIncoTermsFrom.FieldName = "IncoTermsFrom";
			this.colIncoTermsFrom.MinWidth = 25;
			this.colIncoTermsFrom.Name = "colIncoTermsFrom";
			this.colIncoTermsFrom.Visible = true;
			this.colIncoTermsFrom.VisibleIndex = 52;
			this.colIncoTermsFrom.Width = 94;
			// 
			// colIncoTermsTo
			// 
			this.colIncoTermsTo.FieldName = "IncoTermsTo";
			this.colIncoTermsTo.MinWidth = 25;
			this.colIncoTermsTo.Name = "colIncoTermsTo";
			this.colIncoTermsTo.Visible = true;
			this.colIncoTermsTo.VisibleIndex = 53;
			this.colIncoTermsTo.Width = 94;
			// 
			// colAllInOrderToBeLoaded
			// 
			this.colAllInOrderToBeLoaded.FieldName = "AllInOrderToBeLoaded";
			this.colAllInOrderToBeLoaded.MinWidth = 25;
			this.colAllInOrderToBeLoaded.Name = "colAllInOrderToBeLoaded";
			this.colAllInOrderToBeLoaded.Visible = true;
			this.colAllInOrderToBeLoaded.VisibleIndex = 54;
			this.colAllInOrderToBeLoaded.Width = 94;
			// 
			// colAllInOrderOnWater
			// 
			this.colAllInOrderOnWater.FieldName = "AllInOrderOnWater";
			this.colAllInOrderOnWater.MinWidth = 25;
			this.colAllInOrderOnWater.Name = "colAllInOrderOnWater";
			this.colAllInOrderOnWater.Visible = true;
			this.colAllInOrderOnWater.VisibleIndex = 55;
			this.colAllInOrderOnWater.Width = 94;
			// 
			// colContainerToCnee
			// 
			this.colContainerToCnee.FieldName = "ContainerToCnee";
			this.colContainerToCnee.MinWidth = 25;
			this.colContainerToCnee.Name = "colContainerToCnee";
			this.colContainerToCnee.Visible = true;
			this.colContainerToCnee.VisibleIndex = 56;
			this.colContainerToCnee.Width = 94;
			// 
			// colDtCntrToCnee
			// 
			this.colDtCntrToCnee.FieldName = "DtCntrToCnee";
			this.colDtCntrToCnee.MinWidth = 25;
			this.colDtCntrToCnee.Name = "colDtCntrToCnee";
			this.colDtCntrToCnee.Visible = true;
			this.colDtCntrToCnee.VisibleIndex = 57;
			this.colDtCntrToCnee.Width = 94;
			// 
			// colEmptyContainer
			// 
			this.colEmptyContainer.FieldName = "EmptyContainer";
			this.colEmptyContainer.MinWidth = 25;
			this.colEmptyContainer.Name = "colEmptyContainer";
			this.colEmptyContainer.Visible = true;
			this.colEmptyContainer.VisibleIndex = 58;
			this.colEmptyContainer.Width = 94;
			// 
			// colDtEmptyCntr
			// 
			this.colDtEmptyCntr.FieldName = "DtEmptyCntr";
			this.colDtEmptyCntr.MinWidth = 25;
			this.colDtEmptyCntr.Name = "colDtEmptyCntr";
			this.colDtEmptyCntr.Visible = true;
			this.colDtEmptyCntr.VisibleIndex = 59;
			this.colDtEmptyCntr.Width = 94;
			// 
			// colJobSCId
			// 
			this.colJobSCId.FieldName = "JobScId";
			this.colJobSCId.MinWidth = 25;
			this.colJobSCId.Name = "colJobSCId";
			this.colJobSCId.Visible = true;
			this.colJobSCId.VisibleIndex = 60;
			this.colJobSCId.Width = 94;
			// 
			// colLocked
			// 
			this.colLocked.FieldName = "Locked";
			this.colLocked.MinWidth = 25;
			this.colLocked.Name = "colLocked";
			this.colLocked.Visible = true;
			this.colLocked.VisibleIndex = 61;
			this.colLocked.Width = 94;
			// 
			// colClosed
			// 
			this.colClosed.FieldName = "Closed";
			this.colClosed.MinWidth = 25;
			this.colClosed.Name = "colClosed";
			this.colClosed.Visible = true;
			this.colClosed.VisibleIndex = 62;
			this.colClosed.Width = 120;
			// 
			// colClosedDate
			// 
			this.colClosedDate.ColumnEdit = this.repDateFormat;
			this.colClosedDate.FieldName = "ClosedDate";
			this.colClosedDate.MinWidth = 25;
			this.colClosedDate.Name = "colClosedDate";
			this.colClosedDate.Visible = true;
			this.colClosedDate.VisibleIndex = 63;
			this.colClosedDate.Width = 126;
			// 
			// colCanceledJob
			// 
			this.colCanceledJob.FieldName = "CancelledJob";
			this.colCanceledJob.MinWidth = 25;
			this.colCanceledJob.Name = "colCanceledJob";
			this.colCanceledJob.Visible = true;
			this.colCanceledJob.VisibleIndex = 64;
			this.colCanceledJob.Width = 116;
			// 
			// colCanceledDate
			// 
			this.colCanceledDate.ColumnEdit = this.repDateFormat;
			this.colCanceledDate.FieldName = "CancelledJobDate";
			this.colCanceledDate.MinWidth = 25;
			this.colCanceledDate.Name = "colCanceledDate";
			this.colCanceledDate.Visible = true;
			this.colCanceledDate.VisibleIndex = 65;
			this.colCanceledDate.Width = 117;
			// 
			// colCanceledUser
			// 
			this.colCanceledUser.FieldName = "CancelledJobByUserId";
			this.colCanceledUser.MinWidth = 25;
			this.colCanceledUser.Name = "colCanceledUser";
			this.colCanceledUser.Visible = true;
			this.colCanceledUser.VisibleIndex = 66;
			this.colCanceledUser.Width = 121;
			// 
			// colLastJobReopenedBy
			// 
			this.colLastJobReopenedBy.FieldName = "LastJobReopenedBy";
			this.colLastJobReopenedBy.MinWidth = 25;
			this.colLastJobReopenedBy.Name = "colLastJobReopenedBy";
			this.colLastJobReopenedBy.Visible = true;
			this.colLastJobReopenedBy.VisibleIndex = 67;
			this.colLastJobReopenedBy.Width = 155;
			// 
			// colLastJobReopened
			// 
			this.colLastJobReopened.FieldName = "LastJobReopenedDate";
			this.colLastJobReopened.MinWidth = 25;
			this.colLastJobReopened.Name = "colLastJobReopened";
			this.colLastJobReopened.Visible = true;
			this.colLastJobReopened.VisibleIndex = 68;
			this.colLastJobReopened.Width = 159;
			// 
			// colCostReady
			// 
			this.colCostReady.FieldName = "CostReady";
			this.colCostReady.MinWidth = 25;
			this.colCostReady.Name = "colCostReady";
			this.colCostReady.Visible = true;
			this.colCostReady.VisibleIndex = 69;
			this.colCostReady.Width = 94;
			// 
			// colCostReadyDate
			// 
			this.colCostReadyDate.ColumnEdit = this.repDateFormat;
			this.colCostReadyDate.FieldName = "CostReadyDate";
			this.colCostReadyDate.MinWidth = 25;
			this.colCostReadyDate.Name = "colCostReadyDate";
			this.colCostReadyDate.Visible = true;
			this.colCostReadyDate.VisibleIndex = 70;
			this.colCostReadyDate.Width = 123;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 71;
			this.colNotes.Width = 404;
			// 
			// repUsersList
			// 
			this.repUsersList.AutoHeight = false;
			this.repUsersList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repUsersList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "Name", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repUsersList.DisplayMember = "UserName";
			this.repUsersList.Name = "repUsersList";
			this.repUsersList.NullText = "";
			this.repUsersList.ValueMember = "Id";
			// 
			// repSalesList
			// 
			this.repSalesList.AutoHeight = false;
			this.repSalesList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repSalesList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "Name", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repSalesList.DisplayMember = "UserName";
			this.repSalesList.Name = "repSalesList";
			this.repSalesList.NullText = "";
			this.repSalesList.ValueMember = "Id";
			// 
			// repCheckList
			// 
			this.repCheckList.AutoHeight = false;
			this.repCheckList.Name = "repCheckList";
			// 
			// repNumberFormat
			// 
			this.repNumberFormat.AutoHeight = false;
			this.repNumberFormat.Name = "repNumberFormat";
			this.repNumberFormat.UseMaskAsDisplayFormat = true;
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
			this.barSubItem2.Name = "barSubItem2";
			this.barSubItem2.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
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
			this.barSubItem3.Name = "barSubItem3";
			this.barSubItem3.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
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
			// rcJobSeaImport
			// 
			this.rcJobSeaImport.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcJobSeaImport.ExpandCollapseItem.Id = 0;
			this.rcJobSeaImport.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcJobSeaImport.ExpandCollapseItem,
            this.btnNew,
            this.btnDelete,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnEdit,
            this.btnPrint,
            this.rgFilterReports,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem7,
            this.barSubItem1,
            this.barButtonItem16,
            this.barButtonItem17,
            this.barSubItem4,
            this.barCheckItem5,
            this.barCheckItem6,
            this.barButtonItem18,
            this.barCheckItem1,
            this.barButtonItem19,
            this.barCheckItem4,
            this.barCheckItem3,
            this.barButtonItem20,
            this.barHeaderItem2,
            this.btnRefresh,
            this.btnClose,
            this.cboOperatingUsers,
            this.cboSales,
            this.cboStatus,
            this.chkShowProtected,
            this.barCheckItem2,
            this.barCheckItem9,
            this.rgSortByReports,
            this.rgOrderByReports,
            this.btnResetGridStyle});
			this.rcJobSeaImport.Location = new System.Drawing.Point(0, 0);
			this.rcJobSeaImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcJobSeaImport.MaxItemId = 62;
			this.rcJobSeaImport.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.rcJobSeaImport.Name = "rcJobSeaImport";
			this.rcJobSeaImport.OptionsMenuMinWidth = 385;
			this.rcJobSeaImport.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpJobSeaImport,
            this.rpViewSettings});
			this.rcJobSeaImport.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repOperatingUsers,
            this.repSales,
            this.repStatusList});
			this.rcJobSeaImport.Size = new System.Drawing.Size(1441, 193);
			this.rcJobSeaImport.StatusBar = this.ribbonStatusBar1;
			// 
			// btnNew
			// 
			this.btnNew.Caption = "Add New";
			this.btnNew.Enabled = false;
			this.btnNew.Hint = "F1";
			this.btnNew.Id = 1;
			this.btnNew.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnNew.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewCustomer.svg";
			this.btnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNew.ImageOptions.SvgImage")));
			this.btnNew.Name = "btnNew";
			toolTipTitleItem1.Text = "Add (F1)";
			toolTipItem1.Text = "Click F1 for Add";
			superToolTip1.Items.Add(toolTipTitleItem1);
			superToolTip1.Items.Add(toolTipItem1);
			this.btnNew.SuperTip = superToolTip1;
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
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "New Member Type";
			this.barButtonItem1.Id = 11;
			this.barButtonItem1.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewCustomer.svg?Size=16x16";
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "New Group";
			this.barButtonItem2.Id = 12;
			this.barButtonItem2.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewGroup.svg?Size=16x16";
			this.barButtonItem2.Name = "barButtonItem2";
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
			galleryItem1.Caption = "Active Jobs";
			galleryItem1.Checked = true;
			galleryItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
			galleryItem1.Value = "showActive";
			galleryItem2.Caption = "Closed Jobs";
			galleryItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
			galleryItem2.Value = "showClosed";
			galleryItem3.Caption = "Cancelled Jobs";
			galleryItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
			galleryItem3.Value = "showCancelled";
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
			this.rgFilterReports.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgFilterReports_GalleryItemClick);
			// 
			// barButtonItem3
			// 
			this.barButtonItem3.Caption = "Sales Summary";
			this.barButtonItem3.Id = 18;
			this.barButtonItem3.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem3.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesSummary2.svg?Size=16x16";
			this.barButtonItem3.Name = "barButtonItem3";
			// 
			// barButtonItem4
			// 
			this.barButtonItem4.Caption = "Member Type Profile";
			this.barButtonItem4.Id = 19;
			this.barButtonItem4.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem4.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ProfileReport.svg?Size=16x16";
			this.barButtonItem4.Name = "barButtonItem4";
			// 
			// barButtonItem7
			// 
			this.barButtonItem7.Caption = "Employees";
			this.barButtonItem7.Id = 20;
			this.barButtonItem7.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem7.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.EmployeeCard.svg?Size=16x16";
			this.barButtonItem7.Name = "barButtonItem7";
			// 
			// barSubItem1
			// 
			this.barSubItem1.Caption = "Change View";
			this.barSubItem1.Id = 21;
			this.barSubItem1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barSubItem1.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ChangeView.svg";
			this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem4)});
			this.barSubItem1.Name = "barSubItem1";
			this.barSubItem1.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
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
			// barButtonItem16
			// 
			this.barButtonItem16.Caption = "View Settings";
			this.barButtonItem16.Id = 22;
			this.barButtonItem16.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem16.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ViewSetting.svg";
			this.barButtonItem16.Name = "barButtonItem16";
			// 
			// barButtonItem17
			// 
			this.barButtonItem17.Caption = "Reset View";
			this.barButtonItem17.Id = 23;
			this.barButtonItem17.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem17.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ResetView.svg";
			this.barButtonItem17.Name = "barButtonItem17";
			// 
			// barSubItem4
			// 
			this.barSubItem4.Caption = "Data Pane";
			this.barSubItem4.Id = 24;
			this.barSubItem4.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barSubItem4.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.DataPanel.svg";
			this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem6)});
			this.barSubItem4.Name = "barSubItem4";
			this.barSubItem4.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
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
			// barButtonItem18
			// 
			this.barButtonItem18.Caption = "Reverse Sort";
			this.barButtonItem18.Id = 28;
			this.barButtonItem18.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem18.ImageOptions.ImageUri.Uri = "outlook%20inspired/reverssort;Size16x16";
			this.barButtonItem18.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			this.barButtonItem18.Name = "barButtonItem18";
			// 
			// barCheckItem1
			// 
			this.barCheckItem1.Caption = "Add Columns";
			this.barCheckItem1.Id = 30;
			this.barCheckItem1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barCheckItem1.ImageOptions.ImageUri.Uri = "outlook%20inspired/addcolumn;Size16x16";
			this.barCheckItem1.Name = "barCheckItem1";
			// 
			// barButtonItem19
			// 
			this.barButtonItem19.Caption = "Expand/Collapse";
			this.barButtonItem19.Id = 31;
			this.barButtonItem19.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem19.ImageOptions.ImageUri.Uri = "outlook%20inspired/expandcollapse;Size16x16";
			this.barButtonItem19.Name = "barButtonItem19";
			// 
			// barButtonItem20
			// 
			this.barButtonItem20.Caption = "Sales Detail";
			this.barButtonItem20.Id = 34;
			this.barButtonItem20.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.barButtonItem20.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesInvoise2.svg?Size=16x16";
			this.barButtonItem20.Name = "barButtonItem20";
			// 
			// barHeaderItem2
			// 
			this.barHeaderItem2.Caption = "RECORDS: 0";
			this.barHeaderItem2.Id = 35;
			this.barHeaderItem2.Name = "barHeaderItem2";
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
			// cboOperatingUsers
			// 
			this.cboOperatingUsers.Caption = "Operating User";
			this.cboOperatingUsers.CaptionToEditorIndent = 6;
			this.cboOperatingUsers.Edit = this.repOperatingUsers;
			this.cboOperatingUsers.EditWidth = 150;
			this.cboOperatingUsers.Id = 39;
			this.cboOperatingUsers.Name = "cboOperatingUsers";
			// 
			// repOperatingUsers
			// 
			this.repOperatingUsers.AutoHeight = false;
			this.repOperatingUsers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repOperatingUsers.DisplayMember = "DepartmentName";
			this.repOperatingUsers.Name = "repOperatingUsers";
			this.repOperatingUsers.NullText = "";
			this.repOperatingUsers.PopupView = this.repositoryItemSearchLookUpEdit1View;
			this.repOperatingUsers.ValueMember = "Id";
			// 
			// repositoryItemSearchLookUpEdit1View
			// 
			this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDepartmentId,
            this.colDepartmentName});
			this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
			this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// colDepartmentId
			// 
			this.colDepartmentId.Caption = "Id";
			this.colDepartmentId.FieldName = "Id";
			this.colDepartmentId.Name = "colDepartmentId";
			this.colDepartmentId.Visible = true;
			this.colDepartmentId.VisibleIndex = 0;
			this.colDepartmentId.Width = 78;
			// 
			// colDepartmentName
			// 
			this.colDepartmentName.Caption = "Department Name";
			this.colDepartmentName.FieldName = "DepartmentName";
			this.colDepartmentName.Name = "colDepartmentName";
			this.colDepartmentName.Visible = true;
			this.colDepartmentName.VisibleIndex = 1;
			this.colDepartmentName.Width = 844;
			// 
			// cboSales
			// 
			this.cboSales.Caption = "Sales";
			this.cboSales.CaptionToEditorIndent = 50;
			this.cboSales.Edit = this.repSales;
			this.cboSales.EditWidth = 150;
			this.cboSales.Id = 40;
			this.cboSales.Name = "cboSales";
			// 
			// repSales
			// 
			this.repSales.AutoHeight = false;
			this.repSales.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repSales.Name = "repSales";
			this.repSales.NullText = "";
			this.repSales.PopupView = this.repositoryItemSearchLookUpEdit2View;
			// 
			// repositoryItemSearchLookUpEdit2View
			// 
			this.repositoryItemSearchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalesId,
            this.colSalesName});
			this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
			this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
			// 
			// colSalesId
			// 
			this.colSalesId.Caption = "Id";
			this.colSalesId.FieldName = "Id";
			this.colSalesId.Name = "colSalesId";
			this.colSalesId.Visible = true;
			this.colSalesId.VisibleIndex = 0;
			this.colSalesId.Width = 84;
			// 
			// colSalesName
			// 
			this.colSalesName.Caption = "User Name";
			this.colSalesName.FieldName = "UserName";
			this.colSalesName.Name = "colSalesName";
			this.colSalesName.Visible = true;
			this.colSalesName.VisibleIndex = 1;
			this.colSalesName.Width = 838;
			// 
			// cboStatus
			// 
			this.cboStatus.Caption = "Status";
			this.cboStatus.CaptionToEditorIndent = 45;
			this.cboStatus.Edit = this.repStatusList;
			this.cboStatus.EditWidth = 150;
			this.cboStatus.Id = 44;
			this.cboStatus.Name = "cboStatus";
			// 
			// repStatusList
			// 
			this.repStatusList.AutoHeight = false;
			this.repStatusList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repStatusList.Name = "repStatusList";
			this.repStatusList.NullText = "";
			this.repStatusList.PopupView = this.repositoryItemSearchLookUpEdit3View;
			// 
			// repositoryItemSearchLookUpEdit3View
			// 
			this.repositoryItemSearchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.repositoryItemSearchLookUpEdit3View.Name = "repositoryItemSearchLookUpEdit3View";
			this.repositoryItemSearchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.repositoryItemSearchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
			// 
			// chkShowProtected
			// 
			this.chkShowProtected.Caption = "Show Protected";
			this.chkShowProtected.Enabled = false;
			this.chkShowProtected.Id = 45;
			this.chkShowProtected.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("chkShowProtected.ImageOptions.SvgImage")));
			this.chkShowProtected.Name = "chkShowProtected";
			// 
			// barCheckItem2
			// 
			this.barCheckItem2.Caption = "Sort By Booked Date";
			this.barCheckItem2.Id = 51;
			this.barCheckItem2.Name = "barCheckItem2";
			// 
			// barCheckItem9
			// 
			this.barCheckItem9.Caption = "Sort By Followup Date";
			this.barCheckItem9.Id = 52;
			this.barCheckItem9.Name = "barCheckItem9";
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
			galleryItem5.Caption = "Sort By Job No";
			galleryItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage4")));
			galleryItem5.Value = "SortByJobNo";
			galleryItem6.Caption = "Sort By XONO";
			galleryItem6.Checked = true;
			galleryItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage5")));
			galleryItem6.Value = "SortByRefNo";
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
			this.rgSortByReports.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgSortByReports_GalleryItemClick);
			// 
			// rgOrderByReports
			// 
			this.rgOrderByReports.Caption = "ribbonGalleryBarItem1";
			// 
			// 
			// 
			this.rgOrderByReports.Gallery.ColumnCount = 1;
			this.rgOrderByReports.Gallery.DrawImageBackground = false;
			galleryItemGroup3.Caption = "Group1";
			galleryItem7.Caption = "Ascending";
			galleryItem7.Checked = true;
			galleryItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage6")));
			galleryItem7.Value = "Ascending";
			galleryItem8.Caption = "Descending";
			galleryItem8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage7")));
			galleryItem8.Value = "Descending";
			galleryItemGroup3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem7,
            galleryItem8});
			this.rgOrderByReports.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup3});
			this.rgOrderByReports.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck;
			this.rgOrderByReports.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
			skinPaddingEdges5.Bottom = -4;
			skinPaddingEdges5.Top = -4;
			this.rgOrderByReports.Gallery.ItemImagePadding = skinPaddingEdges5;
			skinPaddingEdges6.Bottom = -1;
			skinPaddingEdges6.Top = -1;
			this.rgOrderByReports.Gallery.ItemTextPadding = skinPaddingEdges6;
			this.rgOrderByReports.Gallery.ShowItemText = true;
			this.rgOrderByReports.Id = 58;
			this.rgOrderByReports.Name = "rgOrderByReports";
			this.rgOrderByReports.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgOrderByReports_GalleryItemClick);
			// 
			// btnResetGridStyle
			// 
			this.btnResetGridStyle.Caption = "Reset Grid Style";
			this.btnResetGridStyle.Id = 61;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			this.btnResetGridStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetGridStyle_ItemClick);
			// 
			// rpJobSeaImport
			// 
			this.rpJobSeaImport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup2,
            this.rpgDepartments,
            this.rpgPermissions,
            this.ribbonPageGroup11});
			this.rpJobSeaImport.Name = "rpJobSeaImport";
			this.rpJobSeaImport.Text = "Job Sea Import";
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
			this.ribbonPageGroup2.ItemLinks.Add(this.rgOrderByReports);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "SortBy Reports";
			// 
			// rpgDepartments
			// 
			this.rpgDepartments.AllowTextClipping = false;
			this.rpgDepartments.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.rpgDepartments.ItemLinks.Add(this.cboOperatingUsers);
			this.rpgDepartments.ItemLinks.Add(this.cboSales);
			this.rpgDepartments.ItemLinks.Add(this.cboStatus);
			this.rpgDepartments.Name = "rpgDepartments";
			this.rpgDepartments.Text = "Filter View";
			// 
			// rpgPermissions
			// 
			this.rpgPermissions.ItemLinks.Add(this.chkShowProtected);
			this.rpgPermissions.Name = "rpgPermissions";
			this.rpgPermissions.Text = "Permissions";
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
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 748);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcJobSeaImport;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1441, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.gcSeaImport);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1441, 555);
			this.mainLayout.TabIndex = 14;
			this.mainLayout.Text = "dataLayoutControl1";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1441, 555);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcSeaImport;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1417, 531);
			this.layoutControlItem1.TextVisible = false;
			// 
			// JobSeaImportListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1441, 778);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.rcJobSeaImport);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Name = "JobSeaImportListForm";
			this.Ribbon = this.rcJobSeaImport;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Sea Import List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JobSeaImportListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.gvSeaImportDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcSeaImport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsSeaImportJobs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvSeaImport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repAgents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repPOLPortCodeList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repPODPortCodeList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repJobsType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSideId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repAgentCategories)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsersList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSalesList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repNumberFormat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rcJobSeaImport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repOperatingUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repStatusList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarCheckItem barCheckItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarCheckItem chkSortByBookedDate;
        private DevExpress.XtraBars.BarCheckItem barCheckItem8;
        public DevExpress.XtraBars.Ribbon.RibbonControl rcJobSeaImport;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgFilterReports;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem3;
        private DevExpress.XtraBars.BarCheckItem barCheckItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private DevExpress.XtraBars.BarButtonItem barButtonItem17;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarCheckItem barCheckItem5;
        private DevExpress.XtraBars.BarCheckItem barCheckItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem18;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem19;
        private DevExpress.XtraBars.BarButtonItem barButtonItem20;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem2;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarEditItem cboOperatingUsers;
        private DevExpress.XtraBars.BarEditItem cboSales;
        private DevExpress.XtraBars.BarEditItem cboStatus;
        private DevExpress.XtraBars.BarCheckItem chkShowProtected;
        private DevExpress.XtraBars.BarCheckItem barCheckItem2;
        private DevExpress.XtraBars.BarCheckItem barCheckItem9;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgSortByReports;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpJobSeaImport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDepartments;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPermissions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraDataLayout.DataLayoutControl mainLayout;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repOperatingUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSales;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repStatusList;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit3View;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesId;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesName;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgOrderByReports;
        private DevExpress.XtraGrid.GridControl gcSeaImport;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSeaImportDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailId;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailJobNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailBOL;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailOrigin;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailContNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSeaImport;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colRefNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colJobNo;
        private DevExpress.XtraGrid.Columns.GridColumn colJobDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDateFormat;
        private DevExpress.XtraGrid.Columns.GridColumn colMbol;
        private DevExpress.XtraGrid.Columns.GridColumn colContainerNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBookingNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberId1;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberName1;
        private DevExpress.XtraGrid.Columns.GridColumn colConsigneeId;
        private DevExpress.XtraGrid.Columns.GridColumn colAgentId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repAgents;
        private DevExpress.XtraGrid.Columns.GridColumn colSeaportDeparture;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repPOLPortCodeList;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryDeparture;
        private DevExpress.XtraGrid.Columns.GridColumn colSeaportDestination;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repPODPortCodeList;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryDestination;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckList;
        private DevExpress.XtraGrid.Columns.GridColumn colJobType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repJobsType;
        private DevExpress.XtraGrid.Columns.GridColumn colSideId;
        private DevExpress.XtraGrid.Columns.GridColumn colCommodity;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantities;
        private DevExpress.XtraGrid.Columns.GridColumn colPieces;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colValueOfGoods;
        private DevExpress.XtraGrid.Columns.GridColumn colShippedWithId;
        private DevExpress.XtraGrid.Columns.GridColumn colVesselId;
        private DevExpress.XtraGrid.Columns.GridColumn colFeederVesselId;
        private DevExpress.XtraGrid.Columns.GridColumn colDelivered;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveredTo;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveredDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyId;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalInvoicesLl;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalInvoicesUsd;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCostsLl;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCostsUsd;
        private DevExpress.XtraGrid.Columns.GridColumn colOperatingUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colSales;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colProject;
        private DevExpress.XtraGrid.Columns.GridColumn colTransit;
        private DevExpress.XtraGrid.Columns.GridColumn colFullPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colFullPaidDate;
        private DevExpress.XtraGrid.Columns.GridColumn colClearingAgentId;
        private DevExpress.XtraGrid.Columns.GridColumn colATD;
        private DevExpress.XtraGrid.Columns.GridColumn colATA;
        private DevExpress.XtraGrid.Columns.GridColumn colETD;
        private DevExpress.XtraGrid.Columns.GridColumn colETA;
        private DevExpress.XtraGrid.Columns.GridColumn colCutOffDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDOL;
        private DevExpress.XtraGrid.Columns.GridColumn colPPCC;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colBlstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colRTejrim;
        private DevExpress.XtraGrid.Columns.GridColumn colRTejrimDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTejrim;
        private DevExpress.XtraGrid.Columns.GridColumn colTejrimDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRClearance;
        private DevExpress.XtraGrid.Columns.GridColumn colRClearanceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIncoTerms;
        private DevExpress.XtraGrid.Columns.GridColumn colIncoTermsFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colIncoTermsTo;
        private DevExpress.XtraGrid.Columns.GridColumn colAllInOrderToBeLoaded;
        private DevExpress.XtraGrid.Columns.GridColumn colAllInOrderOnWater;
        private DevExpress.XtraGrid.Columns.GridColumn colContainerToCnee;
        private DevExpress.XtraGrid.Columns.GridColumn colDtCntrToCnee;
        private DevExpress.XtraGrid.Columns.GridColumn colEmptyContainer;
        private DevExpress.XtraGrid.Columns.GridColumn colDtEmptyCntr;
        private DevExpress.XtraGrid.Columns.GridColumn colJobSCId;
        private DevExpress.XtraGrid.Columns.GridColumn colLocked;
        private DevExpress.XtraGrid.Columns.GridColumn colClosed;
        private DevExpress.XtraGrid.Columns.GridColumn colClosedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCanceledJob;
        private DevExpress.XtraGrid.Columns.GridColumn colCanceledDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCanceledUser;
        private DevExpress.XtraGrid.Columns.GridColumn colLastJobReopenedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLastJobReopened;
        private DevExpress.XtraGrid.Columns.GridColumn colCostReady;
        private DevExpress.XtraGrid.Columns.GridColumn colCostReadyDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repUsersList;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repSalesList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bsSeaImportJobs;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repNumberFormat;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repAgentCategories;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repSideId;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
	}
}