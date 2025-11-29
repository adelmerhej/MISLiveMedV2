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
	public partial class BalanceHeadersListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "BalanceHeadersList";
		private int _formId;
		private bool _resetMenu;

		private IList<BalanceGroupModel> _balanceGroups = new List<BalanceGroupModel>();
		private BalanceHeaderModel _balanceHeaderModel = new BalanceHeaderModel();
		private IList<BalanceHeaderModel> _balanceHeaders = new List<BalanceHeaderModel>();


		private readonly BalanceGroupRepository _balanceGroupRepository = new BalanceGroupRepository();
		private readonly BalanceHeaderRepository _balanceHeaderRepository = new BalanceHeaderRepository();

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

		public RibbonControl MainRibbon => rcBalanceHeaders;
		public RibbonPage DefaultPage => rpBalanceHeaders;


		#endregion

		public BalanceHeadersListForm()
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
				_balanceHeaders = _balanceHeaderRepository.SelectBalanceHeaders();

			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsBalanceHeaders.DataSource = _balanceHeaders;

			gcBalanceHeaders.DataSource = null;
			gcBalanceHeaders.DataSource = bsBalanceHeaders;

			repBalanceGroups.DataSource = null;
			repBalanceGroups.DataSource = _balanceGroups;
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
			LayoutsStyle.LoadLayoutGrid(gvBalanceHeaders, CurrentUser.UserName, CurrentUser.CompanyName);
		}

		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			BalanceHeaderEditForm frm = new BalanceHeaderEditForm(new BalanceHeaderModel());
			frm.SendUpdatedBalanceHeader += RcvUpdatedBalanceHeader;
			frm.ShowDialog();
		}

		private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!_balanceHeaders.Any()) return;

			int currentRowId = (int)gvBalanceHeaders.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_balanceHeaderModel = _balanceHeaders.SingleOrDefault(x => x.Id == currentRowId);
			if (_balanceHeaderModel == null) return;

			var frm = new BalanceHeaderEditForm(_balanceHeaderModel);
			frm.SendUpdatedBalanceHeader += RcvUpdatedBalanceHeader;
			frm.ShowDialog();
		}

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{
			InitializeBindings();
			WireUpBindings();
		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcBalanceHeaders.ShowRibbonPrintPreview();
		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!CanDelete()) return;

			try
			{
				int.TryParse(gvBalanceHeaders.GetFocusedRowCellValue("Id").ToString(), out int id);
				string name = gvBalanceHeaders.GetFocusedRowCellValue("Name").ToString();

				if (id > 0)
				{
					if (XtraMessageBox.Show($"Are you sure you want to delete: `{name}`?",
							"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
							MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						_balanceHeaderModel = gvBalanceHeaders.GetFocusedRow() as BalanceHeaderModel;
						if (_balanceHeaderModel == null)
						{
							return;
						}
						_balanceHeaderModel.Deleted = true;

						//delete the record
						if (!_balanceHeaderRepository.DeleteBalanceHeader(_balanceHeaderModel.Id)) return;
						RcvUpdatedBalanceHeader(_balanceHeaderModel, EventArgs.Empty);
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
		private void RcvUpdatedBalanceHeader(object sender, EventArgs e)
		{
			if (sender == null) return;
			_balanceHeaderModel = sender as BalanceHeaderModel;

			if (_balanceHeaderModel != null && (_balanceHeaderModel.LastModifiedDate == null || _balanceHeaderModel.Deleted))
			{
				InitializeBindings();
				WireUpBindings();
			}
			else
			{
				gvBalanceHeaders.UpdateCurrentRow();
			}
		}

		private bool CanDelete()
		{
			BalanceHeaderModel dataBoundItem = gvBalanceHeaders.GetFocusedRow() as BalanceHeaderModel;

			if (gvBalanceHeaders == null || gvBalanceHeaders.SelectedRowsCount == 0) return false;
			if (gvBalanceHeaders.SelectedRowsCount > 1)
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

		private void gvBalanceHeaders_RowCellStyle(object sender, RowCellStyleEventArgs e)
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
				LayoutsStyle.ResetLayoutGrid(gvBalanceHeaders, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}
		private void BalanceHeaderListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvBalanceHeaders, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		#endregion

		private void gcBalanceHeaders_DoubleClick(object sender, EventArgs e)
		{
			if (!_balanceHeaders.Any()) return;

			int currentRowId = (int)gvBalanceHeaders.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_balanceHeaderModel = _balanceHeaders.SingleOrDefault(x => x.Id == currentRowId);
			if (_balanceHeaderModel == null) return;

			var frm = new BalanceHeaderEditForm(_balanceHeaderModel);
			frm.SendUpdatedBalanceHeader += RcvUpdatedBalanceHeader;
			frm.ShowDialog();
		}
	}
}