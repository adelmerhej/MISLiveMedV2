using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using MISLiveMed.DataLayers.Common.Departments;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.Reports.Quotations;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Reports.Quotations;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.Quotations;
using MISLiveMed.UI.Properties;
using MISLiveMed.UI.Utilities;

namespace MISLiveMed.UI.Reports.DOP
{
    public partial class QuotationsJobsReportForm : XtraForm
	{
		private const string _formName = "QuotationsJobsReport";
		private int _formId;

		private IList<QuotationsJobsReportModel> _dataReportModels = new List<QuotationsJobsReportModel>();
        private IList<CustomerModel> _customers = new List<CustomerModel>();
        private IList<UserModel> _sales = new List<UserModel>();
        private IList<UserModel> _users = new List<UserModel>();
        private IList<DepartmentModel> _departments = new List<DepartmentModel>();
        private IList<InitDataModelExtended> _filterList = new List<InitDataModelExtended>();

        private CustomerRepository _customerRepository = new CustomerRepository();
        private DepartmentRepository _departmentRepository = new DepartmentRepository();
        private UserRepository _userRepository = new UserRepository();

        private QuotationsJobsReportRepository _quotationsJobsReportRepository = new QuotationsJobsReportRepository();

        /// <summary>
        /// User Permission Role
        /// </summary>
        private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
        private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
        private readonly FormRepository _formRepository = new FormRepository();

        private bool _canAccessProfit;
        private bool _isAdmin;
        private bool _isProtected;

		private DateTime? _dateFrom = DateTime.Now;
        private DateTime? _dateTo = DateTime.Now;
        private DateTime? _followupDateFrom = DateTime.Now;
        private DateTime? _followupDateTo = DateTime.Now;

        private int _customerId = 0;
        private int _salesId = 0;
        private int _userId = 0;
        private int _departmentId = 0;
        private string _statusFilter = "All";
        private float _defaultZoomValue = 1;

        public QuotationsJobsReportForm()
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

				_customers = _customerRepository.SelectCustomers();
				_sales = _userRepository.SelectUsersAsSales();
				_users = _userRepository.SelectUsers();
				_departments = _departmentRepository.SelectDepartments();

				ApplyDefaultFilter();
				ChangeDateFilterSelection();
				CheckDailyStatus();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {
            cboCustomers.Properties.DataSource = null;
            cboCustomers.Properties.DataSource = _customers;

            cboSales.Properties.DataSource = null;
            cboSales.Properties.DataSource = _sales;

            cboUsers.Properties.DataSource = null;
            cboUsers.Properties.DataSource = _users;

            cboDepartments.Properties.DataSource = null;
            cboDepartments.Properties.DataSource = _departments;

        }

        private void ApplyPermissions()
        {
	        if (_userPermission == null) return;
	        if (_userPermission.Count <= 0) return;
	        var canAccessProfit = _userPermission.SingleOrDefault(x => x.ControlName == "CanAccessProfit")?.Value;
	        if (canAccessProfit != null) _canAccessProfit = (bool)canAccessProfit;

	        var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
	        if (isAdmin != null) _isAdmin = (bool)isAdmin;

			if (_userPermission == null) return;
	        layoutOfSetDefaultFilter.Visibility = _isAdmin
		        ? LayoutVisibility.Always
		        : LayoutVisibility.Never;
		}
        private void ApplyDefaults()
        {
	        grpDateFilterBy.SelectedIndex = 0;
			
			statusFilterGroup.SelectedIndex = 5;
            rgOrderByFilter.SelectedIndex = 0;
            rgSortingByFilter.SelectedIndex = 1;

            _defaultZoomValue = 1;
            zoomValue.EditValue = _defaultZoomValue;
            zoomValue.EditValue = Settings.Default.ZoomValue;

            rgUrgentFilter.SelectedIndex = 0;
            chkShowRemarks.Checked = true;
            rgSectionFilter.SelectedIndex = 0;

            dtJobDateFrom.EditValue = DateTime.Parse("01/01/" + DateTime.Today.Year); ;
            dtJobDateTo.EditValue = DateTime.Now;

            dtFollowupFrom.EditValue = DateTime.Parse("01/01/" + DateTime.Today.Year); ;
            dtFollowupTo.EditValue = DateTime.Now;

            ChangeDateFilterSelection();
            chkAll_CheckedChanged();
        }

