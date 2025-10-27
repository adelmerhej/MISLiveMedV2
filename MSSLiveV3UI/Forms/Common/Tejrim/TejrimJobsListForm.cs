using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.JobData.SeaImport;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Reports;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.BookingStatus;
using MISLiveMed.UI.Reports;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.Common.Tejrim
{
    public partial class TejrimJobsListForm : RibbonForm, IFormWithRibbon
    {
	    private const string _formName = "TejrimJobsList";
	    private int _formId;
	    private bool _resetMenu;

	    private IList<DataReportModel> _jobsSeaImportList = new List<DataReportModel>();
	    private IList<UserModel> _users = new List<UserModel>();
	    private IList<UserModel> _sales = new List<UserModel>();
	    private IList<CustomerModel> _customers = new List<CustomerModel>();
		
		private readonly JobSeaImportRepository _jobSeaImportRepository = new JobSeaImportRepository();
	    private readonly UserRepository _userRepository = new UserRepository();
	    private readonly CustomerRepository _customerRepository = new CustomerRepository();

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
	    private bool _isLimitedView;

		private int _memberId = 0;
	    private int _userId = 0;
	    private int _salesId = 0;
	    private bool _invoiced = false;
	    private DateTime? _dateFrom;
	    private DateTime? _dateTo;

		#region Implementation of IFormWithRibbon

		public RibbonControl MainRibbon => rcTejrimList;
        public RibbonPage DefaultPage => rpTejrimList;


		#endregion

		public TejrimJobsListForm()
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
			{               //
				_formId = _formRepository.SelectFormByName(_formName);
				_userPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, _formId);
				if (_userPermission != null && _userPermission.Count > 0)
				{
					var isProtected = _userPermission.SingleOrDefault(x => x.ControlName == "IsProtected")?.Value;
					if (isProtected != null) _isProtected = (bool)isProtected;

					var isLimitedView = _userPermission.SingleOrDefault(x => x.ControlName == "IsLimitedView")?.Value;
					if (isLimitedView != null) _isLimitedView = (bool)isLimitedView;
				}
				//

				_jobsSeaImportList = null;
				_jobsSeaImportList = _jobSeaImportRepository.GetClosedBookingList();
				_users = _userRepository.SelectUsers();
				_sales = _userRepository.SelectUsersAsSales();
				_customers = _customerRepository.SelectCustomers();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		private void WireUpBindings()
		{
			repUsers.DataSource = null;
			repUsers.DataSource = _users;

			repSales.DataSource = null;
			repSales.DataSource = _sales;

			repCustomers.DataSource = null;
			repCustomers.DataSource = _customers;

			gcTejrimList.DataSource = _jobsSeaImportList;
			gvTejrimList.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
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
			LayoutsStyle.LoadLayoutGrid(gvTejrimList, CurrentUser.UserName);
		}

		private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }


        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            var previewForm = new DocumentViewerForm();

            //_dataReportModels =
            //    (List<DataReportModel>)ReportsDataAccess.GetClosedBookingList(_dateFrom, _dateTo, _startingRefNo, _memberId, _userId, _invoiced);

            var report = new ClosedJobReport();
            report.DataSource = _jobsSeaImportList;

            //Add parameters

            report.Parameters["pDateFrom"].Value = _dateFrom;
            report.Parameters["pDateTo"].Value = _dateTo;

            previewForm.Viewer.DocumentSource = report;
            previewForm.ShowDialog();
        }

        private void dtFrom_EditValueChanged(object sender, EventArgs e)
        {
            if (dtFrom.EditValue != null)
            {
                _dateFrom = (DateTime)dtFrom.EditValue;
            }
            else
            {
                _dateFrom = null;
            }

            RefreshDataGrid();
        }

        private void dtTo_EditValueChanged(object sender, EventArgs e)
        {
            if (dtTo.EditValue != null)
            {
                _dateTo = (DateTime)dtTo.EditValue;
            }
            else
            {
                _dateTo = null;
            }

            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
	        try
	        {
		        _jobsSeaImportList = _jobSeaImportRepository.GetClosedBookingList(_dateFrom, _dateTo, _memberId, _userId, _salesId, _invoiced);
		        gcTejrimList.DataSource = null;
		        gcTejrimList.DataSource = _jobsSeaImportList;

	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Data Error",
			        MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
	        
		}

        private void TejrimListForm_Load(object sender, EventArgs e)
        {
            DateTime defaultDate = DateTime.Now;
            var firstDayOfMonth = new DateTime(defaultDate.Year, defaultDate.Month, 1);
            var lastMonth = firstDayOfMonth.AddMonths(-1);

            dtFrom.EditValue = lastMonth;
            dtTo.EditValue = defaultDate;
        }

        private void btnPrintAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvTejrimList.ShowRibbonPrintPreview();
        }

        private void gvTejrimList_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Invoiced")
            {
                try
                {
                    ToggleInvoicedValue(sender, e);
                }
                catch (Exception exception)
                {
                    XtraMessageBox.Show(exception.Message, @"Currency Conversion Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ToggleInvoicedValue(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.Columns != null)
            {
                try
                {
                    _ = int.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["JobNo"]).ToString(), out int jobNo);
                    _ = bool.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Invoiced"]).ToString(), out bool invoiced);

                    JobSeaImportDal.UpdateInvoicedTejrim(jobNo, invoiced);
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }

        private void barCheckInvoiced_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            _invoiced = barCheckInvoiced.Checked;
            RefreshDataGrid();
        }

        private void gvTejrimList_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
	            bool isInvoiceId = false; //view != null && (bool)view.GetRowCellValue(e.RowHandle, "InvoiceId");
                if (isInvoiceId)
                {
                    e.Appearance.ForeColor = Color.Green;
                }
            }
        }

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvTejrimList, CurrentUser.UserName);
			}
		}

		private void TejrimListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvTejrimList, CurrentUser.UserName);
			}
		}

		private void cboUsers_EditValueChanged(object sender, EventArgs e)
		{
			_userId = 0;
			if (cboUsers.EditValue != null) _userId = (int)cboUsers.EditValue;
			RefreshDataGrid();
		}

		private void cboSales_EditValueChanged(object sender, EventArgs e)
		{
			_salesId = 0;
			if (cboSales.EditValue != null) _salesId = (int)cboSales.EditValue;
			RefreshDataGrid();
		}

		private void cboMembers_EditValueChanged(object sender, EventArgs e)
		{
			_memberId = 0;
			if (cboMembers.EditValue != null) _memberId = (int)cboMembers.EditValue;
			RefreshDataGrid();
		}
	}
}