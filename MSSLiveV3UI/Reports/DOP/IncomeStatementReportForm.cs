using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using MISLiveMed.DataLayers.Accounting.Reports.Statements;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.Reports.Statements;
using MISLiveMed.Models.Models.Common;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.Accounting.Reports.Statements;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;
using MISLiveMed.Utils.SystemData;
using Exception = System.Exception;

namespace MISLiveMed.UI.Reports.DOP
{
    public partial class IncomeStatementReportForm : XtraForm
	{
		private const string _formName = "IncomeStatementReport";
		private const string _filterName = "IncomeStatementReportForm";
		private int _formId;

		private IList<SpecialIncomeStatementModel> _incomeStatements = new List<SpecialIncomeStatementModel>();
        private IList<IncomeAccountModel> _incomeAccounts = new List<IncomeAccountModel>();
        private IList<DetailedIncomeStatementModel> _detailedIncomeStatement = new List<DetailedIncomeStatementModel>();
        private readonly List<InitDataObjectModel> _initDataObjectModelList = new List<InitDataObjectModel>();
        private readonly IncomeStatementRepository _statementRepository = new IncomeStatementRepository();

        /// <summary>
        /// User Permission Role
        /// </summary>
        private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
        private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
        private readonly FormRepository _formRepository = new FormRepository();

        private bool _canAccessProfit;
		private bool _isAdmin;
		private bool _isProtected;

		private decimal _totalProvisionInvoice = 0;
        private decimal _totalProvisionCost = 0;

        private decimal _totalRealProvisionInvoice = 0;
        private decimal _totalRealProvisionCost = 0;

        private decimal _resultOfTheYear = 0;
        private decimal _periodResult = 0;
        private bool _isReal;
        private bool _showDetails;
        private int _monthInterval;
        private string _strCurrency;

        public IncomeStatementReportForm()
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
	        //
	        _formId = _formRepository.SelectFormByName(_formName);
	        _userPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, _formId);
	        if (_userPermission != null && _userPermission.Count > 0)
	        {
		        var isProtected = _userPermission.SingleOrDefault(x => x.ControlName == "IsProtected")?.Value;
		        if (isProtected != null) _isProtected = (bool)isProtected;
	        }
	        //


