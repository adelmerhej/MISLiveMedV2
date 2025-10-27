using System;

namespace MISLiveMed.Models.Models.ClientsReports
{
    public class ClientDetailReportModel
    {
        public int JobNo { get; set; }
        public string QuotationNo { get; set; }
        public string Pol { get; set; }
        public string Pod { get; set; }
        public string Volume { get; set; }
        public string Shipper { get; set; }
        public string Consignee { get; set; }
        public DateTime? LoadingDate { get; set; }
        public DateTime? CutOffDate { get; set; }
        public string Hbl { get; set; }
        public DateTime? Etd { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? Atd { get; set; }
        public DateTime? Ata { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }
        public string Salesman { get; set; }
        public int DepartmentId  { get; set; }
        public string DepartmentName { get; set; }
        public int ReportGroup { get; set; }
        public string ReportGroupName { get; set; }
        public decimal TotalInvoices { get; set; }
        public decimal TotalCosts { get; set; }

    }
}
