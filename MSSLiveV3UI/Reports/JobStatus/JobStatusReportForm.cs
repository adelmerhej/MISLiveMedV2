using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using MISLiveMed.DataLayers.Common.Countries.Ports;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.Reports;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries.Ports;
using MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Reports.JobsStatus;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.Jobs.JobsStatus;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Utilities;

namespace MISLiveMed.UI.Reports.JobStatus
{
    public partial class JobStatusReportForm : XtraForm
	{
		private const string _formName = "JobStatusReport";
		private int _formId;

		private IList<JobSeaImportModel> _seaImportList = new List<JobSeaImportModel>();
        private IList<JobStatusReportModel> _dataReportModels = new List<JobStatusReportModel>();
        private IList<UserModel> _users = new List<UserModel>();
        private IList<CustomerModel> _customers = new List<CustomerModel>();
        private IList<UserModel> _sales = new List<UserModel>();
        private IList<PortModel> _ports = new List<PortModel>();

        private readonly UserRepository _userRepository = new UserRepository();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly PortRepository _portRepository = new PortRepository();

        /// <summary>
        /// User Permission Role
        /// </summary>
        private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
        private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
        private readonly FormRepository _formRepository = new FormRepository();

        private bool _isAdmin;
        private bool _canAccessProfit;
        private bool _isProtected;

		private DateTime _currentDateTime;
        private StringBuilder _sb = new StringBuilder();
        
        public JobStatusReportForm()
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
		        _customers = _customerRepository.SelectCustomers();
		        _sales = _userRepository.SelectUsersAsSales();
		        _ports = _portRepository.SelectPorts(HelperApplication.SelectPortType(16));
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }
		private void ApplyPermissions()
		{
			if (_userPermission == null) return;
			if (_userPermission.Count <= 0) return;

			var canAccessProfit = _userPermission.SingleOrDefault(x => x.ControlName == "CanAccessProfit")?.Value;
			if (canAccessProfit != null) _canAccessProfit = (bool)canAccessProfit;

			var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
			if (isAdmin != null) _isAdmin = (bool)isAdmin;

			if (_isAdmin)
	        {
		        dtDateFrom.EditValue = _currentDateTime;
		        dtDateTo.EditValue = DateTime.Now;
		        chkDetailed.CheckState = CheckState.Checked;
	        }
	        else
	        {
		        dtDateFrom.EditValue = DateTime.Now;
		        dtDateTo.EditValue = DateTime.Now;
	        }
		}
        private void WireUpBindings()
        {
            cboUsers.Properties.DataSource = null;
            cboUsers.Properties.DataSource = _users;

            cboCustomers.Properties.DataSource = null;
            cboCustomers.Properties.DataSource = _customers;

            cboMemberOf.Properties.DataSource = null;
            cboMemberOf.Properties.DataSource = _customers;
            

            cboSales.Properties.DataSource = null;
            cboSales.Properties.DataSource = _sales;

            cboDeparture.Properties.DataSource = null;
            cboDeparture.Properties.DataSource = _ports;

            cboDestination.Properties.DataSource = null;
            cboDestination.Properties.DataSource = _ports;
        }

        private void ApplyDefaults()
        {
            rgShipmentTypeOptions.SelectedIndex = 0;
            rgOperationsType.SelectedIndex = 0;
            rgReportTypeOptions.SelectedIndex = 0;
            rgJobClosedStatus.SelectedIndex = 0;
            chkDetailed.Checked = true;

            rgOrderByFilter.SelectedIndex = 0;
            rgSortingByFilter.SelectedIndex = 1;

            _currentDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

            //chkSaveFilter.Checked = Settings.Default.SaveFilter;
            //if (Settings.Default.SaveFilter)
            //{
            //    dtDateFrom.EditValue = Settings.Default.JStatusDateFrom;
            //    dtDateTo.EditValue = Settings.Default.JStatusDateTo;
            //    chkSaveFilter.Checked = true;
            //}

            if (CurrentUser.UserId == 1)
            {
                //chkShowReal.Visible = true;
            }

            txtJobNo.Focus();
        }

        #region Buttons Events
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int pendingTime = 0; // the delay is 1 second (1000 ms)
                SplashScreenManager.ShowForm(null, typeof(WaitForm1), true, true, true, pendingTime);

                DateTime? dateFrom = (DateTime?)dtDateFrom.EditValue;
                DateTime? dateTo = (DateTime?)dtDateTo.EditValue;

                DateTime? dateEtdFrom = (DateTime?)dtEtaFrom.EditValue;
                DateTime? dateEtdTo = (DateTime?)dtEtaTo.EditValue;

                int userId = 0;
                int customerId = 0;
                int salesId = 0;
                _ = int.TryParse(txtJobNo.Text, out int jobNo);

