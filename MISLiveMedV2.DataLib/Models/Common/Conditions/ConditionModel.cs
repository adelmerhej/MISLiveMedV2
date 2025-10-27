using System;

namespace MISLiveMed.Models.Models.Common.Conditions
{
    public class ConditionModel : EntityObject, ICloneable
    {
        public string Description { get; set; }


        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var conditionModel = (ConditionModel)MemberwiseClone();
            return conditionModel;
        }

        #endregion
    }
}
