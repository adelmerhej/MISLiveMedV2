using System;

namespace MISLiveMed.Models.Models.JobModels.Import.AirFreight.Jobs
{
    public class JobAirImportModel : EntityObject, ICloneable
    {




        #region Implementation of ICloneable

        public object Clone()
        {
            var quotationModel = (JobAirImportModel)MemberwiseClone();
            return quotationModel;
        }

        #endregion
    }
}