                int departmentId = (int)rgShipmentTypeOptions.EditValue;
                int operationsType = (int)rgOperationsType.EditValue;
                bool detailedJobs = chkDetailed.Checked;
                int fullPaid = (int)rgReportTypeOptions.EditValue;
                int jobClosedStatus = (int)rgJobClosedStatus.EditValue;

                string memberOf = cboMemberOf.Text;
                string orderBy = (string)rgOrderByFilter.EditValue;
                string sortingBy = (string)rgSortingByFilter.EditValue;

                bool includeMembers = chkIncludeMembes.CheckState == CheckState.Checked;

                if (cboUsers.EditValue != null)
                {
                    userId = (int)cboUsers.EditValue;
                }

                if (cboCustomers.EditValue != null)
                {
                    customerId = (int)cboCustomers.EditValue;
                }

                if (cboSales.EditValue != null)
                {
                    salesId = (int)cboSales.EditValue;
                }
				
                _dataReportModels =
                    (List<JobStatusReportModel>)ReportsDataAccess.GetJobsReportStatus(dateFrom, dateTo, dateEtdFrom,
                        dateEtdTo, jobNo, customerId, userId, salesId, departmentId, detailedJobs, 
                        fullPaid, jobClosedStatus, includeMembers, memberOf, orderBy, sortingBy);

                var previewForm = new DocumentViewerForm();
                var report = new JobStatusReport();
                IList<JobStatusReportModel> newJobStatusRecords = new List<JobStatusReportModel>();

                switch (departmentId)
                {
                    case 0:
                        newJobStatusRecords = _dataReportModels;
                        break;

                    case 1:
                        newJobStatusRecords = _dataReportModels.Where(x => x.DepartmentId == 5 || x.DepartmentId == 16).ToList();
                        break;
                    case 2:
                        newJobStatusRecords = _dataReportModels.Where(x => x.DepartmentId == 2 || x.DepartmentId == 18).ToList();
                        break;
                    case 3:
                        newJobStatusRecords = _dataReportModels.Where(x => x.DepartmentId == 8 || x.DepartmentId == 17).ToList();
                        break;
                    case 4:
                        newJobStatusRecords = _dataReportModels.Where(x => x.DepartmentId == 6).ToList();
                        break;
                    case 5:
                        newJobStatusRecords = _dataReportModels.Where(x => x.DepartmentId == 16 && x.JobType == 3).ToList();
                        break;

                }

                switch (operationsType)
                {
                    case 0:
                        break;

                    case 1:
                        newJobStatusRecords = newJobStatusRecords.Where(x =>
                            x.StatusType == "SI New" || x.StatusType == "SE New" || 
                            x.StatusType == "AC New" || x.StatusType == "SC New" ||
                            x.StatusType == "AE New" || x.StatusType == "AI New" || x.StatusType == "LF New").ToList();
                        break;

                    case 2:
                        newJobStatusRecords = newJobStatusRecords.Where(x =>
                            x.StatusType == "SI Delivered" || x.StatusType == "SE Delivered" ||
                            x.StatusType == "AC Delivered" || x.StatusType == "SC Delivered" ||
                            x.StatusType == "AE Delivered" || x.StatusType == "AI Delivered" || x.StatusType == "LF Delivered").ToList();
                        break;

                    case 3:
                        newJobStatusRecords = newJobStatusRecords.Where(x =>
                            x.StatusType == "SI Cancelled" || x.StatusType == "SE Cancelled" ||
                            x.StatusType == "AC Cancelled" || x.StatusType == "SC Cancelled" ||
                            x.StatusType == "AE Cancelled" || x.StatusType == "AI Cancelled" || x.StatusType == "LF Cancelled").ToList();
                        break;
     
                }

                report.DataSource = newJobStatusRecords;

                //Add parameters
                report.Parameters["DateFrom"].Value = dtEtaTo.EditValue;
                report.Parameters["DateTo"].Value = dtEtaFrom.EditValue;
                report.Parameters["pDetailed"].Value = detailedJobs;
                report.Parameters["pIncludeAllMembers"].Value = chkIncludeMembes.Checked;
                report.Parameters["pFullPaid"].Value = fullPaid;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        #endregion

        private void SaveFilterSettings()
        {
            //if (chkSaveFilter.CheckState == CheckState.Checked)
            //{
            //    chkSaveFilter.Checked = true;
            //    Settings.Default.JStatusDateFrom = (DateTime)dtDateFrom.EditValue;
            //    Settings.Default.JStatusDateTo = (DateTime)dtDateTo.EditValue;
            //}

            //Settings.Default.SaveFilter = chkSaveFilter.Checked;
            //Settings.Default.Save();
        }

        private void JobStatusReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFilterSettings();
        }
    }
}