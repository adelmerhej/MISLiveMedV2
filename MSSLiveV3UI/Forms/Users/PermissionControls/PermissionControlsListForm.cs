using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.UI.Forms.Users.PermissionControls
{
	public partial class PermissionControlsListForm : RibbonForm
	{
		private const string _formName = "PermissionControlsList";
		private int _formId;
		private bool _resetMenu;

		private UserPermissionControlModel _userPermissionControlModel = new UserPermissionControlModel();
		private IList<UserPermissionControlModel> _userPermissionControls = new List<UserPermissionControlModel>();

		private readonly UserPermissionControlRepository _userPermissionControlRepository = new UserPermissionControlRepository();
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

		public RibbonControl MainRibbon => rcPermissionControlsList;
		public RibbonPage DefaultPage => rpPermissionControlsList;


		#endregion

		public PermissionControlsListForm()
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
				
				_userPermissionControls = _userPermissionControlRepository.SelectUserPermissionControls();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsUserPermissionControls.DataSource = _userPermissionControls;

			//gcCities.DataSource = null;
			//gcCities.DataSource = bsCities;
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
			//LayoutsStyle.LoadLayoutGrid(gvCities, CurrentUserModel.UserName);
		}

		#region Buttons event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			PermissionControlEditForm frm = new PermissionControlEditForm(new UserPermissionControlModel());
			frm.SendUpdatedPermissionControl += RcvUpdatedPermissionControl;
			frm.ShowDialog();
		}

		private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!_userPermissionControls.Any()) return;

			int currentRowId = (int)gvPermissionControls.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_userPermissionControlModel = _userPermissionControls.SingleOrDefault(x => x.Id == currentRowId);
			if (_userPermissionControlModel == null) return;

			var frm = new PermissionControlEditForm(_userPermissionControlModel);
			frm.SendUpdatedPermissionControl += RcvUpdatedPermissionControl;
			frm.ShowDialog();
		}

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{
			InitializeBindings();
			WireUpBindings();
		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcPermissionControls.ShowRibbonPrintPreview();
		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!CanDelete()) return;

			try
			{
				int.TryParse(gvPermissionControls.GetFocusedRowCellValue("Id").ToString(), out int id);
				string name = gvPermissionControls.GetFocusedRowCellValue("ControlName").ToString();

				if (id > 0)
				{
					if (XtraMessageBox.Show($"Are you sure you want to delete `{name}`?",
						    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
						    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						_userPermissionControlModel = gvPermissionControls.GetFocusedRow() as UserPermissionControlModel;
						if (_userPermissionControlModel == null)
						{
							return;
						}
						_userPermissionControlModel.Deleted = true;

						//delete the record
						if (!_userPermissionControlRepository.DeleteCUserPermissionControl(_userPermissionControlModel.Id)) return;
						RcvUpdatedPermissionControl(_userPermissionControlModel, EventArgs.Empty);
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
		private void RcvUpdatedPermissionControl(object sender, EventArgs e)
		{
			if (sender == null) return;
			_userPermissionControlModel = sender as UserPermissionControlModel;

			if (_userPermissionControlModel != null && (_userPermissionControlModel.LastModifiedDate == null || _userPermissionControlModel.Deleted))
			{
				InitializeBindings();
				WireUpBindings();
			}
			else
			{
				gvPermissionControls.UpdateCurrentRow();
			}
		}
		private bool CanDelete()
		{
			UserPermissionControlModel dataBoundItem = gvPermissionControls.GetFocusedRow() as UserPermissionControlModel;

			if (gvPermissionControls == null || gvPermissionControls.SelectedRowsCount == 0) return false;

			if (gvPermissionControls.SelectedRowsCount > 1)
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

			if (dataBoundItem != null && !dataBoundItem.IsDefault)
			{
				XtraMessageBox.Show("This record is in use, cannot be deleted!",
					"Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void gvPermissionControls_RowCellStyle(object sender, RowCellStyleEventArgs e)
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

		private void gcPermissionControls_DoubleClick(object sender, EventArgs e)
		{
			if (!_userPermissionControls.Any()) return;

			int currentRowId = (int)gvPermissionControls.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_userPermissionControlModel = _userPermissionControls.SingleOrDefault(x => x.Id == currentRowId);
			if (_userPermissionControlModel == null) return;

			var frm = new PermissionControlEditForm(_userPermissionControlModel);
			frm.SendUpdatedPermissionControl += RcvUpdatedPermissionControl;
			frm.ShowDialog();
		}
	}
}