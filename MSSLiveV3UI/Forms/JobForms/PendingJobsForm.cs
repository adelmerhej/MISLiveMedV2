using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Common.Countries.Ports;
using MISLiveMed.DataLayers.Common.Departments;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.JobData.Quotations;
using MISLiveMed.DataLayers.JobData.SeaImport;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Carriers;
using MISLiveMed.Models.Models.Common.Countries.Ports;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.JobModels.Quotations;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.Jobs.Quotations;
using MISLiveMed.UI.Reports;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.JobForms
{
    public partial class PendingJobsForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "PendingJobs";
		private int _formId;
		private bool _resetMenu;

		private IList<DepartmentModel> _departmentsList = new List<DepartmentModel>();
        private IList<QuotationModel> _quotationModels = new List<QuotationModel>();
        private IList<UserModel> _users = new List<UserModel>();
        private IList<UserModel> _sales = new List<UserModel>();
        private IList<CustomerModel> _customers = new List<CustomerModel>();
        private IList<PortModel> _portsList = new List<PortModel>();
        private IList<AgentModel> _agentsList = new List<AgentModel>();
        private IList<VesselModel> _seaCarrierList = new List<VesselModel>();

        private QuotationModel _quotationModel = new QuotationModel();
        private IList<QuotationModel> _dataReportModels = new List<QuotationModel>();

        private readonly AgentRepository _agentRepository = new AgentRepository();
        private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();
        private readonly SeaportRepository _seaportRepository = new SeaportRepository();
        private readonly UserRepository _userRepository = new UserRepository();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();

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

		private int _departmentFilter = 0;
        private int _salesFilter = 0;
        private EnumStatusType _statusFilter = EnumStatusType.NotSelected;
        private bool _isBooked = false;
        private bool _isCancelled = false;
        private bool _isLost = false;
        private bool _isAll = false;

        #region Implementation of IFormWithRibbon

        public RibbonControl MainRibbon => rcPedingJobsList;
        public RibbonPage DefaultPage => rpPedingJobsList;


        #endregion

        public PendingJobsForm()
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

				_departmentsList = _departmentRepository.SelectDepartments();
		        _quotationModels = (List<QuotationModel>)JobSeaImportDal.GetQuotationsList(_departmentFilter, _isBooked,
			        _isCancelled, _isLost, _isAll, _salesFilter, _statusFilter);
		        _users = _userRepository.SelectUsers();
		        _sales = _userRepository.SelectUsersAsSales();
		        _customers = _customerRepository.SelectCustomers();
		        _portsList = _seaportRepository.SelectSeaports();
		        _agentsList = _agentRepository.SelectAgents();
		        //_seaCarrierList = (List<VesselModel>) SeaCarrierDal.GetSeaCarrierList();
		        repStatusList.DataSource = Enum.GetValues(typeof(EnumStatusType));
			}
	        catch (Exception e)
	        {
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }
        private void WireUpBindings()
        {
	        repUsersList.DataSource = null;
	        repUsersList.DataSource = _users;

	        repSalesList.DataSource = null;
	        repSalesList.DataSource = _sales;

	        repFilterBySalesList.DataSource = null;
	        repFilterBySalesList.DataSource = _sales;

	        repGridDepartmentList.DataSource = null;
	        repGridDepartmentList.DataSource = _departmentsList;

	        repDepartmentsList.DataSource = null;
	        repDepartmentsList.DataSource = _departmentsList;

	        gcPedingJobsList.DataSource = null;
	        gcPedingJobsList.DataSource = _quotationModels;

	        repMembersList.DataSource = null;
	        repMembersList.DataSource = _customers;

	        repPOLPortCodeList.DataSource = null;
	        repPOLPortCodeList.DataSource = _portsList;

	        repPODPortCodeList.DataSource = null;
	        repPODPortCodeList.DataSource = _portsList;

	        repAgentsList.DataSource = null;
	        repAgentsList.DataSource = _agentsList;

	        repSeaCarrierList.DataSource = null;
	        repSeaCarrierList.DataSource = _seaCarrierList;
        }

		private void ApplyDefaults()
        {
	        LayoutsStyle.LoadLayoutGrid(gvPedingJobsList, CurrentUser.UserName, CurrentUser.CompanyName);
		}

        // TODO: Make it public to check each permission, and return bool
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

        #region MenuButtons

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        #endregion

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            //TODO: working on filters
            int[] selectList = GetCurrentView();
            List<QuotationReportModel> dataReportModels =
                (List<QuotationReportModel>) QuotationDal.GetQuotationsReport(_departmentFilter, _salesFilter, _statusFilter);

            var previewForm = new DocumentViewerForm();
            var report = new QotationsListReport();

            report.DataSource = dataReportModels;

            report.Parameters["isAdmin"].Value = CurrentUser.UserId == 30 && chkShowProfit.Checked;

            previewForm.Viewer.DocumentSource = report;
            previewForm.ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void gvPedingJobsList_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool lost = (bool)view.GetRowCellValue(e.RowHandle, "Lost");
                if (lost)
                {
                    e.Appearance.ForeColor = lost ? Color.Red : Color.Black;
                    e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Strikeout);
                }
                bool cancelled = (bool)view.GetRowCellValue(e.RowHandle, "Deleted");
                if (cancelled)
                {
                    e.Appearance.ForeColor = cancelled ? Color.Gray : Color.Black;
                    e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Italic);
                }
                bool needAtt = (bool)view.GetRowCellValue(e.RowHandle, "Attention");
                if (needAtt)
                {
                    e.Appearance.BackColor = needAtt ? Color.Red : Color.Transparent;
                    e.Appearance.ForeColor = needAtt ? Color.White : Color.Black;

                }
            }
        }
        private int[] GetCurrentView()
        {
            GridView view = gvPedingJobsList;
            int[] selectedList = new int[gvPedingJobsList.DataRowCount];
            for (int i = 0; i < gvPedingJobsList.DataRowCount; i++)
            {
                if (view?.GetRow(i) is QuotationModel quotation)
                    selectedList[i] = quotation.Id;
            }

            return selectedList;
        }

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvPedingJobsList, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		private void PendingJobsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvPedingJobsList, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}
	}
}