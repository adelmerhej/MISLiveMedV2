using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Reports.Accounting;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.UI.Reports.DOPReports
{
    public partial class PrintSalesCommissionReportForm : XtraForm
	{
		private const string _formName = "PrintSalesCommissionReport";
		private int _formId;

		private IList<SalesCommissionReportModel> _salesCommissionReports = new List<SalesCommissionReportModel>();
        private IList<UserModel> _sales = new List<UserModel>();
        
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

		public PrintSalesCommissionReportForm()
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

				_sales = _userRepository.SelectUsersAsSales();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void WireUpBindings()
        {
            cboSales.Properties.DataSource = null;
            cboSales.Properties.DataSource = _sales;

            rgSelection.SelectedIndex = 0;
            rgSalesReportOption.SelectedIndex = 0;
            rgPaymentoption.SelectedIndex = 0;
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

        private void ApplyDefaults()
        {
            dtDateFrom.EditValue = DateTime.Now;
            dtDateTo.EditValue = DateTime.Now;
        }

        #region Buttons Event

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int salesId = 0;
                int tejrim = 0;
                int payment = 0;
                string strPayment = "";
                bool fullPaid = false;

                if (cboSales.EditValue != null)
                {
                    salesId = cboSales.Text == "" ? 0 : (int)cboSales.EditValue;
                }

                tejrim = (int)rgSalesReportOption.EditValue;
                payment = (int)rgPaymentoption.EditValue;
                strPayment = (int)rgPaymentoption.EditValue == 0 ? "" : (int)rgPaymentoption.EditValue == 1 ? "Paid" : "Pending";
                fullPaid = chkFullPaid.CheckState == CheckState.Checked ? true : false;

            }
            catch (Exception exception)
            {
	            XtraMessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


    }
}