using System;

namespace MISLiveMed.Models.Models.Accounting.Reports.Settings
{
	public class BalanceSheetReportParameters
	{
		public DateTime? DateFrom { get; set; }
		public DateTime? DateTo { get; set; }
		public string OutputCurrency { get; set; }
		public int BalanceHeaderId { get; set; }
		public int CurrencyId => OutputCurrency == "USD" ? 2 : 1;
	}
}
