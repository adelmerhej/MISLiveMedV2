using System;

namespace MISLiveMed.Models.Models.Accounting.Journals
{
    public class JournalModel: EntityObject, ICloneable
    {
	    public int JvNo { get; set; }
	    public int JournalTypeId { get; set; }
	    public DateTime JournalDate { get; set; }
	    public string Reference { get; set; }
	    public int CurrencyId { get; set; }
	    public decimal Rate { get; set; }
	    public bool IsPosted { get; set; }
	    public bool IsCloned { get; set; }


	    #region Implementation of ICloneable

	    /// <summary>Creates a new object that is a copy of the current instance.</summary>
	    /// <returns>A new object that is a copy of this instance.</returns>
	    public object Clone()
		{
			var newModel = (JournalModel)MemberwiseClone();
			return newModel;
		}

	    #endregion
    }
}
