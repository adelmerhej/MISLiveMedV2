using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.Reports;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Reports;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.BookingStatus;

namespace MISLiveMed.UI.Reports.BookingStatus
{
    public partial class OnWaterByDepartmentsReportForm : XtraForm
	{
		private const string _formName = "OnWaterByDepartmentsReport";
		private int _formId;

		private IList<DataReportModel> _dataReportModels = new List<DataReportModel>();
		private IList<UserModel> _users = new List<UserModel>();
		private IList<CustomerModel> _customers = new List<CustomerModel>();
		private IList<UserModel> _sales = new List<UserModel>();

		private readonly CustomerRepository _customerRepository = new CustomerRepository();
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

		private int _departmentId;
		private StringBuilder _sb = new StringBuilder();

		public OnWaterByDepartmentsReportForm(int departmentId, string departmentName)
        {
            InitializeComponent();

            try
            {
	            InitializeBindings();
	            WireUpBindings();
	            ApplyDefaults();
	            ApplyPermissions();

				_departmentId = departmentId;
	            _sb.Clear();
	            _sb.Append(Text);
	            Text = _sb.Replace("Departments", departmentName).ToString();

	            dataLayoutControl4.Enabled = _departmentId == 16;
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
				_sales = _userRepository.SelectUsersAsSales();
				_customers = _customerRepository.SelectCustomers();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void WireUpBindings()
		{
			cboUsers.Properties.DataSource = _users;
			cboCustomers.Properties.DataSource = _customers;
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

			layoutControlGroup4.Visibility = _isAdmin || _canAccessProfit ? LayoutVisibility.Always : LayoutVisibility.Never;
			lciChkShowProfit.Visibility = _isAdmin || _canAccessProfit ? LayoutVisibility.Always : LayoutVisibility.Never;
			lblProfitSorting.Visibility = _isAdmin || _canAccessProfit ? LayoutVisibility.Always : LayoutVisibility.Never;
			chkShowProfit.Checked = _isAdmin || _canAccessProfit;
		}

		private void ApplyDefaults()
		{
			rgShipmentStatusFilter.SelectedIndex = 0;
		}

		private void btnPrint_Click(object sender, EventArgs e)
        {
            int critical = rgCriticalOptionsLevel.SelectedIndex;

            string varShipmentType = GetShipmentTypeFilter();
            int varShipmentStatus = rgShipmentTypeFilter.SelectedIndex;
            int varProfitOrder = rgProfitSorting.SelectedIndex;

            try
            {
                var previewForm = new DocumentViewerForm();
                int userId = GetUserId();

                int memberId = 0;
                int salesId = 0;

                if (cboCustomers.EditValue != null)
                {
                    int.TryParse(cboCustomers.EditValue.ToString(), out memberId);
                }

                if (cboSales.EditValue != null)
                {
                    int.TryParse(cboSales.EditValue.ToString(), out salesId);
                }

                switch (rgShipmentStatusFilter.EditValue)
                {
                    case 0:
                        _dataReportModels =
                            (List<DataReportModel>)ReportsDataAccess.GetOnWaterReport(-3,
                                userId, varShipmentStatus, memberId, salesId, 0, critical, 
                                2, _departmentId, 0);

                        var reportOnWater = new OnWaterReport();
                        if (_userPermission != null && varProfitOrder == 0 && _isAdmin)
                        {
                            reportOnWater.DataSource = _dataReportModels.OrderByDescending(x => x.TotalProfit);
                        }
                        else
                        {
                            reportOnWater.DataSource = _dataReportModels;
                        }
                        

                        //Add parameters

                        //report.Parameters["pDateFrom"].Value = JobDateFrom;
                        //report.Parameters["pDateTo"].Value = JobDateTo;
                        reportOnWater.Parameters["ShipmentStatus"].Value = varShipmentType;
                        reportOnWater.Parameters["pDepartment"].Value = _departmentId;
                        reportOnWater.Parameters["pSalesName"].Value = (cboSales.EditValue != null) ? cboSales.Text : "";
                        reportOnWater.Parameters["pCritical"].Value = IsCritical();
                        reportOnWater.Parameters["varCritical"].Value = rgCriticalOptionsLevel.Properties.Items.GetItemByValue("Critical").ToString();
                        // Filter.Properties.Items.GetItemByValue("ByProfit")
                        reportOnWater.Parameters["isAdmin"].Value = _isAdmin && chkShowProfit.Checked;
                        reportOnWater.Parameters["ispPendingFullPaid"].Value = rgShipmentStatusFilter.SelectedIndex == 3;

                        previewForm.Viewer.DocumentSource = reportOnWater;
                        previewForm.ShowDialog();
                        break;

                    case 1:
                        _dataReportModels =
                            (List<DataReportModel>)ReportsDataAccess.GetBookingReadyForTejrimReport("XOI33961", -3,
                                userId, varShipmentStatus, memberId, salesId, 0, critical, 2);

                        var reportReadyForTejrim = new ReadyForTejrimReport();

                        if (_userPermission != null && varProfitOrder == 0 && _isAdmin)
                        {
                            reportReadyForTejrim.DataSource = _dataReportModels.OrderByDescending(x => x.TotalProfit);
                        }
                        else
                        {
                            reportReadyForTejrim.DataSource = _dataReportModels;
                        }

                        //Add parameters

                        //report.Parameters["pDateFrom"].Value = JobDateFrom;
                        //report.Parameters["pDateTo"].Value = JobDateTo;
                        reportReadyForTejrim.Parameters["ShipmentStatus"].Value = varShipmentType;
                        reportReadyForTejrim.Parameters["pDepartment"].Value = _departmentId;
                        reportReadyForTejrim.Parameters["pSalesName"].Value = (cboSales.EditValue != null) ? cboSales.Text : "";
                        reportReadyForTejrim.Parameters["pCritical"].Value = IsCritical();
                        reportReadyForTejrim.Parameters["varCritical"].Value = rgCriticalOptionsLevel.Properties.Items.GetItemByValue("Critical").ToString();
                        reportReadyForTejrim.Parameters["isAdmin"].Value = _isAdmin && chkShowProfit.Checked;
                        reportReadyForTejrim.Parameters["ispPendingFullPaid"].Value = rgShipmentStatusFilter.SelectedIndex == 3;

                        previewForm.Viewer.DocumentSource = reportReadyForTejrim;
                        previewForm.ShowDialog();
                        break;

                    case 2:
                        _dataReportModels =
                            (List<DataReportModel>)ReportsDataAccess.GetBookingNotReadyForTejrimReport("XOI33961",
                                -3,
                                userId, varShipmentStatus, memberId, salesId, 0, critical, 2);

                        var reportNotReadyForTejrim = new NOTReadyForTejrimReport();

                        if (_userPermission != null && varProfitOrder == 0 && _isAdmin)
                        {
                            reportNotReadyForTejrim.DataSource = _dataReportModels.OrderByDescending(x => x.TotalProfit);
                        }
                        else
                        {
                            reportNotReadyForTejrim.DataSource = _dataReportModels;
                        }

                        //Add parameters

                        //report.Parameters["pDateFrom"].Value = JobDateFrom;
                        //report.Parameters["pDateTo"].Value = JobDateTo;
                        reportNotReadyForTejrim.Parameters["ShipmentStatus"].Value = varShipmentType;
                        reportNotReadyForTejrim.Parameters["pDepartment"].Value = _departmentId;
                        reportNotReadyForTejrim.Parameters["pSalesName"].Value = (cboSales.EditValue != null) ? cboSales.Text : "";
                        reportNotReadyForTejrim.Parameters["pCritical"].Value = IsCritical();
                        reportNotReadyForTejrim.Parameters["varCritical"].Value = rgCriticalOptionsLevel.Properties.Items.GetItemByValue("Critical").ToString();
                        reportNotReadyForTejrim.Parameters["isAdmin"].Value = _isAdmin && chkShowProfit.Checked;
                        reportNotReadyForTejrim.Parameters["ispPendingFullPaid"].Value = rgShipmentStatusFilter.SelectedIndex == 3;

                        previewForm.Viewer.DocumentSource = reportNotReadyForTejrim;
                        previewForm.ShowDialog();
                        break;

                    case 3:
                        _dataReportModels =
                            (List<DataReportModel>)ReportsDataAccess.GetOnWaterReport(-3,
                                userId, varShipmentStatus, memberId, salesId, 0, critical, 2, _departmentId, 1);

                        var reportPendingFullPaid = new OnWaterReport();
                        if (_userPermission != null && varProfitOrder == 0 && _isAdmin)
                        {
                            reportPendingFullPaid.DataSource = _dataReportModels.OrderByDescending(x => x.TotalProfit);
                        }
                        else
                        {
                            reportPendingFullPaid.DataSource = _dataReportModels;
                        }


                        //Add parameters

                        //report.Parameters["pDateFrom"].Value = JobDateFrom;
                        //report.Parameters["pDateTo"].Value = JobDateTo;
                        reportPendingFullPaid.Parameters["ShipmentStatus"].Value = varShipmentType;
                        reportPendingFullPaid.Parameters["pDepartment"].Value = _departmentId;
                        reportPendingFullPaid.Parameters["pSalesName"].Value = (cboSales.EditValue != null) ? cboSales.Text : "";
                        reportPendingFullPaid.Parameters["pCritical"].Value = IsCritical();
                        reportPendingFullPaid.Parameters["varCritical"].Value = rgCriticalOptionsLevel.Properties.Items.GetItemByValue("Critical").ToString();
                        reportPendingFullPaid.Parameters["isAdmin"].Value = _isAdmin && chkShowProfit.Checked;
                        reportPendingFullPaid.Parameters["ispPendingFullPaid"].Value = rgShipmentStatusFilter.SelectedIndex == 3;

                        previewForm.Viewer.DocumentSource = reportPendingFullPaid;
                        previewForm.ShowDialog();
                        break;

                    case 4:
                        _dataReportModels =
                            (List<DataReportModel>)ReportsDataAccess.GetOnWaterReport(-3,
                                userId, varShipmentStatus, memberId, salesId, 0, critical, 2, _departmentId, 2);
                                
                        var reportAllPendingFullPaid = new OnWaterReport();
                        if (_userPermission != null && varProfitOrder == 0 && _isAdmin)
                        {
                            reportAllPendingFullPaid.DataSource = _dataReportModels.OrderByDescending(x => x.TotalProfit);
                        }
                        else
                        {
                            reportAllPendingFullPaid.DataSource = _dataReportModels;
                        }


                        //Add parameters

                        //report.Parameters["pDateFrom"].Value = JobDateFrom;
                        //report.Parameters["pDateTo"].Value = JobDateTo;
                        reportAllPendingFullPaid.Parameters["ShipmentStatus"].Value = varShipmentType;
                        reportAllPendingFullPaid.Parameters["pDepartment"].Value = _departmentId;
                        reportAllPendingFullPaid.Parameters["pSalesName"].Value = (cboSales.EditValue != null) ? cboSales.Text : "";
                        reportAllPendingFullPaid.Parameters["pCritical"].Value = IsCritical();
                        reportAllPendingFullPaid.Parameters["varCritical"].Value = rgCriticalOptionsLevel.Properties.Items.GetItemByValue("Critical").ToString();
                        reportAllPendingFullPaid.Parameters["isAdmin"].Value = _isAdmin && chkShowProfit.Checked;
                        reportAllPendingFullPaid.Parameters["ispPendingFullPaid"].Value = rgShipmentStatusFilter.SelectedIndex == 3;

                        previewForm.Viewer.DocumentSource = reportAllPendingFullPaid;
                        previewForm.ShowDialog();
                        break;
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Report Data Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool IsCritical()
        {
            return rgCriticalOptionsLevel.SelectedIndex > 0;
        }

        private int GetUserId()
        {
            int userId = 0;
            if (cboUsers.EditValue != null)
            {
                int.TryParse(cboUsers.EditValue.ToString(), out userId);
            }
            return userId;
        }

        private string GetShipmentTypeFilter()
        {
            // Shipment Type Filter
            string returnShipmentType = string.Empty;

            switch (rgShipmentTypeFilter.SelectedIndex)
            {
                case 0:
                    returnShipmentType = "(ALL)";
                    break;
                case 1:
                    returnShipmentType = "(IMPORT)";
                    break;
                case 2:
                    returnShipmentType = "(CROSS)";
                    break;
            }

            return returnShipmentType;
        }

		private void btnClose_Click(object sender, EventArgs e)
		{
            Close();
		}
	}
}