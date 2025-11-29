using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Accounting.Reports.Settings;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.Reports.Settings;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Accounting.Journals.Reports.Settings
{
	public partial class BalanceSheetSettingsListForm: RibbonForm, IFormWithRibbon
	{
		private const string _formName = "BalanceSheetSettingsList";
		private int _formId;
		private bool _resetMenu;

		private IList<BalanceSheetSettingModel> _balanceSheetSettings = new List<BalanceSheetSettingModel>();
		private BalanceSheetSettingModel _balanceSheetSettingModel = new BalanceSheetSettingModel();

		private IList<BalanceGroupModel> _balanceGroups = new List<BalanceGroupModel>();
		private IList<BalanceHeaderModel> _balanceHeaders = new List<BalanceHeaderModel>();

		private readonly BalanceSheetSettingRepository _balanceSheetSettingsRepository =
			new BalanceSheetSettingRepository();

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

		public RibbonControl MainRibbon => rcAccounts;
		public RibbonPage DefaultPage => rpAccounts;


		#endregion

		public BalanceSheetSettingsListForm()
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

				_balanceSheetSettings = _balanceSheetSettingsRepository.SelectBalanceSheetSettings();
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
			bsBalanceSheetSettings.DataSource = _balanceSheetSettings;

			repBalanceHeaders.DataSource = null;
			repBalanceHeaders.DataSource = _balanceHeaders;

			filterBalanceGroup.DataSource = null;
			filterBalanceGroup.DataSource = _balanceGroups;

			filterBalanceHeaders.DataSource = null;
			filterBalanceHeaders.DataSource = _balanceHeaders;
		}

		private void ApplyDefaults()
		{
			LayoutsStyle.LoadLayoutGrid(gvBalanceSheetSettings, CurrentUser.UserName, CurrentUser.CompanyName);
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
		private void AccountBalanceSettingsListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvBalanceSheetSettings, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			BalanceSheetSettingEditForm frm = new BalanceSheetSettingEditForm(new BalanceSheetSettingModel());
			frm.SendUpdatedAccountBalanceSetting += RcvUpdatedAccountBalanceSetting;
			frm.ShowDialog();
		}

		private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!_balanceSheetSettings.Any()) return;

			int currentRowId = (int)gvBalanceSheetSettings.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_balanceSheetSettingModel = _balanceSheetSettings.SingleOrDefault(x => x.Id == currentRowId);
			if (_balanceSheetSettingModel == null) return;

			var frm = new BalanceSheetSettingEditForm(_balanceSheetSettingModel);
			frm.SendUpdatedAccountBalanceSetting += RcvUpdatedAccountBalanceSetting;
			frm.Show();
		}

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{
			InitializeBindings();
			WireUpBindings();
		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcBalanceSheetSettings.ShowRibbonPrintPreview();
		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!CanDelete()) return;

			try
			{
				int.TryParse(gvBalanceSheetSettings.GetFocusedRowCellValue("Id").ToString(), out int id);
				string name = gvBalanceSheetSettings.GetFocusedRowCellValue("Description").ToString();

				if (id > 0)
				{
					if (XtraMessageBox.Show($"Are you sure you want to delete : `{name}`?",
						    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
						    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						_balanceSheetSettingModel = gvBalanceSheetSettings.GetFocusedRow() as BalanceSheetSettingModel;
						if (_balanceSheetSettingModel == null)
						{
							return;
						}
						_balanceSheetSettingModel.Deleted = true;

						//delete the record
						_balanceSheetSettingsRepository.DeleteBalanceSheetSetting(_balanceSheetSettingModel.Id);
						RcvUpdatedAccountBalanceSetting(_balanceSheetSettingModel, EventArgs.Empty);
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
				LayoutsStyle.ResetLayoutGrid(gvBalanceSheetSettings, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		#endregion

		private void RcvUpdatedAccountBalanceSetting(object sender, EventArgs e)
		{
			if (sender == null) return;
			_balanceSheetSettingModel = sender as BalanceSheetSettingModel;

			if (_balanceSheetSettingModel.LastModifiedDate == null || _balanceSheetSettingModel.Deleted)
			{
				InitializeBindings();
				WireUpBindings();
			}
			else
			{
				gvBalanceSheetSettings.UpdateCurrentRow();
			}
		}

		private void gcAccountBalances_DoubleClick(object sender, EventArgs e)
		{
			if (!_balanceSheetSettings.Any()) return;

			int currentRowId = (int)gvBalanceSheetSettings.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_balanceSheetSettingModel = _balanceSheetSettings.SingleOrDefault(x => x.Id == currentRowId);
			if (_balanceSheetSettingModel == null) return;

			var frm = new BalanceSheetSettingEditForm(_balanceSheetSettingModel);
			frm.SendUpdatedAccountBalanceSetting += RcvUpdatedAccountBalanceSetting;
			frm.Show();
		}

		private bool CanDelete()
		{
			BalanceSheetSettingModel dataBoundItem = gvBalanceSheetSettings.GetFocusedRow() as BalanceSheetSettingModel;

			if (gvBalanceSheetSettings == null || gvBalanceSheetSettings.SelectedRowsCount == 0) return false;
			if (gvBalanceSheetSettings.SelectedRowsCount > 1)
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
			if (dataBoundItem != null && dataBoundItem.Locked)
			{
				XtraMessageBox.Show("This requires higher permission to delete a locked record!",
					"Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void cboBalanceGroup_EditValueChanged(object sender, EventArgs e)
		{
			ApplyBalanceHeaderFilter();
			ApplyGridFilter();
		}

		private void cboBalanceHeaders_EditValueChanged(object sender, EventArgs e)
		{
			ApplyGridFilter();
		}

		private void ApplyBalanceHeaderFilter()
		{
			if (cboBalanceGroup.EditValue != null)
			{
				try
				{
					_balanceHeaders = _balanceHeaderRepository.SelectBalanceHeaderByBalanceGroupId((int)cboBalanceGroup.EditValue);
					filterBalanceHeaders.DataSource = null;
					filterBalanceHeaders.DataSource = _balanceHeaders;
				}
				catch (Exception e)
				{
					XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void ApplyGridFilter()
		{
			ColumnView view = gvBalanceSheetSettings;
			view.ActiveFilter.Clear();

			if (cboBalanceHeaders.EditValue != null)
			{
				view.ActiveFilter.Add(view.Columns["BalanceHeaderId"],
					new ColumnFilterInfo(
						$"[BalanceHeaderId] = '{cboBalanceHeaders.EditValue}'",
						$"Header Group = {cboBalanceHeaders.Edit.GetDisplayText(cboBalanceHeaders.EditValue)}"));
			}
		}

		private void gvBalanceSheetSettings_RowCellStyle(object sender, RowCellStyleEventArgs e)
		{
			GridView view = sender as GridView;
			if (e.RowHandle >= 0)
			{
				bool isGrandTotal = view != null && (bool)view.GetRowCellValue(e.RowHandle, "IsGrandTotal");
				bool isTotal = view != null && (bool)view.GetRowCellValue(e.RowHandle, "IsTotal");

				if (isGrandTotal)
				{
					e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
				}

				if (!isGrandTotal && isTotal)
				{
					e.Appearance.ForeColor = Color.Gray;
					e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
				}
			}
		}

	}
}