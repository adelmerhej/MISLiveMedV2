using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Data.Filtering;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using MISLiveMed.DataLayers.Accounting.Payments;
using MISLiveMed.DataLayers.Common.Currencies;
using MISLiveMed.DataLayers.Common.Departments;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM;
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.JobData.Quotations;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting;
using MISLiveMed.Models.Models.Accounting.Payments;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.Members;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Reports.Accounting;
using MISLiveMed.Models.Models.Reports.Profit;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Reports;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.DateTimeUtils;
using MISLiveMed.Utils.Enums;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Accounting.Payments
{
    public partial class PaymentsListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "PaymentsList";
		private int _formId;
		private bool _resetMenu;

		private PaymentModel _paymentModel = new PaymentModel();
        private IList<PaymentDetailModel> _paymentDetails = new List<PaymentDetailModel>();
        private IList<PaymentModel> _payments = new List<PaymentModel>();
        private IList<PaymentTypeModel> _paymentsType = new List<PaymentTypeModel>();
        private IList<DepartmentModel> _departments = new List<DepartmentModel>();
        private IList<MembersTypeModel> _membersType = new List<MembersTypeModel>();
        private IList<CustomerModel> _customers = new List<CustomerModel>();
        private IList<AgentModel> _agents = new List<AgentModel>();
        private IList<CurrencyModel> _currencies = new List<CurrencyModel>();

        private readonly PaymentRepository _paymentRepository = new PaymentRepository();
        private readonly PaymentDetailRepository _paymentDetailRepository = new PaymentDetailRepository();
        private readonly PaymentTypeRepository _paymentTypeRepository = new PaymentTypeRepository();
        private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();
        private readonly MemberTypeRepository _memberTypeRepository = new MemberTypeRepository();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly AgentRepository _agentRepository = new AgentRepository();
        private readonly CurrencyRepository _currencyRepository = new CurrencyRepository();

        private IList<TotalProfitReportModel> _dataReportModels = new List<TotalProfitReportModel>();

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

		private decimal _customSumLl = 0;
        private decimal _customSumUsd = 0;
        private decimal _paidAmount = 0;
        private decimal _remainingAmount = 0;

        private string _statusFilter = "All";

        StringBuilder _returnValue = new StringBuilder();

        #region Implementation of IFormWithRibbon

        public RibbonControl MainRibbon => rcPaymentsList;
        public RibbonPage DefaultPage => rpPaymentsList;


		#endregion

		public PaymentsListForm()
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

				_payments = _paymentRepository.SelectPayments(EnumPaymentType.PaymentVoucher);
				_paymentDetails = _paymentDetailRepository.SelectPaymentsDetails();
				_paymentsType = _paymentTypeRepository.SelectPaymentsType();
				_departments = _departmentRepository.SelectDepartments();
				_membersType = _memberTypeRepository.SelectMembersType();
				_customers = _customerRepository.SelectCustomers();
				_agents = _agentRepository.SelectAgents();
				_currencies = _currencyRepository.SelectCurrencies();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
        {
            bsPayments.DataSource = _payments;

            gcPayments.DataSource = null;
            gcPayments.DataSource = bsPayments;

            repPaymentsType.DataSource = null;
            repPaymentsType.DataSource = _paymentsType;

            repDepartments.DataSource = null;
            repDepartments.DataSource = _departments;

            repFilterDepartments.DataSource = null;
            repFilterDepartments.DataSource = _departments;

            repMembersType.DataSource = null;
            repMembersType.DataSource = _membersType;

            repCurrencies.DataSource = null;
            repCurrencies.DataSource = _currencies;

            repAgents.DataSource = null;
            repAgents.DataSource = _agents;

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
		}

        private void ApplyDefaults()
        {
            dtDateFrom.EditValue = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            dtDateTo.EditValue = DateTime.Now;

            LayoutsStyle.LoadLayoutGrid(gvPayments, CurrentUser.UserName);
        }

        #region Buttons Event

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            PaymentDetailForm frm = new PaymentDetailForm(new PaymentModel());
            frm.SendUpdatedPayment += RcvUpdatedPayment;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!_payments.Any()) return;

            int currentRowId = (int)gvPayments.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _paymentModel = _payments.SingleOrDefault(x => x.Id == currentRowId);
            if (_paymentModel == null) return;

            var frm = new PaymentDetailForm(_paymentModel);
            frm.SendUpdatedPayment += RcvUpdatedPayment;
            frm.ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Prepare Parameters
            var dateFrom = (DateTime)dtDateFrom.EditValue;
            var dateTo = (DateTime)dtDateTo.EditValue;
            var filterBy = FilterBy();

            IList<PaymentReportModel> currentView = GetFilteredDataGrid();

            IList<PaymentReportModel> dataReportModels = currentView;

            var previewForm = new DocumentViewerForm();
            //var report = new PaymentReport();

            //report.DataSource = dataReportModels;

            //report.Parameters["pFilterStatus"].Value = filterBy.Replace("show", "").ToString();
            //report.Parameters["DateFrom"].Value = dtDateFrom.EditValue;
            //report.Parameters["DateTo"].Value = dtDateTo.EditValue;

            //previewForm.Viewer.DocumentSource = report;
            //previewForm.ShowDialog();
        }

        private void btnPrintFilter_ItemClick(object sender, ItemClickEventArgs e)
        {

            // Prepare Parameters
            var dateFrom = (DateTime)dtDateFrom.EditValue;
            var dateTo = (DateTime)dtDateTo.EditValue;
            var filterBy = FilterBy();
            var sortBy = SortBy();

            int departmentId = 0;
            if (cboFilterDepartments.EditValue != null)
            {
                _ = int.TryParse(cboFilterDepartments.EditValue.ToString(), out departmentId);
            }

            List<PaymentReportModel> dataReportModels =
                (List<PaymentReportModel>)QuotationDal.PaymentReportList(dateFrom, dateTo, filterBy.ToString(), departmentId, sortBy);

            var previewForm = new DocumentViewerForm();
            //var report = new PaymentReport();

            //report.DataSource = dataReportModels;

            //report.Parameters["pFilterStatus"].Value = filterBy.Replace("show", "").ToString();
            //report.Parameters["DateFrom"].Value = dtDateFrom.EditValue;
            //report.Parameters["DateTo"].Value = dtDateTo.EditValue;

            //previewForm.Viewer.DocumentSource = report;
            //previewForm.ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CanDelete()) return;

            try
            {
                int.TryParse(gvPayments.GetFocusedRowCellValue("Id").ToString(), out int id);
                string name = gvPayments.GetFocusedRowCellValue("Id").ToString();

                if (id > 0)
                {
                    if (XtraMessageBox.Show($"Are you sure you want to delete Payment: `{name}`?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        _paymentModel = gvPayments.GetFocusedRow() as PaymentModel;
                        if (_paymentModel == null)
                        {
                            return;
                        }

                        _paymentModel.Deleted = true;

                        //delete the record
                        if (!_paymentRepository.DeletePayment(id))
                        {
                            throw new Exception(
                                "Error while deleting, please try again or contact your system administrator.");
                        }

                        RcvUpdatedPayment(_paymentModel, EventArgs.Empty);
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
            AboutForm frm = new AboutForm();
            frm.ShowDialog();
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

		#endregion

		private void gcPayments_DoubleClick(object sender, EventArgs e)
		{
			if (!_isAdmin && !_canEdit) return;

			if (!_payments.Any()) return;

			int currentRowId = (int)gvPayments.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_paymentModel = _payments.SingleOrDefault(x => x.Id == currentRowId);
			if (_paymentModel == null) return;

			//_paymentModel.PaymentDetails = _paymentDetailRepository.SelectPaymentDetailByPaymentId(currentRowId);

			var frm = new PaymentDetailForm(_paymentModel);
			frm.SendUpdatedPayment += RcvUpdatedPayment;
			frm.ShowDialog();
		}

		#region EventHandler section

		private void RcvUpdatedPayment(object sender, EventArgs e)
        {
            if (sender == null) return;
            _paymentModel = sender as PaymentModel;

            if (_paymentModel != null && (_paymentModel.LastModifiedDate == null || _paymentModel.Deleted))
            {
                InitializeBindings();
                WireUpBindings();
            }
            else
            {
                gvPayments.UpdateCurrentRow();
            }
        }

        #endregion

        private bool CanDelete()
        {
            CountryModel dataBoundItem = gvPayments.GetFocusedRow() as CountryModel;

            if (gvPayments == null || gvPayments.SelectedRowsCount == 0) return false;
            if (gvPayments.SelectedRowsCount > 1)
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

        private void gvPayments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (e.Column.FieldName == "Vat")
            //{
            //    SetVatRate(sender, e);
            //    SetVatAmount(sender, e);
            //    SetVatRateNotification(sender, e);
            //}
        }

        private void gvPaymentDetails_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            var summaryId = Convert.ToInt32((e.Item as GridSummaryItem).Tag);
            var View = sender as GridView;

            // Initialization 
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                _customSumLl = 0;
                _customSumUsd = 0;
                _paidAmount = 0;
                _remainingAmount = 0;
            }

            // Calculation 
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
                switch (summaryId)
                {
                    case 1: //LAmount field
                        _customSumLl += Convert.ToDecimal(e.FieldValue);
                        break;

                    case 2:
                        _customSumUsd += Convert.ToDecimal(e.FieldValue);
                        break;

                    case 3:
                        _paidAmount += Convert.ToDecimal(e.FieldValue);
                        break;

                    case 4:
                        _remainingAmount += Convert.ToDecimal(e.FieldValue);
                        break;
                }

            // Finalization 
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
                switch (summaryId)
                {
                    case 1:
                        e.TotalValue = _customSumLl;
                        break;


                    case 2:
                        e.TotalValue = _customSumUsd;
                        break;

                    case 3:
                        e.TotalValue = _paidAmount;
                        break;

                    case 4:
                        e.TotalValue = _remainingAmount;
                        break;
                }
        }

        private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                DialogResult.Yes)
            {
                _resetMenu = true;
                LayoutsStyle.ResetLayoutGrid(gvPayments, CurrentUser.UserName);
            }
        }
        private void btnResetGridStyle_ItemClick_1(object sender, ItemClickEventArgs e)
        {
	        if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
		            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
	            DialogResult.Yes)
	        {
		        _resetMenu = true;
		        LayoutsStyle.ResetLayoutGrid(gvPayments, CurrentUser.UserName);
	        }
        }

		private void PaymentsListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_resetMenu)
            {
                LayoutsStyle.SaveLayoutGrid(gvPayments, CurrentUser.UserName);
            }
        }

        private void gvPayments_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool posted = (bool)view.GetRowCellValue(e.RowHandle, "Posted");
                bool approved = (bool)view.GetRowCellValue(e.RowHandle, "Approved");
                bool paid = (bool)view.GetRowCellValue(e.RowHandle, "Paid");

                var totalAmount = (decimal)view.GetRowCellValue(e.RowHandle, "Amount");
                var amountPaid = (decimal)view.GetRowCellValue(e.RowHandle, "PaidAmount");

                decimal remainingAmount = (decimal)view.GetRowCellValue(e.RowHandle, "RemainingAmount");

                if (posted)
                {
                    e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
                }

                if (approved && !paid && remainingAmount == totalAmount)
                {
                    e.Appearance.ForeColor = Color.White;
                    e.Appearance.BackColor = Color.LightGreen;
                }

                if (remainingAmount > 0 && remainingAmount < totalAmount && approved && !paid)
                {
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
                }

                if (paid && remainingAmount == 0)
                {
                    e.Appearance.ForeColor = Color.Blue;
                    e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Regular);
                }
            }

        }
        private void gvPayments_CustomRowFilter(object sender, RowFilterEventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                var dataView = view.DataSource;
                BindingSource bindingSource = (view.DataSource as BindingSource);
                if (bindingSource != null)
                {
                    var dataRowView = bindingSource[e.ListSourceRow] as PaymentModel;
                    if (dataRowView.Paid)
                    {
                        //e.Visible = false;
                        //e.Handled = true;
                    }
                }
            }
        }
        private int SortBy()
        {
            int retValue = 0;

            GalleryItem itemValueDate = rgDateFilter.Gallery.GetItemByValue("ValueDate");
            GalleryItem itemPostingDate = rgDateFilter.Gallery.GetItemByValue("PostingDate");
            GalleryItem itemTransactionDate = rgDateFilter.Gallery.GetItemByValue("TransactionDate");

            if (rgDateFilter.Gallery != null)
            {
                if (itemValueDate.Checked)
                {
                    retValue = 0;
                }

                if (itemPostingDate.Checked)
                {
                    retValue = 1;
                }

                if (itemTransactionDate.Checked)
                {
                    retValue = 2;
                }
            }

            return retValue;
        }

        private void GridFilterBy()
        {
            ColumnView view = gvPayments;
            view.ActiveFilter.Clear();

            var gvFilters = new List<CriteriaOperator>();
            view.ActiveFilterCriteria = CriteriaOperator.Or(gvFilters);

            GalleryItem itemPendingInvoices = rgFilterReports.Gallery.GetItemByValue("showPendingInvoices");
            GalleryItem itemPaidInvoices = rgFilterReports.Gallery.GetItemByValue("showPaidInvoices");
            GalleryItem itemPendingCosts = rgFilterReports.Gallery.GetItemByValue("showPendingCosts");
            GalleryItem itemsPaidCosts = rgFilterReports.Gallery.GetItemByValue("showPaidCosts");
            GalleryItem itemsAll = rgFilterReports.Gallery.GetItemByValue("showAll");

            if (rgFilterReports.Gallery != null)
            {
                if (itemPendingInvoices.Checked)
                {
                    gvFilters.Add(new ColumnFilterInfo(column: colPaymentTypeId, "1").FilterCriteria);
                    gvFilters.Add(new ColumnFilterInfo(column: colPaid, "False").FilterCriteria);
                }

                if (itemPaidInvoices.Checked)
                {
                    gvFilters.Add(new ColumnFilterInfo(column: colPaymentTypeId, "1").FilterCriteria);
                    gvFilters.Add(new ColumnFilterInfo(column: colPaid, "True").FilterCriteria);
                }

                if (itemPendingCosts.Checked)
                {
                    gvFilters.Add(new ColumnFilterInfo(column: colPaymentTypeId, "3").FilterCriteria);
                    gvFilters.Add(new ColumnFilterInfo(column: colPaid, "False").FilterCriteria);
                }

                if (itemsPaidCosts.Checked)
                {
                    gvFilters.Add(new ColumnFilterInfo(column: colPaymentTypeId, "3").FilterCriteria);
                    gvFilters.Add(new ColumnFilterInfo(column: colPaid, "True").FilterCriteria);
                }

                if (!itemsAll.Checked && !itemPendingInvoices.Checked && !itemPaidInvoices.Checked &&
                    !itemPendingCosts.Checked && !itemsPaidCosts.Checked)
                {
                    view.ActiveFilter.Clear();
                }
                view.ActiveFilterCriteria = CriteriaOperator.And(gvFilters.Select(o => o));
            }

        }

        private StringBuilder FilterBy()
        {
            _returnValue = new StringBuilder();

            GalleryItem itemPendingInvoices = rgFilterReports.Gallery.GetItemByValue("showPendingInvoices");
            GalleryItem itemPaidInvoices = rgFilterReports.Gallery.GetItemByValue("showPaidInvoices");
            GalleryItem itemPendingCosts = rgFilterReports.Gallery.GetItemByValue("showPendingCosts");
            GalleryItem itemsPaidCosts = rgFilterReports.Gallery.GetItemByValue("showPaidCosts");
            GalleryItem itemsAll = rgFilterReports.Gallery.GetItemByValue("showAll");

            if (rgFilterReports.Gallery != null)
            {
                if (itemPendingInvoices.Checked)
                {
                    _returnValue = _returnValue.Append(itemPendingInvoices.Value.ToString());
                }

                if (itemPaidInvoices.Checked)
                {
                    _returnValue = _returnValue.Append(itemPaidInvoices.Value.ToString());
                }

                if (itemPendingCosts.Checked)
                {
                    _returnValue = _returnValue.Append(itemPendingCosts.Value.ToString());
                }

                if (itemsPaidCosts.Checked)
                {
                    _returnValue = _returnValue.Append(itemsPaidCosts.Value.ToString());
                }

                if (itemsAll.Checked)
                {
                    _returnValue = _returnValue.Append(itemsAll.Value.ToString());
                }
            }

            return _returnValue;
        }

        private IList<PaymentReportModel> GetFilteredDataGrid()
        {
            IList<PaymentReportModel> result = new List<PaymentReportModel>();
            try
            {
                int pendingTime = 0; // the delay is 1 second (1000 ms)
                SplashScreenManager.ShowForm(null, typeof(WaitForm1), true, true, true, pendingTime);

                GridView view = gvPayments;

                for (int i = 0; i < view.RowCount; i++)
                {
                    PaymentModel pay = view.GetRow(i) as PaymentModel;

                    result.Add(new PaymentReportModel
                    {
                        PaymentDate = pay.PaymentDate,
                        PostingDate = pay.PostingDate,
                        ValueDate = pay.ValueDate,
                        JobNo = pay.JobId,
                        DepartmentName = _departmentRepository.SelectDepartmentById(pay.DepartmentId).DepartmentName,
                        JobReference = pay.ReferenceId,
                        AgentName = _agentRepository.SelectAgentById(pay.MemberId).AgentName,
                        CustomerName = _customerRepository.SelectCustomerById(pay.CustomerId).CustomerName,
                        CurrencyCode = _currencyRepository.SelectCurrencyById(pay.CurrencyId).CurrencyCode,
                        Rate = pay.Rate,
                        Amount = pay.Amount,
                        LAmount = pay.LAmount,
                        FAmount = pay.FAmount
                    });
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }

            return result;
        }
	}
}