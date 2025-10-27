using MISLiveMed.Models.Models.Members.Categories;

namespace MISLiveMed.UI.Forms.CRM.Customers.Categories
{
    partial class MembersCategoryListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersCategoryListForm));
			this.rcMembersCategoryList = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.biShowList = new DevExpress.XtraBars.BarCheckItem();
			this.bmiHideDetail = new DevExpress.XtraBars.BarCheckItem();
			this.bmiHorizontalLayout = new DevExpress.XtraBars.BarCheckItem();
			this.bmiVerticalLayout = new DevExpress.XtraBars.BarCheckItem();
			this.bmiShowList = new DevExpress.XtraBars.BarCheckItem();
			this.biPrintSubItem = new DevExpress.XtraBars.BarSubItem();
			this.bmiPrintInvoice = new DevExpress.XtraBars.BarButtonItem();
			this.biNewCustomFilter = new DevExpress.XtraBars.BarButtonItem();
			this.bmiPrintSalesSummary = new DevExpress.XtraBars.BarButtonItem();
			this.bmiPrintSalesAnalysis = new DevExpress.XtraBars.BarButtonItem();
			this.hiItemsCount = new DevExpress.XtraBars.BarHeaderItem();
			this.biShowMasterDetail = new DevExpress.XtraBars.BarCheckItem();
			this.biShowCard = new DevExpress.XtraBars.BarCheckItem();
			this.bmiShowMasterDetail = new DevExpress.XtraBars.BarCheckItem();
			this.bmiShowCard = new DevExpress.XtraBars.BarCheckItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.rpMembersCategoryList = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgDelete = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgCloseView = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.gcMembersCategory = new DevExpress.XtraGrid.GridControl();
			this.bsMembersCategory = new System.Windows.Forms.BindingSource(this.components);
			this.gvMembersCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemCheckEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.rcMembersCategoryList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcMembersCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsMembersCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvMembersCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// rcMembersCategoryList
			// 
			this.rcMembersCategoryList.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
			this.rcMembersCategoryList.ExpandCollapseItem.Id = 0;
			this.rcMembersCategoryList.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcMembersCategoryList.ExpandCollapseItem,
            this.btnNew,
            this.biShowList,
            this.bmiHideDetail,
            this.bmiHorizontalLayout,
            this.bmiVerticalLayout,
            this.bmiShowList,
            this.biPrintSubItem,
            this.bmiPrintInvoice,
            this.biNewCustomFilter,
            this.bmiPrintSalesSummary,
            this.bmiPrintSalesAnalysis,
            this.hiItemsCount,
            this.biShowMasterDetail,
            this.biShowCard,
            this.bmiShowMasterDetail,
            this.bmiShowCard,
            this.btnEdit,
            this.btnRefresh,
            this.btnPrint,
            this.btnDelete,
            this.btnClose,
            this.btnResetGridStyle});
			this.rcMembersCategoryList.Location = new System.Drawing.Point(0, 0);
			this.rcMembersCategoryList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcMembersCategoryList.MaxItemId = 23;
			this.rcMembersCategoryList.Name = "rcMembersCategoryList";
			this.rcMembersCategoryList.OptionsMenuMinWidth = 385;
			this.rcMembersCategoryList.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpMembersCategoryList,
            this.rpViewSettings});
			this.rcMembersCategoryList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
			this.rcMembersCategoryList.Size = new System.Drawing.Size(1370, 193);
			this.rcMembersCategoryList.StatusBar = this.ribbonStatusBar1;
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
			this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
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
			// bmiVerticalLayout
			// 
			this.bmiVerticalLayout.Caption = "Bottom";
			this.bmiVerticalLayout.GroupIndex = 2;
			this.bmiVerticalLayout.Id = 7;
			this.bmiVerticalLayout.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelBottom.svg?Size=16x16";
			this.bmiVerticalLayout.Name = "bmiVerticalLayout";
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
			// biNewCustomFilter
			// 
			this.biNewCustomFilter.Caption = "Custom Filter";
			this.biNewCustomFilter.Id = 8;
			this.biNewCustomFilter.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.biNewCustomFilter.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Filter.svg";
			this.biNewCustomFilter.Name = "biNewCustomFilter";
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
			// biShowCard
			// 
			this.biShowCard.Caption = "Card";
			this.biShowCard.GroupIndex = 1;
			this.biShowCard.Id = 12;
			this.biShowCard.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.biShowCard.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Card.svg";
			this.biShowCard.Name = "biShowCard";
			// 
			// bmiShowMasterDetail
			// 
			this.bmiShowMasterDetail.Caption = "Details";
			this.bmiShowMasterDetail.GroupIndex = 3;
			this.bmiShowMasterDetail.Id = 13;
			this.bmiShowMasterDetail.Name = "bmiShowMasterDetail";
			// 
			// bmiShowCard
			// 
			this.bmiShowCard.Caption = "Card";
			this.bmiShowCard.GroupIndex = 3;
			this.bmiShowCard.Id = 15;
			this.bmiShowCard.Name = "bmiShowCard";
			// 
			// btnEdit
			// 
			this.btnEdit.Caption = "Edit";
			this.btnEdit.Enabled = false;
			this.btnEdit.Id = 16;
			this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Caption = "Refresh";
			this.btnRefresh.Id = 17;
			this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
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
			this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
			// 
			// btnClose
			// 
			this.btnClose.Caption = "Close";
			this.btnClose.Id = 20;
			this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
			this.btnClose.Name = "btnClose";
			this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
			// 
			// btnResetGridStyle
			// 
			this.btnResetGridStyle.Caption = "Reset Grid Style";
			this.btnResetGridStyle.Id = 22;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			this.btnResetGridStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetGridStyle_ItemClick);
			// 
			// rpMembersCategoryList
			// 
			this.rpMembersCategoryList.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup8,
            this.rpgDelete,
            this.rpgCloseView});
			this.rpMembersCategoryList.Name = "rpMembersCategoryList";
			this.rpMembersCategoryList.Text = "Members Category";
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
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.AllowTextClipping = false;
			this.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup3.ItemLinks.Add(this.btnEdit);
			this.ribbonPageGroup3.ItemLinks.Add(this.btnRefresh);
			this.ribbonPageGroup3.MergeOrder = 0;
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.Text = "Actions";
			// 
			// ribbonPageGroup8
			// 
			this.ribbonPageGroup8.AllowTextClipping = false;
			this.ribbonPageGroup8.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup8.ItemLinks.Add(this.btnPrint);
			this.ribbonPageGroup8.MergeOrder = 0;
			this.ribbonPageGroup8.Name = "ribbonPageGroup8";
			this.ribbonPageGroup8.Text = "Quick Reports";
			// 
			// rpgDelete
			// 
			this.rpgDelete.ItemLinks.Add(this.btnDelete);
			this.rpgDelete.Name = "rpgDelete";
			this.rpgDelete.Text = "Delete";
			// 
			// rpgCloseView
			// 
			this.rpgCloseView.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
			this.rpgCloseView.ItemLinks.Add(this.btnClose);
			this.rpgCloseView.Name = "rpgCloseView";
			this.rpgCloseView.Text = "Close View";
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
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 747);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcMembersCategoryList;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1370, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.AllowCustomization = false;
			this.mainLayout.Controls.Add(this.gcMembersCategory);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(717, 447, 450, 350);
			this.mainLayout.Root = this.layoutControlGroup1;
			this.mainLayout.Size = new System.Drawing.Size(1370, 554);
			this.mainLayout.TabIndex = 15;
			this.mainLayout.Text = "layoutControl1";
			// 
			// gcMembersCategory
			// 
			this.gcMembersCategory.DataSource = this.bsMembersCategory;
			this.gcMembersCategory.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcMembersCategory.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcMembersCategory.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcMembersCategory.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcMembersCategory.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcMembersCategory.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcMembersCategory.Location = new System.Drawing.Point(7, 8);
			this.gcMembersCategory.MainView = this.gvMembersCategory;
			this.gcMembersCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcMembersCategory.Name = "gcMembersCategory";
			this.gcMembersCategory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit4,
            this.repositoryItemCheckEdit5});
			this.gcMembersCategory.Size = new System.Drawing.Size(1356, 538);
			this.gcMembersCategory.TabIndex = 4;
			this.gcMembersCategory.UseEmbeddedNavigator = true;
			this.gcMembersCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMembersCategory});
			this.gcMembersCategory.DoubleClick += new System.EventHandler(this.gcMembersCategory_DoubleClick);
			// 
			// bsMembersCategory
			// 
			this.bsMembersCategory.DataSource = typeof(MemberCategoryModel);
			// 
			// gvMembersCategory
			// 
			this.gvMembersCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDescription,
            this.colNotes,
            this.colActive});
			this.gvMembersCategory.DetailHeight = 458;
			this.gvMembersCategory.GridControl = this.gcMembersCategory;
			this.gvMembersCategory.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", null, "")});
			this.gvMembersCategory.Name = "gvMembersCategory";
			this.gvMembersCategory.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.gvMembersCategory.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gvMembersCategory.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvMembersCategory.OptionsBehavior.Editable = false;
			this.gvMembersCategory.OptionsDetail.EnableMasterViewMode = false;
			this.gvMembersCategory.OptionsFind.AlwaysVisible = true;
			this.gvMembersCategory.OptionsPrint.AutoWidth = false;
			this.gvMembersCategory.OptionsPrint.PrintHorzLines = false;
			this.gvMembersCategory.OptionsPrint.PrintVertLines = false;
			this.gvMembersCategory.OptionsView.ColumnAutoWidth = false;
			this.gvMembersCategory.OptionsView.ShowFooter = true;
			this.gvMembersCategory.OptionsView.ShowGroupedColumns = true;
			this.gvMembersCategory.OptionsView.ShowGroupPanel = false;
			this.gvMembersCategory.OptionsView.ShowIndicator = false;
			this.gvMembersCategory.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
			this.gvMembersCategory.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvMembersCategory_RowCellStyle);
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 94;
			// 
			// colDescription
			// 
			this.colDescription.FieldName = "Description";
			this.colDescription.MinWidth = 25;
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 1;
			this.colDescription.Width = 317;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 2;
			this.colNotes.Width = 385;
			// 
			// colActive
			// 
			this.colActive.ColumnEdit = this.repositoryItemCheckEdit5;
			this.colActive.FieldName = "Active";
			this.colActive.MinWidth = 25;
			this.colActive.Name = "colActive";
			this.colActive.Visible = true;
			this.colActive.VisibleIndex = 3;
			this.colActive.Width = 94;
			// 
			// repositoryItemCheckEdit5
			// 
			this.repositoryItemCheckEdit5.AutoHeight = false;
			this.repositoryItemCheckEdit5.Name = "repositoryItemCheckEdit5";
			// 
			// repositoryItemCheckEdit1
			// 
			this.repositoryItemCheckEdit1.AutoHeight = false;
			this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
			// 
			// repositoryItemCheckEdit2
			// 
			this.repositoryItemCheckEdit2.AutoHeight = false;
			this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
			// 
			// repositoryItemCheckEdit3
			// 
			this.repositoryItemCheckEdit3.AutoHeight = false;
			this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
			// 
			// repositoryItemCheckEdit4
			// 
			this.repositoryItemCheckEdit4.AutoHeight = false;
			this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(7, 7, 8, 8);
			this.layoutControlGroup1.Size = new System.Drawing.Size(1370, 554);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcMembersCategory;
			this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem1.Size = new System.Drawing.Size(1356, 538);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// MembersCategoryListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 777);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcMembersCategoryList);
			this.Name = "MembersCategoryListForm";
			this.Ribbon = this.rcMembersCategoryList;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Members Category List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MembersCategoryListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.rcMembersCategoryList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcMembersCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsMembersCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvMembersCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rcMembersCategoryList;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarCheckItem biShowList;
        private DevExpress.XtraBars.BarCheckItem bmiShowMasterDetail;
        private DevExpress.XtraBars.BarCheckItem bmiShowList;
        private DevExpress.XtraBars.BarCheckItem bmiShowCard;
        private DevExpress.XtraBars.BarCheckItem bmiHorizontalLayout;
        private DevExpress.XtraBars.BarCheckItem bmiVerticalLayout;
        private DevExpress.XtraBars.BarCheckItem bmiHideDetail;
        private DevExpress.XtraBars.BarSubItem biPrintSubItem;
        private DevExpress.XtraBars.BarButtonItem bmiPrintInvoice;
        private DevExpress.XtraBars.BarButtonItem biNewCustomFilter;
        private DevExpress.XtraBars.BarButtonItem bmiPrintSalesSummary;
        private DevExpress.XtraBars.BarButtonItem bmiPrintSalesAnalysis;
        private DevExpress.XtraBars.BarHeaderItem hiItemsCount;
        private DevExpress.XtraBars.BarCheckItem biShowMasterDetail;
        private DevExpress.XtraBars.BarCheckItem biShowCard;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMembersCategoryList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgCloseView;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraGrid.GridControl gcMembersCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMembersCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bsMembersCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit5;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
	}
}