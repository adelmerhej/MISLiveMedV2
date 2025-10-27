using System;

namespace MISLiveMed.Models.Models.JobModels.Quotations
{
    public class BookingSheetModel
    {
        public int Id { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime QuotationDate { get; set; }
        public int JobNo { get; set; }
        public string CustomerName { get; set; }
        public string SalesName { get; set; }
        public string ShipperName { get; set; }
        public string AgentName { get; set; }
        public double Volume { get; set; }
        public string Weight { get; set; }
        public DateTime Etd { get; set; }
        public DateTime Eta { get; set; }
        public string Pol { get; set; }
        public string Pod { get; set; }
        public bool SubjectToClearance { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalSelling { get; set; }
        
    }
}
