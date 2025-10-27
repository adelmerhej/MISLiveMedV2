using System;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.Models.Models.JobModels.Cross.SeaFreight.Jobs
{
    public class JobSeaCrossModel : EntityObject, ICloneable
    {
        public string ReferenceNo { get; set; }
        public int DepartmentId { get; set; }
        public int JobNo { get; set; }
        public DateTime JobDate { get; set; }
        public string Mbol { get; set; }
        public string ContainerNo { get; set; }
        public string BookingNo { get; set; }

        public int CustomerId { get; set; }
        public int ConsigneeId { get; set; }
        public int AgentId { get; set; }
        public int SeaportDeparture { get; set; }
        public int CountryDeparture { get; set; }
        public int SeaportDestination { get; set; }
        public int CountryDestination { get; set; }
        public bool Bayan { get; set; }
        public int JobType { get; set; }
        public string Type { get; set; }
        public int SideId { get; set; }
        public string Commodity { get; set; }       //TNature
        public string Quantities { get; set; }      //TQtite
        public int Pieces { get; set; }             //TPieces
        public float Weight { get; set; }           //TWeight
        public float ValueOfGoods { get; set; }     //TValue
        public int ShippedWithId { get; set; }

        public int VesselId { get; set; }
        public int FeederVesselId { get; set; }
        public bool Delivered { get; set; }
        public string DeliveredTo { get; set; }
        public DateTime? DeliveredDate { get; set; }

        //Totals
        public int CurrencyId { get; set; }         //Cur
        public decimal TotalInvoicesLl { get; set; }
        public decimal TotalInvoicesUsd { get; set; }
        public decimal TotalCostsLl { get; set; }
        public decimal TotalCostsUsd { get; set; }

        public int OperatingUserId { get; set; }
        public int SalesId { get; set; }
        public int UserId { get; set; }


        public bool Project { get; set; }
        public bool Transit { get; set; }
        public bool FullPaid { get; set; }
        public DateTime? FullPaidDate { get; set; }
        public int ClearingAgentId { get; set; }

        public DateTime? ATD { get; set; }
        public DateTime? ATA { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? CutOffDate { get; set; }
        public DateTime? DOL { get; set; }
        public string PPCC { get; set; }
        public string Status { get; set; }
        public string Blstatus { get; set; }

        public bool RTejrim { get; set; }
        public DateTime? RTejrimDate { get; set; }
        public bool Tejrim { get; set; }
        public DateTime? TejrimDate { get; set; }
        public bool RClearance { get; set; }
        public DateTime? RClearanceDate { get; set; }
        public int IncoTerms { get; set; }
        public int IncoTermsFrom { get; set; }
        public int IncoTermsTo { get; set; }
        public bool AllInOrderToBeLoaded { get; set; }
        public bool AllInOrderOnWater { get; set; }
        public bool ContainerToCnee { get; set; }
        public DateTime? DtCntrToCnee { get; set; }
        public bool EmptyContainer { get; set; }
        public DateTime? DtEmptyCntr { get; set; }
        public int JobSCId { get; set; }

        public EnumJobStatus JobStatus { get; set; }
        public bool Closed { get; set; }
        public DateTime? ClosedDate { get; set; }
        public bool CanceledJob { get; set; }
        public DateTime? CanceledDate { get; set; }
        public int CanceledUser { get; set; }
        public int LastJobReopenedBy { get; set; }
        public DateTime? LastJobReopened { get; set; }
        public int CostReady { get; set; }
        public DateTime? CostReadyDate { get; set; }

        public virtual JobSeaCrossDetailModel JobSeaCrossDetails { get; set; } = new JobSeaCrossDetailModel();

        #region Implementation of ICloneable

        public object Clone()
        {
            var quotationModel = (JobSeaCrossModel)MemberwiseClone();
            return quotationModel;
        }

        #endregion
    }
}
