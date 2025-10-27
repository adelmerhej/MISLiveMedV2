using System;

//TODO: to be deleted

namespace MISLiveMed.Models.Models.Reports.Profit
{
    public class TotalDOPReportModel
    {
        public int JobNo { get; set; }
        public DateTime JobDate { get; set; }
        public string MemberName { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }


        // Invoices and Receivables
        public decimal TotalInvoices { get; set; }
        public decimal TotalInvoicesWithoutDebitNotes { get; set; }
        public decimal TotalPaidInvoicesWithoutDebitNotes { get; set; }
        public decimal TotalPendingInvoicesWithoutDebitNotes { get; set; }
        public decimal TotalInvoiceDebitNotes { get; set; }
        public decimal TotalPaidDebitNotes { get; set; }
        public decimal TotalPendingDebitNotes { get; set; }
        public decimal TotalPaidCreditNotes { get; set; }
        public decimal TotalPendingCreditNotes { get; set; }
        
        public decimal TotalCostSheets { get; set; }
        public decimal TotalCostSheetsWithoutCustoms { get; set; }
        public decimal TotalCostReceived { get; set; }
        public decimal TotalCostDebitNote { get; set; }
        public decimal TotalCostCreditNote { get; set; }
        public decimal TotalCostCustoms { get; set; }

        public decimal DOPTotalInvoices { get; set; }
        public decimal DOPTotalInvReceived { get; set; }
        public decimal DOPTotalInvDebitNotes { get; set; }
        public decimal DOPTotalInvCreditNotes { get; set; }

        public decimal DOPTotalCostSheets { get; set; }
        public decimal DOPTotalCostReceived { get; set; }
        public decimal TotalPaidDOPCostsJobsReceivedPaid { get; set; }
        public decimal DOPTotalCostDebitNotes { get; set; }
        public decimal DOPTotalCostCreditNotes { get; set; }
        public decimal DOPTotalCostCustoms { get; set; }

        public decimal TotalDOPCommissionJobsAmount { get; set; }
        public decimal TotalDOPCommissionDueAmount { get; set; }
        public decimal TotalDOPPendingCreditNote { get; set; }

        public decimal TotalDOPCollectedNotPaid { get; set; }
        public decimal TotalDOPPaidNotCollected { get; set; }


    }
}
