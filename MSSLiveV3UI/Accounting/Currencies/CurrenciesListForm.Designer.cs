using MISLiveMed.Models.Models.Common.Currencies;

namespace MISLiveMed.UI.Accounting.Currencies
{
    partial class CurrenciesListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrenciesListForm));
			this.rcCurrenciesList = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.btnShowDetails = new DevExpress.XtraBars.BarCheckItem();
			this.btnExchangeCurrencies = new DevExpress.XtraBars.BarButtonItem();
			this.dtCurrentDate = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.btnSave = new DevExpress.XtraBars.BarButtonItem();
			this.rpCurrenciesList = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgHistory = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgExchangeCurrencies = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgDate = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.gcExchangeCurrencies = new DevExpress.XtraGrid.GridControl();
			this.bsExchangeCurrencies = new System.Windows.Forms.BindingSource(this.components);
			this.gvExchangeCurrencies = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCurrencies = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colExchangeDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colExchangeValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repTextFormat = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colNotes1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gcCurrencies = new DevExpress.XtraGrid.GridControl();
			this.bsCurrencies = new System.Windows.Forms.BindingSource(this.components);
			this.gvCurrencies = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrencySymbol = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrencyName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDivByLocalRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colDivideByForeignRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colDecimals = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRounding = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutCurrencies = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutExchangeCurrencies = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.rcCurrenciesList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcExchangeCurrencies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsExchangeCurrencies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvExchangeCurrencies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCurrencies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repTextFormat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcCurrencies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCurrencies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCurrencies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutCurrencies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutExchangeCurrencies)).BeginInit();
			this.SuspendLayout();
			// 
			// rcCurrenciesList
			// 
			this.rcCurrenciesList.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcCurrenciesList.ExpandCollapseItem.Id = 0;
			this.rcCurrenciesList.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcCurrenciesList.ExpandCollapseItem,
            this.btnNew,
            this.btnDelete,
            this.btnEdit,
            this.btnPrint,
            this.btnRefresh,
            this.btnClose,
            this.btnResetGridStyle,
            this.btnShowDetails,
            this.btnExchangeCurrencies,
            this.dtCurrentDate,
            this.btnSave});
			this.rcCurrenciesList.Location = new System.Drawing.Point(0, 0);
			this.rcCurrenciesList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcCurrenciesList.MaxItemId = 48;
			this.rcCurrenciesList.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.rcCurrenciesList.Name = "rcCurrenciesList";
			this.rcCurrenciesList.OptionsMenuMinWidth = 385;
			this.rcCurrenciesList.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpCurrenciesList,
            this.rpViewSettings});
			this.rcCurrenciesList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
			this.rcCurrenciesList.Size = new System.Drawing.Size(1408, 193);
			this.rcCurrenciesList.StatusBar = this.ribbonStatusBar1;
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
			// btnResetGridStyle
			// 
			this.btnResetGridStyle.Caption = "Reset Grid Style";
			this.btnResetGridStyle.Id = 41;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			this.btnResetGridStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetGridStyle_ItemClick);
			// 
			// btnShowDetails
			// 
			this.btnShowDetails.Caption = "Hide Details";
			this.btnShowDetails.Id = 43;
			this.btnShowDetails.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnShowDetails.ImageOptions.SvgImage")));
			this.btnShowDetails.Name = "btnShowDetails";
			this.btnShowDetails.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowDetails_CheckedChanged);
			// 
			// btnExchangeCurrencies
			// 
			this.btnExchangeCurrencies.Caption = "Exchange Currencies";
			this.btnExchangeCurrencies.Id = 45;
			this.btnExchangeCurrencies.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExchangeCurrencies.ImageOptions.SvgImage")));
			this.btnExchangeCurrencies.Name = "btnExchangeCurrencies";
			this.btnExchangeCurrencies.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExchangeCurrencies_ItemClick);
			// 
			// dtCurrentDate
			// 
			this.dtCurrentDate.Caption = "Exchange Date";
			this.dtCurrentDate.Edit = this.repositoryItemDateEdit1;
			this.dtCurrentDate.EditWidth = 120;
			this.dtCurrentDate.Id = 46;
			this.dtCurrentDate.Name = "dtCurrentDate";
			this.dtCurrentDate.EditValueChanged += new System.EventHandler(this.btnCurrentDate_EditValueChanged);
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
			// btnSave
			// 
			this.btnSave.Caption = "Save";
			this.btnSave.Enabled = false;
			this.btnSave.Id = 47;
			this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
			this.btnSave.Name = "btnSave";
			this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
			// 
			// rpCurrenciesList
			// 
			this.rpCurrenciesList.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup11,
            this.rpgHistory,
            this.rpgExchangeCurrencies,
            this.rpgDate});
			this.rpCurrenciesList.Name = "rpCurrenciesList";
			this.rpCurrenciesList.Text = "CURRENCIES";
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
			this.ribbonPageGroup6.ItemLinks.Add(this.btnSave);
			this.ribbonPageGroup6.ItemLinks.Add(this.btnEdit, true);
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
			// rpgHistory
			// 
			this.rpgHistory.ItemLinks.Add(this.btnShowDetails);
			this.rpgHistory.Name = "rpgHistory";
			this.rpgHistory.Text = "History";
			// 
			// rpgExchangeCurrencies
			// 
			this.rpgExchangeCurrencies.ItemLinks.Add(this.btnExchangeCurrencies);
			this.rpgExchangeCurrencies.Name = "rpgExchangeCurrencies";
			this.rpgExchangeCurrencies.Text = "Exchange Currencies";
			// 
			// rpgDate
			// 
			this.rpgDate.ItemLinks.Add(this.dtCurrentDate);
			this.rpgDate.Name = "rpgDate";
			this.rpgDate.Text = "Current Date";
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
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 747);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcCurrenciesList;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1408, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.gcExchangeCurrencies);
			this.mainLayout.Controls.Add(this.gcCurrencies);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1408, 554);
			this.mainLayout.TabIndex = 7;
			this.mainLayout.Text = "layoutControl1";
			// 
			// gcExchangeCurrencies
			// 
			this.gcExchangeCurrencies.DataSource = this.bsExchangeCurrencies;
			this.gcExchangeCurrencies.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcExchangeCurrencies.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcExchangeCurrencies.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcExchangeCurrencies.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcExchangeCurrencies.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcExchangeCurrencies.Location = new System.Drawing.Point(12, 279);
			this.gcExchangeCurrencies.MainView = this.gvExchangeCurrencies;
			this.gcExchangeCurrencies.MenuManager = this.rcCurrenciesList;
			this.gcExchangeCurrencies.Name = "gcExchangeCurrencies";
			this.gcExchangeCurrencies.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTextFormat,
            this.repCurrencies});
			this.gcExchangeCurrencies.Size = new System.Drawing.Size(1384, 263);
			this.gcExchangeCurrencies.TabIndex = 6;
			this.gcExchangeCurrencies.UseEmbeddedNavigator = true;
			this.gcExchangeCurrencies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvExchangeCurrencies});
			this.gcExchangeCurrencies.Visible = false;
			// 
			// bsExchangeCurrencies
			// 
			this.bsExchangeCurrencies.DataSource = typeof(CurrencyExchangeModel);
			// 
			// gvExchangeCurrencies
			// 
			this.gvExchangeCurrencies.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.gridColumn1,
            this.colCurrencyId,
            this.colExchangeDate,
            this.colExchangeValue,
            this.colNotes1});
			this.gvExchangeCurrencies.GridControl = this.gcExchangeCurrencies;
			this.gvExchangeCurrencies.Name = "gvExchangeCurrencies";
			this.gvExchangeCurrencies.OptionsView.ShowGroupPanel = false;
			// 
			// colId1
			// 
			this.colId1.FieldName = "Id";
			this.colId1.MinWidth = 25;
			this.colId1.Name = "colId1";
			this.colId1.OptionsColumn.ReadOnly = true;
			this.colId1.Width = 98;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Week#";
			this.gridColumn1.FieldName = "WeekNumber";
			this.gridColumn1.MinWidth = 25;
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			this.gridColumn1.Width = 94;
			// 
			// colCurrencyId
			// 
			this.colCurrencyId.Caption = "Currency";
			this.colCurrencyId.ColumnEdit = this.repCurrencies;
			this.colCurrencyId.FieldName = "CurrencyId";
			this.colCurrencyId.MinWidth = 25;
			this.colCurrencyId.Name = "colCurrencyId";
			this.colCurrencyId.OptionsColumn.ReadOnly = true;
			this.colCurrencyId.Visible = true;
			this.colCurrencyId.VisibleIndex = 1;
			this.colCurrencyId.Width = 237;
			// 
			// repCurrencies
			// 
			this.repCurrencies.AutoHeight = false;
			this.repCurrencies.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCurrencies.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repCurrencies.DisplayMember = "CurrencyName";
			this.repCurrencies.Name = "repCurrencies";
			this.repCurrencies.NullText = "";
			this.repCurrencies.ValueMember = "Id";
			// 
			// colExchangeDate
			// 
			this.colExchangeDate.FieldName = "ExchangeDate";
			this.colExchangeDate.MinWidth = 25;
			this.colExchangeDate.Name = "colExchangeDate";
			this.colExchangeDate.OptionsColumn.ReadOnly = true;
			this.colExchangeDate.Visible = true;
			this.colExchangeDate.VisibleIndex = 2;
			this.colExchangeDate.Width = 184;
			// 
			// colExchangeValue
			// 
			this.colExchangeValue.ColumnEdit = this.repTextFormat;
			this.colExchangeValue.FieldName = "ExchangeValue";
			this.colExchangeValue.MinWidth = 25;
			this.colExchangeValue.Name = "colExchangeValue";
			this.colExchangeValue.Visible = true;
			this.colExchangeValue.VisibleIndex = 3;
			this.colExchangeValue.Width = 219;
			// 
			// repTextFormat
			// 
			this.repTextFormat.AutoHeight = false;
			this.repTextFormat.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.repTextFormat.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
			this.repTextFormat.MaskSettings.Set("mask", "n");
			this.repTextFormat.Name = "repTextFormat";
			this.repTextFormat.UseMaskAsDisplayFormat = true;
			// 
			// colNotes1
			// 
			this.colNotes1.FieldName = "Notes";
			this.colNotes1.MinWidth = 25;
			this.colNotes1.Name = "colNotes1";
			this.colNotes1.Visible = true;
			this.colNotes1.VisibleIndex = 4;
			this.colNotes1.Width = 616;
			// 
			// gcCurrencies
			// 
			this.gcCurrencies.DataSource = this.bsCurrencies;
			this.gcCurrencies.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcCurrencies.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcCurrencies.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcCurrencies.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcCurrencies.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcCurrencies.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcCurrencies.Location = new System.Drawing.Point(12, 12);
			this.gcCurrencies.MainView = this.gvCurrencies;
			this.gcCurrencies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcCurrencies.Name = "gcCurrencies";
			this.gcCurrencies.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4,
            this.repositoryItemCheckEdit1});
			this.gcCurrencies.Size = new System.Drawing.Size(1384, 263);
			this.gcCurrencies.TabIndex = 5;
			this.gcCurrencies.UseEmbeddedNavigator = true;
			this.gcCurrencies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCurrencies});
			this.gcCurrencies.DoubleClick += new System.EventHandler(this.gcCurrencies_DoubleClick);
			// 
			// bsCurrencies
			// 
			this.bsCurrencies.DataSource = typeof(CurrencyModel);
			// 
			// gvCurrencies
			// 
			this.gvCurrencies.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCurrencyCode,
            this.colCurrencySymbol,
            this.colCurrencyName,
            this.colDivByLocalRate,
            this.colDivideByForeignRate,
            this.colDecimals,
            this.colRounding,
            this.colNotes,
            this.colActive});
			this.gvCurrencies.DetailHeight = 458;
			this.gvCurrencies.GridControl = this.gcCurrencies;
			this.gvCurrencies.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", null, "")});
			this.gvCurrencies.Name = "gvCurrencies";
			this.gvCurrencies.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.gvCurrencies.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gvCurrencies.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvCurrencies.OptionsBehavior.Editable = false;
			this.gvCurrencies.OptionsDetail.EnableMasterViewMode = false;
			this.gvCurrencies.OptionsFind.AlwaysVisible = true;
			this.gvCurrencies.OptionsPrint.AutoWidth = false;
			this.gvCurrencies.OptionsPrint.PrintHorzLines = false;
			this.gvCurrencies.OptionsPrint.PrintVertLines = false;
			this.gvCurrencies.OptionsView.ColumnAutoWidth = false;
			this.gvCurrencies.OptionsView.ShowFooter = true;
			this.gvCurrencies.OptionsView.ShowGroupedColumns = true;
			this.gvCurrencies.OptionsView.ShowGroupPanel = false;
			this.gvCurrencies.OptionsView.ShowIndicator = false;
			this.gvCurrencies.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
			this.gvCurrencies.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvCurrencies_RowCellStyle);
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 46;
			// 
			// colCurrencyCode
			// 
			this.colCurrencyCode.Caption = "Code";
			this.colCurrencyCode.FieldName = "CurrencyCode";
			this.colCurrencyCode.MinWidth = 25;
			this.colCurrencyCode.Name = "colCurrencyCode";
			this.colCurrencyCode.Visible = true;
			this.colCurrencyCode.VisibleIndex = 1;
			this.colCurrencyCode.Width = 115;
			// 
			// colCurrencySymbol
			// 
			this.colCurrencySymbol.Caption = "Symbol";
			this.colCurrencySymbol.FieldName = "CurrencySymbol";
			this.colCurrencySymbol.MinWidth = 25;
			this.colCurrencySymbol.Name = "colCurrencySymbol";
			this.colCurrencySymbol.Visible = true;
			this.colCurrencySymbol.VisibleIndex = 2;
			this.colCurrencySymbol.Width = 67;
			// 
			// colCurrencyName
			// 
			this.colCurrencyName.Caption = "Name";
			this.colCurrencyName.FieldName = "CurrencyName";
			this.colCurrencyName.MinWidth = 25;
			this.colCurrencyName.Name = "colCurrencyName";
			this.colCurrencyName.Visible = true;
			this.colCurrencyName.VisibleIndex = 3;
			this.colCurrencyName.Width = 258;
			// 
			// colDivByLocalRate
			// 
			this.colDivByLocalRate.Caption = "Local Rate";
			this.colDivByLocalRate.ColumnEdit = this.repositoryItemTextEdit1;
			this.colDivByLocalRate.FieldName = "DivByLocalRate";
			this.colDivByLocalRate.MinWidth = 25;
			this.colDivByLocalRate.Name = "colDivByLocalRate";
			this.colDivByLocalRate.Visible = true;
			this.colDivByLocalRate.VisibleIndex = 4;
			this.colDivByLocalRate.Width = 145;
			// 
			// repositoryItemTextEdit1
			// 
			this.repositoryItemTextEdit1.AutoHeight = false;
			this.repositoryItemTextEdit1.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.repositoryItemTextEdit1.MaskSettings.Set("mask", "n");
			this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
			// 
			// colDivideByForeignRate
			// 
			this.colDivideByForeignRate.Caption = "Foreign Rate";
			this.colDivideByForeignRate.ColumnEdit = this.repositoryItemTextEdit2;
			this.colDivideByForeignRate.FieldName = "DivideByForeignRate";
			this.colDivideByForeignRate.MinWidth = 25;
			this.colDivideByForeignRate.Name = "colDivideByForeignRate";
			this.colDivideByForeignRate.Visible = true;
			this.colDivideByForeignRate.VisibleIndex = 5;
			this.colDivideByForeignRate.Width = 139;
			// 
			// repositoryItemTextEdit2
			// 
			this.repositoryItemTextEdit2.AutoHeight = false;
			this.repositoryItemTextEdit2.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.repositoryItemTextEdit2.MaskSettings.Set("mask", "n");
			this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
			// 
			// colDecimals
			// 
			this.colDecimals.FieldName = "Decimals";
			this.colDecimals.MinWidth = 25;
			this.colDecimals.Name = "colDecimals";
			this.colDecimals.Visible = true;
			this.colDecimals.VisibleIndex = 6;
			this.colDecimals.Width = 81;
			// 
			// colRounding
			// 
			this.colRounding.FieldName = "Rounding";
			this.colRounding.MinWidth = 25;
			this.colRounding.Name = "colRounding";
			this.colRounding.Visible = true;
			this.colRounding.VisibleIndex = 7;
			this.colRounding.Width = 76;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 8;
			this.colNotes.Width = 331;
			// 
			// colActive
			// 
			this.colActive.ColumnEdit = this.repositoryItemCheckEdit1;
			this.colActive.FieldName = "Active";
			this.colActive.MinWidth = 25;
			this.colActive.Name = "colActive";
			this.colActive.Visible = true;
			this.colActive.VisibleIndex = 9;
			this.colActive.Width = 94;
			// 
			// repositoryItemCheckEdit1
			// 
			this.repositoryItemCheckEdit1.AutoHeight = false;
			this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
			// 
			// repositoryItemTextEdit3
			// 
			this.repositoryItemTextEdit3.AutoHeight = false;
			this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
			// 
			// repositoryItemTextEdit4
			// 
			this.repositoryItemTextEdit4.AutoHeight = false;
			this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutCurrencies,
            this.layoutExchangeCurrencies});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1408, 554);
			this.Root.TextVisible = false;
			// 
			// layoutCurrencies
			// 
			this.layoutCurrencies.Control = this.gcCurrencies;
			this.layoutCurrencies.Location = new System.Drawing.Point(0, 0);
			this.layoutCurrencies.Name = "layoutCurrencies";
			this.layoutCurrencies.Size = new System.Drawing.Size(1388, 267);
			this.layoutCurrencies.TextSize = new System.Drawing.Size(0, 0);
			this.layoutCurrencies.TextVisible = false;
			// 
			// layoutExchangeCurrencies
			// 
			this.layoutExchangeCurrencies.Control = this.gcExchangeCurrencies;
			this.layoutExchangeCurrencies.Location = new System.Drawing.Point(0, 267);
			this.layoutExchangeCurrencies.Name = "layoutExchangeCurrencies";
			this.layoutExchangeCurrencies.Size = new System.Drawing.Size(1388, 267);
			this.layoutExchangeCurrencies.TextVisible = false;
			// 
			// CurrenciesListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1408, 777);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcCurrenciesList);
			this.Name = "CurrenciesListForm";
			this.Ribbon = this.rcCurrenciesList;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Currencies List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CurrenciesListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.rcCurrenciesList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcExchangeCurrencies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsExchangeCurrencies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvExchangeCurrencies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCurrencies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repTextFormat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcCurrencies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCurrencies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCurrencies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutCurrencies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutExchangeCurrencies)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraBars.Ribbon.RibbonControl rcCurrenciesList;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCurrenciesList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraGrid.GridControl gcCurrencies;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCurrencies;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutCurrencies;
        private System.Windows.Forms.BindingSource bsCurrencies;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencySymbol;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyName;
        private DevExpress.XtraGrid.Columns.GridColumn colDivByLocalRate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDivideByForeignRate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colDecimals;
        private DevExpress.XtraGrid.Columns.GridColumn colRounding;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private System.Windows.Forms.BindingSource bsExchangeCurrencies;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgHistory;
		private DevExpress.XtraBars.BarCheckItem btnShowDetails;
		private DevExpress.XtraGrid.GridControl gcExchangeCurrencies;
		private DevExpress.XtraGrid.Views.Grid.GridView gvExchangeCurrencies;
		private DevExpress.XtraLayout.LayoutControlItem layoutExchangeCurrencies;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgExchangeCurrencies;
		private DevExpress.XtraBars.BarButtonItem btnExchangeCurrencies;
		private DevExpress.XtraGrid.Columns.GridColumn colId1;
		private DevExpress.XtraGrid.Columns.GridColumn colCurrencyId;
		private DevExpress.XtraGrid.Columns.GridColumn colExchangeDate;
		private DevExpress.XtraGrid.Columns.GridColumn colExchangeValue;
		private DevExpress.XtraGrid.Columns.GridColumn colNotes1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDate;
		private DevExpress.XtraBars.BarEditItem dtCurrentDate;
		private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextFormat;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCurrencies;
		private DevExpress.XtraBars.BarButtonItem btnSave;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
	}
}