
using System;

namespace MISLiveMed.Models.Models.Members.Categories
{
    public class MemberTypeModel
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Notes { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool Active { get; set; }
    }
}
