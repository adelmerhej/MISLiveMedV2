using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Accounting.Provisions;
using MISLiveMed.DataLayers.Common.Currencies;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.Provisions;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.DateTimeUtils;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Accounting.Provisions
{
	public partial class ProvisionsForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "ProvisionsForm";
		private int _formId;
		private bool _resetMenu;

		DXMenuItem[] _menuItems;

		private IList<ProvisionModel> _suppliersProvisions = new List<ProvisionModel>();
		private IList<ProvisionModel> _customersProvisions = new List<ProvisionModel>();

		private IList<CurrencyModel> _currencies = new List<CurrencyModel>();
		private IList<int> _workingYears = new List<int>();

		private ProvisionRepository _provisionRepository = new ProvisionRepository();
		private CurrencyRepository _currencyRepository = new CurrencyRepository();
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

		#region Default Parameters

		private readonly int _defaultForeignCurrency = 2;

		#endregion

		#region Implementation of IFormWithRibbon

		public RibbonControl MainRibbon => rcRibbonList;
		public RibbonPage DefaultPage => rpRibbonList;


		#endregion

		public ProvisionsForm()
		{
			InitializeComponent();

			try
			{
				InitializeBindings();
				WireUpBindings();
				ApplyDefaults();
				ApplyPermissions();
				InitializeMenuItems();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void InitializeBindings()
		{
			try
			{               //
				_formId = _formRepository.SelectFormByName(_formName);
				_userPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, _formId);
				if (_userPermission != null && _userPermission.Count > 0)
				{
					var isProtected = _userPermission.SingleOrDefault(x => x.ControlName == "IsProtected")?.Value;
					if (isProtected != null) _isProtected = (bool)isProtected;
				}
				//

				_suppliersProvisions = _provisionRepository.SelectProvisionsByTypeId(ProvisionsType.Suppliers);
				_customersProvisions = _provisionRepository.SelectProvisionsByTypeId(ProvisionsType.Customers);
				_currencies = _currencyRepository.SelectCurrencies();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsSuppliersProvisions.DataSource = _suppliersProvisions;
			bsCustomersProvisions.DataSource = _customersProvisions;

			gcSuppliersProvisions.DataSource = null;
			gcSuppliersProvisions.DataSource = bsSuppliersProvisions;

			gcCustomersProvisions.DataSource = null;
			gcCustomersProvisions.DataSource = bsCustomersProvisions;


			repSuppliersCurrencies.DataSource = null;
			repSuppliersCurrencies.DataSource = _currencies;

			repCustomersCurrencies.DataSource = null;
			repCustomersCurrencies.DataSource = _currencies;

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

			btnSave.Enabled = _isAdmin || _canEdit;
			btnSaveAndClose.Enabled = _isAdmin || _canEdit;
			btnRefresh.Enabled = _isAdmin || _canEdit;
			btnPrint.Enabled = _isAdmin || _canPrint;
			btnDelete.Enabled = _isAdmin || _canDelete;
		}

		private void ApplyDefaults()
		{
			_workingYears = DateTimeUtils.CountYearsToDate();

			gvSuppliersProvisions.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
			gvSuppliersProvisions.OptionsBehavior.AllowAddRows = DefaultBoolean.True;
			gvSuppliersProvisions.OptionsBehavior.AllowDeleteRows = DefaultBoolean.True;

			gvCustomersProvisions.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
			gvCustomersProvisions.OptionsBehavior.AllowAddRows = DefaultBoolean.True;
			gvCustomersProvisions.OptionsBehavior.AllowDeleteRows = DefaultBoolean.True;

			tabPane1.SelectedPageIndex = 0;
		}

		void InitializeMenuItems()
		{
			//DXMenuItem addNewBranch = new DXMenuItem("Edit", AddNewBranch_Click);
			//DXMenuItem editBranch = new DXMenuItem("Edit", EditBranch_Click);
			//DXMenuItem deleteBranch = new DXMenuItem("Delete", DeleteBranch_Click);
			//_menuItems = new[] { addNewBranch, editBranch, deleteBranch };
		}

		#region Buttons Event

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

			InitializeBindings();
			WireUpBindings();
		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (tabPane1.SelectedPageIndex == 0)
			{
				gvSuppliersProvisions.ShowRibbonPrintPreview();

			}
			if (tabPane1.SelectedPageIndex == 1)
			{
				gvCustomersProvisions.ShowRibbonPrintPreview();

			}
		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			//delete
		}

		private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			Close();
		}

		#endregion

		#region Grid Events

		private void gvSuppliersProvisions_CellValueChanged(object sender, CellValueChangedEventArgs e)
		{
			GridView view = sender as GridView;

			try
			{
				if (e.Column.FieldName == "CurrencyId")
				{
					SetCurrencyRate(sender, e);
					CalculateAmount(sender, e);
				}

				if (e.Column.FieldName == "Amount")
				{
					CalculateAmount(sender, e);
				}
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message, @"Validation Error",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void gvCustomersProvisions_CellValueChanged(object sender, CellValueChangedEventArgs e)
		{
			GridView view = sender as GridView;

			try
			{
				if (e.Column.FieldName == "CurrencyId")
				{
					SetCurrencyRate(sender, e);
					CalculateAmount(sender, e);
				}

				if (e.Column.FieldName == "Amount")
				{
					CalculateAmount(sender, e);
				}
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message, @"Validation Error",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void gvSuppliersProvisions_InitNewRow(object sender, InitNewRowEventArgs e)
		{
			GridView view = sender as GridView;

			//Set static values for new entry
			view.SetRowCellValue(e.RowHandle, view.Columns["ProvisionDate"], DateTime.Now);
			view.SetRowCellValue(e.RowHandle, view.Columns["CurrencyId"], _defaultForeignCurrency);
		}

		private void gvCustomersProvisions_InitNewRow(object sender, InitNewRowEventArgs e)
		{
			GridView view = sender as GridView;

			//Set static values for new entry
			view.SetRowCellValue(e.RowHandle, view.Columns["ProvisionDate"], DateTime.Now);
			view.SetRowCellValue(e.RowHandle, view.Columns["CurrencyId"], _defaultForeignCurrency);
		}

		#endregion


		#region Function Events

		private void SetCurrencyRate(object sender, CellValueChangedEventArgs e)
		{
			GridView view = sender as GridView;

			_ = int.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["CurrencyId"]).ToString(), out int currencyId);
			_ = DateTime.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["ProvisionDate"]).ToString(), out DateTime transactionDate);

			var currencyDate = transactionDate;
			var currencyExchangeRate = _currencyExchangeRepository.SelectExchangeCurrency(currencyId, currencyDate);

			if(currencyExchangeRate != null)
				view.SetRowCellValue(e.RowHandle, "Rate", currencyExchangeRate.ExchangeValue);
		}


		private void CalculateAmount(object sender, CellValueChangedEventArgs e)
		{
			if (!(sender is GridView view) || view.Columns == null) return;

			try
			{
				_ = int.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["CurrencyId"]).ToString(), out int currencyId);
				_ = DateTime.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["ProvisionDate"]).ToString(), out DateTime transactionDate);

				// Fetch exchange rates
				var currencyExchangeRate = _currencyExchangeRepository.SelectExchangeCurrency(currencyId, transactionDate);
				var currencyExchangeUsdRate = _currencyExchangeRepository.SelectExchangeCurrency(_defaultForeignCurrency, transactionDate);

				decimal exchangeRate = currencyExchangeRate?.ExchangeValue ?? 0;
				decimal exchangeUsdRate = currencyExchangeUsdRate?.ExchangeValue ?? 1; // Avoid division by zero

				_ = decimal.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Amount"]).ToString(), out decimal amount);

				view.SetRowCellValue(e.RowHandle, "LAmount", amount * exchangeRate);
				view.SetRowCellValue(e.RowHandle, "FAmount", (amount * exchangeRate) / exchangeUsdRate);
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, @"Calculate Amount Error",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void SaveChanges()
		{
			try
			{

				switch (tabPane1.SelectedPageIndex)
				{

					case 0:
						gvSuppliersProvisions.UpdateCurrentRow();
						bsSuppliersProvisions.EndEdit();

						_suppliersProvisions = (List<ProvisionModel>)bsSuppliersProvisions.DataSource;

						foreach (ProvisionModel provisionModel in _suppliersProvisions)
						{
							var exists = provisionModel.Id > 0;
							provisionModel.ProvisionTypeId = (int)ProvisionsType.Suppliers;

							if (exists)
							{
								_provisionRepository.UpdateProvision(provisionModel);
							}
							else
							{
								_provisionRepository.AddNewProvision(provisionModel);
							}
						}

						break;

					case 1:
						gvCustomersProvisions.UpdateCurrentRow();
						bsCustomersProvisions.EndEdit();

						_customersProvisions = (List<ProvisionModel>)bsCustomersProvisions.DataSource;

						foreach (ProvisionModel provisionModel in _customersProvisions)
						{
							var exists = provisionModel.Id > 0;
							provisionModel.ProvisionTypeId = (int)ProvisionsType.Customers;

							if (exists)
							{
								_provisionRepository.UpdateProvision(provisionModel);
							}
							else
							{
								_provisionRepository.AddNewProvision(provisionModel);
							}
						}

						break;
				}



			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, @"On Save Error",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}


		#endregion


	}
}