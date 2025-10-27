using System;

namespace MISLiveMed.Models.Models.Reports.Profit
{
	public class OptimizedTotalProfitReportModel
	{
		public int TotalRecords { get; set; }
		public string ReferenceNo { get; set; }
		public int JobNo { get; set; }
		public DateTime JobDate { get; set; }
		public int DepartmentId { get; set; }
		public string DepartmentName { get; set; }
		public string StatusType { get; set; }
		public string CustomerName { get; set; }
		public string ConsigneeName { get; set; }
		public string CountryOfDeparture { get; set; }
		//public string CountryOfDestination { get; set; }
		public string Departure { get; set; }
		public string Destination { get; set; }
		public string Vessel { get; set; }
		public DateTime? Eta { get; set; }
		public DateTime? Ata { get; set; }
		public int OperatingUserId { get; set; }
		public string UserName { get; set; }
		public string Notes { get; set; }
		public bool Tejrim { get; set; }
		public int SortingOrder { get; set; }
		public int OrderBy { get; set; }
		public int PendingInvoices { get; set; }
		public int PendingCosts { get; set; }
		public decimal TotalInvoices { get; set; }
		public decimal TotalCosts { get; set; }
		public decimal TotalProfit { get; set; }
		public int TotalJobs { get; set; }
		
	}
}
