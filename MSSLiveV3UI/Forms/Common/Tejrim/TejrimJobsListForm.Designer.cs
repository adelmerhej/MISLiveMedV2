namespace MISLiveMed.UI.Forms.Common.Tejrim
{
    partial class TejrimJobsListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TejrimJobsListForm));
			this.gcTejrimList = new DevExpress.XtraGrid.GridControl();
			this.gvTejrimList = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.coltejrimInvoiceId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.chkInvoiceId = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colJobNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJobDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repDateFormat = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.colTejrimDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDeliveredDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReferenceNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMbol = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colConsigneeName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colClearingAgent = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPol = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPod = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVessel = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAtd = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAta = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colETD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colETA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAgent = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJobType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMissingDocs = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSeaCarrier = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colContainerType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLoadedStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLoadedDestination = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLoadingDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCutOffDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalProfit = new DevExpress.XtraGrid.Columns.GridColumn();
			this.rcTejrimList = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.biShowList = new DevExpress.XtraBars.BarCheckItem();
			this.bmiHideDetail = new DevExpress.XtraBars.BarCheckItem();
			this.bmiHorizontalLayout = new DevExpress.XtraBars.BarCheckItem();
			this.bmiShowList = new DevExpress.XtraBars.BarCheckItem();
			this.biPrintSubItem = new DevExpress.XtraBars.BarSubItem();
			this.bmiPrintInvoice = new DevExpress.XtraBars.BarButtonItem();
			this.bmiPrintSalesSummary = new DevExpress.XtraBars.BarButtonItem();
			this.bmiPrintSalesAnalysis = new DevExpress.XtraBars.BarButtonItem();
			this.hiItemsCount = new DevExpress.XtraBars.BarHeaderItem();
			this.biShowMasterDetail = new DevExpress.XtraBars.BarCheckItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.dtFrom = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemDateEdit18 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.dtTo = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemDateEdit19 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.btnPrintAll = new DevExpress.XtraBars.BarButtonItem();
			this.barCheckInvoiced = new DevExpress.XtraBars.BarCheckItem();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.cboSales = new DevExpress.XtraBars.BarEditItem();
			this.repSales = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboUsers = new DevExpress.XtraBars.BarEditItem();
			this.repUsers = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cboMembers = new DevExpress.XtraBars.BarEditItem();
			this.repCustomers = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.rpTejrimList = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgDelete = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgCloseView = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ilters = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.gcTejrimList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvTejrimList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkInvoiceId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rcTejrimList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit18.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit19.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// gcTejrimList
			// 
			this.gcTejrimList.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcTejrimList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcTejrimList.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcTejrimList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcTejrimList.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcTejrimList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcTejrimList.Location = new System.Drawing.Point(14, 14);
			this.gcTejrimList.MainView = this.gvTejrimList;
			this.gcTejrimList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcTejrimList.Name = "gcTejrimList";
			this.gcTejrimList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDateFormat,
            this.chkInvoiceId});
			this.gcTejrimList.Size = new System.Drawing.Size(1366, 515);
			this.gcTejrimList.TabIndex = 6;
			this.gcTejrimList.UseEmbeddedNavigator = true;
			this.gcTejrimList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTejrimList});
			// 
			// gvTejrimList
			// 
			this.gvTejrimList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltejrimInvoiceId,
            this.colJobNo,
            this.colJobDate,
            this.colTejrimDate,
            this.colDeliveredDate,
            this.colReferenceNo,
            this.colMbol,
            this.colCustomerName,
            this.colConsigneeName,
            this.colClearingAgent,
            this.colPol,
            this.colPod,
            this.colVessel,
            this.colAtd,
            this.colAta,
            this.colETD,
            this.colETA,
            this.colSales,
            this.colAgent,
            this.colStatus,
            this.colJobType,
            this.colMissingDocs,
            this.colSeaCarrier,
            this.colContainerType,
            this.colLoadedStatus,
            this.colLoadedDestination,
            this.colLoadingDate,
            this.colCutOffDate,
            this.colTotalProfit});
			this.gvTejrimList.DetailHeight = 458;
			this.gvTejrimList.GridControl = this.gcTejrimList;
			this.gvTejrimList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", null, "")});
			this.gvTejrimList.Name = "gvTejrimList";
			this.gvTejrimList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvTejrimList.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvTejrimList.OptionsFind.AlwaysVisible = true;
			this.gvTejrimList.OptionsPrint.AutoWidth = false;
			this.gvTejrimList.OptionsPrint.PrintHorzLines = false;
			this.gvTejrimList.OptionsPrint.PrintVertLines = false;
			this.gvTejrimList.OptionsView.ColumnAutoWidth = false;
			this.gvTejrimList.OptionsView.ShowGroupedColumns = true;
			this.gvTejrimList.OptionsView.ShowGroupPanel = false;
			this.gvTejrimList.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvTejrimList_RowCellStyle);
			this.gvTejrimList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvTejrimList_CellValueChanged);
			// 
			// coltejrimInvoiceId
			// 
			this.coltejrimInvoiceId.Caption = "InvoiceId";
			this.coltejrimInvoiceId.ColumnEdit = this.chkInvoiceId;
			this.coltejrimInvoiceId.FieldName = "InvoiceId";
			this.coltejrimInvoiceId.MinWidth = 25;
			this.coltejrimInvoiceId.Name = "coltejrimInvoiceId";
			this.coltejrimInvoiceId.Visible = true;
			this.coltejrimInvoiceId.VisibleIndex = 0;
			this.coltejrimInvoiceId.Width = 94;
			// 
			// chkInvoiceId
			// 
			this.chkInvoiceId.AutoHeight = false;
			this.chkInvoiceId.Name = "chkInvoiceId";
			// 
			// colJobNo
			// 
			this.colJobNo.Caption = "JobNo";
			this.colJobNo.FieldName = "JobNo";
			this.colJobNo.MinWidth = 25;
			this.colJobNo.Name = "colJobNo";
			this.colJobNo.OptionsColumn.AllowEdit = false;
			this.colJobNo.Visible = true;
			this.colJobNo.VisibleIndex = 1;
			this.colJobNo.Width = 74;
			// 
			// colJobDate
			// 
			this.colJobDate.Caption = "Job Date";
			this.colJobDate.ColumnEdit = this.repDateFormat;
			this.colJobDate.FieldName = "JobDate";
			this.colJobDate.MinWidth = 25;
			this.colJobDate.Name = "colJobDate";
			this.colJobDate.OptionsColumn.AllowEdit = false;
			this.colJobDate.Visible = true;
			this.colJobDate.VisibleIndex = 27;
			this.colJobDate.Width = 99;
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
			// colTejrimDate
			// 
			this.colTejrimDate.Caption = "Jejrim Date";
			this.colTejrimDate.ColumnEdit = this.repDateFormat;
			this.colTejrimDate.FieldName = "DeliveredDate";
			this.colTejrimDate.MinWidth = 25;
			this.colTejrimDate.Name = "colTejrimDate";
			this.colTejrimDate.OptionsColumn.AllowEdit = false;
			this.colTejrimDate.Visible = true;
			this.colTejrimDate.VisibleIndex = 2;
			this.colTejrimDate.Width = 94;
			// 
			// colDeliveredDate
			// 
			this.colDeliveredDate.Caption = "Delivered Date";
			this.colDeliveredDate.ColumnEdit = this.repDateFormat;
			this.colDeliveredDate.FieldName = "DeliveredDate";
			this.colDeliveredDate.MinWidth = 25;
			this.colDeliveredDate.Name = "colDeliveredDate";
			this.colDeliveredDate.Visible = true;
			this.colDeliveredDate.VisibleIndex = 4;
			this.colDeliveredDate.Width = 94;
			// 
			// colReferenceNo
			// 
			this.colReferenceNo.Caption = "XONO";
			this.colReferenceNo.FieldName = "ReferenceNo";
			this.colReferenceNo.MinWidth = 25;
			this.colReferenceNo.Name = "colReferenceNo";
			this.colReferenceNo.OptionsColumn.AllowEdit = false;
			this.colReferenceNo.Visible = true;
			this.colReferenceNo.VisibleIndex = 3;
			this.colReferenceNo.Width = 105;
			// 
			// colMbol
			// 
			this.colMbol.Caption = "Mbl";
			this.colMbol.FieldName = "Mbl";
			this.colMbol.MinWidth = 25;
			this.colMbol.Name = "colMbol";
			this.colMbol.OptionsColumn.AllowEdit = false;
			this.colMbol.Visible = true;
			this.colMbol.VisibleIndex = 5;
			this.colMbol.Width = 136;
			// 
			// colCustomerName
			// 
			this.colCustomerName.Caption = "Customer Name";
			this.colCustomerName.FieldName = "CustomerName";
			this.colCustomerName.MinWidth = 25;
			this.colCustomerName.Name = "colCustomerName";
			this.colCustomerName.Visible = true;
			this.colCustomerName.VisibleIndex = 6;
			this.colCustomerName.Width = 283;
			// 
			// colConsigneeName
			// 
			this.colConsigneeName.Caption = "Consignee Name";
			this.colConsigneeName.FieldName = "Consignee";
			this.colConsigneeName.MinWidth = 25;
			this.colConsigneeName.Name = "colConsigneeName";
			this.colConsigneeName.OptionsColumn.AllowEdit = false;
			this.colConsigneeName.Visible = true;
			this.colConsigneeName.VisibleIndex = 7;
			this.colConsigneeName.Width = 348;
			// 
			// colClearingAgent
			// 
			this.colClearingAgent.Caption = "Clearing Agent";
			this.colClearingAgent.FieldName = "ClearingAgent";
			this.colClearingAgent.MinWidth = 25;
			this.colClearingAgent.Name = "colClearingAgent";
			this.colClearingAgent.OptionsColumn.AllowEdit = false;
			this.colClearingAgent.Visible = true;
			this.colClearingAgent.VisibleIndex = 8;
			this.colClearingAgent.Width = 203;
			// 
			// colPol
			// 
			this.colPol.Caption = "POL";
			this.colPol.FieldName = "Departure";
			this.colPol.MinWidth = 25;
			this.colPol.Name = "colPol";
			this.colPol.OptionsColumn.AllowEdit = false;
			this.colPol.Visible = true;
			this.colPol.VisibleIndex = 9;
			this.colPol.Width = 130;
			// 
			// colPod
			// 
			this.colPod.Caption = "POD";
			this.colPod.FieldName = "Destination";
			this.colPod.MinWidth = 25;
			this.colPod.Name = "colPod";
			this.colPod.OptionsColumn.AllowEdit = false;
			this.colPod.Visible = true;
			this.colPod.VisibleIndex = 10;
			this.colPod.Width = 113;
			// 
			// colVessel
			// 
			this.colVessel.Caption = "Vessel";
			this.colVessel.FieldName = "Vessel";
			this.colVessel.MinWidth = 25;
			this.colVessel.Name = "colVessel";
			this.colVessel.OptionsColumn.AllowEdit = false;
			this.colVessel.Visible = true;
			this.colVessel.VisibleIndex = 11;
			this.colVessel.Width = 182;
			// 
			// colAtd
			// 
			this.colAtd.Caption = "ATD";
			this.colAtd.ColumnEdit = this.repDateFormat;
			this.colAtd.FieldName = "ATD";
			this.colAtd.MinWidth = 25;
			this.colAtd.Name = "colAtd";
			this.colAtd.OptionsColumn.AllowEdit = false;
			this.colAtd.Visible = true;
			this.colAtd.VisibleIndex = 12;
			this.colAtd.Width = 94;
			// 
			// colAta
			// 
			this.colAta.Caption = "ATA";
			this.colAta.ColumnEdit = this.repDateFormat;
			this.colAta.FieldName = "ATA";
			this.colAta.MinWidth = 25;
			this.colAta.Name = "colAta";
			this.colAta.OptionsColumn.AllowEdit = false;
			this.colAta.Visible = true;
			this.colAta.VisibleIndex = 13;
			this.colAta.Width = 94;
			// 
			// colETD
			// 
			this.colETD.Caption = "ETD";
			this.colETD.ColumnEdit = this.repDateFormat;
			this.colETD.FieldName = "ETD";
			this.colETD.MinWidth = 25;
			this.colETD.Name = "colETD";
			this.colETD.OptionsColumn.AllowEdit = false;
			this.colETD.Visible = true;
			this.colETD.VisibleIndex = 14;
			this.colETD.Width = 94;
			// 
			// colETA
			// 
			this.colETA.Caption = "ETA";
			this.colETA.ColumnEdit = this.repDateFormat;
			this.colETA.FieldName = "ETA";
			this.colETA.MinWidth = 25;
			this.colETA.Name = "colETA";
			this.colETA.OptionsColumn.AllowEdit = false;
			this.colETA.Visible = true;
			this.colETA.VisibleIndex = 15;
			this.colETA.Width = 94;
			// 
			// colSales
			// 
			this.colSales.Caption = "Sales";
			this.colSales.FieldName = "Salesman";
			this.colSales.MinWidth = 25;
			this.colSales.Name = "colSales";
			this.colSales.OptionsColumn.AllowEdit = false;
			this.colSales.Visible = true;
			this.colSales.VisibleIndex = 16;
			this.colSales.Width = 111;
			// 
			// colAgent
			// 
			this.colAgent.Caption = "Agent";
			this.colAgent.FieldName = "AgentName";
			this.colAgent.MinWidth = 25;
			this.colAgent.Name = "colAgent";
			this.colAgent.OptionsColumn.AllowEdit = false;
			this.colAgent.Visible = true;
			this.colAgent.VisibleIndex = 17;
			this.colAgent.Width = 253;
			// 
			// colStatus
			// 
			this.colStatus.Caption = "Status";
			this.colStatus.FieldName = "Status";
			this.colStatus.MinWidth = 25;
			this.colStatus.Name = "colStatus";
			this.colStatus.OptionsColumn.AllowEdit = false;
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 18;
			this.colStatus.Width = 416;
			// 
			// colJobType
			// 
			this.colJobType.Caption = "JobType";
			this.colJobType.FieldName = "JobType";
			this.colJobType.MinWidth = 25;
			this.colJobType.Name = "colJobType";
			this.colJobType.OptionsColumn.AllowEdit = false;
			this.colJobType.Visible = true;
			this.colJobType.VisibleIndex = 19;
			this.colJobType.Width = 94;
			// 
			// colMissingDocs
			// 
			this.colMissingDocs.Caption = "Missing Docs";
			this.colMissingDocs.FieldName = "MissingDocs";
			this.colMissingDocs.MinWidth = 25;
			this.colMissingDocs.Name = "colMissingDocs";
			this.colMissingDocs.OptionsColumn.AllowEdit = false;
			this.colMissingDocs.Visible = true;
			this.colMissingDocs.VisibleIndex = 20;
			this.colMissingDocs.Width = 117;
			// 
			// colSeaCarrier
			// 
			this.colSeaCarrier.Caption = "Sea Carrier";
			this.colSeaCarrier.FieldName = "SeaCarrier";
			this.colSeaCarrier.MinWidth = 25;
			this.colSeaCarrier.Name = "colSeaCarrier";
			this.colSeaCarrier.OptionsColumn.AllowEdit = false;
			this.colSeaCarrier.Visible = true;
			this.colSeaCarrier.VisibleIndex = 21;
			this.colSeaCarrier.Width = 94;
			// 
			// colContainerType
			// 
			this.colContainerType.Caption = "Container Type";
			this.colContainerType.FieldName = "ContainerType";
			this.colContainerType.MinWidth = 25;
			this.colContainerType.Name = "colContainerType";
			this.colContainerType.OptionsColumn.AllowEdit = false;
			this.colContainerType.Visible = true;
			this.colContainerType.VisibleIndex = 22;
			this.colContainerType.Width = 140;
			// 
			// colLoadedStatus
			// 
			this.colLoadedStatus.Caption = "Loaded Status";
			this.colLoadedStatus.FieldName = "LoadedStatus";
			this.colLoadedStatus.MinWidth = 25;
			this.colLoadedStatus.Name = "colLoadedStatus";
			this.colLoadedStatus.OptionsColumn.AllowEdit = false;
			this.colLoadedStatus.Visible = true;
			this.colLoadedStatus.VisibleIndex = 23;
			this.colLoadedStatus.Width = 114;
			// 
			// colLoadedDestination
			// 
			this.colLoadedDestination.Caption = "Loaded Destination";
			this.colLoadedDestination.FieldName = "LoadedDestination";
			this.colLoadedDestination.MinWidth = 25;
			this.colLoadedDestination.Name = "colLoadedDestination";
			this.colLoadedDestination.OptionsColumn.AllowEdit = false;
			this.colLoadedDestination.Visible = true;
			this.colLoadedDestination.VisibleIndex = 24;
			this.colLoadedDestination.Width = 132;
			// 
			// colLoadingDate
			// 
			this.colLoadingDate.Caption = "Loading Date";
			this.colLoadingDate.ColumnEdit = this.repDateFormat;
			this.colLoadingDate.FieldName = "DateOfLoading";
			this.colLoadingDate.MinWidth = 25;
			this.colLoadingDate.Name = "colLoadingDate";
			this.colLoadingDate.OptionsColumn.AllowEdit = false;
			this.colLoadingDate.Visible = true;
			this.colLoadingDate.VisibleIndex = 25;
			this.colLoadingDate.Width = 128;
			// 
			// colCutOffDate
			// 
			this.colCutOffDate.Caption = "Cut-Off Date";
			this.colCutOffDate.ColumnEdit = this.repDateFormat;
			this.colCutOffDate.FieldName = "CutOffDate";
			this.colCutOffDate.MinWidth = 25;
			this.colCutOffDate.Name = "colCutOffDate";
			this.colCutOffDate.OptionsColumn.AllowEdit = false;
			this.colCutOffDate.Visible = true;
			this.colCutOffDate.VisibleIndex = 26;
			this.colCutOffDate.Width = 153;
			// 
			// colTotalProfit
			// 
			this.colTotalProfit.Caption = "Total Profit";
			this.colTotalProfit.FieldName = "TotalProfit";
			this.colTotalProfit.MinWidth = 25;
			this.colTotalProfit.Name = "colTotalProfit";
			this.colTotalProfit.OptionsColumn.AllowEdit = false;
			this.colTotalProfit.Width = 168;
			// 
			// rcTejrimList
			// 
			this.rcTejrimList.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
			this.rcTejrimList.ExpandCollapseItem.Id = 0;
			this.rcTejrimList.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcTejrimList.ExpandCollapseItem,
            this.btnNew,
            this.biShowList,
            this.bmiHideDetail,
            this.bmiHorizontalLayout,
            this.bmiShowList,
            this.biPrintSubItem,
            this.bmiPrintInvoice,
            this.bmiPrintSalesSummary,
            this.bmiPrintSalesAnalysis,
            this.hiItemsCount,
            this.biShowMasterDetail,
            this.btnEdit,
            this.btnRefresh,
            this.btnPrint,
            this.btnDelete,
            this.btnClose,
            this.dtFrom,
            this.dtTo,
            this.btnPrintAll,
            this.barCheckInvoiced,
            this.btnResetGridStyle,
            this.cboSales,
            this.cboUsers,
            this.cboMembers});
			this.rcTejrimList.Location = new System.Drawing.Point(0, 0);
			this.rcTejrimList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcTejrimList.MaxItemId = 29;
			this.rcTejrimList.Name = "rcTejrimList";
			this.rcTejrimList.OptionsMenuMinWidth = 385;
			this.rcTejrimList.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpTejrimList,
            this.rpViewSettings});
			this.rcTejrimList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit18,
            this.repositoryItemDateEdit19,
            this.repSales,
            this.repUsers,
            this.repCustomers});
			this.rcTejrimList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
			this.rcTejrimList.Size = new System.Drawing.Size(1394, 193);
			this.rcTejrimList.StatusBar = this.ribbonStatusBar1;
			// 
			// btnNew
			// 
			this.btnNew.Caption = "Add New";
			this.btnNew.Enabled = false;
			this.btnNew.Id = 1;
			this.btnNew.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.btnNew.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewOrder.svg";
			this.btnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNew.ImageOptions.SvgImage")));
			this.btnNew.Name = "btnNew";
			// 
			// biShowList
			// 
			this.biShowList.Caption = "List";
			this.biShowList.GroupIndex = 1;
			this.biShowList.Id = 4;
			this.biShowList.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.biShowList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biShowList.ImageOptions.SvgImage")));
			this.biShowList.Name = "biShowList";
			// 
			// bmiHideDetail
			// 
			this.bmiHideDetail.Caption = "Off";
			this.bmiHideDetail.GroupIndex = 2;
			this.bmiHideDetail.Id = 7;
			this.bmiHideDetail.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelOff.svg?Size=16x16";
			this.bmiHideDetail.Name = "bmiHideDetail";
			// 
			// bmiHorizontalLayout
			// 
			this.bmiHorizontalLayout.Caption = "Right";
			this.bmiHorizontalLayout.GroupIndex = 2;
			this.bmiHorizontalLayout.Id = 6;
			this.bmiHorizontalLayout.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.DataPanel.svg?Size=16x16";
			this.bmiHorizontalLayout.Name = "bmiHorizontalLayout";
			// 
			// bmiShowList
			// 
			this.bmiShowList.Caption = "List";
			this.bmiShowList.GroupIndex = 3;
			this.bmiShowList.Id = 4;
			this.bmiShowList.Name = "bmiShowList";
			// 
			// biPrintSubItem
			// 
			this.biPrintSubItem.Caption = "Print";
			this.biPrintSubItem.Id = 10;
			this.biPrintSubItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.biPrintSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg";
			this.biPrintSubItem.ImageOptions.LargeImageIndex = 30;
			this.biPrintSubItem.Name = "biPrintSubItem";
			this.biPrintSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
			// 
			// bmiPrintInvoice
			// 
			this.bmiPrintInvoice.Caption = "Invoice";
			this.bmiPrintInvoice.GroupIndex = 5;
			this.bmiPrintInvoice.Id = 6;
			this.bmiPrintInvoice.Name = "bmiPrintInvoice";
			// 
			// bmiPrintSalesSummary
			// 
			this.bmiPrintSalesSummary.Caption = "Summary Report";
			this.bmiPrintSalesSummary.Id = 9;
			this.bmiPrintSalesSummary.Name = "bmiPrintSalesSummary";
			// 
			// bmiPrintSalesAnalysis
			// 
			this.bmiPrintSalesAnalysis.Caption = "Sales Analysis";
			this.bmiPrintSalesAnalysis.Id = 10;
			this.bmiPrintSalesAnalysis.Name = "bmiPrintSalesAnalysis";
			// 
			// hiItemsCount
			// 
			this.hiItemsCount.Caption = "RECORDS: 0";
			this.hiItemsCount.Id = 7;
			this.hiItemsCount.Name = "hiItemsCount";
			// 
			// biShowMasterDetail
			// 
			this.biShowMasterDetail.Caption = "Detail";
			this.biShowMasterDetail.GroupIndex = 1;
			this.biShowMasterDetail.Id = 11;
			this.biShowMasterDetail.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.biShowMasterDetail.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biShowMasterDetail.ImageOptions.SvgImage")));
			this.biShowMasterDetail.Name = "biShowMasterDetail";
			// 
			// btnEdit
			// 
			this.btnEdit.Caption = "Edit";
			this.btnEdit.Enabled = false;
			this.btnEdit.Id = 16;
			this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
			this.btnEdit.Name = "btnEdit";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Caption = "Refresh";
			this.btnRefresh.Id = 17;
			this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
			this.btnRefresh.Name = "btnRefresh";
			// 
			// btnPrint
			// 
			this.btnPrint.Caption = "Print View";
			this.btnPrint.Enabled = false;
			this.btnPrint.Id = 18;
			this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Caption = "Delete";
			this.btnDelete.Enabled = false;
			this.btnDelete.Id = 19;
			this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
			this.btnDelete.Name = "btnDelete";
			// 
			// btnClose
			// 
			this.btnClose.Caption = "Close";
			this.btnClose.Id = 20;
			this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
			this.btnClose.Name = "btnClose";
			this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
			// 
			// dtFrom
			// 
			this.dtFrom.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.True;
			this.dtFrom.Caption = "From";
			this.dtFrom.CaptionToEditorIndent = 20;
			this.dtFrom.Edit = this.repositoryItemDateEdit18;
			this.dtFrom.EditWidth = 150;
			this.dtFrom.Id = 21;
			this.dtFrom.Name = "dtFrom";
			this.dtFrom.EditValueChanged += new System.EventHandler(this.dtFrom_EditValueChanged);
			// 
			// repositoryItemDateEdit18
			// 
			this.repositoryItemDateEdit18.AutoHeight = false;
			this.repositoryItemDateEdit18.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit18.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit18.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repositoryItemDateEdit18.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.repositoryItemDateEdit18.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repositoryItemDateEdit18.Name = "repositoryItemDateEdit18";
			this.repositoryItemDateEdit18.UseMaskAsDisplayFormat = true;
			// 
			// dtTo
			// 
			this.dtTo.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.True;
			this.dtTo.Caption = "To";
			this.dtTo.CaptionToEditorIndent = 33;
			this.dtTo.Edit = this.repositoryItemDateEdit19;
			this.dtTo.EditWidth = 150;
			this.dtTo.Id = 22;
			this.dtTo.Name = "dtTo";
			this.dtTo.EditValueChanged += new System.EventHandler(this.dtTo_EditValueChanged);
			// 
			// repositoryItemDateEdit19
			// 
			this.repositoryItemDateEdit19.AutoHeight = false;
			this.repositoryItemDateEdit19.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit19.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemDateEdit19.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repositoryItemDateEdit19.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.repositoryItemDateEdit19.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.repositoryItemDateEdit19.Name = "repositoryItemDateEdit19";
			this.repositoryItemDateEdit19.UseMaskAsDisplayFormat = true;
			// 
			// btnPrintAll
			// 
			this.btnPrintAll.Caption = "Print All";
			this.btnPrintAll.Enabled = false;
			this.btnPrintAll.Id = 23;
			this.btnPrintAll.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintAll.ImageOptions.SvgImage")));
			this.btnPrintAll.Name = "btnPrintAll";
			this.btnPrintAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintAll_ItemClick);
			// 
			// barCheckInvoiced
			// 
			this.barCheckInvoiced.Caption = "Invoiced";
			this.barCheckInvoiced.Enabled = false;
			this.barCheckInvoiced.Id = 24;
			this.barCheckInvoiced.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barCheckInvoiced.ImageOptions.SvgImage")));
			this.barCheckInvoiced.Name = "barCheckInvoiced";
			this.barCheckInvoiced.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckInvoiced_CheckedChanged);
			// 
			// btnResetGridStyle
			// 
			this.btnResetGridStyle.Caption = "Reset Grid Style";
			this.btnResetGridStyle.Id = 25;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			this.btnResetGridStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetGridStyle_ItemClick);
			// 
			// cboSales
			// 
			this.cboSales.Caption = "By Sales";
			this.cboSales.CaptionToEditorIndent = 35;
			this.cboSales.Edit = this.repSales;
			this.cboSales.EditWidth = 150;
			this.cboSales.Id = 26;
			this.cboSales.Name = "cboSales";
			this.cboSales.EditValueChanged += new System.EventHandler(this.cboSales_EditValueChanged);
			// 
			// repSales
			// 
			this.repSales.AutoHeight = false;
			this.repSales.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repSales.DisplayMember = "UserName";
			this.repSales.Name = "repSales";
			this.repSales.NullText = "";
			this.repSales.PopupView = this.repositoryItemSearchLookUpEdit1View;
			this.repSales.ValueMember = "Id";
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
			this.gridColumn1.Width = 94;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Salesman";
			this.gridColumn2.FieldName = "UserName";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			this.gridColumn2.Width = 1114;
			// 
			// cboUsers
			// 
			this.cboUsers.Caption = "By User";
			this.cboUsers.CaptionToEditorIndent = 40;
			this.cboUsers.Edit = this.repUsers;
			this.cboUsers.EditWidth = 150;
			this.cboUsers.Id = 27;
			this.cboUsers.Name = "cboUsers";
			this.cboUsers.EditValueChanged += new System.EventHandler(this.cboUsers_EditValueChanged);
			// 
			// repUsers
			// 
			this.repUsers.AutoHeight = false;
			this.repUsers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repUsers.DisplayMember = "UserName";
			this.repUsers.Name = "repUsers";
			this.repUsers.NullText = "";
			this.repUsers.PopupView = this.gridView1;
			this.repUsers.ValueMember = "Id";
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
			this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Id";
			this.gridColumn3.FieldName = "Id";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 0;
			this.gridColumn3.Width = 111;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "User Name";
			this.gridColumn4.FieldName = "UserName";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 1;
			this.gridColumn4.Width = 1097;
			// 
			// cboMembers
			// 
			this.cboMembers.Caption = "By Customer";
			this.cboMembers.CaptionToEditorIndent = 15;
			this.cboMembers.Edit = this.repCustomers;
			this.cboMembers.EditWidth = 150;
			this.cboMembers.Id = 28;
			this.cboMembers.Name = "cboMembers";
			this.cboMembers.EditValueChanged += new System.EventHandler(this.cboMembers_EditValueChanged);
			// 
			// repCustomers
			// 
			this.repCustomers.AutoHeight = false;
			this.repCustomers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCustomers.DisplayMember = "CustomerName";
			this.repCustomers.Name = "repCustomers";
			this.repCustomers.NullText = "";
			this.repCustomers.PopupView = this.gridView2;
			this.repCustomers.ValueMember = "Id";
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
			this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView2.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn5
			// 
			this.gridColumn5.Caption = "Id";
			this.gridColumn5.FieldName = "Id";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 0;
			this.gridColumn5.Width = 89;
			// 
			// gridColumn6
			// 
			this.gridColumn6.Caption = "Customer Name";
			this.gridColumn6.FieldName = "CustomerName";
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.Visible = true;
			this.gridColumn6.VisibleIndex = 1;
			this.gridColumn6.Width = 1119;
			// 
			// rpTejrimList
			// 
			this.rpTejrimList.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.rpgDelete,
            this.ribbonPageGroup2,
            this.rpgCloseView,
            this.ilters,
            this.ribbonPageGroup5});
			this.rpTejrimList.Name = "rpTejrimList";
			this.rpTejrimList.Text = "TEJRIM JOBS";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.AllowTextClipping = false;
			this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup1.ItemLinks.Add(this.btnNew);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "New";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.AllowTextClipping = false;
			this.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup3.ItemLinks.Add(this.btnEdit);
			this.ribbonPageGroup3.ItemLinks.Add(this.btnRefresh);
			this.ribbonPageGroup3.ItemLinks.Add(this.btnPrint);
			this.ribbonPageGroup3.ItemLinks.Add(this.btnPrintAll, true);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.Text = "Actions";
			// 
			// rpgDelete
			// 
			this.rpgDelete.ItemLinks.Add(this.btnDelete);
			this.rpgDelete.Name = "rpgDelete";
			this.rpgDelete.Text = "Delete";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.dtFrom);
			this.ribbonPageGroup2.ItemLinks.Add(this.dtTo);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "Filter Date";
			// 
			// rpgCloseView
			// 
			this.rpgCloseView.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
			this.rpgCloseView.ItemLinks.Add(this.btnClose);
			this.rpgCloseView.Name = "rpgCloseView";
			this.rpgCloseView.Text = "Close View";
			// 
			// ilters
			// 
			this.ilters.ItemLinks.Add(this.cboMembers);
			this.ilters.ItemLinks.Add(this.cboUsers);
			this.ilters.ItemLinks.Add(this.cboSales);
			this.ilters.Name = "ilters";
			this.ilters.Text = "FILTERS";
			// 
			// ribbonPageGroup5
			// 
			this.ribbonPageGroup5.ItemLinks.Add(this.barCheckInvoiced);
			this.ribbonPageGroup5.Name = "ribbonPageGroup5";
			this.ribbonPageGroup5.Text = "With Invoice";
			// 
			// rpViewSettings
			// 
			this.rpViewSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
			this.rpViewSettings.Name = "rpViewSettings";
			this.rpViewSettings.Text = "VIEW SETTINGS";
			// 
			// ribbonPageGroup4
			// 
			this.ribbonPageGroup4.ItemLinks.Add(this.btnResetGridStyle);
			this.ribbonPageGroup4.Name = "ribbonPageGroup4";
			this.ribbonPageGroup4.Text = "Grid Settings";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 736);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcTejrimList;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1394, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.gcTejrimList);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1394, 543);
			this.mainLayout.TabIndex = 4;
			this.mainLayout.Text = "layoutControl1";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1394, 543);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcTejrimList;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1370, 519);
			this.layoutControlItem1.TextVisible = false;
			// 
			// TejrimJobsListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1394, 766);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcTejrimList);
			this.Name = "TejrimJobsListForm";
			this.Ribbon = this.rcTejrimList;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Tejrim List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TejrimListForm_FormClosing);
			this.Load += new System.EventHandler(this.TejrimListForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gcTejrimList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvTejrimList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkInvoiceId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rcTejrimList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit18.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit19.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rcTejrimList;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarCheckItem biShowList;
        private DevExpress.XtraBars.BarCheckItem bmiHideDetail;
        private DevExpress.XtraBars.BarCheckItem bmiHorizontalLayout;
        private DevExpress.XtraBars.BarCheckItem bmiShowList;
        private DevExpress.XtraBars.BarSubItem biPrintSubItem;
        private DevExpress.XtraBars.BarButtonItem bmiPrintInvoice;
        private DevExpress.XtraBars.BarButtonItem bmiPrintSalesSummary;
        private DevExpress.XtraBars.BarButtonItem bmiPrintSalesAnalysis;
        private DevExpress.XtraBars.BarHeaderItem hiItemsCount;
        private DevExpress.XtraBars.BarCheckItem biShowMasterDetail;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpTejrimList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgCloseView;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcTejrimList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTejrimList;
        private DevExpress.XtraGrid.Columns.GridColumn colJobNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMbol;
        private DevExpress.XtraGrid.Columns.GridColumn colConsigneeName;
        private DevExpress.XtraGrid.Columns.GridColumn colPod;
        private DevExpress.XtraGrid.Columns.GridColumn colPol;
        private DevExpress.XtraGrid.Columns.GridColumn colVessel;
        private DevExpress.XtraGrid.Columns.GridColumn colSales;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colETD;
        private DevExpress.XtraGrid.Columns.GridColumn colETA;
        private DevExpress.XtraGrid.Columns.GridColumn colAtd;
        private DevExpress.XtraGrid.Columns.GridColumn colAta;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarEditItem dtFrom;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit18;
        private DevExpress.XtraBars.BarEditItem dtTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit19;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn colAgent;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colJobType;
        private DevExpress.XtraGrid.Columns.GridColumn colMissingDocs;
        private DevExpress.XtraGrid.Columns.GridColumn colSeaCarrier;
        private DevExpress.XtraGrid.Columns.GridColumn colContainerType;
        private DevExpress.XtraGrid.Columns.GridColumn colLoadedStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colLoadedDestination;
        private DevExpress.XtraGrid.Columns.GridColumn colLoadingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCutOffDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProfit;
        private DevExpress.XtraGrid.Columns.GridColumn colJobDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDateFormat;
        private DevExpress.XtraGrid.Columns.GridColumn colTejrimDate;
        private DevExpress.XtraBars.BarButtonItem btnPrintAll;
        private DevExpress.XtraGrid.Columns.GridColumn coltejrimInvoiceId;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkInvoiceId;
        private DevExpress.XtraGrid.Columns.GridColumn colClearingAgent;
        private DevExpress.XtraBars.BarCheckItem barCheckInvoiced;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ilters;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.BarEditItem cboSales;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSales;
		private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
		private DevExpress.XtraBars.BarEditItem cboUsers;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repUsers;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraBars.BarEditItem cboMembers;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repCustomers;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private DevExpress.XtraGrid.Columns.GridColumn colDeliveredDate;
		private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
	}
}