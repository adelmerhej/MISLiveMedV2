using System;

namespace MISLiveMed.Models.Models.Members.Customers.ReportsModel
{
    public class CustomersListReportModel
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string HomePage { get; set; }
        public string CurrentSale { get; set; }
        public string MofNo { get; set; }
        public DateTime Activation { get; set; }
    }
}
