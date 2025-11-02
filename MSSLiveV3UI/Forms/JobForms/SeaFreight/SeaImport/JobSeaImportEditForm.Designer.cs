using MISLiveMed.Models.Models.Accounting.CostSheets;
using MISLiveMed.Models.Models.Accounting.Invoices;
using MISLiveMed.Models.Models.Common.Documents;
using MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs;

namespace MISLiveMed.UI.Forms.JobForms.SeaFreight.SeaImport
{
    partial class JobSeaImportEditForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobSeaImportEditForm));
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup5 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges5 = new DevExpress.Skins.SkinPaddingEdges();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges6 = new DevExpress.Skins.SkinPaddingEdges();
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup6 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem13 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem14 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem15 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem16 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem17 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem18 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.Utils.ContextButton contextButton1 = new DevExpress.Utils.ContextButton();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			this.rcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
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
			this.btnNewInvoice = new DevExpress.XtraBars.BarButtonItem();
			this.btnNewCost = new DevExpress.XtraBars.BarButtonItem();
			this.btnProtected = new DevExpress.XtraBars.BarCheckItem();
			this.bsJobSeaImport = new System.Windows.Forms.BindingSource(this.components);
			this.btnCloseInvoice = new DevExpress.XtraBars.BarButtonItem();
			this.btnSaveInvoice = new DevExpress.XtraBars.BarButtonItem();
			this.btnSaveAndCloseInvoice = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefreshInvoice = new DevExpress.XtraBars.BarButtonItem();
			this.btnDeleteInvoice = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrintInvoice = new DevExpress.XtraBars.BarButtonItem();
			this.btnInvoiceProtected = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrintOriginalInvoice = new DevExpress.XtraBars.BarButtonItem();
			this.btnCloseCost = new DevExpress.XtraBars.BarButtonItem();
			this.btnSaveCost = new DevExpress.XtraBars.BarButtonItem();
			this.btnSaveAndCloseCost = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefreshCost = new DevExpress.XtraBars.BarButtonItem();
			this.btnDeleteCost = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrintCost = new DevExpress.XtraBars.BarButtonItem();
			this.btnCostProtected = new DevExpress.XtraBars.BarButtonItem();
			this.rpMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgSecurity = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpInvoice = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup14 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup15 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpCost = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup16 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup17 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup18 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup19 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup20 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup21 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.bsJobSeaImportDetails = new System.Windows.Forms.BindingSource(this.components);
			this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
			this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
			this.bsCosts = new System.Windows.Forms.BindingSource(this.components);
			this.bsInvoices = new System.Windows.Forms.BindingSource(this.components);
			this.bsDocuments = new System.Windows.Forms.BindingSource(this.components);
			this.mainLayout = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.tabGroupNotes = new DevExpress.XtraTab.XtraTabControl();
			this.tabStatus = new DevExpress.XtraTab.XtraTabPage();
			this.layoutStatus = new DevExpress.XtraLayout.LayoutControl();
			this.txtStatus = new DevExpress.XtraEditors.MemoEdit();
			this.layoutControlGroup10 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.tabBlStatus = new DevExpress.XtraTab.XtraTabPage();
			this.layoutBlStatus = new DevExpress.XtraLayout.LayoutControl();
			this.txtBlStatus = new DevExpress.XtraEditors.MemoEdit();
			this.layoutControlGroup13 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
			this.tabNotes = new DevExpress.XtraTab.XtraTabPage();
			this.layoutNotes = new DevExpress.XtraLayout.LayoutControl();
			this.txtNotes = new DevExpress.XtraEditors.MemoEdit();
			this.layoutControlGroup14 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
			this.txtProfitLL = new DevExpress.XtraEditors.TextEdit();
			this.txtProfitUSD = new DevExpress.XtraEditors.TextEdit();
			this.txtTotalInvoicesUSD = new DevExpress.XtraEditors.TextEdit();
			this.txtTotalInvoicesLL = new DevExpress.XtraEditors.TextEdit();
			this.txtTotalCostsUSD = new DevExpress.XtraEditors.TextEdit();
			this.txtTotalCostsLL = new DevExpress.XtraEditors.TextEdit();
			this.grpJobInformation = new DevExpress.XtraTab.XtraTabControl();
			this.tabJobInformation = new DevExpress.XtraTab.XtraTabPage();
			this.layoutClientInformation = new DevExpress.XtraLayout.LayoutControl();
			this.txtMbl = new DevExpress.XtraEditors.TextEdit();
			this.txtJobNo = new DevExpress.XtraEditors.TextEdit();
			this.txtReferenceNo = new DevExpress.XtraEditors.TextEdit();
			this.dtJobDate = new DevExpress.XtraEditors.DateEdit();
			this.cboCustomers = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gcId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboConsignees = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gcConsigneeId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gcConsigneeName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboJobsType = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTypeDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.EtdDate = new DevExpress.XtraEditors.DateEdit();
			this.AtdDate = new DevExpress.XtraEditors.DateEdit();
			this.LoadingDate = new DevExpress.XtraEditors.DateEdit();
			this.AtaDate = new DevExpress.XtraEditors.DateEdit();
			this.EtaDate = new DevExpress.XtraEditors.DateEdit();
			this.CutOffDate = new DevExpress.XtraEditors.DateEdit();
			this.cboDeparture = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView14 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colSeaportDepartureId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSeaportDepartureName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboDestination = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colcboDestinationId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcboDestinationName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtCountryOfDeparture = new DevExpress.XtraEditors.TextEdit();
			this.txtCountryOfDestination = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup8 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblJobNo = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblReferenceNo = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblJobDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblCustomerName = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblConsigneeName = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblJobType = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblEtd = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblAtd = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblLoadingDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblAta = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblEta = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblCutOffDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblDeparture = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblDestination = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblCountryOfDeparture = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblCountryOfDestination = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblMbl = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem24 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.tabShipmentInformation = new DevExpress.XtraTab.XtraTabPage();
			this.layoutShipmentTracking = new DevExpress.XtraLayout.LayoutControl();
			this.cboShippedWith = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colShippedWithId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippedWith = new DevExpress.XtraGrid.Columns.GridColumn();
			this.dtConfirmEmptyContainer = new DevExpress.XtraEditors.DateEdit();
			this.dtEmptyContainer = new DevExpress.XtraEditors.DateEdit();
			this.dtContainerToCnee = new DevExpress.XtraEditors.DateEdit();
			this.chkEmptyContainer = new DevExpress.XtraEditors.CheckEdit();
			this.chkConfirmEmptyContainer = new DevExpress.XtraEditors.CheckEdit();
			this.chkContainerToCnee = new DevExpress.XtraEditors.CheckEdit();
			this.txtBookingNo = new DevExpress.XtraEditors.TextEdit();
			this.dtMissingDocumentsDate = new DevExpress.XtraEditors.DateEdit();
			this.dtPaidDoDate = new DevExpress.XtraEditors.DateEdit();
			this.dtTejrimDate = new DevExpress.XtraEditors.DateEdit();
			this.dateEdit10 = new DevExpress.XtraEditors.DateEdit();
			this.dtPendingForDelivery = new DevExpress.XtraEditors.DateEdit();
			this.dtReadyForClearance = new DevExpress.XtraEditors.DateEdit();
			this.dtReadyForTejrim = new DevExpress.XtraEditors.DateEdit();
			this.chkDeliveryDate = new DevExpress.XtraEditors.CheckEdit();
			this.chkMissingDocuments = new DevExpress.XtraEditors.CheckEdit();
			this.chkPendingForDelivery = new DevExpress.XtraEditors.CheckEdit();
			this.chkPaidDo = new DevExpress.XtraEditors.CheckEdit();
			this.chkReadyForClearance = new DevExpress.XtraEditors.CheckEdit();
			this.chkTejrim = new DevExpress.XtraEditors.CheckEdit();
			this.chkRTejrim = new DevExpress.XtraEditors.CheckEdit();
			this.cboAgents = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView12 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ColumnAgentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnAgentName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboIncoTerms = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView13 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ColumnTermsId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnTermCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnTermsDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboSeaCarriers = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ColumnSeaCarrierId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnSeaCarrierName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboVessels = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView61 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colVesselId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVesselName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboFeederVessels = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colFeederVesselId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFeederVesselName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtFreeOfDemurage = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup9 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblVessels = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblFeederVessels = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblAgents = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblSeaCarriers = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblIncoTerms = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblTejrimDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblPaidDoDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblMissingDocumentsDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem15 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblFreeOfDemurage = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblBookingNo = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem26 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblReadyForTejrim = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblReadyForClearance = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblPendingForDelivery = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblContainerToCneeDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblEmptyContainerDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblConfirmEmptyContainerDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblShippedWith = new DevExpress.XtraLayout.LayoutControlItem();
			this.tabPackageDetails = new DevExpress.XtraTab.XtraTabPage();
			this.layoutPackageDetails = new DevExpress.XtraLayout.LayoutControl();
			this.txtValueOfGoods = new DevExpress.XtraEditors.TextEdit();
			this.txtVolume = new DevExpress.XtraEditors.TextEdit();
			this.txtWeight = new DevExpress.XtraEditors.TextEdit();
			this.txtPieces = new DevExpress.XtraEditors.TextEdit();
			this.txtQuantities = new DevExpress.XtraEditors.TextEdit();
			this.txtNatureOfGoods = new DevExpress.XtraEditors.MemoEdit();
			this.layoutControlGroup11 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblQuantities = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem18 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblPieces = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblWeight = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblCommodities = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem19 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem20 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem21 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem22 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblVolume = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblValueOfGoods = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem25 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.tabUserInformation = new DevExpress.XtraTab.XtraTabPage();
			this.layoutUserInformation = new DevExpress.XtraLayout.LayoutControl();
			this.txtUserLogData = new DevExpress.XtraEditors.MemoEdit();
			this.cboUsers = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.columnUserId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.columnUserName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboSales = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.columnSalesmanId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.columnSalesmanName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboOperatingUsers = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.columnOperatingUserId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.columnOperatingUserName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblUserName = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblSalesman = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblOperatingUser = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem13 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem14 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem16 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem17 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblUserLogData = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem23 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.tabDetails = new DevExpress.XtraBars.Navigation.TabPane();
			this.tabJobDetails = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.layoutJobDetails = new DevExpress.XtraLayout.LayoutControl();
			this.gcJobDetails = new DevExpress.XtraGrid.GridControl();
			this.gvJobDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJobId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHbl = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOriginId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCountries = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colSupplierId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repShippers = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colContainerNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantities = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPieces = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUnitOfMeasureId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPackages = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colValueOfGoods = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTerms = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCcAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOriginal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPl = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPop = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCommodity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotify = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.tabRequirements = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.layoutRequirements = new DevExpress.XtraLayout.LayoutControl();
			this.lblAllInOrderOnWater = new DevExpress.XtraEditors.LabelControl();
			this.lblAllInOrderToBeloaded = new DevExpress.XtraEditors.LabelControl();
			this.btnAllInOrderOW = new DevExpress.XtraEditors.SimpleButton();
			this.btnAllInOrderTBL = new DevExpress.XtraEditors.SimpleButton();
			this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
			this.gcRequiredOnWater = new DevExpress.XtraGrid.GridControl();
			this.gvRequiredOnWater = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn47 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn48 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.gridColumn49 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn50 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn51 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gcRequiredToBeLoaded = new DevExpress.XtraGrid.GridControl();
			this.gvRequiredToBeLoaded = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn41 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn45 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.gridColumn43 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn44 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn46 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup12 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
			this.lcAllInOrderToBeloaded = new DevExpress.XtraLayout.LayoutControlItem();
			this.lcAllInOrderOnWater = new DevExpress.XtraLayout.LayoutControlItem();
			this.tabSellingGroup = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.layoutInvoicesGrid = new DevExpress.XtraLayout.LayoutControl();
			this.gcInvoices = new DevExpress.XtraGrid.GridControl();
			this.gvInvoices = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colSellingId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingQHeaderId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repSellingMemberList = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colSellingMemberNameId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingMemberName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingItemId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repSellingItemsList = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colItemId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingPaymentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repSellingPayemntsList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colSellingCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repSellingCurrenciesList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colSellingRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingL_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingF_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingVat = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingVatRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingVatAmountLL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingVatAmountUSD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingVatAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.tabCostGroup = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.layoutCostSheetsGrid = new DevExpress.XtraLayout.LayoutControl();
			this.gcCosts = new DevExpress.XtraGrid.GridControl();
			this.gvCosts = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCostId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostQHeaderId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostItemId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCostItemsList = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostAgentName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCostAgents = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colAgentID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAgentName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostPaymentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCostMethodofPaymentList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colCostCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCostCurrenciesList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colCostRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostL_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostF_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostVat = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostVatRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostVatAmountLL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostVatAmountUSD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostVatAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.tabDocuments = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.layoutAttachedDocumnets = new DevExpress.XtraLayout.LayoutControl();
			this.gcDocuments = new DevExpress.XtraGrid.GridControl();
			this.gvDocuments = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
			this.colDocumentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.openDocuments = new DevExpress.XtraEditors.SearchControl();
			this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblAddFiles = new DevExpress.XtraLayout.LayoutControlItem();
			this.tabCommissions = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.layoutSalesManagement = new DevExpress.XtraLayout.LayoutControl();
			this.gridControl2 = new DevExpress.XtraGrid.GridControl();
			this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.tabShipmentStatus = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.layoutShipmentStatus = new DevExpress.XtraLayout.LayoutControl();
			this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblDetailedTransactions = new DevExpress.XtraLayout.LayoutControlItem();
			this.tabJobInfo = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblGroupNotes = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup15 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.grpTotalLL = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblTotalCostsLL = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblTotalInvoicesLL = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblProfitLL = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.grpTotalUsd = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblTotalCostsUSD = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblTotalInvoicesUSD = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblProfitUSD = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.rcMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsJobSeaImport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsJobSeaImportDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCosts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsInvoices)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDocuments)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tabGroupNotes)).BeginInit();
			this.tabGroupNotes.SuspendLayout();
			this.tabStatus.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutStatus)).BeginInit();
			this.layoutStatus.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			this.tabBlStatus.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutBlStatus)).BeginInit();
			this.layoutBlStatus.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtBlStatus.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
			this.tabNotes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutNotes)).BeginInit();
			this.layoutNotes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProfitLL.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProfitUSD.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalInvoicesUSD.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalInvoicesLL.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalCostsUSD.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalCostsLL.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpJobInformation)).BeginInit();
			this.grpJobInformation.SuspendLayout();
			this.tabJobInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutClientInformation)).BeginInit();
			this.layoutClientInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtMbl.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtJobNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtReferenceNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtJobDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtJobDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCustomers.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboConsignees.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboJobsType.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EtdDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EtdDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtdDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtdDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LoadingDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LoadingDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtaDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AtaDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EtaDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EtaDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CutOffDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CutOffDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboDeparture.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboDestination.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCountryOfDeparture.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCountryOfDestination.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJobNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblReferenceNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJobDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCustomerName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblConsigneeName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJobType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblEtd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAtd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblLoadingDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblEta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCutOffDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDeparture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDestination)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCountryOfDeparture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCountryOfDestination)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMbl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem24)).BeginInit();
			this.tabShipmentInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutShipmentTracking)).BeginInit();
			this.layoutShipmentTracking.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboShippedWith.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtConfirmEmptyContainer.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtConfirmEmptyContainer.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtEmptyContainer.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtEmptyContainer.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtContainerToCnee.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtContainerToCnee.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkEmptyContainer.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkConfirmEmptyContainer.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkContainerToCnee.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBookingNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtMissingDocumentsDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtMissingDocumentsDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtPaidDoDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtPaidDoDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtTejrimDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtTejrimDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit10.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit10.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtPendingForDelivery.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtPendingForDelivery.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtReadyForClearance.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtReadyForClearance.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtReadyForTejrim.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtReadyForTejrim.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkDeliveryDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkMissingDocuments.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkPendingForDelivery.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkPaidDo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkReadyForClearance.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkTejrim.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkRTejrim.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboAgents.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboIncoTerms.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboSeaCarriers.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboVessels.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView61)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboFeederVessels.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFreeOfDemurage.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblVessels)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblFeederVessels)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAgents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSeaCarriers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblIncoTerms)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTejrimDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPaidDoDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMissingDocumentsDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblFreeOfDemurage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblBookingNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblReadyForTejrim)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblReadyForClearance)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPendingForDelivery)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblContainerToCneeDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblEmptyContainerDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblConfirmEmptyContainerDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblShippedWith)).BeginInit();
			this.tabPackageDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutPackageDetails)).BeginInit();
			this.layoutPackageDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtValueOfGoods.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVolume.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPieces.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantities.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNatureOfGoods.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblQuantities)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPieces)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCommodities)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblVolume)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblValueOfGoods)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem25)).BeginInit();
			this.tabUserInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutUserInformation)).BeginInit();
			this.layoutUserInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtUserLogData.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboUsers.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboSales.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboOperatingUsers.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblUserName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSalesman)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOperatingUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblUserLogData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tabDetails)).BeginInit();
			this.tabDetails.SuspendLayout();
			this.tabJobDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutJobDetails)).BeginInit();
			this.layoutJobDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcJobDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvJobDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCountries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repShippers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.tabRequirements.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutRequirements)).BeginInit();
			this.layoutRequirements.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
			this.gridSplitContainer1.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
			this.gridSplitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcRequiredOnWater)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvRequiredOnWater)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcRequiredToBeLoaded)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvRequiredToBeLoaded)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lcAllInOrderToBeloaded)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lcAllInOrderOnWater)).BeginInit();
			this.tabSellingGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutInvoicesGrid)).BeginInit();
			this.layoutInvoicesGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcInvoices)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvInvoices)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSellingMemberList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSellingItemsList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSellingPayemntsList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSellingCurrenciesList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			this.tabCostGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutCostSheetsGrid)).BeginInit();
			this.layoutCostSheetsGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcCosts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCosts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCostItemsList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCostAgents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCostMethodofPaymentList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCostCurrenciesList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			this.tabDocuments.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutAttachedDocumnets)).BeginInit();
			this.layoutAttachedDocumnets.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcDocuments)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDocuments)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.openDocuments.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAddFiles)).BeginInit();
			this.tabCommissions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutSalesManagement)).BeginInit();
			this.layoutSalesManagement.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			this.tabShipmentStatus.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutShipmentStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDetailedTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tabJobInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblGroupNotes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpTotalLL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalCostsLL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalInvoicesLL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProfitLL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpTotalUsd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalCostsUSD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalInvoicesUSD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProfitUSD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			this.SuspendLayout();
			// 
			// rcMain
			// 
			this.rcMain.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcMain.ExpandCollapseItem.Id = 0;
			this.rcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcMain.ExpandCollapseItem,
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
            this.btnNewInvoice,
            this.btnNewCost,
            this.btnProtected,
            this.btnCloseInvoice,
            this.btnSaveInvoice,
            this.btnSaveAndCloseInvoice,
            this.btnRefreshInvoice,
            this.btnDeleteInvoice,
            this.btnPrintInvoice,
            this.btnInvoiceProtected,
            this.btnPrintOriginalInvoice,
            this.btnCloseCost,
            this.btnSaveCost,
            this.btnSaveAndCloseCost,
            this.btnRefreshCost,
            this.btnDeleteCost,
            this.btnPrintCost,
            this.btnCostProtected});
			this.rcMain.Location = new System.Drawing.Point(0, 0);
			this.rcMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcMain.MaxItemId = 44;
			this.rcMain.Name = "rcMain";
			this.rcMain.OptionsMenuMinWidth = 385;
			this.rcMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpMain,
            this.rpInvoice,
            this.rpCost});
			this.rcMain.Size = new System.Drawing.Size(1448, 193);
			this.rcMain.StatusBar = this.ribbonStatusBar1;
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
			galleryItemGroup5.Caption = "Group1";
			this.galleryQuickLetters.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup5});
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
			galleryItemGroup6.Caption = "ActionGroup";
			galleryItem13.Caption = "Normal Mod";
			galleryItem13.Checked = true;
			galleryItem13.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
			galleryItem13.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem13.Value = 0;
			galleryItem14.Caption = "Close current Job";
			galleryItem14.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
			galleryItem14.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem14.Value = 1;
			galleryItem15.Caption = "Edit closed Job";
			galleryItem15.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
			galleryItem15.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem15.Value = 2;
			galleryItem16.Caption = "Cancel current File";
			galleryItem16.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage3")));
			galleryItem16.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem16.Value = 3;
			galleryItem17.Caption = "ReOpen canceled File";
			galleryItem17.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage4")));
			galleryItem17.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem17.Value = 4;
			galleryItem18.Caption = "N/A";
			galleryItem18.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage5")));
			galleryItem18.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem18.Value = 5;
			galleryItemGroup6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem13,
            galleryItem14,
            galleryItem15,
            galleryItem16,
            galleryItem17,
            galleryItem18});
			this.rgJobStatusAction.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup6});
			this.rgJobStatusAction.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck;
			this.rgJobStatusAction.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
			this.rgJobStatusAction.Gallery.ShowItemText = true;
			this.rgJobStatusAction.Id = 23;
			this.rgJobStatusAction.Name = "rgJobStatusAction";
			this.rgJobStatusAction.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgJobStatusAction_GalleryItemClick);
			// 
			// btnNewInvoice
			// 
			this.btnNewInvoice.Caption = "New Invoice";
			this.btnNewInvoice.Id = 24;
			this.btnNewInvoice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNewInvoice.ImageOptions.SvgImage")));
			this.btnNewInvoice.Name = "btnNewInvoice";
			this.btnNewInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewInvoice_ItemClick);
			// 
			// btnNewCost
			// 
			this.btnNewCost.Caption = "New Cost";
			this.btnNewCost.Enabled = false;
			this.btnNewCost.Id = 25;
			this.btnNewCost.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNewCost.ImageOptions.SvgImage")));
			this.btnNewCost.Name = "btnNewCost";
			this.btnNewCost.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewCost_ItemClick);
			// 
			// btnProtected
			// 
			this.btnProtected.Caption = "Protected";
			this.btnProtected.DataBindings.Add(new System.Windows.Forms.Binding("BindableChecked", this.bsJobSeaImport, "IsProtected", true));
			this.btnProtected.Enabled = false;
			this.btnProtected.Id = 28;
			this.btnProtected.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProtected.ImageOptions.SvgImage")));
			this.btnProtected.Name = "btnProtected";
			this.btnProtected.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProtected_CheckedChanged);
			// 
			// bsJobSeaImport
			// 
			this.bsJobSeaImport.DataSource = typeof(MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs.JobSeaImportModel);
			// 
			// btnCloseInvoice
			// 
			this.btnCloseInvoice.Caption = "Close";
			this.btnCloseInvoice.Id = 29;
			this.btnCloseInvoice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCloseInvoice.ImageOptions.SvgImage")));
			this.btnCloseInvoice.Name = "btnCloseInvoice";
			this.btnCloseInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCloseInvoice_ItemClick);
			// 
			// btnSaveInvoice
			// 
			this.btnSaveInvoice.Caption = "Save";
			this.btnSaveInvoice.Enabled = false;
			this.btnSaveInvoice.Id = 30;
			this.btnSaveInvoice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveInvoice.ImageOptions.SvgImage")));
			this.btnSaveInvoice.Name = "btnSaveInvoice";
			this.btnSaveInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveInvoice_ItemClick);
			// 
			// btnSaveAndCloseInvoice
			// 
			this.btnSaveAndCloseInvoice.Caption = "Save && Close";
			this.btnSaveAndCloseInvoice.Enabled = false;
			this.btnSaveAndCloseInvoice.Id = 31;
			this.btnSaveAndCloseInvoice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveAndCloseInvoice.ImageOptions.SvgImage")));
			this.btnSaveAndCloseInvoice.Name = "btnSaveAndCloseInvoice";
			this.btnSaveAndCloseInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAndCloseInvoice_ItemClick);
			// 
			// btnRefreshInvoice
			// 
			this.btnRefreshInvoice.Caption = "Refresh";
			this.btnRefreshInvoice.Id = 32;
			this.btnRefreshInvoice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefreshInvoice.ImageOptions.SvgImage")));
			this.btnRefreshInvoice.Name = "btnRefreshInvoice";
			this.btnRefreshInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshInvoice_ItemClick);
			// 
			// btnDeleteInvoice
			// 
			this.btnDeleteInvoice.Caption = "Delete";
			this.btnDeleteInvoice.Enabled = false;
			this.btnDeleteInvoice.Id = 33;
			this.btnDeleteInvoice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteInvoice.ImageOptions.SvgImage")));
			this.btnDeleteInvoice.Name = "btnDeleteInvoice";
			this.btnDeleteInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteInvoice_ItemClick);
			// 
			// btnPrintInvoice
			// 
			this.btnPrintInvoice.Caption = "Print Copy";
			this.btnPrintInvoice.Enabled = false;
			this.btnPrintInvoice.Id = 34;
			this.btnPrintInvoice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintInvoice.ImageOptions.SvgImage")));
			this.btnPrintInvoice.Name = "btnPrintInvoice";
			this.btnPrintInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintInvoice_ItemClick);
			// 
			// btnInvoiceProtected
			// 
			this.btnInvoiceProtected.Caption = "Invoice Protected";
			this.btnInvoiceProtected.Enabled = false;
			this.btnInvoiceProtected.Id = 35;
			this.btnInvoiceProtected.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInvoiceProtected.ImageOptions.SvgImage")));
			this.btnInvoiceProtected.Name = "btnInvoiceProtected";
			this.btnInvoiceProtected.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInvoiceProtected_ItemClick);
			// 
			// btnPrintOriginalInvoice
			// 
			this.btnPrintOriginalInvoice.Caption = "Print Original Invoice";
			this.btnPrintOriginalInvoice.Enabled = false;
			this.btnPrintOriginalInvoice.Id = 36;
			this.btnPrintOriginalInvoice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintOriginalInvoice.ImageOptions.SvgImage")));
			this.btnPrintOriginalInvoice.Name = "btnPrintOriginalInvoice";
			this.btnPrintOriginalInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintOriginalInvoice_ItemClick);
			// 
			// btnCloseCost
			// 
			this.btnCloseCost.Caption = "Close";
			this.btnCloseCost.Id = 37;
			this.btnCloseCost.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCloseCost.ImageOptions.SvgImage")));
			this.btnCloseCost.Name = "btnCloseCost";
			this.btnCloseCost.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCloseCost_ItemClick);
			// 
			// btnSaveCost
			// 
			this.btnSaveCost.Caption = "Save";
			this.btnSaveCost.Enabled = false;
			this.btnSaveCost.Id = 38;
			this.btnSaveCost.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveCost.ImageOptions.SvgImage")));
			this.btnSaveCost.Name = "btnSaveCost";
			this.btnSaveCost.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveCost_ItemClick);
			// 
			// btnSaveAndCloseCost
			// 
			this.btnSaveAndCloseCost.Caption = "Save && Close";
			this.btnSaveAndCloseCost.Enabled = false;
			this.btnSaveAndCloseCost.Id = 39;
			this.btnSaveAndCloseCost.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveAndCloseCost.ImageOptions.SvgImage")));
			this.btnSaveAndCloseCost.Name = "btnSaveAndCloseCost";
			this.btnSaveAndCloseCost.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAndCloseCost_ItemClick);
			// 
			// btnRefreshCost
			// 
			this.btnRefreshCost.Caption = "Refresh";
			this.btnRefreshCost.Id = 40;
			this.btnRefreshCost.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefreshCost.ImageOptions.SvgImage")));
			this.btnRefreshCost.Name = "btnRefreshCost";
			this.btnRefreshCost.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshCost_ItemClick);
			// 
			// btnDeleteCost
			// 
			this.btnDeleteCost.Caption = "Delete";
			this.btnDeleteCost.Enabled = false;
			this.btnDeleteCost.Id = 41;
			this.btnDeleteCost.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteCost.ImageOptions.SvgImage")));
			this.btnDeleteCost.Name = "btnDeleteCost";
			this.btnDeleteCost.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteCost_ItemClick);
			// 
			// btnPrintCost
			// 
			this.btnPrintCost.Caption = "Print Costsheet";
			this.btnPrintCost.Enabled = false;
			this.btnPrintCost.Id = 42;
			this.btnPrintCost.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintCost.ImageOptions.SvgImage")));
			this.btnPrintCost.Name = "btnPrintCost";
			this.btnPrintCost.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintCost_ItemClick);
			// 
			// btnCostProtected
			// 
			this.btnCostProtected.Caption = "Costsheet Protected";
			this.btnCostProtected.Enabled = false;
			this.btnCostProtected.Id = 43;
			this.btnCostProtected.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCostProtected.ImageOptions.SvgImage")));
			this.btnCostProtected.Name = "btnCostProtected";
			this.btnCostProtected.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCostProtected_ItemClick);
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
            this.ribbonPageGroup9,
            this.rpgSecurity});
			this.rpMain.Name = "rpMain";
			this.rpMain.Text = "SEA IMPORT EDIT";
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
			// rpgSecurity
			// 
			this.rpgSecurity.ItemLinks.Add(this.btnProtected);
			this.rpgSecurity.Name = "rpgSecurity";
			this.rpgSecurity.Text = "Security";
			// 
			// rpInvoice
			// 
			this.rpInvoice.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup10,
            this.ribbonPageGroup11,
            this.ribbonPageGroup12,
            this.ribbonPageGroup13,
            this.ribbonPageGroup14,
            this.ribbonPageGroup15});
			this.rpInvoice.Name = "rpInvoice";
			this.rpInvoice.Text = "Invoices";
			this.rpInvoice.Visible = false;
			// 
			// ribbonPageGroup6
			// 
			this.ribbonPageGroup6.ItemLinks.Add(this.btnNewInvoice);
			this.ribbonPageGroup6.Name = "ribbonPageGroup6";
			this.ribbonPageGroup6.Text = "New";
			// 
			// ribbonPageGroup10
			// 
			this.ribbonPageGroup10.ItemLinks.Add(this.btnSaveInvoice);
			this.ribbonPageGroup10.ItemLinks.Add(this.btnSaveAndCloseInvoice);
			this.ribbonPageGroup10.Name = "ribbonPageGroup10";
			this.ribbonPageGroup10.Text = "Save";
			// 
			// ribbonPageGroup11
			// 
			this.ribbonPageGroup11.ItemLinks.Add(this.btnRefreshInvoice);
			this.ribbonPageGroup11.Name = "ribbonPageGroup11";
			this.ribbonPageGroup11.Text = "Edit";
			// 
			// ribbonPageGroup12
			// 
			this.ribbonPageGroup12.ItemLinks.Add(this.btnDeleteInvoice);
			this.ribbonPageGroup12.Name = "ribbonPageGroup12";
			this.ribbonPageGroup12.Text = "Delete";
			// 
			// ribbonPageGroup13
			// 
			this.ribbonPageGroup13.ItemLinks.Add(this.btnPrintInvoice);
			this.ribbonPageGroup13.ItemLinks.Add(this.btnPrintOriginalInvoice, true);
			this.ribbonPageGroup13.Name = "ribbonPageGroup13";
			this.ribbonPageGroup13.Text = "Quick Print Invoice";
			// 
			// ribbonPageGroup14
			// 
			this.ribbonPageGroup14.ItemLinks.Add(this.btnInvoiceProtected);
			this.ribbonPageGroup14.Name = "ribbonPageGroup14";
			this.ribbonPageGroup14.Text = "Security";
			// 
			// ribbonPageGroup15
			// 
			this.ribbonPageGroup15.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
			this.ribbonPageGroup15.AllowTextClipping = false;
			this.ribbonPageGroup15.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup15.ItemLinks.Add(this.btnCloseInvoice);
			this.ribbonPageGroup15.Name = "ribbonPageGroup15";
			this.ribbonPageGroup15.Text = "Close";
			// 
			// rpCost
			// 
			this.rpCost.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup16,
            this.ribbonPageGroup17,
            this.ribbonPageGroup18,
            this.ribbonPageGroup19,
            this.ribbonPageGroup20,
            this.ribbonPageGroup21});
			this.rpCost.Name = "rpCost";
			this.rpCost.Text = "Costs";
			this.rpCost.Visible = false;
			// 
			// ribbonPageGroup5
			// 
			this.ribbonPageGroup5.ItemLinks.Add(this.btnNewCost);
			this.ribbonPageGroup5.Name = "ribbonPageGroup5";
			this.ribbonPageGroup5.Text = "Cost Events";
			// 
			// ribbonPageGroup16
			// 
			this.ribbonPageGroup16.ItemLinks.Add(this.btnSaveCost);
			this.ribbonPageGroup16.ItemLinks.Add(this.btnSaveAndCloseCost);
			this.ribbonPageGroup16.Name = "ribbonPageGroup16";
			this.ribbonPageGroup16.Text = "Save";
			// 
			// ribbonPageGroup17
			// 
			this.ribbonPageGroup17.ItemLinks.Add(this.btnRefreshCost);
			this.ribbonPageGroup17.Name = "ribbonPageGroup17";
			this.ribbonPageGroup17.Text = "Edit";
			// 
			// ribbonPageGroup18
			// 
			this.ribbonPageGroup18.ItemLinks.Add(this.btnDeleteCost);
			this.ribbonPageGroup18.Name = "ribbonPageGroup18";
			this.ribbonPageGroup18.Text = "Delete";
			// 
			// ribbonPageGroup19
			// 
			this.ribbonPageGroup19.ItemLinks.Add(this.btnPrintCost);
			this.ribbonPageGroup19.Name = "ribbonPageGroup19";
			this.ribbonPageGroup19.Text = "Quick Reports";
			// 
			// ribbonPageGroup20
			// 
			this.ribbonPageGroup20.ItemLinks.Add(this.btnCostProtected);
			this.ribbonPageGroup20.Name = "ribbonPageGroup20";
			this.ribbonPageGroup20.Text = "Security";
			// 
			// ribbonPageGroup21
			// 
			this.ribbonPageGroup21.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
			this.ribbonPageGroup21.AllowTextClipping = false;
			this.ribbonPageGroup21.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup21.ItemLinks.Add(this.btnCloseCost);
			this.ribbonPageGroup21.Name = "ribbonPageGroup21";
			this.ribbonPageGroup21.Text = "Close";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 919);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcMain;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1448, 30);
			// 
			// bsJobSeaImportDetails
			// 
			this.bsJobSeaImportDetails.DataSource = typeof(MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs.JobSeaImportDetailModel);
			// 
			// xtraTabPage1
			// 
			this.xtraTabPage1.Name = "xtraTabPage1";
			this.xtraTabPage1.Size = new System.Drawing.Size(98, 94);
			// 
			// xtraTabPage2
			// 
			this.xtraTabPage2.Name = "xtraTabPage2";
			this.xtraTabPage2.Size = new System.Drawing.Size(98, 80);
			// 
			// bsCosts
			// 
			this.bsCosts.DataSource = typeof(MISLiveMed.Models.Models.Accounting.CostSheets.CostModel);
			// 
			// bsInvoices
			// 
			this.bsInvoices.DataSource = typeof(MISLiveMed.Models.Models.Accounting.Invoices.InvoiceModel);
			// 
			// bsDocuments
			// 
			this.bsDocuments.DataSource = typeof(MISLiveMed.Models.Models.Common.Documents.DocumentModel);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.tabGroupNotes);
			this.mainLayout.Controls.Add(this.txtProfitLL);
			this.mainLayout.Controls.Add(this.txtProfitUSD);
			this.mainLayout.Controls.Add(this.txtTotalInvoicesUSD);
			this.mainLayout.Controls.Add(this.txtTotalInvoicesLL);
			this.mainLayout.Controls.Add(this.txtTotalCostsUSD);
			this.mainLayout.Controls.Add(this.txtTotalCostsLL);
			this.mainLayout.Controls.Add(this.grpJobInformation);
			this.mainLayout.Controls.Add(this.tabDetails);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1448, 726);
			this.mainLayout.TabIndex = 2;
			this.mainLayout.Text = "dataLayoutControl1";
			// 
			// tabGroupNotes
			// 
			this.tabGroupNotes.Location = new System.Drawing.Point(832, 232);
			this.tabGroupNotes.Name = "tabGroupNotes";
			this.tabGroupNotes.SelectedTabPage = this.tabStatus;
			this.tabGroupNotes.Size = new System.Drawing.Size(602, 184);
			this.tabGroupNotes.TabIndex = 24;
			this.tabGroupNotes.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabStatus,
            this.tabBlStatus,
            this.tabNotes});
			// 
			// tabStatus
			// 
			this.tabStatus.Controls.Add(this.layoutStatus);
			this.tabStatus.Name = "tabStatus";
			this.tabStatus.Size = new System.Drawing.Size(600, 154);
			this.tabStatus.Text = "Status";
			// 
			// layoutStatus
			// 
			this.layoutStatus.Controls.Add(this.txtStatus);
			this.layoutStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutStatus.Location = new System.Drawing.Point(0, 0);
			this.layoutStatus.Name = "layoutStatus";
			this.layoutStatus.Root = this.layoutControlGroup10;
			this.layoutStatus.Size = new System.Drawing.Size(600, 154);
			this.layoutStatus.TabIndex = 0;
			this.layoutStatus.Text = "layoutControl1";
			// 
			// txtStatus
			// 
			this.txtStatus.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "Status", true));
			this.txtStatus.Location = new System.Drawing.Point(14, 14);
			this.txtStatus.MenuManager = this.rcMain;
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(572, 126);
			this.txtStatus.StyleController = this.layoutStatus;
			this.txtStatus.TabIndex = 5;
			// 
			// layoutControlGroup10
			// 
			this.layoutControlGroup10.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup10.GroupBordersVisible = false;
			this.layoutControlGroup10.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
			this.layoutControlGroup10.Name = "layoutControlGroup10";
			this.layoutControlGroup10.Size = new System.Drawing.Size(600, 154);
			this.layoutControlGroup10.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtStatus;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(576, 130);
			this.layoutControlItem2.TextVisible = false;
			// 
			// tabBlStatus
			// 
			this.tabBlStatus.Controls.Add(this.layoutBlStatus);
			this.tabBlStatus.Name = "tabBlStatus";
			this.tabBlStatus.Size = new System.Drawing.Size(602, 155);
			this.tabBlStatus.Text = "BL/Status";
			// 
			// layoutBlStatus
			// 
			this.layoutBlStatus.Controls.Add(this.txtBlStatus);
			this.layoutBlStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutBlStatus.Location = new System.Drawing.Point(0, 0);
			this.layoutBlStatus.Name = "layoutBlStatus";
			this.layoutBlStatus.Root = this.layoutControlGroup13;
			this.layoutBlStatus.Size = new System.Drawing.Size(602, 155);
			this.layoutBlStatus.TabIndex = 0;
			this.layoutBlStatus.Text = "layoutControl1";
			// 
			// txtBlStatus
			// 
			this.txtBlStatus.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "Blstatus", true));
			this.txtBlStatus.Location = new System.Drawing.Point(14, 14);
			this.txtBlStatus.MenuManager = this.rcMain;
			this.txtBlStatus.Name = "txtBlStatus";
			this.txtBlStatus.Size = new System.Drawing.Size(574, 127);
			this.txtBlStatus.StyleController = this.layoutBlStatus;
			this.txtBlStatus.TabIndex = 5;
			// 
			// layoutControlGroup13
			// 
			this.layoutControlGroup13.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup13.GroupBordersVisible = false;
			this.layoutControlGroup13.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
			this.layoutControlGroup13.Name = "layoutControlGroup13";
			this.layoutControlGroup13.Size = new System.Drawing.Size(602, 155);
			this.layoutControlGroup13.TextVisible = false;
			// 
			// layoutControlItem9
			// 
			this.layoutControlItem9.Control = this.txtBlStatus;
			this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Size = new System.Drawing.Size(578, 131);
			this.layoutControlItem9.TextVisible = false;
			// 
			// tabNotes
			// 
			this.tabNotes.Controls.Add(this.layoutNotes);
			this.tabNotes.Name = "tabNotes";
			this.tabNotes.Size = new System.Drawing.Size(602, 155);
			this.tabNotes.Text = "Notes";
			// 
			// layoutNotes
			// 
			this.layoutNotes.Controls.Add(this.txtNotes);
			this.layoutNotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutNotes.Location = new System.Drawing.Point(0, 0);
			this.layoutNotes.Name = "layoutNotes";
			this.layoutNotes.Root = this.layoutControlGroup14;
			this.layoutNotes.Size = new System.Drawing.Size(602, 155);
			this.layoutNotes.TabIndex = 0;
			this.layoutNotes.Text = "layoutControl1";
			// 
			// txtNotes
			// 
			this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "Notes", true));
			this.txtNotes.Location = new System.Drawing.Point(14, 14);
			this.txtNotes.MenuManager = this.rcMain;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(574, 127);
			this.txtNotes.StyleController = this.layoutNotes;
			this.txtNotes.TabIndex = 5;
			// 
			// layoutControlGroup14
			// 
			this.layoutControlGroup14.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup14.GroupBordersVisible = false;
			this.layoutControlGroup14.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem14});
			this.layoutControlGroup14.Name = "layoutControlGroup14";
			this.layoutControlGroup14.Size = new System.Drawing.Size(602, 155);
			this.layoutControlGroup14.TextVisible = false;
			// 
			// layoutControlItem14
			// 
			this.layoutControlItem14.Control = this.txtNotes;
			this.layoutControlItem14.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Size = new System.Drawing.Size(578, 131);
			this.layoutControlItem14.TextVisible = false;
			// 
			// txtProfitLL
			// 
			this.txtProfitLL.Location = new System.Drawing.Point(954, 178);
			this.txtProfitLL.MenuManager = this.rcMain;
			this.txtProfitLL.Name = "txtProfitLL";
			this.txtProfitLL.Properties.ReadOnly = true;
			this.txtProfitLL.Size = new System.Drawing.Size(164, 22);
			this.txtProfitLL.StyleController = this.mainLayout;
			this.txtProfitLL.TabIndex = 23;
			// 
			// txtProfitUSD
			// 
			this.txtProfitUSD.Location = new System.Drawing.Point(1244, 178);
			this.txtProfitUSD.MenuManager = this.rcMain;
			this.txtProfitUSD.Name = "txtProfitUSD";
			this.txtProfitUSD.Properties.ReadOnly = true;
			this.txtProfitUSD.Size = new System.Drawing.Size(162, 22);
			this.txtProfitUSD.StyleController = this.mainLayout;
			this.txtProfitUSD.TabIndex = 22;
			// 
			// txtTotalInvoicesUSD
			// 
			this.txtTotalInvoicesUSD.Location = new System.Drawing.Point(1244, 94);
			this.txtTotalInvoicesUSD.MenuManager = this.rcMain;
			this.txtTotalInvoicesUSD.Name = "txtTotalInvoicesUSD";
			this.txtTotalInvoicesUSD.Properties.ReadOnly = true;
			this.txtTotalInvoicesUSD.Size = new System.Drawing.Size(162, 22);
			this.txtTotalInvoicesUSD.StyleController = this.mainLayout;
			this.txtTotalInvoicesUSD.TabIndex = 20;
			// 
			// txtTotalInvoicesLL
			// 
			this.txtTotalInvoicesLL.Location = new System.Drawing.Point(954, 94);
			this.txtTotalInvoicesLL.MenuManager = this.rcMain;
			this.txtTotalInvoicesLL.Name = "txtTotalInvoicesLL";
			this.txtTotalInvoicesLL.Properties.ReadOnly = true;
			this.txtTotalInvoicesLL.Size = new System.Drawing.Size(164, 22);
			this.txtTotalInvoicesLL.StyleController = this.mainLayout;
			this.txtTotalInvoicesLL.TabIndex = 19;
			// 
			// txtTotalCostsUSD
			// 
			this.txtTotalCostsUSD.Location = new System.Drawing.Point(1244, 68);
			this.txtTotalCostsUSD.MenuManager = this.rcMain;
			this.txtTotalCostsUSD.Name = "txtTotalCostsUSD";
			this.txtTotalCostsUSD.Properties.ReadOnly = true;
			this.txtTotalCostsUSD.Size = new System.Drawing.Size(162, 22);
			this.txtTotalCostsUSD.StyleController = this.mainLayout;
			this.txtTotalCostsUSD.TabIndex = 18;
			// 
			// txtTotalCostsLL
			// 
			this.txtTotalCostsLL.Location = new System.Drawing.Point(954, 68);
			this.txtTotalCostsLL.MenuManager = this.rcMain;
			this.txtTotalCostsLL.Name = "txtTotalCostsLL";
			this.txtTotalCostsLL.Properties.ReadOnly = true;
			this.txtTotalCostsLL.Size = new System.Drawing.Size(164, 22);
			this.txtTotalCostsLL.StyleController = this.mainLayout;
			this.txtTotalCostsLL.TabIndex = 17;
			// 
			// grpJobInformation
			// 
			this.grpJobInformation.Location = new System.Drawing.Point(14, 14);
			this.grpJobInformation.Name = "grpJobInformation";
			this.grpJobInformation.SelectedTabPage = this.tabJobInformation;
			this.grpJobInformation.Size = new System.Drawing.Size(814, 402);
			this.grpJobInformation.TabIndex = 16;
			this.grpJobInformation.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabJobInformation,
            this.tabShipmentInformation,
            this.tabPackageDetails,
            this.tabUserInformation});
			// 
			// tabJobInformation
			// 
			this.tabJobInformation.Controls.Add(this.layoutClientInformation);
			this.tabJobInformation.Name = "tabJobInformation";
			this.tabJobInformation.Size = new System.Drawing.Size(812, 372);
			this.tabJobInformation.Text = "Job Information";
			// 
			// layoutClientInformation
			// 
			this.layoutClientInformation.Controls.Add(this.txtMbl);
			this.layoutClientInformation.Controls.Add(this.txtJobNo);
			this.layoutClientInformation.Controls.Add(this.txtReferenceNo);
			this.layoutClientInformation.Controls.Add(this.dtJobDate);
			this.layoutClientInformation.Controls.Add(this.cboCustomers);
			this.layoutClientInformation.Controls.Add(this.cboConsignees);
			this.layoutClientInformation.Controls.Add(this.cboJobsType);
			this.layoutClientInformation.Controls.Add(this.EtdDate);
			this.layoutClientInformation.Controls.Add(this.AtdDate);
			this.layoutClientInformation.Controls.Add(this.LoadingDate);
			this.layoutClientInformation.Controls.Add(this.AtaDate);
			this.layoutClientInformation.Controls.Add(this.EtaDate);
			this.layoutClientInformation.Controls.Add(this.CutOffDate);
			this.layoutClientInformation.Controls.Add(this.cboDeparture);
			this.layoutClientInformation.Controls.Add(this.cboDestination);
			this.layoutClientInformation.Controls.Add(this.txtCountryOfDeparture);
			this.layoutClientInformation.Controls.Add(this.txtCountryOfDestination);
			this.layoutClientInformation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutClientInformation.Location = new System.Drawing.Point(0, 0);
			this.layoutClientInformation.Name = "layoutClientInformation";
			this.layoutClientInformation.Root = this.layoutControlGroup8;
			this.layoutClientInformation.Size = new System.Drawing.Size(812, 372);
			this.layoutClientInformation.TabIndex = 0;
			this.layoutClientInformation.Text = "layoutControl1";
			// 
			// txtMbl
			// 
			this.txtMbl.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "Mbl", true));
			this.txtMbl.Location = new System.Drawing.Point(155, 118);
			this.txtMbl.MenuManager = this.rcMain;
			this.txtMbl.Name = "txtMbl";
			this.txtMbl.Size = new System.Drawing.Size(249, 22);
			this.txtMbl.StyleController = this.layoutClientInformation;
			this.txtMbl.TabIndex = 14;
			// 
			// txtJobNo
			// 
			this.txtJobNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "JobNo", true));
			this.txtJobNo.Location = new System.Drawing.Point(373, 14);
			this.txtJobNo.Name = "txtJobNo";
			this.txtJobNo.Properties.ReadOnly = true;
			this.txtJobNo.Size = new System.Drawing.Size(128, 22);
			this.txtJobNo.StyleController = this.layoutClientInformation;
			this.txtJobNo.TabIndex = 4;
			// 
			// txtReferenceNo
			// 
			this.txtReferenceNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "ReferenceNo", true));
			this.txtReferenceNo.Location = new System.Drawing.Point(155, 14);
			this.txtReferenceNo.Name = "txtReferenceNo";
			this.txtReferenceNo.Properties.ReadOnly = true;
			this.txtReferenceNo.Size = new System.Drawing.Size(171, 22);
			this.txtReferenceNo.StyleController = this.layoutClientInformation;
			this.txtReferenceNo.TabIndex = 5;
			// 
			// dtJobDate
			// 
			this.dtJobDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "JobDate", true));
			this.dtJobDate.EditValue = null;
			this.dtJobDate.Location = new System.Drawing.Point(559, 14);
			this.dtJobDate.Name = "dtJobDate";
			this.dtJobDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtJobDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtJobDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtJobDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtJobDate.Properties.DisplayFormat.FormatString = "";
			this.dtJobDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.dtJobDate.Properties.EditFormat.FormatString = "";
			this.dtJobDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.dtJobDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtJobDate.Properties.ReadOnly = true;
			this.dtJobDate.Properties.UseMaskAsDisplayFormat = true;
			this.dtJobDate.Size = new System.Drawing.Size(239, 22);
			this.dtJobDate.StyleController = this.layoutClientInformation;
			this.dtJobDate.TabIndex = 8;
			// 
			// cboCustomers
			// 
			this.cboCustomers.Location = new System.Drawing.Point(155, 40);
			this.cboCustomers.Name = "cboCustomers";
			this.cboCustomers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCustomers.Properties.DisplayMember = "CustomerName";
			this.cboCustomers.Properties.NullText = "";
			this.cboCustomers.Properties.PopupView = this.searchLookUpEdit1View;
			this.cboCustomers.Properties.ShowAddNewButton = true;
			this.cboCustomers.Properties.ValueMember = "Id";
			this.cboCustomers.Size = new System.Drawing.Size(643, 22);
			this.cboCustomers.StyleController = this.layoutClientInformation;
			this.cboCustomers.TabIndex = 9;
			// 
			// searchLookUpEdit1View
			// 
			this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcId,
            this.gcName});
			this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
			this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// gcId
			// 
			this.gcId.Caption = "Id";
			this.gcId.FieldName = "Id";
			this.gcId.Name = "gcId";
			this.gcId.Visible = true;
			this.gcId.VisibleIndex = 0;
			this.gcId.Width = 100;
			// 
			// gcName
			// 
			this.gcName.Caption = "Customer Name";
			this.gcName.FieldName = "CustomerName";
			this.gcName.Name = "gcName";
			this.gcName.Visible = true;
			this.gcName.VisibleIndex = 1;
			this.gcName.Width = 936;
			// 
			// cboConsignees
			// 
			this.cboConsignees.Location = new System.Drawing.Point(155, 66);
			this.cboConsignees.Name = "cboConsignees";
			this.cboConsignees.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboConsignees.Properties.DisplayMember = "CustomerName";
			this.cboConsignees.Properties.NullText = "";
			this.cboConsignees.Properties.PopupView = this.gridView11;
			this.cboConsignees.Properties.ShowAddNewButton = true;
			this.cboConsignees.Properties.ValueMember = "Id";
			this.cboConsignees.Size = new System.Drawing.Size(643, 22);
			this.cboConsignees.StyleController = this.layoutClientInformation;
			this.cboConsignees.TabIndex = 12;
			// 
			// gridView11
			// 
			this.gridView11.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcConsigneeId,
            this.gcConsigneeName});
			this.gridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView11.Name = "gridView11";
			this.gridView11.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView11.OptionsView.ShowGroupPanel = false;
			// 
			// gcConsigneeId
			// 
			this.gcConsigneeId.Caption = "Id";
			this.gcConsigneeId.FieldName = "Id";
			this.gcConsigneeId.Name = "gcConsigneeId";
			this.gcConsigneeId.Visible = true;
			this.gcConsigneeId.VisibleIndex = 0;
			this.gcConsigneeId.Width = 107;
			// 
			// gcConsigneeName
			// 
			this.gcConsigneeName.Caption = "Consignee Name";
			this.gcConsigneeName.FieldName = "CustomerName";
			this.gcConsigneeName.Name = "gcConsigneeName";
			this.gcConsigneeName.Visible = true;
			this.gcConsigneeName.VisibleIndex = 1;
			this.gcConsigneeName.Width = 929;
			// 
			// cboJobsType
			// 
			this.cboJobsType.Location = new System.Drawing.Point(155, 92);
			this.cboJobsType.Name = "cboJobsType";
			this.cboJobsType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboJobsType.Properties.DisplayMember = "Description";
			this.cboJobsType.Properties.NullText = "";
			this.cboJobsType.Properties.PopupView = this.gridView2;
			this.cboJobsType.Properties.ShowAddNewButton = true;
			this.cboJobsType.Properties.ValueMember = "Id";
			this.cboJobsType.Size = new System.Drawing.Size(249, 22);
			this.cboJobsType.StyleController = this.layoutClientInformation;
			this.cboJobsType.TabIndex = 10;
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTypeId,
            this.colTypeDescription});
			this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView2.OptionsView.ShowGroupPanel = false;
			// 
			// colTypeId
			// 
			this.colTypeId.Caption = "Id";
			this.colTypeId.FieldName = "Id";
			this.colTypeId.Name = "colTypeId";
			this.colTypeId.Visible = true;
			this.colTypeId.VisibleIndex = 0;
			this.colTypeId.Width = 72;
			// 
			// colTypeDescription
			// 
			this.colTypeDescription.Caption = "Description";
			this.colTypeDescription.FieldName = "Description";
			this.colTypeDescription.Name = "colTypeDescription";
			this.colTypeDescription.Visible = true;
			this.colTypeDescription.VisibleIndex = 1;
			this.colTypeDescription.Width = 964;
			// 
			// EtdDate
			// 
			this.EtdDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "Etd", true));
			this.EtdDate.EditValue = null;
			this.EtdDate.Location = new System.Drawing.Point(155, 155);
			this.EtdDate.Name = "EtdDate";
			this.EtdDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.EtdDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.EtdDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.EtdDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.EtdDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.EtdDate.Properties.UseMaskAsDisplayFormat = true;
			this.EtdDate.Size = new System.Drawing.Size(248, 22);
			this.EtdDate.StyleController = this.layoutClientInformation;
			this.EtdDate.TabIndex = 4;
			// 
			// AtdDate
			// 
			this.AtdDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "Atd", true));
			this.AtdDate.EditValue = null;
			this.AtdDate.Location = new System.Drawing.Point(155, 181);
			this.AtdDate.Name = "AtdDate";
			this.AtdDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.AtdDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.AtdDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.AtdDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.AtdDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.AtdDate.Properties.UseMaskAsDisplayFormat = true;
			this.AtdDate.Size = new System.Drawing.Size(248, 22);
			this.AtdDate.StyleController = this.layoutClientInformation;
			this.AtdDate.TabIndex = 6;
			// 
			// LoadingDate
			// 
			this.LoadingDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "LoadingDate", true));
			this.LoadingDate.EditValue = null;
			this.LoadingDate.Location = new System.Drawing.Point(155, 207);
			this.LoadingDate.Name = "LoadingDate";
			this.LoadingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.LoadingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.LoadingDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.LoadingDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.LoadingDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.LoadingDate.Properties.UseMaskAsDisplayFormat = true;
			this.LoadingDate.Size = new System.Drawing.Size(248, 22);
			this.LoadingDate.StyleController = this.layoutClientInformation;
			this.LoadingDate.TabIndex = 8;
			// 
			// AtaDate
			// 
			this.AtaDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "Ata", true));
			this.AtaDate.EditValue = null;
			this.AtaDate.Location = new System.Drawing.Point(548, 181);
			this.AtaDate.Name = "AtaDate";
			this.AtaDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.AtaDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.AtaDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.AtaDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.AtaDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.AtaDate.Properties.UseMaskAsDisplayFormat = true;
			this.AtaDate.Size = new System.Drawing.Size(250, 22);
			this.AtaDate.StyleController = this.layoutClientInformation;
			this.AtaDate.TabIndex = 7;
			// 
			// EtaDate
			// 
			this.EtaDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "Eta", true));
			this.EtaDate.EditValue = null;
			this.EtaDate.Location = new System.Drawing.Point(548, 155);
			this.EtaDate.Name = "EtaDate";
			this.EtaDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.EtaDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.EtaDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.EtaDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.EtaDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.EtaDate.Properties.UseMaskAsDisplayFormat = true;
			this.EtaDate.Size = new System.Drawing.Size(250, 22);
			this.EtaDate.StyleController = this.layoutClientInformation;
			this.EtaDate.TabIndex = 5;
			// 
			// CutOffDate
			// 
			this.CutOffDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "CutOffDate", true));
			this.CutOffDate.EditValue = null;
			this.CutOffDate.Location = new System.Drawing.Point(548, 207);
			this.CutOffDate.Name = "CutOffDate";
			this.CutOffDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.CutOffDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.CutOffDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.CutOffDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.CutOffDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.CutOffDate.Properties.UseMaskAsDisplayFormat = true;
			this.CutOffDate.Size = new System.Drawing.Size(250, 22);
			this.CutOffDate.StyleController = this.layoutClientInformation;
			this.CutOffDate.TabIndex = 9;
			// 
			// cboDeparture
			// 
			this.cboDeparture.Location = new System.Drawing.Point(155, 252);
			this.cboDeparture.Name = "cboDeparture";
			this.cboDeparture.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboDeparture.Properties.DisplayMember = "Name";
			this.cboDeparture.Properties.NullText = "";
			this.cboDeparture.Properties.PopupView = this.gridView14;
			this.cboDeparture.Properties.ShowAddNewButton = true;
			this.cboDeparture.Properties.ValueMember = "Id";
			this.cboDeparture.Size = new System.Drawing.Size(248, 22);
			this.cboDeparture.StyleController = this.layoutClientInformation;
			this.cboDeparture.TabIndex = 10;
			// 
			// gridView14
			// 
			this.gridView14.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSeaportDepartureId,
            this.colSeaportDepartureName});
			this.gridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView14.Name = "gridView14";
			this.gridView14.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView14.OptionsView.ShowGroupPanel = false;
			// 
			// colSeaportDepartureId
			// 
			this.colSeaportDepartureId.Caption = "Id";
			this.colSeaportDepartureId.FieldName = "Id";
			this.colSeaportDepartureId.Name = "colSeaportDepartureId";
			this.colSeaportDepartureId.Visible = true;
			this.colSeaportDepartureId.VisibleIndex = 0;
			this.colSeaportDepartureId.Width = 72;
			// 
			// colSeaportDepartureName
			// 
			this.colSeaportDepartureName.Caption = "Name";
			this.colSeaportDepartureName.FieldName = "Name";
			this.colSeaportDepartureName.Name = "colSeaportDepartureName";
			this.colSeaportDepartureName.Visible = true;
			this.colSeaportDepartureName.VisibleIndex = 1;
			this.colSeaportDepartureName.Width = 964;
			// 
			// cboDestination
			// 
			this.cboDestination.Location = new System.Drawing.Point(155, 278);
			this.cboDestination.Name = "cboDestination";
			this.cboDestination.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboDestination.Properties.DisplayMember = "Name";
			this.cboDestination.Properties.NullText = "";
			this.cboDestination.Properties.PopupView = this.searchLookUpEdit2View;
			this.cboDestination.Properties.ShowAddNewButton = true;
			this.cboDestination.Properties.ValueMember = "Id";
			this.cboDestination.Size = new System.Drawing.Size(248, 22);
			this.cboDestination.StyleController = this.layoutClientInformation;
			this.cboDestination.TabIndex = 11;
			// 
			// searchLookUpEdit2View
			// 
			this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcboDestinationId,
            this.colcboDestinationName});
			this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
			this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
			// 
			// colcboDestinationId
			// 
			this.colcboDestinationId.Caption = "Id";
			this.colcboDestinationId.FieldName = "Id";
			this.colcboDestinationId.Name = "colcboDestinationId";
			this.colcboDestinationId.Visible = true;
			this.colcboDestinationId.VisibleIndex = 0;
			this.colcboDestinationId.Width = 77;
			// 
			// colcboDestinationName
			// 
			this.colcboDestinationName.Caption = "Name";
			this.colcboDestinationName.FieldName = "Name";
			this.colcboDestinationName.Name = "colcboDestinationName";
			this.colcboDestinationName.Visible = true;
			this.colcboDestinationName.VisibleIndex = 1;
			this.colcboDestinationName.Width = 959;
			// 
			// txtCountryOfDeparture
			// 
			this.txtCountryOfDeparture.Location = new System.Drawing.Point(548, 252);
			this.txtCountryOfDeparture.Name = "txtCountryOfDeparture";
			this.txtCountryOfDeparture.Properties.ReadOnly = true;
			this.txtCountryOfDeparture.Size = new System.Drawing.Size(250, 22);
			this.txtCountryOfDeparture.StyleController = this.layoutClientInformation;
			this.txtCountryOfDeparture.TabIndex = 12;
			// 
			// txtCountryOfDestination
			// 
			this.txtCountryOfDestination.Location = new System.Drawing.Point(548, 278);
			this.txtCountryOfDestination.Name = "txtCountryOfDestination";
			this.txtCountryOfDestination.Properties.ReadOnly = true;
			this.txtCountryOfDestination.Size = new System.Drawing.Size(250, 22);
			this.txtCountryOfDestination.StyleController = this.layoutClientInformation;
			this.txtCountryOfDestination.TabIndex = 13;
			// 
			// layoutControlGroup8
			// 
			this.layoutControlGroup8.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup8.GroupBordersVisible = false;
			this.layoutControlGroup8.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblJobNo,
            this.lblReferenceNo,
            this.lblJobDate,
            this.lblCustomerName,
            this.lblConsigneeName,
            this.lblJobType,
            this.emptySpaceItem4,
            this.lblEtd,
            this.lblAtd,
            this.lblLoadingDate,
            this.lblAta,
            this.lblEta,
            this.lblCutOffDate,
            this.emptySpaceItem9,
            this.lblDeparture,
            this.lblDestination,
            this.lblCountryOfDeparture,
            this.lblCountryOfDestination,
            this.emptySpaceItem11,
            this.lblMbl,
            this.emptySpaceItem10,
            this.emptySpaceItem24});
			this.layoutControlGroup8.Name = "Root";
			this.layoutControlGroup8.Size = new System.Drawing.Size(812, 372);
			this.layoutControlGroup8.TextVisible = false;
			// 
			// lblJobNo
			// 
			this.lblJobNo.Control = this.txtJobNo;
			this.lblJobNo.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblJobNo.CustomizationFormText = "Job No";
			this.lblJobNo.Location = new System.Drawing.Point(316, 0);
			this.lblJobNo.Name = "lblJobNo";
			this.lblJobNo.Size = new System.Drawing.Size(175, 26);
			this.lblJobNo.Text = "Job No";
			this.lblJobNo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblJobNo.TextSize = new System.Drawing.Size(38, 16);
			this.lblJobNo.TextToControlDistance = 5;
			// 
			// lblReferenceNo
			// 
			this.lblReferenceNo.Control = this.txtReferenceNo;
			this.lblReferenceNo.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblReferenceNo.CustomizationFormText = "Reference No";
			this.lblReferenceNo.Location = new System.Drawing.Point(0, 0);
			this.lblReferenceNo.Name = "lblReferenceNo";
			this.lblReferenceNo.Size = new System.Drawing.Size(316, 26);
			this.lblReferenceNo.Text = "Reference No";
			this.lblReferenceNo.TextSize = new System.Drawing.Size(126, 16);
			// 
			// lblJobDate
			// 
			this.lblJobDate.Control = this.dtJobDate;
			this.lblJobDate.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblJobDate.CustomizationFormText = "Job Date";
			this.lblJobDate.Location = new System.Drawing.Point(491, 0);
			this.lblJobDate.Name = "lblJobDate";
			this.lblJobDate.Size = new System.Drawing.Size(297, 26);
			this.lblJobDate.Text = "Job Date";
			this.lblJobDate.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblJobDate.TextSize = new System.Drawing.Size(49, 16);
			this.lblJobDate.TextToControlDistance = 5;
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.Control = this.cboCustomers;
			this.lblCustomerName.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblCustomerName.CustomizationFormText = "Customer Name";
			this.lblCustomerName.Location = new System.Drawing.Point(0, 26);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(788, 26);
			this.lblCustomerName.Text = "Customer Name";
			this.lblCustomerName.TextSize = new System.Drawing.Size(126, 16);
			// 
			// lblConsigneeName
			// 
			this.lblConsigneeName.Control = this.cboConsignees;
			this.lblConsigneeName.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblConsigneeName.CustomizationFormText = "Consignee Name";
			this.lblConsigneeName.Location = new System.Drawing.Point(0, 52);
			this.lblConsigneeName.Name = "lblConsigneeName";
			this.lblConsigneeName.Size = new System.Drawing.Size(788, 26);
			this.lblConsigneeName.Text = "Consignee Name";
			this.lblConsigneeName.TextSize = new System.Drawing.Size(126, 16);
			// 
			// lblJobType
			// 
			this.lblJobType.Control = this.cboJobsType;
			this.lblJobType.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblJobType.CustomizationFormText = "Job Type";
			this.lblJobType.Location = new System.Drawing.Point(0, 78);
			this.lblJobType.Name = "lblJobType";
			this.lblJobType.Size = new System.Drawing.Size(394, 26);
			this.lblJobType.Text = "Job Type";
			this.lblJobType.TextSize = new System.Drawing.Size(126, 16);
			// 
			// emptySpaceItem4
			// 
			this.emptySpaceItem4.Location = new System.Drawing.Point(0, 130);
			this.emptySpaceItem4.Name = "emptySpaceItem4";
			this.emptySpaceItem4.Size = new System.Drawing.Size(788, 11);
			// 
			// lblEtd
			// 
			this.lblEtd.Control = this.EtdDate;
			this.lblEtd.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblEtd.CustomizationFormText = "ETD";
			this.lblEtd.Location = new System.Drawing.Point(0, 141);
			this.lblEtd.Name = "lblEtd";
			this.lblEtd.Size = new System.Drawing.Size(393, 26);
			this.lblEtd.Text = "ETD";
			this.lblEtd.TextSize = new System.Drawing.Size(126, 16);
			// 
			// lblAtd
			// 
			this.lblAtd.Control = this.AtdDate;
			this.lblAtd.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblAtd.CustomizationFormText = "ATD";
			this.lblAtd.Location = new System.Drawing.Point(0, 167);
			this.lblAtd.Name = "lblAtd";
			this.lblAtd.Size = new System.Drawing.Size(393, 26);
			this.lblAtd.Text = "ATD";
			this.lblAtd.TextSize = new System.Drawing.Size(126, 16);
			// 
			// lblLoadingDate
			// 
			this.lblLoadingDate.Control = this.LoadingDate;
			this.lblLoadingDate.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblLoadingDate.CustomizationFormText = "Loading Date";
			this.lblLoadingDate.Location = new System.Drawing.Point(0, 193);
			this.lblLoadingDate.Name = "lblLoadingDate";
			this.lblLoadingDate.Size = new System.Drawing.Size(393, 26);
			this.lblLoadingDate.Text = "Loading Date";
			this.lblLoadingDate.TextSize = new System.Drawing.Size(126, 16);
			// 
			// lblAta
			// 
			this.lblAta.Control = this.AtaDate;
			this.lblAta.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblAta.CustomizationFormText = "ATA";
			this.lblAta.Location = new System.Drawing.Point(393, 167);
			this.lblAta.Name = "lblAta";
			this.lblAta.Size = new System.Drawing.Size(395, 26);
			this.lblAta.Text = "ATA";
			this.lblAta.TextSize = new System.Drawing.Size(126, 16);
			// 
			// lblEta
			// 
			this.lblEta.Control = this.EtaDate;
			this.lblEta.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblEta.CustomizationFormText = "ETA";
			this.lblEta.Location = new System.Drawing.Point(393, 141);
			this.lblEta.Name = "lblEta";
			this.lblEta.Size = new System.Drawing.Size(395, 26);
			this.lblEta.Text = "ETA";
			this.lblEta.TextSize = new System.Drawing.Size(126, 16);
			// 
			// lblCutOffDate
			// 
			this.lblCutOffDate.Control = this.CutOffDate;
			this.lblCutOffDate.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblCutOffDate.CustomizationFormText = "Cut-off-Date";
			this.lblCutOffDate.Location = new System.Drawing.Point(393, 193);
			this.lblCutOffDate.Name = "lblCutOffDate";
			this.lblCutOffDate.Size = new System.Drawing.Size(395, 26);
			this.lblCutOffDate.Text = "Cut-off-Date";
			this.lblCutOffDate.TextSize = new System.Drawing.Size(126, 16);
			// 
			// emptySpaceItem9
			// 
			this.emptySpaceItem9.Location = new System.Drawing.Point(0, 219);
			this.emptySpaceItem9.Name = "emptySpaceItem9";
			this.emptySpaceItem9.Size = new System.Drawing.Size(788, 19);
			// 
			// lblDeparture
			// 
			this.lblDeparture.Control = this.cboDeparture;
			this.lblDeparture.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblDeparture.CustomizationFormText = "Departure";
			this.lblDeparture.Location = new System.Drawing.Point(0, 238);
			this.lblDeparture.Name = "lblDeparture";
			this.lblDeparture.Size = new System.Drawing.Size(393, 26);
			this.lblDeparture.Text = "Departure";
			this.lblDeparture.TextSize = new System.Drawing.Size(126, 16);
			// 
			// lblDestination
			// 
			this.lblDestination.Control = this.cboDestination;
			this.lblDestination.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblDestination.CustomizationFormText = "Destination";
			this.lblDestination.Location = new System.Drawing.Point(0, 264);
			this.lblDestination.Name = "lblDestination";
			this.lblDestination.Size = new System.Drawing.Size(393, 26);
			this.lblDestination.Text = "Destination";
			this.lblDestination.TextSize = new System.Drawing.Size(126, 16);
			// 
			// lblCountryOfDeparture
			// 
			this.lblCountryOfDeparture.Control = this.txtCountryOfDeparture;
			this.lblCountryOfDeparture.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblCountryOfDeparture.CustomizationFormText = "Country of Departure";
			this.lblCountryOfDeparture.Location = new System.Drawing.Point(393, 238);
			this.lblCountryOfDeparture.Name = "lblCountryOfDeparture";
			this.lblCountryOfDeparture.Size = new System.Drawing.Size(395, 26);
			this.lblCountryOfDeparture.Text = "Country of Departure";
			this.lblCountryOfDeparture.TextSize = new System.Drawing.Size(126, 16);
			// 
			// lblCountryOfDestination
			// 
			this.lblCountryOfDestination.Control = this.txtCountryOfDestination;
			this.lblCountryOfDestination.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblCountryOfDestination.CustomizationFormText = "Country of Destination";
			this.lblCountryOfDestination.Location = new System.Drawing.Point(393, 264);
			this.lblCountryOfDestination.Name = "lblCountryOfDestination";
			this.lblCountryOfDestination.Size = new System.Drawing.Size(395, 26);
			this.lblCountryOfDestination.Text = "Country of Destination";
			this.lblCountryOfDestination.TextSize = new System.Drawing.Size(126, 16);
			// 
			// emptySpaceItem11
			// 
			this.emptySpaceItem11.Location = new System.Drawing.Point(0, 290);
			this.emptySpaceItem11.Name = "emptySpaceItem11";
			this.emptySpaceItem11.Size = new System.Drawing.Size(788, 58);
			// 
			// lblMbl
			// 
			this.lblMbl.Control = this.txtMbl;
			this.lblMbl.Location = new System.Drawing.Point(0, 104);
			this.lblMbl.Name = "lblMbl";
			this.lblMbl.Size = new System.Drawing.Size(394, 26);
			this.lblMbl.Text = "MBL#";
			this.lblMbl.TextSize = new System.Drawing.Size(126, 16);
			// 
			// emptySpaceItem10
			// 
			this.emptySpaceItem10.Location = new System.Drawing.Point(394, 104);
			this.emptySpaceItem10.Name = "emptySpaceItem10";
			this.emptySpaceItem10.Size = new System.Drawing.Size(394, 26);
			// 
			// emptySpaceItem24
			// 
			this.emptySpaceItem24.Location = new System.Drawing.Point(394, 78);
			this.emptySpaceItem24.Name = "emptySpaceItem24";
			this.emptySpaceItem24.Size = new System.Drawing.Size(394, 26);
			// 
			// tabShipmentInformation
			// 
			this.tabShipmentInformation.Controls.Add(this.layoutShipmentTracking);
			this.tabShipmentInformation.Name = "tabShipmentInformation";
			this.tabShipmentInformation.Size = new System.Drawing.Size(812, 372);
			this.tabShipmentInformation.Text = "Shipment Information";
			// 
			// layoutShipmentTracking
			// 
			this.layoutShipmentTracking.Controls.Add(this.cboShippedWith);
			this.layoutShipmentTracking.Controls.Add(this.dtConfirmEmptyContainer);
			this.layoutShipmentTracking.Controls.Add(this.dtEmptyContainer);
			this.layoutShipmentTracking.Controls.Add(this.dtContainerToCnee);
			this.layoutShipmentTracking.Controls.Add(this.chkEmptyContainer);
			this.layoutShipmentTracking.Controls.Add(this.chkConfirmEmptyContainer);
			this.layoutShipmentTracking.Controls.Add(this.chkContainerToCnee);
			this.layoutShipmentTracking.Controls.Add(this.txtBookingNo);
			this.layoutShipmentTracking.Controls.Add(this.dtMissingDocumentsDate);
			this.layoutShipmentTracking.Controls.Add(this.dtPaidDoDate);
			this.layoutShipmentTracking.Controls.Add(this.dtTejrimDate);
			this.layoutShipmentTracking.Controls.Add(this.dateEdit10);
			this.layoutShipmentTracking.Controls.Add(this.dtPendingForDelivery);
			this.layoutShipmentTracking.Controls.Add(this.dtReadyForClearance);
			this.layoutShipmentTracking.Controls.Add(this.dtReadyForTejrim);
			this.layoutShipmentTracking.Controls.Add(this.chkDeliveryDate);
			this.layoutShipmentTracking.Controls.Add(this.chkMissingDocuments);
			this.layoutShipmentTracking.Controls.Add(this.chkPendingForDelivery);
			this.layoutShipmentTracking.Controls.Add(this.chkPaidDo);
			this.layoutShipmentTracking.Controls.Add(this.chkReadyForClearance);
			this.layoutShipmentTracking.Controls.Add(this.chkTejrim);
			this.layoutShipmentTracking.Controls.Add(this.chkRTejrim);
			this.layoutShipmentTracking.Controls.Add(this.cboAgents);
			this.layoutShipmentTracking.Controls.Add(this.cboIncoTerms);
			this.layoutShipmentTracking.Controls.Add(this.cboSeaCarriers);
			this.layoutShipmentTracking.Controls.Add(this.cboVessels);
			this.layoutShipmentTracking.Controls.Add(this.cboFeederVessels);
			this.layoutShipmentTracking.Controls.Add(this.txtFreeOfDemurage);
			this.layoutShipmentTracking.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutShipmentTracking.Location = new System.Drawing.Point(0, 0);
			this.layoutShipmentTracking.Name = "layoutShipmentTracking";
			this.layoutShipmentTracking.Root = this.layoutControlGroup9;
			this.layoutShipmentTracking.Size = new System.Drawing.Size(812, 372);
			this.layoutShipmentTracking.TabIndex = 0;
			this.layoutShipmentTracking.Text = "layoutControl1";
			// 
			// cboShippedWith
			// 
			this.cboShippedWith.Location = new System.Drawing.Point(133, 66);
			this.cboShippedWith.MenuManager = this.rcMain;
			this.cboShippedWith.Name = "cboShippedWith";
			this.cboShippedWith.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboShippedWith.Properties.DisplayMember = "Name";
			this.cboShippedWith.Properties.NullText = "";
			this.cboShippedWith.Properties.PopupView = this.gridView1;
			this.cboShippedWith.Properties.ValueMember = "Id";
			this.cboShippedWith.Size = new System.Drawing.Size(239, 22);
			this.cboShippedWith.StyleController = this.layoutShipmentTracking;
			this.cboShippedWith.TabIndex = 35;
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShippedWithId,
            this.colShippedWith});
			this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// colShippedWithId
			// 
			this.colShippedWithId.Caption = "Id";
			this.colShippedWithId.FieldName = "Id";
			this.colShippedWithId.Name = "colShippedWithId";
			this.colShippedWithId.Visible = true;
			this.colShippedWithId.VisibleIndex = 0;
			this.colShippedWithId.Width = 77;
			// 
			// colShippedWith
			// 
			this.colShippedWith.Caption = "Shipped With";
			this.colShippedWith.FieldName = "Name";
			this.colShippedWith.Name = "colShippedWith";
			this.colShippedWith.Visible = true;
			this.colShippedWith.VisibleIndex = 1;
			this.colShippedWith.Width = 959;
			// 
			// dtConfirmEmptyContainer
			// 
			this.dtConfirmEmptyContainer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "ConfirmEmptyContainerDate", true));
			this.dtConfirmEmptyContainer.EditValue = null;
			this.dtConfirmEmptyContainer.Location = new System.Drawing.Point(195, 334);
			this.dtConfirmEmptyContainer.MenuManager = this.rcMain;
			this.dtConfirmEmptyContainer.Name = "dtConfirmEmptyContainer";
			this.dtConfirmEmptyContainer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtConfirmEmptyContainer.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtConfirmEmptyContainer.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtConfirmEmptyContainer.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtConfirmEmptyContainer.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtConfirmEmptyContainer.Properties.UseMaskAsDisplayFormat = true;
			this.dtConfirmEmptyContainer.Size = new System.Drawing.Size(177, 22);
			this.dtConfirmEmptyContainer.StyleController = this.layoutShipmentTracking;
			this.dtConfirmEmptyContainer.TabIndex = 34;
			// 
			// dtEmptyContainer
			// 
			this.dtEmptyContainer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "EmptyContainerDate", true));
			this.dtEmptyContainer.EditValue = null;
			this.dtEmptyContainer.Location = new System.Drawing.Point(195, 306);
			this.dtEmptyContainer.MenuManager = this.rcMain;
			this.dtEmptyContainer.Name = "dtEmptyContainer";
			this.dtEmptyContainer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtEmptyContainer.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtEmptyContainer.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtEmptyContainer.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtEmptyContainer.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtEmptyContainer.Properties.UseMaskAsDisplayFormat = true;
			this.dtEmptyContainer.Size = new System.Drawing.Size(177, 22);
			this.dtEmptyContainer.StyleController = this.layoutShipmentTracking;
			this.dtEmptyContainer.TabIndex = 33;
			// 
			// dtContainerToCnee
			// 
			this.dtContainerToCnee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "ContainerToCneeDate", true));
			this.dtContainerToCnee.EditValue = null;
			this.dtContainerToCnee.Location = new System.Drawing.Point(195, 278);
			this.dtContainerToCnee.MenuManager = this.rcMain;
			this.dtContainerToCnee.Name = "dtContainerToCnee";
			this.dtContainerToCnee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtContainerToCnee.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtContainerToCnee.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtContainerToCnee.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtContainerToCnee.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtContainerToCnee.Properties.UseMaskAsDisplayFormat = true;
			this.dtContainerToCnee.Size = new System.Drawing.Size(177, 22);
			this.dtContainerToCnee.StyleController = this.layoutShipmentTracking;
			this.dtContainerToCnee.TabIndex = 32;
			// 
			// chkEmptyContainer
			// 
			this.chkEmptyContainer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "EmptyContainer", true));
			this.chkEmptyContainer.Location = new System.Drawing.Point(14, 306);
			this.chkEmptyContainer.MenuManager = this.rcMain;
			this.chkEmptyContainer.Name = "chkEmptyContainer";
			this.chkEmptyContainer.Properties.Caption = "Empty in Depot";
			this.chkEmptyContainer.Size = new System.Drawing.Size(168, 24);
			this.chkEmptyContainer.StyleController = this.layoutShipmentTracking;
			this.chkEmptyContainer.TabIndex = 31;
			// 
			// chkConfirmEmptyContainer
			// 
			this.chkConfirmEmptyContainer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "ConfirmEmptyContainer", true));
			this.chkConfirmEmptyContainer.Location = new System.Drawing.Point(14, 334);
			this.chkConfirmEmptyContainer.MenuManager = this.rcMain;
			this.chkConfirmEmptyContainer.Name = "chkConfirmEmptyContainer";
			this.chkConfirmEmptyContainer.Properties.Caption = "Confirm Empty in Depot";
			this.chkConfirmEmptyContainer.Size = new System.Drawing.Size(168, 24);
			this.chkConfirmEmptyContainer.StyleController = this.layoutShipmentTracking;
			this.chkConfirmEmptyContainer.TabIndex = 30;
			// 
			// chkContainerToCnee
			// 
			this.chkContainerToCnee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "ContainerToCnee", true));
			this.chkContainerToCnee.Location = new System.Drawing.Point(14, 278);
			this.chkContainerToCnee.MenuManager = this.rcMain;
			this.chkContainerToCnee.Name = "chkContainerToCnee";
			this.chkContainerToCnee.Properties.Caption = "Container to consignee";
			this.chkContainerToCnee.Size = new System.Drawing.Size(168, 24);
			this.chkContainerToCnee.StyleController = this.layoutShipmentTracking;
			this.chkContainerToCnee.TabIndex = 29;
			// 
			// txtBookingNo
			// 
			this.txtBookingNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "BookingNo", true));
			this.txtBookingNo.Location = new System.Drawing.Point(133, 118);
			this.txtBookingNo.MenuManager = this.rcMain;
			this.txtBookingNo.Name = "txtBookingNo";
			this.txtBookingNo.Size = new System.Drawing.Size(239, 22);
			this.txtBookingNo.StyleController = this.layoutShipmentTracking;
			this.txtBookingNo.TabIndex = 28;
			// 
			// dtMissingDocumentsDate
			// 
			this.dtMissingDocumentsDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "MissingDocumentsDate", true));
			this.dtMissingDocumentsDate.EditValue = null;
			this.dtMissingDocumentsDate.Location = new System.Drawing.Point(540, 210);
			this.dtMissingDocumentsDate.MenuManager = this.rcMain;
			this.dtMissingDocumentsDate.Name = "dtMissingDocumentsDate";
			this.dtMissingDocumentsDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtMissingDocumentsDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtMissingDocumentsDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtMissingDocumentsDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtMissingDocumentsDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtMissingDocumentsDate.Properties.UseMaskAsDisplayFormat = true;
			this.dtMissingDocumentsDate.Size = new System.Drawing.Size(258, 22);
			this.dtMissingDocumentsDate.StyleController = this.layoutShipmentTracking;
			this.dtMissingDocumentsDate.TabIndex = 27;
			// 
			// dtPaidDoDate
			// 
			this.dtPaidDoDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "PaidDODate", true));
			this.dtPaidDoDate.EditValue = null;
			this.dtPaidDoDate.Location = new System.Drawing.Point(540, 182);
			this.dtPaidDoDate.MenuManager = this.rcMain;
			this.dtPaidDoDate.Name = "dtPaidDoDate";
			this.dtPaidDoDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtPaidDoDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtPaidDoDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtPaidDoDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtPaidDoDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtPaidDoDate.Properties.UseMaskAsDisplayFormat = true;
			this.dtPaidDoDate.Size = new System.Drawing.Size(258, 22);
			this.dtPaidDoDate.StyleController = this.layoutShipmentTracking;
			this.dtPaidDoDate.TabIndex = 26;
			// 
			// dtTejrimDate
			// 
			this.dtTejrimDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "TejrimDate", true));
			this.dtTejrimDate.EditValue = null;
			this.dtTejrimDate.Location = new System.Drawing.Point(540, 154);
			this.dtTejrimDate.MenuManager = this.rcMain;
			this.dtTejrimDate.Name = "dtTejrimDate";
			this.dtTejrimDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtTejrimDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtTejrimDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtTejrimDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtTejrimDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtTejrimDate.Properties.UseMaskAsDisplayFormat = true;
			this.dtTejrimDate.Size = new System.Drawing.Size(258, 22);
			this.dtTejrimDate.StyleController = this.layoutShipmentTracking;
			this.dtTejrimDate.TabIndex = 25;
			// 
			// dateEdit10
			// 
			this.dateEdit10.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "DeliveredDate", true));
			this.dateEdit10.EditValue = null;
			this.dateEdit10.Location = new System.Drawing.Point(195, 238);
			this.dateEdit10.MenuManager = this.rcMain;
			this.dateEdit10.Name = "dateEdit10";
			this.dateEdit10.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit10.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit10.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dateEdit10.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dateEdit10.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dateEdit10.Properties.UseMaskAsDisplayFormat = true;
			this.dateEdit10.Size = new System.Drawing.Size(177, 22);
			this.dateEdit10.StyleController = this.layoutShipmentTracking;
			this.dateEdit10.TabIndex = 24;
			// 
			// dtPendingForDelivery
			// 
			this.dtPendingForDelivery.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "PendingDeliveryDate", true));
			this.dtPendingForDelivery.EditValue = null;
			this.dtPendingForDelivery.Location = new System.Drawing.Point(195, 210);
			this.dtPendingForDelivery.MenuManager = this.rcMain;
			this.dtPendingForDelivery.Name = "dtPendingForDelivery";
			this.dtPendingForDelivery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtPendingForDelivery.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtPendingForDelivery.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtPendingForDelivery.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtPendingForDelivery.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtPendingForDelivery.Properties.UseMaskAsDisplayFormat = true;
			this.dtPendingForDelivery.Size = new System.Drawing.Size(177, 22);
			this.dtPendingForDelivery.StyleController = this.layoutShipmentTracking;
			this.dtPendingForDelivery.TabIndex = 23;
			// 
			// dtReadyForClearance
			// 
			this.dtReadyForClearance.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "RClearanceDate", true));
			this.dtReadyForClearance.EditValue = null;
			this.dtReadyForClearance.Location = new System.Drawing.Point(195, 182);
			this.dtReadyForClearance.MenuManager = this.rcMain;
			this.dtReadyForClearance.Name = "dtReadyForClearance";
			this.dtReadyForClearance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtReadyForClearance.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtReadyForClearance.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtReadyForClearance.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtReadyForClearance.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtReadyForClearance.Properties.UseMaskAsDisplayFormat = true;
			this.dtReadyForClearance.Size = new System.Drawing.Size(177, 22);
			this.dtReadyForClearance.StyleController = this.layoutShipmentTracking;
			this.dtReadyForClearance.TabIndex = 22;
			// 
			// dtReadyForTejrim
			// 
			this.dtReadyForTejrim.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "RTejrimDate", true));
			this.dtReadyForTejrim.EditValue = null;
			this.dtReadyForTejrim.Location = new System.Drawing.Point(195, 154);
			this.dtReadyForTejrim.MenuManager = this.rcMain;
			this.dtReadyForTejrim.Name = "dtReadyForTejrim";
			this.dtReadyForTejrim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtReadyForTejrim.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtReadyForTejrim.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtReadyForTejrim.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtReadyForTejrim.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtReadyForTejrim.Properties.UseMaskAsDisplayFormat = true;
			this.dtReadyForTejrim.Size = new System.Drawing.Size(177, 22);
			this.dtReadyForTejrim.StyleController = this.layoutShipmentTracking;
			this.dtReadyForTejrim.TabIndex = 21;
			// 
			// chkDeliveryDate
			// 
			this.chkDeliveryDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "Delivered", true));
			this.chkDeliveryDate.Location = new System.Drawing.Point(14, 238);
			this.chkDeliveryDate.MenuManager = this.rcMain;
			this.chkDeliveryDate.Name = "chkDeliveryDate";
			this.chkDeliveryDate.Properties.Caption = "Delivery Date";
			this.chkDeliveryDate.Size = new System.Drawing.Size(168, 24);
			this.chkDeliveryDate.StyleController = this.layoutShipmentTracking;
			this.chkDeliveryDate.TabIndex = 20;
			// 
			// chkMissingDocuments
			// 
			this.chkMissingDocuments.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "MissingDocuments", true));
			this.chkMissingDocuments.Location = new System.Drawing.Point(386, 210);
			this.chkMissingDocuments.MenuManager = this.rcMain;
			this.chkMissingDocuments.Name = "chkMissingDocuments";
			this.chkMissingDocuments.Properties.Caption = "Missing Documents";
			this.chkMissingDocuments.Size = new System.Drawing.Size(141, 24);
			this.chkMissingDocuments.StyleController = this.layoutShipmentTracking;
			this.chkMissingDocuments.TabIndex = 19;
			// 
			// chkPendingForDelivery
			// 
			this.chkPendingForDelivery.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "PendingForDelivery", true));
			this.chkPendingForDelivery.Location = new System.Drawing.Point(14, 210);
			this.chkPendingForDelivery.MenuManager = this.rcMain;
			this.chkPendingForDelivery.Name = "chkPendingForDelivery";
			this.chkPendingForDelivery.Properties.Caption = "Pending for Delivery";
			this.chkPendingForDelivery.Size = new System.Drawing.Size(168, 24);
			this.chkPendingForDelivery.StyleController = this.layoutShipmentTracking;
			this.chkPendingForDelivery.TabIndex = 18;
			// 
			// chkPaidDo
			// 
			this.chkPaidDo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "PaidDO", true));
			this.chkPaidDo.Location = new System.Drawing.Point(386, 182);
			this.chkPaidDo.MenuManager = this.rcMain;
			this.chkPaidDo.Name = "chkPaidDo";
			this.chkPaidDo.Properties.Caption = "Paid D/O";
			this.chkPaidDo.Size = new System.Drawing.Size(141, 24);
			this.chkPaidDo.StyleController = this.layoutShipmentTracking;
			this.chkPaidDo.TabIndex = 17;
			// 
			// chkReadyForClearance
			// 
			this.chkReadyForClearance.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "RClearance", true));
			this.chkReadyForClearance.Location = new System.Drawing.Point(14, 182);
			this.chkReadyForClearance.MenuManager = this.rcMain;
			this.chkReadyForClearance.Name = "chkReadyForClearance";
			this.chkReadyForClearance.Properties.Caption = "Ready for Clearance";
			this.chkReadyForClearance.Size = new System.Drawing.Size(168, 24);
			this.chkReadyForClearance.StyleController = this.layoutShipmentTracking;
			this.chkReadyForClearance.TabIndex = 16;
			// 
			// chkTejrim
			// 
			this.chkTejrim.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "Tejrim", true));
			this.chkTejrim.Location = new System.Drawing.Point(386, 154);
			this.chkTejrim.MenuManager = this.rcMain;
			this.chkTejrim.Name = "chkTejrim";
			this.chkTejrim.Properties.Caption = "Tejrim";
			this.chkTejrim.Size = new System.Drawing.Size(141, 24);
			this.chkTejrim.StyleController = this.layoutShipmentTracking;
			this.chkTejrim.TabIndex = 15;
			// 
			// chkRTejrim
			// 
			this.chkRTejrim.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "RTejrim", true));
			this.chkRTejrim.Location = new System.Drawing.Point(14, 154);
			this.chkRTejrim.MenuManager = this.rcMain;
			this.chkRTejrim.Name = "chkRTejrim";
			this.chkRTejrim.Properties.Caption = "Ready for Tejrim";
			this.chkRTejrim.Size = new System.Drawing.Size(168, 24);
			this.chkRTejrim.StyleController = this.layoutShipmentTracking;
			this.chkRTejrim.TabIndex = 14;
			// 
			// cboAgents
			// 
			this.cboAgents.Location = new System.Drawing.Point(133, 40);
			this.cboAgents.Name = "cboAgents";
			this.cboAgents.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboAgents.Properties.DisplayMember = "AgentName";
			this.cboAgents.Properties.NullText = "";
			this.cboAgents.Properties.PopupView = this.gridView12;
			this.cboAgents.Properties.ValueMember = "Id";
			this.cboAgents.Size = new System.Drawing.Size(665, 22);
			this.cboAgents.StyleController = this.layoutShipmentTracking;
			this.cboAgents.TabIndex = 17;
			// 
			// gridView12
			// 
			this.gridView12.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnAgentId,
            this.ColumnAgentName});
			this.gridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView12.Name = "gridView12";
			this.gridView12.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView12.OptionsView.ShowGroupPanel = false;
			// 
			// ColumnAgentId
			// 
			this.ColumnAgentId.Caption = "Id";
			this.ColumnAgentId.FieldName = "Id";
			this.ColumnAgentId.Name = "ColumnAgentId";
			this.ColumnAgentId.Visible = true;
			this.ColumnAgentId.VisibleIndex = 0;
			this.ColumnAgentId.Width = 110;
			// 
			// ColumnAgentName
			// 
			this.ColumnAgentName.Caption = "Name";
			this.ColumnAgentName.FieldName = "AgentName";
			this.ColumnAgentName.Name = "ColumnAgentName";
			this.ColumnAgentName.Visible = true;
			this.ColumnAgentName.VisibleIndex = 1;
			this.ColumnAgentName.Width = 926;
			// 
			// cboIncoTerms
			// 
			this.cboIncoTerms.Location = new System.Drawing.Point(133, 92);
			this.cboIncoTerms.Name = "cboIncoTerms";
			this.cboIncoTerms.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboIncoTerms.Properties.DisplayMember = "Description";
			this.cboIncoTerms.Properties.NullText = "";
			this.cboIncoTerms.Properties.PopupView = this.gridView13;
			this.cboIncoTerms.Properties.ValueMember = "Id";
			this.cboIncoTerms.Size = new System.Drawing.Size(239, 22);
			this.cboIncoTerms.StyleController = this.layoutShipmentTracking;
			this.cboIncoTerms.TabIndex = 18;
			// 
			// gridView13
			// 
			this.gridView13.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnTermsId,
            this.ColumnTermCode,
            this.ColumnTermsDescription});
			this.gridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView13.Name = "gridView13";
			this.gridView13.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView13.OptionsView.ShowGroupPanel = false;
			// 
			// ColumnTermsId
			// 
			this.ColumnTermsId.Caption = "Id";
			this.ColumnTermsId.FieldName = "Id";
			this.ColumnTermsId.Name = "ColumnTermsId";
			this.ColumnTermsId.Visible = true;
			this.ColumnTermsId.VisibleIndex = 0;
			this.ColumnTermsId.Width = 74;
			// 
			// ColumnTermCode
			// 
			this.ColumnTermCode.Caption = "Code";
			this.ColumnTermCode.FieldName = "TermCode";
			this.ColumnTermCode.Name = "ColumnTermCode";
			this.ColumnTermCode.Visible = true;
			this.ColumnTermCode.VisibleIndex = 1;
			this.ColumnTermCode.Width = 123;
			// 
			// ColumnTermsDescription
			// 
			this.ColumnTermsDescription.Caption = "Description";
			this.ColumnTermsDescription.FieldName = "Description";
			this.ColumnTermsDescription.Name = "ColumnTermsDescription";
			this.ColumnTermsDescription.Visible = true;
			this.ColumnTermsDescription.VisibleIndex = 2;
			this.ColumnTermsDescription.Width = 839;
			// 
			// cboSeaCarriers
			// 
			this.cboSeaCarriers.Location = new System.Drawing.Point(495, 66);
			this.cboSeaCarriers.Name = "cboSeaCarriers";
			this.cboSeaCarriers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboSeaCarriers.Properties.DisplayMember = "CarrierName";
			this.cboSeaCarriers.Properties.NullText = "";
			this.cboSeaCarriers.Properties.PopupView = this.searchLookUpEdit3View;
			this.cboSeaCarriers.Properties.ValueMember = "Id";
			this.cboSeaCarriers.Size = new System.Drawing.Size(303, 22);
			this.cboSeaCarriers.StyleController = this.layoutShipmentTracking;
			this.cboSeaCarriers.TabIndex = 19;
			// 
			// searchLookUpEdit3View
			// 
			this.searchLookUpEdit3View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnSeaCarrierId,
            this.ColumnSeaCarrierName});
			this.searchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
			this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
			// 
			// ColumnSeaCarrierId
			// 
			this.ColumnSeaCarrierId.Caption = "Id";
			this.ColumnSeaCarrierId.FieldName = "Id";
			this.ColumnSeaCarrierId.Name = "ColumnSeaCarrierId";
			this.ColumnSeaCarrierId.Visible = true;
			this.ColumnSeaCarrierId.VisibleIndex = 0;
			this.ColumnSeaCarrierId.Width = 96;
			// 
			// ColumnSeaCarrierName
			// 
			this.ColumnSeaCarrierName.Caption = "Name";
			this.ColumnSeaCarrierName.FieldName = "Name";
			this.ColumnSeaCarrierName.Name = "ColumnSeaCarrierName";
			this.ColumnSeaCarrierName.Visible = true;
			this.ColumnSeaCarrierName.VisibleIndex = 1;
			this.ColumnSeaCarrierName.Width = 940;
			// 
			// cboVessels
			// 
			this.cboVessels.Location = new System.Drawing.Point(133, 14);
			this.cboVessels.Name = "cboVessels";
			this.cboVessels.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboVessels.Properties.DisplayMember = "Name";
			this.cboVessels.Properties.NullText = "";
			this.cboVessels.Properties.PopupView = this.gridView61;
			this.cboVessels.Properties.ShowAddNewButton = true;
			this.cboVessels.Properties.ValueMember = "Id";
			this.cboVessels.Size = new System.Drawing.Size(239, 22);
			this.cboVessels.StyleController = this.layoutShipmentTracking;
			this.cboVessels.TabIndex = 11;
			// 
			// gridView61
			// 
			this.gridView61.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVesselId,
            this.colVesselName});
			this.gridView61.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView61.Name = "gridView61";
			this.gridView61.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView61.OptionsView.ShowGroupPanel = false;
			// 
			// colVesselId
			// 
			this.colVesselId.Caption = "Id";
			this.colVesselId.FieldName = "Id";
			this.colVesselId.Name = "colVesselId";
			this.colVesselId.Visible = true;
			this.colVesselId.VisibleIndex = 0;
			this.colVesselId.Width = 68;
			// 
			// colVesselName
			// 
			this.colVesselName.Caption = "lVessel Name";
			this.colVesselName.FieldName = "Name";
			this.colVesselName.Name = "colVesselName";
			this.colVesselName.Visible = true;
			this.colVesselName.VisibleIndex = 1;
			this.colVesselName.Width = 968;
			// 
			// cboFeederVessels
			// 
			this.cboFeederVessels.Location = new System.Drawing.Point(495, 14);
			this.cboFeederVessels.Name = "cboFeederVessels";
			this.cboFeederVessels.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboFeederVessels.Properties.DisplayMember = "Name";
			this.cboFeederVessels.Properties.NullText = "";
			this.cboFeederVessels.Properties.PopupView = this.gridView7;
			this.cboFeederVessels.Properties.ShowAddNewButton = true;
			this.cboFeederVessels.Properties.ValueMember = "Id";
			this.cboFeederVessels.Size = new System.Drawing.Size(303, 22);
			this.cboFeederVessels.StyleController = this.layoutShipmentTracking;
			this.cboFeederVessels.TabIndex = 14;
			// 
			// gridView7
			// 
			this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFeederVesselId,
            this.colFeederVesselName});
			this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView7.Name = "gridView7";
			this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView7.OptionsView.ShowGroupPanel = false;
			// 
			// colFeederVesselId
			// 
			this.colFeederVesselId.Caption = "Id";
			this.colFeederVesselId.FieldName = "Id";
			this.colFeederVesselId.Name = "colFeederVesselId";
			this.colFeederVesselId.Visible = true;
			this.colFeederVesselId.VisibleIndex = 0;
			this.colFeederVesselId.Width = 84;
			// 
			// colFeederVesselName
			// 
			this.colFeederVesselName.Caption = "Name";
			this.colFeederVesselName.FieldName = "Name";
			this.colFeederVesselName.Name = "colFeederVesselName";
			this.colFeederVesselName.Visible = true;
			this.colFeederVesselName.VisibleIndex = 1;
			this.colFeederVesselName.Width = 952;
			// 
			// txtFreeOfDemurage
			// 
			this.txtFreeOfDemurage.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "FreeOfDemurrage", true));
			this.txtFreeOfDemurage.Location = new System.Drawing.Point(495, 118);
			this.txtFreeOfDemurage.Name = "txtFreeOfDemurage";
			this.txtFreeOfDemurage.Size = new System.Drawing.Size(303, 22);
			this.txtFreeOfDemurage.StyleController = this.layoutShipmentTracking;
			this.txtFreeOfDemurage.TabIndex = 15;
			// 
			// layoutControlGroup9
			// 
			this.layoutControlGroup9.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup9.GroupBordersVisible = false;
			this.layoutControlGroup9.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem15,
            this.layoutControlItem17,
            this.layoutControlItem19,
            this.layoutControlItem16,
            this.layoutControlItem18,
            this.layoutControlItem20,
            this.layoutControlItem21,
            this.emptySpaceItem5,
            this.lblVessels,
            this.lblFeederVessels,
            this.lblAgents,
            this.lblSeaCarriers,
            this.lblIncoTerms,
            this.lblTejrimDate,
            this.lblPaidDoDate,
            this.lblMissingDocumentsDate,
            this.emptySpaceItem15,
            this.lblFreeOfDemurage,
            this.lblBookingNo,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem22,
            this.emptySpaceItem12,
            this.emptySpaceItem26,
            this.lblReadyForTejrim,
            this.lblReadyForClearance,
            this.lblPendingForDelivery,
            this.layoutControlItem25,
            this.lblContainerToCneeDate,
            this.lblEmptyContainerDate,
            this.lblConfirmEmptyContainerDate,
            this.emptySpaceItem2,
            this.lblShippedWith});
			this.layoutControlGroup9.Name = "Root";
			this.layoutControlGroup9.Size = new System.Drawing.Size(812, 372);
			this.layoutControlGroup9.TextVisible = false;
			// 
			// layoutControlItem15
			// 
			this.layoutControlItem15.Control = this.chkRTejrim;
			this.layoutControlItem15.Location = new System.Drawing.Point(0, 140);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Size = new System.Drawing.Size(172, 28);
			this.layoutControlItem15.TextVisible = false;
			// 
			// layoutControlItem17
			// 
			this.layoutControlItem17.Control = this.chkReadyForClearance;
			this.layoutControlItem17.Location = new System.Drawing.Point(0, 168);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Size = new System.Drawing.Size(172, 28);
			this.layoutControlItem17.TextVisible = false;
			// 
			// layoutControlItem19
			// 
			this.layoutControlItem19.Control = this.chkPendingForDelivery;
			this.layoutControlItem19.Location = new System.Drawing.Point(0, 196);
			this.layoutControlItem19.Name = "layoutControlItem19";
			this.layoutControlItem19.Size = new System.Drawing.Size(172, 28);
			this.layoutControlItem19.TextVisible = false;
			// 
			// layoutControlItem16
			// 
			this.layoutControlItem16.Control = this.chkTejrim;
			this.layoutControlItem16.Location = new System.Drawing.Point(372, 140);
			this.layoutControlItem16.Name = "layoutControlItem16";
			this.layoutControlItem16.Size = new System.Drawing.Size(145, 28);
			this.layoutControlItem16.TextVisible = false;
			// 
			// layoutControlItem18
			// 
			this.layoutControlItem18.Control = this.chkPaidDo;
			this.layoutControlItem18.Location = new System.Drawing.Point(372, 168);
			this.layoutControlItem18.Name = "layoutControlItem18";
			this.layoutControlItem18.Size = new System.Drawing.Size(145, 28);
			this.layoutControlItem18.TextVisible = false;
			// 
			// layoutControlItem20
			// 
			this.layoutControlItem20.Control = this.chkMissingDocuments;
			this.layoutControlItem20.Location = new System.Drawing.Point(372, 196);
			this.layoutControlItem20.Name = "layoutControlItem20";
			this.layoutControlItem20.Size = new System.Drawing.Size(145, 28);
			this.layoutControlItem20.TextVisible = false;
			// 
			// layoutControlItem21
			// 
			this.layoutControlItem21.Control = this.chkDeliveryDate;
			this.layoutControlItem21.Location = new System.Drawing.Point(0, 224);
			this.layoutControlItem21.Name = "layoutControlItem21";
			this.layoutControlItem21.Size = new System.Drawing.Size(172, 28);
			this.layoutControlItem21.TextVisible = false;
			// 
			// emptySpaceItem5
			// 
			this.emptySpaceItem5.Location = new System.Drawing.Point(0, 130);
			this.emptySpaceItem5.Name = "emptySpaceItem5";
			this.emptySpaceItem5.Size = new System.Drawing.Size(788, 10);
			// 
			// lblVessels
			// 
			this.lblVessels.Control = this.cboVessels;
			this.lblVessels.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblVessels.CustomizationFormText = "Vessel";
			this.lblVessels.Location = new System.Drawing.Point(0, 0);
			this.lblVessels.Name = "lblVessels";
			this.lblVessels.Size = new System.Drawing.Size(362, 26);
			this.lblVessels.Text = "Vessel";
			this.lblVessels.TextSize = new System.Drawing.Size(104, 16);
			// 
			// lblFeederVessels
			// 
			this.lblFeederVessels.Control = this.cboFeederVessels;
			this.lblFeederVessels.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblFeederVessels.CustomizationFormText = "Feeder Vessel";
			this.lblFeederVessels.Location = new System.Drawing.Point(362, 0);
			this.lblFeederVessels.Name = "lblFeederVessels";
			this.lblFeederVessels.Size = new System.Drawing.Size(426, 26);
			this.lblFeederVessels.Text = "Feeder Vessel";
			this.lblFeederVessels.TextSize = new System.Drawing.Size(104, 16);
			// 
			// lblAgents
			// 
			this.lblAgents.Control = this.cboAgents;
			this.lblAgents.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblAgents.CustomizationFormText = "Agents";
			this.lblAgents.Location = new System.Drawing.Point(0, 26);
			this.lblAgents.Name = "lblAgents";
			this.lblAgents.Size = new System.Drawing.Size(788, 26);
			this.lblAgents.Text = "Agents";
			this.lblAgents.TextSize = new System.Drawing.Size(104, 16);
			// 
			// lblSeaCarriers
			// 
			this.lblSeaCarriers.Control = this.cboSeaCarriers;
			this.lblSeaCarriers.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblSeaCarriers.CustomizationFormText = "Sea Carriers";
			this.lblSeaCarriers.Location = new System.Drawing.Point(362, 52);
			this.lblSeaCarriers.Name = "lblSeaCarriers";
			this.lblSeaCarriers.Size = new System.Drawing.Size(426, 26);
			this.lblSeaCarriers.Text = "Sea Carriers";
			this.lblSeaCarriers.TextSize = new System.Drawing.Size(104, 16);
			// 
			// lblIncoTerms
			// 
			this.lblIncoTerms.Control = this.cboIncoTerms;
			this.lblIncoTerms.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblIncoTerms.CustomizationFormText = "Inco Terms";
			this.lblIncoTerms.Location = new System.Drawing.Point(0, 78);
			this.lblIncoTerms.Name = "lblIncoTerms";
			this.lblIncoTerms.Size = new System.Drawing.Size(362, 26);
			this.lblIncoTerms.Text = "Inco Terms";
			this.lblIncoTerms.TextSize = new System.Drawing.Size(104, 16);
			// 
			// lblTejrimDate
			// 
			this.lblTejrimDate.Control = this.dtTejrimDate;
			this.lblTejrimDate.Location = new System.Drawing.Point(517, 140);
			this.lblTejrimDate.Name = "lblTejrimDate";
			this.lblTejrimDate.Size = new System.Drawing.Size(271, 28);
			this.lblTejrimDate.Text = " ";
			this.lblTejrimDate.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblTejrimDate.TextSize = new System.Drawing.Size(4, 16);
			this.lblTejrimDate.TextToControlDistance = 5;
			// 
			// lblPaidDoDate
			// 
			this.lblPaidDoDate.Control = this.dtPaidDoDate;
			this.lblPaidDoDate.Location = new System.Drawing.Point(517, 168);
			this.lblPaidDoDate.Name = "lblPaidDoDate";
			this.lblPaidDoDate.Size = new System.Drawing.Size(271, 28);
			this.lblPaidDoDate.Text = " ";
			this.lblPaidDoDate.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblPaidDoDate.TextSize = new System.Drawing.Size(4, 16);
			this.lblPaidDoDate.TextToControlDistance = 5;
			// 
			// lblMissingDocumentsDate
			// 
			this.lblMissingDocumentsDate.Control = this.dtMissingDocumentsDate;
			this.lblMissingDocumentsDate.Location = new System.Drawing.Point(517, 196);
			this.lblMissingDocumentsDate.Name = "lblMissingDocumentsDate";
			this.lblMissingDocumentsDate.Size = new System.Drawing.Size(271, 28);
			this.lblMissingDocumentsDate.Text = " ";
			this.lblMissingDocumentsDate.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblMissingDocumentsDate.TextSize = new System.Drawing.Size(4, 16);
			this.lblMissingDocumentsDate.TextToControlDistance = 5;
			// 
			// emptySpaceItem15
			// 
			this.emptySpaceItem15.Location = new System.Drawing.Point(362, 78);
			this.emptySpaceItem15.Name = "emptySpaceItem15";
			this.emptySpaceItem15.Size = new System.Drawing.Size(426, 26);
			// 
			// lblFreeOfDemurage
			// 
			this.lblFreeOfDemurage.Control = this.txtFreeOfDemurage;
			this.lblFreeOfDemurage.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblFreeOfDemurage.CustomizationFormText = "Free of Demurage";
			this.lblFreeOfDemurage.Location = new System.Drawing.Point(362, 104);
			this.lblFreeOfDemurage.Name = "lblFreeOfDemurage";
			this.lblFreeOfDemurage.Size = new System.Drawing.Size(426, 26);
			this.lblFreeOfDemurage.Text = "Free of Demurage";
			this.lblFreeOfDemurage.TextSize = new System.Drawing.Size(104, 16);
			// 
			// lblBookingNo
			// 
			this.lblBookingNo.Control = this.txtBookingNo;
			this.lblBookingNo.Location = new System.Drawing.Point(0, 104);
			this.lblBookingNo.Name = "lblBookingNo";
			this.lblBookingNo.Size = new System.Drawing.Size(362, 26);
			this.lblBookingNo.Text = "Booking#";
			this.lblBookingNo.TextSize = new System.Drawing.Size(104, 16);
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.Control = this.chkContainerToCnee;
			this.layoutControlItem7.Location = new System.Drawing.Point(0, 264);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(172, 28);
			this.layoutControlItem7.TextVisible = false;
			// 
			// layoutControlItem8
			// 
			this.layoutControlItem8.Control = this.chkConfirmEmptyContainer;
			this.layoutControlItem8.Location = new System.Drawing.Point(0, 320);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(172, 28);
			this.layoutControlItem8.TextVisible = false;
			// 
			// layoutControlItem22
			// 
			this.layoutControlItem22.Control = this.chkEmptyContainer;
			this.layoutControlItem22.Location = new System.Drawing.Point(0, 292);
			this.layoutControlItem22.Name = "layoutControlItem22";
			this.layoutControlItem22.Size = new System.Drawing.Size(172, 28);
			this.layoutControlItem22.TextVisible = false;
			// 
			// emptySpaceItem12
			// 
			this.emptySpaceItem12.Location = new System.Drawing.Point(362, 140);
			this.emptySpaceItem12.Name = "emptySpaceItem12";
			this.emptySpaceItem12.Size = new System.Drawing.Size(10, 208);
			// 
			// emptySpaceItem26
			// 
			this.emptySpaceItem26.Location = new System.Drawing.Point(372, 224);
			this.emptySpaceItem26.Name = "emptySpaceItem26";
			this.emptySpaceItem26.Size = new System.Drawing.Size(416, 124);
			// 
			// lblReadyForTejrim
			// 
			this.lblReadyForTejrim.Control = this.dtReadyForTejrim;
			this.lblReadyForTejrim.Location = new System.Drawing.Point(172, 140);
			this.lblReadyForTejrim.Name = "lblReadyForTejrim";
			this.lblReadyForTejrim.Size = new System.Drawing.Size(190, 28);
			this.lblReadyForTejrim.Text = " ";
			this.lblReadyForTejrim.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblReadyForTejrim.TextSize = new System.Drawing.Size(4, 16);
			this.lblReadyForTejrim.TextToControlDistance = 5;
			// 
			// lblReadyForClearance
			// 
			this.lblReadyForClearance.Control = this.dtReadyForClearance;
			this.lblReadyForClearance.Location = new System.Drawing.Point(172, 168);
			this.lblReadyForClearance.Name = "lblReadyForClearance";
			this.lblReadyForClearance.Size = new System.Drawing.Size(190, 28);
			this.lblReadyForClearance.Text = " ";
			this.lblReadyForClearance.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblReadyForClearance.TextSize = new System.Drawing.Size(4, 16);
			this.lblReadyForClearance.TextToControlDistance = 5;
			// 
			// lblPendingForDelivery
			// 
			this.lblPendingForDelivery.Control = this.dtPendingForDelivery;
			this.lblPendingForDelivery.Location = new System.Drawing.Point(172, 196);
			this.lblPendingForDelivery.Name = "lblPendingForDelivery";
			this.lblPendingForDelivery.Size = new System.Drawing.Size(190, 28);
			this.lblPendingForDelivery.Text = " ";
			this.lblPendingForDelivery.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblPendingForDelivery.TextSize = new System.Drawing.Size(4, 16);
			this.lblPendingForDelivery.TextToControlDistance = 5;
			// 
			// layoutControlItem25
			// 
			this.layoutControlItem25.Control = this.dateEdit10;
			this.layoutControlItem25.Location = new System.Drawing.Point(172, 224);
			this.layoutControlItem25.Name = "layoutControlItem25";
			this.layoutControlItem25.Size = new System.Drawing.Size(190, 28);
			this.layoutControlItem25.Text = " ";
			this.layoutControlItem25.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.layoutControlItem25.TextSize = new System.Drawing.Size(4, 16);
			this.layoutControlItem25.TextToControlDistance = 5;
			// 
			// lblContainerToCneeDate
			// 
			this.lblContainerToCneeDate.Control = this.dtContainerToCnee;
			this.lblContainerToCneeDate.Location = new System.Drawing.Point(172, 264);
			this.lblContainerToCneeDate.Name = "lblContainerToCneeDate";
			this.lblContainerToCneeDate.Size = new System.Drawing.Size(190, 28);
			this.lblContainerToCneeDate.Text = " ";
			this.lblContainerToCneeDate.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblContainerToCneeDate.TextSize = new System.Drawing.Size(4, 16);
			this.lblContainerToCneeDate.TextToControlDistance = 5;
			// 
			// lblEmptyContainerDate
			// 
			this.lblEmptyContainerDate.Control = this.dtEmptyContainer;
			this.lblEmptyContainerDate.Location = new System.Drawing.Point(172, 292);
			this.lblEmptyContainerDate.Name = "lblEmptyContainerDate";
			this.lblEmptyContainerDate.Size = new System.Drawing.Size(190, 28);
			this.lblEmptyContainerDate.Text = " ";
			this.lblEmptyContainerDate.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblEmptyContainerDate.TextSize = new System.Drawing.Size(4, 16);
			this.lblEmptyContainerDate.TextToControlDistance = 5;
			// 
			// lblConfirmEmptyContainerDate
			// 
			this.lblConfirmEmptyContainerDate.Control = this.dtConfirmEmptyContainer;
			this.lblConfirmEmptyContainerDate.Location = new System.Drawing.Point(172, 320);
			this.lblConfirmEmptyContainerDate.Name = "lblConfirmEmptyContainerDate";
			this.lblConfirmEmptyContainerDate.Size = new System.Drawing.Size(190, 28);
			this.lblConfirmEmptyContainerDate.Text = " ";
			this.lblConfirmEmptyContainerDate.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblConfirmEmptyContainerDate.TextSize = new System.Drawing.Size(4, 16);
			this.lblConfirmEmptyContainerDate.TextToControlDistance = 5;
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 252);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(362, 12);
			// 
			// lblShippedWith
			// 
			this.lblShippedWith.Control = this.cboShippedWith;
			this.lblShippedWith.Location = new System.Drawing.Point(0, 52);
			this.lblShippedWith.Name = "lblShippedWith";
			this.lblShippedWith.Size = new System.Drawing.Size(362, 26);
			this.lblShippedWith.Text = "Shipped With";
			this.lblShippedWith.TextSize = new System.Drawing.Size(104, 16);
			// 
			// tabPackageDetails
			// 
			this.tabPackageDetails.Controls.Add(this.layoutPackageDetails);
			this.tabPackageDetails.Name = "tabPackageDetails";
			this.tabPackageDetails.Size = new System.Drawing.Size(814, 374);
			this.tabPackageDetails.Text = "Package Details";
			// 
			// layoutPackageDetails
			// 
			this.layoutPackageDetails.Controls.Add(this.txtValueOfGoods);
			this.layoutPackageDetails.Controls.Add(this.txtVolume);
			this.layoutPackageDetails.Controls.Add(this.txtWeight);
			this.layoutPackageDetails.Controls.Add(this.txtPieces);
			this.layoutPackageDetails.Controls.Add(this.txtQuantities);
			this.layoutPackageDetails.Controls.Add(this.txtNatureOfGoods);
			this.layoutPackageDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutPackageDetails.Location = new System.Drawing.Point(0, 0);
			this.layoutPackageDetails.Name = "layoutPackageDetails";
			this.layoutPackageDetails.Root = this.layoutControlGroup11;
			this.layoutPackageDetails.Size = new System.Drawing.Size(814, 374);
			this.layoutPackageDetails.TabIndex = 0;
			this.layoutPackageDetails.Text = "layoutControl1";
			// 
			// txtValueOfGoods
			// 
			this.txtValueOfGoods.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "ValueOfGoods", true));
			this.txtValueOfGoods.Location = new System.Drawing.Point(114, 293);
			this.txtValueOfGoods.MenuManager = this.rcMain;
			this.txtValueOfGoods.Name = "txtValueOfGoods";
			this.txtValueOfGoods.Size = new System.Drawing.Size(291, 22);
			this.txtValueOfGoods.StyleController = this.layoutPackageDetails;
			this.txtValueOfGoods.TabIndex = 9;
			// 
			// txtVolume
			// 
			this.txtVolume.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "Volume", true));
			this.txtVolume.Location = new System.Drawing.Point(114, 40);
			this.txtVolume.MenuManager = this.rcMain;
			this.txtVolume.Name = "txtVolume";
			this.txtVolume.Size = new System.Drawing.Size(291, 22);
			this.txtVolume.StyleController = this.layoutPackageDetails;
			this.txtVolume.TabIndex = 8;
			// 
			// txtWeight
			// 
			this.txtWeight.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "Weight", true));
			this.txtWeight.Location = new System.Drawing.Point(114, 92);
			this.txtWeight.MenuManager = this.rcMain;
			this.txtWeight.Name = "txtWeight";
			this.txtWeight.Size = new System.Drawing.Size(291, 22);
			this.txtWeight.StyleController = this.layoutPackageDetails;
			this.txtWeight.TabIndex = 6;
			// 
			// txtPieces
			// 
			this.txtPieces.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "Pieces", true));
			this.txtPieces.Location = new System.Drawing.Point(114, 66);
			this.txtPieces.MenuManager = this.rcMain;
			this.txtPieces.Name = "txtPieces";
			this.txtPieces.Size = new System.Drawing.Size(291, 22);
			this.txtPieces.StyleController = this.layoutPackageDetails;
			this.txtPieces.TabIndex = 5;
			// 
			// txtQuantities
			// 
			this.txtQuantities.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "Quantities", true));
			this.txtQuantities.Location = new System.Drawing.Point(114, 14);
			this.txtQuantities.MenuManager = this.rcMain;
			this.txtQuantities.Name = "txtQuantities";
			this.txtQuantities.Size = new System.Drawing.Size(291, 22);
			this.txtQuantities.StyleController = this.layoutPackageDetails;
			this.txtQuantities.TabIndex = 4;
			// 
			// txtNatureOfGoods
			// 
			this.txtNatureOfGoods.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsJobSeaImport, "NatureOfGoods", true));
			this.txtNatureOfGoods.Location = new System.Drawing.Point(114, 134);
			this.txtNatureOfGoods.MenuManager = this.rcMain;
			this.txtNatureOfGoods.Name = "txtNatureOfGoods";
			this.txtNatureOfGoods.Size = new System.Drawing.Size(686, 155);
			this.txtNatureOfGoods.StyleController = this.layoutPackageDetails;
			this.txtNatureOfGoods.TabIndex = 7;
			// 
			// layoutControlGroup11
			// 
			this.layoutControlGroup11.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup11.GroupBordersVisible = false;
			this.layoutControlGroup11.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblQuantities,
            this.emptySpaceItem18,
            this.lblPieces,
            this.lblWeight,
            this.lblCommodities,
            this.emptySpaceItem19,
            this.emptySpaceItem20,
            this.emptySpaceItem21,
            this.emptySpaceItem22,
            this.lblVolume,
            this.lblValueOfGoods,
            this.emptySpaceItem25});
			this.layoutControlGroup11.Name = "Root";
			this.layoutControlGroup11.Size = new System.Drawing.Size(814, 374);
			this.layoutControlGroup11.TextVisible = false;
			// 
			// lblQuantities
			// 
			this.lblQuantities.Control = this.txtQuantities;
			this.lblQuantities.Location = new System.Drawing.Point(0, 0);
			this.lblQuantities.Name = "lblQuantities";
			this.lblQuantities.Size = new System.Drawing.Size(395, 26);
			this.lblQuantities.Text = "Quantities";
			this.lblQuantities.TextSize = new System.Drawing.Size(85, 16);
			// 
			// emptySpaceItem18
			// 
			this.emptySpaceItem18.Location = new System.Drawing.Point(0, 305);
			this.emptySpaceItem18.Name = "emptySpaceItem18";
			this.emptySpaceItem18.Size = new System.Drawing.Size(790, 45);
			// 
			// lblPieces
			// 
			this.lblPieces.Control = this.txtPieces;
			this.lblPieces.Location = new System.Drawing.Point(0, 52);
			this.lblPieces.Name = "lblPieces";
			this.lblPieces.Size = new System.Drawing.Size(395, 26);
			this.lblPieces.Text = "Pieces";
			this.lblPieces.TextSize = new System.Drawing.Size(85, 16);
			// 
			// lblWeight
			// 
			this.lblWeight.Control = this.txtWeight;
			this.lblWeight.Location = new System.Drawing.Point(0, 78);
			this.lblWeight.Name = "lblWeight";
			this.lblWeight.Size = new System.Drawing.Size(395, 26);
			this.lblWeight.Text = "Weight";
			this.lblWeight.TextSize = new System.Drawing.Size(85, 16);
			// 
			// lblCommodities
			// 
			this.lblCommodities.Control = this.txtNatureOfGoods;
			this.lblCommodities.Location = new System.Drawing.Point(0, 120);
			this.lblCommodities.Name = "lblCommodities";
			this.lblCommodities.Size = new System.Drawing.Size(790, 159);
			this.lblCommodities.Text = "Commodities";
			this.lblCommodities.TextSize = new System.Drawing.Size(85, 16);
			// 
			// emptySpaceItem19
			// 
			this.emptySpaceItem19.Location = new System.Drawing.Point(0, 104);
			this.emptySpaceItem19.Name = "emptySpaceItem19";
			this.emptySpaceItem19.Size = new System.Drawing.Size(790, 16);
			// 
			// emptySpaceItem20
			// 
			this.emptySpaceItem20.Location = new System.Drawing.Point(395, 0);
			this.emptySpaceItem20.Name = "emptySpaceItem20";
			this.emptySpaceItem20.Size = new System.Drawing.Size(395, 26);
			// 
			// emptySpaceItem21
			// 
			this.emptySpaceItem21.Location = new System.Drawing.Point(395, 26);
			this.emptySpaceItem21.Name = "emptySpaceItem21";
			this.emptySpaceItem21.Size = new System.Drawing.Size(395, 52);
			// 
			// emptySpaceItem22
			// 
			this.emptySpaceItem22.Location = new System.Drawing.Point(395, 78);
			this.emptySpaceItem22.Name = "emptySpaceItem22";
			this.emptySpaceItem22.Size = new System.Drawing.Size(395, 26);
			// 
			// lblVolume
			// 
			this.lblVolume.Control = this.txtVolume;
			this.lblVolume.Location = new System.Drawing.Point(0, 26);
			this.lblVolume.Name = "lblVolume";
			this.lblVolume.Size = new System.Drawing.Size(395, 26);
			this.lblVolume.Text = "Volume";
			this.lblVolume.TextSize = new System.Drawing.Size(85, 16);
			// 
			// lblValueOfGoods
			// 
			this.lblValueOfGoods.Control = this.txtValueOfGoods;
			this.lblValueOfGoods.Location = new System.Drawing.Point(0, 279);
			this.lblValueOfGoods.Name = "lblValueOfGoods";
			this.lblValueOfGoods.Size = new System.Drawing.Size(395, 26);
			this.lblValueOfGoods.Text = "Value of goods";
			this.lblValueOfGoods.TextSize = new System.Drawing.Size(85, 16);
			// 
			// emptySpaceItem25
			// 
			this.emptySpaceItem25.Location = new System.Drawing.Point(395, 279);
			this.emptySpaceItem25.Name = "emptySpaceItem25";
			this.emptySpaceItem25.Size = new System.Drawing.Size(395, 26);
			// 
			// tabUserInformation
			// 
			this.tabUserInformation.Controls.Add(this.layoutUserInformation);
			this.tabUserInformation.Name = "tabUserInformation";
			this.tabUserInformation.Size = new System.Drawing.Size(814, 374);
			this.tabUserInformation.Text = "User Information";
			// 
			// layoutUserInformation
			// 
			this.layoutUserInformation.Controls.Add(this.txtUserLogData);
			this.layoutUserInformation.Controls.Add(this.cboUsers);
			this.layoutUserInformation.Controls.Add(this.cboSales);
			this.layoutUserInformation.Controls.Add(this.cboOperatingUsers);
			this.layoutUserInformation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutUserInformation.Location = new System.Drawing.Point(0, 0);
			this.layoutUserInformation.Name = "layoutUserInformation";
			this.layoutUserInformation.Root = this.layoutControlGroup2;
			this.layoutUserInformation.Size = new System.Drawing.Size(814, 374);
			this.layoutUserInformation.TabIndex = 0;
			this.layoutUserInformation.Text = "layoutControl1";
			// 
			// txtUserLogData
			// 
			this.txtUserLogData.Location = new System.Drawing.Point(14, 135);
			this.txtUserLogData.MenuManager = this.rcMain;
			this.txtUserLogData.Name = "txtUserLogData";
			this.txtUserLogData.Properties.ReadOnly = true;
			this.txtUserLogData.Properties.UseReadOnlyAppearance = false;
			this.txtUserLogData.Size = new System.Drawing.Size(786, 212);
			this.txtUserLogData.StyleController = this.layoutUserInformation;
			this.txtUserLogData.TabIndex = 14;
			// 
			// cboUsers
			// 
			this.cboUsers.Location = new System.Drawing.Point(115, 14);
			this.cboUsers.Name = "cboUsers";
			this.cboUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboUsers.Properties.DisplayMember = "UserName";
			this.cboUsers.Properties.NullText = "";
			this.cboUsers.Properties.PopupView = this.gridView3;
			this.cboUsers.Properties.ValueMember = "Id";
			this.cboUsers.Size = new System.Drawing.Size(290, 22);
			this.cboUsers.StyleController = this.layoutUserInformation;
			this.cboUsers.TabIndex = 6;
			// 
			// gridView3
			// 
			this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnUserId,
            this.columnUserName});
			this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView3.Name = "gridView3";
			this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView3.OptionsView.ShowGroupPanel = false;
			// 
			// columnUserId
			// 
			this.columnUserId.Caption = "Id";
			this.columnUserId.FieldName = "Id";
			this.columnUserId.Name = "columnUserId";
			this.columnUserId.Visible = true;
			this.columnUserId.VisibleIndex = 0;
			this.columnUserId.Width = 95;
			// 
			// columnUserName
			// 
			this.columnUserName.Caption = "User Name";
			this.columnUserName.FieldName = "UserName";
			this.columnUserName.Name = "columnUserName";
			this.columnUserName.Visible = true;
			this.columnUserName.VisibleIndex = 1;
			this.columnUserName.Width = 941;
			// 
			// cboSales
			// 
			this.cboSales.Location = new System.Drawing.Point(115, 40);
			this.cboSales.Name = "cboSales";
			this.cboSales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboSales.Properties.DisplayMember = "UserName";
			this.cboSales.Properties.NullText = "";
			this.cboSales.Properties.PopupView = this.gridView4;
			this.cboSales.Properties.ValueMember = "Id";
			this.cboSales.Size = new System.Drawing.Size(290, 22);
			this.cboSales.StyleController = this.layoutUserInformation;
			this.cboSales.TabIndex = 7;
			// 
			// gridView4
			// 
			this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnSalesmanId,
            this.columnSalesmanName});
			this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView4.Name = "gridView4";
			this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView4.OptionsView.ShowGroupPanel = false;
			// 
			// columnSalesmanId
			// 
			this.columnSalesmanId.Caption = "Id";
			this.columnSalesmanId.FieldName = "Id";
			this.columnSalesmanId.Name = "columnSalesmanId";
			this.columnSalesmanId.Visible = true;
			this.columnSalesmanId.VisibleIndex = 0;
			this.columnSalesmanId.Width = 84;
			// 
			// columnSalesmanName
			// 
			this.columnSalesmanName.Caption = "Salesman";
			this.columnSalesmanName.FieldName = "UserName";
			this.columnSalesmanName.Name = "columnSalesmanName";
			this.columnSalesmanName.Visible = true;
			this.columnSalesmanName.VisibleIndex = 1;
			this.columnSalesmanName.Width = 952;
			// 
			// cboOperatingUsers
			// 
			this.cboOperatingUsers.Location = new System.Drawing.Point(115, 66);
			this.cboOperatingUsers.Name = "cboOperatingUsers";
			this.cboOperatingUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboOperatingUsers.Properties.DisplayMember = "UserName";
			this.cboOperatingUsers.Properties.NullText = "";
			this.cboOperatingUsers.Properties.PopupView = this.gridView5;
			this.cboOperatingUsers.Properties.ValueMember = "Id";
			this.cboOperatingUsers.Size = new System.Drawing.Size(290, 22);
			this.cboOperatingUsers.StyleController = this.layoutUserInformation;
			this.cboOperatingUsers.TabIndex = 13;
			// 
			// gridView5
			// 
			this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnOperatingUserId,
            this.columnOperatingUserName});
			this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView5.Name = "gridView5";
			this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView5.OptionsView.ShowGroupPanel = false;
			// 
			// columnOperatingUserId
			// 
			this.columnOperatingUserId.Caption = "Id";
			this.columnOperatingUserId.FieldName = "Id";
			this.columnOperatingUserId.Name = "columnOperatingUserId";
			this.columnOperatingUserId.Visible = true;
			this.columnOperatingUserId.VisibleIndex = 0;
			this.columnOperatingUserId.Width = 93;
			// 
			// columnOperatingUserName
			// 
			this.columnOperatingUserName.Caption = "Operating User";
			this.columnOperatingUserName.FieldName = "UserName";
			this.columnOperatingUserName.Name = "columnOperatingUserName";
			this.columnOperatingUserName.Visible = true;
			this.columnOperatingUserName.VisibleIndex = 1;
			this.columnOperatingUserName.Width = 943;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup2.GroupBordersVisible = false;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblUserName,
            this.lblSalesman,
            this.lblOperatingUser,
            this.emptySpaceItem13,
            this.emptySpaceItem14,
            this.emptySpaceItem16,
            this.emptySpaceItem17,
            this.lblUserLogData,
            this.emptySpaceItem23});
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(814, 374);
			this.layoutControlGroup2.TextVisible = false;
			// 
			// lblUserName
			// 
			this.lblUserName.Control = this.cboUsers;
			this.lblUserName.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblUserName.CustomizationFormText = "User Name";
			this.lblUserName.Location = new System.Drawing.Point(0, 0);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(395, 26);
			this.lblUserName.Text = "User Name";
			this.lblUserName.TextSize = new System.Drawing.Size(86, 16);
			// 
			// lblSalesman
			// 
			this.lblSalesman.Control = this.cboSales;
			this.lblSalesman.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblSalesman.CustomizationFormText = "Salesman";
			this.lblSalesman.Location = new System.Drawing.Point(0, 26);
			this.lblSalesman.Name = "lblSalesman";
			this.lblSalesman.Size = new System.Drawing.Size(395, 26);
			this.lblSalesman.Text = "Salesman";
			this.lblSalesman.TextSize = new System.Drawing.Size(86, 16);
			// 
			// lblOperatingUser
			// 
			this.lblOperatingUser.Control = this.cboOperatingUsers;
			this.lblOperatingUser.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblOperatingUser.CustomizationFormText = "Operating User";
			this.lblOperatingUser.Location = new System.Drawing.Point(0, 52);
			this.lblOperatingUser.Name = "lblOperatingUser";
			this.lblOperatingUser.Size = new System.Drawing.Size(395, 26);
			this.lblOperatingUser.Text = "Operating User";
			this.lblOperatingUser.TextSize = new System.Drawing.Size(86, 16);
			// 
			// emptySpaceItem13
			// 
			this.emptySpaceItem13.Location = new System.Drawing.Point(0, 337);
			this.emptySpaceItem13.Name = "emptySpaceItem13";
			this.emptySpaceItem13.Size = new System.Drawing.Size(790, 13);
			// 
			// emptySpaceItem14
			// 
			this.emptySpaceItem14.Location = new System.Drawing.Point(395, 0);
			this.emptySpaceItem14.Name = "emptySpaceItem14";
			this.emptySpaceItem14.Size = new System.Drawing.Size(395, 26);
			// 
			// emptySpaceItem16
			// 
			this.emptySpaceItem16.Location = new System.Drawing.Point(395, 26);
			this.emptySpaceItem16.Name = "emptySpaceItem16";
			this.emptySpaceItem16.Size = new System.Drawing.Size(395, 26);
			// 
			// emptySpaceItem17
			// 
			this.emptySpaceItem17.Location = new System.Drawing.Point(395, 52);
			this.emptySpaceItem17.Name = "emptySpaceItem17";
			this.emptySpaceItem17.Size = new System.Drawing.Size(395, 26);
			// 
			// lblUserLogData
			// 
			this.lblUserLogData.Control = this.txtUserLogData;
			this.lblUserLogData.Location = new System.Drawing.Point(0, 101);
			this.lblUserLogData.Name = "lblUserLogData";
			this.lblUserLogData.Size = new System.Drawing.Size(790, 236);
			this.lblUserLogData.Text = "User Log Data";
			this.lblUserLogData.TextLocation = DevExpress.Utils.Locations.Top;
			this.lblUserLogData.TextSize = new System.Drawing.Size(86, 16);
			// 
			// emptySpaceItem23
			// 
			this.emptySpaceItem23.Location = new System.Drawing.Point(0, 78);
			this.emptySpaceItem23.Name = "emptySpaceItem23";
			this.emptySpaceItem23.Size = new System.Drawing.Size(790, 23);
			// 
			// tabDetails
			// 
			this.tabDetails.Controls.Add(this.tabJobDetails);
			this.tabDetails.Controls.Add(this.tabRequirements);
			this.tabDetails.Controls.Add(this.tabSellingGroup);
			this.tabDetails.Controls.Add(this.tabCostGroup);
			this.tabDetails.Controls.Add(this.tabDocuments);
			this.tabDetails.Controls.Add(this.tabCommissions);
			this.tabDetails.Controls.Add(this.tabShipmentStatus);
			this.tabDetails.Location = new System.Drawing.Point(14, 420);
			this.tabDetails.Name = "tabDetails";
			this.tabDetails.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabJobDetails,
            this.tabRequirements,
            this.tabSellingGroup,
            this.tabCostGroup,
            this.tabDocuments,
            this.tabCommissions,
            this.tabShipmentStatus});
			this.tabDetails.RegularSize = new System.Drawing.Size(1420, 292);
			this.tabDetails.SelectedPage = this.tabJobDetails;
			this.tabDetails.Size = new System.Drawing.Size(1420, 292);
			this.tabDetails.TabIndex = 15;
			this.tabDetails.Text = "tabPane1";
			this.tabDetails.Click += new System.EventHandler(this.tabDetails_Click);
			// 
			// tabJobDetails
			// 
			this.tabJobDetails.Caption = "Job Details";
			this.tabJobDetails.Controls.Add(this.layoutJobDetails);
			this.tabJobDetails.Name = "tabJobDetails";
			this.tabJobDetails.Size = new System.Drawing.Size(1420, 251);
			// 
			// layoutJobDetails
			// 
			this.layoutJobDetails.Controls.Add(this.gcJobDetails);
			this.layoutJobDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutJobDetails.Location = new System.Drawing.Point(0, 0);
			this.layoutJobDetails.Name = "layoutJobDetails";
			this.layoutJobDetails.Root = this.layoutControlGroup1;
			this.layoutJobDetails.Size = new System.Drawing.Size(1420, 251);
			this.layoutJobDetails.TabIndex = 0;
			this.layoutJobDetails.Text = "layoutControl1";
			// 
			// gcJobDetails
			// 
			this.gcJobDetails.DataSource = this.bsJobSeaImportDetails;
			this.gcJobDetails.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcJobDetails.Location = new System.Drawing.Point(14, 14);
			this.gcJobDetails.MainView = this.gvJobDetails;
			this.gcJobDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcJobDetails.Name = "gcJobDetails";
			this.gcJobDetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCountries,
            this.repShippers});
			this.gcJobDetails.Size = new System.Drawing.Size(1392, 223);
			this.gcJobDetails.TabIndex = 5;
			this.gcJobDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvJobDetails});
			// 
			// gvJobDetails
			// 
			this.gvJobDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colJobId,
            this.colHbl,
            this.colOriginId,
            this.colSupplierId,
            this.colContainerNo,
            this.colQuantities,
            this.colUnitId,
            this.colPieces,
            this.colUnitOfMeasureId,
            this.colPackages,
            this.colWeight,
            this.colValueOfGoods,
            this.colTerms,
            this.colCcAmount,
            this.colOriginal,
            this.colPhoto,
            this.colPl,
            this.colPop,
            this.colCommodity,
            this.colNotify,
            this.colNotes});
			this.gvJobDetails.DetailHeight = 431;
			this.gvJobDetails.GridControl = this.gcJobDetails;
			this.gvJobDetails.Name = "gvJobDetails";
			this.gvJobDetails.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
			this.gvJobDetails.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
			this.gvJobDetails.OptionsNavigation.AutoFocusNewRow = true;
			this.gvJobDetails.OptionsNavigation.EnterMoveNextColumn = true;
			this.gvJobDetails.OptionsPrint.AutoWidth = false;
			this.gvJobDetails.OptionsView.ColumnAutoWidth = false;
			this.gvJobDetails.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.gvJobDetails.OptionsView.ShowFooter = true;
			this.gvJobDetails.OptionsView.ShowGroupPanel = false;
			// 
			// colId1
			// 
			this.colId1.FieldName = "Id";
			this.colId1.MinWidth = 25;
			this.colId1.Name = "colId1";
			this.colId1.Width = 94;
			// 
			// colJobId
			// 
			this.colJobId.FieldName = "JobId";
			this.colJobId.MinWidth = 25;
			this.colJobId.Name = "colJobId";
			this.colJobId.Width = 94;
			// 
			// colHbl
			// 
			this.colHbl.FieldName = "Hbl";
			this.colHbl.MinWidth = 25;
			this.colHbl.Name = "colHbl";
			this.colHbl.Visible = true;
			this.colHbl.VisibleIndex = 0;
			this.colHbl.Width = 151;
			// 
			// colOriginId
			// 
			this.colOriginId.Caption = "Origin";
			this.colOriginId.ColumnEdit = this.repCountries;
			this.colOriginId.FieldName = "OriginId";
			this.colOriginId.MinWidth = 25;
			this.colOriginId.Name = "colOriginId";
			this.colOriginId.Visible = true;
			this.colOriginId.VisibleIndex = 1;
			this.colOriginId.Width = 132;
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
			// colSupplierId
			// 
			this.colSupplierId.Caption = "Supplier";
			this.colSupplierId.ColumnEdit = this.repShippers;
			this.colSupplierId.FieldName = "SupplierId";
			this.colSupplierId.MinWidth = 25;
			this.colSupplierId.Name = "colSupplierId";
			this.colSupplierId.Visible = true;
			this.colSupplierId.VisibleIndex = 2;
			this.colSupplierId.Width = 211;
			// 
			// repShippers
			// 
			this.repShippers.AutoHeight = false;
			this.repShippers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repShippers.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repShippers.DisplayMember = "Name";
			this.repShippers.Name = "repShippers";
			this.repShippers.NullText = "";
			this.repShippers.ValueMember = "Id";
			// 
			// colContainerNo
			// 
			this.colContainerNo.FieldName = "ContainerNo";
			this.colContainerNo.MinWidth = 25;
			this.colContainerNo.Name = "colContainerNo";
			this.colContainerNo.Visible = true;
			this.colContainerNo.VisibleIndex = 3;
			this.colContainerNo.Width = 143;
			// 
			// colQuantities
			// 
			this.colQuantities.FieldName = "Quantities";
			this.colQuantities.MinWidth = 25;
			this.colQuantities.Name = "colQuantities";
			this.colQuantities.Visible = true;
			this.colQuantities.VisibleIndex = 4;
			this.colQuantities.Width = 95;
			// 
			// colUnitId
			// 
			this.colUnitId.Caption = "Unit";
			this.colUnitId.FieldName = "UnitId";
			this.colUnitId.MinWidth = 25;
			this.colUnitId.Name = "colUnitId";
			this.colUnitId.Visible = true;
			this.colUnitId.VisibleIndex = 5;
			this.colUnitId.Width = 94;
			// 
			// colPieces
			// 
			this.colPieces.FieldName = "Pieces";
			this.colPieces.MinWidth = 25;
			this.colPieces.Name = "colPieces";
			this.colPieces.Visible = true;
			this.colPieces.VisibleIndex = 6;
			this.colPieces.Width = 78;
			// 
			// colUnitOfMeasureId
			// 
			this.colUnitOfMeasureId.Caption = "Unit of Measure";
			this.colUnitOfMeasureId.FieldName = "UnitOfMeasureId";
			this.colUnitOfMeasureId.MinWidth = 25;
			this.colUnitOfMeasureId.Name = "colUnitOfMeasureId";
			this.colUnitOfMeasureId.Visible = true;
			this.colUnitOfMeasureId.VisibleIndex = 7;
			this.colUnitOfMeasureId.Width = 123;
			// 
			// colPackages
			// 
			this.colPackages.FieldName = "Packages";
			this.colPackages.MinWidth = 25;
			this.colPackages.Name = "colPackages";
			this.colPackages.Visible = true;
			this.colPackages.VisibleIndex = 8;
			this.colPackages.Width = 166;
			// 
			// colWeight
			// 
			this.colWeight.FieldName = "Weight";
			this.colWeight.MinWidth = 25;
			this.colWeight.Name = "colWeight";
			this.colWeight.Visible = true;
			this.colWeight.VisibleIndex = 9;
			this.colWeight.Width = 94;
			// 
			// colValueOfGoods
			// 
			this.colValueOfGoods.FieldName = "ValueOfGoods";
			this.colValueOfGoods.MinWidth = 25;
			this.colValueOfGoods.Name = "colValueOfGoods";
			this.colValueOfGoods.Visible = true;
			this.colValueOfGoods.VisibleIndex = 10;
			this.colValueOfGoods.Width = 94;
			// 
			// colTerms
			// 
			this.colTerms.FieldName = "Terms";
			this.colTerms.MinWidth = 25;
			this.colTerms.Name = "colTerms";
			this.colTerms.Visible = true;
			this.colTerms.VisibleIndex = 11;
			this.colTerms.Width = 94;
			// 
			// colCcAmount
			// 
			this.colCcAmount.Caption = "CC Amount";
			this.colCcAmount.FieldName = "CcAmount";
			this.colCcAmount.MinWidth = 25;
			this.colCcAmount.Name = "colCcAmount";
			this.colCcAmount.Visible = true;
			this.colCcAmount.VisibleIndex = 12;
			this.colCcAmount.Width = 94;
			// 
			// colOriginal
			// 
			this.colOriginal.FieldName = "Original";
			this.colOriginal.MinWidth = 25;
			this.colOriginal.Name = "colOriginal";
			this.colOriginal.Visible = true;
			this.colOriginal.VisibleIndex = 13;
			this.colOriginal.Width = 94;
			// 
			// colPhoto
			// 
			this.colPhoto.FieldName = "Photo";
			this.colPhoto.MinWidth = 25;
			this.colPhoto.Name = "colPhoto";
			this.colPhoto.Visible = true;
			this.colPhoto.VisibleIndex = 14;
			this.colPhoto.Width = 94;
			// 
			// colPl
			// 
			this.colPl.FieldName = "Pl";
			this.colPl.MinWidth = 25;
			this.colPl.Name = "colPl";
			this.colPl.Visible = true;
			this.colPl.VisibleIndex = 15;
			this.colPl.Width = 94;
			// 
			// colPop
			// 
			this.colPop.FieldName = "Pop";
			this.colPop.MinWidth = 25;
			this.colPop.Name = "colPop";
			this.colPop.Visible = true;
			this.colPop.VisibleIndex = 16;
			this.colPop.Width = 94;
			// 
			// colCommodity
			// 
			this.colCommodity.FieldName = "Commodity";
			this.colCommodity.MinWidth = 25;
			this.colCommodity.Name = "colCommodity";
			this.colCommodity.Visible = true;
			this.colCommodity.VisibleIndex = 17;
			this.colCommodity.Width = 364;
			// 
			// colNotify
			// 
			this.colNotify.FieldName = "Notify";
			this.colNotify.MinWidth = 25;
			this.colNotify.Name = "colNotify";
			this.colNotify.Visible = true;
			this.colNotify.VisibleIndex = 18;
			this.colNotify.Width = 100;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 19;
			this.colNotes.Width = 280;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(1420, 251);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcJobDetails;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1396, 227);
			this.layoutControlItem1.TextVisible = false;
			// 
			// tabRequirements
			// 
			this.tabRequirements.Caption = "Requirements";
			this.tabRequirements.Controls.Add(this.layoutRequirements);
			this.tabRequirements.Name = "tabRequirements";
			this.tabRequirements.Size = new System.Drawing.Size(1420, 251);
			// 
			// layoutRequirements
			// 
			this.layoutRequirements.Controls.Add(this.lblAllInOrderOnWater);
			this.layoutRequirements.Controls.Add(this.lblAllInOrderToBeloaded);
			this.layoutRequirements.Controls.Add(this.btnAllInOrderOW);
			this.layoutRequirements.Controls.Add(this.btnAllInOrderTBL);
			this.layoutRequirements.Controls.Add(this.gridSplitContainer1);
			this.layoutRequirements.Controls.Add(this.gcRequiredToBeLoaded);
			this.layoutRequirements.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutRequirements.Location = new System.Drawing.Point(0, 0);
			this.layoutRequirements.Name = "layoutRequirements";
			this.layoutRequirements.Root = this.layoutControlGroup12;
			this.layoutRequirements.Size = new System.Drawing.Size(1420, 251);
			this.layoutRequirements.TabIndex = 1;
			this.layoutRequirements.Text = "layoutControl6";
			// 
			// lblAllInOrderOnWater
			// 
			this.lblAllInOrderOnWater.Appearance.BackColor = System.Drawing.Color.Lime;
			this.lblAllInOrderOnWater.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAllInOrderOnWater.Appearance.ForeColor = System.Drawing.Color.White;
			this.lblAllInOrderOnWater.Appearance.Options.UseBackColor = true;
			this.lblAllInOrderOnWater.Appearance.Options.UseFont = true;
			this.lblAllInOrderOnWater.Appearance.Options.UseForeColor = true;
			this.lblAllInOrderOnWater.Location = new System.Drawing.Point(1311, 14);
			this.lblAllInOrderOnWater.Name = "lblAllInOrderOnWater";
			this.lblAllInOrderOnWater.Size = new System.Drawing.Size(94, 21);
			this.lblAllInOrderOnWater.StyleController = this.layoutRequirements;
			this.lblAllInOrderOnWater.TabIndex = 9;
			this.lblAllInOrderOnWater.Text = "All in order";
			// 
			// lblAllInOrderToBeloaded
			// 
			this.lblAllInOrderToBeloaded.Appearance.BackColor = System.Drawing.Color.Lime;
			this.lblAllInOrderToBeloaded.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAllInOrderToBeloaded.Appearance.ForeColor = System.Drawing.Color.White;
			this.lblAllInOrderToBeloaded.Appearance.Options.UseBackColor = true;
			this.lblAllInOrderToBeloaded.Appearance.Options.UseFont = true;
			this.lblAllInOrderToBeloaded.Appearance.Options.UseForeColor = true;
			this.lblAllInOrderToBeloaded.Location = new System.Drawing.Point(602, 14);
			this.lblAllInOrderToBeloaded.Name = "lblAllInOrderToBeloaded";
			this.lblAllInOrderToBeloaded.Size = new System.Drawing.Size(94, 21);
			this.lblAllInOrderToBeloaded.StyleController = this.layoutRequirements;
			this.lblAllInOrderToBeloaded.TabIndex = 8;
			this.lblAllInOrderToBeloaded.Text = "All in order";
			// 
			// btnAllInOrderOW
			// 
			this.btnAllInOrderOW.Location = new System.Drawing.Point(1311, 210);
			this.btnAllInOrderOW.Name = "btnAllInOrderOW";
			this.btnAllInOrderOW.Size = new System.Drawing.Size(95, 27);
			this.btnAllInOrderOW.StyleController = this.layoutRequirements;
			this.btnAllInOrderOW.TabIndex = 7;
			this.btnAllInOrderOW.Text = "<< All In Order";
			// 
			// btnAllInOrderTBL
			// 
			this.btnAllInOrderTBL.Location = new System.Drawing.Point(602, 210);
			this.btnAllInOrderTBL.Name = "btnAllInOrderTBL";
			this.btnAllInOrderTBL.Size = new System.Drawing.Size(95, 27);
			this.btnAllInOrderTBL.StyleController = this.layoutRequirements;
			this.btnAllInOrderTBL.TabIndex = 6;
			this.btnAllInOrderTBL.Text = "<< All In Order";
			this.btnAllInOrderTBL.Click += new System.EventHandler(this.btnAllInOrderTBL_Click);
			// 
			// gridSplitContainer1
			// 
			this.gridSplitContainer1.Grid = this.gcRequiredOnWater;
			this.gridSplitContainer1.Location = new System.Drawing.Point(701, 14);
			this.gridSplitContainer1.Name = "gridSplitContainer1";
			// 
			// gridSplitContainer1.Panel1
			// 
			this.gridSplitContainer1.Panel1.Controls.Add(this.gcRequiredOnWater);
			this.gridSplitContainer1.Panel1.Text = "Panel1";
			// 
			// gridSplitContainer1.Panel2
			// 
			this.gridSplitContainer1.Panel2.Text = "Panel2";
			this.gridSplitContainer1.Size = new System.Drawing.Size(606, 223);
			this.gridSplitContainer1.TabIndex = 5;
			// 
			// gcRequiredOnWater
			// 
			this.gcRequiredOnWater.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcRequiredOnWater.Location = new System.Drawing.Point(0, 0);
			this.gcRequiredOnWater.MainView = this.gvRequiredOnWater;
			this.gcRequiredOnWater.Name = "gcRequiredOnWater";
			this.gcRequiredOnWater.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheckEdit});
			this.gcRequiredOnWater.Size = new System.Drawing.Size(606, 223);
			this.gcRequiredOnWater.TabIndex = 0;
			this.gcRequiredOnWater.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRequiredOnWater});
			// 
			// gvRequiredOnWater
			// 
			this.gvRequiredOnWater.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn47,
            this.gridColumn48,
            this.gridColumn49,
            this.gridColumn50,
            this.gridColumn51});
			this.gvRequiredOnWater.GridControl = this.gcRequiredOnWater;
			this.gvRequiredOnWater.Name = "gvRequiredOnWater";
			this.gvRequiredOnWater.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvRequiredOnWater.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvRequiredOnWater.OptionsCustomization.AllowFilter = false;
			this.gvRequiredOnWater.OptionsCustomization.AllowGroup = false;
			this.gvRequiredOnWater.OptionsView.ColumnAutoWidth = false;
			this.gvRequiredOnWater.OptionsView.ShowGroupExpandCollapseButtons = false;
			this.gvRequiredOnWater.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn47
			// 
			this.gridColumn47.Caption = "Id";
			this.gridColumn47.FieldName = "Id";
			this.gridColumn47.MinWidth = 25;
			this.gridColumn47.Name = "gridColumn47";
			this.gridColumn47.Width = 87;
			// 
			// gridColumn48
			// 
			this.gridColumn48.Caption = "Required";
			this.gridColumn48.ColumnEdit = this.repCheckEdit;
			this.gridColumn48.FieldName = "IsRequired";
			this.gridColumn48.MinWidth = 25;
			this.gridColumn48.Name = "gridColumn48";
			this.gridColumn48.Visible = true;
			this.gridColumn48.VisibleIndex = 0;
			// 
			// repCheckEdit
			// 
			this.repCheckEdit.AutoHeight = false;
			this.repCheckEdit.Name = "repCheckEdit";
			// 
			// gridColumn49
			// 
			this.gridColumn49.Caption = "Job No";
			this.gridColumn49.FieldName = "JobNo";
			this.gridColumn49.MinWidth = 25;
			this.gridColumn49.Name = "gridColumn49";
			this.gridColumn49.Width = 94;
			// 
			// gridColumn50
			// 
			this.gridColumn50.Caption = "Description";
			this.gridColumn50.FieldName = "Description";
			this.gridColumn50.MinWidth = 25;
			this.gridColumn50.Name = "gridColumn50";
			this.gridColumn50.OptionsColumn.ReadOnly = true;
			this.gridColumn50.Visible = true;
			this.gridColumn50.VisibleIndex = 1;
			this.gridColumn50.Width = 326;
			// 
			// gridColumn51
			// 
			this.gridColumn51.Caption = "FulFilled";
			this.gridColumn51.ColumnEdit = this.repCheckEdit;
			this.gridColumn51.FieldName = "IsFulFilled";
			this.gridColumn51.MinWidth = 25;
			this.gridColumn51.Name = "gridColumn51";
			this.gridColumn51.Visible = true;
			this.gridColumn51.VisibleIndex = 2;
			this.gridColumn51.Width = 94;
			// 
			// gcRequiredToBeLoaded
			// 
			this.gcRequiredToBeLoaded.Location = new System.Drawing.Point(14, 14);
			this.gcRequiredToBeLoaded.MainView = this.gvRequiredToBeLoaded;
			this.gcRequiredToBeLoaded.MenuManager = this.rcMain;
			this.gcRequiredToBeLoaded.Name = "gcRequiredToBeLoaded";
			this.gcRequiredToBeLoaded.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheckBox});
			this.gcRequiredToBeLoaded.Size = new System.Drawing.Size(584, 223);
			this.gcRequiredToBeLoaded.TabIndex = 4;
			this.gcRequiredToBeLoaded.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRequiredToBeLoaded});
			// 
			// gvRequiredToBeLoaded
			// 
			this.gvRequiredToBeLoaded.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn41,
            this.gridColumn45,
            this.gridColumn43,
            this.gridColumn44,
            this.gridColumn46});
			this.gvRequiredToBeLoaded.GridControl = this.gcRequiredToBeLoaded;
			this.gvRequiredToBeLoaded.Name = "gvRequiredToBeLoaded";
			this.gvRequiredToBeLoaded.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvRequiredToBeLoaded.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvRequiredToBeLoaded.OptionsCustomization.AllowFilter = false;
			this.gvRequiredToBeLoaded.OptionsCustomization.AllowGroup = false;
			this.gvRequiredToBeLoaded.OptionsView.ColumnAutoWidth = false;
			this.gvRequiredToBeLoaded.OptionsView.ShowGroupExpandCollapseButtons = false;
			this.gvRequiredToBeLoaded.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn41
			// 
			this.gridColumn41.Caption = "Id";
			this.gridColumn41.FieldName = "Id";
			this.gridColumn41.MinWidth = 25;
			this.gridColumn41.Name = "gridColumn41";
			this.gridColumn41.Width = 87;
			// 
			// gridColumn45
			// 
			this.gridColumn45.Caption = "Required";
			this.gridColumn45.ColumnEdit = this.repCheckBox;
			this.gridColumn45.FieldName = "IsRequired";
			this.gridColumn45.MinWidth = 25;
			this.gridColumn45.Name = "gridColumn45";
			this.gridColumn45.Visible = true;
			this.gridColumn45.VisibleIndex = 0;
			// 
			// repCheckBox
			// 
			this.repCheckBox.AutoHeight = false;
			this.repCheckBox.Name = "repCheckBox";
			// 
			// gridColumn43
			// 
			this.gridColumn43.Caption = "Job No";
			this.gridColumn43.FieldName = "JobNo";
			this.gridColumn43.MinWidth = 25;
			this.gridColumn43.Name = "gridColumn43";
			this.gridColumn43.Width = 94;
			// 
			// gridColumn44
			// 
			this.gridColumn44.Caption = "Description";
			this.gridColumn44.FieldName = "Description";
			this.gridColumn44.MinWidth = 25;
			this.gridColumn44.Name = "gridColumn44";
			this.gridColumn44.OptionsColumn.ReadOnly = true;
			this.gridColumn44.Visible = true;
			this.gridColumn44.VisibleIndex = 1;
			this.gridColumn44.Width = 358;
			// 
			// gridColumn46
			// 
			this.gridColumn46.Caption = "FulFilled";
			this.gridColumn46.ColumnEdit = this.repCheckBox;
			this.gridColumn46.FieldName = "IsFulFilled";
			this.gridColumn46.MinWidth = 25;
			this.gridColumn46.Name = "gridColumn46";
			this.gridColumn46.Visible = true;
			this.gridColumn46.VisibleIndex = 2;
			this.gridColumn46.Width = 65;
			// 
			// layoutControlGroup12
			// 
			this.layoutControlGroup12.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup12.GroupBordersVisible = false;
			this.layoutControlGroup12.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.emptySpaceItem6,
            this.emptySpaceItem8,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.lcAllInOrderToBeloaded,
            this.lcAllInOrderOnWater});
			this.layoutControlGroup12.Name = "layoutControlGroup12";
			this.layoutControlGroup12.Size = new System.Drawing.Size(1420, 251);
			this.layoutControlGroup12.TextVisible = false;
			// 
			// layoutControlItem10
			// 
			this.layoutControlItem10.Control = this.gcRequiredToBeLoaded;
			this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Size = new System.Drawing.Size(588, 227);
			this.layoutControlItem10.TextVisible = false;
			// 
			// layoutControlItem11
			// 
			this.layoutControlItem11.Control = this.gridSplitContainer1;
			this.layoutControlItem11.Location = new System.Drawing.Point(687, 0);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Size = new System.Drawing.Size(610, 227);
			this.layoutControlItem11.TextVisible = false;
			// 
			// emptySpaceItem6
			// 
			this.emptySpaceItem6.Location = new System.Drawing.Point(588, 25);
			this.emptySpaceItem6.Name = "emptySpaceItem4";
			this.emptySpaceItem6.Size = new System.Drawing.Size(99, 171);
			// 
			// emptySpaceItem8
			// 
			this.emptySpaceItem8.Location = new System.Drawing.Point(1297, 25);
			this.emptySpaceItem8.Name = "emptySpaceItem8";
			this.emptySpaceItem8.Size = new System.Drawing.Size(99, 171);
			// 
			// layoutControlItem12
			// 
			this.layoutControlItem12.Control = this.btnAllInOrderTBL;
			this.layoutControlItem12.Location = new System.Drawing.Point(588, 196);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Size = new System.Drawing.Size(99, 31);
			this.layoutControlItem12.TextVisible = false;
			// 
			// layoutControlItem13
			// 
			this.layoutControlItem13.Control = this.btnAllInOrderOW;
			this.layoutControlItem13.Location = new System.Drawing.Point(1297, 196);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Size = new System.Drawing.Size(99, 31);
			this.layoutControlItem13.TextVisible = false;
			// 
			// lcAllInOrderToBeloaded
			// 
			this.lcAllInOrderToBeloaded.Control = this.lblAllInOrderToBeloaded;
			this.lcAllInOrderToBeloaded.Location = new System.Drawing.Point(588, 0);
			this.lcAllInOrderToBeloaded.Name = "lcAllInOrderToBeloaded";
			this.lcAllInOrderToBeloaded.Size = new System.Drawing.Size(99, 25);
			this.lcAllInOrderToBeloaded.TextVisible = false;
			this.lcAllInOrderToBeloaded.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
			// 
			// lcAllInOrderOnWater
			// 
			this.lcAllInOrderOnWater.Control = this.lblAllInOrderOnWater;
			this.lcAllInOrderOnWater.Location = new System.Drawing.Point(1297, 0);
			this.lcAllInOrderOnWater.Name = "lcAllInOrderOnWater";
			this.lcAllInOrderOnWater.Size = new System.Drawing.Size(99, 25);
			this.lcAllInOrderOnWater.TextVisible = false;
			this.lcAllInOrderOnWater.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
			// 
			// tabSellingGroup
			// 
			this.tabSellingGroup.Caption = "Invoices";
			this.tabSellingGroup.Controls.Add(this.layoutInvoicesGrid);
			this.tabSellingGroup.Name = "tabSellingGroup";
			this.tabSellingGroup.Size = new System.Drawing.Size(1420, 251);
			// 
			// layoutInvoicesGrid
			// 
			this.layoutInvoicesGrid.Controls.Add(this.gcInvoices);
			this.layoutInvoicesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutInvoicesGrid.Location = new System.Drawing.Point(0, 0);
			this.layoutInvoicesGrid.Name = "layoutInvoicesGrid";
			this.layoutInvoicesGrid.Root = this.layoutControlGroup3;
			this.layoutInvoicesGrid.Size = new System.Drawing.Size(1420, 251);
			this.layoutInvoicesGrid.TabIndex = 0;
			this.layoutInvoicesGrid.Text = "layoutControl1";
			// 
			// gcInvoices
			// 
			this.gcInvoices.DataSource = this.bsInvoices;
			this.gcInvoices.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcInvoices.Location = new System.Drawing.Point(14, 14);
			this.gcInvoices.MainView = this.gvInvoices;
			this.gcInvoices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcInvoices.Name = "gcInvoices";
			this.gcInvoices.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSellingItemsList,
            this.repSellingCurrenciesList,
            this.repSellingPayemntsList,
            this.repSellingMemberList});
			this.gcInvoices.Size = new System.Drawing.Size(1392, 223);
			this.gcInvoices.TabIndex = 4;
			this.gcInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInvoices});
			// 
			// gvInvoices
			// 
			this.gvInvoices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSellingId,
            this.colSellingQHeaderId,
            this.colSellingCustomerId,
            this.colSellingItemId,
            this.colSellingDescription,
            this.colSellingPaymentId,
            this.colSellingCurrencyId,
            this.colSellingRate,
            this.colSellingAmount,
            this.colSellingL_Amount,
            this.colSellingF_Amount,
            this.colSellingVat,
            this.colSellingVatRate,
            this.colSellingNotes,
            this.colSellingDeleted,
            this.colSellingVatAmountLL,
            this.colSellingVatAmountUSD,
            this.colSellingVatAmount});
			this.gvInvoices.DetailHeight = 431;
			this.gvInvoices.GridControl = this.gcInvoices;
			this.gvInvoices.Name = "gvInvoices";
			this.gvInvoices.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvInvoices.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvInvoices.OptionsBehavior.Editable = false;
			this.gvInvoices.OptionsBehavior.ReadOnly = true;
			this.gvInvoices.OptionsNavigation.AutoFocusNewRow = true;
			this.gvInvoices.OptionsNavigation.EnterMoveNextColumn = true;
			this.gvInvoices.OptionsPrint.AutoWidth = false;
			this.gvInvoices.OptionsView.ColumnAutoWidth = false;
			this.gvInvoices.OptionsView.ShowFooter = true;
			this.gvInvoices.OptionsView.ShowGroupPanel = false;
			// 
			// colSellingId
			// 
			this.colSellingId.Caption = "Id";
			this.colSellingId.FieldName = "Id";
			this.colSellingId.MinWidth = 25;
			this.colSellingId.Name = "colSellingId";
			this.colSellingId.OptionsColumn.TabStop = false;
			this.colSellingId.Width = 76;
			// 
			// colSellingQHeaderId
			// 
			this.colSellingQHeaderId.Caption = "QHeaderId";
			this.colSellingQHeaderId.FieldName = "QHeaderId";
			this.colSellingQHeaderId.MinWidth = 25;
			this.colSellingQHeaderId.Name = "colSellingQHeaderId";
			this.colSellingQHeaderId.OptionsColumn.TabStop = false;
			this.colSellingQHeaderId.Width = 94;
			// 
			// colSellingCustomerId
			// 
			this.colSellingCustomerId.Caption = "Customer Name";
			this.colSellingCustomerId.ColumnEdit = this.repSellingMemberList;
			this.colSellingCustomerId.FieldName = "MemberId";
			this.colSellingCustomerId.MinWidth = 25;
			this.colSellingCustomerId.Name = "colSellingCustomerId";
			this.colSellingCustomerId.OptionsColumn.TabStop = false;
			this.colSellingCustomerId.Visible = true;
			this.colSellingCustomerId.VisibleIndex = 0;
			this.colSellingCustomerId.Width = 148;
			// 
			// repSellingMemberList
			// 
			this.repSellingMemberList.AutoHeight = false;
			this.repSellingMemberList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repSellingMemberList.DisplayMember = "CustomerName";
			this.repSellingMemberList.Name = "repSellingMemberList";
			this.repSellingMemberList.NullText = "";
			this.repSellingMemberList.PopupView = this.repositoryItemSearchLookUpEdit1View;
			this.repSellingMemberList.ValueMember = "Id";
			// 
			// repositoryItemSearchLookUpEdit1View
			// 
			this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSellingMemberNameId,
            this.colSellingMemberName});
			this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
			this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// colSellingMemberNameId
			// 
			this.colSellingMemberNameId.Caption = "Id";
			this.colSellingMemberNameId.FieldName = "Id";
			this.colSellingMemberNameId.Name = "colSellingMemberNameId";
			this.colSellingMemberNameId.Visible = true;
			this.colSellingMemberNameId.VisibleIndex = 0;
			this.colSellingMemberNameId.Width = 122;
			// 
			// colSellingMemberName
			// 
			this.colSellingMemberName.Caption = "Customer Name";
			this.colSellingMemberName.FieldName = "CustomerName";
			this.colSellingMemberName.Name = "colSellingMemberName";
			this.colSellingMemberName.Visible = true;
			this.colSellingMemberName.VisibleIndex = 1;
			this.colSellingMemberName.Width = 1116;
			// 
			// colSellingItemId
			// 
			this.colSellingItemId.Caption = "Item";
			this.colSellingItemId.ColumnEdit = this.repSellingItemsList;
			this.colSellingItemId.FieldName = "ItemId";
			this.colSellingItemId.MinWidth = 25;
			this.colSellingItemId.Name = "colSellingItemId";
			this.colSellingItemId.Visible = true;
			this.colSellingItemId.VisibleIndex = 1;
			this.colSellingItemId.Width = 79;
			// 
			// repSellingItemsList
			// 
			this.repSellingItemsList.AutoHeight = false;
			this.repSellingItemsList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repSellingItemsList.DisplayMember = "ItemCode";
			this.repSellingItemsList.Name = "repSellingItemsList";
			this.repSellingItemsList.NullText = "";
			this.repSellingItemsList.PopupView = this.gridView8;
			this.repSellingItemsList.ValueMember = "Id";
			// 
			// gridView8
			// 
			this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemId,
            this.gridColumn2,
            this.gridColumn3});
			this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView8.Name = "gridView8";
			this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView8.OptionsView.ShowGroupPanel = false;
			// 
			// colItemId
			// 
			this.colItemId.Caption = "Id";
			this.colItemId.FieldName = "Id";
			this.colItemId.Name = "colItemId";
			this.colItemId.Visible = true;
			this.colItemId.VisibleIndex = 0;
			this.colItemId.Width = 74;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Code";
			this.gridColumn2.FieldName = "ItemCode";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			this.gridColumn2.Width = 106;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Name";
			this.gridColumn3.FieldName = "Description";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			this.gridColumn3.Width = 742;
			// 
			// colSellingDescription
			// 
			this.colSellingDescription.Caption = "Description";
			this.colSellingDescription.FieldName = "Description";
			this.colSellingDescription.MinWidth = 25;
			this.colSellingDescription.Name = "colSellingDescription";
			this.colSellingDescription.Visible = true;
			this.colSellingDescription.VisibleIndex = 2;
			this.colSellingDescription.Width = 225;
			// 
			// colSellingPaymentId
			// 
			this.colSellingPaymentId.Caption = "Payment";
			this.colSellingPaymentId.ColumnEdit = this.repSellingPayemntsList;
			this.colSellingPaymentId.FieldName = "PaymentId";
			this.colSellingPaymentId.MinWidth = 25;
			this.colSellingPaymentId.Name = "colSellingPaymentId";
			this.colSellingPaymentId.OptionsColumn.TabStop = false;
			this.colSellingPaymentId.Visible = true;
			this.colSellingPaymentId.VisibleIndex = 3;
			this.colSellingPaymentId.Width = 94;
			// 
			// repSellingPayemntsList
			// 
			this.repSellingPayemntsList.AutoHeight = false;
			this.repSellingPayemntsList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repSellingPayemntsList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repSellingPayemntsList.DisplayMember = "Description";
			this.repSellingPayemntsList.Name = "repSellingPayemntsList";
			this.repSellingPayemntsList.NullText = "";
			this.repSellingPayemntsList.ValueMember = "Id";
			// 
			// colSellingCurrencyId
			// 
			this.colSellingCurrencyId.Caption = "Currency";
			this.colSellingCurrencyId.ColumnEdit = this.repSellingCurrenciesList;
			this.colSellingCurrencyId.FieldName = "CurrencyId";
			this.colSellingCurrencyId.MinWidth = 25;
			this.colSellingCurrencyId.Name = "colSellingCurrencyId";
			this.colSellingCurrencyId.OptionsColumn.TabStop = false;
			this.colSellingCurrencyId.Visible = true;
			this.colSellingCurrencyId.VisibleIndex = 4;
			this.colSellingCurrencyId.Width = 94;
			// 
			// repSellingCurrenciesList
			// 
			this.repSellingCurrenciesList.AutoHeight = false;
			this.repSellingCurrenciesList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repSellingCurrenciesList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCode", "Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repSellingCurrenciesList.DisplayMember = "CurrencyCode";
			this.repSellingCurrenciesList.Name = "repSellingCurrenciesList";
			this.repSellingCurrenciesList.NullText = "";
			this.repSellingCurrenciesList.ValueMember = "Id";
			// 
			// colSellingRate
			// 
			this.colSellingRate.Caption = "Rate";
			this.colSellingRate.DisplayFormat.FormatString = "n";
			this.colSellingRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSellingRate.FieldName = "Rate";
			this.colSellingRate.MinWidth = 25;
			this.colSellingRate.Name = "colSellingRate";
			this.colSellingRate.OptionsColumn.TabStop = false;
			this.colSellingRate.Visible = true;
			this.colSellingRate.VisibleIndex = 5;
			this.colSellingRate.Width = 94;
			// 
			// colSellingAmount
			// 
			this.colSellingAmount.Caption = "Amount";
			this.colSellingAmount.DisplayFormat.FormatString = "n";
			this.colSellingAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSellingAmount.FieldName = "Amount";
			this.colSellingAmount.MinWidth = 25;
			this.colSellingAmount.Name = "colSellingAmount";
			this.colSellingAmount.Visible = true;
			this.colSellingAmount.VisibleIndex = 6;
			this.colSellingAmount.Width = 100;
			// 
			// colSellingL_Amount
			// 
			this.colSellingL_Amount.Caption = "L.L.";
			this.colSellingL_Amount.DisplayFormat.FormatString = "{0:n2}";
			this.colSellingL_Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSellingL_Amount.FieldName = "LocalAmount";
			this.colSellingL_Amount.MinWidth = 25;
			this.colSellingL_Amount.Name = "colSellingL_Amount";
			this.colSellingL_Amount.OptionsColumn.ReadOnly = true;
			this.colSellingL_Amount.OptionsColumn.TabStop = false;
			this.colSellingL_Amount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "LocalAmount", "{0:n2}", "1")});
			this.colSellingL_Amount.Visible = true;
			this.colSellingL_Amount.VisibleIndex = 7;
			this.colSellingL_Amount.Width = 170;
			// 
			// colSellingF_Amount
			// 
			this.colSellingF_Amount.Caption = "USD";
			this.colSellingF_Amount.DisplayFormat.FormatString = "{0:n2}";
			this.colSellingF_Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSellingF_Amount.FieldName = "ForeignAmount";
			this.colSellingF_Amount.MinWidth = 25;
			this.colSellingF_Amount.Name = "colSellingF_Amount";
			this.colSellingF_Amount.OptionsColumn.ReadOnly = true;
			this.colSellingF_Amount.OptionsColumn.TabStop = false;
			this.colSellingF_Amount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "ForeignAmount", "{0:n2}", "2")});
			this.colSellingF_Amount.Visible = true;
			this.colSellingF_Amount.VisibleIndex = 8;
			this.colSellingF_Amount.Width = 170;
			// 
			// colSellingVat
			// 
			this.colSellingVat.Caption = "VAT";
			this.colSellingVat.FieldName = "Vat";
			this.colSellingVat.MinWidth = 25;
			this.colSellingVat.Name = "colSellingVat";
			this.colSellingVat.OptionsColumn.TabStop = false;
			this.colSellingVat.Visible = true;
			this.colSellingVat.VisibleIndex = 9;
			this.colSellingVat.Width = 94;
			// 
			// colSellingVatRate
			// 
			this.colSellingVatRate.Caption = "VAT Rate";
			this.colSellingVatRate.DisplayFormat.FormatString = "{0:n2}%";
			this.colSellingVatRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colSellingVatRate.FieldName = "VatRate";
			this.colSellingVatRate.MinWidth = 25;
			this.colSellingVatRate.Name = "colSellingVatRate";
			this.colSellingVatRate.OptionsColumn.TabStop = false;
			this.colSellingVatRate.Visible = true;
			this.colSellingVatRate.VisibleIndex = 10;
			this.colSellingVatRate.Width = 94;
			// 
			// colSellingNotes
			// 
			this.colSellingNotes.Caption = "Notes";
			this.colSellingNotes.FieldName = "Notes";
			this.colSellingNotes.MinWidth = 25;
			this.colSellingNotes.Name = "colSellingNotes";
			this.colSellingNotes.Visible = true;
			this.colSellingNotes.VisibleIndex = 11;
			this.colSellingNotes.Width = 364;
			// 
			// colSellingDeleted
			// 
			this.colSellingDeleted.Caption = "Deleted";
			this.colSellingDeleted.FieldName = "Deleted";
			this.colSellingDeleted.MinWidth = 25;
			this.colSellingDeleted.Name = "colSellingDeleted";
			this.colSellingDeleted.Width = 94;
			// 
			// colSellingVatAmountLL
			// 
			this.colSellingVatAmountLL.Caption = "Vat Amount LL";
			this.colSellingVatAmountLL.DisplayFormat.FormatString = "{0:n2}";
			this.colSellingVatAmountLL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSellingVatAmountLL.FieldName = "LocalVatAmount";
			this.colSellingVatAmountLL.MinWidth = 25;
			this.colSellingVatAmountLL.Name = "colSellingVatAmountLL";
			this.colSellingVatAmountLL.OptionsColumn.ReadOnly = true;
			this.colSellingVatAmountLL.OptionsColumn.TabStop = false;
			this.colSellingVatAmountLL.Visible = true;
			this.colSellingVatAmountLL.VisibleIndex = 12;
			this.colSellingVatAmountLL.Width = 170;
			// 
			// colSellingVatAmountUSD
			// 
			this.colSellingVatAmountUSD.Caption = "Vat Amount USD";
			this.colSellingVatAmountUSD.DisplayFormat.FormatString = "{0:n2}";
			this.colSellingVatAmountUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSellingVatAmountUSD.FieldName = "ForeignVatAmount";
			this.colSellingVatAmountUSD.MinWidth = 25;
			this.colSellingVatAmountUSD.Name = "colSellingVatAmountUSD";
			this.colSellingVatAmountUSD.OptionsColumn.ReadOnly = true;
			this.colSellingVatAmountUSD.OptionsColumn.TabStop = false;
			this.colSellingVatAmountUSD.Visible = true;
			this.colSellingVatAmountUSD.VisibleIndex = 13;
			this.colSellingVatAmountUSD.Width = 170;
			// 
			// colSellingVatAmount
			// 
			this.colSellingVatAmount.Caption = "Vat Amount";
			this.colSellingVatAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colSellingVatAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSellingVatAmount.FieldName = "VatAmount";
			this.colSellingVatAmount.MinWidth = 25;
			this.colSellingVatAmount.Name = "colSellingVatAmount";
			this.colSellingVatAmount.OptionsColumn.ReadOnly = true;
			this.colSellingVatAmount.OptionsColumn.TabStop = false;
			this.colSellingVatAmount.Visible = true;
			this.colSellingVatAmount.VisibleIndex = 14;
			this.colSellingVatAmount.Width = 170;
			// 
			// layoutControlGroup3
			// 
			this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup3.GroupBordersVisible = false;
			this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
			this.layoutControlGroup3.Name = "layoutControlGroup3";
			this.layoutControlGroup3.Size = new System.Drawing.Size(1420, 251);
			this.layoutControlGroup3.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.gcInvoices;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(1396, 227);
			this.layoutControlItem3.TextVisible = false;
			// 
			// tabCostGroup
			// 
			this.tabCostGroup.Caption = "Cost Sheets";
			this.tabCostGroup.Controls.Add(this.layoutCostSheetsGrid);
			this.tabCostGroup.Name = "tabCostGroup";
			this.tabCostGroup.Size = new System.Drawing.Size(1424, 242);
			// 
			// layoutCostSheetsGrid
			// 
			this.layoutCostSheetsGrid.Controls.Add(this.gcCosts);
			this.layoutCostSheetsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutCostSheetsGrid.Location = new System.Drawing.Point(0, 0);
			this.layoutCostSheetsGrid.Name = "layoutCostSheetsGrid";
			this.layoutCostSheetsGrid.Root = this.layoutControlGroup4;
			this.layoutCostSheetsGrid.Size = new System.Drawing.Size(1424, 242);
			this.layoutCostSheetsGrid.TabIndex = 0;
			this.layoutCostSheetsGrid.Text = "layoutControl1";
			// 
			// gcCosts
			// 
			this.gcCosts.DataSource = this.bsCosts;
			this.gcCosts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcCosts.Location = new System.Drawing.Point(14, 14);
			this.gcCosts.MainView = this.gvCosts;
			this.gcCosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcCosts.Name = "gcCosts";
			this.gcCosts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCostAgents,
            this.repCostItemsList,
            this.repCostMethodofPaymentList,
            this.repCostCurrenciesList});
			this.gcCosts.Size = new System.Drawing.Size(1396, 214);
			this.gcCosts.TabIndex = 4;
			this.gcCosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCosts});
			// 
			// gvCosts
			// 
			this.gvCosts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCostId,
            this.colCostQHeaderId,
            this.colCostItemId,
            this.colCostDescription,
            this.colCostAgentName,
            this.colCostPaymentId,
            this.colCostCurrencyId,
            this.colCostRate,
            this.colCostAmount,
            this.colCostL_Amount,
            this.colCostF_Amount,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.colCostVat,
            this.colCostVatRate,
            this.colCostNotes,
            this.colCostVatAmountLL,
            this.colCostVatAmountUSD,
            this.colCostVatAmount,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.colCostDeleted});
			this.gvCosts.DetailHeight = 431;
			this.gvCosts.GridControl = this.gcCosts;
			this.gvCosts.Name = "gvCosts";
			this.gvCosts.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvCosts.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvCosts.OptionsBehavior.Editable = false;
			this.gvCosts.OptionsBehavior.ReadOnly = true;
			this.gvCosts.OptionsNavigation.AutoFocusNewRow = true;
			this.gvCosts.OptionsNavigation.EnterMoveNextColumn = true;
			this.gvCosts.OptionsPrint.AutoWidth = false;
			this.gvCosts.OptionsView.ColumnAutoWidth = false;
			this.gvCosts.OptionsView.ShowFooter = true;
			this.gvCosts.OptionsView.ShowGroupPanel = false;
			// 
			// colCostId
			// 
			this.colCostId.Caption = "Id";
			this.colCostId.FieldName = "Id";
			this.colCostId.MinWidth = 25;
			this.colCostId.Name = "colCostId";
			this.colCostId.OptionsColumn.TabStop = false;
			this.colCostId.Width = 76;
			// 
			// colCostQHeaderId
			// 
			this.colCostQHeaderId.Caption = "QHeaderId";
			this.colCostQHeaderId.FieldName = "QHeaderId";
			this.colCostQHeaderId.MinWidth = 25;
			this.colCostQHeaderId.Name = "colCostQHeaderId";
			this.colCostQHeaderId.OptionsColumn.TabStop = false;
			this.colCostQHeaderId.Width = 94;
			// 
			// colCostItemId
			// 
			this.colCostItemId.Caption = "Item";
			this.colCostItemId.ColumnEdit = this.repCostItemsList;
			this.colCostItemId.FieldName = "ItemId";
			this.colCostItemId.MinWidth = 25;
			this.colCostItemId.Name = "colCostItemId";
			this.colCostItemId.Visible = true;
			this.colCostItemId.VisibleIndex = 0;
			this.colCostItemId.Width = 97;
			// 
			// repCostItemsList
			// 
			this.repCostItemsList.AutoHeight = false;
			this.repCostItemsList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCostItemsList.DisplayMember = "ItemCode";
			this.repCostItemsList.Name = "repCostItemsList";
			this.repCostItemsList.NullText = "";
			this.repCostItemsList.PopupView = this.gridView9;
			this.repCostItemsList.ValueMember = "Id";
			// 
			// gridView9
			// 
			this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn25,
            this.gridColumn26,
            this.gridColumn27});
			this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView9.Name = "gridView9";
			this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView9.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn25
			// 
			this.gridColumn25.FieldName = "Id";
			this.gridColumn25.Name = "gridColumn25";
			this.gridColumn25.Visible = true;
			this.gridColumn25.VisibleIndex = 0;
			this.gridColumn25.Width = 65;
			// 
			// gridColumn26
			// 
			this.gridColumn26.FieldName = "ItemCode";
			this.gridColumn26.Name = "gridColumn26";
			this.gridColumn26.Visible = true;
			this.gridColumn26.VisibleIndex = 1;
			this.gridColumn26.Width = 80;
			// 
			// gridColumn27
			// 
			this.gridColumn27.FieldName = "Description";
			this.gridColumn27.Name = "gridColumn27";
			this.gridColumn27.Visible = true;
			this.gridColumn27.VisibleIndex = 2;
			this.gridColumn27.Width = 777;
			// 
			// colCostDescription
			// 
			this.colCostDescription.Caption = "Description";
			this.colCostDescription.FieldName = "Description";
			this.colCostDescription.MinWidth = 25;
			this.colCostDescription.Name = "colCostDescription";
			this.colCostDescription.Visible = true;
			this.colCostDescription.VisibleIndex = 1;
			this.colCostDescription.Width = 216;
			// 
			// colCostAgentName
			// 
			this.colCostAgentName.Caption = "Agent Name";
			this.colCostAgentName.ColumnEdit = this.repCostAgents;
			this.colCostAgentName.FieldName = "AgentId";
			this.colCostAgentName.MinWidth = 25;
			this.colCostAgentName.Name = "colCostAgentName";
			this.colCostAgentName.Visible = true;
			this.colCostAgentName.VisibleIndex = 2;
			this.colCostAgentName.Width = 141;
			// 
			// repCostAgents
			// 
			this.repCostAgents.AutoHeight = false;
			this.repCostAgents.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCostAgents.DisplayMember = "AgentName";
			this.repCostAgents.Name = "repCostAgents";
			this.repCostAgents.NullText = "";
			this.repCostAgents.PopupView = this.repositoryItemSearchLookUpEdit2View;
			this.repCostAgents.ValueMember = "Id";
			// 
			// repositoryItemSearchLookUpEdit2View
			// 
			this.repositoryItemSearchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAgentID,
            this.colAgentName});
			this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
			this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
			// 
			// colAgentID
			// 
			this.colAgentID.Caption = "Id";
			this.colAgentID.FieldName = "Id";
			this.colAgentID.Name = "colAgentID";
			this.colAgentID.Visible = true;
			this.colAgentID.VisibleIndex = 0;
			this.colAgentID.Width = 118;
			// 
			// colAgentName
			// 
			this.colAgentName.Caption = "Member Name";
			this.colAgentName.FieldName = "AgentName";
			this.colAgentName.Name = "colAgentName";
			this.colAgentName.Visible = true;
			this.colAgentName.VisibleIndex = 1;
			this.colAgentName.Width = 1120;
			// 
			// colCostPaymentId
			// 
			this.colCostPaymentId.Caption = "Payment";
			this.colCostPaymentId.ColumnEdit = this.repCostMethodofPaymentList;
			this.colCostPaymentId.FieldName = "PaymentId";
			this.colCostPaymentId.MinWidth = 25;
			this.colCostPaymentId.Name = "colCostPaymentId";
			this.colCostPaymentId.OptionsColumn.TabStop = false;
			this.colCostPaymentId.Visible = true;
			this.colCostPaymentId.VisibleIndex = 3;
			this.colCostPaymentId.Width = 94;
			// 
			// repCostMethodofPaymentList
			// 
			this.repCostMethodofPaymentList.AutoHeight = false;
			this.repCostMethodofPaymentList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCostMethodofPaymentList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description")});
			this.repCostMethodofPaymentList.DisplayMember = "Description";
			this.repCostMethodofPaymentList.Name = "repCostMethodofPaymentList";
			this.repCostMethodofPaymentList.NullText = "";
			this.repCostMethodofPaymentList.ValueMember = "Id";
			// 
			// colCostCurrencyId
			// 
			this.colCostCurrencyId.Caption = "Currency";
			this.colCostCurrencyId.ColumnEdit = this.repCostCurrenciesList;
			this.colCostCurrencyId.FieldName = "CurrencyId";
			this.colCostCurrencyId.MinWidth = 25;
			this.colCostCurrencyId.Name = "colCostCurrencyId";
			this.colCostCurrencyId.OptionsColumn.TabStop = false;
			this.colCostCurrencyId.Visible = true;
			this.colCostCurrencyId.VisibleIndex = 4;
			this.colCostCurrencyId.Width = 94;
			// 
			// repCostCurrenciesList
			// 
			this.repCostCurrenciesList.AutoHeight = false;
			this.repCostCurrenciesList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCostCurrenciesList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCode", "Currency"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "Name")});
			this.repCostCurrenciesList.DisplayMember = "CurrencyCode";
			this.repCostCurrenciesList.Name = "repCostCurrenciesList";
			this.repCostCurrenciesList.NullText = "";
			this.repCostCurrenciesList.ValueMember = "Id";
			// 
			// colCostRate
			// 
			this.colCostRate.Caption = "Rate";
			this.colCostRate.DisplayFormat.FormatString = "n";
			this.colCostRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colCostRate.FieldName = "Rate";
			this.colCostRate.MinWidth = 25;
			this.colCostRate.Name = "colCostRate";
			this.colCostRate.OptionsColumn.TabStop = false;
			this.colCostRate.Visible = true;
			this.colCostRate.VisibleIndex = 5;
			this.colCostRate.Width = 94;
			// 
			// colCostAmount
			// 
			this.colCostAmount.Caption = "Amount";
			this.colCostAmount.DisplayFormat.FormatString = "n";
			this.colCostAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colCostAmount.FieldName = "Amount";
			this.colCostAmount.MinWidth = 25;
			this.colCostAmount.Name = "colCostAmount";
			this.colCostAmount.Visible = true;
			this.colCostAmount.VisibleIndex = 6;
			this.colCostAmount.Width = 100;
			// 
			// colCostL_Amount
			// 
			this.colCostL_Amount.Caption = "L.L.";
			this.colCostL_Amount.DisplayFormat.FormatString = "{0:n2}";
			this.colCostL_Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colCostL_Amount.FieldName = "LocalAmount";
			this.colCostL_Amount.GroupFormat.FormatString = "n";
			this.colCostL_Amount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colCostL_Amount.MinWidth = 25;
			this.colCostL_Amount.Name = "colCostL_Amount";
			this.colCostL_Amount.OptionsColumn.ReadOnly = true;
			this.colCostL_Amount.OptionsColumn.TabStop = false;
			this.colCostL_Amount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "LocalAmount", "{0:n2}", "1")});
			this.colCostL_Amount.Visible = true;
			this.colCostL_Amount.VisibleIndex = 7;
			this.colCostL_Amount.Width = 170;
			// 
			// colCostF_Amount
			// 
			this.colCostF_Amount.Caption = "USD";
			this.colCostF_Amount.DisplayFormat.FormatString = "{0:n2}";
			this.colCostF_Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colCostF_Amount.FieldName = "ForeignAmount";
			this.colCostF_Amount.MinWidth = 25;
			this.colCostF_Amount.Name = "colCostF_Amount";
			this.colCostF_Amount.OptionsColumn.ReadOnly = true;
			this.colCostF_Amount.OptionsColumn.TabStop = false;
			this.colCostF_Amount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "ForeignAmount", "{0:n2}", "2")});
			this.colCostF_Amount.Visible = true;
			this.colCostF_Amount.VisibleIndex = 8;
			this.colCostF_Amount.Width = 170;
			// 
			// gridColumn7
			// 
			this.gridColumn7.Caption = "Provision Amount";
			this.gridColumn7.DisplayFormat.FormatString = "{0:n2}";
			this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.gridColumn7.FieldName = "ProvisionAmount";
			this.gridColumn7.MinWidth = 25;
			this.gridColumn7.Name = "gridColumn7";
			this.gridColumn7.OptionsEditForm.VisibleIndex = 9;
			this.gridColumn7.Visible = true;
			this.gridColumn7.VisibleIndex = 9;
			this.gridColumn7.Width = 128;
			// 
			// gridColumn8
			// 
			this.gridColumn8.Caption = "Provision LL";
			this.gridColumn8.DisplayFormat.FormatString = "{0:n2}";
			this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.gridColumn8.FieldName = "ProvisionAmountLL";
			this.gridColumn8.MinWidth = 25;
			this.gridColumn8.Name = "gridColumn8";
			this.gridColumn8.OptionsColumn.ReadOnly = true;
			this.gridColumn8.OptionsColumn.TabStop = false;
			this.gridColumn8.OptionsEditForm.VisibleIndex = 10;
			this.gridColumn8.Visible = true;
			this.gridColumn8.VisibleIndex = 10;
			this.gridColumn8.Width = 124;
			// 
			// gridColumn9
			// 
			this.gridColumn9.Caption = "Provision USD";
			this.gridColumn9.DisplayFormat.FormatString = "{0:n2}";
			this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.gridColumn9.FieldName = "ProvisionAmountUSD";
			this.gridColumn9.MinWidth = 25;
			this.gridColumn9.Name = "gridColumn9";
			this.gridColumn9.OptionsColumn.ReadOnly = true;
			this.gridColumn9.OptionsColumn.TabStop = false;
			this.gridColumn9.OptionsEditForm.VisibleIndex = 11;
			this.gridColumn9.Visible = true;
			this.gridColumn9.VisibleIndex = 11;
			this.gridColumn9.Width = 124;
			// 
			// colCostVat
			// 
			this.colCostVat.Caption = "VAT";
			this.colCostVat.FieldName = "Vat";
			this.colCostVat.MinWidth = 25;
			this.colCostVat.Name = "colCostVat";
			this.colCostVat.OptionsColumn.TabStop = false;
			this.colCostVat.Visible = true;
			this.colCostVat.VisibleIndex = 12;
			this.colCostVat.Width = 94;
			// 
			// colCostVatRate
			// 
			this.colCostVatRate.Caption = "VAT Rate";
			this.colCostVatRate.DisplayFormat.FormatString = "{0:n2}%";
			this.colCostVatRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colCostVatRate.FieldName = "VatRate";
			this.colCostVatRate.MinWidth = 25;
			this.colCostVatRate.Name = "colCostVatRate";
			this.colCostVatRate.OptionsColumn.TabStop = false;
			this.colCostVatRate.Visible = true;
			this.colCostVatRate.VisibleIndex = 13;
			this.colCostVatRate.Width = 94;
			// 
			// colCostNotes
			// 
			this.colCostNotes.Caption = "Notes";
			this.colCostNotes.FieldName = "Notes";
			this.colCostNotes.MinWidth = 25;
			this.colCostNotes.Name = "colCostNotes";
			this.colCostNotes.Visible = true;
			this.colCostNotes.VisibleIndex = 14;
			this.colCostNotes.Width = 389;
			// 
			// colCostVatAmountLL
			// 
			this.colCostVatAmountLL.Caption = "Vat Amount LL";
			this.colCostVatAmountLL.DisplayFormat.FormatString = "{0:n2}";
			this.colCostVatAmountLL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colCostVatAmountLL.FieldName = "LocalVatAmount";
			this.colCostVatAmountLL.MinWidth = 25;
			this.colCostVatAmountLL.Name = "colCostVatAmountLL";
			this.colCostVatAmountLL.OptionsColumn.ReadOnly = true;
			this.colCostVatAmountLL.OptionsColumn.TabStop = false;
			this.colCostVatAmountLL.Visible = true;
			this.colCostVatAmountLL.VisibleIndex = 15;
			this.colCostVatAmountLL.Width = 170;
			// 
			// colCostVatAmountUSD
			// 
			this.colCostVatAmountUSD.Caption = "Vat Amount USD";
			this.colCostVatAmountUSD.DisplayFormat.FormatString = "{0:n2}";
			this.colCostVatAmountUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colCostVatAmountUSD.FieldName = "ForeignVatAmount";
			this.colCostVatAmountUSD.MinWidth = 25;
			this.colCostVatAmountUSD.Name = "colCostVatAmountUSD";
			this.colCostVatAmountUSD.OptionsColumn.ReadOnly = true;
			this.colCostVatAmountUSD.OptionsColumn.TabStop = false;
			this.colCostVatAmountUSD.Visible = true;
			this.colCostVatAmountUSD.VisibleIndex = 16;
			this.colCostVatAmountUSD.Width = 170;
			// 
			// colCostVatAmount
			// 
			this.colCostVatAmount.Caption = "Vat Amount";
			this.colCostVatAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colCostVatAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colCostVatAmount.FieldName = "VatAmount";
			this.colCostVatAmount.MinWidth = 25;
			this.colCostVatAmount.Name = "colCostVatAmount";
			this.colCostVatAmount.OptionsColumn.ReadOnly = true;
			this.colCostVatAmount.OptionsColumn.TabStop = false;
			this.colCostVatAmount.Visible = true;
			this.colCostVatAmount.VisibleIndex = 17;
			this.colCostVatAmount.Width = 170;
			// 
			// gridColumn10
			// 
			this.gridColumn10.Caption = "Provision VAT Amount";
			this.gridColumn10.FieldName = "ProvisionVATAmount";
			this.gridColumn10.MinWidth = 25;
			this.gridColumn10.Name = "gridColumn10";
			this.gridColumn10.OptionsColumn.TabStop = false;
			this.gridColumn10.Width = 139;
			// 
			// gridColumn11
			// 
			this.gridColumn11.Caption = "Provision VAT LL";
			this.gridColumn11.FieldName = "ProvisionVATAmountLL";
			this.gridColumn11.MinWidth = 25;
			this.gridColumn11.Name = "gridColumn11";
			this.gridColumn11.OptionsColumn.ReadOnly = true;
			this.gridColumn11.OptionsColumn.TabStop = false;
			this.gridColumn11.Width = 107;
			// 
			// gridColumn12
			// 
			this.gridColumn12.Caption = "Provision VAT USD";
			this.gridColumn12.FieldName = "ProvisionVATAmountUSD";
			this.gridColumn12.MinWidth = 25;
			this.gridColumn12.Name = "gridColumn12";
			this.gridColumn12.OptionsColumn.ReadOnly = true;
			this.gridColumn12.OptionsColumn.TabStop = false;
			this.gridColumn12.Width = 119;
			// 
			// colCostDeleted
			// 
			this.colCostDeleted.Caption = "Deleted";
			this.colCostDeleted.FieldName = "Deleted";
			this.colCostDeleted.MinWidth = 25;
			this.colCostDeleted.Name = "colCostDeleted";
			this.colCostDeleted.Width = 94;
			// 
			// layoutControlGroup4
			// 
			this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup4.GroupBordersVisible = false;
			this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
			this.layoutControlGroup4.Name = "layoutControlGroup4";
			this.layoutControlGroup4.Size = new System.Drawing.Size(1424, 242);
			this.layoutControlGroup4.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.gcCosts;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(1400, 218);
			this.layoutControlItem4.TextVisible = false;
			// 
			// tabDocuments
			// 
			this.tabDocuments.Caption = "Attached Documents";
			this.tabDocuments.Controls.Add(this.layoutAttachedDocumnets);
			this.tabDocuments.Name = "tabDocuments";
			this.tabDocuments.Size = new System.Drawing.Size(1420, 251);
			// 
			// layoutAttachedDocumnets
			// 
			this.layoutAttachedDocumnets.Controls.Add(this.gcDocuments);
			this.layoutAttachedDocumnets.Controls.Add(this.openDocuments);
			this.layoutAttachedDocumnets.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutAttachedDocumnets.Location = new System.Drawing.Point(0, 0);
			this.layoutAttachedDocumnets.Name = "layoutAttachedDocumnets";
			this.layoutAttachedDocumnets.Root = this.layoutControlGroup5;
			this.layoutAttachedDocumnets.Size = new System.Drawing.Size(1420, 251);
			this.layoutAttachedDocumnets.TabIndex = 0;
			this.layoutAttachedDocumnets.Text = "layoutControl1";
			// 
			// gcDocuments
			// 
			this.gcDocuments.DataSource = this.bsDocuments;
			this.gcDocuments.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
			this.gcDocuments.Location = new System.Drawing.Point(14, 48);
			this.gcDocuments.MainView = this.gvDocuments;
			this.gcDocuments.Margin = new System.Windows.Forms.Padding(4);
			this.gcDocuments.Name = "gcDocuments";
			this.gcDocuments.Size = new System.Drawing.Size(1392, 189);
			this.gcDocuments.TabIndex = 7;
			this.gcDocuments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDocuments});
			// 
			// gvDocuments
			// 
			this.gvDocuments.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.gvDocuments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocumentId,
            this.colName,
            this.colDate1});
			this.gvDocuments.ColumnSet.DescriptionColumn = this.colDate1;
			this.gvDocuments.ColumnSet.TextColumn = this.colName;
			this.gvDocuments.ContextButtonOptions.AllowGlyphSkinning = true;
			contextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Right;
			contextButton1.Id = new System.Guid("29468572-0411-449a-bc2d-0c333134705c");
			contextButton1.ImageOptionsCollection.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage6")));
			contextButton1.ImageOptionsCollection.ItemNormal.SvgImageSize = new System.Drawing.Size(16, 16);
			contextButton1.Name = "removeButton";
			this.gvDocuments.ContextButtons.Add(contextButton1);
			this.gvDocuments.GridControl = this.gcDocuments;
			this.gvDocuments.Name = "gvDocuments";
			this.gvDocuments.OptionsBehavior.Editable = false;
			this.gvDocuments.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Tiles;
			this.gvDocuments.OptionsViewStyles.Tiles.ContextButtonsUseFullItemArea = true;
			// 
			// colDocumentId
			// 
			this.colDocumentId.Caption = "Id";
			this.colDocumentId.FieldName = "Id";
			this.colDocumentId.MinWidth = 25;
			this.colDocumentId.Name = "colDocumentId";
			this.colDocumentId.Visible = true;
			this.colDocumentId.VisibleIndex = 2;
			this.colDocumentId.Width = 94;
			// 
			// colName
			// 
			this.colName.AppearanceCell.Options.UseTextOptions = true;
			this.colName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.colName.FieldName = "DocumentName";
			this.colName.MinWidth = 29;
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 0;
			this.colName.Width = 109;
			// 
			// colDate1
			// 
			this.colDate1.FieldName = "DocumentDate";
			this.colDate1.MinWidth = 29;
			this.colDate1.Name = "colDate1";
			this.colDate1.Visible = true;
			this.colDate1.VisibleIndex = 1;
			this.colDate1.Width = 109;
			// 
			// openDocuments
			// 
			this.openDocuments.Client = this.gcDocuments;
			this.openDocuments.Location = new System.Drawing.Point(14, 14);
			this.openDocuments.Margin = new System.Windows.Forms.Padding(4);
			this.openDocuments.Name = "openDocuments";
			this.openDocuments.Properties.AutoHeight = false;
			this.openDocuments.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
			editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(16, 16);
			this.openDocuments.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", "loadFile", null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.openDocuments.Properties.Client = this.gcDocuments;
			this.openDocuments.Size = new System.Drawing.Size(1392, 30);
			this.openDocuments.StyleController = this.layoutAttachedDocumnets;
			this.openDocuments.TabIndex = 6;
			this.openDocuments.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.openFolder_ButtonClick);
			// 
			// layoutControlGroup5
			// 
			this.layoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup5.GroupBordersVisible = false;
			this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.lblAddFiles});
			this.layoutControlGroup5.Name = "layoutControlGroup5";
			this.layoutControlGroup5.Size = new System.Drawing.Size(1420, 251);
			this.layoutControlGroup5.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.gcDocuments;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 34);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(1396, 193);
			this.layoutControlItem5.TextVisible = false;
			// 
			// lblAddFiles
			// 
			this.lblAddFiles.Control = this.openDocuments;
			this.lblAddFiles.Location = new System.Drawing.Point(0, 0);
			this.lblAddFiles.Name = "lblAddFiles";
			this.lblAddFiles.Size = new System.Drawing.Size(1396, 34);
			this.lblAddFiles.Text = "Add Files";
			this.lblAddFiles.TextVisible = false;
			// 
			// tabCommissions
			// 
			this.tabCommissions.Caption = "Sales Management";
			this.tabCommissions.Controls.Add(this.layoutSalesManagement);
			this.tabCommissions.Name = "tabCommissions";
			this.tabCommissions.Size = new System.Drawing.Size(1424, 242);
			// 
			// layoutSalesManagement
			// 
			this.layoutSalesManagement.Controls.Add(this.gridControl2);
			this.layoutSalesManagement.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutSalesManagement.Location = new System.Drawing.Point(0, 0);
			this.layoutSalesManagement.Name = "layoutSalesManagement";
			this.layoutSalesManagement.Root = this.layoutControlGroup6;
			this.layoutSalesManagement.Size = new System.Drawing.Size(1424, 242);
			this.layoutSalesManagement.TabIndex = 0;
			this.layoutSalesManagement.Text = "Sales Management";
			// 
			// gridControl2
			// 
			this.gridControl2.DataSource = this.bsJobSeaImportDetails;
			this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gridControl2.Location = new System.Drawing.Point(14, 14);
			this.gridControl2.MainView = this.gridView10;
			this.gridControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gridControl2.Name = "gridControl2";
			this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
			this.gridControl2.Size = new System.Drawing.Size(1396, 214);
			this.gridControl2.TabIndex = 6;
			this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView10});
			// 
			// gridView10
			// 
			this.gridView10.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn24,
            this.gridColumn28,
            this.gridColumn29,
            this.gridColumn30,
            this.gridColumn31,
            this.gridColumn32,
            this.gridColumn33,
            this.gridColumn34,
            this.gridColumn35,
            this.gridColumn36,
            this.gridColumn37,
            this.gridColumn38});
			this.gridView10.DetailHeight = 431;
			this.gridView10.GridControl = this.gridControl2;
			this.gridView10.Name = "gridView10";
			this.gridView10.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
			this.gridView10.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
			this.gridView10.OptionsNavigation.AutoFocusNewRow = true;
			this.gridView10.OptionsNavigation.EnterMoveNextColumn = true;
			this.gridView10.OptionsPrint.AutoWidth = false;
			this.gridView10.OptionsView.ColumnAutoWidth = false;
			this.gridView10.OptionsView.ShowFooter = true;
			this.gridView10.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn5
			// 
			this.gridColumn5.FieldName = "Id";
			this.gridColumn5.MinWidth = 25;
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.Width = 94;
			// 
			// gridColumn6
			// 
			this.gridColumn6.FieldName = "JobId";
			this.gridColumn6.MinWidth = 25;
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.Width = 94;
			// 
			// gridColumn13
			// 
			this.gridColumn13.Caption = "HBL";
			this.gridColumn13.FieldName = "Bol";
			this.gridColumn13.MinWidth = 25;
			this.gridColumn13.Name = "gridColumn13";
			this.gridColumn13.Visible = true;
			this.gridColumn13.VisibleIndex = 0;
			this.gridColumn13.Width = 132;
			// 
			// gridColumn14
			// 
			this.gridColumn14.FieldName = "OrigId";
			this.gridColumn14.MinWidth = 25;
			this.gridColumn14.Name = "gridColumn14";
			this.gridColumn14.Width = 94;
			// 
			// gridColumn15
			// 
			this.gridColumn15.FieldName = "Origin";
			this.gridColumn15.MinWidth = 25;
			this.gridColumn15.Name = "gridColumn15";
			this.gridColumn15.Visible = true;
			this.gridColumn15.VisibleIndex = 1;
			this.gridColumn15.Width = 108;
			// 
			// gridColumn16
			// 
			this.gridColumn16.FieldName = "SuppId";
			this.gridColumn16.MinWidth = 25;
			this.gridColumn16.Name = "gridColumn16";
			this.gridColumn16.Width = 94;
			// 
			// gridColumn17
			// 
			this.gridColumn17.Caption = "Shipper";
			this.gridColumn17.FieldName = "Supplier";
			this.gridColumn17.MinWidth = 25;
			this.gridColumn17.Name = "gridColumn17";
			this.gridColumn17.Visible = true;
			this.gridColumn17.VisibleIndex = 2;
			this.gridColumn17.Width = 242;
			// 
			// gridColumn18
			// 
			this.gridColumn18.Caption = "Container#";
			this.gridColumn18.FieldName = "ContNo";
			this.gridColumn18.MinWidth = 25;
			this.gridColumn18.Name = "gridColumn18";
			this.gridColumn18.Visible = true;
			this.gridColumn18.VisibleIndex = 3;
			this.gridColumn18.Width = 197;
			// 
			// gridColumn19
			// 
			this.gridColumn19.FieldName = "Qty";
			this.gridColumn19.MinWidth = 25;
			this.gridColumn19.Name = "gridColumn19";
			this.gridColumn19.Visible = true;
			this.gridColumn19.VisibleIndex = 4;
			this.gridColumn19.Width = 66;
			// 
			// gridColumn20
			// 
			this.gridColumn20.FieldName = "Unit";
			this.gridColumn20.MinWidth = 25;
			this.gridColumn20.Name = "gridColumn20";
			this.gridColumn20.Visible = true;
			this.gridColumn20.VisibleIndex = 5;
			this.gridColumn20.Width = 102;
			// 
			// gridColumn21
			// 
			this.gridColumn21.FieldName = "UnitId";
			this.gridColumn21.MinWidth = 25;
			this.gridColumn21.Name = "gridColumn21";
			this.gridColumn21.Visible = true;
			this.gridColumn21.VisibleIndex = 6;
			this.gridColumn21.Width = 94;
			// 
			// gridColumn22
			// 
			this.gridColumn22.FieldName = "Pieces";
			this.gridColumn22.MinWidth = 25;
			this.gridColumn22.Name = "gridColumn22";
			this.gridColumn22.Visible = true;
			this.gridColumn22.VisibleIndex = 7;
			this.gridColumn22.Width = 94;
			// 
			// gridColumn23
			// 
			this.gridColumn23.FieldName = "UnitOfMesureId";
			this.gridColumn23.MinWidth = 25;
			this.gridColumn23.Name = "gridColumn23";
			this.gridColumn23.Visible = true;
			this.gridColumn23.VisibleIndex = 8;
			this.gridColumn23.Width = 94;
			// 
			// gridColumn24
			// 
			this.gridColumn24.FieldName = "Packages";
			this.gridColumn24.MinWidth = 25;
			this.gridColumn24.Name = "gridColumn24";
			this.gridColumn24.Visible = true;
			this.gridColumn24.VisibleIndex = 9;
			this.gridColumn24.Width = 94;
			// 
			// gridColumn28
			// 
			this.gridColumn28.FieldName = "Weight";
			this.gridColumn28.MinWidth = 25;
			this.gridColumn28.Name = "gridColumn28";
			this.gridColumn28.Visible = true;
			this.gridColumn28.VisibleIndex = 10;
			this.gridColumn28.Width = 94;
			// 
			// gridColumn29
			// 
			this.gridColumn29.FieldName = "ValueOfGoods";
			this.gridColumn29.MinWidth = 25;
			this.gridColumn29.Name = "gridColumn29";
			this.gridColumn29.Visible = true;
			this.gridColumn29.VisibleIndex = 11;
			this.gridColumn29.Width = 94;
			// 
			// gridColumn30
			// 
			this.gridColumn30.FieldName = "Terms";
			this.gridColumn30.MinWidth = 25;
			this.gridColumn30.Name = "gridColumn30";
			this.gridColumn30.Visible = true;
			this.gridColumn30.VisibleIndex = 12;
			this.gridColumn30.Width = 94;
			// 
			// gridColumn31
			// 
			this.gridColumn31.FieldName = "CcAmount";
			this.gridColumn31.MinWidth = 25;
			this.gridColumn31.Name = "gridColumn31";
			this.gridColumn31.Visible = true;
			this.gridColumn31.VisibleIndex = 13;
			this.gridColumn31.Width = 94;
			// 
			// gridColumn32
			// 
			this.gridColumn32.ColumnEdit = this.repositoryItemCheckEdit2;
			this.gridColumn32.FieldName = "Original";
			this.gridColumn32.MinWidth = 25;
			this.gridColumn32.Name = "gridColumn32";
			this.gridColumn32.Visible = true;
			this.gridColumn32.VisibleIndex = 14;
			this.gridColumn32.Width = 94;
			// 
			// repositoryItemCheckEdit2
			// 
			this.repositoryItemCheckEdit2.AutoHeight = false;
			this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
			// 
			// gridColumn33
			// 
			this.gridColumn33.ColumnEdit = this.repositoryItemCheckEdit2;
			this.gridColumn33.FieldName = "Photo";
			this.gridColumn33.MinWidth = 25;
			this.gridColumn33.Name = "gridColumn33";
			this.gridColumn33.Visible = true;
			this.gridColumn33.VisibleIndex = 15;
			this.gridColumn33.Width = 94;
			// 
			// gridColumn34
			// 
			this.gridColumn34.ColumnEdit = this.repositoryItemCheckEdit2;
			this.gridColumn34.FieldName = "Pl";
			this.gridColumn34.MinWidth = 25;
			this.gridColumn34.Name = "gridColumn34";
			this.gridColumn34.Visible = true;
			this.gridColumn34.VisibleIndex = 16;
			this.gridColumn34.Width = 94;
			// 
			// gridColumn35
			// 
			this.gridColumn35.ColumnEdit = this.repositoryItemCheckEdit2;
			this.gridColumn35.FieldName = "Pop";
			this.gridColumn35.MinWidth = 25;
			this.gridColumn35.Name = "gridColumn35";
			this.gridColumn35.Visible = true;
			this.gridColumn35.VisibleIndex = 17;
			this.gridColumn35.Width = 94;
			// 
			// gridColumn36
			// 
			this.gridColumn36.FieldName = "Commodity";
			this.gridColumn36.MinWidth = 25;
			this.gridColumn36.Name = "gridColumn36";
			this.gridColumn36.Visible = true;
			this.gridColumn36.VisibleIndex = 18;
			this.gridColumn36.Width = 94;
			// 
			// gridColumn37
			// 
			this.gridColumn37.FieldName = "Notify";
			this.gridColumn37.MinWidth = 25;
			this.gridColumn37.Name = "gridColumn37";
			this.gridColumn37.Visible = true;
			this.gridColumn37.VisibleIndex = 19;
			this.gridColumn37.Width = 94;
			// 
			// gridColumn38
			// 
			this.gridColumn38.FieldName = "Notes";
			this.gridColumn38.MinWidth = 25;
			this.gridColumn38.Name = "gridColumn38";
			this.gridColumn38.Visible = true;
			this.gridColumn38.VisibleIndex = 20;
			this.gridColumn38.Width = 94;
			// 
			// layoutControlGroup6
			// 
			this.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup6.GroupBordersVisible = false;
			this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
			this.layoutControlGroup6.Name = "layoutControlGroup6";
			this.layoutControlGroup6.Size = new System.Drawing.Size(1424, 242);
			this.layoutControlGroup6.TextVisible = false;
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.gridControl2;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(1400, 218);
			this.layoutControlItem6.TextVisible = false;
			// 
			// tabShipmentStatus
			// 
			this.tabShipmentStatus.Caption = "Shipment Status";
			this.tabShipmentStatus.Controls.Add(this.layoutShipmentStatus);
			this.tabShipmentStatus.Name = "tabShipmentStatus";
			this.tabShipmentStatus.Size = new System.Drawing.Size(1424, 242);
			// 
			// layoutShipmentStatus
			// 
			this.layoutShipmentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutShipmentStatus.Location = new System.Drawing.Point(0, 0);
			this.layoutShipmentStatus.Name = "layoutShipmentStatus";
			this.layoutShipmentStatus.Root = this.layoutControlGroup7;
			this.layoutShipmentStatus.Size = new System.Drawing.Size(1424, 242);
			this.layoutShipmentStatus.TabIndex = 0;
			this.layoutShipmentStatus.Text = "layoutS hipment Status";
			// 
			// layoutControlGroup7
			// 
			this.layoutControlGroup7.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup7.GroupBordersVisible = false;
			this.layoutControlGroup7.Name = "layoutControlGroup7";
			this.layoutControlGroup7.Size = new System.Drawing.Size(1424, 242);
			this.layoutControlGroup7.TextVisible = false;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblDetailedTransactions,
            this.tabJobInfo,
            this.lblGroupNotes,
            this.layoutControlGroup15});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1448, 726);
			this.Root.TextVisible = false;
			// 
			// lblDetailedTransactions
			// 
			this.lblDetailedTransactions.Control = this.tabDetails;
			this.lblDetailedTransactions.Location = new System.Drawing.Point(0, 406);
			this.lblDetailedTransactions.Name = "lblDetailedTransactions";
			this.lblDetailedTransactions.Size = new System.Drawing.Size(1424, 296);
			this.lblDetailedTransactions.Text = "Detailed Transactions";
			this.lblDetailedTransactions.TextVisible = false;
			// 
			// tabJobInfo
			// 
			this.tabJobInfo.Control = this.grpJobInformation;
			this.tabJobInfo.Location = new System.Drawing.Point(0, 0);
			this.tabJobInfo.Name = "tabJobInfo";
			this.tabJobInfo.Size = new System.Drawing.Size(818, 406);
			this.tabJobInfo.Text = "Job Information";
			this.tabJobInfo.TextVisible = false;
			// 
			// lblGroupNotes
			// 
			this.lblGroupNotes.Control = this.tabGroupNotes;
			this.lblGroupNotes.Location = new System.Drawing.Point(818, 218);
			this.lblGroupNotes.Name = "lblGroupNotes";
			this.lblGroupNotes.Size = new System.Drawing.Size(606, 188);
			this.lblGroupNotes.Text = "Notes";
			this.lblGroupNotes.TextLocation = DevExpress.Utils.Locations.Top;
			this.lblGroupNotes.TextVisible = false;
			// 
			// layoutControlGroup15
			// 
			this.layoutControlGroup15.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.grpTotalLL,
            this.grpTotalUsd});
			this.layoutControlGroup15.Location = new System.Drawing.Point(818, 0);
			this.layoutControlGroup15.Name = "layoutControlGroup15";
			this.layoutControlGroup15.Size = new System.Drawing.Size(606, 218);
			this.layoutControlGroup15.TextVisible = false;
			// 
			// grpTotalLL
			// 
			this.grpTotalLL.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpTotalLL.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblTotalCostsLL,
            this.lblTotalInvoicesLL,
            this.lblProfitLL,
            this.emptySpaceItem1});
			this.grpTotalLL.Location = new System.Drawing.Point(0, 0);
			this.grpTotalLL.Name = "grpTotalLL";
			this.grpTotalLL.Size = new System.Drawing.Size(290, 190);
			this.grpTotalLL.Text = "Total LL";
			// 
			// lblTotalCostsLL
			// 
			this.lblTotalCostsLL.Control = this.txtTotalCostsLL;
			this.lblTotalCostsLL.Location = new System.Drawing.Point(0, 0);
			this.lblTotalCostsLL.Name = "lblTotalCostsLL";
			this.lblTotalCostsLL.Size = new System.Drawing.Size(262, 26);
			this.lblTotalCostsLL.Text = "Total Costs";
			this.lblTotalCostsLL.TextSize = new System.Drawing.Size(79, 16);
			// 
			// lblTotalInvoicesLL
			// 
			this.lblTotalInvoicesLL.Control = this.txtTotalInvoicesLL;
			this.lblTotalInvoicesLL.Location = new System.Drawing.Point(0, 26);
			this.lblTotalInvoicesLL.Name = "lblTotalInvoicesLL";
			this.lblTotalInvoicesLL.Size = new System.Drawing.Size(262, 26);
			this.lblTotalInvoicesLL.Text = "Total Invoices";
			this.lblTotalInvoicesLL.TextSize = new System.Drawing.Size(79, 16);
			// 
			// lblProfitLL
			// 
			this.lblProfitLL.Control = this.txtProfitLL;
			this.lblProfitLL.Location = new System.Drawing.Point(0, 110);
			this.lblProfitLL.Name = "lblProfitLL";
			this.lblProfitLL.Size = new System.Drawing.Size(262, 26);
			this.lblProfitLL.Text = "Profit LL";
			this.lblProfitLL.TextSize = new System.Drawing.Size(79, 16);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 52);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(262, 58);
			// 
			// grpTotalUsd
			// 
			this.grpTotalUsd.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpTotalUsd.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblTotalCostsUSD,
            this.lblTotalInvoicesUSD,
            this.lblProfitUSD,
            this.emptySpaceItem3});
			this.grpTotalUsd.Location = new System.Drawing.Point(290, 0);
			this.grpTotalUsd.Name = "grpTotalUsd";
			this.grpTotalUsd.Size = new System.Drawing.Size(288, 190);
			this.grpTotalUsd.Text = "Total USD";
			// 
			// lblTotalCostsUSD
			// 
			this.lblTotalCostsUSD.Control = this.txtTotalCostsUSD;
			this.lblTotalCostsUSD.Location = new System.Drawing.Point(0, 0);
			this.lblTotalCostsUSD.Name = "lblTotalCostsUSD";
			this.lblTotalCostsUSD.Size = new System.Drawing.Size(260, 26);
			this.lblTotalCostsUSD.Text = "Total Costs";
			this.lblTotalCostsUSD.TextSize = new System.Drawing.Size(79, 16);
			// 
			// lblTotalInvoicesUSD
			// 
			this.lblTotalInvoicesUSD.Control = this.txtTotalInvoicesUSD;
			this.lblTotalInvoicesUSD.Location = new System.Drawing.Point(0, 26);
			this.lblTotalInvoicesUSD.Name = "lblTotalInvoicesUSD";
			this.lblTotalInvoicesUSD.Size = new System.Drawing.Size(260, 26);
			this.lblTotalInvoicesUSD.Text = "Total Invoices";
			this.lblTotalInvoicesUSD.TextSize = new System.Drawing.Size(79, 16);
			// 
			// lblProfitUSD
			// 
			this.lblProfitUSD.Control = this.txtProfitUSD;
			this.lblProfitUSD.Location = new System.Drawing.Point(0, 110);
			this.lblProfitUSD.Name = "lblProfitUSD";
			this.lblProfitUSD.Size = new System.Drawing.Size(260, 26);
			this.lblProfitUSD.Text = "Profit USD";
			this.lblProfitUSD.TextSize = new System.Drawing.Size(79, 16);
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.Location = new System.Drawing.Point(0, 52);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(260, 58);
			// 
			// JobSeaImportEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1448, 949);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcMain);
			this.Name = "JobSeaImportEditForm";
			this.Ribbon = this.rcMain;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Edit Job Sea Import Record";
			((System.ComponentModel.ISupportInitialize)(this.rcMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsJobSeaImport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsJobSeaImportDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCosts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsInvoices)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDocuments)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tabGroupNotes)).EndInit();
			this.tabGroupNotes.ResumeLayout(false);
			this.tabStatus.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutStatus)).EndInit();
			this.layoutStatus.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			this.tabBlStatus.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutBlStatus)).EndInit();
			this.layoutBlStatus.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtBlStatus.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
			this.tabNotes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutNotes)).EndInit();
			this.layoutNotes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProfitLL.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProfitUSD.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalInvoicesUSD.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalInvoicesLL.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalCostsUSD.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalCostsLL.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpJobInformation)).EndInit();
			this.grpJobInformation.ResumeLayout(false);
			this.tabJobInformation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutClientInformation)).EndInit();
			this.layoutClientInformation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtMbl.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtJobNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtReferenceNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtJobDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtJobDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCustomers.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboConsignees.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboJobsType.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EtdDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EtdDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtdDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtdDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LoadingDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LoadingDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtaDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AtaDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EtaDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EtaDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CutOffDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CutOffDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboDeparture.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboDestination.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCountryOfDeparture.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCountryOfDestination.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJobNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblReferenceNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJobDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCustomerName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblConsigneeName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJobType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblEtd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAtd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblLoadingDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblEta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCutOffDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDeparture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDestination)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCountryOfDeparture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCountryOfDestination)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMbl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem24)).EndInit();
			this.tabShipmentInformation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutShipmentTracking)).EndInit();
			this.layoutShipmentTracking.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cboShippedWith.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtConfirmEmptyContainer.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtConfirmEmptyContainer.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtEmptyContainer.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtEmptyContainer.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtContainerToCnee.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtContainerToCnee.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkEmptyContainer.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkConfirmEmptyContainer.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkContainerToCnee.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBookingNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtMissingDocumentsDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtMissingDocumentsDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtPaidDoDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtPaidDoDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtTejrimDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtTejrimDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit10.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit10.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtPendingForDelivery.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtPendingForDelivery.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtReadyForClearance.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtReadyForClearance.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtReadyForTejrim.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtReadyForTejrim.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkDeliveryDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkMissingDocuments.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkPendingForDelivery.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkPaidDo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkReadyForClearance.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkTejrim.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkRTejrim.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboAgents.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboIncoTerms.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboSeaCarriers.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboVessels.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView61)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboFeederVessels.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFreeOfDemurage.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblVessels)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblFeederVessels)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAgents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSeaCarriers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblIncoTerms)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTejrimDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPaidDoDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMissingDocumentsDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblFreeOfDemurage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblBookingNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblReadyForTejrim)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblReadyForClearance)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPendingForDelivery)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblContainerToCneeDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblEmptyContainerDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblConfirmEmptyContainerDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblShippedWith)).EndInit();
			this.tabPackageDetails.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutPackageDetails)).EndInit();
			this.layoutPackageDetails.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtValueOfGoods.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVolume.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPieces.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantities.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNatureOfGoods.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblQuantities)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPieces)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCommodities)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblVolume)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblValueOfGoods)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem25)).EndInit();
			this.tabUserInformation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutUserInformation)).EndInit();
			this.layoutUserInformation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtUserLogData.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboUsers.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboSales.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboOperatingUsers.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblUserName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSalesman)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOperatingUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblUserLogData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tabDetails)).EndInit();
			this.tabDetails.ResumeLayout(false);
			this.tabJobDetails.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutJobDetails)).EndInit();
			this.layoutJobDetails.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcJobDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvJobDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCountries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repShippers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.tabRequirements.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutRequirements)).EndInit();
			this.layoutRequirements.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
			this.gridSplitContainer1.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
			this.gridSplitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcRequiredOnWater)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvRequiredOnWater)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcRequiredToBeLoaded)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvRequiredToBeLoaded)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lcAllInOrderToBeloaded)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lcAllInOrderOnWater)).EndInit();
			this.tabSellingGroup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutInvoicesGrid)).EndInit();
			this.layoutInvoicesGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcInvoices)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvInvoices)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSellingMemberList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSellingItemsList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSellingPayemntsList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSellingCurrenciesList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			this.tabCostGroup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutCostSheetsGrid)).EndInit();
			this.layoutCostSheetsGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcCosts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCosts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCostItemsList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCostAgents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCostMethodofPaymentList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCostCurrenciesList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			this.tabDocuments.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutAttachedDocumnets)).EndInit();
			this.layoutAttachedDocumnets.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcDocuments)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDocuments)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.openDocuments.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAddFiles)).EndInit();
			this.tabCommissions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutSalesManagement)).EndInit();
			this.layoutSalesManagement.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			this.tabShipmentStatus.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutShipmentStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDetailedTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tabJobInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblGroupNotes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpTotalLL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalCostsLL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalInvoicesLL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProfitLL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpTotalUsd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalCostsUSD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalInvoicesUSD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProfitUSD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rcMain;
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
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.BindingSource bsJobSeaImport;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.BindingSource bsJobSeaImportDetails;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private System.Windows.Forms.BindingSource bsDocuments;
        private System.Windows.Forms.BindingSource bsInvoices;
        private System.Windows.Forms.BindingSource bsCosts;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgJobStatusAction;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpInvoice;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnNewInvoice;
		private DevExpress.XtraBars.BarButtonItem btnNewCost;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpCost;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
		private DevExpress.XtraBars.BarCheckItem btnProtected;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSecurity;
		private DevExpress.XtraBars.BarButtonItem btnCloseInvoice;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup14;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup15;
		private DevExpress.XtraBars.BarButtonItem btnSaveInvoice;
		private DevExpress.XtraBars.BarButtonItem btnSaveAndCloseInvoice;
		private DevExpress.XtraBars.BarButtonItem btnRefreshInvoice;
		private DevExpress.XtraBars.BarButtonItem btnDeleteInvoice;
		private DevExpress.XtraBars.BarButtonItem btnPrintInvoice;
		private DevExpress.XtraBars.BarButtonItem btnInvoiceProtected;
		private DevExpress.XtraBars.BarButtonItem btnPrintOriginalInvoice;
		private DevExpress.XtraBars.BarButtonItem btnCloseCost;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup16;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup17;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup18;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup19;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup20;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup21;
		private DevExpress.XtraBars.BarButtonItem btnSaveCost;
		private DevExpress.XtraBars.BarButtonItem btnSaveAndCloseCost;
		private DevExpress.XtraBars.BarButtonItem btnRefreshCost;
		private DevExpress.XtraBars.BarButtonItem btnDeleteCost;
		private DevExpress.XtraBars.BarButtonItem btnPrintCost;
		private DevExpress.XtraBars.BarButtonItem btnCostProtected;
		private DevExpress.XtraDataLayout.DataLayoutControl mainLayout;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraBars.Navigation.TabPane tabDetails;
		private DevExpress.XtraBars.Navigation.TabNavigationPage tabJobDetails;
		private DevExpress.XtraBars.Navigation.TabNavigationPage tabRequirements;
		private DevExpress.XtraLayout.LayoutControlItem lblDetailedTransactions;
		private DevExpress.XtraBars.Navigation.TabNavigationPage tabSellingGroup;
		private DevExpress.XtraBars.Navigation.TabNavigationPage tabCostGroup;
		private DevExpress.XtraBars.Navigation.TabNavigationPage tabDocuments;
		private DevExpress.XtraBars.Navigation.TabNavigationPage tabCommissions;
		private DevExpress.XtraBars.Navigation.TabNavigationPage tabShipmentStatus;
		private DevExpress.XtraLayout.LayoutControl layoutJobDetails;
		private DevExpress.XtraGrid.GridControl gcJobDetails;
		private DevExpress.XtraGrid.Views.Grid.GridView gvJobDetails;
		private DevExpress.XtraGrid.Columns.GridColumn colId1;
		private DevExpress.XtraGrid.Columns.GridColumn colJobId;
		private DevExpress.XtraGrid.Columns.GridColumn colHbl;
		private DevExpress.XtraGrid.Columns.GridColumn colOriginId;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCountries;
		private DevExpress.XtraGrid.Columns.GridColumn colSupplierId;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repShippers;
		private DevExpress.XtraGrid.Columns.GridColumn colContainerNo;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantities;
		private DevExpress.XtraGrid.Columns.GridColumn colUnitId;
		private DevExpress.XtraGrid.Columns.GridColumn colPieces;
		private DevExpress.XtraGrid.Columns.GridColumn colUnitOfMeasureId;
		private DevExpress.XtraGrid.Columns.GridColumn colPackages;
		private DevExpress.XtraGrid.Columns.GridColumn colWeight;
		private DevExpress.XtraGrid.Columns.GridColumn colValueOfGoods;
		private DevExpress.XtraGrid.Columns.GridColumn colTerms;
		private DevExpress.XtraGrid.Columns.GridColumn colCcAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colOriginal;
		private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
		private DevExpress.XtraGrid.Columns.GridColumn colPl;
		private DevExpress.XtraGrid.Columns.GridColumn colPop;
		private DevExpress.XtraGrid.Columns.GridColumn colCommodity;
		private DevExpress.XtraGrid.Columns.GridColumn colNotify;
		private DevExpress.XtraGrid.Columns.GridColumn colNotes;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControl layoutInvoicesGrid;
		private DevExpress.XtraGrid.GridControl gcInvoices;
		private DevExpress.XtraGrid.Views.Grid.GridView gvInvoices;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingId;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingQHeaderId;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingCustomerId;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSellingMemberList;
		private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingMemberNameId;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingMemberName;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingItemId;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSellingItemsList;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
		private DevExpress.XtraGrid.Columns.GridColumn colItemId;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingPaymentId;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repSellingPayemntsList;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingCurrencyId;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repSellingCurrenciesList;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingRate;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingL_Amount;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingF_Amount;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingVat;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingVatRate;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingNotes;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingDeleted;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingVatAmountLL;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingVatAmountUSD;
		private DevExpress.XtraGrid.Columns.GridColumn colSellingVatAmount;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControl layoutCostSheetsGrid;
		private DevExpress.XtraGrid.GridControl gcCosts;
		private DevExpress.XtraGrid.Views.Grid.GridView gvCosts;
		private DevExpress.XtraGrid.Columns.GridColumn colCostId;
		private DevExpress.XtraGrid.Columns.GridColumn colCostQHeaderId;
		private DevExpress.XtraGrid.Columns.GridColumn colCostItemId;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repCostItemsList;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
		private DevExpress.XtraGrid.Columns.GridColumn colCostDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colCostAgentName;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repCostAgents;
		private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
		private DevExpress.XtraGrid.Columns.GridColumn colAgentID;
		private DevExpress.XtraGrid.Columns.GridColumn colAgentName;
		private DevExpress.XtraGrid.Columns.GridColumn colCostPaymentId;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCostMethodofPaymentList;
		private DevExpress.XtraGrid.Columns.GridColumn colCostCurrencyId;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCostCurrenciesList;
		private DevExpress.XtraGrid.Columns.GridColumn colCostRate;
		private DevExpress.XtraGrid.Columns.GridColumn colCostAmount;
		private DevExpress.XtraGrid.Columns.GridColumn colCostL_Amount;
		private DevExpress.XtraGrid.Columns.GridColumn colCostF_Amount;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
		private DevExpress.XtraGrid.Columns.GridColumn colCostVat;
		private DevExpress.XtraGrid.Columns.GridColumn colCostVatRate;
		private DevExpress.XtraGrid.Columns.GridColumn colCostNotes;
		private DevExpress.XtraGrid.Columns.GridColumn colCostVatAmountLL;
		private DevExpress.XtraGrid.Columns.GridColumn colCostVatAmountUSD;
		private DevExpress.XtraGrid.Columns.GridColumn colCostVatAmount;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
		private DevExpress.XtraGrid.Columns.GridColumn colCostDeleted;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControl layoutAttachedDocumnets;
		private DevExpress.XtraGrid.GridControl gcDocuments;
		private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView gvDocuments;
		private DevExpress.XtraGrid.Columns.GridColumn colDocumentId;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colDate1;
		private DevExpress.XtraEditors.SearchControl openDocuments;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem lblAddFiles;
		private DevExpress.XtraLayout.LayoutControl layoutSalesManagement;
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraLayout.LayoutControl layoutShipmentStatus;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
		private DevExpress.XtraTab.XtraTabControl grpJobInformation;
		private DevExpress.XtraTab.XtraTabPage tabJobInformation;
		private DevExpress.XtraTab.XtraTabPage tabShipmentInformation;
		private DevExpress.XtraLayout.LayoutControlItem tabJobInfo;
		private DevExpress.XtraLayout.LayoutControl layoutClientInformation;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup8;
		private DevExpress.XtraEditors.TextEdit txtJobNo;
		private DevExpress.XtraLayout.LayoutControlItem lblJobNo;
		private DevExpress.XtraEditors.TextEdit txtReferenceNo;
		private DevExpress.XtraLayout.LayoutControlItem lblReferenceNo;
		private DevExpress.XtraEditors.DateEdit dtJobDate;
		private DevExpress.XtraLayout.LayoutControlItem lblJobDate;
		private DevExpress.XtraEditors.SearchLookUpEdit cboCustomers;
		private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
		private DevExpress.XtraLayout.LayoutControlItem lblCustomerName;
		private DevExpress.XtraEditors.SearchLookUpEdit cboConsignees;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView11;
		private DevExpress.XtraLayout.LayoutControlItem lblConsigneeName;
		private DevExpress.XtraEditors.SearchLookUpEdit cboJobsType;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraLayout.LayoutControlItem lblJobType;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
		private DevExpress.XtraTab.XtraTabPage tabUserInformation;
		private DevExpress.XtraLayout.LayoutControl layoutShipmentTracking;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup9;
		private DevExpress.XtraEditors.TextEdit txtProfitUSD;
		private DevExpress.XtraEditors.TextEdit txtTotalInvoicesUSD;
		private DevExpress.XtraEditors.TextEdit txtTotalInvoicesLL;
		private DevExpress.XtraEditors.TextEdit txtTotalCostsUSD;
		private DevExpress.XtraEditors.TextEdit txtTotalCostsLL;
		private DevExpress.XtraEditors.TextEdit txtProfitLL;
		private DevExpress.XtraLayout.LayoutControl layoutRequirements;
		private DevExpress.XtraEditors.LabelControl lblAllInOrderOnWater;
		private DevExpress.XtraEditors.LabelControl lblAllInOrderToBeloaded;
		private DevExpress.XtraEditors.SimpleButton btnAllInOrderOW;
		private DevExpress.XtraEditors.SimpleButton btnAllInOrderTBL;
		private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
		private DevExpress.XtraGrid.GridControl gcRequiredOnWater;
		private DevExpress.XtraGrid.Views.Grid.GridView gvRequiredOnWater;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn47;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn48;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckEdit;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn49;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn50;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn51;
		private DevExpress.XtraGrid.GridControl gcRequiredToBeLoaded;
		private DevExpress.XtraGrid.Views.Grid.GridView gvRequiredToBeLoaded;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn41;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn45;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckBox;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn43;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn44;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn46;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup12;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
		private DevExpress.XtraLayout.LayoutControlItem lcAllInOrderToBeloaded;
		private DevExpress.XtraLayout.LayoutControlItem lcAllInOrderOnWater;
		private DevExpress.XtraLayout.LayoutControl layoutUserInformation;
		private DevExpress.XtraEditors.SearchLookUpEdit cboUsers;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem lblUserName;
		private DevExpress.XtraEditors.SearchLookUpEdit cboSales;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
		private DevExpress.XtraLayout.LayoutControlItem lblSalesman;
		private DevExpress.XtraEditors.SearchLookUpEdit cboOperatingUsers;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
		private DevExpress.XtraLayout.LayoutControlItem lblOperatingUser;
		private DevExpress.XtraTab.XtraTabPage tabPackageDetails;
		private DevExpress.XtraLayout.LayoutControl layoutPackageDetails;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup11;
		private DevExpress.XtraTab.XtraTabControl tabGroupNotes;
		private DevExpress.XtraTab.XtraTabPage tabStatus;
		private DevExpress.XtraTab.XtraTabPage tabBlStatus;
		private DevExpress.XtraLayout.LayoutControlItem lblGroupNotes;
		private DevExpress.XtraTab.XtraTabPage tabNotes;
		private DevExpress.XtraLayout.LayoutControl layoutStatus;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup10;
		private DevExpress.XtraLayout.LayoutControl layoutBlStatus;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup13;
		private DevExpress.XtraLayout.LayoutControl layoutNotes;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup14;
		private DevExpress.XtraEditors.MemoEdit txtStatus;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraEditors.MemoEdit txtBlStatus;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
		private DevExpress.XtraEditors.MemoEdit txtNotes;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup15;
		private DevExpress.XtraLayout.LayoutControlGroup grpTotalLL;
		private DevExpress.XtraLayout.LayoutControlItem lblTotalCostsLL;
		private DevExpress.XtraLayout.LayoutControlItem lblTotalInvoicesLL;
		private DevExpress.XtraLayout.LayoutControlItem lblProfitLL;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlGroup grpTotalUsd;
		private DevExpress.XtraLayout.LayoutControlItem lblTotalCostsUSD;
		private DevExpress.XtraLayout.LayoutControlItem lblTotalInvoicesUSD;
		private DevExpress.XtraLayout.LayoutControlItem lblProfitUSD;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
		private DevExpress.XtraEditors.CheckEdit chkRTejrim;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
		private DevExpress.XtraEditors.CheckEdit chkDeliveryDate;
		private DevExpress.XtraEditors.CheckEdit chkMissingDocuments;
		private DevExpress.XtraEditors.CheckEdit chkPendingForDelivery;
		private DevExpress.XtraEditors.CheckEdit chkPaidDo;
		private DevExpress.XtraEditors.CheckEdit chkReadyForClearance;
		private DevExpress.XtraEditors.CheckEdit chkTejrim;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
		private DevExpress.XtraEditors.DateEdit dateEdit10;
		private DevExpress.XtraEditors.DateEdit dtPendingForDelivery;
		private DevExpress.XtraEditors.DateEdit dtReadyForClearance;
		private DevExpress.XtraEditors.DateEdit dtReadyForTejrim;
		private DevExpress.XtraLayout.LayoutControlItem lblReadyForTejrim;
		private DevExpress.XtraLayout.LayoutControlItem lblReadyForClearance;
		private DevExpress.XtraLayout.LayoutControlItem lblPendingForDelivery;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
		private DevExpress.XtraEditors.DateEdit EtdDate;
		private DevExpress.XtraEditors.DateEdit AtdDate;
		private DevExpress.XtraEditors.DateEdit LoadingDate;
		private DevExpress.XtraEditors.DateEdit AtaDate;
		private DevExpress.XtraEditors.DateEdit EtaDate;
		private DevExpress.XtraEditors.DateEdit CutOffDate;
		private DevExpress.XtraLayout.LayoutControlItem lblEtd;
		private DevExpress.XtraLayout.LayoutControlItem lblAtd;
		private DevExpress.XtraLayout.LayoutControlItem lblLoadingDate;
		private DevExpress.XtraLayout.LayoutControlItem lblAta;
		private DevExpress.XtraLayout.LayoutControlItem lblEta;
		private DevExpress.XtraLayout.LayoutControlItem lblCutOffDate;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
		private DevExpress.XtraEditors.SearchLookUpEdit cboDeparture;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView14;
		private DevExpress.XtraEditors.SearchLookUpEdit cboDestination;
		private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
		private DevExpress.XtraEditors.TextEdit txtCountryOfDeparture;
		private DevExpress.XtraEditors.TextEdit txtCountryOfDestination;
		private DevExpress.XtraLayout.LayoutControlItem lblDeparture;
		private DevExpress.XtraLayout.LayoutControlItem lblDestination;
		private DevExpress.XtraLayout.LayoutControlItem lblCountryOfDeparture;
		private DevExpress.XtraLayout.LayoutControlItem lblCountryOfDestination;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
		private DevExpress.XtraEditors.SearchLookUpEdit cboAgents;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView12;
		private DevExpress.XtraEditors.SearchLookUpEdit cboIncoTerms;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView13;
		private DevExpress.XtraEditors.SearchLookUpEdit cboSeaCarriers;
		private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit3View;
		private DevExpress.XtraEditors.SearchLookUpEdit cboVessels;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView61;
		private DevExpress.XtraEditors.SearchLookUpEdit cboFeederVessels;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
		private DevExpress.XtraLayout.LayoutControlItem lblVessels;
		private DevExpress.XtraLayout.LayoutControlItem lblFeederVessels;
		private DevExpress.XtraLayout.LayoutControlItem lblAgents;
		private DevExpress.XtraLayout.LayoutControlItem lblSeaCarriers;
		private DevExpress.XtraLayout.LayoutControlItem lblIncoTerms;
		private DevExpress.XtraEditors.DateEdit dtMissingDocumentsDate;
		private DevExpress.XtraEditors.DateEdit dtPaidDoDate;
		private DevExpress.XtraEditors.DateEdit dtTejrimDate;
		private DevExpress.XtraLayout.LayoutControlItem lblTejrimDate;
		private DevExpress.XtraLayout.LayoutControlItem lblPaidDoDate;
		private DevExpress.XtraLayout.LayoutControlItem lblMissingDocumentsDate;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem12;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem13;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem14;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem16;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem17;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem15;
		private DevExpress.XtraEditors.TextEdit txtWeight;
		private DevExpress.XtraEditors.TextEdit txtPieces;
		private DevExpress.XtraEditors.TextEdit txtQuantities;
		private DevExpress.XtraEditors.MemoEdit txtNatureOfGoods;
		private DevExpress.XtraLayout.LayoutControlItem lblQuantities;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem18;
		private DevExpress.XtraLayout.LayoutControlItem lblPieces;
		private DevExpress.XtraLayout.LayoutControlItem lblWeight;
		private DevExpress.XtraLayout.LayoutControlItem lblCommodities;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem19;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem20;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem21;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem22;
		private DevExpress.XtraEditors.TextEdit txtMbl;
		private DevExpress.XtraLayout.LayoutControlItem lblMbl;
		private DevExpress.XtraEditors.TextEdit txtFreeOfDemurage;
		private DevExpress.XtraLayout.LayoutControlItem lblFreeOfDemurage;
		private DevExpress.XtraEditors.TextEdit txtBookingNo;
		private DevExpress.XtraLayout.LayoutControlItem lblBookingNo;
		private DevExpress.XtraEditors.CheckEdit chkEmptyContainer;
		private DevExpress.XtraEditors.CheckEdit chkConfirmEmptyContainer;
		private DevExpress.XtraEditors.CheckEdit chkContainerToCnee;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
		private DevExpress.XtraEditors.MemoEdit txtUserLogData;
		private DevExpress.XtraLayout.LayoutControlItem lblUserLogData;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem23;
		private DevExpress.XtraEditors.DateEdit dtConfirmEmptyContainer;
		private DevExpress.XtraEditors.DateEdit dtEmptyContainer;
		private DevExpress.XtraEditors.DateEdit dtContainerToCnee;
		private DevExpress.XtraLayout.LayoutControlItem lblContainerToCneeDate;
		private DevExpress.XtraLayout.LayoutControlItem lblEmptyContainerDate;
		private DevExpress.XtraLayout.LayoutControlItem lblConfirmEmptyContainerDate;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraGrid.Columns.GridColumn gcId;
		private DevExpress.XtraGrid.Columns.GridColumn gcName;
		private DevExpress.XtraGrid.Columns.GridColumn gcConsigneeId;
		private DevExpress.XtraGrid.Columns.GridColumn gcConsigneeName;
		private DevExpress.XtraGrid.Columns.GridColumn colTypeId;
		private DevExpress.XtraGrid.Columns.GridColumn colTypeDescription;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem24;
		private DevExpress.XtraGrid.Columns.GridColumn colSeaportDepartureId;
		private DevExpress.XtraGrid.Columns.GridColumn colSeaportDepartureName;
		private DevExpress.XtraGrid.Columns.GridColumn colcboDestinationId;
		private DevExpress.XtraGrid.Columns.GridColumn colcboDestinationName;
		private DevExpress.XtraGrid.Columns.GridColumn colVesselId;
		private DevExpress.XtraGrid.Columns.GridColumn colVesselName;
		private DevExpress.XtraGrid.Columns.GridColumn colFeederVesselId;
		private DevExpress.XtraGrid.Columns.GridColumn colFeederVesselName;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnAgentId;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnAgentName;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnSeaCarrierId;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnSeaCarrierName;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnTermsId;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnTermCode;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnTermsDescription;
		private DevExpress.XtraGrid.Columns.GridColumn columnUserId;
		private DevExpress.XtraGrid.Columns.GridColumn columnUserName;
		private DevExpress.XtraGrid.Columns.GridColumn columnSalesmanId;
		private DevExpress.XtraGrid.Columns.GridColumn columnSalesmanName;
		private DevExpress.XtraGrid.Columns.GridColumn columnOperatingUserId;
		private DevExpress.XtraGrid.Columns.GridColumn columnOperatingUserName;
		private DevExpress.XtraEditors.TextEdit txtVolume;
		private DevExpress.XtraLayout.LayoutControlItem lblVolume;
		private DevExpress.XtraEditors.TextEdit txtValueOfGoods;
		private DevExpress.XtraLayout.LayoutControlItem lblValueOfGoods;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem25;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem26;
		private DevExpress.XtraEditors.SearchLookUpEdit cboShippedWith;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraLayout.LayoutControlItem lblShippedWith;
		private DevExpress.XtraGrid.Columns.GridColumn colShippedWithId;
		private DevExpress.XtraGrid.Columns.GridColumn colShippedWith;
	}
}