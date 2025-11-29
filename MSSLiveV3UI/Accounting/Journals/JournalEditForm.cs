using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Accounting.Charts;
using MISLiveMed.DataLayers.Accounting.Journals;
using MISLiveMed.DataLayers.Accounting.Reports.Statements;
using MISLiveMed.DataLayers.Common.Currencies;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.Charts;
using MISLiveMed.Models.Models.Accounting.Journals;
using MISLiveMed.Models.Models.Accounting.Journals.Reports;
using MISLiveMed.Models.Models.Accounting.Reports.Statements;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.Accounting.Journals;
using MISLiveMed.Reports.Accounting.Reports.Statements;
using MISLiveMed.UI.Reports;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Accounting.Journals
{
	public partial class JournalEditForm : RibbonForm
	{
		private const string _formName = "JournalEdit";
		private int _formId;
		private DataEntityState _objState = DataEntityState.Unchanged;
		private bool _resetMenu;
		DXMenuItem[] _menuItems;

		private JournalModel _journalModel = new JournalModel();

		private JournalDetailModel _journalDetailModel = new JournalDetailModel();
		private IList<JournalDetailModel> _journalDetails = new List<JournalDetailModel>();
		private IList<JournalTypeModel> _journalTypes = new List<JournalTypeModel>();
		private IList<CurrencyModel> _currencies = new List<CurrencyModel>();
		private IList<ChartModel> _charts = new List<ChartModel>();
		private IList<IdListModel> deletedList = new List<IdListModel>();

		private readonly JournalRepository _journalRepository = new JournalRepository();
		private readonly JournalDetailRepository _journalDetailRepository = new JournalDetailRepository();
		private readonly JournalTypeRepository _journalTypeRepository = new JournalTypeRepository();
		private readonly CurrencyRepository _currencyRepository = new CurrencyRepository();
		private readonly ChartRepository _chartRepository = new ChartRepository();
		private readonly StatementOfAccountRepository _statementOfAccountRepository = new StatementOfAccountRepository();
		private readonly CurrencyExchangeRepository _currencyExchangeRepository = new CurrencyExchangeRepository();

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
		private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
		private readonly FormRepository _formRepository = new FormRepository();
		private readonly LogInfoRepository _logInfoRepository = new LogInfoRepository();

		//Init permission variables
		private bool _canAdd;
		private bool _canEdit;
		private bool _canDelete;
		private bool _canPrint;
		private bool _isAdmin;
		private bool _isProtected;
		
		//For JV default values
		private int _defaultCurrency;
		private int _defaultJvType;
		private bool _isDeleted;

		// Init balances values
		private decimal customDebitSumLL;
		private decimal customCreditSumLL;
		private decimal customSumLL;
		private decimal customDebitSumUSD;
		private decimal customCreditSumUSD;
		private decimal customSumUSD;
		private decimal totalBalance;
		private int oldCurrencyId = 0;

		public EventHandler SendUpdatedJournal;

		public JournalEditForm(JournalModel model)
		{
			InitializeComponent();

			try
			{
				_journalModel = model;

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

				_journalDetails = _journalDetailRepository.SelectJournalDetailsByJvNo(CurrentUser.WorkingYear, _journalModel.Id);
				_journalTypes = _journalTypeRepository.SelectJournalTypes();
				_currencies = _currencyRepository.SelectCurrencies();
				_charts = _chartRepository.SelectCharts(false, true);

			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsJournal.DataSource = _journalModel;
			bsJournalDetails.DataSource = _journalDetails;

			cboCurrency.Properties.DataSource = null;
			cboCurrency.Properties.DataSource = _currencies;
			cboCurrency.EditValue = _journalModel.CurrencyId;

			repCurrencies.DataSource = null;
			repCurrencies.DataSource = _currencies;

			cboJournalTypes.Properties.DataSource = null;
			cboJournalTypes.Properties.DataSource = _journalTypes;
			cboJournalTypes.EditValue = _journalModel.JournalTypeId;

			repCharts.DataSource = null;
			repCharts.DataSource = _charts;

			repAccountNames.DataSource = null;
			repAccountNames.DataSource = _charts;
		}

		private void ApplyPermissions()
		{
			if (_userPermission == null) return;
			if (_userPermission.Count <= 0) return;

			var canAdd = _userPermission.SingleOrDefault(x => x.ControlName == "CanAdd")?.Value;
			if (canAdd != null) _canAdd = (bool)canAdd;

			var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
			if (canEdit != null) _canEdit = (bool)canEdit;

			var canDelete = _userPermission.SingleOrDefault(x => x.ControlName == "CanDelete")?.Value;
			if (canDelete != null) _canDelete = (bool)canDelete;

			var canPrint = _userPermission.SingleOrDefault(x => x.ControlName == "CanPrint")?.Value;
			if (canPrint != null) _canPrint = (bool)canPrint;

			var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
			if (isAdmin != null) _isAdmin = (bool)isAdmin;

			btnNew.Enabled = _isAdmin || _canAdd;
			btnSaveAs.Enabled = _isAdmin || _canAdd;
			btnSave.Enabled = _isAdmin || _canEdit;
			btnSaveAndClose.Enabled = _isAdmin || _canEdit;
			btnPrint.Enabled = _isAdmin || _canPrint;
			btnDelete.Enabled = _isAdmin || _canDelete;
			
			//TODO: Add custom for statement
			btnPrintStatement.Enabled = _isAdmin || _canEdit;

			dtJvDate.ReadOnly = !_isAdmin && !_canEdit;
			cboJournalTypes.ReadOnly = !_isAdmin && !_canEdit;
			txtReference.ReadOnly = !_isAdmin && !_canEdit;
			cboCurrency.ReadOnly = !_isAdmin && !_canEdit;
			txtRate.ReadOnly = !_isAdmin && !_canEdit;
			txtNotes.ReadOnly = !_isAdmin && !_canEdit;
			chkPosted.ReadOnly = !_isAdmin && !_canEdit;
			chkProtected.ReadOnly = !_isAdmin && !_canEdit;

			gvJournalDetails.OptionsView.NewItemRowPosition = _canAdd ? NewItemRowPosition.Bottom : NewItemRowPosition.None;
			gvJournalDetails.OptionsBehavior.AllowAddRows = !_canAdd ? DefaultBoolean.True : DefaultBoolean.False; ;
			gvJournalDetails.OptionsBehavior.AllowDeleteRows = !_canDelete ? DefaultBoolean.True : DefaultBoolean.False;
		}

		private void ApplyDefaults()
		{
			LayoutsStyle.LoadLayoutGrid(gvJournalDetails, CurrentUser.UserName, CurrentUser.CompanyName);

			//TODO: Retrieve from configuration
			_defaultCurrency = 2;
			_defaultJvType = 1;

			if (_journalModel.Id == 0)
			{
				ApplyNewDefaultValues();
				gcJournalDetails.Focus();
			}

		}

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
				DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvJournalDetails, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		private void JournalEditForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				if (XtraMessageBox.Show("There is unsaved data, are you sure you want to close and discard changes?",
					    "Unsaved data", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
					    MessageBoxDefaultButton.Button2) == DialogResult.No)
					e.Cancel = true;
			}

			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvJournalDetails, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		private void ApplyNewDefaultValues()
		{
			try
			{
				_journalModel = new JournalModel();
				_journalDetails = new List<JournalDetailModel>();
				_journalModel.JournalDate = DateTime.Now;

				_journalModel.JournalTypeId = _defaultJvType;
				cboJournalTypes.EditValue = _defaultJvType;

				_journalModel.CurrencyId = _defaultCurrency;
				cboCurrency.EditValue = _defaultCurrency;

				if (_journalModel.JournalDate != null)
				{
					var currencyExchange = _currencyExchangeRepository.SelectExchangeCurrency(_defaultCurrency, _journalModel.JournalDate);
					if (currencyExchange != null && decimal.TryParse(currencyExchange.ExchangeValue.ToString(), out decimal newRate))
					{
						_journalModel.Rate = newRate;
					}
				}

				_journalModel.WorkingYear = CurrentUser.WorkingYear;

				gvJournalDetails.OptionsView.NewItemRowPosition = _canAdd ? NewItemRowPosition.Bottom : NewItemRowPosition.None;
				gvJournalDetails.OptionsBehavior.AllowAddRows = !_canAdd ? DefaultBoolean.True : DefaultBoolean.False; ;
				gvJournalDetails.OptionsBehavior.AllowDeleteRows = !_canDelete ? DefaultBoolean.True : DefaultBoolean.False;

				bsJournal.DataSource = _journalModel;
				bsJournalDetails.DataSource = _journalDetails;

				_objState = DataEntityState.Added;
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			if(_objState == DataEntityState.Added) return;

			_journalModel = new JournalModel();
			ApplyNewDefaultValues();
			gcJournalDetails.Focus();
		}
		private void btnSaveAs_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (_journalModel.Locked)
			{
				XtraMessageBox.Show("Period is locked, you cannot Add, Edit or Clone a locked JV.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_journalModel = _journalModel.Clone() as JournalModel;

			IList<JournalDetailModel> newJournalDetails = new List<JournalDetailModel>();

			foreach (var record in _journalDetails)
			{
				record.Id = 0;
				record.JournalId = 0;
				record.ValueDate = DateTime.Now;
				newJournalDetails.Add(record.Clone() as JournalDetailModel);
			}
			_journalDetails = newJournalDetails;

			_journalModel.Id = 0;
			_journalModel.JvNo = 0;
			_journalModel.Reference = "";

			bsJournal.DataSource = _journalModel;
			bsJournal.ResetBindings(false);

			bsJournalDetails.DataSource = _journalDetails;
			bsJournalDetails.ResetBindings(false);

			gcJournalDetails.Focus();
		}

		private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
		{
			SaveData();
		}

		private void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			SaveData(true);
		}

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{
			InitializeBindings();
			WireUpBindings();
		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (gvJournalDetails != null && gvJournalDetails.GetFocusedRowCellValue("JournalId") == null) return;

			//Prepare variables
			DateTime? dateFrom = null;
			DateTime? dateTo = null;
			int journalId = 0;
			
			if (dtFrom.EditValue != null) dateFrom = DateTime.Parse(dtFrom.EditValue.ToString());
			if (dtTo.EditValue != null) dateTo = DateTime.Parse(dtTo.EditValue.ToString());
			if (gvJournalDetails != null)
			{
				journalId = int.Parse(gvJournalDetails.GetFocusedRowCellValue("JournalId").ToString());
			}

			IList<JournalVoucherReportModel> dataReportModels =
				_journalRepository.JournalVoucherReport(journalId);
			
			var previewForm = new DocumentViewerForm();
			var report = new JournalVoucherReport();

			report.DataSource = dataReportModels;

			report.Parameters["DateFrom"].Value = dateFrom;
			report.Parameters["DateTo"].Value = dateTo;

			previewForm.Viewer.DocumentSource = report;
			previewForm.ShowDialog();
		}

		private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			Close();
		}

		#endregion

		private void SaveData(bool close = false)
		{
			if (!ValidateData()) return;

			try
			{
				BindingContext[bsJournal].EndCurrentEdit();
				BindingContext[bsJournalDetails].EndCurrentEdit();

				_journalModel = bsJournal.Current as JournalModel;
				if (_journalModel == null) return;

				_journalModel.JournalTypeId = (int)cboJournalTypes.EditValue;
				_journalModel.CurrencyId = (int)cboCurrency.EditValue;

				if (_journalModel.Id == 0)
				{
					_logInfoRepository.CreateLogInfo(_journalModel);
					
					_journalModel.JvNo = _journalRepository.SelectNewJvNo(CurrentUser.WorkingYear);
					_journalModel.Reference = Convert.ToString(_journalModel.JvNo.ToString().PadLeft(6, '0')); 

					var journalId = _journalRepository.AddNewJournal(_journalModel);

					txtJvNo.Text = _journalModel.JvNo.ToString();
					txtReference.Text = _journalModel.Reference;
				}
				else
				{
					_logInfoRepository.UpdateLogInfo(_journalModel);
					_ = _journalRepository.UpdateJournal(_journalModel);
				}

				//Update Deleted list if Any
				if (_isDeleted)
				{
					foreach (var record in deletedList)
					{
						_journalDetailRepository.DeleteJournalDetail(record.Id);
					}

					EnumerateLines();
					_isDeleted = false;
				}
				
				// UPDATE DETAILS
				foreach (var journalDetail in _journalDetails)
				{
					journalDetail.JournalId = _journalModel.Id;

					if (journalDetail.Id == 0)
					{
						_logInfoRepository.CreateLogInfo(journalDetail);
						_ = _journalDetailRepository.AddNewJournalDetail(journalDetail);
					}
					else
					{
						_logInfoRepository.UpdateLogInfo(journalDetail);
						_journalDetailRepository.UpdateJournalDetail(journalDetail);
					}
				}
				
				SendUpdatedJournal(_journalModel, EventArgs.Empty);

				_objState = DataEntityState.Unchanged;
				if (close) Close();
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message,
					"On Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private bool ValidateData()
		{
			var validateReturnValue = true;
			var messageNumber = 0;
			var validateMessage = new StringBuilder();

			if (txtJvNo.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- JV No cannot be empty.");
				validateReturnValue = false;
				txtJvNo.Focus();
			}

			if (dtJvDate.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- JV Date cannot be empty.");
				validateReturnValue = false;
				dtJvDate.Focus();
			}

			if (cboJournalTypes.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Type cannot be empty.");
				validateReturnValue = false;
				cboJournalTypes.Focus();
			}

			if (_journalModel.Locked)
			{
				messageNumber += 1;
				validateMessage.Append("\n- Period is locked, you cannot Add, Edit or Clone a locked JV.");
				validateReturnValue = false;
				dtJvDate.Focus();
			}

			if (cboCurrency.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Currency cannot be empty.");
				validateReturnValue = false;
				cboCurrency.Focus();
			}
			if (txtRate.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Rate cannot be empty.");
				validateReturnValue = false;
				txtRate.Focus();
			}

			if (txtWorkingYear.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- WorkingYear cannot be empty.");
				validateReturnValue = false;
				txtWorkingYear.Focus();
			}

			if (!_journalDetails.Any())
			{
				messageNumber += 1;
				validateMessage.Append("\n- Journal should contains details.");
				validateReturnValue = false;
				gcJournalDetails.Focus();
			}

			//- Check if Balance is zero
			decimal.TryParse(txtBalanceLL.Text, out var balanceLL);
			decimal.TryParse(txtBalanceUSD.Text, out var balanceUSD);
			if (balanceLL != 0 || balanceUSD != 0)
			{
				messageNumber += 1;
				validateMessage.Append("\n- Cannot save unbalanced JV.");
				validateReturnValue = false;
			}

			if (!validateReturnValue)
			{
				validateMessage.Insert(0, "The following need your attention:");
				if (messageNumber > 1) validateMessage.Replace("following", "followings");
				XtraMessageBox.Show(validateMessage + " \nPlease try again.",
					"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			return validateReturnValue;
		}
		private void gvJournalDetails_CellValueChanged(object sender, CellValueChangedEventArgs e)
		{
			GridView view = sender as GridView;

			try
			{
				if (e.Column.FieldName == "ChartId")
				{
					CheckChartOfAccount(sender, e);
				}

				//Currency
				if (e.Column.FieldName == "CurrencyId")
				{
					CheckCurrency(sender, e);
				}

				//Debit Credit
				if (e.Column.FieldName == "DebCred")
				{
					CalculateRemainingBalance(sender, e);
				}

				//Rate/Amounts
				if (e.Column.FieldName == "Rate" || e.Column.FieldName == "Amount")
				{
					CalculateAmounts(sender, e);
				}

				//Cost Center
				if (e.Column.FieldName == "CostCenter")
				{
					CalculateCostCenter(sender, e);
				}

			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "CellValue Changed Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnPrintStatement_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (gvJournalDetails != null && gvJournalDetails.GetFocusedRowCellValue("ChartId") == null) return;

			//Prepare variables
			DateTime? dateFrom = null;
			DateTime? dateTo = null;
			int chartId = 0;
			int currencyId = 2;
			bool isProtected = chkShowProtected.Checked;
			int workingYear = 0;

			if (dtFrom.EditValue != null) dateFrom = DateTime.Parse(dtFrom.EditValue.ToString());
			if (dtTo.EditValue != null) dateTo = DateTime.Parse(dtTo.EditValue.ToString());
			if (gvJournalDetails != null)
			{
				chartId = int.Parse(gvJournalDetails.GetFocusedRowCellValue("ChartId").ToString());
			}

			if (gvJournalDetails != null)
			{
				currencyId = int.Parse(gvJournalDetails.GetFocusedRowCellValue("CurrencyId").ToString());
			}

			IList<StatementOfAccountReportModel> dataReportModels = 
				_statementOfAccountRepository.StatementOfAccountReport(dateFrom, dateTo, chartId, currencyId);

			ChartModel chartAccount = _chartRepository.SelectChartsById(chartId);

			var previewForm = new DocumentViewerForm();
			var report = new StatementOfAccountReport();

			report.DataSource = dataReportModels;

			report.Parameters["DateFrom"].Value = dateFrom;
			report.Parameters["DateTo"].Value = dateTo;
			report.Parameters["AccountNumber"].Value = chartAccount.AccountNumber;
			report.Parameters["AccountName"].Value = chartAccount.AccountName;

			previewForm.Viewer.DocumentSource = report;
			previewForm.ShowDialog();
		}


		#region Grid Events

		private void gvJournalDetails_InitNewRow(object sender, InitNewRowEventArgs e)
		{
			GridView view = sender as GridView;
			bool isValidAmount;

			//Set static values to Journal details
			view.SetRowCellValue(e.RowHandle, view.Columns["JournalId"], _journalModel.Id);
			view.SetRowCellValue(e.RowHandle, view.Columns["Line"], view.RowCount);
			view.SetRowCellValue(e.RowHandle, view.Columns["ValueDate"], DateTime.Now);
			view.SetRowCellValue(e.RowHandle, view.Columns["WorkingYear"], CurrentUser.WorkingYear);
			view.SetRowCellValue(e.RowHandle, view.Columns["CurrencyId"], cboCurrency.EditValue);
			view.SetRowCellValue(e.RowHandle, view.Columns["Rate"], decimal.Parse(txtRate.Text));

			int currentRowVisibleIndex = view.GetDataSourceRowIndex(e.RowHandle);
			int previousRowVisibleIndex = currentRowVisibleIndex - 1;
			object row = view.GetRow(previousRowVisibleIndex);

			//After selecting Account number start setting default data
			//Description
			if (view.GetRowCellValue(previousRowVisibleIndex, view.Columns["Description"]) == null)
			{
				view.SetRowCellValue(e.RowHandle, view.Columns["Description"], txtNotes.Text.Trim());
			}
			else
			{
				view.SetRowCellValue(e.RowHandle, view.Columns["Description"], view.GetRowCellValue(previousRowVisibleIndex, view.Columns["Description"]));
			}

			// Debit/Credit flag
			if (view.GetRowCellValue(previousRowVisibleIndex, view.Columns["DbCr"]) == null)
			{
				view.SetRowCellValue(e.RowHandle, view.Columns["DbCr"], EnumDebCred.D);
			}
			else
			{
				view.SetRowCellValue(e.RowHandle, view.Columns["DbCr"],
					(view.GetRowCellValue(previousRowVisibleIndex, view.Columns["DbCr"]).ToString() == "D") ? EnumDebCred.C : EnumDebCred.D);
			}

			// Amount
			if (view.GetRowCellValue(previousRowVisibleIndex, view.Columns["Amount"]) == null)
			{
				view.SetRowCellValue(e.RowHandle, view.Columns["Amount"], 0);
			}
			else
			{
				decimal.TryParse(view.GetRowCellValue(previousRowVisibleIndex, view.Columns["Amount"]).ToString(),
					out decimal previousAmount);

				view.SetRowCellValue(e.RowHandle, view.Columns["Amount"], Math.Abs(previousAmount));
			}

			// LAmount
			if (view.GetRowCellValue(previousRowVisibleIndex, view.Columns["LAmount"]) == null)
			{
				view.SetRowCellValue(e.RowHandle, view.Columns["LAmount"], 0);
			}
			else
			{
				isValidAmount = decimal.TryParse(txtBalanceLL.Text, out decimal varBalAmount);
				if (isValidAmount)
				{
					view.SetRowCellValue(e.RowHandle, view.Columns["LAmount"], Math.Abs(varBalAmount));
				}
			}
			// FAmount
			if (view.GetRowCellValue(previousRowVisibleIndex, view.Columns["FAmount"]) == null)
			{
				view.SetRowCellValue(e.RowHandle, view.Columns["FAmount"], 0);
			}
			else
			{
				isValidAmount = decimal.TryParse(txtBalanceUSD.Text, out decimal varBalAmount);
				if (isValidAmount)
				{
					view.SetRowCellValue(e.RowHandle, view.Columns["FAmount"], Math.Abs(varBalAmount));
				}
			}
		}

		#endregion


		#region Chart Event
		private void CheckChartOfAccount(object sender, CellValueChangedEventArgs e)
		{
			GridView chartView = repCharts.View;
			int rowHandle = chartView.FocusedRowHandle;
			string fieldName = "ChartId";
			object accountName = chartView.GetRowCellValue(rowHandle, fieldName);

			GridView view = sender as GridView;
			view.SetRowCellValue(e.RowHandle, "AccountName", accountName);

			_ = int.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["ChartId"]).ToString(), out int chartId);

		}

		private void CheckCurrency(object sender, CellValueChangedEventArgs e)
		{
			GridView view = sender as GridView;
			//get current amount
			decimal varAmount = 0;
			//get remaining balance
			decimal varBalanceAmount = 0;
			if (view.GetRowCellValue(view.FocusedRowHandle, view.Columns["CurrencyId"]) != null)
			{
				int currencyId =
					int.Parse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["CurrencyId"]).ToString());
			}

			if (view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Amount"]) != null)
			{
				varAmount = decimal.Parse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Amount"]).ToString());
			}
		}

		private decimal CalculateRemainingBalance(object sender, CellValueChangedEventArgs e)
		{
			GridView view = sender as GridView;
			if (view.GetRowCellValue(view.FocusedRowHandle, view.Columns["DebCred"]) == null || view.GetRowCellValue(view.FocusedRowHandle, view.Columns["CurrencyId"]) == null)
			{
				return 0;
			}
			decimal total = 0;
			int currencyId = int.Parse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["CurrencyId"]).ToString());

			for (int i = 0; i < view.RowCount; i++)
			{
				if (view.GetRowCellValue(view.FocusedRowHandle, view.Columns["DebCred"]).ToString() == "D")
				{
					total += Convert.ToDecimal(view.GetRowCellValue(i + 1, "FAmount"));
				}
				else if (view.GetRowCellValue(view.FocusedRowHandle, view.Columns["DebCred"]).ToString() == "C")
				{
					total -= Convert.ToDecimal(view.GetRowCellValue(i + 1, "FAmount"));
				}
			}

			total = CalculateRate(2, currencyId, total);
			return total;
		}

		private decimal CalculateRate(int currencyIn, int currencyOut, decimal pValue)
		{
			decimal exchangeRate = 0;
			decimal rateValue = 0;
			decimal baseCurrencyValue = 0;

			baseCurrencyValue = GetRate(2);
			exchangeRate = GetRate(currencyIn);

			if (currencyIn == currencyOut) rateValue = pValue;
			if (currencyOut == 1 && currencyIn != currencyOut)
				rateValue = pValue * exchangeRate;
			else if (currencyOut == 2 && currencyIn != currencyOut)
				rateValue = pValue * exchangeRate / baseCurrencyValue;

			return rateValue;
		}

		private decimal GetRate(int pCurrencyId)
		{
			var currencyDate = dtJvDate.DateTime;
			decimal rateValue = 0;

			//var resultRateCurrency = _services.CurrencyExchange.GetCurrencyRate(pCurrencyId, currencyDate);
			var resultRateCurrency = _currencyExchangeRepository.SelectExchangeCurrency(pCurrencyId, currencyDate);
			if (resultRateCurrency != null) rateValue = resultRateCurrency.ExchangeValue;

			return rateValue;
		}

		private void CalculateAmounts(object sender, CellValueChangedEventArgs e)
		{
			GridView view = sender as GridView;

			if (view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Amount"]) != null)
			{
				decimal amountValue = 0;
				{
					decimal.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Amount"]).ToString(),
						out amountValue);
				}
				int curId = int.Parse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["CurrencyId"])
					.ToString());
				view.SetRowCellValue(e.RowHandle, "LAmount", CalculateRate(curId, 1, amountValue));
				view.SetRowCellValue(e.RowHandle, "FAmount", CalculateRate(curId, 2, amountValue));
			}
		}

		private void CalculateCostCenter(object sender, CellValueChangedEventArgs e)
		{
			GridView view = sender as GridView;

		}

		#endregion

		private void gvJournalDetails_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				if (XtraMessageBox.Show("Are you sure to delete this record?", "Confirmation", MessageBoxButtons.YesNo) !=
				    DialogResult.Yes)
					return;

				GridView view = sender as GridView;
				deletedList.Add(new IdListModel { Id = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Id"])) });
				view.DeleteRow(view.FocusedRowHandle);
				_isDeleted = true;
			}
		}

		private void gvJournalDetails_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
		{
			var summaryId = Convert.ToInt32((e.Item as GridSummaryItem)?.Tag);
			var View = sender as GridView;

			var isDebit = false;

			// Initialization 
			if (e.SummaryProcess == CustomSummaryProcess.Start)
			{
				customDebitSumLL = 0;
				customCreditSumLL = 0;
				customSumLL = 0;

				customDebitSumUSD = 0;
				customCreditSumUSD = 0;
				customSumUSD = 0;
			}

			// Calculation 
			if (e.SummaryProcess == CustomSummaryProcess.Calculate)
				switch (summaryId)
				{
					case 1: //LAmount field
						isDebit = (string)gvJournalDetails.GetRowCellValue(e.RowHandle, "DbCr") == "D";
						if (isDebit)
						{
							customSumLL += Convert.ToDecimal(e.FieldValue);
							customDebitSumLL += Convert.ToDecimal(e.FieldValue);
						}
						else if (!isDebit)
						{
							customSumLL -= Convert.ToDecimal(e.FieldValue);
							customCreditSumLL += Convert.ToDecimal(e.FieldValue);
						}

						break;

					case 2: //FAmount field
						isDebit = (string)gvJournalDetails.GetRowCellValue(e.RowHandle, "DbCr") == "D";
						if (isDebit)
						{
							customSumUSD += Convert.ToDecimal(e.FieldValue);
							customDebitSumUSD += Convert.ToDecimal(e.FieldValue);
						}
						else if (!isDebit)
						{
							customSumUSD -= Convert.ToDecimal(e.FieldValue);
							customCreditSumUSD += Convert.ToDecimal(e.FieldValue);
						}

						break;
				}

			// Finalization 
			if (e.SummaryProcess == CustomSummaryProcess.Finalize)
				switch (summaryId)
				{
					case 1:
						e.TotalValue = customSumLL;
						txtBalanceLL.Text = customSumLL.ToString();
						txtDebitLL.Text = customDebitSumLL.ToString();
						txtCreditLL.Text = customCreditSumLL.ToString();
						break;

					case 2:
						e.TotalValue = customSumUSD;
						txtBalanceUSD.Text = customSumUSD.ToString();
						txtDebitUSD.Text = customDebitSumUSD.ToString();
						txtCreditUSD.Text = customCreditSumUSD.ToString();
						break;
				}
		}

		private void EnumerateLines()
		{
			for (int i = 0; i < gvJournalDetails.DataRowCount; i++)
			{
				gvJournalDetails.SetRowCellValue(i, gvJournalDetails.Columns["Line"], i+1);
			}
		}

		private void JournalEditForm_KeyUp(object sender, KeyEventArgs e)
		{

		}


	}
}