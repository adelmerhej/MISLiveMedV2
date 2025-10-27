using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using MISLiveMed.DataLayers.Accounting.Journals;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Accounting.Journals;
using MISLiveMed.Models.Models.Accounting.Journals.Reports;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.Reports.Accounting.Journals;
using MISLiveMed.UI.Reports;

namespace MISLiveMed.UI.Accounting.Journals.Reports
{
	public partial class DailyJournalReportForm: XtraForm
	{
		private const string _formName = "DailyJournalReport";
		private int _formId;
		private bool _resetMenu;

		private IList<JournalTypeModel> _journalTypes = new List<JournalTypeModel>();

		private readonly JournalRepository _journalRepository = new JournalRepository();
		private readonly JournalTypeRepository _journalTypeRepository = new JournalTypeRepository();

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
		private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
		private readonly FormRepository _formRepository = new FormRepository();

		//Init permission variables
		private bool _isAdmin;
		private bool _isProtected;

		public DailyJournalReportForm()
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

				_journalTypes = _journalTypeRepository.SelectJournalTypes();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void WireUpBindings()
		{
			cboJournalTypes.Properties.DataSource = null;
			cboJournalTypes.Properties.DataSource = _journalTypes;
		}

		private void ApplyPermissions()
		{
			grpRecordsFilter.Visibility = _isProtected ? LayoutVisibility.Always : LayoutVisibility.Never;
		}

		private void ApplyDefaults()
		{
			dtDateFrom.EditValue = DateTime.Parse("01/01/" + DateTime.Today.Year);
			dtDateTo.EditValue = DateTime.Now;

			rgCurrencyOutput.SelectedIndex = 0;

		}

		#region Buttons Event
		private void btnPreview_Click(object sender, EventArgs e)
		{
			if (!ValidateForm()) return;
			try
			{
				//Prepare variables
				DateTime? dateFrom = null;
				DateTime? dateTo = null;
				if (dtDateFrom.EditValue != null) dateFrom = DateTime.Parse(dtDateFrom.EditValue.ToString());
				if (dtDateTo.EditValue != null) dateTo = DateTime.Parse(dtDateTo.EditValue.ToString());

				string codeFrom = "";
				if (txtJvCodeFrom.Text != "") codeFrom = txtJvCodeFrom.Text;

				string codeTo = "";
				if (txtJvCodeTo.Text != "") codeTo = txtJvCodeTo.Text;

				string refNoFrom = "";
				if (txtRefNoFrom.Text != "") refNoFrom = txtRefNoFrom.Text;

				string refNoTo = "";
				if (txtRefNoTo.Text != "") refNoTo = txtRefNoTo.Text;

				int journalTypes = 0;
				if (cboJournalTypes.EditValue != null) journalTypes = (int)cboJournalTypes.EditValue;

				string journalTypeCode = "";
				if (cboJournalTypes.EditValue != null) journalTypeCode = cboJournalTypes.Text;

				int currencyOut = rgCurrencyOutput.SelectedIndex;
				int sortingByFilter = rgSortingByFilter.SelectedIndex;

				bool isProtected = chkShowProtected.Checked;

				IList<JournalVoucherReportModel> dataReportModels =
					_journalRepository.DailyJournalVoucherReport(dateFrom, dateTo, codeFrom, codeTo, refNoFrom, refNoTo, 
						journalTypes, sortingByFilter, isProtected);

				var previewForm = new DocumentViewerForm();
				var report = new DailyJournalVoucherReport();

				report.DataSource = dataReportModels;

				report.Parameters["DateFrom"].Value = dateFrom;
				report.Parameters["DateTo"].Value = dateTo;
				report.Parameters["JvNoFrom"].Value = codeFrom;
				report.Parameters["JvNoTo"].Value = codeTo;
				report.Parameters["RefNoFrom"].Value = refNoFrom;
				report.Parameters["RefNoTo"].Value = refNoTo;
				report.Parameters["JournalType"].Value = journalTypeCode;
				report.Parameters["CurrencyOut"].Value = currencyOut;

				previewForm.Viewer.DocumentSource = report;
				previewForm.ShowDialog();
			}
			catch (Exception exception)
			{
				XtraMessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion

		private bool ValidateForm()
		{
			var validateReturnValue = true;
			var messageNumber = 0;
			var validateMessage = new StringBuilder();

			//if (cboAccountNumberFrom.Text == "")
			//{
			//	messageNumber += 1;
			//	validateMessage.Append("\n- Account Number cannot be empty.");
			//	validateReturnValue = false;
			//	cboAccountNumberFrom.Focus();
			//}

			if (!validateReturnValue)
			{
				validateMessage.Insert(0, "The following need your attention:\n");
				if (messageNumber > 1) validateMessage.Replace("following", "followings");
				XtraMessageBox.Show(validateMessage + " \n\nCannot be null or empty, please try again.",
					"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			return validateReturnValue;
		}

		private void txtRefNoFrom_Validated(object sender, EventArgs e)
		{
			txtRefNoFrom.Text = txtRefNoFrom.Text.PadLeft(6, '0');
		}

		private void txtRefNoTo_Validated(object sender, EventArgs e)
		{
			txtRefNoTo.Text = txtRefNoTo.Text.PadLeft(6, '0');
		}

	}
}