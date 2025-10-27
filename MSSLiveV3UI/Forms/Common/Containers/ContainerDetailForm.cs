using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Containers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.Common.Containers
{
    public partial class ContainerDetailForm : XtraForm
    {
	    private const string _formName = "ContainerDetail";
	    private int _formId;

	    private DataEntityState _objState = DataEntityState.Unchanged;

	    private ContainerTypeModel _containerTypeModel = new ContainerTypeModel();

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

		public ContainerDetailForm(ContainerTypeModel model)
	    {
		    InitializeComponent();

		    try
		    {
			    _containerTypeModel = model;

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
		    //bsBranch.DataSource = _branchModel;

		    //cboMasterContainer.Properties.DataSource = null;
		    //cboMasterContainer.Properties.DataSource = _companies;
		    //cboMasterContainer.EditValue = _branchModel.CompanyId;
	    }

	    private void ApplyDefaults()
	    {
		    cboMasterContainer.Focus();
	    }

	    private void ApplyPermissions()
	    {
		    if (_userPermission == null) return;
		    if (_userPermission.Count <= 0) return;

		    var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
		    if (canEdit != null) _canEdit = (bool)canEdit;

		    var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
		    if (isAdmin != null) _isAdmin = (bool)isAdmin;

			cboMasterContainer.ReadOnly = !_isAdmin || !_canEdit;
		    txtCntrPrefix.ReadOnly = !_isAdmin || !_canEdit;
		    txtCntrNumber.ReadOnly = !_isAdmin || !_canEdit;
		    txtSealNumber.ReadOnly = !_isAdmin || !_canEdit;
		    cboCntrTeuList.ReadOnly = !_isAdmin || !_canEdit;
		    cboCntrTypeList.ReadOnly = !_isAdmin || !_canEdit;
		    cboCntrTareList.ReadOnly = !_isAdmin || !_canEdit;
		    txtCntrTareValue.ReadOnly = !_isAdmin || !_canEdit;

		    chkActive.Enabled = _isAdmin || _canEdit;
		    btnSave.Enabled = _isAdmin || _canEdit;
	    }


		#region Buttons event

		private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion


    }
}