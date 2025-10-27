using System;

namespace MISLiveMed.Models.Models.Reports.Profit
{
    public class DetailedTotalProfitReportModel
    {
        //public int TotalRecords { get; set; }
        public int SortingOrder { get; set; }
        public int JobNo { get; set; }
        public DateTime JobDate { get; set; }
        public string MemberName { get; set; }

        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        // Invoices, Costs, Profit (Job Status Related)
        public decimal TotalInvoices { get; set; }
        public decimal TotalCosts { get; set; }
       
        // Partial Inv Payment, Partial Cost Payment, Partial Commission
        public decimal PartialPaidInvoices { get; set; }
        public decimal PartialPaidCosts { get; set; }
        public decimal TotalCommission { get; set; }
        public decimal TotalCreditNotes { get; set; }


        // Invoices, Costs, Profit (DOP Balances Related)
        public decimal DopTotalInvoices { get; set; }
        public decimal DopTotalCosts { get; set; }
        //public decimal DopTotalProfit { get; set; }
        // DOP Inv Payment, Partial Cost Payment, Partial Commission
        public decimal DopPartialPaidInvoices { get; set; }
        public decimal DopPartialPaidCosts { get; set; }
        public decimal DopTotalCommission { get; set; }
        public decimal DopTotalCreditNotes { get; set; }

        // Invoices, Costs, Profit (DOP Balances Related)
        public decimal FPOTotalInvoices { get; set; }
        public decimal FPOTotalDebitInvoices { get; set; }
        //public decimal DopTotalProfit { get; set; }
        // DOP Inv Payment, Partial Cost Payment, Partial Commission
        public decimal FPOPartialPaidInvoices { get; set; }
        public decimal FPOTotalCosts { get; set; }

        public decimal FPOCreditPaidCosts { get; set; }
        public decimal FPOTotalCommission { get; set; }
        public decimal FPOTotalCreditNotes { get; set; }
        public decimal Paid_Not_Collected { get; set; }
        public decimal Collected_but_Not_Paid { get; set; }
        public string Notes { get; set; }
    }
}

