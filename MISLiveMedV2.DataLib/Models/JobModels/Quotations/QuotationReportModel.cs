using System;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.Models.Models.JobModels.Quotations
{
    public class QuotationReportModel
    {
        public int Id { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime QuotationDate { get; set; }
        public int JobNo { get; set; }
        public string DepartmentName { get; set; }
        public string MemberName { get; set; }
        public string UserName { get; set; }
        public string SalesName { get; set; }
        public string Carrier { get; set; }
        public string AgentName { get; set; }
        public string Vol { get; set; }
        public string ETD { get; set; }
        public string ETA { get; set; }
        public string Pol { get; set; }
        public string Pod { get; set; }
        public string Terms { get; set; }
        public string ShipperName { get; set; }
        public bool Lost { get; set; }
        public EnumStatusType Status { get; set; }
        public bool Booked { get; set; }
        public bool Deleted { get; set; }
        public DateTime FollowupDate { get; set; }
        public decimal TotalProfit { get; set; }
        public string Notes { get; set; }

    }
}
