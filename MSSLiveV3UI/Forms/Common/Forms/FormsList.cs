using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Common.Companies;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Companies;
using MISLiveMed.Models.Models.Common.Forms;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.Common.Forms
{
	public partial class FormsList : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "FormsList";
		private int _formId;
		private bool _resetMenu;

		private IList<FormModel> _forms = new List<FormModel>();
		private FormModel _formModel = new FormModel();
		private IList<CompanyModel> _companies = new List<CompanyModel>();
		private IList<BranchModel> _branches = new List<BranchModel>();

		private readonly CompanyRepository _companyRepository = new CompanyRepository();
		private readonly BranchRepository _branchRepository = new BranchRepository();

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
		private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
		private readonly FormRepository _formRepository = new FormRepository();

		//Init permissionvariables
		private bool _canAdd;
		private bool _canEdit;
		private bool _canDelete;
		private bool _canPrint;
		private bool _isAdmin;
		private bool _isProtected;

		#region Implementation of IFormWithRibbon

		public RibbonControl MainRibbon => rcFormsList;
		public RibbonPage DefaultPage => rpFormsList;

		#endregion
		
		public FormsList()
		{
			InitializeComponent();

			try
			{
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

				_forms = _formRepository.SelectForms();
				_companies = _companyRepository.SelectCompanies();
				_branches = _branchRepository.SelectBranches();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsForms.DataSource = _forms;

			gcForms.DataSource = null;
			gcForms.DataSource = _companies;

			repCompanies.DataSource = null;
			repCompanies.DataSource = _companies;

			repBranches.DataSource = null;
			repBranches.DataSource = _branches;
		}

		private void ApplyDefaults()
		{
			LayoutsStyle.LoadLayoutGrid(gvForms, CurrentUser.UserName);
		}

		private void ApplyPermissions()
		{
			if (_userPermission == null) return;
			if (_userPermission.Count <= 0) return;

			var canAdd = _userPermission.SingleOrDefault(x => x.ControlName == "CanAdd")?.Value;
			if (canAdd != null) _canAdd = (bool)canAdd;

			var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
			if (canEdit != null) _canEdit = (bool)canEdit;

			var canDelete = _userPermission.SingleOrDefault(x => x.ControlName == "CanDelete")?.Value;
			if (canDelete != null) _canDelete = (bool)canDelete;

			var canPrint = _userPermission.SingleOrDefault(x => x.ControlName == "CanPrint")?.Value;
			if (canPrint != null) _canPrint = (bool)canPrint;

			var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
			if (isAdmin != null) _isAdmin = (bool)isAdmin;

			btnNew.Enabled = _isAdmin || _canAdd;
			btnEdit.Enabled = _isAdmin || _canEdit;
			btnPrint.Enabled = _isAdmin || _canPrint;
			btnDelete.Enabled = _isAdmin || _canDelete;
		}

		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			FormEdit frm = new FormEdit(new FormModel());
			frm.SendUpdatedForm += RcvUpdatedForm;
			frm.ShowDialog();
		}

		private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!_forms.Any()) return;

			int currentRowId = (int)gvForms.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_formModel = _forms.SingleOrDefault(x => x.Id == currentRowId);
			if (_formModel == null) return;

			var frm = new FormEdit(_formModel);
			frm.SendUpdatedForm += RcvUpdatedForm;
			frm.ShowDialog();
		}

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{
			InitializeBindings();
			WireUpBindings();
			ApplyDefaults();
			ApplyPermissions();
		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcForms.ShowRibbonPrintPreview();
		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!CanDelete()) return;

			try
			{
				int.TryParse(gvForms.GetFocusedRowCellValue("Id").ToString(), out int id);
				string name = gvForms.GetFocusedRowCellValue("Name").ToString();

				if (id > 0)
				{
					if (XtraMessageBox.Show($"Are you sure you want to delete Record: `{name}`?",
							"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
							MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						_formModel = gvForms.GetFocusedRow() as FormModel;
						if (_formModel == null)
						{
							return;
						}
						_formModel.Deleted = true;

						//delete the record
						_formRepository.DeleteForm(_formModel.Id);
						RcvUpdatedForm(_formModel, EventArgs.Empty);
					}
				}

			}
			catch (Exception exception)
			{
				switch (exception.Message)
				{
					case "-2146233088":
						XtraMessageBox.Show("This record is linked to one or more transactions, delete all links first.",
							"Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						break;

					default:
						XtraMessageBox.Show(exception.Message,
							"Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						break;
				}
			}
		}

		private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			Close();
		}

		#endregion

		private void RcvUpdatedForm(object sender, EventArgs e)
		{
			if (sender == null) return;
			_formModel = sender as FormModel;

			if (_formModel.LastModifiedDate == null || _formModel.Deleted)
			{
				InitializeBindings();
				WireUpBindings();
			}
			else
			{
				gvForms.UpdateCurrentRow();
			}
		}
		private void gcForms_DoubleClick(object sender, EventArgs e)
		{
			if (!_isAdmin && !_canEdit) return;

			if (!_forms.Any()) return;

			int currentRowId = (int)gvForms.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_formModel = _forms.SingleOrDefault(x => x.Id == currentRowId);
			if (_formModel == null) return;

			var frm = new FormEdit(_formModel);
			frm.SendUpdatedForm += RcvUpdatedForm;
			frm.ShowDialog();
		}

		private void gvForms_RowCellStyle(object sender, RowCellStyleEventArgs e)
		{
			GridView view = sender as GridView;
			if (e.RowHandle >= 0)
			{
				bool isActive = (bool)view.GetRowCellValue(e.RowHandle, "Active");
				bool isDefault = (bool)view.GetRowCellValue(e.RowHandle, "IsDefault");
				if (isDefault)
				{
					e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
				}
				if (!isActive)
				{
					e.Appearance.ForeColor = Color.Gray;
					e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Italic);
				}
			}
		}

		private bool CanDelete()
		{
			FormModel dataBoundItem = gvForms.GetFocusedRow() as FormModel;

			if (gvForms == null || gvForms.SelectedRowsCount == 0) return false;
			if (gvForms.SelectedRowsCount > 1)
			{
				XtraMessageBox.Show("Only one record can be selected at a time, please try again",
					"Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (dataBoundItem != null && dataBoundItem.IsDefault)
			{
				XtraMessageBox.Show("Cannot delete system record!",
					"Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}
	}
}