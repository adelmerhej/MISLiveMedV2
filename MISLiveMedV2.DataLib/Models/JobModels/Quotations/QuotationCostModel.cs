using System;

namespace MISLiveMed.Models.Models.JobModels.Quotations
{
    public class QuotationCostModel : EntityObject, ICloneable
    {
        public int QHeaderId { get; set; }
        public int AgentId { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; }
        public int PaymentId { get; set; }
        public int CurrencyId { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal LocalAmount { get; set; }
        public decimal ForeignAmount { get; set; }
        public decimal ProvisionAmount { get; set; }
        public decimal ProvisionAmountLL { get; set; }
        public decimal ProvisionAmountUSD { get; set; }
        public bool Vat { get; set; }
        public decimal VatRate { get; set; }
        public decimal VatAmount { get; set; }
        public decimal LocalVatAmount { get; set; }
        public decimal ForeignVatAmount { get; set; }
        public decimal ProvisionVATAmount { get; set; }
        public decimal ProvisionVATAmountLL { get; set; }
        public decimal ProvisionVATAmountUSD { get; set; }

        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var clonedModel = (QuotationCostModel)MemberwiseClone();
            return clonedModel;
        }

        #endregion
    }
}
