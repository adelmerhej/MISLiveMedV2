namespace MISLiveMed.Models.Models.Accounting.Reports.Statements
{
	public class BalanceSheetInitialModel
	{
		public string Number { get; set; }
		public string Serial { get; set; }
		public string AccountName { get; set; }
		public string Code { get; set; }
		public string CurrencyCode { get; set; }
		public string DbCr { get; set; }
		public decimal OPLL { get; set; }
		public decimal OPUSD { get; set; }
		public decimal DBLL { get; set; }
		public decimal DBUSD { get; set; }
		public decimal CRLL { get; set; }
		public decimal CRUSD { get; set; }
	}

	public class BalanceSheetModel : EntityObject
    {
	    public int BalanceHeaderId { get; set; }
	    public int ParentId { get; set; }
	    public string AccountNumber { get; set; }
	    public string Description { get; set; }
	    public string DbCr { get; set; }
	    public bool ColumnFirst { get; set; }
	    public bool ColumnSecond { get; set; }
	    public bool IsTotal { get; set; }
	    public bool IsGrandTotal { get; set; }
	    public int OrderInList { get; set; }
	}

	public class ExtendedBalanceSheetSettingModel : EntityObject
	{
		public int BalanceHeaderId { get; set; }
		public int ParentId { get; set; }
		public string AccountNumber { get; set; }
		public string Description { get; set; }
		public string Chiff { get; set; }
		public string DbCr { get; set; }
		public decimal Amounta { get; set; }
		public decimal Amountb { get; set; }
		public decimal Amountn { get; set; }
		public bool ColumnFirst { get; set; }
		public bool ColumnSecond { get; set; }
		public int OrderInList { get; set; }
		public bool IsTotal { get; set; }
		public bool IsGrandTotal { get; set; }
		public int UserId { get; set; }
	}
}
