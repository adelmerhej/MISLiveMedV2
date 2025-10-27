namespace MISLiveMed.Models.Models.Accounting.Commissions
{
    public class CommissionDetailModel : EntityObject
    {
        public int CommissionManagerId { get; set; }
        public int CommissionId { get; set; }
        public int SalesId { get; set; }
        public int CurrencyId { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal LAmount { get; set; }
        public decimal FAmount { get; set; }
        public decimal SalesProfitShare { get; set; }
        public decimal FixCommission { get; set; }
        public bool Paid { get; set; }
    }
}
