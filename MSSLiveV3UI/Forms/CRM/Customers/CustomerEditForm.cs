using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.CRM.Customers
{
    public partial class CustomerEditForm : RibbonForm
	{
		private const string _formName = "CustomerEdit";
		private int _formId;
		private bool _resetMenu;

		private DataEntityState _objState = DataEntityState.Unchanged;

        private CustomerModel _customerModel = new CustomerModel();
        private IList<CustomerModel> _customers = new List<CustomerModel>();
        private IList<CustomerModel> _memberOf = new List<CustomerModel>();

        private IList<CityModel> _cities = new List<CityModel>();
        private IList<CountryModel> _countries = new List<CountryModel>();
        private IList<UserModel> _salesUsers = new List<UserModel>();
        private IList<UserModel> _responsibleUsers = new List<UserModel>();
        private IList<CustomerHistoryModel> _customerHistoryList = new List<CustomerHistoryModel>();
        private IList<OperatingUserHistoryModel> _operatingUserHistoryList = new List<OperatingUserHistoryModel>();

        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly CityRepository _cityRepository = new CityRepository();
        private readonly CountryRepository _countryRepository = new CountryRepository();
        private readonly UserRepository _userRepository = new UserRepository();

        /// <summary>
        /// User Permission Role
        /// </summary>
        private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
        private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
        private readonly FormRepository _formRepository = new FormRepository();
        private readonly LogInfoRepository _logInfoRepository = new LogInfoRepository();

        //Init permission variables
        private bool _canAdd;
        private bool _canEdit;
        private bool _canDelete;
        private bool _canPrint;
        private bool _isAdmin;
        private bool _isProtected;
        private bool _isLimitedView;

		public EventHandler SendUpdatedCustomer;

        public CustomerEditForm(CustomerModel customer)
        {
            InitializeComponent();

            try
            {
                _customerModel = customer;

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
				_memberOf = _customers;

				_cities = _cityRepository.SelectCities();
				_countries = _countryRepository.SelectCountries();
				_salesUsers = _userRepository.SelectUsers();
				_responsibleUsers = _userRepository.SelectUsers();
				_customerHistoryList = _customerRepository.SelectCustomerHistoryById(_customerModel.Id);
				_operatingUserHistoryList = _userRepository.SelectUserHistoryById(_customerModel.ResponsibleId);
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {
            bsCustomers.DataSource = _customerModel;
            bsCustomerHistoryList.DataSource = _customerHistoryList;
            bsRepsonsibleHistoryList.DataSource = _operatingUserHistoryList;

            cboMemberOfList.Properties.DataSource = null;
            cboMemberOfList.Properties.DataSource = _memberOf;

            cboCountries.Properties.DataSource = null;
            cboCountries.Properties.DataSource = _countries;

            cboCities.Properties.DataSource = null;
            cboCities.Properties.DataSource = _cities;

            cboCountries.EditValue = _customerModel.CountryId;
            cboCities.EditValue = _customerModel.CityId;

            cboCurrentSalesman.Properties.DataSource = null;
            cboCurrentSalesman.Properties.DataSource = _salesUsers;

            cboResponsibleUser.Properties.DataSource = null;
            cboResponsibleUser.Properties.DataSource = _responsibleUsers;

            gcJobsHistory.DataSource = null;
            gcJobsHistory.DataSource = bsCustomerHistoryList;

            gcRepsonsibleHistory.DataSource = null;
            gcRepsonsibleHistory.DataSource = bsRepsonsibleHistoryList;
        }

        private void ApplyDefaults()
        {
	        txtCustomerName.Focus();
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
	        btnSave.Enabled = _isAdmin || _canEdit;
	        btnSaveAndClose.Enabled = _isAdmin || _canEdit;
	        btnPrint.Enabled = _isAdmin || _canPrint;
	        btnDelete.Enabled = _isAdmin || _canDelete;
		}

        private bool ValidateData()
        {
            var validateReturnValue = true;
            var messageNumber = 0;
            var validateMessage = new StringBuilder();

            if (txtCustomerName.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Customer Name cannot be empty.");
                validateReturnValue = false;
                txtCustomerName.Focus();
            }

            if (cboCountries.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Country Name cannot be empty.");
                validateReturnValue = false;
                cboCountries.Focus();
            }

            if (cboCities.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- City Region Name cannot be empty.");
                validateReturnValue = false;
                cboCities.Focus();
            }

            if (txtAddress.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Address Name cannot be empty.");
                validateReturnValue = false;
                txtAddress.Focus();
            }

            if (txtPhoneNumber1.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- At least one phone number is required.");
                validateReturnValue = false;
                txtPhoneNumber1.Focus();
            }

            if (!validateReturnValue)
            {
                validateMessage.Insert(0, "The following need your attention:");
                if (messageNumber > 1) validateMessage.Replace("following", "followings");
                XtraMessageBox.Show(validateMessage + " \nPlease try again.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return validateReturnValue;
        }


        #region Bind controls

        private void BindEditors()
        {
            foreach (var control in moduleDataLayout.Items.ConvertToTypedList())
            {
                var item = control.Tag;
                if (item == null) continue;
                control.Text = control.Text + @" <color=red>*</color>";

            }
        }

        #endregion

        #region Menu Buttons

        private void biClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _customerModel = new CustomerModel();
            InitializeBindings();
            WireUpBindings();
        }

        private void biSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!ValidateData()) return;
            SaveCustomer();
        }

        private void biSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!ValidateData()) return;
            SaveCustomer();
            Close();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        private void biDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }
            
        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var previewForm = new DocumentViewerForm();
            //var report = new QotationsListReport();

            //report.DataSource = dataReportModels;

            ////report.Parameters["isAdmin"].Value = CurrentUserInfoModel.UserId == 30 && chkShowProfit.Checked;

            //previewForm.Viewer.DocumentSource = report;
            //previewForm.ShowDialog();
        }


        #endregion


        private void SaveCustomer()
        {
            try
            {
                BindingContext[bsCustomers].EndCurrentEdit();
                
                _customerModel.CustomerName = txtCustomerName.Text.Trim();

                if (cboCountries.EditValue != null) _customerModel.CountryId = (int)cboCountries.EditValue;
                if (cboCities.EditValue != null) _customerModel.CityId = (int)cboCities.EditValue;
                //if (cboCategories.EditValue != null) _customerModel.CustomerCategoryId = _customerRepository.FindById((int)cboCategories.EditValue);
                if (cboMemberOfList.EditValue != null && cboMemberOfList.Text != "") _customerModel.MemberOfId = (int)cboMemberOfList.EditValue;

                if (cboCurrentSalesman.EditValue != null) _customerModel.SalesId = (int)cboCurrentSalesman.EditValue;
                if (cboResponsibleUser.EditValue != null) _customerModel.ResponsibleId = (int)cboResponsibleUser.EditValue;

                if (_customerModel.Id == 0)
                {
                    _logInfoRepository.CreateLogInfo(_customerModel);

                    int newCustomer = _customerRepository.AddNewCustomer(_customerModel);
                    if (newCustomer == 0)
                    {
                        throw new Exception($"Error while saving : {txtCustomerName.Text}");
                    }
                }
                else
                {
                    _logInfoRepository.UpdateLogInfo(_customerModel);
                    _customerRepository.UpdateCustomer(_customerModel);
                }

                SendUpdatedCustomer(_customerModel, EventArgs.Empty);
                _objState = DataEntityState.Unchanged;
                Close();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "User save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cboMemberOfList_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int? myResult = null;
            //    if (cboMemberOfList.EditValue != null)
            //        myResult = (int?)cboMemberOfList.EditValue;

            //    _memberModel.MemberOf = myResult;
            //}
            //catch (Exception exception)
            //{
            //    //
            //}

        }
        
        #region AutoSugest
        void OnAutoSuggest(object sender, LookUpEditAutoSuggestEventArgs e)
        {
            //...
            e.SetHighlightRanges(HighlightTags(e.Text));
        }

        static Func<string, string, DisplayTextHighlightRange[]> HighlightTags(string pattern)
        {
            var indexOf = IgnoreCaseComparisonFunctions.GetIndexOf(
                CultureInfo.CurrentCulture.CompareInfo, CompareOptions.IgnoreCase);
            var parts = pattern.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            return (displayText, fieldName) =>
            {
                var tags = displayText.Split(new string[] { ", " },
                    StringSplitOptions.RemoveEmptyEntries);
                var ranges = new List<DisplayTextHighlightRange>();
                for (int i = 1/*skip country tag*/; i < tags.Length; i++)
                {
                    int tagStart = displayText.IndexOf(tags[i]);
                    for (int j = 0; j < parts.Length; j++)
                    {
                        int index = indexOf(tags[i], parts[j]);
                        if (index != -1)
                            ranges.Add(new DisplayTextHighlightRange(tagStart + index, parts[j].Length));
                    }
                }
                return ranges.ToArray();
            };
        }


        #endregion


    }
}