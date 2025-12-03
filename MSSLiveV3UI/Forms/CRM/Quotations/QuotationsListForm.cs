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
using DevExpress.XtraSplashScreen;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Countries.Ports;
using MISLiveMed.DataLayers.Common.Departments;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.CRM.Quotations;
using MISLiveMed.DataLayers.JobData.Quotations;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries.Ports;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.JobModels.Quotations;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.Jobs.Quotations;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Reports;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.CRM.Quotations
{
    public partial class QuotationsListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "QuotationsList";
		private int _formId;
		private bool _resetMenu;

		private QuotationModel _quotationModel = new QuotationModel();
        private IList<QuotationModel> _quotationModels = new List<QuotationModel>();
        private IList<QuotationModel> _dataReportModels = new List<QuotationModel>();

        private IList<DepartmentModel> _departments = new List<DepartmentModel>();
        private IList<CustomerModel> _customers = new List<CustomerModel>();
        private IList<UserModel> _users = new List<UserModel>();
        private IList<UserModel> _sales = new List<UserModel>();

        private IList<PortModel> _ports = new List<PortModel>();
        private IList<AgentModel> _agentsList = new List<AgentModel>();
        private IList<AgentModel> _seaCarrierList = new List<AgentModel>();

        private readonly QuotationRepository _quotationRepository = new QuotationRepository();
        private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly UserRepository _userRepository = new UserRepository();
        private readonly PortRepository _portRepository = new PortRepository();
        private readonly AgentRepository _agentRepository = new AgentRepository();
        private readonly CityRepository _cityRepository = new CityRepository();

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

		private string _sortingBy = "Ascending";
        private int? _departmentFilter = 0;
        private int? _salesFilter = 0;
        private EnumStatusType _statusFilter = EnumStatusType.NotSelected;
        private bool _isBooked = false;
        private bool _isCancelled = false;
        private bool _isLost = false;
        private bool _isAll = false;

        #region Implementation of IFormWithRibbon

        public RibbonControl MainRibbon => rcQuotationList;
        public RibbonPage DefaultPage => rpQuotationList;


        #endregion

        public QuotationsListForm()
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

				_quotationModels = _quotationRepository.SelectQuotations(_isProtected);
				_departments = _departmentRepository.SelectDepartments(_isProtected);
				_customers = _customerRepository.SelectCustomers(_isProtected);
				_users = _userRepository.SelectUsers(_isProtected);
				_sales = _userRepository.SelectUsersAsSales(_isProtected);
				_ports = _portRepository.SelectPorts(PortType.Seaport);
				_agentsList = _agentRepository.SelectAgents(_isProtected);
				_seaCarrierList = _agentRepository.SelectAgents().Where(x => (x.AgentCategoryId == 3 || x.AgentCategoryId == 4) 
				                                                             && (_isProtected || x.IsProtected == _isProtected)).ToList();

				repStatusList.DataSource = Enum.GetValues(typeof(EnumStatusType));
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {
            bsQuotations.DataSource = _quotationModels;

            gcQuotations.DataSource = null;
            gcQuotations.DataSource = bsQuotations;

            repDepartmentsList.DataSource = null;
            repDepartmentsList.DataSource = _departments;

            repDepartments.DataSource = null;
            repDepartments.DataSource = _departments;

            repCustomers.DataSource = null;
            repCustomers.DataSource = _customers;

            repUsersList.DataSource = null;
            repUsersList.DataSource = _users;

            repFilterBySalesList.DataSource = null;
            repFilterBySalesList.DataSource = _sales;

            repSalesList.DataSource = null;
            repSalesList.DataSource = _sales;

            gcQuotations.DataSource = null;
            gcQuotations.DataSource = _quotationModels;

            repPOLList.DataSource = null;
            repPOLList.DataSource = _ports;

            repPODList.DataSource = null;
            repPODList.DataSource = _ports;

            repAgents.DataSource = null;
            repAgents.DataSource = _agentsList;

            repSeaCarriers.DataSource = null;
            repSeaCarriers.DataSource = _seaCarrierList;
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

			chkShowProfit.Visibility = _isAdmin ? BarItemVisibility.Always : BarItemVisibility.Never;
	        rpgPermissions.Visible = _isAdmin;
	        chkShowProfit.Checked = _isAdmin;
	        gvQuotations.Columns["TotalProfit"].Visible = _isAdmin;
		}

        private void ApplyDefaults()
        {
            LayoutsStyle.LoadLayoutGrid(gvQuotations, CurrentUser.UserName, CurrentUser.CompanyName);

            rgFilterReports.Gallery.GetItemByValue("showRequested").Checked = false;
            rgFilterReports.Gallery.GetItemByValue("showQuoted").Checked = false;
            rgFilterReports.Gallery.GetItemByValue("showBooked").Checked = false;
            rgFilterReports.Gallery.GetItemByValue("showLost").Checked = false;
            rgFilterReports.Gallery.GetItemByValue("showCancelled").Checked = false;
            rgFilterReports.Gallery.GetItemByValue("showAll").Checked = false;
            rgFilterReports.Gallery.GetItemByValue("showUrgent").Checked = false;

            rgSortByReports.Gallery.GetItemByValue("SortByFollowingDate").Checked = true;
            gvQuotations.Columns["FollowupDate"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            //Apply default filter
            gvQuotations.ActiveFilter.Clear();
            ColumnView view = gvQuotations;
            view.ActiveFilter.Add(view.Columns["Status"],
                new ColumnFilterInfo("[Status] = 'Requested' OR [Status] = 'Quoted'", "Quoted & Requested = True"));
        }
        
        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuotationEditForm frm = new QuotationEditForm(new QuotationModel());
            frm.SendUpdatedQuotation += RcvUpdatedQuotation;
            frm.ShowDialog();
        }

        private void gcQuotation_DoubleClick(object sender, EventArgs e)
        {
	        if (!_isAdmin && !_canEdit) return;

			if (_quotationModels == null) return;

            int currentRowId = (int)gvQuotations.GetFocusedRowCellValue("Id");
            _quotationModel = _quotationModels.SingleOrDefault(x => x.Id == currentRowId);

            var quotationForm = new QuotationEditForm(_quotationModel);
            quotationForm.SendUpdatedQuotation += RcvUpdatedQuotation;
            quotationForm.ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                int pendingTime = 0;
                SplashScreenManager.ShowForm(null, typeof(WaitForm1), true, true, true, pendingTime);

                InitializeBindings();
                WireUpBindings();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void RcvUpdatedQuotation(object sender, EventArgs e)
        {
            if (sender == null) return;
            //InitializeBindings();
            gvQuotations.UpdateCurrentRow();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_quotationModels == null) return;

            int currentRowId = (int)gvQuotations.GetFocusedRowCellValue("Id");
            _quotationModel = _quotationModels.SingleOrDefault(x => x.Id == currentRowId);

            var quotationForm = new QuotationEditForm(_quotationModel);
            quotationForm.SendUpdatedQuotation += RcvUpdatedQuotation;
            quotationForm.ShowDialog();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            //TODO: working on filters
            int[] selectList = GetCurrentView();
            List<QuotationReportModel> dataReportModels =
                (List<QuotationReportModel>)QuotationDal.GetQuotationsReport(_departmentFilter, _salesFilter, _statusFilter);

            var previewForm = new DocumentViewerForm();
            var report = new QotationsListReport();

            report.DataSource = dataReportModels;

            report.Parameters["isAdmin"].Value = CurrentUser.UserId == 30 && chkShowProfit.Checked;

            previewForm.Viewer.DocumentSource = report;
            previewForm.ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_quotationModel.Id <= 0) return;

            try
            {
                if (XtraMessageBox.Show($"Are you sure you want to delete XONO: `{_quotationModel.FullReferenceNo()}`?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //delete record
                    QuotationDal.DeleteQuotation(_quotationModel.Id);
                    RcvUpdatedQuotation(_quotationModel, EventArgs.Empty);
                }

            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "User delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int[] GetCurrentView()
        {
            GridView view = gvQuotations;
            int[] selectedList = new int[gvQuotations.DataRowCount];
            for (int i = 0; i < gvQuotations.DataRowCount; i++)
            {
                if (view?.GetRow(i) is QuotationModel quotation)
                    selectedList[i] = quotation.Id;
            }

            return selectedList;
        }

        private void cboDepartments_EditValueChanged(object sender, EventArgs e)
        {
            _departmentFilter = (int?)cboDepartments.EditValue;
            GridFilterBy();
        }

        private void cboSalesList_EditValueChanged(object sender, EventArgs e)
        {
            _salesFilter = (int?)cboSales.EditValue;
            GridFilterBy();
        }

        private void cboStatus_EditValueChanged(object sender, EventArgs e)
        {
            _statusFilter = cboStatus.EditValue != null
                ? (EnumStatusType)cboStatus.EditValue
                : EnumStatusType.NotSelected;

            GridFilterBy();
        }

        private void chkShowProfit_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            gvQuotations.Columns["TotalProfit"].Visible = chkShowProfit.Checked;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcQuotations.ShowRibbonPrintPreview();
        }

        #region Grid Filter/Sorting Event

        private void rgFilterReports_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            GridFilterBy();
        }

        private void GridFilterBy()
        {
            ColumnView view = gvQuotations;
            view.ActiveFilter.Clear();

            GalleryItem itemIsRequested = rgFilterReports.Gallery.GetItemByValue("showRequested");
            GalleryItem itemIsQuoted = rgFilterReports.Gallery.GetItemByValue("showQuoted");
            GalleryItem itemIsBooked = rgFilterReports.Gallery.GetItemByValue("showBooked");
            GalleryItem itemIsLost = rgFilterReports.Gallery.GetItemByValue("showLost");
            GalleryItem itemIsCancelled = rgFilterReports.Gallery.GetItemByValue("showCancelled");
            GalleryItem itemIsAll = rgFilterReports.Gallery.GetItemByValue("showAll");
            GalleryItem itemIsUrgent = rgFilterReports.Gallery.GetItemByValue("showUrgent");

            if (_departmentFilter != null && cboDepartments.Edit.GetDisplayText(cboDepartments.EditValue) != "")
            {
                view.ActiveFilter.Add(view.Columns["DepartmentId"],
                    new ColumnFilterInfo(
                        $"[DepartmentId] = '{cboDepartments.EditValue}'",
                        $"Department = {cboDepartments.Edit.GetDisplayText(cboDepartments.EditValue)}"));
            }

            if (_salesFilter != null && cboSales.Edit.GetDisplayText(cboSales.EditValue) != "")
            {
                view.ActiveFilter.Add(view.Columns["SalesId"],
                    new ColumnFilterInfo(
                        $"[SalesId] = '{cboSales.EditValue}'",
                        $"Sales = {cboSales.Edit.GetDisplayText(cboSales.EditValue)}"));
            }

            if (cboStatus.Edit.GetDisplayText(cboStatus.EditValue) != "")
            {
                view.ActiveFilter.Add(view.Columns["Status"],
                    new ColumnFilterInfo(
                        $"[Status] = '{cboStatus.EditValue}'",
                        $"Status = {cboStatus.Edit.GetDisplayText(cboStatus.EditValue)}"));
            }

            if (rgFilterReports.Gallery != null)
            {
                if (itemIsRequested.Checked)
                {
                    view.ActiveFilter.Add(view.Columns["Status"],
                        new ColumnFilterInfo("[Status] = 1", "Requested = True"));
                }

                if (itemIsQuoted.Checked)
                {
                    view.ActiveFilter.Add(view.Columns["Status"],
                        new ColumnFilterInfo("[Status] = 0", "Quoted = True"));
                }

                if (itemIsBooked.Checked)
                {
                    view.ActiveFilter.Add(view.Columns["Status"],
                        new ColumnFilterInfo("[Status] = 2", "Booked = True"));
                }

                if (itemIsLost.Checked)
                {
                    view.ActiveFilter.Add(view.Columns["Status"],
                        new ColumnFilterInfo("[Status] = 3", "Lost = True"));
                }

                if (itemIsCancelled.Checked)
                {
                    view.ActiveFilter.Add(view.Columns["Status"],
                        new ColumnFilterInfo("[Status] = 4", "Canceled = True"));
                }

                if (itemIsUrgent.Checked)
                {
                    view.ActiveFilter.Add(view.Columns["Urgent"],
                        new ColumnFilterInfo("[Urgent] = 'True'", "Urgent = True"));
                }

                if (itemIsAll.Checked)
                {
                    view.ActiveFilter.Clear();
                }

                if (!itemIsAll.Checked && !itemIsRequested.Checked && !itemIsQuoted.Checked && !itemIsBooked.Checked && !itemIsLost.Checked && !itemIsCancelled.Checked && !itemIsUrgent.Checked && _statusFilter == EnumStatusType.NotSelected)
                {
                    view.ActiveFilter.Add(view.Columns["Status"],
                        new ColumnFilterInfo("[Status] = 0 OR [Status] = 1", "Quoted & Requested = True"));
                }
            }
            gvQuotations.MoveFirst();
        }

        #endregion


        #region Grid Order by option

        private void rgSortByReports_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            GridSortBy();
        }

        private void ribbonGalleryBarItem1_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            GridSortBy();
        }


        private void GridSortBy()
        {
            GalleryItem sortByFollowingDate = rgSortByReports.Gallery.GetItemByValue("SortByFollowingDate");
            GalleryItem sortByBookedDate = rgSortByReports.Gallery.GetItemByValue("SortByBookedDate");
            GalleryItem sortByQuotationDate = rgSortByReports.Gallery.GetItemByValue("SortByQuotationDate");

            GalleryItem orderByAscending = rgOrderByReports.Gallery.GetItemByValue("Ascending");
            GalleryItem orderByDescending = rgOrderByReports.Gallery.GetItemByValue("Descending");

            gvQuotations.ClearSorting();

            if (rgSortByReports.Gallery != null)
            {
                if (sortByFollowingDate.Checked)
                {
                    gvQuotations.Columns["FollowupDate"].SortOrder = orderByAscending.Checked
                        ? DevExpress.Data.ColumnSortOrder.Ascending
                        : DevExpress.Data.ColumnSortOrder.Descending;
                }
                if (sortByBookedDate.Checked)
                {
                    gvQuotations.Columns["BookedDate"].SortOrder = orderByAscending.Checked
                        ? DevExpress.Data.ColumnSortOrder.Ascending
                        : DevExpress.Data.ColumnSortOrder.Descending;
                }
                if (sortByQuotationDate.Checked)
                {
                    gvQuotations.Columns["QuotationDate"].SortOrder = orderByAscending.Checked
                        ? DevExpress.Data.ColumnSortOrder.Ascending
                        : DevExpress.Data.ColumnSortOrder.Descending;
                }
            }
            gvQuotations.MoveFirst();
        }

        #endregion


        #region Grid Lod/Save Style option

        private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                DialogResult.Yes)
            {
                _resetMenu = true;
                LayoutsStyle.ResetLayoutGrid(gvQuotations, CurrentUser.UserName, CurrentUser.CompanyName);
            }
        }

        private void QuotationsListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_resetMenu)
            {
                LayoutsStyle.SaveLayoutGrid(gvQuotations, CurrentUser.UserName, CurrentUser.CompanyName);
            }
        }

        private void gvQuotation_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
			GridView view = sender as GridView;

			if (e.RowHandle < 0) return;

			bool requestChangeFollowup = false;

			bool isUrgent = (bool)view.GetRowCellValue(e.RowHandle, "Urgent");
			if (isUrgent)
			{
				e.Appearance.ForeColor = Color.Red;
			}

			int status = (int)view.GetRowCellValue(e.RowHandle, "Status");
			var followupValue = view.GetRowCellValue(e.RowHandle, "FollowupDate");

			if (followupValue != null)
			{
				requestChangeFollowup = (DateTime)view.GetRowCellValue(e.RowHandle, "FollowupDate") <= DateTime.Today;
			}

			int _id = (int)view.GetRowCellValue(e.RowHandle, "Id");

			if (requestChangeFollowup && status != 2 && status != 3 && status != 4)
			{
				e.Appearance.BackColor = Color.LightCoral;
				e.Appearance.ForeColor = Color.White;
			}

			if (status == 2)
			{
				//e.Appearance.BackColor = Color.LightGreen;
				e.Appearance.ForeColor = Color.Green;
			}

			if (status == 3)
			{
				e.Appearance.ForeColor = Color.Red;
				e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Strikeout);
			}

			if (status == 4)
			{
				e.Appearance.ForeColor = Color.Gray;
				e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Italic);
			}
		}

		#endregion

	}
}