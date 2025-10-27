using System;

namespace MISLiveMed.Models.Models.Accounting.Invoices
{
    public class InvoiceDetailModel : EntityObject, ICloneable
    {
        public int InvoiceId { get; set; }
        public int ItemId { get; set; }
        public int ItemCode { get; set; }
        public string Description { get; set; }
        public int CurrencyId { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal LAmount { get; set; }
        public decimal FAmount { get; set; }
        public bool VAT { get; set; }
        public decimal VATRate { get; set; }
        public decimal VATValue { get; set; }
        public bool AllowEdit { get; set; } // to be used by admin to allow edit for specific user


        #region Implementation of ICloneable

        public object Clone()
        {
            var newModel = (InvoiceDetailModel)MemberwiseClone();
            return newModel;
        }

        #endregion

    }
}
