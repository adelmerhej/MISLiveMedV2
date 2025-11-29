using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Common.Companies;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Currencies;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Companies;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.Common.Companies
{
	public partial class CompaniesListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "CompaniesList";
		private int _formId;
		private bool _resetMenu;

		private IList<CompanyModel> _companies = new List<CompanyModel>();
		private CompanyModel _companyModel = new CompanyModel();
		private IList<CountryModel> _countries = new List<CountryModel>();
		private IList<CityModel> _cities = new List<CityModel>();
		private IList<CurrencyModel> _currencies = new List<CurrencyModel>();

		private readonly CompanyRepository _companyRepository = new CompanyRepository();
		private readonly CountryRepository _countryRepository = new CountryRepository();
		private readonly CityRepository _cityRepository = new CityRepository();
		private readonly CurrencyRepository _currencyRepository = new CurrencyRepository();

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

		#region Implementation of IFormWithRibbon

		public RibbonControl MainRibbon => rcCompaniesList;
		public RibbonPage DefaultPage => rpCompaniesList;


		#endregion

		public CompaniesListForm()
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

				_companies = _companyRepository.SelectCompanies();
				_countries = _countryRepository.SelectCountries();
				_cities = _cityRepository.SelectCities();
				_currencies = _currencyRepository.SelectCurrencies();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			gcCompanies.DataSource = null;
			gcCompanies.DataSource = _companies;

			repCountries.DataSource = null; 
			repCountries.DataSource = _countries; 

			repCities.DataSource = null;
			repCities.DataSource = _cities;

			repLocalCurrencies.DataSource = null;
			repLocalCurrencies.DataSource = _currencies;

			repForeignCurrencies.DataSource = null;
			repForeignCurrencies.DataSource = _currencies;
		}

		private void ApplyDefaults()
		{
			LayoutsStyle.LoadLayoutGrid(gvCompanies, CurrentUser.UserName, CurrentUser.CompanyName);
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
			btnEdit.Enabled = _isAdmin || _canEdit;
			btnPrint.Enabled = _isAdmin || _canPrint;
			btnDelete.Enabled = _isAdmin || _canDelete;
		}

		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			CompanyEditForm frm = new CompanyEditForm(new CompanyModel());
			frm.SendUpdatedCompany += RcvUpdatedCompany;
			frm.ShowDialog();
		}

		private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!_companies.Any()) return;

			int currentRowId = (int)gvCompanies.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_companyModel = _companies.SingleOrDefault(x => x.Id == currentRowId);
			if (_companyModel == null) return;

			var frm = new CompanyEditForm(_companyModel);
			frm.SendUpdatedCompany += RcvUpdatedCompany;
			frm.ShowDialog();
		}

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{
			InitializeBindings();
			WireUpBindings();
		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcCompanies.ShowRibbonPrintPreview();
		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!CanDelete()) return;

			try
			{
				int.TryParse(gvCompanies.GetFocusedRowCellValue("Id").ToString(), out int id);
				string name = gvCompanies.GetFocusedRowCellValue("CompanyName").ToString();

				if (id > 0)
				{
					if (XtraMessageBox.Show($"Are you sure you want to delete Record: `{name}`?",
						    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
						    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						_companyModel = gvCompanies.GetFocusedRow() as CompanyModel;
						if (_companyModel == null)
						{
							return;
						}
						_companyModel.Deleted = true;

						//delete the record
						_companyRepository.DeleteCompany(_companyModel.Id);
						RcvUpdatedCompany(_companyModel, EventArgs.Empty);
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

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvCompanies, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		private void CompaniesListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvCompanies, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		#endregion

		private void RcvUpdatedCompany(object sender, EventArgs e)
		{
			if (sender == null) return;
			_companyModel = sender as CompanyModel;

			if (_companyModel.LastModifiedDate == null || _companyModel.Deleted)
			{
				InitializeBindings();
				WireUpBindings();
			}
			else
			{
				gvCompanies.UpdateCurrentRow();
			}
		}

		private void gcCompanies_DoubleClick(object sender, EventArgs e)
		{
			if (!_isAdmin && !_canEdit) return;

			if (!_companies.Any()) return;

			int currentRowId = (int)gvCompanies.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_companyModel = _companies.SingleOrDefault(x => x.Id == currentRowId);
			if (_companyModel == null) return;

			var frm = new CompanyEditForm(_companyModel);
			frm.SendUpdatedCompany += RcvUpdatedCompany;
			frm.ShowDialog();
		}

		private void gvCompanies_RowCellStyle(object sender, RowCellStyleEventArgs e)
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
					e.Appearance.ForeColor = Color.Gray;
					e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Italic);
				}
			}
		}

		private bool CanDelete()
		{
			CompanyModel dataBoundItem = gvCompanies.GetFocusedRow() as CompanyModel;

			if (gvCompanies == null || gvCompanies.SelectedRowsCount == 0) return false;
			if (gvCompanies.SelectedRowsCount > 1)
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

	}
}