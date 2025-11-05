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
using MISLiveMed.UI.Forms.Common.Forms;
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
using MISLiveMed.UI.Reports.JobStatus;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;
using MISLiveMed.Utils.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
			// OpenForm(new PendingJobsForm());
			//}

			//if (CurrentUserInfoModel.IsAdmin && Settings.Default.ShowPendingJobs)
			//{
			// OpenForm(new PendingJobsForm());
			//}

			// frmMain.Caption = App.Title & " - " & gv_version & " - User name: " & CurrentUserName"
			// - Server: " & IIf(server = ".", "(LocalHost)", server) & " - Database: " & gv_DefaultDatabase
		}

		private void ApplyPermissions()
		{
			// Determine admin rights from MainForm permissions once
			_isAdmin = _userPermission?.FirstOrDefault(x => x.ControlName == "IsAdmin")?.Value ?? false;

			if (_forms == null || _forms.Count ==0) return;

			// Helper: safely collapse group if not active
			Action<DevExpress.XtraBars.Navigation.AccordionControlElement, bool> collapseIfNeeded = (elem, active) =>
			{
				if (!active)
				{
					try { elem.AccordionControl.CollapseAll(); }
					catch
					{
						// ignored
					}
				}
			};
			if (collapseIfNeeded == null) throw new ArgumentNullException(nameof(collapseIfNeeded));

			// Map form name -> action to apply visibility/activation (keys are enum values)
			var map = BuildPermissionMap(collapseIfNeeded);

			foreach (var form in _forms)
			{
				bool isVisible = false;
				bool isActive = false;

				try
				{
					var menuPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, form.Id) ?? new List<UserPermissionModel>();
					isVisible = menuPermission.FirstOrDefault(x => x.ControlName == "IsVisible")?.Value ?? false;
					isActive = menuPermission.FirstOrDefault(x => x.ControlName == "IsActive")?.Value ?? false;
				}
				catch
				{
					// ignore per-form errors
				}

				// Try to parse form name to enum
				if (Enum.TryParse<FormNames>(form.Name, true, out var formEnum))
				{
					if (formEnum == FormNames.UsersMenu)
					{
						// preserve previous behavior: admin gets full UsersMenu via defaults; others controlled by permission
						if (CurrentUser.UserName.ToLower() != "admin")
						{
							mnuUsersMenu.Visible = isVisible;
							if (!isActive) mnuUsersMenu.AccordionControl.CollapseAll();
							mnuUsersMenu.Enabled = isActive;
						}
						continue;
					}

					if (map.TryGetValue(formEnum, out var apply))
					{
						try { apply(isVisible, isActive); } catch { }
					}
				}
				// else: unknown form/menu - ignore
			}
		}

		private Dictionary<FormNames, Action<bool, bool>> BuildPermissionMap(Action<DevExpress.XtraBars.Navigation.AccordionControlElement, bool> collapseIfNeeded)
		{
			return new Dictionary<FormNames, Action<bool, bool>>
			{
				// MAIN MENU LIST
				[FormNames.NavigationMenu] = (v, a) => { mnuNavigationMenu.Visible = v; mnuNavigationMenu.Enabled = a; },
				[FormNames.MainAdministrationMenu] = (v, a) => { mnuMainAdministrationMenu.Visible = v; mnuMainAdministrationMenu.Enabled = a; },
				[FormNames.MainAccountingMenu] = (v, a) => { mnuMainAccountingMenu.Visible = v; mnuMainAccountingMenu.Enabled = a; },
				[FormNames.SetupMenu] = (v, a) => { mnuSetupMenu.Visible = v; mnuSetupMenu.Enabled = a; },

				// Dashboard Department
				[FormNames.Dashboard] = (v, a) => { mnuDashboard.Visible = v; collapseIfNeeded(mnuDashboard, a); mnuDashboard.Enabled = a; },
				[FormNames.QuotationsList] = (v, a) => { mnuQuotationsList.Visible = v; mnuQuotationsList.Enabled = a; },
				[FormNames.TotalProfitReport] = (v, a) => { mnuTotalProfitReport.Visible = v; mnuTotalProfitReport.Enabled = a; },
				[FormNames.JobStatusReport] = (v, a) => { mnuJobStatusReport.Visible = v; mnuJobStatusReport.Enabled = a; },
				[FormNames.DetailedProfitReport] = (v, a) => { mnuDetailedProfitReport.Visible = v; mnuDetailedProfitReport.Enabled = a; },
				[FormNames.EmptyContainersReport] = (v, a) => { mnuEmptyContainersReport.Visible = v; mnuEmptyContainersReport.Enabled = a; },
				[FormNames.QuotationsJobsReport] = (v, a) => { mnuQuotationsJobsReport.Visible = v; mnuQuotationsJobsReport.Enabled = a; },

				// Group Departments
				[FormNames.GroupDepartments] = (v, a) => { mnuGroupDepartments.Visible = v; collapseIfNeeded(mnuGroupDepartments, a); mnuGroupDepartments.Enabled = a; },
				[FormNames.AccountingDepartment] = (v, a) => { mnuAccountingDepartment.Visible = v; mnuAccountingDepartment.Enabled = a; },
				[FormNames.PaymentsList] = (v, a) => { mnuTransactionPaymentsList.Visible = v; mnuTransactionPaymentsList.Enabled = a; },
				[FormNames.ReceiptsList] = (v, a) => { mnuTransactionReceiptsList.Visible = v; mnuTransactionReceiptsList.Enabled = a; },
				[FormNames.DebitNotesList] = (v, a) => { mnuTransactionDebitNotesList.Visible = v; mnuTransactionDebitNotesList.Enabled = a; },
				[FormNames.CreditNotesList] = (v, a) => { mnuTransactionCreditNotesList.Visible = v; mnuTransactionCreditNotesList.Enabled = a; },
				[FormNames.CommissionsHistoryList] = (v, a) => { mnuCommissionsList.Visible = v; mnuCommissionsList.Enabled = a; },
				[FormNames.ImportDepartmentMenu] = (v, a) => { mnuImportDepartmentMenu.Visible = v; mnuImportDepartmentMenu.Enabled = a; },
				[FormNames.JobSeaImportList] = (v, a) => { mnuJobsSeaImportList.Visible = v; mnuJobsSeaImportList.Enabled = a; },
				[FormNames.JobAirImportList] = (v, a) => { mnuJobsAirImportList.Visible = v; mnuJobsAirImportList.Enabled = a; },
				[FormNames.ExportDepartmentMenu] = (v, a) => { mnuExportDepartmentMenu.Visible = v; mnuExportDepartmentMenu.Enabled = a; },
				[FormNames.JobSeaExportList] = (v, a) => { mnuJobsSeaExportList.Visible = v; mnuJobsSeaExportList.Enabled = a; },
				[FormNames.JobAirExportList] = (v, a) => { mnuJobsAirExportList.Visible = v; mnuJobsAirExportList.Enabled = a; },
				[FormNames.CrossDepartment] = (v, a) => { mnuCrossDepartment.Visible = v; mnuCrossDepartment.Enabled = a; },
				[FormNames.JobSeaCrossList] = (v, a) => { mnuJobsSeaCrossList.Visible = v; mnuJobsSeaCrossList.Enabled = a; },
				[FormNames.JobAirCrossList] = (v, a) => { mnuJobsAirCrossList.Visible = v; mnuJobsAirCrossList.Enabled = a; },
				[FormNames.ClearanceDepartment] = (v, a) => { mnuClearanceDepartment.Visible = v; mnuClearanceDepartment.Enabled = a; },
				[FormNames.JobSeaClearanceList] = (v, a) => { mnuJobsSeaClearanceList.Visible = v; mnuJobsSeaClearanceList.Enabled = a; },
				[FormNames.JobAirClearanceList] = (v, a) => { mnuJobsAirClearanceList.Visible = v; mnuJobsAirClearanceList.Enabled = a; },
				[FormNames.LandFreightDepartment] = (v, a) => { mnuLandFreightDepartment.Visible = v; mnuLandFreightDepartment.Enabled = a; },
				[FormNames.JobsLandFreight] = (v, a) => { mnuJobsLandFreightList.Visible = v; mnuJobsLandFreightList.Enabled = a; },
				[FormNames.TejrimDepartment] = (v, a) => { mnuTejrimDepartment.Visible = v; mnuTejrimDepartment.Enabled = a; },
				[FormNames.TejrimJobsList] = (v, a) => { mnuTejrimJobsList.Visible = v; mnuTejrimJobsList.Enabled = a; },
				[FormNames.ClosedJobsList] = (v, a) => { mnuClosedJobsList.Visible = v; mnuClosedJobsList.Enabled = a; },
				[FormNames.WarehouseDepartment] = (v, a) => { mnuWarehouseDepartment.Visible = v; mnuWarehouseDepartment.Enabled = a; },
				[FormNames.JobsWarehouseList] = (v, a) => { mnuJobsWarehouseList.Visible = v; mnuJobsWarehouseList.Enabled = a; },

				// Group Reports
				[FormNames.GroupReports] = (v, a) => { mnuGroupReports.Visible = v; collapseIfNeeded(mnuGroupReports, a); mnuGroupReports.Enabled = a; },
				[FormNames.ClientsReportsGroup] = (v, a) => { mnuClientsReportsGroup.Visible = v; mnuClientsReportsGroup.Enabled = a; },
				[FormNames.ClientInvoicesDetailReport] = (v, a) => { mnuClientInvoicesDetailReport.Visible = v; mnuClientInvoicesDetailReport.Enabled = a; },
				[FormNames.InvoicesDetailReport] = (v, a) => { mnuInvoicesDetailReport.Visible = v; mnuInvoicesDetailReport.Enabled = a; },
				[FormNames.ClientsReport] = (v, a) => { mnuClientsReport.Visible = v; mnuClientsReport.Enabled = a; },
				[FormNames.ClientSalesReport] = (v, a) => { mnuClientSalesReport.Visible = v; mnuClientSalesReport.Enabled = a; },
				[FormNames.ImportDepartmentReports] = (v, a) => { mnuImportDepartmentReports.Visible = v; mnuImportDepartmentReports.Enabled = a; },
				[FormNames.ToBeLoadedSeaImport] = (v, a) => { mnuToBeLoadedSeaImport.Visible = v; mnuToBeLoadedSeaImport.Enabled = a; },
				[FormNames.OnWaterSeaImport] = (v, a) => { mnuOnWaterSeaimport.Visible = v; mnuOnWaterSeaimport.Enabled = a; },
				[FormNames.AirImportStatusReport] = (v, a) => { mnuAirImportStatus.Visible = v; mnuAirImportStatus.Enabled = a; },
				[FormNames.ExportDepartmentReports] = (v, a) => { mnuExportDepartmentReports.Visible = v; mnuExportDepartmentReports.Enabled = a; },
				[FormNames.ToBeLoadedSeaExport] = (v, a) => { mnuToBeLoadedSeaExport.Visible = v; mnuToBeLoadedSeaExport.Enabled = a; },
				[FormNames.OnWaterSeaExport] = (v, a) => { mnuExportOnWater.Visible = v; mnuExportOnWater.Enabled = a; },
				[FormNames.AirExportStatusReport] = (v, a) => { mnuAirExportStatus.Visible = v; mnuAirExportStatus.Enabled = a; },
				[FormNames.CrossDepartmentReports] = (v, a) => { mnuCrossDepartmentReports.Visible = v; mnuCrossDepartmentReports.Enabled = a; },
				[FormNames.PendingCrossReports] = (v, a) => { mnuPendingCrossReports.Visible = v; mnuPendingCrossReports.Enabled = a; },
				[FormNames.ClearanceDepartmentReports] = (v, a) => { mnuClearanceDepartmentReports.Visible = v; mnuClearanceDepartmentReports.Enabled = a; },
				[FormNames.JobClearanceReport] = (v, a) => { mnuJobClearanceReport.Visible = v; mnuJobClearanceReport.Enabled = a; },
				[FormNames.NegativeReport] = (v, a) => { mnuNegativeReport.Visible = v; mnuNegativeReport.Enabled = a; },

				// CRM AND Members
				[FormNames.MembersMenu] = (v, a) => { mnuMembers.Visible = v; collapseIfNeeded(mnuMembers, a); mnuMembers.Enabled = a; },
				[FormNames.CustomersList] = (v, a) => { mnuCustomersList.Visible = v; mnuCustomersList.Enabled = a; },
				[FormNames.AgentsList] = (v, a) => { mnuAgentsList.Visible = v; mnuAgentsList.Enabled = a; },

				// Administration Menu
				[FormNames.Administration] = (v, a) => { mnuAdministration.Visible = v; collapseIfNeeded(mnuAdministration, a); mnuAdministration.Enabled = a; },
				[FormNames.CountriesGroup] = (v, a) => { mnuCountriesGroup.Visible = v; collapseIfNeeded(mnuCountriesGroup, a); mnuCountriesGroup.Enabled = a; },
				[FormNames.CitiesList] = (v, a) => { mnuCitiesList.Visible = v; mnuCitiesList.Enabled = a; },
				[FormNames.CountriesList] = (v, a) => { mnuCountriesList.Visible = v; mnuCountriesList.Enabled = a; },
				[FormNames.DistrictsList] = (v, a) => { mnuDistrictsList.Visible = v; mnuDistrictsList.Enabled = a; },
				[FormNames.ProvincesList] = (v, a) => { mnuProvincesList.Visible = v; mnuProvincesList.Enabled = a; },
				[FormNames.RegionsList] = (v, a) => { mnuRegionsList.Visible = v; mnuRegionsList.Enabled = a; },
				[FormNames.ContinentsList] = (v, a) => { mnuContinentsList.Visible = v; mnuContinentsList.Enabled = a; },
				[FormNames.SeaportsList] = (v, a) => { mnuSeaportsList.Visible = v; mnuSeaportsList.Enabled = a; },
				[FormNames.AirportsList] = (v, a) => { mnuAirportsList.Visible = v; mnuAirportsList.Enabled = a; },
				[FormNames.LandFreightPortsList] = (v, a) => { mnuLandFreightPortsList.Visible = v; mnuLandFreightPortsList.Enabled = a; },

				// Types Menu
				[FormNames.TypesMenu] = (v, a) => { mnuTypesMenu.Visible = v; collapseIfNeeded(mnuTypesMenu, a); mnuTypesMenu.Enabled = a; },
				[FormNames.ContainersTypeList] = (v, a) => { mnuContainersTypeList.Visible = v; mnuContainersTypeList.Enabled = a; },
				[FormNames.WarehousesList] = (v, a) => { mnuWarehousesList.Visible = v; mnuWarehousesList.Enabled = a; },
				[FormNames.ProductTypesList] = (v, a) => { mnuProductTypesList.Visible = v; mnuProductTypesList.Enabled = a; },
				[FormNames.MembersCategoryList] = (v, a) => { mnuMembersCategoryList.Visible = v; mnuMembersCategoryList.Enabled = a; },
				[FormNames.AgentGroupList] = (v, a) => { mnuAgentGroupList.Visible = v; mnuAgentGroupList.Enabled = a; },
				[FormNames.AgentCategoryList] = (v, a) => { mnuAgentCategoryList.Visible = v; mnuAgentCategoryList.Enabled = a; },

				// Items Menu
				[FormNames.ItemsListMenu] = (v, a) => { mnuItemsMenu.Visible = v; collapseIfNeeded(mnuItemsMenu, a); mnuItemsMenu.Enabled = a; },
				[FormNames.ItemsList] = (v, a) => { mnuItemsList.Visible = v; mnuItemsList.Enabled = a; },
				[FormNames.RequirementsList] = (v, a) => { mnuRequirementsList.Visible = v; mnuRequirementsList.Enabled = a; },

				// Carriers Menu
				[FormNames.CarriersMenu] = (v, a) => { mnuCarriersMenu.Visible = v; collapseIfNeeded(mnuCarriersMenu, a); mnuCarriersMenu.Enabled = a; },
				[FormNames.SeaCarriersList] = (v, a) => { mnuSeaCarriersList.Visible = v; mnuSeaCarriersList.Enabled = a; },
				[FormNames.AirLinesList] = (v, a) => { mnuAirLinesList.Visible = v; mnuAirLinesList.Enabled = a; },
				[FormNames.TrucksList] = (v, a) => { mnuTrucksList.Visible = v; mnuTrucksList.Enabled = a; },

				// Main Accounting
				[FormNames.AccountingMenu] = (v, a) => { mnuAccounting.Visible = v; collapseIfNeeded(mnuAccounting, a); mnuAccounting.Enabled = a; },
				[FormNames.TransactionsMenu] = (v, a) => { mnuTransactions.Visible = v; collapseIfNeeded(mnuTransactions, a); mnuTransactions.Enabled = a; },
				[FormNames.JournalsMenu] = (v, a) => { mnuJournals.Visible = v; mnuJournals.Enabled = a; },
				[FormNames.ListOfInvoicesMenu] = (v, a) => { mnuListOfInvoices.Visible = v; mnuListOfInvoices.Enabled = a; },
				[FormNames.ListOfCostsMenu] = (v, a) => { mnuListOfCosts.Visible = v; mnuListOfCosts.Enabled = a; },
				[FormNames.CurrenciesMenu] = (v, a) => { mnuCurrenciesMenu.Visible = v; collapseIfNeeded(mnuCurrenciesMenu, a); mnuCurrenciesMenu.Enabled = a; },
				[FormNames.CurrenciesList] = (v, a) => { mnuCurrenciesList.Visible = v; mnuCurrenciesList.Enabled = a; },
				[FormNames.ExchangeList] = (v, a) => { mnuExchangeList.Visible = v; mnuExchangeList.Enabled = a; },
				[FormNames.ChartOfAccounts] = (v, a) => { mnuChartOfAccounts.Visible = v; collapseIfNeeded(mnuChartOfAccounts, a); mnuChartOfAccounts.Enabled = a; },
				[FormNames.ChartsList] = (v, a) => { mnuChartsList.Visible = v; mnuChartsList.Enabled = a; },
				[FormNames.BanksList] = (v, a) => { mnuBanksList.Visible = v; mnuBanksList.Enabled = a; },
				[FormNames.AccountingSetupMenu] = (v, a) => { mnuAccountingSetup.Visible = v; collapseIfNeeded(mnuAccountingSetup, a); mnuAccountingSetup.Enabled = a; },
				[FormNames.CalendarYearsMenu] = (v, a) => { mnuCalendarYears.Visible = v; mnuCalendarYears.Enabled = a; },
				[FormNames.JvTypeList] = (v, a) => { mnuJvTypeList.Visible = v; mnuJvTypeList.Enabled = a; },
				[FormNames.JvTypesSerialsList] = (v, a) => { JvTypesSerialsList.Visible = v; JvTypesSerialsList.Enabled = a; },
				[FormNames.PaymentTypesList] = (v, a) => { mnuPaymentTypesList.Visible = v; mnuPaymentTypesList.Enabled = a; },

				// Reports Menu
				[FormNames.ReportsMenu] = (v, a) => { mnuReportsMenu.Visible = v; collapseIfNeeded(mnuReportsMenu, a); mnuReportsMenu.Enabled = a; },
				[FormNames.StatementOfAccount] = (v, a) => { mnuStatementOfAccount.Visible = v; mnuStatementOfAccount.Enabled = a; },
				[FormNames.TrialBalance] = (v, a) => { mnuTrialBalance.Visible = v; mnuTrialBalance.Enabled = a; },
				[FormNames.PrintDopReport] = (v, a) => { mnuPrintDop.Visible = v; mnuPrintDop.Enabled = a; },
				[FormNames.PrintSalesCommission] = (v, a) => { mnuPrintSalesCommission.Visible = v; mnuPrintSalesCommission.Enabled = a; },
				[FormNames.BalanceSheet] = (v, a) => { mnuBalanceSheet.Visible = v; mnuBalanceSheet.Enabled = a; },
				[FormNames.DailyJournal] = (v, a) => { mnuDailyJournal.Visible = v; mnuDailyJournal.Enabled = a; },
				[FormNames.BalanceGroup] = (v, a) => { mnuBalanceGroup.Visible = v; mnuBalanceGroup.Enabled = a; },
				[FormNames.BalanceHeaders] = (v, a) => { mnuBalanceHeaders.Visible = v; mnuBalanceHeaders.Enabled = a; },
				[FormNames.BalanceSettings] = (v, a) => { mnuBalanceSettings.Visible = v; mnuBalanceSettings.Enabled = a; },

				// Setup Menu
				[FormNames.UsersMenu] = (v, a) => { /* special-cased below */ },
				[FormNames.UsersList] = (v, a) => { mnuUsersList.Visible = v; mnuUsersList.Enabled = a; },
				[FormNames.CompaniesList] = (v, a) => { mnuCompaniesList.Visible = v; mnuCompaniesList.Enabled = a; },
				[FormNames.DepartmentsMenu] = (v, a) => { mnuDepartmentsMenu.Visible = v; collapseIfNeeded(mnuDepartmentsMenu, a); mnuDepartmentsMenu.Enabled = a; },
				[FormNames.DepartmentsList] = (v, a) => { mnuDepartmentsList.Visible = v; mnuDepartmentsList.Enabled = a; },
				[FormNames.SettingsMenu] = (v, a) => { mnuSettings.Visible = v; collapseIfNeeded(mnuSettings, a); mnuSettings.Enabled = a; },
				[FormNames.PermissionControlsList] = (v, a) => { mnuPermissionControlsList.Visible = v; mnuPermissionControlsList.Enabled = a; },
				[FormNames.CommissionsManager] = (v, a) => { mnuCommissionsManager.Visible = v; mnuCommissionsManager.Enabled = a; },
				[FormNames.GeneralSettings] = (v, a) => { mnuGeneralSettings.Visible = v; mnuGeneralSettings.Enabled = a; },
				[FormNames.DatabaseSettings] = (v, a) => { mnuDatabaseSettings.Visible = _isAdmin && v; mnuDatabaseSettings.Enabled = _isAdmin && a; },
				[FormNames.ReportGroupSettings] = (v, a) => { mnuReportGroupSettings.Visible = v; mnuReportGroupSettings.Enabled = a; },
				[FormNames.ReportSettings] = (v, a) => { mnuReportSettings.Visible = v; mnuReportSettings.Enabled = a; },

				// Migrations
				[FormNames.Migrations] = (v, a) => { mnuMigrations.Visible = v; mnuMigrations.Enabled = a; },
				[FormNames.MigrateCharts] = (v, a) => { mnuMigrateCharts.Visible = v; mnuMigrateCharts.Enabled = a; },
				[FormNames.MigrateJournals] = (v, a) => { mnuMigrateJournals.Visible = v; mnuMigrateJournals.Enabled = a; },

				// Chart odd duplicate (designer has both mnuChartofAccount and mnuChartOfAccounts)
				[FormNames.ChartofAccount] = (v, a) => { try { mnuChartofAccount.Visible = v; mnuChartofAccount.Enabled = a; } catch { } },
				[FormNames.ChartOfAccounts] = (v, a) => { try { mnuChartOfAccounts.Visible = v; collapseIfNeeded(mnuChartOfAccounts, a); mnuChartOfAccounts.Enabled = a; } catch { } },
			};
		}

		// Known alternate DB names mapping to enum values (case-insensitive)
		private static readonly Dictionary<string, FormNames> _formNameMappings = new Dictionary<string, FormNames>(StringComparer.OrdinalIgnoreCase)
		{
			// common variants / legacy names
			["Chart of Accounts"] = FormNames.ChartOfAccounts,
			["ChartofAccount"] = FormNames.ChartofAccount,
			["Users Menu"] = FormNames.UsersMenu,
			["Users List"] = FormNames.UsersList,
			["Companies List"] = FormNames.CompaniesList,
			["Quotations List"] = FormNames.QuotationsList,
			["Job Sea Import List"] = FormNames.JobSeaImportList,
			["Job Air Import List"] = FormNames.JobAirImportList,
			["Job Sea Export List"] = FormNames.JobSeaExportList,
			["Job Air Export List"] = FormNames.JobAirExportList,
			// add more mappings here as needed
		};

		// Try to map a DB form name to the FormNames enum, supporting normalization and legacy mappings
		private static bool TryMapFormName(string dbName, out FormNames formEnum)
		{
			formEnum = default;
			if (string.IsNullOrWhiteSpace(dbName)) return false;

			//1) direct parse (case-insensitive)
			if (Enum.TryParse<FormNames>(dbName, true, out formEnum)) return true;

			//2) normalization: remove spaces, underscores, hyphens and try parse again
			var normalized = new string(dbName.Where(c => c != ' ' && c != '_' && c != '-').ToArray());
			if (Enum.TryParse<FormNames>(normalized, true, out formEnum)) return true;

			//3) explicit legacy mappings
			if (_formNameMappings.TryGetValue(dbName.Trim(), out formEnum)) return true;

			//4) try normalized key lookup in mappings
			if (_formNameMappings.TryGetValue(normalized, out formEnum)) return true;

			return false;
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

		private void mnuForms_Click(object sender, EventArgs e)
		{
			OpenForm(new FormsList());
		}

		private void mnuFormsCategories_Click(object sender, EventArgs e)
		{

		}
	}
}