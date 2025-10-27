using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.CRM.Agents.Categories
{
    public partial class AgentCategoryEditForm : XtraForm
    {
	    private const string _formName = "AgentCategoryEdit";
	    private int _formId;

	    private DataEntityState objState = DataEntityState.Unchanged;
	    private AgentCategoryModel _agentCategoryModel = new AgentCategoryModel();

	    private AgentCategoryRepository _agentCategoryRepository = new AgentCategoryRepository();

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

		public EventHandler SendUpdatedAgentCategory;

		public AgentCategoryEditForm(AgentCategoryModel agentCategory)
		{
			InitializeComponent();

			try
			{
				_agentCategoryModel = agentCategory;

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
			bsAgentsCategory.DataSource = _agentCategoryModel;
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

		private void ApplyDefaults()
		{
			txtName.Focus();
		}

		private bool ValidateData()
		{
			var validateReturnValue = true;
			var messageNumber = 0;
			var validateMessage = new StringBuilder();
			if (txtName.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Agent Group Name cannot be empty.");
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

		#region Buttons Event

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateData()) return;

			try
			{
				BindingContext[bsAgentsCategory].EndCurrentEdit();

				if (_agentCategoryModel.Id == 0)
				{
					_logInfoRepository.CreateLogInfo(_agentCategoryModel);

					int newContinent = _agentCategoryRepository.AddNewAgentCategory(_agentCategoryModel);
					if (newContinent == 0)
					{
						throw new Exception($"Error while saving : {txtName.Text}");
					}
				}
				else
				{
					_logInfoRepository.UpdateLogInfo(_agentCategoryModel);
					_agentCategoryRepository.UpdateAgentCategory(_agentCategoryModel);
				}

				SendUpdatedAgentCategory(_agentCategoryModel, EventArgs.Empty);
				objState = DataEntityState.Unchanged;

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

	}
}