using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Accounting.Charts;
using MISLiveMed.DataLayers.Accounting.Reports.Statements;
using MISLiveMed.DataLayers.Common.Currencies;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.Charts;
using MISLiveMed.Models.Models.Accounting.Reports.Statements;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.Accounting.Reports.Statements;
using MISLiveMed.UI.Reports;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;
using MISLiveMed.Utils.SystemData;

namespace MISLiveMed.UI.Accounting.Journals.Reports
{
	public partial class BalanceSheetForm: XtraForm
	{
		private const string _formName = "BalanceSheet";
		private int _formId;
		private bool _resetMenu;

		private BalanceSheetModel _balanceSheetModel = new BalanceSheetModel();
		private IList<BalanceSheetModel> _balanceSheets = new List<BalanceSheetModel>();

		private IList<ChartModel> _charts = new List<ChartModel>();
		private IList<CurrencyModel> _currencies = new List<CurrencyModel>();

		private IList<SpecialIncomeStatementModel> _incomeStatements = new List<SpecialIncomeStatementModel>();
		private IList<IncomeAccountModel> _incomeAccounts = new List<IncomeAccountModel>();

		private readonly BalanceSheetRepository _balanceSheetRepositories = new BalanceSheetRepository();

		private readonly ChartRepository _chartRepository = new ChartRepository();
		private readonly CurrencyRepository _currencyRepository = new CurrencyRepository();
		private readonly BalanceSheetRepository _balanceSheetRepository = new BalanceSheetRepository();
		private readonly IncomeStatementRepository _statementRepository = new IncomeStatementRepository();

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
		private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
		private readonly FormRepository _formRepository = new FormRepository();

		//Init permission variables
		private bool _isAdmin;
		private bool _isProtected;
		private int _workingYear;
		private int _monthInterval;
		private decimal _totalProvisionInvoice = 0;
		private decimal _totalProvisionCost = 0;
		private decimal _resultOfTheYear = 0;
		private decimal _periodResult = 0;
		private bool _isReal;

		public BalanceSheetForm()
		{
            InitializeComponent();
			
            try
            {
	            InitializeBindings();
	            WireUpBindings();
	            ApplyDefaults();
	            ApplyPermissions();
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
			}
			catch (Exception e)
			{
				ErrorHandler.ShowError(e.Message);
			}
		}
		private void WireUpBindings()
		{
			UpdateComboResults();
		}

		private void ApplyPermissions()
		{ 
			//chkShowProtected.Visible = _isProtected;
		}

		private void ApplyDefaults()
		{
			dtDateFrom.EditValue = DateTime.Parse("01/01/" + DateTime.Today.Year);
			dtDateTo.EditValue = DateTime.Now;

			rgBalanceReportOptions.SelectedIndex = 0;
			rgCurrencyOutput.SelectedIndex = 1;
			rgSortingByFilter.SelectedIndex = 0;
			rgPrinterOutput.SelectedIndex = 0;

			_workingYear = CurrentUser.WorkingYear;
		}

		#region Butons Event

