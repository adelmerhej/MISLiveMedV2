using System;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs
{
    public class JobSeaImportModel : EntityObject, ICloneable
    {
        public string ReferenceNo { get; set; }
        public int DepartmentId { get; set; }
        public int JobTypeId { get; set; }
        public int JobNo { get; set; }
        public DateTime JobDate { get; set; }
        public string Mbl { get; set; }
        public int CustomerId { get; set; } 
        public int ConsigneeId { get; set; }
        public int SeaportDeparture { get; set; }
        public int CountryDeparture { get; set; }
        public int SeaportDestination { get; set; }
        public int CountryDestination { get; set; }

		//Agent and Booking
		public int AgentId { get; set; }
		public string BookingNo { get; set; }
		public string FreeOfDemurrage { get; set; }
		public int ShippedWithId { get; set; }
		public int SideId { get; set; }

		//Commodities
		public string NatureOfGoods { get; set; }
		public float ValueOfGoods { get; set; }

		//Volume
		public string Quantities { get; set; }
		public string Volume { get; set; }
        public int Pieces { get; set; }             
        public float Weight { get; set; }           
        
        public int VesselId { get; set; }
        public int FeederVesselId { get; set; }

        //Totals
        public int PreferredCurrencyId { get; set; }
        public decimal TotalInvoicesLl { get; set; }
        public decimal TotalInvoicesUsd { get; set; }
        public decimal TotalCostsLl { get; set; }
        public decimal TotalCostsUsd { get; set; }

		//Users
		public int OperatingUserId { get; set; }
        public int SalesId { get; set; }
        public int UserId { get; set; }
        
        public bool Project { get; set; }
        public bool Transit { get; set; }
        public bool FullPaid { get; set; }
        public DateTime? FullPaidDate { get; set; }
        public int ClearingAgentId { get; set; }

		//Trace and tracking Dates
		public DateTime? Etd { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? Atd { get; set; }
        public DateTime? Ata { get; set; }
        public DateTime? CutOffDate { get; set; }
        public DateTime? LoadingDate { get; set; }
        public string Ppcc { get; set; }

        public string Status { get; set; }
        public string BlStatus { get; set; }

        public bool RTejrim { get; set; }
        public DateTime? RTejrimDate { get; set; }
        public bool Tejrim { get; set; }
        public DateTime? TejrimDate { get; set; }
        public bool RClearance { get; set; }
        public DateTime? RClearanceDate { get; set; }

		public int IncoTerms { get; set; }

        public bool AllInOrderToBeLoaded { get; set; }
        public bool AllInOrderOnWater { get; set; }

        public bool @PendingForDelivery { get; set; }
        public DateTime? @PendingDeliveryDate { get; set; }
        public bool Delivered { get; set; }
        public string DeliveredTo { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public bool ContainerToCnee { get; set; }
        public DateTime? ContainerToCneeDate { get; set; }
        public bool EmptyContainer { get; set; }
        public DateTime? EmptyContainerDate { get; set; }
        public bool ConfirmEmptyContainer { get; set; }
        public DateTime? ConfirmEmptyContainerDate { get; set; }

        public int JobScId { get; set; }

        public EnumJobStatus JobStatus { get; set; }
        public bool Closed { get; set; }
        public DateTime? ClosedDate { get; set; }
        public bool CancelledJob { get; set; }
        public DateTime? CancelledJobDate { get; set; }
        public int CancelledJobByUserId { get; set; }
        public int LastJobReopenedBy { get; set; }
        public DateTime? LastJobReopenedDate{ get; set; }
        public int CostReady { get; set; }
        public DateTime? CostReadyDate { get; set; }
        public bool PaidDO { get; set; }
        public DateTime? PaidDODate { get; set; }
        public bool MissingDocuments { get; set; }
        public DateTime? MissingDocumentsDate { get; set; }
        public DateTime? ArrivalDate { get; set; }

		public virtual JobSeaImportDetailModel JobSeaImportDetails { get; set; } = new JobSeaImportDetailModel();

        #region Implementation of ICloneable

        public object Clone()
        {
            var quotationModel = (JobSeaImportModel)MemberwiseClone();
            return quotationModel;
        }

        #endregion

    }
}
