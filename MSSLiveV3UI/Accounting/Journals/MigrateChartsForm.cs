using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Accounting.Charts;
using MISLiveMed.Models.Models.Accounting.Charts;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.UI.Accounting.Journals
{
	public partial class MigrateChartsForm: XtraForm
	{
		private IList<ChartModel> _charts = new List<ChartModel>();
		
		private readonly ChartRepository _chartRepository = new ChartRepository();


		int _workingYear = DateTime.Now.Year;

		public MigrateChartsForm()
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
				_charts = _chartRepository.SelectCharts(false, false);

				lblCount.Text = _charts.Count.ToString();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsCharts.DataSource = _charts;

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
			bsCharts.DataSource = _charts;

			btnImport.Enabled = true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			IList<AccNameModel> chartStatus = new List<AccNameModel>();

			try
			{
				int count = 0;

				//GET old journal table
				chartStatus = _chartRepository.SelectAccByCode(_workingYear);

				progressBarControl1.Properties.Step = 1;
				progressBarControl1.Properties.ShowTitle = true;
				progressBarControl1.Properties.PercentView = true;
				progressBarControl1.Properties.Minimum = 0;
				progressBarControl1.Properties.Maximum = chartStatus.Count;
				progressBarControl1.Visible = true;

				foreach (var chartRecord in chartStatus)
				{
					//Check if old record in accname exists in Charts table
					var chartExist = _chartRepository.SelectChartsBySerial(chartRecord.number, chartRecord.serial ?? "");

					if (chartExist == null)
					{
						ChartModel chart = new ChartModel();
						chart.ParentId = 0;
						chart.Number = chartRecord.number;
						chart.Serial = chartRecord.serial ?? "";
						chart.AccountName = chartRecord.name;
						chart.ChartType = chartRecord.serial == null ? "T" : "R";
						chart.CompanyId = CurrentUser.CompanyId;
						if (CurrentUser.BranchId != null) chart.BranchId = (int)CurrentUser.BranchId;
						chart.CreatedBy = CurrentUser.UserId;
						chart.CreatedDate = DateTime.Now;
						chart.LastModifiedBy = CurrentUser.UserId;
						chart.LastModifiedDate = DateTime.Now;
						chart.WorkingYear = _workingYear;
						chart.Locked = false;

						_chartRepository.AddNewChart(chart);
						count++;
					}
					progressBarControl1.PerformStep();
					progressBarControl1.Update();
				}
				
				bsCharts.ResetBindings(false);
				bsCharts.DataSource = _charts;

				btnCancel.Text = @"Close";
				XtraMessageBox.Show($"Migration Done! - Added ({count}) records.", @"Migration", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception exception)
			{
				btnImport.Enabled = true;
				XtraMessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



	}
}