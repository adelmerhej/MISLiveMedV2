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
		#region Constants

		private const string FormName = "CostSellingSheet";
		private const int CommissionItemId = 236;
		private const string VatNoteMessage = " + VAT: ";

		#endregion

		#region Fields

		private int _formId;
		private bool _resetMenu;
		private DXMenuItem[] _menuItems;
		private QuotationHeaderModel _costHeaderSelling;

		// Data collections
		private IList<DepartmentModel> _departments = new List<DepartmentModel>();
		private IList<CurrencyModel> _currencies = new List<CurrencyModel>();
		private IList<AgentModel> _agents = new List<AgentModel>();
		private IList<PaymentMethodModel> _paymentsMethod = new List<PaymentMethodModel>();
		private IList<QuotationCostModel> _quotationRealCostList = new List<QuotationCostModel>();
		private IList<QuotationSellingModel> _quotationSellingList = new List<QuotationSellingModel>();
		private IList<ItemModel> _items = new List<ItemModel>();
		private IList<VesselModel> _carriers = new List<VesselModel>();
		private IList<ItemModel> _defaultItems = new List<ItemModel>();
		private IList<UserModel> _users = new List<UserModel>();
		private UserModel _salesPerson = new UserModel();
		private IList<CustomerModel> _customers = new List<CustomerModel>();
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();

		// Binding sources
		private readonly BindingSource _bsQuotationRealCostList = new BindingSource();
		private readonly BindingSource _bsQuotationSellingList = new BindingSource();

		// Repositories
		private readonly CustomerRepository _customerRepository = new CustomerRepository();
		private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();
		private readonly CurrencyRepository _currencyRepository = new CurrencyRepository();
		private readonly AgentRepository _agentRepository = new AgentRepository();
		private readonly UserRepository _userRepository = new UserRepository();
		private readonly ItemRepository _itemRepository = new ItemRepository();
		private readonly QuotationCostRepository _realCostRepository = new QuotationCostRepository();
		private readonly QuotationSellingRepository _sellingRepository = new QuotationSellingRepository();
		private readonly PaymentMethodRepository _paymentMethodRepository = new PaymentMethodRepository();
		private readonly CurrencyExchangeRepository _currencyExchangeRepository = new CurrencyExchangeRepository();
		private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
		private readonly FormRepository _formRepository = new FormRepository();

		// Permission flags
		private bool _canAdd;
		private bool _canEdit;
		private bool _canDelete;
		private bool _canPrint;
		private bool _isAdmin;
		private bool _isProtected;

		// Summary calculation accumulators
		private SummaryTotals _costTotals = new SummaryTotals();
		private SummaryTotals _sellingTotals = new SummaryTotals();

		#endregion

		#region Default Parameters

		private decimal _defaultRate = 15000M;
		private readonly int _defaultPaymentMethod = 2;
		private readonly int _defaultLocalCurrency = 1;
		private readonly int _defaultForeignCurrency = 2;
		private readonly int _defaultVat = 11;

		#endregion

		public EventHandler SendUpdatedCostSelling;

		#region Helper Classes

		private class SummaryTotals
		{
			public decimal TotalLL { get; set; }
			public decimal TotalUSD { get; set; }
			public decimal VatLL { get; set; }
			public decimal VatUSD { get; set; }
			public decimal CommissionLL { get; set; }
			public decimal CommissionUSD { get; set; }
			public decimal NetLL => TotalLL + VatLL;
			public decimal NetUSD => TotalUSD + VatUSD;

			public void Reset()
			{
				TotalLL = TotalUSD = VatLL = VatUSD = CommissionLL = CommissionUSD = 0;
			}
		}

		#endregion

		#region Constructor

		public CostSellingSheetForm(QuotationHeaderModel model)
		{
			InitializeComponent();

			try
			{
				_costHeaderSelling = model ?? new QuotationHeaderModel();

				InitializeBindings();
				WireUpBindings();
				ApplyDefaults();
				ApplyPermissions();
				InitializeMenuItems();

				if (_costHeaderSelling.Id == 0)
				{
					InitNewSettings();
				}
			}
			catch (Exception e)
			{
				ShowError(e.Message);
			}
		}

		#endregion

		#region Initialization Methods

		private void InitializeBindings()
		{
			try
			{
				LoadUserPermissions();
				LoadLookupData();
				LoadDefaultItemsIfNew();
			}
			catch (Exception e)
			{
				ShowError(e.Message);
			}
		}

		private void LoadUserPermissions()
		{
			_formId = _formRepository.SelectFormByName(FormName);
			_userPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, _formId);

			if (_userPermission?.Count > 0)
			{
				_isProtected = GetPermissionValue<bool>("IsProtected");
			}
		}

		private void LoadLookupData()
		{
			_departments = _departmentRepository.SelectDepartments();
			_customers = _customerRepository.SelectCustomers();
			_agents = _agentRepository.SelectAgents();
			_users = _userRepository.SelectUsers();
			_currencies = _currencyRepository.SelectCurrencies();
			_items = _itemRepository.SelectItems();
			_paymentsMethod = _paymentMethodRepository.SelectPaymentsMethod(true);
		}

		private void LoadDefaultItemsIfNew()
		{
			if (_costHeaderSelling.Id == 0)
			{
				_defaultItems = _itemRepository.SelectItemsByDepartment(0, _costHeaderSelling.DepartmentId, 1);
				_salesPerson = _userRepository.SelectSalesByCustomerId(_costHeaderSelling.MemberId);
			}
		}

		private void PopulateDefaultItemsList()
		{
			if (_costHeaderSelling.Id > 0)
			{
				PopulateDetails();
				return;
			}

			UpdateDefaultRate();

			foreach (var item in _defaultItems)
			{
				PopulateNewRealCostItems(item.Id, item.Description);
				PopulateNewSellingItems(item.Id, item.Description);
			}

			BindGridDataSource(gcQuotationCost, _quotationRealCostList);
			BindGridDataSource(gcQuotationSelling, _quotationSellingList);
		}

		private void UpdateDefaultRate()
		{
			var currencyExchange = _currencyExchangeRepository.SelectExchangeCurrency(_defaultForeignCurrency, DateTime.Now);
			_defaultRate = currencyExchange?.ExchangeValue ?? 1;
		}

		private void WireUpBindings()
		{
			//bsQuotationHeader.DataSource = _costHeaderSelling;

			PopulateDefaultItemsList();

			BindGridWithBindingSource(gcQuotationCost, _bsQuotationRealCostList, _quotationRealCostList);
			BindGridWithBindingSource(gcQuotationSelling, _bsQuotationSellingList, _quotationSellingList);

			BindLookupDataSource(cboDepartmentList.Properties, _departments);
			BindLookupDataSource(cboUserList.Properties, _users);
			BindLookupDataSource(cboCarriers.Properties, _carriers);
			cboCarriers.EditValue = _costHeaderSelling.SeaCarrierId;

			// Real Cost Section lookups
			BindLookupDataSource(repCostItemsList, _items);
			BindLookupDataSource(repCostAgents, _agents);
			BindLookupDataSource(repCostMethodofPaymentList, _paymentsMethod);
			BindLookupDataSource(repCostCurrenciesList, _currencies);

			// Selling Section lookups
			BindLookupDataSource(repSellingMemberList, _customers);
			BindLookupDataSource(repSellingItemsList, _items);
			BindLookupDataSource(repSellingPayemntsList, _paymentsMethod);
			BindLookupDataSource(repSellingCurrenciesList, _currencies);

			if (!string.IsNullOrEmpty(_salesPerson?.UserName))
			{
				txtSalesPerson.Text = _salesPerson.UserName;
			}
		}

		private void BindGridDataSource<T>(GridControl grid, T dataSource)
		{
			grid.DataSource = dataSource;
		}

		private void BindGridWithBindingSource<T>(GridControl grid, BindingSource bindingSource, T dataSource)
		{
			bindingSource.DataSource = dataSource;
			grid.DataSource = null;
			grid.DataSource = bindingSource;
		}

		private void BindLookupDataSource(object control, object dataSource)
		{
			if (control is DevExpress.XtraEditors.Repository.RepositoryItemLookUpEditBase lookupEdit)
			{
				lookupEdit.DataSource = null;
				lookupEdit.DataSource = dataSource;
			}
			else
			{
				// Handle LookUpEdit.Properties which has a DataSource property
				var dataSourceProperty = control.GetType().GetProperty("DataSource");
				if (dataSourceProperty != null)
				{
					dataSourceProperty.SetValue(control, null);
					dataSourceProperty.SetValue(control, dataSource);
				}
			}
		}

		private void ApplyPermissions()
		{
			if (_userPermission == null || _userPermission.Count <= 0) return;

			_canAdd = GetPermissionValue<bool>("CanAdd");
			_canEdit = GetPermissionValue<bool>("CanEdit");
			_canDelete = GetPermissionValue<bool>("CanDelete");
			_canPrint = GetPermissionValue<bool>("CanPrint");
			_isAdmin = GetPermissionValue<bool>("IsAdmin");

			SetButtonPermissions();
			SetGridPermissions();
		}

		private T GetPermissionValue<T>(string controlName)
		{
			var permission = _userPermission?.SingleOrDefault(x => x.ControlName == controlName)?.Value;
			if (permission == null)
				return default;

			try
			{
				return (T)Convert.ChangeType(permission, typeof(T));
			}
			catch
			{
				return default;
			}
		}

		private void SetButtonPermissions()
		{
			btnNew.Enabled = _isAdmin || _canAdd;
			btnSave.Enabled = _isAdmin || _canEdit;
			btnSaveAndClose.Enabled = _isAdmin || _canEdit;
			btnRefresh.Enabled = _isAdmin || _canEdit;
			btnPrint.Enabled = _isAdmin || _canPrint;
			btnDelete.Enabled = _isAdmin || _canDelete;
		}

		private void SetGridPermissions()
		{
			ConfigureGridRowPermissions(gvQuotationCost, _canAdd, _canDelete);

			// Selling grid always allows add/delete per original logic
			gvQuotationSelling.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
			gvQuotationSelling.OptionsBehavior.AllowAddRows = DefaultBoolean.True;
			gvQuotationSelling.OptionsBehavior.AllowDeleteRows = DefaultBoolean.True;
		}

		private void ConfigureGridRowPermissions(GridView view, bool canAdd, bool canDelete)
		{
			view.OptionsView.NewItemRowPosition = canAdd ? NewItemRowPosition.Bottom : NewItemRowPosition.None;
			view.OptionsBehavior.AllowAddRows = canAdd ? DefaultBoolean.True : DefaultBoolean.False;
			view.OptionsBehavior.AllowDeleteRows = canDelete ? DefaultBoolean.True : DefaultBoolean.False;
		}

		private void ApplyDefaults()
		{
			SetProvisionColumnsVisibility(_costHeaderSelling.DisplayProvisionColumns);
		}

		private void SetProvisionColumnsVisibility(bool visible)
		{
			var provisionColumns = new[] { "ProvisionAmount", "ProvisionAmountLL", "ProvisionAmountUSD" };
			int visibleIndex = 9;

			foreach (var columnName in provisionColumns)
			{
				var column = gvQuotationCost.Columns[columnName];
				if (column != null)
				{
					column.Visible = visible;
					column.VisibleIndex = visibleIndex++;
				}
			}
		}

		private void InitNewSettings()
		{
			dtQuoteDate.EditValue = DateTime.Now;
			dtBookedDate.EditValue = DateTime.Now;
			UpdateDefaultRate();
		}

		private void InitializeMenuItems()
		{
			_menuItems = new[]
			{
				new DXMenuItem("Edit", ItemEdit_Click),
				new DXMenuItem("Delete", ItemDelete_Click)
			};
		}

		#endregion
		#region Save and Data Operations

		private void SaveChanges()
		{
			try
			{
				CommitGridChanges();
				PrepareModelForSave();
				PersistChanges();
				PopulateDetails();
				SendUpdatedCostSelling?.Invoke(true, EventArgs.Empty);
			}
			catch (Exception e)
			{
				ShowError(e.Message);
			}
		}

		private void CommitGridChanges()
		{
			gvQuotationCost.UpdateCurrentRow();
			gvQuotationSelling.UpdateCurrentRow();
			//bsQuotationHeader.EndEdit();
			_bsQuotationRealCostList.EndEdit();
			_bsQuotationSellingList.EndEdit();
		}

		private void PrepareModelForSave()
		{
			//_costHeaderSelling = (QuotationHeaderModel)bsQuotationHeader.Current;
			_costHeaderSelling.QuotationRealCostDetails = (List<QuotationCostModel>)_bsQuotationRealCostList.DataSource;
			_costHeaderSelling.QuotationSellingModels = (List<QuotationSellingModel>)_bsQuotationSellingList.DataSource;

			if (cboCarriers.EditValue != null)
			{
				_costHeaderSelling.SeaCarrierId = (int)cboCarriers.EditValue;
			}
		}

		private void PersistChanges()
		{
			if (_costHeaderSelling.Id == 0 && txtJobNo.Text == @"0")
			{
				//var costSellingModel = QuotationBookingSheetDal.AddNewQuotationHeader(_costHeaderSelling);
				//txtJobNo.Text = costSellingModel.Id.ToString();
			}
			else
			{
				QuotationBookingSheetDal.UpdateQuotationHeaderCostSelling(_costHeaderSelling);
			}
		}

		private void PopulateDetails()
		{
			_quotationRealCostList = _realCostRepository.SelectRealCostByQuotationId(
				_costHeaderSelling.QuotationId, _costHeaderSelling.VersionNo);
			_quotationSellingList = _sellingRepository.SelectSellingByQuotationId(
				_costHeaderSelling.QuotationId, _costHeaderSelling.VersionNo);

			BindGridWithBindingSource(gcQuotationCost, _bsQuotationRealCostList, _quotationRealCostList);
			BindGridWithBindingSource(gcQuotationSelling, _bsQuotationSellingList, _quotationSellingList);
		}

		#endregion

		#region Button Events

		private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
		{
			_costHeaderSelling = new QuotationHeaderModel();
			InitNewSettings();
		}

		private void btnSave_ItemClick(object sender, ItemClickEventArgs e) => SaveChanges();

		private void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			SaveChanges();
			Close();
		}

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{
			// Reserved for future implementation
		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (_costHeaderSelling.Id <= 0) return;

			if (!ConfirmAction($"Are you sure you want to delete Cost/Selling records: `{txtJobNo.Text}`?", "Confirm Delete"))
				return;

			try
			{
				QuotationBookingSheetDal.DeleteCostSellingQuotation(_costHeaderSelling.Id);
				SendUpdatedCostSelling?.Invoke(_costHeaderSelling, EventArgs.Empty);
				Close();
			}
			catch (Exception ex)
			{
				ShowError(ex.Message, "User delete error");
			}
		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{
			var dataReportModels = (List<CostSellingReportModel>)QuotationDal.GetCostSellingQuotationsReportById(
				_costHeaderSelling.QuotationId, _costHeaderSelling.VersionNo);

			using (var previewForm = new DocumentViewerForm())
			{
				var report = new CostSellingReport { DataSource = dataReportModels };
				previewForm.Viewer.DocumentSource = report;
				previewForm.ShowDialog();
			}
		}

		private void btnClose_ItemClick(object sender, ItemClickEventArgs e) => Close();

		#endregion

		private void txtValidity_EditValueChanged(object sender, EventArgs e)
		{
			// Reserved for future implementation
		}

		#region Populate Items Detail

		private void PopulateNewRealCostItems(int itemId, string itemDescription)
		{
			var cost = new QuotationCostModel
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
			_quotationRealCostList.Add(cost);
		}

		private void PopulateNewSellingItems(int itemId, string itemDescription)
		{
			var selling = new QuotationSellingModel
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
			_quotationSellingList.Add(selling);
		}

		#endregion

		#region Grid Cell Value Changed Events

		private void gvQuotationCost_CellValueChanged(object sender, CellValueChangedEventArgs e)
		{
			HandleCellValueChanged(sender, e, isCostGrid: true);
		}

		private void gvQuotationSelling_CellValueChanged(object sender, CellValueChangedEventArgs e)
		{
			HandleCellValueChanged(sender, e, isCostGrid: false);
		}

		private void HandleCellValueChanged(object sender, CellValueChangedEventArgs e, bool isCostGrid)
		{
			var view = sender as GridView;
			if (view?.Columns == null) return;

			try
			{
				switch (e.Column.FieldName)
				{
					case "ItemId":
						SetCurrencyRate(view, e);
						CalculateAmount(view, e);
						UpdateItemDescription(view, e);
						if (isCostGrid) CalculateSalesCommission(view, e);
						break;

					case "Vat":
						SetVatRate(view, e);
						SetVatAmount(view, e);
						SetVatRateNotification(view, e);
						break;

					case "CurrencyId":
						SetCurrencyRate(view, e);
						CalculateAmount(view, e);
						break;

					case "Amount":
						CalculateAmount(view, e);
						break;
				}
			}
			catch (Exception ex)
			{
				ShowError(ex.Message, GetErrorTitle(e.Column.FieldName));
			}
		}

		private string GetErrorTitle(string fieldName)
		{
			switch (fieldName)
			{
				case "ItemId": return "Item missing";
				case "Amount": return "Currency Conversion Error";
				default: return "Error";
			}
		}

		private void UpdateItemDescription(GridView view, CellValueChangedEventArgs e)
		{
			int itemId = ParseInt(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["ItemId"]));
			if (itemId <= 0) return;

			string itemDesc = _itemRepository.SelectItemById(itemId)?.Description;
			if (!string.IsNullOrEmpty(itemDesc))
			{
				view.SetRowCellValue(e.RowHandle, "Description", itemDesc);
			}
		}

		#endregion

		#region Sales Commission

		private void CalculateSalesCommission(GridView view, CellValueChangedEventArgs e)
		{
			int itemId = ParseInt(view.GetRowCellValue(e.RowHandle, "ItemId"));
			if (itemId == CommissionItemId)
			{
				// Reserved for commission calculation
			}
		}

		#endregion


		#region Amount Calculations

		private void CalculateAmount(GridView view, CellValueChangedEventArgs e)
		{
			if (view?.Columns == null) return;

			DateTime quoteDate = ParseDateTime(dtBookedDate.EditValue?.ToString()) ?? dtBookedDate.DateTime;
			int currencyId = ParseInt(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["CurrencyId"]));
			decimal amount = ParseDecimal(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Amount"]));
			bool isVat = ParseBool(view.GetRowCellValue(e.RowHandle, "Vat"));

			var exchangeRates = GetExchangeRates(currencyId, quoteDate);

			view.SetRowCellValue(e.RowHandle, "LocalAmount", amount * exchangeRates.LocalRate);
			view.SetRowCellValue(e.RowHandle, "ForeignAmount", amount * exchangeRates.LocalRate / exchangeRates.ForeignRate);

			if (isVat)
			{
				SetVatAmount(view, e);
			}
		}

		private (decimal LocalRate, decimal ForeignRate) GetExchangeRates(int currencyId, DateTime date)
		{
			var localExchange = _currencyExchangeRepository.SelectExchangeCurrency(currencyId, date);
			var foreignExchange = _currencyExchangeRepository.SelectExchangeCurrency(_defaultForeignCurrency, date);

			return (
				LocalRate: localExchange?.ExchangeValue ?? 0,
				ForeignRate: foreignExchange?.ExchangeValue ?? 1
			);
		}

		#endregion

		#region VAT Calculations

		private void SetVatAmount(GridView view, CellValueChangedEventArgs e)
		{
			DateTime quoteDate = ParseDateTime(dtBookedDate.EditValue?.ToString()) ?? dtBookedDate.DateTime;
			int currencyId = ParseInt(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["CurrencyId"]));
			decimal amount = ParseDecimal(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Amount"]));
			decimal vatRate = ParseDecimal(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["VatRate"]));

			var exchangeRates = GetExchangeRates(currencyId, quoteDate);
			decimal vatMultiplier = vatRate / 100;

			view.SetRowCellValue(e.RowHandle, "VatAmount", amount * vatMultiplier);
			view.SetRowCellValue(e.RowHandle, "LocalVatAmount", amount * vatMultiplier * exchangeRates.LocalRate);
			view.SetRowCellValue(e.RowHandle, "ForeignVatAmount", (amount * vatMultiplier * exchangeRates.LocalRate) / exchangeRates.ForeignRate);
		}

		private void SetVatRateNotification(GridView view, CellValueChangedEventArgs e)
		{
			var noteMessage = new StringBuilder();
			string currentNotes = view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Notes"])?.ToString() ?? string.Empty;
			noteMessage.Append(currentNotes);

			bool isVat = ParseBool(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Vat"]));

			if (isVat)
			{
				if (!currentNotes.Contains(VatNoteMessage))
				{
					noteMessage.Append(VatNoteMessage);
				}
			}
			else
			{
				noteMessage.Replace(VatNoteMessage, string.Empty);
			}

			view.SetRowCellValue(e.RowHandle, "Notes", noteMessage.ToString());
		}

		private void SetVatRate(GridView view, CellValueChangedEventArgs e)
		{
			bool isVat = ParseBool(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Vat"]));
			view.SetRowCellValue(e.RowHandle, "VatRate", isVat ? _defaultVat : 0);
		}

		private void SetCurrencyRate(GridView view, CellValueChangedEventArgs e)
		{
			int currencyId = ParseInt(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["CurrencyId"]));
			DateTime currencyDate = _costHeaderSelling.BookingDate ?? dtBookedDate.DateTime;

			var currencyExchange = _currencyExchangeRepository.SelectExchangeCurrency(currencyId, currencyDate);
			view.SetRowCellValue(e.RowHandle, "Rate", currencyExchange?.ExchangeValue ?? 0);
		}

		#endregion

		#region Parsing Helpers

		private DateTime? ParseDateTime(string value) =>
			DateTime.TryParse(value, out var result) ? result : (DateTime?)null;

		private int ParseInt(object value) =>
			int.TryParse(value?.ToString(), out var result) ? result : 0;

		private decimal ParseDecimal(object value) =>
			decimal.TryParse(value?.ToString(), out var result) ? result : 0m;

		private bool ParseBool(object value) =>
			bool.TryParse(value?.ToString(), out var result) && result;

		#endregion

		#region Grid New Row Initialization

		private void gvQuotationCost_InitNewRow(object sender, InitNewRowEventArgs e)
		{
			var view = sender as GridView;
			InitializeNewCostRow(view, e.RowHandle);
		}

		private void gvQuotationSelling_InitNewRow(object sender, InitNewRowEventArgs e)
		{
			var view = sender as GridView;
			InitializeNewSellingRow(view, e.RowHandle);
		}

		private void InitializeNewCostRow(GridView view, int rowHandle)
		{
			SetCommonNewRowValues(view, rowHandle);
			view.SetRowCellValue(rowHandle, view.Columns["AgentId"], _costHeaderSelling.AgentId);
		}

		private void InitializeNewSellingRow(GridView view, int rowHandle)
		{
			SetCommonNewRowValues(view, rowHandle);
			view.SetRowCellValue(rowHandle, view.Columns["MemberId"], _costHeaderSelling.MemberId);
		}

		private void SetCommonNewRowValues(GridView view, int rowHandle)
		{
			view.SetRowCellValue(rowHandle, view.Columns["QHeaderId"], _costHeaderSelling.QuotationId);
			view.SetRowCellValue(rowHandle, view.Columns["PaymentId"], _defaultPaymentMethod);
			view.SetRowCellValue(rowHandle, view.Columns["CurrencyId"], _defaultForeignCurrency);
			view.SetRowCellValue(rowHandle, view.Columns["Rate"], _defaultRate);
			view.SetRowCellValue(rowHandle, view.Columns["Vat"], 0);
		}

		#endregion

		#region Grid Row Filter

		private void gvQuotationCost_CustomRowFilter(object sender, RowFilterEventArgs e)
		{
			FilterDeletedRows<QuotationCostModel>(sender, e, _bsQuotationRealCostList);
		}

		private void gvQuotationSelling_CustomRowFilter(object sender, RowFilterEventArgs e)
		{
			FilterDeletedRows<QuotationSellingModel>(sender, e, _bsQuotationSellingList);
		}

		private void FilterDeletedRows<T>(object sender, RowFilterEventArgs e, BindingSource bindingSource) where T : class
		{
			if (bindingSource?[e.ListSourceRow] is T model)
			{
				bool isDeleted = (model as dynamic).Deleted;
				if (isDeleted)
				{
					e.Visible = false;
					e.Handled = true;
				}
			}
		}

		#endregion

		#region Grid Key Events

		private void gvQuotationCost_KeyUp(object sender, KeyEventArgs e)
		{
			HandleDeleteKeyPress(sender as GridView, e);
		}

		private void gvQuotationSelling_KeyUp(object sender, KeyEventArgs e)
		{
			HandleDeleteKeyPress(sender as GridView, e);
		}

		private void HandleDeleteKeyPress(GridView view, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Delete) return;
			if (!ConfirmAction("Delete row?", "Confirmation")) return;

			view?.SetRowCellValue(view.FocusedRowHandle, "Deleted", true);
		}

		#endregion

		#region Grid Popup Menu

		private void ItemEdit_Click(object sender, EventArgs e)
		{
			gvQuotationCost.ShowEditor();
		}

		private void ItemDelete_Click(object sender, EventArgs e)
		{
			if (!ConfirmAction("Delete row?", "Confirmation")) return;

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
			ShowGridPopupMenu(sender as GridView, e);
		}

		private void gvQuotationSelling_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
		{
			ShowGridPopupMenu(sender as GridView, e);
		}

		private void ShowGridPopupMenu(GridView view, PopupMenuShowingEventArgs e)
		{
			if (!e.HitInfo.InRow) return;

			view.FocusedRowHandle = e.HitInfo.RowHandle;
			foreach (var item in _menuItems)
			{
				e.Menu.Items.Add(item);
			}
		}

		#endregion

		#region Grid Summary Calculations

		private void gvQuotationCost_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
		{
			CalculateCustomSummary(sender as GridView, e, _costTotals, isCostGrid: true);
		}

		private void gvQuotationSelling_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
		{
			CalculateCustomSummary(sender as GridView, e, _sellingTotals, isCostGrid: false);
		}

		private void CalculateCustomSummary(GridView view, CustomSummaryEventArgs e, SummaryTotals totals, bool isCostGrid)
		{
			var summaryId = Convert.ToInt32((e.Item as GridSummaryItem)?.Tag);

			switch (e.SummaryProcess)
			{
				case CustomSummaryProcess.Start:
					totals.Reset();
					break;

				case CustomSummaryProcess.Calculate:
					CalculateSummaryRow(view, e, totals, summaryId, isCostGrid);
					break;

				case CustomSummaryProcess.Finalize:
					FinalizeSummary(e, totals, summaryId, isCostGrid);
					break;
			}
		}

		private void CalculateSummaryRow(GridView view, CustomSummaryEventArgs e, SummaryTotals totals, int summaryId, bool isCostGrid)
		{
			bool isVat = ParseBool(view.GetRowCellValue(e.RowHandle, "Vat"));
			decimal vatRate = ParseDecimal(view.GetRowCellValue(e.RowHandle, "VatRate"));
			decimal fieldValue = Convert.ToDecimal(e.FieldValue);

			switch (summaryId)
			{
				case 1: // LL field
					totals.TotalLL += fieldValue;
					if (isVat)
					{
						totals.VatLL += fieldValue * vatRate / 100;
						string vatColumnName = isCostGrid ? "CostVatAmountLL" : "SellingVatAmountLL";
						view.SetRowCellValue(e.RowHandle, vatColumnName, totals.VatLL);
					}
					if (isCostGrid && IsCommissionItem(view, e.RowHandle))
					{
						totals.CommissionLL += ParseDecimal(view.GetRowCellValue(e.RowHandle, "LocalAmount"));
					}
					break;

				case 2: // USD field
					totals.TotalUSD += fieldValue;
					if (isVat)
					{
						totals.VatUSD += fieldValue * vatRate / 100;
						string vatColumnName = isCostGrid ? "CostVatAmountUSD" : "SellingVatAmountUSD";
						view.SetRowCellValue(e.RowHandle, vatColumnName, totals.VatUSD);
					}
					if (isCostGrid && IsCommissionItem(view, e.RowHandle))
					{
						totals.CommissionUSD += ParseDecimal(view.GetRowCellValue(e.RowHandle, "ForeignAmount"));
					}
					break;
			}
		}

		private bool IsCommissionItem(GridView view, int rowHandle)
		{
			int itemId = ParseInt(view.GetRowCellValue(rowHandle, "ItemId"));
			return itemId == CommissionItemId;
		}

		private void FinalizeSummary(CustomSummaryEventArgs e, SummaryTotals totals, int summaryId, bool isCostGrid)
		{
			switch (summaryId)
			{
				case 1:
					e.TotalValue = totals.TotalLL;
					break;

				case 2:
					e.TotalValue = totals.TotalUSD;
					UpdateSummaryTextBoxes(totals, isCostGrid);
					break;
			}

			UpdateProfitCalculations();
		}

		private void UpdateSummaryTextBoxes(SummaryTotals totals, bool isCostGrid)
		{
			if (isCostGrid)
			{
				txtTotalCostUSD.Text = (totals.TotalUSD - totals.CommissionUSD).ToString(CultureInfo.InvariantCulture);
				txtTotalCostVat.Text = totals.VatUSD.ToString(CultureInfo.InvariantCulture);
				txtTotalCommission.Text = totals.CommissionUSD.ToString(CultureInfo.InvariantCulture);
				txtGrossCommission.Text = totals.CommissionUSD.ToString(CultureInfo.InvariantCulture);
			}
			else
			{
				txtTotalSellingUSD.Text = totals.TotalUSD.ToString(CultureInfo.InvariantCulture);
				txtTotalSellingVat.Text = totals.VatUSD.ToString(CultureInfo.InvariantCulture);
			}
		}

		private void UpdateProfitCalculations()
		{
			txtTotalVAT.Text = (_sellingTotals.VatUSD - _costTotals.VatUSD).ToString(CultureInfo.InvariantCulture);
			txtGrossProfit.Text = (_sellingTotals.TotalUSD - _costTotals.TotalUSD + _costTotals.CommissionUSD).ToString(CultureInfo.InvariantCulture);
			txtNetProfitLL.Text = (_sellingTotals.NetLL - _costTotals.NetLL).ToString();
			txtNetProfitUSD.Text = (_sellingTotals.NetUSD - _costTotals.NetUSD).ToString();
		}

		#endregion

		#region Miscellaneous Events

		private void chkDisplayProvisionColumns_CheckedChanged(object sender, EventArgs e)
		{
			SetProvisionColumnsVisibility(chkDisplayProvisionColumns.Checked);
		}

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!ConfirmAction("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu..."))
				return;

			_resetMenu = true;
			LayoutsStyle.ResetLayoutGrid(gvQuotationCost, CurrentUser.UserName, CurrentUser.CompanyName);
			LayoutsStyle.ResetLayoutGrid(gvQuotationSelling, CurrentUser.UserName, CurrentUser.CompanyName);
		}

		private void CostSellingSheetForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_resetMenu) return;

			LayoutsStyle.SaveLayoutGrid(gvQuotationCost, CurrentUser.UserName, CurrentUser.CompanyName);
			LayoutsStyle.SaveLayoutGrid(gvQuotationSelling, CurrentUser.UserName, CurrentUser.CompanyName);
		}

		#endregion

		#region UI Helper Methods

		private void ShowError(string message, string title = "Error")
		{
			XtraMessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private bool ConfirmAction(string message, string title)
		{
			return XtraMessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2) == DialogResult.Yes;
		}

		#endregion
	}
}