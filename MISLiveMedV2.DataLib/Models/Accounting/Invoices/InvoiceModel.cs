using System;

namespace MISLiveMed.Models.Models.Accounting.Invoices
{
    public class InvoiceModel : EntityObject, ICloneable
    {
        public int InvoiceNo { get; set; }
        public string InvoiceRef { get; set; }
        public int JobId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int MemberId { get; set; }
        public bool ToNotified { get; set; }
        public int Notify { get; set; }
        public string Attn { get; set; }
        public string Subject { get; set; }
        public string Subject1 { get; set; }
        public string Subject2 { get; set; }
        public string Subject3 { get; set; }
        public int CurrencyId { get; set; }
        public decimal CurrencyRate { get; set; }
        public decimal Amount { get; set; }
        public decimal LAmount { get; set; }
        public decimal FAmount { get; set; }
        public decimal TotalItemVAT { get; set; }
        public decimal TotalItemNonVAT { get; set; }
        public decimal TotalVAT { get; set; }
        public decimal LTotalVAT { get; set; }
        public decimal FTotalVAT { get; set; }
        public bool IsAgent { get; set; }
        public int SalesId { get; set; }
        public int UserId { get; set; }
        public DateTime OperationDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool Posted { get; set; }
        public bool Original { get; set; }
        public bool Closed { get; set; }
        public DateTime? ClosedDate { get; set; }
        public bool Canceled { get; set; }
        public DateTime? CanceledDate { get; set; }
        public string Reason { get; set; }
        public decimal CurSLRate { get; set; }
        public decimal TotalReceived { get; set; }
        public decimal DiffOfExchange { get; set; }
        public decimal TotalCreditNote { get; set; }
        public decimal TotalDebitNote { get; set; }
        public decimal TotalDue { get; set; }
        public DateTime? PrintOriginalDate { get; set; }
        public int PrintOriginalByUser { get; set; }
        public DateTime? LastPrintOrigDate { get; set; }
        public int LastPrintOrigByUser { get; set; }
        public int JVNO { get; set; }
        public bool DebitNote { get; set; }
        public bool CreditNote { get; set; }
        public DateTime? DueDate { get; set; }
        public string RefNo { get; set; }
        public decimal SettledAmount { get; set; }
        public bool Paid { get; set; }


        #region Implementation of ICloneable

        public object Clone()
        {
            var newModel = (InvoiceModel)MemberwiseClone();
            return newModel;
        }

        #endregion

    }
}
