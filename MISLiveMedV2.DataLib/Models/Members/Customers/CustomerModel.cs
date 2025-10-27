using System;

namespace MISLiveMed.Models.Models.Members.Customers
{
    public class CustomerModel : EntityObject
    {
        public string CustomerName { get; set; }
        public int? MemberOfId { get; set; }
        public DateTime? ActiveDate { get; set; }
        public DateTime? FollowupDate { get; set; }
        public DateTime? CNSSExpiryDate { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int CustomerCategoryId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string PhoneNumber3 { get; set; }
        public string FaxNumber { get; set; }
        public string Website { get; set; }
        public string PoBox { get; set; }
        public string MofNo { get; set; }
        public string Email { get; set; }
        public string Activity { get; set; }
        public bool IsSales { get; set; }
        public int ResponsibleId { get; set; }
        public int SalesId { get; set; }
        public int PaymentId { get; set; }
        public int Days { get; set; }
        public int CustomsDays { get; set; }
        public string PaymentStatus { get; set; }
        public decimal Amount { get; set; }
        public int Rating { get; set; }

    }
}
