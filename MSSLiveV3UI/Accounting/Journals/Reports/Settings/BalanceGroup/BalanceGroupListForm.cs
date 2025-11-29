using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Accounting.Reports.Settings;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.Reports.Settings;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Accounting.Journals.Reports.Settings.BalanceGroup
{
	public partial class BalanceGroupListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "BalanceGroupList";
		private int _formId;
		private bool _resetMenu;

		private BalanceGroupModel _balanceGroupModel = new BalanceGroupModel();
		private IList<BalanceGroupModel> _balanceGroups = new List<BalanceGroupModel>();

		private readonly BalanceGroupRepository _balanceGroupRepository = new BalanceGroupRepository();

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
		private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
		private readonly FormRepository _formRepository = new FormRepository();

		//Init permission variables
		private bool _canAdd;
		private bool _canEdit;
		private bool _canDelete;
		private bool _canPrint;
		private bool _isAdmin;
		private bool _isProtected;

		#region Implementation of IFormWithRibbon

		public RibbonControl MainRibbon => rcBalanceGroups;
		public RibbonPage DefaultPage => rpBalanceGroups;


		#endregion

		public BalanceGroupListForm()
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

				_balanceGroups = _balanceGroupRepository.SelectBalanceGroup();

			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			gcBalanceGroups.DataSource = null;
			gcBalanceGroups.DataSource = _balanceGroups;
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
		private void ApplyDefaults()
		{
			LayoutsStyle.LoadLayoutGrid(gvBalanceGroups, CurrentUser.UserName, CurrentUser.CompanyName);
		}

		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			BalanceGroupEditForm frm = new BalanceGroupEditForm(new BalanceGroupModel());
			frm.SendUpdatedBalanceGroup += RcvUpdatedBalanceGroup;
			frm.ShowDialog();
		}

		private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!_balanceGroups.Any()) return;

			int currentRowId = (int)gvBalanceGroups.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_balanceGroupModel = _balanceGroups.SingleOrDefault(x => x.Id == currentRowId);
			if (_balanceGroupModel == null) return;

			var frm = new BalanceGroupEditForm(_balanceGroupModel);
			frm.SendUpdatedBalanceGroup += RcvUpdatedBalanceGroup;
			frm.ShowDialog();
		}

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{
			InitializeBindings();
			WireUpBindings();
		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcBalanceGroups.ShowRibbonPrintPreview();
		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!CanDelete()) return;

			try
			{
				int.TryParse(gvBalanceGroups.GetFocusedRowCellValue("Id").ToString(), out int id);
				string name = gvBalanceGroups.GetFocusedRowCellValue("Name").ToString();

				if (id > 0)
				{
					if (XtraMessageBox.Show($"Are you sure you want to delete: `{name}`?",
							"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
							MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						_balanceGroupModel = gvBalanceGroups.GetFocusedRow() as BalanceGroupModel;
						if (_balanceGroupModel == null)
						{
							return;
						}
						_balanceGroupModel.Deleted = true;

						//delete the record
						if (!_balanceGroupRepository.DeleteBalanceGroup(_balanceGroupModel.Id)) return;
						RcvUpdatedBalanceGroup(_balanceGroupModel, EventArgs.Empty);
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
		private void RcvUpdatedBalanceGroup(object sender, EventArgs e)
		{
			if (sender == null) return;
			_balanceGroupModel = sender as BalanceGroupModel;

			if (_balanceGroupModel != null && (_balanceGroupModel.LastModifiedDate == null || _balanceGroupModel.Deleted))
			{
				InitializeBindings();
				WireUpBindings();
			}
			else
			{
				gvBalanceGroups.UpdateCurrentRow();
			}
		}

		private bool CanDelete()
		{
			BalanceGroupModel dataBoundItem = gvBalanceGroups.GetFocusedRow() as BalanceGroupModel;

			if (gvBalanceGroups == null || gvBalanceGroups.SelectedRowsCount == 0) return false;
			if (gvBalanceGroups.SelectedRowsCount > 1)
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

		private void gvBalanceGroups_RowCellStyle(object sender, RowCellStyleEventArgs e)
		{
			GridView view = sender as GridView;
			if (e.RowHandle >= 0)
			{
				bool isActive = view != null && (bool)view.GetRowCellValue(e.RowHandle, "Active");
				bool isDefault = view != null && (bool)view.GetRowCellValue(e.RowHandle, "IsDefault");
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

		#region Grid Events

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
				DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvBalanceGroups, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}
		private void BalanceGroupListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvBalanceGroups, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		#endregion

		private void gcBalanceGroups_DoubleClick(object sender, EventArgs e)
		{
			if (!_balanceGroups.Any()) return;

			int currentRowId = (int)gvBalanceGroups.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_balanceGroupModel = _balanceGroups.SingleOrDefault(x => x.Id == currentRowId);
			if (_balanceGroupModel == null) return;

			var frm = new BalanceGroupEditForm(_balanceGroupModel);
			frm.SendUpdatedBalanceGroup += RcvUpdatedBalanceGroup;
			frm.ShowDialog();
		}
	}
}