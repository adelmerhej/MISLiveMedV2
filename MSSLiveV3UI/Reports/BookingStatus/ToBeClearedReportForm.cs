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
using MISLiveMed.Reports.BookingStatus.Clearance;

namespace MISLiveMed.UI.Reports.BookingStatus
{
    public partial class ToBeClearedReportForm : XtraForm
    {
	    private const string _formName = "ToBeClearedReport";
	    private int _formId;

	    private IList<DataReportModel> _dataReportModels = new List<DataReportModel>();
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

		private DateTime _currentDateTime;

        public ToBeClearedReportForm()
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
	        cboUsers.Properties.DataSource = _users;
	        cboCustomers.Properties.DataSource = _customers;
	        cboSales.Properties.DataSource = _sales;
        }
        private void ApplyDefaults()
		{
			dtDateFrom.EditValue = DateTime.Parse("01/01/2024");
			dtDateTo.EditValue = DateTime.Now;

			btnPrint.Focus();
	        layoutControlGroup4.Visibility = _isAdmin ? LayoutVisibility.Always : LayoutVisibility.Never;
	        lblOrderFilter.Visibility = _isAdmin ? LayoutVisibility.Always : LayoutVisibility.Never;
	        if (_userPermission != null) chkShowProfit.Checked = _isAdmin;

			rgOrderByFilter.SelectedIndex = 0;
			rgSortingByFilter.SelectedIndex = 0;
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
			lblOrderFilter.Visibility = _isAdmin || _canAccessProfit ? LayoutVisibility.Always : LayoutVisibility.Never;
			chkShowProfit.Checked = _isAdmin || _canAccessProfit;
		}

		#region MenuButtons

		private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
			try
			{
				var dateFrom = dtDateFrom.EditValue;
				var dateTo = dtDateTo.EditValue;
				int customerId = 0;
				int userId = 0;
				int salesId = 0;

				if (cboCustomers.EditValue != null) customerId = (int)cboCustomers.EditValue;
				if (cboUsers.EditValue != null) userId = (int)cboUsers.EditValue;
				if (cboSales.EditValue != null) salesId = (int)cboSales.EditValue;

				string orderBy = (string)rgOrderByFilter.EditValue;
				string sortingBy = (string)rgSortingByFilter.EditValue;

				_dataReportModels =
					(List<DataReportModel>)ReportsDataAccess.GetToBeClearedReportList((DateTime?)dateFrom,
						(DateTime?)dateTo, customerId, userId, salesId, orderBy, sortingBy);

				var previewForm = new DocumentViewerForm();
				var report = new TobeClearedReport();
				report.DataSource = _dataReportModels;

				report.Parameters["pSalesName"].Value = cboSales.EditValue != null ? cboSales.Text : "";
				report.Parameters["isAdmin"].Value = _isAdmin && chkShowProfit.Checked;
				report.Parameters["pDateFrom"].Value = dateFrom;
				report.Parameters["pDateTo"].Value = dateTo;

				previewForm.Viewer.DocumentSource = report;

				previewForm.ShowDialog();
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message, "Report Data Error!", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}


        #endregion


    }
}