using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.Reports;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Reports.Profit;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.Jobs.JobsStatus;
using MISLiveMed.UI.Main;

namespace MISLiveMed.UI.Reports.DOP
{
    public partial class DetailedProfitReportForm : XtraForm
	{
		private const string _formName = "DetailedProfitReport";
		private int _formId;

		private IList<DetailedProfitReportModel> _detailedTotalProfitModels;
        private IList<DepartmentModel> _departments = new List<DepartmentModel>();
        private IList<UserModel> _users = new List<UserModel>();
        private IList<CustomerModel> _customers = new List<CustomerModel>();
        private IList<UserModel> _sales = new List<UserModel>();

        private readonly UserRepository _userRepository = new UserRepository();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        
        private StringBuilder _sb = new StringBuilder();
        private int _outputType = 0;

        /// <summary>
        /// User Permission Role
        /// </summary>
        private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
        private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
        private readonly FormRepository _formRepository = new FormRepository();

        private bool _canAccessProfit;
        private bool _isAdmin;
        private bool _isProtected;

		public DetailedProfitReportForm(int outputType = 1)
        {
            InitializeComponent();
            
            try
            {
	            _outputType = outputType;

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
				_customers = _customerRepository.SelectCustomers();
				_sales = _userRepository.SelectUsersAsSales();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {
            cboUsersList.Properties.DataSource = _users;
            cboCustomersList.Properties.DataSource = _customers;
            cboSalesList.Properties.DataSource = _sales;

        }
        private void ApplyDefaults()
        {
            dtDateFrom.EditValue = DateTime.Parse("08/01/2016");
            dtDateTo.EditValue = DateTime.Now;
            
            rgShipmentTypeOptions.SelectedIndex = 0;
            rgProvision.SelectedIndex = 0;
            chkDetailedReport.CheckState = CheckState.Checked;
            rgReportVisibilityOptions.SelectedIndex = 0;
            rgPendingPaidJobs.SelectedIndex = 0;
        }

        private void ApplyPermissions()
        {
	        if (_userPermission == null) return;
	        if (_userPermission.Count <= 0) return;

	        var canAccessProfit = _userPermission.SingleOrDefault(x => x.ControlName == "CanAccessProfit")?.Value;
	        if (canAccessProfit != null) _canAccessProfit = (bool)canAccessProfit;

	        var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
	        if (isAdmin != null) _isAdmin = (bool)isAdmin;

		}

		private void btnPrint_Click(object sender, System.EventArgs e)
        {
            DateTime? dateFrom = (DateTime)dtDateFrom.EditValue;
            DateTime? dateTo = (DateTime)dtDateTo.EditValue;
            int provision = (int)rgProvision.EditValue;
            var strOutputType = _outputType == 1 ? "V1" : "Real";

            int userId = 0;
            int customerId = 0;
            int salesId = 0;
            int pendingFullPaid = (int)rgPendingPaidJobs.EditValue;
            
            int departmentId = (int)rgShipmentTypeOptions.EditValue;
            int visibilityType = (int)rgReportVisibilityOptions.EditValue;
            bool detailedReport = (bool)chkDetailedReport.EditValue;

            if (cboUsersList.EditValue != null)
            {
                userId = (int)cboUsersList.EditValue;
            }

            if (cboCustomersList.EditValue != null)
            {
                customerId = (int)cboCustomersList.EditValue;
            }

            if (cboSalesList.EditValue != null)
            {
                salesId = (int)cboSalesList.EditValue;
            }

            try
            
            {
                int pendingTime = 0; // the delay is 1 second (1000 ms)
                SplashScreenManager.ShowForm(null, typeof(WaitForm1), true, true, true, pendingTime);

                _detailedTotalProfitModels = null;
                _detailedTotalProfitModels =
                    (List<DetailedProfitReportModel>)ReportsDataAccess.DetailedProfitReport(dateFrom,
                        dateTo, customerId, userId, salesId, departmentId, pendingFullPaid);


                InitSummaryModel initSummaryModels = new InitSummaryModel();
                InitSummaryModel initSummaryDueModels = new InitSummaryModel();
                
                initSummaryModels = ReportsDataAccess.SummarySalesCommissions(dateFrom, dateTo, salesId, 2, 0);
                initSummaryDueModels = ReportsDataAccess.SummarySalesCommissions(dateFrom, dateTo, salesId, 1, 0);

                var previewForm = new DocumentViewerForm();
                var report = new AccDetailedProfitReport();
                report.DataSource = _detailedTotalProfitModels;

                //rgReportVisibilityOptions
                report.Parameters["pDetailedReport"].Value = detailedReport;

                report.Parameters["pVersionNo"].Value = "- " + strOutputType;
                report.Parameters["pTotalCommissions"].Value = initSummaryModels.Value;
                report.Parameters["pTotalDueCommissions"].Value = initSummaryDueModels.Value;


                previewForm.Viewer.DocumentSource = report;

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

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}