using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.AspNet.Identity;
using MISLiveMed.DataLayers.Common.Companies;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Currencies;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Companies;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Common.Forms;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Forms.Common.Countries;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Common;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.Common.Companies
{
	public partial class CompanyEditForm : RibbonForm
	{
		private const string _formName = "CompanyEdit";
		private int _formId;
		private bool _resetMenu;

		DXMenuItem[] _menuItems;

		private DataEntityState _objState = DataEntityState.Unchanged;

		private IList<CompanyModel> _companies = new List<CompanyModel>();
		private CompanyModel _companyModel = new CompanyModel();

		private CountryModel _countryModel = new CountryModel();
		private IList<CountryModel> _countries = new List<CountryModel>();

		private CityModel _cityModel = new CityModel();
		private IList<CityModel> _cities = new List<CityModel>();

		private CurrencyModel _currencyModel = new CurrencyModel();
		private IList<CurrencyModel> _currencies = new List<CurrencyModel>();

		private BranchModel _branchModel = new BranchModel();
		private IList<BranchModel> _branches = new List<BranchModel>();
		private CopyDataCheckListModel _copyDataCheckList = new CopyDataCheckListModel();

		private readonly CompanyRepository _companyRepository = new CompanyRepository();
		private readonly CountryRepository _countryRepository = new CountryRepository();
		private readonly CityRepository _cityRepository = new CityRepository();
		private readonly CurrencyRepository _currencyRepository = new CurrencyRepository();
		private readonly BranchRepository _branchRepository = new BranchRepository();

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
		private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
		private readonly FormRepository _formRepository = new FormRepository();
		private readonly LogInfoRepository _logInfoRepository = new LogInfoRepository();

		//Init permissionvariables
		private bool _canAdd;
		private bool _canEdit;
		private bool _canDelete;
		private bool _canPrint;
		private bool _isAdmin;
		private bool _isProtected;

		public EventHandler SendUpdatedCompany;

		public CompanyEditForm(CompanyModel model)
		{
			InitializeComponent();

			try
			{
				_companyModel = model;

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

				_countries = _countryRepository.SelectCountries();
				_cities = _cityRepository.SelectCities();
				_currencies = _currencyRepository.SelectCurrencies();
				_companies = _companyRepository.SelectCompanies();
				_branches = _branchRepository.SelectBranches();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsCompany.DataSource = _companyModel;
			bsBranches.DataSource = _branches;

			cboCountries.Properties.DataSource = null;
			cboCountries.Properties.DataSource = _countries;
			cboCountries.EditValue = _companyModel.CountryId;

			cboCities.Properties.DataSource = null;
			cboCities.Properties.DataSource = _cities;
			cboCities.EditValue = _companyModel.CityId;

			cboLocalCurrencies.Properties.DataSource = null;
			cboLocalCurrencies.Properties.DataSource = _currencies;
			cboLocalCurrencies.EditValue = _companyModel.LocalCurrency;

			cboForeignCurrencies.Properties.DataSource = null;
			cboForeignCurrencies.Properties.DataSource = _currencies;
			cboForeignCurrencies.EditValue = _companyModel.ForeignCurrency;

			repCompanies.DataSource = null;
			repCompanies.DataSource = _companies;
		}

		private void ApplyDefaults()
		{
			if (_companyModel.Id == 0)
			{
				_companyModel.Active = true;
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

			btnAddNewBranch.Enabled = _isAdmin || _canAdd;
			btnEditBranch.Enabled = _isAdmin || _canEdit;
			btnDeleteBranch.Enabled = _isAdmin || _canDelete;
		}

		void InitializeMenuItems()
		{
			DXMenuItem addNewBranch = new DXMenuItem("Edit", AddNewBranch_Click);
			DXMenuItem editBranch = new DXMenuItem("Edit", EditBranch_Click);
			DXMenuItem deleteBranch = new DXMenuItem("Delete", DeleteBranch_Click);
			_menuItems = new[] { addNewBranch, editBranch, deleteBranch };
		}

		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			_companyModel = new CompanyModel();
			bsCompany.DataSource = _companyModel;
			bsCompany.ResetBindings(true);
			ApplyDefaults();
		}

		private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!ValidateData()) return;
			SaveCompany();
		}

		private void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!ValidateData()) return;
			SaveCompany();
			Close();
		}

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{
			InitializeBindings();
			WireUpBindings();
		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			// Delete
		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{
			// Print
		}

		private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			Close();
		}

		private void AddNewBranch_Click(object sender, EventArgs e)
		{
			_companyModel = new CompanyModel();
			bsCompany.DataSource = _companyModel;
			bsCompany.ResetBindings(true);
		}

		private void EditBranch_Click(object sender, EventArgs e)
		{
			gvBranches.ShowEditor();
		}

		private void DeleteBranch_Click(object sender, EventArgs e)
		{
			int.TryParse(gvBranches.GetFocusedRowCellValue("Id").ToString(), out int id);
			if (id == 0) return;

			if (XtraMessageBox.Show(@"Delete row?", @"Confirmation", MessageBoxButtons.YesNo) !=
			    DialogResult.Yes)
				return;

			//GridView view = sender as GridView;
			gvBranches.SetRowCellValue(gvBranches.FocusedRowHandle, "Deleted", true);
		}

		private void btnAddNewBranch_ItemClick(object sender, ItemClickEventArgs e)
		{
			BranchEditForm frm = new BranchEditForm(new BranchModel());
			frm.SendUpdatedBranch += RcvUpdatedBranch;
			frm.ShowDialog();
		}

		private void btnEditBranch_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!_branches.Any()) return;

			int currentRowId = (int)gvBranches.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_branchModel = _branches.SingleOrDefault(x => x.Id == currentRowId);
			if (_branchModel == null) return;

			var frm = new BranchEditForm(_branchModel);
			frm.SendUpdatedBranch += RcvUpdatedBranch;
			frm.ShowDialog();
		}

		private void btnDeleteBranch_ItemClick(object sender, ItemClickEventArgs e)
		{
			DeleteBranch_Click(sender, e);
		}

		#endregion

		private void SaveCompany()
		{
			try
			{
				BindingContext[bsCompany].EndCurrentEdit();

				if (cboCountries.EditValue != null) _companyModel.CountryId = (int)cboCountries.EditValue;
				if (cboCities.EditValue != null) _companyModel.CityId = (int)cboCities.EditValue;

				if (cboLocalCurrencies.EditValue != null) _companyModel.LocalCurrency = (int)cboLocalCurrencies.EditValue;
				if (cboForeignCurrencies.EditValue != null) _companyModel.ForeignCurrency = (int)cboForeignCurrencies.EditValue;
				_companyModel.CompanyId = _companyModel.Id;
				_companyModel.BranchId = _companyModel.Id;

				if (_companyModel.Id == 0)
				{
					_companyModel.CreatedBy = CurrentUser.UserId;
					int newRecord = _companyRepository.AddNewCompany(_companyModel);
					if (newRecord == 0)
					{
						throw new Exception($"Error while saving : {txtCompanyName.Text}");
					}
					txtCompanyId.Text = newRecord.ToString();
					SeedDefaultForNewCompany(false);
				}
				else
				{
					_companyModel.LastModifiedBy = CurrentUser.UserId;
					_companyRepository.UpdateCompany(_companyModel);
				}

				SendUpdatedCompany(_companyModel, EventArgs.Empty);
				_objState = DataEntityState.Unchanged;
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message,
					"Error While saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool ValidateData()
		{
			var validateReturnValue = true;
			var messageNumber = 0;
			var validateMessage = new StringBuilder();

			if (txtCompanyName.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Company Name cannot be empty.");
				validateReturnValue = false;
				txtCompanyName.Focus();
			}

			if (txtShortName.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Short Name cannot be empty.");
				validateReturnValue = false;
				txtShortName.Focus();
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


		private void cboCountries_AddNewValue(object sender, AddNewValueEventArgs e)
		{
			CountryEditForm frm = new CountryEditForm(new CountryModel());
			frm.SendUpdatedCountry += RcvUpdatedCountry;
			frm.ShowDialog();
		}

		private void cboCities_AddNewValue(object sender, AddNewValueEventArgs e)
		{
			CityEditForm frm = new CityEditForm(new CityModel());
			frm.SendUpdatedCity += RcvUpdatedCity;
			frm.ShowDialog();
		}

		private void RcvUpdatedCountry(object sender, EventArgs e)
		{
			if (sender == null) return;
			_countryModel = sender as CountryModel;

			_countries.Add(_countryModel);

			cboCountries.Properties.DataSource = null;
			cboCountries.Properties.DataSource = _countries;
			if (_countryModel != null) cboCountries.EditValue = _countryModel.Id;
		}

		private bool CanDelete()
		{
			CityModel dataBoundItem = gvBranches.GetFocusedRow() as CityModel;

			if (gvBranches == null || gvBranches.SelectedRowsCount == 0) return false;
			if (gvBranches.SelectedRowsCount > 1)
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

		private void RcvUpdatedCity(object sender, EventArgs e)
		{
			if (sender == null) return;
			_cityModel = sender as CityModel;

			_cities.Add(_cityModel);

			cboCities.Properties.DataSource = null;
			cboCities.Properties.DataSource = _countries;
			if (_cityModel != null) cboCities.EditValue = _cityModel.Id;
		}

		private void RcvUpdatedBranch(object sender, EventArgs e)
		{
			if (sender == null) return;
			_branchModel = sender as BranchModel;

			if (_branchModel.LastModifiedDate == null || _branchModel.Deleted)
			{
				InitializeBindings();
				WireUpBindings();
			}
			else
			{
				gvBranches.UpdateCurrentRow();
			}
		}

		private void gvBranches_RowCellStyle(object sender, RowCellStyleEventArgs e)
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

		private void gcBranches_DoubleClick(object sender, EventArgs e)
		{
			if (!_branches.Any()) return;

			int currentRowId = (int)gvBranches.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_branchModel = _branches.SingleOrDefault(x => x.Id == currentRowId);
			if (_branchModel == null) return;

			var frm = new BranchEditForm(_branchModel);
			frm.SendUpdatedBranch += RcvUpdatedBranch;
			frm.ShowDialog();
		}
		private void btnSeedDefault_ItemClick(object sender, ItemClickEventArgs e)
		{
			CopyDataCheckListForm frm = new CopyDataCheckListForm();
			frm.SendUpdatedCheckList += RcvUpdatedCheckList;
			frm.ShowDialog();

			SeedDefaultForNewCompany();
			SeedOtherData();
			XtraMessageBox.Show("Seed Data completed!", @"Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void RcvUpdatedCheckList(object sender, EventArgs e)
		{
			if (sender == null) return;

			_copyDataCheckList = sender as CopyDataCheckListModel;
		}

		private void SeedDefaultForNewCompany(bool warning = true)
		{
			// Seed new company with default values
			if (_companyModel.Id == 1) return;

			//FormsCategories
			if (warning)
			{
				if (XtraMessageBox.Show(
						$"This action will set new default settings for a new company, do you wish to continue?",
						"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button1) == DialogResult.No) return;
			}

			try
			{
				//Default branch
				var exist = _branchRepository.SelectBranchById(_companyModel.BranchId);
				if (exist == null)
				{
					int newId = _branchRepository.AddNewBranch(new BranchModel
					{
						Name = "New Branch for " + txtCompanyName.Text,
						CompanyId = _companyModel.Id,
						BranchId = _companyModel.Id,
						CreatedBy = CurrentUser.UserId
					});
					BranchModel newBranch = _branchRepository.SelectBranchById(newId);
					_branches.Add(newBranch);

					gcBranches.DataSource = null;
					gcBranches.DataSource = _branches;

					_companyModel.CompanyId = newId;
					_companyModel.BranchId = newId;
					_companyRepository.UpdateCompany(_companyModel);
				}

				//default admin user for the new company
				var userExist = new UserRepository().SelectDefaultUserByCompanyId(_companyModel.Id);

				if (userExist == null)
				{
					SystemUtilities.PasswordHasher = new PasswordHasher();
					UserModel userModel = new UserModel
					{
						UserName = "admin",
						PasswordHash = SystemUtilities.PasswordHasher.HashPassword("admin"),
						SecurityStamp = Guid.NewGuid().ToString("D"),
						SecurityLevel = 1,
						FirstTimeAccess = true,
						PermissionChanged = true,
						Notes = "System Default",
						CompanyId = _companyModel.CompanyId,
						BranchId = _companyModel.BranchId,
						CreatedBy = CurrentUser.UserId,
						IsDefault = true
					};
					new UserRepository().AddNewUser(userModel);
				}

				//Forms Category
				FormCategoryRepository formCategoryRepository = new FormCategoryRepository();
				var formsCategory = formCategoryRepository.SelectDefaultFormsCategories();

				foreach (var form in formsCategory)
				{
					if (formCategoryRepository.SelectFormCategoryByName(form.Name, _companyModel.Id) == 0)
					{
						FormCategoryModel newModel = new FormCategoryModel
						{
							Name = form.Name,
							CreatedBy = CurrentUser.UserId,
							CompanyId = _companyModel.Id,
							BranchId = _branchRepository.SelectBranchById(_companyModel.Id).Id
						};
						formCategoryRepository.AddNewFormCategory(newModel);
					}
				}

				//Forms
				FormRepository formRepository = new FormRepository();
				var forms = formRepository.SelectDefaultForms();

				foreach (var form in forms)
				{
					if (formRepository.SelectFormByName(form.Name, _companyModel.Id) == 0)
					{
						FormModel newModel = new FormModel
						{
							Name = form.Name,
							CreatedBy = CurrentUser.UserId,
							CompanyId = _companyModel.Id,
							BranchId = _branchRepository.SelectBranchById(_companyModel.Id).Id
						};
						formRepository.AddNewForm(newModel);
					}
				}

				//Add UsersPermissionControls
				UserPermissionControlRepository userPermissionControlRepository = new UserPermissionControlRepository();
				var userPermissionControls = userPermissionControlRepository.SelectDefaultUserPermissionControls();

				foreach (var control in userPermissionControls)
				{
					if (userPermissionControlRepository.SelectUserPermissionControlByControlName(control.ControlName, _companyModel.Id) == 0)
					{
						UserPermissionControlModel newModel = new UserPermissionControlModel
						{
							ControlName = control.ControlName,
							CreatedBy = CurrentUser.UserId,
							CompanyId = _companyModel.Id,
							BranchId = _branchRepository.SelectBranchById(_companyModel.Id).Id,
							IsDefault = control.IsDefault
						};
						userPermissionControlRepository.AddNewUserPermissionControl(newModel);
					}
				}

				XtraMessageBox.Show("Seed Data completed!", @"Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void SeedOtherData()
		{
			try
			{
				if (_copyDataCheckList.CopyContinents)
				{
					ContinentRepository continentRepository = new ContinentRepository();

					//Default Copy Continents
					var exist = continentRepository.SelectContinentByCompanyId(_companyModel.Id);
					if (!exist.Any())
					{
						var defaultContinent = continentRepository.SelectContinentByCompanyId(1);
						foreach (var continent in defaultContinent)
						{
							_ = continentRepository.AddNewContinent(new ContinentModel
							{
								Name = continent.Name,
								Notes = continent.Notes,
								IsDefault = continent.IsDefault,
								CompanyId = _companyModel.Id,
								BranchId = _companyModel.BranchId,
								CreatedBy = CurrentUser.UserId
							});
						}
					}
				}

				if (_copyDataCheckList.CopyRegions)
				{
					RegionRepository regionRepository = new RegionRepository();

					//Default Copy Regions
					var exist = regionRepository.SelectRegionsByCompanyId(_companyModel.Id);
					if (!exist.Any())
					{
						var defaultRegion = regionRepository.SelectRegionsByCompanyId(1);
						foreach (var region in defaultRegion)
						{
							_ = regionRepository.AddNewRegion(new RegionModel
							{
								Name = region.Name,
								Notes = region.Notes,
								IsDefault = region.IsDefault,
								CompanyId = _companyModel.Id,
								BranchId = _companyModel.BranchId,
								CreatedBy = CurrentUser.UserId
							});
						}
					}
				}

				if (_copyDataCheckList.CopyCountries)
				{
					CountryRepository countryRepository = new CountryRepository();

					//Default Copy Country
					var exist = countryRepository.SelectCountriesByCompanyId(_companyModel.Id);
					if (!exist.Any())
					{
						var defaultCountry = countryRepository.SelectCountriesByCompanyId(1);
						foreach (var country in defaultCountry)
						{
							_ = countryRepository.AddNewCountry(new CountryModel
							{
								ContinentId = country.ContinentId,
								RegionId = country.RegionId,
								Code2 = country.Code2,
								CountryCode = country.CountryCode,
								CountryName = country.CountryName,
								Nationality = country.Nationality,
								SurfaceArea = country.SurfaceArea,
								IndependentYear = country.IndependentYear,
								Population = country.Population,
								LifeExpectancy = country.LifeExpectancy,
								GNP = country.GNP,
								GNPOld = country.GNPOld,
								LocalName = country.LocalName,
								GovernmentForm = country.GovernmentForm,
								HeadOfState = country.HeadOfState,
								Capital = country.Capital,
								Notes = country.Notes,
								IsDefault = country.IsDefault,
								CompanyId = _companyModel.Id,
								BranchId = _companyModel.BranchId,
								CreatedBy = CurrentUser.UserId
							});
						}
					}
				}

				if (_copyDataCheckList.CopyProvinces)
				{
					ProvinceRepository provinceRepository = new ProvinceRepository();

					//Default Copy Provinces
					var exist = provinceRepository.SelectProvincesByCompanyId(_companyModel.Id);
					if (!exist.Any())
					{
						var defaultProvince = provinceRepository.SelectProvincesByCompanyId(1);
						foreach (var province in defaultProvince)
						{
							_ = provinceRepository.AddNewProvince(new ProvinceModel
							{
								Name = province.Name,
								CountryId = province.CountryId,
								Notes = province.Notes,
								IsDefault = province.IsDefault,
								CompanyId = _companyModel.Id,
								BranchId = _companyModel.BranchId,
								CreatedBy = CurrentUser.UserId
							});
						}
					}
				}

				if (_copyDataCheckList.CopyDistricts)
				{
					DistrictRepository districtRepository = new DistrictRepository();

					//Default Copy Districts
					var exist = districtRepository.SelectDistrictsByCompanyId(_companyModel.Id);
					if (!exist.Any())
					{
						var defaultDistrict = districtRepository.SelectDistrictsByCompanyId(1);
						foreach (var district in defaultDistrict)
						{
							_ = districtRepository.AddNewDistrict(new DistrictModel
							{
								Name = district.Name,
								CountryId = district.CountryId,
								ProvinceId = district.ProvinceId,
								Notes = district.Notes,
								IsDefault = district.IsDefault,
								CompanyId = _companyModel.Id,
								BranchId = _companyModel.BranchId,
								CreatedBy = CurrentUser.UserId
							});
						}
					}
				}

				if (_copyDataCheckList.CopyCities)
				{
					CityRepository cityRepository = new CityRepository();

					//Default Copy Cities
					var exist = cityRepository.SelectCitiesByCompanyId(_companyModel.Id);
					if (!exist.Any())
					{
						var defaultCity = cityRepository.SelectCitiesByCompanyId(1);
						foreach (var city in defaultCity)
						{
							_ = cityRepository.AddNewCity(new CityModel
							{
								CountryId = city.CountryId,
								DistrictId = city.DistrictId,
								CityCode = city.CityCode,
								CityName = city.CityName,
								Population = city.Population,
								IsCapital = city.IsCapital,
								Notes = city.Notes,
								IsDefault = city.IsDefault,
								CompanyId = _companyModel.Id,
								BranchId = _companyModel.BranchId,
								CreatedBy = CurrentUser.UserId
							});
						}
					}
				}

				if (_copyDataCheckList.CopyCurrencies)
				{
					CurrencyRepository currencyRepository = new CurrencyRepository();

					//Default Copy Currencies
					var exist = currencyRepository.SelectCurrenciesByCompanyId(_companyModel.Id);
					if (!exist.Any())
					{
						var defaultCurrency = currencyRepository.SelectCurrenciesByCompanyId(1);
						foreach (var currency in defaultCurrency)
						{
							_ = currencyRepository.AddNewCurrency(new CurrencyModel
							{
								CurrencyCode = currency.CurrencyCode,
								CurrencySymbol = currency.CurrencySymbol,
								CurrencyName = currency.CurrencyName,
								DivByLocalRate = currency.DivByLocalRate,
								DivideByForeignRate = currency.DivideByForeignRate,
								Decimals = currency.Decimals,
								Rounding = currency.Rounding,
								Notes = currency.Notes,
								IsDefault = currency.IsDefault,
								CompanyId = _companyModel.Id,
								BranchId = _companyModel.BranchId,
								CreatedBy = CurrentUser.UserId
							});
						}
					}
				}

				if (_copyDataCheckList.CopyCurrenciesExchangeHistory)
				{
					//ContinentRepository continentRepository = new ContinentRepository();

					////Default Copy Continents
					//var exist = continentRepository.SelectContinentByCompanyId(_companyModel.Id);
					//if (!exist.Any())
					//{
					//	var defaultContinent = continentRepository.SelectContinentByCompanyId(1);
					//	foreach (var continent in defaultContinent)
					//	{
					//		_ = continentRepository.AddNewContinent(new ContinentModel
					//		{
					//			Name = continent.Name,
					//			Notes = continent.Notes,
					//			IsDefault = continent.IsDefault,
					//			CompanyId = _companyModel.Id,.
					//			BranchId = _companyModel.BranchId,
					//			CreatedBy = CurrentUserModel.UserId
					//		});
					//	}
					//}
				}

				if (_copyDataCheckList.CopyCharts)
				{
					//
				}

				if (_copyDataCheckList.CopySeaPorts)
				{
					//
				}

				if (_copyDataCheckList.CopyAirPorts)
				{
					//
				}

				if (_copyDataCheckList.CopyLandBorders)
				{
					//
				}

				if (_copyDataCheckList.CopyAirlines)
				{
					//
				}

				if (_copyDataCheckList.CopyCarriers)
				{
					//
				}
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}