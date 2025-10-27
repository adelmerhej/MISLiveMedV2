using System;

namespace MISLiveMed.Models.Models.Reports.JobsStatus
{
    public class JobStatusReportModel
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
        public string MemberOf { get; set; }
        public string ConsigneeName { get; set; }
        public int PendingInvoices { get; set; }
        public int PendingCosts { get; set; }
        public int Tejrim { get; set; }
        public int TotalRecords { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int JobType { get; set; }
        public DateTime? ATA { get; set; }
        public DateTime? ETA { get; set; }
    }
}
