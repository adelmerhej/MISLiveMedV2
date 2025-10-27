using System;

namespace MISLiveMed.Models.Models.Accounting.Payments
{
    public class PaymentDetailModel : EntityObject
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDetailDate { get; set; }
        public int TypeId { get; set; }
        public int ReferenceId { get; set; }
        public DateTime? ValueDate { get; set; }
        public int CurrencyId { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal LAmount { get; set; }
        public decimal FAmount { get; set; }
        public float Discount { get; set; }
        public bool Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int ApprovedBy { get; set; }
        public bool Paid { get; set; }
        public DateTime? PaidDate { get; set; }
        public int PaidBy { get; set; }
    }
}
