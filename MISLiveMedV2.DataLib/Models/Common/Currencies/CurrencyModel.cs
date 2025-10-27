using System;

namespace MISLiveMed.Models.Models.Common.Currencies
{
    public class CurrencyModel : EntityObject, ICloneable
	{
        public string CurrencyCode { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencyName { get; set; }
        public int DivByLocalRate { get; set; }
        public int DivideByForeignRate { get; set; }
        public decimal Decimals { get; set; }
        public int Rounding { get; set; }


        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
	        var newModel = (CurrencyModel)MemberwiseClone();
	        return newModel;
        }

        #endregion

	}
}
