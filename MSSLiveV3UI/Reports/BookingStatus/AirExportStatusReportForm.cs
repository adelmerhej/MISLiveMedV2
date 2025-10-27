using System;
using System.Collections.Generic;
using System.Linq;
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
using MISLiveMed.Reports.BookingStatus.AirFreight;

namespace MISLiveMed.UI.Reports.BookingStatus
{
    public partial class AirExportStatusReportForm : XtraForm
	{
		private const string _formName = "AirExportStatusReport";
		private int _formId;

		private List<AirDataReportModel> _dataReportModels = new List<AirDataReportModel>();

        private IList<UserModel> _users = new List<UserModel>();
        private IList<CustomerModel> _customers = new List<CustomerModel>();
        private IList<UserModel> _sales = new List<UserModel>();

        private CustomerRepository _customerRepository = new CustomerRepository();
        private UserRepository _userRepository = new UserRepository();

        /// <summary>
        /// User Permission Role
        /// </summary>
        private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
        private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
        private readonly FormRepository _formRepository = new FormRepository();

        private bool _canAccessProfit;
		private bool _isAdmin;
		private bool _isProtected;

		public AirExportStatusReportForm()
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
	        try
	        {
		        cboUsers.Properties.DataSource = _users;
		        cboCustomers.Properties.DataSource = _customers;
		        cboSales.Properties.DataSource = _sales;

				_formId = _formRepository.SelectFormByName(_formName);
				_userPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, _formId);
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

			layoutControlGroup4.Visibility = _isAdmin || _canAccessProfit ? LayoutVisibility.Always : LayoutVisibility.Never;
			lciChkShowProfit.Visibility = _isAdmin || _canAccessProfit ? LayoutVisibility.Always : LayoutVisibility.Never;
			lblProfitSorting.Visibility = _isAdmin || _canAccessProfit ? LayoutVisibility.Always : LayoutVisibility.Never;
			chkShowProfit.Checked = _isAdmin || _canAccessProfit;
		}

        private void ApplyDefaults()
        {
	        dtDateFrom.EditValue = DateTime.Parse("01/01/" + DateTime.Now.Year);
	        dtDateTo.EditValue = DateTime.Now;

	        rgShipmentTypeOptions.SelectedIndex = 0;
	        rgCriticalOptionsLevel.SelectedIndex = 0;
	        rgProfitSorting.SelectedIndex = 0;

	        btnPrint.Focus();
	        lciChkShowProfit.Visibility = _isAdmin || _canAccessProfit ? LayoutVisibility.Always : LayoutVisibility.Never;
	        lblProfitSorting.Visibility = _isAdmin || _canAccessProfit ? LayoutVisibility.Always : LayoutVisibility.Never;

	        chkShowProfit.Visible = _isAdmin || _canAccessProfit;
	        chkShowProfit.Checked = _isAdmin || _canAccessProfit;
		}
        
        #region Buttons Event

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var dateFrom = dtDateFrom.EditValue;
                var dateTo = dtDateTo.EditValue;
                int varProfitOrder = rgProfitSorting.SelectedIndex;

                int customerId = 0;
                int userId = 0;
                int salesId = 0;

                if (cboCustomers.EditValue != null) _ = int.TryParse(cboCustomers.EditValue.ToString(), out customerId);
                if (cboUsers.EditValue != null) _ = int.TryParse(cboUsers.EditValue.ToString(), out userId);
                if (cboSales.EditValue != null) _ = int.TryParse(cboSales.EditValue.ToString(), out salesId);

                _dataReportModels =
                    (List<AirDataReportModel>)ReportsDataAccess.GetAirFreightExportReportList((DateTime?)dateFrom,
                        (DateTime?)dateTo, customerId, userId, salesId);

                var previewForm = new DocumentViewerForm();
                var report = new AirExportStatusReport();

                if (varProfitOrder == 0)
                {
                    report.DataSource = _dataReportModels.OrderBy(x => x.TotalProfit);
                }
                else
                {
                    report.DataSource = _dataReportModels;
                }



                //Add parameters

                report.Parameters["pDateFrom"].Value = dateFrom;
                report.Parameters["pDateTo"].Value = dateTo;
                //report.Parameters["pShipmentStatus"].Value = varShipmentStatus;
                //report.Parameters["pSalesName"].Value = (cboSales.EditValue != null) ? cboSales.Text : "";
                //report.Parameters["pCritical"].Value = IsCritical();
                //report.Parameters["varCritical"].Value = criticalStatus;
                report.Parameters["isAdmin"].Value = _isAdmin;
                report.Parameters["ProfitVisibility"].Value = _isAdmin;

                previewForm.Viewer.DocumentSource = report;

                previewForm.ShowDialog();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Report Data Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

    }
}