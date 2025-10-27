using System;

namespace MISLiveMed.Models.Models.Common.Countries
{
    public class CityModel : EntityObject, ICloneable
    {
        public int CountryId { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public int DistrictId { get; set; }
        public decimal Population { get; set; }
        public bool IsCapital { get; set; }


        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var cityModel = (CityModel)MemberwiseClone();
            return cityModel;
        }

        #endregion
    }
}
