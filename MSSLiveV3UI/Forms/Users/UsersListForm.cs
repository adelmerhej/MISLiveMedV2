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

		// Centralized open-edit form helper
		private void OpenUserEdit(UserModel model)
		{
			if (model == null) return;
			var userForm = new UserEditForm(model);
			userForm.SendUpdatedUser += RcvUpdatedUser;
			userForm.ShowDialog();
		}

		// Try get focused row user model safely
		private bool TryGetFocusedUser(out UserModel user)
		{
			user = null;
			if (_users == null || !_users.Any()) return false;

			var idObj = gvUsers.GetFocusedRowCellValue("Id");
			if (idObj == null) return false;

			int id;
			try { id = Convert.ToInt32(idObj); } catch { return false; }
			if (id <= 0) return false;

			user = _users.SingleOrDefault(x => x.Id == id);
			return user != null;
		}

		private void InitializeBindings()
		{
			try
			{
				_formId = _formRepository.SelectFormByName(_formName);
				_userPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, _formId) ?? new List<UserPermissionModel>();
				if (_userPermission.Count > 0)
				{
					var isProtected = _userPermission.SingleOrDefault(x => x.ControlName == "IsProtected")?.Value;
					_isProtected = HelperApplication.ConvertToBool(isProtected) ?? _isProtected;
				}
				_users = _userRepository.SelectUsers() ?? new List<UserModel>();
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
			LayoutsStyle.LoadLayoutGrid(gvUsers, CurrentUser.UserName, CurrentUser.CompanyName);
		}

		private void ApplyPermissions()
		{
			if (_userPermission == null || _userPermission.Count == 0)
			{
				// leave defaults
				return;
			}

			_canAdd = GetPermission("CanAdd");
			_canEdit = GetPermission("CanEdit");
			_canDelete = GetPermission("CanDelete");
			_canPrint = GetPermission("CanPrint");
			_isAdmin = GetPermission("IsAdmin");
			_isProtected = GetPermission("IsProtected", _isProtected);

			btnNew.Enabled = _isAdmin || _canAdd;
			btnEdit.Enabled = _isAdmin || _canEdit;
			btnPrint.Enabled = _isAdmin || _canPrint;
			btnDelete.Enabled = _isAdmin || _canDelete;
		}

		private bool GetPermission(string name, bool defaultValue = false)
		{
			var raw = _userPermission.FirstOrDefault(p => p.ControlName == name)?.Value;
			return HelperApplication.ConvertToBool(raw) ?? defaultValue;
		}

		#region MenuButtons

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			OpenUserEdit(new UserModel());
		}

		private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (TryGetFocusedUser(out var user))
			{
				OpenUserEdit(user);
			}
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
			// implement delete when repository supports it
		}

		private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			Close();
		}

		#endregion

		private void gvUsers_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				if (TryGetFocusedUser(out var user))
				{
					OpenUserEdit(user);
				}
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void RcvUpdatedUser(object sender, EventArgs e)
		{
			var updated = sender as UserModel;
			if (updated == null) return;
			_userModel = updated;

			if (_userModel.LastModifiedDate == null || _userModel.Deleted)
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
				LayoutsStyle.ResetLayoutGrid(gvUsers, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		private void UsersListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvUsers, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		private void gvUsers_RowCellStyle(object sender, RowCellStyleEventArgs e)
		{
			var view = sender as GridView;
			if (view == null || e.RowHandle < 0) return;
			bool isActive = HelperApplication.ConvertToBool(view.GetRowCellValue(e.RowHandle, "Active")) ?? false;
			bool isDefault = HelperApplication.ConvertToBool(view.GetRowCellValue(e.RowHandle, "IsDefault")) ?? false;
			if (!isActive)
			{
				e.Appearance.ForeColor = Color.Gray;
				e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Italic);
			}
			if (isDefault)
			{
				e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
			}
		}
	}
}