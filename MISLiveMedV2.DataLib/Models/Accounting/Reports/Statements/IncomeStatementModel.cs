namespace MISLiveMed.Models.Models.Accounting.Reports.Statements
{
    public class IncomeStatementModel
	{
		public string Number { get; set; }
		public string Description { get; set; }
		public string Chiff { get; set; }
		public decimal Amounta { get; set; }
		public decimal Amountb { get; set; }
		public decimal Amountn { get; set; }
		public bool IsTotal { get; set; }
		public int ColumnList { get; set; }
		public int OrderInList { get; set; }
	}
}
