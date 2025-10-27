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
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.Common.Companies
{
	public partial class BranchesListForm : RibbonForm
	{
		private const string _formName = "BranchesList";
		private int _formId;
		private bool _resetMenu;

		private BranchModel _branchModel = new BranchModel();
		private IList<BranchModel> _branches = new List<BranchModel>();

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

		public RibbonControl MainRibbon => rcBranchesList;
		public RibbonPage DefaultPage => rpBranchesList;


		#endregion

		public BranchesListForm()
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

				_branches = _branchRepository.SelectBranches();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsBranches.DataSource = _branches;
		}

		private void ApplyDefaults()
		{
			LayoutsStyle.LoadLayoutGrid(gvBranches, CurrentUser.UserName);
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
			BranchEditForm frm = new BranchEditForm(new BranchModel());
			frm.SendUpdatedBranch += RcvUpdatedBranch;
			frm.ShowDialog();
		}

		private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!_branches.Any()) return;

			int currentRowId = (int)gvBranches.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_branchModel = _branches.SingleOrDefault(x => x.Id == currentRowId);
			if (_branchModel == null) return;

			var frm = new BranchEditForm(_branchModel);
			frm.SendUpdatedBranch += RcvUpdatedBranch;
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
			gvBranches.ShowRibbonPrintPreview();
		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!CanDelete()) return;

			try
			{
				int.TryParse(gvBranches.GetFocusedRowCellValue("Id").ToString(), out int id);
				string name = gvBranches.GetFocusedRowCellValue("Name").ToString();

				if (id > 0)
				{
					if (XtraMessageBox.Show($"Are you sure you want to delete Record: `{name}`?",
						    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
						    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						_branchModel = gvBranches.GetFocusedRow() as BranchModel;
						if (_branchModel == null)
						{
							return;
						}
						_branchModel.Deleted = true;

						//delete the record
						_branchRepository.DeleteBranch(_branchModel.Id);
						RcvUpdatedBranch(_branchModel, EventArgs.Empty);
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

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvBranches, CurrentUser.UserName);
			}
		}
		private void BranchesListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvBranches, CurrentUser.UserName);
			}
		}

		#endregion

		private void RcvUpdatedBranch(object sender, EventArgs e)
		{
			if (sender == null) return;
			_branchModel = sender as BranchModel;

			if (_branchModel.LastModifiedDate == null || _branchModel.Deleted)
			{
				InitializeBindings();
				WireUpBindings();
			}
			else
			{
				gvBranches.UpdateCurrentRow();
			}
		}

		private void gcBranches_DoubleClick(object sender, EventArgs e)
		{
			if (!_isAdmin && !_canEdit) return;

			if (!_branches.Any()) return;

			int currentRowId = (int)gvBranches.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_branchModel = _branches.SingleOrDefault(x => x.Id == currentRowId);
			if (_branchModel == null) return;

			var frm = new BranchEditForm(_branchModel);
			frm.SendUpdatedBranch += RcvUpdatedBranch;
			frm.ShowDialog();
		}

		private bool CanDelete()
		{
			BranchModel dataBoundItem = gvBranches.GetFocusedRow() as BranchModel;

			if (gvBranches == null || gvBranches.SelectedRowsCount == 0) return false;
			if (gvBranches.SelectedRowsCount > 1)
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

		private void gvBranches_RowCellStyle(object sender, RowCellStyleEventArgs e)
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
	}
}