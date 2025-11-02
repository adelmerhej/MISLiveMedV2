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
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.Users
{
	public partial class UsersListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "UsersList";
		private int _formId;
		private bool _resetMenu;

		private UserModel _userModel = new UserModel();
		private IList<UserModel> _users = new List<UserModel>();

		private readonly UserRepository _userRepository = new UserRepository();
		private readonly UserDetailRepository _userDetailRepository = new UserDetailRepository();

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

		public RibbonControl MainRibbon => rcUsersList;
		public RibbonPage DefaultPage => rpUsersList;


		#endregion

		public UsersListForm()
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

				_users = _userRepository.SelectUsers();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			gcUsers.DataSource = null;
			gcUsers.DataSource = _users;
		}
		private void ApplyDefaults()
		{
			LayoutsStyle.LoadLayoutGrid(gvUsers, CurrentUser.UserName);
		}
		private void ApplyPermissions()
		{
			// If no permissions loaded, keep defaults for buttons
			if (_userPermission == null || _userPermission.Count == 0)
			{
				return;
			}

			// Retrieve permissions safely and succinctly
			_canAdd = GetPermission("CanAdd");
			_canEdit = GetPermission("CanEdit");
			_canDelete = GetPermission("CanDelete");
			_canPrint = GetPermission("CanPrint");
			_isAdmin = GetPermission("IsAdmin");
			_isProtected = GetPermission("IsProtected");

			// Apply to UI elements
			btnNew.Enabled = _isAdmin || _canAdd;
			btnEdit.Enabled = _isAdmin || _canEdit;
			btnPrint.Enabled = _isAdmin || _canPrint;
			btnDelete.Enabled = _isAdmin || _canDelete;
		}

		// Helper to get a permission flag by name with default fallback
		private bool GetPermission(string name, bool defaultValue = false)
		{
			var raw = _userPermission.FirstOrDefault(p => p.ControlName == name)?.Value;
			return HelperApplication.ConvertToBool(raw) ?? defaultValue;
		}

		#region MenuButtons

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			UserEditForm frm = new UserEditForm(new UserModel());
			frm.SendUpdatedUser += RcvUpdatedUser;
			frm.ShowDialog();
		}

		private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!_users.Any()) return;

			int currentRowId = (int)gvUsers.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_userModel = _users.SingleOrDefault(x => x.Id == currentRowId);
			if (_userModel == null) return;

			var userForm = new UserEditForm(_userModel);
			userForm.SendUpdatedUser += RcvUpdatedUser;
			userForm.ShowDialog();
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
			gcUsers.ShowRibbonPrintPreview();
		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			Close();
		}

		#endregion

		private void gvUsers_DoubleClick(object sender, EventArgs e)
		{
			if (!_users.Any()) return;

			try
			{
				int currentRowId = (int)gvUsers.GetFocusedRowCellValue("Id");
				if (currentRowId == 0) return;

				_userModel = _users.SingleOrDefault(x => x.Id == currentRowId);
				if (_userModel == null) return;

				var userForm = new UserEditForm(_userModel);
				userForm.SendUpdatedUser += RcvUpdatedUser;
				userForm.ShowDialog();
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void RcvUpdatedUser(object sender, EventArgs e)
		{
			if (sender == null) return;
			_userModel = sender as UserModel;

			if (_userModel != null && (_userModel.LastModifiedDate == null || _userModel.Deleted))
			{
				InitializeBindings();
				WireUpBindings();
			}
			else
			{
				gvUsers.UpdateCurrentRow();
			}
		}

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
				DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvUsers, CurrentUser.UserName);
			}
		}

		private void UsersListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvUsers, CurrentUser.UserName);
			}
		}

		private void gvUsers_RowCellStyle(object sender, RowCellStyleEventArgs e)
		{
			GridView view = sender as GridView;
			if (e.RowHandle >= 0)
			{
				bool isActive = (bool)view.GetRowCellValue(e.RowHandle, "Active");
				bool isDefault = (bool)view.GetRowCellValue(e.RowHandle, "IsDefault");
				if (!isActive)
				{
					e.Appearance.ForeColor = isActive ? Color.Black : Color.Gray;
					e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Italic);
				}
				if (isDefault)
				{
					e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
				}
			}
		}

	}
}