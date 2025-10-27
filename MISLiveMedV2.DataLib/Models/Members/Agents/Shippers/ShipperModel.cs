using System;

namespace MISLiveMed.Models.Models.Members.Agents.Shippers
{
    public class ShipperModel : EntityObject, ICloneable
    {
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }

        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var continentModel = (ShipperModel)MemberwiseClone();
            return continentModel;
        }

        #endregion
    }
}
