using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using MISLiveMed.DataLayers.Accounting.Commissions;
using MISLiveMed.DataLayers.Common.Departments;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.Commissions;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Accounting.Commissions
{
    public partial class CommissionsHistoryListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "CommissionsHistoryList";
		private int _formId;
		private bool _resetMenu;

		private CommissionModel _commissionModel = new CommissionModel();
        private IList<CommissionModel> _commissions = new List<CommissionModel>();
        private IList<CustomerModel> _customers = new List<CustomerModel>();
        private IList<DepartmentModel> _departments = new List<DepartmentModel>();

        private readonly CommissionRepository _commissionRepository = new CommissionRepository();
        private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private UserRepository _userRepository = new UserRepository();

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

		private bool _onlyPaid = false;

        #region Implementation of IFormWithRibbon

        public RibbonControl MainRibbon => rcCommissionHistory;
        public RibbonPage DefaultPage => rpCommissionHistory;


        #endregion

        public CommissionsHistoryListForm()
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

				_commissions = _commissionRepository.SelectCommissions(_onlyPaid);
				_departments = _departmentRepository.SelectDepartments();
				_customers = _customerRepository.SelectCustomers();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {
            bsCommissions.DataSource = _commissions;

            gcCommissions.DataSource = null;
            gcCommissions.DataSource = bsCommissions;

            repDepartments.DataSource = null;
            repDepartments.DataSource = _departments;

            repCustomers.DataSource = null;
            repCustomers.DataSource = _customers;
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
	        btnRecalculateCommissions.Enabled = _isAdmin || _canEdit;
		}

        private void ApplyDefaults()
        {
	        LayoutsStyle.LoadLayoutGrid(gvCommissions, CurrentUser.UserName, CurrentUser.CompanyName);
		}

        #region Buttons Event

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            CommissionsHistoryEditForm frm = new CommissionsHistoryEditForm(new CommissionModel());
            frm.SendUpdatedCommissionsHistory += RcvUpdatedCommissionsHistory;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!_commissions.Any()) return;

            int currentRowId = (int)gvCommissions.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _commissionModel = _commissions.SingleOrDefault(x => x.Id == currentRowId);
            if (_commissionModel == null) return;

            var frm = new CommissionsHistoryEditForm(_commissionModel);
            frm.SendUpdatedCommissionsHistory += RcvUpdatedCommissionsHistory;
            frm.ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcCommissions.ShowRibbonPrintPreview();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CanDelete()) return;

            try
            {
                int.TryParse(gvCommissions.GetFocusedRowCellValue("Id").ToString(), out int id);
                //string name = gvCommissions.GetFocusedRowCellValue("SalesId").ToString();

                if (id > 0)
                {
                    if (XtraMessageBox.Show($"Are you sure you want to delete Record: `{id}`?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        _commissionModel = gvCommissions.GetFocusedRow() as CommissionModel;
                        if (_commissionModel == null)
                        {
                            return;
                        }
                        _commissionModel.Deleted = true;

                        //delete the record
                        _commissionRepository.DeleteCommission(_commissionModel.Id);
                        RcvUpdatedCommissionsHistory(_commissionModel, EventArgs.Empty);
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

        private void btnRecalculateCommissions_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show($"This will take some time, do you wish to continue?",
                        "Re-calculate...", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //Start Re-calculate Process
                    int pendingTime = 0; // the delay is 1 second (1000 ms)
                    SplashScreenManager.ShowForm(null, typeof(WaitForm1), true, true, true, pendingTime);

                    _commissionRepository.ReCalculateCommissions();
                    RcvUpdatedCommissionsHistory(_commissionModel, EventArgs.Empty);
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "Calculate error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }


		#endregion
        private void gcCommissions_DoubleClick(object sender, EventArgs e)
		{
			if (!_isAdmin && !_canEdit) return;

			if (!_commissions.Any()) return;

			int currentRowId = (int)gvCommissions.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_commissionModel = _commissions.SingleOrDefault(x => x.Id == currentRowId);
			if (_commissionModel == null) return;

			var frm = new CommissionsHistoryEditForm(_commissionModel);
			frm.SendUpdatedCommissionsHistory += RcvUpdatedCommissionsHistory;
			frm.ShowDialog();
		}

		private void gvCommissionManager_RowCellStyle(object sender, RowCellStyleEventArgs e)
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
        private bool CanDelete()
        {
            CommissionModel dataBoundItem = gvCommissions.GetFocusedRow() as CommissionModel;

            if (gvCommissions == null || gvCommissions.SelectedRowsCount == 0) return false;
            if (gvCommissions.SelectedRowsCount > 1)
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

        private void RcvUpdatedCommissionsHistory(object sender, EventArgs e)
        {
            if (sender == null) return;
            _commissionModel = sender as CommissionModel;

            if (_commissionModel != null && (_commissionModel.LastModifiedDate == null || _commissionModel.Deleted))
            {
                InitializeBindings();
                WireUpBindings();
            }
            else
            {
                gvCommissions.UpdateCurrentRow();
            }
        }

		#region Grid Events
        private void CommissionsHistoryListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvCommissions, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvCommissions, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		#endregion

	}
}