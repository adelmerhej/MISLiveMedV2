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
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Members.Categories;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.CRM.Customers.Categories
{
    public partial class MembersCategoryListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "MembersCategoryList";
		private int _formId;
		private bool _resetMenu;

		private MemberCategoryModel _memberCategoryModel = new MemberCategoryModel();
        private IEnumerable<MemberCategoryModel> _membersCategory = new List<MemberCategoryModel>();

        private MemberCategoryRepository _memberCategoryRepository = new MemberCategoryRepository();

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

		public RibbonControl MainRibbon => rcMembersCategoryList;
        public RibbonPage DefaultPage => rpMembersCategoryList;


        #endregion

        public MembersCategoryListForm()
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

				_membersCategory = _memberCategoryRepository.SelectMembersCategory();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void WireUpBindings()
        {
            bsMembersCategory.DataSource = _membersCategory;

            gcMembersCategory.DataSource = null;
            gcMembersCategory.DataSource = bsMembersCategory;
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
	        LayoutsStyle.LoadLayoutGrid(gvMembersCategory, CurrentUser.UserName);
		}
        
        #region Buttons Event

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new MemberCategoryEditForm(new MemberCategoryModel());
            frm.SendUpdatedMemberCategory += RcvUpdatedMemberCategory;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!_membersCategory.Any()) return;

            int currentRowId = (int)gvMembersCategory.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _memberCategoryModel = _membersCategory.SingleOrDefault(x => x.Id == currentRowId);
            if (_memberCategoryModel == null) return;

            var frm = new MemberCategoryEditForm(_memberCategoryModel);
            frm.SendUpdatedMemberCategory += RcvUpdatedMemberCategory;
            frm.ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcMembersCategory.ShowRibbonPrintPreview();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CanDelete()) return;

            try
            {
                int.TryParse(gvMembersCategory.GetFocusedRowCellValue("Id").ToString(), out int id);
                string name = gvMembersCategory.GetFocusedRowCellValue("Description").ToString();

                if (id > 0)
                {
                    if (XtraMessageBox.Show($"Are you sure you want to delete Member Category: `{name}`?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        _memberCategoryModel = gvMembersCategory.GetFocusedRow() as MemberCategoryModel;
                        if (_memberCategoryModel == null)
                        {
                            return;
                        }
                        _memberCategoryModel.Deleted = true;

                        //delete the record
                        if (!_memberCategoryRepository.DeleteMemberCategory(id))
                        {
                            throw new Exception(
                                "Error while deleting, please try again or contact your system administrator.");
                        }
                        RcvUpdatedMemberCategory(_memberCategoryModel, EventArgs.Empty);
                    }
                }

            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "User delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new AboutForm();
            frm.ShowDialog();
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        #endregion

        private bool CanDelete()
        {
            MemberCategoryModel dataBoundItem = gvMembersCategory.GetFocusedRow() as MemberCategoryModel;

            if (gvMembersCategory == null || gvMembersCategory.SelectedRowsCount == 0) return false;
            if (gvMembersCategory.SelectedRowsCount > 1)
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
        private void RcvUpdatedMemberCategory(object sender, EventArgs e)
        {
            if (sender == null) return;
            _memberCategoryModel = sender as MemberCategoryModel;

            if (_memberCategoryModel.LastModifiedDate == null || _memberCategoryModel.Deleted)
            {
                InitializeBindings();
                WireUpBindings();
            }
            else
            {
                gvMembersCategory.UpdateCurrentRow();
            }
        }

        private void gvMembersCategory_RowCellStyle(object sender, RowCellStyleEventArgs e)
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

        private void gcMembersCategory_DoubleClick(object sender, EventArgs e)
        {
	        if (!_isAdmin && !_canEdit) return;

			if (!_membersCategory.Any()) return;

            int currentRowId = (int)gvMembersCategory.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _memberCategoryModel = _membersCategory.SingleOrDefault(x => x.Id == currentRowId);
            if (_memberCategoryModel == null) return;

            var frm = new MemberCategoryEditForm(_memberCategoryModel);
            frm.SendUpdatedMemberCategory += RcvUpdatedMemberCategory;
            frm.ShowDialog();
        }

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvMembersCategory, CurrentUser.UserName);
			}
		}

		private void MembersCategoryListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvMembersCategory, CurrentUser.UserName);
			}
		}
	}
}