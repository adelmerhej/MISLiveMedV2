using System;

namespace MISLiveMed.Models.Models.Accounting.Payments
{
    public class PaymentModel : EntityObject
    {
        public DateTime PaymentDate { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime? ValueDate { get; set; }
        public int PaymentTypeId { get; set; }
        public int JobId { get; set; }
        public int DepartmentId { get; set; }
        public string ReferenceNo { get; set; }
        public int ReferenceId { get; set; }
        public int MemberTypeId { get; set; }
        public int MemberId { get; set; }
        public int CustomerId { get; set; }
        public int CurrencyId { get; set; }
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

        public decimal Discount { get; set; }
        public bool Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int ApprovedBy { get; set; }
        public bool Paid { get; set; }
        public DateTime? PaidDate { get; set; }
        public int PaidBy { get; set; }
        public bool Posted { get; set; }
        public bool Protected { get; set; }

    }
}