        #region Buttons Event

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            try
            {
                _customerId = 0;
                _salesId = 0;
                _userId = 0;
                _departmentId = 0;

                _dateFrom = null;
                _dateTo = null;
                _followupDateFrom = null;
                _followupDateTo = null;

                if (dtJobDateFrom.EditValue != null) _dateFrom = (DateTime)dtJobDateFrom.EditValue;
                if (dtJobDateTo.EditValue != null) _dateTo = (DateTime)dtJobDateTo.EditValue;

                if (dtFollowupFrom.EditValue != null) _followupDateFrom = (DateTime)dtFollowupFrom.EditValue;
                if (dtFollowupTo.EditValue != null) _followupDateTo = (DateTime)dtFollowupTo.EditValue;


                if (cboCustomers.EditValue != null) _customerId = (int)cboCustomers.EditValue;
                if (cboSales.EditValue != null) _salesId = (int)cboSales.EditValue;
                if (cboUsers.EditValue != null) _userId = (int)cboUsers.EditValue;
                if (cboDepartments.EditValue != null) _departmentId = (int)cboDepartments.EditValue;

                _statusFilter = statusFilterGroup.GetItemValue(statusFilterGroup.SelectedIndex) as string;
                string orderBy = (string)rgOrderByFilter.EditValue;
                string sortingBy = (string)rgSortingByFilter.EditValue;
                int urgent = rgUrgentFilter.SelectedIndex;

                int sectionFilter = rgSectionFilter.SelectedIndex;

                _dataReportModels = _quotationsJobsReportRepository.QuotationsJobsReport(_dateFrom, _dateTo,
                    _departmentId, _customerId, _salesId, _userId, _statusFilter, chkToggleQueryResult.Checked,
                    orderBy, sortingBy, urgent, _followupDateFrom, _followupDateTo, sectionFilter);

                if (chkGroupByDepartments.Checked)
                {
                    PrintReportByDepartment();
                }
                else
                {
                    PrintReportByList();
                }

                SaveFilter();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        #endregion

        #region Print Report Output

        private void PrintReportByDepartment()
        {
            try
            {
                var previewForm = new DocumentViewerForm();
                var report = new QuotationsJobsReport();

                report.DataSource = _dataReportModels;

                previewForm.Viewer.DocumentSource = report;
                previewForm.Viewer.AutoZoom = true;
                previewForm.Viewer.Zoom = (float)zoomValue.Value / 100;

                //Adding parameters
                _statusFilter = statusFilterGroup.GetItemValue(statusFilterGroup.SelectedIndex) as string;

                report.Parameters["pFilterStatus"].Value = _statusFilter;
                report.Parameters["DateFrom"].Value = dtJobDateFrom.DateTime;
                report.Parameters["DateTo"].Value = dtJobDateTo.DateTime;
                report.Parameters["ShowRemarks"].Value = chkShowRemarks.Checked;

                previewForm.ShowDialog();

                SaveFilter();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Report Data Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void PrintReportByList()
        {
            try
            {
                var previewForm = new DocumentViewerForm();
                var report = new QuotationsJobsListReport();

                report.DataSource = _dataReportModels;

                previewForm.Viewer.DocumentSource = report;
                previewForm.Viewer.AutoZoom = true;
                previewForm.Viewer.Zoom = (float)zoomValue.Value / 100;

                //Adding parameters
                _statusFilter = statusFilterGroup.GetItemValue(statusFilterGroup.SelectedIndex) as string;

                report.Parameters["pFilterStatus"].Value = _statusFilter;
                report.Parameters["DateFrom"].Value = _dateFrom;
                report.Parameters["DateTo"].Value = _dateTo;
                report.Parameters["ShowRemarks"].Value = chkShowRemarks.Checked;

                previewForm.ShowDialog();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Report Data Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            chkAll_CheckedChanged();
        }
        private void chkAll_CheckedChanged()
        {
            //chkBooked.Enabled = !chkAll.Checked;
            //chkDeleted.Enabled = !chkAll.Checked;
            //chkLost.Enabled = !chkAll.Checked;

            //chkBooked.Checked = chkAll.Checked;
            //chkLost.Checked = chkAll.Checked;
            //chkDeleted.Checked = chkAll.Checked;
        }

        private void chkToggleQueryResult_CheckedChanged(object sender, EventArgs e)
        {
            if (chkToggleQueryResult.Checked)
            {
                grpStatusFilter.Text = @"Status filter (Match Jobs)";
                rgUrgentFilter.SelectedIndex = 0;
                rgUrgentFilter.Enabled = false;
            }
            else
            {
                grpStatusFilter.Text = @"Status filter (Non Operations)";
                rgUrgentFilter.Enabled = true;
            }
        }

        private void QuotationsJobsReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckAndSaveSettings();
            SaveFilter();
        }
        private void CheckAndSaveSettings()
        {
            if (zoomValue.EditValue != null) Settings.Default.ZoomValue = (float)zoomValue.Value;
            Settings.Default.Save();
        }

        private void rgOrderByFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderBy = (string)rgOrderByFilter.EditValue;
            int sortingBy = (int)rgSortingByFilter.SelectedIndex;

            switch (orderBy)
            {
                case "ByFollowupDate":
                    rgSortingByFilter.SelectedIndex = 0;
                    break;

                default:
                    rgSortingByFilter.SelectedIndex = sortingBy;
                    break;
            }
        }

        private void statusFilterGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SaveFilter()
        {
            if(!chkSaveFilter.Checked)
            {
                Settings.Default.CustomFilter = "";
                Settings.Default.SaveCustomFilter = false;
                Settings.Default.Save();
                return;
            }

            // INIT
            List<InitDataModelExtended> initDataList = new List<InitDataModelExtended>();

            //SEED
            if (dtJobDateFrom.EditValue != null)
                initDataList.Add(new InitDataModelExtended { Name = "DateFrom", Value = dtJobDateFrom.EditValue.ToString() });

            if (dtJobDateTo.EditValue != null)
                initDataList.Add(new InitDataModelExtended { Name = "DateTo", Value = dtJobDateTo.EditValue.ToString() });

            if (chkDaily.EditValue != null)
                initDataList.Add(new InitDataModelExtended { Name = "Daily", Value = chkDaily.Checked.ToString() });

            if (cboDepartments.EditValue != null)
                initDataList.Add(new InitDataModelExtended
                    { Name = "Department", Value = cboDepartments.EditValue.ToString() });

            if (cboCustomers.EditValue != null)
                initDataList.Add(new InitDataModelExtended
                    { Name = "Customer", Value = cboCustomers.EditValue.ToString() });

            if (cboSales.EditValue != null)
                initDataList.Add(new InitDataModelExtended
                    { Name = "Sales", Value = cboSales.EditValue.ToString() });

            if (cboUsers.EditValue != null)
                initDataList.Add(new InitDataModelExtended
                    { Name = "User", Value = cboUsers.EditValue.ToString() });

            initDataList.Add(new InitDataModelExtended
                    { Name = "UrgentFilter", Value = rgUrgentFilter.SelectedIndex.ToString() });

            initDataList.Add(new InitDataModelExtended
                    { Name = "OrderByFilter", Value = rgOrderByFilter.SelectedIndex.ToString() });

            // Status Filter Group
            //InitDataModelExtended listFilterGroup = new InitDataModelExtended();
            IList<InitCheckModel> listFilterGroup = new List<InitCheckModel>();
            for (int i = 0; i < statusFilterGroup.ItemCount - 1; i++)
            {
                listFilterGroup.Add(new InitCheckModel
                {
                    Name = statusFilterGroup.Items[i].Description,
                    Value = statusFilterGroup.Items[i].CheckState.ToString()
                });
            }

            initDataList.Add(new InitDataModelExtended
                { Name = "dateFilterBy", Value = grpDateFilterBy.SelectedIndex.ToString() });

            initDataList.Add(new InitDataModelExtended
                { Name = "statusFilterGroup", Value = statusFilterGroup.SelectedIndex.ToString(), ValuesList = listFilterGroup });

            //

            initDataList.Add(new InitDataModelExtended
                { Name = "ToggleQueryResult", Value = chkToggleQueryResult.Checked.ToString() });

            initDataList.Add(new InitDataModelExtended
                { Name = "GroupByDepartments", Value = chkGroupByDepartments.Checked.ToString() });

            initDataList.Add(new InitDataModelExtended
                { Name = "SortingByFilter", Value = rgSortingByFilter.SelectedIndex.ToString() });


            //
            var jSonToString = HelperApplication.SaveJsonFilterList(initDataList);

            Settings.Default.CustomFilter = jSonToString;
            Settings.Default.SaveCustomFilter = true;
            Settings.Default.Save();
        }

        private void ApplyDefaultFilter()
        {
            var json = Settings.Default.CustomFilter;
            chkSaveFilter.Checked = Settings.Default.SaveCustomFilter;
            var defaultFilterList = HelperApplication.ReadJsonFilterList(json);

            if (defaultFilterList == null) return;

            foreach (var filter in defaultFilterList)
            {
                switch (filter.Name)
                {
                    case "Daily":
                        chkDaily.Checked = bool.Parse(filter.Value);
                        break;

                    case "DateFrom":
                        dtJobDateFrom.EditValue = DateTime.Parse(filter.Value);
                        break;

                    case "DateTo":
                        dtJobDateTo.EditValue = (chkDaily.Checked) ? DateTime.Now : DateTime.Parse(filter.Value);
                        break;

                    case "Department":
                        cboDepartments.EditValue = int.Parse(filter.Value);
                        break;

                    case "Customer":
                        cboCustomers.EditValue = int.Parse(filter.Value);
                        break;

                    case "Sales":
                        cboSales.EditValue = int.Parse(filter.Value);
                        break;

                    case "User":
                        cboUsers.EditValue = int.Parse(filter.Value);
                        break;

                    case "UrgentFilter":
                        rgUrgentFilter.SelectedIndex = int.Parse(filter.Value);
                        break;

                    case "OrderByFilter":
                        rgOrderByFilter.SelectedIndex = int.Parse(filter.Value);
                        break;

                    //statusFilterGroup should be multiple values
                    case "statusFilterGroup":
                        statusFilterGroup.SelectedIndex = int.Parse(filter.Value);
                        for (int i = 0; i < statusFilterGroup.ItemCount; i++)
                        {
                            statusFilterGroup.Items[i].CheckState = CheckState.Checked;
                        }
                        break;

                    case "ToggleQueryResult":
                        chkToggleQueryResult.Checked = bool.Parse(filter.Value);
                        break;

                    case "GroupByDepartments":
                        chkGroupByDepartments.Checked = bool.Parse(filter.Value);
                        break;

                    case "SortingByFilter":
                        rgSortingByFilter.SelectedIndex = int.Parse(filter.Value);
                        break;

                    case "dateFilterBy":
                        grpDateFilterBy.SelectedIndex = int.Parse(filter.Value);
                        break;

                        //
                }
            }
        }

        private void btnResetToDefault_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSetDefaultFilter_Click(object sender, EventArgs e)
        {

        }

        private void chkDaily_CheckedChanged(object sender, EventArgs e)
        {
            CheckDailyStatus();
        }

        private void grpDateFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeDateFilterSelection();
        }

        private void ChangeDateFilterSelection()
        {
            chkDaily.Enabled = grpDateFilterBy.SelectedIndex == 0;

            if (grpDateFilterBy.SelectedIndex == 0)
            {
                dtJobDateFrom.Enabled = true;
                dtJobDateTo.Enabled = true;
                dtFollowupFrom.Enabled = false;
                dtFollowupTo.Enabled = false;
                dtFollowupFrom.EditValue = null;
                dtFollowupTo.EditValue = null;
                dtJobDateFrom.EditValue = DateTime.Parse("01/01/2024");
                dtJobDateTo.EditValue = DateTime.Now;
            }
            else
            {
                dtJobDateFrom.Enabled = false;
                dtJobDateTo.Enabled = false;
                dtFollowupFrom.Enabled = true;
                dtFollowupTo.Enabled = true;
                dtJobDateFrom.EditValue = null;
                dtJobDateTo.EditValue = null;
                dtFollowupFrom.EditValue = DateTime.Parse("01/01/2024");
                dtFollowupTo.EditValue = DateTime.Now;
            }

        }

        private void CheckDailyStatus()
        {
            dtJobDateFrom.Enabled = !chkDaily.Checked;
            dtJobDateTo.Enabled = !chkDaily.Checked;
            if (chkDaily.Checked) dtJobDateFrom.EditValue = DateTime.Now;
            if (chkDaily.Checked) dtJobDateTo.EditValue = DateTime.Now;
        }
    }
}