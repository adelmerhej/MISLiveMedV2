using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Accounting.Charts;
using MISLiveMed.DataLayers.Accounting.Journals;
using MISLiveMed.DataLayers.Common.Currencies;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.Charts;
using MISLiveMed.Models.Models.Accounting.Journals;
using MISLiveMed.Models.Models.Common.Currencies;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Accounting.Journals
{
	public partial class JournalsListForm : RibbonForm, IFormWithRibbon
	{
		private const string _formName = "JournalsList";
		private int _formId;
		private bool _resetMenu;

		private JournalModel _journalModel = new JournalModel();
		private IList<JournalModel> _journals = new List<JournalModel>();
		private IList<JournalDetailModel> _journalDetails = new List<JournalDetailModel>();
		private IList<JournalTypeModel> _journalTypes = new List<JournalTypeModel>();
		private IList<CurrencyModel> _currencies = new List<CurrencyModel>();
		private IList<ChartModel> _charts = new List<ChartModel>();

		private readonly JournalRepository _journalRepository = new JournalRepository();
		private readonly JournalDetailRepository _journalDetailRepository = new JournalDetailRepository();
		private readonly JournalTypeRepository _journalTypeRepository = new JournalTypeRepository();
		private readonly CurrencyRepository _currencyRepository = new CurrencyRepository();
		private readonly ChartRepository _chartRepository = new ChartRepository();

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

		#region Implementation of IFormWithRibbon

		public RibbonControl MainRibbon => rcJournalsList;
		public RibbonPage DefaultPage => rpJournalsList;


		#endregion

		public JournalsListForm()
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

				_journals = _journalRepository.SelectJournals(CurrentUser.WorkingYear);
				_journalDetails = _journalDetailRepository.SelectJournalDetails(CurrentUser.WorkingYear);
				_journalTypes = _journalTypeRepository.SelectJournalTypes();
				_currencies = _currencyRepository.SelectCurrencies();
				_charts = _chartRepository.SelectCharts(false, false);

				//repStatusList.DataSource = Enum.GetValues(typeof(EnumStatusType));
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsJournals.DataSource = _journals;

			repCurrencies.DataSource = null;
			repCurrencies.DataSource = _currencies;

			repCharts.DataSource = null;
			repCharts.DataSource = _charts;

			repChartList.DataSource = null;
			repChartList.DataSource = _charts;

			repJournalTypes.DataSource = null;
			repJournalTypes.DataSource = _journalTypes;

			repWorkingYear1.DataSource = Enumeration.GetAll<HelperApplication.DetailControlTypeFormatter.WorkingYearPeriod>();
			repWorkingYear1.DisplayMember = "Key";
			repWorkingYear1.ValueMember = "Key";

			cboWorkingYear.EditValue = CurrentUser.WorkingYear;
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
			btnPrintFilter.Enabled = _isAdmin || _canPrint;
			btnDelete.Enabled = _isAdmin || _canDelete;
		}

		private void ApplyDefaults()
		{
			LayoutsStyle.LoadLayoutGrid(gvJournals, CurrentUser.UserName, CurrentUser.CompanyName);

		}

		#region Form Events

		private void JournalsListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutGrid(gvJournals, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}
		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutGrid(gvJournals, CurrentUser.UserName, CurrentUser.CompanyName);
			}
		}

		#endregion
		#region Buttond Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			JournalEditForm frm = new JournalEditForm(new JournalModel());
			frm.SendUpdatedJournal += RcvUpdatedJournal;
			frm.ShowDialog();
		}
		private void btnSaveAs_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!_journals.Any()) return;

			int currentRowId = (int)gvJournals.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_journalModel = _journals.SingleOrDefault(x => x.Id == currentRowId);
			if (_journalModel == null) return;

			if (_journalModel.Locked)
			{
				XtraMessageBox.Show("Period is locked, you cannot Add, Edit or Clone a locked JV.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_journalModel.IsCloned = true;
			_journalModel.Id = 0;
			_journalModel.JvNo = 0;
			_journalModel.JournalDate = DateTime.Now;

			var frm = new JournalEditForm(_journalModel);
			frm.SendUpdatedJournal += RcvUpdatedJournal;
			frm.Show();
		}

		private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!_journals.Any()) return;

			int currentRowId = (int)gvJournals.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_journalModel = _journals.SingleOrDefault(x => x.Id == currentRowId);
			if (_journalModel == null) return;

			var frm = new JournalEditForm(_journalModel);
			frm.SendUpdatedJournal += RcvUpdatedJournal;
			frm.Show();
		}

		private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
		{
			InitializeBindings();
			WireUpBindings();
		}

		private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcJournals.ShowRibbonPrintPreview();
		}

		private void btnPrintFilter_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (!CanDelete()) return;

			try
			{
				int.TryParse(gvJournals.GetFocusedRowCellValue("Id").ToString(), out int id);
				string name = gvJournals.GetFocusedRowCellValue("JvNo").ToString();

				if (id > 0)
				{
					if (XtraMessageBox.Show($"Are you sure you want to delete : `{name}`?",
						    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
						    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						_journalModel = gvJournals.GetFocusedRow() as JournalModel;
						if (_journalModel == null)
						{
							return;
						}
						_journalModel.Deleted = true;

						//delete the record
						_journalRepository.DeleteJournal(_journalModel.Id);
						RcvUpdatedJournal(_journalModel, EventArgs.Empty);
					}
				}

			}
			catch (Exception exception)
			{
				switch (exception.Message)
				{
					case "-2146233088":
						XtraMessageBox.Show("This record is linked to one or more transactions, delete all links first.",
							"Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						break;

					default:
						XtraMessageBox.Show(exception.Message,
							"Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						break;
				}
			}
		}

		private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			Close();
		}
		
		#endregion

		private void gvJournals_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
		{
			var view = sender as GridView;
			if (view.GetRow(e.RowHandle) is JournalModel journalModel)
				e.IsEmpty = !_journalDetails.Any(x =>
					x.JournalId == journalModel.Id && x.WorkingYear == journalModel.WorkingYear);
		}

		private void gvJournals_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
		{
			var view = sender as GridView;
			if (view.GetRow(e.RowHandle) is JournalModel journalModel)
			{
				e.ChildList = _journalDetails
					.Where(x => x.JournalId == journalModel.Id && x.WorkingYear == journalModel.WorkingYear).ToList();
				view.OptionsBehavior.Editable = false;
			}
		}

		private void gvJournals_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
		{
			e.RelationCount = 1;
		}

		private void gvJournals_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
		{
			e.RelationName = "JournalDetails";
		}

		private void cboWorkingYear_EditValueChanged(object sender, EventArgs e)
		{
			if (cboWorkingYear.EditValue != null)
			{
				CurrentUser.WorkingYear = (int)cboWorkingYear.EditValue;
				InitializeBindings();
				WireUpBindings();
			}
		}

		private void RcvUpdatedJournal(object sender, EventArgs e)
		{
			if (sender == null) return;
			_journalModel = sender as JournalModel;

			if (_journalModel.LastModifiedDate == null || _journalModel.Deleted)
			{
				InitializeBindings();
				WireUpBindings();
			}
			else
			{
				gvJournals.UpdateCurrentRow();
			}
		}

		private bool CanDelete()
		{
			JournalModel dataBoundItem = gvJournals.GetFocusedRow() as JournalModel;

			if (gvJournals == null || gvJournals.SelectedRowsCount == 0) return false;
			if (gvJournals.SelectedRowsCount > 1)
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
			if (dataBoundItem != null && dataBoundItem.Locked)
			{
				XtraMessageBox.Show("This requires higher permission to delete a locked record!",
					"Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void gcJournals_DoubleClick(object sender, EventArgs e)
		{
			if (!_journals.Any()) return;

			int currentRowId = (int)gvJournals.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_journalModel = _journals.SingleOrDefault(x => x.Id == currentRowId);
			if (_journalModel == null) return;

			var frm = new JournalEditForm(_journalModel);
			frm.SendUpdatedJournal += RcvUpdatedJournal;
			frm.ShowDialog();
		}

		private void btnPrintStatement_ItemClick(object sender, ItemClickEventArgs e)
		{

		}
	}
}