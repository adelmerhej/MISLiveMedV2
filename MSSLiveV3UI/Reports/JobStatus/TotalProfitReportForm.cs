using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UI.CrossTab;
using DevExpress.XtraSplashScreen;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.Reports;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Reports.Profit;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.BookingStatus;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Properties;

namespace MISLiveMed.UI.Reports.JobStatus
{
    public partial class TotalProfitReportForm : XtraForm
	{
		private const string _formName = "TotalProfitReport";
		private int _formId;

		private IList<TotalProfitReportModel> _dataReportModels = new List<TotalProfitReportModel>();
		private IList<OptimizedTotalProfitReportModel> _AlldataReportModels = new List<OptimizedTotalProfitReportModel>();
        private IList<UserModel> _users = new List<UserModel>();
        private IList<CustomerModel> _customers = new List<CustomerModel>();
        private IList<UserModel> _sales = new List<UserModel>();
        private IList<CountryModel> _countries = new List<CountryModel>();

        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly UserRepository _userRepository = new UserRepository();
        private readonly CountryRepository _countryRepository = new CountryRepository();

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
        private bool _isNegative;
        private float _defaultZoomValue = 1;
        
        public TotalProfitReportForm(bool isNegative = false)
        {
            InitializeComponent();

            try
            {
	            _isNegative = isNegative;

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
                _countries = _countryRepository.SelectCountries();
			}
            catch (Exception e)
            {
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }
        private void WireUpBindings()
        {
            cboUsers.Properties.DataSource = null;
            cboUsers.Properties.DataSource = _users;

            cboCustomers.Properties.DataSource = null;
            cboCustomers.Properties.DataSource = _customers;

            cboSales.Properties.DataSource = null;
            cboSales.Properties.DataSource = _sales;

            cboCountries.Properties.DataSource = null;
            cboCountries.Properties.DataSource = _countries;
        }
        private void ApplyPermissions()
        {
            //DateTime currentDate = DateTime.Now;
            //dtEtaFrom.EditValue = currentDate.AddDays(-1);
            //dtEtaTo.EditValue = currentDate;

			if (_userPermission == null) return;
            if (_userPermission.Count <= 0) return;

            var canAccessProfit = _userPermission.SingleOrDefault(x => x.ControlName == "CanAccessProfit")?.Value;
            if (canAccessProfit != null) _canAccessProfit = (bool)canAccessProfit;

            var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
            if (isAdmin != null) _isAdmin = (bool)isAdmin;

			if (_isAdmin)
            {
                lciChkShowProfit.Visibility = _isAdmin ? LayoutVisibility.Always : LayoutVisibility.Never;
                chkShowUsersReport.Visible = true;
                chkShowUsersReport.Visible = true;
            }

            if (!_canAccessProfit)
            {
                rgOrderByFilter.Properties.Items.Remove(rgOrderByFilter.Properties.Items.GetItemByValue("ByProfit"));
            }

            chkOnlyNegative.Checked = _isNegative;
        }
        private void ApplyDefaults()
		{
			dtDateFrom.EditValue = null;
			dtDateTo.EditValue = null;
			dtDateFrom.Enabled = false;
			dtDateTo.Enabled = false;

			_currentDateTime = DateTime.UtcNow;

            rgShipmentTypeOptions.EditValue = 0;
            rgPendingPaidJobs.EditValue = 0;

            rgAdvancedFilter.SelectedIndex = 0;
            rgOrderByFilter.SelectedIndex = 0;

            rgSortingByFilter.SelectedIndex = 0;

            chkPrintDetailed.Checked = true;
            chkOnlyNegative.Checked = false;

            _defaultZoomValue = 100;
            zoomValue.EditValue = _defaultZoomValue;

            btnPrint.Focus();

            zoomValue.EditValue = Settings.Default.ZoomValue;
        }


        #region MenuButtons

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
			if (_canAccessProfit == false || chkShowUsersReport.Checked)
	        {
		        PrintJobsByDepartmentReport();
		        return;
	        }

			try
            {
                int pendingTime = 0; // the delay is 1 second (1000 ms)
                SplashScreenManager.ShowForm(null, typeof(WaitForm1), true, true, true, pendingTime);

				var previewForm = new DocumentViewerForm();

                int pending = (int)rgPendingPaidJobs.EditValue;
                bool detailedJobs = chkPrintDetailed.Checked;
                int userId = 0;
                int customerId = 0;
                int salesId = 0;

                if (cboUsers.EditValue != null) userId = (int)cboUsers.EditValue;
                if (cboCustomers.EditValue != null) customerId = (int)cboCustomers.EditValue;
                if (cboSales.EditValue != null) salesId = (int)cboSales.EditValue;

                DateTime? dateEtaFrom = (DateTime?)dtEtaFrom.EditValue;
                DateTime? dateEtaTo = (DateTime?)dtEtaTo.EditValue;

				var report = new TotalProfitByDepartmentsReport();
                if (chkIncludeClosedJobs.Checked)
                {
	                AllDataReportTotalProfitList(pending, detailedJobs);
                    return;
                }
				_dataReportModels = TotalProfitListReport(pending, detailedJobs);

                report.DataSource = _dataReportModels;

                report.Parameters["DateFrom"].Value = dateEtaFrom;
                report.Parameters["DateTo"].Value = dateEtaTo;
				report.Parameters["isAdmin"].Value = _isAdmin;
                report.Parameters["showNegative"].Value = chkOnlyNegative.Checked;
                report.Parameters["detailedJobs"].Value = detailedJobs;

                previewForm.Viewer.DocumentSource = report;

                previewForm.Viewer.AutoZoom = true;
                previewForm.Viewer.Zoom = (float)zoomValue.Value / 100;

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

        private void PrintJobsByDepartmentReport()
        {
            try
            {
                int pendingTime = 0; // the delay is 1 second (1000 ms)
                SplashScreenManager.ShowForm(null, typeof(WaitForm1), true, true, true, pendingTime);

                var previewForm = new DocumentViewerForm();

                int pending = (int)rgPendingPaidJobs.EditValue;
                bool detailedJobs = chkPrintDetailed.Checked;
                if (dtDateFrom.EditValue != null)
                {
	                DateTime? dateFrom = (DateTime)dtDateFrom.EditValue;
                }

                if (dtDateTo.EditValue != null)
                {
	                DateTime? dateTo = (DateTime)dtDateTo.EditValue;
                }

                var report = new JobListByDepartmentReport();
                _dataReportModels = TotalProfitListReport(pending, detailedJobs);
                report.DataSource = _dataReportModels;

                //report.Parameters["DateFrom"].Value = dateFrom;
                //report.Parameters["DateTo"].Value = dateTo;
				report.Parameters["isAdmin"].Value = _isAdmin && !chkOnlyNegative.Checked;
                report.Parameters["detailedJobs"].Value = detailedJobs;

                previewForm.Viewer.DocumentSource = report;

                previewForm.Viewer.AutoZoom = true;
                previewForm.Viewer.Zoom = (float)zoomValue.Value / 100;

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


        #region Reports Output
        //
        private IList<TotalProfitReportModel> TotalProfitListReport(int pending, bool detailedJobs)
        {
            DateTime? dateEtaFrom = (DateTime?)dtEtaFrom.EditValue;
            DateTime? dateEtaTo = (DateTime?)dtEtaTo.EditValue;

            int userId = 0;
            int customerId = 0;
            int salesId = 0;
            bool printDifferenceOnly = chkPrintDifferenceOnly.Checked;

			if (cboUsers.EditValue != null) userId = (int)cboUsers.EditValue;
            if (cboCustomers.EditValue != null) customerId = (int)cboCustomers.EditValue;
            if (cboSales.EditValue != null) salesId = (int)cboSales.EditValue;

            int departmentId = (int)rgShipmentTypeOptions.EditValue;
            string filterBy = (string)rgAdvancedFilter.EditValue;
            string orderBy = (string)rgOrderByFilter.EditValue;
            string sortingBy = (string)rgSortingByFilter.EditValue;

            if (chkOnlyNegative.Checked)
            {
                _dataReportModels =
                    ReportsDataAccess.GetTotalNegativeReportList(dateEtaFrom,
                        dateEtaTo, 0, 0, departmentId);
            }
            else
            {

                _dataReportModels =
                    ReportsDataAccess.GetTotalProfitReportList(dateEtaFrom,
                        dateEtaTo, customerId, userId, salesId, departmentId,
                        (int)rgPendingPaidJobs.EditValue, detailedJobs, filterBy, orderBy, sortingBy, printDifferenceOnly);
            }

            return _dataReportModels;
        }

        private void AllDataReportTotalProfitList(int pending, bool detailedJobs)
        {
	        DateTime? dateEtaFrom = (DateTime?)dtEtaFrom.EditValue;
	        DateTime? dateEtaTo = (DateTime?)dtEtaTo.EditValue;
	        DateTime? dateJobFrom = (DateTime?)dtDateFrom.EditValue;
	        DateTime? dateJobTo = (DateTime?)dtDateTo.EditValue;
	        bool printDifferenceOnly = chkPrintDifferenceOnly.Checked;

			int userId = 0;
	        int customerId = 0;
	        int salesId = 0;

	        if (cboUsers.EditValue != null) userId = (int)cboUsers.EditValue;
	        if (cboCustomers.EditValue != null) customerId = (int)cboCustomers.EditValue;
	        if (cboSales.EditValue != null) salesId = (int)cboSales.EditValue;

	        int departmentId = (int)rgShipmentTypeOptions.EditValue;
	        string filterBy = (string)rgAdvancedFilter.EditValue;
	        string orderBy = (string)rgOrderByFilter.EditValue;
	        string sortingBy = (string)rgSortingByFilter.EditValue;

	        _AlldataReportModels =
		        ReportsDataAccess.AllTotalProfitReportList(dateEtaFrom, dateEtaTo, dateJobFrom, dateJobTo,
					customerId, userId, salesId, departmentId,
			        (int)rgPendingPaidJobs.EditValue, detailedJobs, filterBy, orderBy, sortingBy, printDifferenceOnly);

	        var previewForm = new DocumentViewerForm();
			var report = new TotalProfitByDepartmentsReport();
			report.DataSource = _AlldataReportModels;

            report.Parameters["DateFrom"].Value = dateJobFrom;
            report.Parameters["DateTo"].Value = dateJobTo;
            report.Parameters["isAdmin"].Value = _isAdmin;
	        report.Parameters["showNegative"].Value = chkOnlyNegative.Checked;
	        report.Parameters["detailedJobs"].Value = detailedJobs;

	        previewForm.Viewer.DocumentSource = report;

	        previewForm.Viewer.AutoZoom = true;
	        previewForm.Viewer.Zoom = (float)zoomValue.Value / 100;

	        previewForm.ShowDialog();
		}
		#endregion


		#region #Report Generation Code

		private XtraReport CreateReport()
        {
            // Create a blank report.
            XtraReport crossTabReport = new XtraReport()
            {
                VerticalContentSplitting = VerticalContentSplitting.Smart,
                HorizontalContentSplitting = HorizontalContentSplitting.Smart
            };

            // Create a detail band and add it to the report.
            DetailBand detail = new DetailBand();
            crossTabReport.Bands.Add(detail);

            // Create a cross tab and add it to the Detail band.
            XRCrossTab crossTab = new XRCrossTab();
            detail.Controls.Add(crossTab);
            crossTab.PrintOptions.RepeatColumnHeaders = true;
            crossTab.PrintOptions.RepeatRowHeaders = true;

            // Create a data source
            //Access97ConnectionParameters connectionParameters = new Access97ConnectionParameters(@"|DataDirectory|\nwind.mdb", "", "");
            //SqlDataSource ds = new SqlDataSource(connectionParameters);

            //// Create an SQL query to access the SalesPerson view.
            //SelectQuery query = SelectQueryFluentBuilder.AddTable("SalesPerson")
            //            .SelectColumn("CategoryName")
            //            .SelectColumn("ProductName")
            //            .SelectColumn("Country")
            //            .SelectColumn("Sales Person")
            //            .SelectColumn("Quantity")
            //            .SelectColumn("Extended Price").Build("SalesPerson");
            //ds.Queries.Add(query);

            // Bind the cross tab to data.
            crossTab.DataSource = _dataReportModels;
            crossTab.DataMember = "DepartmentName";

            // Generate cross tab's fields.
            crossTab.RowFields.Add(new CrossTabRowField() { FieldName = "JobNo" });
            crossTab.RowFields.Add(new CrossTabRowField() { FieldName = "DepartmentName" });
            crossTab.ColumnFields.Add(new CrossTabColumnField() { FieldName = "StatusType" });
            crossTab.ColumnFields.Add(new CrossTabColumnField() { FieldName = "DepartmentName" });
            crossTab.DataFields.Add(new CrossTabDataField() { FieldName = "TotalProfit" });
            crossTab.DataFields.Add(new CrossTabDataField() { FieldName = "TotalProfit" });
            crossTab.GenerateLayout();
            /*
            +----------------+---------------+-------------------------------+---------------------------+---------------------------+
            | Category Name  | Product Name  | [Country]                     | Total [Country]           | Grand total               |
            |                |               +-------------------------------+                           |                           |
            |                |               | [Sales Person]                |                           |                           |
            |                |               +------------+------------------+----------+----------------+----------+----------------+
            |                |               | Quantity   | Extended Price   | Quantity | Extended Price | Quantity | Extended Price |
            +----------------+---------------+------------+------------------+----------+----------------+----------+----------------+
            | [CategoryName] | [ProductName] | [Quantity] | [Extended Price] |          |                |          |                |
            +----------------+---------------+------------+------------------+----------+----------------+----------+----------------+
            | Total [CategoryName]           |            |                  |          |                |          |                |
            +--------------------------------+------------+------------------+----------+----------------+----------+----------------+
            | Grand Total                    |            |                  |          |                |          |                |
            +--------------------------------+------------+------------------+----------+----------------+----------+----------------+
            */

            //Adjust generated cells
            foreach (var c in crossTab.ColumnDefinitions)
            {
                //Enable auto-width for all columns
                c.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.GrowOnly;
            }

            foreach (XRCrossTabCell c in crossTab.Cells)
            {
                if (c.DataLevel == 1 && c.RowIndex != 2)
                {
                    //Adjust format string for the "Extended Price" cells
                    c.TextFormatString = "{0:c}";
                }
            }


            // Assign styles to cross tab
            crossTab.CrossTabStyles.GeneralStyle = new XRControlStyle()
            {
                Name = "Default",
                Borders = BorderSide.All,
                Padding = new PaddingInfo() { All = 2 }
            };
            crossTab.CrossTabStyles.DataAreaStyle = crossTab.CrossTabStyles.TotalAreaStyle = new XRControlStyle()
            {
                Name = "Data",
                TextAlignment = TextAlignment.TopRight
            };
            crossTab.CrossTabStyles.HeaderAreaStyle = new XRControlStyle()
            {
                Name = "HeaderAndTotals",
                BackColor = Color.WhiteSmoke
            };
            return crossTabReport;
        }
        #endregion #Code

        private void rgOrderByFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderBy = (string)rgOrderByFilter.EditValue;
            string sortingBy = (string)rgSortingByFilter.EditValue;

            switch (orderBy)
            {
                case "ByProfit":
                    rgSortingByFilter.SelectedIndex = 1;
                    break;

                default:
                    rgSortingByFilter.SelectedIndex = 0;
                    break;
            }
        }

        private void TotalProfitReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CheckAndSaveSettings();
        }

        private void CheckAndSaveSettings()
        {
            if (zoomValue.EditValue != null) Settings.Default.ZoomValue = (float)zoomValue.Value;
            Settings.Default.Save();
        }

		private void chkIncludeClosedJobs_CheckedChanged(object sender, EventArgs e)
		{

			if (chkIncludeClosedJobs.Checked)
			{
				dtEtaFrom.EditValue = null;
				dtEtaTo.EditValue = null;
				dtEtaFrom.Enabled = false;
				dtEtaTo.Enabled = false;

				dtDateFrom.Enabled = true;
				dtDateTo.Enabled = true;
				dtDateFrom.EditValue = DateTime.Parse("01/01/" + (DateTime.Today.Year - 1));
				dtDateTo.EditValue = DateTime.Now;
			}
			else
			{
				dtDateFrom.EditValue = null;
				dtDateTo.EditValue = null;
				dtDateFrom.Enabled = false;
				dtDateTo.Enabled = false;

				dtEtaFrom.Enabled = true;
				dtEtaTo.Enabled = true;
				dtEtaFrom.EditValue = null;
				dtEtaTo.EditValue = null;
			}
		}
		
	}
}