using System;

namespace MISLiveMed.Models.Models.Common.Departments
{
    public class DepartmentModel : EntityObject, ICloneable
    {
        public string DepartmentName { get; set; }
        public string ShortCode { get; set; }
        public string Prefix { get; set; }
        public int StartingNo { get; set; }
        public bool JobActive { get; set; }


        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var departmentModel = (DepartmentModel)MemberwiseClone();
            return departmentModel;
        }

        #endregion
    }
}
