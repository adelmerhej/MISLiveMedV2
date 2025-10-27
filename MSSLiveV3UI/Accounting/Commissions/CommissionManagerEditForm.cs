using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Accounting.Commissions;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.Commissions;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Accounting.Commissions
{
    public partial class CommissionManagerEditForm : XtraForm
	{
		private const string _formName = "CommissionManagerEdit";
		private int _formId;

		private DataEntityState _objState = DataEntityState.Unchanged;

		private CommissionManagerModel _commissionModel = new CommissionManagerModel();
        private IList<CommissionManagerModel> _commissions = new List<CommissionManagerModel>();
        private IList<UserModel> _users = new List<UserModel>();

        private readonly CommissionManagerRepository _commissionManagerRepository = new CommissionManagerRepository();
        private readonly UserRepository _userRepository = new UserRepository();

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

		public EventHandler SendUpdatedCommissionManager;

        public CommissionManagerEditForm(CommissionManagerModel model)
        {
            InitializeComponent();
            
            try
            {
				_commissionModel = model;

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
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {
            bsCommissionManager.DataSource = _commissionModel;

            cboSales.Properties.DataSource = null;
            cboSales.Properties.DataSource = _users;
            if (_commissionModel != null) cboSales.EditValue = _commissionModel.SalesId;
        }

        private void ApplyPermissions()
        {
	        if (_userPermission == null) return;
	        if (_userPermission.Count <= 0) return;

	        var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
	        if (canEdit != null) _canEdit = (bool)canEdit;

	        var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
	        if (isAdmin != null) _isAdmin = (bool)isAdmin;

			cboSales.ReadOnly = !_isAdmin || !_canEdit;
	        dtStartDate.ReadOnly = !_isAdmin || !_canEdit;
	        dtEndDate.ReadOnly = !_isAdmin || !_canEdit;
	        txtSalesProfitShare.ReadOnly = !_isAdmin || !_canEdit;
	        txtOfficeFees.ReadOnly = !_isAdmin || !_canEdit;
	        txtRecurringSalesProfitShare.ReadOnly = !_isAdmin || !_canEdit;
	        txtTransferFees.ReadOnly = !_isAdmin || !_canEdit;
	        txtFixCommission.ReadOnly = !_isAdmin || !_canEdit;
	        txtNotes.ReadOnly = !_isAdmin || !_canEdit;

	        chkActive.Enabled = _isAdmin || _canEdit;
	        chkIsSales.Enabled = _isAdmin || _canEdit;
	        btnSave.Enabled = _isAdmin || _canEdit;
		}

        private void ApplyDefaults()
        {

        }

        #region Buttons Event

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            try
            {
                BindingContext[bsCommissionManager].EndCurrentEdit();

                if (cboSales.EditValue != null) _commissionModel.SalesId = (int)cboSales.EditValue;

                if (_commissionModel.Id == 0)
                {
	                _logInfoRepository.CreateLogInfo(_commissionModel);
                    var newAirportId = _commissionManagerRepository.AddNewCommissionManager(_commissionModel);
                    txtId.Text = newAirportId.ToString();
                }
                else
                {
	                _logInfoRepository.UpdateLogInfo(_commissionModel);
                    _commissionManagerRepository.UpdateCommissionManager(_commissionModel);
                }

                SendUpdatedCommissionManager(_commissionModel, EventArgs.Empty);

                _objState = DataEntityState.Unchanged;
                Close();
			}
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "User save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private bool ValidateData()
        {
            var validateReturnValue = true;
            var messageNumber = 0;
            var validateMessage = new StringBuilder();

            if (cboSales.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Sales Name cannot be empty.");
                validateReturnValue = false;
                cboSales.Focus();
            }

            if (dtStartDate.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Start Date cannot be empty.");
                validateReturnValue = false;
                dtStartDate.Focus();
            }

            if (dtEndDate.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- End Date cannot be empty.");
                validateReturnValue = false;
                dtEndDate.Focus();
            }

            if (txtSalesProfitShare.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Sales commission cannot be empty.");
                validateReturnValue = false;
                txtSalesProfitShare.Focus();
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

		private void CommissionManagerEditForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				e.Cancel = true;
			}
		}
	}
}