using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.AspNet.Identity;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Common;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.Users
{
	public partial class ChangePasswordForm : XtraForm
	{
		private const string _formName = "ChangePasswordForm";
		private int _formId;

		private DataEntityState _objState = DataEntityState.Unchanged;

		private UserModel _userModel = new UserModel();
		private readonly UserRepository _userRepository = new UserRepository();

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

		public event EventHandler SendChangedPassword;

		public ChangePasswordForm(UserModel model)
		{
			InitializeComponent();

			try
			{
				_userModel = model;

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

		}

		private void ApplyPermissions()
		{
			if (_userPermission == null) return;
			if (_userPermission.Count <= 0) return;

			var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
			if (canEdit != null) _canEdit = (bool)canEdit;

			var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
			if (isAdmin != null) _isAdmin = (bool)isAdmin;

			btnSave.Enabled = _isAdmin || _canEdit;
		}

		private void ApplyDefaults()
		{
			txtUserName.Text = _userModel.UserName;
		}

		#region Buttons Event

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateForm()) return;

			try
			{
				SystemUtilities.PasswordHasher = new PasswordHasher();

				_userModel.PasswordHash = SystemUtilities.PasswordHasher.HashPassword(txtNewPassword.Text);

				_userModel.Password = txtConfirmPassword.Text.Trim(); // TODO: to be removed, it's just for logging purpose only
				if (!_userRepository.UpdateUser(_userModel))
				{
					throw new Exception("Error while changing password\n- Contact your system administrator.");
				}

				XtraMessageBox.Show("Password changed!",
					"Password notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

				SendChangedPassword(_userModel, EventArgs.Empty);
				Close();
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message, "Change Password",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
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

			if (txtConfirmPassword.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Confirm Password cannot be empty.");
				validateReturnValue = false;
				txtConfirmPassword.Focus();
			}

			if (txtNewPassword.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- New Password cannot be empty.");
				validateReturnValue = false;
				txtNewPassword.Focus();
			}

			if (txtOldPassword.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Old Password cannot be empty.");
				validateReturnValue = false;
				txtOldPassword.Focus();
			}

			if (txtUserName.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- User Name cannot be empty.");
				validateReturnValue = false;
				txtUserName.Focus();
			}

			if (txtNewPassword.Text == txtOldPassword.Text)
			{
				messageNumber += 1;
				validateMessage.Append("\n- New Password and old Password cannot be the same.");
				validateReturnValue = false;
				txtNewPassword.Focus();
			}

			if (txtNewPassword.Text != txtConfirmPassword.Text)
			{
				messageNumber += 1;
				validateMessage.Append("\n- New Password and Confirm Password do not match.");
				validateReturnValue = false;
				txtConfirmPassword.Focus();
			}

			if (txtNewPassword.Text != txtConfirmPassword.Text)
			{
				messageNumber += 1;
				validateMessage.Append("\n- New Password and Confirm Password do not match.");
				validateReturnValue = false;
				txtConfirmPassword.Focus();
			}

			#region Check username in database
			_userModel = _userRepository.GetUsersByName(_userModel.UserName, _isProtected);

			SystemUtilities.PasswordHasher = new PasswordHasher();
			var passwordVerificationResult =
				SystemUtilities.PasswordHasher.VerifyHashedPassword(_userModel.PasswordHash, txtOldPassword.Text);

			if (_userModel == null || _userModel.UserName != txtUserName.Text ||
			    passwordVerificationResult == PasswordVerificationResult.Failed)
			{
				messageNumber += 1;
				validateMessage.Append("\n- User Name or password are not correct.");
				validateReturnValue = false;
				txtUserName.Focus();
			}

			#endregion

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