using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Currencies;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Accounting.Currencies
{
    public partial class CurrencyEditForm : XtraForm
    {
	    private const string _formName = "CurrencyEdit";
	    private int _formId = 0;

	    private DataEntityState _objState = DataEntityState.Unchanged;

		private CurrencyModel _currencyModel;
        private CurrencyRepository _currencyRepository = new CurrencyRepository();
        private UserRepository _userRepository = new UserRepository();

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

		public EventHandler SendUpdatedCurrency;

        public CurrencyEditForm(CurrencyModel model)
        {
            InitializeComponent();

            try
            {
	            _currencyModel = model;

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

	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

        private void WireUpBindings()
        {
	        bsCurrency.DataSource = _currencyModel;
        }

        private void ApplyPermissions()
		{
			if (_userPermission == null) return;
			if (_userPermission.Count <= 0) return;

			var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
			if (canEdit != null) _canEdit = (bool)canEdit;

			var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
			if (isAdmin != null) _isAdmin = (bool)isAdmin;

			txtCode.ReadOnly = !_isAdmin || !_canEdit;
			txtCurrencySymbol.ReadOnly = !_isAdmin || !_canEdit;
			txtName.ReadOnly = !_isAdmin || !_canEdit;
			txtNotes.ReadOnly = !_isAdmin || !_canEdit;

			chkDivByRateLocal.Enabled = _isAdmin || _canEdit;
			chkDivideByRateForeign.Enabled = _isAdmin || _canEdit;
			chkActive.Enabled = _isAdmin || _canEdit;
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
                BindingContext[bsCurrency].EndCurrentEdit();
                _currencyModel = bsCurrency.Current as CurrencyModel;

                if (_currencyModel != null && _currencyModel.Id == 0)
                {
	                _logInfoRepository.CreateLogInfo(_currencyModel);
                    var newCurrencyId = _currencyRepository.AddNewCurrency(_currencyModel);
                    txtId.Text = newCurrencyId.ToString();
                }
                else
                {
	                _logInfoRepository.UpdateLogInfo(_currencyModel);
                    _currencyRepository.UpdateCurrency(_currencyModel);
                }

                SendUpdatedCurrency(_currencyModel, EventArgs.Empty);
                Close();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "On Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (txtCode.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Code cannot be empty.");
                validateReturnValue = false;
                txtCode.Focus();
            }

            if (txtName.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Name cannot be empty.");
                validateReturnValue = false;
                txtName.Focus();
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

		private void CurrencyEditForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				e.Cancel = true;
			}
		}
	}
}