using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.CRM.Customers
{
    public partial class CustomerQuickAddForm : XtraForm
	{
		private const string _formName = "CustomerQuickAdd";
		private int _formId;
		private DataEntityState _objState = DataEntityState.Unchanged;

		private CustomerModel _customerModel = new CustomerModel();
		private IList<UserModel> _sales = new List<UserModel>();

		private readonly UserRepository _userRepository = new UserRepository();
		private readonly CustomerRepository _customerRepository = new CustomerRepository();

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
		private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
		private readonly FormRepository _formRepository = new FormRepository();
		private readonly LogInfoRepository _logInfoRepository = new LogInfoRepository();

		//init permission variables
		private bool _canEdit;
		private bool _isAdmin;
		private bool _isProtected;

		public EventHandler SendUpdatedCustomer;

		public CustomerQuickAddForm()
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

				_sales = _userRepository.SelectUsersAsSales(_isProtected);
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
		}
        private void ApplyDefaults()
        {

        }
        private void ApplyPermissions()
        {
	        if (_userPermission == null) return;
	        if (_userPermission.Count <= 0) return;

	        var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
	        if (canEdit != null) _canEdit = (bool)canEdit;

	        var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
	        if (isAdmin != null) _isAdmin = (bool)isAdmin;

	        txtCustomerName.ReadOnly = !_isAdmin || !_canEdit;
	        cboSales.ReadOnly = !_isAdmin || !_canEdit;

	        btnSave.Enabled = _isAdmin || _canEdit;
		}

		private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                _customerModel.CustomerName = txtCustomerName.Text;
                if(cboSales.EditValue !=null) _customerModel.SalesId = (int)cboSales.EditValue;

                var newCustomerId = _customerRepository.AddNewCustomer(_customerModel);
                txtCustomerId.Text = newCustomerId.ToString();

                SendUpdatedCustomer(_customerModel, EventArgs.Empty);
                Close();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "User save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            var validateReturnValue = true;
            var messageNumber = 0;
            var validateMessage = new StringBuilder();

            if (txtCustomerName.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Customer cannot be empty.");
                validateReturnValue = false;
                txtCustomerName.Focus();
            }

            if (cboSales.Text == "")
            {
	            messageNumber += 1;
	            validateMessage.Append("\n- Sales cannot be empty.");
	            validateReturnValue = false;
	            cboSales.Focus();
            }

			if (!validateReturnValue)
            {
                validateMessage.Insert(0, "The following need your attention:");
                if (messageNumber > 1) validateMessage.Replace("following", "followings");
                XtraMessageBox.Show(validateMessage + " \nPlease try again.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return validateReturnValue;
        }


        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

    }
}