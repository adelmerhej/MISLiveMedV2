using System;

namespace MISLiveMed.Models.Models.Reports.Profit
{
    public class DetailedProfitReportModel
    {
        public int JobNo { get; set; }

        public DateTime JobDate { get; set; }

        public int CustomerId { get; set; }

        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }
        public string CustomerName { get; set; }

        public Decimal TotalInvoices { get; set; }
        public int PendingInvoices { get; set; }
        public Decimal TotalDebitNotesNotPaid { get; set; }
        public Decimal TotalCosts { get; set; }
        public int PendingCosts { get; set; }
        public Decimal TotalCustomsNotesNotPaid { get; set; }

        //
        public Decimal TotalDopInvoices { get; set; }
        public Decimal TotalDopCosts { get; set; }


        //
        public Decimal TotalDopCollectedNotPaid { get; set; }
        public Decimal TotalDopPaidNotCollected { get; set; }

        public Decimal TotalDopPendingCreditNote { get; set; }
        public Decimal PartialDopCollectedNotPaid { get; set; }

        public Decimal TotalPartialCollectedNotPaid { get; set; }
        public string Notes { get; set; }

    }
}
