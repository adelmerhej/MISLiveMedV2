using System;

namespace MISLiveMed.Models.Models.Accounting.Reports.Settings
{
    public class BalanceSheetSettingModel : EntityObject, ICloneable
    {
	    public int BalanceHeaderId { get; set; }
	    public int ParentId { get; set; }
	    public string AccountNumber { get; set; }
	    public string Description { get; set; }
	    public string DbCr { get; set; }
	    public bool ColumnFirst { get; set; }
	    public bool ColumnSecond { get; set; }
	    public int OrderInList { get; set; }
	    public bool IsTotal { get; set; }
	    public bool IsGrandTotal { get; set; }

		#region Implementation of ICloneable

		/// <summary>Creates a new object that is a copy of the current instance.</summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone()
	    {
			var newModel = (BalanceSheetSettingModel)MemberwiseClone();
			return newModel;
		}

	    #endregion
    }
}