using System;

namespace MISLiveMed.Models.Models.Common.Countries.Ports
{
    public class PortTypeModel : EntityObject, ICloneable
    {
        public string PortType { get; set; }


        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var portTypeModel = (PortTypeModel)MemberwiseClone();
            return portTypeModel;
        }

        #endregion
    }
}
