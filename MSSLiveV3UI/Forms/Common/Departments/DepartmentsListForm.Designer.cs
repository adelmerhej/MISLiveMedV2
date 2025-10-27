namespace MISLiveMed.UI.Forms.Common.Departments
{
    partial class DepartmentsListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentsListForm));
			this.rcDepartmentsList = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
			this.barCheckItem7 = new DevExpress.XtraBars.BarCheckItem();
			this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
			this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.rpDepartmentsList = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.gcDepartment = new DevExpress.XtraGrid.GridControl();
			this.gvDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShortCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrefix = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStartingNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.chkActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colJobActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.chkJobActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.rcDepartmentsList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcDepartment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkActive)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkJobActive)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// rcDepartmentsList
			// 
			this.rcDepartmentsList.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcDepartmentsList.ExpandCollapseItem.Id = 0;
			this.rcDepartmentsList.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcDepartmentsList.ExpandCollapseItem,
            this.btnNew,
            this.btnDelete,
            this.btnEdit,
            this.btnPrint,
            this.barButtonItem13,
            this.barCheckItem7,
            this.barButtonItem14,
            this.barHeaderItem1,
            this.btnRefresh,
            this.btnClose,
            this.btnResetGridStyle});
			this.rcDepartmentsList.Location = new System.Drawing.Point(0, 0);
			this.rcDepartmentsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcDepartmentsList.MaxItemId = 41;
			this.rcDepartmentsList.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.rcDepartmentsList.Name = "rcDepartmentsList";
			this.rcDepartmentsList.OptionsMenuMinWidth = 385;
			this.rcDepartmentsList.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpDepartmentsList,
            this.rpViewSettings});
			this.rcDepartmentsList.Size = new System.Drawing.Size(1402, 193);
			this.rcDepartmentsList.StatusBar = this.ribbonStatusBar1;
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
			// rpDepartmentsList
			// 
			this.rpDepartmentsList.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup11});
			this.rpDepartmentsList.Name = "rpDepartmentsList";
			this.rpDepartmentsList.Text = "Departments";
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
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 728);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcDepartmentsList;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1402, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.AllowCustomization = false;
			this.mainLayout.Controls.Add(this.gcDepartment);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(717, 447, 450, 350);
			this.mainLayout.Root = this.layoutControlGroup1;
			this.mainLayout.Size = new System.Drawing.Size(1402, 535);
			this.mainLayout.TabIndex = 9;
			this.mainLayout.Text = "layoutControl1";
			// 
			// gcDepartment
			// 
			this.gcDepartment.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcDepartment.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcDepartment.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcDepartment.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcDepartment.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcDepartment.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcDepartment.Location = new System.Drawing.Point(7, 8);
			this.gcDepartment.MainView = this.gvDepartment;
			this.gcDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcDepartment.Name = "gcDepartment";
			this.gcDepartment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkActive,
            this.chkJobActive});
			this.gcDepartment.Size = new System.Drawing.Size(1388, 519);
			this.gcDepartment.TabIndex = 4;
			this.gcDepartment.UseEmbeddedNavigator = true;
			this.gcDepartment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDepartment});
			this.gcDepartment.DoubleClick += new System.EventHandler(this.gcDepartment_DoubleClick);
			// 
			// gvDepartment
			// 
			this.gvDepartment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDepartmentName,
            this.colShortCode,
            this.colPrefix,
            this.colStartingNo,
            this.colActive,
            this.colJobActive,
            this.colNotes});
			this.gvDepartment.DetailHeight = 458;
			this.gvDepartment.GridControl = this.gcDepartment;
			this.gvDepartment.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", null, "")});
			this.gvDepartment.Name = "gvDepartment";
			this.gvDepartment.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.gvDepartment.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gvDepartment.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvDepartment.OptionsBehavior.Editable = false;
			this.gvDepartment.OptionsDetail.EnableMasterViewMode = false;
			this.gvDepartment.OptionsFind.AlwaysVisible = true;
			this.gvDepartment.OptionsPrint.AutoWidth = false;
			this.gvDepartment.OptionsPrint.PrintHorzLines = false;
			this.gvDepartment.OptionsPrint.PrintVertLines = false;
			this.gvDepartment.OptionsView.ColumnAutoWidth = false;
			this.gvDepartment.OptionsView.ShowFooter = true;
			this.gvDepartment.OptionsView.ShowGroupedColumns = true;
			this.gvDepartment.OptionsView.ShowGroupPanel = false;
			this.gvDepartment.OptionsView.ShowIndicator = false;
			this.gvDepartment.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
			// 
			// colId
			// 
			this.colId.Caption = "Id";
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 94;
			// 
			// colDepartmentName
			// 
			this.colDepartmentName.Caption = "Department Name";
			this.colDepartmentName.FieldName = "DepartmentName";
			this.colDepartmentName.MinWidth = 25;
			this.colDepartmentName.Name = "colDepartmentName";
			this.colDepartmentName.Visible = true;
			this.colDepartmentName.VisibleIndex = 1;
			this.colDepartmentName.Width = 331;
			// 
			// colShortCode
			// 
			this.colShortCode.Caption = "Short Code";
			this.colShortCode.FieldName = "ShortCode";
			this.colShortCode.MinWidth = 25;
			this.colShortCode.Name = "colShortCode";
			this.colShortCode.Visible = true;
			this.colShortCode.VisibleIndex = 2;
			this.colShortCode.Width = 97;
			// 
			// colPrefix
			// 
			this.colPrefix.Caption = "Prefix";
			this.colPrefix.FieldName = "Prefix";
			this.colPrefix.MinWidth = 25;
			this.colPrefix.Name = "colPrefix";
			this.colPrefix.Visible = true;
			this.colPrefix.VisibleIndex = 3;
			this.colPrefix.Width = 91;
			// 
			// colStartingNo
			// 
			this.colStartingNo.Caption = "Starting No";
			this.colStartingNo.FieldName = "StartingNo";
			this.colStartingNo.MinWidth = 25;
			this.colStartingNo.Name = "colStartingNo";
			this.colStartingNo.Visible = true;
			this.colStartingNo.VisibleIndex = 4;
			this.colStartingNo.Width = 87;
			// 
			// colActive
			// 
			this.colActive.Caption = "Active";
			this.colActive.ColumnEdit = this.chkActive;
			this.colActive.FieldName = "Active";
			this.colActive.MinWidth = 25;
			this.colActive.Name = "colActive";
			this.colActive.Visible = true;
			this.colActive.VisibleIndex = 6;
			this.colActive.Width = 79;
			// 
			// chkActive
			// 
			this.chkActive.AutoHeight = false;
			this.chkActive.Name = "chkActive";
			// 
			// colJobActive
			// 
			this.colJobActive.Caption = "In Job Active";
			this.colJobActive.ColumnEdit = this.chkJobActive;
			this.colJobActive.FieldName = "JobActive";
			this.colJobActive.MinWidth = 25;
			this.colJobActive.Name = "colJobActive";
			this.colJobActive.Visible = true;
			this.colJobActive.VisibleIndex = 7;
			this.colJobActive.Width = 95;
			// 
			// chkJobActive
			// 
			this.chkJobActive.AutoHeight = false;
			this.chkJobActive.Name = "chkJobActive";
			// 
			// colNotes
			// 
			this.colNotes.Caption = "Notes";
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 5;
			this.colNotes.Width = 507;
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
			this.layoutControlGroup1.Size = new System.Drawing.Size(1402, 535);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcDepartment;
			this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem1.Size = new System.Drawing.Size(1388, 519);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
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
			// btnResetGridStyle
			// 
			this.btnResetGridStyle.Caption = "Reset Grid Style";
			this.btnResetGridStyle.Id = 40;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			this.btnResetGridStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetGridStyle_ItemClick);
			// 
			// DepartmentsListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1402, 758);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcDepartmentsList);
			this.Name = "DepartmentsListForm";
			this.Ribbon = this.rcDepartmentsList;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Departments List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DepartmentsListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.rcDepartmentsList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcDepartment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkActive)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkJobActive)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraBars.Ribbon.RibbonControl rcDepartmentsList;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarCheckItem barCheckItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpDepartmentsList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraLayout.LayoutControl mainLayout;
        private DevExpress.XtraGrid.GridControl gcDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDepartment;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colShortCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPrefix;
        private DevExpress.XtraGrid.Columns.GridColumn colStartingNo;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colJobActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkJobActive;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
	}
}