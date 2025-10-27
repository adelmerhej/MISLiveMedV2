using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.Common.Countries
{
    public partial class CityEditForm : XtraForm
    {
	    private const string _formName = "CityEdit";
	    private int _formId;

	    private DataEntityState _objState = DataEntityState.Unchanged;

	    private CityModel _cityModel = new CityModel();

	    private CountryModel _countryModel = new CountryModel();
	    private IList<CountryModel> _countries = new List<CountryModel>();
	    private DistrictModel _districtModel = new DistrictModel();
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
	    private readonly LogInfoRepository _logInfoRepository = new LogInfoRepository();

	    private bool _canEdit;
	    private bool _isAdmin;
	    private bool _isProtected;

		public EventHandler SendUpdatedCity;

		public CityEditForm(CityModel model)
        {
            InitializeComponent();

            try
            {
	            _cityModel = model;

	            InitializeBindings();
	            WireUpBindings();
	            ApplyDefaults();
	            ApplyPermissions();
            }
            catch (Exception e)
            {
	            XtraMessageBox.Show(e.Message, "Error in loading...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
		        _districts = _districtRepository.SelectDistricts();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

        private void WireUpBindings()
        {
	        bsCity.DataSource = _cityModel;

	        cboCountries.Properties.DataSource = null;
	        cboCountries.Properties.DataSource = _countries;
	        cboCountries.EditValue = _cityModel.CountryId;

	        cboDistricts.Properties.DataSource = null;
	        cboDistricts.Properties.DataSource = _districts;
	        cboDistricts.EditValue = _cityModel.DistrictId;
		}

        private void ApplyPermissions()
        {
	        if (_userPermission == null) return;
	        if (_userPermission.Count <= 0) return;

	        var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
	        if (canEdit != null) _canEdit = (bool)canEdit;

	        var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
	        if (isAdmin != null) _isAdmin = (bool)isAdmin;

	        chkActive.Enabled = _isAdmin || _canEdit;
	        chkIsCapital.Enabled = _isAdmin || _canEdit;
	        btnSave.Enabled = _isAdmin || _canEdit;

	        txtCode.ReadOnly = !_isAdmin || !_canEdit;
	        txtName.ReadOnly = !_isAdmin || !_canEdit;
	        cboCountries.ReadOnly = !_isAdmin || !_canEdit;
	        cboDistricts.ReadOnly = !_isAdmin || !_canEdit;
	        txtPopulation.ReadOnly = !_isAdmin || !_canEdit;
	        txtNotes.ReadOnly = !_isAdmin || !_canEdit;
		}

        private void ApplyDefaults()
        {

        }

        #region Buttons Event

        private void btnSave_Click(object sender, EventArgs e)
        {
	        if (!ValidateData()) return;

	        try
	        {
		        BindingContext[bsCity].EndCurrentEdit();
		        _cityModel = bsCity.Current as CityModel;

		        if (cboCountries.EditValue != null) _cityModel.CountryId = (int)cboCountries.EditValue;
		        if (cboDistricts.EditValue != null) _cityModel.DistrictId = (int)cboDistricts.EditValue;

		        if (_cityModel.Id == 0)
		        {
			        _logInfoRepository.CreateLogInfo(_cityModel);
			        var newCityId = _cityRepository.AddNewCity(_cityModel);
			        txtId.Text = newCityId.ToString();
		        }
		        else
		        {
			        _logInfoRepository.UpdateLogInfo(_cityModel);
			        _cityRepository.UpdateCity(_cityModel);
		        }

		        SendUpdatedCity(_cityModel, EventArgs.Empty);

		        _objState = DataEntityState.Unchanged;
		        Close();
	        }
	        catch (Exception exception)
	        {
		        XtraMessageBox.Show(exception.Message,
			        "On Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private bool ValidateData()
        {
            var validateReturnValue = true;
            var messageNumber = 0;
            var validateMessage = new StringBuilder();

            if (txtCode.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Code cannot be empty.");
                validateReturnValue = false;
                txtCode.Focus();
            }

            if (txtName.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Name cannot be empty.");
                validateReturnValue = false;
                txtName.Focus();
            }

            if (cboCountries.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Country cannot be empty.");
                validateReturnValue = false;
                cboCountries.Focus();
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

        private void cboDistricts_AddNewValue(object sender, AddNewValueEventArgs e)
        {
            DistrictEditForm frm = new DistrictEditForm(new DistrictModel());
            frm.SendUpdatedDistrict += RcvUpdatedDistrict;
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

        private void RcvUpdatedDistrict(object sender, EventArgs e)
        {
            if (sender == null) return;
            _districtModel = sender as DistrictModel;

            _districts.Add(_districtModel);

            cboDistricts.Properties.DataSource = null;
            cboDistricts.Properties.DataSource = _districts;
            if (_districtModel != null) cboDistricts.EditValue = _districtModel.Id;
        }

		private void CityEditForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				e.Cancel = true;
			}
		}
	}
}