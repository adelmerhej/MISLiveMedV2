using System;

namespace MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs
{
    public class JobSeaImportDetailModel : EntityObject, ICloneable
    {
        public int JobId { get; set; } = 0;
        public string Hbl { get; set; }
        public int OriginId { get; set; }
        public int SupplierId { get; set; }
        public string ContainerNo { get; set; }
        public float Quantities { get; set; }
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
            var quotationModel = (JobSeaImportDetailModel)MemberwiseClone();
            return quotationModel;
        }

        #endregion

    }
}
