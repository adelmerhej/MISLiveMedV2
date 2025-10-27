using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout.Utils;
using MISLiveMed.DataLayers.Common.Currencies;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Accounting.Currencies
{
    public partial class CurrenciesListForm : RibbonForm, IFormWithRibbon
    {
	    private const string _formName = "CurrenciesList";
	    private int _formId;
	    private bool _resetMenu;

		private CurrencyModel _currencyModel = new CurrencyModel();
	    private IList<CurrencyModel> _currencies = new List<CurrencyModel>();
	    private CurrencyExchangeModel _currencyExchangeModel = new CurrencyExchangeModel();
	    private IList<CurrencyExchangeModel> _currenciesExchange = new List<CurrencyExchangeModel>();

	    private readonly CurrencyRepository _currencyRepository = new CurrencyRepository();
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

	    private DateTime _currentDate = DateTime.Now;

		#region Implementation of IFormWithRibbon

		public RibbonControl MainRibbon => rcCurrenciesList;
        public RibbonPage DefaultPage => rpCurrenciesList;


        #endregion

        public CurrenciesListForm()
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

				_currencies = _currencyRepository.SelectCurrencies();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {
            bsCurrencies.DataSource = _currencies;

			gcCurrencies.DataSource = null;
            gcCurrencies.DataSource = bsCurrencies;

            repCurrencies.DataSource = null;
            repCurrencies.DataSource = _currencies;

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
			btnSave.Enabled = _isAdmin || _canEdit;
	        btnEdit.Enabled = _isAdmin || _canEdit;
	        btnPrint.Enabled = _isAdmin || _canPrint;
	        btnDelete.Enabled = _isAdmin || _canDelete;
		}

        private void ApplyDefaults()
        {
	        LayoutsStyle.LoadLayoutGrid(gvCurrencies, CurrentUser.UserName);
	        btnShowDetails.Checked = true;
	        dtCurrentDate.EditValue = DateTime.Now;

        }

		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            CurrencyEditForm frm = new CurrencyEditForm(new CurrencyModel());
            frm.SendUpdatedCurrency += RcvUpdatedCurrency;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!_currencies.Any()) return;

            int currentRowId = (int)gvCurrencies.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _currencyModel = _currencies.SingleOrDefault(x => x.Id == currentRowId);
            if (_currencyModel == null) return;

            var frm = new CurrencyEditForm(_currencyModel);
            frm.SendUpdatedCurrency += RcvUpdatedCurrency;
            frm.ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcCurrencies.ShowRibbonPrintPreview();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CanDelete()) return;

            try
            {
                int.TryParse(gvCurrencies.GetFocusedRowCellValue("Id").ToString(), out int id);
                string name = gvCurrencies.GetFocusedRowCellValue("CurrencyName").ToString();

                if (id > 0)
                {
                    if (XtraMessageBox.Show($"Are you sure you want to delete Currency: `{name}`?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        _currencyModel = gvCurrencies.GetFocusedRow() as CurrencyModel;
                        if (_currencyModel == null)
                        {
                            return;
                        }
                        _currencyModel.Deleted = true;

                        //delete the record
                        _currencyRepository.DeleteCurrency(_currencyModel.Id);
                        RcvUpdatedCurrency(_currencyModel, EventArgs.Empty);
                    }
                }
            }
            catch (Exception exception)
            {
                switch (exception.Message)
                {
                    case "-2146233088":
                        XtraMessageBox.Show("This record is linked to one or more transactions, delete all links first.",
                            "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    default:
                        XtraMessageBox.Show(exception.Message,
                            "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        #endregion

        private bool CanDelete()
        {
            CurrencyModel dataBoundItem = gvCurrencies.GetFocusedRow() as CurrencyModel;

            if (gvCurrencies == null || gvCurrencies.SelectedRowsCount == 0) return false;
            if (gvCurrencies.SelectedRowsCount > 1)
            {
                XtraMessageBox.Show("Only one record can be selected at a time, please try again",
                    "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dataBoundItem != null && dataBoundItem.IsDefault)
            {
                XtraMessageBox.Show("Cannot delete system record!",
                    "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void RcvUpdatedCurrency(object sender, EventArgs e)
        {
            if (sender == null) return;
            _currencyModel = sender as CurrencyModel;

            if (_currencyModel != null && (_currencyModel.LastModifiedDate == null || _currencyModel.Deleted))
            {
                InitializeBindings();
                WireUpBindings();
            }
            else
            {
                gvCurrencies.UpdateCurrentRow();
            }
        }

        private void gvCurrencies_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool isActive = (bool)view.GetRowCellValue(e.RowHandle, "Active");
                bool isDefault = (bool)view.GetRowCellValue(e.RowHandle, "IsDefault");
                if (isDefault)
                {
                    e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
                }
                if (!isActive)
                {
                    e.Appearance.ForeColor = isActive ? Color.Black : Color.Gray;
                    e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Italic);
                }
            }
        }
        private void gcCurrencies_DoubleClick(object sender, EventArgs e)
        {
	        if (!_isAdmin && !_canEdit) return;

			if (!_currencies.Any()) return;

            int currentRowId = (int)gvCurrencies.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _currencyModel = _currencies.SingleOrDefault(x => x.Id == currentRowId);
            if (_currencyModel == null) return;

            var frm = new CurrencyEditForm(_currencyModel);
            frm.SendUpdatedCurrency += RcvUpdatedCurrency;
            frm.ShowDialog();
        }

		#region Grid Events

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvCurrencies, CurrentUser.UserName);
			}
		}

		private void CurrenciesListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvCurrencies, CurrentUser.UserName);
			}
		}

		#endregion

		private void btnShowDetails_CheckedChanged(object sender, ItemClickEventArgs e)
		{
			layoutExchangeCurrencies.Visibility = btnShowDetails.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
			btnShowDetails.Caption = btnShowDetails.Checked ? "Hide Details" : "Show Details";
		}

		private void btnCurrentDate_EditValueChanged(object sender, EventArgs e)
		{
			UpdateExchangeCurrencyView();
		}

		private void UpdateExchangeCurrencyView()
		{
			CheckCurrentRate();

			try
			{
				var selectedDate = dtCurrentDate.EditValue;

				if (selectedDate != null)
				{
					_currentDate = (DateTime)dtCurrentDate.EditValue;
				}

				//_currenciesExchange = _currencyExchangeRepository.SelectCurrencyByDate(_currentDate.Date);

				bsExchangeCurrencies.DataSource = _currenciesExchange;
				gcExchangeCurrencies.DataSource = null;
				gcExchangeCurrencies.DataSource = bsExchangeCurrencies;
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void CheckCurrentRate()
		{
			try
			{
				if(dtCurrentDate.EditValue == null) return;
				DateTime selectedDate = (DateTime)dtCurrentDate.EditValue;
				
				//IList<CurrencyExchangeModel> newExchangeRates = new List<CurrencyExchangeModel>();
				//newExchangeRates = _currencyExchangeRepository.SelectCurrencyByDate(selectedDate);

				//if (newExchangeRates.Count == 0)
				//{

				//}

				foreach (var currencyModel in _currencies)
				{
					var exists = _currencyExchangeRepository.CheckForExchangeCurrency(currencyModel.Id, selectedDate);
					if(exists != null) continue;

					CurrencyExchangeModel newModel = new CurrencyExchangeModel();
					newModel.CurrencyId = currencyModel.Id;
					newModel.ExchangeDate = selectedDate;

					var exchangeRate =
						_currencyExchangeRepository.SelectExchangeCurrency(currencyModel.Id, selectedDate);
					if (exchangeRate != null) newModel.ExchangeValue = exchangeRate.ExchangeValue;

					newModel.CompanyId = CurrentUser.CompanyId;
					if (CurrentUser.BranchId != null) newModel.BranchId = (int)CurrentUser.BranchId;
					newModel.CreatedBy = CurrentUser.UserId;
					_ = _currencyExchangeRepository.AddNewCurrencyExchange(newModel);
				}

				_currenciesExchange = null;
				_currenciesExchange = _currencyExchangeRepository.SelectCurrencyByDate(selectedDate);
				bsExchangeCurrencies.DataSource = _currenciesExchange;
				bsExchangeCurrencies.ResetBindings(false);
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!ValidateData()) return;

			try
			{
				BindingContext[bsExchangeCurrencies].EndCurrentEdit();

				if (_currenciesExchange == null) return;
				
				foreach (var currencyExchange in _currenciesExchange)
				{
					if (currencyExchange.Id == 0)
					{
						_logInfoRepository.CreateLogInfo(currencyExchange);
						_ = _currencyExchangeRepository.AddNewCurrencyExchange(currencyExchange);
					}
					else
					{
						_logInfoRepository.UpdateLogInfo(currencyExchange);
						_currencyExchangeRepository.UpdateCurrencyExchange(currencyExchange);
					}
				}
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool ValidateData()
		{
			var validateReturnValue = true;
			var messageNumber = 0;
			var validateMessage = new StringBuilder();

			if (dtCurrentDate.EditValue == null)
			{
				messageNumber += 1;
				validateMessage.Append("\n- Date cannot be empty.");
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

		private void btnExchangeCurrencies_ItemClick(object sender, ItemClickEventArgs e)
		{

		}
	}
}