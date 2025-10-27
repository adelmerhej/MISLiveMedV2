using MISLiveMed.Models.Models.Accounting.Reports.Settings;

namespace MISLiveMed.UI.Accounting.Journals.Reports.Settings.BalanceGroup
{
	partial class BalanceHeadersListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceHeadersListForm));
			this.rcBalanceHeaders = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.rpBalanceHeaders = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.gcBalanceHeaders = new DevExpress.XtraGrid.GridControl();
			this.bsBalanceHeaders = new System.Windows.Forms.BindingSource(this.components);
			this.gvBalanceHeaders = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBalanceGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repBalanceGroups = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCheckbox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.rcBalanceHeaders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcBalanceHeaders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsBalanceHeaders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvBalanceHeaders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repBalanceGroups)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckbox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// rcBalanceHeaders
			// 
			this.rcBalanceHeaders.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcBalanceHeaders.ExpandCollapseItem.Id = 0;
			this.rcBalanceHeaders.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcBalanceHeaders.ExpandCollapseItem,
            this.btnNew,
            this.btnDelete,
            this.btnEdit,
            this.btnPrint,
            this.btnRefresh,
            this.btnClose,
            this.btnResetGridStyle});
			this.rcBalanceHeaders.Location = new System.Drawing.Point(0, 0);
			this.rcBalanceHeaders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcBalanceHeaders.MaxItemId = 42;
			this.rcBalanceHeaders.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.rcBalanceHeaders.Name = "rcBalanceHeaders";
			this.rcBalanceHeaders.OptionsMenuMinWidth = 385;
			this.rcBalanceHeaders.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpBalanceHeaders,
            this.rpViewSettings});
			this.rcBalanceHeaders.Size = new System.Drawing.Size(1402, 193);
			this.rcBalanceHeaders.StatusBar = this.ribbonStatusBar1;
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
			// rpBalanceHeaders
			// 
			this.rpBalanceHeaders.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup11});
			this.rpBalanceHeaders.Name = "rpBalanceHeaders";
			this.rpBalanceHeaders.Text = "Balance Headers";
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
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 753);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcBalanceHeaders;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1402, 30);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.gcBalanceHeaders);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 193);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1402, 560);
			this.mainLayout.TabIndex = 9;
			this.mainLayout.Text = "layoutControl1";
			// 
			// gcBalanceHeaders
			// 
			this.gcBalanceHeaders.DataSource = this.bsBalanceHeaders;
			this.gcBalanceHeaders.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcBalanceHeaders.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcBalanceHeaders.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcBalanceHeaders.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcBalanceHeaders.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcBalanceHeaders.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcBalanceHeaders.Location = new System.Drawing.Point(12, 12);
			this.gcBalanceHeaders.MainView = this.gvBalanceHeaders;
			this.gcBalanceHeaders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gcBalanceHeaders.Name = "gcBalanceHeaders";
			this.gcBalanceHeaders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheckbox,
            this.repBalanceGroups});
			this.gcBalanceHeaders.Size = new System.Drawing.Size(1378, 536);
			this.gcBalanceHeaders.TabIndex = 5;
			this.gcBalanceHeaders.UseEmbeddedNavigator = true;
			this.gcBalanceHeaders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBalanceHeaders});
			this.gcBalanceHeaders.DoubleClick += new System.EventHandler(this.gcBalanceHeaders_DoubleClick);
			// 
			// bsBalanceHeaders
			// 
			this.bsBalanceHeaders.DataSource = typeof(BalanceHeaderModel);
			// 
			// gvBalanceHeaders
			// 
			this.gvBalanceHeaders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colBalanceGroupId,
            this.colDescription,
            this.colNotes,
            this.colActive});
			this.gvBalanceHeaders.DetailHeight = 458;
			this.gvBalanceHeaders.GridControl = this.gcBalanceHeaders;
			this.gvBalanceHeaders.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", null, "")});
			this.gvBalanceHeaders.Name = "gvBalanceHeaders";
			this.gvBalanceHeaders.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.gvBalanceHeaders.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvBalanceHeaders.OptionsBehavior.Editable = false;
			this.gvBalanceHeaders.OptionsFind.AlwaysVisible = true;
			this.gvBalanceHeaders.OptionsPrint.AutoWidth = false;
			this.gvBalanceHeaders.OptionsPrint.PrintHorzLines = false;
			this.gvBalanceHeaders.OptionsPrint.PrintVertLines = false;
			this.gvBalanceHeaders.OptionsView.ColumnAutoWidth = false;
			this.gvBalanceHeaders.OptionsView.ShowFooter = true;
			this.gvBalanceHeaders.OptionsView.ShowGroupedColumns = true;
			this.gvBalanceHeaders.OptionsView.ShowGroupPanel = false;
			this.gvBalanceHeaders.OptionsView.ShowIndicator = false;
			this.gvBalanceHeaders.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
			this.gvBalanceHeaders.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvBalanceHeaders_RowCellStyle);
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			// 
			// colBalanceGroupId
			// 
			this.colBalanceGroupId.Caption = "Balance Group";
			this.colBalanceGroupId.ColumnEdit = this.repBalanceGroups;
			this.colBalanceGroupId.FieldName = "BalanceGroupId";
			this.colBalanceGroupId.MinWidth = 25;
			this.colBalanceGroupId.Name = "colBalanceGroupId";
			this.colBalanceGroupId.Visible = true;
			this.colBalanceGroupId.VisibleIndex = 1;
			this.colBalanceGroupId.Width = 228;
			// 
			// repBalanceGroups
			// 
			this.repBalanceGroups.AutoHeight = false;
			this.repBalanceGroups.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repBalanceGroups.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repBalanceGroups.DisplayMember = "Description";
			this.repBalanceGroups.Name = "repBalanceGroups";
			this.repBalanceGroups.NullText = "";
			this.repBalanceGroups.ValueMember = "Id";
			// 
			// colDescription
			// 
			this.colDescription.FieldName = "Description";
			this.colDescription.MinWidth = 25;
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 2;
			this.colDescription.Width = 379;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 3;
			this.colNotes.Width = 570;
			// 
			// colActive
			// 
			this.colActive.ColumnEdit = this.repCheckbox;
			this.colActive.FieldName = "Active";
			this.colActive.MinWidth = 25;
			this.colActive.Name = "colActive";
			this.colActive.Visible = true;
			this.colActive.VisibleIndex = 4;
			this.colActive.Width = 94;
			// 
			// repCheckbox
			// 
			this.repCheckbox.AutoHeight = false;
			this.repCheckbox.Name = "repCheckbox";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1402, 560);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcBalanceHeaders;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1382, 540);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// BalanceHeadersListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1402, 783);
			this.Controls.Add(this.mainLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcBalanceHeaders);
			this.Name = "BalanceHeadersListForm";
			this.Ribbon = this.rcBalanceHeaders;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Balance Headers List";
			((System.ComponentModel.ISupportInitialize)(this.rcBalanceHeaders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcBalanceHeaders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsBalanceHeaders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvBalanceHeaders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repBalanceGroups)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckbox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public DevExpress.XtraBars.Ribbon.RibbonControl rcBalanceHeaders;
		private DevExpress.XtraBars.BarButtonItem btnNew;
		private DevExpress.XtraBars.BarButtonItem btnDelete;
		private DevExpress.XtraBars.BarButtonItem btnEdit;
		private DevExpress.XtraBars.BarButtonItem btnPrint;
		private DevExpress.XtraBars.BarButtonItem btnRefresh;
		private DevExpress.XtraBars.BarButtonItem btnClose;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpBalanceHeaders;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
		private DevExpress.XtraLayout.LayoutControl mainLayout;
		private DevExpress.XtraGrid.GridControl gcBalanceHeaders;
		private DevExpress.XtraGrid.Views.Grid.GridView gvBalanceHeaders;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colNotes;
		private DevExpress.XtraGrid.Columns.GridColumn colActive;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckbox;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private System.Windows.Forms.BindingSource bsBalanceHeaders;
		private DevExpress.XtraGrid.Columns.GridColumn colBalanceGroupId;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repBalanceGroups;
	}
}