using System;

namespace MISLiveMed.Models.Models.Members.Customers
{
    public class CustomerHistoryModel
    {
        public string DepartmentName { get; set; }
        public int JobId { get; set; }
        public int InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string ReferenceNo { get; set; }
        public bool Paid { get; set; }
        public string InvoiceType { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalReceived { get; set; }

    }
}
