using System;
using MISLiveMed.Utils.Enums;

namespace MISLiveMed.Models.Models.JobModels.Quotations
{
    public class QuotationModel : EntityObject, ICloneable
    {
	    public string DepartmentPrefix { get; set; }
	    public int ReferenceNo { get; set; }
	    public int DepartmentId { get; set; }
	    public DateTime QuotationDate { get; set; }
	    public int MemberId { get; set; }
	    public int ConsigneeId { get; set; }
	    public int UserId { get; set; }
	    public int SalesId { get; set; }
	    public string Vol { get; set; }
	    public int Pol { get; set; }
	    public int Pod { get; set; }
	    public EnumStatusType Status { get; set; }
	    public int? AgentId { get; set; }
	    public int? CarrierId { get; set; }
	    public bool Attention { get; set; }
	    public bool Booked { get; set; }
	    public DateTime? BookedDate { get; set; }
	    public DateTime? FollowupDate { get; set; }
	    public DateTime? QuotedDate { get; set; }
	    public bool Lost { get; set; }
	    public DateTime? LostDate { get; set; }
	    public bool Canceled { get; set; }
	    public DateTime? CanceledDate { get; set; }
	    public string Reason { get; set; }
	    public bool Urgent { get; set; }
	    public DateTime? UrgentDate { get; set; }
	    public DateTime? RequestDate { get; set; }
	    public int JobNo { get; set; }
	    public DateTime? ETD { get; set; }
	    public DateTime? ETA { get; set; }
	    public DateTime? ATD { get; set; }
	    public DateTime? ATA { get; set; }
	    public int TermsId { get; set; }
	    public string ShipperName { get; set; }
	    public DateTime? DeletedDate { get; set; }
	    public decimal TotalProfit { get; set; }

		public string FullReferenceNo()
        {
            return DepartmentPrefix + ReferenceNo.ToString();
        }

        #region Implementation of ICloneable

        public object Clone()
        {
            var quotationModel = (QuotationModel)MemberwiseClone();
            return quotationModel;
        }

        #endregion
    }
}
