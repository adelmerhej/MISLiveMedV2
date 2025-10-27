using System;

namespace MISLiveMed.Models.Models.Accounting.CostSheets
{
    public class CostModel : EntityObject, ICloneable
    {
        public int SheetNo { get; set; }
        public DateTime CostDate { get; set; }
        public int DepartmentId { get; set; }
        public int JobId { get; set; }
        public int OperationTypeId { get; set; }
        public int MemberId { get; set; }
        public int PaymentId { get; set; }
        public int CurrencyId { get; set; }
        public decimal CurrencyRate { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceRef { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal LTotalAmount { get; set; }
        public decimal FTotalAmount { get; set; }
        public bool DisplayProvisionColumns { get; set; }
        public decimal ProvisionTotalAmount { get; set; }
        public decimal LProvisionTotalAmount { get; set; }
        public decimal FProvisionTotalAmount { get; set; }
        public bool Paid { get; set; }
        public bool Locked { get; set; }
        public bool Posted { get; set; }
        public bool Closed { get; set; }
        public DateTime? ClosedDate { get; set; }
        public bool Canceled { get; set; }
        public DateTime? CanceledDate { get; set; }
        public int JvId { get; set; }

        #region Implementation of ICloneable

        public object Clone()
        {
            var costsheetModel = (CostModel)MemberwiseClone();
            return costsheetModel;
        }

        #endregion
    }
}
