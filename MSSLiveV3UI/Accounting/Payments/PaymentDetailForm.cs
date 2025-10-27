using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Accounting.Payments;
using MISLiveMed.DataLayers.Common.Currencies;
using MISLiveMed.DataLayers.Common.Departments;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM;
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting;
using MISLiveMed.Models.Models.Accounting.Payments;
using MISLiveMed.Models.Models.Common;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.Members;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Accounting.Payments
{
    public partial class PaymentDetailForm : RibbonForm
	{
		private const string _formName = "PaymentDetail";
		private int _formId;
		private bool _resetMenu;

		private DataEntityState _objState = DataEntityState.Unchanged;

		DXMenuItem[] _menuItems;

        private PaymentModel _paymentModel;
        private IList<PaymentDetailModel> _paymentsDetail = new List<PaymentDetailModel>();
        private IList<PaymentTypeModel> _paymentsType = new List<PaymentTypeModel>();
        private IList<DepartmentModel> _departments = new List<DepartmentModel>();
        private IList<MembersTypeModel> _membersType = new List<MembersTypeModel>();
        private IList<InitDataObjectModel> _customers = new List<InitDataObjectModel>();
        private IList<InitDataObjectModel> _agents = new List<InitDataObjectModel>();
        private IList<CurrencyModel> _currencies = new List<CurrencyModel>();
        private IList<UserModel> _users = new List<UserModel>();

        private readonly PaymentRepository _paymentRepository = new PaymentRepository();
        private readonly PaymentDetailRepository _paymentDetailRepository = new PaymentDetailRepository();
        private readonly PaymentTypeRepository _paymentTypeRepository = new PaymentTypeRepository();
        private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();
        private readonly MemberTypeRepository _memberTypeRepository = new MemberTypeRepository();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly AgentRepository _agentRepository = new AgentRepository();
        private readonly CurrencyRepository _currencyRepository = new CurrencyRepository();
        private readonly UserRepository _userRepository = new UserRepository();
        private readonly CurrencyExchangeRepository _currencyExchangeRepository = new CurrencyExchangeRepository();

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
        private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
        private readonly FormRepository _formRepository = new FormRepository();
        private readonly LogInfoRepository _logInfoRepository = new LogInfoRepository();

        //Init permissionvariables
        private bool _canAdd;
        private bool _canEdit;
        private bool _canDelete;
        private bool _canPrint;
        private bool _canApprove;
        private bool _isAdmin;
        private bool _isProtected;

		public EventHandler SendUpdatedPayment;

        private decimal _maxAmount = 0.00M;

        // Init balances values
        private decimal customSum;
        private decimal customSumLL;
        private decimal customSumUSD;

        private decimal totalBalanceLL;
        private decimal totalBalanceUSD;
        private int oldCurrencyId = 0;

        public PaymentDetailForm(PaymentModel payment)
        {
            InitializeComponent();

            try
            {
				_paymentModel = payment;

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

				_paymentsType = _paymentTypeRepository.SelectPaymentsType();
				_departments = _departmentRepository.SelectDepartments();
				_membersType = _memberTypeRepository.SelectMembersType();
				_customers = _customerRepository.SelectMembers();
				_agents = _agentRepository.SelectMembers();
				_currencies = _currencyRepository.SelectCurrencies();
				_users = _userRepository.SelectUsers();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {
            bsPayment.DataSource = _paymentModel;
            bsPaymentDetails.DataSource = _paymentsDetail;

            gcPaymentsDetail.DataSource = null;
            gcPaymentsDetail.DataSource = bsPaymentDetails;

            cboPaymentTypes.Properties.DataSource = null;
            cboPaymentTypes.Properties.DataSource = _paymentsType;

            cboDepartments.Properties.DataSource = null;
            cboDepartments.Properties.DataSource = _departments;

            cboMemberTypes.Properties.DataSource = null;
            cboMemberTypes.Properties.DataSource = _membersType;

            cboCurrencies.Properties.DataSource = null;
            cboCurrencies.Properties.DataSource = _currencies;

            repPaidByusers.DataSource = null;
            repPaidByusers.DataSource = _users;

            cboMembers.Properties.DataSource = null;
            cboMembers.Properties.ValueMember = "Value";
            cboMembers.Properties.DisplayMember = "Name";
            cboMembers.Properties.DataSource = _agents;

            repTypes.DataSource = null;
            repTypes.DataSource = _paymentsType;

            repCurrencies.DataSource = null;
            repCurrencies.DataSource = _currencies;

            btnApprove.Checked = _paymentModel.Approved;

            if (btnApprove.Checked)
            {
                btnApprove.ItemAppearance.Normal.Font = new Font("Tahoma", 8, FontStyle.Bold);
                btnApprove.ItemAppearance.Normal.ForeColor = Color.Green;
                btnApprove.ItemAppearance.Hovered.Font = new Font("Tahoma", 8, FontStyle.Bold);
                btnApprove.ItemAppearance.Hovered.ForeColor = Color.Green;
                btnApprove.ItemAppearance.Pressed.Font = new Font("Tahoma", 8, FontStyle.Bold);
                btnApprove.ItemAppearance.Pressed.ForeColor = Color.Green;
                btnApprove.Caption = @"Approved";
                msgBarText.Caption = _paymentModel.Approved ? @"Approval Granted!" : "Waiting Approval...";
                msgBarText.ItemAppearance.Normal.ForeColor = Color.Green;
            }
            else
            {
                btnApprove.ItemAppearance.Normal.Font = new Font("Tahoma", 8, FontStyle.Regular);
                btnApprove.ItemAppearance.Normal.ForeColor = Color.Black;
                btnApprove.ItemAppearance.Hovered.Font = new Font("Tahoma", 8, FontStyle.Regular);
                btnApprove.ItemAppearance.Hovered.ForeColor = Color.Black;
                btnApprove.ItemAppearance.Pressed.Font = new Font("Tahoma", 8, FontStyle.Regular);
                btnApprove.ItemAppearance.Pressed.ForeColor = Color.Black;
                btnApprove.Caption = @"Approve";
                msgBarText.Caption = _paymentModel.Approved ? @"Approval Granted!" : "Waiting Approval...";
                msgBarText.ItemAppearance.Normal.ForeColor = Color.Red;
            }
        }

        private void ApplyPermissions()
        {
			if (!_paymentModel.Paid && _paymentModel.Approved)
			{
				gvPaymentsDetail.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
				gvPaymentsDetail.OptionsBehavior.AllowAddRows = DefaultBoolean.True;
				gvPaymentsDetail.OptionsBehavior.AllowDeleteRows = DefaultBoolean.True;
			}

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

			var canApprove = _userPermission.SingleOrDefault(x => x.ControlName == "CanApprove")?.Value;
			if (canApprove != null) _canApprove = (bool)canApprove;

			btnNew.Enabled = _isAdmin || _canAdd;
			btnSave.Enabled = _isAdmin || _canEdit;
			btnSaveAndClose.Enabled = _isAdmin || _canEdit;
			btnRefresh.Enabled = _isAdmin || _canEdit;
			btnPrint.Enabled = _isAdmin || _canPrint;
			btnDelete.Enabled = _isAdmin || _canDelete;

			btnUndoPayment.Visibility = _isAdmin ? BarItemVisibility.Always : BarItemVisibility.Never;

			btnApprove.Visibility = _isAdmin || _canApprove
				? BarItemVisibility.Always
				: BarItemVisibility.Never;

			gvPaymentsDetail.OptionsBehavior.ReadOnly = !_paymentModel.Approved;

			btnActionPay.Enabled = _paymentModel.Approved;
			btnUndoPayment.Enabled = btnActionPay.Enabled && _paymentModel.Paid;

			gvPaymentsDetail.Columns["Approved"].Visible = _paymentModel.Approved && _isAdmin;
			gvPaymentsDetail.Columns["ApprovedDate"].Visible = _paymentModel.Approved && _isAdmin;
			gvPaymentsDetail.Columns["ApprovedBy"].Visible = _paymentModel.Approved && _isAdmin;
			gvPaymentsDetail.Columns["Paid"].Visible = _paymentModel.Approved;
			gvPaymentsDetail.Columns["PaidBy"].Visible = _paymentModel.Approved;

			msgBarText.Caption = _paymentModel.Approved ? "" : @"Waiting Approval...";

			gvPaymentsDetail.OptionsView.NewItemRowPosition = _canAdd ? NewItemRowPosition.Bottom : NewItemRowPosition.None;
			gvPaymentsDetail.OptionsBehavior.AllowAddRows = !_canAdd ? DefaultBoolean.True : DefaultBoolean.False; ;
			gvPaymentsDetail.OptionsBehavior.AllowDeleteRows = !_canDelete ? DefaultBoolean.True : DefaultBoolean.False;
		}

        private void ApplyDefaults()
        {
            DXMenuItem itemEdit = new DXMenuItem("Edit", ItemEdit_Click);
            DXMenuItem itemDelete = new DXMenuItem("Delete", ItemDelete_Click);
            _menuItems = new[] { itemEdit, itemDelete };

            //Add new default payment if not already paid
            _maxAmount = _paymentModel.FAmount;

            //check if paid
            gvPaymentsDetail.OptionsBehavior.ReadOnly = _paymentModel.Paid;
            btnActionPay.Enabled = _paymentModel.Approved && !_paymentModel.Paid;
            btnApprove.Enabled = _paymentModel.Paid == false;

            if ((_paymentModel.Paid == true || _paymentsDetail != null) && _paymentsDetail.Count > 0) return;

            if (_paymentsDetail == null)
                _paymentsDetail = new List<PaymentDetailModel>();

            msgBarText.Caption = _paymentModel.Approved ? "" : @"Waiting Approval...";

			try
            {
                gcPaymentsDetail.DataSource = null;
                gcPaymentsDetail.DataSource = _paymentsDetail;

            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemEdit_Click(object sender, EventArgs e)
        {
            gvPaymentsDetail.ShowEditor();
        }

        private void ItemDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(@"Delete row?", @"Confirmation", MessageBoxButtons.YesNo) !=
                DialogResult.Yes)
                return;

            GridView view = sender as GridView;
            gvPaymentsDetail.SetRowCellValue(gvPaymentsDetail.FocusedRowHandle, "Deleted", true);

        }

        #region Calculate rates functions
        private decimal CalculateRate(int currencyIn, int currencyOut, decimal pValue, DateTime pTransactionDate)
        {
            decimal exchangeRate = 0;
            decimal rateValue = 0;
            decimal baseCurrencyValue = 0;

            baseCurrencyValue = GetRate(2, pTransactionDate);
            exchangeRate = GetRate(currencyIn, pTransactionDate);

            if (currencyIn == currencyOut) rateValue = pValue;
            if (currencyOut == 1 && currencyIn != currencyOut)
                rateValue = pValue * exchangeRate;
            else if (currencyOut == 2 && currencyIn != currencyOut)
                rateValue = pValue * exchangeRate / baseCurrencyValue;

            return rateValue;
        }

        private decimal GetRate(int pCurrencyId, DateTime? pTransactionDate)
        {
            var currencyDate = pTransactionDate;
            decimal rateValue = 0;

            var currencyExchangeRate = _currencyExchangeRepository.SelectExchangeCurrency(pCurrencyId, currencyDate);
            if (currencyExchangeRate != null) rateValue = currencyExchangeRate.ExchangeValue;

            return rateValue;
        }

        #endregion

        #region Buttons Event

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CanSave()) return;

            Save();
        }

        private void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CanSave()) return;

            Save();
            Close();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnMeeting_ItemClick(object sender, ItemClickEventArgs e)
        {

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

        private void gvPaymentsDetail_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            if (customSumUSD >= _maxAmount) return;

            GridView view = sender as GridView;
            //var oldRow = view.GetRowCellValue(view.DataRowCount - 1, view.Columns["Amount"]);

            //Set static values to Journal details
            view.SetRowCellValue(e.RowHandle, view.Columns["PaymentId"], _paymentModel.Id);
            view.SetRowCellValue(e.RowHandle, view.Columns["PaymentDetailDate"], DateTime.Now);
            view.SetRowCellValue(e.RowHandle, view.Columns["TypeId"], cboPaymentTypes.EditValue);
            view.SetRowCellValue(e.RowHandle, view.Columns["ReferenceId"], txtReference.Text);
            view.SetRowCellValue(e.RowHandle, view.Columns["CurrencyId"], cboCurrencies.EditValue);
            view.SetRowCellValue(e.RowHandle, view.Columns["Rate"], txtTotalAmountLL.Text);
            view.SetRowCellValue(e.RowHandle, view.Columns["Amount"], _maxAmount - customSumUSD);

            view.SetRowCellValue(e.RowHandle, view.Columns["LAmount"],
	            CalculateRate((int)cboCurrencies.EditValue, 1, _maxAmount - customSumUSD, DateTime.Now));

            view.SetRowCellValue(e.RowHandle, view.Columns["FAmount"],
	            CalculateRate((int)cboCurrencies.EditValue, 2, _maxAmount - customSumUSD, DateTime.Now));

        }

        private void btnActionPay_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CanSave()) return;

            _paymentModel.Paid = true;
            PayRemainingBalance();
            Save();
            btnUndoPayment.Enabled = _paymentModel.Paid;
            //Close();

        }

        private void PayRemainingBalance()
        {
            try
            {
                _paymentsDetail = (IList<PaymentDetailModel>)bsPaymentDetails.DataSource;

                _ = decimal.TryParse(txtRemainingAmount.Text, out decimal totalRemainingAmount);
                _ = decimal.TryParse(txtRemainingAmountLL.Text, out decimal totalRemainingAmountLL);
                _ = decimal.TryParse(txtRemainingAmountUSD.Text, out decimal totalRemainingAmountUSD);

                if (totalRemainingAmount > 0)
                {
                    _paymentsDetail.Add(new PaymentDetailModel
                    {
                        PaymentId = _paymentModel.Id,
                        PaymentDetailDate = DateTime.Now,
                        TypeId = _paymentModel.PaymentTypeId,
                        ReferenceId = _paymentModel.ReferenceId,
                        CurrencyId = _paymentModel.CurrencyId,
                        Rate = _paymentModel.Rate,
                        Amount = totalRemainingAmount,
                        LAmount = totalRemainingAmountLL,
                        FAmount = totalRemainingAmountUSD,
                        Discount = 0
                    });
                }
                bsPaymentDetails.DataSource = _paymentsDetail;
                gcPaymentsDetail.DataSource = null;
                gcPaymentsDetail.DataSource = bsPaymentDetails;

                _paymentModel.Paid = true;

            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message,
                    "Payment error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void gvPaymentsDetail_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            var summaryId = Convert.ToInt32((e.Item as GridSummaryItem).Tag);
            var view = sender as GridView;

            // Initialization 
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                customSum = 0;
                customSumLL = 0;
                customSumUSD = 0;
            }

            // Calculation 
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
                switch (summaryId)
                {
                    case 1: //Amount field
                        customSum += Convert.ToDecimal(e.FieldValue);
                        break;

                    case 2: //LAmount field
                        customSumLL += Convert.ToDecimal(e.FieldValue);
                        break;

                    case 3:
                        customSumUSD += Convert.ToDecimal(e.FieldValue);
                        break;
                }

            // Finalization 
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
                switch (summaryId)
                {
                    case 1:
                        e.TotalValue = customSum;

                        txtTotalPaidAmount.Text = customSum.ToString();
                        txtRemainingAmount.Text = (_paymentModel.Amount - customSum).ToString();

                        break;

                    case 2:
                        e.TotalValue = customSumLL;

                        txtTotalPaidAmountLL.Text = customSumLL.ToString();
                        txtRemainingAmountLL.Text = (_paymentModel.LAmount - customSumLL).ToString();
                        break;


                    case 3:
                        e.TotalValue = customSumUSD;

                        txtTotalPaidAmountUSD.Text = customSumUSD.ToString();
                        txtRemainingAmountUSD.Text = (_paymentModel.FAmount - customSumUSD).ToString();
                        break;
                }
        }

        private void CalculateAmounts(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Amount"]) != null)
            {
                decimal amountValue = 0;
                {
                    decimal.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Amount"]).ToString(),
                        out amountValue);
                }
                int curId = int.Parse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["CurrencyId"]).ToString());
                var currentDate = DateTime.Parse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["PaymentDetailDate"]).ToString());


                view.SetRowCellValue(e.RowHandle, "LAmount", CalculateRate(curId, 1, amountValue, currentDate));
                view.SetRowCellValue(e.RowHandle, "FAmount", CalculateRate(curId, 2, amountValue, currentDate));

                _ = decimal.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["LAmount"]).ToString(), out totalBalanceLL);
                _ = decimal.TryParse(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["FAmount"]).ToString(), out totalBalanceUSD);
            }
        }

        private void Save()
        {
            try
            {
                BindingContext[bsPaymentDetails].EndCurrentEdit();
                BindingContext[bsPayment].EndCurrentEdit();

                gvPaymentsDetail.UpdateCurrentRow();

                _paymentsDetail = (IList<PaymentDetailModel>)bsPaymentDetails.DataSource;
                _paymentModel = (PaymentModel)bsPayment.DataSource;

                foreach (PaymentDetailModel payment in _paymentsDetail)
                {
                    if (payment.Deleted)
                    {
	                    _logInfoRepository.UpdateLogInfo(payment);
                        _paymentDetailRepository.DeletePaymentDetail(payment.Id);
                        continue;
                    }

                    if (payment.Id == 0)
                    {
	                    _logInfoRepository.CreateLogInfo(payment);
                        _paymentDetailRepository.AddNewPaymentDetail(payment);
                    }
                    else
                    {
	                    _logInfoRepository.UpdateLogInfo(payment);
                        _paymentDetailRepository.UpdatePaymentDetail(payment);
                    }
                }

                _ = _paymentRepository.UpdatePayment(_paymentModel);
                _ = _paymentRepository.UpdatePaymentById(_paymentModel.Id);

                //switch (_paymentModel.ActionType)
                //{
                //    case 1:
                //        _paymentRepository.UpdateCostSheetPayment(_paymentModel);
                //        break;

                //    case 2:
                //        _paymentRepository.UpdateCostSheetPayment(_paymentModel);
                //        break;
                //}

                //_paymentRepository.UpdateCostSheetPayment(_paymentModel);

                SendUpdatedPayment(_paymentModel, EventArgs.Empty);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "User save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvPaymentsDetail_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                var dataView = view.DataSource;
                BindingSource bindingSource = (view.DataSource as BindingSource);
                if (bindingSource != null)
                {
                    var dataRowView = bindingSource[e.ListSourceRow] as PaymentDetailModel;
                    if (dataRowView.Deleted)
                    {
                        e.Visible = false;
                        e.Handled = true;
                    }

                    if (dataRowView.Paid && !_isAdmin)
                    {
                        gvPaymentsDetail.Columns["Paid"].OptionsColumn.ReadOnly = true;
                        gvPaymentsDetail.Columns["PaidBy"].OptionsColumn.ReadOnly = true;
                    }

                }
            }
        }

        private void gvPaymentsDetail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (XtraMessageBox.Show(@"Delete row?", @"Confirmation", MessageBoxButtons.YesNo) !=
                    DialogResult.Yes)
                    return;
                GridView view = sender as GridView;

                view.SetRowCellValue(view.FocusedRowHandle, "Deleted", true);
            }
        }

        private void gvPaymentsDetail_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
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

        private void gvPaymentsDetail_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            if (_paymentsDetail.Count == 0)
            {
                _paymentsDetail.Add(new PaymentDetailModel
                {
                    PaymentId = _paymentModel.Id,
                    PaymentDetailDate = DateTime.Now,
                    TypeId = _paymentModel.PaymentTypeId,
                    ReferenceId = _paymentModel.ReferenceId,
                    CurrencyId = _paymentModel.CurrencyId,
                    Rate = _paymentModel.Rate,
                    Amount = _paymentModel.Amount,
                    LAmount = _paymentModel.LAmount,
                    FAmount = _paymentModel.FAmount,
                    Discount = 0
                });
                gcPaymentsDetail.DataSource = null;
                gcPaymentsDetail.DataSource = _paymentsDetail;
            }
            //Rate/Amounts
            if (e.Column.FieldName == "Rate" || e.Column.FieldName == "Amount")
            {
                CalculateAmounts(sender, e);
            }

            if (e.Column.FieldName == "Approved")
            {
                view.SetRowCellValue(view.FocusedRowHandle, "ApprovedBy", CurrentUser.UserId);
                view.SetRowCellValue(view.FocusedRowHandle, "ApprovedDate", DateTime.Now);
            }
            if (e.Column.FieldName == "Paid")
            {
                view.SetRowCellValue(view.FocusedRowHandle, "PaidBy", CurrentUser.UserId);
                view.SetRowCellValue(view.FocusedRowHandle, "PaymentDetailDate", DateTime.Now);

                gvPaymentsDetail.Columns["Paid"].OptionsColumn.ReadOnly = false;
                gvPaymentsDetail.Columns["PaidBy"].OptionsColumn.ReadOnly = false;
            }

        }

        private void gvPaymentsDetail_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            bool approved = (bool)view.GetRowCellValue(view.DataRowCount - 1, view.Columns["Approved"]);
            bool paid = (bool)view.GetRowCellValue(view.DataRowCount - 1, view.Columns["Paid"]);

            if (approved && paid)
            {
                var oldValue = e.OldValue;
            }

        }

        private void gvPaymentsDetail_BeforeLeaveRow(object sender, RowAllowEventArgs e)
        {
            //GridView view = sender as GridView;
            //decimal.TryParse(txtRemainingAmountUSD.Text, out decimal remainingAmountValue);
            //decimal.TryParse(txtTotalAmountUSD.Text, out decimal totalAmountValue);

            //if (remainingAmountValue < 0)
            //{
            //    XtraMessageBox.Show($"Amount exceed the total amount of `{totalAmountValue}`, please check again!",
            //        "Amount error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Allow = false;

            //    return;
            //}

            //if (Math.Round(customSumUSD,2) > Math.Round(_maxAmount, 2))
            //{
            //    XtraMessageBox.Show($"Amount exceed the total amount of `{_maxAmount}`, please check again!",
            //        "Amount error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Allow = false;
            //}
        }

        private bool CanSave()
        {
            var validateReturnValue = true;
            var messageNumber = 0;
            var validateMessage = new StringBuilder();

            //if (Math.Round(customSumUSD, 2) > Math.Round(_maxAmount, 2))
            //{
            //    messageNumber += 1;
            //    validateMessage.Append($"\n- Amount exceed the total amount of `{_maxAmount}`, please check again!");
            //    validateReturnValue = false;
            //    gcPaymentsDetail.Focus();
            //}

            if (!validateReturnValue)
            {
                validateMessage.Insert(0, "The following need your attention:");
                if (messageNumber > 1) validateMessage.Replace("following", "followings");
                XtraMessageBox.Show(validateMessage + " \nPlease try again.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return validateReturnValue;
        }

        private void btnApprove_ItemClick(object sender, ItemClickEventArgs e)
        {
            _paymentModel.Approved = btnApprove.Checked;

            if (btnApprove.Checked)
            {
                btnApprove.ItemAppearance.Normal.Font = new Font("Tahoma", 8, FontStyle.Bold);
                btnApprove.ItemAppearance.Normal.ForeColor = Color.Green;
                btnApprove.ItemAppearance.Hovered.Font = new Font("Tahoma", 8, FontStyle.Bold);
                btnApprove.ItemAppearance.Hovered.ForeColor = Color.Green;
                btnApprove.ItemAppearance.Pressed.Font = new Font("Tahoma", 8, FontStyle.Bold);
                btnApprove.ItemAppearance.Pressed.ForeColor = Color.Green;
                btnApprove.Caption = @"Approved";
                msgBarText.Caption = _paymentModel.Approved ? @"Approval Granted!" : "Waiting Approval...";
                msgBarText.ItemAppearance.Normal.ForeColor = Color.Green;
            }
            else
            {
                btnApprove.ItemAppearance.Normal.Font = new Font("Tahoma", 8, FontStyle.Regular);
                btnApprove.ItemAppearance.Normal.ForeColor = Color.Black;
                btnApprove.ItemAppearance.Hovered.Font = new Font("Tahoma", 8, FontStyle.Regular);
                btnApprove.ItemAppearance.Hovered.ForeColor = Color.Black;
                btnApprove.ItemAppearance.Pressed.Font = new Font("Tahoma", 8, FontStyle.Regular);
                btnApprove.ItemAppearance.Pressed.ForeColor = Color.Black;
                btnApprove.Caption = @"Approve";
                msgBarText.Caption = _paymentModel.Approved ? @"Approval Granted!" : "Waiting Approval...";
                msgBarText.ItemAppearance.Normal.ForeColor = Color.Red;
            }
            gvPaymentsDetail.Columns["Approved"].Visible = btnApprove.Checked && _isAdmin;
            gvPaymentsDetail.Columns["ApprovedDate"].Visible = btnApprove.Checked && _isAdmin;
            gvPaymentsDetail.Columns["ApprovedBy"].Visible = btnApprove.Checked && _isAdmin;

            gvPaymentsDetail.OptionsBehavior.ReadOnly = btnApprove.Checked;
            btnActionPay.Enabled = btnApprove.Checked;
        }

        private void btnUndoPayment_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Please check payments 1st with accounting department!" +
                                "", "Coming soon!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _paymentModel.Paid = false;
            gvPaymentsDetail.OptionsBehavior.ReadOnly = false;
            btnActionPay.Enabled = true;
            chkPaid.EditValue = false;

            _paymentDetailRepository.DeleteAllPaymentDetails(_paymentModel.Id);

            _paymentsDetail = new List<PaymentDetailModel>();
            bsPaymentDetails.DataSource = _paymentsDetail;

            gcPaymentsDetail.DataSource = null;
            gcPaymentsDetail.DataSource = bsPaymentDetails;

            if (!CanSave()) return;

            Save();

        }

		private void PaymentDetailForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_objState != DataEntityState.Unchanged)
			{
				e.Cancel = true;
			}
		}
	}
}