using System;

namespace MISLiveMed.Models.Models.Reports.TrackingReports
{
	public class ToBeLoadedReportModel
	{
		public string ReferenceNo { get; set; }
		public int JobNo { get; set; }
		public DateTime? JobDate { get; set; }
		public int DepartmentId { get; set; }
		public string DepartmentName { get; set; }
		public string Mbl { get; set; }
		public int CustomerId { get; set; }
		public string CustomerName { get; set; }
		public string Consignee { get; set; }
		public int DepartureId { get; set; }
		public string Departure { get; set; }
		public string Destination { get; set; }
		public string Vessel { get; set; }
		public DateTime? ArrivalDate { get; set; }
		public DateTime? ATD { get; set; }
		public DateTime? ATA { get; set; }
		public DateTime? ETD { get; set; }
		public DateTime? ETA { get; set; }
		public string AgentName { get; set; }
		public string Status { get; set; }
		public string JobType { get; set; }
		public string SeaCarrier { get; set; }
		public string ContainerType { get; set; }
		public string LoadedStatus { get; set; }
		public string LoadedDestination { get; set; }
		public DateTime? LoadingDate { get; set; }
		public DateTime? CutOffDate { get; set; }
		public DateTime? DeliveredDate { get; set; }
		public bool Tejrim { get; set; }
		public bool CanceledJob { get; set; }
		public int UserId { get; set; }
		public string UserName { get; set; }
		public int SalesId { get; set; }
		public string Salesman { get; set; }
		public int OperatingUserId { get; set; }
		public string OperatingUser { get; set; }


		public bool FullPaid { get; set; }
		public decimal SeaFreight { get; set; }
		public decimal TotalProfit { get; set; }
		public string MissingDocs { get; set; }
		public bool AlreadyLate { get; set; }
		public bool AllInOrderToBeLoaded { get; set; }
		public bool AllInOrderOnWater { get; set; }
		

		public int ShipperId { get; set; }
		public string Shipper { get; set; }
		public int ClearingAgentId { get; set; }
		public string ClearingAgent { get; set; }
	}
}
