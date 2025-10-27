using System;

namespace MISLiveMed.Models.Models.Common.Items
{
    public class ItemsPerDepartmentModel : EntityObject, ICloneable
    {
        public string ItemCode { get; set; }
        public int DepartmentId { get; set; }
        public int SubDeptId { get; set; }
        public string Due { get; set; }
        public bool PerKg { get; set; }
        public bool PerCbm { get; set; }
        public bool PerUnit { get; set; }
        public bool PerDo { get; set; }
        public decimal Rate { get; set; }
        public bool Vat { get; set; }
        public string CostGc { get; set; }
        public string InvoiceGc { get; set; }
        public int ByDefault { get; set; }
        public bool Profit { get; set; }
        public string CurrencyCode { get; set; }
        public int CurrencyId { get; set; }
        public bool Invoice { get; set; }
        public bool Locally { get; set; }
        public decimal Rank { get; set; }
        public string FreightCharges { get; set; }
        public decimal VatRate { get; set; }
        public string ItemAccNumber { get; set; }
        public string CostAccNumber { get; set; }


        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var itemDepartmentModel = (ItemsPerDepartmentModel)MemberwiseClone();
            return itemDepartmentModel;
        }

        #endregion
    }
}
