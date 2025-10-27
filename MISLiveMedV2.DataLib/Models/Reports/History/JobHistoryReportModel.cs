using System;

namespace MISLiveMed.Models.Models.Reports.History
{
    public class JobsHistoryReportModel
    {
        public string ReferenceNo { get; set; }
        public int JobNo { get; set; }
        public DateTime JobDate { get; set; }
        public string MemberName { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }


        // Invoices and Receivables
        public decimal TotalInvoices { get; set; }
        public decimal TotalInvoicesWithoutDebitNote { get; set; }
        public decimal TotalInvoicesNotPaid { get; set; }
        public decimal TotalInvoicesPaid { get; set; }
        public decimal TotalDebitNotesNotPaid { get; set; }
        public decimal TotalDebitNotesPaid { get; set; }


        // CostSheet and Payable
        public decimal TotalCostSheets { get; set; }
        public decimal TotalCostSheetsWithoutCustoms { get; set; }
        public decimal TotalCostSheetsNotPaid { get; set; }
        public decimal TotalCostSheetsPaid { get; set; }
        public decimal TotalCustomsNotesNotPaid { get; set; }
        public decimal TotalCustomsNotesPaid { get; set; }
        public decimal TotalCreditNotesNotPaid { get; set; }
        public decimal TotalCreditNotesPaid { get; set; }
        public decimal TotalJobsPayablesReceived { get; set; }


        // DOP summary
        public decimal TotalDOPInvoicesJobsAmount { get; set; }
        public decimal PartialDOPPaidInvoices { get; set; }
        public decimal TotalDOPCostsJobsAmount { get; set; }

        // COMMISSION
        public decimal TotalDOPCommissionJobsAmount { get; set; }
        public decimal TotalDOPCommissionDueAmount { get; set; }

        // Total DOP Collected But Not Paid
        public decimal TotalDOPCollectedNotPaid { get; set; }
        public decimal TotalDOPPaidNotCollected { get; set; }
        public decimal TotalDOPPendingCreditNote { get; set; }

        //to check
        public decimal TotalDOPPaidCosts { get; set; }
    }
}
