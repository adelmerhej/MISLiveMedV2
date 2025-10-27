using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Forms.CRM.Customers
{
    public partial class CustomersListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "CustomersList";
		private int _formId;
		private bool _resetMenu;

		private IList<CustomerModel> _customers = new List<CustomerModel>();
		private CustomerModel _customerModel = new CustomerModel();

		private CustomerRepository _customerRepository = new CustomerRepository();

        private IList<CountryModel> _countries = new List<CountryModel>();
        private IList<CityModel> _cities = new List<CityModel>();
        private IList<UserModel> _users = new List<UserModel>();

        private CountryRepository _countryRepository = new CountryRepository();
        private CityRepository _cityRepository = new CityRepository();
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
        private bool _isLimitedView;

		private int _selectedUser = 0;

        #region Implementation of IFormWithRibbon

        public RibbonControl MainRibbon => rcCustomersList;
        public RibbonPage DefaultPage => rpCustomersList;


        #endregion

        public CustomersListForm()
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

			        var isLimitedView = _userPermission.SingleOrDefault(x => x.ControlName == "IsLimitedView")?.Value;
			        if (isLimitedView != null) _isLimitedView = (bool)isLimitedView;
				}
		        //

				_customers = _customerRepository.SelectCustomers(_isProtected, _isLimitedView);
		        _countries = _countryRepository.SelectCountries();
		        _cities = _cityRepository.SelectCities();
		        _users = _userRepository.SelectUsersAsSales(_isProtected);
	        }
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}
        private void WireUpBindings()
        {
            bsCustomers.DataSource = _customers;

            gcCustomers.DataSource = null;
            gcCustomers.DataSource = bsCustomers;

            repSalesFilter.DataSource = null;
            repSalesFilter.DataSource = _users;

            repUsers.DataSource = null;
            repUsers.DataSource = _users;
        }

        private void ApplyDefaults()
        {
	        LayoutsStyle.LoadLayoutGrid(gvCustomers, CurrentUser.UserName);
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

		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomerEditForm frm = new CustomerEditForm(new CustomerModel());
            frm.SendUpdatedCustomer += RcvUpdatedCustomer;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!_customers.Any()) return;

            int currentRowId = (int)gvCustomers.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _customerModel = _customers.SingleOrDefault(x => x.Id == currentRowId);
            if (_customerModel == null) return;

            var frm = new CustomerEditForm(_customerModel);
            frm.SendUpdatedCustomer += RcvUpdatedCustomer;
            frm.Show();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcCustomers.ShowRibbonPrintPreview();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CanDelete()) return;

            try
            {
                //int.TryParse(gvCustomers.GetFocusedRowCellValue("Id").ToString(), out int id);
                string id = gvCustomers.GetFocusedRowCellValue("Id").ToString();
                string name = gvCustomers.GetFocusedRowCellValue("CustomerName").ToString();

                if (id != string.Empty)
                {
                    if (XtraMessageBox.Show($"Are you sure you want to delete Customer: `{name}`?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        _customerModel = gvCustomers.GetFocusedRow() as CustomerModel;
                        if (_customerModel == null)
                        {
                            return;
                        }
                        _customerModel.Deleted = true;

                        //delete the record
                        if (!_customerRepository.DeleteCustomer(_customerModel.Id))
                        {
                            throw new Exception(
                                "Error while deleting, please try again or contact your system administrator.");
                        }
                        RcvUpdatedCustomer(_customerModel, EventArgs.Empty);
                    }
                }

            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "User delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsrAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.ShowDialog();
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        #endregion

        private void gcCustomers_DoubleClick(object sender, EventArgs e)
        {
	        if (!_isAdmin && !_canEdit) return;

			if (!_customers.Any()) return;

            int currentRowId = (int)gvCustomers.GetFocusedRowCellValue("Id");
            if (currentRowId == 0) return;

            _customerModel = _customers.SingleOrDefault(x => x.Id == currentRowId);
            if (_customerModel == null) return;

            var frm = new CustomerEditForm(_customerModel);
            frm.SendUpdatedCustomer += RcvUpdatedCustomer;
            frm.Show();
        }

        #region EventHandler section

        private void RcvUpdatedCustomer(object sender, EventArgs e)
        {
            if (sender == null) return;
            _customerModel = sender as CustomerModel;

            if (_customerModel.LastModifiedDate == null || _customerModel.Deleted)
            {
                InitializeBindings();
                WireUpBindings();
            }
            else
            {
                gvCustomers.UpdateCurrentRow();
            }
        }

        #endregion

        private bool CanDelete()
        {
            CountryModel dataBoundItem = gvCustomers.GetFocusedRow() as CountryModel;

            if (gvCustomers == null || gvCustomers.SelectedRowsCount == 0) return false;
            if (gvCustomers.SelectedRowsCount > 1)
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

        private void gvCustomers_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool isActive = (bool)view.GetRowCellValue(e.RowHandle, "Active");
                bool isDefault = (bool)view.GetRowCellValue(e.RowHandle, "IsDefault");

                DateTime? followupDate = (DateTime?)view.GetRowCellValue(e.RowHandle, "FollowupDate");

                bool dueToFollowup = followupDate != null;
                if(dueToFollowup)
                {
                    dueToFollowup = (followupDate <= DateTime.Now ? true : false);
                }

                if (isDefault)
                {
                    e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
                }
                if (!isActive)
                {
                    e.Appearance.ForeColor = isActive ? Color.Black : Color.Gray;
                    e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Italic);
                }
                if (dueToFollowup)
                {
                    e.Appearance.ForeColor = dueToFollowup ? Color.White : Color.Black;
                    e.Appearance.BackColor = dueToFollowup ? Color.OrangeRed: Color.Transparent;
                }
            }
        }

        private void cboSalesFilter_EditValueChanged(object sender, EventArgs e)
        {
            _customers = null;
            _customers = cboSalesFilter.EditValue != null
                ? _customerRepository.SelectCustomersBySalesId((int)cboSalesFilter.EditValue)
                : _customerRepository.SelectCustomers();
            bsCustomers.DataSource = _customers;
        }

        private void customersRating_EditValueChanged(object sender, EventArgs e)
        {
            _customers = null;
            
            var customerRate = customersRating.EditValue;
            _ = int.TryParse(customerRate.ToString(), out int ratingValue);

            _customers = ratingValue == 0
                ? _customerRepository.SelectCustomers()
                : _customerRepository.SelectCustomersByRating(_isProtected, _isLimitedView, ratingValue);

            bsCustomers.DataSource = _customers;
        }

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvCustomers, CurrentUser.UserName);
			}
		}

		private void CustomersListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvCustomers, CurrentUser.UserName);
			}
		}
	}
}