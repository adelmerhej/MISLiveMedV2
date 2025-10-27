using System;

namespace MISLiveMed.Models.Models.ClientsReports
{
    public class InvoiceDetailReportModel
    {
        public int JobNo { get; set; }
        public string QuotationNo { get; set; }
        public string InvoiceNo { get; set; }
        public string Mbl { get; set; }
        public string Pol { get; set; }
        public string Pod { get; set; }
        public string Volume { get; set; }
        public string Supplier { get; set; }
        public string Customer { get; set; }
        public string Consignee { get; set; }
        public string MemberOf { get; set; }

        public DateTime? Etd { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? Atd { get; set; }
        public DateTime? Ata { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }
        public string Salesman { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int ReportGroup { get; set; }
        public string ReportGroupName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? AgentDueDate { get; set; }
        public decimal TotalInvoiceAmount { get; set; }
        public decimal TotalCostAmount { get; set; }
        public bool IsProtected { get; set; }
    }
}
