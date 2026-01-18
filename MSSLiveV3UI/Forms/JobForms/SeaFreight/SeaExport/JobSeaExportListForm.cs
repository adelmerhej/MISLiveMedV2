using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Countries.Ports;
using MISLiveMed.DataLayers.Common.Departments;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.JobData.SeaExport;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries.Ports;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.JobModels.Export.SeaFreight.Jobs;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.JobForms.SeaFreight.SeaExport
{
    public partial class JobSeaExportListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "JobSeaExportList";
		private int _formId;
		private bool _resetMenu;

		private IList<JobSeaExportModel> _seaExports = new List<JobSeaExportModel>();
        private JobSeaExportModel _jobSeaExportModel = new JobSeaExportModel();
        private IList<JobSeaExportDetailsModel> _seaExportJobDetails = new List<JobSeaExportDetailsModel>();

        private IList<CustomerModel> _customers = new List<CustomerModel>();
        private IList<AgentModel> _agents = new List<AgentModel>();
        private IList<PortModel> _ports = new List<PortModel>();
        private IList<UserModel> _users = new List<UserModel>();
        private IList<UserModel> _sales = new List<UserModel>();
        private IList<DepartmentModel> _departments = new List<DepartmentModel>();

        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly JobSeaExportRepository _seaExportRepository = new JobSeaExportRepository();
        private readonly JobSeaExportDetailRepository _seaExportDetailRepository = new JobSeaExportDetailRepository();
        private readonly PortRepository _portRepository = new PortRepository();
        private readonly UserRepository _userRepository = new UserRepository();
        private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();
        private readonly AgentRepository _agentRepository = new AgentRepository();

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

		public RibbonControl MainRibbon => rcJobSeaExport;
        public RibbonPage DefaultPage => rpJobSeaExport;


        #endregion

        public JobSeaExportListForm()
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

				_customers = _customerRepository.SelectCustomers(_isProtected);
                _seaExports = _seaExportRepository.JobsSeaExport(_isProtected);
                _seaExportJobDetails = _seaExportDetailRepository.JobsSeaExportDetail(_isProtected);
                _ports = _portRepository.SelectPorts(PortType.Seaport);
                _users = _userRepository.SelectUsers(_isProtected);
                _sales = _userRepository.SelectUsersAsSales(_isProtected);
                _agents = _agentRepository.SelectAgents(_isProtected);
			}
            catch (Exception e)
            {
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {
            gcSeaExport.DataSource = null;
            gcSeaExport.DataSource = _seaExports;

            repCustomers.DataSource = null;
            repCustomers.DataSource = _customers;

            repAgents.DataSource = null;
            repAgents.DataSource = _agents;

            repPOLPortCodeList.DataSource = null;
            repPOLPortCodeList.DataSource = _ports;

            repPODPortCodeList.DataSource = null;
            repPODPortCodeList.DataSource = _ports;

            repUsersList.DataSource = null;
            repUsersList.DataSource = _users;

            repSalesList.DataSource = null;
            repSalesList.DataSource = _sales;

            //repStatusList.DataSource = Enum.GetValues(typeof(EnumStatusType));

            _departments = null;
            _departments = _departmentRepository.SelectDepartments();
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
	        LayoutsStyle.LoadLayoutGrid(gvSeaExport, CurrentUser.UserName, CurrentUser.CompanyName);
        }

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvSeaExport, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		private void JobSeaExportListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvSeaExport, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		#region Buttons Events

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void chkShowProfit_CheckedChanged(object sender, ItemClickEventArgs e)
		{

		}

		private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			Close();
		}

		#endregion


	}
}