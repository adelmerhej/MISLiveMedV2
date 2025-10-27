using System;

namespace MISLiveMed.Models.Models.Common.Conditions
{
    public class ConditionDetailModel : EntityObject, ICloneable
    {
        public int ConditionId { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; }
        public bool IsFulFilled { get; set; }
        public bool IsVisible { get; set; }
        public DateTime RequiredEffectiveDate { get; set; }
        public bool ReadyForTejrimDefault { get; set; }


        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var conditionDetailModel = (ConditionDetailModel)MemberwiseClone();
            return conditionDetailModel;
        }

        #endregion
    }
}
