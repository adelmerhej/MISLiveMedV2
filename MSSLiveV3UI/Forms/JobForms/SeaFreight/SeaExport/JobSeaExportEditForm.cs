using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout.Utils;
using MISLiveMed.DataLayers.Accounting.Costs;
using MISLiveMed.DataLayers.Accounting.Invoices;
using MISLiveMed.DataLayers.Common.Carriers;
using MISLiveMed.DataLayers.Common.Conditions;
using MISLiveMed.DataLayers.Common.Countries;
using MISLiveMed.DataLayers.Common.Countries.Ports;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Common.JobsType;
using MISLiveMed.DataLayers.Common.Terms;
using MISLiveMed.DataLayers.CRM.Agents;
using MISLiveMed.DataLayers.CRM.Agents.Shippers;
using MISLiveMed.DataLayers.CRM.Customers;
using MISLiveMed.DataLayers.JobData.Common;
using MISLiveMed.DataLayers.JobData.SeaExport;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.CostSheets;
using MISLiveMed.Models.Models.Accounting.Invoices;
using MISLiveMed.Models.Models.Common.Carriers;
using MISLiveMed.Models.Models.Common.Conditions;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Common.Countries.Ports;
using MISLiveMed.Models.Models.Common.Documents;
using MISLiveMed.Models.Models.Common.JobsType;
using MISLiveMed.Models.Models.Common.Terms;
using MISLiveMed.Models.Models.JobModels;
using MISLiveMed.Models.Models.JobModels.Export.SeaFreight.Jobs;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Members.Agents.Shippers;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MISLiveMed.UI.Forms.JobForms.SeaFreight.SeaExport
{
	public partial class JobSeaExportEditForm : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		private const string _formName = "JobSeaExportEdit";
		private int _formId;

		private DataEntityState _objState = DataEntityState.Unchanged;

		DXMenuItem[] _menuItems;

		private JobSeaExportModel _jobSeaExportModel = new JobSeaExportModel();
		private IList<JobSeaExportDetailModel> _jobSeaExportDetails = new List<JobSeaExportDetailModel>();
		private IList<ShipperModel> _shippers = new List<ShipperModel>();
		private IList<UserModel> _users = new List<UserModel>();
		private UserModel _userModel = new UserModel();

		//CustomerModel
		private CustomerModel _customerModel = new CustomerModel();
		private IList<CustomerModel> _customers = new List<CustomerModel>();

		private IList<JobTypeModel> _jobTypes = new List<JobTypeModel>();

		private VesselModel _vesselModel = new VesselModel();
		private IList<VesselModel> _vessels = new List<VesselModel>();
		private IList<VesselModel> _feederVessels = new List<VesselModel>();

		private IList<AgentModel> _agents = new List<AgentModel>();
		private IList<AgentModel> _seaCarriers = new List<AgentModel>();
		private IList<TermsModel> _terms = new List<TermsModel>();
		private IList<AgentCategoryModel> _agentCategories = new List<AgentCategoryModel>();

		private PortModel _seaportModel = new PortModel();
		private IList<PortModel> _seaports = new List<PortModel>();

		private IList<CountryModel> _countries = new List<CountryModel>();

		private IList<ConditionDetailModel> _tblConditionDetails = new List<ConditionDetailModel>();
		private IList<ConditionDetailModel> _owConditionDetails = new List<ConditionDetailModel>();

		private IList<RequiredDocumentModel> _requiredDocumentsToBeLoaded = new List<RequiredDocumentModel>();
		private IList<RequiredDocumentModel> _requiredDocumentsOnWater = new List<RequiredDocumentModel>();

		private IList<DocumentModel> _documents = new List<DocumentModel>();
		private DocumentModel _currentDocument = new DocumentModel();

		//Invoice data
		private InvoiceModel _invoiceModel = new InvoiceModel();
		private IList<InvoiceModel> _invoices = new List<InvoiceModel>();

		//Cost Sheet
		private CostModel _costModel = new CostModel();
		private IList<CostModel> _costs = new List<CostModel>();

		private readonly JobSeaExportRepository _jobSeaExportRepository = new JobSeaExportRepository();
		private readonly JobSeaExportDetailRepository _jobSeaExportDetailRepository = new JobSeaExportDetailRepository();
		private readonly UserRepository _userRepository = new UserRepository();
		private readonly CustomerRepository _customerRepository = new CustomerRepository();
		private readonly JobTypeRepository _jobTypeRepository = new JobTypeRepository();
		private readonly VesselRepository _vesselRepository = new VesselRepository();
		private readonly AgentRepository _agentRepository = new AgentRepository();
		private readonly TermRepository _termRepository = new TermRepository();
		private readonly SeaportRepository _seaportRepository = new SeaportRepository();
		private readonly CountryRepository _countryRepository = new CountryRepository();
		private readonly RequiredDocumentRepository _requiredDocumentRepository = new RequiredDocumentRepository();
		private readonly ShipperRepository _shipperRepository = new ShipperRepository();
		private readonly AgentCategoryRepository _agentCategoryRepository = new AgentCategoryRepository();

		private readonly InvoiceRepository _invoiceRepository = new InvoiceRepository();
		private readonly CostRepository _costRepository = new CostRepository();

		private readonly ConditionDetailRepository _conditionDetailRepository = new ConditionDetailRepository();

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

		public EventHandler SendUpdatedJobSeaExport;

		public JobSeaExportEditForm(JobSeaExportModel model)
		{
			InitializeComponent();

			_jobSeaExportModel = model;

			StartLoading();
		}

		private void StartLoading()
		{
			try
			{
				InitializeBindings();
				WireUpBindings();
				ApplyDefaults();
				ApplyPermissions();
				InitializeMenuItems();
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
				_formId = _formRepository.SelectFormByName(_formName);
				_userPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, _formId);

				_jobSeaExportDetails = _jobSeaExportModel.JobNo == 0
					? new List<JobSeaExportDetailModel>()
					: _jobSeaExportDetailRepository.JobsSeaExportDetailByJobNo(_jobSeaExportModel.JobNo);

				_users = _userRepository.SelectUsers();
				_userModel = _userRepository.SelectUserById(CurrentUser.UserId);
				_userPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, _formId);

				_customers = _customerRepository.SelectCustomers();
				_agents = _agentRepository.SelectAgents();

				_jobTypes = _jobTypeRepository.SelectJobsType();
				_vessels = _vesselRepository.SeaVesselByCategoryId(false, false);
				_feederVessels = _vesselRepository.SeaVesselByCategoryId(true, false);
				_terms = _termRepository.SelectTerms();
				_seaports = _seaportRepository.SelectSeaports();
				_countries = _countryRepository.SelectCountries();
				_agentCategories = _agentCategoryRepository.SelectAgentCategories();
				//_seaCarriers = _agentRepository.SelectAgentByCategoryId(_jobSeaExportModel.ShippedWithId, false, false);

				//Gather Requirements

				_tblConditionDetails = _conditionDetailRepository.SelectConditionDetails((int)ConditionSelection.ToBeLoaded, CurrentUser.CompanyId, true);
				_owConditionDetails = _conditionDetailRepository.SelectConditionDetails((int)ConditionSelection.OnWater, CurrentUser.CompanyId, true);

				_requiredDocumentsToBeLoaded
					= _requiredDocumentRepository.JobRequiredDocumentsList(_jobSeaExportModel.JobNo, _jobSeaExportModel.DepartmentId, (int)ConditionSelection.ToBeLoaded, CurrentUser.CompanyId);
				_requiredDocumentsOnWater
					= _requiredDocumentRepository.JobRequiredDocumentsList(_jobSeaExportModel.JobNo, _jobSeaExportModel.DepartmentId, (int)ConditionSelection.OnWater, CurrentUser.CompanyId);

				//Update/Merge Conditions...
				_jobSeaExportDetailRepository.JobsSeaExportDetailByJobNo(1);

				//Gather related invoices
				_invoices = _invoiceRepository.SelectInvoicesByJobNo(_jobSeaExportModel.JobNo, _jobSeaExportModel.DepartmentId);

				//Gather related Costs
				_costs = _costRepository.SelectCostByJobNo(_jobSeaExportModel.JobNo, _jobSeaExportModel.DepartmentId);

				_shippers = _shipperRepository.SelectShippers();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsJobSeaExport.DataSource = _jobSeaExportModel;
			bsJobSeaExportDetails.DataSource = _jobSeaExportDetails;

			//Invoices
			bsInvoices.DataSource = null;
			bsInvoices.DataSource = _invoices;

			//Cost Sheet
			bsCosts.DataSource = null;
			bsCosts.DataSource = _costs;

			cboCustomers.Properties.DataSource = null;
			cboCustomers.Properties.DataSource = _customers;
			cboCustomers.EditValue = _jobSeaExportModel.CustomerId;

			cboConsignees.Properties.DataSource = null;
			cboConsignees.Properties.DataSource = _customers;
			cboConsignees.EditValue = _jobSeaExportModel.ConsigneeId;

			cboJobsType.Properties.DataSource = null;
			cboJobsType.Properties.DataSource = _jobTypes;
			cboJobsType.EditValue = _jobSeaExportModel.JobTypeId;

			cboVessels.Properties.DataSource = null;
			cboVessels.Properties.DataSource = _vessels;
			cboVessels.EditValue = _jobSeaExportModel.VesselId;

			cboFeederVessels.Properties.DataSource = null;
			cboFeederVessels.Properties.DataSource = _feederVessels;
			cboFeederVessels.EditValue = _jobSeaExportModel.FeederVesselId;

			cboAgents.Properties.DataSource = null;
			cboAgents.Properties.DataSource = _agents;
			cboAgents.EditValue = _jobSeaExportModel.AgentId;

			cboIncoTerms.Properties.DataSource = null;
			cboIncoTerms.Properties.DataSource = _terms;
			cboIncoTerms.EditValue = _jobSeaExportModel.IncoTerms;

			cboDeparture.Properties.DataSource = null;
			cboDeparture.Properties.DataSource = _seaports;
			cboDeparture.EditValue = _jobSeaExportModel.SeaportDeparture;

			cboDestination.Properties.DataSource = null;
			cboDestination.Properties.DataSource = _seaports;
			cboDestination.EditValue = _jobSeaExportModel.SeaportDestination;

			cboUsers.Properties.DataSource = null;
			cboUsers.Properties.DataSource = _users;
			cboUsers.EditValue = _jobSeaExportModel.UserId;

			cboSales.Properties.DataSource = null;
			cboSales.Properties.DataSource = _users;
			cboSales.EditValue = _jobSeaExportModel.SalesId;

			cboShippedWith.Properties.DataSource = null;
			cboShippedWith.Properties.DataSource = _agentCategories;
			cboShippedWith.EditValue = _jobSeaExportModel.ShippedWithId;

			cboSeaCarriers.Properties.DataSource = null;
			cboSeaCarriers.Properties.DataSource = _seaCarriers;
			cboSeaCarriers.EditValue = _jobSeaExportModel.SideId;

			cboOperatingUsers.Properties.DataSource = null;
			cboOperatingUsers.Properties.DataSource = _users;
			cboOperatingUsers.EditValue = _jobSeaExportModel.OperatingUserId;

			repCountries.DataSource = null;
			repCountries.DataSource = _countries;

			repShippers.DataSource = null;
			repShippers.DataSource = _shippers;

			repTblConditionsList.DataSource = null;
			repTblConditionsList.DataSource = _tblConditionDetails;

			repOWConditionsList.DataSource = null;
			repOWConditionsList.DataSource = _owConditionDetails;

			gcRequiredToBeLoaded.DataSource = null;
			gcRequiredToBeLoaded.DataSource = _requiredDocumentsToBeLoaded;

			gcRequiredOnWater.DataSource = null;
			gcRequiredOnWater.DataSource = _requiredDocumentsOnWater;

			btnProtected.Checked = _jobSeaExportModel.IsProtected;

			// Keep requirements UI state in sync
			EnsureRequirementsUiState();

		}

		private bool IsToBeLoadedAllInOrderAchieved()
		{
			var view = gvRequiredToBeLoaded;
			if (view == null) return false;
			if (view.DataRowCount <= 0) return false;

			for (int i = 0; i < view.DataRowCount; i++)
			{
				if (view.IsGroupRow(i) || view.IsNewItemRow(i)) continue;

				bool isRequired = view.GetRowCellValue(i, "IsRequired") is bool r && r;
				if (!isRequired) continue;

				bool isFulFilled = view.GetRowCellValue(i, "IsFulFilled") is bool f && f;
				if (!isFulFilled) return false;
			}

			return true;
		}

		private bool IsOnWaterAllInOrderAchieved()
		{
			var view = gvRequiredOnWater;
			if (view == null) return false;
			if (view.DataRowCount <= 0) return false;

			for (int i = 0; i < view.DataRowCount; i++)
			{
				if (view.IsGroupRow(i) || view.IsNewItemRow(i)) continue;

				bool isRequired = view.GetRowCellValue(i, "IsRequired") is bool r && r;
				if (!isRequired) continue;

				bool isFulFilled = view.GetRowCellValue(i, "IsFulFilled") is bool f && f;
				if (!isFulFilled) return false;
			}

			return true;
		}

		private void EnsureRequirementsUiState()
		{
			// To Be Loaded side
			bool allInOrderTBL = _jobSeaExportModel?.AllInOrderToBeLoaded == true || IsToBeLoadedAllInOrderAchieved();
			_jobSeaExportModel.AllInOrderToBeLoaded = allInOrderTBL;
			lcAllInOrderToBeloaded.Visibility = allInOrderTBL ? LayoutVisibility.Always : LayoutVisibility.Never;
			btnAllInOrderTBL.Text = ToggleInOrderSetting(allInOrderTBL);
			//gcRequiredToBeLoaded.Enabled = !allInOrderTBL;
			gvRequiredToBeLoaded.OptionsBehavior.Editable = !allInOrderTBL;
			gvRequiredToBeLoaded.OptionsBehavior.ReadOnly = allInOrderTBL;

			// On Water side
			bool allInOrderOW = _jobSeaExportModel?.AllInOrderOnWater == true || IsOnWaterAllInOrderAchieved();
			_jobSeaExportModel.AllInOrderOnWater = allInOrderOW;
			lcAllInOrderOnWater.Visibility = allInOrderOW ? LayoutVisibility.Always : LayoutVisibility.Never;
			btnAllInOrderOW.Text = ToggleInOrderSetting(allInOrderOW);
			//gcRequiredOnWater.Enabled = !allInOrderOW;
			gvRequiredOnWater.OptionsBehavior.Editable = !allInOrderOW;
			gvRequiredOnWater.OptionsBehavior.ReadOnly = allInOrderOW;
		}

		private void ApplyPermissions()
		{
			dtJobDate.ReadOnly = true; // _userModel.SecurityLevel > 2;
			cboUsers.ReadOnly = true; //_userModel.SecurityLevel > 2;
			cboSales.ReadOnly = true; //_userModel.SecurityLevel > 2;
			cboOperatingUsers.ReadOnly = true; //userModel.SecurityLevel > 2;

			//rpSettings.Visible = _userModel.UserLevel < 3;

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

			var isProtected = _userPermission.SingleOrDefault(x => x.ControlName == "IsProtected")?.Value;
			if (isProtected != null) _isProtected = (bool)isProtected;

			btnNew.Enabled = _isAdmin || _canAdd;
			btnSave.Enabled = _isAdmin || _canEdit;
			btnSaveAndClose.Enabled = _isAdmin || _canEdit;
			btnPrint.Enabled = _isAdmin || _canPrint;
			btnDelete.Enabled = _isAdmin || _canDelete;
			btnProtected.Enabled = _isAdmin;
		}

		private void ApplyDefaults()
		{
			tabGroupNotes.SelectedTabPageIndex = 0;
			tabDetails.SelectedPageIndex = 0;

			lcAllInOrderToBeloaded.Visibility = _jobSeaExportModel.AllInOrderToBeLoaded ? LayoutVisibility.Always : LayoutVisibility.Never;
			lcAllInOrderOnWater.Visibility = _jobSeaExportModel.AllInOrderOnWater ? LayoutVisibility.Always : LayoutVisibility.Never;
			btnAllInOrderTBL.Text = ToggleInOrderSetting(_jobSeaExportModel.AllInOrderToBeLoaded);
			btnAllInOrderOW.Text = ToggleInOrderSetting(_jobSeaExportModel.AllInOrderOnWater);

			//EnumJobStatus
			rgJobStatusAction.Gallery.GetItemByValue(0).Checked = _jobSeaExportModel.JobStatus == EnumJobStatus.NormalMod;
			rgJobStatusAction.Gallery.GetItemByValue(1).Checked = _jobSeaExportModel.JobStatus == EnumJobStatus.ClosedMod;
			rgJobStatusAction.Gallery.GetItemByValue(2).Checked = _jobSeaExportModel.JobStatus == EnumJobStatus.EditMod;
			rgJobStatusAction.Gallery.GetItemByValue(3).Checked = _jobSeaExportModel.JobStatus == EnumJobStatus.CanceledMod;
			rgJobStatusAction.Gallery.GetItemByValue(4).Checked = _jobSeaExportModel.JobStatus == EnumJobStatus.ReOpenedMod; ;
			rgJobStatusAction.Gallery.GetItemByValue(5).Checked = _jobSeaExportModel.JobStatus == EnumJobStatus.NotSelectedMod;

			if (_jobSeaExportModel.Id == 0)
			{
				_jobSeaExportModel.JobDate = DateTime.Now;
				_jobSeaExportModel.JobStatus = EnumJobStatus.NormalMod;
				_jobSeaExportModel.DepartmentId = (int)JobsType.SeaExport;
				_jobSeaExportModel.CompanyId = CurrentUser.CompanyId;
				_jobSeaExportModel.UserId = CurrentUser.UserId;
				_jobSeaExportModel.OperatingUserId = CurrentUser.UserId;

				cboUsers.EditValue = _jobSeaExportModel.UserId;
				cboOperatingUsers.EditValue = _jobSeaExportModel.OperatingUserId;

				_objState = DataEntityState.Added;
			}
		}

		private void InitJobDetailsGrid()
		{
			//_jobSeaExportDetails = new List<JobSeaExportDetailsModel>
			//{

			//}

			//bsJobSeaExportDetails.Add(_jobSeaExportDetails);
		}

		void InitializeMenuItems()
		{
			DXMenuItem itemEdit = new DXMenuItem("Edit", ItemEdit_Click);
			DXMenuItem itemDelete = new DXMenuItem("Delete", ItemDelete_Click);
			_menuItems = new[] { itemEdit, itemDelete };
		}

		private string ToggleInOrderSetting(bool isAllInOrder)
		{
			string strOrigin = " ".PadLeft(4) + "<< All In Order".PadRight(20);
			string strAllInOrder = " ".PadLeft(4) + "Clear All In Order".PadRight(20);

			var allInOrderMessage = new StringBuilder();
			allInOrderMessage.Append(isAllInOrder ? strAllInOrder : strOrigin);

			return allInOrderMessage.ToString();
		}

		#region Grid Popup menu 

		private void ItemEdit_Click(object sender, EventArgs e)
		{
			//gvQuotationCost.ShowEditor();
		}

		private void ItemDelete_Click(object sender, EventArgs e)
		{
			if (XtraMessageBox.Show(@"Delete row?", @"Confirmation", MessageBoxButtons.YesNo) !=
				DialogResult.Yes)
				return;
			GridView view = sender as GridView;
			if (view != null)
			{
				view.SetRowCellValue(view.FocusedRowHandle, "Deleted", true);
				view.DeleteRow(gvJobDetails.FocusedRowHandle);
			}

			//switch (tabPane1.SelectedPage.Name)
			//{
			//    case "tabRealCostGroup":
			//        gvQuotationCost.SetRowCellValue(gvQuotationCost.FocusedRowHandle, "Deleted", true);
			//        break;

			//    case "tabSellingGroup":
			//        gvQuotationSelling.SetRowCellValue(gvQuotationSelling.FocusedRowHandle, "Deleted", true);
			//        break;
			//}
		}

		#endregion


	}
}