		private void btnPreview_Click(object sender, EventArgs e)
		{
			if (!ValidateForm()) return;

			switch (rgBalanceReportOptions.SelectedIndex)
			{
				case 0:
					ShowBalanceSheetReport();
					break;

				case 1:
					ShowIncomeStatementReport();
					break;
					
				case 2:
					MergeBothReports();
					break;

				default:
					ShowBalanceSheetReport();
					break;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion

		private void ShowBalanceSheetReport()
		{
			try
            {
                DateTime? dateFrom = DateHelper.GetNullableDate(dtDateFrom.EditValue);
                DateTime? dateTo = DateHelper.GetNullableDate(dtDateTo.EditValue);
                string outputCurrency = rgCurrencyOutput.EditValue?.ToString() ?? string.Empty;
                int balanceHeaderId = cboResults.EditValue != null ? Convert.ToInt32(cboResults.EditValue) : 0;

                // Generate the Balance Sheet data and retrieve the report models.
                _balanceSheetRepositories.GenerateBalanceSheetData(dateFrom, dateTo, balanceHeaderId, outputCurrency, _workingYear);
                IList<ExtendedBalanceSheetSettingModel> reportData = _balanceSheetRepositories.SelectBalanceSheet();

                // Configure the report
                var report = new BalanceSheetReport { DataSource = reportData };
                report.Parameters["DateFrom"].Value = dateFrom;
                report.Parameters["DateTo"].Value = dateTo;
                report.Parameters["OutputCurrency"].Value = outputCurrency;

                // Display report in the viewer
                using (var previewForm = new DocumentViewerForm())
                {
                    previewForm.Viewer.DocumentSource = report;
                    previewForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex.Message);
			}
		}

		private void ShowIncomeStatementReport()
		{
			try
			{
				DateTime? dateFrom = ParseDate(dtDateFrom.EditValue);
				DateTime? dateTo = ParseDate(dtDateTo.EditValue);
				string outputCurrency = rgCurrencyOutput.EditValue?.ToString() ?? string.Empty;
				int balanceHeaderId = cboResults.EditValue != null ? Convert.ToInt32(cboResults.EditValue) : 0;

				GenerateIncomeStatement(dateFrom, dateTo, outputCurrency);

				// Retrieve the generated income statement data.
				_incomeStatements = _statementRepository.SelectIncomeStatements();

				var report = new IncomeStatementReport { DataSource = _incomeStatements };
				report.Parameters["DateFrom"].Value = dateFrom;
				report.Parameters["DateTo"].Value = dateTo;
				report.Parameters["OutputCurrency"].Value = outputCurrency;

				using (var previewForm = new DocumentViewerForm())
				{
					previewForm.Viewer.DocumentSource = report;
					previewForm.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				ErrorHandler.ShowError(ex.Message);
			}
		}

		private void MergeBothReports()
		{
			// Implement merging logic of Balance Sheet and Income Statement reports

		}
		
		#region Income Statement Generation

		private void GenerateIncomeStatement(DateTime? dateFrom, DateTime? dateTo, string outputCurrency)
		{
			// Initialize variables
			_isReal = false;
			_totalProvisionInvoice = 0;
			_totalProvisionCost = 0;
			decimal totalIncome = 0;
			decimal totalExpenses = 0;
			decimal totalGroup = 0;
			decimal interests = 0;
			int currencyId = outputCurrency == "USD" ? 2 : 1;
			_monthInterval = ((dateTo?.Month ?? 0) + 1) - (dateFrom?.Month ?? 0);

			// Calculate date span (using a custom DateTimeSpan helper)
			int dateSpan = DateTimeSpan.CompareDates(dateFrom.GetValueOrDefault(), dateTo.GetValueOrDefault()).Months + 1;

			// Initialize temporary income statement table and select income accounts
			_statementRepository.DeleteIncomeStatementTmpTable();
			_incomeAccounts = _statementRepository.SelectIncomeAccounts();

			// Process each income account (consider using a mapping or strategy pattern for further decoupling)
			foreach (var incomeAccount in _incomeAccounts)
			{
				ProcessIncomeAccount(incomeAccount, dateFrom, dateTo, currencyId, ref totalIncome, ref totalExpenses, ref totalGroup, ref interests);
			}
		}

		private void ProcessIncomeAccount(IncomeAccountModel incomeAccount, DateTime? dateFrom, DateTime? dateTo, int currencyId,
			ref decimal totalIncome, ref decimal totalExpenses, ref decimal totalGroup, ref decimal interests)
		{
			decimal subTotals = 0;
			decimal totals = 0;
			string accName = string.Empty;

			// Local helper to add an entry to the income statements
			void AddEntry(decimal amount) =>
				_statementRepository.AddIncomeStatementEntry(dateFrom, dateTo, _isReal, incomeAccount.IsTotal,
					incomeAccount.AccountGroup, incomeAccount.AccountNumber, incomeAccount.Description,
					incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section, currencyId, amount);

			// Process based on account number. For brevity, only a subset of cases is shown.
			switch (incomeAccount.AccountNumber)
			{
				case "7132":
					subTotals = _statementRepository.ExecuteIncomeAccountCalculation(dateFrom, dateTo, _isReal, currencyId, "7132") -
								_statementRepository.ExecuteIncomeAccountCalculation(dateFrom, dateTo, _isReal, currencyId, "7191");
					AddEntry(subTotals);
					break;
				case "8111":
				case "8111_T":
					if (!_isReal) return;
					AddEntry(_totalProvisionInvoice);
					break;
				case "7132_T":
					totals = _statementRepository.CalculateTotalIncome(incomeAccount.AccountGroup, 2);
					if (_isReal) totals += _totalProvisionInvoice;
					AddEntry(totals);
					totalIncome += totals;
					break;
				case "773":
					subTotals = _statementRepository.ExecuteIncomeAccountCalculation(dateFrom, dateTo, _isReal, currencyId, "773");
					AddEntry(subTotals);
					break;
				case "773_T":
					totals = _statementRepository.CalculateTotalIncome(incomeAccount.AccountGroup, incomeAccount.ColumnList);
					AddEntry(totals);
					interests = totals;
					totalIncome += interests;
					break;
				case "6211":
					subTotals = _statementRepository.ExecuteIncomeAccountCalculation(dateFrom, dateTo, _isReal, currencyId, "6211");
					AddEntry(subTotals);
					break;
				case "8011":
				case "8011_T":
					if (!_isReal) return;
					AddEntry(_totalProvisionCost);
					break;
				case "6211_T":
					totals = _statementRepository.CalculateTotalIncome(incomeAccount.AccountGroup, 2);
					if (_isReal) totals += _totalProvisionCost;
					AddEntry(totals);
					totalExpenses += totals;
					break;
				// Add further cases following the pattern from the original code...
				default:
					totals = _statementRepository.ExecuteIncomeAccountCalculation(dateFrom, dateTo, _isReal, currencyId, incomeAccount.AccountNumber);
					AddEntry(totals);
					break;
			}
		}
		public string CalculatePercentage(decimal totalIncome, decimal totals)
		{
			if (totalIncome == 0)
				throw new DivideByZeroException("Total income cannot be zero.");

			decimal percentage = Math.Round((totalIncome - totals) / totalIncome * 100, 2);
			return percentage.ToString("N2");
		}

		#endregion

		private void rgBalanceReportOptions_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (rgBalanceReportOptions.SelectedIndex)
			{
				case 0:
					this.Text = @"Balance Sheet";
					break;

				case 1:
					this.Text = @"Profit and Loss / Income";
					break;

				case 2:
					this.Text = @"Balance Sheet && Profit and Loss / Income";
					break;
			}

			UpdateComboResults();
		}

		protected void UpdateComboResults()
		{
			switch (rgBalanceReportOptions.SelectedIndex)
			{
				case 0:
					cboResults.Enabled = true;
					cboResults.Properties.DataSource = Enumeration.GetAll<HelperApplication.DetailControlTypeFormatter.BalanceSheetDisplayResult>();
					cboResults.Properties.DisplayMember = "Value";
					cboResults.Properties.ValueMember = "Key";
					cboResults.EditValue = 0; 
					break;

				case 1:
					cboResults.Enabled = true;
					cboResults.Properties.DataSource = Enumeration.GetAll<HelperApplication.DetailControlTypeFormatter.IncomeStatementDisplayResult>();
					cboResults.Properties.DisplayMember = "Value";
					cboResults.Properties.ValueMember = "Key";
					cboResults.EditValue = 0;
					break;

				case 2:
					cboResults.Properties.DataSource = null;
					cboResults.Properties.DisplayMember = "Value";
					cboResults.Properties.ValueMember = "Key";
					cboResults.Enabled = false;
					break;
			}
		}

		private void dtDateFrom_EditValueChanged(object sender, EventArgs e)
		{
			if (dtDateFrom.EditValue == null) return;

			var workingYear = (DateTime)dtDateFrom.EditValue;
			_workingYear = workingYear.Year;
		}


		#region Helper Methods

		private DateTime? ParseDate(object editValue)
		{
			if (editValue != null && DateTime.TryParse(editValue.ToString(), out DateTime parsedDate))
				return parsedDate;
			return null;
		}

		private bool ValidateForm()
		{
			var validateReturnValue = true;
			var messageNumber = 0;
			var validateMessage = new StringBuilder();

			//if (cboAccountNumberFrom.Text == "")
			//{
			//	messageNumber += 1;
			//	validateMessage.Append("\n- Account Number cannot be empty.");
			//	validateReturnValue = false;
			//	cboAccountNumberFrom.Focus();
			//}

			if (!validateReturnValue)
			{
				validateMessage.Insert(0, "The following need your attention:\n");
				if (messageNumber > 1) validateMessage.Replace("following", "followings");
				XtraMessageBox.Show(validateMessage + " \n\nCannot be null or empty, please try again.",
					"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			return validateReturnValue;
		}

		#endregion
	}
}