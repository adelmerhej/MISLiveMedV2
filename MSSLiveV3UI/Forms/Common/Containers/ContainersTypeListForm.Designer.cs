namespace MISLiveMed.UI.Forms.Common.Containers
{
    partial class ContainersTypeListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainersTypeListForm));
			this.rcContainersTypeList = new DevExpress.XtraBars.Ribbon.RibbonControl();
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
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.rpContainersTypeList = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.gcContainerTypeList = new DevExpress.XtraGrid.GridControl();
			this.gvContainerTypeList = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colContainersTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colContainersTypeDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMainContainersTypeList = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repMainContainerTypeList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colcolContainersTypeNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.rcContainersTypeList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcContainerTypeList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvContainerTypeList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repMainContainerTypeList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// rcContainersTypeList
			// 
			this.rcContainersTypeList.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcContainersTypeList.ExpandCollapseItem.Id = 0;
			this.rcContainersTypeList.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcContainersTypeList.ExpandCollapseItem,
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
			this.rcContainersTypeList.Location = new System.Drawing.Point(0, 0);
			this.rcContainersTypeList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcContainersTypeList.MaxItemId = 41;
			this.rcContainersTypeList.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.rcContainersTypeList.Name = "rcContainersTypeList";
			this.rcContainersTypeList.OptionsMenuMinWidth = 385;
			this.rcContainersTypeList.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpContainersTypeList,
            this.rpViewSettings});
			this.rcContainersTypeList.Size = new System.Drawing.Size(1475, 193);
			this.rcContainersTypeList.StatusBar = this.ribbonStatusBar1;
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
			// btnResetGridStyle
			// 
			this.btnResetGridStyle.Caption = "Reset Grid Style";
			this.btnResetGridStyle.Id = 40;
			this.btnResetGridStyle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResetGridStyle.ImageOptions.SvgImage")));
			this.btnResetGridStyle.Name = "btnResetGridStyle";
			this.btnResetGridStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetGridStyle_ItemClick);
			// 
			// rpContainersTypeList
			// 
			this.rpContainersTypeList.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup11});
			this.rpContainersTypeList.Name = "rpContainersTypeList";
			this.rpContainersTypeList.Text = "Containers Type";
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
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 751);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcContainersTypeList;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1475, 30);
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.gcContainerTypeList);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 193);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(1475, 558);
			this.layoutControl1.TabIndex = 4;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// gcContainerTypeList
			// 
			this.gcContainerTypeList.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcContainerTypeList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcContainerTypeList.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcContainerTypeList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcContainerTypeList.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcContainerTypeList.Location = new System.Drawing.Point(12, 12);
			this.gcContainerTypeList.MainView = this.gvContainerTypeList;
			this.gcContainerTypeList.Name = "gcContainerTypeList";
			this.gcContainerTypeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repMainContainerTypeList});
			this.gcContainerTypeList.Size = new System.Drawing.Size(1451, 534);
			this.gcContainerTypeList.TabIndex = 5;
			this.gcContainerTypeList.UseEmbeddedNavigator = true;
			this.gcContainerTypeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContainerTypeList});
			this.gcContainerTypeList.DoubleClick += new System.EventHandler(this.gcContainerTypeList_DoubleClick);
			// 
			// gvContainerTypeList
			// 
			this.gvContainerTypeList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colContainersTypeId,
            this.colContainersTypeDescription,
            this.colMainContainersTypeList,
            this.colcolContainersTypeNotes});
			this.gvContainerTypeList.GridControl = this.gcContainerTypeList;
			this.gvContainerTypeList.Name = "gvContainerTypeList";
			this.gvContainerTypeList.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.gvContainerTypeList.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvContainerTypeList.OptionsBehavior.Editable = false;
			this.gvContainerTypeList.OptionsBehavior.ReadOnly = true;
			this.gvContainerTypeList.OptionsFind.AlwaysVisible = true;
			this.gvContainerTypeList.OptionsView.ShowGroupedColumns = true;
			this.gvContainerTypeList.OptionsView.ShowGroupPanel = false;
			this.gvContainerTypeList.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvContainerTypeList_RowCellStyle);
			// 
			// colContainersTypeId
			// 
			this.colContainersTypeId.Caption = "Id";
			this.colContainersTypeId.FieldName = "Id";
			this.colContainersTypeId.MinWidth = 25;
			this.colContainersTypeId.Name = "colContainersTypeId";
			this.colContainersTypeId.Visible = true;
			this.colContainersTypeId.VisibleIndex = 0;
			this.colContainersTypeId.Width = 73;
			// 
			// colContainersTypeDescription
			// 
			this.colContainersTypeDescription.Caption = "Description";
			this.colContainersTypeDescription.FieldName = "Description";
			this.colContainersTypeDescription.MinWidth = 25;
			this.colContainersTypeDescription.Name = "colContainersTypeDescription";
			this.colContainersTypeDescription.Visible = true;
			this.colContainersTypeDescription.VisibleIndex = 1;
			this.colContainersTypeDescription.Width = 188;
			// 
			// colMainContainersTypeList
			// 
			this.colMainContainersTypeList.Caption = "Main Type";
			this.colMainContainersTypeList.ColumnEdit = this.repMainContainerTypeList;
			this.colMainContainersTypeList.FieldName = "ContainerTypeId";
			this.colMainContainersTypeList.MinWidth = 25;
			this.colMainContainersTypeList.Name = "colMainContainersTypeList";
			this.colMainContainersTypeList.Visible = true;
			this.colMainContainersTypeList.VisibleIndex = 2;
			this.colMainContainersTypeList.Width = 94;
			// 
			// repMainContainerTypeList
			// 
			this.repMainContainerTypeList.AutoHeight = false;
			this.repMainContainerTypeList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repMainContainerTypeList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repMainContainerTypeList.DisplayMember = "Description";
			this.repMainContainerTypeList.Name = "repMainContainerTypeList";
			this.repMainContainerTypeList.NullText = "";
			this.repMainContainerTypeList.ValueMember = "Id";
			// 
			// colcolContainersTypeNotes
			// 
			this.colcolContainersTypeNotes.Caption = "Notes";
			this.colcolContainersTypeNotes.FieldName = "Notes";
			this.colcolContainersTypeNotes.MinWidth = 25;
			this.colcolContainersTypeNotes.Name = "colcolContainersTypeNotes";
			this.colcolContainersTypeNotes.Visible = true;
			this.colcolContainersTypeNotes.VisibleIndex = 3;
			this.colcolContainersTypeNotes.Width = 686;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1475, 558);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcContainerTypeList;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1455, 538);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// ContainersTypeListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1475, 781);
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcContainersTypeList);
			this.Name = "ContainersTypeListForm";
			this.Ribbon = this.rcContainersTypeList;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Containers Type List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContainersTypeListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.rcContainersTypeList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcContainerTypeList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvContainerTypeList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repMainContainerTypeList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.Ribbon.RibbonControl rcContainersTypeList;
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
        private DevExpress.XtraBars.Ribbon.RibbonPage rpContainersTypeList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcContainerTypeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContainerTypeList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colContainersTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colContainersTypeDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colcolContainersTypeNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colMainContainersTypeList;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repMainContainerTypeList;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
	}
}