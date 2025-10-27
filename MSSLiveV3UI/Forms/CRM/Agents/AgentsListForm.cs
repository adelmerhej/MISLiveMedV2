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
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.CRM.Agents
{
    public partial class AgentsListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "AgentsList";
		private int _formId;
		private bool _resetMenu;

		private IList<AgentModel> _agents = new List<AgentModel>();
        private AgentModel _agentModel = new AgentModel();

        private readonly AgentRepository _agentRepository = new AgentRepository();

        private IList<AgentGroupModel> _agentsGroups = new List<AgentGroupModel>();
        private IList<AgentCategoryModel> _agentsCategories = new List<AgentCategoryModel>();
        private IList<CountryModel> _countries = new List<CountryModel>();
        private IList<CityModel> _cities = new List<CityModel>();

        private IList<UserModel> _responsibles = new List<UserModel>();
        private IList<UserModel> _salesUsers = new List<UserModel>();

        private readonly AgentGroupRepository _agentGroupRepository = new AgentGroupRepository();
        private readonly AgentCategoryRepository _agentCategoryRepository = new AgentCategoryRepository();
        private readonly CountryRepository _countryRepository = new CountryRepository();
        private readonly CityRepository _cityRepository = new CityRepository();
        private readonly UserRepository _userRepository = new UserRepository();

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

		public RibbonControl MainRibbon => rcAgentsList;
        public RibbonPage DefaultPage => rpAgentsList;


        #endregion

        public AgentsListForm()
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

				_agents = _agentRepository.SelectAgents();
				_agentsGroups = _agentGroupRepository.SelectAgentsGroup();
				_agentsCategories = _agentCategoryRepository.SelectAgentCategories();
				_countries = _countryRepository.SelectCountries();
				_cities = _cityRepository.SelectCities();
				_responsibles = _userRepository.SelectUsers();
				_salesUsers = _userRepository.SelectUsersAsSales();

			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {
            bsAgents.DataSource = _agents;

            gcAgents.DataSource = null;
            gcAgents.DataSource = bsAgents;

            repCountries.DataSource = null;
            repCountries.DataSource = _countries;

            repCities.DataSource = null;
            repCities.DataSource = _cities;

            repAgentsGroups.DataSource = null;
            repAgentsGroups.DataSource = _agentsGroups;

            repAgentsCategories.DataSource = null;
            repAgentsCategories.DataSource = _agentsCategories;

            repResponsibles.DataSource = null;
            repResponsibles.DataSource = _responsibles;

            repSales.DataSource = null;
            repSales.DataSource = _salesUsers;
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
	        LayoutsStyle.LoadLayoutGrid(gvAgents, CurrentUser.UserName);
		}

        #region Buttons Event

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            AgentEditForm frm = new AgentEditForm(new AgentModel());
            frm.SendUpdatedAgent += RcvUpdatedAgent;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!_agents.Any()) return;

            int currentRowId = (int)gvAgents.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _agentModel = _agents.SingleOrDefault(x => x.Id == currentRowId);
            if (_agentModel == null) return;

            var frm = new AgentEditForm(_agentModel);
            frm.SendUpdatedAgent += RcvUpdatedAgent;
            frm.ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvAgents.ShowRibbonPrintPreview();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CanDelete()) return;

            try
            {
                int.TryParse(gvAgents.GetFocusedRowCellValue("Id").ToString(), out int id);
                string name = gvAgents.GetFocusedRowCellValue("AgentName").ToString();

                if (id > 0)
                {
                    if (XtraMessageBox.Show($"Are you sure you want to delete Agent: `{name}`?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        _agentModel = gvAgents.GetFocusedRow() as AgentModel;
                        if (_agentModel == null)
                        {
                            return;
                        }
                        _agentModel.Deleted = true;

                        //delete the record
                        if (!_agentRepository.DeleteAgent(id))
                        {
                            throw new Exception(
                                "Error while deleting, please try again or contact your system administrator.");
                        }
                        RcvUpdatedAgent(_agentModel, EventArgs.Empty);
                    }
                }

            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "User delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new AboutForm();
            frm.ShowDialog();
        }
        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        #endregion


        #region EventHandler section

        private void RcvUpdatedAgent(object sender, EventArgs e)
        {
            if (sender == null) return;
            _agentModel = sender as AgentModel;

            if (_agentModel.LastModifiedDate == null || _agentModel.Deleted)
            {
                InitializeBindings();
                WireUpBindings();
            }
            else
            {
                gvAgents.UpdateCurrentRow();
            }
        }

        #endregion
        

        private bool CanDelete()
        {
            AgentModel dataBoundItem = gvAgents.GetFocusedRow() as AgentModel;

            if (gvAgents == null || gvAgents.SelectedRowsCount == 0) return false;
            if (gvAgents.SelectedRowsCount > 1)
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

        private void gcAgentsList_DoubleClick_1(object sender, EventArgs e)
        {
	        if (!_isAdmin && !_canEdit) return;

			if (!_agents.Any()) return;

            int currentRowId = (int)gvAgents.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _agentModel = _agents.SingleOrDefault(x => x.Id == currentRowId);
            if (_agentModel == null) return;

            var frm = new AgentEditForm(_agentModel);
            frm.SendUpdatedAgent += RcvUpdatedAgent;
            frm.ShowDialog();
        }

        private void gvAgentsList_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
	        GridView view = sender as GridView;
	        if (e.RowHandle >= 0)
	        {
		        bool isActive = view != null && (bool)view.GetRowCellValue(e.RowHandle, "Active");
		        bool isDefault = view != null && (bool)view.GetRowCellValue(e.RowHandle, "IsDefault");
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

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvAgents, CurrentUser.UserName);
			}
		}

		private void AgentsListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvAgents, CurrentUser.UserName);
			}
		}
	}
}