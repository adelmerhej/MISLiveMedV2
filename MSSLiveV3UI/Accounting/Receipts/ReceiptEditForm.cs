using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
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
using MISLiveMed.Models.Models.Accounting.Receipts;
using MISLiveMed.Models.Models.Common;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.Members;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;

namespace MISLiveMed.UI.Accounting.Receipts
{
    public partial class ReceiptEditForm : RibbonForm
	{
		private const string _formName = "ReceiptEdit";
		private int _formId;
		private bool _resetMenu;

		DXMenuItem[] _menuItems;

        private ReceiptModel _receiptModel = new ReceiptModel();
        private IList<ReceiptDetailModel> _receiptsDetail = new List<ReceiptDetailModel>();
        private IList<PaymentTypeModel> _paymentsType = new List<PaymentTypeModel>();
        private IList<DepartmentModel> _departments = new List<DepartmentModel>();
        private IList<MembersTypeModel> _membersType = new List<MembersTypeModel>();
        private IList<InitDataObjectModel> _customers = new List<InitDataObjectModel>();
        private IList<InitDataObjectModel> _agents = new List<InitDataObjectModel>();
        private IList<CurrencyModel> _currencies = new List<CurrencyModel>();

        private readonly PaymentRepository _paymentRepository = new PaymentRepository();
        private readonly PaymentDetailRepository _paymentDetailRepository = new PaymentDetailRepository();
        private readonly PaymentTypeRepository _paymentTypeRepository = new PaymentTypeRepository();
        private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();
        private readonly MemberTypeRepository _memberTypeRepository = new MemberTypeRepository();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly AgentRepository _agentRepository = new AgentRepository();
        private readonly CurrencyRepository _currencyRepository = new CurrencyRepository();

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

		public EventHandler SendUpdatedReceipt;

        private decimal _maxAmount = 0;

        // Init balances values
        private decimal customDebitSumLL;
        private decimal customCreditSumLL;
        private decimal customSumLL;
        private decimal customDebitSumUSD;
        private decimal customCreditSumUSD;
        private decimal customSumUSD;
        private decimal totalBalance;
        private int oldCurrencyId = 0;

        public ReceiptEditForm(ReceiptModel model)
        {
            InitializeComponent();

            try
            {
                _receiptModel = model;

                InitializeBindings();
                WireUpBindings();
                ApplyDefaults();
                ApplyPermissions();
			}
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, @"Initialize Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			}
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Initialize Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {
            bsPayment.DataSource = _receiptModel;
            //bsPaymentDetails.DataSource = _paymentModel.PaymentDetails;

            gcReceiptDetail.DataSource = null;
            gcReceiptDetail.DataSource = bsPaymentDetails;

            cboPaymentTypes.Properties.DataSource = null;
            cboPaymentTypes.Properties.DataSource = _paymentsType;

            cboDepartments.Properties.DataSource = null;
            cboDepartments.Properties.DataSource = _departments;

            cboMemberTypes.Properties.DataSource = null;
            cboMemberTypes.Properties.DataSource = _membersType;

            cboCurrencies.Properties.DataSource = null;
            cboCurrencies.Properties.DataSource = _currencies;

            cboMembers.Properties.DataSource = null;
            cboMembers.Properties.ValueMember = "Value";
            cboMembers.Properties.DisplayMember = "Name";
            cboMembers.Properties.DataSource = _agents;

            repTypes.DataSource = null;
            repTypes.DataSource = _paymentsType;

            repCurrencies.DataSource = null;
            repCurrencies.DataSource = _currencies;

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

	        var canApprove = _userPermission.SingleOrDefault(x => x.ControlName == "CanApprove")?.Value;
	        if (canApprove != null) _canApprove = (bool)canApprove;

			gvReceiptDetail.OptionsView.NewItemRowPosition = _canAdd ? NewItemRowPosition.Bottom : NewItemRowPosition.None;
	        gvReceiptDetail.OptionsBehavior.AllowAddRows = !_canAdd ? DefaultBoolean.True : DefaultBoolean.False; ;
	        gvReceiptDetail.OptionsBehavior.AllowDeleteRows = !_canDelete ? DefaultBoolean.True : DefaultBoolean.False;

	        btnUndoPayment.Visibility = _isAdmin ? BarItemVisibility.Always : BarItemVisibility.Never;

	        btnNew.Enabled = _isAdmin || _canEdit;
	        btnSave.Enabled = _isAdmin || _canEdit;
	        btnSaveAndClose.Enabled = _isAdmin || _canEdit;
	        btnRefresh.Enabled = _isAdmin || _canEdit;
	        btnPrint.Enabled = _isAdmin || _canPrint;
	        btnDelete.Enabled = _isAdmin || _canDelete;
	        btnSchedule.Enabled = _isAdmin || _canEdit;
	        btnApprove.Enabled = _isAdmin || _canApprove;
	        btnActionPay.Enabled = _isAdmin || _canApprove;
	        btnUndoPayment.Enabled = _isAdmin || _canApprove;
		}

        private void ApplyDefaults()
        {
            DXMenuItem itemEdit = new DXMenuItem("Edit", ItemEdit_Click);
            DXMenuItem itemDelete = new DXMenuItem("Delete", ItemDelete_Click);
            _menuItems = new[] { itemEdit, itemDelete };

            //Add new default payment if not already paid
            if ((_receiptModel.Paid == true || _receiptsDetail != null) && _receiptsDetail.Count > 0) return;

            if (_receiptsDetail == null)
                _receiptsDetail = new List<ReceiptDetailModel>();


            try
            {
                _receiptsDetail.Add(new ReceiptDetailModel
                {
                    ReceiptId = _receiptModel.Id,
                    ReceiptDetailDate = DateTime.Now,
                    TypeId = _receiptModel.ReceiptTypeId,
                    CurrencyId = _receiptModel.CurrencyId,
                    Rate = _receiptModel.Rate,
                    Amount = _receiptModel.Amount,
                    LAmount = _receiptModel.LAmount,
                    FAmount = _receiptModel.FAmount,
                    Discount = 0
                });
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ItemEdit_Click(object sender, EventArgs e)
        {
            gvReceiptDetail.ShowEditor();
        }

        private void ItemDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(@"Delete row?", @"Confirmation", MessageBoxButtons.YesNo) !=
                DialogResult.Yes)
                return;

            GridView view = sender as GridView;
            gvReceiptDetail.SetRowCellValue(gvReceiptDetail.FocusedRowHandle, "Deleted", true);

        }
    }
}