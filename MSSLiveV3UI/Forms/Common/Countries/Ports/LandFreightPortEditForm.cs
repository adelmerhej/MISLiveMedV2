using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Countries.Ports;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Common.Countries.Ports;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.Common.Countries.Ports
{
    public partial class LandFreightPortEditForm : XtraForm
    {
	    private const string _formName = "LandFreightPortEdit";
	    private int _formId;

	    private DataEntityState _objState = DataEntityState.Unchanged;
	    private readonly PortType _portType = PortType.LandBorder;

	    private PortModel _landFreightPortModel = new PortModel();
	    private IList<PortModel> _landFreightPorts = new List<PortModel>();

	    private CityModel _cityModel = new CityModel();
	    private IList<CityModel> _cities = new List<CityModel>();
	    private CountryModel _countryModel = new CountryModel();
	    private IList<CountryModel> _countries = new List<CountryModel>();

	    private LandFreightPortRepository _landFreightPortRepository = new LandFreightPortRepository();
	    private CityRepository _citiesRepository = new CityRepository();
	    private CountryRepository _countryRepository = new CountryRepository();

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

		public EventHandler SendUpdatedFreightPort;

        public LandFreightPortEditForm(PortModel model)
        {
            InitializeComponent();

            try
            {
	            _landFreightPortModel = model;

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

				_cities = _citiesRepository.SelectCities();
		        _countries = _countryRepository.SelectCountries();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }

        private void WireUpBindings()
        {
	        bsLandFreightPort.DataSource = _landFreightPortModel;

	        cboCities.Properties.DataSource = null;
	        cboCities.Properties.DataSource = _cities;
	        cboCities.EditValue = _landFreightPortModel.CityId;

	        cboCountries.Properties.DataSource = null;
	        cboCountries.Properties.DataSource = _countries;
	        cboCountries.EditValue = _landFreightPortModel.CountryId;
        }

        private void ApplyPermissions()
        {
	        if (_userPermission == null) return;
	        if (_userPermission.Count <= 0) return;

	        var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
	        if (canEdit != null) _canEdit = (bool)canEdit;

	        var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
	        if (isAdmin != null) _isAdmin = (bool)isAdmin;

	        txtCode.ReadOnly = !_isAdmin || !_canEdit;
	        txtName.ReadOnly = !_isAdmin || !_canEdit;
	        cboCities.ReadOnly = !_isAdmin || !_canEdit;
	        cboCountries.ReadOnly = !_isAdmin || !_canEdit;
	        txtNotes.ReadOnly = !_isAdmin || !_canEdit;

	        chkActive.Enabled = _isAdmin || _canEdit;
	        btnSave.Enabled = _isAdmin || _canEdit;
		}

        private void ApplyDefaults()
        {
	        txtCode.Focus();
        }

		#region Buttons Event

		private void btnSave_Click(object sender, EventArgs e)
        {
	        if (!ValidateData()) return;

	        try
	        {
		        BindingContext[bsLandFreightPort].EndCurrentEdit();
		        _landFreightPortModel = bsLandFreightPort.Current as PortModel;

		        if (cboCountries.EditValue != null) _landFreightPortModel.CountryId = (int)cboCountries.EditValue;
		        if (cboCities.EditValue != null) _landFreightPortModel.CityId = (int)cboCities.EditValue;
		        _landFreightPortModel.PortTypeId = (int)_portType;

				if (_landFreightPortModel.Id == 0)
		        {
			        _logInfoRepository.CreateLogInfo(_landFreightPortModel);
			        var newSeaportId = _landFreightPortRepository.AddNewLandFreightPort(_landFreightPortModel);
			        txtId.Text = newSeaportId.ToString();
		        }
		        else
		        {
			        _logInfoRepository.UpdateLogInfo(_landFreightPortModel);
			        _landFreightPortRepository.UpdateLandFreightPort(_landFreightPortModel);
		        }

		        SendUpdatedFreightPort(_landFreightPortModel, EventArgs.Empty);
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

            if (cboCities.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- City cannot be empty.");
                validateReturnValue = false;
                cboCities.Focus();
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

		private void LandFreightPortEditForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				e.Cancel = true;
			}
		}

		private void cboCities_AddNewValue(object sender, AddNewValueEventArgs e)
		{
			CityEditForm cityForm = new CityEditForm(new CityModel());
			cityForm.SendUpdatedCity += RcvUpdatedCity;
			cityForm.ShowDialog();
		}
		private void RcvUpdatedCity(object sender, EventArgs e)
		{
			if (sender == null) return;
			_cityModel = sender as CityModel;

			_cities.Add(_cityModel);

			cboCities.Properties.DataSource = null;
			cboCities.Properties.DataSource = _cities;
			if (_cityModel != null) cboCities.EditValue = _cityModel.Id;
		}
		private void cboCountries_AddNewValue(object sender, AddNewValueEventArgs e)
		{
			CountryEditForm countryForm = new CountryEditForm(new CountryModel());
			countryForm.SendUpdatedCountry += RcvUpdatedCountry;
			countryForm.ShowDialog();

		}
		private void RcvUpdatedCountry(object sender, EventArgs e)
		{
			if (sender == null) return;
			_countryModel = sender as CountryModel;

			_countries.Add(_countryModel);

			cboCountries.Properties.DataSource = null;
			cboCountries.Properties.DataSource = _cities;
			if (_countryModel != null) cboCountries.EditValue = _countryModel.Id;
		}
	}
}