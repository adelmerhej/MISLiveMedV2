using System;

namespace MISLiveMed.Models.Models.Members.Agents
{
    public class AgentModel : EntityObject
    {
        public string AgentName { get; set; }
        public int MemberOfId { get; set; }
        public DateTime? ActiveDate { get; set; }
        public DateTime? FollowupDate { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int AgentGroupId { get; set; }
        public int AgentCategoryId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string PhoneNumber3 { get; set; }
        public string FaxNumber { get; set; }
        public string Website { get; set; }
        public string MofNo { get; set; }
        public string Email { get; set; }
        public string Activity { get; set; }
        public bool IsSales { get; set; }
        public int ResponsibleId { get; set; }
        public int SalesId { get; set; }
        public string PostalCode { get; set; }
        public string PostalAddress { get; set; }
        public int Branch { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Days { get; set; }
        public int OldId { get; set; }
    }
}
