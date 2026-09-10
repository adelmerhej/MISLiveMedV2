using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Common.Countries.Ports;
using MISLiveMed.DataLayers.Common.Departments;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Common.JobsType;
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.JobData.SeaExport;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries.Ports;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.Common.JobsType;
using MISLiveMed.Models.Models.JobModels.Export.SeaFreight.Jobs;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;
using MISLiveMed.Utils.Layout;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MISLiveMed.UI.Forms.JobForms.SeaFreight.SeaExport
{
    public partial class JobSeaExportListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "JobSeaExportList";
		private int _formId;
		private bool _resetMenu;
		private JobSeaExportEditForm _jobSeaExportEditForm;

		private IList<JobSeaExportModel> _seaExports;
		private JobSeaExportModel _jobSeaExportModel;
		private IList<JobSeaExportDetailModel> _seaExportJobDetails;
		private IList<CustomerModel> _customers;
		private IList<AgentModel> _agents;
		private IList<PortModel> _ports;
		private IList<UserModel> _users;
		private IList<UserModel> _sales;
		private IList<DepartmentModel> _departments;
		private IList<JobTypeModel> _jobsType;
		private IList<AgentCategoryModel> _agentCategories;

		private readonly CustomerRepository _customerRepository = new CustomerRepository();
		private readonly JobSeaExportRepository _seaExportRepository = new JobSeaExportRepository();
		private readonly JobSeaExportDetailRepository _seaExportDetailRepository = new JobSeaExportDetailRepository();
		private readonly PortRepository _portRepository = new PortRepository();
		private readonly UserRepository _userRepository = new UserRepository();
		private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();
		private readonly AgentRepository _agentRepository = new AgentRepository();
		private readonly JobTypeRepository _jobTypeRepository = new JobTypeRepository();
		private readonly AgentCategoryRepository _agentCategoryRepository = new AgentCategoryRepository();

		private IList<UserPermissionModel> _userPermission;
		private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
		private readonly FormRepository _formRepository = new FormRepository();

		private bool _canAdd;
		private bool _canEdit;
		private bool _canDelete;
		private bool _canPrint;
		private bool _isAdmin;
		private bool _isProtected;

		private int _orderBy;
		private int? _departmentFilter = 0;
		private int? _salesFilter = 0;

		private EnumStatusType _statusFilter = EnumStatusType.NotSelected;

		#region Implementation of IFormWithRibbon

		public RibbonControl MainRibbon => rcJobSeaExport;
		public RibbonPage DefaultPage => rpJobSeaExport;


		#endregion

		public JobSeaExportListForm()
        {
            InitializeComponent();

			StartLoading();
		}

		private void StartLoading()
		{
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
				_formId = _formRepository.SelectFormByName(_formName);
				_userPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, _formId) ?? new List<UserPermissionModel>();

				_isProtected = _userPermission.Any(x => x.ControlName == "IsProtected" && x.Value is bool b && b);

				_customers = _customerRepository.SelectCustomers(_isProtected);
				_seaExports = _seaExportRepository.JobsSeaExportList(_isProtected);
				_seaExportJobDetails = _seaExportDetailRepository.JobsSeaExportDetail(_isProtected);
				_ports = _portRepository.SelectPorts(PortType.Seaport);
				_users = _userRepository.SelectUsers(_isProtected);
				_sales = _userRepository.SelectUsersAsSales(_isProtected);
				_agents = _agentRepository.SelectAgents(_isProtected);
				_agentCategories = _agentCategoryRepository.SelectAgentCategories(_isProtected);
				_jobsType = _jobTypeRepository.SelectJobsType(_isProtected);
				_departments = _departmentRepository.SelectDepartments();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			gcSeaExport.DataSource = _seaExports;
			repCustomers.DataSource = _customers;
			repAgents.DataSource = _agents;
			repSideId.DataSource = _agents;
			repPOLPortCodeList.DataSource = _ports;
			repPODPortCodeList.DataSource = _ports;
			repUsersList.DataSource = _users;
			repSalesList.DataSource = _sales;
			repJobsType.DataSource = _jobsType;
			repAgentCategories.DataSource = _agentCategories;
			repStatusList.DataSource = Enum.GetValues(typeof(EnumStatusType));
		}

		private void ApplyPermissions()
		{
			if (_userPermission == null || _userPermission.Count == 0) return;

			_canAdd = _userPermission.Any(x => x.ControlName == "CanAdd" && x.Value is bool b && b);
			_canEdit = _userPermission.Any(x => x.ControlName == "CanEdit" && x.Value is bool b && b);
			_canDelete = _userPermission.Any(x => x.ControlName == "CanDelete" && x.Value is bool b && b);
			_canPrint = _userPermission.Any(x => x.ControlName == "CanPrint" && x.Value is bool b && b);
			_isAdmin = _userPermission.Any(x => x.ControlName == "IsAdmin" && x.Value is bool b && b);

			btnNew.Enabled = _isAdmin || _canAdd;
			btnEdit.Enabled = _isAdmin || _canEdit;
			btnPrint.Enabled = _isAdmin || _canPrint;
			btnDelete.Enabled = _isAdmin || _canDelete;

			rpgPermissions.Visible = _isProtected || _isAdmin;
			chkShowProtected.Visibility = (_isProtected || _isAdmin) ? BarItemVisibility.Always : BarItemVisibility.Never;
		}

		private void ApplyDefaults()
		{
			LayoutsStyle.LoadLayoutGrid(gvSeaExport, CurrentUser.UserName, CurrentUser.CompanyName);

			foreach (var value in new[] { "showActive", "showClosed", "showCancelled", "showAll" })
				rgFilterReports.Gallery.GetItemByValue(value).Checked = false;

			rgSortByReports.Gallery.GetItemByValue("SortByJobNo").Checked = true;
			rgOrderByReports.Gallery.GetItemByValue("Descending").Checked = true;
			gvSeaExport.Columns["JobNo"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;

			gvSeaExport.ActiveFilter.Clear();
			gvSeaExport.ActiveFilter.Add(gvSeaExport.Columns["Tejrim"],
				new ColumnFilterInfo("[Tejrim] = 'False'", "Tejrim = False"));

			LayoutsStyle.LoadLayoutGrid(gvSeaExport, CurrentUser.UserName, CurrentUser.CompanyName);
		}

		private void JobSeaExportListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvSeaExport, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		private void RcvUpdatedJobSeaExport(object sender, EventArgs e)
		{
			if (sender is not JobSeaExportModel model) return;
			_jobSeaExportModel = model;

			if (_jobSeaExportModel.LastModifiedDate == null || _jobSeaExportModel.Deleted)
			{
				InitializeBindings();
				WireUpBindings();
			}
			else
			{
				gvSeaExport.UpdateCurrentRow();
			}
		}

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			//var frm = new JobSeaExportEditForm(new JobSeaExportModel());
			//frm.SendUpdatedJobSeaExport += RcvUpdatedJobSeaExport;
			//frm.ShowDialog();
			ShowJobSeaExportEditor(new JobSeaExportModel());
		}

		private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!_seaExports.Any()) return;

			try
			{
				if (gvSeaExport.GetFocusedRowCellValue("Id") is not int currentRowId) return;

				_jobSeaExportModel = _seaExports.SingleOrDefault(x => x.Id == currentRowId);
				if (_jobSeaExportModel == null) return;

				ShowJobSeaExportEditor(_jobSeaExportModel);
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{
			InitializeBindings();
			WireUpBindings();
		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcSeaExport.ShowRibbonPrintPreview();
		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			// Implementation needed
		}

		private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			Close();
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

		private void gvSeaExportList_RowCellStyle(object sender, RowCellStyleEventArgs e)
		{

		}

		private void rgFilterReports_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
		{
			GridFilterBy();
		}

		private void GridFilterBy()
		{
			var view = gvSeaExport;
			view.ActiveFilter.Clear();

			var itemIsActive = rgFilterReports.Gallery.GetItemByValue("showActive");
			var itemIsClosed = rgFilterReports.Gallery.GetItemByValue("showClosed");
			var itemIsCancelled = rgFilterReports.Gallery.GetItemByValue("showCancelled");
			var itemIsAll = rgFilterReports.Gallery.GetItemByValue("showAll");

			if (_departmentFilter != null && !string.IsNullOrEmpty(cboOperatingUsers.Edit.GetDisplayText(cboOperatingUsers.EditValue)))
			{
				view.ActiveFilter.Add(view.Columns["DepartmentId"],
					new ColumnFilterInfo(
						$"[DepartmentId] = '{cboOperatingUsers.EditValue}'",
						$"Department = {cboOperatingUsers.Edit.GetDisplayText(cboOperatingUsers.EditValue)}"));
			}

			if (_salesFilter != null && !string.IsNullOrEmpty(cboSales.Edit.GetDisplayText(cboSales.EditValue)))
			{
				view.ActiveFilter.Add(view.Columns["SalesId"],
					new ColumnFilterInfo(
						$"[SalesId] = '{cboSales.EditValue}'",
						$"Sales = {cboSales.Edit.GetDisplayText(cboSales.EditValue)}"));
			}

			if (!string.IsNullOrEmpty(cboStatus.Edit.GetDisplayText(cboStatus.EditValue)))
			{
				view.ActiveFilter.Add(view.Columns["Status"],
					new ColumnFilterInfo(
						$"[Status] = '{cboStatus.EditValue}'",
						$"Status = {cboStatus.Edit.GetDisplayText(cboStatus.EditValue)}"));
			}

			if (itemIsActive.Checked)
			{
				view.ActiveFilter.Add(view.Columns["Tejrim"],
					new ColumnFilterInfo("[Tejrim] = 'False' AND [CancelledJob] = 'False' AND [Closed] = 'False'",
						"Tejrim = False"));
			}
			if (itemIsClosed.Checked)
			{
				view.ActiveFilter.Add(view.Columns["Tejrim"],
					new ColumnFilterInfo("[Tejrim] = 'True' AND [CancelledJob] = 'False' AND [Closed] = 'True'", "Tejrim = True"));
			}
			if (itemIsCancelled.Checked)
			{
				view.ActiveFilter.Add(view.Columns["CancelledJob"],
					new ColumnFilterInfo("[CancelledJob] = 'True'", "Canceled = True"));
			}
			if (!itemIsAll.Checked && !itemIsActive.Checked && !itemIsClosed.Checked && !itemIsCancelled.Checked)
			{
				view.ActiveFilter.Add(view.Columns["Tejrim"],
					new ColumnFilterInfo("[Tejrim] = 'False'", "Tejrim = False"));
			}
			gvSeaExport.MoveFirst();
		}

		private void rgSortByReports_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
		{
			GridSortBy();
		}

		private void GridSortBy()
		{
			var sortByJobNo = rgSortByReports.Gallery.GetItemByValue("SortByJobNo");
			var sortByRefNo = rgSortByReports.Gallery.GetItemByValue("SortByRefNo");
			var orderByAscending = rgOrderByReports.Gallery.GetItemByValue("Ascending");
			var orderByDescending = rgOrderByReports.Gallery.GetItemByValue("Descending");

			gvSeaExport.ClearSorting();
			if (rgSortByReports.Gallery != null)
			{
				if (sortByJobNo.Checked)
				{
					gvSeaExport.Columns["JobNo"].SortOrder = orderByAscending.Checked
						? DevExpress.Data.ColumnSortOrder.Ascending
						: DevExpress.Data.ColumnSortOrder.Descending;
				}
				if (sortByRefNo.Checked)
				{
					gvSeaExport.Columns["ReferenceNo"].SortOrder = orderByAscending.Checked
						? DevExpress.Data.ColumnSortOrder.Ascending
						: DevExpress.Data.ColumnSortOrder.Descending;
				}
			}
			gvSeaExport.MoveFirst();
		}

		private void gvSeaExport_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
		{

		}

		private void gvSeaExport_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
		{

		}

		private void gvSeaExport_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
		{
			e.RelationCount = 1;
		}

		private void gvSeaExport_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
		{
			e.RelationName = "FK_JobDetails";
		}

		private void gvSeaExports_DoubleClick(object sender, EventArgs e)
		{

		}

		private void rgOrderByReports_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
		{
			GridSortBy();
		}

		private void chkShowProtected_CheckedChanged(object sender, ItemClickEventArgs e)
		{
			// Implementation needed
		}


		private void ShowJobSeaExportEditor(JobSeaExportModel model)
		{
			if (_jobSeaExportEditForm == null || _jobSeaExportEditForm.IsDisposed)
			{
				_jobSeaExportEditForm = new JobSeaExportEditForm(model);
				_jobSeaExportEditForm.SendUpdatedJobSeaExport += RcvUpdatedJobSeaExport;
				_jobSeaExportEditForm.FormClosed += JobSeaExportEditForm_FormClosed;

				_jobSeaExportEditForm.Show(this);
				return;
			}

			if (_jobSeaExportEditForm.WindowState == FormWindowState.Minimized)
				_jobSeaExportEditForm.WindowState = FormWindowState.Normal;

			_jobSeaExportEditForm.Activate();
			_jobSeaExportEditForm.BringToFront();
		}

		private void JobSeaExportEditForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			var form = sender as JobSeaExportEditForm;
			if (form != null)
			{
				form.SendUpdatedJobSeaExport -= RcvUpdatedJobSeaExport;
				form.FormClosed -= JobSeaExportEditForm_FormClosed;
			}
			if (ReferenceEquals(_jobSeaExportEditForm, sender))
				_jobSeaExportEditForm = null;
		}
	}
}