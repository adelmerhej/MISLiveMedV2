using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MISLiveMed.DataLayers.Common.Companies;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Companies;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.Common.Companies
{
	public partial class BranchEditForm : XtraForm
	{
		private const string _formName = "BranchEdit";
		private int _formId;

		private DataEntityState _objState = DataEntityState.Unchanged;

		private BranchModel _branchModel = new BranchModel();
		private IList<BranchModel> _branches = new List<BranchModel>();
		private CompanyModel _companyModel = new CompanyModel();
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

		//init permission variables
		private bool _canEdit;
		private bool _isAdmin;
		private bool _isProtected;

		public EventHandler SendUpdatedBranch;

		public BranchEditForm(BranchModel model)
		{
			InitializeComponent();

			try
			{
				_branchModel = model;

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
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsBranch.DataSource = _branchModel;

			cboCompanies.Properties.DataSource = null;
			cboCompanies.Properties.DataSource = _companies;
			cboCompanies.EditValue = _branchModel.CompanyId;
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
			cboCompanies.ReadOnly = !_isAdmin || !_canEdit;
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
				BindingContext[bsBranch].EndCurrentEdit();
				_branchModel = bsBranch.Current as BranchModel;
				if (_branchModel == null) return;

				if (_branchModel.Id == 0)
				{
					_logInfoRepository.CreateLogInfo(_branchModel);
					if (cboCompanies.EditValue != null) _branchModel.CompanyId = (int)cboCompanies.EditValue;
					var newId = _branchRepository.AddNewBranch(_branchModel);
					txtId.Text = newId.ToString();
				}
				else
				{
					_logInfoRepository.UpdateLogInfo(_branchModel);
					if (cboCompanies.EditValue != null) _branchModel.CompanyId = (int)cboCompanies.EditValue;
					_branchModel.BranchId = _branchModel.Id;
					_branchRepository.UpdateBranch(_branchModel);
				}

				SendUpdatedBranch(_branchModel, EventArgs.Empty);
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

			if (!validateReturnValue)
			{
				validateMessage.Insert(0, "The following need your attention:");
				if (messageNumber > 1) validateMessage.Replace("following", "followings");
				XtraMessageBox.Show(validateMessage + " \nPlease try again.",
					"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			return validateReturnValue;
		}

		private void cboContinents_AddNewValue(object sender, AddNewValueEventArgs e)
		{
			CompanyEditForm frm = new CompanyEditForm(new CompanyModel());
			frm.SendUpdatedCompany += RcvUpdatedCompany;
			frm.ShowDialog();
		}

		private void RcvUpdatedCompany(object sender, EventArgs e)
		{
			if (sender == null) return;
			_companyModel = sender as CompanyModel;

			_companies.Add(_companyModel);

			cboCompanies.Properties.DataSource = null;
			cboCompanies.Properties.DataSource = _companies;
			if (_companyModel != null) cboCompanies.EditValue = _companyModel.Id;
		}
	}
}