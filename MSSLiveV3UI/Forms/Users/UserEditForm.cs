using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraSplashScreen;
using Microsoft.AspNet.Identity;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Common.Titles;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Common.Forms;
using MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Properties;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Common;
using MISLiveMed.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MISLiveMed.UI.Forms.Users
{
	public partial class UserEditForm : XtraForm
	{
		private const string _formName = "UserEdit";
		private int _formId;
		DXMenuItem[] _menuItems;

		private DataEntityState _objState = DataEntityState.Unchanged;

		private UserModel _userModel = new UserModel();
		private UserDetailModel _userDetailModel = new UserDetailModel();
		private IList<CountryModel> _countries = new List<CountryModel>();
		private IList<CityModel> _cities = new List<CityModel>();
		private IList<ProvinceModel> _provinces = new List<ProvinceModel>();
		private IList<DistrictModel> _districts = new List<DistrictModel>();
		private FormModel _formModel = new FormModel();
		private IList<FormModel> _forms = new List<FormModel>();
		private IList<UserPermissionModel> _userPermissionAppRecords = new List<UserPermissionModel>();
		private IList<UserPermissionControlModel> _userPermissionControls = new List<UserPermissionControlModel>();

		private readonly UserRepository _userRepository = new UserRepository();
		private readonly UserDetailRepository _userDetailRepository = new UserDetailRepository();
		private readonly TitleRepository _titleRepository = new TitleRepository();
		private readonly CountryRepository _countryRepository = new CountryRepository();
		private readonly CityRepository _cityRepository = new CityRepository();
		private readonly DistrictRepository _districtRepository = new DistrictRepository();
		private readonly ProvinceRepository _provincesRepository = new ProvinceRepository();
		private readonly UserPermissionControlRepository _userPermissionControlRepository = new UserPermissionControlRepository();

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

		public EventHandler SendUpdatedUser;

		public UserEditForm(UserModel model)
		{
			InitializeComponent();

			try
			{
				_userModel = model;

				InitializeBindings();
				WireUpBindings();
				ApplyDefaults();
				ApplyPermissions();
				InitializeMenuItems();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, "Error in loading...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
				
				_countries = _countryRepository.SelectCountries();
				_provinces = _provincesRepository.SelectProvinces();
				_districts = _districtRepository.SelectDistricts();
				_cities = _cityRepository.SelectCities();
				_forms = _formRepository.SelectForms();
				_userPermissionControls = _userPermissionControlRepository.SelectUserPermissionControls();
				_userDetailModel = _userDetailRepository.SelectUserDetailById(_userModel.Id) ?? new UserDetailModel();

				_titleRepository.SelectTitles();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsUser.DataSource = _userModel;
			if (_userDetailModel != null) bsUserDetails.DataSource = _userDetailModel;

			cboCountries.Properties.DataSource = null;
			cboCountries.Properties.DataSource = _countries;
			if (_userDetailModel != null) cboCountries.EditValue = _userDetailModel.CountryId;

			cboProvinces.Properties.DataSource = null;
			cboProvinces.Properties.DataSource = _provinces;
			if (_userDetailModel != null) cboProvinces.EditValue = _userDetailModel.ProvinceId;

			cboDistricts.Properties.DataSource = null;
			cboDistricts.Properties.DataSource = _districts;
			if (_userDetailModel != null) cboDistricts.EditValue = _userDetailModel.DistrictId;

			cboCities.Properties.DataSource = null;
			cboCities.Properties.DataSource = _cities;
			if (_userDetailModel != null) cboCities.EditValue = _userDetailModel.CityId;

			HelperApplication.InitTitleComboBox(cboTitles.Properties);
			if (_userDetailModel != null) cboTitles.SelectedItem = _userDetailModel.Title;

			gcAppForms.DataSource = null;
			gcAppForms.DataSource = _forms;

			repUsersPermissionControls.DataSource = null;
			repUsersPermissionControls.DataSource = _userPermissionControls;
		}

		private void ApplyPermissions()
		{
			// If no permissions loaded, keep defaults for buttons
			if (_userPermission == null || _userPermission.Count == 0)
			{
				return;
			}

			// Retrieve permissions safely and succinctly
			_canEdit = GetPermission("CanEdit");
			_isAdmin = GetPermission("IsAdmin");
			_isProtected = GetPermission("IsProtected");

			// Apply to UI elements
			txtUserName.ReadOnly = !_isAdmin && !_canEdit;
			txtPassword.ReadOnly = !_isAdmin && !_canEdit;
			cboTitles.ReadOnly = !_isAdmin && !_canEdit;
			txtFirstName.ReadOnly = !_isAdmin && !_canEdit;
			txtLastName.ReadOnly = !_isAdmin && !_canEdit;

			txtMobile.ReadOnly = !_isAdmin && !_canEdit;
			txtPhone.ReadOnly = !_isAdmin && !_canEdit;
			dtBirthDate.ReadOnly = !_isAdmin && !_canEdit;
			txtEmail.ReadOnly = !_isAdmin && !_canEdit;
			txtAddress.ReadOnly = !_isAdmin && !_canEdit;

			cboCountries.ReadOnly = !_isAdmin && !_canEdit;
			cboCities.ReadOnly = !_isAdmin && !_canEdit;
			cboProvinces.ReadOnly = !_isAdmin && !_canEdit;
			cboDistricts.ReadOnly = !_isAdmin && !_canEdit;

			txtNotes.ReadOnly = !_isAdmin && !_canEdit;
			btnSave.Enabled = _isAdmin || _canEdit;

			chkActive.Enabled = _isAdmin;
			passwordLink.Visibility = _isAdmin ? LayoutVisibility.Always : LayoutVisibility.Never;
			lblPassword.Visibility = _isAdmin ? LayoutVisibility.Always : LayoutVisibility.Never;
			changePasswordLink.Enabled = _isAdmin || _canEdit;
			xtpUserPermissions.PageVisible = _isAdmin;
			xtpAccountingInfo.PageVisible = _isAdmin;

			chkMobileNumberConfirmed.Enabled = _isAdmin;
			chkConfirmedEmail.Enabled = _isAdmin;
		}

		// Helper to get a permission flag by name with default fallback
		private bool GetPermission(string name, bool defaultValue = false)
		{
			var raw = _userPermission.FirstOrDefault(p => p.ControlName == name)?.Value;
			return HelperApplication.ConvertToBool(raw) ?? defaultValue;
		}

		private void ApplyDefaults()
		{
			txtUserName.Focus();
			userTabControl.TabIndex = 0;
			txtPassword.Text = Settings.Default.UserPassword;
		}
		void InitializeMenuItems()
		{
			DXMenuItem itemAdd = new DXMenuItem("Add", ItemAdd_Click);
			DXMenuItem itemEdit = new DXMenuItem("Edit", ItemEdit_Click);
			DXMenuItem itemDelete = new DXMenuItem("Delete", ItemDelete_Click);
			_menuItems = new[] { itemAdd, itemEdit, itemDelete };
		}
		private void ItemAdd_Click(object sender, EventArgs e)
		{
			gvFormPermissions.ShowEditor();
		}

		private void ItemEdit_Click(object sender, EventArgs e)
		{
			gvFormPermissions.ShowEditor();
		}
		private void ItemDelete_Click(object sender, EventArgs e)
		{
			if (!_userPermissionControls.Any()) return;

			int id = (int)gvFormPermissions.GetFocusedRowCellValue("Id");
			string name = gvFormPermissions.GetFocusedRowCellValue("ControlName").ToString();

			if (id != 0)
			{
				if (XtraMessageBox.Show($"Are you sure you want to delete `{name}`?",
					    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
					    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					gvFormPermissions.SetRowCellValue(gvFormPermissions.FocusedRowHandle, "Deleted", true);

					//delete the record
					if (!_userPermissionRepository.DeleteUserPermission(id))
					{
						throw new Exception(
							"Error while deleting, please try again or contact your system administrator.");
					}

					gvFormPermissions.UpdateCurrentRow();
				}
			}
		}
		private void gvFormPermissions_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
		{
			if (e.HitInfo.InRow)

			{
				GridView view = sender as GridView;
				view.FocusedRowHandle = e.HitInfo.RowHandle;

				foreach (DXMenuItem item in _menuItems)
					e.Menu.Items.Add(item);
				//}
			}
		}

		#region Buttons Event

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateData()) return;

			try
			{
				BindingContext[bsUser].EndCurrentEdit();
				_userModel = (UserModel)bsUser.Current;

				//var newPass = SystemUtilities.PasswordHasher.HashPassword(txtPassword.Text);

				if (_userModel == null) return;

				if (cboCountries.EditValue != null) _userDetailModel.CountryId = (int)cboCountries.EditValue;
				if (cboCities.EditValue != null) _userDetailModel.CityId = (int)cboCities.EditValue;
				if (cboDistricts.EditValue != null) _userDetailModel.DistrictId = (int)cboDistricts.EditValue;
				if (cboProvinces.EditValue != null) _userDetailModel.ProvinceId = (int)cboProvinces.EditValue;
				if (cboTitles.EditValue != null) _userDetailModel.Title = (int)cboTitles.EditValue;

				if (_userModel.Id == 0)
				{
					_logInfoRepository.CreateLogInfo(_userModel);

					SystemUtilities.PasswordHasher = new PasswordHasher();
					_userModel.PasswordHash = SystemUtilities.PasswordHasher.HashPassword(txtPassword.Text);
					_userModel.SecurityStamp = Guid.NewGuid().ToString("D");
					_userModel.FirstTimeAccess = true;
					_userModel.PermissionChanged = true;

					var newId = _userRepository.AddNewUser(_userModel);
				}
				else
				{
					_logInfoRepository.UpdateLogInfo(_userModel);
					_userRepository.UpdateUser(_userModel);
				}

				_userDetailModel.UserId = _userModel.Id;

				if (_userDetailModel.Id == 0)
				{
					_logInfoRepository.CreateLogInfo(_userDetailModel);
					var newId = _userDetailRepository.AddNewUserDetail(_userDetailModel);
				}
				else
				{
					_logInfoRepository.UpdateLogInfo(_userDetailModel);
					_userDetailRepository.UpdateUserDetail(_userDetailModel);
				}

				SendUpdatedUser(_userModel, EventArgs.Empty);

				_objState = DataEntityState.Unchanged;
				Close();
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message,
					"On Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			//var messageNumber = 0;
			var validateMessage = new StringBuilder();

			if (txtUserName.Text == "")
			{
				//messageNumber += 1;
				validateMessage.Append("\n- User Name cannot be empty.");
				validateReturnValue = false;
				txtUserName.Focus();
			}

			if (txtPassword.Text == "" && _userModel.Id == 0)
			{
				//messageNumber += 1;
				validateMessage.Append("\n- Password cannot be empty.");
				validateReturnValue = false;
				txtPassword.Focus();
			}

			if (txtFirstName.Text == "")
			{
				//messageNumber += 1;
				validateMessage.Append("\n- First Name cannot be empty.");
				validateReturnValue = false;
				txtFirstName.Focus();
			}

			if (txtSecurityLevel.Value <= 0 || txtSecurityLevel.Value > 10 || txtSecurityLevel.Text == "")
			{
				//messageNumber += 1;
				validateMessage.Append("\n- Security Level should have value between 1 and 10.");
				validateReturnValue = false;
				txtSecurityLevel.Focus();
			}
			//txtSecurityLevel

			if (!validateReturnValue)
			{
				validateMessage.Insert(0, "The following need your attention:");
				//if (messageNumber > 1) validateMessage.Replace("following", "followings");
				XtraMessageBox.Show(validateMessage + " \nPlease try again.",
					"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			return validateReturnValue;
		}

		private void UserEditForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				e.Cancel = true;
			}
		}

		private void btnSeedDefaultData_Click(object sender, EventArgs e)
		{
			try
			{
				if (XtraMessageBox.Show(
						$"This action may overwrite all permissions with default, do you wish to continue?",
						"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (_userModel == null)
					{
						XtraMessageBox.Show("User cannot be empty", @"Error", MessageBoxButtons.OK,
							MessageBoxIcon.Exclamation);
						return;
					}

					int pendingTime = 0; // the delay is 1 second (1000 ms)
					SplashScreenManager.ShowForm(null, typeof(WaitForm1), true, true, true, pendingTime);
					SplashScreenManager.Default.SetWaitFormCaption("Please wait");
					SplashScreenManager.Default.SetWaitFormDescription("Adding forms");

					_userPermissionRepository.SeedUserPermissionsData(_userModel.Id,_userModel.UserName.ToLower() == "admin");

					SplashScreenManager.CloseForm(false);

					XtraMessageBox.Show("Seeding Done!",
						"Seeding Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message, "Seeding Data Error!", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void changePasswordLink_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtUserName.Text == "")
				{
					XtraMessageBox.Show(this,
						"You have to authenticate your username to change its password.\nOtherwise contact your system administrator.",
						"Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtUserName.Focus();
					return;
				}

				var changeUserModel = _userRepository.GetUsersByName(txtUserName.Text.Trim());
				if (txtUserName.Text == string.Empty || changeUserModel == null)
				{
					XtraMessageBox.Show($"Invalid username [ {txtUserName.Text} ].", "Change Password",
						MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				ChangePasswordForm _frm = new ChangePasswordForm(changeUserModel);
				_frm.SendChangedPassword += RcvChangedPassword;
				_frm.ShowDialog();
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtPassword_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			ButtonEdit edit = sender as ButtonEdit;
			if (edit != null) edit.Properties.PasswordChar = (edit.Properties.PasswordChar == '*') ? '\0' : '*';
		}

		private void txtPassword_MouseLeave(object sender, EventArgs e)
		{
			ButtonEdit edit = sender as ButtonEdit;
			if (edit != null) edit.Properties.PasswordChar = edit.Properties.PasswordChar = '*';
		}

		private void gvAppForms_RowClick(object sender, RowClickEventArgs e)
		{
			FetchPermissions();
		}

		private void FetchPermissions()
		{
			try
			{
				if (!_forms.Any()) return;

				int currentRowId = (int)gvAppForms.GetFocusedRowCellValue("Id");
				if (currentRowId == 0) return;

				_formModel = _forms.SingleOrDefault(x => x.Id == currentRowId);
				if (_formModel == null) return;

				_userPermissionAppRecords = _userPermissionRepository.SelectUserPermissionById(_userModel.Id, currentRowId);

				gcFormPermissions.DataSource = null;
				gcFormPermissions.DataSource = _userPermissionAppRecords;

			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
			}
		}
		private void btnUpdatePermissions_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (var record in _userPermissionAppRecords)
				{
					_logInfoRepository.UpdateLogInfo(record);
					_ = _userPermissionRepository.UpdateUserPermission(record);
				}

				_userModel.PermissionChanged = true;
				_logInfoRepository.UpdateLogInfo(_userModel);
				_ = _userRepository.UpdateUser(_userModel);

				XtraMessageBox.Show("Permission Saved! Restart to make changes.", @"Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void gvFormPermissions_RowCellStyle(object sender, RowCellStyleEventArgs e)
		{
			GridView view = sender as GridView;
			if (e.RowHandle >= 0)
			{
				bool isActive = view != null && (bool)view.GetRowCellValue(e.RowHandle, "Value");
				if (isActive)
				{
					e.Appearance.ForeColor = Color.Black;
					e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
				}
				if (!isActive)
				{
					e.Appearance.ForeColor = Color.Gray;
					e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Italic);
				}
			}
		}
		private void gvFormPermissions_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F12)
			{
				try
				{
					if (CurrentUser.UserName.ToLower() == "admin")
					{
						var result = XtraInputBox.Show("Enter your password:", "Change Settings", "Default");
						var superAdminPassword = _userRepository.AuthenticateSuperAdmin(CurrentUser.UserName.ToLower());

						if (superAdminPassword != null)
						{
							SystemUtilities.PasswordHasher = new PasswordHasher();
							var passwordVerificationResult =
								SystemUtilities.PasswordHasher.VerifyHashedPassword(superAdminPassword.PasswordHash, result);

							switch (passwordVerificationResult)
							{
								case PasswordVerificationResult.Failed:
									XtraMessageBox.Show(@"Username or Password are incorrect! Please try again.", @"Error",
										MessageBoxButtons.OK, MessageBoxIcon.Error);

									break;

								case PasswordVerificationResult.Success:
									gvFormPermissions.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
									gvFormPermissions.OptionsBehavior.AllowAddRows = DefaultBoolean.True;
									gvFormPermissions.OptionsBehavior.AllowDeleteRows = DefaultBoolean.True;

									return;

								case PasswordVerificationResult.SuccessRehashNeeded:

									break;
							}
						}
					}
				}
				catch (Exception exception)
				{
					//
				}
			}
		}

		private void RcvChangedPassword(object sender, EventArgs e)
		{
			if (sender is not UserModel model) return;
			_userModel = model;
		}
	}
}