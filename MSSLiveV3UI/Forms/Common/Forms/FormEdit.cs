using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Companies;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Companies;
using MISLiveMed.Models.Models.Common.Forms;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.Common.Forms
{
	public partial class FormEdit : XtraForm
	{
		private const string _formName = "FormEdit";
		private int _formId;

		private DataEntityState _objState = DataEntityState.Unchanged;

		private FormModel _formModel = new FormModel();
		private IList<BranchModel> _branches = new List<BranchModel>();
		private IList<CompanyModel> _companies = new List<CompanyModel>();

		private readonly BranchRepository _branchRepository = new BranchRepository();
		private readonly CompanyRepository _companyRepository = new CompanyRepository();

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

		public EventHandler SendUpdatedForm;

		public FormEdit(FormModel model)
		{
			InitializeComponent();

			try
			{
				_formModel = model;

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

				_companies = _companyRepository.SelectCompanies();
				_branches = _branchRepository.SelectBranches();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsForm.DataSource = _formModel;

			cboCompanies.Properties.DataSource = null;
			cboCompanies.Properties.DataSource = _companies;
			cboCompanies.EditValue = _formModel.CompanyId;

			cboBranches.Properties.DataSource = null;
			cboBranches.Properties.DataSource = _branches;
			cboBranches.EditValue = _formModel.BranchId;
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
			cboCompanies.ReadOnly = !_isAdmin && !_canEdit;
			cboBranches.ReadOnly = !_isAdmin && !_canEdit;
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
				BindingContext[bsForm].EndCurrentEdit();
				_formModel = bsForm.Current as FormModel;
				if (_formModel == null) return;

				if (cboCompanies.EditValue != null) _formModel.CompanyId = (int)cboCompanies.EditValue;

				if (_formModel.Id == 0)
				{
					_logInfoRepository.CreateLogInfo(_formModel);
					var newId = _formRepository.AddNewForm(_formModel);
					txtId.Text = newId.ToString();
				}
				else
				{
					_logInfoRepository.UpdateLogInfo(_formModel);
					_formRepository.UpdateForm(_formModel);
				}

				SendUpdatedForm(_formModel, EventArgs.Empty);
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
			Close();
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
				validateMessage.Append("\n- Name cannot be empty.");
				validateReturnValue = false;
				txtName.Focus();
			}

			if (cboCompanies.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Company cannot be empty.");
				validateReturnValue = false;
				cboCompanies.Focus();
			}

			if (cboBranches.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Branch cannot be empty.");
				validateReturnValue = false;
				cboBranches.Focus();
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

		private void FormEdit_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				e.Cancel = true;
			}
		}
	}
}