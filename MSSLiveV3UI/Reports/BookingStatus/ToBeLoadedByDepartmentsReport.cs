using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.Reports;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Reports;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.BookingStatus;

namespace MISLiveMed.UI.Reports.BookingStatus
{
    public partial class ToBeLoadedByDepartmentsReport : XtraForm
	{
		private const string _formName = "ToBeLoadedByDepartmentsReport";
		private int _formId;

		private IList<DataReportModel> _dataReportModels = new List<DataReportModel>();
        private IList<UserModel> _users = new List<UserModel>();
        private IList<CustomerModel> _customers = new List<CustomerModel>();
        private IList<UserModel> _sales = new List<UserModel>();
        private IList<AgentModel> _agents = new List<AgentModel>();
        private readonly AgentRepository _agentRepository = new AgentRepository();

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

		private readonly int _departmentId;
        private readonly StringBuilder _sb = new StringBuilder();

        public ToBeLoadedByDepartmentsReport(int departmentId, string departmentName)
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
				_agents = _agentRepository.SelectAgents();
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

            cboAgents.Properties.DataSource = null;
            cboAgents.Properties.DataSource = _agents;
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
	        rgShipmentTypeOptions.SelectedIndex = 0;
	        rgShipmentStatusOptions.SelectedIndex = 0;
	        rgCriticalOptionsLevel.SelectedIndex = 0;
	        rgProfitSorting.SelectedIndex = 0;
        }

        #region Overrides of XtraForm

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        #endregion

        private void ToBeLoadedByDepartmentsReport_Load(object sender, EventArgs e)
        {
            LoadDefaults();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int critical = 0;
            int veryCritical = 0;
            int extremelyCritical = 0;
            string criticalStatus = "";

            var shipmentStatusOptions = rgShipmentStatusOptions.SelectedIndex;
            var shipmentTypeOptions = rgShipmentTypeOptions.SelectedIndex;
            var varProfitOrder = rgProfitSorting.SelectedIndex;

            string varVesselStatus = String.Empty;
            string varShipmentStatus = String.Empty;

            switch (shipmentTypeOptions)
            {
                case 0:
                    varShipmentStatus = "ALL";
                    break;
                case 1:
                    varShipmentStatus = "IMPORT";
                    break;
                case 2:
                    varShipmentStatus = "CROSS";
                    break;
            }

            switch (shipmentStatusOptions)
            {
                case 0:
                    varVesselStatus = "NOT RELEASED";
                    break;
                case 1:
                    varVesselStatus = "RELEASED";

                    break;
                case 2:
                    varVesselStatus = "NOT RELEASED";
                    break;
            }
            varShipmentStatus = "(" + varShipmentStatus + " " + varVesselStatus + ")";

            switch (rgCriticalOptionsLevel.SelectedIndex)
            {
                case 0:
                    critical = 0;
                    veryCritical = 0;
                    extremelyCritical = 0;
                    criticalStatus = "";
                    break;

                case 1:
                    critical = 1;
                    criticalStatus = "Critical";
                    break;

                case 2:
                    veryCritical = 1;
                    criticalStatus = "Very Critical";
                    break;

                case 3:
                    extremelyCritical = 1;
                    criticalStatus = "Extremely Critical";
                    break;

            }

            int userId = 0;
            int memberId = 0;
            int salesId = 0;
            int allInOrder = 0;

            if (cboUsers.EditValue != null)
            {
                int.TryParse(cboUsers.EditValue.ToString(), out userId);
            }

            if (cboCustomers.EditValue != null)
            {
                int.TryParse(cboCustomers.EditValue.ToString(), out memberId);
            }

            if (cboSales.EditValue != null)
            {
                int.TryParse(cboSales.EditValue.ToString(), out salesId);
            }

            if (chkAllInOrder.Checked)
            {
                allInOrder = 1;
            }

            if (chkMissing.Checked)
            {
                allInOrder = 2;
            }
            if ((chkMissing.Checked && chkAllInOrder.Checked) || (!chkMissing.Checked && !chkAllInOrder.Checked))
            {
                allInOrder = 0;
            }

            try
            {
                _dataReportModels = (List<DataReportModel>)ReportsDataAccess.GetToBeLoadedReport(-3, userId, shipmentTypeOptions, 
                    shipmentStatusOptions, memberId, salesId, allInOrder, 
            critical, veryCritical, extremelyCritical, _departmentId, 2);



                var previewForm = new DocumentViewerForm();
                var report = new ToBeLoadedReport();

                if (_userPermission != null && varProfitOrder == 0 && _isAdmin)
                {
                    report.DataSource = _dataReportModels.OrderByDescending(x => x.TotalProfit);

                }
                else
                {
                    report.DataSource = _dataReportModels;

                }

                //Add parameters
                report.Parameters["pShipmentStatus"].Value = varShipmentStatus;
                report.Parameters["pDepartment"].Value = _departmentId;
                report.Parameters["pSalesName"].Value = cboSales.EditValue != null ? cboSales.Text : "";
                report.Parameters["pCritical"].Value = IsCritical();
                report.Parameters["varCritical"].Value = criticalStatus;
                report.Parameters["isAdmin"].Value = _isAdmin && chkShowProfit.Checked;
                report.Parameters["showSeaFreight"].Value = chkShowSeaFreight.Checked;

                previewForm.Viewer.DocumentSource = report;

                previewForm.ShowDialog();
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

        private void LoadDefaults()
        {
	        btnPrint.Focus();
	        lciChkShowProfit.Visibility = _isAdmin ? LayoutVisibility.Always : LayoutVisibility.Never;
	        lblProfitSorting.Visibility = _isAdmin ? LayoutVisibility.Always : LayoutVisibility.Never;

	        chkShowProfit.Visible = _isAdmin;
	        chkShowProfit.Checked = _isAdmin;
	        chkShowSeaFreight.Checked = _isAdmin;
		}

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}