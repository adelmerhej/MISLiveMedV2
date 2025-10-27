using System;

namespace MISLiveMed.Models.Models.Common.Countries
{
    public class CountryModel : EntityObject, ICloneable
    {
        public string Code2 { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string Nationality { get; set; }

        public decimal SurfaceArea { get; set; }
        public int IndependentYear { get; set; }
        public int Population { get; set; }
        public decimal LifeExpectancy { get; set; }
        public decimal GNP { get; set; }
        public decimal GNPOld { get; set; }
        public string LocalName { get; set; }
        public string GovernmentForm { get; set; }
        public string HeadOfState { get; set; }
        public int Capital { get; set; }

        public int ContinentId { get; set; }
        public int RegionId { get; set; }

        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var countryModel = (CountryModel)MemberwiseClone();
            return countryModel;
        }

        #endregion
    }
}
