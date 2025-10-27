using System;

namespace MISLiveMed.Models.Models.JobModels.Quotations
{
    public class QuotationCostPriceModel : EntityObject, ICloneable
    {
        public int VersionNo { get; set; }
        public DateTime? QuoteDate { get; set; }
        public int DepartmentId { get; set; }
        public int QuotationId { get; set; }
        public int SeaCarrierId { get; set; }
        public double TransitTime { get; set; }
        public int Validity { get; set; }
        public DateTime? ValidityDate { get; set; }
        public int CurrencyId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalLocalVatAmount { get; set; }
        public decimal TotalForeignVatAmount { get; set; }

        #region Implementation of ICloneable

        public object Clone()
        {
            var clonedModel = (QuotationCostPriceModel)MemberwiseClone();
            return clonedModel;
        }

        #endregion
    }
}
