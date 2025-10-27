using System;

namespace MISLiveMed.Models.Models.Reports.CostSelling
{
    public class BookingSheetReportModel
    {
        public int Id { get; set; }
        public int VersionNo { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime? QuotationDate { get; set; }
        public int JobNo { get; set; }
        public string MemberName { get; set; }
        public string SalesName { get; set; }
        public string UserName { get; set; }
        public string Carrier { get; set; }
        public string AgentName { get; set; }
        public string Vol { get; set; }
        public DateTime? Etd { get; set; }
        public DateTime? Eta { get; set; }
        public string Pol { get; set; }
        public string Pod { get; set; }
        public string Terms { get; set; }
        public string ShipperName { get; set; }
        public string CostDescription { get; set; }
        public string SellingDescription { get; set; }
        public string CommissionDescription { get; set; }
        public decimal TotalSelling { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalProfit { get; set; }
        public decimal Commission { get; set; }
        public string Notes { get; set; }
        public string ValidityDescription { get; set; }
        public int Validity { get; set; }
        public int TransitTime { get; set; }
        public decimal TotalCostVatAmount { get; set; }
        public decimal TotalSellingVatAmount { get; set; }
    }
}
