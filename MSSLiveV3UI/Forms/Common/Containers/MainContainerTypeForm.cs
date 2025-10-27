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
	public partial class MainContainerTypeForm : XtraForm
	{
		private const string _formName = "MainContainerType";
		private int _formId;

		private DataEntityState _objState = DataEntityState.Unchanged;

		private MainContainerTypeModel _mainContainerTypeModel = new MainContainerTypeModel();

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

		public EventHandler SendUpdatedMainContainerType;

		public MainContainerTypeForm(MainContainerTypeModel model)
		{
			InitializeComponent();

			try
			{
				_mainContainerTypeModel = model;

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
			bsMainContainerType.DataSource = _mainContainerTypeModel;
		}

		private void ApplyDefaults()
		{
			txtName.Focus();
		}

		private void ApplyPermissions()
		{
			if (_userPermission == null) return;
			if (_userPermission.Count <= 0) return;

			var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
			if (canEdit != null) _canEdit = (bool)canEdit;

			var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
			if (isAdmin != null) _isAdmin = (bool)isAdmin;

			txtName.ReadOnly = !_isAdmin || !_canEdit;
			txtNotes.ReadOnly = !_isAdmin || !_canEdit;

			chkActive.Enabled = _isAdmin || _canEdit;
			btnSave.Enabled = _isAdmin || _canEdit;
		}

		#region Buttons Event

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateData()) return;

			try
			{
				BindingContext[bsMainContainerType].EndCurrentEdit();
				_mainContainerTypeModel = bsMainContainerType.Current as MainContainerTypeModel;
				if (_mainContainerTypeModel == null) return;

				if (_mainContainerTypeModel.Id == 0)
				{
					_logInfoRepository.CreateLogInfo(_mainContainerTypeModel);
					var newId = _mainContainerTypeRepository.AddNewMainContainerType(_mainContainerTypeModel);
					txtId.Text = newId.ToString();
				}
				else
				{
					_logInfoRepository.UpdateLogInfo(_mainContainerTypeModel);
					_mainContainerTypeRepository.UpdateMainContainerType(_mainContainerTypeModel);
				}

				SendUpdatedMainContainerType(_mainContainerTypeModel, EventArgs.Empty);

				_objState = DataEntityState.Unchanged;
				Close();
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message,
					$"On Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{

		}

		#endregion

		private bool ValidateData()
		{
			var validateReturnValue = true;
			var messageNumber = 0;
			var validateMessage = new StringBuilder();

			if (txtName.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Description cannot be empty.");
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

		private void MainContainerTypeForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				e.Cancel = true;
			}
		}
	}
}