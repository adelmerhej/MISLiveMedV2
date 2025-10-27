using System;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.Models.Models.Reports.Quotations
{
    public class QuotationsJobsDataReport
    {
        public int Id { get; set; }
        public string DepartmentPrefix { get; set; }
        public int ReferenceNo { get; set; }
        public int DepartmentId { get; set; }
        public int MemberId { get; set; }
        public int ConsigneeId { get; set; }
        public DateTime QuotationDate { get; set; }
        public int UserId { get; set; }
        public int SalesId { get; set; }
        public string Vol { get; set; }
        public int Pol { get; set; }
        public int Pod { get; set; }
        public string Notes { get; set; }
        public bool Lost { get; set; }
        public EnumStatusType Status { get; set; }
        public int? AgentId { get; set; }
        public int? CarrierId { get; set; }
        public bool Attention { get; set; }
        public bool Booked { get; set; }
        public DateTime FollowupDate { get; set; }
        public string CustomerName { get; set; }
        public string Consignee { get; set; }
        public decimal TotalProfit { get; set; }
        public DateTime? BookedDate { get; set; }
        public int TermsId { get; set; }
        public int JobNo { get; set; }
        public string ShipperName { get; set; }

        public string FullReferenceNo()
        {
            return DepartmentPrefix + ReferenceNo.ToString();
        }
    }
}
