using System;

namespace MISLiveMed.Models.Models.Common.Carriers
{
    public class VesselModel : EntityObject, ICloneable
    {
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public string CaptainName { get; set; }
        public string Flag { get; set; }
        public string ShipLineAgentId { get; set; }
        public int NationalityId { get; set; }
        public string IMONumber { get; set; }
        public bool FeederVessel { get; set; }

        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var seaCarrierModel = (VesselModel)MemberwiseClone();
            return seaCarrierModel;
        }

        #endregion
    }
}
