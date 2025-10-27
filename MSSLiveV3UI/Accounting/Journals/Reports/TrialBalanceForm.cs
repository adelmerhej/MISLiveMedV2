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

namespace MISLiveMed.UI.Accounting.Journals.Reports
{
	public partial class TrialBalanceForm: XtraForm
	{
		private const string _formName = "TrialBalance";
		private int _formId;
		private bool _resetMenu;

		private IList<ChartModel> _charts = new List<ChartModel>();
		private IList<CurrencyModel> _currencies = new List<CurrencyModel>();

		private readonly ChartRepository _chartRepository = new ChartRepository();
		private readonly CurrencyRepository _currencyRepository = new CurrencyRepository();
		private readonly StatementOfAccountRepository _statementOfAccountRepository = new StatementOfAccountRepository();

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
		private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
		private readonly FormRepository _formRepository = new FormRepository();

		//Init permission variables
		private bool _isAdmin;
		private bool _isProtected;

		public TrialBalanceForm()
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

				_charts = _chartRepository.SelectCharts(true, false);
				_currencies = _currencyRepository.SelectCurrencies();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void WireUpBindings()
		{
			cboAccountNumberFrom.Properties.DataSource = null;
			cboAccountNumberFrom.Properties.DataSource = _charts;

			cboAccountNumberTo.Properties.DataSource = null;
			cboAccountNumberTo.Properties.DataSource = _charts;
		}

		private void ApplyPermissions()
		{
			chkShowProtected.Visible = _isProtected;
		}

		private void ApplyDefaults()
		{
			dtDateFrom.EditValue = DateTime.Parse("01/01/" + DateTime.Today.Year);
			dtDateTo.EditValue = DateTime.Now;

			rgCurrencyOut.SelectedIndex = 2;
		}

		#region Buttons Event

		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (!ValidateForm()) return;

			// Prepare variables
			DateTime? dateFrom = dtDateFrom.EditValue as DateTime?;
			DateTime? dateTo = dtDateTo.EditValue as DateTime?;

			int fromChartId = cboAccountNumberFrom.EditValue as int? ?? 0;
			int toChartId = cboAccountNumberTo.EditValue as int? ?? 0;
			int currencyId = cboCurrencies.EditValue as int? ?? 0;
			int currencyOut = rgCurrencyOut.SelectedIndex;
			int workingYear = dateFrom?.Year ?? 0;

			string accountFrom = String.Empty;
			string accountTo = String.Empty;
			string accountNameFrom = String.Empty;
			string accountNameTo = String.Empty;

			bool showDetailed = chkShowDetailed.Checked;
			bool isProtected = chkShowProtected.Checked;

			// Fetch report data
			IList<TrialBalanceModel> dataReportModels =
				_statementOfAccountRepository.TrialBalanceReport(dateFrom, dateTo, cboAccountNumberFrom.Text, cboAccountNumberTo.Text, currencyId, workingYear, isProtected);

			ChartModel chartAccountFrom = _chartRepository.SelectChartsById(fromChartId);
			ChartModel chartAccountTo = _chartRepository.SelectChartsById(toChartId);

			if(chartAccountFrom != null) accountFrom = chartAccountFrom.AccountNumber;
			if(chartAccountFrom != null) accountTo = chartAccountTo.AccountNumber;
			if(chartAccountFrom != null) accountNameFrom = chartAccountFrom.AccountName;
			if(chartAccountFrom != null) accountNameTo = chartAccountTo.AccountName;

			// Prepare and show report
			var report = new TrialBalanceReport
			{
				DataSource = dataReportModels,
			};
			report.Parameters["DateFrom"].Value = dateFrom;
			report.Parameters["DateTo"].Value = dateTo;
			report.Parameters["FromAccountNumber"].Value = accountFrom;
			report.Parameters["ToAccountNumber"].Value = accountTo;
			report.Parameters["FromAccountName"].Value = accountNameFrom;
			report.Parameters["ToAccountName"].Value = accountNameTo;
			report.Parameters["CurrencyOut"].Value = currencyOut;

			new DocumentViewerForm { Viewer = { DocumentSource = report } }.ShowDialog();

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion

		private void cboAccountNumberFrom_EditValueChanged(object sender, EventArgs e)
		{
			txtAccountNameFrom.Text = String.Empty;
			object marketId = cboAccountNumberFrom.Properties.View.GetFocusedRowCellValue("AccountName");

			if (marketId != null && cboAccountNumberFrom.Text != "") txtAccountNameFrom.Text = marketId.ToString();
		}

		private void cboAccountNumberTo_EditValueChanged(object sender, EventArgs e)
		{
			txtAccountNameTo.Text = String.Empty;
			object marketId = cboAccountNumberTo.Properties.View.GetFocusedRowCellValue("AccountName");

			if (marketId != null && cboAccountNumberTo.Text != "") txtAccountNameTo.Text = marketId.ToString();
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
	}
}