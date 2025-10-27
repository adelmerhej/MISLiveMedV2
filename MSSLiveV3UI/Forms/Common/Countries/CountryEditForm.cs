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
    public partial class CountryEditForm : XtraForm
    {
	    private const string _formName = "CountryEdit";
	    private int _formId;

	    private DataEntityState _objState = DataEntityState.Unchanged;

	    private CountryModel _countryModel = new CountryModel();

	    private RegionModel _regionModel = new RegionModel();
	    private IList<RegionModel> _regions = new List<RegionModel>();

	    private ContinentModel _continentModel = new ContinentModel();
	    private IList<ContinentModel> _continents = new List<ContinentModel>();

	    private readonly CountryRepository _countryRepository = new CountryRepository();
	    private readonly RegionRepository _regionRepository = new RegionRepository();
	    private readonly ContinentRepository _continentRepository = new ContinentRepository();

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

		public EventHandler SendUpdatedCountry;

        public CountryEditForm(CountryModel model)
        {
            InitializeComponent();

            try
            {
	            _countryModel = model;

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

				_regions = _regionRepository.SelectRegions();
		        _continents = _continentRepository.SelectContinents();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

        private void WireUpBindings()
        {
	        bsCountry.DataSource = _countryModel;

	        cboRegions.Properties.DataSource = null;
	        cboRegions.Properties.DataSource = _regions;
	        cboRegions.EditValue = _countryModel.RegionId;

	        cboContinents.Properties.DataSource = null;
	        cboContinents.Properties.DataSource = _continents;
	        cboContinents.EditValue = _countryModel.ContinentId;
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

	        txtCode2.ReadOnly = !_isAdmin || !_canEdit;
	        txtCode.ReadOnly = !_isAdmin || !_canEdit;
	        txtName.ReadOnly = !_isAdmin || !_canEdit;
	        txtNationality.ReadOnly = !_isAdmin || !_canEdit;
	        txtSurfaceArea.ReadOnly = !_isAdmin || !_canEdit;
	        txtPopulation.ReadOnly = !_isAdmin || !_canEdit;
	        txtIndependentYear.ReadOnly = !_isAdmin || !_canEdit;
	        txtLifeExpectancy.ReadOnly = !_isAdmin || !_canEdit;
	        txtGNP.ReadOnly = !_isAdmin || !_canEdit;
	        txtGNPOld.ReadOnly = !_isAdmin || !_canEdit;
	        txtLocalName.ReadOnly = !_isAdmin || !_canEdit;
	        txtCapital.ReadOnly = !_isAdmin || !_canEdit;
	        txtGovernmentForm.ReadOnly = !_isAdmin || !_canEdit;
	        txtHeadOfState.ReadOnly = !_isAdmin || !_canEdit;
	        cboRegions.ReadOnly = !_isAdmin || !_canEdit;
	        cboContinents.ReadOnly = !_isAdmin || !_canEdit;
	        txtNotes.ReadOnly = !_isAdmin || !_canEdit;
		}

        private void ApplyDefaults()
        {
	        txtName.Focus();
        }

		#region Buttons Event

		private void btnSave_Click(object sender, EventArgs e)
        {
	        if (!ValidateData()) return;

	        try
	        {
		        BindingContext[bsCountry].EndCurrentEdit();
		        _countryModel = bsCountry.Current as CountryModel;

		        if (_countryModel == null) return;

		        if (cboContinents.EditValue != null) _countryModel.ContinentId = (int)cboContinents.EditValue;
		        if (cboRegions.EditValue != null) _countryModel.RegionId = (int)cboRegions.EditValue;

		        if (_countryModel.Id == 0)
		        {
			        _logInfoRepository.CreateLogInfo(_countryModel);
			        var newCityId = _countryRepository.AddNewCountry(_countryModel);
			        txtId.Text = newCityId.ToString();
		        }
		        else
		        {
			        _logInfoRepository.UpdateLogInfo(_countryModel);
			        _countryRepository.UpdateCountry(_countryModel);
		        }

		        SendUpdatedCountry(_countryModel, EventArgs.Empty);

		        _objState = DataEntityState.Unchanged;
		        Close();
	        }
	        catch (Exception exception)
	        {
		        XtraMessageBox.Show(exception.Message,
			        $"On Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (txtCode2.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- ISO Code cannot be empty.");
                validateReturnValue = false;
                txtCode2.Focus();
            }

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

            if (!validateReturnValue)
            {
                validateMessage.Insert(0, "The following need your attention:");
                if (messageNumber > 1) validateMessage.Replace("following", "followings");
                XtraMessageBox.Show(validateMessage + " \nPlease try again.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return validateReturnValue;
        }

        private void cboRegions_AddNewValue(object sender, AddNewValueEventArgs e)
        {
            RegionEditForm frm = new RegionEditForm(new RegionModel());
            frm.SendUpdatedRegion += RcvUpdatedRegion;
            frm.ShowDialog();
        }

        private void cboContinents_AddNewValue(object sender, AddNewValueEventArgs e)
        {
            ContinentEditForm frm = new ContinentEditForm(new ContinentModel());
            frm.SendUpdatedContinent += RcvUpdatedContinent;
            frm.ShowDialog();
        }

        private void RcvUpdatedRegion(object sender, EventArgs e)
        {
            if (sender == null) return;
            _regionModel = sender as RegionModel;

            _regions.Add(_regionModel);

            cboContinents.Properties.DataSource = null;
            cboContinents.Properties.DataSource = _regions;
            if (_regionModel != null) cboContinents.EditValue = _regionModel.Id;
        }

        private void RcvUpdatedContinent(object sender, EventArgs e)
        {
            if (sender == null) return;
            _continentModel = sender as ContinentModel;

            _continents.Add(_continentModel);

            cboContinents.Properties.DataSource = null;
            cboContinents.Properties.DataSource = _continents;
            if (_continentModel != null) cboContinents.EditValue = _continentModel.Id;
        }

		private void CountryEditForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				e.Cancel = true;
			}
		}
	}
}