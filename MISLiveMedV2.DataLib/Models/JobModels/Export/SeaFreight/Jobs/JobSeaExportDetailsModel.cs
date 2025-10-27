using System;

namespace MISLiveMed.Models.Models.JobModels.Export.SeaFreight.Jobs
{
    public class JobSeaExportDetailsModel : EntityObject, ICloneable
    {
        public int JobId { get; set; } = 0;
        public string Bol { get; set; }
        public int OrigId { get; set; }
        public string Origin { get; set; }
        public int SuppId { get; set; }
        public string Supplier { get; set; }
        public string ContNo { get; set; }
        public float Qty { get; set; }
        public string Unit { get; set; }
        public int UnitId { get; set; }
        public int Pieces { get; set; }
        public int UnitOfMeasureId { get; set; }
        public string Packages { get; set; }
        public double Weight { get; set; }
        public double ValueOfGoods { get; set; }
        public string Terms { get; set; }
        public decimal CcAmount { get; set; }
        public bool Original { get; set; }
        public bool Photo { get; set; }
        public bool Pl { get; set; }
        public bool Pop { get; set; }
        public string Commodity { get; set; }
        public string Notify { get; set; }


        #region Implementation of ICloneable

        public object Clone()
        {
            var quotationModel = (JobSeaExportDetailsModel)MemberwiseClone();
            return quotationModel;
        }

        #endregion

    }
}
