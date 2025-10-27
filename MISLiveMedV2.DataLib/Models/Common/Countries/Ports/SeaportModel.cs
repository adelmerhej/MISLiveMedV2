using System;

namespace MISLiveMed.Models.Models.Common.Countries.Ports
{
    public class SeaportModel : EntityObject, ICloneable
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }


        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var seaportModel = (SeaportModel)MemberwiseClone();
            return seaportModel;
        }

        #endregion
    }
}
