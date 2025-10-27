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
	public partial class StatementOfAccountForm: XtraForm
	{
		private const string _formName = "StatementOfAccount";
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

		public StatementOfAccountForm()
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

				_charts = _chartRepository.SelectCharts(false, false);
				_currencies = _currencyRepository.SelectCurrencies();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void WireUpBindings()
		{
			cboAccountNumber.Properties.DataSource = null;
			cboAccountNumber.Properties.DataSource = _charts;

			cboCurrencies.Properties.DataSource = null;
			cboCurrencies.Properties.DataSource = _currencies;
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
			chkWithPreviousBalance.Checked = true;
			chkConsolidatePastPeriods.Checked = true;
		}

		#region Buttons Event

		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (!ValidateForm()) return;
			//Prepare variables
			DateTime? dateFrom = null;
			DateTime? dateTo = null;
			if (dtDateFrom.EditValue != null) dateFrom = DateTime.Parse(dtDateFrom.EditValue.ToString());
			if (dtDateTo.EditValue != null) dateTo = DateTime.Parse(dtDateTo.EditValue.ToString());

			int chartId = 0;
			if (cboAccountNumber.EditValue != null) chartId = (int)cboAccountNumber.EditValue;

			int currencyId = 0;
			if (cboCurrencies.EditValue != null) currencyId = (int)cboCurrencies.EditValue;

			int journalTypes = 0;
			if (cboJournalTypes.EditValue != null) journalTypes = (int)cboJournalTypes.EditValue;

			bool withPreviousBalance = chkWithPreviousBalance.Checked;
			bool showDetailed = chkShowDetailed.Checked;

			int currencyOut = rgCurrencyOut.SelectedIndex;

			int workingYear = !chkConsolidatePastPeriods.Checked ? DateTime.Now.Year : 0;
			var isProtected = chkShowProtected.Checked;

			IList<StatementOfAccountReportModel> dataReportModels =
				_statementOfAccountRepository.StatementOfAccountReport(dateFrom, dateTo, chartId, currencyId, workingYear, isProtected);

			ChartModel chartAccount = _chartRepository.SelectChartsById(chartId);

			var previewForm = new DocumentViewerForm();
			var report = new StatementOfAccountReport();

			report.DataSource = dataReportModels;

			report.Parameters["DateFrom"].Value = dateFrom;
			report.Parameters["DateTo"].Value = dateTo;
			report.Parameters["AccountNumber"].Value = chartAccount.AccountNumber;
			report.Parameters["AccountName"].Value = chartAccount.AccountName;
			report.Parameters["CurrencyOut"].Value = currencyOut;

			previewForm.Viewer.DocumentSource = report;
			previewForm.ShowDialog();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion

		private void cboAccountNumber_EditValueChanged(object sender, EventArgs e)
		{
			txtAccountName.Text = String.Empty;
			object marketId = cboAccountNumber.Properties.View.GetFocusedRowCellValue("AccountName");

			if (marketId != null && cboAccountNumber.Text != "") txtAccountName.Text = marketId.ToString();
		}

		private bool ValidateForm()
		{
			var validateReturnValue = true;
			var messageNumber = 0;
			var validateMessage = new StringBuilder();

			if (cboAccountNumber.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Account Number cannot be empty.");
				validateReturnValue = false;
				cboAccountNumber.Focus();
			}

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