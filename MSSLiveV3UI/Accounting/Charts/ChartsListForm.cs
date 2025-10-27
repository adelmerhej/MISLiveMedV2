using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Accounting.Charts;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.Charts;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Layout;

namespace MISLiveMed.UI.Accounting.Charts
{
    public partial class ChartsListForm : RibbonForm, IFormWithRibbon
    {
	    private const string _formName = "ChartsList";
	    private int _formId;
	    private bool _resetMenu;

		private ChartModel _chartModel = new ChartModel();
	    private IList<ChartModel> _charts = new List<ChartModel>();
	    private IList<ChartDetailModel> _chartDetails = new List<ChartDetailModel>();

	    private readonly ChartRepository _chartRepository = new ChartRepository();
	    private readonly ChartDetailRepository _chartDetailRepository = new ChartDetailRepository();

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

		public RibbonControl MainRibbon => rcCharts;
        public RibbonPage DefaultPage => rpCharts;


        #endregion

        public ChartsListForm()
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

				_charts = _chartRepository.SelectCharts(false, false);
				_chartDetails = _chartDetailRepository.SelectChartDetails();
			}
	        catch (Exception e)
	        {
		        XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
		}

        private void WireUpBindings()
        {
	        bsCharts.DataSource = _charts;

	        chartTreeList.DataSource = null;
	        chartTreeList.DataSource = bsCharts;
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
	        LayoutsStyle.LoadLayoutTreeList(chartTreeList, CurrentUser.UserName);
		}


		#region Buttons Event

		private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChartEditForm frm = new ChartEditForm(new ChartModel());
            frm.SendUpdatedChartAccount += RcvUpdatedChartAccount;
            frm.ShowDialog();
        }
         
        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
	        if (!_charts.Any()) return;

	        int currentRowId = (int)chartTreeList.GetFocusedRowCellValue("Id");
	        if (currentRowId == 0) return;

	        _chartModel = _charts.SingleOrDefault(x => x.Id == currentRowId);
	        if (_chartModel == null) return;

	        var frm = new ChartEditForm(_chartModel);
	        frm.SendUpdatedChartAccount += RcvUpdatedChartAccount;
	        frm.ShowDialog();
		}

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
			InitializeBindings();
			WireUpBindings();
			ApplyDefaults();
			ApplyPermissions();
		}

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
			//chartTreeList.ShowRibbonPrintPreview();
			//int chartId = 0;
			//if (chartTreeList != null && int.Parse(chartTreeList.FocusedNode.GetDisplayText("ChartId")) == 0) { return; }

			//var previewForm = new DocumentViewerForm();
			//var report = new StatementReport();

			//TreeListColumn columnChartId = chartTreeList.Columns["ChartId"];
			//if (chartTreeList.FocusedNode.GetValue(columnChartId) != null)
			//{
			//	chartId = (int)chartTreeList.FocusedNode.GetValue(columnChartId);
			//}

			////int chartId = int.Parse(chartTreeList.Columns.getc);
			//DateTime dateFrom = DateTime.Parse(dtFrom.EditValue.ToString());
			//DateTime dateTo = DateTime.Parse(dtTo.EditValue.ToString());

			//report.DataSource = statementConnector.PrintJournalStatement(chartId, wYear, wCompanyId, dateFrom, dateTo, 0, true, "");

			//report.Parameters["DateFrom"].Value = dateFrom;
			//report.Parameters["DateTo"].Value = dateTo;

			////Get company info
			//companyList = companyConnector.GetCompanyListById(wCompanyId);

			//report.Parameters["CompanyName"].Value = companyList.CompanyName.Trim();
			//report.Parameters["Address"].Value = companyList.Address.Trim();
			//report.Parameters["PhoneNumber"].Value = companyList.PhoneNumber.Trim();
			//report.Parameters["FaxNumber"].Value = companyList.FaxNumber.Trim();

			//previewForm.Viewer.DocumentSource = report;
			//previewForm.ShowDialog();
		}

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
	        if (!CanDelete()) return;

	        try
	        {
				int.TryParse(chartTreeList.GetFocusedRowCellValue("Id").ToString(), out int id);
		        string name = chartTreeList.GetFocusedRowCellValue("AccountName").ToString();

		        if (id > 0)
		        {
			        if (XtraMessageBox.Show($"Are you sure you want to delete: `{name}`?",
				            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
				            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			        {
				        _chartModel = chartTreeList.GetFocusedRow() as ChartModel;
				        if (_chartModel == null)
				        {
					        return;
				        }
				        _chartModel.Deleted = true;

				        //delete the record
				        if (!_chartRepository.DeleteChart(_chartModel.Id)) return;
				        RcvUpdatedChartAccount(_chartModel, EventArgs.Empty);
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

		private void RcvUpdatedChartAccount(object sender, EventArgs e)
		{
			if (sender == null) return;
			_chartModel = sender as ChartModel;

			if (_chartModel != null && (_chartModel.LastModifiedDate == null || _chartModel.Deleted))
			{
				InitializeBindings();
				WireUpBindings();
			}
			else
			{
				chartTreeList.Update();
			}
		}

		private bool CanDelete()
		{
			ContinentModel dataBoundItem = chartTreeList.GetFocusedRow() as ContinentModel;

			if (!_charts.Any()) return false;

			if (chartTreeList == null) return false;
			int currentRowId = (int)chartTreeList.GetFocusedRowCellValue("Id");
			string name = chartTreeList.GetFocusedRowCellValue("AccountName").ToString();
			if (currentRowId == 0) return false;
			
			if (_chartRepository.ValidateAccountInJournal(currentRowId))
			{
				XtraMessageBox.Show($"There is one or more transaction related to `{name}`, cannot be deleted.",
					"Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (dataBoundItem != null && dataBoundItem.IsDefault)
			{
				XtraMessageBox.Show("Cannot delete system record!",
					"Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (HasTransactions()) return false;

			return true;
		}

		#region Grid Events
		private void ChartsListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_resetMenu)
			{
				LayoutsStyle.SaveLayoutTreeList(chartTreeList, CurrentUser.UserName);
			}
		}

		private void btnResetGridStyle_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("This will reset Grid layout next login, to its default settings.\nAre you sure you want to continue?", "Reset Menu...",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
			    DialogResult.Yes)
			{
				_resetMenu = true;
				LayoutsStyle.ResetLayoutTreeList(chartTreeList, CurrentUser.UserName);
			}
		}

		#endregion

		private void chartTreeList_DoubleClick(object sender, EventArgs e)
		{
			if (!_isAdmin && !_canEdit) return;

			if (!_charts.Any()) return;

			int currentRowId = (int)chartTreeList.GetFocusedRowCellValue("Id");
			if (currentRowId == 0) return;

			_chartModel = _charts.SingleOrDefault(x => x.Id == currentRowId);
			if (_chartModel == null) return;

			var frm = new ChartEditForm(_chartModel);
			frm.SendUpdatedChartAccount += RcvUpdatedChartAccount;
			frm.ShowDialog();
		}

		private bool HasTransactions()
		{
			try
			{
				//if (!_charts.Any()) return;

				//int currentRowId = (int)chartTreeList.GetFocusedRowCellValue("Id");
				//if (currentRowId == 0) return;

				//_chartModel = _charts.SingleOrDefault(x => x.Id == currentRowId);
				//if (_chartModel == null) return;

				//var frm = new ChartEditForm(_chartModel);
				//frm.SendUpdatedChartAccount += RcvUpdatedChartAccount;
				//frm.ShowDialog();

				if (!_charts.Any()) return false;

				//_chartRepository.SelectChartsByNumber();

				return false;
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
	}
}