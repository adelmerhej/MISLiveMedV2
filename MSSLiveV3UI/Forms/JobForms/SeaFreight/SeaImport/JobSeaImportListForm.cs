using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
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
using MISLiveMed.DataLayers.JobData.SeaImport;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries.Ports;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.Common.JobsType;
using MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.JobForms.SeaFreight.SeaImport
{
    public partial class JobSeaImportListForm : RibbonForm, IFormWithRibbon
    {
        private const string _formName = "JobSeaImportList";
        private int _formId;
        private bool _resetMenu;

        private IList<JobSeaImportModel> _seaImports;
        private JobSeaImportModel _jobSeaImportModel;
        private IList<JobSeaImportDetailModel> _seaImportJobDetails;
        private IList<CustomerModel> _customers;
        private IList<AgentModel> _agents;
        private IList<PortModel> _ports;
        private IList<UserModel> _users;
        private IList<UserModel> _sales;
        private IList<DepartmentModel> _departments;
        private IList<JobTypeModel> _jobsType;
        private IList<AgentCategoryModel> _agentCategories;

        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly JobSeaImportRepository _seaImportRepository = new JobSeaImportRepository();
        private readonly JobSeaImportDetailRepository _seaImportDetailRepository = new JobSeaImportDetailRepository();
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

        public RibbonControl MainRibbon => rcJobSeaImport;
        public RibbonPage DefaultPage => rpJobSeaImport;

        public JobSeaImportListForm(JobsType jobType)
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
                _formId = _formRepository.SelectFormByName(_formName);
                _userPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, _formId) ?? new List<UserPermissionModel>();

                _isProtected = _userPermission.Any(x => x.ControlName == "IsProtected" && x.Value is bool b && b);

                _customers = _customerRepository.SelectCustomers(_isProtected);
                _seaImports = _seaImportRepository.JobSeaImportList(_isProtected);
                _seaImportJobDetails = _seaImportDetailRepository.JobsSeaImportDetail(_isProtected);
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
            gcSeaImport.DataSource = _seaImports;
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
            LayoutsStyle.LoadLayoutGrid(gvSeaImport, CurrentUser.UserName, CurrentUser.CompanyName);

            foreach (var value in new[] { "showActive", "showClosed", "showCancelled", "showAll" })
                rgFilterReports.Gallery.GetItemByValue(value).Checked = false;

            rgSortByReports.Gallery.GetItemByValue("SortByJobNo").Checked = true;
            rgOrderByReports.Gallery.GetItemByValue("Descending").Checked = true;
            gvSeaImport.Columns["JobNo"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;

            gvSeaImport.ActiveFilter.Clear();
            gvSeaImport.ActiveFilter.Add(gvSeaImport.Columns["Tejrim"],
                new ColumnFilterInfo("[Tejrim] = 'False'", "Tejrim = False"));

            LayoutsStyle.LoadLayoutGrid(gvSeaImport, CurrentUser.UserName, CurrentUser.CompanyName);
        }

        private void RcvUpdatedJobSeaImport(object sender, EventArgs e)
        {
            if (sender is not JobSeaImportModel model) return;
            _jobSeaImportModel = model;

            if (_jobSeaImportModel.LastModifiedDate == null || _jobSeaImportModel.Deleted)
            {
                InitializeBindings();
                WireUpBindings();
            }
            else
            {
                gvSeaImport.UpdateCurrentRow();
            }
        }

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new JobSeaImportEditForm(new JobSeaImportModel());
            frm.SendUpdatedJobSeaImport += RcvUpdatedJobSeaImport;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_seaImports == null) return;
            if (gvSeaImport.GetFocusedRowCellValue("Id") is not int currentRowId) return;
            _jobSeaImportModel = _seaImports.SingleOrDefault(x => x.Id == currentRowId);

            var seaImportForm = new JobSeaImportEditForm(_jobSeaImportModel);
            seaImportForm.SendUpdatedJobSeaImport += RcvUpdatedJobSeaImport;
            seaImportForm.ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcSeaImport.ShowRibbonPrintPreview();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Implementation needed
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void gvSeaImportList_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (sender is not GridView view || e.RowHandle < 0) return;

            bool closed = view.GetRowCellValue(e.RowHandle, "Closed") is bool c && c;
            bool cancelled = view.GetRowCellValue(e.RowHandle, "CancelledJob") is bool can && can;
            bool readyForTejrim = view.GetRowCellValue(e.RowHandle, "RTejrim") is bool r && r;

            if (closed)
            {
                e.Appearance.ForeColor = Color.Gray;
                e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Italic);
            }
            if (cancelled)
            {
                e.Appearance.ForeColor = Color.Red;
                e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Strikeout);
            }
            if (readyForTejrim)
            {
                e.Appearance.BackColor = Color.Blue;
                e.Appearance.ForeColor = Color.White;
            }
        }

        private void rgFilterReports_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            GridFilterBy();
        }

        private void GridFilterBy()
        {
            var view = gvSeaImport;
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
            gvSeaImport.MoveFirst();
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

            gvSeaImport.ClearSorting();
            if (rgSortByReports.Gallery != null)
            {
                if (sortByJobNo.Checked)
                {
                    gvSeaImport.Columns["JobNo"].SortOrder = orderByAscending.Checked
                        ? DevExpress.Data.ColumnSortOrder.Ascending
                        : DevExpress.Data.ColumnSortOrder.Descending;
                }
                if (sortByRefNo.Checked)
                {
                    gvSeaImport.Columns["ReferenceNo"].SortOrder = orderByAscending.Checked
                        ? DevExpress.Data.ColumnSortOrder.Ascending
                        : DevExpress.Data.ColumnSortOrder.Descending;
                }
            }
            gvSeaImport.MoveFirst();
        }

        private void gvSeaImports_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            if (sender is not GridView view) return;
            if (view.GetRow(e.RowHandle) is JobSeaImportModel seaImportJobList)
                e.IsEmpty = _seaImportJobDetails.All(x => x.JobId != seaImportJobList.JobNo);
        }

        private void gvSeaImports_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            if (sender is not GridView view) return;
            if (view.GetRow(e.RowHandle) is JobSeaImportModel seaImportJobList)
            {
                e.ChildList = _seaImportJobDetails
                    .Where(x => x.JobId == seaImportJobList.JobNo).ToList();
                view.OptionsBehavior.Editable = false;
            }
        }

        private void gvSeaImports_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gvSeaImports_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "FK_JobDetails";
        }

        private void gcSeaImports_DoubleClick(object sender, EventArgs e)
        {
            if (!_isAdmin && !_canEdit) return;
            if (_seaImports == null) return;
            if (gvSeaImport.GetFocusedRowCellValue("Id") is not int currentRowId) return;
            _jobSeaImportModel = _seaImports.SingleOrDefault(x => x.Id == currentRowId);

            var seaImportForm = new JobSeaImportEditForm(_jobSeaImportModel);
            seaImportForm.SendUpdatedJobSeaImport += RcvUpdatedJobSeaImport;
            seaImportForm.ShowDialog();
        }

        private void rgOrderByReports_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            GridSortBy();
        }

        private void chkShowProtected_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            // Implementation needed
        }

        private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                DialogResult.Yes)
            {
                _resetMenu = true;
                LayoutsStyle.ResetLayoutGrid(gvSeaImport, CurrentUser.UserName, CurrentUser.CompanyName);
            }
        }

        private void JobSeaImportListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_resetMenu)
            {
                LayoutsStyle.SaveLayoutGrid(gvSeaImport, CurrentUser.UserName, CurrentUser.CompanyName);
            }
        }
    }
}