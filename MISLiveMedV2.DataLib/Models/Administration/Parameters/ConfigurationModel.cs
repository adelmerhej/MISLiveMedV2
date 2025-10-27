using System;

namespace MISLiveMed.Models.Models.Administration.Parameters
{
    public class ConfigurationModel : EntityObject, ICloneable
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }
        public string TextValue { get; set; }

        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var configurationModel = (ConfigurationModel)MemberwiseClone();
            return configurationModel;
        }

        #endregion
    }
}
