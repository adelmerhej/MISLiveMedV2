using System;

namespace MISLiveMed.Models.Models.Common.Countries
{
    public class DistrictModel : EntityObject, ICloneable
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public int ProvinceId { get; set; }


        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var districtModel = (DistrictModel)MemberwiseClone();
            return districtModel;
        }

        #endregion
    }
}
