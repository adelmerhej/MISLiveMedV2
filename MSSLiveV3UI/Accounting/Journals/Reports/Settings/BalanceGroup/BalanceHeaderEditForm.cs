using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Accounting.Reports.Settings;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.Reports.Settings;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Accounting.Journals.Reports.Settings.BalanceGroup
{
	public partial class BalanceHeaderEditForm : XtraForm
	{
		private const string _formName = "BalanceHeaderEdit";
		private int _formId;

		private DataEntityState _objState = DataEntityState.Unchanged;

		private BalanceHeaderModel _balanceHeaderModel;
		private IList<BalanceGroupModel> _balanceGroups = new List<BalanceGroupModel>();

		private readonly BalanceHeaderRepository _balanceHeaderRepository = new BalanceHeaderRepository();
		private readonly BalanceGroupRepository _balanceGroupRepository = new BalanceGroupRepository();

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

		public EventHandler SendUpdatedBalanceHeader;

		public BalanceHeaderEditForm(BalanceHeaderModel model)
		{
			InitializeComponent();
			
			try
			{
				_balanceHeaderModel = model;

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

				_balanceGroups = _balanceGroupRepository.SelectBalanceGroup();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsBalanceHeader.DataSource = _balanceHeaderModel;

			cboBalanceGroups.Properties.DataSource = null;
			cboBalanceGroups.Properties.DataSource = _balanceGroups;
			if (_balanceHeaderModel != null) cboBalanceGroups.EditValue = _balanceHeaderModel.BalanceGroupId;
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
			cboBalanceGroups.ReadOnly = !_isAdmin || !_canEdit;
			txtNotes.ReadOnly = !_isAdmin || !_canEdit;

			chkActive.Enabled = _isAdmin || _canEdit;
			btnSave.Enabled = _isAdmin || _canEdit;
		}

		private void ApplyDefaults()
		{
			txtName.Focus();
		}

		#region Buttons Event

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateData()) return;

			try
			{
				BindingContext[bsBalanceHeader].EndCurrentEdit();
				_balanceHeaderModel = bsBalanceHeader.Current as BalanceHeaderModel;

				if (_balanceHeaderModel == null) return;

				if (_balanceHeaderModel.Id == 0)
				{
					_logInfoRepository.CreateLogInfo(_balanceHeaderModel);
					var newCityId = _balanceHeaderRepository.AddNewBalanceHeader(_balanceHeaderModel);
					txtId.Text = newCityId.ToString();
				}
				else
				{
					_logInfoRepository.UpdateLogInfo(_balanceHeaderModel);
					_balanceHeaderRepository.UpdateBalanceHeader(_balanceHeaderModel);
				}

				SendUpdatedBalanceHeader(_balanceHeaderModel, EventArgs.Empty);

				_objState = DataEntityState.Unchanged;
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
			//var messageNumber = 0;
			var validateMessage = new StringBuilder();

			if (txtName.Text == "")
			{
				//messageNumber += 1;
				validateMessage.Append("\n- Name cannot be empty.");
				validateReturnValue = false;
				txtName.Focus();
			}

			if (!validateReturnValue)
			{
				validateMessage.Insert(0, "The following need your attention:");
				//if (messageNumber > 1) validateMessage.Replace("following", "followings");
				XtraMessageBox.Show(validateMessage + " \nPlease try again.",
					"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			return validateReturnValue;
		}

		private void ContinentEditForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				e.Cancel = true;
			}
		}
	}
}