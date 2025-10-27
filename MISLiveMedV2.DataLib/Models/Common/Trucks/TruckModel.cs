using System;

namespace MISLiveMed.Models.Models.Common.Trucks
{
    public class TruckModel : EntityObject, ICloneable
    {
        public string Plate1 { get; set; }
        public string Plate2 { get; set; }
        public int RegistrationCountryId { get; set; }
        public string DriverName { get; set; }
        public int DriverNationalityId { get; set; }
        public bool IsMultiTruck { get; set; }
        public int DriverId { get; set; }
        public string TruckRemarks { get; set; }
        public string Remarks { get; set; }
        public int MemberId { get; set; }
        public bool Tir { get; set; }
        public DateTime? TruckDate { get; set; }


        #region Implementation of ICloneable

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
            var truckModel = (TruckModel)MemberwiseClone();
            return truckModel;
        }

        #endregion
    }
}
