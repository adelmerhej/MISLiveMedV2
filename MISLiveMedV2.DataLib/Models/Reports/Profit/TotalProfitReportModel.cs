using System;

namespace MISLiveMed.Models.Models.Reports.Profit
{
    public class TotalProfitReportModel
    {
        public int SortingOrder { get; set; }
        public int JobNo { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime JobDate { get; set; }
        public string DepartmentName { get; set; }
        public string StatusType { get; }
        public decimal TotalProfit { get; set; }
        public int OrderBy { get; set; }

        public int OperatingUserId { get; set; }
        public int DepartmentId { get; set; }
        public string UserName { get; set; }
        public string CustomerName { get; set; }
        public string ConsigneeName { get; set; }
        public int PendingInvoices { get; set; }
        public int PendingCosts { get; set; }
        public int Tejrim { get; set; }
        public int TotalRecords { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? ATA { get; set; }
        public string Notes { get; set; }
        public string CountryOfDeparture { get; set; }
        //public string CountryOfDestination { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string Vessel { get; set; }
        public bool IsExport { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string MemberOf { get; set; }
        public int TotalJobs { get; set; }
	}
}
