
using System;

namespace MISLiveMed.Models.Models.Members.Organizations
{
    public class OrganizationModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool Active { get; set; }
    }
}
