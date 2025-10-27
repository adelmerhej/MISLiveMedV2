using System;

namespace MISLiveMed.Models.Models.JobModels.Import.SeaFreight
{
    public class JobSeaImportQuotModel
    {
        public int Id { get; set; }
        public int JobNo { get; set; }
        public DateTime JobDate { get; set; }
        public int UserId { get; set; }
        public int ConsigneeId { get; set; }
        public int Consignee { get; set; }
        public int Departure { get; set; }
        public int Destination { get; set; }
        public int JobType { get; set; }
        public int CarrierId { get; set; }
        public int AgentId { get; set; }
    }
}
