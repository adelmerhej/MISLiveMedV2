using System;
using System.Collections.Generic;

namespace MISLiveMed.Models.Models.JobModels.Quotations
{
    public class QuotationHeaderCostSellingModel : EntityObject
    {
        public DateTime? QuoteDate { get; set; }
        public DateTime? BookingDate { get; set; }
        public int QuotationId { get; set; }
        public int DepartmentId { get; set; }
        public int AgentId { get; set; }
        public int SeaCarrierId { get; set; }
        public int MemberId { get; set; }
        public int VersionNo { get; set; }
        public double TransitTime { get; set; }
        public int Validity { get; set; }
        public DateTime? ValidityDate { get; set; }
        public int UserId { get; set; }
        public bool DisplayProvisionColumns { get; set; }
        public virtual List<QuotationCostModel> QuotationRealCostDetails { get; set; } = new List<QuotationCostModel>();
        public virtual List<QuotationSellingModel> QuotationSellingModels { get; set; } = new List<QuotationSellingModel>();
    }
}
