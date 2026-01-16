using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Common.Carriers;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Countries.Ports;
using MISLiveMed.DataLayers.Common.Currencies;
using MISLiveMed.DataLayers.Common.Departments;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Common.Terms;
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.CRM.Quotations;
using MISLiveMed.DataLayers.JobData.Quotations;
using MISLiveMed.DataLayers.JobData.Quotations.BookingSheet;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Carriers;
using MISLiveMed.Models.Models.Common.Countries.Ports;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.Common.Terms;
using MISLiveMed.Models.Models.JobModels.Quotations;
using MISLiveMed.Models.Models.Members;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Reports.CostSelling;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.BookingStatus.BookingSheet;
using MISLiveMed.UI.Forms.Common.Countries.Ports;
using MISLiveMed.UI.Forms.CRM.Customers;
using MISLiveMed.UI.Reports;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Forms.CRM.Quotations
{
    public partial class QuotationEditForm : RibbonForm
	{
		private const string _formName = "QuotationEdit";
		private int _formId;
		private bool _resetMenu;
		private DataEntityState _objState = DataEntityState.Unchanged;

		private QuotationModel _quotationModel;
		private IList<QuotationHeaderModel> _quotationsHeaders = new List<QuotationHeaderModel>();

		private IList<DepartmentModel> _departments = new List<DepartmentModel>();
		private IList<UserModel> _users = new List<UserModel>();
		private IList<UserModel> _sales = new List<UserModel>();
		private IList<CustomerModel> _customers = new List<CustomerModel>();
		private IList<AgentModel> _agents = new List<AgentModel>();
		private IList<VesselModel> _seaCarriers = new List<VesselModel>();
		private IList<TermsModel> _terms = new List<TermsModel>();
		private IList<CurrencyModel> _currencies = new List<CurrencyModel>();
		private PortModel _portModel = new PortModel();
		private IList<PortModel> _ports = new List<PortModel>();

		private IList<QuotationCostPriceModel> _quotationCostPriceModels = new List<QuotationCostPriceModel>();
		private IList<QuotationSellingPriceModel> _quotationsSelling = new List<QuotationSellingPriceModel>();

		private readonly DepartmentRepository _departmentRepository = new DepartmentRepository();
		private readonly CustomerRepository _customerRepository = new CustomerRepository();
		private readonly PortRepository _portRepository = new PortRepository();
		private readonly AgentRepository _agentRepository = new AgentRepository();
		private readonly VesselRepository _seaCarrierRepository = new VesselRepository();
		private readonly CurrencyRepository _currencyRepository = new CurrencyRepository();
		private readonly TermRepository _termRepository = new TermRepository();
		private readonly CityRepository _cityRepository = new CityRepository();
		private readonly UserRepository _userRepository = new UserRepository();

		private readonly QuotationHeaderCostSellingRepository _quotationHeaderRepository =
		new QuotationHeaderCostSellingRepository();

		private readonly QuotationCostRepository _quotationCostRepository = new QuotationCostRepository();

		private readonly QuotationSellingRepository _sellingRepository = new QuotationSellingRepository();

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
		private bool _canPrint;
		private bool _isAdmin;
		private bool _canCreateJob;
		private bool _isProtected;
		private bool _canChangeUser;

		private bool _clonedQuotation;

        public EventHandler SendUpdatedQuotation;

        public QuotationEditForm(QuotationModel quotation)
        {
            InitializeComponent();
            try
            {
				_quotationModel = quotation;

				InitializeBindings();
				RefreshCostSellingRecords();
				WireUpBindings();
	            ApplyPermissions();
	            ApplyDefaults();

				if (_quotationModel.Id == 0) InitNew();
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
				}
				//

				_departments = _departmentRepository.SelectDepartments();
                _users = _userRepository.SelectUsers();
                _sales = _userRepository.SelectUsersAsSales();
                _customers = _customerRepository.SelectCustomers();
                _agents = _agentRepository.SelectAgents();
                _ports = _portRepository.SelectPorts(HelperApplication.SelectPortType(_quotationModel.DepartmentId));
                //_seaCarriers = _seaCarrierRepository.SeaCarriersList();
                _currencies = _currencyRepository.SelectCurrencies();
                _terms = _termRepository.SelectTerms();
                _quotationsHeaders = _quotationHeaderRepository.QuotationHeaderList(_quotationModel.Id);

                _quotationCostPriceModels = _quotationCostRepository.TotalQuotationCostPrice(_quotationModel.Id);
                _quotationsSelling = _sellingRepository.TotalQuotationsSellingCost(_quotationModel.Id);

				FindRelatedJobNo();
            }
            catch (Exception e)
            {
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void WireUpBindings()
        {
            bsQuotations.DataSource = _quotationModel;
            txtXONumber.Text = _quotationModel.FullReferenceNo();

            cboCustomers.Properties.DataSource = null;
            cboCustomers.Properties.DataSource = _customers;

            cboConsigneesList.Properties.DataSource = null;
            cboConsigneesList.Properties.DataSource = _customers;

            cboHandledBy.Properties.DataSource = null;
            cboHandledBy.Properties.DataSource = _users;

            cboSales.Properties.DataSource = null;
            cboSales.Properties.DataSource = _users;

            cboPolList.Properties.DataSource = null;
            cboPolList.Properties.DataSource = _ports;
            cboPolList.EditValue = _quotationModel.Pol;

            cboPodList.Properties.DataSource = null;
            cboPodList.Properties.DataSource = _ports;
            cboPodList.EditValue = _quotationModel.Pod;

            gcQuoteDetails.DataSource = null;
            gcQuoteDetails.DataSource = _quotationsHeaders;

            gcRealCosts.DataSource = null;
            gcRealCosts.DataSource = _quotationCostPriceModels;

            gcSellings.DataSource = null;
            gcSellings.DataSource = _quotationsSelling;

            cboDepartments.Properties.DataSource = null;
            cboDepartments.Properties.DataSource = _departments;

            cboAgentsList.Properties.DataSource = null;
            cboAgentsList.Properties.DataSource = _agents;

            cboCarrierList.Properties.DataSource = null;
            cboCarrierList.Properties.DataSource = _seaCarriers;

            cboStatus.Properties.DataSource = Enum.GetValues(typeof(EnumStatusType));

            btnUrgent.Checked = _quotationModel.Urgent;

            repSellingCurrenciesList.DataSource = null;
            repSellingCurrenciesList.DataSource = _currencies;

            cboTermsList.Properties.DataSource = null;
            cboTermsList.Properties.DataSource = _terms;

            repSeaCarrierList.DataSource = null;
            repSeaCarrierList.DataSource = _seaCarriers;

            if (btnUrgent.Checked)
            {
                btnUrgent.ItemAppearance.Normal.Font = new Font("Tahoma", 8, FontStyle.Bold);
                btnUrgent.ItemAppearance.Normal.ForeColor = Color.Red;
                btnUrgent.ItemAppearance.Hovered.Font = new Font("Tahoma", 8, FontStyle.Bold);
                btnUrgent.ItemAppearance.Hovered.ForeColor = Color.Red;
                btnUrgent.ItemAppearance.Pressed.Font = new Font("Tahoma", 8, FontStyle.Bold);
                btnUrgent.ItemAppearance.Pressed.ForeColor = Color.Red;
            }
            else
            {
                btnUrgent.ItemAppearance.Normal.Font = new Font("Tahoma", 8, FontStyle.Regular);
                btnUrgent.ItemAppearance.Normal.ForeColor = Color.Black;
                btnUrgent.ItemAppearance.Hovered.Font = new Font("Tahoma", 8, FontStyle.Regular);
                btnUrgent.ItemAppearance.Hovered.ForeColor = Color.Black;
                btnUrgent.ItemAppearance.Pressed.Font = new Font("Tahoma", 8, FontStyle.Regular);
                btnUrgent.ItemAppearance.Pressed.ForeColor = Color.Black;
            }
        }

        private void ApplyPermissions()
		{
			if (_userPermission == null) return;
			if (_userPermission.Count <= 0) return;

			var canAdd = _userPermission.SingleOrDefault(x => x.ControlName == "CanAdd")?.Value;
			if (canAdd != null) _canAdd = (bool)canAdd;

			var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
			if (canEdit != null) _canEdit = (bool)canEdit;

			var canPrint = _userPermission.SingleOrDefault(x => x.ControlName == "CanPrint")?.Value;
			if (canPrint != null) _canPrint = (bool)canPrint;

			var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
			if (isAdmin != null) _isAdmin = (bool)isAdmin;

			var canChangeUser = _userPermission.SingleOrDefault(x => x.ControlName == "CanChangeUser")?.Value;
			if (canChangeUser != null) _canChangeUser = (bool)canChangeUser;

			var canCreateJob = _userPermission.SingleOrDefault(x => x.ControlName == "CanCreateJob")?.Value;
			if (canCreateJob != null) _canCreateJob = (bool)canCreateJob;

			btnNew.Enabled = _isAdmin || _canAdd;
			btnSave.Enabled = _isAdmin || _canEdit;
			btnSaveAndClose.Enabled = _isAdmin || _canEdit;
			btnSaveAs.Enabled = _isAdmin || _canEdit;
			btnPrint.Enabled = _isAdmin || _canPrint;
			btnCreateNewJob.Enabled = _isAdmin || _canCreateJob;
			btnUrgent.Enabled = true;
			//biSave.Enabled = !_quotationModel.Lost;
			//biSaveAndClose.Enabled = !_quotationModel.Lost;
			//cboHandledBy.ReadOnly = _isAdmin || _canChangeUser;

			if (_quotationModel.Status != EnumStatusType.Requested)
			{
				btnUrgent.Enabled = false;
			}

			CheckQuotationFilterStatus();

			if (_isAdmin)
			{
				dtQuotationDate.ReadOnly = false;
				dtBookedDate.ReadOnly = false;
			}
		}

        private void InitNew()
        {
            if (_quotationModel.ReferenceNo == 0)
            {
                _quotationModel.QuotationDate = DateTime.Now;
                _quotationModel.FollowupDate = DateTime.Now;

                cboStatus.EditValue = EnumStatusType.Requested;
                _quotationModel.Status = EnumStatusType.Requested;

                //TODO: to set default department in general settings 
                cboDepartments.ReadOnly = false;
                btnUrgent.Checked = true;
                AddDefaultDepartments();
            }
            else
            {
                cboDepartments.ReadOnly = true;
                GetTermsDescription();
            }

            //Filters
            rgQuotationStatusOptions.Gallery.GetItemByValue(0).Checked = _quotationModel.Status == EnumStatusType.Requested;
            rgQuotationStatusOptions.Gallery.GetItemByValue(1).Checked = _quotationModel.Status == EnumStatusType.Quoted;
            rgQuotationStatusOptions.Gallery.GetItemByValue(2).Checked = _quotationModel.Status == EnumStatusType.Booked;
            rgQuotationStatusOptions.Gallery.GetItemByValue(3).Checked = _quotationModel.Status == EnumStatusType.Lost;
            rgQuotationStatusOptions.Gallery.GetItemByValue(4).Checked = _quotationModel.Status == EnumStatusType.Canceled;
            rgQuotationStatusOptions.Gallery.GetItemByValue(5).Checked = _quotationModel.Status == EnumStatusType.NotSelected;

        }

        private void AddDefaultDepartments()
        {
            switch (cboDepartments.EditValue)
            {
                case 2:     // AIR EXPORT
                    cboPolList.EditValue = _portRepository.SelectPortByName(PortType.Airport, "Beirut").Id;
                    break;

                case 5:     //AIR IMPORT
                    cboPodList.EditValue = _portRepository.SelectPortByName(PortType.Airport, "Beirut").Id;
                    break;

                case 6:     //LAND FREIGHT

                    break;

                case 8:     //AIR CLEARANCE
                    cboPodList.EditValue = _portRepository.SelectPortByName(PortType.Airport, "Beirut").Id;
                    break;

                case 16:    //SEA IMPORT
                    cboPodList.EditValue = _portRepository.SelectPortByName(PortType.Seaport, "Beirut").Id;
                    break;

                case 17:    //SEA CLEARANCE
                    cboPodList.EditValue = _portRepository.SelectPortByName(PortType.Seaport, "Beirut").Id;
                    break;

                case 18:    //SEA EXPORT
                    cboPolList.EditValue = _portRepository.SelectPortByName(PortType.Seaport, "Beirut").Id;
                    break;

                case 24:    //WAREHOUSE
                    cboPodList.EditValue = _portRepository.SelectPortByName(PortType.Seaport, "Beirut").Id;
                    break;

                case 27:    //SEA CROSS
                    break;

                default:
                    break;

            }
        }

        private void RefreshPorts()
        
        {
            _ports = null;
            if (cboDepartments.EditValue != null)
                _ports = _portRepository.SelectPorts(
                    HelperApplication.SelectPortType((int)cboDepartments.EditValue));

            cboPolList.Properties.DataSource = null;
            cboPolList.Properties.DataSource = _ports;

            cboPodList.Properties.DataSource = null;
            cboPodList.Properties.DataSource = _ports;
        }

        private void FindRelatedJobNo()
        {
            try
            {
                txtJobNo.Text = _quotationHeaderRepository.FindRelatedJobNo(_quotationModel.ReferenceNo, _quotationModel.DepartmentId,
                    _quotationModel.DepartmentPrefix).ToString();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyDefaults()
        {
	        btnCreateNewJob.Enabled = _quotationModel.Id != 0 && _quotationModel.JobNo == 0;
			CheckQuotationFilterStatus();
		}

        private void RefreshCostSellingRecords()
        {
            try
            {
                _quotationCostPriceModels = _quotationCostRepository.TotalQuotationCostPrice(_quotationModel.Id);
                _quotationsSelling = _sellingRepository.TotalQuotationsSellingCost(_quotationModel.Id);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Users Functions


        private void GetTermsDescription()
        {
            try
            {
                if (_quotationModel != null && _quotationModel.TermsId > 0)
                    txtTermDescription.Text = _termRepository.SelectTermById(_quotationModel.TermsId).Description;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion


        #region MenuBottons

        //

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _quotationModel = new QuotationModel();

            InitializeBindings();
            WireUpBindings();
            InitNew();
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!ValidateForm()) return;

            SaveQuotation();
        }

        private bool SaveQuotation()
        {
            try
            {
                if (_quotationModel == null) return false;

                if (_quotationModel.Status == EnumStatusType.Lost || _quotationModel.Status == EnumStatusType.Canceled)
                {
	                string varStatus = _quotationModel.Status == EnumStatusType.Canceled ? "Canceled" : "Lost";
	                XtraMessageBox.Show($@"{varStatus} Quotation cannot be modified.", @"Missing info", MessageBoxButtons.OK,
		                MessageBoxIcon.Exclamation);
	                return false;
                }

				BindingContext[bsQuotations].EndCurrentEdit();
                _quotationModel = bsQuotations.Current as QuotationModel;

                _quotationModel.UrgentDate = _quotationModel.Urgent ? (DateTime?)DateTime.Now : null;

                //update database
                if (_quotationModel.ReferenceNo == 0)
                {
                    var digits = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                    string result = txtXONumber.Text.TrimEnd(digits);

                    //TODO: replace it with _quotationHeaderRepository
                    var newQuotationModel = Task.Run(() => QuotationDal.InsertQuotation(_quotationModel)).Result;
                    txtXONumber.Text = result + newQuotationModel.ReferenceNo.ToString();
                    _quotationModel.ReferenceNo = newQuotationModel.ReferenceNo;
                    var yy = newQuotationModel.FullReferenceNo();

                    StringBuilder shipmentInfo = new StringBuilder();
                    shipmentInfo.Append($@"New Booking for Customer: {cboCustomers.Text}");
                    shipmentInfo.Append(Environment.NewLine);
                    shipmentInfo.Append($@"From: {cboPolList.Text}");
                    shipmentInfo.Append(Environment.NewLine);
                    shipmentInfo.Append($@"To: {cboPodList.Text}");
                    shipmentInfo.Append(Environment.NewLine);
                    shipmentInfo.Append(cboTotalVolume.Text == "" ? $@"INFO N/A" : $@"INFO: {cboTotalVolume.Text}");

                    string xxx = shipmentInfo.ToString();
                    HelperApplication.NotifyByEmail($"New {txtXONumber.Text}",
                        shipmentInfo.ToString());
           
                }
                else
                {
                    if (!_quotationModel.Urgent)
                    {
                        _quotationModel.Urgent = false;
                        _quotationModel.UrgentDate = null;

                    }
                    //StringBuilder shipmentInfo = new StringBuilder();
                    //shipmentInfo.Append($@"New Booking for Customer: {cboCustomers.Text}");
                    //shipmentInfo.Append(Environment.NewLine);
                    //shipmentInfo.Append($@"From: {cboPolList.Text}");
                    //shipmentInfo.Append(Environment.NewLine);
                    //shipmentInfo.Append($@"To: {cboPodList.Text}");
                    //shipmentInfo.Append(Environment.NewLine);
                    //shipmentInfo.Append(cboTotalVolume.Text == "" ? $@"INFO N/A" : $@"INFO: {cboTotalVolume.Text}");

                    //string xxx = shipmentInfo.ToString();

                    _quotationModel.JobNo = _quotationHeaderRepository.FindRelatedJobNo(_quotationModel.ReferenceNo,
                        _quotationModel.DepartmentId, _quotationModel.DepartmentPrefix);

                    //TODO: replace it with _quotationHeaderRepository
                    QuotationDal.UpdateQuotation(_quotationModel);
                    // HelperApplication.NotifyByEmail($"New {txtXONumber.Text}", $"New quotation for Customer: {cboCustomers.Text}");

                }

                cboDepartments.ReadOnly = true;
                SendUpdatedQuotation(_quotationModel, EventArgs.Empty);

            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message,
                    "User save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidateForm()
        {
            var validateReturnValue = true;
            var messageNumber = 0;
            var validateMessage = new StringBuilder();
            if (cboHandledBy.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Handled By cannot be empty.");
                validateReturnValue = false;
                cboHandledBy.Focus();
            }

            if (cboSales.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Sales cannot be empty.");
                validateReturnValue = false;
                cboSales.Focus();
            }

            if (cboDepartments.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Department cannot be empty.");
                validateReturnValue = false;
                cboDepartments.Focus();
            }

            if (cboCustomers.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- Customer cannot be empty.");
                validateReturnValue = false;
                cboCustomers.Focus();
            }

            if (cboPolList.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- POL cannot be empty.");
                validateReturnValue = false;
                cboPolList.Focus();
            }

            if (cboPodList.Text == "")
            {
                messageNumber += 1;
                validateMessage.Append("\n- POD cannot be empty.");
                validateReturnValue = false;
                cboPodList.Focus();
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

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
            SendUpdatedQuotation(_quotationModel, EventArgs.Empty);
        }

        private void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            IEnumerable<BookingSheetReportModel> dataReportModels = QuotationBookingSheetDal.GetBookingSheetReportById(_quotationModel.Id);

            var previewForm = new DocumentViewerForm();
            var report = new BookingSheetReport();

            report.DataSource = dataReportModels;

            previewForm.Viewer.DocumentSource = report;
            previewForm.ShowDialog();
        }


		#endregion

		private void cboDepartmentList_EditValueChanged(object sender, EventArgs e)
		{
			if (_quotationModel.ReferenceNo > 0) return;

			try
			{
				int departmentId = cboDepartments.EditValue as int? ?? 0;

				var department = _departmentRepository.SelectDepartmentById(departmentId);
				if (department != null)
				{
					_quotationModel.DepartmentPrefix = department.Prefix;
				}

				txtXONumber.Text = _quotationModel.FullReferenceNo();

				AddDefaultDepartments();
				RefreshPorts();
				btnCreateNewJob.Enabled = departmentId != 0 && _quotationModel.Id != 0;
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message, "Error Retrieving Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void biSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!ValidateForm()) return;
            if (!SaveQuotation()) return;
            Close();
        }

        private void cboPolList_AddNewValue(object sender, AddNewValueEventArgs e)
        {
            if (_quotationModel.DepartmentId == 16 || _quotationModel.DepartmentId == 17 ||
                _quotationModel.DepartmentId == 18 || _quotationModel.DepartmentId == 27)
            {
                SeaportEditForm seaportForm = new SeaportEditForm(new PortModel());
                seaportForm.SendUpdatedSeaport += RcvUpdatedPolSeaport;
                seaportForm.ShowDialog();
            }
            else if (_quotationModel.DepartmentId == 2 || _quotationModel.DepartmentId == 5 || _quotationModel.DepartmentId == 8)
            {
                AirportEditForm airportForm = new AirportEditForm(new PortModel());
                airportForm.SendUpdatedAirport += RcvUpdatedPolSeaport;
                airportForm.ShowDialog();
            }
            else if (_quotationModel.DepartmentId == 6 || _quotationModel.DepartmentId == 24)
            {
                LandFreightPortEditForm portForm = new LandFreightPortEditForm(new PortModel());
                portForm.SendUpdatedFreightPort += RcvUpdatedPolSeaport;
                portForm.ShowDialog();
            }
        }

        private void cboPodList_AddNewValue(object sender, AddNewValueEventArgs e)
        {
            if (_quotationModel.DepartmentId == 16 || _quotationModel.DepartmentId == 17 ||
                _quotationModel.DepartmentId == 18 || _quotationModel.DepartmentId == 27)
            {
                SeaportEditForm seaportForm = new SeaportEditForm(new PortModel());
                seaportForm.SendUpdatedSeaport += RcvUpdatedPodSeaport;
                seaportForm.ShowDialog();
            }
            else if (_quotationModel.DepartmentId == 2 || _quotationModel.DepartmentId == 5 || _quotationModel.DepartmentId == 8)
            {
                AirportEditForm airportForm = new AirportEditForm(new PortModel());
                airportForm.SendUpdatedAirport += RcvUpdatedPodSeaport;
                airportForm.ShowDialog();
            }
            else if (_quotationModel.DepartmentId == 6 || _quotationModel.DepartmentId == 24)
            {
                LandFreightPortEditForm portForm = new LandFreightPortEditForm(new PortModel());
                portForm.SendUpdatedFreightPort += RcvUpdatedPodSeaport;
                portForm.ShowDialog();
            }
        }

        #region Event Handler

        private void RcvUpdatedPolSeaport(object sender, EventArgs e)
        {
            if (sender == null) return;
            _portModel = sender as PortModel;

            _ports.Add(_portModel);

            cboPolList.Properties.DataSource = null;
            cboPolList.Properties.DataSource = _ports;
            if (_portModel != null) cboPolList.EditValue = _portModel.Id;
        }

        private void RcvUpdatedPodSeaport(object sender, EventArgs e)
        {
            if (sender == null) return;
            _portModel = sender as PortModel;

            _ports.Add(_portModel);

            cboPolList.Properties.DataSource = null;
            cboPolList.Properties.DataSource = _ports;
            if (_portModel != null) cboPolList.EditValue = _portModel.Id;
        }

        private void RcvUpdatedCustomer(object sender, EventArgs e)
        {
            if (sender == null) return;
            var send = sender as MemberModel;

            if (send != null) cboCustomers.EditValue = send.Id;
        }

        private void RcvUpdatedCostSelling(object sender, EventArgs e)
        {
            InitializeBindings();
            WireUpBindings();
        }

        #endregion

        private void cboCustomersList_AddNewValue(object sender, AddNewValueEventArgs e)
        {
            CustomerQuickAddForm customerForm = new CustomerQuickAddForm();
            customerForm.SendUpdatedCustomer += RcvUpdatedCustomer;
            customerForm.ShowDialog();
        }

        private void cboCustomersList_EditValueChanged(object sender, EventArgs e)
        {
            if (cboConsigneesList.Text == "" && cboCustomers.Text != "")
            {
                cboConsigneesList.EditValue = cboCustomers.EditValue;
            }

            if (cboCustomers.Text != "")
            {
                int currentSales = 0;

                currentSales = _userRepository.SelectSalesByCustomerId((int)cboCustomers.EditValue)?.Id ?? 0;

                //TODO: This is example for Null validation
                _quotationModel.SalesId = currentSales;
                cboSales.EditValue = currentSales;
            }
        }

        private void QuotationEditForm_Load(object sender, EventArgs e)
        {
            InitNew();
        }

        private void btnAddCostSelling_Click(object sender, EventArgs e)
        {
            if (_quotationModel.Status == EnumStatusType.Lost || _quotationModel.Status == EnumStatusType.Canceled)
            {
                string varStatus = _quotationModel.Status == EnumStatusType.Canceled ? "Canceled" : "Lost";
                XtraMessageBox.Show($@"{varStatus} Quotation cannot be modified.", @"Missing info", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (!ValidateForm()) return;

            SaveQuotation();

            if (_quotationModel.Id <= 0 || _quotationModel.DepartmentId == 0)
            {
                XtraMessageBox.Show(@"Please finish the transaction first to complete all cost/seeling info details.", @"Missing info", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                cboDepartments.Focus();
                return;
            }

            if (_quotationModel.Status != EnumStatusType.Booked && _quotationModel.BookedDate < DateTime.Today)
            {
                if (XtraMessageBox.Show($@"Quotation# {_quotationModel.FullReferenceNo()} not booked yet." + 
                                Environment.NewLine + $"do you wish to change the booked date to today `{DateTime.Today.ToShortDateString()}`?",
                        "Booked status...", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }

                _quotationModel.BookedDate = DateTime.Now;
                dtBookedDate.EditValue = DateTime.Now;
            }

            int newVersionNo = GetNewVersionNo();

            if (newVersionNo == 0)
            {
                XtraMessageBox.Show(
                    @"An error occurred while getting new version.\nPlease contact your system administrator.",
                    @"Missing Version No.", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            CostSellingSheetForm costSellingForm = new CostSellingSheetForm(new QuotationHeaderModel
            {
                QuotationId = _quotationModel.Id,
                VersionNo = newVersionNo,
                DepartmentId = (int)cboDepartments.EditValue,
                AgentId = (cboAgentsList.EditValue == null || cboAgentsList.Text == "") ? 0 : (int)cboAgentsList.EditValue,
                SeaCarrierId = (cboCarrierList.EditValue == null || cboCarrierList.Text == "") ? 0 : (int)cboCarrierList.EditValue,
                MemberId = cboCustomers.EditValue == null ? 0 : (int)cboCustomers.EditValue,
                QuoteDate = DateTime.Now,
                BookingDate = DateTime.Now,
                TransitTime = 0,
                Validity = 0,
                ValidityDate = DateTime.Now,
                UserId = 1
            });
            costSellingForm.SendUpdatedCostSelling += RcvUpdatedCostSelling;
            costSellingForm.ShowDialog();
        }

        private int GetNewVersionNo()
        {
            int newVersionNo = _quotationHeaderRepository.NewVersionNo(_quotationModel.DepartmentId, _quotationModel.Id);

            return newVersionNo;
        }

        private void btnEditCostSelling_Click(object sender, EventArgs e)
        {
	        if (!_isAdmin && !_canEdit) return;

			if (_quotationModel.Status == EnumStatusType.Lost || _quotationModel.Status == EnumStatusType.Canceled)
            {
                string varStatus = _quotationModel.Status == EnumStatusType.Canceled ? "Canceled" : "Lost";
                XtraMessageBox.Show($@"{varStatus} Quotation cannot be modified.", @"Missing info", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (_quotationModel.Id <= 0 || gvRealCosts.RowCount <= 0) return;

            QuotationHeaderModel costSelling;

            int currentRowId = (int)gvRealCosts.GetFocusedRowCellValue("Id");

            costSelling = _quotationHeaderRepository.QuotationLastVersion(currentRowId) ?? new QuotationHeaderModel();

            costSelling.BookingDate = _quotationModel.BookedDate;
            CostSellingSheetForm costSellingForm = new CostSellingSheetForm(costSelling);
            costSellingForm.SendUpdatedCostSelling += RcvUpdatedCostSelling;
            costSellingForm.ShowDialog();
        }

        private void gcCostList_DoubleClick(object sender, EventArgs e)
        {
	        if (!_isAdmin && !_canEdit) return;

			if (_quotationModel.Id <= 0) return;

            QuotationHeaderModel costSelling;

            int currentRowId = (int)gvRealCosts.GetFocusedRowCellValue("Id");

            costSelling = (_quotationHeaderRepository.QuotationLastVersion(currentRowId) ?? new QuotationHeaderModel()) ??
                          new QuotationHeaderModel();

            CostSellingSheetForm costSellingForm = new CostSellingSheetForm(costSelling);
            costSellingForm.SendUpdatedCostSelling += RcvUpdatedCostSelling;
            costSellingForm.ShowDialog();
        }

        private void gcSellingList_DoubleClick(object sender, EventArgs e)
        {
	        if (!_isAdmin && !_canEdit) return;

			if (_quotationModel.Id <= 0) return;

            QuotationHeaderModel costSelling;

            int currentRowId = (int)gvSellings.GetFocusedRowCellValue("Id");

            costSelling = (_quotationHeaderRepository.QuotationLastVersion(currentRowId) ?? new QuotationHeaderModel()) ??
                          new QuotationHeaderModel();

            CostSellingSheetForm costSellingForm = new CostSellingSheetForm(costSelling);
            costSellingForm.SendUpdatedCostSelling += RcvUpdatedCostSelling;
            costSellingForm.ShowDialog();
        }


        private void btnCreateNewJob_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show(@"Are you sure you want to create a new JOB?",
                    "Confirm create new...", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if(!CreateNewJob()) return;
            }
        }

        private void UpdateCarrierList()
        {
            if (cboCarrierList.Text != string.Empty)
            {
                for (int i = 0; i < gvRealCosts.RowCount; i++)
                {
                    if (gvRealCosts.IsDataRow(i))
                    {
                        gvRealCosts.SetRowCellValue(i, "SeaCarrierId", cboCarrierList.EditValue);
                        gvRealCosts.UpdateCurrentRow();
                        gvRealCosts.RefreshRow(i);

                    }
                }

                for (int i = 0; i < gvSellings.RowCount; i++)
                {
                    if (gvSellings.IsDataRow(i))
                    {
                        gvSellings.SetRowCellValue(i, "SeaCarrierId", cboCarrierList.EditValue);
                        gvSellings.UpdateCurrentRow();
                        gvSellings.RefreshRow(i);

                    }
                }
            }

        }

        private void cboCarrierList_Validated(object sender, EventArgs e)
        {
            UpdateCarrierList();
        }

        //TODO: Example to select value from different field in searchLookupEdit
        private void cboTermsList_EditValueChanged(object sender, EventArgs e)
        {
            GridView view = cboTermsList.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            string fieldName = "Description";
            object value = view.GetRowCellValue(rowHandle, fieldName);

            if (value != null) txtTermDescription.Text = value.ToString() ?? "";
        }

        private void cboTermsList_Validated(object sender, EventArgs e)
        {
            if (cboTermsList.EditValue == null)
            {
                txtTermDescription.Text = "";
            }
            else
            {
                GridView view = cboTermsList.Properties.View;
                int rowHandle = view.FocusedRowHandle;
                string fieldName = "Description";
                object value = view.GetRowCellValue(rowHandle, fieldName);

                if (value != null) txtTermDescription.Text = value.ToString() ?? "";
            }
        }

        private UserModel GetSalesPerson(int memberId)
        {
            UserModel userModel = new UserModel();
            try
            {
                userModel = _userRepository.SelectSalesByCustomerId(memberId);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return userModel;
        }

        private void btnSaveAs_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (_quotationModel.Id == 0) return;

            if (XtraMessageBox.Show(
                    @"This will create a duplicate copy with new XoNo." + Environment.NewLine +
                    "Are you sure to continue?",
                    "Confirm create new...", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    // Save as new quotation
                    QuotationModel newQuotationModel = (QuotationModel)_quotationModel.Clone();

                    newQuotationModel.Id = 0;
                    newQuotationModel.ReferenceNo = 0;
                    _quotationModel = newQuotationModel;

                    SaveQuotation();

                    //QuotationHeaderCostSellingModel newQuotationModel = (QuotationHeaderCostSellingModel)_quotationModel.Clone();
                    //_ = QuotationBookingSheetDal.InsertQuotationHeaderCostSelling(_costSelling);

                    InitializeBindings();
                    WireUpBindings();

                    XtraMessageBox.Show($@"New XoNo '{txtXONumber.Text}' created successfully.", @"New XoNo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnUrgent_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (_quotationModel.Status != EnumStatusType.Requested) return;

            _quotationModel.Urgent = btnUrgent.Checked;

            if (btnUrgent.Checked)
            {
                btnUrgent.ItemAppearance.Normal.Font = new Font("Tahoma", 8, FontStyle.Bold);
                btnUrgent.ItemAppearance.Normal.ForeColor = Color.Red;
                btnUrgent.ItemAppearance.Hovered.Font = new Font("Tahoma", 8, FontStyle.Bold);
                btnUrgent.ItemAppearance.Hovered.ForeColor = Color.Red;
                btnUrgent.ItemAppearance.Pressed.Font = new Font("Tahoma", 8, FontStyle.Bold);
                btnUrgent.ItemAppearance.Pressed.ForeColor = Color.Red;
            }
            else
            {
                btnUrgent.ItemAppearance.Normal.Font = new Font("Tahoma", 8, FontStyle.Regular);
                btnUrgent.ItemAppearance.Normal.ForeColor = Color.Black;
                btnUrgent.ItemAppearance.Hovered.Font = new Font("Tahoma", 8, FontStyle.Regular);
                btnUrgent.ItemAppearance.Hovered.ForeColor = Color.Black;
                btnUrgent.ItemAppearance.Pressed.Font = new Font("Tahoma", 8, FontStyle.Regular);
                btnUrgent.ItemAppearance.Pressed.ForeColor = Color.Black;
            }
        }

        private void cboSales_DoubleClick(object sender, EventArgs e)
        {
            EditSales();
            UpdateSalesName();
        }

        private void btnEditSales_Click(object sender, EventArgs e)
        {
            EditSales();
            UpdateSalesName();
        }

        private void EditSales()
        {
            if (!_customers.Any()) return;

            int currentRowId = (int)cboCustomers.EditValue;
            if (currentRowId == 0) return;

            CustomerModel customerModel = _customers.SingleOrDefault(x => x.Id == currentRowId);
            if (customerModel == null) return;

            var frm = new CustomerEditForm(customerModel);
            frm.SendUpdatedCustomer += RcvUpdatedCustomer;
            frm.ShowDialog();
        }

        private void UpdateSalesName()
        {
            if (cboCustomers.Text != "")
            {
                int currentSales = 0;

                currentSales = _userRepository.SelectSalesByCustomerId((int)cboCustomers.EditValue).Id;

                //TODO: This is example for Null validation
                _quotationModel.SalesId = currentSales;
                cboSales.EditValue = currentSales;
            }
        }

        #region Quotation Options
        private void btnQuoted_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_quotationModel.Id <= 0 || _quotationModel.Status == EnumStatusType.Quoted) return;
        }

        private void btnRequested_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_quotationModel.Id <= 0 || _quotationModel.Status == EnumStatusType.Requested) return;


        }

        private void btnBooked_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_quotationModel.Id <= 0 || _quotationModel.Status == EnumStatusType.Booked) return;
        }

        private void btnLost_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_quotationModel.Id <= 0 || _quotationModel.Status == EnumStatusType.Lost) return;

        }

        //private void btnCanceled_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    if (_quotationModel.Id <= 0 || _quotationModel.Status == EnumStatusType.Canceled) return;

        //    try
        //    {
        //        if (XtraMessageBox.Show($"Are you sure you want to cancel Quotation#: `{txtXONumber.Text}`?",
        //                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        //                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        //        {
        //            //delete record
        //            BindingContext[bsQuotations].EndCurrentEdit();

        //            QuotationDal.CancelQuotation(_quotationModel.Id);
        //            SendUpdatedQuotation(_quotationModel, EventArgs.Empty);
        //            Close();
        //        }

        //    }
        //    catch (Exception exception)
        //    {
        //        XtraMessageBox.Show(exception.Message,
        //            "User delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        #endregion

        private void CheckQuotationFilterStatus()
        {
            GalleryItem itemRequested = rgQuotationStatusOptions.Gallery.GetItemByValue(0);
            GalleryItem itemQuoted = rgQuotationStatusOptions.Gallery.GetItemByValue(1);
            GalleryItem itemBooked = rgQuotationStatusOptions.Gallery.GetItemByValue(2);
            GalleryItem itemLost = rgQuotationStatusOptions.Gallery.GetItemByValue(3);
            GalleryItem itemCanceled = rgQuotationStatusOptions.Gallery.GetItemByValue(4);
            GalleryItem itemNotSelected = rgQuotationStatusOptions.Gallery.GetItemByValue(5);

            if (rgQuotationStatusOptions.Gallery != null)
            {
                itemRequested.Enabled = true;
                itemQuoted.Enabled = true;
                itemBooked.Enabled = true;
                itemLost.Enabled = true;
                itemCanceled.Enabled = true;
                itemNotSelected.Enabled = true;

                if (_quotationModel.Status == EnumStatusType.Requested)
                {
                    itemRequested.Enabled = false;
                    itemNotSelected.Enabled = false;
                }

                if (_quotationModel.Status == EnumStatusType.Quoted)
                {
                    itemRequested.Enabled = false;
                    itemQuoted.Enabled = false;
                    itemNotSelected.Enabled = false;
                }

                if (_quotationModel.Status == EnumStatusType.Booked)
                {
                    itemRequested.Enabled = false;
                    itemQuoted.Enabled = false;
                    itemBooked.Enabled = false;
                    itemNotSelected.Enabled = false;
                }

                if (_quotationModel.Status == EnumStatusType.Lost)
                {
                    itemRequested.Enabled = false;
                    itemQuoted.Enabled = false;
                    itemBooked.Enabled = false;
                    itemLost.Enabled = false;
                    itemCanceled.Enabled = false;
                    itemNotSelected.Enabled = false;
                }

                if (_quotationModel.Status == EnumStatusType.Canceled)
                {
                    itemRequested.Enabled = false;
                    itemQuoted.Enabled = false;
                    itemBooked.Enabled = false;
                    itemLost.Enabled = false;
                    itemCanceled.Enabled = false;
                    itemNotSelected.Enabled = false;
                }
                itemNotSelected.Enabled = _isAdmin;
            }
        }

        private void rgQuotationStatusOptions_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            GalleryItem itemRequested = rgQuotationStatusOptions.Gallery.GetItemByValue(0);
            GalleryItem itemQuoted = rgQuotationStatusOptions.Gallery.GetItemByValue(1);
            GalleryItem itemBooked = rgQuotationStatusOptions.Gallery.GetItemByValue(2);
            GalleryItem itemLost = rgQuotationStatusOptions.Gallery.GetItemByValue(3);
            GalleryItem itemCanceled = rgQuotationStatusOptions.Gallery.GetItemByValue(4);
            GalleryItem itemNotSelected = rgQuotationStatusOptions.Gallery.GetItemByValue(5);

            if (rgQuotationStatusOptions.Gallery != null)
            {
                if (itemRequested.Checked)
                {
                    cboStatus.EditValue = EnumStatusType.Requested;
                    _quotationModel.Booked = false;
                    _quotationModel.BookedDate = null;
                    _quotationModel.Lost = false;
                    _quotationModel.LostDate = null;
                    _quotationModel.Deleted = false;
                    _quotationModel.DeletedDate = null;
                }

                if (itemQuoted.Checked)
                {
                    cboStatus.EditValue = EnumStatusType.Quoted;
                    _quotationModel.Booked = false;
                    _quotationModel.BookedDate = null;
                    _quotationModel.Lost = false;
                    _quotationModel.LostDate = null;
                    _quotationModel.Deleted = false;
                    _quotationModel.DeletedDate = null;
                    _quotationModel.QuotedDate = DateTime.Now;
                }

                if (itemBooked.Checked)
                {
                    SetBooked();
                }

                if (itemLost.Checked)
                {
                    cboStatus.EditValue = EnumStatusType.Lost;
                    if (_quotationModel.ReferenceNo <= 0) return;
                    cboStatus.EditValue = EnumStatusType.Lost;

                    //lblreason.Visibility = (chkLost.Checked == true) ? LayoutVisibility.Always : LayoutVisibility.Never;
                    _quotationModel.LostDate = _quotationModel.LostDate ?? DateTime.Now;
                    _quotationModel.Urgent = false;
                    btnUrgent.Checked = false;

                    _quotationModel.Booked = false;
                    _quotationModel.BookedDate = null;
                    _quotationModel.Deleted = false;
                    _quotationModel.DeletedDate = null;
                }

                if (itemCanceled.Checked)
                {
                    cboStatus.EditValue = EnumStatusType.Canceled;
                    _quotationModel.Booked = false;
                    _quotationModel.BookedDate = null;
                    _quotationModel.Lost = false;
                    _quotationModel.LostDate = null;
                    _quotationModel.Deleted = true;
                    _quotationModel.DeletedDate = DateTime.Now;
                }

                if (itemNotSelected.Checked)
                {
                    if (XtraMessageBox.Show($@"This action will reset Quote `{txtXONumber.Text}` selection.?",
                            $@"Reset Quote# `{txtXONumber.Text}`", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.No)
                    {
                        CheckQuotationFilterStatus();
                        return;
                    }

                    cboStatus.EditValue = EnumStatusType.NotSelected;
                    _quotationModel.Status = EnumStatusType.NotSelected;
                    _quotationModel.Booked = false;
                    _quotationModel.BookedDate = null;
                    _quotationModel.QuotedDate = null;
                    _quotationModel.Lost = false;
                    _quotationModel.LostDate = null;
                    _quotationModel.Deleted = false;
                    _quotationModel.DeletedDate = null;

                    itemRequested.Enabled = true;
                    itemQuoted.Enabled = true;
                    itemBooked.Enabled = true;
                    itemLost.Enabled = true;
                    itemCanceled.Enabled = true;
                }
            }
        }

        private void SetBooked()
        {
            if (_quotationModel.ReferenceNo <= 0) return;

            if (_quotationModel.BookedDate == null)
            {
                _quotationModel.BookedDate = DateTime.Now;
                dtBookedDate.DateTime = DateTime.Now;
            }
            else
            {
                if (dtBookedDate.DateTime.Date < DateTime.Now.Date && dtBookedDate.DateTime.Date != null)
                {
                    if (XtraMessageBox.Show($@"Booked Date `{dtBookedDate.DateTime}` registered with different date of today: 
                                `{DateTime.Now}`." + Environment.NewLine + "Do you want to update and change it to today date?",
                            "Booking date changed...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        dtBookedDate.DateTime = DateTime.Now;
                    }
                }
            }
            cboStatus.EditValue = EnumStatusType.Booked;

            if (_quotationModel.ReferenceNo > 0) return;
            if (!ValidateForm()) return;

            CostSellingSheetForm costForm = new CostSellingSheetForm(new QuotationHeaderModel());
            costForm.SendUpdatedCostSelling += RcvUpdatedCostSelling;
            costForm.ShowDialog();

            if (XtraMessageBox.Show($@"Do you want to create a new Job for the XoNo: {txtXONumber.Text}?",
                    "Creating new Job Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // Add new job
                //_quotationModel.BookedDate = DateTime.Now;
            }
        }

        private bool CreateNewJob()
        {
            try
            {
	            //get quotation department

	            if (cboDepartments == null) return false;

	            int department = (int)cboDepartments.EditValue;


	            return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



    }
}