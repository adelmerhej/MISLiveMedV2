using System;

namespace MISLiveMed.Models.Models.Reports.Quotations
{
    public class QuotationsJobsReportModel
    {
        public string Prefix { get; set; }
        public int ReferenceNo { get; set; }
        public int JobNo { get; set; }
        public string DepartmentName { get; set; }
        public DateTime QuotationDate { get; set;}
        public string CustomerName { get; set; }
        public string Consignee { get; set; }
        public string UserName { get; set;}
        public string Salesman { get; set;}
        public string Vol { get; set;}
        public string Departure { get; set;}
        public string Destination { get; set;}
        public string Notes { get; set;}
        public DateTime? FollowupDate { get; set;}
        public DateTime? BookedDate { get; set; }
        public DateTime? QuotedDate { get; set; }
       
        public string ShipperName { get; set; }
        public int DepartmentId { get; set;}
        public bool Booked { get; set;}
        public bool Lost { get; set;}
        public bool Deleted { get; set;}
        public string Status { get; set; }
        public int DepartmentsOrder { get; set; }
        public DateTime? RequestedDate { get; set; }
        public DateTime? LostDate { get; set; }
        public DateTime? CanceledDate { get; set; }

        public string FullReferenceNo()
        {
            return Prefix + ReferenceNo.ToString();
        }
    }
}
