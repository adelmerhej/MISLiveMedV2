using System;

namespace MISLiveMed.Models.Models.Accounting.Commissions
{
    public class CommissionManagerModel : EntityObject
    {
        public int SalesId { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public decimal SalesProfitShare { get; set; }
        public decimal RecurringSalesProfitShare { get; set; }
        public decimal FixCommission { get; set; }
        public decimal DefaultOfficeFees { get; set; }
        public decimal DefaultTransferFees { get; set; }
        public bool IsSales { get; set; }
    }
}
