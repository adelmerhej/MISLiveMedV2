using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MISLiveMed.DataLayers.Accounting.Charts;
using MISLiveMed.DataLayers.Accounting.Journals;
using MISLiveMed.DataLayers.Common.Currencies;
using MISLiveMed.Models.Models.Accounting.Journals;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Accounting.Journals
{
	public partial class MigrateJournalsForm : XtraForm
	{
		private IList<JournalModel> _journals = new List<JournalModel>();
		private IList<JournalDetailModel> _journalDetails = new List<JournalDetailModel>();

		private readonly JournalRepository _journalRepository = new JournalRepository();
		private readonly JournalDetailRepository _journalDetailRepository = new JournalDetailRepository();

		int _workingYear = DateTime.Now.Year;

		public MigrateJournalsForm()
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
				_journals = _journalRepository.SelectJournals(_workingYear);
				_journalDetails = _journalDetailRepository.SelectJournalDetails(_workingYear);

				lblCount.Text = _journals.Count.ToString();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsJournals.DataSource = _journals;

			cboWorkingYear.Properties.DataSource = Enumeration.GetAll<HelperApplication.DetailControlTypeFormatter.WorkingYearPeriod>();
			cboWorkingYear.Properties.DisplayMember = "Key";
			cboWorkingYear.Properties.ValueMember = "Key";

			cboWorkingYear.EditValue = CurrentUser.WorkingYear;

			btnImport.Enabled = true;
		}

		private void ApplyPermissions()
		{

		}

		private void ApplyDefaults()
		{

		}

		private void cboWorkingYear_EditValueChanged(object sender, EventArgs e)
		{
			if (cboWorkingYear.EditValue == null) return;

			_workingYear = (int)cboWorkingYear.EditValue;
			InitializeBindings();
			bsJournals.DataSource = _journals;
			_journalDetails = _journalDetailRepository.SelectJournalDetails(_workingYear);

			btnImport.Enabled = true;
		}


		private void btnImport_Click(object sender, EventArgs e)
		{
			btnImport.Enabled = false;

			IList<AJournalModel> journalStatus = new List<AJournalModel>();

			try
			{
				int count = 0;
				//GET old journal table
				journalStatus = _journalRepository.SelectAJournals(_workingYear);

				progressBarControl1.Reset();
				progressBarControl1.Properties.Step = 1;
				progressBarControl1.Properties.ShowTitle = true;
				progressBarControl1.Properties.PercentView = true;
				progressBarControl1.Properties.Minimum = 0;
				progressBarControl1.Properties.Maximum = journalStatus.Count;
				progressBarControl1.Visible = true;
				
				foreach (var ajournal in journalStatus)
				{
					//Check if old record in journal exists in Journals table
					var journalExist = _journalRepository.SelectJournalByJvNo(int.Parse(ajournal.code), _workingYear);
					if (journalExist == null)
					{
						// Add new entry for journals
						JournalModel newEntry = new JournalModel();

						newEntry.JvNo = int.Parse(ajournal.code);
						newEntry.JournalTypeId = ajournal.jotype.Trim() == "000" ? 3 : 1;
						newEntry.JournalDate = ajournal.date;
						newEntry.Reference = ajournal.reference;
						newEntry.CurrencyId = 2;
						newEntry.Rate = (decimal)ajournal.rate;
						newEntry.IsPosted = true;
						newEntry.CompanyId = 1;
						newEntry.BranchId = 1;

						var newUserName = ajournal.creator ?? "IMAD";
						newEntry.CreatedBy = newUserName.Trim() == "IMAD" ? 30 : 8;

						newEntry.CreatedDate = DateTime.ParseExact(ajournal.cr_time ?? DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture), "dd/MM/yyyy HH:mm:ss", null);

						newEntry.LastModifiedBy = newUserName == "IMAD" ? 30 : 8;

						newEntry.LastModifiedDate =
								DateTime.ParseExact(ajournal.le_time ?? DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture), "dd/MM/yyyy HH:mm:ss", null);
						
						newEntry.WorkingYear = _workingYear;
						newEntry.Locked = _workingYear < 2025;

						_ = _journalRepository.AddNewJournal(newEntry);
						count++;
						journalExist = newEntry;
					}
					AddJournalDetails(journalExist);

					progressBarControl1.PerformStep();
					progressBarControl1.Update();
				}

				bsJournals.ResetBindings(false);
				bsJournals.DataSource = _journals;

				_journalDetails = _journalDetailRepository.SelectJournalDetails(_workingYear);

				btnCancel.Text = @"Close";
				XtraMessageBox.Show($"Migration Done! - Added ({count}) records.", @"Migration", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception exception)
			{
				btnImport.Enabled = true;
				XtraMessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AddJournalDetails(JournalModel dataModel)
		{
			//btnImport.Enabled = false;

			JournalModel journalModel = new JournalModel();
			IList<AdetailModel> journalDetailsStatus = new List<AdetailModel>();

			ChartRepository chartRepository = new ChartRepository();
			CurrencyRepository currencyRepository = new CurrencyRepository();

			try
			{
				//Get details
				journalDetailsStatus = _journalDetailRepository.SelectJournalDetailsByCode(_workingYear, dataModel.JvNo.ToString().PadLeft(6, '0'));

				var journalDetailsExist = _journalDetailRepository.SelectJournalDetailsByJvNo(_workingYear, dataModel.Id);
				if (journalDetailsExist.Count == 0)
				{
					foreach (var journalDetail in journalDetailsStatus)
					{
						//check if already added in JournalDetails table
						var accountModel = chartRepository.SelectChartsBySerial(journalDetail.number, journalDetail.serial);
						int accountId = 0;
						if (accountModel != null) accountId = accountModel.Id;

						JournalDetailModel newJournalDetail = new JournalDetailModel();

						newJournalDetail.JournalId = dataModel.Id;
						newJournalDetail.Line = int.Parse(journalDetail.line.Trim());
						newJournalDetail.ChartId = accountId;
						newJournalDetail.ValueDate = journalDetail.vdate;
						newJournalDetail.CurrencyId = currencyRepository.SelectCurrencyByCode(journalDetail.currency.Trim());
						newJournalDetail.Rate = dataModel.Rate;
						newJournalDetail.Description = journalDetail.label ?? "";
						newJournalDetail.DbCr = journalDetail.dbcr;
						newJournalDetail.Amount = (decimal)journalDetail.am;
						newJournalDetail.LAmount = (decimal)journalDetail.amlc1;
						newJournalDetail.FAmount = (decimal)journalDetail.amlc2;
						newJournalDetail.Posted = journalDetail.posted;
						newJournalDetail.DocumentRef = journalDetail.document;
						newJournalDetail.CompanyId = CurrentUser.CompanyId;
						if (CurrentUser.BranchId != null) newJournalDetail.BranchId = (int)CurrentUser.BranchId;
						newJournalDetail.CreatedBy = dataModel.CreatedBy;
						newJournalDetail.CreatedDate = dataModel.CreatedDate;
						newJournalDetail.LastModifiedBy = dataModel.LastModifiedBy;
						newJournalDetail.LastModifiedDate = dataModel.LastModifiedDate;
						newJournalDetail.WorkingYear = dataModel.WorkingYear;
						newJournalDetail.Locked = _workingYear < 2025;

						_journalDetailRepository.AddNewJournalDetail(newJournalDetail);

					}
				}

			}
			catch (Exception exception)
			{
				btnImport.Enabled = true;
				XtraMessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

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
			e.RelationName = "fk_JournalDetails";
		}
	}
}