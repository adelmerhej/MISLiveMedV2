using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Common.Departments;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.Common;
using MISLiveMed.UI.Reports;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.Common.Departments
{
    public partial class DepartmentsListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "DepartmentsList";
		private int _formId;
		private bool _resetMenu;

		private IList<DepartmentModel> _departmentsList = new List<DepartmentModel>();
		private DepartmentModel _department = new DepartmentModel();

		private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();

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

		public RibbonControl MainRibbon => rcDepartmentsList;
        public RibbonPage DefaultPage => rpDepartmentsList;


        #endregion

        public DepartmentsListForm()
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

				_departmentsList = _departmentRepository.SelectDepartments();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

        private void WireUpBindings()
        {
	        gcDepartment.DataSource = null;
	        gcDepartment.DataSource = _departmentsList;
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
	        LayoutsStyle.LoadLayoutGrid(gvDepartment, CurrentUser.UserName);
        }

		#region MenuButtons

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            DepartmentEditForm frm = new DepartmentEditForm(new DepartmentModel());
            frm.SendUpdatedDepartment += RcvUpdatedDepartment;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DepartmentEditForm frm = new DepartmentEditForm(_department);
            frm.SendUpdatedDepartment += RcvUpdatedDepartment;
            frm.ShowDialog();
        }

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
			InitializeBindings();
			WireUpBindings();
		}

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<DepartmentModel> dataReportModels = GetCurrentView();

            var previewForm = new DocumentViewerForm();
            var report = new DepartmentsListReport();

            report.DataSource = dataReportModels;


            previewForm.Viewer.DocumentSource = report;
            previewForm.ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
	        if (!CanDelete()) return;

	        try
	        {
		        int.TryParse(gvDepartment.GetFocusedRowCellValue("Id").ToString(), out int id);
		        string name = gvDepartment.GetFocusedRowCellValue("DepartmentName").ToString();

		        if (id > 0)
		        {
			        if (XtraMessageBox.Show($"Are you sure you want to delete: `{name}`?",
				            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
				            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			        {
				        _department = gvDepartment.GetFocusedRow() as DepartmentModel;
				        if (_department == null)
				        {
					        return;
				        }
				        _department.Deleted = true;

				        //delete the record
				        _departmentRepository.DeleteDepartment(_department.Id);
				        RcvUpdatedDepartment(_department, EventArgs.Empty);
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
		private bool CanDelete()
		{
			DepartmentModel dataBoundItem = gvDepartment.GetFocusedRow() as DepartmentModel;

			if (gvDepartment == null || gvDepartment.SelectedRowsCount == 0) return false;

			if (gvDepartment.SelectedRowsCount > 1)
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
		private void gcDepartment_DoubleClick(object sender, EventArgs e)
        {
	        if (!_isAdmin && !_canEdit) return;

			if (_department == null) return;

            int currentRowId = (int)gvDepartment.GetFocusedRowCellValue("Id");
            _department = _departmentsList.SingleOrDefault(x => x.Id == currentRowId);

            var departmentForm = new DepartmentEditForm(_department);
            departmentForm.SendUpdatedDepartment += RcvUpdatedDepartment;
            departmentForm.ShowDialog();
        }

        private List<DepartmentModel> GetCurrentView()
        {
            GridView view = gvDepartment;
            List<DepartmentModel> dep = new List<DepartmentModel>();
            for (int i = 0; i < gvDepartment.DataRowCount; i++)
            {
                if (view?.GetRow(i) is DepartmentModel department)
                    dep.Add(department);
            }

            return dep;
        }
        private void RcvUpdatedDepartment(object sender, EventArgs e)
        {
	        if (sender == null) return;
	        //InitializeBindings();
	        gvDepartment.UpdateCurrentRow();
        }

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvDepartment, CurrentUser.UserName);
			}
		}

		private void DepartmentsListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvDepartment, CurrentUser.UserName);
			}
		}

	}
}