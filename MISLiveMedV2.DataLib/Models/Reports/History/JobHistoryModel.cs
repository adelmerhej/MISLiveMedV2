using System;

namespace MISLiveMed.Models.Models.Reports.History
{
    public class JobHistoryModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperatorId { get; set; }
        public int InvoiceID { get; set; }
        public int JobId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime ChangeDate { get; set; }
        public string Operation { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string Section { get; set; }

    }
}
