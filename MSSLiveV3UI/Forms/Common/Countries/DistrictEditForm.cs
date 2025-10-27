using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.Common.Countries
{
    public partial class DistrictEditForm : XtraForm
    {
	    private const string _formName = "DistrictEdit";
	    private int _formId;

	    private DataEntityState _objState = DataEntityState.Unchanged;

	    private DistrictModel _districtModel = new DistrictModel();

	    private ProvinceModel _provinceModel = new ProvinceModel();
	    private IList<ProvinceModel> _provinces = new List<ProvinceModel>();

	    private CountryModel _countryModel = new CountryModel();
	    private IList<CountryModel> _countries = new List<CountryModel>();

	    private readonly DistrictRepository _districtRepository = new DistrictRepository();
	    private readonly ProvinceRepository _provinceRepository = new ProvinceRepository();
	    private readonly CountryRepository _countryRepository = new CountryRepository();

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

		public EventHandler SendUpdatedDistrict;

        public DistrictEditForm(DistrictModel model)
        {
            InitializeComponent();

            try
            {
	            _districtModel = model;

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

				_countries = _countryRepository.SelectCountries();
		        _provinces = _provinceRepository.SelectProvinces();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

        private void WireUpBindings()
        {
	        bsDistrict.DataSource = _districtModel;

	        cboCountries.Properties.DataSource = null;
	        cboCountries.Properties.DataSource = _countries;
	        cboCountries.EditValue = _districtModel.CountryId;

	        cboProvinces.Properties.DataSource = null;
	        cboProvinces.Properties.DataSource = _provinces;
	        cboProvinces.EditValue = _districtModel.ProvinceId;
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
	        btnSave.Enabled = _isAdmin || _canEdit;

	        txtName.ReadOnly = !_isAdmin || !_canEdit;
	        cboCountries.ReadOnly = !_isAdmin || !_canEdit;
	        cboProvinces.ReadOnly = !_isAdmin || !_canEdit;
	        txtNotes.ReadOnly = !_isAdmin || !_canEdit;
		}

        private void ApplyDefaults()
        {
	        txtName.Focus();
        }
        
		#region Buttons Event

		private void btnSave_Click(object sender, System.EventArgs e)
        {
	        if (!ValidateData()) return;

	        try
	        {
		        BindingContext[bsDistrict].EndCurrentEdit();
		        _districtModel = bsDistrict.Current as DistrictModel;

		        if (_districtModel == null) return;

		        if (cboCountries.EditValue != null) _districtModel.CountryId = (int)cboCountries.EditValue;
		        if (cboProvinces.EditValue != null) _districtModel.ProvinceId = (int)cboProvinces.EditValue;

		        if (_districtModel.Id == 0)
		        {
			        _logInfoRepository.CreateLogInfo(_districtModel);
			        var newCityId = _districtRepository.AddNewDistrict(_districtModel);
			        txtId.Text = newCityId.ToString();
		        }
		        else
		        {
			        _logInfoRepository.UpdateLogInfo(_districtModel);
			        _districtRepository.UpdateDistrict(_districtModel);
		        }

		        SendUpdatedDistrict(_districtModel, EventArgs.Empty);

		        _objState = DataEntityState.Unchanged;
		        Close();
	        }
	        catch (Exception exception)
	        {
		        XtraMessageBox.Show(exception.Message,
			        $"On Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion

        private bool ValidateData()
        {
            var validateReturnValue = true;
            var messageNumber = 0;
            var validateMessage = new StringBuilder();

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

            if (cboProvinces.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Provinces cannot be empty.");
                validateReturnValue = false;
                cboProvinces.Focus();
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

        private void cboProvinces_AddNewValue(object sender, DevExpress.XtraEditors.Controls.AddNewValueEventArgs e)
        {
            ProvinceEditForm frm = new ProvinceEditForm(new ProvinceModel());
            frm.SendUpdatedProvince += RcvUpdatedProvince;
            frm.ShowDialog();
        }

        private void cboCountries_AddNewValue(object sender, DevExpress.XtraEditors.Controls.AddNewValueEventArgs e)
        {
            CountryEditForm frm = new CountryEditForm(new CountryModel());
            frm.SendUpdatedCountry += RcvUpdatedCountry;
            frm.ShowDialog();
        }

        private void cboCountries_EditValueChanged(object sender, EventArgs e)
        {
            int countryValue = (int)cboCountries.EditValue;

            if (countryValue == 0)
            {
                _provinces = _provinceRepository.SelectProvinces();
                cboProvinces.Properties.DataSource = null;
                cboProvinces.Properties.DataSource = _provinces;
            }
            else
            {
                _provinces = _provinceRepository.SelectProvincesByCountryId((int)cboCountries.EditValue);
                cboProvinces.Properties.DataSource = null;
                cboProvinces.Properties.DataSource = _provinces;
            }
        }
        private void RcvUpdatedCountry(object sender, EventArgs e)
        {
            if (sender == null) return;
            _countryModel = sender as CountryModel;

            _countries.Add(_countryModel);

            cboCountries.Properties.DataSource = null;
            cboCountries.Properties.DataSource = _countries;
            if (_countryModel != null)
            {
                _districtModel.CountryId = _countryModel.Id;
                cboCountries.EditValue = _countryModel.Id;
            }
        }
        private void RcvUpdatedProvince(object sender, EventArgs e)
        {
            if (sender == null) return;
            _provinceModel = sender as ProvinceModel;

            _provinces.Add(_provinceModel);

            cboProvinces.Properties.DataSource = null;
            cboProvinces.Properties.DataSource = _provinces;
            if (_provinceModel != null)
            {
                _districtModel.ProvinceId = _provinceModel.Id;
                cboProvinces.EditValue = _provinceModel.Id;
            }
        }
        private void DistrictEditForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				e.Cancel = true;
			}
		}
	}
}