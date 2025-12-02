using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.UI.Forms.Users
{
    partial class UserEditForm
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
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditForm));
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			this.bsUser = new System.Windows.Forms.BindingSource(this.components);
			this.bsUserDetails = new System.Windows.Forms.BindingSource(this.components);
			this.bsUserPermission = new System.Windows.Forms.BindingSource(this.components);
			this.mainLayout = new DevExpress.XtraLayout.LayoutControl();
			this.userTabControl = new DevExpress.XtraTab.XtraTabControl();
			this.xtpUserInfo = new DevExpress.XtraTab.XtraTabPage();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.spcUserInfo = new DevExpress.XtraEditors.SplitContainerControl();
			this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
			this.userPic = new DevExpress.XtraEditors.PictureEdit();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
			this.lcMain = new DevExpress.XtraLayout.LayoutControl();
			this.txtPhone = new DevExpress.XtraEditors.TextEdit();
			this.chkMobileNumberConfirmed = new DevExpress.XtraEditors.CheckEdit();
			this.chkConfirmedEmail = new DevExpress.XtraEditors.CheckEdit();
			this.txtEmail = new DevExpress.XtraEditors.TextEdit();
			this.txtUserName = new DevExpress.XtraEditors.TextEdit();
			this.cboCities = new DevExpress.XtraEditors.LookUpEdit();
			this.cboCountries = new DevExpress.XtraEditors.LookUpEdit();
			this.chkActive = new DevExpress.XtraEditors.CheckEdit();
			this.changePasswordLink = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.txtNotes = new DevExpress.XtraEditors.MemoEdit();
			this.txtMobile = new DevExpress.XtraEditors.TextEdit();
			this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
			this.txtLastName = new DevExpress.XtraEditors.TextEdit();
			this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
			this.dtBirthDate = new DevExpress.XtraEditors.DateEdit();
			this.cboProvinces = new DevExpress.XtraEditors.LookUpEdit();
			this.cboDistricts = new DevExpress.XtraEditors.LookUpEdit();
			this.cboTitles = new DevExpress.XtraEditors.ImageComboBoxEdit();
			this.txtPassword = new DevExpress.XtraEditors.ButtonEdit();
			this.layoutControlGroup8 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblFirstName = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblLastName = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblNotes = new DevExpress.XtraLayout.LayoutControlItem();
			this.lcgInfo = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblMobile = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblBirthDate = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblEmail = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
			this.lcgAddress = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblAddress = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblDistricts = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblProvinces = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblCities = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblCountries = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblPhone = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem13 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem14 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.passwordLink = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblTitle = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem15 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblPassword = new DevExpress.XtraLayout.LayoutControlItem();
			this.lblUserName = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.xtpUserPermissions = new DevExpress.XtraTab.XtraTabPage();
			this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
			this.btnUpdatePermissions = new DevExpress.XtraEditors.SimpleButton();
			this.spcUserPermissions = new DevExpress.XtraEditors.SplitContainerControl();
			this.layoutControl5 = new DevExpress.XtraLayout.LayoutControl();
			this.gcAppForms = new DevExpress.XtraGrid.GridControl();
			this.gvAppForms = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControl6 = new DevExpress.XtraLayout.LayoutControl();
			this.gcFormPermissions = new DevExpress.XtraGrid.GridControl();
			this.gvFormPermissions = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repUsersPermissionControls = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
			this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colControlName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			this.btnSeedDefaultData = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem25 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.xtpAccountingInfo = new DevExpress.XtraTab.XtraTabPage();
			this.layoutControl7 = new DevExpress.XtraLayout.LayoutControl();
			this.layoutControl8 = new DevExpress.XtraLayout.LayoutControl();
			this.txtSecurityLevel = new DevExpress.XtraEditors.SpinEdit();
			this.chkIsSales = new DevExpress.XtraEditors.CheckEdit();
			this.chkTwoFactorAuth = new DevExpress.XtraEditors.CheckEdit();
			this.txtAuthId = new DevExpress.XtraEditors.TextEdit();
			this.chkChangePasswordOnFirstLogon = new DevExpress.XtraEditors.CheckEdit();
			this.layoutControlGroup9 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.emptySpaceItem18 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.grpAccounting = new DevExpress.XtraLayout.LayoutControlGroup();
			this.emptySpaceItem23 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem24 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.lblSecurityLevel = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem19 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem22 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.grpAuthenticateSettings = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lblAuthId = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem20 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem21 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem17 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem16 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.bsUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsUserDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsUserPermission)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).BeginInit();
			this.mainLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userTabControl)).BeginInit();
			this.userTabControl.SuspendLayout();
			this.xtpUserInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcUserInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spcUserInfo.Panel1)).BeginInit();
			this.spcUserInfo.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcUserInfo.Panel2)).BeginInit();
			this.spcUserInfo.Panel2.SuspendLayout();
			this.spcUserInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
			this.layoutControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userPic.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
			this.layoutControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
			this.lcMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkMobileNumberConfirmed.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkConfirmedEmail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCities.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCountries.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtBirthDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtBirthDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboProvinces.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboDistricts.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboTitles.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblFirstName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblLastName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNotes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lcgInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMobile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblBirthDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblEmail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lcgAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDistricts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProvinces)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCities)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCountries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPhone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.passwordLink)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblUserName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			this.xtpUserPermissions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
			this.layoutControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcUserPermissions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spcUserPermissions.Panel1)).BeginInit();
			this.spcUserPermissions.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcUserPermissions.Panel2)).BeginInit();
			this.spcUserPermissions.Panel2.SuspendLayout();
			this.spcUserPermissions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl5)).BeginInit();
			this.layoutControl5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcAppForms)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvAppForms)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).BeginInit();
			this.layoutControl6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcFormPermissions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvFormPermissions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsersPermissionControls)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem25)).BeginInit();
			this.xtpAccountingInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl7)).BeginInit();
			this.layoutControl7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl8)).BeginInit();
			this.layoutControl8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtSecurityLevel.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkIsSales.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkTwoFactorAuth.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAuthId.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkChangePasswordOnFirstLogon.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpAccounting)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSecurityLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpAuthenticateSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAuthId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem16)).BeginInit();
			this.SuspendLayout();
			// 
			// bsUser
			// 
			this.bsUser.DataSource = typeof(MISLiveMed.Models.Models.Users.UserModel);
			// 
			// bsUserDetails
			// 
			this.bsUserDetails.DataSource = typeof(MISLiveMed.Models.Models.Users.UserDetailModel);
			// 
			// bsUserPermission
			// 
			this.bsUserPermission.DataSource = typeof(MISLiveMed.Models.Models.Users.UserPermissionModel);
			// 
			// mainLayout
			// 
			this.mainLayout.Controls.Add(this.userTabControl);
			this.mainLayout.Controls.Add(this.btnCancel);
			this.mainLayout.Controls.Add(this.btnSave);
			this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainLayout.Location = new System.Drawing.Point(0, 0);
			this.mainLayout.Name = "mainLayout";
			this.mainLayout.Root = this.Root;
			this.mainLayout.Size = new System.Drawing.Size(1143, 758);
			this.mainLayout.TabIndex = 3;
			this.mainLayout.Text = "layoutControl1";
			// 
			// userTabControl
			// 
			this.userTabControl.Location = new System.Drawing.Point(14, 14);
			this.userTabControl.Name = "userTabControl";
			this.userTabControl.SelectedTabPage = this.xtpUserInfo;
			this.userTabControl.Size = new System.Drawing.Size(1115, 699);
			this.userTabControl.TabIndex = 4;
			this.userTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpUserInfo,
            this.xtpUserPermissions,
            this.xtpAccountingInfo});
			// 
			// xtpUserInfo
			// 
			this.xtpUserInfo.Controls.Add(this.layoutControl1);
			this.xtpUserInfo.Name = "xtpUserInfo";
			this.xtpUserInfo.Size = new System.Drawing.Size(1113, 669);
			this.xtpUserInfo.Text = "User Info";
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.spcUserInfo);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(1113, 669);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// spcUserInfo
			// 
			this.spcUserInfo.Location = new System.Drawing.Point(14, 14);
			this.spcUserInfo.Name = "spcUserInfo";
			// 
			// spcUserInfo.Panel1
			// 
			this.spcUserInfo.Panel1.Controls.Add(this.layoutControl2);
			this.spcUserInfo.Panel1.Text = "Panel1";
			// 
			// spcUserInfo.Panel2
			// 
			this.spcUserInfo.Panel2.Controls.Add(this.layoutControl3);
			this.spcUserInfo.Panel2.Text = "Panel2";
			this.spcUserInfo.Size = new System.Drawing.Size(1085, 641);
			this.spcUserInfo.SplitterPosition = 284;
			this.spcUserInfo.TabIndex = 4;
			// 
			// layoutControl2
			// 
			this.layoutControl2.Controls.Add(this.userPic);
			this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl2.Location = new System.Drawing.Point(0, 0);
			this.layoutControl2.Name = "layoutControl2";
			this.layoutControl2.Root = this.layoutControlGroup2;
			this.layoutControl2.Size = new System.Drawing.Size(284, 641);
			this.layoutControl2.TabIndex = 0;
			this.layoutControl2.Text = "layoutControl2";
			// 
			// userPic
			// 
			this.userPic.Location = new System.Drawing.Point(14, 14);
			this.userPic.Name = "userPic";
			this.userPic.Properties.ReadOnly = true;
			this.userPic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.userPic.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
			this.userPic.Size = new System.Drawing.Size(256, 210);
			this.userPic.StyleController = this.layoutControl2;
			this.userPic.TabIndex = 5;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup2.GroupBordersVisible = false;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.emptySpaceItem1});
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(284, 641);
			this.layoutControlGroup2.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.userPic;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(260, 214);
			this.layoutControlItem4.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 214);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(260, 403);
			// 
			// layoutControl3
			// 
			this.layoutControl3.Controls.Add(this.lcMain);
			this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl3.Location = new System.Drawing.Point(0, 0);
			this.layoutControl3.Name = "layoutControl3";
			this.layoutControl3.Root = this.layoutControlGroup3;
			this.layoutControl3.Size = new System.Drawing.Size(789, 641);
			this.layoutControl3.TabIndex = 0;
			this.layoutControl3.Text = "layoutControl3";
			// 
			// lcMain
			// 
			this.lcMain.AllowCustomization = false;
			this.lcMain.Controls.Add(this.txtPhone);
			this.lcMain.Controls.Add(this.chkMobileNumberConfirmed);
			this.lcMain.Controls.Add(this.chkConfirmedEmail);
			this.lcMain.Controls.Add(this.txtEmail);
			this.lcMain.Controls.Add(this.txtUserName);
			this.lcMain.Controls.Add(this.cboCities);
			this.lcMain.Controls.Add(this.cboCountries);
			this.lcMain.Controls.Add(this.chkActive);
			this.lcMain.Controls.Add(this.changePasswordLink);
			this.lcMain.Controls.Add(this.txtNotes);
			this.lcMain.Controls.Add(this.txtMobile);
			this.lcMain.Controls.Add(this.txtAddress);
			this.lcMain.Controls.Add(this.txtLastName);
			this.lcMain.Controls.Add(this.txtFirstName);
			this.lcMain.Controls.Add(this.dtBirthDate);
			this.lcMain.Controls.Add(this.cboProvinces);
			this.lcMain.Controls.Add(this.cboDistricts);
			this.lcMain.Controls.Add(this.cboTitles);
			this.lcMain.Controls.Add(this.txtPassword);
			this.lcMain.Location = new System.Drawing.Point(14, 14);
			this.lcMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lcMain.Name = "lcMain";
			this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1062, 287, 450, 596);
			this.lcMain.Root = this.layoutControlGroup8;
			this.lcMain.Size = new System.Drawing.Size(761, 613);
			this.lcMain.TabIndex = 6;
			this.lcMain.Text = "layoutControl1";
			// 
			// txtPhone
			// 
			this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUserDetails, "PhoneNumber", true));
			this.txtPhone.Location = new System.Drawing.Point(110, 247);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
			this.txtPhone.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
			this.txtPhone.Properties.MaskSettings.Set("allowBlankInput", true);
			this.txtPhone.Properties.MaskSettings.Set("mask", "(\\(\\d\\d\\d\\)) ?\\d{1,2}-\\d\\d\\d\\d\\d\\d");
			this.txtPhone.Properties.ReadOnly = true;
			this.txtPhone.Size = new System.Drawing.Size(416, 22);
			this.txtPhone.StyleController = this.lcMain;
			this.txtPhone.TabIndex = 34;
			// 
			// chkMobileNumberConfirmed
			// 
			this.chkMobileNumberConfirmed.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUser, "MobileNumberConfirmed", true));
			this.chkMobileNumberConfirmed.Enabled = false;
			this.chkMobileNumberConfirmed.Location = new System.Drawing.Point(530, 219);
			this.chkMobileNumberConfirmed.Name = "chkMobileNumberConfirmed";
			this.chkMobileNumberConfirmed.Properties.Caption = "Mobile Number Confirmed";
			this.chkMobileNumberConfirmed.Size = new System.Drawing.Size(203, 24);
			this.chkMobileNumberConfirmed.StyleController = this.lcMain;
			this.chkMobileNumberConfirmed.TabIndex = 33;
			// 
			// chkConfirmedEmail
			// 
			this.chkConfirmedEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUser, "EmailConfirmed", true));
			this.chkConfirmedEmail.Enabled = false;
			this.chkConfirmedEmail.Location = new System.Drawing.Point(532, 299);
			this.chkConfirmedEmail.Name = "chkConfirmedEmail";
			this.chkConfirmedEmail.Properties.Caption = "Confirmed Email";
			this.chkConfirmedEmail.Size = new System.Drawing.Size(201, 24);
			this.chkConfirmedEmail.StyleController = this.lcMain;
			this.chkConfirmedEmail.TabIndex = 32;
			// 
			// txtEmail
			// 
			this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUser, "Email", true));
			this.txtEmail.Location = new System.Drawing.Point(110, 299);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
			this.txtEmail.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
			this.txtEmail.Properties.MaskSettings.Set("allowBlankInput", true);
			this.txtEmail.Properties.MaskSettings.Set("mask", "\\w+([-+.\'&]\\w+)*@\\w+([-.&]\\w+)*\\.\\w+([-.]\\w+)*");
			this.txtEmail.Properties.ReadOnly = true;
			this.txtEmail.Size = new System.Drawing.Size(418, 22);
			this.txtEmail.StyleController = this.lcMain;
			this.txtEmail.TabIndex = 31;
			// 
			// txtUserName
			// 
			this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUser, "UserName", true));
			this.txtUserName.Location = new System.Drawing.Point(96, 14);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Properties.ReadOnly = true;
			this.txtUserName.Size = new System.Drawing.Size(281, 22);
			this.txtUserName.StyleController = this.lcMain;
			this.txtUserName.TabIndex = 29;
			// 
			// cboCities
			// 
			this.cboCities.Location = new System.Drawing.Point(474, 393);
			this.cboCities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboCities.Name = "cboCities";
			this.cboCities.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCities.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CityName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.cboCities.Properties.DisplayMember = "CityName";
			this.cboCities.Properties.NullText = "";
			this.cboCities.Properties.ReadOnly = true;
			this.cboCities.Properties.ValueMember = "Id";
			this.cboCities.Size = new System.Drawing.Size(245, 22);
			this.cboCities.StyleController = this.lcMain;
			this.cboCities.TabIndex = 27;
			// 
			// cboCountries
			// 
			this.cboCountries.Location = new System.Drawing.Point(124, 393);
			this.cboCountries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboCountries.Name = "cboCountries";
			this.cboCountries.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboCountries.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountryName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.cboCountries.Properties.DisplayMember = "CountryName";
			this.cboCountries.Properties.NullText = "";
			this.cboCountries.Properties.ReadOnly = true;
			this.cboCountries.Properties.ValueMember = "Id";
			this.cboCountries.Size = new System.Drawing.Size(264, 22);
			this.cboCountries.StyleController = this.lcMain;
			this.cboCountries.TabIndex = 28;
			// 
			// chkActive
			// 
			this.chkActive.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUser, "Active", true));
			this.chkActive.Enabled = false;
			this.chkActive.Location = new System.Drawing.Point(643, 14);
			this.chkActive.Name = "chkActive";
			this.chkActive.Properties.Caption = "Active";
			this.chkActive.Size = new System.Drawing.Size(104, 24);
			this.chkActive.StyleController = this.lcMain;
			this.chkActive.TabIndex = 25;
			// 
			// changePasswordLink
			// 
			this.changePasswordLink.Enabled = false;
			this.changePasswordLink.Location = new System.Drawing.Point(98, 42);
			this.changePasswordLink.Name = "changePasswordLink";
			this.changePasswordLink.Size = new System.Drawing.Size(102, 16);
			this.changePasswordLink.StyleController = this.lcMain;
			this.changePasswordLink.TabIndex = 23;
			this.changePasswordLink.Text = "Change Password";
			this.changePasswordLink.Visible = false;
			this.changePasswordLink.Click += new System.EventHandler(this.changePasswordLink_Click);
			// 
			// txtNotes
			// 
			this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUser, "Notes", true));
			this.txtNotes.Location = new System.Drawing.Point(14, 503);
			this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Properties.ReadOnly = true;
			this.txtNotes.Size = new System.Drawing.Size(733, 25);
			this.txtNotes.StyleController = this.lcMain;
			this.txtNotes.TabIndex = 12;
			// 
			// txtMobile
			// 
			this.txtMobile.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUser, "MobileNumber", true));
			this.txtMobile.Location = new System.Drawing.Point(110, 219);
			this.txtMobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtMobile.Name = "txtMobile";
			this.txtMobile.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
			this.txtMobile.Properties.MaskSettings.Set("allowBlankInput", true);
			this.txtMobile.Properties.MaskSettings.Set("mask", "(\\(\\d\\d\\d\\)) ?\\d{1,2}-\\d\\d\\d\\d\\d\\d");
			this.txtMobile.Properties.ReadOnly = true;
			this.txtMobile.Size = new System.Drawing.Size(416, 22);
			this.txtMobile.StyleController = this.lcMain;
			this.txtMobile.TabIndex = 10;
			// 
			// txtAddress
			// 
			this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUserDetails, "Address", true));
			this.txtAddress.Location = new System.Drawing.Point(124, 367);
			this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Properties.ReadOnly = true;
			this.txtAddress.Size = new System.Drawing.Size(595, 22);
			this.txtAddress.StyleController = this.lcMain;
			this.txtAddress.TabIndex = 4;
			// 
			// txtLastName
			// 
			this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUserDetails, "LastName", true));
			this.txtLastName.Location = new System.Drawing.Point(96, 143);
			this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Properties.ReadOnly = true;
			this.txtLastName.Size = new System.Drawing.Size(281, 22);
			this.txtLastName.StyleController = this.lcMain;
			this.txtLastName.TabIndex = 2;
			// 
			// txtFirstName
			// 
			this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUserDetails, "FirstName", true));
			this.txtFirstName.Location = new System.Drawing.Point(96, 117);
			this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Properties.ReadOnly = true;
			this.txtFirstName.Size = new System.Drawing.Size(281, 22);
			this.txtFirstName.StyleController = this.lcMain;
			this.txtFirstName.TabIndex = 1;
			// 
			// dtBirthDate
			// 
			this.dtBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUserDetails, "BirthDate", true));
			this.dtBirthDate.EditValue = null;
			this.dtBirthDate.Location = new System.Drawing.Point(110, 273);
			this.dtBirthDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dtBirthDate.Name = "dtBirthDate";
			this.dtBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.dtBirthDate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtBirthDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
			this.dtBirthDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
			this.dtBirthDate.Properties.ReadOnly = true;
			this.dtBirthDate.Properties.UseMaskAsDisplayFormat = true;
			this.dtBirthDate.Size = new System.Drawing.Size(265, 22);
			this.dtBirthDate.StyleController = this.lcMain;
			this.dtBirthDate.TabIndex = 11;
			// 
			// cboProvinces
			// 
			this.cboProvinces.Location = new System.Drawing.Point(124, 419);
			this.cboProvinces.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboProvinces.Name = "cboProvinces";
			this.cboProvinces.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboProvinces.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.cboProvinces.Properties.DisplayMember = "Name";
			this.cboProvinces.Properties.NullText = "";
			this.cboProvinces.Properties.ReadOnly = true;
			this.cboProvinces.Properties.ValueMember = "Id";
			this.cboProvinces.Size = new System.Drawing.Size(264, 22);
			this.cboProvinces.StyleController = this.lcMain;
			this.cboProvinces.TabIndex = 8;
			// 
			// cboDistricts
			// 
			this.cboDistricts.Location = new System.Drawing.Point(474, 419);
			this.cboDistricts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboDistricts.Name = "cboDistricts";
			this.cboDistricts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboDistricts.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.cboDistricts.Properties.DisplayMember = "Name";
			this.cboDistricts.Properties.NullText = "";
			this.cboDistricts.Properties.PopupSizeable = false;
			this.cboDistricts.Properties.ReadOnly = true;
			this.cboDistricts.Properties.ValueMember = "Id";
			this.cboDistricts.Size = new System.Drawing.Size(245, 22);
			this.cboDistricts.StyleController = this.lcMain;
			this.cboDistricts.TabIndex = 7;
			// 
			// cboTitles
			// 
			this.cboTitles.Location = new System.Drawing.Point(96, 91);
			this.cboTitles.Name = "cboTitles";
			this.cboTitles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboTitles.Properties.ReadOnly = true;
			this.cboTitles.Size = new System.Drawing.Size(281, 22);
			this.cboTitles.StyleController = this.lcMain;
			this.cboTitles.TabIndex = 24;
			// 
			// txtPassword
			// 
			this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUser, "Password", true));
			this.txtPassword.Location = new System.Drawing.Point(96, 62);
			this.txtPassword.Name = "txtPassword";
			editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
			editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(12, 12);
			this.txtPassword.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtPassword.Properties.PasswordChar = '*';
			this.txtPassword.Properties.ReadOnly = true;
			this.txtPassword.Size = new System.Drawing.Size(281, 25);
			this.txtPassword.StyleController = this.lcMain;
			this.txtPassword.TabIndex = 26;
			this.txtPassword.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtPassword_ButtonClick);
			// 
			// layoutControlGroup8
			// 
			this.layoutControlGroup8.CustomizationFormText = "layoutControlGroup1";
			this.layoutControlGroup8.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup8.GroupBordersVisible = false;
			this.layoutControlGroup8.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblFirstName,
            this.lblLastName,
            this.emptySpaceItem3,
            this.lblNotes,
            this.lcgInfo,
            this.emptySpaceItem11,
            this.emptySpaceItem12,
            this.emptySpaceItem13,
            this.emptySpaceItem14,
            this.passwordLink,
            this.emptySpaceItem9,
            this.lblTitle,
            this.emptySpaceItem10,
            this.layoutControlItem5,
            this.emptySpaceItem15,
            this.lblPassword,
            this.lblUserName,
            this.emptySpaceItem5});
			this.layoutControlGroup8.Name = "Root";
			this.layoutControlGroup8.Size = new System.Drawing.Size(761, 613);
			this.layoutControlGroup8.TextVisible = false;
			// 
			// lblFirstName
			// 
			this.lblFirstName.Control = this.txtFirstName;
			this.lblFirstName.CustomizationFormText = "layoutControlItem3";
			this.lblFirstName.Location = new System.Drawing.Point(0, 103);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(367, 26);
			this.lblFirstName.Text = "First Name:";
			this.lblFirstName.TextSize = new System.Drawing.Size(67, 16);
			// 
			// lblLastName
			// 
			this.lblLastName.Control = this.txtLastName;
			this.lblLastName.CustomizationFormText = "layoutControlItem5";
			this.lblLastName.Location = new System.Drawing.Point(0, 129);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(367, 26);
			this.lblLastName.Text = "Last Name:";
			this.lblLastName.TextSize = new System.Drawing.Size(67, 16);
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
			this.emptySpaceItem3.Location = new System.Drawing.Point(0, 518);
			this.emptySpaceItem3.MaxSize = new System.Drawing.Size(0, 71);
			this.emptySpaceItem3.MinSize = new System.Drawing.Size(111, 71);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.emptySpaceItem3.Size = new System.Drawing.Size(737, 71);
			this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			// 
			// lblNotes
			// 
			this.lblNotes.Control = this.txtNotes;
			this.lblNotes.CustomizationFormText = "layoutControlItem3";
			this.lblNotes.Location = new System.Drawing.Point(0, 469);
			this.lblNotes.Name = "lblNotes";
			this.lblNotes.Size = new System.Drawing.Size(737, 49);
			this.lblNotes.Text = "Notes:";
			this.lblNotes.TextLocation = DevExpress.Utils.Locations.Top;
			this.lblNotes.TextSize = new System.Drawing.Size(67, 16);
			// 
			// lcgInfo
			// 
			this.lcgInfo.CustomizationFormText = "layoutControlGroup3";
			this.lcgInfo.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.lcgInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblMobile,
            this.lblBirthDate,
            this.emptySpaceItem6,
            this.emptySpaceItem4,
            this.lblEmail,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.lcgAddress,
            this.lblPhone,
            this.emptySpaceItem2});
			this.lcgInfo.Location = new System.Drawing.Point(0, 165);
			this.lcgInfo.Name = "lcgInfo";
			this.lcgInfo.Size = new System.Drawing.Size(737, 304);
			this.lcgInfo.Text = "Personal Info";
			// 
			// lblMobile
			// 
			this.lblMobile.Control = this.txtMobile;
			this.lblMobile.CustomizationFormText = "layoutControlItem11";
			this.lblMobile.Location = new System.Drawing.Point(0, 0);
			this.lblMobile.Name = "lblMobile";
			this.lblMobile.Size = new System.Drawing.Size(502, 28);
			this.lblMobile.Text = "Mobile:";
			this.lblMobile.TextSize = new System.Drawing.Size(67, 16);
			// 
			// lblBirthDate
			// 
			this.lblBirthDate.Control = this.dtBirthDate;
			this.lblBirthDate.CustomizationFormText = "lciBirthDate";
			this.lblBirthDate.Location = new System.Drawing.Point(0, 54);
			this.lblBirthDate.Name = "lblBirthDate";
			this.lblBirthDate.Size = new System.Drawing.Size(351, 26);
			this.lblBirthDate.Text = "Birth Date:";
			this.lblBirthDate.TextSize = new System.Drawing.Size(67, 16);
			// 
			// emptySpaceItem6
			// 
			this.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6";
			this.emptySpaceItem6.Location = new System.Drawing.Point(351, 54);
			this.emptySpaceItem6.Name = "emptySpaceItem6";
			this.emptySpaceItem6.Size = new System.Drawing.Size(358, 26);
			// 
			// emptySpaceItem4
			// 
			this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem4.Location = new System.Drawing.Point(0, 240);
			this.emptySpaceItem4.Name = "emptySpaceItem1";
			this.emptySpaceItem4.Size = new System.Drawing.Size(709, 10);
			// 
			// lblEmail
			// 
			this.lblEmail.Control = this.txtEmail;
			this.lblEmail.Location = new System.Drawing.Point(0, 80);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(504, 28);
			this.lblEmail.Text = "Email";
			this.lblEmail.TextSize = new System.Drawing.Size(67, 16);
			// 
			// layoutControlItem12
			// 
			this.layoutControlItem12.Control = this.chkConfirmedEmail;
			this.layoutControlItem12.Location = new System.Drawing.Point(504, 80);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Size = new System.Drawing.Size(205, 28);
			this.layoutControlItem12.TextVisible = false;
			// 
			// layoutControlItem13
			// 
			this.layoutControlItem13.Control = this.chkMobileNumberConfirmed;
			this.layoutControlItem13.Location = new System.Drawing.Point(502, 0);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Size = new System.Drawing.Size(207, 28);
			this.layoutControlItem13.TextVisible = false;
			// 
			// lcgAddress
			// 
			this.lcgAddress.CustomizationFormText = "layoutControlGroup2";
			this.lcgAddress.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.lcgAddress.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblAddress,
            this.lblDistricts,
            this.lblProvinces,
            this.lblCities,
            this.lblCountries});
			this.lcgAddress.Location = new System.Drawing.Point(0, 108);
			this.lcgAddress.Name = "lcgAddress";
			this.lcgAddress.Size = new System.Drawing.Size(709, 132);
			this.lcgAddress.Text = "Address Info";
			// 
			// lblAddress
			// 
			this.lblAddress.AppearanceItemCaption.Options.UseTextOptions = true;
			this.lblAddress.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.lblAddress.Control = this.txtAddress;
			this.lblAddress.CustomizationFormText = "layoutControlItem6";
			this.lblAddress.Location = new System.Drawing.Point(0, 0);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(681, 26);
			this.lblAddress.Text = "Address";
			this.lblAddress.TextSize = new System.Drawing.Size(67, 16);
			// 
			// lblDistricts
			// 
			this.lblDistricts.AppearanceItemCaption.Options.UseTextOptions = true;
			this.lblDistricts.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.lblDistricts.Control = this.cboDistricts;
			this.lblDistricts.CustomizationFormText = "layoutControlItem8";
			this.lblDistricts.Location = new System.Drawing.Point(350, 52);
			this.lblDistricts.Name = "lblDistricts";
			this.lblDistricts.Size = new System.Drawing.Size(331, 26);
			this.lblDistricts.Text = "District";
			this.lblDistricts.TextSize = new System.Drawing.Size(67, 16);
			// 
			// lblProvinces
			// 
			this.lblProvinces.Control = this.cboProvinces;
			this.lblProvinces.CustomizationFormText = "layoutControlItem9";
			this.lblProvinces.Location = new System.Drawing.Point(0, 52);
			this.lblProvinces.Name = "lblProvinces";
			this.lblProvinces.Size = new System.Drawing.Size(350, 26);
			this.lblProvinces.Text = "Province";
			this.lblProvinces.TextSize = new System.Drawing.Size(67, 16);
			// 
			// lblCities
			// 
			this.lblCities.AppearanceItemCaption.Options.UseTextOptions = true;
			this.lblCities.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.lblCities.Control = this.cboCities;
			this.lblCities.Location = new System.Drawing.Point(350, 26);
			this.lblCities.Name = "lblCities";
			this.lblCities.Size = new System.Drawing.Size(331, 26);
			this.lblCities.Text = "City";
			this.lblCities.TextSize = new System.Drawing.Size(67, 16);
			// 
			// lblCountries
			// 
			this.lblCountries.Control = this.cboCountries;
			this.lblCountries.Location = new System.Drawing.Point(0, 26);
			this.lblCountries.Name = "lblCountries";
			this.lblCountries.Size = new System.Drawing.Size(350, 26);
			this.lblCountries.Text = "Country";
			this.lblCountries.TextSize = new System.Drawing.Size(67, 16);
			// 
			// lblPhone
			// 
			this.lblPhone.Control = this.txtPhone;
			this.lblPhone.Location = new System.Drawing.Point(0, 28);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(502, 26);
			this.lblPhone.Text = "Phone:";
			this.lblPhone.TextSize = new System.Drawing.Size(67, 16);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.Location = new System.Drawing.Point(502, 28);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(207, 26);
			// 
			// emptySpaceItem11
			// 
			this.emptySpaceItem11.Location = new System.Drawing.Point(367, 48);
			this.emptySpaceItem11.Name = "emptySpaceItem11";
			this.emptySpaceItem11.Size = new System.Drawing.Size(370, 29);
			// 
			// emptySpaceItem12
			// 
			this.emptySpaceItem12.Location = new System.Drawing.Point(367, 0);
			this.emptySpaceItem12.Name = "emptySpaceItem12";
			this.emptySpaceItem12.Size = new System.Drawing.Size(262, 28);
			// 
			// emptySpaceItem13
			// 
			this.emptySpaceItem13.Location = new System.Drawing.Point(367, 103);
			this.emptySpaceItem13.Name = "emptySpaceItem13";
			this.emptySpaceItem13.Size = new System.Drawing.Size(370, 26);
			// 
			// emptySpaceItem14
			// 
			this.emptySpaceItem14.Location = new System.Drawing.Point(367, 129);
			this.emptySpaceItem14.Name = "emptySpaceItem14";
			this.emptySpaceItem14.Size = new System.Drawing.Size(370, 26);
			// 
			// passwordLink
			// 
			this.passwordLink.Control = this.changePasswordLink;
			this.passwordLink.Location = new System.Drawing.Point(84, 28);
			this.passwordLink.Name = "passwordLink";
			this.passwordLink.Size = new System.Drawing.Size(106, 20);
			this.passwordLink.TextVisible = false;
			this.passwordLink.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
			// 
			// emptySpaceItem9
			// 
			this.emptySpaceItem9.Location = new System.Drawing.Point(0, 28);
			this.emptySpaceItem9.Name = "emptySpaceItem9";
			this.emptySpaceItem9.Size = new System.Drawing.Size(84, 20);
			// 
			// lblTitle
			// 
			this.lblTitle.Control = this.cboTitles;
			this.lblTitle.Location = new System.Drawing.Point(0, 77);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(367, 26);
			this.lblTitle.Text = "Title:";
			this.lblTitle.TextSize = new System.Drawing.Size(67, 16);
			// 
			// emptySpaceItem10
			// 
			this.emptySpaceItem10.Location = new System.Drawing.Point(367, 77);
			this.emptySpaceItem10.Name = "emptySpaceItem4";
			this.emptySpaceItem10.Size = new System.Drawing.Size(370, 26);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.chkActive;
			this.layoutControlItem5.Location = new System.Drawing.Point(629, 0);
			this.layoutControlItem5.Name = "layoutControlItem3";
			this.layoutControlItem5.Size = new System.Drawing.Size(108, 28);
			this.layoutControlItem5.TextVisible = false;
			// 
			// emptySpaceItem15
			// 
			this.emptySpaceItem15.Location = new System.Drawing.Point(190, 28);
			this.emptySpaceItem15.Name = "emptySpaceItem10";
			this.emptySpaceItem15.Size = new System.Drawing.Size(547, 20);
			// 
			// lblPassword
			// 
			this.lblPassword.Control = this.txtPassword;
			this.lblPassword.Location = new System.Drawing.Point(0, 48);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(367, 29);
			this.lblPassword.Text = "Password:";
			this.lblPassword.TextSize = new System.Drawing.Size(67, 16);
			// 
			// lblUserName
			// 
			this.lblUserName.Control = this.txtUserName;
			this.lblUserName.Location = new System.Drawing.Point(0, 0);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(367, 28);
			this.lblUserName.Text = "User Name";
			this.lblUserName.TextSize = new System.Drawing.Size(67, 16);
			// 
			// emptySpaceItem5
			// 
			this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
			this.emptySpaceItem5.Location = new System.Drawing.Point(0, 155);
			this.emptySpaceItem5.Name = "emptySpaceItem5";
			this.emptySpaceItem5.Size = new System.Drawing.Size(737, 10);
			// 
			// layoutControlGroup3
			// 
			this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup3.GroupBordersVisible = false;
			this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
			this.layoutControlGroup3.Name = "layoutControlGroup3";
			this.layoutControlGroup3.Size = new System.Drawing.Size(789, 641);
			this.layoutControlGroup3.TextVisible = false;
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.lcMain;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(765, 617);
			this.layoutControlItem6.TextVisible = false;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(1113, 669);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.spcUserInfo;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(1089, 645);
			this.layoutControlItem2.TextVisible = false;
			// 
			// xtpUserPermissions
			// 
			this.xtpUserPermissions.Controls.Add(this.layoutControl4);
			this.xtpUserPermissions.Name = "xtpUserPermissions";
			this.xtpUserPermissions.Size = new System.Drawing.Size(1117, 673);
			this.xtpUserPermissions.Text = "User Permissions";
			// 
			// layoutControl4
			// 
			this.layoutControl4.Controls.Add(this.btnUpdatePermissions);
			this.layoutControl4.Controls.Add(this.spcUserPermissions);
			this.layoutControl4.Controls.Add(this.btnSeedDefaultData);
			this.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl4.Location = new System.Drawing.Point(0, 0);
			this.layoutControl4.Name = "layoutControl4";
			this.layoutControl4.Root = this.layoutControlGroup4;
			this.layoutControl4.Size = new System.Drawing.Size(1117, 673);
			this.layoutControl4.TabIndex = 0;
			this.layoutControl4.Text = "layoutControl4";
			// 
			// btnUpdatePermissions
			// 
			this.btnUpdatePermissions.Location = new System.Drawing.Point(952, 632);
			this.btnUpdatePermissions.Name = "btnUpdatePermissions";
			this.btnUpdatePermissions.Size = new System.Drawing.Size(151, 27);
			this.btnUpdatePermissions.StyleController = this.layoutControl4;
			this.btnUpdatePermissions.TabIndex = 8;
			this.btnUpdatePermissions.Text = "Update Permissions";
			this.btnUpdatePermissions.Click += new System.EventHandler(this.btnUpdatePermissions_Click);
			// 
			// spcUserPermissions
			// 
			this.spcUserPermissions.Location = new System.Drawing.Point(14, 14);
			this.spcUserPermissions.Name = "spcUserPermissions";
			// 
			// spcUserPermissions.Panel1
			// 
			this.spcUserPermissions.Panel1.Controls.Add(this.layoutControl5);
			this.spcUserPermissions.Panel1.Text = "Panel1";
			// 
			// spcUserPermissions.Panel2
			// 
			this.spcUserPermissions.Panel2.Controls.Add(this.layoutControl6);
			this.spcUserPermissions.Panel2.Text = "Panel2";
			this.spcUserPermissions.Size = new System.Drawing.Size(1089, 614);
			this.spcUserPermissions.SplitterPosition = 578;
			this.spcUserPermissions.TabIndex = 4;
			// 
			// layoutControl5
			// 
			this.layoutControl5.Controls.Add(this.gcAppForms);
			this.layoutControl5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl5.Location = new System.Drawing.Point(0, 0);
			this.layoutControl5.Name = "layoutControl5";
			this.layoutControl5.Root = this.layoutControlGroup5;
			this.layoutControl5.Size = new System.Drawing.Size(578, 614);
			this.layoutControl5.TabIndex = 0;
			this.layoutControl5.Text = "layoutControl5";
			// 
			// gcAppForms
			// 
			this.gcAppForms.Location = new System.Drawing.Point(14, 14);
			this.gcAppForms.MainView = this.gvAppForms;
			this.gcAppForms.Name = "gcAppForms";
			this.gcAppForms.Size = new System.Drawing.Size(550, 586);
			this.gcAppForms.TabIndex = 5;
			this.gcAppForms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAppForms});
			// 
			// gvAppForms
			// 
			this.gvAppForms.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
			this.gvAppForms.GridControl = this.gcAppForms;
			this.gvAppForms.Name = "gvAppForms";
			this.gvAppForms.OptionsBehavior.Editable = false;
			this.gvAppForms.OptionsBehavior.ReadOnly = true;
			this.gvAppForms.OptionsFind.AlwaysVisible = true;
			this.gvAppForms.OptionsView.ColumnAutoWidth = false;
			this.gvAppForms.OptionsView.ShowGroupPanel = false;
			this.gvAppForms.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvAppForms_RowClick);
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Id";
			this.gridColumn1.FieldName = "Id";
			this.gridColumn1.MinWidth = 25;
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Width = 94;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Name";
			this.gridColumn2.FieldName = "Name";
			this.gridColumn2.MinWidth = 25;
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 0;
			this.gridColumn2.Width = 176;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Description";
			this.gridColumn3.FieldName = "Description";
			this.gridColumn3.MinWidth = 25;
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 1;
			this.gridColumn3.Width = 313;
			// 
			// layoutControlGroup5
			// 
			this.layoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup5.GroupBordersVisible = false;
			this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
			this.layoutControlGroup5.Name = "layoutControlGroup5";
			this.layoutControlGroup5.Size = new System.Drawing.Size(578, 614);
			this.layoutControlGroup5.TextVisible = false;
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.Control = this.gcAppForms;
			this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(554, 590);
			this.layoutControlItem7.TextVisible = false;
			// 
			// layoutControl6
			// 
			this.layoutControl6.Controls.Add(this.gcFormPermissions);
			this.layoutControl6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl6.Location = new System.Drawing.Point(0, 0);
			this.layoutControl6.Name = "layoutControl6";
			this.layoutControl6.Root = this.layoutControlGroup6;
			this.layoutControl6.Size = new System.Drawing.Size(499, 614);
			this.layoutControl6.TabIndex = 0;
			this.layoutControl6.Text = "layoutControl6";
			// 
			// gcFormPermissions
			// 
			this.gcFormPermissions.Location = new System.Drawing.Point(14, 14);
			this.gcFormPermissions.MainView = this.gvFormPermissions;
			this.gcFormPermissions.Name = "gcFormPermissions";
			this.gcFormPermissions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repUsersPermissionControls});
			this.gcFormPermissions.Size = new System.Drawing.Size(471, 586);
			this.gcFormPermissions.TabIndex = 5;
			this.gcFormPermissions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFormPermissions});
			// 
			// gvFormPermissions
			// 
			this.gvFormPermissions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
			this.gvFormPermissions.GridControl = this.gcFormPermissions;
			this.gvFormPermissions.Name = "gvFormPermissions";
			this.gvFormPermissions.OptionsFind.AlwaysVisible = true;
			this.gvFormPermissions.OptionsSelection.CheckBoxSelectorField = "Value";
			this.gvFormPermissions.OptionsSelection.InvertSelection = true;
			this.gvFormPermissions.OptionsSelection.MultiSelect = true;
			this.gvFormPermissions.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
			this.gvFormPermissions.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
			this.gvFormPermissions.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
			this.gvFormPermissions.OptionsView.ColumnAutoWidth = false;
			this.gvFormPermissions.OptionsView.ShowGroupPanel = false;
			this.gvFormPermissions.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvFormPermissions_RowCellStyle);
			this.gvFormPermissions.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvFormPermissions_PopupMenuShowing);
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "Id";
			this.gridColumn4.FieldName = "Id";
			this.gridColumn4.MinWidth = 25;
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Width = 94;
			// 
			// gridColumn5
			// 
			this.gridColumn5.Caption = "Permission Id";
			this.gridColumn5.FieldName = "UserPermissionId";
			this.gridColumn5.MinWidth = 25;
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.Width = 94;
			// 
			// gridColumn6
			// 
			this.gridColumn6.Caption = "Control Name";
			this.gridColumn6.ColumnEdit = this.repUsersPermissionControls;
			this.gridColumn6.FieldName = "ControlName";
			this.gridColumn6.MinWidth = 25;
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.OptionsColumn.ReadOnly = true;
			this.gridColumn6.Visible = true;
			this.gridColumn6.VisibleIndex = 1;
			this.gridColumn6.Width = 286;
			// 
			// repUsersPermissionControls
			// 
			this.repUsersPermissionControls.AutoHeight = false;
			this.repUsersPermissionControls.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repUsersPermissionControls.DisplayMember = "ControlName";
			this.repUsersPermissionControls.Name = "repUsersPermissionControls";
			this.repUsersPermissionControls.NullText = "";
			this.repUsersPermissionControls.PopupView = this.repositoryItemSearchLookUpEdit1View;
			this.repUsersPermissionControls.ValueMember = "ControlName";
			// 
			// repositoryItemSearchLookUpEdit1View
			// 
			this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colControlName});
			this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
			this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// colControlName
			// 
			this.colControlName.Caption = "Control Name";
			this.colControlName.FieldName = "ControlName";
			this.colControlName.Name = "colControlName";
			this.colControlName.Visible = true;
			this.colControlName.VisibleIndex = 0;
			// 
			// gridColumn7
			// 
			this.gridColumn7.Caption = "Value";
			this.gridColumn7.FieldName = "Value";
			this.gridColumn7.MinWidth = 25;
			this.gridColumn7.Name = "gridColumn7";
			this.gridColumn7.Visible = true;
			this.gridColumn7.VisibleIndex = 2;
			this.gridColumn7.Width = 85;
			// 
			// gridColumn8
			// 
			this.gridColumn8.Caption = "Notes";
			this.gridColumn8.FieldName = "Notes";
			this.gridColumn8.MinWidth = 25;
			this.gridColumn8.Name = "gridColumn8";
			this.gridColumn8.Width = 987;
			// 
			// layoutControlGroup6
			// 
			this.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup6.GroupBordersVisible = false;
			this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8});
			this.layoutControlGroup6.Name = "layoutControlGroup6";
			this.layoutControlGroup6.Size = new System.Drawing.Size(499, 614);
			this.layoutControlGroup6.TextVisible = false;
			// 
			// layoutControlItem8
			// 
			this.layoutControlItem8.Control = this.gcFormPermissions;
			this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(475, 590);
			this.layoutControlItem8.TextVisible = false;
			// 
			// btnSeedDefaultData
			// 
			this.btnSeedDefaultData.Location = new System.Drawing.Point(14, 632);
			this.btnSeedDefaultData.Name = "btnSeedDefaultData";
			this.btnSeedDefaultData.Size = new System.Drawing.Size(158, 27);
			this.btnSeedDefaultData.StyleController = this.layoutControl4;
			this.btnSeedDefaultData.TabIndex = 7;
			this.btnSeedDefaultData.Text = "Seed Default";
			this.btnSeedDefaultData.Visible = false;
			this.btnSeedDefaultData.Click += new System.EventHandler(this.btnSeedDefaultData_Click);
			// 
			// layoutControlGroup4
			// 
			this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup4.GroupBordersVisible = false;
			this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.emptySpaceItem8,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.emptySpaceItem25});
			this.layoutControlGroup4.Name = "layoutControlGroup4";
			this.layoutControlGroup4.Size = new System.Drawing.Size(1117, 673);
			this.layoutControlGroup4.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.spcUserPermissions;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(1093, 618);
			this.layoutControlItem3.TextVisible = false;
			// 
			// emptySpaceItem8
			// 
			this.emptySpaceItem8.Location = new System.Drawing.Point(162, 618);
			this.emptySpaceItem8.Name = "emptySpaceItem8";
			this.emptySpaceItem8.Size = new System.Drawing.Size(480, 31);
			// 
			// layoutControlItem14
			// 
			this.layoutControlItem14.Control = this.btnSeedDefaultData;
			this.layoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.layoutControlItem14.CustomizationFormText = "layoutControlItem14";
			this.layoutControlItem14.Location = new System.Drawing.Point(0, 618);
			this.layoutControlItem14.Name = "layoutControlItem14";
			this.layoutControlItem14.Size = new System.Drawing.Size(162, 31);
			this.layoutControlItem14.TextVisible = false;
			// 
			// layoutControlItem15
			// 
			this.layoutControlItem15.Control = this.btnUpdatePermissions;
			this.layoutControlItem15.Location = new System.Drawing.Point(938, 618);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Size = new System.Drawing.Size(155, 31);
			this.layoutControlItem15.TextVisible = false;
			// 
			// emptySpaceItem25
			// 
			this.emptySpaceItem25.Location = new System.Drawing.Point(642, 618);
			this.emptySpaceItem25.Name = "emptySpaceItem25";
			this.emptySpaceItem25.Size = new System.Drawing.Size(296, 31);
			// 
			// xtpAccountingInfo
			// 
			this.xtpAccountingInfo.Controls.Add(this.layoutControl7);
			this.xtpAccountingInfo.Name = "xtpAccountingInfo";
			this.xtpAccountingInfo.Size = new System.Drawing.Size(1117, 673);
			this.xtpAccountingInfo.Text = "Accounting Info";
			// 
			// layoutControl7
			// 
			this.layoutControl7.Controls.Add(this.layoutControl8);
			this.layoutControl7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl7.Location = new System.Drawing.Point(0, 0);
			this.layoutControl7.Name = "layoutControl7";
			this.layoutControl7.Root = this.layoutControlGroup7;
			this.layoutControl7.Size = new System.Drawing.Size(1117, 673);
			this.layoutControl7.TabIndex = 0;
			this.layoutControl7.Text = "layoutControl7";
			// 
			// layoutControl8
			// 
			this.layoutControl8.Controls.Add(this.txtSecurityLevel);
			this.layoutControl8.Controls.Add(this.chkIsSales);
			this.layoutControl8.Controls.Add(this.chkTwoFactorAuth);
			this.layoutControl8.Controls.Add(this.txtAuthId);
			this.layoutControl8.Controls.Add(this.chkChangePasswordOnFirstLogon);
			this.layoutControl8.Location = new System.Drawing.Point(14, 14);
			this.layoutControl8.Name = "layoutControl8";
			this.layoutControl8.Root = this.layoutControlGroup9;
			this.layoutControl8.Size = new System.Drawing.Size(1089, 645);
			this.layoutControl8.TabIndex = 4;
			this.layoutControl8.Text = "layoutControl8";
			// 
			// txtSecurityLevel
			// 
			this.txtSecurityLevel.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUser, "SecurityLevel", true));
			this.txtSecurityLevel.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.txtSecurityLevel.Location = new System.Drawing.Point(240, 258);
			this.txtSecurityLevel.Name = "txtSecurityLevel";
			this.txtSecurityLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtSecurityLevel.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.txtSecurityLevel.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.txtSecurityLevel.Size = new System.Drawing.Size(78, 24);
			this.txtSecurityLevel.StyleController = this.layoutControl8;
			this.txtSecurityLevel.TabIndex = 12;
			// 
			// chkIsSales
			// 
			this.chkIsSales.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUserDetails, "IsSales", true));
			this.chkIsSales.Location = new System.Drawing.Point(139, 286);
			this.chkIsSales.Name = "chkIsSales";
			this.chkIsSales.Properties.Caption = "Is Sales";
			this.chkIsSales.Size = new System.Drawing.Size(533, 24);
			this.chkIsSales.StyleController = this.layoutControl8;
			this.chkIsSales.TabIndex = 11;
			// 
			// chkTwoFactorAuth
			// 
			this.chkTwoFactorAuth.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUser, "TwoFactorEnabled", true));
			this.chkTwoFactorAuth.Location = new System.Drawing.Point(127, 108);
			this.chkTwoFactorAuth.Name = "chkTwoFactorAuth";
			this.chkTwoFactorAuth.Properties.Caption = "Two Factor Authentication";
			this.chkTwoFactorAuth.Size = new System.Drawing.Size(545, 24);
			this.chkTwoFactorAuth.StyleController = this.layoutControl8;
			this.chkTwoFactorAuth.TabIndex = 9;
			// 
			// txtAuthId
			// 
			this.txtAuthId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUser, "SecurityStamp", true));
			this.txtAuthId.Location = new System.Drawing.Point(129, 54);
			this.txtAuthId.Name = "txtAuthId";
			this.txtAuthId.Properties.ReadOnly = true;
			this.txtAuthId.Properties.UseReadOnlyAppearance = false;
			this.txtAuthId.Size = new System.Drawing.Size(543, 22);
			this.txtAuthId.StyleController = this.layoutControl8;
			this.txtAuthId.TabIndex = 8;
			// 
			// chkChangePasswordOnFirstLogon
			// 
			this.chkChangePasswordOnFirstLogon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsUser, "ChangePasswordNextLogon", true));
			this.chkChangePasswordOnFirstLogon.Location = new System.Drawing.Point(127, 80);
			this.chkChangePasswordOnFirstLogon.Name = "chkChangePasswordOnFirstLogon";
			this.chkChangePasswordOnFirstLogon.Properties.Caption = "Change Password On First Logon";
			this.chkChangePasswordOnFirstLogon.Size = new System.Drawing.Size(545, 24);
			this.chkChangePasswordOnFirstLogon.StyleController = this.layoutControl8;
			this.chkChangePasswordOnFirstLogon.TabIndex = 7;
			// 
			// layoutControlGroup9
			// 
			this.layoutControlGroup9.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup9.GroupBordersVisible = false;
			this.layoutControlGroup9.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem18,
            this.grpAccounting,
            this.emptySpaceItem22,
            this.grpAuthenticateSettings,
            this.emptySpaceItem17,
            this.emptySpaceItem7});
			this.layoutControlGroup9.Name = "layoutControlGroup6";
			this.layoutControlGroup9.Size = new System.Drawing.Size(1089, 645);
			this.layoutControlGroup9.TextVisible = false;
			// 
			// emptySpaceItem18
			// 
			this.emptySpaceItem18.Location = new System.Drawing.Point(0, 531);
			this.emptySpaceItem18.Name = "emptySpaceItem18";
			this.emptySpaceItem18.Size = new System.Drawing.Size(676, 90);
			// 
			// grpAccounting
			// 
			this.grpAccounting.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpAccounting.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem23,
            this.layoutControlItem21,
            this.emptySpaceItem24,
            this.lblSecurityLevel,
            this.emptySpaceItem19});
			this.grpAccounting.Location = new System.Drawing.Point(0, 204);
			this.grpAccounting.Name = "grpAccounting";
			this.grpAccounting.Size = new System.Drawing.Size(676, 327);
			this.grpAccounting.Text = "Accounting settings";
			// 
			// emptySpaceItem23
			// 
			this.emptySpaceItem23.Location = new System.Drawing.Point(0, 56);
			this.emptySpaceItem23.Name = "emptySpaceItem23";
			this.emptySpaceItem23.Size = new System.Drawing.Size(648, 217);
			// 
			// layoutControlItem21
			// 
			this.layoutControlItem21.Control = this.chkIsSales;
			this.layoutControlItem21.Location = new System.Drawing.Point(111, 28);
			this.layoutControlItem21.Name = "layoutControlItem21";
			this.layoutControlItem21.Size = new System.Drawing.Size(537, 28);
			this.layoutControlItem21.TextVisible = false;
			// 
			// emptySpaceItem24
			// 
			this.emptySpaceItem24.Location = new System.Drawing.Point(0, 0);
			this.emptySpaceItem24.Name = "emptySpaceItem24";
			this.emptySpaceItem24.Size = new System.Drawing.Size(111, 56);
			// 
			// lblSecurityLevel
			// 
			this.lblSecurityLevel.Control = this.txtSecurityLevel;
			this.lblSecurityLevel.Location = new System.Drawing.Point(111, 0);
			this.lblSecurityLevel.Name = "lblSecurityLevel";
			this.lblSecurityLevel.Size = new System.Drawing.Size(183, 28);
			this.lblSecurityLevel.Text = "Security Level";
			this.lblSecurityLevel.TextSize = new System.Drawing.Size(86, 16);
			// 
			// emptySpaceItem19
			// 
			this.emptySpaceItem19.Location = new System.Drawing.Point(294, 0);
			this.emptySpaceItem19.Name = "emptySpaceItem19";
			this.emptySpaceItem19.Size = new System.Drawing.Size(354, 28);
			// 
			// emptySpaceItem22
			// 
			this.emptySpaceItem22.Location = new System.Drawing.Point(0, 136);
			this.emptySpaceItem22.Name = "emptySpaceItem22";
			this.emptySpaceItem22.Size = new System.Drawing.Size(676, 68);
			// 
			// grpAuthenticateSettings
			// 
			this.grpAuthenticateSettings.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			this.grpAuthenticateSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblAuthId,
            this.layoutControlItem17,
            this.emptySpaceItem20,
            this.layoutControlItem18,
            this.emptySpaceItem21});
			this.grpAuthenticateSettings.Location = new System.Drawing.Point(0, 0);
			this.grpAuthenticateSettings.Name = "grpAuthenticateSettings";
			this.grpAuthenticateSettings.Size = new System.Drawing.Size(676, 136);
			this.grpAuthenticateSettings.Text = "Authenticate Settings";
			// 
			// lblAuthId
			// 
			this.lblAuthId.Control = this.txtAuthId;
			this.lblAuthId.Location = new System.Drawing.Point(0, 0);
			this.lblAuthId.Name = "lblAuthId";
			this.lblAuthId.Size = new System.Drawing.Size(648, 26);
			this.lblAuthId.Text = "Authenticate Id";
			this.lblAuthId.TextSize = new System.Drawing.Size(86, 16);
			// 
			// layoutControlItem17
			// 
			this.layoutControlItem17.Control = this.chkChangePasswordOnFirstLogon;
			this.layoutControlItem17.Location = new System.Drawing.Point(99, 26);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Size = new System.Drawing.Size(549, 28);
			this.layoutControlItem17.TextVisible = false;
			// 
			// emptySpaceItem20
			// 
			this.emptySpaceItem20.Location = new System.Drawing.Point(0, 26);
			this.emptySpaceItem20.Name = "emptySpaceItem20";
			this.emptySpaceItem20.Size = new System.Drawing.Size(99, 28);
			// 
			// layoutControlItem18
			// 
			this.layoutControlItem18.Control = this.chkTwoFactorAuth;
			this.layoutControlItem18.Location = new System.Drawing.Point(99, 54);
			this.layoutControlItem18.Name = "layoutControlItem18";
			this.layoutControlItem18.Size = new System.Drawing.Size(549, 28);
			this.layoutControlItem18.TextVisible = false;
			// 
			// emptySpaceItem21
			// 
			this.emptySpaceItem21.Location = new System.Drawing.Point(0, 54);
			this.emptySpaceItem21.Name = "emptySpaceItem21";
			this.emptySpaceItem21.Size = new System.Drawing.Size(99, 28);
			// 
			// emptySpaceItem17
			// 
			this.emptySpaceItem17.Location = new System.Drawing.Point(676, 0);
			this.emptySpaceItem17.Name = "emptySpaceItem17";
			this.emptySpaceItem17.Size = new System.Drawing.Size(45, 621);
			// 
			// emptySpaceItem7
			// 
			this.emptySpaceItem7.Location = new System.Drawing.Point(721, 0);
			this.emptySpaceItem7.Name = "emptySpaceItem7";
			this.emptySpaceItem7.Size = new System.Drawing.Size(344, 621);
			// 
			// layoutControlGroup7
			// 
			this.layoutControlGroup7.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup7.GroupBordersVisible = false;
			this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
			this.layoutControlGroup7.Name = "layoutControlGroup7";
			this.layoutControlGroup7.Size = new System.Drawing.Size(1117, 673);
			this.layoutControlGroup7.TextVisible = false;
			// 
			// layoutControlItem9
			// 
			this.layoutControlItem9.Control = this.layoutControl8;
			this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Size = new System.Drawing.Size(1093, 649);
			this.layoutControlItem9.TextVisible = false;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(936, 717);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(193, 27);
			this.btnCancel.StyleController = this.mainLayout;
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(770, 717);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(162, 27);
			this.btnSave.StyleController = this.mainLayout;
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "&Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.emptySpaceItem16});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1143, 758);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.userTabControl;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1119, 703);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem10
			// 
			this.layoutControlItem10.Control = this.btnSave;
			this.layoutControlItem10.Location = new System.Drawing.Point(756, 703);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Size = new System.Drawing.Size(166, 31);
			this.layoutControlItem10.TextVisible = false;
			// 
			// layoutControlItem11
			// 
			this.layoutControlItem11.Control = this.btnCancel;
			this.layoutControlItem11.Location = new System.Drawing.Point(922, 703);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Size = new System.Drawing.Size(197, 31);
			this.layoutControlItem11.TextVisible = false;
			// 
			// emptySpaceItem16
			// 
			this.emptySpaceItem16.Location = new System.Drawing.Point(0, 703);
			this.emptySpaceItem16.Name = "emptySpaceItem16";
			this.emptySpaceItem16.Size = new System.Drawing.Size(756, 31);
			// 
			// UserEditForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(1143, 758);
			this.Controls.Add(this.mainLayout);
			this.MaximizeBox = false;
			this.Name = "UserEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit User";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserEditForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsUserDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsUserPermission)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainLayout)).EndInit();
			this.mainLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.userTabControl)).EndInit();
			this.userTabControl.ResumeLayout(false);
			this.xtpUserInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spcUserInfo.Panel1)).EndInit();
			this.spcUserInfo.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spcUserInfo.Panel2)).EndInit();
			this.spcUserInfo.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spcUserInfo)).EndInit();
			this.spcUserInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
			this.layoutControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.userPic.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
			this.layoutControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
			this.lcMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkMobileNumberConfirmed.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkConfirmedEmail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCities.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboCountries.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtBirthDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtBirthDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboProvinces.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboDistricts.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboTitles.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblFirstName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblLastName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNotes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lcgInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMobile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblBirthDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblEmail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lcgAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDistricts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProvinces)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCities)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCountries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPhone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.passwordLink)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblUserName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			this.xtpUserPermissions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
			this.layoutControl4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spcUserPermissions.Panel1)).EndInit();
			this.spcUserPermissions.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spcUserPermissions.Panel2)).EndInit();
			this.spcUserPermissions.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spcUserPermissions)).EndInit();
			this.spcUserPermissions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl5)).EndInit();
			this.layoutControl5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcAppForms)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvAppForms)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).EndInit();
			this.layoutControl6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcFormPermissions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvFormPermissions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repUsersPermissionControls)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem25)).EndInit();
			this.xtpAccountingInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl7)).EndInit();
			this.layoutControl7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl8)).EndInit();
			this.layoutControl8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtSecurityLevel.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkIsSales.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkTwoFactorAuth.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAuthId.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkChangePasswordOnFirstLogon.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpAccounting)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSecurityLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpAuthenticateSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAuthId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem16)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsUser;
		private System.Windows.Forms.BindingSource bsUserDetails;
		private System.Windows.Forms.BindingSource bsUserPermission;
		private DevExpress.XtraLayout.LayoutControl mainLayout;
		private DevExpress.XtraTab.XtraTabControl userTabControl;
		private DevExpress.XtraTab.XtraTabPage xtpUserInfo;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.SplitContainerControl spcUserInfo;
		private DevExpress.XtraLayout.LayoutControl layoutControl2;
		private DevExpress.XtraEditors.PictureEdit userPic;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControl layoutControl3;
		private DevExpress.XtraLayout.LayoutControl lcMain;
		private DevExpress.XtraEditors.TextEdit txtPhone;
		private DevExpress.XtraEditors.CheckEdit chkMobileNumberConfirmed;
		private DevExpress.XtraEditors.CheckEdit chkConfirmedEmail;
		private DevExpress.XtraEditors.TextEdit txtEmail;
		private DevExpress.XtraEditors.TextEdit txtUserName;
		private DevExpress.XtraEditors.LookUpEdit cboCities;
		private DevExpress.XtraEditors.LookUpEdit cboCountries;
		private DevExpress.XtraEditors.CheckEdit chkActive;
		private DevExpress.XtraEditors.HyperlinkLabelControl changePasswordLink;
		private DevExpress.XtraEditors.MemoEdit txtNotes;
		private DevExpress.XtraEditors.TextEdit txtMobile;
		private DevExpress.XtraEditors.MemoEdit txtAddress;
		private DevExpress.XtraEditors.TextEdit txtLastName;
		private DevExpress.XtraEditors.TextEdit txtFirstName;
		private DevExpress.XtraEditors.DateEdit dtBirthDate;
		private DevExpress.XtraEditors.LookUpEdit cboProvinces;
		private DevExpress.XtraEditors.LookUpEdit cboDistricts;
		private DevExpress.XtraEditors.ImageComboBoxEdit cboTitles;
		private DevExpress.XtraEditors.ButtonEdit txtPassword;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup8;
		private DevExpress.XtraLayout.LayoutControlItem lblFirstName;
		private DevExpress.XtraLayout.LayoutControlItem lblLastName;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraLayout.LayoutControlItem lblNotes;
		private DevExpress.XtraLayout.LayoutControlGroup lcgInfo;
		private DevExpress.XtraLayout.LayoutControlItem lblMobile;
		private DevExpress.XtraLayout.LayoutControlItem lblBirthDate;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
		private DevExpress.XtraLayout.LayoutControlItem lblEmail;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
		private DevExpress.XtraLayout.LayoutControlGroup lcgAddress;
		private DevExpress.XtraLayout.LayoutControlItem lblAddress;
		private DevExpress.XtraLayout.LayoutControlItem lblDistricts;
		private DevExpress.XtraLayout.LayoutControlItem lblProvinces;
		private DevExpress.XtraLayout.LayoutControlItem lblCities;
		private DevExpress.XtraLayout.LayoutControlItem lblCountries;
		private DevExpress.XtraLayout.LayoutControlItem lblPhone;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem12;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem13;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem14;
		private DevExpress.XtraLayout.LayoutControlItem passwordLink;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
		private DevExpress.XtraLayout.LayoutControlItem lblTitle;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem15;
		private DevExpress.XtraLayout.LayoutControlItem lblPassword;
		private DevExpress.XtraLayout.LayoutControlItem lblUserName;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraTab.XtraTabPage xtpUserPermissions;
		private DevExpress.XtraLayout.LayoutControl layoutControl4;
		private DevExpress.XtraEditors.SimpleButton btnUpdatePermissions;
		private DevExpress.XtraEditors.SplitContainerControl spcUserPermissions;
		private DevExpress.XtraLayout.LayoutControl layoutControl5;
		private DevExpress.XtraGrid.GridControl gcAppForms;
		private DevExpress.XtraGrid.Views.Grid.GridView gvAppForms;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraLayout.LayoutControl layoutControl6;
		private DevExpress.XtraGrid.GridControl gcFormPermissions;
		private DevExpress.XtraGrid.Views.Grid.GridView gvFormPermissions;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repUsersPermissionControls;
		private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
		private DevExpress.XtraGrid.Columns.GridColumn colControlName;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
		private DevExpress.XtraEditors.SimpleButton btnSeedDefaultData;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
		private DevExpress.XtraTab.XtraTabPage xtpAccountingInfo;
		private DevExpress.XtraLayout.LayoutControl layoutControl7;
		private DevExpress.XtraLayout.LayoutControl layoutControl8;
		private DevExpress.XtraEditors.CheckEdit chkIsSales;
		private DevExpress.XtraEditors.CheckEdit chkTwoFactorAuth;
		private DevExpress.XtraEditors.TextEdit txtAuthId;
		private DevExpress.XtraEditors.CheckEdit chkChangePasswordOnFirstLogon;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup9;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem18;
		private DevExpress.XtraLayout.LayoutControlGroup grpAccounting;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem23;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem24;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem22;
		private DevExpress.XtraLayout.LayoutControlGroup grpAuthenticateSettings;
		private DevExpress.XtraLayout.LayoutControlItem lblAuthId;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem20;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem21;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem17;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
		private DevExpress.XtraEditors.SimpleButton btnCancel;
		private DevExpress.XtraEditors.SimpleButton btnSave;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem16;
		private DevExpress.XtraEditors.SpinEdit txtSecurityLevel;
		private DevExpress.XtraLayout.LayoutControlItem lblSecurityLevel;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem19;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem25;
	}
}