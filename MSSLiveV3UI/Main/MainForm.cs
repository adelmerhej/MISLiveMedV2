using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Forms;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Accounting.Banks;
using MISLiveMed.UI.Accounting.Charts;
using MISLiveMed.UI.Accounting.Commissions;
using MISLiveMed.UI.Accounting.Costs;
using MISLiveMed.UI.Accounting.CreditNotes;
using MISLiveMed.UI.Accounting.Currencies;
using MISLiveMed.UI.Accounting.DebitNotes;
using MISLiveMed.UI.Accounting.Invoices;
using MISLiveMed.UI.Accounting.Journals;
using MISLiveMed.UI.Accounting.Journals.Reports;
using MISLiveMed.UI.Accounting.Journals.Reports.Settings;
using MISLiveMed.UI.Accounting.Journals.Reports.Settings.BalanceGroup;
using MISLiveMed.UI.Accounting.Payments;
using MISLiveMed.UI.Accounting.Receipts;
using MISLiveMed.UI.Forms.Common.Carriers;
using MISLiveMed.UI.Forms.Common.Companies;
using MISLiveMed.UI.Forms.Common.Containers;
using MISLiveMed.UI.Forms.Common.Countries;
using MISLiveMed.UI.Forms.Common.Countries.Ports;
using MISLiveMed.UI.Forms.Common.Departments;
using MISLiveMed.UI.Forms.Common.Items;
using MISLiveMed.UI.Forms.Common.Tejrim;
using MISLiveMed.UI.Forms.CRM.Agents;
using MISLiveMed.UI.Forms.CRM.Agents.Categories;
using MISLiveMed.UI.Forms.CRM.Agents.Groups;
using MISLiveMed.UI.Forms.CRM.Customers;
using MISLiveMed.UI.Forms.CRM.Customers.Categories;
using MISLiveMed.UI.Forms.CRM.Quotations;
using MISLiveMed.UI.Forms.JobForms.AirFreight.AirCross;
using MISLiveMed.UI.Forms.JobForms.AirFreight.AirExport;
using MISLiveMed.UI.Forms.JobForms.AirFreight.AirImport;
using MISLiveMed.UI.Forms.JobForms.Clearance.AirFreight;
using MISLiveMed.UI.Forms.JobForms.Clearance.SeaFreight;
using MISLiveMed.UI.Forms.JobForms.SeaFreight.SeaCross;
using MISLiveMed.UI.Forms.JobForms.SeaFreight.SeaExport;
using MISLiveMed.UI.Forms.JobForms.SeaFreight.SeaImport;
using MISLiveMed.UI.Forms.JobForms.SeaFreight.SeaImport.Reports;
using MISLiveMed.UI.Forms.Users;
using MISLiveMed.UI.Forms.Users.PermissionControls;
using MISLiveMed.UI.Main.Administration.Configuration;
using MISLiveMed.UI.Properties;
using MISLiveMed.UI.Reports.BookingStatus;
using MISLiveMed.UI.Reports.ClientsReports;
using MISLiveMed.UI.Reports.DOP;
using MISLiveMed.UI.Reports.DOPReports;
using MISLiveMed.UI.Reports.History;
using MISLiveMed.UI.Reports.JobStatus;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Main
{
    public partial class MainForm : RibbonForm
	{
		private const string _formName = "MainForm";
		private int _formId;

		private IList<FormModel> _forms = new List<FormModel>();
        //private List<DataReportModel> _dataReportModels = new List<DataReportModel>();

        /// <summary>
        /// User Permission Role
        /// </summary>
        private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
        private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
        private readonly FormRepository _formRepository = new FormRepository();

		private bool _isVisible;
		private bool _isActive;
		private bool _isAdmin;
		private bool _isProtected;
		
		private bool _resetMenu;
        private readonly bool _logOut;

		public MainForm()
        {
            InitializeComponent();
            
            try
            {
	            InitializeBindings();
	            WireUpBindings();
	            ApplyPermissions();
	            ApplyDefaults();

				UpdateStatus();
	            
	            defaultLookAndFeel1.LookAndFeel.SetSkinStyle(Settings.Default.ApplicationSkinName, Settings.Default.ApplicationPalette);
	            LayoutsStyle.LoadLayoutMenu(mainMenu, CurrentUser.UserName);

	            _logOut = true;
			}
            catch (Exception e)
            {
	            XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
		private void InitializeBindings()
        {
	        try
	        {
		        //
		        _formId = _formRepository.SelectFormByName(_formName);
		        _userPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, _formId);
		        if (_userPermission != null && _userPermission.Count > 0)
		        {
			        var isProtected = _userPermission.SingleOrDefault(x => x.ControlName == "IsProtected")?.Value;
			        if (isProtected != null) _isProtected = (bool)isProtected;
		        }
		        //

				_forms = _formRepository.SelectForms();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}
		private void WireUpBindings()
        {
			
        }
        private void ApplyDefaults()
        {
	        if (CurrentUser.UserName.ToLower() == "admin")
	        {
		        mnuSetupMenu.Enabled = true;

				mnuUsersMenu.Visible = true;
				mnuUsersMenu.AccordionControl.ExpandAll();
				mnuUsersMenu.Enabled = true;

				mnuUsersList.Visible = true;
		        mnuUsersList.Enabled = true;

		        mnuCompaniesList.Visible = true;
		        mnuCompaniesList.Enabled = true;
			}

	        //tsViewPendingJobs.EditValue = Settings.Default.ShowPendingJobs;

	        //companiesList = companyConnector.GetCompanyListAll();
	        //repCompaniesList.DataSource = companiesList;
	        //wCompanyId = Settings.Default.CompanyId;
	        //cboCompaniesList.EditValue = wCompanyId; 

	        //if (Settings.Default.ShowPendingJobs)
	        //{
	        //    OpenForm(new PendingJobsForm());
	        //}

	        //if (CurrentUserInfoModel.IsAdmin && Settings.Default.ShowPendingJobs)
	        //{
	        //    OpenForm(new PendingJobsForm());
	        //}

	        //    frmMain.Caption = App.Title & " - " & gv_version & " - User name: " & CurrentUserName"
	        //  - Server: " & IIf(server = ".", "(LocalHost)", server) & " - Database: " & gv_DefaultDatabase
        }

		private void ApplyPermissions()
		{
			if (_userPermission == null) return;
			//if (_userPermission.Count <= 0) return;

			// Only admin can access DatabaseSettings
			var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
			if (isAdmin != null) _isAdmin = (bool)isAdmin;
			mnuDatabaseSettings.Visible = _isAdmin;

			// Only for Main Form
			foreach (var form in _forms)
			{
				var menuPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, form.Id);
				var isVisible = menuPermission.SingleOrDefault(x => x.ControlName == "IsVisible")?.Value;
				if (isVisible != null) _isVisible = (bool)isVisible;

				var isActive = menuPermission.SingleOrDefault(x => x.ControlName == "IsActive")?.Value;
				if (isActive != null) _isActive = (bool)isActive;

				isAdmin = menuPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
				if (isAdmin != null) _isAdmin = (bool)isAdmin;

				switch (form.Name)
				{
					#region MAIN MENU LIST
					//
					//*************** MAIN MENU LIST *****************//
					case "NavigationMenu":
						mnuNavigationMenu.Visible = _isVisible;
						mnuNavigationMenu.Enabled = _isActive;
						break;

					case "MainAdministrationMenu":
						mnuMainAdministrationMenu.Visible = _isVisible;
						mnuMainAdministrationMenu.Enabled = _isActive;
						break;

					case "MainAccountingMenu":
						mnuMainAccountingMenu.Visible = _isVisible;
						mnuMainAccountingMenu.Enabled = _isActive;
						break;

					case "SetupMenu":
						mnuSetupMenu.Visible = _isVisible;
						mnuSetupMenu.Enabled = _isActive;
						break;

					//***************************************************//
					#endregion

					#region Dashboard Department
					//
					//*************** Dashboard Department *****************//
					case "Dashboard":
						mnuDashboard.Visible = _isVisible;
						if (!_isActive) mnuDashboard.AccordionControl.CollapseAll();
						mnuDashboard.Enabled = _isActive;
						break;
					//***************************************************//

					case "QuotationsList":
						mnuQuotationsList.Visible = _isVisible;
						mnuQuotationsList.Enabled = _isActive;

						break;

					case "TotalProfitReport":
						mnuTotalProfitReport.Visible = _isVisible;
						mnuTotalProfitReport.Enabled = _isActive;
						break;

					case "JobStatusReport":
						mnuJobStatusReport.Visible = _isVisible;
						mnuJobStatusReport.Enabled = _isActive;
						break;

					case "DetailedProfitReport":
						mnuDetailedProfitReport.Visible = _isVisible;
						mnuDetailedProfitReport.Enabled = _isActive;
						break;

					//case "IncomeStatementReport":
					//	mnuIncomeStatementReport.Visible = _isVisible;
					//	mnuIncomeStatementReport.Enabled = _isActive;
					//	break;

					case "EmptyContainersReport":
						mnuEmptyContainersReport.Visible = _isVisible;
						mnuEmptyContainersReport.Enabled = _isActive;
						break;

					case "QuotationsJobsReport":
						mnuQuotationsJobsReport.Visible = _isVisible;
						mnuQuotationsJobsReport.Enabled = _isActive;
						break;
						
					//***************************************************//

					#endregion

					#region Group Departments

					//*************** Group Departments *****************//
					case "GroupDepartments":
						mnuGroupDepartments.Visible = _isVisible;
						if (!_isActive) mnuGroupDepartments.AccordionControl.CollapseAll();
						mnuGroupDepartments.Enabled = _isActive;
						break;
					//***************************************************//

					//
					//*************** Accounting Department *****************//
					case "AccountingDepartment":
						mnuAccountingDepartment.Visible = _isVisible;
						mnuAccountingDepartment.Enabled = _isActive;
						break;

					case "PaymentsList":
						mnuTransactionPaymentsList.Visible = _isVisible;
						mnuTransactionPaymentsList.Enabled = _isActive;
						break;

					case "ReceiptsList":
						mnuTransactionReceiptsList.Visible = _isVisible;
						mnuTransactionReceiptsList.Enabled = _isActive;
						break;

					case "DebitNotesList":
						mnuTransactionDebitNotesList.Visible = _isVisible;
						mnuTransactionDebitNotesList.Enabled = _isActive;

						break;

					case "CreditNotesList":
						mnuTransactionCreditNotesList.Visible = _isVisible;
						mnuTransactionCreditNotesList.Enabled = _isActive;
						break;

					case "CommissionsHistoryList":
						mnuCommissionsList.Visible = _isVisible;
						mnuCommissionsList.Enabled = _isActive;
						break;
					//**************************************************//
					//*************** Import Department *****************//
					case "ImportDepartmentMenu":
						mnuImportDepartmentMenu.Visible = _isVisible;
						mnuImportDepartmentMenu.Enabled = _isActive;
						break;

					case "JobSeaImportList":
						mnuJobsSeaImportList.Visible = _isVisible;
						mnuJobsSeaImportList.Enabled = _isActive;
						break;

					case "JobAirImportList":
						mnuJobsAirImportList.Visible = _isVisible;
						mnuJobsAirImportList.Enabled = _isActive;
						break;
					//**************************************************//

					//
					//*************** Export Department *****************//
					case "ExportDepartmentMenu":
						mnuExportDepartmentMenu.Visible = _isVisible;
						mnuExportDepartmentMenu.Enabled = _isActive;
						break;

					case "JobSeaExportList":
						mnuJobsSeaExportList.Visible = _isVisible;
						mnuJobsSeaExportList.Enabled = _isActive;
						break;

					case "JobAirExportList":
						mnuJobsAirExportList.Visible = _isVisible;
						mnuJobsAirExportList.Enabled = _isActive;
						break;
					//**************************************************//

					//
					//*************** Cross Department *****************//
					case "CrossDepartment":
						mnuCrossDepartment.Visible = _isVisible;
						mnuCrossDepartment.Enabled = _isActive;
						break;

					case "JobSeaCrossList":
						mnuJobsSeaCrossList.Visible = _isVisible;
						mnuJobsSeaCrossList.Enabled = _isActive;
						break;

					case "JobAirCrossList":
						mnuJobsAirCrossList.Visible = _isVisible;
						mnuJobsAirCrossList.Enabled = _isActive;
						break;
					//**************************************************//

					//
					//*************** Clearance Department *****************//
					case "ClearanceDepartment":
						mnuClearanceDepartment.Visible = _isVisible;
						mnuClearanceDepartment.Enabled = _isActive;
						break;

					case "JobSeaClearanceList":
						mnuJobsSeaClearanceList.Visible = _isVisible;
						mnuJobsSeaClearanceList.Enabled = _isActive;
						break;

					case "JobAirClearanceList":
						mnuJobsAirClearanceList.Visible = _isVisible;
						mnuJobsAirClearanceList.Enabled = _isActive;
						break;
					//********************************************************//

					//
					//*************** Land Freight Department ***************//
					case "LandFreightDepartment":
						mnuLandFreightDepartment.Visible = _isVisible;
						mnuLandFreightDepartment.Enabled = _isActive;
						break;

					case "JobsLandFreight":
						mnuJobsLandFreightList.Visible = _isVisible;
						mnuJobsLandFreightList.Enabled = _isActive;
						break;
					//*******************************************************//

					//
					//*************** Tejrim Department *********************//
					case "TejrimDepartment":
						mnuTejrimDepartment.Visible = _isVisible;
						mnuTejrimDepartment.Enabled = _isActive;
						break;

					case "TejrimJobsList":
						mnuTejrimJobsList.Visible = _isVisible;
						mnuTejrimJobsList.Enabled = _isActive;
						break;

					case "ClosedJobsList":
						mnuClosedJobsList.Visible = _isVisible;
						mnuClosedJobsList.Enabled = _isActive;
						break;
					//******************************************************//

					//
					//*************** uWarehouse Department ****************//
					case "WarehouseDepartment":
						mnuWarehouseDepartment.Visible = _isVisible;
						mnuWarehouseDepartment.Enabled = _isActive;
						break;

					case "JobsWarehouseList":
						mnuJobsWarehouseList.Visible = _isVisible;
						mnuJobsWarehouseList.Enabled = _isActive;
						break;
					//******************************************************//
					#endregion

					#region Group Reports

					//
					//*************** Group Reports ************************//
					case "GroupReports":
						mnuGroupReports.Visible = _isVisible;
						if (!_isActive) mnuGroupReports.AccordionControl.CollapseAll();
						mnuGroupReports.Enabled = _isActive;
						break;
					//*****************************************************//

					//
					//************* Clients Reports Group *****************//
					case "ClientsReportsGroup":
						mnuClientsReportsGroup.Visible = _isVisible;
						mnuClientsReportsGroup.Enabled = _isActive;
						break;

					case "ClientInvoicesDetailReport":
						mnuClientInvoicesDetailReport.Visible = _isVisible;
						mnuClientInvoicesDetailReport.Enabled = _isActive;
						break;

					case "InvoicesDetailReport":
						mnuInvoicesDetailReport.Visible = _isVisible;
						mnuInvoicesDetailReport.Enabled = _isActive;
						break;

					case "ClientsReport":
						mnuClientsReport.Visible = _isVisible;
						mnuClientsReport.Enabled = _isActive;
						break;

					case "ClientSalesReport":
						mnuClientSalesReport.Visible = _isVisible;
						mnuClientSalesReport.Enabled = _isActive;
						break;
					
					//*****************************************************//

					//
					//*************Import Department Reports***************//
					case "ImportDepartmentReports":
						mnuImportDepartmentReports.Visible = _isVisible;
						mnuImportDepartmentReports.Enabled = _isActive;
						break;

					case "ToBeLoadedSeaImport":
						mnuToBeLoadedSeaImport.Visible = _isVisible;
						mnuToBeLoadedSeaImport.Enabled = _isActive;
						break;

					case "OnWaterSeaImport":
						mnuOnWaterSeaimport.Visible = _isVisible;
						mnuOnWaterSeaimport.Enabled = _isActive;
						break;

					case "AirImportStatusReport":
						mnuAirImportStatus.Visible = _isVisible;
						mnuAirImportStatus.Enabled = _isActive;
						break;
					//*****************************************************//

					//
					//*************Export Department Reports***************//
					case "ExportDepartmentReports":
						mnuExportDepartmentReports.Visible = _isVisible;
						mnuExportDepartmentReports.Enabled = _isActive;
						break;

					case "ToBeLoadedSeaExport":
						mnuToBeLoadedSeaExport.Visible = _isVisible;
						mnuToBeLoadedSeaExport.Enabled = _isActive;
						break;

					case "OnWaterSeaExport":
						mnuExportOnWater.Visible = _isVisible;
						mnuExportOnWater.Enabled = _isActive;
						break;

					case "AirExportStatusReport":
						mnuAirExportStatus.Visible = _isVisible;
						mnuAirExportStatus.Enabled = _isActive;
						break;
					//*****************************************************//

					//
					//*************Cross Department Reports***************//
					case "CrossDepartmentReports":
						mnuCrossDepartmentReports.Visible = _isVisible;
						mnuCrossDepartmentReports.Enabled = _isActive;
						break;

					case "PendingCrossReports":
						mnuPendingCrossReports.Visible = _isVisible;
						mnuPendingCrossReports.Enabled = _isActive;
						break;
					//*****************************************************//

					//
					//*************Clearance Department Reports***************//
					case "ClearanceDepartmentReports":
						mnuClearanceDepartmentReports.Visible = _isVisible;
						mnuClearanceDepartmentReports.Enabled = _isActive;
						break;

					case "JobClearanceReport":
						mnuJobClearanceReport.Visible = _isVisible;
						mnuJobClearanceReport.Enabled = _isActive;
						break;

					//*****************************************************//

					//
					//***********Land Freight Department Reports************//
					case "LandFreightDepartmentReports":
						mnuLandFreightDepartmentReports.Visible = _isVisible;
						mnuLandFreightDepartmentReports.Enabled = _isActive;
						break;

					//SET MENU GOES HERE

					//*****************************************************//

					case "NegativeReport":
						mnuNegativeReport.Visible = _isVisible;
						mnuNegativeReport.Enabled = _isActive;
						break;

					//*****************************************************//

					#endregion

					#region CRM AND Members

					//
					//****************CRM AND Members**********************//
					case "MembersMenu":
						mnuMembers.Visible = _isVisible;
						if (!_isActive) mnuMembers.AccordionControl.CollapseAll();
						mnuMembers.Enabled = _isActive;
						break;

					case "CustomersList":
						mnuCustomersList.Visible = _isVisible;
						mnuCustomersList.Enabled = _isActive;
						break;

					case "AgentsList":
						mnuAgentsList.Visible = _isVisible;
						mnuAgentsList.Enabled = _isActive;
						break;

					//*****************************************************//

					#endregion

					#region Administration Menu
					//
					//**************Administration Menu********************//
					case "Administration":
						mnuAdministration.Visible = _isVisible;
						if (!_isActive) mnuAdministration.AccordionControl.CollapseAll();
						mnuAdministration.Enabled = _isActive;
						break;

					//*****************************************************//

					#region Countries Menu

					case "CountriesGroup":
						mnuCountriesGroup.Visible = _isVisible;
						if (!_isActive) mnuCountriesGroup.AccordionControl.CollapseAll();
						mnuCountriesGroup.Enabled = _isActive;
						break;

					case "CitiesList":
						mnuCitiesList.Visible = _isVisible;
						mnuCitiesList.Enabled = _isActive;
						break;

					case "CountriesList":
						mnuCountriesList.Visible = _isVisible;
						mnuCountriesList.Enabled = _isActive;
						break;

					case "DistrictsList":
						mnuDistrictsList.Visible = _isVisible;
						mnuDistrictsList.Enabled = _isActive;
						break;

					case "ProvincesList":
						mnuProvincesList.Visible = _isVisible;
						mnuProvincesList.Enabled = _isActive;
						break;

					case "RegionsList":
						mnuRegionsList.Visible = _isVisible;
						mnuRegionsList.Enabled = _isActive;
						break;

					case "ContinentsList":
						mnuContinentsList.Visible = _isVisible;
						mnuContinentsList.Enabled = _isActive;
						break;

					case "SeaportsList":
						mnuSeaportsList.Visible = _isVisible;
						mnuSeaportsList.Enabled = _isActive;
						break;

					case "AirportsList":
						mnuAirportsList.Visible = _isVisible;
						mnuAirportsList.Enabled = _isActive;
						break;

					case "LandFreightPortsList":
						mnuLandFreightPortsList.Visible = _isVisible;
						mnuLandFreightPortsList.Enabled = _isActive;
						break;

					//*****************************************************//

					#endregion

					#region Types Menu

					//
					//**************Types Menu********************//
					case "TypesMenu":
						mnuTypesMenu.Visible = _isVisible;
						if (!_isActive) mnuTypesMenu.AccordionControl.CollapseAll();
						mnuTypesMenu.Enabled = _isActive;
						break;

					//*****************************************************//
					case "ContainersTypeList":
						mnuContainersTypeList.Visible = _isVisible;
						mnuContainersTypeList.Enabled = _isActive;
						break;

					case "WarehousesList":
						mnuWarehousesList.Visible = _isVisible;
						mnuWarehousesList.Enabled = _isActive;
						break;

					case "ProductTypesList":
						mnuProductTypesList.Visible = _isVisible;
						mnuProductTypesList.Enabled = _isActive;
						break;

					case "MembersCategoryList":
						mnuMembersCategoryList.Visible = _isVisible;
						mnuMembersCategoryList.Enabled = _isActive;
						break;

					case "AgentGroupList":
						mnuAgentGroupList.Visible = _isVisible;
						mnuAgentGroupList.Enabled = _isActive;
						break;

					case "AgentCategoryList":
						mnuAgentCategoryList.Visible = _isVisible;
						mnuAgentCategoryList.Enabled = _isActive;
						break;

					//*****************************************************//

					#endregion

					#region Items Menu

					//
					//**************Items Menu********************//
					case "ItemsListMenu":
						mnuItemsMenu.Visible = _isVisible;
						if (!_isActive) mnuItemsMenu.AccordionControl.CollapseAll();
						mnuItemsMenu.Enabled = _isActive;
						break;

					case "ItemsList":
						mnuItemsList.Visible = _isVisible;
						mnuItemsList.Enabled = _isActive;
						break;

					case "RequirementsList":
						mnuRequirementsList.Visible = _isVisible;
						mnuRequirementsList.Enabled = _isActive;
						break;

					//*****************************************************//

					#endregion

					#region Carriers Menu
					//
					//**************Carriers Menu********************//
					case "CarriersMenu":
						mnuCarriersMenu.Visible = _isVisible;
						if (!_isActive) mnuCarriersMenu.AccordionControl.CollapseAll();
						mnuCarriersMenu.Enabled = _isActive;
						break;

					case "SeaCarriersList":
						mnuSeaCarriersList.Visible = _isVisible;
						mnuSeaCarriersList.Enabled = _isActive;
						break;

					case "AirLinesList":
						mnuAirLinesList.Visible = _isVisible;
						mnuAirLinesList.Enabled = _isActive;
						break;

					case "TrucksList":
						mnuTrucksList.Visible = _isVisible;
						mnuTrucksList.Enabled = _isActive;
						break;

					//*****************************************************//
					#endregion


					#endregion

					#region Main Accounting

					//
					//**************Accounting Menu********************//
					case "AccountingMenu":
						mnuAccounting.Visible = _isVisible;
						if (!_isActive) mnuAccounting.AccordionControl.CollapseAll();
						mnuAccounting.Enabled = _isActive;
						break;

					//*****************************************************//


					#region Transactions Menu

					//
					//**************Transactions Menu********************//
					case "TransactionsMenu":
						mnuTransactions.Visible = _isVisible;
						if (!_isActive) mnuTransactions.AccordionControl.CollapseAll();
						mnuTransactions.Enabled = _isActive;
						break;

					case "JournalsMenu":
						mnuJournals.Visible = _isVisible;
						mnuJournals.Enabled = _isActive;
						break;


					case "ListOfInvoicesMenu":
						mnuListOfInvoices.Visible = _isVisible;
						mnuListOfInvoices.Enabled = _isActive;
						break;

					case "ListOfCostsMenu":
						mnuListOfCosts.Visible = _isVisible;
						mnuListOfCosts.Enabled = _isActive;
						break;

					//*****************************************************//

					#endregion

					#region Currencies Menu

					//
					//**************Currencies Menu********************//
					case "CurrenciesMenu":
						mnuCurrenciesMenu.Visible = _isVisible;
						if (!_isActive) mnuCurrenciesMenu.AccordionControl.CollapseAll();
						mnuCurrenciesMenu.Enabled = _isActive;
						break;

					case "CurrenciesList":
						mnuCurrenciesList.Visible = _isVisible;
						mnuCurrenciesList.Enabled = _isActive;
						break;

					case "ExchangeList":
						mnuExchangeList.Visible = _isVisible;
						mnuExchangeList.Enabled = _isActive;
						break;

					//*****************************************************//

					#endregion

					#region Chart Of Accounts Menu

					//
					//**************Charts Menu********************//
					case "ChartOfAccounts":
						mnuChartOfAccounts.Visible = _isVisible;
						if (!_isActive) mnuChartOfAccounts.AccordionControl.CollapseAll();
						mnuChartOfAccounts.Enabled = _isActive;
						break;

					case "ChartsList":
						mnuChartsList.Visible = _isVisible;
						mnuChartsList.Enabled = _isActive;
						break;

					case "BanksList":
						mnuBanksList.Visible = _isVisible;
						mnuBanksList.Enabled = _isActive;
						break;

					//*****************************************************//

					#endregion

					#region AccountingSetup Menu

					//
					//**************AccountingSetup Menu********************//
					case "AccountingSetupMenu":
						mnuAccountingSetup.Visible = _isVisible;
						if (!_isActive) mnuAccountingSetup.AccordionControl.CollapseAll();
						mnuAccountingSetup.Enabled = _isActive;
						break;

					case "CalendarYearsMenu":
						mnuCalendarYears.Visible = _isVisible;
						mnuCalendarYears.Enabled = _isActive;
						break;

					case "JvTypeList":
						mnuJvTypeList.Visible = _isVisible;
						mnuJvTypeList.Enabled = _isActive;
						break;

					case "JvTypesSerialsList":
						JvTypesSerialsList.Visible = _isVisible;
						JvTypesSerialsList.Enabled = _isActive;
						break;

					case "PaymentTypesList":
						mnuPaymentTypesList.Visible = _isVisible;
						mnuPaymentTypesList.Enabled = _isActive;
						break;

					//*****************************************************//

					#endregion

					#region Accounting Reports Menu

					//
					//**************Accounting Reports Menu********************//
					case "ReportsMenu":
						mnuReportsMenu.Visible = _isVisible;
						if (!_isActive) mnuReportsMenu.AccordionControl.CollapseAll();
						mnuReportsMenu.Enabled = _isActive;
						break;

					case "StatementOfAccount":
						mnuStatementOfAccount.Visible = _isVisible;
						mnuStatementOfAccount.Enabled = _isActive;
						break;

					case "TrialBalance":
						mnuTrialBalance.Visible = _isVisible;
						mnuTrialBalance.Enabled = _isActive;
						break;

					case "PrintDopReport":
						mnuPrintDop.Visible = _isVisible;
						mnuPrintDop.Enabled = _isActive;
						break;

					case "PrintSalesCommission":
						mnuPrintSalesCommission.Visible = _isVisible;
						mnuPrintSalesCommission.Enabled = _isActive;
						break;

					//*****************************************************//

					#endregion

					#endregion

					#region Main Setup Menu

					//
					//**************Users Reports Menu********************//

					case "UsersMenu":
						if (CurrentUser.UserName.ToLower() != "admin")
						{
							mnuUsersMenu.Visible = _isVisible;
							if (!_isActive) mnuUsersMenu.AccordionControl.CollapseAll();
							mnuUsersMenu.Enabled = _isActive;
						} 
						break;

					case "UsersList":
						mnuUsersList.Visible = _isVisible;
						mnuUsersList.Enabled = _isActive;
						break;

					case "CompaniesList":
						mnuCompaniesList.Visible = _isVisible;
						mnuCompaniesList.Enabled = _isActive;
						break;
						
					//*****************************************************//

					//
					//**************Departments Menu********************//

					case "DepartmentsMenu":
						mnuDepartmentsMenu.Visible = _isVisible;
						if (!_isActive) mnuDepartmentsMenu.AccordionControl.CollapseAll();
						mnuDepartmentsMenu.Enabled = _isActive;
						break;

					case "DepartmentsList":
						mnuDepartmentsList.Visible = _isVisible;
						mnuDepartmentsList.Enabled = _isActive;
						break;

					//*****************************************************//


					//
					//*****************Settings Menu***********************//

					case "SettingsMenu":
						mnuSettings.Visible = _isVisible;
						if (!_isActive) mnuSettings.AccordionControl.CollapseAll();
						mnuSettings.Enabled = _isActive;
						break;

					case "PermissionControlsList":
						mnuPermissionControlsList.Visible = _isVisible;
						mnuPermissionControlsList.Enabled = _isActive;
						break;

					case "CommissionsManager":
						mnuCommissionsManager.Visible = _isVisible;
						mnuCommissionsManager.Enabled = _isActive;
						break;

					case "GeneralSettings":
						mnuGeneralSettings.Visible = _isVisible;
						mnuGeneralSettings.Enabled = _isActive;
						break;
						
					case "DatabaseSettings":
						mnuDatabaseSettings.Visible = _isVisible;
						mnuDatabaseSettings.Enabled = _isActive;
						break;


					case "ReportGroupSettings":
						mnuReportSettings.Visible = _isVisible;
						mnuReportSettings.Enabled = _isActive;
						break;

					case "ReportSettings":
						mnuReportSettings.Visible = _isVisible;
						mnuReportSettings.Enabled = _isActive;
						break;

					case "BalanceSettings":
						mnuBalanceSettings.Visible = _isVisible;
						mnuBalanceSettings.Enabled = _isActive;
						break;

						#endregion
				}
			}
		}
		private void MainForm_Activated(object sender, EventArgs e)
        {
            try
            {
                var af = ActiveMdiChild as IFormWithRibbon;
                if (af == null) return;
                ribbonMainForm.SelectedPage = ribbonMainForm.MergedPages[af.DefaultPage.Text];

                UpdateStatus();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			var settings = Settings.Default;
			settings.SkinName = UserLookAndFeel.Default.SkinName;
			settings.Palette = UserLookAndFeel.Default.ActiveSvgPaletteName;
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutMenu(mainMenu, CurrentUser.UserName);
			}
		}
		private void OpenForm<T>(T myForm, bool isDialog = false) where T : Form
		{
			try
			{
				if (!Application.OpenForms.OfType<T>().Any())
				{
					if (!isDialog) myForm.MdiParent = this;

					myForm.Show();
				}
				else
				{
					Application.OpenForms[myForm.Name]?.Focus();
					//myForm.Focus();
				}
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Main OpenForm Error Message!", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}
		private void MainForm_MdiChildActivate(object sender, EventArgs e)
		{
			try
			{
				var af = ActiveMdiChild as IFormWithRibbon;
				if (af == null) return;
				ribbonMainForm.SelectedPage = ribbonMainForm.MergedPages[af.DefaultPage.Text];

				UpdateStatus();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
			}
		}
		private void UpdateStatus()
		{
			//Get HOST NAME
			statusHost.Caption = @"Host: " + CurrentUser.HostName;
			statusDatabase.Caption = @"Database: " + CurrentUser.DatabaseName;
			statusAppName.Caption = @"App: " + HelperApplication.AssemblyDescription;
			statusVersion.Caption = Resources.VERSION + @" " + HelperApplication.AssemblyVersion;

			statusCompanyName.Caption = Resources.COMPANY_NAME + @" " + CurrentUser.CompanyName;
			statusUserName.Caption = Resources.USER_NAME + @" " + CurrentUser.UserName;
			statusDate.Caption = Resources.TODAY + @" " + DateTime.Now.ToLongDateString();
		}

		#region Buttons Event
		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{
			InitializeBindings();
		}

		private void btnResetLayout_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset menu layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutMenu(mainMenu, CurrentUser.UserName);
			}
		}
        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
	        AboutForm frm = new AboutForm();
	        frm.ShowDialog();
        }

		#endregion

		#region MenuButtons
		//
		private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
		{
			ExitAndClean();
		}
		private void btnEnd_ItemClick(object sender, ItemClickEventArgs e)
		{
			Application.Exit();
		}

		#endregion
		
		#region CloseForm
		private void ExitAndClean()
        {
            //main form close
            if (_logOut)
            {
                Settings.Default.ApplicationSkinName = defaultLookAndFeel1.LookAndFeel.SkinName;
                Settings.Default.ApplicationPalette = defaultLookAndFeel1.LookAndFeel.ActiveSvgPaletteName;

                Settings.Default.Save();
                Close();
            }
        }
		
        #endregion

		#region MenuTree Events

		#region Dashboard Menu

		private void mnuQuotations_Click(object sender, EventArgs e)
		{
			OpenForm(new QuotationsListForm());
		}
		private void mnuTotalProfit_Click(object sender, EventArgs e)
		{
			OpenForm(new TotalProfitReportForm(false), true);
		}

		private void mnuJobsStatus_Click(object sender, EventArgs e)
		{
			OpenForm(new JobStatusReportForm(), true);
		}

		private void mnuDetailedProfitReport_Click(object sender, EventArgs e)
		{
			OpenForm(new DetailedProfitReportForm(1), true);
		}

		private void mnuIncomeStatement_Click(object sender, EventArgs e)
		{
			OpenForm(new IncomeStatementReportForm(), true);
		}

		private void mnuEmptyContainersReport_Click(object sender, EventArgs e)
		{
			OpenForm(new EmptyContainerReportForm(), true);
		}

		private void mnuQuotationsJobsList_Click(object sender, EventArgs e)
		{
			OpenForm(new QuotationsJobsReportForm(), true);
		}

		private void mnuAllJobsHistoryListReport_Click(object sender, EventArgs e)
		{
			
		}

		private void mnuJobHistoryReport_Click(object sender, EventArgs e)
		{
			
		}

		#endregion

		#region Job Transaction By Departments Menu
		
		#region Accounting Department Sub Menu

		private void mnuTransactionPaymentsList_Click(object sender, EventArgs e)
		{
			OpenForm(new PaymentsListForm());
		}

		private void mnuTransactionReceiptsList_Click(object sender, EventArgs e)
		{
			OpenForm(new ReceiptsListForm());
		}
		private void mnuTransactionDebitNotesList_Click(object sender, EventArgs e)
		{
			OpenForm(new DebitNotesListForm());
		}
		private void mnuTransactionCreditNotesList_Click(object sender, EventArgs e)
		{
			OpenForm(new CreditNotesListForm());
		}

		private void mnuCommissionsList_Click(object sender, EventArgs e)
		{
			OpenForm(new CommissionsHistoryListForm());
		}

		#endregion
		
		#region Import Department Sub Menu

		//Sea Import
		private void mnuJobsSeaImportList_Click(object sender, EventArgs e)
		{
			OpenForm(new JobSeaImportListForm());
		}
		
		private void mnuJobsAirImport_Click(object sender, EventArgs e)
		{
			OpenForm(new JobAirImportListForm());
		}

		//Sea Export
		private void mnuJobsSeaExport_Click(object sender, EventArgs e)
		{
			OpenForm(new JobSeaExportListForm());
		}

		private void mnuJobsAirExport_Click(object sender, EventArgs e)
		{
			OpenForm(new JobAirExportListForm());
		}

		//Cross Department
		private void mnuJobsSeaCross_Click(object sender, EventArgs e)
		{
			OpenForm(new JobSeaCrossListForm());
		}

		private void mnuJobsAirCross_Click(object sender, EventArgs e)
		{
			OpenForm(new JobAirCrossListForm());
		}

		//Clearance Department
		private void mnuJobsSeaClearance_Click(object sender, EventArgs e)
		{
			OpenForm(new JobSeaClearanceListForm());
		}

		private void mnuJobsAirClearance_Click(object sender, EventArgs e)
		{
			OpenForm(new JobAirClearanceListForm());
		}

		//Land Freight Department
		private void mnuJobsLandFreight_Click(object sender, EventArgs e)
		{

		}

		//Tejrim Department
		private void mnuTejrimJobs_Click(object sender, EventArgs e)
		{
			OpenForm(new TejrimJobsListForm());
		}

		private void mnuClosedJobs_Click(object sender, EventArgs e)
		{
			//OpenForm(new ClosedJobsListForm());
		}

		//Warehouse Department
		private void mnuJobsWarehouseList_Click(object sender, EventArgs e)
		{

		}
		#endregion

		#region Reports Menu

		// Clients Reports
		private void mnuClientInvoicesDetailReport_Click(object sender, EventArgs e)
		{
			OpenForm(new ClientsInvoiceReportForm(), true);
		}

		private void mnuInvoicesDetailReport_Click(object sender, EventArgs e)
		{
			OpenForm(new InvoicesDetailedReportForm(), true);
		}

		private void mnuClientsReport_Click(object sender, EventArgs e)
		{
			OpenForm(new ClientsDetailReportForm(), true);
		}

		private void mnuClientSalesReport_Click(object sender, EventArgs e)
		{
			OpenForm(new ClientSalesReportForm(), true);
		}


		// Import Department Reports
		private void mnuToBeLoadedSeaImport_Click(object sender, EventArgs e)
		{
			OpenForm(new ToBeLoadedByDepartmentsReport(16, "Sea Import"), true);
		}

		private void mnuOnWaterSeaimport_Click(object sender, EventArgs e)
		{
			OpenForm(new OnWaterByDepartmentsReportForm(16, "Sea Import"), true);
		}
		private void mnuAirImportStatus_Click(object sender, EventArgs e)
		{
			OpenForm(new AirImportStatusReportForm(), true);
		}

		// Export Department Reports
		private void mnuToBeLoadedSeaExport_Click(object sender, EventArgs e)
		{
			OpenForm(new ToBeLoadedByDepartmentsReport(18, "Sea Export"), true);
		}

		private void mnuExportOnWater_Click(object sender, EventArgs e)
		{
			OpenForm(new OnWaterByDepartmentsReportForm(18, "Sea Export"), true);
		}

		private void mnuAirExportStatus_Click(object sender, EventArgs e)
		{
			OpenForm(new AirExportStatusReportForm(), true);
		}

		// Cross Department Reports
		private void mnuPendingCrossReports_Click(object sender, EventArgs e)
		{

		}

		// Clearance Department Reports
		private void mnuJobClearanceReport_Click(object sender, EventArgs e)
		{
			OpenForm(new ToBeClearedReportForm(), true);
		}

		// 
		private void mnuNegativeReport_Click(object sender, EventArgs e)
		{
			OpenForm(new TotalProfitReportForm(true), true);
		}

		#endregion

		#region Members Menu

		private void mnuCustomersList_Click(object sender, EventArgs e)
		{
			OpenForm(new CustomersListForm());
		}

		private void mnuAgentsList_Click(object sender, EventArgs e)
		{
			OpenForm(new AgentsListForm());
		}

		#endregion

		#endregion

		#region Administration Menu

		#region Countries Menu

		private void mnuCitiesList_Click(object sender, EventArgs e)
		{
			OpenForm(new CitiesListForm());
		}
		private void mnuCountriesList_Click(object sender, EventArgs e)
		{
			OpenForm(new CountriesListForm());
		}

		private void mnuDistrictsList_Click(object sender, EventArgs e)
		{
			OpenForm(new DistrictsListForm());
		}
		private void mnuProvincesList_Click(object sender, EventArgs e)
		{
			OpenForm(new ProvincesListForm());
		}

		private void mnuRegionsList_Click(object sender, EventArgs e)
		{
			OpenForm(new RegionsListForm());
		}

		private void mnuContinentsList_Click(object sender, EventArgs e)
		{
			OpenForm(new ContinentsListForm());
		}

		private void mnuSeaportsList_Click(object sender, EventArgs e)
		{
			OpenForm(new SeaportsListForm());
		}

		private void mnuAirportsList_Click(object sender, EventArgs e)
		{
			OpenForm(new AirportsListForm());
		}

		private void mnuLandFreightPortsList_Click(object sender, EventArgs e)
		{
			OpenForm(new LandFreightPortsListForm());
		}

		#endregion

		#region Types Menu

		private void mnuContainersTypeList_Click(object sender, EventArgs e)
		{
			OpenForm(new ContainersTypeListForm());
		}

		private void mnuWarehousesList_Click(object sender, EventArgs e)
		{

		}

		private void mnuProductTypesList_Click(object sender, EventArgs e)
		{

		}
		private void mnuMembersCategoryList_Click(object sender, EventArgs e)
		{
			OpenForm(new MembersCategoryListForm());
		}

		private void mnuAgentGroupList_Click(object sender, EventArgs e)
		{
			OpenForm(new AgentGroupListForm());
		}
		private void mnuAgentCategoryList_Click(object sender, EventArgs e)
		{
			OpenForm(new AgentsCategoriesListForm());
		}

		#endregion

		#region Items Menu

		private void mnuItemsList_Click(object sender, EventArgs e)
		{
			OpenForm(new ItemsListForm());
		}

		private void mnuRequirementsList_Click(object sender, EventArgs e)
		{
			OpenForm(new RequirementsListForm());
		}

		#endregion

		#region Carriers Menu

		private void mnuSeaCarriers_Click(object sender, EventArgs e)
		{
			OpenForm(new VesselsListForm());
		}
		private void mnuAirLinesList_Click(object sender, EventArgs e)
		{
			OpenForm(new AirlinesListForm());
		}
		private void mnuTrucksList_Click(object sender, EventArgs e)
		{
			OpenForm(new TrucksListForm());
		}

		#endregion

		#endregion

		#region Accounting Menu

		#region Transactions Menu

		private void mnuJournals_Click(object sender, EventArgs e)
		{
			OpenForm(new JournalsListForm());
		}

		private void mnuProvisions_Click(object sender, EventArgs e)
		{
			
		}

		private void mnuInvoicesList_Click(object sender, EventArgs e)
		{
			OpenForm(new InvoicesListForm());
		}

		private void mnuCostsList_Click(object sender, EventArgs e)
		{
			OpenForm(new CostsListForm());
		}

		#endregion

		#region Currencies Menu

		private void mnuCurrenciesList_Click(object sender, EventArgs e)
		{
			OpenForm(new CurrenciesListForm());
		}

		private void mnuExchangeList_Click(object sender, EventArgs e)
		{

		}

		#endregion
		
		#region Charts Menu
		private void mnuChartsList_Click(object sender, EventArgs e)
		{
			OpenForm(new ChartsListForm());
		}

		private void mnuBanksList_Click(object sender, EventArgs e)
		{
			OpenForm(new BanksListForm());
		}

		#endregion

		#region Setup Menu
		private void mnuCalendarYears_Click(object sender, EventArgs e)
		{

		}

		private void mnuJvTypeList_Click(object sender, EventArgs e)
		{

		}

		private void JvTypesSerialsList_Click(object sender, EventArgs e)
		{

		}

		private void mnuPaymentTypesList_Click(object sender, EventArgs e)
		{

		}

		#endregion

		#region Reports Menu

		private void mnuStatementOfAccount_Click(object sender, EventArgs e)
		{
			OpenForm(new StatementOfAccountForm(), true);
		}

		private void mnuTrialBalance_Click(object sender, EventArgs e)
		{
			OpenForm(new TrialBalanceForm(), true);
		}

		private void mnuBalanceSheet_Click(object sender, EventArgs e)
		{
			OpenForm(new BalanceSheetForm(), true);
		}


		private void mnuPrintDop_Click(object sender, EventArgs e)
		{
			OpenForm(new PrintDopReportForm(), true);
		}

		private void mnuPrintSalesCommission_Click(object sender, EventArgs e)
		{
			OpenForm(new PrintSalesCommissionReportForm(), true);
		}

		#endregion

		#endregion

		#region Setup Menu

		#region Users Menu
		private void mnuUsersList_Click(object sender, EventArgs e)
		{
			OpenForm(new UsersListForm());
		}
		private void mnuCommissionsManager_Click(object sender, EventArgs e)
		{
			OpenForm(new CommissionManagerListForm());
		}

		#endregion

		#region Departments Menu

		private void mnuDepartmentsList_Click(object sender, EventArgs e)
		{
			OpenForm(new DepartmentsListForm());
		}

		#endregion

		#region Settings Menu
		private void mnuCompaniesList_Click(object sender, EventArgs e)
		{
			OpenForm(new CompaniesListForm());
		}

		private void mnuGeneralSettings_Click(object sender, EventArgs e)
		{

		}

		private void mnuDatabaseSettings_Click(object sender, EventArgs e)
		{
			ServerConfigurationForm dbForm = new ServerConfigurationForm();
			dbForm.ShowDialog();
		}

		#endregion

		#endregion
		private void mnuPermissionControlsList_Click(object sender, EventArgs e)
		{
			OpenForm(new PermissionControlsListForm());
		}
		#endregion

		#region Right menu settings

		private void mnuPersonalization_Click(object sender, EventArgs e)
		{

		}
		private void mnuAbout_Click(object sender, EventArgs e)
		{
			AboutForm frm = new AboutForm();
			frm.ShowDialog();
		}
		private void tsViewPendingJobs_Toggled(object sender, EventArgs e)
		{
			//Settings.Default.ShowPendingJobs = tsViewPendingJobs.IsOn;
			//Settings.Default.Save();
		}


		#endregion

		private void mnuTejrimJobsList_Click(object sender, EventArgs e)
		{
			OpenForm(new TejrimJobsListForm());
		}

		private void mnuMigrateCharts_Click(object sender, EventArgs e)
		{
			MigrateChartsForm dbForm = new MigrateChartsForm();
			dbForm.ShowDialog();
		}

		private void mnuMigrateJournals_Click(object sender, EventArgs e)
		{
			MigrateJournalsForm dbForm = new MigrateJournalsForm();
			dbForm.ShowDialog();
		}

		private void mnuDailyJournal_Click(object sender, EventArgs e)
		{
			OpenForm(new DailyJournalReportForm(), true);
		}

		private void mnuReportSettings_Click(object sender, EventArgs e)
		{
			//OpenForm(new ReportSettingsListForm(), true);
		}

		private void mnuBalanceGroup_Click(object sender, EventArgs e)
		{
			OpenForm(new BalanceGroupListForm());
		}

		private void mnuBalanceHeaders_Click(object sender, EventArgs e)
		{
			OpenForm(new BalanceHeadersListForm());
		}

		private void mnuBalanceSettings_Click(object sender, EventArgs e)
		{
			OpenForm(new BalanceSheetSettingsListForm());
		}


	}
}