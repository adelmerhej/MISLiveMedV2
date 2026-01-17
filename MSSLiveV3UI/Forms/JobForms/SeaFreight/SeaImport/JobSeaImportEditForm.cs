using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
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
using MISLiveMed.DataLayers.JobData.SeaImport;
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
using MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Members.Agents.Shippers;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Accounting.Invoices;
using MISLiveMed.UI.Forms.Common.Carriers;
using MISLiveMed.UI.Forms.Common.Countries.Ports;
using MISLiveMed.UI.Forms.CRM.Customers;
using MISLiveMed.UI.Main;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MISLiveMed.UI.Forms.JobForms.SeaFreight.SeaImport
{
	public partial class JobSeaImportEditForm : RibbonForm
	{
		private const string _formName = "JobSeaImportEdit";
		private int _formId;

		private DataEntityState _objState = DataEntityState.Unchanged;

		DXMenuItem[] _menuItems;

		private JobSeaImportModel _jobSeaImportModel = new JobSeaImportModel();
		private IList<JobSeaImportDetailModel> _jobSeaImportDetails = new List<JobSeaImportDetailModel>();
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

		private readonly JobSeaImportRepository _jobSeaImportRepository = new JobSeaImportRepository();
		private readonly JobSeaImportDetailRepository _jobSeaImportDetailRepository = new JobSeaImportDetailRepository();
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

		public EventHandler SendUpdatedJobSeaImport;

		public JobSeaImportEditForm(JobSeaImportModel model)
		{
			InitializeComponent();

			_jobSeaImportModel = model;

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

				_jobSeaImportDetails = _jobSeaImportModel.JobNo == 0
					? new List<JobSeaImportDetailModel>()
					: _jobSeaImportDetailRepository.JobsSeaImportDetailByJobNo(_jobSeaImportModel.JobNo);

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
				//_seaCarriers = _agentRepository.SelectAgentByCategoryId(_jobSeaImportModel.ShippedWithId, false, false);

				//Gather Requirements

				_tblConditionDetails = _conditionDetailRepository.SelectConditionDetails((int)ConditionSelection.ToBeLoaded, CurrentUser.CompanyId, true);
				_owConditionDetails = _conditionDetailRepository.SelectConditionDetails((int)ConditionSelection.OnWater, CurrentUser.CompanyId, true);

				_requiredDocumentsToBeLoaded
					= _requiredDocumentRepository.JobRequiredDocumentsList(_jobSeaImportModel.JobNo, _jobSeaImportModel.DepartmentId, (int)ConditionSelection.ToBeLoaded, CurrentUser.CompanyId);
				_requiredDocumentsOnWater
					= _requiredDocumentRepository.JobRequiredDocumentsList(_jobSeaImportModel.JobNo, _jobSeaImportModel.DepartmentId, (int)ConditionSelection.OnWater, CurrentUser.CompanyId);

				//Update/Merge Conditions...
				_jobSeaImportDetailRepository.JobsSeaImportDetailByJobNo(1);

				//Gather related invoices
				_invoices = _invoiceRepository.SelectInvoicesByJobNo(_jobSeaImportModel.JobNo, _jobSeaImportModel.DepartmentId);

				//Gather related Costs
				_costs = _costRepository.SelectCostByJobNo(_jobSeaImportModel.JobNo, _jobSeaImportModel.DepartmentId);

				_shippers = _shipperRepository.SelectShippers();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsJobSeaImport.DataSource = _jobSeaImportModel;
			bsJobSeaImportDetails.DataSource = _jobSeaImportDetails;

			//Invoices
			bsInvoices.DataSource = null;
			bsInvoices.DataSource = _invoices;

			//Cost Sheet
			bsCosts.DataSource = null;
			bsCosts.DataSource = _costs;

			cboCustomers.Properties.DataSource = null;
			cboCustomers.Properties.DataSource = _customers;
			cboCustomers.EditValue = _jobSeaImportModel.CustomerId;

			cboConsignees.Properties.DataSource = null;
			cboConsignees.Properties.DataSource = _customers;
			cboConsignees.EditValue = _jobSeaImportModel.ConsigneeId;

			cboJobsType.Properties.DataSource = null;
			cboJobsType.Properties.DataSource = _jobTypes;
			cboJobsType.EditValue = _jobSeaImportModel.JobTypeId;

			cboVessels.Properties.DataSource = null;
			cboVessels.Properties.DataSource = _vessels;
			cboVessels.EditValue = _jobSeaImportModel.VesselId;

			cboFeederVessels.Properties.DataSource = null;
			cboFeederVessels.Properties.DataSource = _feederVessels;
			cboFeederVessels.EditValue = _jobSeaImportModel.FeederVesselId;

			cboAgents.Properties.DataSource = null;
			cboAgents.Properties.DataSource = _agents;
			cboAgents.EditValue = _jobSeaImportModel.AgentId;

			cboIncoTerms.Properties.DataSource = null;
			cboIncoTerms.Properties.DataSource = _terms;
			cboIncoTerms.EditValue = _jobSeaImportModel.IncoTerms;

			cboDeparture.Properties.DataSource = null;
			cboDeparture.Properties.DataSource = _seaports;
			cboDeparture.EditValue = _jobSeaImportModel.SeaportDeparture;

			cboDestination.Properties.DataSource = null;
			cboDestination.Properties.DataSource = _seaports;
			cboDestination.EditValue = _jobSeaImportModel.SeaportDestination;

			cboUsers.Properties.DataSource = null;
			cboUsers.Properties.DataSource = _users;
			cboUsers.EditValue = _jobSeaImportModel.UserId;

			cboSales.Properties.DataSource = null;
			cboSales.Properties.DataSource = _users;
			cboSales.EditValue = _jobSeaImportModel.SalesId;

			cboShippedWith.Properties.DataSource = null;
			cboShippedWith.Properties.DataSource = _agentCategories;
			cboShippedWith.EditValue = _jobSeaImportModel.ShippedWithId;

			cboSeaCarriers.Properties.DataSource = null;
			cboSeaCarriers.Properties.DataSource = _seaCarriers;
			cboSeaCarriers.EditValue = _jobSeaImportModel.SideId;

			cboOperatingUsers.Properties.DataSource = null;
			cboOperatingUsers.Properties.DataSource = _users;
			cboOperatingUsers.EditValue = _jobSeaImportModel.OperatingUserId;

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

			btnProtected.Checked = _jobSeaImportModel.IsProtected;

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
			bool allInOrderTBL = _jobSeaImportModel?.AllInOrderToBeLoaded == true || IsToBeLoadedAllInOrderAchieved();
			_jobSeaImportModel.AllInOrderToBeLoaded = allInOrderTBL;
			lcAllInOrderToBeloaded.Visibility = allInOrderTBL ? LayoutVisibility.Always : LayoutVisibility.Never;
			btnAllInOrderTBL.Text = ToggleInOrderSetting(allInOrderTBL);
			//gcRequiredToBeLoaded.Enabled = !allInOrderTBL;
			gvRequiredToBeLoaded.OptionsBehavior.Editable = !allInOrderTBL;
			gvRequiredToBeLoaded.OptionsBehavior.ReadOnly = allInOrderTBL;

			// On Water side
			bool allInOrderOW = _jobSeaImportModel?.AllInOrderOnWater == true || IsOnWaterAllInOrderAchieved();
			_jobSeaImportModel.AllInOrderOnWater = allInOrderOW;
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

			lcAllInOrderToBeloaded.Visibility = _jobSeaImportModel.AllInOrderToBeLoaded ? LayoutVisibility.Always : LayoutVisibility.Never;
			lcAllInOrderOnWater.Visibility = _jobSeaImportModel.AllInOrderOnWater ? LayoutVisibility.Always : LayoutVisibility.Never;
			btnAllInOrderTBL.Text = ToggleInOrderSetting(_jobSeaImportModel.AllInOrderToBeLoaded);
			btnAllInOrderOW.Text = ToggleInOrderSetting(_jobSeaImportModel.AllInOrderOnWater);

			//EnumJobStatus
			rgJobStatusAction.Gallery.GetItemByValue(0).Checked = _jobSeaImportModel.JobStatus == EnumJobStatus.NormalMod;
			rgJobStatusAction.Gallery.GetItemByValue(1).Checked = _jobSeaImportModel.JobStatus == EnumJobStatus.ClosedMod;
			rgJobStatusAction.Gallery.GetItemByValue(2).Checked = _jobSeaImportModel.JobStatus == EnumJobStatus.EditMod;
			rgJobStatusAction.Gallery.GetItemByValue(3).Checked = _jobSeaImportModel.JobStatus == EnumJobStatus.CanceledMod;
			rgJobStatusAction.Gallery.GetItemByValue(4).Checked = _jobSeaImportModel.JobStatus == EnumJobStatus.ReOpenedMod; ;
			rgJobStatusAction.Gallery.GetItemByValue(5).Checked = _jobSeaImportModel.JobStatus == EnumJobStatus.NotSelectedMod;

			if (_jobSeaImportModel.Id == 0)
			{
				_jobSeaImportModel.JobDate = DateTime.Now;
				_jobSeaImportModel.JobStatus = EnumJobStatus.NormalMod;
				_jobSeaImportModel.DepartmentId = (int)JobsType.SeaImport;
				_jobSeaImportModel.CompanyId = CurrentUser.CompanyId;
				_jobSeaImportModel.UserId = CurrentUser.UserId;
				_jobSeaImportModel.OperatingUserId = CurrentUser.UserId;

				cboUsers.EditValue = _jobSeaImportModel.UserId;
				cboOperatingUsers.EditValue = _jobSeaImportModel.OperatingUserId;

				_objState = DataEntityState.Added;
			}
		}

		private void InitJobDetailsGrid()
		{
			//_jobSeaImportDetails = new List<JobSeaImportDetailsModel>
			//{

			//}

			//bsJobSeaImportDetails.Add(_jobSeaImportDetails);
		}

		void InitializeMenuItems()
		{
			DXMenuItem itemEdit = new DXMenuItem("Edit", ItemEdit_Click);
			DXMenuItem itemDelete = new DXMenuItem("Delete", ItemDelete_Click);
			_menuItems = new[] { itemEdit, itemDelete };
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


		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			_jobSeaImportModel = new JobSeaImportModel();
			StartLoading();

			InitJobDetailsGrid();
			_objState = DataEntityState.Added;
		}

		private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!ValidateData()) return;
			SaveData();
		}

		private void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!ValidateData()) return;
			SaveData();
			Close();
		}

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{
			InitializeBindings();
			WireUpBindings();
		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			//Delete
		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{
			//Print
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

		private bool ValidateData()
		{
			var validateReturnValue = true;
			var messageNumber = 0;
			var validateMessage = new StringBuilder();

			if (txtReferenceNo.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- XoNo cannot be empty.");
				validateReturnValue = false;
				txtReferenceNo.Focus();
			}

			if (cboCustomers.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Customer cannot be empty.");
				validateReturnValue = false;
				cboCustomers.Focus();
			}

			if (cboConsignees.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Consignee cannot be empty.");
				validateReturnValue = false;
				cboConsignees.Focus();
			}

			if (cboJobsType.Text == "")
			{
				messageNumber += 1;
				validateMessage.Append("\n- Job Type cannot be empty.");
				validateReturnValue = false;
				cboJobsType.Focus();
			}
			//


			if (!validateReturnValue)
			{
				validateMessage.Insert(0, "The following need your attention:");
				if (messageNumber > 1) validateMessage.Replace("following", "followings");
				XtraMessageBox.Show(validateMessage + " \nPlease try again.",
					"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			return validateReturnValue;
		}

		private void SaveData()
		{
			try
			{
				BindingContext[bsJobSeaImport].EndCurrentEdit();
				_jobSeaImportModel = (JobSeaImportModel)bsJobSeaImport.Current;

				BindingContext[bsJobSeaImportDetails].EndCurrentEdit();
				_jobSeaImportDetails = (IList<JobSeaImportDetailModel>)bsJobSeaImportDetails.List;

				UpdateFormComboListDetails();

				cboOperatingUsers.EditValue = CurrentUser.UserId;

				if (_jobSeaImportModel.Id == 0)
				{
					_logInfoRepository.CreateLogInfo(_jobSeaImportModel);
					_jobSeaImportModel.Id = _jobSeaImportRepository.AddNewJobSeaImport(_jobSeaImportModel);
				}
				else
				{
					_logInfoRepository.UpdateLogInfo(_jobSeaImportModel);
					_jobSeaImportRepository.UpdateJobSeaImport(_jobSeaImportModel);
				}

				// UPDATE DETAILS
				foreach (var seaImportDetail in _jobSeaImportDetails)
				{
					seaImportDetail.JobId = _jobSeaImportModel.JobNo;

					if (seaImportDetail.Id == 0)
					{
						_logInfoRepository.CreateLogInfo(seaImportDetail);
						_ = _jobSeaImportDetailRepository.AddNewJobSeaImportDetail(seaImportDetail);
					}
					else
					{
						_logInfoRepository.UpdateLogInfo(seaImportDetail);
						_jobSeaImportDetailRepository.UpdateJobSeaImportDetail(seaImportDetail);
					}
				}

				//Update Requirements
				// To Be Loaded
				foreach (var condition in _requiredDocumentsToBeLoaded)
				{
					condition.ConditionId = (int)ConditionSelection.ToBeLoaded;
					//condition.JobNo = _jobSeaImportModel.JobNo;
					if (condition.Id == 0)
					{
						_logInfoRepository.CreateLogInfo(condition);
						_ = _requiredDocumentRepository.AddNewRequiredDocument(condition);
					}
					else
					{
						_logInfoRepository.UpdateLogInfo(condition);
						_requiredDocumentRepository.UpdateRequiredDocument(condition);
					}
				}

				// On Water
				foreach (var condition in _requiredDocumentsOnWater)
				{
					//condition.JobNo = _jobSeaImportModel.JobNo;
					condition.ConditionId = (int)ConditionSelection.OnWater;
					if (condition.Id == 0)
					{
						_logInfoRepository.CreateLogInfo(condition);
						_ = _requiredDocumentRepository.AddNewRequiredDocument(condition);
					}
					else
					{
						_logInfoRepository.UpdateLogInfo(condition);
						_requiredDocumentRepository.UpdateRequiredDocument(condition);
					}
				}


				_objState = DataEntityState.Unchanged;
				SendUpdatedJobSeaImport(_jobSeaImportModel, EventArgs.Empty);
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message,
					"On save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateFormComboListDetails()
		{
			_jobSeaImportModel.CustomerId = cboCustomers.EditValue == null ? 0 : (int)cboCustomers.EditValue;
			_jobSeaImportModel.ConsigneeId = cboConsignees.EditValue == null ? 0 : (int)cboConsignees.EditValue;
			_jobSeaImportModel.JobTypeId = cboJobsType.EditValue == null ? 0 : (int)cboJobsType.EditValue;
			_jobSeaImportModel.SeaportDeparture = cboDeparture.EditValue == null ? 0 : (int)cboDeparture.EditValue;
			_jobSeaImportModel.SeaportDestination = cboDestination.EditValue == null ? 0 : (int)cboDestination.EditValue;

			_jobSeaImportModel.AgentId = cboAgents.EditValue == null ? 0 : (int)cboAgents.EditValue;
			_jobSeaImportModel.ShippedWithId = cboShippedWith.EditValue == null ? 0 : (int)cboShippedWith.EditValue;
			_jobSeaImportModel.SideId = cboSeaCarriers.EditValue == null ? 0 : (int)cboSeaCarriers.EditValue;
			_jobSeaImportModel.VesselId = cboVessels.EditValue == null ? 0 : (int)cboVessels.EditValue;
			_jobSeaImportModel.FeederVesselId = cboFeederVessels.EditValue == null ? 0 : (int)cboFeederVessels.EditValue;
			_jobSeaImportModel.IncoTerms = cboIncoTerms.EditValue == null ? 0 : (int)cboIncoTerms.EditValue;

			_jobSeaImportModel.UserId = cboUsers.EditValue == null ? 0 : (int)cboUsers.EditValue;
			_jobSeaImportModel.SalesId = cboSales.EditValue == null ? 0 : (int)cboSales.EditValue;
			_jobSeaImportModel.OperatingUserId = cboOperatingUsers.EditValue == null ? 0 : (int)cboOperatingUsers.EditValue;
		}


		private string ToggleInOrderSetting(bool isAllInOrder)
		{
			string strOrigin = " ".PadLeft(4) + "<< All In Order".PadRight(20);
			string strAllInOrder = " ".PadLeft(4) + "Clear All In Order".PadRight(20);

			var allInOrderMessage = new StringBuilder();
			allInOrderMessage.Append(isAllInOrder ? strAllInOrder : strOrigin);

			return allInOrderMessage.ToString();
		}

		private DocumentModel LoadDocument()
		{
			try
			{
				OpenFileDialog ofd = new OpenFileDialog();
				ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

				ofd.Filter = @"All Files (*.*)|*.*" +
							 @"|PDF Portable Document Format (*.pdf)|*.pdf" +
							 @"|PNG Portable Network Graphics (*.png)|*.png" +
							 @"|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
							 @"|BMP Windows Bitmap (*.bmp)|*.bmp" +
							 @"|TIF Tagged Imaged File Format (*.tif *.tiff)|*.tif;*.tiff" +
							 @"|GIF Graphics Interchange Format (*.gif)|*.gif";

				if (ofd.ShowDialog() == DialogResult.OK)
				{
					DocumentModel newDocument = new DocumentModel();
					using (FileStream stream = new FileStream(ofd.FileName, FileMode.Open))
					{

						newDocument.DocumentName = ofd.SafeFileName;
						newDocument.OriginPath = ofd.FileName;
						newDocument.DocumentDate = File.GetCreationTime(ofd.FileName);

						byte[] bytes = new byte[stream.Length];
						var read = stream.Read(bytes, 0, bytes.Length);

						newDocument.DocumentContent = bytes;
					}

					return newDocument;
				}

			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return null;
		}

		private void openFolder_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			try
			{
				// Select one or more files to attach
				var ofd = new OpenFileDialog
				{
					InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
					Multiselect = true,
					Filter = @"All Files (*.*)|*.*" +
							 @"|PDF Portable Document Format (*.pdf)|*.pdf" +
							 @"|PNG Portable Network Graphics (*.png)|*.png" +
							 @"|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
							 @"|BMP Windows Bitmap (*.bmp)|*.bmp" +
							 @"|TIF Tagged Imaged File Format (*.tif *.tiff)|*.tif;*.tiff" +
							 @"|GIF Graphics Interchange Format (*.gif)|*.gif"
				};

				if (ofd.ShowDialog() != DialogResult.OK) return;

				// Prepare destination folder: Documents\MISLiveMed\Jobs\<ReferenceNo>\<JobNo>
				string referenceNo = !string.IsNullOrWhiteSpace(txtReferenceNo.Text)
					? txtReferenceNo.Text
					: _jobSeaImportModel.ReferenceNo;
				string jobNo = !string.IsNullOrWhiteSpace(txtJobNo.Text)
					? txtJobNo.Text
					: _jobSeaImportModel.JobNo.ToString();

				string Sanitize(string value)
				{
					if (string.IsNullOrWhiteSpace(value)) return "Unknown";
					var invalid = Path.GetInvalidFileNameChars();
					foreach (var c in invalid)
					{
						value = value.Replace(c.ToString(), "_");
					}
					return value.Trim();
				}

				referenceNo = Sanitize(referenceNo);
				jobNo = Sanitize(jobNo);

				string baseFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MISLiveMed", "Jobs", referenceNo, jobNo);
				Directory.CreateDirectory(baseFolder);

				foreach (var file in ofd.FileNames)
				{
					try
					{
						string fileName = Path.GetFileName(file);
						string destinationPath = Path.Combine(baseFolder, fileName);

						if (File.Exists(destinationPath))
						{
							var result = XtraMessageBox.Show($"File '{fileName}' already exists. Overwrite?", "Confirm Overwrite", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
							if (result == DialogResult.Cancel)
							{
								break;
							}
							if (result == DialogResult.No)
							{
								continue;
							}
							// Yes -> overwrite below
						}

						File.Copy(file, destinationPath, true);

						// Create document model and add to binding source
						var newDocument = new DocumentModel
						{
							DocumentName = Path.GetFileName(destinationPath),
							OriginPath = destinationPath,
							DocumentDate = File.GetCreationTime(destinationPath),
							StreamedDate = DateTime.Now,
							DocumentContent = File.ReadAllBytes(destinationPath)
						};

						bsDocuments.Add(newDocument);
					}
					catch (Exception ex)
					{
						XtraMessageBox.Show(ex.Message, @"Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}

			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void rgJobStatusAction_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
		{
			GalleryItem itemNormal = rgJobStatusAction.Gallery.GetItemByValue(0);
			GalleryItem itemQuoted = rgJobStatusAction.Gallery.GetItemByValue(1);
			GalleryItem itemBooked = rgJobStatusAction.Gallery.GetItemByValue(2);
			GalleryItem itemLost = rgJobStatusAction.Gallery.GetItemByValue(3);
			GalleryItem itemCanceled = rgJobStatusAction.Gallery.GetItemByValue(4);
			GalleryItem itemNotSelected = rgJobStatusAction.Gallery.GetItemByValue(5);

			if (rgJobStatusAction.Gallery == null) return;

			if (itemNormal.Checked)
			{

			}

			if (itemQuoted.Checked)
			{

			}

			if (itemBooked.Checked)
			{

			}

			if (itemLost.Checked)
			{

			}

			if (itemCanceled.Checked)
			{

			}

			if (itemNotSelected.Checked)
			{

			}
		}

		private void RcvUpdatedInvoice(object sender, EventArgs e)
		{
			if (sender == null) return;
			_invoiceModel = sender as InvoiceModel;
			if (_invoiceModel == null) return;

			if (_invoiceModel.LastModifiedDate == null || _invoiceModel.Deleted)
			{
				_invoices.Add(_invoiceModel);
				gcInvoices.DataSource = null;
				gcInvoices.DataSource = _invoices;
			}
			else
			{
				gvInvoices.UpdateCurrentRow();
			}
		}

		private void RcvUpdatedCost(object sender, EventArgs e)
		{
			if (sender == null) return;
			_costModel = sender as CostModel;
			if (_costModel == null) return;

			if (_costModel.LastModifiedDate == null || _costModel.Deleted)
			{
				_costs.Add(_costModel);
				gcInvoices.DataSource = null;
				gcInvoices.DataSource = _costs;
			}
			else
			{
				gvInvoices.UpdateCurrentRow();
			}
		}

		private void tabDetails_Click(object sender, EventArgs e)
		{
			switch (tabDetails.SelectedPage.Name)
			{
				case "tabSellingGroup":
					rpInvoice.Visible = true;
					rpCost.Visible = false;
					rcMain.SelectPage(rpInvoice);
					break;

				case "tabCostGroup":
					rpInvoice.Visible = false;
					rpCost.Visible = true;
					rcMain.SelectPage(rpCost);
					break;

				default:
					rpInvoice.Visible = false;
					rpCost.Visible = false;
					rcMain.SelectPage(rpMain);
					break;
			}
		}

		private void btnProtected_CheckedChanged(object sender, ItemClickEventArgs e)
		{
			//if (_userPermission. != EnumStatusType.Requested) return;

			_jobSeaImportModel.IsProtected = btnProtected.Checked;

			if (btnProtected.Checked)
			{
				//btnProtected.Appearance.Image.Palette = new Palette();
				btnProtected.ItemAppearance.Normal.Font = new Font("Tahoma", 8, FontStyle.Bold);
				btnProtected.ItemAppearance.Normal.ForeColor = Color.Red;
				btnProtected.ItemAppearance.Hovered.Font = new Font("Tahoma", 8, FontStyle.Bold);
				btnProtected.ItemAppearance.Hovered.ForeColor = Color.Red;
				btnProtected.ItemAppearance.Pressed.Font = new Font("Tahoma", 8, FontStyle.Bold);
				btnProtected.ItemAppearance.Pressed.ForeColor = Color.Red;
			}
			else
			{
				btnProtected.ItemAppearance.Normal.Font = new Font("Tahoma", 8, FontStyle.Regular);
				btnProtected.ItemAppearance.Normal.ForeColor = Color.Black;
				btnProtected.ItemAppearance.Hovered.Font = new Font("Tahoma", 8, FontStyle.Regular);
				btnProtected.ItemAppearance.Hovered.ForeColor = Color.Black;
				btnProtected.ItemAppearance.Pressed.Font = new Font("Tahoma", 8, FontStyle.Regular);
				btnProtected.ItemAppearance.Pressed.ForeColor = Color.Black;
			}
		}

		#region Invoices Buttons Event
		private void btnNewInvoice_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (_jobSeaImportModel == null || _jobSeaImportModel.Id == 0)
			{
				XtraMessageBox.Show("Please save the job first before creating an invoice.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			var newInvoice = new InvoiceModel
			{
				JobId = _jobSeaImportModel.JobNo,
				DepartmentId = (int)JobsType.SeaImport,
				RefNo = _jobSeaImportModel.ReferenceNo,
				InvoiceRef = _jobSeaImportModel.ReferenceNo,
				MemberId = _jobSeaImportModel.CustomerId,
			};
			var frm = new InvoiceEditForm(newInvoice);
			frm.SendUpdatedInvoice += RcvUpdatedInvoice;
			frm.ShowDialog();
		}

		private void btnEditInvoice_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnPrintInvoice_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnPrintOriginalInvoice_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnRefreshInvoice_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcInvoices.DataSource = null;
			gcInvoices.DataSource = _invoices;
		}

		private void btnDeleteInvoice_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnCloseInvoice_ItemClick(object sender, ItemClickEventArgs e)
		{
			Close();
		}

		#endregion


		#region Costsheet Buttons Event
		private void btnNewCost_ItemClick(object sender, ItemClickEventArgs e)
		{

		}
		private void btnEditCost_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnRefreshCost_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnPrintCost_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnDeleteCost_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnCloseCost_ItemClick(object sender, ItemClickEventArgs e)
		{
			Close();
		}


		#endregion

		private void gvRequiredToBeLoaded_RowCellStyle(object sender, RowCellStyleEventArgs e)
		{
			if (sender is not GridView view || e.RowHandle < 0) return;

			bool isRequired = view.GetRowCellValue(e.RowHandle, "IsRequired") is bool c && c;
			bool isFulFilled = view.GetRowCellValue(e.RowHandle, "IsFulFilled") is bool can && can;

			if (isRequired)
			{
				e.Appearance.ForeColor = Color.Red;
				e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
			}
			if (isFulFilled)
			{
				e.Appearance.ForeColor = Color.Green;
				e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
			}
		}

		private void gvRequiredOnWater_CellValueChanged(object sender, CellValueChangedEventArgs e)
		{
			if (sender is not GridView view) return;
			if (_jobSeaImportModel == null) return;
			if (e.RowHandle < 0) return;

			if (e.Column.FieldName == "IsFulFilled")
			{
				bool isFulFilled = e.Value is bool b && b;
				if (isFulFilled)
				{
					view.SetRowCellValue(e.RowHandle, "IsRequired", true);
				}
			}

			EnsureRequirementsUiState();
		}

		private void gvRequiredOnWater_CellValueChanging(object sender, CellValueChangedEventArgs e)
		{
			if (sender is not GridView view) return;
			if (e.Column.FieldName is "IsFulFilled" or "IsRequired")
				view.PostEditor();
		}

		private void gvRequiredToBeLoaded_CellValueChanged(object sender, CellValueChangedEventArgs e)
		{
			if (sender is not GridView view) return;
			if (_jobSeaImportModel == null) return;
			if (e.RowHandle < 0) return;

			if (e.Column.FieldName == "IsFulFilled")
			{
				bool isFulFilled = e.Value is bool b && b;
				if (isFulFilled)
				{
					// If fulfilled, force required as checked
					view.SetRowCellValue(e.RowHandle, "IsRequired", true);
				}
			}

			// Recompute all-in-order state for To-Be-Loaded
			EnsureRequirementsUiState();
		}

		private void gvRequiredToBeLoaded_CellValueChanging(object sender, CellValueChangedEventArgs e)
		{
			// Make checkbox edits commit immediately (so CellValueChanged fires right away)
			if (sender is not GridView view) return;
			if (e.Column.FieldName is "IsFulFilled" or "IsRequired")
				view.PostEditor();
		}

		private void gvRequiredOnWater_RowCellStyle(object sender, RowCellStyleEventArgs e)
		{
			if (sender is not GridView view || e.RowHandle < 0) return;

			bool isRequired = view.GetRowCellValue(e.RowHandle, "IsRequired") is bool c && c;
			bool isFulFilled = view.GetRowCellValue(e.RowHandle, "IsFulFilled") is bool can && can;

			if (isRequired)
			{
				e.Appearance.ForeColor = Color.Red;
				e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
			}
			if (isFulFilled)
			{
				e.Appearance.ForeColor = Color.Green;
				e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);
			}
		}

		private void btnAllInOrderTBL_Click(object sender, EventArgs e)
		{
			GridView view = gvRequiredToBeLoaded;

			if (_jobSeaImportModel.AllInOrderToBeLoaded)
			{
				if (XtraMessageBox.Show($"Are you sure you want to clear list and reset to default?",
						"Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					for (int i = 0; i < view.DataRowCount; i++)
					{
						if ((bool)view.GetRowCellValue(i, "IsRequired"))
						{
							view.SetRowCellValue(i, view.Columns["IsFulFilled"], false);
						}
					}
					_jobSeaImportModel.AllInOrderToBeLoaded = false;
					lcAllInOrderToBeloaded.Visibility = LayoutVisibility.Never;
					btnAllInOrderTBL.Text = ToggleInOrderSetting(_jobSeaImportModel.AllInOrderToBeLoaded);
					EnsureRequirementsUiState();
				}
			}
			else
			{
				if (XtraMessageBox.Show($"Are you sure you want to put All in Order?",
						"Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					for (int i = 0; i < view.DataRowCount; i++)
					{
						if ((bool)view.GetRowCellValue(i, "IsRequired"))
						{
							view.SetRowCellValue(i, view.Columns["IsFulFilled"], true);
						}
					}
					_jobSeaImportModel.AllInOrderToBeLoaded = true;
					lcAllInOrderToBeloaded.Visibility = LayoutVisibility.Always;
					btnAllInOrderTBL.Text = ToggleInOrderSetting(_jobSeaImportModel.AllInOrderToBeLoaded);
					EnsureRequirementsUiState();
				}
			}
		}

		private void btnAllInOrderOW_Click(object sender, EventArgs e)
		{
			GridView view = gvRequiredOnWater;

			if (_jobSeaImportModel.AllInOrderOnWater)
			{
				if (XtraMessageBox.Show($"Are you sure you want to clear list and reset to default?",
						"Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					for (int i = 0; i < view.DataRowCount; i++)
					{
						if ((bool)view.GetRowCellValue(i, "IsRequired"))
						{
							view.SetRowCellValue(i, view.Columns["IsFulFilled"], false);
						}
					}
					_jobSeaImportModel.AllInOrderOnWater = false;
					lcAllInOrderOnWater.Visibility = LayoutVisibility.Never;
					btnAllInOrderOW.Text = ToggleInOrderSetting(_jobSeaImportModel.AllInOrderOnWater);
					EnsureRequirementsUiState();
				}
			}
			else
			{
				if (XtraMessageBox.Show($"Are you sure you want to put All in Order?",
						"Confirm...", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					for (int i = 0; i < view.DataRowCount; i++)
					{
						if ((bool)view.GetRowCellValue(i, "IsRequired"))
						{
							view.SetRowCellValue(i, view.Columns["IsFulFilled"], true);
						}
					}
					_jobSeaImportModel.AllInOrderOnWater = true;
					lcAllInOrderOnWater.Visibility = LayoutVisibility.Always;
					btnAllInOrderOW.Text = ToggleInOrderSetting(_jobSeaImportModel.AllInOrderOnWater);
					EnsureRequirementsUiState();
				}
			}
		}

		#region Add new Customers

		// Add new Customers
		private void cboCustomers_AddNewValue(object sender, AddNewValueEventArgs e)
		{
			var form = new CustomerEditForm(new CustomerModel());
			form.SendUpdatedCustomer += RcvUpdatedCustomerAsync;
			form.ShowDialog();
		}

		// Add new Consignees
		private void cboConsignees_AddNewValue(object sender, AddNewValueEventArgs e)
		{
			var form = new CustomerEditForm(new CustomerModel());
			form.SendUpdatedCustomer += RcvUpdatedConsigneeAsync;
			form.ShowDialog();
		}

		private void RcvUpdatedCustomerAsync(object sender, EventArgs e)
		{
			if (sender == null) return;
			_customerModel = sender as CustomerModel;

			_customers.Add(_customerModel);

			cboCustomers.Properties.DataSource = null;
			cboCustomers.Properties.DataSource = _customers;
			if (_customerModel != null) cboCustomers.EditValue = _customerModel.Id;
		}

		private void RcvUpdatedConsigneeAsync(object sender, EventArgs e)
		{
			if (sender == null) return;
			_customerModel = sender as CustomerModel;

			_customers.Add(_customerModel);

			cboConsignees.Properties.DataSource = null;
			cboConsignees.Properties.DataSource = _customers;
			if (_customerModel != null) cboConsignees.EditValue = _customerModel.Id;
		}


		#endregion

		#region Add new sea ports
		private void cboDeparture_AddNewValue(object sender, AddNewValueEventArgs e)
		{
			var form = new SeaportEditForm(new PortModel());
			form.SendUpdatedSeaport += RcvUpdatedDepartureAsync;
			form.ShowDialog();
		}

		private void cboDestination_AddNewValue(object sender, AddNewValueEventArgs e)
		{
			var form = new SeaportEditForm(new PortModel());
			form.SendUpdatedSeaport += RcvUpdatedDestinationAsync;
			form.ShowDialog();
		}

		private void RcvUpdatedDepartureAsync(object sender, EventArgs e)
		{
			if (sender == null) return;
			_seaportModel = sender as PortModel;

			_seaports.Add(_seaportModel);

			cboDeparture.Properties.DataSource = null;
			cboDeparture.Properties.DataSource = _seaports;
			if (_seaportModel != null) cboDeparture.EditValue = _seaportModel.Id;
		}

		private void RcvUpdatedDestinationAsync(object sender, EventArgs e)
		{
			if (sender == null) return;
			_seaportModel = sender as PortModel;

			_seaports.Add(_seaportModel);

			cboDestination.Properties.DataSource = null;
			cboDestination.Properties.DataSource = _seaports;
			if (_seaportModel != null) cboDestination.EditValue = _seaportModel.Id;
		}

		#endregion Add new Vessels, Feeder Vessel

		private void cboVessels_AddNewValue(object sender, AddNewValueEventArgs e)
		{
			var form = new VesselEditForm(new VesselModel(), false);
			form.SendUpdatedVessel += RcvUpdatedVesselAsync;
			form.ShowDialog();
		}

		private void cboFeederVessels_AddNewValue(object sender, AddNewValueEventArgs e)
		{
			var form = new VesselEditForm(new VesselModel(), true);
			form.SendUpdatedVessel += RcvUpdatedFeederVesselAsync;
			form.ShowDialog();
		}

		private void RcvUpdatedVesselAsync(object sender, EventArgs e)
		{
			if (sender == null) return;
			_vesselModel = sender as VesselModel;

			_vessels.Add(_vesselModel);

			cboVessels.Properties.DataSource = null;
			cboVessels.Properties.DataSource = _vessels;
			if (_vesselModel != null) cboVessels.EditValue = _vesselModel.Id;
		}

		private void RcvUpdatedFeederVesselAsync(object sender, EventArgs e)
		{
			if (sender == null) return;
			_vesselModel = sender as VesselModel;

			_vessels.Add(_vesselModel);

			cboFeederVessels.Properties.DataSource = null;
			cboFeederVessels.Properties.DataSource = _vessels;
			if (_vesselModel != null) cboFeederVessels.EditValue = _vesselModel.Id;
		}



		#region 



		#endregion

		private void cboShippedWith_EditValueChanged(object sender, EventArgs e)
		{
			var shippedWith = cboShippedWith.EditValue == null ? 0 : (int)cboShippedWith.EditValue;

			_seaCarriers = _agentRepository.SelectAgentByCategoryId(shippedWith, false, false);

			cboSeaCarriers.Properties.DataSource = null;
			cboSeaCarriers.Properties.DataSource = _seaCarriers;
			cboSeaCarriers.EditValue = _jobSeaImportModel.SideId;
		}

		private void cboCustomers_EditValueChanged(object sender, EventArgs e)
		{
			if (_jobSeaImportModel.SalesId > 0) return;

			var salesPersonId = _customerRepository.GetSalesPersonByCustomerId(
				cboCustomers.EditValue == null ? 0 : (int)cboCustomers.EditValue);

			cboSales.EditValue = salesPersonId;
		}

		private void SyncDateFromCheck(CheckEdit check, DateEdit dateEdit)
		{
			if (check == null || dateEdit == null) return;

			if (check.Checked)
			{
				if (dateEdit.EditValue == null || dateEdit.EditValue == DBNull.Value)
					dateEdit.EditValue = DateTime.Now;
			}
			else
			{
				dateEdit.EditValue = null; // or DBNull.Value depending on your binding
			}
		}

		private void chkRTejrim_CheckedChanged(object sender, EventArgs e)
		{
			SyncDateFromCheck(sender as CheckEdit, dtReadyForTejrim);
		}

		private void chkReadyForClearance_CheckedChanged(object sender, EventArgs e)
		{
			SyncDateFromCheck(sender as CheckEdit, dtReadyForClearance);
		}

		private void chkPendingForDelivery_CheckedChanged(object sender, EventArgs e)
		{
			SyncDateFromCheck(sender as CheckEdit, dtPendingForDelivery);
		}

		private void chkContainerToCnee_CheckedChanged(object sender, EventArgs e)
		{
			SyncDateFromCheck(sender as CheckEdit, dtContainerToCnee);
		}

		private void chkEmptyContainer_CheckedChanged(object sender, EventArgs e)
		{
			SyncDateFromCheck(sender as CheckEdit, dtEmptyContainer);
		}

		private void chkConfirmEmptyContainer_CheckedChanged(object sender, EventArgs e)
		{
			SyncDateFromCheck(sender as CheckEdit, dtConfirmEmptyContainer);
		}

		private void chkDeliveryDate_CheckedChanged(object sender, EventArgs e)
		{
			SyncDateFromCheck(sender as CheckEdit, dtDeliveryDate);
		}

		private void chkTejrim_CheckedChanged(object sender, EventArgs e)
		{
			SyncDateFromCheck(sender as CheckEdit, dtTejrimDate);
		}

		private void chkPaidDo_CheckedChanged(object sender, EventArgs e)
		{
			SyncDateFromCheck(sender as CheckEdit, dtPaidDoDate);
		}

		private void chkMissingDocuments_CheckedChanged(object sender, EventArgs e)
		{
			SyncDateFromCheck(sender as CheckEdit, dtMissingDocumentsDate);
		}

	}
}