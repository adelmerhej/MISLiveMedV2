using System;
using System.Collections.Generic;
using MISLiveMed.Models.Models.Members.Agents;
using MISLiveMed.Models.Models.Members.Customers;

namespace MISLiveMed.Models.Models.Members
{
    public class MemberModel
    {
        public int Id { get; set; }

        public string MemberName { get; set; }
        public int MemberTypeId { get; set; }
        public int MemberCategoryId { get; set; }
        public int? MemberOf { get; set; }
        public bool IsSales { get; set; }
        public int OrganizationId { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
        public string AccountNumber { get; set; }
        public string CostAccNo { get; set; }
        public bool Detail { get; set; }
        public decimal Commission { get; set; }
        public int SeqId { get; set; }
        public DateTime? FollowupDate { get; set; }
        public virtual List<CustomerModel> Customers { get; set; } = new List<CustomerModel>();
        public virtual List<AgentModel> Agents { get; set; } = new List<AgentModel>();

        public MemberModel()
        {
            Customers = new List<CustomerModel>();
        }

    }
}
