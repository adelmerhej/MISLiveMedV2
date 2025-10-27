namespace MISLiveMed.Models.Models.Accounting.Reports.Statements
{
    public class DetailedIncomeStatementModel
    {
        public int DepartmentId { get; set; }
        public string ShortCode { get; set; }
        public string DepartmentName { get; set; }
        public int JobNo { get; set; }
        public string CustomerName { get; set; }
		public decimal TotalInvoices { get; set; }
        public decimal TotalRevenues { get; set; }
        public decimal ProvisionInvoices { get; set; }
		public decimal TotalCosts { get; set; }
		public decimal TotalSubContracts { get; set; }
        public decimal ProvisionCosts { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal RealGrossProfit { get; set; }
        public string InvoiceNo { get; set; }
        public string CostInvoiceNo { get; set; }
        public bool InvProvision { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
    }
}
