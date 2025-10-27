using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Departments;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.Common.Departments
{
	public partial class DepartmentEditForm : XtraForm
	{
		private const string _formName = "DepartmentEdit";
		private int _formId;

		private DataEntityState _objState = DataEntityState.Unchanged;
		private DepartmentModel _department = new DepartmentModel();
		private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();

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

		public EventHandler SendUpdatedDepartment;

		public DepartmentEditForm(DepartmentModel department)
		{
			InitializeComponent();

			try
			{
				_department = department;

				InitializeBindings();
				WireUpBindings();
				ApplyDefaults();
				ApplyPermissions();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, "Error in loading...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			bsDepartments.DataSource = _department;
		}

		private void ApplyPermissions()
		{
			if (_userPermission == null) return;
			if (_userPermission.Count <= 0) return;

			var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
			if (canEdit != null) _canEdit = (bool)canEdit;

			var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
			if (isAdmin != null) _isAdmin = (bool)isAdmin;

			txtCode.ReadOnly = !_canEdit && !_isAdmin;
			txtName.ReadOnly = !_isAdmin && !_canEdit;
			txtPrefix.ReadOnly = !_isAdmin && !_canEdit;
			txtStartingNo.ReadOnly = !_isAdmin && !_canEdit;
			txtNotes.ReadOnly = !_isAdmin && !_canEdit;

			chkActive.Enabled = _isAdmin || _canEdit;
			chkInJobActive.Enabled = _isAdmin || _canEdit;
			btnSave.Enabled = _isAdmin || _canEdit;
		}

		private void ApplyDefaults()
		{

		}

		#region Buttons Event

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateForm()) return;

			try
			{
				BindingContext[bsDepartments].EndCurrentEdit();

				if (_department.Id == 0)
				{
					var newDepartmentResult = _departmentRepository.AddNewDepartment(_department);
					txtId.Text = newDepartmentResult.ToString();
				}
				else
				{
					_departmentRepository.UpdateDepartment(_department);
				}

				SendUpdatedDepartment(_department, EventArgs.Empty);
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

		private bool ValidateForm()
		{
			var validateReturnValue = true;
			var messageNumber = 0;
			var validateMessage = new StringBuilder();

			if (txtName.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Department Name cannot be empty.");
				validateReturnValue = false;
				txtName.Focus();
			}

			if (txtCode.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Short Code cannot be empty.");
				validateReturnValue = false;
				txtCode.Focus();
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

	}
}