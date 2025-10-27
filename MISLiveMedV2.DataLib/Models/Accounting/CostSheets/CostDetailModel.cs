using System;

namespace MISLiveMed.Models.Models.Accounting.CostSheets
{
    public class CostDetailModel : EntityObject, ICloneable
    {
        public int SheetId { get; set; }
        public string Reference { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal LAmount { get; set; }
        public decimal FAmount { get; set; }
        public decimal ProvisionAmount { get; set; }
        public decimal LProvisionAmount { get; set; }
        public decimal FProvisionAmount { get; set; }


        #region Implementation of ICloneable

        public object Clone()
        {
            var costsheetDetailModel = (CostDetailModel)MemberwiseClone();
            return costsheetDetailModel;
        }

        #endregion
    }
}
