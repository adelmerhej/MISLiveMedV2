using System;

namespace MISLiveMed.Models.Models.Common.Currencies
{
    public class CurrencyExchangeModel : EntityObject, ICloneable
    {
        public int CurrencyId { get; set; }
        public DateTime ExchangeDate { get; set; }
        public decimal ExchangeValue { get; set; }
        public decimal HighValue { get; set; }
        public int WeekNumber { get; set; }


        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var newModel = (CurrencyExchangeModel)MemberwiseClone();
            return newModel;
        }

        #endregion

    }
}
