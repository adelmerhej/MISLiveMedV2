using System;
using MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs;

namespace MISLiveMed.Models.Models.JobModels.Import.AirFreight.Jobs
{
    public class JobAirImportDetailsModel : EntityObject, ICloneable
    {
        public int JobId { get; set; } = 0;
        public string Awb { get; set; }
        public int OrigId { get; set; }
        public string Origin { get; set; }
        public int SuppId { get; set; }
        public string Supplier { get; set; }
        public int Pieces { get; set; }
        public int Gross { get; set; }
        public int Charge { get; set; }
        public int Volume { get; set; }
        public double ValueOfGoods { get; set; }
        public string Terms { get; set; }
        public decimal CcAmount { get; set; }
        public bool Original { get; set; }
        public bool Photo { get; set; }
        public bool Pl { get; set; }
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
