using System;

namespace MISLiveMed.Models.Models.Reports.Accounting
{
    public class PaymentReportModel
    {
        public DateTime PaymentDate { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime? ValueDate { get; set; }
        public int JobNo { get; set; }
        public string DepartmentName { get; set; }
        public int JobReference { get; set; }
        public string RefNo { get; set; }
        public string AgentName { get; set; }
        public string CustomerName { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal LAmount { get; set; }
        public decimal FAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal PaidLAmount { get; set; }
        public decimal PaidFAmount { get; set; }

        public decimal RemainingAmount { get; set; }
        public decimal RemainingLAmount { get; set; }
        public decimal RemainingFAmount { get; set; }
    }
}
