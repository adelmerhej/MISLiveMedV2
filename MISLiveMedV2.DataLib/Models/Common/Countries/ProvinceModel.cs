using System;

namespace MISLiveMed.Models.Models.Common.Countries
{
    public class ProvinceModel : EntityObject, ICloneable
    {
        public string Name { get; set; }
        public int CountryId { get; set; }

        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var provinceModel = (ProvinceModel)MemberwiseClone();
            return provinceModel;
        }

        #endregion
    }
}
