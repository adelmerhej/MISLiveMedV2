using System;

namespace MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Reports
{
    public class EmptyContainerReportModel
    {
        public int OrderNo { get; set; }
        public int JobNo { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime JobDate { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string CustomerName { get; set; }
        public bool ContainerToCnee { get; set; }
        public DateTime? dtCntrToCnee { get; set; }
        public bool EmptyContainer { get; set; }
        public DateTime? dtEmptyCntr { get; set; }
        public string UserName { get; set; }
        public string SalesName { get; set; }
        public string Mbl { get; set; }
        public string ContainerNo { get; set; }
        public DateTime? Ata { get; set; }
        public string Status { get; set; }
        public string BlStatus { get; set; }
        public string Notes { get; set; }
        public DateTime? TejrimDate { get; set; }
        public string CarrierName { get; set; }
        public int ArrivalDays { get; set; }
        public int TejrimDays { get; set; }
        public int DiffCntrToCnee { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public bool FullPaid { get; set; }
        public DateTime? FullPaidDate { get; set; }
        public bool PaidDo { get; set; }
        public DateTime PaidDate { get; set; }
        public bool MissingDocuments { get; set; }
        public DateTime     MissingDocumentsDate { get; set; }
        public decimal     TotalInvoices { get; set; }
        public decimal     TotalCosts { get; set; }
        public decimal     TotalProfit { get; set; }
    }
}
