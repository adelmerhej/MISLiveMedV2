using System;

namespace MISLiveMed.Models.Models.Common.Categories
{
    public class CategoryModel : EntityObject, ICloneable
    {
        public string Description { get; set; }


        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var categoryModel = (CategoryModel)MemberwiseClone();
            return categoryModel;
        }

        #endregion
    }
}
