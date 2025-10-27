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
using MISLiveMed.DataLayers.Accounting.Commissions;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.Commissions;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Accounting.Commissions
{
    public partial class CommissionManagerListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "CommissionManagerList";
		private int _formId;
		private bool _resetMenu;

		private CommissionManagerModel _commissionManagerModel = new CommissionManagerModel();
        private IList<CommissionManagerModel> _commissions = new List<CommissionManagerModel>();
        private IList<UserModel> _users = new List<UserModel>();
        
        private readonly CommissionManagerRepository _commissionManagerRepository = new CommissionManagerRepository();
        private readonly UserRepository _userRepository = new UserRepository();

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

		public RibbonControl MainRibbon => rcCommissionManager;
        public RibbonPage DefaultPage => rpCommissionManager;


        #endregion

        public CommissionManagerListForm()
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

				_commissions = _commissionManagerRepository.SelectCommissionsManagement();
				_users = _userRepository.SelectUsers();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {
            bsCommissionManager.DataSource = _commissions;

            gcCommissionManager.DataSource = null;
            gcCommissionManager.DataSource = bsCommissionManager;

            repUsers.DataSource = null;
            repUsers.DataSource = _users;
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
            rgFilterReports.Gallery.GetItemByValue("showAll").Checked = false;
            rgFilterReports.Gallery.GetItemByValue("showSalesOnly").Checked = true;
            rgFilterReports.Gallery.GetItemByValue("showInactive").Checked = false;
            rgFilterReports.Gallery.GetItemByValue("showExpired").Checked = false;

            //Apply default filter
            gvCommissionManager.ActiveFilter.Clear();
            ColumnView view = gvCommissionManager;
            view.ActiveFilter.Add(view.Columns["IsSales"],
                new ColumnFilterInfo("[IsSales] = 'True'", "Is Sales = True"));

            LayoutsStyle.LoadLayoutGrid(gvCommissionManager, CurrentUser.UserName);
		}

        #region Buttons Event

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            CommissionManagerEditForm frm = new CommissionManagerEditForm(new CommissionManagerModel());
            frm.SendUpdatedCommissionManager += RcvUpdatedCommissionManager;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!_commissions.Any()) return;

            int currentRowId = (int)gvCommissionManager.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _commissionManagerModel = _commissions.SingleOrDefault(x => x.Id == currentRowId);
            if (_commissionManagerModel == null) return;

            var frm = new CommissionManagerEditForm(_commissionManagerModel);
            frm.SendUpdatedCommissionManager += RcvUpdatedCommissionManager;
            frm.ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcCommissionManager.ShowRibbonPrintPreview();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CanDelete()) return;

            try
            {
                int.TryParse(gvCommissionManager.GetFocusedRowCellValue("Id").ToString(), out int id);
                string name = gvCommissionManager.GetFocusedRowCellValue("SalesId").ToString();

                if (id > 0)
                {
                    if (XtraMessageBox.Show($"Are you sure you want to delete Record: `{name}`?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        _commissionManagerModel = gvCommissionManager.GetFocusedRow() as CommissionManagerModel;
                        if (_commissionManagerModel == null)
                        {
                            return;
                        }
                        _commissionManagerModel.Deleted = true;

                        //delete the record
                        _commissionManagerRepository.DeleteCommissionManager(_commissionManagerModel.Id);
                        RcvUpdatedCommissionManager(_commissionManagerModel, EventArgs.Empty);
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

        private void RcvUpdatedCommissionManager(object sender, EventArgs e)
        {
            if (sender == null) return;
            _commissionManagerModel = sender as CommissionManagerModel;

            if (_commissionManagerModel != null && (_commissionManagerModel.LastModifiedDate == null || _commissionManagerModel.Deleted))
            {
                InitializeBindings();
                WireUpBindings();
            }
            else
            {
                gvCommissionManager.UpdateCurrentRow();
            }
        }
        private void gcCommissionManager_DoubleClick(object sender, EventArgs e)
        {
	        if (!_isAdmin && !_canEdit) return;

			if (!_commissions.Any()) return;

	        int currentRowId = (int)gvCommissionManager.GetFocusedRowCellValue("Id");
	        if (currentRowId == 0) return;

	        _commissionManagerModel = _commissions.SingleOrDefault(x => x.Id == currentRowId);
	        if (_commissionManagerModel == null) return;

	        var frm = new CommissionManagerEditForm(_commissionManagerModel);
	        frm.SendUpdatedCommissionManager += RcvUpdatedCommissionManager;
	        frm.ShowDialog();
        }

		private void gvCommissionManager_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool isActive = view != null && (bool)view.GetRowCellValue(e.RowHandle, "Active");
                bool isDefault = view != null && (bool)view.GetRowCellValue(e.RowHandle, "IsDefault");
                bool isSales = view != null && (bool)view.GetRowCellValue(e.RowHandle, "IsSales");
                if (view != null)
                {
                    DateTime expiredContract = (DateTime)view.GetRowCellValue(e.RowHandle, "ContractEndDate");

                    if (isDefault)
                    {
                        e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
                    }

                    if (!isSales)
                    {
                        e.Appearance.ForeColor = Color.Gray;
                        e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Italic);
                    }
                    if (expiredContract < DateTime.Now)
                    {
                        e.Appearance.ForeColor = Color.Red;
                        e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Strikeout);
                    }
                }

                if (!isActive)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }

        private bool CanDelete()
        {
            CityModel dataBoundItem = gvCommissionManager.GetFocusedRow() as CityModel;

            if (gvCommissionManager == null || gvCommissionManager.SelectedRowsCount == 0) return false;
            if (gvCommissionManager.SelectedRowsCount > 1)
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

        private void rgFilterReports_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            GridFilterBy();
        }

        private void GridFilterBy()
        {
            ColumnView view = gvCommissionManager;
            view.ActiveFilter.Clear();

            GalleryItem itemIsAll = rgFilterReports.Gallery.GetItemByValue("showAll");
            GalleryItem itemIsSalesOnly = rgFilterReports.Gallery.GetItemByValue("showSalesOnly");
            GalleryItem itemIsInactive = rgFilterReports.Gallery.GetItemByValue("showInactive");
            GalleryItem itemIsExpired = rgFilterReports.Gallery.GetItemByValue("showExpired");

            if (rgFilterReports.Gallery != null)
            {
                if (itemIsSalesOnly.Checked)
                {
                    view.ActiveFilter.Add(view.Columns["IsSales"],
                        new ColumnFilterInfo("[IsSales] = 'True'", "Is Sales = True"));
                }

                if (itemIsInactive.Checked)
                {
                    view.ActiveFilter.Add(view.Columns["Active"],
                        new ColumnFilterInfo("[Active] = 'False'", "Active = False"));
                }

                if (itemIsExpired.Checked)
                {
                    view.ActiveFilter.Add(view.Columns["ContractEndDate"],
                        new ColumnFilterInfo("[ContractEndDate] < Today", "Expired = True"));
                }

                if (itemIsAll.Checked)
                {
                    view.ActiveFilter.Clear();
                }

                if (!itemIsAll.Checked && !itemIsSalesOnly.Checked && !itemIsInactive.Checked && !itemIsExpired.Checked)
                {
                    view.ActiveFilter.Add(view.Columns["Active"],
                        new ColumnFilterInfo("[Active] = 'True'", "Active = True"));
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
				LayoutsStyle.ResetLayoutGrid(gvCommissionManager, CurrentUser.UserName);
			}
		}

		private void CommissionManagerListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvCommissionManager, CurrentUser.UserName);
			}
		}

		#endregion

	}
}