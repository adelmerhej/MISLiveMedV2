using System;

namespace MISLiveMed.Models.Models.Reports
{
    public class AirDataReportModel
    {
        public int JobNo { get; set; }
        public DateTime? JobDate { get; set; }
        public string ReferenceNo { get; set; }
        public string MAWB { get; set; }

        public string CustomerName { get; set; }
        public string Consignee { get; set; }
        public string AgentName { get; set; }
        public string Airline { get; set; }
        public string FlightNo1 { get; set; }
        public string Via { get; set; }
        public string FlightNo2 { get; set; }
        public string AirportDeparture { get; set; }
        public string AirportDestination { get; set; }
        public string Carrier { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? ATD { get; set; }
        public DateTime? ATA { get; set; }
        public DateTime? CutOffDate { get; set; }
        public DateTime? LoadingDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public string Sales { get; set; }
        public string OperatingUser { get; set; }
        public string Status { get; set; }
        public string JobType { get; set; }
        public string MissingDocs { get; set; }
        public bool Tejrim { get; set; }
        public bool CancelJob { get; set; }
        public int UserId { get; set; }
        public decimal TotalProfit { get; set; }
    }
}
