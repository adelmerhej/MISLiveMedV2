using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.CRM.Agents
{
    public partial class AgentEditForm : RibbonForm
	{
		private const string _formName = "AgentEdit";
		private int _formId;
		private bool _resetMenu;

		private DataEntityState objState = DataEntityState.Unchanged;
		private AgentModel _agentModel = new AgentModel();
		private IList<AgentModel> _agents = new List<AgentModel>();

		private IList<CityModel> _cities = new List<CityModel>();
		private IList<CountryModel> _countries = new List<CountryModel>();

		private IList<AgentGroupModel> _agentsGroups = new List<AgentGroupModel>();
		private IList<AgentCategoryModel> _agentsCategories = new List<AgentCategoryModel>();

		private AgentRepository _agentRepository = new AgentRepository();
		private AgentGroupRepository _agentGroupRepository = new AgentGroupRepository();
		private AgentCategoryRepository _agentCategoryRepository = new AgentCategoryRepository();
		private CountryRepository _countryRepository = new CountryRepository();
		private CityRepository _cityRepository = new CityRepository();

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

		public EventHandler SendUpdatedAgent;

        public AgentEditForm(AgentModel agentModel)
        {
            InitializeComponent();

            try
            {
	            _agentModel = agentModel;

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

				_agents = _agentRepository.SelectAgents();
		        _agentsGroups = _agentGroupRepository.SelectAgentsGroup();
		        _agentsCategories = _agentCategoryRepository.SelectAgentCategories();

		        _cities = _cityRepository.SelectCities();
		        _countries = _countryRepository.SelectCountries();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

        private void WireUpBindings()
        {
            bsAgents.DataSource = _agentModel;

            cboMemberOf.Properties.DataSource = null;
            cboMemberOf.Properties.DataSource = _agents;
            cboMemberOf.EditValue = _agentModel.MemberOfId;
            
            cboAgentsGroup.Properties.DataSource = null;
            cboAgentsGroup.Properties.DataSource = _agentsGroups;
            cboAgentsGroup.EditValue = _agentModel.AgentGroupId;

            cboAgentsCategories.Properties.DataSource = null;
            cboAgentsCategories.Properties.DataSource = _agentsCategories;
            cboAgentsCategories.EditValue = _agentModel.AgentCategoryId;

            cboCountries.Properties.DataSource = null;
            cboCountries.Properties.DataSource = _countries;

            cboCities.Properties.DataSource = null;
            cboCities.Properties.DataSource = _cities;

            cboCountries.EditValue = _agentModel.CountryId;
            cboCities.EditValue = _agentModel.CityId;
        }

        private void ApplyDefaults()
        {

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
		}

        
        private bool ValidateData()
        {
            var validateReturnValue = true;
            var messageNumber = 0;
            var validateMessage = new StringBuilder();

            if (txtAgentName.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Agent Name cannot be empty.");
                validateReturnValue = false;
                txtAgentName.Focus();
            }

            //if (cboMemberType.Text == "")
            //{
            //    messageNumber += 1;
            //    validateMessage.Append("\n- MemberType cannot be empty.");
            //    validateReturnValue = false;
            //    cboMemberType.Focus();
            //}

            if (cboCountries.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Country Name cannot be empty.");
                validateReturnValue = false;
                cboCountries.Focus();
            }

            if (cboCities.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- City Region Name cannot be empty.");
                validateReturnValue = false;
                cboCities.Focus();
            }

            if (txtAddress.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Address Name cannot be empty.");
                validateReturnValue = false;
                txtAddress.Focus();
            }

            if (txtPhoneNumber1.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- At least one phone number is required.");
                validateReturnValue = false;
                txtPhoneNumber1.Focus();
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

        #region Buttons Event

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _agentModel = new AgentModel();
            InitializeBindings();
            WireUpBindings();
        }

        private void biSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!ValidateData()) return;
            SaveAgent();
        }

        private void biSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!ValidateData()) return;
            SaveAgent();
            Close();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void biDelete_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnMeeting_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new AboutForm();
            frm.ShowDialog();
        }

        private void biClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        #endregion

        private void SaveAgent()
        {
            try
            {
                BindingContext[bsAgents].EndCurrentEdit();

                if (cboCountries.EditValue != null) _agentModel.CountryId = (int)cboCountries.EditValue;
                if (cboCities.EditValue != null) _agentModel.CityId = (int)cboCities.EditValue;
                //if (cboMemberType.EditValue != null) _agentModel.Category = _categoryRepository.FindById((int)cboMemberType.EditValue);
                if (cboMemberOf.EditValue != null) _agentModel.MemberOfId = (int)cboMemberOf.EditValue;

                //if (cboCurrentSalesman.EditValue != null) _agentModel.SalesId = (int)cboCurrentSalesman.EditValue;
                if (cboResponsibleUser.EditValue != null) _agentModel.ResponsibleId = (int)cboResponsibleUser.EditValue;
                //if (cboCompanies.EditValue != null) _agentModel.CompanyId = (int)cboCompanies.EditValue;
                //if (cboBranches.EditValue != null) _agentModel.BranchId = (int)cboBranches.EditValue;

                if (_agentModel.Id == 0)
                {
	                _logInfoRepository.CreateLogInfo(_agentModel);

                    int newAgent = _agentRepository.AddNewAgent(_agentModel);
                    if (newAgent == 0)
                    {
                        throw new Exception($"Error while saving : {txtAgentName.Text}");
                    }
                }
                else
                {
	                _logInfoRepository.UpdateLogInfo(_agentModel);
                    _agentRepository.UpdateAgent(_agentModel);
                }

                SendUpdatedAgent(_agentModel, EventArgs.Empty);
                objState = DataEntityState.Unchanged;
                Close();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "User save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

	}
}