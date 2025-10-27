using System;

namespace MISLiveMed.Models.Models.Reports.DOPBalances
{
    public class DetailedProfitReportModal
    {
        public int JobNo { get; set; }
        public DateTime JobDate { get; set; }
        public string DepartmentName { get; set; }

        //Total Invoice
        public decimal TotalInvoices { get; set;}
        public decimal PartialPaidInvoices { get; set; }

        //Total Cost
        public decimal TotalCosts { get; set; }
        public decimal PartialPaidCosts { get; set; }
        public decimal TotalCommission { get; set; }
        public decimal TotalCreditNotes { get; set; }

        //Total Profit
        public decimal TotalProfit { get; set; }
    }
}
