using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.UI.Forms.Users
{
    partial class UsersListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersListForm));
			this.rcUsersList = new DevExpress.XtraBars.Ribbon.RibbonControl();
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
			this.rpUsersList = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.RootLayout = new DevExpress.XtraLayout.LayoutControl();
			this.gcUsers = new DevExpress.XtraGrid.GridControl();
			this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
			this.gvUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmailConfirmed = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMobileNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMobileNumberConfirmed = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTwoFactorEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLockoutEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLockoutEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAccessFailedCount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colChangePasswordNextLogon = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSecurityLevel = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUserLevel = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repUserFirstName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.rcUsersList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RootLayout)).BeginInit();
			this.RootLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repUserFirstName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// rcUsersList
			// 
			this.rcUsersList.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.rcUsersList.ExpandCollapseItem.Id = 0;
			this.rcUsersList.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcUsersList.ExpandCollapseItem,
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
			this.rcUsersList.Location = new System.Drawing.Point(0, 0);
			this.rcUsersList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcUsersList.MaxItemId = 41;
			this.rcUsersList.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.rcUsersList.Name = "rcUsersList";
			this.rcUsersList.OptionsMenuMinWidth = 385;
			this.rcUsersList.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpUsersList,
            this.rpViewSettings});
			this.rcUsersList.Size = new System.Drawing.Size(1480, 193);
			this.rcUsersList.StatusBar = this.ribbonStatusBar1;
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
			// rpUsersList
			// 
			this.rpUsersList.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup11});
			this.rpUsersList.Name = "rpUsersList";
			this.rpUsersList.Text = "USERS";
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
			this.ribbonPageGroup2.Text = "Reset Grid Style";
			// 
			// ribbonStatusBar1
			// 
			this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 681);
			this.ribbonStatusBar1.Name = "ribbonStatusBar1";
			this.ribbonStatusBar1.Ribbon = this.rcUsersList;
			this.ribbonStatusBar1.Size = new System.Drawing.Size(1480, 30);
			// 
			// RootLayout
			// 
			this.RootLayout.Controls.Add(this.gcUsers);
			this.RootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RootLayout.Location = new System.Drawing.Point(0, 193);
			this.RootLayout.Name = "RootLayout";
			this.RootLayout.Root = this.Root;
			this.RootLayout.Size = new System.Drawing.Size(1480, 488);
			this.RootLayout.TabIndex = 4;
			this.RootLayout.Text = "layoutControl1";
			// 
			// gcUsers
			// 
			this.gcUsers.DataSource = this.bsUsers;
			this.gcUsers.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcUsers.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcUsers.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcUsers.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcUsers.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcUsers.Location = new System.Drawing.Point(12, 12);
			this.gcUsers.MainView = this.gvUsers;
			this.gcUsers.Name = "gcUsers";
			this.gcUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repUserFirstName});
			this.gcUsers.Size = new System.Drawing.Size(1456, 464);
			this.gcUsers.TabIndex = 7;
			this.gcUsers.UseEmbeddedNavigator = true;
			this.gcUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsers});
			// 
			// bsUsers
			// 
			this.bsUsers.DataSource = typeof(UserModel);
			// 
			// gvUsers
			// 
			this.gvUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.gridColumn1,
            this.colEmail,
            this.colEmailConfirmed,
            this.colMobileNumber,
            this.colMobileNumberConfirmed,
            this.colTwoFactorEnabled,
            this.colLockoutEndDate,
            this.colLockoutEnabled,
            this.colAccessFailedCount,
            this.colChangePasswordNextLogon,
            this.colSecurityLevel,
            this.colIsAdmin,
            this.colUserLevel,
            this.colNotes,
            this.colActive});
			this.gvUsers.GridControl = this.gcUsers;
			this.gvUsers.Name = "gvUsers";
			this.gvUsers.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.gvUsers.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvUsers.OptionsBehavior.Editable = false;
			this.gvUsers.OptionsBehavior.ReadOnly = true;
			this.gvUsers.OptionsFind.AlwaysVisible = true;
			this.gvUsers.OptionsView.ColumnAutoWidth = false;
			this.gvUsers.OptionsView.ShowGroupedColumns = true;
			this.gvUsers.OptionsView.ShowGroupPanel = false;
			this.gvUsers.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvUsers_RowCellStyle);
			this.gvUsers.DoubleClick += new System.EventHandler(this.gvUsers_DoubleClick);
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 61;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "User Name";
			this.gridColumn1.FieldName = "UserName";
			this.gridColumn1.MinWidth = 25;
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 1;
			this.gridColumn1.Width = 177;
			// 
			// colEmail
			// 
			this.colEmail.FieldName = "Email";
			this.colEmail.MinWidth = 25;
			this.colEmail.Name = "colEmail";
			this.colEmail.Visible = true;
			this.colEmail.VisibleIndex = 2;
			this.colEmail.Width = 250;
			// 
			// colEmailConfirmed
			// 
			this.colEmailConfirmed.FieldName = "EmailConfirmed";
			this.colEmailConfirmed.MinWidth = 25;
			this.colEmailConfirmed.Name = "colEmailConfirmed";
			this.colEmailConfirmed.Visible = true;
			this.colEmailConfirmed.VisibleIndex = 3;
			this.colEmailConfirmed.Width = 112;
			// 
			// colMobileNumber
			// 
			this.colMobileNumber.FieldName = "MobileNumber";
			this.colMobileNumber.MinWidth = 25;
			this.colMobileNumber.Name = "colMobileNumber";
			this.colMobileNumber.Visible = true;
			this.colMobileNumber.VisibleIndex = 4;
			this.colMobileNumber.Width = 225;
			// 
			// colMobileNumberConfirmed
			// 
			this.colMobileNumberConfirmed.FieldName = "MobileNumberConfirmed";
			this.colMobileNumberConfirmed.MinWidth = 25;
			this.colMobileNumberConfirmed.Name = "colMobileNumberConfirmed";
			this.colMobileNumberConfirmed.Visible = true;
			this.colMobileNumberConfirmed.VisibleIndex = 5;
			this.colMobileNumberConfirmed.Width = 158;
			// 
			// colTwoFactorEnabled
			// 
			this.colTwoFactorEnabled.FieldName = "TwoFactorEnabled";
			this.colTwoFactorEnabled.MinWidth = 25;
			this.colTwoFactorEnabled.Name = "colTwoFactorEnabled";
			this.colTwoFactorEnabled.Visible = true;
			this.colTwoFactorEnabled.VisibleIndex = 6;
			this.colTwoFactorEnabled.Width = 139;
			// 
			// colLockoutEndDate
			// 
			this.colLockoutEndDate.FieldName = "LockoutEndDate";
			this.colLockoutEndDate.MinWidth = 25;
			this.colLockoutEndDate.Name = "colLockoutEndDate";
			this.colLockoutEndDate.Visible = true;
			this.colLockoutEndDate.VisibleIndex = 7;
			this.colLockoutEndDate.Width = 145;
			// 
			// colLockoutEnabled
			// 
			this.colLockoutEnabled.FieldName = "LockoutEnabled";
			this.colLockoutEnabled.MinWidth = 25;
			this.colLockoutEnabled.Name = "colLockoutEnabled";
			this.colLockoutEnabled.Visible = true;
			this.colLockoutEnabled.VisibleIndex = 8;
			this.colLockoutEnabled.Width = 142;
			// 
			// colAccessFailedCount
			// 
			this.colAccessFailedCount.FieldName = "AccessFailedCount";
			this.colAccessFailedCount.MinWidth = 25;
			this.colAccessFailedCount.Name = "colAccessFailedCount";
			this.colAccessFailedCount.Visible = true;
			this.colAccessFailedCount.VisibleIndex = 9;
			this.colAccessFailedCount.Width = 147;
			// 
			// colChangePasswordNextLogon
			// 
			this.colChangePasswordNextLogon.FieldName = "ChangePasswordNextLogon";
			this.colChangePasswordNextLogon.MinWidth = 25;
			this.colChangePasswordNextLogon.Name = "colChangePasswordNextLogon";
			this.colChangePasswordNextLogon.Visible = true;
			this.colChangePasswordNextLogon.VisibleIndex = 10;
			this.colChangePasswordNextLogon.Width = 160;
			// 
			// colSecurityLevel
			// 
			this.colSecurityLevel.FieldName = "SecurityLevel";
			this.colSecurityLevel.MinWidth = 25;
			this.colSecurityLevel.Name = "colSecurityLevel";
			this.colSecurityLevel.Visible = true;
			this.colSecurityLevel.VisibleIndex = 11;
			this.colSecurityLevel.Width = 94;
			// 
			// colIsAdmin
			// 
			this.colIsAdmin.FieldName = "IsAdmin";
			this.colIsAdmin.MinWidth = 25;
			this.colIsAdmin.Name = "colIsAdmin";
			this.colIsAdmin.Visible = true;
			this.colIsAdmin.VisibleIndex = 12;
			this.colIsAdmin.Width = 94;
			// 
			// colUserLevel
			// 
			this.colUserLevel.FieldName = "UserLevel";
			this.colUserLevel.MinWidth = 25;
			this.colUserLevel.Name = "colUserLevel";
			this.colUserLevel.Visible = true;
			this.colUserLevel.VisibleIndex = 13;
			this.colUserLevel.Width = 94;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 14;
			this.colNotes.Width = 94;
			// 
			// colActive
			// 
			this.colActive.FieldName = "Active";
			this.colActive.MinWidth = 25;
			this.colActive.Name = "colActive";
			this.colActive.Visible = true;
			this.colActive.VisibleIndex = 15;
			this.colActive.Width = 94;
			// 
			// repUserFirstName
			// 
			this.repUserFirstName.AutoHeight = false;
			this.repUserFirstName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repUserFirstName.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirstName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repUserFirstName.DisplayMember = "FirstName";
			this.repUserFirstName.Name = "repUserFirstName";
			this.repUserFirstName.NullText = "";
			this.repUserFirstName.ValueMember = "Id";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1480, 488);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcUsers;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1460, 468);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// UsersListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1480, 711);
			this.Controls.Add(this.RootLayout);
			this.Controls.Add(this.ribbonStatusBar1);
			this.Controls.Add(this.rcUsersList);
			this.Name = "UsersListForm";
			this.Ribbon = this.rcUsersList;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar1;
			this.Text = "Users List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.rcUsersList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RootLayout)).EndInit();
			this.RootLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repUserFirstName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.Ribbon.RibbonControl rcUsersList;
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
        private DevExpress.XtraBars.Ribbon.RibbonPage rpUsersList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraLayout.LayoutControl RootLayout;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsers;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bsUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colEmailConfirmed;
        private DevExpress.XtraGrid.Columns.GridColumn colMobileNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMobileNumberConfirmed;
        private DevExpress.XtraGrid.Columns.GridColumn colTwoFactorEnabled;
        private DevExpress.XtraGrid.Columns.GridColumn colLockoutEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLockoutEnabled;
        private DevExpress.XtraGrid.Columns.GridColumn colAccessFailedCount;
        private DevExpress.XtraGrid.Columns.GridColumn colChangePasswordNextLogon;
        private DevExpress.XtraGrid.Columns.GridColumn colSecurityLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colUserLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repUserFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
	}
}