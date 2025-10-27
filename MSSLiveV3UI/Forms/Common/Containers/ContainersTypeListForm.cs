using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Common.Containers;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Containers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.Common.Containers
{
    public partial class ContainersTypeListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "ContainersTypeList";
		private int _formId;
		private bool _resetMenu;

		private IList<ContainerTypeModel> _containersType = new List<ContainerTypeModel>();
		private ContainerTypeModel _containerType = new ContainerTypeModel();
		private IList<MainContainerTypeModel> _mainContainerTypeList = new List<MainContainerTypeModel>();

		private readonly MainContainerTypeRepository _mainContainerTypeRepository = new MainContainerTypeRepository();
		private readonly ContainerTypeRepository _containerTypeRepository = new ContainerTypeRepository();

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

		public RibbonControl MainRibbon => rcContainersTypeList;
        public RibbonPage DefaultPage => rpContainersTypeList;


        #endregion

        public ContainersTypeListForm()
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

				_containersType = null;
		        _containersType = _containerTypeRepository.SelectContainersType();

		        _mainContainerTypeList = null;
		        _mainContainerTypeList = _mainContainerTypeRepository.SelectMainContainersType();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }

        private void WireUpBindings()
        {
	        gcContainerTypeList.DataSource = null;
	        gcContainerTypeList.DataSource = _containersType;

	        repMainContainerTypeList.DataSource = null;
	        repMainContainerTypeList.DataSource = _mainContainerTypeList;
        }

        private void ApplyDefaults()
        {
	        LayoutsStyle.LoadLayoutGrid(gvContainerTypeList, CurrentUser.UserName);
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

		private void RcvUpdatedContainerType(object sender, EventArgs e)
        {
            if (sender == null) return;
            //InitializeBindings();
            gvContainerTypeList.UpdateCurrentRow();
        }

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ContainerTypeForm frm = new ContainerTypeForm(new ContainerTypeModel());
            frm.SendUpdatedContainerType += RcvUpdatedContainerType;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ContainerTypeForm frm = new ContainerTypeForm(_containerType);
            frm.SendUpdatedContainerType += RcvUpdatedContainerType;
            frm.ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Print
            ContainerDetailForm frm = new ContainerDetailForm(_containerType);
            frm.ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
	        if (!CanDelete()) return;

			if (_containerType.Id <= 0) return;

            try
            {
                if (XtraMessageBox.Show($"Are you sure you want to delete Container Type: `{_containerType.Description}`?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
					//delete record
					_containerTypeRepository.DeleteContainerType(_containerType.Id);
                    RcvUpdatedContainerType(_containerType, EventArgs.Empty);
                }

            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "User delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CanDelete()
        {
	        ContainerTypeModel dataBoundItem = gvContainerTypeList.GetFocusedRow() as ContainerTypeModel;

	        if (gvContainerTypeList == null || gvContainerTypeList.SelectedRowsCount == 0) return false;
	        if (gvContainerTypeList.SelectedRowsCount > 1)
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
		        LayoutsStyle.ResetLayoutGrid(gvContainerTypeList, CurrentUser.UserName);
	        }
		}

        private void ContainersTypeListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
	        if (!_resetMenu)
	        {
		        LayoutsStyle.SaveLayoutGrid(gvContainerTypeList, CurrentUser.UserName);
	        }
        }

		private void gcContainerTypeList_DoubleClick(object sender, EventArgs e)
        {
	        if (!_isAdmin && !_canEdit) return;

			if (_containerType == null) return;

			int currentRowId = (int)gvContainerTypeList.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_containerType = _containersType.SingleOrDefault(x => x.Id == currentRowId);
			if (_containerType == null) return;

			var containerTypeForm = new ContainerTypeForm(_containerType);
            containerTypeForm.SendUpdatedContainerType += RcvUpdatedContainerType;
            containerTypeForm.ShowDialog();
        }

		private void gvContainerTypeList_RowCellStyle(object sender, RowCellStyleEventArgs e)
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

	}
}