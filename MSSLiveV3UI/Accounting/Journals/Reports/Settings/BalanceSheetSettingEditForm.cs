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

namespace MISLiveMed.UI.Accounting.Journals.Reports.Settings
{
	public partial class BalanceSheetSettingEditForm: XtraForm
	{
		private const string _formName = "BalanceSheetSettingEdit";
		private int _formId;
		private DataEntityState _objState = DataEntityState.Unchanged;

		private BalanceSheetSettingModel _balanceSheetSettingModel = new BalanceSheetSettingModel();
		private IList<BalanceHeaderModel> _balanceHeaders = new List<BalanceHeaderModel>();

		private readonly BalanceSheetSettingRepository _balanceSheetSettingsRepository =
			new BalanceSheetSettingRepository();

		private readonly BalanceHeaderRepository _balanceHeaderRepository = new BalanceHeaderRepository();

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

		public EventHandler SendUpdatedAccountBalanceSetting;

		public BalanceSheetSettingEditForm(BalanceSheetSettingModel model)
		{
            InitializeComponent();

            try
            {
	            _balanceSheetSettingModel = model;

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

		private void AccountBalanceSettingEditForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				if (XtraMessageBox.Show("There is unsaved data, are you sure you want to close and discard changes?",
					    "Unsaved data", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
					    MessageBoxDefaultButton.Button2) == DialogResult.No)
					e.Cancel = true;
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

				_balanceHeaders = _balanceHeaderRepository.SelectBalanceHeaders();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsBalanceSheetSettings.DataSource = _balanceSheetSettingModel;
			cboBalanceHeaders.Properties.DataSource = _balanceHeaders;
			
			if (_balanceSheetSettingModel != null)
			{
				cboBalanceHeaders.EditValue = _balanceSheetSettingModel.BalanceHeaderId;
				rgpAccountOutput.SelectedIndex = GetDbCrIndex();
			}
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

			cboBalanceHeaders.ReadOnly = !_isAdmin || !_canEdit;
			txtParentId.ReadOnly = !_isAdmin || !_canEdit;
			txtAccountNumbers.ReadOnly = !_isAdmin || !_canEdit;
			txtDescription.ReadOnly = !_isAdmin || !_canEdit;
			orderInListValue.ReadOnly = !_isAdmin || !_canEdit;
			rgpAccountOutput.ReadOnly = !_isAdmin || !_canEdit;
			txtNotes.ReadOnly = !_isAdmin || !_canEdit;

			chkShowInFirstColumn.Enabled = _isAdmin || _canEdit;
			chkShowInSecondColumn.Enabled = _isAdmin || _canEdit;
			chkIsTotal.Enabled = _isAdmin || _canEdit;
			chkActive.Enabled = _isAdmin || _canEdit;
			chkIsGrandTotal.Enabled = _isAdmin || _canEdit;
			btnSave.Enabled = _isAdmin || _canEdit;

		}

		#region Buttons Event

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateData()) return;

			try
			{
				//BindingContext[bsBalanceSheetSetting].EndCurrentEdit();
				//_accountBalanceModel = bsBalanceSheetSetting.Current as BalanceSheetSettingModel;

				if (_balanceSheetSettingModel == null) return;

				if(cboBalanceHeaders != null) _balanceSheetSettingModel.BalanceHeaderId = (int)cboBalanceHeaders.EditValue;
				_balanceSheetSettingModel.DbCr = rgpAccountOutput.EditValue.ToString();

				if (_balanceSheetSettingModel.Id == 0)
				{
					_logInfoRepository.CreateLogInfo(_balanceSheetSettingModel);
					txtId.Text = _balanceSheetSettingsRepository.AddNewBalanceSheetSetting(_balanceSheetSettingModel).ToString();
				}
				else
				{
					_logInfoRepository.UpdateLogInfo(_balanceSheetSettingModel);
					_balanceSheetSettingsRepository.UpdateBalanceSheetSetting(_balanceSheetSettingModel);
				}

				SendUpdatedAccountBalanceSetting(_balanceSheetSettingModel, EventArgs.Empty);

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
			var messageNumber = 0;
			var validateMessage = new StringBuilder();

			if (txtDescription.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Description cannot be empty.");
				validateReturnValue = false;
				txtDescription.Focus();
			}

			
			if (cboBalanceHeaders.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Balance Header cannot be empty.");
				validateReturnValue = false;
				cboBalanceHeaders.Focus();
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

		private int GetDbCrIndex()
		{
			int returnIndex = 0;

			switch (_balanceSheetSettingModel.DbCr)
			{
				case "A":
					returnIndex = 0;
					break;

				case "D":
					returnIndex = 1;
					break;

				case "C":
					returnIndex = 2;
					break;
			}

			return returnIndex;
		}
	}
}