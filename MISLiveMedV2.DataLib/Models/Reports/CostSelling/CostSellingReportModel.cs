namespace MISLiveMed.Models.Models.Reports.CostSelling
{
    public class CostSellingReportModel
    {
        public int Id { get; set; }
        public int QHeaderId { get; set; }
        public string MemberName { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string Payment { get; set; }
        public string Currency { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public bool Vat { get; set; }
        public decimal VatRate { get; set; }
        public string Section { get; set; }
    }
}
