using MISLiveMed.Models.Models.Accounting.Commissions;

namespace MISLiveMed.UI.Accounting.Commissions
{
    partial class CommissionManagerListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommissionManagerListForm));
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges1 = new DevExpress.Skins.SkinPaddingEdges();
			DevExpress.Skins.SkinPaddingEdges skinPaddingEdges2 = new DevExpress.Skins.SkinPaddingEdges();
			this.rcCommissionManager = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.rgFilterReports = new DevExpress.XtraBars.RibbonGalleryBarItem();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.rpCommissionManager = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.bsCommissionManager = new System.Windows.Forms.BindingSource(this.components);
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.gcCommissionManager = new DevExpress.XtraGrid.GridControl();
			this.gvCommissionManager = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repUsers = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colContractStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.colContractEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSalesProfitShare = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRecurringSalesProfitShare = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFixCommission = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOfficeFees = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransferFees = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsSales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.rcCommissionManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCommissionManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcCommissionManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCommissionManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// rcCommissionManager
			// 
			this.rcCommissionManager.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcCommissionManager.ExpandCollapseItem.Id = 0;
			this.rcCommissionManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcCommissionManager.ExpandCollapseItem,
            this.btnNew,
            this.btnDelete,
            this.btnEdit,
            this.btnPrint,
            this.btnRefresh,
            this.btnClose,
            this.rgFilterReports,
            this.btnResetGridStyle});
			this.rcCommissionManager.Location = new System.Drawing.Point(0, 0);
			this.rcCommissionManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcCommissionManager.MaxItemId = 43;
			this.rcCommissionManager.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.rcCommissionManager.Name = "rcCommissionManager";
			this.rcCommissionManager.OptionsMenuMinWidth = 385;
			this.rcCommissionManager.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpCommissionManager,
            this.rpViewSettings});
			this.rcCommissionManager.Size = new System.Drawing.Size(1445, 193);
			this.rcCommissionManager.StatusBar = this.ribbonStatusBar1;
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
			// rgFilterReports
			// 
			this.rgFilterReports.Caption = "Quick Filter";
			// 
			// 
			// 
			this.rgFilterReports.Gallery.ColumnCount = 2;
			this.rgFilterReports.Gallery.DrawImageBackground = false;
			galleryItemGroup1.Caption = "Group1";
			galleryItem1.Caption = "All";
			galleryItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
			galleryItem1.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem1.Value = "showAll";
			galleryItem2.Caption = "Sales only";
			galleryItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
			galleryItem2.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem2.Value = "showSalesOnly";
			galleryItem3.Caption = "Expired";
			galleryItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
			galleryItem3.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem3.Value = "showExpired";
			galleryItem4.Caption = "Inactive";
			galleryItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage3")));
			galleryItem4.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			galleryItem4.Value = "showInactive";
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
			this.rgFilterReports.Id = 41;
			this.rgFilterReports.Name = "rgFilterReports";
			this.rgFilterReports.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgFilterReports_GalleryItemClick);
			// 
			// btnResetGridStyle
			// 
			this.btnResetGridStyle.Caption = "Reset Grid Style";
			this.btnResetGridStyle.Id = 42;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			this.btnResetGridStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetGridStyle_ItemClick);
			// 
			// rpCommissionManager
			// 
			this.rpCommissionManager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup11,
            this.ribbonPageGroup2});
			this.rpCommissionManager.Name = "rpCommissionManager";
			this.rpCommissionManager.Text = "Commission Manager";
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
			this.ribbonPageGroup6.ItemLinks.Add(this.btnEdit);
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
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.rgFilterReports);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "Report filter";
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
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 765);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcCommissionManager;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1445, 30);
			// 
			// bsCommissionManager
			// 
			this.bsCommissionManager.DataSource = typeof(CommissionManagerModel);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.gcCommissionManager);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1445, 572);
			this.mainLayout.TabIndex = 2;
			this.mainLayout.Text = "layoutControl1";
			// 
			// gcCommissionManager
			// 
			this.gcCommissionManager.DataSource = this.bsCommissionManager;
			this.gcCommissionManager.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcCommissionManager.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcCommissionManager.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcCommissionManager.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcCommissionManager.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcCommissionManager.Location = new System.Drawing.Point(12, 12);
			this.gcCommissionManager.MainView = this.gvCommissionManager;
			this.gcCommissionManager.MenuManager = this.rcCommissionManager;
			this.gcCommissionManager.Name = "gcCommissionManager";
			this.gcCommissionManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repUsers,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
			this.gcCommissionManager.Size = new System.Drawing.Size(1421, 548);
			this.gcCommissionManager.TabIndex = 4;
			this.gcCommissionManager.UseEmbeddedNavigator = true;
			this.gcCommissionManager.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCommissionManager});
			this.gcCommissionManager.DoubleClick += new System.EventHandler(this.gcCommissionManager_DoubleClick);
			// 
			// gvCommissionManager
			// 
			this.gvCommissionManager.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colUserId,
            this.colContractStartDate,
            this.colContractEndDate,
            this.colSalesProfitShare,
            this.colRecurringSalesProfitShare,
            this.colFixCommission,
            this.colOfficeFees,
            this.colTransferFees,
            this.colIsSales,
            this.colNotes,
            this.colActive});
			this.gvCommissionManager.GridControl = this.gcCommissionManager;
			this.gvCommissionManager.Name = "gvCommissionManager";
			this.gvCommissionManager.OptionsBehavior.Editable = false;
			this.gvCommissionManager.OptionsBehavior.ReadOnly = true;
			this.gvCommissionManager.OptionsFind.AlwaysVisible = true;
			this.gvCommissionManager.OptionsPrint.AutoWidth = false;
			this.gvCommissionManager.OptionsPrint.PrintHorzLines = false;
			this.gvCommissionManager.OptionsPrint.PrintVertLines = false;
			this.gvCommissionManager.OptionsView.ColumnAutoWidth = false;
			this.gvCommissionManager.OptionsView.ShowGroupedColumns = true;
			this.gvCommissionManager.OptionsView.ShowGroupPanel = false;
			this.gvCommissionManager.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvCommissionManager_RowCellStyle);
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 48;
			// 
			// colUserId
			// 
			this.colUserId.ColumnEdit = this.repUsers;
			this.colUserId.FieldName = "SalesId";
			this.colUserId.MinWidth = 25;
			this.colUserId.Name = "colUserId";
			this.colUserId.Visible = true;
			this.colUserId.VisibleIndex = 1;
			this.colUserId.Width = 212;
			// 
			// repUsers
			// 
			this.repUsers.AutoHeight = false;
			this.repUsers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repUsers.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "User Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repUsers.DisplayMember = "UserName";
			this.repUsers.Name = "repUsers";
			this.repUsers.NullText = "";
			this.repUsers.ValueMember = "Id";
			// 
			// colContractStartDate
			// 
			this.colContractStartDate.ColumnEdit = this.repositoryItemDateEdit1;
			this.colContractStartDate.FieldName = "ContractStartDate";
			this.colContractStartDate.MinWidth = 25;
			this.colContractStartDate.Name = "colContractStartDate";
			this.colContractStartDate.Visible = true;
			this.colContractStartDate.VisibleIndex = 2;
			this.colContractStartDate.Width = 158;
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
			// colContractEndDate
			// 
			this.colContractEndDate.ColumnEdit = this.repositoryItemDateEdit1;
			this.colContractEndDate.FieldName = "ContractEndDate";
			this.colContractEndDate.MinWidth = 25;
			this.colContractEndDate.Name = "colContractEndDate";
			this.colContractEndDate.Visible = true;
			this.colContractEndDate.VisibleIndex = 3;
			this.colContractEndDate.Width = 137;
			// 
			// colSalesProfitShare
			// 
			this.colSalesProfitShare.DisplayFormat.FormatString = "p";
			this.colSalesProfitShare.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colSalesProfitShare.FieldName = "SalesProfitShare";
			this.colSalesProfitShare.MinWidth = 25;
			this.colSalesProfitShare.Name = "colSalesProfitShare";
			this.colSalesProfitShare.Visible = true;
			this.colSalesProfitShare.VisibleIndex = 4;
			this.colSalesProfitShare.Width = 154;
			// 
			// colRecurringSalesProfitShare
			// 
			this.colRecurringSalesProfitShare.DisplayFormat.FormatString = "p";
			this.colRecurringSalesProfitShare.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colRecurringSalesProfitShare.FieldName = "RecurringSalesProfitShare";
			this.colRecurringSalesProfitShare.MinWidth = 25;
			this.colRecurringSalesProfitShare.Name = "colRecurringSalesProfitShare";
			this.colRecurringSalesProfitShare.Visible = true;
			this.colRecurringSalesProfitShare.VisibleIndex = 5;
			this.colRecurringSalesProfitShare.Width = 199;
			// 
			// colFixCommission
			// 
			this.colFixCommission.DisplayFormat.FormatString = "{0:n2}";
			this.colFixCommission.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colFixCommission.FieldName = "FixCommission";
			this.colFixCommission.MinWidth = 25;
			this.colFixCommission.Name = "colFixCommission";
			this.colFixCommission.Visible = true;
			this.colFixCommission.VisibleIndex = 6;
			this.colFixCommission.Width = 154;
			// 
			// colOfficeFees
			// 
			this.colOfficeFees.Caption = "Office Fees";
			this.colOfficeFees.DisplayFormat.FormatString = "p";
			this.colOfficeFees.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colOfficeFees.FieldName = "OfficeFees";
			this.colOfficeFees.MinWidth = 25;
			this.colOfficeFees.Name = "colOfficeFees";
			this.colOfficeFees.Visible = true;
			this.colOfficeFees.VisibleIndex = 7;
			this.colOfficeFees.Width = 105;
			// 
			// colTransferFees
			// 
			this.colTransferFees.Caption = "Transfer Fees";
			this.colTransferFees.DisplayFormat.FormatString = "{0:n2}";
			this.colTransferFees.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTransferFees.FieldName = "TransferFees";
			this.colTransferFees.MinWidth = 25;
			this.colTransferFees.Name = "colTransferFees";
			this.colTransferFees.Visible = true;
			this.colTransferFees.VisibleIndex = 8;
			this.colTransferFees.Width = 103;
			// 
			// colIsSales
			// 
			this.colIsSales.Caption = "Is Sales";
			this.colIsSales.ColumnEdit = this.repositoryItemCheckEdit1;
			this.colIsSales.FieldName = "IsSales";
			this.colIsSales.MinWidth = 25;
			this.colIsSales.Name = "colIsSales";
			this.colIsSales.Visible = true;
			this.colIsSales.VisibleIndex = 9;
			this.colIsSales.Width = 94;
			// 
			// repositoryItemCheckEdit1
			// 
			this.repositoryItemCheckEdit1.AutoHeight = false;
			this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 10;
			this.colNotes.Width = 328;
			// 
			// colActive
			// 
			this.colActive.ColumnEdit = this.repositoryItemCheckEdit2;
			this.colActive.FieldName = "Active";
			this.colActive.MinWidth = 25;
			this.colActive.Name = "colActive";
			this.colActive.Visible = true;
			this.colActive.VisibleIndex = 11;
			this.colActive.Width = 74;
			// 
			// repositoryItemCheckEdit2
			// 
			this.repositoryItemCheckEdit2.AutoHeight = false;
			this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1445, 572);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcCommissionManager;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1425, 552);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// CommissionManagerListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1445, 795);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcCommissionManager);
			this.Name = "CommissionManagerListForm";
			this.Ribbon = this.rcCommissionManager;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Commission Manager List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CommissionManagerListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.rcCommissionManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCommissionManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcCommissionManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCommissionManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.Ribbon.RibbonControl rcCommissionManager;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCommissionManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.BindingSource bsCommissionManager;
        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraGrid.GridControl gcCommissionManager;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCommissionManager;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colContractStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colContractEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesProfitShare;
        private DevExpress.XtraGrid.Columns.GridColumn colRecurringSalesProfitShare;
        private DevExpress.XtraGrid.Columns.GridColumn colFixCommission;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSales;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgFilterReports;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn colOfficeFees;
        private DevExpress.XtraGrid.Columns.GridColumn colTransferFees;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
	}
}