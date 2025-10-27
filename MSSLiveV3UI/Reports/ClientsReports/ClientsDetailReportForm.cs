using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.Reports.ClientsReports;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.ClientsReports;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.ClientsReports;
using MISLiveMed.UI.Main;

namespace MISLiveMed.UI.Reports.ClientsReports
{
    public partial class ClientsDetailReportForm : XtraForm
	{
		private const string _formName = "ClientsDetailReport";
		private int _formId;

        private IList<UserModel> _sales = new List<UserModel>();
        private IList<UserModel> _users = new List<UserModel>();
        private IList<CustomerModel> _customers = new List<CustomerModel>();
        private IList<ClientDetailReportModel> _dataReportModels = new List<ClientDetailReportModel>();

        private readonly UserRepository _userRepository = new UserRepository();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly ClientDetailReportRepository _clientDetailReportRepository = new ClientDetailReportRepository();

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
        private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
        private readonly FormRepository _formRepository = new FormRepository();

        private bool _canAccessProfit;
		private bool _isAdmin;
		private bool _isProtected;

		public ClientsDetailReportForm()
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
				_users = _userRepository.SelectUsers();
				_sales = _userRepository.SelectUsersAsSales();
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

            cboUsers.Properties.DataSource = null;
            cboUsers.Properties.DataSource = _users;

            cboSales.Properties.DataSource = null;
            cboSales.Properties.DataSource = _sales;

        }

        private void ApplyPermissions()
		{   
			if (_userPermission == null) return;
			if (_userPermission.Count <= 0) return;

			var canAccessProfit = _userPermission.SingleOrDefault(x => x.ControlName == "CanAccessProfit")?.Value;
			if (canAccessProfit != null) _canAccessProfit = (bool)canAccessProfit;

			var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
			if (isAdmin != null) _isAdmin = (bool)isAdmin;

			chkShowProfit.Visible = _isAdmin || _canAccessProfit;
			chkShowProfit.Checked = _isAdmin || _canAccessProfit;
		}

        private void ApplyDefaults()
        {
            //dtDateFrom.EditValue = new DateTime(DateTime.Now.Year, 1, 1); ;
            //dtDateTo.EditValue = DateTime.Now;

            chkDepartmentsList.SelectedIndex = 0;
            statusFilterGroup.SelectedIndex = 0;

            rgOrderByFilter.SelectedIndex = 0;
            rgSortingByFilter.SelectedIndex = 0;
        }

        #region Buttons Event

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int pendingTime = 0; // the delay is 1 second (1000 ms)
                SplashScreenManager.ShowForm(null, typeof(WaitForm1), true, true, true, pendingTime);

                var previewForm = new DocumentViewerForm();

                //int pending = (int)rgPendingPaidJobs.EditValue;
                //bool detailedJobs = chkPrintDetailed.Checked;
                int userId = 0;
                int customerId = 0;
                int salesId = 0;

                DateTime? dateFrom = (DateTime?)dtDateFrom.EditValue;
                DateTime? dateTo = (DateTime?)dtDateTo.EditValue;



                if (cboUsers.EditValue != null) userId = (int)cboUsers.EditValue;
                if (cboCustomers.EditValue != null) customerId = (int)cboCustomers.EditValue;
                if (cboSales.EditValue != null) salesId = (int)cboSales.EditValue;

                //statusFilterGroup.Items[5].CheckState
                int fullPaid = (int)statusFilterGroup.Items[5].CheckState;

                string statusFilter = FillStatusFilterList();
                string departmentsFilter = FillDepartmentsFilterList();

                string orderBy = (string)rgOrderByFilter.EditValue;
                string sortingBy = (string)rgSortingByFilter.EditValue;

                var report = new ClientsDetailedReport();
                _dataReportModels = _clientDetailReportRepository.SelectClientDetailReport(dateFrom, dateTo, userId, customerId, salesId, 
                    statusFilter, departmentsFilter, orderBy, sortingBy, fullPaid);

                report.DataSource = _dataReportModels;

                report.Parameters["DateFrom"].Value = dateFrom;
                report.Parameters["DateTo"].Value = dateTo;
                report.Parameters["ProfitVisibility"].Value = chkShowProfit.CheckState == CheckState.Checked; ;

                //report.Parameters["isAdmin"].Value = _isAdmin;
                //report.Parameters["showNegative"].Value = chkOnlyNegative.Checked;
                //report.Parameters["detailedJobs"].Value = detailedJobs;

                previewForm.Viewer.DocumentSource = report;

                previewForm.Viewer.AutoZoom = true;
                previewForm.Viewer.Zoom = (float)zoomValue.Value/100;

                previewForm.ShowDialog();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Report Data Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void statusFilterGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (statusFilterGroup.SelectedIndex)
            {
                case 0:
                    statusFilterGroup.CheckAll();
                    statusFilterGroup.Items[4].CheckState = CheckState.Unchecked;
                    statusFilterGroup.Items[5].CheckState = CheckState.Unchecked;
                    break;

                default:
                    statusFilterGroup.Items[0].CheckState = CheckState.Unchecked;
                    break;

            }
        }
        private void chkDepartmentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (chkDepartmentsList.SelectedIndex)
            {
                case 0:
                    chkDepartmentsList.CheckAll();
                    break;

                default:
                    chkDepartmentsList.Items[0].CheckState = CheckState.Unchecked;
                    break;

            }
        }

        private string FillStatusFilterList()
        {
            StringBuilder statusFilterList = new StringBuilder();

            foreach (CheckedListBoxItem status in statusFilterGroup.Items)
            {
                if (status.Value.ToString() == "0") continue;
                if (status.CheckState == CheckState.Unchecked) continue;

                statusFilterList.Append(status.Value.ToString());
                statusFilterList.Append(",");
            }
            if (statusFilterList.Length > 0) statusFilterList.Length -= 1;

            return statusFilterList.ToString();
        }

        private string FillDepartmentsFilterList()
        {
            StringBuilder departmentsList = new StringBuilder();

            foreach (CheckedListBoxItem department in chkDepartmentsList.CheckedItems)
            {
                if (department.Value.ToString() == "0") continue;
                if (department.CheckState == CheckState.Unchecked) continue;

                departmentsList.Append(department.Value.ToString());
                departmentsList.Append(",");
            }
            if (departmentsList.Length > 0) departmentsList.Length -= 1;

            return departmentsList.ToString();
        }
	}
}