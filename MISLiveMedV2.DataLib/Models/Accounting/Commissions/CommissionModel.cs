using System;

namespace MISLiveMed.Models.Models.Accounting.Commissions
{
    public class CommissionModel : EntityObject
    {
        public DateTime CommissionDate { get; set; }
        public int JobId { get; set; }
        public int DepartmentId { get; set; }
        public int CustomerId { get; set; }
        public int OperatingUserId { get; set; }
        public decimal TotalInvoices { get; set; }
        public decimal TotalCosts { get; set; }
        public decimal TotalRealCosts { get; set; }
        public bool Paid { get; set; }
        public bool IsDue { get; set; }

    }
}
