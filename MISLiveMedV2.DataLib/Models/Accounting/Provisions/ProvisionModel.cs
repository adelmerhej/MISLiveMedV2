using System;

namespace MISLiveMed.Models.Models.Accounting.Provisions
{
    public class ProvisionModel : EntityObject, ICloneable
    {
        public int ProvisionTypeId { get; set; }
        public DateTime ProvisionDate { get; set; }
        public int CurrencyId { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal LAmount { get; set; }
        public decimal FAmount { get; set; }
        public int WorkingYear { get; set; }    // TODO: to be moved to EntityObject


        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var classModel = (ProvisionModel)MemberwiseClone();
            return classModel;
        }

        #endregion
    }
}