			_initDataObjectModelList.Add(new InitDataObjectModel
            {
                Name = "ALL",
                Value = "ALL"
            });
            _initDataObjectModelList.Add(new InitDataObjectModel
            {
                Name = "EXPENDITURES",
                Value = "EXPENDITURES"
            });
            _initDataObjectModelList.Add(new InitDataObjectModel
            {
                Name = "INCOME",
                Value = "INCOME"
            });
        }

        private void WireUpBindings()
        {
            cboResults.Properties.DataSource = null;
            cboResults.Properties.DataSource = _initDataObjectModelList;
        }

        private void ApplyDefaults()
        {
            dtDateFrom.EditValue = DateTime.Parse("01/01/" + DateTime.Today.Year);
            dtDateTo.EditValue = DateTime.Now;

            chkRemoveDuplicates.Checked = true;
            chkShowDetails.Checked = true;

			rgCurrencyOutput.SelectedIndex = 1;
            rgSortingByFilter.SelectedIndex = 0;
            rgPrinterOutput.SelectedIndex = 0;
            chkReal.Checked = true;
            ReadFilter();
        }

        private void ReadFilter()
        {
	        string filePath = Path.Combine(Path.GetTempPath(), _filterName) + ".json";
            if(!File.Exists(filePath)) return;
            
            chkSaveFilter.Checked = File.Exists(filePath);

	        using (var sr = new StreamReader(filePath))
	        {
		        string json = sr.ReadToEnd();
		        var defaultFilterList = HelperApplication.ReadJsonFilterList(json);

		        if (defaultFilterList == null) return;
				foreach (var filter in defaultFilterList)
				{
					switch (filter.Name)
					{
						case "DateFrom":
							dtDateFrom.EditValue = DateTime.Parse(filter.Value);
							break;

						case "DateTo":
							dtDateTo.EditValue = DateTime.Parse(filter.Value);
							break;
					}
				}
			}
		}

        private void ApplyPermissions()
        {
	        if (_userPermission == null) return;
	        if (_userPermission.Count <= 0) return;

	        var canAccessProfit = _userPermission.SingleOrDefault(x => x.ControlName == "CanAccessProfit")?.Value;
	        if (canAccessProfit != null) _canAccessProfit = (bool)canAccessProfit;

	        var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
	        if (isAdmin != null) _isAdmin = (bool)isAdmin;

		}

		#region Buttons Event

		private void btnPreview_Click(object sender, EventArgs e)
        {
            _strCurrency = rgCurrencyOutput.AccessibleName;
            _isReal = chkReal.Checked;
            _showDetails = chkShowDetails.Checked;

            _totalProvisionInvoice = 0;
            _totalProvisionCost = 0;

            _totalRealProvisionInvoice = 0;
            _totalRealProvisionCost = 0;

            _resultOfTheYear = 0;
            _periodResult = 0;
            
            if (_showDetails)
            {
                PrintDetailedIncomeReport();
            }
            else
            {
                PrintIncomeReport();
            }

            SaveFilter();
        }

		private void SaveFilter()
		{
			if (!chkSaveFilter.Checked) return;

			try
			{
				// INIT
				List<InitDataModelExtended> initDataList = new List<InitDataModelExtended>();

				//SEED
				if (dtDateFrom.EditValue != null)
					initDataList.Add(new InitDataModelExtended { Name = "DateFrom", Value = dtDateFrom.EditValue.ToString() });

				if (dtDateTo.EditValue != null)
					initDataList.Add(new InitDataModelExtended { Name = "DateTo", Value = dtDateTo.EditValue.ToString() });

				var jSonToString = HelperApplication.SaveJsonFilterList(initDataList);

                HelperApplication.SaveCustomFilter(_filterName, jSonToString);
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message,
					"Save filter error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


        #region Functions

        private void PrintIncomeReport()
        {
            try
            {
                if (_isReal) CalculateProvision();
                GenerateIncome();

                var previewForm = new DocumentViewerForm();
                var report = new ProfitAndLossReport();
                report.DataSource = _incomeStatements;

                report.Parameters["DateFrom"].Value = dtDateFrom.EditValue;
                report.Parameters["DateTo"].Value = dtDateTo.EditValue;
                report.Parameters["strCurrency"].Value = _strCurrency;
                report.Parameters["TotalProvisionInvoice"].Value = _totalProvisionInvoice;
                report.Parameters["TotalProvisionCost"].Value = _totalProvisionCost;
                report.Parameters["MonthInterval"].Value = _monthInterval;
                report.Parameters["ResultOfTheYear"].Value = _resultOfTheYear;
                report.Parameters["PeriodResult"].Value = _periodResult;

                previewForm.Viewer.DocumentSource = report;
                previewForm.ShowDialog();

            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "Report error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDetailedIncomeReport()
        {
            try
            {
				if (_isReal) CalculateProvision();

                string orderBy = (string)rgOrderByFilter.EditValue;
                string sortingBy = (string)rgSortingByFilter.EditValue;
                var removeDuplicates = chkRemoveDuplicates.Checked;

				_detailedIncomeStatement = _statementRepository.GenerateDetailedIncome((DateTime)dtDateFrom.EditValue, (DateTime)dtDateTo.EditValue, 
					orderBy, sortingBy, removeDuplicates);

				DateTime dateFrom = (DateTime)dtDateFrom.EditValue;
                DateTime dateTo = (DateTime)dtDateTo.EditValue;
				_monthInterval = dateTo.Month + 1 - dateFrom.Month;

				var previewForm = new DocumentViewerForm();
                var report = new DetailedIncomeReport();

                report.DataSource = _detailedIncomeStatement;

                report.Parameters["DateFrom"].Value = dtDateFrom.EditValue;
                report.Parameters["DateTo"].Value = dtDateTo.EditValue;
                report.Parameters["strCurrency"].Value = _strCurrency;
                report.Parameters["TotalProvisionInvoice"].Value = _totalProvisionInvoice;
                report.Parameters["TotalProvisionCost"].Value = _totalProvisionCost;
                report.Parameters["MonthInterval"].Value = _monthInterval;
                report.Parameters["ResultOfTheYear"].Value = _resultOfTheYear;
                report.Parameters["YearToDate"].Value = chkRemoveDuplicates.Checked;

                previewForm.Viewer.DocumentSource = report;
                previewForm.ShowDialog();

            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "Report error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateIncome()
        {
            try
            {
                int pendingTime = 0;
                SplashScreenManager.ShowForm(null, typeof(WaitReportForm1), true, true, true, pendingTime);

                string accName = "";
                decimal subTotals = 0;
                decimal totals = 0;
                decimal totalIncome = 0;
                decimal totalExpenses = 0;
                decimal totalGroup = 0;

                decimal interests = 0;
                DateTime dateFrom = (DateTime)dtDateFrom.EditValue;
                DateTime dateTo = (DateTime)dtDateTo.EditValue;

                int currencyId = (int)rgCurrencyOutput.EditValue;
                _monthInterval = dateTo.Month+1 - dateFrom.Month;

                //DateTimeSpan
                var dateSpan = DateTimeSpan.CompareDates(dateFrom, dateTo).Months+1;

                // Init Income Statement temporary Table
                _statementRepository.DeleteIncomeStatementTmpTable();

                // SelectIncomeAccounts
                _incomeAccounts = _statementRepository.SelectIncomeAccounts();

                //Generate Accounts for Income Statement
                //_statementRepository.GenerateIncomeStatements((DateTime?)dtDateFrom.EditValue,
                //    (DateTime?)dtDateTo.EditValue, (bool)chkReal.EditValue, currencyId);

                foreach (var incomeAccount in _incomeAccounts)
                {
                    switch (incomeAccount.AccountNumber)
                    {
                        case "7132":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "7132");

                            subTotals -= _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "7191");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);

                            break;

                        case "8111":
                            if (!_isReal) continue;

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, _totalProvisionInvoice);

                            break;

                        case "8111_T":
                            if (!_isReal) continue;

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, _totalProvisionInvoice);

                            break;


                        case "7132_T":
                            totals = _statementRepository.CalculateTotalIncome(incomeAccount.AccountGroup, 2);

                            if (_isReal) totals += _totalProvisionInvoice;

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, totals);

                            totalIncome += totals;

                            break;

                        case "773":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "773");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "773_T":
                            totals = _statementRepository.CalculateTotalIncome(incomeAccount.AccountGroup, incomeAccount.ColumnList);

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, totals);

                            interests = totals;
                            totalIncome += interests;

                            break;

                        case "6211":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6211");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "8011":
                            if (!_isReal) continue;

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, _totalProvisionCost);

                            break;

                        case "8011_T":
                            if (!_isReal) continue;

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, _totalProvisionCost);

                            break;


                        case "6211_T":
                            totals = _statementRepository.CalculateTotalIncome(incomeAccount.AccountGroup, 2);

                            if (_isReal) totals += _totalProvisionCost;

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, totals);

                            totalExpenses += totals;

                            break;


                        case "6211_G":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6211");

                            subTotals += _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6212");

                            // (Math.Round(Math.Ceiling(((totalIncome - totals) / totalIncome * 100)*100), 3)/100).ToString("N2");
                            string vPercent = "";

                            if (totalIncome > 0)
                            {
                                vPercent = CalculatePercentage(totalIncome, totals);
                            }

                            totalGroup = totalIncome - totals;
                            _periodResult = totalGroup;


							_statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description + $"      {vPercent} %", incomeAccount.OrderInList,
                                incomeAccount.ColumnList, incomeAccount.Section, currencyId, totalGroup);


                            break;

                        case "6261":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6261");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "6262":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6262");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "6263":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6263");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "6264":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6264");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "6265":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6265");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "6268":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6268");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "6269":
                            totals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6269");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, totals);
                            break;

                        case "6261_T":
                            totals = _statementRepository.CalculateTotalIncome(incomeAccount.AccountGroup, 2);

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, totals);

                            totalExpenses += totals;

                            break;

                        case "6261_G":
                            totals = _statementRepository.CalculateTotalIncome(incomeAccount.AccountGroup, 2);

                            totalGroup -= totals;

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList,
                                incomeAccount.ColumnList, incomeAccount.Section, currencyId, totalGroup);

                            break;

                        case "6311":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6311");

                            subTotals += _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6312");

                            subTotals += _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6315");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "6351":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6351");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "6316":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6316");

                            subTotals += _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6317");


                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "6421":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6421");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "6411":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6411");

                            subTotals += _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6452");

                            subTotals += _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6453");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "6443":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6443");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "6311_T":
                            totals = _statementRepository.CalculateTotalIncome(incomeAccount.AccountGroup, 2);

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, totals);

                            totalExpenses += totals;

                            break;

                        case "6311_G":
                            totals = _statementRepository.CalculateTotalIncome(incomeAccount.AccountGroup, 2);

                            totalGroup -= totals;

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList,
                                incomeAccount.ColumnList, incomeAccount.Section, currencyId, totalGroup);

                            break;

                        case "6512":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6512");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "6736":
                            subTotals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6736");

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, subTotals);
                            break;

                        case "6736_T":
                            totals = _statementRepository.CalculateTotalIncome(incomeAccount.AccountGroup, 2);

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, totals);

                            interests = totals;
                            totalExpenses += totals;

                            break;

                        case "6751":

                            int columnOrder = 0;

                            totals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "7751");

                            totals -= _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, "6751");

                            columnOrder = 4;
                            accName = "POSITIVE DIFFERENCE OF EXCHANGE";
                            if (totals < 0)
                            {
	                            totals = -totals; // if negative reverse the sign because we already deducting it
								columnOrder = 2;
                                accName = "NEGATIVE DIFFERENCE OF EXCHANGE";
                            }

                            totalIncome += totals;
                            interests -= totals;

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                accName, incomeAccount.OrderInList, columnOrder, incomeAccount.Section,
                                currencyId, Math.Abs(totals));
                            break;


                        case "6751_G":

                            totalGroup -= interests;

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList,
                                incomeAccount.ColumnList, incomeAccount.Section, currencyId, totalGroup);

                            totalExpenses += totals;

                            _resultOfTheYear = totalGroup;

                            break;

                        case "6751_T":

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                incomeAccount.Description, incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, totalGroup);

                            

                            break;


                        default:
                            totals = _statementRepository.ExecuteIncomeAccountCalculation((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, currencyId, incomeAccount.AccountNumber);

                            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue,
                                (bool)chkReal.EditValue, incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber,
                                "NOT EXISTING ACCOUNT", incomeAccount.OrderInList, incomeAccount.ColumnList, incomeAccount.Section,
                                currencyId, totals);
                            break;
                    }
                }
                
                //Select Generated Accounts for Income Statement
                _incomeStatements = _statementRepository.SelectIncomeStatements();
                var xxx = totalIncome;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message,
                    "Report error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }

        }

        private void CalculateProvision()
        {
            try
            {
                _totalProvisionInvoice = _statementRepository.CalculateIncomeProvisions((DateTime)dtDateFrom.EditValue, (DateTime)dtDateTo.EditValue, (int)ProvisionsType.Customers);
                _totalProvisionCost = _statementRepository.CalculateIncomeProvisions((DateTime)dtDateFrom.EditValue, (DateTime)dtDateTo.EditValue, (int)ProvisionsType.Suppliers);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message,
                    "Calculate Provision Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void AddNewIncomeRecord(SpecialIncomeStatementModel incomeAccount)
        {
            _statementRepository.AddIncomeStatementEntry((DateTime?)dtDateFrom.EditValue, (DateTime?)dtDateTo.EditValue, (bool)chkReal.EditValue,
                incomeAccount.IsTotal, incomeAccount.AccountGroup, incomeAccount.AccountNumber, incomeAccount.Description, incomeAccount.OrderInList,
                incomeAccount.ColumnList, incomeAccount.Section, incomeAccount.CurrencyId, incomeAccount.Amount1);
        }

        #endregion


        public string CalculatePercentage(decimal totalIncome, decimal totals)
        {
            // Ensure totalIncome is not zero to avoid division by zero
            if (totalIncome == 0)
            {
                throw new DivideByZeroException("Total income cannot be zero.");
            }

            decimal percentage = Math.Round((totalIncome - totals) / totalIncome * 100 * 100, 2) / 100;
            string vPercent = percentage.ToString("N2");

            return vPercent;
        }

		private void IncomeStatementReportForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				if (!chkSaveFilter.Checked)
				{
					string filePath = Path.Combine(Path.GetTempPath(), _filterName) + ".json";
					File.SetAttributes(filePath, FileAttributes.Normal);
					File.Delete(filePath);
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
			}

		}
	}
}