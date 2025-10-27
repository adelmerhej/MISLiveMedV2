using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Departments;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Reports.History;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.Reports.History;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;

namespace MISLiveMed.UI.Reports.History
{
    public partial class AllJobsHistoryListReportForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "AllJobsHistoryListReport";
		private int _formId;

		private IList<JobsHistoryReportModel> _jobsHistory = new List<JobsHistoryReportModel>();
        private IList<UserModel> _users = new List<UserModel>();
        private IList<DepartmentModel> _departments = new List<DepartmentModel>();
        private IList<JobsHistoryReportModel> _jobsHistoryReport = new List<JobsHistoryReportModel>();

        private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();
        private readonly UserRepository _userRepository = new UserRepository();

        /// <summary>
        /// User Permission Role
        /// </summary>
        private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
        private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
        private readonly FormRepository _formRepository = new FormRepository();

        private bool _canAccessProfit;
		private bool _isAdmin;
		private bool _isProtected;

		private int _sortingBy = 0;
        private int _departmentsFilter = 0;
        private int _usersFilter = 0;
        private int _statusFilter = -1;
        private bool _isActive = false;
        private bool _isCanceled = false;
        private bool _isClosed = false;
        private bool _isAll = true;

        private DateTime _startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

        #region Implementation of IFormWithRibbon

        public RibbonControl MainRibbon => rcJobHistory;
        public RibbonPage DefaultPage => rpJobHistory;


        #endregion

        public AllJobsHistoryListReportForm()
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

				_users = _userRepository.SelectUsers();
				_departments = _departmentRepository.SelectDepartments();
				_jobsHistory = JobHistoryDal.JobHistoryReportDataList(DateFromAsDateOnly(), dtTo.EditValue as DateTime?, 0,
					0, _isAll, _isActive, _isClosed, _isCanceled, _sortingBy);
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }
        private void ApplyPermissions()
        {
	        if (_userPermission.Count <= 0) return;

	        var canAccessProfit = _userPermission.SingleOrDefault(x => x.ControlName == "CanAccessProfit")?.Value;
	        if (canAccessProfit != null) _canAccessProfit = (bool)canAccessProfit;

	        var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
	        if (isAdmin != null) _isAdmin = (bool)isAdmin;
        }

		private void WireUpBindings()
        {
            //repUsers.DataSource = null;
            //repUsers.DataSource = _users;

            //repOperators.DataSource = null;
            //repOperators.DataSource = _users;

            //repDepartments.DataSource = null;
            //repDepartments.DataSource = _departments;

            bsAllJobsHistory.DataSource = _jobsHistory;
            gcJobHistory.DataSource = null;
            gcJobHistory.DataSource = bsAllJobsHistory;

        }

        private void ApplyDefaults()
        {
            rgFilterReports.Gallery.GetItemByValue("showAll").Checked = false;
            rgFilterReports.Gallery.GetItemByValue("showActive").Checked = false;
            rgFilterReports.Gallery.GetItemByValue("showClosed").Checked = false;
            rgFilterReports.Gallery.GetItemByValue("showCanceled").Checked = false;

            rgSortByReports.Gallery.GetItemByValue("SortByJobNo").Checked = true;
            rgSortByReports.Gallery.GetItemByValue("SortByDepartments").Checked = false;

            dtFrom.EditValue = DateTime.Parse("08/01/2016");
            dtTo.EditValue = DateTime.Now;
        }

        #region Buttons Event

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        #endregion

        #region MyRegion

        private DateTime? DateFromAsDateOnly()
        {
            if (dtFrom.EditValue == null) return null;

            DateTime fromDate = (DateTime)dtFrom.EditValue;
            fromDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day, 0, 0, 0);

            return fromDate;
        }

        #endregion

    }
}