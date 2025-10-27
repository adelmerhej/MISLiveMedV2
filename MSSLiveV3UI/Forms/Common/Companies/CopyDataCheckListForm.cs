using System;
using MISLiveMed.Models.Models.Common.Companies;

namespace MISLiveMed.UI.Forms.Common.Companies
{
	public partial class CopyDataCheckListForm : DevExpress.XtraEditors.XtraForm
	{
		private CopyDataCheckListModel _copyDataCheckList = new CopyDataCheckListModel();

		public EventHandler SendUpdatedCheckList;

		public CopyDataCheckListForm()
		{
			InitializeComponent();

			InitializeBindings();
			WireUpBindings();
			ApplyDefaults();
			ApplyPermissions();
		}

		private void InitializeBindings()
		{

		}

		private void WireUpBindings()
		{

		}
		private void ApplyDefaults()
		{
			chkCopyContinents.Checked = true;
			chkCopyRegions.Checked = true;
			chkCopyCountries.Checked = true;
			chkCopyProvinces.Checked = true;
			chkCopyDistricts.Checked = true;
			chkCopyCities.Checked = true;
			chkCopyCurrencies.Checked = true;
			chkCopyCurrenciesExchangeHistory.Checked = true;

			chkCopyCharts.Checked = true;
			chkCopySeaPorts.Checked = true;
			chkCopyAirPorts.Checked = true;
			chkCopyLandBorders.Checked = true;
			chkCopyAirlines.Checked = true;
			chkCopyCarriers.Checked = true;
			chkCopyVessels.Checked = true;
		}

		private void ApplyPermissions()
		{

		}

		#region Buttons Event

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			_copyDataCheckList.CopyContinents = chkCopyContinents.Checked;
			_copyDataCheckList.CopyRegions = chkCopyRegions.Checked;
			_copyDataCheckList.CopyCountries = chkCopyCountries.Checked;
			_copyDataCheckList.CopyProvinces = chkCopyProvinces.Checked;
			_copyDataCheckList.CopyDistricts = chkCopyDistricts.Checked;
			_copyDataCheckList.CopyCities = chkCopyCities.Checked;
			_copyDataCheckList.CopyCurrencies = chkCopyCurrencies.Checked;
			_copyDataCheckList.CopyCurrenciesExchangeHistory = chkCopyCurrenciesExchangeHistory.Checked;

			_copyDataCheckList.CopyCharts = chkCopyCharts.Checked;
			_copyDataCheckList.CopySeaPorts = chkCopySeaPorts.Checked;
			_copyDataCheckList.CopyAirPorts = chkCopyAirPorts.Checked;
			_copyDataCheckList.CopyLandBorders = chkCopyLandBorders.Checked;
			_copyDataCheckList.CopyAirlines = chkCopyAirlines.Checked;
			_copyDataCheckList.CopyCarriers = chkCopyCarriers.Checked;
			_copyDataCheckList.CopyVessels = chkCopyVessels.Checked;

			SendUpdatedCheckList(_copyDataCheckList, EventArgs.Empty);
			Close();
		}

		#endregion

	}
}