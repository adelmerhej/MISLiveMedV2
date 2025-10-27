using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Containers;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Containers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.Common.Containers
{
    public partial class ContainerTypeForm : XtraForm
    {
	    private const string _formName = "ContainerType";
	    private int _formId;

	    private DataEntityState _objState = DataEntityState.Unchanged;

	    private ContainerTypeModel _containerType = new ContainerTypeModel();
	    private IList<MainContainerTypeModel> _mainContainersType = new List<MainContainerTypeModel>();

	    private readonly ContainerTypeRepository _containerTypeRepository = new ContainerTypeRepository();
	    private readonly MainContainerTypeRepository _mainContainerTypeRepository = new MainContainerTypeRepository();

	    /// <summary>
	    /// User Permission Role
	    /// </summary>
	    private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
	    private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
	    private readonly FormRepository _formRepository = new FormRepository();
	    private readonly LogInfoRepository _logInfoRepository = new LogInfoRepository();

	    private bool _canEdit;
	    private bool _isAdmin;
	    private bool _isProtected;

		public EventHandler SendUpdatedContainerType;

        public ContainerTypeForm(ContainerTypeModel model)
        {
	        InitializeComponent();

	        try
	        {
		        _containerType = model;

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

				_mainContainersType = _mainContainerTypeRepository.SelectMainContainersType();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }

        private void WireUpBindings()
        {
	        bsContainerType.DataSource = _containerType;
			cboMainType.Properties.DataSource = _mainContainersType;
		}

        private void ApplyPermissions()
        {
	        if (_userPermission == null) return;
	        if (_userPermission.Count <= 0) return;

	        var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
	        if (canEdit != null) _canEdit = (bool)canEdit;

	        var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
	        if (isAdmin != null) _isAdmin = (bool)isAdmin;

			txtDescription.ReadOnly = !_isAdmin || !_canEdit;
	        cboMainType.ReadOnly = !_isAdmin || !_canEdit;
	        txtNotes.ReadOnly = !_isAdmin || !_canEdit;

	        chkActive.Enabled = _isAdmin || _canEdit;
	        btnSave.Enabled = _isAdmin || _canEdit;
		}

        private void ApplyDefaults()
        {
	        //txtName.Focus();
        }

		#region Buttons Event

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateForm()) return;

			SaveContainerType();
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion


		private bool ValidateForm()
        {
            var validateReturnValue = true;
            var messageNumber = 0;
            var validateMessage = new StringBuilder();
            if (txtDescription.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Container Description cannot be empty.");
                validateReturnValue = false;
                txtDescription.Focus();
            }

            if (cboMainType.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Main Container cannot be empty.");
                validateReturnValue = false;
                cboMainType.Focus();
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

        private bool SaveContainerType()
        {
            try
            {
                _containerType.Description = txtDescription.Text;
                _containerType.ContainerTypeId = (int)cboMainType.EditValue;
                _containerType.Notes = txtNotes.Text;

                if (_containerType.Id == 0)
                {
	                _logInfoRepository.CreateLogInfo(_containerType);
                     txtId.Text = _containerTypeRepository.AddNewContainerType(_containerType).ToString();
                }
                else
                {
	                _logInfoRepository.UpdateLogInfo(_containerType);
	                _containerTypeRepository.UpdateContainerType(_containerType);
                }

                SendUpdatedContainerType(_containerType, EventArgs.Empty);

                _objState = DataEntityState.Unchanged;
	            Close();
			}
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "User save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

		private void ContainerTypeForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				e.Cancel = true;
			}
		}
	}
}