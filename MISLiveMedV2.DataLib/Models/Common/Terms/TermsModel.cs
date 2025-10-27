
using System;

namespace MISLiveMed.Models.Models.Common.Terms
{
    public class TermsModel : EntityObject, ICloneable
    {
        public string TermCode { get; set; }
        public string Description { get; set; }

        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var termsModel = (TermsModel)MemberwiseClone();
            return termsModel;
        }

        #endregion
    }
}
