using System;

namespace MISLiveMed.Models.Models.Accounting.Journals
{
    public class JournalDetailModel : EntityObject, ICloneable
    {
	    public int JournalId { get; set; }
	    public int Line { get; set; }
	    public int ChartId { get; set; }
	    public int CostCenterId { get; set; }
	    public int FlowTypeId { get; set; }
	    public DateTime ValueDate { get; set; }
	    public int CurrencyId { get; set; }
	    public decimal Rate { get; set; }
	    public string Description { get; set; }
	    public string DbCr { get; set; }
	    public decimal Amount { get; set; }
	    public decimal LAmount { get; set; }
	    public decimal FAmount { get; set; }
	    public bool Posted { get; set; }
	    public string DocumentRef { get; set; }
	    public int JobNo { get; set; }
	    public int DepartmentId { get; set; }
		
	    #region Implementation of ICloneable

	    /// <summary>Creates a new object that is a copy of the current instance.</summary>
	    /// <returns>A new object that is a copy of this instance.</returns>
	    public object Clone()
	    {
		    var newModel = (JournalDetailModel)MemberwiseClone();
		    return newModel;
	    }

	    #endregion
    }
}
