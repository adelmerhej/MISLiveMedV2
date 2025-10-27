using MISLiveMed.Models.Models.Members.Agents;

namespace MISLiveMed.UI.Forms.CRM.Agents
{
    partial class AgentsListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentsListForm));
			this.gcAgents = new DevExpress.XtraGrid.GridControl();
			this.bsAgents = new System.Windows.Forms.BindingSource(this.components);
			this.gvAgents = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAgentName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMemberOfId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repMemberOfList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colActiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repDateFormat = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.colFollowupDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCountryId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCountries = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colCityId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCities = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colAgentGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repAgentsGroups = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colAgentCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repAgentsCategories = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPhoneNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPhoneNumber2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPhoneNumber3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFaxNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMofNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colActivity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colResponsibleId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repResponsibles = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPostalAddress = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repMemberTypeList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repMemberCategoryList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repOrganizationList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.repCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.repSales = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.rcAgentsList = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnNew = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnClose = new DevExpress.XtraBars.BarButtonItem();
			this.btnResetGridStyle = new DevExpress.XtraBars.BarButtonItem();
			this.rpAgentsList = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgDelete = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpgCloseView = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rpViewSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
			this.RootLayout = new DevExpress.XtraLayout.LayoutControl();
			this.moduleLayout = new DevExpress.XtraLayout.LayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.gcAgents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsAgents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvAgents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repMemberOfList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCountries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCities)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repAgentsGroups)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repAgentsCategories)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repResponsibles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repMemberTypeList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repMemberCategoryList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repOrganizationList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rcAgentsList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RootLayout)).BeginInit();
			this.RootLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).BeginInit();
			this.moduleLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// gcAgents
			// 
			this.gcAgents.DataSource = this.bsAgents;
			this.gcAgents.EmbeddedNavigator.Buttons.Append.Visible = false;
			this.gcAgents.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
			this.gcAgents.EmbeddedNavigator.Buttons.Edit.Visible = false;
			this.gcAgents.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
			this.gcAgents.EmbeddedNavigator.Buttons.Remove.Visible = false;
			this.gcAgents.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.gcAgents.Location = new System.Drawing.Point(7, 18);
			this.gcAgents.MainView = this.gvAgents;
			this.gcAgents.Margin = new System.Windows.Forms.Padding(14, 16, 14, 16);
			this.gcAgents.Name = "gcAgents";
			this.gcAgents.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repMemberTypeList,
            this.repMemberCategoryList,
            this.repMemberOfList,
            this.repOrganizationList,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit4,
            this.repAgentsGroups,
            this.repAgentsCategories,
            this.repCountries,
            this.repCities,
            this.repDateFormat,
            this.repCheckBox,
            this.repResponsibles,
            this.repSales});
			this.gcAgents.ShowOnlyPredefinedDetails = true;
			this.gcAgents.Size = new System.Drawing.Size(1395, 542);
			this.gcAgents.TabIndex = 4;
			this.gcAgents.UseEmbeddedNavigator = true;
			this.gcAgents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAgents});
			this.gcAgents.DoubleClick += new System.EventHandler(this.gcAgentsList_DoubleClick_1);
			// 
			// bsAgents
			// 
			this.bsAgents.DataSource = typeof(AgentModel);
			// 
			// gvAgents
			// 
			this.gvAgents.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colAgentName,
            this.colMemberOfId,
            this.colActiveDate,
            this.colFollowupDate,
            this.colCountryId,
            this.colCityId,
            this.colAgentGroupId,
            this.colAgentCategoryId,
            this.colAddress,
            this.colPhoneNumber1,
            this.colPhoneNumber2,
            this.colPhoneNumber3,
            this.colFaxNumber,
            this.colWebsite,
            this.colMofNo,
            this.colEmail,
            this.colActivity,
            this.colResponsibleId,
            this.colPostalCode,
            this.colPostalAddress,
            this.colBranch,
            this.colName,
            this.colNotes});
			this.gvAgents.DetailHeight = 458;
			this.gvAgents.DetailVerticalIndent = 13;
			this.gvAgents.GridControl = this.gcAgents;
			this.gvAgents.Name = "gvAgents";
			this.gvAgents.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.False;
			this.gvAgents.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvAgents.OptionsBehavior.Editable = false;
			this.gvAgents.OptionsBehavior.ReadOnly = true;
			this.gvAgents.OptionsDetail.AllowZoomDetail = false;
			this.gvAgents.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
			this.gvAgents.OptionsDetail.SmartDetailHeight = true;
			this.gvAgents.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Excel;
			this.gvAgents.OptionsFind.AlwaysVisible = true;
			this.gvAgents.OptionsSelection.MultiSelect = true;
			this.gvAgents.OptionsView.ColumnAutoWidth = false;
			this.gvAgents.OptionsView.ShowGroupPanel = false;
			this.gvAgents.OptionsView.ShowIndicator = false;
			this.gvAgents.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
			this.gvAgents.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvAgentsList_RowCellStyle);
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 65;
			// 
			// colAgentName
			// 
			this.colAgentName.FieldName = "AgentName";
			this.colAgentName.MinWidth = 25;
			this.colAgentName.Name = "colAgentName";
			this.colAgentName.Visible = true;
			this.colAgentName.VisibleIndex = 1;
			this.colAgentName.Width = 272;
			// 
			// colMemberOfId
			// 
			this.colMemberOfId.Caption = "Member Of";
			this.colMemberOfId.ColumnEdit = this.repMemberOfList;
			this.colMemberOfId.FieldName = "MemberOfId";
			this.colMemberOfId.MinWidth = 25;
			this.colMemberOfId.Name = "colMemberOfId";
			this.colMemberOfId.Visible = true;
			this.colMemberOfId.VisibleIndex = 8;
			this.colMemberOfId.Width = 149;
			// 
			// repMemberOfList
			// 
			this.repMemberOfList.AutoHeight = false;
			this.repMemberOfList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repMemberOfList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AgentName", "Member Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repMemberOfList.DisplayMember = "AgentName";
			this.repMemberOfList.Name = "repMemberOfList";
			this.repMemberOfList.NullText = "";
			this.repMemberOfList.ValueMember = "Id";
			// 
			// colActiveDate
			// 
			this.colActiveDate.ColumnEdit = this.repDateFormat;
			this.colActiveDate.FieldName = "ActiveDate";
			this.colActiveDate.MinWidth = 25;
			this.colActiveDate.Name = "colActiveDate";
			this.colActiveDate.Visible = true;
			this.colActiveDate.VisibleIndex = 2;
			this.colActiveDate.Width = 118;
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
			// colFollowupDate
			// 
			this.colFollowupDate.ColumnEdit = this.repDateFormat;
			this.colFollowupDate.FieldName = "FollowupDate";
			this.colFollowupDate.MinWidth = 25;
			this.colFollowupDate.Name = "colFollowupDate";
			this.colFollowupDate.Visible = true;
			this.colFollowupDate.VisibleIndex = 3;
			this.colFollowupDate.Width = 115;
			// 
			// colCountryId
			// 
			this.colCountryId.Caption = "Country";
			this.colCountryId.ColumnEdit = this.repCountries;
			this.colCountryId.FieldName = "CountryId";
			this.colCountryId.MinWidth = 25;
			this.colCountryId.Name = "colCountryId";
			this.colCountryId.Visible = true;
			this.colCountryId.VisibleIndex = 4;
			this.colCountryId.Width = 118;
			// 
			// repCountries
			// 
			this.repCountries.AutoHeight = false;
			this.repCountries.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCountries.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountryName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repCountries.DisplayMember = "CountryName";
			this.repCountries.Name = "repCountries";
			this.repCountries.NullText = "";
			this.repCountries.ValueMember = "Id";
			// 
			// colCityId
			// 
			this.colCityId.Caption = "City";
			this.colCityId.ColumnEdit = this.repCities;
			this.colCityId.FieldName = "CityId";
			this.colCityId.MinWidth = 25;
			this.colCityId.Name = "colCityId";
			this.colCityId.Visible = true;
			this.colCityId.VisibleIndex = 5;
			this.colCityId.Width = 94;
			// 
			// repCities
			// 
			this.repCities.AutoHeight = false;
			this.repCities.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCities.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CityName", "City Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repCities.DisplayMember = "CityName";
			this.repCities.Name = "repCities";
			this.repCities.NullText = "";
			this.repCities.ValueMember = "Id";
			// 
			// colAgentGroupId
			// 
			this.colAgentGroupId.Caption = "Agent Group";
			this.colAgentGroupId.ColumnEdit = this.repAgentsGroups;
			this.colAgentGroupId.FieldName = "AgentGroupId";
			this.colAgentGroupId.MinWidth = 25;
			this.colAgentGroupId.Name = "colAgentGroupId";
			this.colAgentGroupId.Visible = true;
			this.colAgentGroupId.VisibleIndex = 6;
			this.colAgentGroupId.Width = 137;
			// 
			// repAgentsGroups
			// 
			this.repAgentsGroups.AutoHeight = false;
			this.repAgentsGroups.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repAgentsGroups.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repAgentsGroups.DisplayMember = "Description";
			this.repAgentsGroups.Name = "repAgentsGroups";
			this.repAgentsGroups.NullText = "";
			this.repAgentsGroups.ValueMember = "Id";
			// 
			// colAgentCategoryId
			// 
			this.colAgentCategoryId.Caption = "Agent Category";
			this.colAgentCategoryId.ColumnEdit = this.repAgentsCategories;
			this.colAgentCategoryId.FieldName = "AgentCategoryId";
			this.colAgentCategoryId.MinWidth = 25;
			this.colAgentCategoryId.Name = "colAgentCategoryId";
			this.colAgentCategoryId.Visible = true;
			this.colAgentCategoryId.VisibleIndex = 7;
			this.colAgentCategoryId.Width = 139;
			// 
			// repAgentsCategories
			// 
			this.repAgentsCategories.AutoHeight = false;
			this.repAgentsCategories.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repAgentsCategories.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repAgentsCategories.DisplayMember = "Name";
			this.repAgentsCategories.Name = "repAgentsCategories";
			this.repAgentsCategories.NullText = "";
			this.repAgentsCategories.ValueMember = "Id";
			// 
			// colAddress
			// 
			this.colAddress.FieldName = "Address";
			this.colAddress.MinWidth = 25;
			this.colAddress.Name = "colAddress";
			this.colAddress.Visible = true;
			this.colAddress.VisibleIndex = 9;
			this.colAddress.Width = 94;
			// 
			// colPhoneNumber1
			// 
			this.colPhoneNumber1.FieldName = "PhoneNumber1";
			this.colPhoneNumber1.MinWidth = 25;
			this.colPhoneNumber1.Name = "colPhoneNumber1";
			this.colPhoneNumber1.Visible = true;
			this.colPhoneNumber1.VisibleIndex = 10;
			this.colPhoneNumber1.Width = 128;
			// 
			// colPhoneNumber2
			// 
			this.colPhoneNumber2.FieldName = "PhoneNumber2";
			this.colPhoneNumber2.MinWidth = 25;
			this.colPhoneNumber2.Name = "colPhoneNumber2";
			this.colPhoneNumber2.Visible = true;
			this.colPhoneNumber2.VisibleIndex = 11;
			this.colPhoneNumber2.Width = 114;
			// 
			// colPhoneNumber3
			// 
			this.colPhoneNumber3.FieldName = "PhoneNumber3";
			this.colPhoneNumber3.MinWidth = 25;
			this.colPhoneNumber3.Name = "colPhoneNumber3";
			this.colPhoneNumber3.Visible = true;
			this.colPhoneNumber3.VisibleIndex = 12;
			this.colPhoneNumber3.Width = 126;
			// 
			// colFaxNumber
			// 
			this.colFaxNumber.FieldName = "FaxNumber";
			this.colFaxNumber.MinWidth = 25;
			this.colFaxNumber.Name = "colFaxNumber";
			this.colFaxNumber.Visible = true;
			this.colFaxNumber.VisibleIndex = 13;
			this.colFaxNumber.Width = 127;
			// 
			// colWebsite
			// 
			this.colWebsite.FieldName = "Website";
			this.colWebsite.MinWidth = 25;
			this.colWebsite.Name = "colWebsite";
			this.colWebsite.Visible = true;
			this.colWebsite.VisibleIndex = 14;
			this.colWebsite.Width = 116;
			// 
			// colMofNo
			// 
			this.colMofNo.FieldName = "MofNo";
			this.colMofNo.MinWidth = 25;
			this.colMofNo.Name = "colMofNo";
			this.colMofNo.Visible = true;
			this.colMofNo.VisibleIndex = 15;
			this.colMofNo.Width = 104;
			// 
			// colEmail
			// 
			this.colEmail.FieldName = "Email";
			this.colEmail.MinWidth = 25;
			this.colEmail.Name = "colEmail";
			this.colEmail.Visible = true;
			this.colEmail.VisibleIndex = 16;
			this.colEmail.Width = 163;
			// 
			// colActivity
			// 
			this.colActivity.FieldName = "Activity";
			this.colActivity.MinWidth = 25;
			this.colActivity.Name = "colActivity";
			this.colActivity.Visible = true;
			this.colActivity.VisibleIndex = 17;
			this.colActivity.Width = 94;
			// 
			// colResponsibleId
			// 
			this.colResponsibleId.Caption = "Responsible";
			this.colResponsibleId.ColumnEdit = this.repResponsibles;
			this.colResponsibleId.FieldName = "ResponsibleId";
			this.colResponsibleId.MinWidth = 25;
			this.colResponsibleId.Name = "colResponsibleId";
			this.colResponsibleId.Visible = true;
			this.colResponsibleId.VisibleIndex = 18;
			this.colResponsibleId.Width = 94;
			// 
			// repResponsibles
			// 
			this.repResponsibles.AutoHeight = false;
			this.repResponsibles.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repResponsibles.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repResponsibles.DisplayMember = "UserName";
			this.repResponsibles.Name = "repResponsibles";
			this.repResponsibles.NullText = "";
			this.repResponsibles.ValueMember = "Id";
			// 
			// colPostalCode
			// 
			this.colPostalCode.FieldName = "PostalCode";
			this.colPostalCode.MinWidth = 25;
			this.colPostalCode.Name = "colPostalCode";
			this.colPostalCode.Visible = true;
			this.colPostalCode.VisibleIndex = 19;
			this.colPostalCode.Width = 94;
			// 
			// colPostalAddress
			// 
			this.colPostalAddress.FieldName = "PostalAddress";
			this.colPostalAddress.MinWidth = 25;
			this.colPostalAddress.Name = "colPostalAddress";
			this.colPostalAddress.Visible = true;
			this.colPostalAddress.VisibleIndex = 20;
			this.colPostalAddress.Width = 94;
			// 
			// colBranch
			// 
			this.colBranch.FieldName = "Branch";
			this.colBranch.MinWidth = 25;
			this.colBranch.Name = "colBranch";
			this.colBranch.Visible = true;
			this.colBranch.VisibleIndex = 21;
			this.colBranch.Width = 94;
			// 
			// colName
			// 
			this.colName.FieldName = "Name";
			this.colName.MinWidth = 25;
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 22;
			this.colName.Width = 94;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.MinWidth = 25;
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 23;
			this.colNotes.Width = 94;
			// 
			// repMemberTypeList
			// 
			this.repMemberTypeList.AutoHeight = false;
			this.repMemberTypeList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repMemberTypeList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeName", "Type Name")});
			this.repMemberTypeList.DisplayMember = "TypeName";
			this.repMemberTypeList.Name = "repMemberTypeList";
			this.repMemberTypeList.NullText = "";
			this.repMemberTypeList.ValueMember = "Id";
			// 
			// repMemberCategoryList
			// 
			this.repMemberCategoryList.AutoHeight = false;
			this.repMemberCategoryList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repMemberCategoryList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description")});
			this.repMemberCategoryList.DisplayMember = "Description";
			this.repMemberCategoryList.Name = "repMemberCategoryList";
			this.repMemberCategoryList.NullText = "";
			this.repMemberCategoryList.ValueMember = "Id";
			// 
			// repOrganizationList
			// 
			this.repOrganizationList.AutoHeight = false;
			this.repOrganizationList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repOrganizationList.Name = "repOrganizationList";
			this.repOrganizationList.NullText = "";
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
			// repCheckBox
			// 
			this.repCheckBox.AutoHeight = false;
			this.repCheckBox.Name = "repCheckBox";
			// 
			// repSales
			// 
			this.repSales.AutoHeight = false;
			this.repSales.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repSales.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
			this.repSales.DisplayMember = "UserName";
			this.repSales.Name = "repSales";
			this.repSales.NullText = "";
			this.repSales.ValueMember = "Id";
			// 
			// rcAgentsList
			// 
			this.rcAgentsList.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
			this.rcAgentsList.ExpandCollapseItem.Id = 0;
			this.rcAgentsList.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcAgentsList.ExpandCollapseItem,
            this.btnNew,
            this.btnEdit,
            this.btnRefresh,
            this.btnPrint,
            this.btnDelete,
            this.btnClose,
            this.btnResetGridStyle});
			this.rcAgentsList.Location = new System.Drawing.Point(0, 0);
			this.rcAgentsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rcAgentsList.MaxItemId = 23;
			this.rcAgentsList.Name = "rcAgentsList";
			this.rcAgentsList.OptionsMenuMinWidth = 385;
			this.rcAgentsList.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpAgentsList,
            this.rpViewSettings});
			this.rcAgentsList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
			this.rcAgentsList.Size = new System.Drawing.Size(1442, 193);
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
			// rpAgentsList
			// 
			this.rpAgentsList.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup8,
            this.rpgDelete,
            this.rpgCloseView});
			this.rpAgentsList.Name = "rpAgentsList";
			this.rpAgentsList.Text = "AGENTS LIST";
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
			// barHeaderItem1
			// 
			this.barHeaderItem1.Caption = "RECORDS: 0";
			this.barHeaderItem1.Id = 7;
			this.barHeaderItem1.Name = "barHeaderItem1";
			// 
			// RootLayout
			// 
			this.RootLayout.Controls.Add(this.moduleLayout);
			this.RootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RootLayout.Location = new System.Drawing.Point(0, 193);
			this.RootLayout.Name = "RootLayout";
			this.RootLayout.Root = this.Root;
			this.RootLayout.Size = new System.Drawing.Size(1442, 602);
			this.RootLayout.TabIndex = 8;
			this.RootLayout.Text = "layoutControl1";
			// 
			// moduleLayout
			// 
			this.moduleLayout.AllowCustomization = false;
			this.moduleLayout.Controls.Add(this.gcAgents);
			this.moduleLayout.Location = new System.Drawing.Point(12, 12);
			this.moduleLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.moduleLayout.Name = "moduleLayout";
			this.moduleLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 412, 812, 500);
			this.moduleLayout.Root = this.layoutControlGroup1;
			this.moduleLayout.Size = new System.Drawing.Size(1418, 578);
			this.moduleLayout.TabIndex = 12;
			this.moduleLayout.Text = "moduleLayout";
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "Root";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 14, 16, 16);
			this.layoutControlGroup1.Size = new System.Drawing.Size(1418, 578);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcAgents;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1399, 546);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1442, 602);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.moduleLayout;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(1422, 582);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// AgentsListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1442, 795);
			this.Controls.Add(this.RootLayout);
			this.Controls.Add(this.rcAgentsList);
			this.Name = "AgentsListForm";
			this.Ribbon = this.rcAgentsList;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agents List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgentsListForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.gcAgents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsAgents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvAgents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repMemberOfList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repDateFormat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCountries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCities)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repAgentsGroups)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repAgentsCategories)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repResponsibles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repMemberTypeList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repMemberCategoryList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repOrganizationList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCheckBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repSales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rcAgentsList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RootLayout)).EndInit();
			this.RootLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).EndInit();
			this.moduleLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rcAgentsList;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAgentsList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpViewSettings;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgCloseView;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraLayout.LayoutControl RootLayout;
        private DevExpress.XtraLayout.LayoutControl moduleLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gcAgents;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAgents;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repMemberCategoryList;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repMemberOfList;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repOrganizationList;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repMemberTypeList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bsAgents;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repAgentsGroups;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repAgentsCategories;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCountries;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCities;
        private DevExpress.XtraGrid.Columns.GridColumn colAgentName;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberOfId;
        private DevExpress.XtraGrid.Columns.GridColumn colActiveDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFollowupDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryId;
        private DevExpress.XtraGrid.Columns.GridColumn colCityId;
        private DevExpress.XtraGrid.Columns.GridColumn colAgentGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn colAgentCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber1;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber2;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber3;
        private DevExpress.XtraGrid.Columns.GridColumn colFaxNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colMofNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colActivity;
        private DevExpress.XtraGrid.Columns.GridColumn colResponsibleId;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDateFormat;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repResponsibles;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repSales;
		private DevExpress.XtraBars.BarButtonItem btnResetGridStyle;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
	}
}