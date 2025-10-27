using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Carriers;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;

namespace MISLiveMed.UI.Forms.Common.Carriers
{
    public partial class VesselEditForm : XtraForm
    {
	    private const string _formName = "VesselEdit";
	    private int _formId;

	    private VesselModel _vesselModel = new VesselModel();
	    private VesselModel _initialModel = new VesselModel();
	    private IList<CountryModel> _countries = new List<CountryModel>();
	    private IList<AgentModel> _agents = new List<AgentModel>();

	    private readonly CountryRepository _countryRepository = new CountryRepository();
	    private readonly AgentRepository _agentRepository = new AgentRepository();

	    /// <summary>
	    /// User Permission Role
	    /// </summary>
	    private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
	    private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
	    private readonly FormRepository _formRepository = new FormRepository();
	    private readonly LogInfoRepository _logInfoRepository = new LogInfoRepository();

	    //init permission variables
	    private bool _canEdit;
	    private bool _isAdmin;
	    private bool _isProtected;

	    public EventHandler SendUpdatedVessel;

		public VesselEditForm(VesselModel model)
        {
            InitializeComponent();

            try
            {
	            _vesselModel = model;

	            _initialModel = (VesselModel)model.Clone();

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
		        _agents = _agentRepository.SelectAgents();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

        private void WireUpBindings()
        {
	        cboNationalities.Properties.DataSource = null;
	        cboNationalities.Properties.DataSource = _countries;
	        cboNationalities.EditValue = _vesselModel.NationalityId;

	        cboShipLineAgents.Properties.DataSource = null;
	        cboShipLineAgents.Properties.DataSource = _agents;
	        cboShipLineAgents.EditValue = _vesselModel.ShipLineAgentId;
        }

        private void ApplyDefaults()
        {
	        if (_vesselModel.Id == 0)
	        {
		        chkActive.CheckState = CheckState.Checked;
	        }
        }

        private void ApplyPermissions()
        {
	        if (_userPermission == null) return;
	        if (_userPermission.Count <= 0) return;

	        var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
	        if (canEdit != null) _canEdit = (bool)canEdit;

	        var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
	        if (isAdmin != null) _isAdmin = (bool)isAdmin;

			txtName.ReadOnly = !_isAdmin || !_canEdit;
	        txtArabicName.ReadOnly = !_isAdmin || !_canEdit;
	        txtCaptainName.ReadOnly = !_isAdmin || !_canEdit;
	        txtFlag.ReadOnly = !_isAdmin || !_canEdit;
	        txtNotes.ReadOnly = !_isAdmin || !_canEdit;

	        cboNationalities.Enabled = _isAdmin || _canEdit;
	        cboShipLineAgents.Enabled = _isAdmin || _canEdit;
	        chkFeederVessel.Enabled = _isAdmin || _canEdit;
	        chkActive.Enabled = _isAdmin || _canEdit;
	        btnSave.Enabled = _isAdmin || _canEdit;

	        chkIsProtected.Visible = chkIsProtected.Enabled = _isAdmin;
        }

		private void btnSave_Click(object sender, EventArgs e)
		{

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}