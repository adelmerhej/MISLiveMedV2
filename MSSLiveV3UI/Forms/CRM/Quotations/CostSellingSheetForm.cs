using System;
using System.Collections.Generic;
using System.Globalization;
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
using MISLiveMed.DataLayers.Accounting.Payments;
using MISLiveMed.DataLayers.Common.Carriers;
using MISLiveMed.DataLayers.Common.Currencies;
using MISLiveMed.DataLayers.Common.Departments;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Common.Items;
using MISLiveMed.DataLayers.Common.Payments;
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.CRM.Quotations;
using MISLiveMed.DataLayers.JobData.Quotations;
using MISLiveMed.DataLayers.JobData.Quotations.BookingSheet;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Carriers;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.Common.Items;
using MISLiveMed.Models.Models.Common.Payments;
using MISLiveMed.Models.Models.JobModels.Quotations;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Reports.CostSelling;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.BookingStatus.BookingSheet;
using MISLiveMed.UI.Reports;
using MISLiveMed.Utils.Enums;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.CRM.Quotations
{
    public partial class CostSellingSheetForm : RibbonForm
	{
		private const string _formName = "CostSellingSheet";
		private int _formId;
		private bool _resetMenu;

		DXMenuItem[] _menuItems;
		private DataEntityState _objState = DataEntityState.Unchanged;

		private QuotationHeaderCostSellingModel _costHeaderSelling;

        private IList<DepartmentModel> _departments = new List<DepartmentModel>();
        private IList<CurrencyModel> _currencies = new List<CurrencyModel>();
        private IList<AgentModel> _agents = new List<AgentModel>();
        private IList<PaymentMethodModel> _paymentsMethod = new List<PaymentMethodModel>();

        private IList<QuotationCostModel> _quotationRealCostList = new List<QuotationCostModel>();
        private QuotationCostModel _quotationRealCost = new QuotationCostModel();

        private IList<QuotationSellingModel> _quotationSellingList = new List<QuotationSellingModel>();
        private QuotationSellingModel _quotationSelling = new QuotationSellingModel();

        private IList<ItemModel> _items = new List<ItemModel>();
        private IList<VesselModel> _carriers = new List<VesselModel>();
        private IList<ItemModel> _defaultItems = new List<ItemModel>();
        private IList<UserModel> _users = new List<UserModel>();
        private UserModel _salesPerson = new UserModel();

        private BindingSource _bsQuotationRealCostList = new BindingSource();
        private BindingSource _bsQuotationSellingList = new BindingSource();

        private IList<CustomerModel> _customers = new List<CustomerModel>();
        private CustomerRepository _customerRepository = new CustomerRepository();

        private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();
        private readonly CurrencyRepository _currencyRepository = new CurrencyRepository();
        private readonly AgentRepository _agentRepository = new AgentRepository();
        private readonly PaymentRepository _paymentRepository = new PaymentRepository();
        private readonly UserRepository _userRepository = new UserRepository();
        private readonly ItemRepository _itemRepository = new ItemRepository();

        private readonly QuotationRepository _quotationRepository = new QuotationRepository();
        private readonly QuotationCostRepository _realCostRepository = new QuotationCostRepository();
        private readonly QuotationSellingRepository _sellingRepository = new QuotationSellingRepository();
        private readonly PaymentMethodRepository _paymentMethodRepository = new PaymentMethodRepository();
        private readonly VesselRepository _seaCarrierRepository = new VesselRepository();
        private readonly CurrencyExchangeRepository _currencyExchangeRepository = new CurrencyExchangeRepository();

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
        private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
        private readonly FormRepository _formRepository = new FormRepository();

        //Init permissionvariables
        private bool _canAdd;
        private bool _canEdit;
        private bool _canDelete;
        private bool _canPrint;
        private bool _isAdmin;
        private bool _isProtected;

		// Init Cost values
		private decimal _customTotalCostLL;
        private decimal _customTotalCostUSD;

        private decimal _customTotalVatCostLL;
        private decimal _customTotalVatCostUSD;

        private decimal _customTotalCommissionLL;
        private decimal _customTotalCommissionUSD;

        // Init Selling values
        private decimal _customTotalSellingLL;
        private decimal _customTotalSellingUSD;

        private decimal _customTotalVatSellingLL;
        private decimal _customTotalVatSellingUSD;

        // Init Totals values
        private decimal _totalNetCostLL;
        private decimal _totalNetCostUSD;
        private decimal _totalNetSellingLL;
        private decimal _totalNetSellingUSD;

        #region Default Parameters

        //TODO: We should read default parameters from parameters table
        private decimal _defaultRate = 15000M;
        private readonly int _defaultPaymentMethod = 2;
        private readonly int _defaultLocalCurrency = 1;
        private readonly int _defaultForeignCurrency = 2;
        private readonly int _defaultVat = 11;
        private string _vatNoteMessage = " + VAT: ";

        #endregion

        public EventHandler SendUpdatedCostSelling;

        public CostSellingSheetForm(QuotationHeaderCostSellingModel model)
        {
            InitializeComponent();

            try
            {
				_costHeaderSelling = model;

				InitializeBindings();
	            WireUpBindings();
	            ApplyDefaults();
	            ApplyPermissions();
	            InitializeMenuItems();

	            if (model.Id == 0)
	            {
		            _costHeaderSelling = new QuotationHeaderCostSellingModel();
		            InitNewSettings();
	            }
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

				_departments = _departmentRepository.SelectDepartments();
				_customers = _customerRepository.SelectCustomers();
				_agents = _agentRepository.SelectAgents();
				_users = _userRepository.SelectUsers();
				_currencies = _currencyRepository.SelectCurrencies();
				_items = _itemRepository.SelectItems();
				_paymentsMethod = _paymentMethodRepository.SelectPaymentsMethod(true);
				//_carriers = _seaCarrierRepository.SeaCarriersList();

				if (_costHeaderSelling.Id == 0)
				{
					_defaultItems = _itemRepository.SelectItemsByDepartment(0, _costHeaderSelling.DepartmentId, 1);
					_salesPerson = _userRepository.SelectSalesByCustomerId(_costHeaderSelling.MemberId);
				}

			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void PopulateDefaultItemsList()
        {
            if (_costHeaderSelling.Id > 0) //check if there is a previous version of quotation
            {
                PopulateDetails();
                return;
            }

            // Fetch exchange rates
            var currencyExchangeUsdRate = _currencyExchangeRepository.SelectExchangeCurrency(_defaultForeignCurrency, DateTime.Now);
			_defaultRate = currencyExchangeUsdRate?.ExchangeValue ?? 1; // Avoid division by zero

            foreach (var item in _defaultItems)
            {
                PopulateNewRealCostItems(item.Id, item.Description);
                PopulateNewSellingItems(item.Id, item.Description);
            }

            gcQuotationCost.DataSource = _quotationRealCostList;
            gcQuotationSelling.DataSource = _quotationSellingList;
        }

        private void WireUpBindings()
        {
            bsQuotationHeaderCostSelling.DataSource = _costHeaderSelling;

            PopulateDefaultItemsList();

            _bsQuotationRealCostList.DataSource = _quotationRealCostList;
            gcQuotationCost.DataSource = null;
            gcQuotationCost.DataSource = _bsQuotationRealCostList;

            _bsQuotationSellingList.DataSource = _quotationSellingList;
            gcQuotationSelling.DataSource = null;
            gcQuotationSelling.DataSource = _bsQuotationSellingList;

            cboDepartmentList.Properties.DataSource = null;
            cboDepartmentList.Properties.DataSource = _departments;

            cboUserList.Properties.DataSource = null;
            cboUserList.Properties.DataSource = _users;

            cboCarriers.Properties.DataSource = null;
            cboCarriers.Properties.DataSource = _carriers;
            cboCarriers.EditValue = _costHeaderSelling.SeaCarrierId;

            //Real Cost Section
            repCostItemsList.DataSource = null;
            repCostItemsList.DataSource = _items;

            repCostAgents.DataSource = null;
            repCostAgents.DataSource = _agents;

            repCostMethodofPaymentList.DataSource = null;
            repCostMethodofPaymentList.DataSource = _paymentsMethod;

            repCostCurrenciesList.DataSource = null;
            repCostCurrenciesList.DataSource = _currencies;

            //Selling Section
            repSellingMemberList.DataSource = null;
            repSellingMemberList.DataSource = _customers;

            repSellingItemsList.DataSource = null;
            repSellingItemsList.DataSource = _items;

            repSellingPayemntsList.DataSource = null;
            repSellingPayemntsList.DataSource = _paymentsMethod;

            repSellingCurrenciesList.DataSource = null;
            repSellingCurrenciesList.DataSource = _currencies;

            if (_salesPerson.UserName != null)
            {
                txtSalesPerson.Text = _salesPerson.UserName;

                //TODO: add commission to quotation
                //txtCommission.Text = _salesPerson.SalesProfitShare.ToString();
            }
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
	        btnSaveAndClose.Enabled = _isAdmin || _canEdit;
	        btnRefresh.Enabled = _isAdmin || _canEdit;
	        btnPrint.Enabled = _isAdmin || _canPrint;
	        btnDelete.Enabled = _isAdmin || _canDelete;

	        gvQuotationCost.OptionsView.NewItemRowPosition = _canAdd ? NewItemRowPosition.Bottom : NewItemRowPosition.None;
	        gvQuotationCost.OptionsBehavior.AllowAddRows = !_canAdd ? DefaultBoolean.True : DefaultBoolean.False; ;
	        gvQuotationCost.OptionsBehavior.AllowDeleteRows = !_canDelete ? DefaultBoolean.True : DefaultBoolean.False;

	        gvQuotationSelling.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
	        gvQuotationSelling.OptionsBehavior.AllowAddRows = DefaultBoolean.True;
	        gvQuotationSelling.OptionsBehavior.AllowDeleteRows = DefaultBoolean.True;
		}

        private void ApplyDefaults()
        {
	        gvQuotationCost.Columns["ProvisionAmount"].Visible = _costHeaderSelling.DisplayProvisionColumns;
	        gvQuotationCost.Columns["ProvisionAmount"].VisibleIndex = 9;
	        gvQuotationCost.Columns["ProvisionAmountLL"].Visible = _costHeaderSelling.DisplayProvisionColumns;
	        gvQuotationCost.Columns["ProvisionAmountLL"].VisibleIndex = 10;
	        gvQuotationCost.Columns["ProvisionAmountUSD"].Visible = _costHeaderSelling.DisplayProvisionColumns;
	        gvQuotationCost.Columns["ProvisionAmountUSD"].VisibleIndex = 11;
		}

        private void InitNewSettings()
        {
            dtQuoteDate.EditValue = DateTime.Now;
            dtBookedDate.EditValue = DateTime.Now;

            // Fetch exchange rates
            var currencyExchangeUsdRate = _currencyExchangeRepository.SelectExchangeCurrency(_defaultForeignCurrency, DateTime.Now);
            _defaultRate = currencyExchangeUsdRate?.ExchangeValue ?? 1; // Avoid division by zero
		}

        void InitializeMenuItems()
        {
            DXMenuItem itemEdit = new DXMenuItem("Edit", ItemEdit_Click);
            DXMenuItem itemDelete = new DXMenuItem("Delete", ItemDelete_Click);
            _menuItems = new[] { itemEdit, itemDelete };
        }
        private void SaveChanges()
        {
            //TODO: Validate form

            gvQuotationCost.UpdateCurrentRow();
            gvQuotationSelling.UpdateCurrentRow();

            bsQuotationHeaderCostSelling.EndEdit();
            _bsQuotationRealCostList.EndEdit();
            _bsQuotationSellingList.EndEdit();

            _costHeaderSelling = (QuotationHeaderCostSellingModel)bsQuotationHeaderCostSelling.Current;
            _costHeaderSelling.QuotationRealCostDetails = (List<QuotationCostModel>)_bsQuotationRealCostList.DataSource;
            _costHeaderSelling.QuotationSellingModels = (List<QuotationSellingModel>)_bsQuotationSellingList.DataSource;

            if (cboCarriers.EditValue != null) _costHeaderSelling.SeaCarrierId = (int)cboCarriers.EditValue;

            try
            {
                if (_costHeaderSelling.Id == 0 && txtJobNo.Text == @"0")
                {
                    var costSellingModel = QuotationBookingSheetDal.InsertQuotationHeaderCostSelling(_costHeaderSelling);
                    txtJobNo.Text = costSellingModel.Id.ToString();
                }
                else
                {
                    QuotationBookingSheetDal.UpdateQuotationHeaderCostSelling(_costHeaderSelling);
                }

                // update grid
                PopulateDetails();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }

            SendUpdatedCostSelling(true, EventArgs.Empty);
            //return true;
        }
        private void PopulateDetails()
        {
            _quotationRealCostList =
                _realCostRepository.SelectRealCostByQuotationId(_costHeaderSelling.QuotationId, _costHeaderSelling.VersionNo);

            _quotationSellingList = _sellingRepository.SelectSellingByQuotationId(_costHeaderSelling.QuotationId, _costHeaderSelling.VersionNo);

            _bsQuotationRealCostList.DataSource = _quotationRealCostList;
            gcQuotationCost.DataSource = null;
            gcQuotationCost.DataSource = _bsQuotationRealCostList;

            _bsQuotationSellingList.DataSource = _quotationSellingList;
            gcQuotationSelling.DataSource = null;
            gcQuotationSelling.DataSource = _bsQuotationSellingList;

        }

        #region Buttons Events

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            _costHeaderSelling = new QuotationHeaderCostSellingModel();
            InitNewSettings();
        }
        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveChanges();
        }

        private void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveChanges();
            Close();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            //CalculateSalesCommission(sender, e);
            //GetDataCombos();
            //WireUpDataCombos();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_costHeaderSelling.Id <= 0) return;

            try
            {
                if (XtraMessageBox.Show($"Are you sure you want to delete Cost/Selling records: `{txtJobNo.Text}`?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //delete record
                    QuotationBookingSheetDal.DeleteCostSellingQuotation(_costHeaderSelling.Id);
                    SendUpdatedCostSelling(_costHeaderSelling, EventArgs.Empty);
                    Close();
                }

            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "User delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<CostSellingReportModel> dataReportModels =
                (List<CostSellingReportModel>)QuotationDal.GetCostSellingQuotationsReportById(_costHeaderSelling.QuotationId, _costHeaderSelling.VersionNo);

            var previewForm = new DocumentViewerForm();
            //var report = new CostSellingReport();
            var report = new CostSellingReport();

            report.DataSource = dataReportModels;

            //report.Parameters["isAdmin"].Value = CurrentUserInfoModel.UserId == 30 && chkShowProfit.Checked;

            previewForm.Viewer.DocumentSource = report;
            previewForm.ShowDialog();
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        #endregion

        private void txtValidity_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    _ = int.TryParse(txtValidity.Text, out int totalDays);
            //    if (_costSelling.ValidityDate != null)
            //    {
            //        //if (dtValidityDate.DateTime.AddDays(totalDays) >= dtValidityDate.DateTime)
            //        //{

            //        //}
            //        dtValidityDate.EditValue = dtValidityDate.DateTime.AddDays(totalDays);
            //    }
            //}
            //catch (Exception exception)
            //{
            //    txtValidity.Text = "0";
            //    // ignored
            //}
        }

        #region Populate Items detail for cost / selling

        private void PopulateNewRealCostItems(int itemId, string itemDescription)
        {
            _quotationRealCost = new QuotationCostModel
            {
                AgentId = _costHeaderSelling.AgentId,
                PaymentId = _defaultPaymentMethod,
                ItemId = itemId,
                Description = itemDescription,
                CurrencyId = _defaultForeignCurrency,
                Rate = _defaultRate,
                Amount = 0,
                Vat = false,
                VatRate = 0
            };
            _quotationRealCostList.Add(_quotationRealCost);
        }

        private void PopulateNewSellingItems(int itemId, string itemDescription)
        {
            _quotationSelling = new QuotationSellingModel
            {
                MemberId = _costHeaderSelling.MemberId,
                PaymentId = _defaultPaymentMethod,
                ItemId = itemId,
                Description = itemDescription,
                CurrencyId = _defaultForeignCurrency,
                Rate = _defaultRate,
                Amount = 0,
                Vat = false,
                VatRate = 0
            };
            _quotationSellingList.Add(_quotationSelling);
        }

        #endregion


        private void gvQuotationCost_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            _ = int.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["ItemId"]).ToString(), out int selectedItem);

            if (e.Column.FieldName == "ItemId")
            {
                SetCurrencyRate(sender, e);
                CalculateAmount(sender, e);
            }

            if (e.Column.FieldName == "Vat")
            {
                SetVatRate(sender, e);
                SetVatAmount(sender, e);
                SetVatRateNotification(sender, e);
            }

            if (e.Column.FieldName == "CurrencyId")
            {
                SetCurrencyRate(sender, e);
                CalculateAmount(sender, e);
            }

            if (e.Column.FieldName == "ItemId")
            {
                if (view.Columns != null)
                {
                    _ = int.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["ItemId"]).ToString(), out int itemId);

                    try
                    {
                        string itemDesc = _itemRepository.SelectItemById(itemId).Description;
                        view.SetRowCellValue(e.RowHandle, "Description", itemDesc);

                        CalculateSalesCommission(sender, e);
                    }
                    catch (Exception exception)
                    {
                        XtraMessageBox.Show(exception.Message, @"Item missing",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            if (e.Column.FieldName == "Amount")
            {
                try
                {
                    CalculateAmount(sender, e);
                }
                catch (Exception exception)
                {
                    XtraMessageBox.Show(exception.Message, @"Currency Conversion Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void gvQuotationSelling_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Vat")
            {
                SetVatRate(sender, e);
                SetVatAmount(sender, e);
                SetVatRateNotification(sender, e);
            }

            if (e.Column.FieldName == "CurrencyId")
            {
                SetCurrencyRate(sender, e);
                CalculateAmount(sender, e);
            }

            if (e.Column.FieldName == "ItemId")
            {
                GridView view = sender as GridView;
                if (view.Columns != null)
                {
                    _ = int.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["ItemId"]).ToString(), out int itemId);

                    try
                    {
                        string itemDesc = _itemRepository.SelectItemById(itemId).Description;
                        view.SetRowCellValue(e.RowHandle, "Description", itemDesc);
                    }
                    catch (Exception exception)
                    {
                        XtraMessageBox.Show(exception.Message, @"Item missing",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            if (e.Column.FieldName == "Amount")
            {
                try
                {
                    CalculateAmount(sender, e);
                }
                catch (Exception exception)
                {
                    XtraMessageBox.Show(exception.Message, @"Currency Conversion Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        #region Calculate Sales Commission

        private void CalculateSalesCommission(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.Columns != null)
            {
                try
                {
                    int itemId = (int)view.GetRowCellValue(e.RowHandle, "ItemId");
                    if (itemId == 236)
                    {
                        //Get sales commission and apply it to gross profit
                        //TODO: Add commission to quotation
                        //var salesCommission = _salesPerson.SalesProfitShare;
                    }
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }

		#endregion


		#region Calculate Grid Amount

		private void CalculateAmount(object sender, CellValueChangedEventArgs e)
		{
			if (!(sender is GridView view) || view.Columns == null) return;

			try
			{
				// Parse the booked date or use a fallback
				DateTime quoteDate = ParseDateTime(dtBookedDate.EditValue?.ToString()) ?? dtBookedDate.DateTime;

				// Retrieve values from the grid
				int currencyId = ParseInt(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["CurrencyId"]));
				decimal rate = ParseDecimal(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Rate"]));
				decimal amount = ParseDecimal(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Amount"]));
				bool isVat = Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, "Vat") ?? false);

				// Fetch exchange rates
				var currencyExchangeRate = _currencyExchangeRepository.SelectExchangeCurrency(currencyId, quoteDate);
				var currencyExchangeUsdRate = _currencyExchangeRepository.SelectExchangeCurrency(_defaultForeignCurrency, quoteDate);

				decimal exchangeRate = currencyExchangeRate?.ExchangeValue ?? 0;
				decimal exchangeUsdRate = currencyExchangeUsdRate?.ExchangeValue ?? 1; // Avoid division by zero

				// Calculate and set amounts
				view.SetRowCellValue(e.RowHandle, "LocalAmount", amount * exchangeRate);
				view.SetRowCellValue(e.RowHandle, "ForeignAmount", amount * exchangeRate / exchangeUsdRate);

				// Handle VAT if applicable
				if (isVat) SetVatAmount(sender, e);
			}
			catch (Exception ex)
			{
				throw new Exception("An error occurred while calculating the amount.", ex);
			}
		}

		// Helper methods for parsing
		private DateTime? ParseDateTime(string value)
		{
			return DateTime.TryParse(value, out var result) ? result : (DateTime?)null;
		}

		private int ParseInt(object value)
		{
			return int.TryParse(value?.ToString(), out var result) ? result : 0;
		}

		private decimal ParseDecimal(object value)
		{
			return decimal.TryParse(value?.ToString(), out var result) ? result : 0m;
		}

		#endregion

		private void SetVatAmount(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            _ = DateTime.TryParse(dtBookedDate.EditValue.ToString(), out DateTime quoteDate);
            _ = int.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["CurrencyId"]).ToString(), out int currencyId);

            _ = decimal.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Amount"]).ToString(), out decimal amount);
            _ = decimal.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["VatRate"]).ToString(), out decimal vatRate);

            // Fetch exchange rates
            var currencyExchangeRate = _currencyExchangeRepository.SelectExchangeCurrency(currencyId, quoteDate);
            var currencyExchangeUsdRate = _currencyExchangeRepository.SelectExchangeCurrency(_defaultForeignCurrency, quoteDate);

            decimal exchangeRate = currencyExchangeRate?.ExchangeValue ?? 0;
            decimal exchangeUsdRate = currencyExchangeUsdRate?.ExchangeValue ?? 1; // Avoid division by zero

            view.SetRowCellValue(e.RowHandle, "VatAmount", amount * (vatRate / 100));
            view.SetRowCellValue(e.RowHandle, "LocalVatAmount", amount * (vatRate / 100) * exchangeRate);
            view.SetRowCellValue(e.RowHandle, "ForeignVatAmount", (amount * (vatRate / 100) * exchangeRate) / exchangeUsdRate);
        }

        private void SetVatRateNotification(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            var noteMessage = new StringBuilder();
            noteMessage.Append(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Notes"]));

            if (view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Vat"]).ToString().ToLower() == "true")
            {
                noteMessage.Append(_vatNoteMessage);
            }
            else
            {
                noteMessage.Replace(_vatNoteMessage, "");
            }

            view.SetRowCellValue(e.RowHandle, "Notes", noteMessage.ToString());
        }

        private void SetVatRate(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            view.SetRowCellValue(e.RowHandle, "VatRate",
                view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Vat"]).ToString().ToLower() == "true" ? _defaultVat : 0);
        }

        private void SetCurrencyRate(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            _ = int.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["CurrencyId"]).ToString(), out int currencyId);
            var currencyDate = _costHeaderSelling.BookingDate ?? dtBookedDate.DateTime;
            if (_costHeaderSelling.BookingDate == null) currencyDate = dtBookedDate.DateTime;

            var currencyExchangeRate = _currencyExchangeRepository.SelectExchangeCurrency(currencyId, currencyDate).ExchangeValue;
            view.SetRowCellValue(e.RowHandle, "Rate", currencyExchangeRate);
        }

        private void gvQuotationCost_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;

            //Set static values for new entry
            view.SetRowCellValue(e.RowHandle, view.Columns["QHeaderId"], _costHeaderSelling.QuotationId);
            view.SetRowCellValue(e.RowHandle, view.Columns["AgentId"], _costHeaderSelling.AgentId);
            view.SetRowCellValue(e.RowHandle, view.Columns["PaymentId"], _defaultPaymentMethod);
            view.SetRowCellValue(e.RowHandle, view.Columns["CurrencyId"], _defaultForeignCurrency);
            view.SetRowCellValue(e.RowHandle, view.Columns["Rate"], _defaultRate);
            view.SetRowCellValue(e.RowHandle, view.Columns["Vat"], 0);

        }

        private void gvQuotationSelling_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;

            //Set static values for new entry
            view.SetRowCellValue(e.RowHandle, view.Columns["QHeaderId"], _costHeaderSelling.QuotationId);
            view.SetRowCellValue(e.RowHandle, view.Columns["MemberId"], _costHeaderSelling.MemberId);
            view.SetRowCellValue(e.RowHandle, view.Columns["PaymentId"], _defaultPaymentMethod);
            view.SetRowCellValue(e.RowHandle, view.Columns["CurrencyId"], _defaultForeignCurrency);
            view.SetRowCellValue(e.RowHandle, view.Columns["Rate"], _defaultRate);
            view.SetRowCellValue(e.RowHandle, view.Columns["Vat"], 0);
        }

        private void gvQuotationSelling_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (XtraMessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) !=
                    DialogResult.Yes)
                    return;
                GridView view = sender as GridView;

                view.SetRowCellValue(view.FocusedRowHandle, "Deleted", true);
            }
        }

        private void gvQuotationCost_CustomRowFilter(object sender, RowFilterEventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                var dataView = view.DataSource;
                BindingSource bindingSource = (view.DataSource as BindingSource);
                if (bindingSource != null)
                {
                    var dataRowView = bindingSource[e.ListSourceRow] as QuotationCostModel;
                    if (dataRowView.Deleted)
                    {
                        e.Visible = false;
                        e.Handled = true;
                    }
                }
            }
        }

        private void gvQuotationSelling_CustomRowFilter(object sender, RowFilterEventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                var dataView = view.DataSource;
                BindingSource bindingSource = (view.DataSource as BindingSource);
                if (bindingSource != null)
                {
                    var dataRowView = bindingSource[e.ListSourceRow] as QuotationSellingModel;
                    if (dataRowView.Deleted)
                    {
                        e.Visible = false;
                        e.Handled = true;
                    }
                }
            }
        }

        #region Grid Popup menu 

        private void ItemEdit_Click(object sender, EventArgs e)
        {
            gvQuotationCost.ShowEditor();
        }

        private void ItemDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(@"Delete row?", @"Confirmation", MessageBoxButtons.YesNo) !=
                DialogResult.Yes)
                return;
            //GridView view = sender as GridView;

            switch (tabPane1.SelectedPage.Name)
            {
                case "tabRealCostGroup":
                    gvQuotationCost.SetRowCellValue(gvQuotationCost.FocusedRowHandle, "Deleted", true);
                    break;

                case "tabSellingGroup":
                    gvQuotationSelling.SetRowCellValue(gvQuotationSelling.FocusedRowHandle, "Deleted", true);
                    break;
            }
        }

        private void gvQuotationCost_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)

            {
                GridView view = sender as GridView;
                view.FocusedRowHandle = e.HitInfo.RowHandle;

                foreach (DXMenuItem item in _menuItems)
                    e.Menu.Items.Add(item);
                //}
            }
        }

        private void gvQuotationSelling_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                GridView view = sender as GridView;
                view.FocusedRowHandle = e.HitInfo.RowHandle;

                foreach (DXMenuItem item in _menuItems)
                    e.Menu.Items.Add(item);
                //}
            }
        }

        #endregion

        private void gvQuotationCost_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            var summaryId = Convert.ToInt32((e.Item as GridSummaryItem)?.Tag);
            GridView view = sender as GridView;

            // Initialization 
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                _customTotalCostLL = 0;
                _customTotalCostUSD = 0;

                _customTotalVatCostLL = 0;
                _customTotalVatCostUSD = 0;

                _customTotalCommissionLL = 0;
                _customTotalCommissionUSD = 0;
            }

            // Calculation 
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
                switch (summaryId)
                {
                    case 1: //LL field
                        var isVat = (bool)view.GetRowCellValue(e.RowHandle, "Vat");
                        var isCommission = (int)view.GetRowCellValue(e.RowHandle, "ItemId");

                        _customTotalCostLL += Convert.ToDecimal(e.FieldValue);

                        if (isVat)
                        {
                            var vatValue = (decimal)view.GetRowCellValue(e.RowHandle, "VatRate");
                            _customTotalVatCostLL += Convert.ToDecimal(e.FieldValue) * vatValue / 100;

                            view.SetRowCellValue(e.RowHandle, "CostVatAmountLL", _customTotalVatCostLL);
                        }

                        if (isCommission == 236)
                        {
                            _customTotalCommissionLL += (decimal)view.GetRowCellValue(e.RowHandle, "LocalAmount");
                        }

                        break;

                    case 2: //USD field
                        isVat = (bool)view.GetRowCellValue(e.RowHandle, "Vat");
                        isCommission = (int)view.GetRowCellValue(e.RowHandle, "ItemId");

                        _customTotalCostUSD += Convert.ToDecimal(e.FieldValue);

                        if (isVat)
                        {
                            var vatValue = (decimal)view.GetRowCellValue(e.RowHandle, "VatRate");
                            _customTotalVatCostUSD += Convert.ToDecimal(e.FieldValue) * vatValue / 100;

                            view.SetRowCellValue(e.RowHandle, "CostVatAmountUSD", _customTotalVatCostUSD);
                        }

                        if (isCommission == 236)
                        {
                            _customTotalCommissionUSD += (decimal)view.GetRowCellValue(e.RowHandle, "ForeignAmount");
                        }

                        break;
                }

            // Finalization 
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                switch (summaryId)
                {
                    case 1:
                        e.TotalValue = _customTotalCostLL;

                        _totalNetCostLL = (_customTotalCostLL + _customTotalVatCostLL);

                        break;

                    case 2:
                        e.TotalValue = _customTotalCostUSD;
                        txtTotalCostUSD.Text = (_customTotalCostUSD - _customTotalCommissionUSD).ToString(CultureInfo.InvariantCulture);

                        txtTotalCostVat.Text = (_customTotalVatCostUSD).ToString(CultureInfo.InvariantCulture);
                        txtTotalCommission.Text = (_customTotalCommissionUSD).ToString(CultureInfo.InvariantCulture);
                        txtGrossCommission.Text = (_customTotalCommissionUSD).ToString(CultureInfo.InvariantCulture);

                        _totalNetCostUSD = (_customTotalCostUSD + _customTotalVatCostUSD);

                        break;
                }

                txtTotalVAT.Text = (_customTotalVatSellingUSD - _customTotalVatCostUSD).ToString(CultureInfo.InvariantCulture);
                txtGrossProfit.Text = (_customTotalSellingUSD - _customTotalCostUSD + _customTotalCommissionUSD).ToString(CultureInfo.InvariantCulture);

                txtNetProfitLL.Text = (_totalNetSellingLL - _totalNetCostLL).ToString();
                txtNetProfitUSD.Text = (_totalNetSellingUSD - _totalNetCostUSD).ToString();

            }

        }

        private void gvQuotationSelling_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            var summaryId = Convert.ToInt32((e.Item as GridSummaryItem).Tag);
            GridView view = sender as GridView;

            // Initialization 
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                _customTotalSellingLL = 0;
                _customTotalSellingUSD = 0;

                _customTotalVatSellingLL = 0;
                _customTotalVatSellingUSD = 0;
            }

            // Calculation 
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
                switch (summaryId)
                {
                    case 1: //LL field
                        var isVat = (bool)gvQuotationSelling.GetRowCellValue(e.RowHandle, "Vat");

                        _customTotalSellingLL += Convert.ToDecimal(e.FieldValue);

                        if (isVat)
                        {
                            var vatValue = (decimal)gvQuotationSelling.GetRowCellValue(e.RowHandle, "VatRate");
                            _customTotalVatSellingLL += Convert.ToDecimal(e.FieldValue) * vatValue / 100;

                            view.SetRowCellValue(e.RowHandle, "SellingVatAmountLL", _customTotalVatSellingLL);
                        }

                        break;

                    case 2: //USD field
                        isVat = (bool)gvQuotationSelling.GetRowCellValue(e.RowHandle, "Vat");

                        _customTotalSellingUSD += Convert.ToDecimal(e.FieldValue);

                        if (isVat)
                        {
                            var vatValue = (decimal)gvQuotationSelling.GetRowCellValue(e.RowHandle, "VatRate");
                            _customTotalVatSellingUSD += Convert.ToDecimal(e.FieldValue) * vatValue / 100;

                            view.SetRowCellValue(e.RowHandle, "SellingVatAmountUSD", _customTotalVatSellingUSD);
                        }

                        break;
                }

            // Finalization 
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                switch (summaryId)
                {
                    case 1:
                        e.TotalValue = _customTotalSellingLL;

                        _totalNetSellingLL = (_customTotalSellingLL + _customTotalVatSellingLL);

                        break;

                    case 2:
                        e.TotalValue = _customTotalSellingUSD;
                        txtTotalSellingUSD.Text = (_customTotalSellingUSD).ToString(CultureInfo.InvariantCulture);
                        txtTotalSellingVat.Text = (_customTotalVatSellingUSD).ToString(CultureInfo.InvariantCulture);

                        _totalNetSellingUSD = (_customTotalSellingUSD + _customTotalVatSellingUSD);

                        break;
                }

                txtTotalVAT.Text = (_customTotalVatSellingUSD - _customTotalVatCostUSD).ToString(CultureInfo.InvariantCulture);
                txtGrossProfit.Text = (_customTotalSellingUSD - _customTotalCostUSD + _customTotalCommissionUSD).ToString(CultureInfo.InvariantCulture);

                txtNetProfitLL.Text = (_totalNetSellingLL - _totalNetCostLL).ToString();
                txtNetProfitUSD.Text = (_totalNetSellingUSD - _totalNetCostUSD).ToString();
            }
        }

        private void gvQuotationCost_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (XtraMessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) !=
                    DialogResult.Yes)
                    return;
                GridView view = sender as GridView;

                view.SetRowCellValue(view.FocusedRowHandle, "Deleted", true);
            }
        }

        private void chkDisplayProvisionColumns_CheckedChanged(object sender, EventArgs e)
        {
            gvQuotationCost.Columns["ProvisionAmount"].Visible = chkDisplayProvisionColumns.Checked;
            gvQuotationCost.Columns["ProvisionAmountLL"].Visible = chkDisplayProvisionColumns.Checked;
            gvQuotationCost.Columns["ProvisionAmountUSD"].Visible = chkDisplayProvisionColumns.Checked;
        }

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvQuotationCost, CurrentUser.UserName);
				LayoutsStyle.ResetLayoutGrid(gvQuotationSelling, CurrentUser.UserName);
			}
		}

		private void CostSellingSheetForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvQuotationCost, CurrentUser.UserName);
				LayoutsStyle.SaveLayoutGrid(gvQuotationSelling, CurrentUser.UserName);
			}
		}
	}
}