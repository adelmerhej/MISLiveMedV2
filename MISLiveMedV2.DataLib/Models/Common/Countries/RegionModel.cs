using System;

namespace MISLiveMed.Models.Models.Common.Countries
{
    public class RegionModel : EntityObject, ICloneable
    {
        public string Name { get; set; }
        public int ContinentId { get; set; }

        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var regionModel = (RegionModel)MemberwiseClone();
            return regionModel;
        }

        #endregion
    }
}
