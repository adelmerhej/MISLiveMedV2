using MISLiveMed.Models.Models.JobModels.Quotations;

namespace MISLiveMed.UI.Forms.CRM.Quotations
{
    partial class QuotationEditForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuotationEditForm));
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			this.btnMainExit = new DevExpress.XtraBars.BarButtonItem();
			this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnSave = new DevExpress.XtraBars.BarButtonItem();
			this.biClose = new DevExpress.XtraBars.BarButtonItem();
			this.btnSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
			this.btnCreateNewJob = new DevExpress.XtraBars.BarButtonItem();
			this.btnMeeting = new DevExpress.XtraBars.BarButtonItem();
			this.bmiPrintProfile = new DevExpress.XtraBars.BarButtonItem();
			this.bmiPrintSummary = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.bmiPrintDirectory = new DevExpress.XtraBars.BarButtonItem();
			this.bmiPrintTaskList = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.btnSaveAs = new DevExpress.XtraBars.BarButtonItem();
			this.btnUrgent = new DevExpress.XtraBars.BarCheckItem();
			this.rgQuotationStatusOptions = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rbQuotationStatusOptions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.lcMain = new DevExpress.XtraLayout.LayoutControl();
			this.btnEditSales = new DevExpress.XtraEditors.SimpleButton();
			this.txtReason = new DevExpress.XtraEditors.MemoEdit();
			this.bsQuotations = new System.Windows.Forms.BindingSource(this.components);
			this.cboSales = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtTermDescription = new DevExpress.XtraEditors.TextEdit();
			this.cboTermsList = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTermsId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltermCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltermsDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtShipperName = new DevExpress.XtraEditors.TextEdit();
			this.txtNotes = new DevExpress.XtraEditors.MemoEdit();
			this.btnEditCostSelling = new DevExpress.XtraEditors.SimpleButton();
			this.btnAddCostSelling = new DevExpress.XtraEditors.SimpleButton();
			this.gcSellings = new DevExpress.XtraGrid.GridControl();
			this.gvSellings = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colSellingHeaderId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingQuotationId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingVersionNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingQuoteDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.colSellingDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingTransitTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingValidity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingValidityDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemDateEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.colSellingCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repSellingCurrenciesList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.costSellingTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingTotalLocalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSellingTotalForeignAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.costSellingNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalSellingVatAmountLL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalSellingVatAmountUSD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repSellingSeaCarrierList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.gcRealCosts = new DevExpress.XtraGrid.GridControl();
			this.gvRealCosts = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colHeaderId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostQuotationId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostVersionNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.colCostDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostSeaCarrierId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repSeaCarrierList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colCostTransitTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostValidity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostValidityDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.colCostCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCurrenciesList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colCostTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostTotalLocalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostTotalForeignAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCostNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalLocalVatAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalForeignVatAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repAgentList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.dtBookedDate = new DevExpress.XtraEditors.DateEdit();
			this.cboConsigneesList = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colConsigneeId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColConsigneeName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtJobNo = new DevExpress.XtraEditors.TextEdit();
			this.dtFollowUp = new DevExpress.XtraEditors.DateEdit();
			this.cboCarrierList = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.cboAgentsList = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colAgentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAgentName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtXONumber = new DevExpress.XtraEditors.TextEdit();
			this.cboHandledBy = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.repUsersList = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.dtQuotationDate = new DevExpress.XtraEditors.DateEdit();
			this.cboStatus = new DevExpress.XtraEditors.GridLookUpEdit();
			this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.cboPolList = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colPolId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPolPortCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPolPortName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboPodList = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colPodId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPodPortCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPodCityName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCities = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repCountries = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.cboDepartments = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDepartmentPrefix = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboTotalVolume = new DevExpress.XtraEditors.ButtonEdit();
			this.txtTypeOfShipment = new DevExpress.XtraEditors.LookUpEdit();
			this.cboCustomers = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.grpShipmentInfo = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblPolList = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblPodList = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblClientName = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblConsigneeName = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblTotalVolume = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblAgentsList = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblCarrierList = new DevExpress.XtraLayout.LayoutControlItem();
			this.tabsGroup = new DevExpress.XtraLayout.TabbedControlGroup();
			this.tabRealCost = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.tabSelling = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblNotes = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblShipperName = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblTerms = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblTermDescription = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.grpXoInfo = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblXONumber = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblQuotationDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblHandledBy = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblFollowUpDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblDepartment = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblJobNo = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblBookedDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblSales = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.grpStatusInfo = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblStatus = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblreason = new DevExpress.XtraLayout.LayoutControlItem();
			this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
			this.hideContainerRight = new DevExpress.XtraBars.Docking.AutoHideContainer();
			this.dockXoHistory = new DevExpress.XtraBars.Docking.DockPanel();
			this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
			this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
			this.gcQuoteDetails = new DevExpress.XtraGrid.GridControl();
			this.gvQuoteDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colHistoryId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistoryQuotationId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistoryVersionNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistoryQuoteDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistoryDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistorySeaCarrierId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistoryTransitTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistoryValidity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistoryValidityDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistoryCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistoryTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistoryTotalLL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistoryTotalUSD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistoryNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistoryTotalVatAmountLL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHistoryTotalVatAmountUSD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
			this.lcMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsQuotations)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboSales.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTermDescription.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboTermsList.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipperName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcSellings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvSellings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSellingCurrenciesList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSellingSeaCarrierList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcRealCosts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvRealCosts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSeaCarrierList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCurrenciesList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repAgentList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtBookedDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtBookedDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboConsigneesList.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtJobNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtFollowUp.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtFollowUp.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCarrierList.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboAgentsList.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtXONumber.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboHandledBy.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsersList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtQuotationDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtQuotationDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboPolList.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboPodList.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCities)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCountries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboDepartments.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboTotalVolume.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTypeOfShipment.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCustomers.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpShipmentInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPolList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPodList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblClientName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblConsigneeName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalVolume)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAgentsList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCarrierList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tabsGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tabRealCost)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tabSelling)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNotes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblShipperName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTerms)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTermDescription)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpXoInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblXONumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblQuotationDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblHandledBy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblFollowUpDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDepartment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJobNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblBookedDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpStatusInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblreason)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
			this.hideContainerRight.SuspendLayout();
			this.dockXoHistory.SuspendLayout();
			this.controlContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
			this.layoutControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcQuoteDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvQuoteDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
			this.SuspendLayout();
			// 
			// btnMainExit
			// 
			this.btnMainExit.Name = "btnMainExit";
			// 
			// ribbonControl
			// 
			this.ribbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnSave,
            this.biClose,
            this.btnSaveAndClose,
            this.btnCreateNewJob,
            this.btnMeeting,
            this.bmiPrintProfile,
            this.bmiPrintSummary,
            this.btnPrint,
            this.bmiPrintDirectory,
            this.bmiPrintTaskList,
            this.btnRefresh,
            this.btnNew,
            this.btnSaveAs,
            this.btnUrgent,
            this.rgQuotationStatusOptions});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ribbonControl.MaxItemId = 38;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.OptionsMenuMinWidth = 385;
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl.Size = new System.Drawing.Size(1527, 193);
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
			this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
			// 
			// biClose
			// 
			this.biClose.Caption = "Close";
			this.biClose.Id = 2;
			this.biClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.biClose.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg";
			this.biClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biClose.ImageOptions.SvgImage")));
			this.biClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape);
			this.biClose.Name = "biClose";
			this.biClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
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
			this.btnSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biSaveAndClose_ItemClick);
			// 
			// btnCreateNewJob
			// 
			this.btnCreateNewJob.Caption = "Create New Job";
			this.btnCreateNewJob.Enabled = false;
			this.btnCreateNewJob.Id = 5;
			this.btnCreateNewJob.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnCreateNewJob.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.MailMerge.svg";
			this.btnCreateNewJob.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreateNewJob.ImageOptions.SvgImage")));
			this.btnCreateNewJob.Name = "btnCreateNewJob";
			this.btnCreateNewJob.VisibleInSearchMenu = false;
			this.btnCreateNewJob.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateNewJob_ItemClick);
			// 
			// btnMeeting
			// 
			this.btnMeeting.Caption = "Meeting";
			this.btnMeeting.Enabled = false;
			this.btnMeeting.Id = 6;
			this.btnMeeting.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnMeeting.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Meeting.svg";
			this.btnMeeting.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMeeting.ImageOptions.SvgImage")));
			this.btnMeeting.Name = "btnMeeting";
			this.btnMeeting.VisibleInSearchMenu = false;
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
			this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
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
			// btnRefresh
			// 
			this.btnRefresh.Caption = "Refresh";
			this.btnRefresh.Id = 17;
			this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
			// 
			// btnNew
			// 
			this.btnNew.Caption = "Add New";
			this.btnNew.Enabled = false;
			this.btnNew.Id = 18;
			this.btnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNew.ImageOptions.SvgImage")));
			this.btnNew.Name = "btnNew";
			this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
			// 
			// btnSaveAs
			// 
			this.btnSaveAs.Caption = "Save As";
			this.btnSaveAs.Enabled = false;
			this.btnSaveAs.Id = 20;
			this.btnSaveAs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.ImageOptions.Image")));
			this.btnSaveAs.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.ImageOptions.LargeImage")));
			this.btnSaveAs.Name = "btnSaveAs";
			this.btnSaveAs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAs_ItemClick);
			// 
			// btnUrgent
			// 
			this.btnUrgent.Caption = "Is Urgent";
			this.btnUrgent.Enabled = false;
			this.btnUrgent.Id = 22;
			this.btnUrgent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUrgent.ImageOptions.SvgImage")));
			this.btnUrgent.Name = "btnUrgent";
			this.btnUrgent.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrgent_CheckedChanged);
			// 
			// rgQuotationStatusOptions
			// 
			this.rgQuotationStatusOptions.Caption = "ribbonGalleryBarItem1";
			// 
			// 
			// 
			this.rgQuotationStatusOptions.Gallery.ColumnCount = 3;
			this.rgQuotationStatusOptions.Gallery.DrawImageBackground = false;
			galleryItemGroup1.Caption = "Group2";
			galleryItem1.Caption = "Requested";
			galleryItem1.Checked = true;
			galleryItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
			galleryItem1.Value = 0;
			galleryItem2.Caption = "Quoted";
			galleryItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
			galleryItem2.Value = 1;
			galleryItem3.Caption = "Booked";
			galleryItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
			galleryItem3.Value = 2;
			galleryItem4.Caption = "Lost";
			galleryItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage3")));
			galleryItem4.Value = 3;
			galleryItem5.Caption = "Canceled";
			galleryItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage4")));
			galleryItem5.Value = 4;
			galleryItem6.Caption = "N/A";
			galleryItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage5")));
			galleryItem6.Value = 5;
			galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4,
            galleryItem5,
            galleryItem6});
			this.rgQuotationStatusOptions.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
			this.rgQuotationStatusOptions.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck;
			this.rgQuotationStatusOptions.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
			this.rgQuotationStatusOptions.Gallery.ShowItemText = true;
			this.rgQuotationStatusOptions.Id = 37;
			this.rgQuotationStatusOptions.Name = "rgQuotationStatusOptions";
			this.rgQuotationStatusOptions.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgQuotationStatusOptions_GalleryItemClick);
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8,
            this.ribbonPageGroup1,
            this.ribbonPageGroup7,
            this.ribbonPageGroup4,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5,
            this.rbQuotationStatusOptions});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "QUOTATION";
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
			this.ribbonPageGroup1.MergeOrder = 0;
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Save";
			// 
			// ribbonPageGroup7
			// 
			this.ribbonPageGroup7.AllowTextClipping = false;
			this.ribbonPageGroup7.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup7.ItemLinks.Add(this.btnSaveAs);
			this.ribbonPageGroup7.ItemLinks.Add(this.btnRefresh, true);
			this.ribbonPageGroup7.MergeOrder = 0;
			this.ribbonPageGroup7.Name = "ribbonPageGroup7";
			this.ribbonPageGroup7.Text = "Edit";
			// 
			// ribbonPageGroup4
			// 
			this.ribbonPageGroup4.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup4.ItemLinks.Add(this.btnPrint);
			this.ribbonPageGroup4.ItemLinks.Add(this.btnMeeting);
			this.ribbonPageGroup4.ItemLinks.Add(this.btnCreateNewJob, true);
			this.ribbonPageGroup4.MergeOrder = 0;
			this.ribbonPageGroup4.Name = "ribbonPageGroup4";
			this.ribbonPageGroup4.Text = "Actions";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
			this.ribbonPageGroup3.AllowTextClipping = false;
			this.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup3.ItemLinks.Add(this.biClose);
			this.ribbonPageGroup3.MergeOrder = 0;
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.Text = "Close";
			// 
			// ribbonPageGroup5
			// 
			this.ribbonPageGroup5.ItemLinks.Add(this.btnUrgent);
			this.ribbonPageGroup5.Name = "ribbonPageGroup5";
			this.ribbonPageGroup5.Text = "Urgent Status";
			// 
			// rbQuotationStatusOptions
			// 
			this.rbQuotationStatusOptions.ItemLinks.Add(this.rgQuotationStatusOptions);
			this.rbQuotationStatusOptions.Name = "rbQuotationStatusOptions";
			this.rbQuotationStatusOptions.Text = "Quotation Status Options";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 882);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.ribbonControl;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1527, 30);
			// 
			// lcMain
			// 
			this.lcMain.AllowCustomization = false;
			this.lcMain.Controls.Add(this.btnEditSales);
			this.lcMain.Controls.Add(this.txtReason);
			this.lcMain.Controls.Add(this.cboSales);
			this.lcMain.Controls.Add(this.txtTermDescription);
			this.lcMain.Controls.Add(this.cboTermsList);
			this.lcMain.Controls.Add(this.txtShipperName);
			this.lcMain.Controls.Add(this.txtNotes);
			this.lcMain.Controls.Add(this.btnEditCostSelling);
			this.lcMain.Controls.Add(this.btnAddCostSelling);
			this.lcMain.Controls.Add(this.gcSellings);
			this.lcMain.Controls.Add(this.gcRealCosts);
			this.lcMain.Controls.Add(this.dtBookedDate);
			this.lcMain.Controls.Add(this.cboConsigneesList);
			this.lcMain.Controls.Add(this.txtJobNo);
			this.lcMain.Controls.Add(this.dtFollowUp);
			this.lcMain.Controls.Add(this.cboCarrierList);
			this.lcMain.Controls.Add(this.cboAgentsList);
			this.lcMain.Controls.Add(this.txtXONumber);
			this.lcMain.Controls.Add(this.cboHandledBy);
			this.lcMain.Controls.Add(this.dtQuotationDate);
			this.lcMain.Controls.Add(this.cboStatus);
			this.lcMain.Controls.Add(this.cboPolList);
			this.lcMain.Controls.Add(this.cboPodList);
			this.lcMain.Controls.Add(this.cboDepartments);
			this.lcMain.Controls.Add(this.cboTotalVolume);
			this.lcMain.Controls.Add(this.txtTypeOfShipment);
			this.lcMain.Controls.Add(this.cboCustomers);
			this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lcMain.Location = new System.Drawing.Point(0, 193);
			this.lcMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lcMain.Name = "lcMain";
			this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(605, 287, 907, 596);
			this.lcMain.Root = this.layoutControlGroup1;
			this.lcMain.Size = new System.Drawing.Size(1501, 689);
			this.lcMain.TabIndex = 7;
			this.lcMain.Text = "layoutControl1";
			// 
			// btnEditSales
			// 
			this.btnEditSales.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditSales.ImageOptions.SvgImage")));
			this.btnEditSales.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			this.btnEditSales.Location = new System.Drawing.Point(699, 180);
			this.btnEditSales.Name = "btnEditSales";
			this.btnEditSales.Size = new System.Drawing.Size(26, 27);
			this.btnEditSales.StyleController = this.lcMain;
			this.btnEditSales.TabIndex = 27;
			this.btnEditSales.Click += new System.EventHandler(this.btnEditSales_Click);
			// 
			// txtReason
			// 
			this.txtReason.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "Reason", true));
			this.txtReason.Location = new System.Drawing.Point(779, 633);
			this.txtReason.MenuManager = this.ribbonControl;
			this.txtReason.Name = "txtReason";
			this.txtReason.Size = new System.Drawing.Size(698, 22);
			this.txtReason.StyleController = this.lcMain;
			this.txtReason.TabIndex = 25;
			// 
			// bsQuotations
			// 
			this.bsQuotations.DataSource = typeof(QuotationModel);
			// 
			// cboSales
			// 
			this.cboSales.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "SalesId", true));
			this.cboSales.Location = new System.Drawing.Point(179, 180);
			this.cboSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboSales.Name = "cboSales";
			this.cboSales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboSales.Properties.DisplayMember = "UserName";
			this.cboSales.Properties.NullText = "";
			this.cboSales.Properties.PopupView = this.gridView7;
			this.cboSales.Properties.ReadOnly = true;
			this.cboSales.Properties.ShowAddNewButton = true;
			this.cboSales.Properties.UseReadOnlyAppearance = false;
			this.cboSales.Properties.ValueMember = "Id";
			this.cboSales.Size = new System.Drawing.Size(516, 22);
			this.cboSales.StyleController = this.lcMain;
			this.cboSales.TabIndex = 24;
			this.cboSales.ToolTipTitle = "Double Click to change Sales person.";
			this.cboSales.DoubleClick += new System.EventHandler(this.cboSales_DoubleClick);
			// 
			// gridView7
			// 
			this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3});
			this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView7.Name = "gridView7";
			this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView7.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Id";
			this.gridColumn2.FieldName = "Id";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 0;
			this.gridColumn2.Width = 20;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Name";
			this.gridColumn3.FieldName = "UserName";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 1;
			this.gridColumn3.Width = 352;
			// 
			// txtTermDescription
			// 
			this.txtTermDescription.Location = new System.Drawing.Point(1106, 313);
			this.txtTermDescription.MenuManager = this.ribbonControl;
			this.txtTermDescription.Name = "txtTermDescription";
			this.txtTermDescription.Properties.ReadOnly = true;
			this.txtTermDescription.Size = new System.Drawing.Size(371, 22);
			this.txtTermDescription.StyleController = this.lcMain;
			this.txtTermDescription.TabIndex = 11;
			// 
			// cboTermsList
			// 
			this.cboTermsList.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "TermsId", true));
			this.cboTermsList.Location = new System.Drawing.Point(833, 313);
			this.cboTermsList.MenuManager = this.ribbonControl;
			this.cboTermsList.Name = "cboTermsList";
			this.cboTermsList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboTermsList.Properties.DisplayMember = "Description";
			this.cboTermsList.Properties.NullText = "";
			this.cboTermsList.Properties.PopupView = this.gridView6;
			this.cboTermsList.Properties.ValueMember = "Id";
			this.cboTermsList.Size = new System.Drawing.Size(201, 22);
			this.cboTermsList.StyleController = this.lcMain;
			this.cboTermsList.TabIndex = 10;
			this.cboTermsList.EditValueChanged += new System.EventHandler(this.cboTermsList_EditValueChanged);
			this.cboTermsList.Validated += new System.EventHandler(this.cboTermsList_Validated);
			// 
			// gridView6
			// 
			this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTermsId,
            this.coltermCode,
            this.coltermsDescription});
			this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView6.Name = "gridView6";
			this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView6.OptionsView.ShowGroupPanel = false;
			// 
			// colTermsId
			// 
			this.colTermsId.Caption = "Id";
			this.colTermsId.FieldName = "Id";
			this.colTermsId.Name = "colTermsId";
			this.colTermsId.Visible = true;
			this.colTermsId.VisibleIndex = 0;
			this.colTermsId.Width = 71;
			// 
			// coltermCode
			// 
			this.coltermCode.Caption = "Code";
			this.coltermCode.FieldName = "TermCode";
			this.coltermCode.Name = "coltermCode";
			this.coltermCode.Visible = true;
			this.coltermCode.VisibleIndex = 1;
			this.coltermCode.Width = 142;
			// 
			// coltermsDescription
			// 
			this.coltermsDescription.Caption = "Description";
			this.coltermsDescription.FieldName = "Description";
			this.coltermsDescription.Name = "coltermsDescription";
			this.coltermsDescription.Visible = true;
			this.coltermsDescription.VisibleIndex = 2;
			this.coltermsDescription.Width = 1025;
			// 
			// txtShipperName
			// 
			this.txtShipperName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsQuotations, "ShipperName", true));
			this.txtShipperName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "ShipperName", true));
			this.txtShipperName.Location = new System.Drawing.Point(179, 287);
			this.txtShipperName.MenuManager = this.ribbonControl;
			this.txtShipperName.Name = "txtShipperName";
			this.txtShipperName.Size = new System.Drawing.Size(550, 22);
			this.txtShipperName.StyleController = this.lcMain;
			this.txtShipperName.TabIndex = 8;
			this.txtShipperName.ToolTip = "Shipper Name if available";
			// 
			// txtNotes
			// 
			this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsQuotations, "Notes", true));
			this.txtNotes.Location = new System.Drawing.Point(179, 469);
			this.txtNotes.MenuManager = this.ribbonControl;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(550, 79);
			this.txtNotes.StyleController = this.lcMain;
			this.txtNotes.TabIndex = 18;
			// 
			// btnEditCostSelling
			// 
			this.btnEditCostSelling.Location = new System.Drawing.Point(1261, 552);
			this.btnEditCostSelling.Name = "btnEditCostSelling";
			this.btnEditCostSelling.Size = new System.Drawing.Size(105, 27);
			this.btnEditCostSelling.StyleController = this.lcMain;
			this.btnEditCostSelling.TabIndex = 19;
			this.btnEditCostSelling.Text = "Edit Cost/Selling";
			this.btnEditCostSelling.Click += new System.EventHandler(this.btnEditCostSelling_Click);
			// 
			// btnAddCostSelling
			// 
			this.btnAddCostSelling.Location = new System.Drawing.Point(1370, 552);
			this.btnAddCostSelling.Name = "btnAddCostSelling";
			this.btnAddCostSelling.Size = new System.Drawing.Size(107, 27);
			this.btnAddCostSelling.StyleController = this.lcMain;
			this.btnAddCostSelling.TabIndex = 20;
			this.btnAddCostSelling.Text = "Add Cost/Selling";
			this.btnAddCostSelling.Click += new System.EventHandler(this.btnAddCostSelling_Click);
			// 
			// gcSellings
			// 
			this.gcSellings.Location = new System.Drawing.Point(745, 405);
			this.gcSellings.MainView = this.gvSellings;
			this.gcSellings.MenuManager = this.ribbonControl;
			this.gcSellings.Name = "gcSellings";
			this.gcSellings.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit3,
            this.repositoryItemDateEdit4,
            this.repSellingSeaCarrierList,
            this.repSellingCurrenciesList});
			this.gcSellings.Size = new System.Drawing.Size(720, 131);
			this.gcSellings.TabIndex = 1;
			this.gcSellings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSellings});
			this.gcSellings.DoubleClick += new System.EventHandler(this.gcSellingList_DoubleClick);
			// 
			// gvSellings
			// 
			this.gvSellings.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSellingHeaderId,
            this.colSellingQuotationId,
            this.colSellingVersionNo,
            this.colSellingQuoteDate,
            this.colSellingDepartmentId,
            this.colSellingTransitTime,
            this.colSellingValidity,
            this.colSellingValidityDate,
            this.colSellingCurrencyId,
            this.costSellingTotalAmount,
            this.colSellingTotalLocalAmount,
            this.colSellingTotalForeignAmount,
            this.costSellingNotes,
            this.colTotalSellingVatAmountLL,
            this.colTotalSellingVatAmountUSD});
			this.gvSellings.GridControl = this.gcSellings;
			this.gvSellings.Name = "gvSellings";
			this.gvSellings.OptionsBehavior.Editable = false;
			this.gvSellings.OptionsBehavior.ReadOnly = true;
			this.gvSellings.OptionsCustomization.AllowGroup = false;
			this.gvSellings.OptionsMenu.ShowGroupSortSummaryItems = false;
			this.gvSellings.OptionsView.AllowHtmlDrawGroups = false;
			this.gvSellings.OptionsView.ColumnAutoWidth = false;
			this.gvSellings.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
			this.gvSellings.OptionsView.ShowGroupedColumns = true;
			this.gvSellings.OptionsView.ShowGroupExpandCollapseButtons = false;
			this.gvSellings.OptionsView.ShowGroupPanel = false;
			// 
			// colSellingHeaderId
			// 
			this.colSellingHeaderId.Caption = "Id";
			this.colSellingHeaderId.FieldName = "Id";
			this.colSellingHeaderId.MinWidth = 25;
			this.colSellingHeaderId.Name = "colSellingHeaderId";
			this.colSellingHeaderId.Width = 73;
			// 
			// colSellingQuotationId
			// 
			this.colSellingQuotationId.Caption = "Quotation";
			this.colSellingQuotationId.FieldName = "QuotationId";
			this.colSellingQuotationId.MinWidth = 25;
			this.colSellingQuotationId.Name = "colSellingQuotationId";
			this.colSellingQuotationId.Width = 94;
			// 
			// colSellingVersionNo
			// 
			this.colSellingVersionNo.Caption = "Version No";
			this.colSellingVersionNo.FieldName = "VersionNo";
			this.colSellingVersionNo.MinWidth = 25;
			this.colSellingVersionNo.Name = "colSellingVersionNo";
			this.colSellingVersionNo.Visible = true;
			this.colSellingVersionNo.VisibleIndex = 0;
			this.colSellingVersionNo.Width = 80;
			// 
			// colSellingQuoteDate
			// 
			this.colSellingQuoteDate.Caption = "Quote Date";
			this.colSellingQuoteDate.ColumnEdit = this.repositoryItemDateEdit3;
			this.colSellingQuoteDate.FieldName = "QuoteDate";
			this.colSellingQuoteDate.MinWidth = 25;
			this.colSellingQuoteDate.Name = "colSellingQuoteDate";
			this.colSellingQuoteDate.Visible = true;
			this.colSellingQuoteDate.VisibleIndex = 1;
			// 
			// repositoryItemDateEdit3
			// 
			this.repositoryItemDateEdit3.AutoHeight = false;
			this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit3.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repositoryItemDateEdit3.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.repositoryItemDateEdit3.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
			this.repositoryItemDateEdit3.UseMaskAsDisplayFormat = true;
			// 
			// colSellingDepartmentId
			// 
			this.colSellingDepartmentId.Caption = "Department";
			this.colSellingDepartmentId.FieldName = "DepartmentId";
			this.colSellingDepartmentId.MinWidth = 25;
			this.colSellingDepartmentId.Name = "colSellingDepartmentId";
			this.colSellingDepartmentId.Width = 133;
			// 
			// colSellingTransitTime
			// 
			this.colSellingTransitTime.Caption = "Transit Time";
			this.colSellingTransitTime.FieldName = "TransitTime";
			this.colSellingTransitTime.MinWidth = 25;
			this.colSellingTransitTime.Name = "colSellingTransitTime";
			this.colSellingTransitTime.Visible = true;
			this.colSellingTransitTime.VisibleIndex = 2;
			this.colSellingTransitTime.Width = 93;
			// 
			// colSellingValidity
			// 
			this.colSellingValidity.Caption = "Validity";
			this.colSellingValidity.FieldName = "Validity";
			this.colSellingValidity.MinWidth = 25;
			this.colSellingValidity.Name = "colSellingValidity";
			this.colSellingValidity.Visible = true;
			this.colSellingValidity.VisibleIndex = 3;
			this.colSellingValidity.Width = 58;
			// 
			// colSellingValidityDate
			// 
			this.colSellingValidityDate.Caption = "Validity Date";
			this.colSellingValidityDate.ColumnEdit = this.repositoryItemDateEdit4;
			this.colSellingValidityDate.FieldName = "ValidityDate";
			this.colSellingValidityDate.MinWidth = 25;
			this.colSellingValidityDate.Name = "colSellingValidityDate";
			this.colSellingValidityDate.Visible = true;
			this.colSellingValidityDate.VisibleIndex = 4;
			this.colSellingValidityDate.Width = 94;
			// 
			// repositoryItemDateEdit4
			// 
			this.repositoryItemDateEdit4.AutoHeight = false;
			this.repositoryItemDateEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit4.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repositoryItemDateEdit4.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.repositoryItemDateEdit4.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repositoryItemDateEdit4.Name = "repositoryItemDateEdit4";
			this.repositoryItemDateEdit4.UseMaskAsDisplayFormat = true;
			// 
			// colSellingCurrencyId
			// 
			this.colSellingCurrencyId.Caption = "Currency";
			this.colSellingCurrencyId.ColumnEdit = this.repSellingCurrenciesList;
			this.colSellingCurrencyId.FieldName = "CurrencyId";
			this.colSellingCurrencyId.MinWidth = 25;
			this.colSellingCurrencyId.Name = "colSellingCurrencyId";
			this.colSellingCurrencyId.Visible = true;
			this.colSellingCurrencyId.VisibleIndex = 5;
			this.colSellingCurrencyId.Width = 69;
			// 
			// repSellingCurrenciesList
			// 
			this.repSellingCurrenciesList.AutoHeight = false;
			this.repSellingCurrenciesList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repSellingCurrenciesList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCode", "Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repSellingCurrenciesList.DisplayMember = "CurrencyCode";
			this.repSellingCurrenciesList.Name = "repSellingCurrenciesList";
			this.repSellingCurrenciesList.NullText = "";
			this.repSellingCurrenciesList.ValueMember = "Id";
			// 
			// costSellingTotalAmount
			// 
			this.costSellingTotalAmount.Caption = "Total Amount";
			this.costSellingTotalAmount.DisplayFormat.FormatString = "{0:n2}";
			this.costSellingTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.costSellingTotalAmount.FieldName = "TotalAmount";
			this.costSellingTotalAmount.MinWidth = 25;
			this.costSellingTotalAmount.Name = "costSellingTotalAmount";
			this.costSellingTotalAmount.Visible = true;
			this.costSellingTotalAmount.VisibleIndex = 6;
			this.costSellingTotalAmount.Width = 100;
			// 
			// colSellingTotalLocalAmount
			// 
			this.colSellingTotalLocalAmount.Caption = "Total L.L.";
			this.colSellingTotalLocalAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colSellingTotalLocalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSellingTotalLocalAmount.MinWidth = 25;
			this.colSellingTotalLocalAmount.Name = "colSellingTotalLocalAmount";
			this.colSellingTotalLocalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "SUM={0:0.##}")});
			this.colSellingTotalLocalAmount.Visible = true;
			this.colSellingTotalLocalAmount.VisibleIndex = 7;
			this.colSellingTotalLocalAmount.Width = 150;
			// 
			// colSellingTotalForeignAmount
			// 
			this.colSellingTotalForeignAmount.Caption = "Total USD";
			this.colSellingTotalForeignAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colSellingTotalForeignAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSellingTotalForeignAmount.MinWidth = 25;
			this.colSellingTotalForeignAmount.Name = "colSellingTotalForeignAmount";
			this.colSellingTotalForeignAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "SUM={0:0.##}")});
			this.colSellingTotalForeignAmount.Visible = true;
			this.colSellingTotalForeignAmount.VisibleIndex = 8;
			this.colSellingTotalForeignAmount.Width = 150;
			// 
			// costSellingNotes
			// 
			this.costSellingNotes.Caption = "Notes";
			this.costSellingNotes.FieldName = "Notes";
			this.costSellingNotes.MinWidth = 25;
			this.costSellingNotes.Name = "costSellingNotes";
			this.costSellingNotes.Visible = true;
			this.costSellingNotes.VisibleIndex = 9;
			this.costSellingNotes.Width = 429;
			// 
			// colTotalSellingVatAmountLL
			// 
			this.colTotalSellingVatAmountLL.Caption = "Total Vat Amount LL";
			this.colTotalSellingVatAmountLL.DisplayFormat.FormatString = "{0:n2}";
			this.colTotalSellingVatAmountLL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotalSellingVatAmountLL.FieldName = "TotalLocalVatAmount";
			this.colTotalSellingVatAmountLL.MinWidth = 25;
			this.colTotalSellingVatAmountLL.Name = "colTotalSellingVatAmountLL";
			this.colTotalSellingVatAmountLL.Visible = true;
			this.colTotalSellingVatAmountLL.VisibleIndex = 10;
			this.colTotalSellingVatAmountLL.Width = 150;
			// 
			// colTotalSellingVatAmountUSD
			// 
			this.colTotalSellingVatAmountUSD.Caption = "Total Vat Amount USD";
			this.colTotalSellingVatAmountUSD.DisplayFormat.FormatString = "{0:n2}";
			this.colTotalSellingVatAmountUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotalSellingVatAmountUSD.FieldName = "TotalForeignVatAmount";
			this.colTotalSellingVatAmountUSD.MinWidth = 25;
			this.colTotalSellingVatAmountUSD.Name = "colTotalSellingVatAmountUSD";
			this.colTotalSellingVatAmountUSD.Visible = true;
			this.colTotalSellingVatAmountUSD.VisibleIndex = 11;
			this.colTotalSellingVatAmountUSD.Width = 150;
			// 
			// repSellingSeaCarrierList
			// 
			this.repSellingSeaCarrierList.AutoHeight = false;
			this.repSellingSeaCarrierList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repSellingSeaCarrierList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repSellingSeaCarrierList.DisplayMember = "CarrierName";
			this.repSellingSeaCarrierList.Name = "repSellingSeaCarrierList";
			this.repSellingSeaCarrierList.NullText = "";
			this.repSellingSeaCarrierList.ValueMember = "Id";
			// 
			// gcRealCosts
			// 
			this.gcRealCosts.Location = new System.Drawing.Point(745, 405);
			this.gcRealCosts.MainView = this.gvRealCosts;
			this.gcRealCosts.MenuManager = this.ribbonControl;
			this.gcRealCosts.Name = "gcRealCosts";
			this.gcRealCosts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repAgentList,
            this.repositoryItemDateEdit2,
            this.repSeaCarrierList,
            this.repCurrenciesList});
			this.gcRealCosts.Size = new System.Drawing.Size(720, 131);
			this.gcRealCosts.TabIndex = 14;
			this.gcRealCosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRealCosts});
			this.gcRealCosts.DoubleClick += new System.EventHandler(this.gcCostList_DoubleClick);
			// 
			// gvRealCosts
			// 
			this.gvRealCosts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHeaderId,
            this.colCostQuotationId,
            this.colCostVersionNo,
            this.colCostDate,
            this.colCostDepartmentId,
            this.colCostSeaCarrierId,
            this.colCostTransitTime,
            this.colCostValidity,
            this.colCostValidityDate,
            this.colCostCurrencyId,
            this.colCostTotalAmount,
            this.colCostTotalLocalAmount,
            this.colCostTotalForeignAmount,
            this.colCostNotes,
            this.colTotalLocalVatAmount,
            this.colTotalForeignVatAmount});
			this.gvRealCosts.GridControl = this.gcRealCosts;
			this.gvRealCosts.Name = "gvRealCosts";
			this.gvRealCosts.OptionsBehavior.Editable = false;
			this.gvRealCosts.OptionsBehavior.ReadOnly = true;
			this.gvRealCosts.OptionsCustomization.AllowGroup = false;
			this.gvRealCosts.OptionsMenu.ShowGroupSortSummaryItems = false;
			this.gvRealCosts.OptionsView.AllowHtmlDrawGroups = false;
			this.gvRealCosts.OptionsView.ColumnAutoWidth = false;
			this.gvRealCosts.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
			this.gvRealCosts.OptionsView.ShowGroupedColumns = true;
			this.gvRealCosts.OptionsView.ShowGroupExpandCollapseButtons = false;
			this.gvRealCosts.OptionsView.ShowGroupPanel = false;
			// 
			// colHeaderId
			// 
			this.colHeaderId.Caption = "Id";
			this.colHeaderId.FieldName = "Id";
			this.colHeaderId.MinWidth = 25;
			this.colHeaderId.Name = "colHeaderId";
			this.colHeaderId.Width = 73;
			// 
			// colCostQuotationId
			// 
			this.colCostQuotationId.Caption = "Quotation";
			this.colCostQuotationId.FieldName = "QuotationId";
			this.colCostQuotationId.MinWidth = 25;
			this.colCostQuotationId.Name = "colCostQuotationId";
			this.colCostQuotationId.Width = 94;
			// 
			// colCostVersionNo
			// 
			this.colCostVersionNo.Caption = "Version No";
			this.colCostVersionNo.FieldName = "VersionNo";
			this.colCostVersionNo.MinWidth = 25;
			this.colCostVersionNo.Name = "colCostVersionNo";
			this.colCostVersionNo.Visible = true;
			this.colCostVersionNo.VisibleIndex = 1;
			this.colCostVersionNo.Width = 83;
			// 
			// colCostDate
			// 
			this.colCostDate.Caption = "Quote Date";
			this.colCostDate.ColumnEdit = this.repositoryItemDateEdit1;
			this.colCostDate.FieldName = "QuoteDate";
			this.colCostDate.MinWidth = 25;
			this.colCostDate.Name = "colCostDate";
			this.colCostDate.Visible = true;
			this.colCostDate.VisibleIndex = 2;
			this.colCostDate.Width = 91;
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
			// colCostDepartmentId
			// 
			this.colCostDepartmentId.Caption = "Department";
			this.colCostDepartmentId.FieldName = "DepartmentId";
			this.colCostDepartmentId.MinWidth = 25;
			this.colCostDepartmentId.Name = "colCostDepartmentId";
			this.colCostDepartmentId.Width = 133;
			// 
			// colCostSeaCarrierId
			// 
			this.colCostSeaCarrierId.Caption = "SeaCarrier";
			this.colCostSeaCarrierId.ColumnEdit = this.repSeaCarrierList;
			this.colCostSeaCarrierId.FieldName = "SeaCarrierId";
			this.colCostSeaCarrierId.MinWidth = 25;
			this.colCostSeaCarrierId.Name = "colCostSeaCarrierId";
			this.colCostSeaCarrierId.Visible = true;
			this.colCostSeaCarrierId.VisibleIndex = 0;
			this.colCostSeaCarrierId.Width = 139;
			// 
			// repSeaCarrierList
			// 
			this.repSeaCarrierList.AutoHeight = false;
			this.repSeaCarrierList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repSeaCarrierList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repSeaCarrierList.DisplayMember = "CarrierName";
			this.repSeaCarrierList.Name = "repSeaCarrierList";
			this.repSeaCarrierList.NullText = "";
			this.repSeaCarrierList.ValueMember = "Id";
			// 
			// colCostTransitTime
			// 
			this.colCostTransitTime.Caption = "Transit Time";
			this.colCostTransitTime.FieldName = "TransitTime";
			this.colCostTransitTime.MinWidth = 25;
			this.colCostTransitTime.Name = "colCostTransitTime";
			this.colCostTransitTime.Visible = true;
			this.colCostTransitTime.VisibleIndex = 3;
			this.colCostTransitTime.Width = 100;
			// 
			// colCostValidity
			// 
			this.colCostValidity.Caption = "Validity";
			this.colCostValidity.FieldName = "Validity";
			this.colCostValidity.MinWidth = 25;
			this.colCostValidity.Name = "colCostValidity";
			this.colCostValidity.Visible = true;
			this.colCostValidity.VisibleIndex = 4;
			this.colCostValidity.Width = 59;
			// 
			// colCostValidityDate
			// 
			this.colCostValidityDate.Caption = "Validity Date";
			this.colCostValidityDate.ColumnEdit = this.repositoryItemDateEdit2;
			this.colCostValidityDate.FieldName = "ValidityDate";
			this.colCostValidityDate.MinWidth = 25;
			this.colCostValidityDate.Name = "colCostValidityDate";
			this.colCostValidityDate.Visible = true;
			this.colCostValidityDate.VisibleIndex = 5;
			this.colCostValidityDate.Width = 94;
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
			this.repositoryItemDateEdit2.UseMaskAsDisplayFormat = true;
			// 
			// colCostCurrencyId
			// 
			this.colCostCurrencyId.Caption = "Currency";
			this.colCostCurrencyId.ColumnEdit = this.repCurrenciesList;
			this.colCostCurrencyId.FieldName = "CurrencyId";
			this.colCostCurrencyId.MinWidth = 25;
			this.colCostCurrencyId.Name = "colCostCurrencyId";
			this.colCostCurrencyId.Visible = true;
			this.colCostCurrencyId.VisibleIndex = 6;
			this.colCostCurrencyId.Width = 67;
			// 
			// repCurrenciesList
			// 
			this.repCurrenciesList.AutoHeight = false;
			this.repCurrenciesList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCurrenciesList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCode", "Currency Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repCurrenciesList.DisplayMember = "CurrencyCode";
			this.repCurrenciesList.Name = "repCurrenciesList";
			this.repCurrenciesList.NullText = "";
			this.repCurrenciesList.ValueMember = "Id";
			// 
			// colCostTotalAmount
			// 
			this.colCostTotalAmount.Caption = "Total Amount";
			this.colCostTotalAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colCostTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colCostTotalAmount.FieldName = "TotalAmount";
			this.colCostTotalAmount.MinWidth = 25;
			this.colCostTotalAmount.Name = "colCostTotalAmount";
			this.colCostTotalAmount.Visible = true;
			this.colCostTotalAmount.VisibleIndex = 7;
			this.colCostTotalAmount.Width = 100;
			// 
			// colCostTotalLocalAmount
			// 
			this.colCostTotalLocalAmount.Caption = "Total L.L.";
			this.colCostTotalLocalAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colCostTotalLocalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colCostTotalLocalAmount.MinWidth = 25;
			this.colCostTotalLocalAmount.Name = "colCostTotalLocalAmount";
			this.colCostTotalLocalAmount.OptionsColumn.ReadOnly = true;
			this.colCostTotalLocalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "SUM={0:n}")});
			this.colCostTotalLocalAmount.Visible = true;
			this.colCostTotalLocalAmount.VisibleIndex = 8;
			this.colCostTotalLocalAmount.Width = 150;
			// 
			// colCostTotalForeignAmount
			// 
			this.colCostTotalForeignAmount.Caption = "Total USD";
			this.colCostTotalForeignAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colCostTotalForeignAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colCostTotalForeignAmount.MinWidth = 25;
			this.colCostTotalForeignAmount.Name = "colCostTotalForeignAmount";
			this.colCostTotalForeignAmount.OptionsColumn.ReadOnly = true;
			this.colCostTotalForeignAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "SUM={0:n}")});
			this.colCostTotalForeignAmount.Visible = true;
			this.colCostTotalForeignAmount.VisibleIndex = 9;
			this.colCostTotalForeignAmount.Width = 150;
			// 
			// colCostNotes
			// 
			this.colCostNotes.Caption = "Notes";
			this.colCostNotes.FieldName = "Notes";
			this.colCostNotes.MinWidth = 25;
			this.colCostNotes.Name = "colCostNotes";
			this.colCostNotes.Visible = true;
			this.colCostNotes.VisibleIndex = 10;
			this.colCostNotes.Width = 429;
			// 
			// colTotalLocalVatAmount
			// 
			this.colTotalLocalVatAmount.Caption = "Total Vat Amount LL";
			this.colTotalLocalVatAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colTotalLocalVatAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotalLocalVatAmount.FieldName = "TotalLocalVatAmount";
			this.colTotalLocalVatAmount.MinWidth = 25;
			this.colTotalLocalVatAmount.Name = "colTotalLocalVatAmount";
			this.colTotalLocalVatAmount.OptionsColumn.ReadOnly = true;
			this.colTotalLocalVatAmount.Visible = true;
			this.colTotalLocalVatAmount.VisibleIndex = 11;
			this.colTotalLocalVatAmount.Width = 150;
			// 
			// colTotalForeignVatAmount
			// 
			this.colTotalForeignVatAmount.Caption = "Total Vat Amount USD";
			this.colTotalForeignVatAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colTotalForeignVatAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotalForeignVatAmount.FieldName = "TotalForeignVatAmount";
			this.colTotalForeignVatAmount.MinWidth = 25;
			this.colTotalForeignVatAmount.Name = "colTotalForeignVatAmount";
			this.colTotalForeignVatAmount.OptionsColumn.ReadOnly = true;
			this.colTotalForeignVatAmount.Visible = true;
			this.colTotalForeignVatAmount.VisibleIndex = 12;
			this.colTotalForeignVatAmount.Width = 150;
			// 
			// repAgentList
			// 
			this.repAgentList.AutoHeight = false;
			this.repAgentList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repAgentList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MemberName", "Agent Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repAgentList.DisplayMember = "MemberName";
			this.repAgentList.Name = "repAgentList";
			this.repAgentList.NullText = "";
			this.repAgentList.ValueMember = "Id";
			// 
			// dtBookedDate
			// 
			this.dtBookedDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "BookedDate", true));
			this.dtBookedDate.EditValue = null;
			this.dtBookedDate.Location = new System.Drawing.Point(179, 128);
			this.dtBookedDate.MenuManager = this.ribbonControl;
			this.dtBookedDate.Name = "dtBookedDate";
			this.dtBookedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtBookedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtBookedDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtBookedDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtBookedDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtBookedDate.Properties.ReadOnly = true;
			this.dtBookedDate.Properties.UseMaskAsDisplayFormat = true;
			this.dtBookedDate.Properties.UseReadOnlyAppearance = false;
			this.dtBookedDate.Size = new System.Drawing.Size(546, 22);
			this.dtBookedDate.StyleController = this.lcMain;
			this.dtBookedDate.TabIndex = 3;
			// 
			// cboConsigneesList
			// 
			this.cboConsigneesList.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "ConsigneeId", true));
			this.cboConsigneesList.EditValue = "";
			this.cboConsigneesList.Location = new System.Drawing.Point(788, 261);
			this.cboConsigneesList.MenuManager = this.ribbonControl;
			this.cboConsigneesList.Name = "cboConsigneesList";
			this.cboConsigneesList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboConsigneesList.Properties.DisplayMember = "CustomerName";
			this.cboConsigneesList.Properties.NullText = "";
			this.cboConsigneesList.Properties.PopupView = this.gridView8;
			this.cboConsigneesList.Properties.ValueMember = "Id";
			this.cboConsigneesList.Size = new System.Drawing.Size(689, 22);
			this.cboConsigneesList.StyleController = this.lcMain;
			this.cboConsigneesList.TabIndex = 7;
			// 
			// gridView8
			// 
			this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colConsigneeId,
            this.ColConsigneeName});
			this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView8.Name = "gridView8";
			this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView8.OptionsView.ShowGroupPanel = false;
			// 
			// colConsigneeId
			// 
			this.colConsigneeId.Caption = "Id";
			this.colConsigneeId.FieldName = "Id";
			this.colConsigneeId.Name = "colConsigneeId";
			this.colConsigneeId.Visible = true;
			this.colConsigneeId.VisibleIndex = 0;
			this.colConsigneeId.Width = 122;
			// 
			// ColConsigneeName
			// 
			this.ColConsigneeName.Caption = "Name";
			this.ColConsigneeName.FieldName = "CustomerName";
			this.ColConsigneeName.Name = "ColConsigneeName";
			this.ColConsigneeName.Visible = true;
			this.ColConsigneeName.VisibleIndex = 1;
			this.ColConsigneeName.Width = 680;
			// 
			// txtJobNo
			// 
			this.txtJobNo.Location = new System.Drawing.Point(815, 50);
			this.txtJobNo.MenuManager = this.ribbonControl;
			this.txtJobNo.Name = "txtJobNo";
			this.txtJobNo.Properties.ReadOnly = true;
			this.txtJobNo.Size = new System.Drawing.Size(662, 22);
			this.txtJobNo.StyleController = this.lcMain;
			this.txtJobNo.TabIndex = 1;
			this.txtJobNo.TabStop = false;
			// 
			// dtFollowUp
			// 
			this.dtFollowUp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "FollowupDate", true));
			this.dtFollowUp.EditValue = null;
			this.dtFollowUp.Location = new System.Drawing.Point(814, 102);
			this.dtFollowUp.MenuManager = this.ribbonControl;
			this.dtFollowUp.Name = "dtFollowUp";
			this.dtFollowUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtFollowUp.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtFollowUp.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtFollowUp.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtFollowUp.Properties.UseMaskAsDisplayFormat = true;
			this.dtFollowUp.Size = new System.Drawing.Size(663, 22);
			this.dtFollowUp.StyleController = this.lcMain;
			this.dtFollowUp.TabIndex = 2;
			// 
			// cboCarrierList
			// 
			this.cboCarrierList.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "CarrierId", true));
			this.cboCarrierList.Location = new System.Drawing.Point(179, 443);
			this.cboCarrierList.MenuManager = this.ribbonControl;
			this.cboCarrierList.Name = "cboCarrierList";
			this.cboCarrierList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCarrierList.Properties.DisplayMember = "CarrierName";
			this.cboCarrierList.Properties.NullText = "";
			this.cboCarrierList.Properties.ShowAddNewButton = true;
			this.cboCarrierList.Properties.ValueMember = "Id";
			this.cboCarrierList.Size = new System.Drawing.Size(550, 22);
			this.cboCarrierList.StyleController = this.lcMain;
			this.cboCarrierList.TabIndex = 17;
			this.cboCarrierList.Validated += new System.EventHandler(this.cboCarrierList_Validated);
			// 
			// cboAgentsList
			// 
			this.cboAgentsList.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "AgentId", true));
			this.cboAgentsList.Location = new System.Drawing.Point(179, 417);
			this.cboAgentsList.MenuManager = this.ribbonControl;
			this.cboAgentsList.Name = "cboAgentsList";
			this.cboAgentsList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboAgentsList.Properties.DisplayMember = "AgentName";
			this.cboAgentsList.Properties.NullText = "";
			this.cboAgentsList.Properties.PopupView = this.gridView5;
			this.cboAgentsList.Properties.ShowAddNewButton = true;
			this.cboAgentsList.Properties.ValueMember = "Id";
			this.cboAgentsList.Size = new System.Drawing.Size(550, 22);
			this.cboAgentsList.StyleController = this.lcMain;
			this.cboAgentsList.TabIndex = 16;
			// 
			// gridView5
			// 
			this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAgentId,
            this.colAgentName});
			this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView5.Name = "gridView5";
			this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView5.OptionsView.ShowGroupPanel = false;
			// 
			// colAgentId
			// 
			this.colAgentId.Caption = "Id";
			this.colAgentId.FieldName = "Id";
			this.colAgentId.Name = "colAgentId";
			this.colAgentId.Visible = true;
			this.colAgentId.VisibleIndex = 0;
			this.colAgentId.Width = 131;
			// 
			// colAgentName
			// 
			this.colAgentName.Caption = "Name";
			this.colAgentName.FieldName = "AgentName";
			this.colAgentName.Name = "colAgentName";
			this.colAgentName.Visible = true;
			this.colAgentName.VisibleIndex = 1;
			this.colAgentName.Width = 936;
			// 
			// txtXONumber
			// 
			this.txtXONumber.EditValue = "XO Number";
			this.txtXONumber.Location = new System.Drawing.Point(179, 50);
			this.txtXONumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtXONumber.Name = "txtXONumber";
			this.txtXONumber.Properties.ReadOnly = true;
			this.txtXONumber.Size = new System.Drawing.Size(546, 22);
			this.txtXONumber.StyleController = this.lcMain;
			this.txtXONumber.TabIndex = 1;
			this.txtXONumber.TabStop = false;
			// 
			// cboHandledBy
			// 
			this.cboHandledBy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "UserId", true));
			this.cboHandledBy.Location = new System.Drawing.Point(179, 154);
			this.cboHandledBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboHandledBy.Name = "cboHandledBy";
			this.cboHandledBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboHandledBy.Properties.DisplayMember = "UserName";
			this.cboHandledBy.Properties.NullText = "";
			this.cboHandledBy.Properties.PopupView = this.repUsersList;
			this.cboHandledBy.Properties.ShowAddNewButton = true;
			this.cboHandledBy.Properties.UseReadOnlyAppearance = false;
			this.cboHandledBy.Properties.ValueMember = "Id";
			this.cboHandledBy.Size = new System.Drawing.Size(546, 22);
			this.cboHandledBy.StyleController = this.lcMain;
			this.cboHandledBy.TabIndex = 4;
			// 
			// repUsersList
			// 
			this.repUsersList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserId,
            this.colUserName});
			this.repUsersList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.repUsersList.Name = "repUsersList";
			this.repUsersList.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.repUsersList.OptionsView.ShowGroupPanel = false;
			// 
			// colUserId
			// 
			this.colUserId.Caption = "Id";
			this.colUserId.FieldName = "Id";
			this.colUserId.Name = "colUserId";
			this.colUserId.Visible = true;
			this.colUserId.VisibleIndex = 0;
			this.colUserId.Width = 20;
			// 
			// colUserName
			// 
			this.colUserName.Caption = "Name";
			this.colUserName.FieldName = "UserName";
			this.colUserName.Name = "colUserName";
			this.colUserName.Visible = true;
			this.colUserName.VisibleIndex = 1;
			this.colUserName.Width = 352;
			// 
			// dtQuotationDate
			// 
			this.dtQuotationDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "QuotationDate", true));
			this.dtQuotationDate.EditValue = null;
			this.dtQuotationDate.Location = new System.Drawing.Point(179, 102);
			this.dtQuotationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dtQuotationDate.Name = "dtQuotationDate";
			this.dtQuotationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtQuotationDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtQuotationDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtQuotationDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtQuotationDate.Properties.DisplayFormat.FormatString = "";
			this.dtQuotationDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.dtQuotationDate.Properties.EditFormat.FormatString = "";
			this.dtQuotationDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.dtQuotationDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtQuotationDate.Properties.ReadOnly = true;
			this.dtQuotationDate.Properties.UseMaskAsDisplayFormat = true;
			this.dtQuotationDate.Properties.UseReadOnlyAppearance = false;
			this.dtQuotationDate.Size = new System.Drawing.Size(546, 22);
			this.dtQuotationDate.StyleController = this.lcMain;
			this.dtQuotationDate.TabIndex = 1;
			this.dtQuotationDate.TabStop = false;
			// 
			// cboStatus
			// 
			this.cboStatus.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "Status", true));
			this.cboStatus.Location = new System.Drawing.Point(179, 633);
			this.cboStatus.Name = "cboStatus";
			this.cboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboStatus.Properties.NullText = "";
			this.cboStatus.Properties.PopupView = this.gridLookUpEdit1View;
			this.cboStatus.Properties.ReadOnly = true;
			this.cboStatus.Properties.UseReadOnlyAppearance = false;
			this.cboStatus.Size = new System.Drawing.Size(199, 22);
			this.cboStatus.StyleController = this.lcMain;
			this.cboStatus.TabIndex = 21;
			// 
			// gridLookUpEdit1View
			// 
			this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
			this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// cboPolList
			// 
			this.cboPolList.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "Pol", true));
			this.cboPolList.Location = new System.Drawing.Point(179, 365);
			this.cboPolList.Name = "cboPolList";
			this.cboPolList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboPolList.Properties.DisplayMember = "Name";
			this.cboPolList.Properties.NullText = "";
			this.cboPolList.Properties.PopupView = this.gridView1;
			this.cboPolList.Properties.ShowAddNewButton = true;
			this.cboPolList.Properties.ValueMember = "Id";
			this.cboPolList.Size = new System.Drawing.Size(550, 22);
			this.cboPolList.StyleController = this.lcMain;
			this.cboPolList.TabIndex = 12;
			this.cboPolList.AddNewValue += new DevExpress.XtraEditors.Controls.AddNewValueEventHandler(this.cboPolList_AddNewValue);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPolId,
            this.colPolPortCode,
            this.colPolPortName});
			this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// colPolId
			// 
			this.colPolId.Caption = "Id";
			this.colPolId.FieldName = "Id";
			this.colPolId.Name = "colPolId";
			this.colPolId.Visible = true;
			this.colPolId.VisibleIndex = 0;
			this.colPolId.Width = 70;
			// 
			// colPolPortCode
			// 
			this.colPolPortCode.Caption = "Port Code";
			this.colPolPortCode.FieldName = "Code";
			this.colPolPortCode.Name = "colPolPortCode";
			this.colPolPortCode.Visible = true;
			this.colPolPortCode.VisibleIndex = 1;
			this.colPolPortCode.Width = 40;
			// 
			// colPolPortName
			// 
			this.colPolPortName.Caption = "Port Name";
			this.colPolPortName.FieldName = "Name";
			this.colPolPortName.Name = "colPolPortName";
			this.colPolPortName.Visible = true;
			this.colPolPortName.VisibleIndex = 2;
			this.colPolPortName.Width = 260;
			// 
			// cboPodList
			// 
			this.cboPodList.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "Pod", true));
			this.cboPodList.Location = new System.Drawing.Point(179, 391);
			this.cboPodList.Name = "cboPodList";
			this.cboPodList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboPodList.Properties.DisplayMember = "Name";
			this.cboPodList.Properties.NullText = "";
			this.cboPodList.Properties.PopupView = this.gridView3;
			this.cboPodList.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCities,
            this.repCountries});
			this.cboPodList.Properties.ShowAddNewButton = true;
			this.cboPodList.Properties.ValueMember = "Id";
			this.cboPodList.Size = new System.Drawing.Size(550, 22);
			this.cboPodList.StyleController = this.lcMain;
			this.cboPodList.TabIndex = 15;
			this.cboPodList.AddNewValue += new DevExpress.XtraEditors.Controls.AddNewValueEventHandler(this.cboPodList_AddNewValue);
			// 
			// gridView3
			// 
			this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPodId,
            this.colPodPortCode,
            this.colPodCityName});
			this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView3.Name = "gridView3";
			this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView3.OptionsView.ShowGroupPanel = false;
			// 
			// colPodId
			// 
			this.colPodId.Caption = "Id";
			this.colPodId.FieldName = "Id";
			this.colPodId.Name = "colPodId";
			this.colPodId.Visible = true;
			this.colPodId.VisibleIndex = 0;
			this.colPodId.Width = 60;
			// 
			// colPodPortCode
			// 
			this.colPodPortCode.Caption = "Port Code";
			this.colPodPortCode.FieldName = "Code";
			this.colPodPortCode.Name = "colPodPortCode";
			this.colPodPortCode.Visible = true;
			this.colPodPortCode.VisibleIndex = 1;
			this.colPodPortCode.Width = 50;
			// 
			// colPodCityName
			// 
			this.colPodCityName.Caption = "Port Name";
			this.colPodCityName.FieldName = "Name";
			this.colPodCityName.Name = "colPodCityName";
			this.colPodCityName.Visible = true;
			this.colPodCityName.VisibleIndex = 2;
			this.colPodCityName.Width = 260;
			// 
			// repCities
			// 
			this.repCities.AutoHeight = false;
			this.repCities.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCities.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CityID", "CityID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CityName", "name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repCities.DisplayMember = "CityName";
			this.repCities.Name = "repCities";
			this.repCities.NullText = "";
			this.repCities.ValueMember = "CityID";
			// 
			// repCountries
			// 
			this.repCountries.AutoHeight = false;
			this.repCountries.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCountries.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountryID", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountryName", "Country Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repCountries.DisplayMember = "CountryName";
			this.repCountries.Name = "repCountries";
			this.repCountries.NullText = "";
			this.repCountries.ValueMember = "CountryID";
			// 
			// cboDepartments
			// 
			this.cboDepartments.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "DepartmentId", true));
			this.cboDepartments.Location = new System.Drawing.Point(179, 76);
			this.cboDepartments.Name = "cboDepartments";
			this.cboDepartments.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboDepartments.Properties.DisplayMember = "DepartmentName";
			this.cboDepartments.Properties.NullText = "";
			this.cboDepartments.Properties.PopupView = this.gridView4;
			this.cboDepartments.Properties.ReadOnly = true;
			this.cboDepartments.Properties.ValueMember = "Id";
			this.cboDepartments.Size = new System.Drawing.Size(546, 22);
			this.cboDepartments.StyleController = this.lcMain;
			this.cboDepartments.TabIndex = 0;
			this.cboDepartments.EditValueChanged += new System.EventHandler(this.cboDepartmentList_EditValueChanged);
			// 
			// gridView4
			// 
			this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDepartmentId,
            this.colDepartmentName,
            this.colDepartmentPrefix});
			this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView4.Name = "gridView4";
			this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView4.OptionsView.ShowGroupPanel = false;
			// 
			// colDepartmentId
			// 
			this.colDepartmentId.Caption = "Id";
			this.colDepartmentId.FieldName = "Id";
			this.colDepartmentId.Name = "colDepartmentId";
			this.colDepartmentId.Visible = true;
			this.colDepartmentId.VisibleIndex = 0;
			this.colDepartmentId.Width = 71;
			// 
			// colDepartmentName
			// 
			this.colDepartmentName.Caption = "Department Name";
			this.colDepartmentName.FieldName = "DepartmentName";
			this.colDepartmentName.Name = "colDepartmentName";
			this.colDepartmentName.Visible = true;
			this.colDepartmentName.VisibleIndex = 1;
			this.colDepartmentName.Width = 306;
			// 
			// colDepartmentPrefix
			// 
			this.colDepartmentPrefix.Caption = "Prefix";
			this.colDepartmentPrefix.FieldName = "Prefix";
			this.colDepartmentPrefix.Name = "colDepartmentPrefix";
			this.colDepartmentPrefix.Visible = true;
			this.colDepartmentPrefix.VisibleIndex = 2;
			this.colDepartmentPrefix.Width = 690;
			// 
			// cboTotalVolume
			// 
			this.cboTotalVolume.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "Vol", true));
			this.cboTotalVolume.Location = new System.Drawing.Point(179, 339);
			this.cboTotalVolume.MenuManager = this.ribbonControl;
			this.cboTotalVolume.Name = "cboTotalVolume";
			this.cboTotalVolume.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, true, false, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.cboTotalVolume.Size = new System.Drawing.Size(550, 22);
			this.cboTotalVolume.StyleController = this.lcMain;
			this.cboTotalVolume.TabIndex = 9;
			// 
			// txtTypeOfShipment
			// 
			this.txtTypeOfShipment.Location = new System.Drawing.Point(179, 313);
			this.txtTypeOfShipment.MenuManager = this.ribbonControl;
			this.txtTypeOfShipment.Name = "txtTypeOfShipment";
			this.txtTypeOfShipment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTypeOfShipment.Properties.NullText = "";
			this.txtTypeOfShipment.Size = new System.Drawing.Size(550, 22);
			this.txtTypeOfShipment.StyleController = this.lcMain;
			this.txtTypeOfShipment.TabIndex = 26;
			// 
			// cboCustomers
			// 
			this.cboCustomers.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotations, "MemberId", true));
			this.cboCustomers.Location = new System.Drawing.Point(179, 261);
			this.cboCustomers.Name = "cboCustomers";
			this.cboCustomers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCustomers.Properties.DisplayMember = "CustomerName";
			this.cboCustomers.Properties.NullText = "";
			this.cboCustomers.Properties.PopupView = this.searchLookUpEdit1View;
			this.cboCustomers.Properties.ShowAddNewButton = true;
			this.cboCustomers.Properties.ValueMember = "Id";
			this.cboCustomers.Size = new System.Drawing.Size(550, 22);
			this.cboCustomers.StyleController = this.lcMain;
			this.cboCustomers.TabIndex = 6;
			this.cboCustomers.AddNewValue += new DevExpress.XtraEditors.Controls.AddNewValueEventHandler(this.cboCustomersList_AddNewValue);
			this.cboCustomers.EditValueChanged += new System.EventHandler(this.cboCustomersList_EditValueChanged);
			// 
			// searchLookUpEdit1View
			// 
			this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn20});
			this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
			this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Id";
			this.gridColumn1.FieldName = "Id";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			this.gridColumn1.Width = 84;
			// 
			// gridColumn20
			// 
			this.gridColumn20.Caption = "Name";
			this.gridColumn20.FieldName = "CustomerName";
			this.gridColumn20.Name = "gridColumn20";
			this.gridColumn20.Visible = true;
			this.gridColumn20.VisibleIndex = 1;
			this.gridColumn20.Width = 838;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.grpShipmentInfo,
            this.emptySpaceItem2,
            this.grpXoInfo,
            this.grpStatusInfo});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(1501, 689);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// grpShipmentInfo
			// 
			this.grpShipmentInfo.CustomizationFormText = "layoutControlGroup2";
			this.grpShipmentInfo.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpShipmentInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblPolList,
            this.lblPodList,
            this.lblClientName,
            this.lblConsigneeName,
            this.lblTotalVolume,
            this.lblAgentsList,
            this.lblCarrierList,
            this.tabsGroup,
            this.layoutControlItem8,
            this.emptySpaceItem3,
            this.layoutControlItem9,
            this.emptySpaceItem5,
            this.lblNotes,
            this.lblShipperName,
            this.lblTerms,
            this.lblTermDescription,
            this.layoutControlItem4,
            this.emptySpaceItem12});
			this.grpShipmentInfo.Location = new System.Drawing.Point(0, 211);
			this.grpShipmentInfo.Name = "grpShipmentInfo";
			this.grpShipmentInfo.Size = new System.Drawing.Size(1481, 372);
			this.grpShipmentInfo.Text = "Shipment Info";
			// 
			// lblPolList
			// 
			this.lblPolList.Control = this.cboPolList;
			this.lblPolList.Location = new System.Drawing.Point(0, 104);
			this.lblPolList.Name = "lblPolList";
			this.lblPolList.Size = new System.Drawing.Size(709, 26);
			this.lblPolList.Text = "Port of Loading (POL)";
			// 
			// lblPodList
			// 
			this.lblPodList.Control = this.cboPodList;
			this.lblPodList.Location = new System.Drawing.Point(0, 130);
			this.lblPodList.Name = "lblPodList";
			this.lblPodList.Size = new System.Drawing.Size(709, 26);
			this.lblPodList.Text = "Port of Destination (POD)";
			// 
			// lblClientName
			// 
			this.lblClientName.Control = this.cboCustomers;
			this.lblClientName.Location = new System.Drawing.Point(0, 0);
			this.lblClientName.Name = "lblClientName";
			this.lblClientName.Size = new System.Drawing.Size(709, 26);
			this.lblClientName.Text = "Client Name";
			// 
			// lblConsigneeName
			// 
			this.lblConsigneeName.Control = this.cboConsigneesList;
			this.lblConsigneeName.Location = new System.Drawing.Point(709, 0);
			this.lblConsigneeName.Name = "lblConsigneeName";
			this.lblConsigneeName.Size = new System.Drawing.Size(748, 26);
			this.lblConsigneeName.Text = "Consignee Name";
			this.lblConsigneeName.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
			this.lblConsigneeName.TextToControlDistance = 5;
			// 
			// lblTotalVolume
			// 
			this.lblTotalVolume.Control = this.cboTotalVolume;
			this.lblTotalVolume.Location = new System.Drawing.Point(0, 78);
			this.lblTotalVolume.Name = "lblTotalVolume";
			this.lblTotalVolume.Size = new System.Drawing.Size(709, 26);
			this.lblTotalVolume.Text = "Total Volume";
			// 
			// lblAgentsList
			// 
			this.lblAgentsList.Control = this.cboAgentsList;
			this.lblAgentsList.Location = new System.Drawing.Point(0, 156);
			this.lblAgentsList.Name = "lblAgentsList";
			this.lblAgentsList.Size = new System.Drawing.Size(709, 26);
			this.lblAgentsList.Text = "Agents";
			// 
			// lblCarrierList
			// 
			this.lblCarrierList.Control = this.cboCarrierList;
			this.lblCarrierList.Location = new System.Drawing.Point(0, 182);
			this.lblCarrierList.Name = "lblCarrierList";
			this.lblCarrierList.Size = new System.Drawing.Size(709, 26);
			this.lblCarrierList.Text = "Carriers";
			this.lblCarrierList.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
			// 
			// tabsGroup
			// 
			this.tabsGroup.Location = new System.Drawing.Point(709, 104);
			this.tabsGroup.Name = "tabsGroup";
			this.tabsGroup.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Far;
			this.tabsGroup.SelectedTabPage = this.tabRealCost;
			this.tabsGroup.Size = new System.Drawing.Size(748, 187);
			this.tabsGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabRealCost,
            this.tabSelling});
			this.tabsGroup.Text = "Cost/Selling Group";
			// 
			// tabRealCost
			// 
			this.tabRealCost.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.tabRealCost.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
			this.tabRealCost.Location = new System.Drawing.Point(0, 0);
			this.tabRealCost.Name = "tabRealCost";
			this.tabRealCost.Size = new System.Drawing.Size(724, 135);
			this.tabRealCost.Text = "Quotation Cost";
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.gcRealCosts;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(724, 135);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// tabSelling
			// 
			this.tabSelling.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
			this.tabSelling.Location = new System.Drawing.Point(0, 0);
			this.tabSelling.Name = "tabSelling";
			this.tabSelling.Size = new System.Drawing.Size(724, 135);
			this.tabSelling.Text = "Quotation Selling";
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.Control = this.gcSellings;
			this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(724, 135);
			this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem7.TextVisible = false;
			// 
			// layoutControlItem8
			// 
			this.layoutControlItem8.Control = this.btnAddCostSelling;
			this.layoutControlItem8.Location = new System.Drawing.Point(1346, 291);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(111, 31);
			this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem8.TextVisible = false;
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.Location = new System.Drawing.Point(0, 291);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(1237, 31);
			// 
			// layoutControlItem9
			// 
			this.layoutControlItem9.Control = this.btnEditCostSelling;
			this.layoutControlItem9.Location = new System.Drawing.Point(1237, 291);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Size = new System.Drawing.Size(109, 31);
			this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem9.TextVisible = false;
			// 
			// emptySpaceItem5
			// 
			this.emptySpaceItem5.Location = new System.Drawing.Point(709, 26);
			this.emptySpaceItem5.MaxSize = new System.Drawing.Size(748, 0);
			this.emptySpaceItem5.MinSize = new System.Drawing.Size(748, 10);
			this.emptySpaceItem5.Name = "emptySpaceItem5";
			this.emptySpaceItem5.Size = new System.Drawing.Size(748, 26);
			this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			// 
			// lblNotes
			// 
			this.lblNotes.Control = this.txtNotes;
			this.lblNotes.Location = new System.Drawing.Point(0, 208);
			this.lblNotes.Name = "lblNotes";
			this.lblNotes.Size = new System.Drawing.Size(709, 83);
			this.lblNotes.Text = "Notes";
			// 
			// lblShipperName
			// 
			this.lblShipperName.Control = this.txtShipperName;
			this.lblShipperName.Location = new System.Drawing.Point(0, 26);
			this.lblShipperName.Name = "lblShipperName";
			this.lblShipperName.Size = new System.Drawing.Size(709, 26);
			this.lblShipperName.Text = "Shipper Name";
			// 
			// lblTerms
			// 
			this.lblTerms.Control = this.cboTermsList;
			this.lblTerms.Location = new System.Drawing.Point(709, 52);
			this.lblTerms.Name = "lblTerms";
			this.lblTerms.Size = new System.Drawing.Size(305, 26);
			this.lblTerms.Text = "Terms";
			this.lblTerms.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
			this.lblTerms.TextToControlDistance = 50;
			// 
			// lblTermDescription
			// 
			this.lblTermDescription.Control = this.txtTermDescription;
			this.lblTermDescription.Location = new System.Drawing.Point(1014, 52);
			this.lblTermDescription.Name = "lblTermDescription";
			this.lblTermDescription.Size = new System.Drawing.Size(443, 26);
			this.lblTermDescription.Text = "Description";
			this.lblTermDescription.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblTermDescription.TextToControlDistance = 5;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtTypeOfShipment;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 52);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(709, 26);
			this.layoutControlItem4.Text = "Type of Ship";
			// 
			// emptySpaceItem12
			// 
			this.emptySpaceItem12.Location = new System.Drawing.Point(709, 78);
			this.emptySpaceItem12.Name = "emptySpaceItem12";
			this.emptySpaceItem12.Size = new System.Drawing.Size(748, 26);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 659);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(1481, 10);
			// 
			// grpXoInfo
			// 
			this.grpXoInfo.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpXoInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblXONumber,
            this.lblQuotationDate,
            this.lblHandledBy,
            this.emptySpaceItem10,
            this.lblFollowUpDate,
            this.lblDepartment,
            this.lblJobNo,
            this.emptySpaceItem11,
            this.lblBookedDate,
            this.emptySpaceItem4,
            this.emptySpaceItem7,
            this.lblSales,
            this.layoutControlItem5});
			this.grpXoInfo.Location = new System.Drawing.Point(0, 0);
			this.grpXoInfo.Name = "grpXoInfo";
			this.grpXoInfo.Size = new System.Drawing.Size(1481, 211);
			this.grpXoInfo.Text = "XO Info";
			// 
			// lblXONumber
			// 
			this.lblXONumber.Control = this.txtXONumber;
			this.lblXONumber.CustomizationFormText = "layoutControlItem2";
			this.lblXONumber.Location = new System.Drawing.Point(0, 0);
			this.lblXONumber.Name = "lblXONumber";
			this.lblXONumber.Size = new System.Drawing.Size(705, 26);
			this.lblXONumber.Text = "XO Number";
			// 
			// lblQuotationDate
			// 
			this.lblQuotationDate.Control = this.dtQuotationDate;
			this.lblQuotationDate.CustomizationFormText = "layoutControlItem3";
			this.lblQuotationDate.Location = new System.Drawing.Point(0, 52);
			this.lblQuotationDate.Name = "lblQuotationDate";
			this.lblQuotationDate.Size = new System.Drawing.Size(705, 26);
			this.lblQuotationDate.Text = "Quotation Date";
			// 
			// lblHandledBy
			// 
			this.lblHandledBy.AppearanceItemCaption.Options.UseTextOptions = true;
			this.lblHandledBy.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.lblHandledBy.Control = this.cboHandledBy;
			this.lblHandledBy.CustomizationFormText = "layoutControlItem6";
			this.lblHandledBy.Location = new System.Drawing.Point(0, 104);
			this.lblHandledBy.Name = "lblHandledBy";
			this.lblHandledBy.Size = new System.Drawing.Size(705, 26);
			this.lblHandledBy.Text = "Handled By";
			// 
			// emptySpaceItem10
			// 
			this.emptySpaceItem10.Location = new System.Drawing.Point(705, 78);
			this.emptySpaceItem10.Name = "emptySpaceItem10";
			this.emptySpaceItem10.Size = new System.Drawing.Size(752, 26);
			// 
			// lblFollowUpDate
			// 
			this.lblFollowUpDate.Control = this.dtFollowUp;
			this.lblFollowUpDate.Location = new System.Drawing.Point(705, 52);
			this.lblFollowUpDate.Name = "lblFollowUpDate";
			this.lblFollowUpDate.Size = new System.Drawing.Size(752, 26);
			this.lblFollowUpDate.Text = "Followup date";
			this.lblFollowUpDate.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblFollowUpDate.TextToControlDistance = 5;
			// 
			// lblDepartment
			// 
			this.lblDepartment.Control = this.cboDepartments;
			this.lblDepartment.Location = new System.Drawing.Point(0, 26);
			this.lblDepartment.Name = "lblDepartment";
			this.lblDepartment.Size = new System.Drawing.Size(705, 26);
			this.lblDepartment.Text = "Department";
			// 
			// lblJobNo
			// 
			this.lblJobNo.Control = this.txtJobNo;
			this.lblJobNo.Location = new System.Drawing.Point(705, 0);
			this.lblJobNo.Name = "lblJobNo";
			this.lblJobNo.Size = new System.Drawing.Size(752, 26);
			this.lblJobNo.Text = "Related JobNo";
			this.lblJobNo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblJobNo.TextToControlDistance = 5;
			// 
			// emptySpaceItem11
			// 
			this.emptySpaceItem11.Location = new System.Drawing.Point(705, 26);
			this.emptySpaceItem11.Name = "emptySpaceItem11";
			this.emptySpaceItem11.Size = new System.Drawing.Size(752, 26);
			// 
			// lblBookedDate
			// 
			this.lblBookedDate.Control = this.dtBookedDate;
			this.lblBookedDate.Location = new System.Drawing.Point(0, 78);
			this.lblBookedDate.Name = "lblBookedDate";
			this.lblBookedDate.Size = new System.Drawing.Size(705, 26);
			this.lblBookedDate.Text = "Booked Date";
			// 
			// emptySpaceItem4
			// 
			this.emptySpaceItem4.Location = new System.Drawing.Point(705, 104);
			this.emptySpaceItem4.Name = "emptySpaceItem4";
			this.emptySpaceItem4.Size = new System.Drawing.Size(752, 26);
			// 
			// emptySpaceItem7
			// 
			this.emptySpaceItem7.Location = new System.Drawing.Point(705, 130);
			this.emptySpaceItem7.MaxSize = new System.Drawing.Size(752, 0);
			this.emptySpaceItem7.MinSize = new System.Drawing.Size(752, 10);
			this.emptySpaceItem7.Name = "emptySpaceItem7";
			this.emptySpaceItem7.Size = new System.Drawing.Size(752, 31);
			this.emptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			// 
			// lblSales
			// 
			this.lblSales.Control = this.cboSales;
			this.lblSales.Location = new System.Drawing.Point(0, 130);
			this.lblSales.Name = "lblSales";
			this.lblSales.Size = new System.Drawing.Size(675, 31);
			this.lblSales.Text = "Sales";
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.btnEditSales;
			this.layoutControlItem5.Location = new System.Drawing.Point(675, 130);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(30, 31);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// grpStatusInfo
			// 
			this.grpStatusInfo.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpStatusInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblStatus,
            this.emptySpaceItem8,
            this.emptySpaceItem9,
            this.lblreason});
			this.grpStatusInfo.Location = new System.Drawing.Point(0, 583);
			this.grpStatusInfo.Name = "grpStatusInfo";
			this.grpStatusInfo.Size = new System.Drawing.Size(1481, 76);
			this.grpStatusInfo.Text = "Status Info";
			// 
			// lblStatus
			// 
			this.lblStatus.Control = this.cboStatus;
			this.lblStatus.Location = new System.Drawing.Point(0, 0);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(358, 26);
			this.lblStatus.Text = "Status";
			// 
			// emptySpaceItem8
			// 
			this.emptySpaceItem8.Location = new System.Drawing.Point(358, 0);
			this.emptySpaceItem8.Name = "emptySpaceItem8";
			this.emptySpaceItem8.Size = new System.Drawing.Size(221, 26);
			// 
			// emptySpaceItem9
			// 
			this.emptySpaceItem9.Location = new System.Drawing.Point(579, 0);
			this.emptySpaceItem9.Name = "emptySpaceItem9";
			this.emptySpaceItem9.Size = new System.Drawing.Size(129, 26);
			// 
			// lblreason
			// 
			this.lblreason.Control = this.txtReason;
			this.lblreason.Location = new System.Drawing.Point(708, 0);
			this.lblreason.Name = "lblreason";
			this.lblreason.Size = new System.Drawing.Size(749, 26);
			this.lblreason.Text = "Reason";
			this.lblreason.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.lblreason.TextToControlDistance = 5;
			this.lblreason.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
			// 
			// dockManager1
			// 
			this.dockManager1.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerRight});
			this.dockManager1.Form = this;
			this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
			// 
			// hideContainerRight
			// 
			this.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.hideContainerRight.Controls.Add(this.dockXoHistory);
			this.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.hideContainerRight.Location = new System.Drawing.Point(1501, 193);
			this.hideContainerRight.Name = "hideContainerRight";
			this.hideContainerRight.Size = new System.Drawing.Size(26, 689);
			// 
			// dockXoHistory
			// 
			this.dockXoHistory.Controls.Add(this.controlContainer1);
			this.dockXoHistory.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
			this.dockXoHistory.ID = new System.Guid("f1fd3f5f-c318-4829-b375-77abe026a0f5");
			this.dockXoHistory.Location = new System.Drawing.Point(0, 0);
			this.dockXoHistory.Name = "dockXoHistory";
			this.dockXoHistory.OriginalSize = new System.Drawing.Size(389, 200);
			this.dockXoHistory.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
			this.dockXoHistory.SavedIndex = 0;
			this.dockXoHistory.Size = new System.Drawing.Size(389, 689);
			this.dockXoHistory.Text = "XO History";
			this.dockXoHistory.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
			// 
			// controlContainer1
			// 
			this.controlContainer1.Controls.Add(this.layoutControl2);
			this.controlContainer1.Location = new System.Drawing.Point(6, 32);
			this.controlContainer1.Name = "controlContainer1";
			this.controlContainer1.Size = new System.Drawing.Size(379, 653);
			this.controlContainer1.TabIndex = 0;
			// 
			// layoutControl2
			// 
			this.layoutControl2.Controls.Add(this.gcQuoteDetails);
			this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl2.Location = new System.Drawing.Point(0, 0);
			this.layoutControl2.Name = "layoutControl2";
			this.layoutControl2.Root = this.layoutControlGroup2;
			this.layoutControl2.Size = new System.Drawing.Size(379, 653);
			this.layoutControl2.TabIndex = 0;
			this.layoutControl2.Text = "layoutControl2";
			// 
			// gcQuoteDetails
			// 
			this.gcQuoteDetails.Location = new System.Drawing.Point(12, 12);
			this.gcQuoteDetails.MainView = this.gvQuoteDetails;
			this.gcQuoteDetails.Name = "gcQuoteDetails";
			this.gcQuoteDetails.Size = new System.Drawing.Size(355, 629);
			this.gcQuoteDetails.TabIndex = 23;
			this.gcQuoteDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQuoteDetails});
			// 
			// gvQuoteDetails
			// 
			this.gvQuoteDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHistoryId,
            this.colHistoryQuotationId,
            this.colHistoryVersionNo,
            this.colHistoryQuoteDate,
            this.colHistoryDepartmentId,
            this.colHistorySeaCarrierId,
            this.colHistoryTransitTime,
            this.colHistoryValidity,
            this.colHistoryValidityDate,
            this.colHistoryCurrencyId,
            this.colHistoryTotalAmount,
            this.colHistoryTotalLL,
            this.colHistoryTotalUSD,
            this.colHistoryNotes,
            this.colHistoryTotalVatAmountLL,
            this.colHistoryTotalVatAmountUSD});
			this.gvQuoteDetails.GridControl = this.gcQuoteDetails;
			this.gvQuoteDetails.Name = "gvQuoteDetails";
			this.gvQuoteDetails.OptionsBehavior.Editable = false;
			this.gvQuoteDetails.OptionsBehavior.ReadOnly = true;
			this.gvQuoteDetails.OptionsCustomization.AllowGroup = false;
			this.gvQuoteDetails.OptionsMenu.ShowGroupSortSummaryItems = false;
			this.gvQuoteDetails.OptionsView.AllowHtmlDrawGroups = false;
			this.gvQuoteDetails.OptionsView.ColumnAutoWidth = false;
			this.gvQuoteDetails.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
			this.gvQuoteDetails.OptionsView.ShowGroupedColumns = true;
			this.gvQuoteDetails.OptionsView.ShowGroupExpandCollapseButtons = false;
			this.gvQuoteDetails.OptionsView.ShowGroupPanel = false;
			// 
			// colHistoryId
			// 
			this.colHistoryId.Caption = "Id";
			this.colHistoryId.FieldName = "Id";
			this.colHistoryId.MinWidth = 25;
			this.colHistoryId.Name = "colHistoryId";
			this.colHistoryId.Width = 73;
			// 
			// colHistoryQuotationId
			// 
			this.colHistoryQuotationId.Caption = "Quotation";
			this.colHistoryQuotationId.FieldName = "QuotationId";
			this.colHistoryQuotationId.MinWidth = 25;
			this.colHistoryQuotationId.Name = "colHistoryQuotationId";
			this.colHistoryQuotationId.Width = 94;
			// 
			// colHistoryVersionNo
			// 
			this.colHistoryVersionNo.Caption = "Version No";
			this.colHistoryVersionNo.FieldName = "VersionNo";
			this.colHistoryVersionNo.MinWidth = 25;
			this.colHistoryVersionNo.Name = "colHistoryVersionNo";
			this.colHistoryVersionNo.Visible = true;
			this.colHistoryVersionNo.VisibleIndex = 1;
			this.colHistoryVersionNo.Width = 83;
			// 
			// colHistoryQuoteDate
			// 
			this.colHistoryQuoteDate.Caption = "Quote Date";
			this.colHistoryQuoteDate.FieldName = "QuoteDate";
			this.colHistoryQuoteDate.MinWidth = 25;
			this.colHistoryQuoteDate.Name = "colHistoryQuoteDate";
			this.colHistoryQuoteDate.Visible = true;
			this.colHistoryQuoteDate.VisibleIndex = 2;
			this.colHistoryQuoteDate.Width = 91;
			// 
			// colHistoryDepartmentId
			// 
			this.colHistoryDepartmentId.Caption = "Department";
			this.colHistoryDepartmentId.FieldName = "DepartmentId";
			this.colHistoryDepartmentId.MinWidth = 25;
			this.colHistoryDepartmentId.Name = "colHistoryDepartmentId";
			this.colHistoryDepartmentId.Width = 133;
			// 
			// colHistorySeaCarrierId
			// 
			this.colHistorySeaCarrierId.Caption = "SeaCarrier";
			this.colHistorySeaCarrierId.FieldName = "SeaCarrierId";
			this.colHistorySeaCarrierId.MinWidth = 25;
			this.colHistorySeaCarrierId.Name = "colHistorySeaCarrierId";
			this.colHistorySeaCarrierId.Visible = true;
			this.colHistorySeaCarrierId.VisibleIndex = 0;
			this.colHistorySeaCarrierId.Width = 139;
			// 
			// colHistoryTransitTime
			// 
			this.colHistoryTransitTime.Caption = "Transit Time";
			this.colHistoryTransitTime.FieldName = "TransitTime";
			this.colHistoryTransitTime.MinWidth = 25;
			this.colHistoryTransitTime.Name = "colHistoryTransitTime";
			this.colHistoryTransitTime.Visible = true;
			this.colHistoryTransitTime.VisibleIndex = 3;
			this.colHistoryTransitTime.Width = 100;
			// 
			// colHistoryValidity
			// 
			this.colHistoryValidity.Caption = "Validity";
			this.colHistoryValidity.FieldName = "Validity";
			this.colHistoryValidity.MinWidth = 25;
			this.colHistoryValidity.Name = "colHistoryValidity";
			this.colHistoryValidity.Visible = true;
			this.colHistoryValidity.VisibleIndex = 4;
			this.colHistoryValidity.Width = 59;
			// 
			// colHistoryValidityDate
			// 
			this.colHistoryValidityDate.Caption = "Validity Date";
			this.colHistoryValidityDate.FieldName = "ValidityDate";
			this.colHistoryValidityDate.MinWidth = 25;
			this.colHistoryValidityDate.Name = "colHistoryValidityDate";
			this.colHistoryValidityDate.Visible = true;
			this.colHistoryValidityDate.VisibleIndex = 5;
			this.colHistoryValidityDate.Width = 94;
			// 
			// colHistoryCurrencyId
			// 
			this.colHistoryCurrencyId.Caption = "Currency";
			this.colHistoryCurrencyId.FieldName = "CurrencyId";
			this.colHistoryCurrencyId.MinWidth = 25;
			this.colHistoryCurrencyId.Name = "colHistoryCurrencyId";
			this.colHistoryCurrencyId.Visible = true;
			this.colHistoryCurrencyId.VisibleIndex = 6;
			this.colHistoryCurrencyId.Width = 67;
			// 
			// colHistoryTotalAmount
			// 
			this.colHistoryTotalAmount.Caption = "Total Amount";
			this.colHistoryTotalAmount.DisplayFormat.FormatString = "{0:n2}";
			this.colHistoryTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colHistoryTotalAmount.FieldName = "TotalAmount";
			this.colHistoryTotalAmount.MinWidth = 25;
			this.colHistoryTotalAmount.Name = "colHistoryTotalAmount";
			this.colHistoryTotalAmount.Visible = true;
			this.colHistoryTotalAmount.VisibleIndex = 7;
			this.colHistoryTotalAmount.Width = 100;
			// 
			// colHistoryTotalLL
			// 
			this.colHistoryTotalLL.Caption = "Total L.L.";
			this.colHistoryTotalLL.DisplayFormat.FormatString = "{0:n2}";
			this.colHistoryTotalLL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colHistoryTotalLL.MinWidth = 25;
			this.colHistoryTotalLL.Name = "colHistoryTotalLL";
			this.colHistoryTotalLL.OptionsColumn.ReadOnly = true;
			this.colHistoryTotalLL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "SUM={0:n}")});
			this.colHistoryTotalLL.Visible = true;
			this.colHistoryTotalLL.VisibleIndex = 8;
			this.colHistoryTotalLL.Width = 150;
			// 
			// colHistoryTotalUSD
			// 
			this.colHistoryTotalUSD.Caption = "Total USD";
			this.colHistoryTotalUSD.DisplayFormat.FormatString = "{0:n2}";
			this.colHistoryTotalUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colHistoryTotalUSD.MinWidth = 25;
			this.colHistoryTotalUSD.Name = "colHistoryTotalUSD";
			this.colHistoryTotalUSD.OptionsColumn.ReadOnly = true;
			this.colHistoryTotalUSD.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "SUM={0:n}")});
			this.colHistoryTotalUSD.Visible = true;
			this.colHistoryTotalUSD.VisibleIndex = 9;
			this.colHistoryTotalUSD.Width = 150;
			// 
			// colHistoryNotes
			// 
			this.colHistoryNotes.Caption = "Notes";
			this.colHistoryNotes.FieldName = "Notes";
			this.colHistoryNotes.MinWidth = 25;
			this.colHistoryNotes.Name = "colHistoryNotes";
			this.colHistoryNotes.Visible = true;
			this.colHistoryNotes.VisibleIndex = 10;
			this.colHistoryNotes.Width = 429;
			// 
			// colHistoryTotalVatAmountLL
			// 
			this.colHistoryTotalVatAmountLL.Caption = "Total Vat Amount LL";
			this.colHistoryTotalVatAmountLL.DisplayFormat.FormatString = "{0:n2}";
			this.colHistoryTotalVatAmountLL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colHistoryTotalVatAmountLL.FieldName = "TotalLocalVatAmount";
			this.colHistoryTotalVatAmountLL.MinWidth = 25;
			this.colHistoryTotalVatAmountLL.Name = "colHistoryTotalVatAmountLL";
			this.colHistoryTotalVatAmountLL.OptionsColumn.ReadOnly = true;
			this.colHistoryTotalVatAmountLL.Visible = true;
			this.colHistoryTotalVatAmountLL.VisibleIndex = 11;
			this.colHistoryTotalVatAmountLL.Width = 150;
			// 
			// colHistoryTotalVatAmountUSD
			// 
			this.colHistoryTotalVatAmountUSD.Caption = "Total Vat Amount USD";
			this.colHistoryTotalVatAmountUSD.DisplayFormat.FormatString = "{0:n2}";
			this.colHistoryTotalVatAmountUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colHistoryTotalVatAmountUSD.FieldName = "TotalForeignVatAmount";
			this.colHistoryTotalVatAmountUSD.MinWidth = 25;
			this.colHistoryTotalVatAmountUSD.Name = "colHistoryTotalVatAmountUSD";
			this.colHistoryTotalVatAmountUSD.OptionsColumn.ReadOnly = true;
			this.colHistoryTotalVatAmountUSD.Visible = true;
			this.colHistoryTotalVatAmountUSD.VisibleIndex = 12;
			this.colHistoryTotalVatAmountUSD.Width = 150;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup2.GroupBordersVisible = false;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(379, 653);
			this.layoutControlGroup2.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcQuoteDetails;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(359, 633);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.Location = new System.Drawing.Point(561, 78);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(534, 26);
			// 
			// emptySpaceItem6
			// 
			this.emptySpaceItem6.Location = new System.Drawing.Point(561, 52);
			this.emptySpaceItem6.Name = "emptySpaceItem6";
			this.emptySpaceItem6.Size = new System.Drawing.Size(534, 26);
			// 
			// QuotationEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1527, 912);
			this.Controls.Add(this.lcMain);
			this.Controls.Add(this.hideContainerRight);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.ribbonControl);
			this.Name = "QuotationEditForm";
			this.Ribbon = this.ribbonControl;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Quotation Form";
			this.Load += new System.EventHandler(this.QuotationEditForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
			this.lcMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsQuotations)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboSales.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTermDescription.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboTermsList.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipperName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcSellings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvSellings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSellingCurrenciesList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSellingSeaCarrierList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcRealCosts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvRealCosts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSeaCarrierList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCurrenciesList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repAgentList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtBookedDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtBookedDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboConsigneesList.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtJobNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtFollowUp.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtFollowUp.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCarrierList.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboAgentsList.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtXONumber.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboHandledBy.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsersList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtQuotationDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtQuotationDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboPolList.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboPodList.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCities)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCountries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboDepartments.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboTotalVolume.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTypeOfShipment.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCustomers.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpShipmentInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPolList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPodList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblClientName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblConsigneeName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalVolume)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAgentsList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCarrierList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tabsGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tabRealCost)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tabSelling)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNotes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblShipperName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTerms)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTermDescription)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpXoInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblXONumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblQuotationDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblHandledBy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblFollowUpDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDepartment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblJobNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblBookedDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpStatusInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblreason)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
			this.hideContainerRight.ResumeLayout(false);
			this.dockXoHistory.ResumeLayout(false);
			this.controlContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
			this.layoutControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcQuoteDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvQuoteDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem btnMainExit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem biClose;
        private DevExpress.XtraBars.BarButtonItem btnSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem btnCreateNewJob;
        private DevExpress.XtraBars.BarButtonItem btnMeeting;
        private DevExpress.XtraBars.BarButtonItem bmiPrintProfile;
        private DevExpress.XtraBars.BarButtonItem bmiPrintSummary;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem bmiPrintDirectory;
        private DevExpress.XtraBars.BarButtonItem bmiPrintTaskList;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.TextEdit txtXONumber;
        private DevExpress.XtraEditors.SearchLookUpEdit cboHandledBy;
        private DevExpress.XtraGrid.Views.Grid.GridView repUsersList;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraEditors.DateEdit dtQuotationDate;
        private DevExpress.XtraEditors.GridLookUpEdit cboStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit cboPolList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPolId;
        private DevExpress.XtraGrid.Columns.GridColumn colPolPortName;
        private DevExpress.XtraGrid.Columns.GridColumn colPolPortCode;
        private DevExpress.XtraEditors.SearchLookUpEdit cboPodList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colPodId;
        private DevExpress.XtraGrid.Columns.GridColumn colPodCityName;
        private DevExpress.XtraGrid.Columns.GridColumn colPodPortCode;
        private DevExpress.XtraEditors.SearchLookUpEdit cboDepartments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentPrefix;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup grpShipmentInfo;
        private DevExpress.XtraLayout.LayoutControlItem lblPolList;
        private DevExpress.XtraLayout.LayoutControlItem lblPodList;
        private DevExpress.XtraLayout.LayoutControlItem lblClientName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup grpXoInfo;
        private DevExpress.XtraLayout.LayoutControlItem lblXONumber;
        private DevExpress.XtraLayout.LayoutControlItem lblQuotationDate;
        private DevExpress.XtraLayout.LayoutControlItem lblHandledBy;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraLayout.LayoutControlItem lblDepartment;
        private DevExpress.XtraLayout.LayoutControlGroup grpStatusInfo;
        private DevExpress.XtraLayout.LayoutControlItem lblStatus;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraEditors.SearchLookUpEdit cboCarrierList;
        private DevExpress.XtraEditors.SearchLookUpEdit cboAgentsList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraLayout.LayoutControlItem lblAgentsList;
        private DevExpress.XtraLayout.LayoutControlItem lblCarrierList;
        private DevExpress.XtraGrid.Columns.GridColumn colAgentId;
        private DevExpress.XtraGrid.Columns.GridColumn colAgentName;
        private DevExpress.XtraEditors.DateEdit dtFollowUp;
        private DevExpress.XtraLayout.LayoutControlItem lblFollowUpDate;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.TextEdit txtJobNo;
        private DevExpress.XtraLayout.LayoutControlItem lblJobNo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerRight;
        private DevExpress.XtraBars.Docking.DockPanel dockXoHistory;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gcQuoteDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gvQuoteDetails;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SearchLookUpEdit cboConsigneesList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraLayout.LayoutControlItem lblConsigneeName;
        private DevExpress.XtraGrid.Columns.GridColumn colConsigneeId;
        private DevExpress.XtraGrid.Columns.GridColumn ColConsigneeName;
        private DevExpress.XtraEditors.ButtonEdit cboTotalVolume;
        private DevExpress.XtraLayout.LayoutControlItem lblTotalVolume;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private System.Windows.Forms.BindingSource bsQuotations;
        private DevExpress.XtraEditors.DateEdit dtBookedDate;
        private DevExpress.XtraLayout.LayoutControlItem lblBookedDate;
        private DevExpress.XtraGrid.GridControl gcRealCosts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRealCosts;
        private DevExpress.XtraGrid.GridControl gcSellings;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSellings;
        private DevExpress.XtraLayout.TabbedControlGroup tabsGroup;
        private DevExpress.XtraLayout.LayoutControlGroup tabRealCost;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup tabSelling;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnAddCostSelling;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SimpleButton btnEditCostSelling;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.Columns.GridColumn colHeaderId;
        private DevExpress.XtraGrid.Columns.GridColumn colCostQuotationId;
        private DevExpress.XtraGrid.Columns.GridColumn colCostDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCostVersionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCostDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colCostSeaCarrierId;
        private DevExpress.XtraGrid.Columns.GridColumn colCostTransitTime;
        private DevExpress.XtraGrid.Columns.GridColumn colCostValidity;
        private DevExpress.XtraGrid.Columns.GridColumn colCostValidityDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCurrencyId;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repAgentList;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraEditors.MemoEdit txtNotes;
        private DevExpress.XtraLayout.LayoutControlItem lblNotes;
        private DevExpress.XtraEditors.TextEdit txtShipperName;
        private DevExpress.XtraLayout.LayoutControlItem lblShipperName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repSeaCarrierList;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCurrenciesList;
        private DevExpress.XtraGrid.Columns.GridColumn colCostTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCostNotes;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repSellingSeaCarrierList;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repSellingCurrenciesList;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingHeaderId;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingQuotationId;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingVersionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingQuoteDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingTransitTime;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingValidity;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingValidityDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingCurrencyId;
        private DevExpress.XtraGrid.Columns.GridColumn costSellingTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn costSellingNotes;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraEditors.SearchLookUpEdit cboTermsList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraLayout.LayoutControlItem lblTerms;
        private DevExpress.XtraGrid.Columns.GridColumn colTermsId;
        private DevExpress.XtraGrid.Columns.GridColumn coltermCode;
        private DevExpress.XtraGrid.Columns.GridColumn coltermsDescription;
        private DevExpress.XtraEditors.TextEdit txtTermDescription;
        private DevExpress.XtraLayout.LayoutControlItem lblTermDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCostTotalLocalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCostTotalForeignAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingTotalLocalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingTotalForeignAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalLocalVatAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalForeignVatAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSellingVatAmountLL;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSellingVatAmountUSD;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryQuotationId;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryVersionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryQuoteDate;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colHistorySeaCarrierId;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryTransitTime;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryValidity;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryValidityDate;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryCurrencyId;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryTotalLL;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryTotalUSD;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryTotalVatAmountLL;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoryTotalVatAmountUSD;
        private DevExpress.XtraEditors.SearchLookUpEdit cboSales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraLayout.LayoutControlItem lblSales;
        private DevExpress.XtraEditors.MemoEdit txtReason;
        private DevExpress.XtraLayout.LayoutControlItem lblreason;
        private DevExpress.XtraEditors.LookUpEdit txtTypeOfShipment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.BarButtonItem btnSaveAs;
        private DevExpress.XtraBars.BarCheckItem btnUrgent;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraEditors.SimpleButton btnEditSales;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCities;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCountries;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbQuotationStatusOptions;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgQuotationStatusOptions;
        private DevExpress.XtraEditors.SearchLookUpEdit cboCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
    }
}