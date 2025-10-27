using System;

namespace MISLiveMed.Models.Models.Common.Items
{
    public class ItemModel : EntityObject, ICloneable
    {
        public string ItemCode { get; set; }
        public string Description { get; set; }


        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var itemModel = (ItemModel)MemberwiseClone();
            return itemModel;
        }

        #endregion
    }
}
