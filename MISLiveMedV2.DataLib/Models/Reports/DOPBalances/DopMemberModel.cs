using System;

namespace MISLiveMed.Models.Models.Reports.DOPBalances
{
    public class DopMemberModel
    {
        public int TransactionType { get; set; } // 1: Invoices, 2: Costs
        public string InvoiceNo { get; set;}
        //public string InvoiceDescription { get; set;}
        public int JobNo { get; set; }
        public string ReferenceNo { get; set; }
        public string DepartmentName { get; set;}
        public string ShortCode { get; set;}
        public string MemberName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime ValueDate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CurRate { get; set; }
        public decimal Amount { get; set; }
        public decimal SettledAmount { get; set; }
        public int Pending { get; set; }
        public string UserName { get; set; }
        public string SalesName { get; set; }
        public bool Tejrim { get; set; }
        public string BookingNo { get; set; }
        public string ETD { get; set; }
        public string ETA { get; set; }
        public int InvProvision { get; set; }
        public bool Provision { get; set; }
        public decimal FreshPayment { get; set; }
        public decimal USDRate { get; set; }
        public bool CancelJob { get; set; }
        public int Localization { get; set; }
        public decimal USDAmount { get; set; }


    }
}
