
using System;

namespace MISLiveMed.Models.Models.Members.Customers.ReportsModel
{
    public class CustomerDetailedListReportModel
    {
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string MemberType { get; set; }
        public string MemberCategory { get; set; }
        public string MemberOf { get; set; }
        public bool IsSales { get; set; }
        public string Organization { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
        public string AccountNumber { get; set; }
        public string CostAccNo { get; set; }
        public decimal Commission { get; set; }
        public string ThirdParty { get; set; } //it could be sales, agent, or any other member who get this client
        public DateTime CreationDate { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string HomePage { get; set; }
        public string CurrentSale { get; set; }
        public DateTime CurrentSalesDate { get; set; }
        public string SalesMemo { get; set; }
        public string Category { get; set; }
        public string Activity { get; set; }
        public string Responsible { get; set; }
        public string MofNo { get; set; }
        public DateTime Activation { get; set; }

    }
}
