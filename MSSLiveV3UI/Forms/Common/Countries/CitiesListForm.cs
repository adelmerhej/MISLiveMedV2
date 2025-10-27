using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.Common.Countries
{
    public partial class CitiesListForm : RibbonForm, IFormWithRibbon
    {
	    private const string _formName = "CitiesList";
	    private int _formId;
	    private bool _resetMenu;

	    private CityModel _cityModel = new CityModel();
	    private IList<CityModel> _cities = new List<CityModel>();
	    private IList<CountryModel> _countries = new List<CountryModel>();
	    private IList<DistrictModel> _districts = new List<DistrictModel>();

	    private readonly CityRepository _cityRepository = new CityRepository();
	    private readonly CountryRepository _countryRepository = new CountryRepository();
	    private readonly DistrictRepository _districtRepository = new DistrictRepository();

	    /// <summary>
	    /// User Permission Role
	    /// </summary>
	    private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
	    private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
	    private readonly FormRepository _formRepository = new FormRepository();

	    //Init permission variables
	    private bool _canAdd;
	    private bool _canEdit;
	    private bool _canDelete;
	    private bool _canPrint;
	    private bool _isAdmin;
	    private bool _isProtected;

		#region Implementation of IFormWithRibbon

		public RibbonControl MainRibbon => rcCitiesList;
	    public RibbonPage DefaultPage => rpCitiesList;


	    #endregion

		public CitiesListForm()
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

				_cities = _cityRepository.SelectCities();
		        _countries = _countryRepository.SelectCountries();
		        _districts = _districtRepository.SelectDistricts();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

        private void WireUpBindings()
        {
	        bsCities.DataSource = _cities;

	        gcCities.DataSource = null;
	        gcCities.DataSource = bsCities;

	        repCountries.DataSource = null;
	        repCountries.DataSource = _countries;

	        repDistricts.DataSource = null;
	        repDistricts.DataSource = _districts;
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

        private void ApplyDefaults()
        {
	        LayoutsStyle.LoadLayoutGrid(gvCities, CurrentUser.UserName);
		}

		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            CityEditForm frm = new CityEditForm(new CityModel());
            frm.SendUpdatedCity += RcvUpdatedCity;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!_cities.Any()) return;

            int currentRowId = (int)gvCities.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _cityModel = _cities.SingleOrDefault(x => x.Id == currentRowId);
            if (_cityModel == null) return;

            var frm = new CityEditForm(_cityModel);
            frm.SendUpdatedCity += RcvUpdatedCity;
            frm.ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcCities.ShowRibbonPrintPreview();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CanDelete()) return;

            try
            {
                int.TryParse(gvCities.GetFocusedRowCellValue("Id").ToString(), out int id);
                string name = gvCities.GetFocusedRowCellValue("CityName").ToString();

                if (id > 0)
                {
                    if (XtraMessageBox.Show($"Are you sure you want to delete City: `{name}`?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        _cityModel = gvCities.GetFocusedRow() as CityModel;
                        if (_cityModel == null)
                        {
                            return;
                        }
                        _cityModel.Deleted = true;

                        //delete the record
                        _cityRepository.DeleteCity(_cityModel.Id);
                        RcvUpdatedCity(_cityModel, EventArgs.Empty);
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

        private void gcCities_DoubleClick(object sender, System.EventArgs e)
        {
	        if (!_isAdmin && !_canEdit) return;

			if (!_cities.Any()) return;

            int currentRowId = (int)gvCities.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _cityModel = _cities.SingleOrDefault(x => x.Id == currentRowId);
            if (_cityModel == null) return;

            var frm = new CityEditForm(_cityModel);
            frm.SendUpdatedCity += RcvUpdatedCity;
            frm.ShowDialog();
        }

        private void RcvUpdatedCity(object sender, EventArgs e)
        {
            if (sender == null) return;
            _cityModel = sender as CityModel;

            if (_cityModel.LastModifiedDate == null || _cityModel.Deleted)
            {
                InitializeBindings();
                WireUpBindings();
            }
            else
            {
                gvCities.UpdateCurrentRow();
            }
        }

        private bool CanDelete()
        {
            CityModel dataBoundItem = gvCities.GetFocusedRow() as CityModel;

            if (gvCities == null || gvCities.SelectedRowsCount == 0) return false;
            if (gvCities.SelectedRowsCount > 1)
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

        private void gvCities_RowCellStyle(object sender, RowCellStyleEventArgs e)
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

		#region Grid Events

		private void CitiesListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvCities, CurrentUser.UserName);
			}
		}

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvCities, CurrentUser.UserName);
			}
		}

		#endregion

	}
}