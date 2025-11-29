using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Accounting.Payments;
using MISLiveMed.DataLayers.Accounting.Receipts;
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
using MISLiveMed.Utils.Enums;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Accounting.Receipts
{
    public partial class ReceiptsListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "ReceiptsList";
		private int _formId;
		private bool _resetMenu;

		private ReceiptModel _receiptModel = new ReceiptModel();
        private ReceiptDetailModel _receiptDetailModel = new ReceiptDetailModel();
        private IList<ReceiptModel> _receipts = new List<ReceiptModel>();
        private IList<ReceiptDetailModel> _receiptDetails = new List<ReceiptDetailModel>();
        private IList<PaymentTypeModel> _paymentsType = new List<PaymentTypeModel>();
        private IList<DepartmentModel> _departments = new List<DepartmentModel>();
        private IList<MembersTypeModel> _membersType = new List<MembersTypeModel>();
        private IList<InitDataObjectModel> _customers = new List<InitDataObjectModel>();
        private IList<InitDataObjectModel> _agents = new List<InitDataObjectModel>();
        private IList<CurrencyModel> _currencies = new List<CurrencyModel>();

        private readonly ReceiptRepository _receiptRepository = new ReceiptRepository();
        private readonly ReceiptDetailRepository _receiptDetailRepository = new ReceiptDetailRepository();
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

        //Init permissionvariables
        private bool _canAdd;
        private bool _canEdit;
        private bool _canDelete;
        private bool _canPrint;
        private bool _isAdmin;
        private bool _isProtected;

		#region Implementation of IFormWithRibbon

		public RibbonControl MainRibbon => rcReceipts;
        public RibbonPage DefaultPage => rpReceipts;


        #endregion

        public ReceiptsListForm()
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

				_receipts = _receiptRepository.SelectReceipts(EnumPaymentType.Receipt);
		        _receiptDetails = _receiptDetailRepository.SelectReceiptsDetails();
		        _paymentsType = _paymentTypeRepository.SelectPaymentsType();
		        _departments = _departmentRepository.SelectDepartments();
		        _membersType = _memberTypeRepository.SelectMembersType();
		        //_customers = _customerRepository.SelectCustomers();
		        //_agents = _agentRepository.SelectAgents();
		        _currencies = _currencyRepository.SelectCurrencies();
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

        private void WireUpBindings()
        {
            bsReceipts.DataSource = _receipts;

            gcReceipts.DataSource = null;
            gcReceipts.DataSource = bsReceipts;

            repReceiptsType.DataSource = null;
            repReceiptsType.DataSource = _paymentsType;

            repDepartments.DataSource = null;
            repDepartments.DataSource = _departments;

            repMembersType.DataSource = null;
            repMembersType.DataSource = _membersType;

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

			btnNew.Enabled = _isAdmin || _canAdd;
	        btnEdit.Enabled = _isAdmin || _canEdit;
	        btnRefresh.Enabled = _isAdmin || _canEdit;
	        btnPrint.Enabled = _isAdmin || _canPrint;
	        btnDelete.Enabled = _isAdmin || _canDelete;
		}

        private void ApplyDefaults()
        {
	        LayoutsStyle.LoadLayoutGrid(gvReceipts, CurrentUser.UserName, CurrentUser.CompanyName);
		}

        #region Buttons Event

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnPrintFilter_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        #endregion

        private void RcvUpdatedReceipt(object sender, EventArgs e)
        {
            if (sender == null) return;
            _receiptModel = sender as ReceiptModel;

            if (_receiptModel != null && (_receiptModel.LastModifiedDate == null || _receiptModel.Deleted))
            {
                InitializeBindings();
                WireUpBindings();
            }
            else
            {
                gvReceipts.UpdateCurrentRow();
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
				LayoutsStyle.ResetLayoutGrid(gvReceipts, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		private void ReceiptsListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvReceipts, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		#endregion

		private void gcReceipts_DoubleClick(object sender, EventArgs e)
		{
			if (!_isAdmin && !_canEdit) return;


		}
	}
}