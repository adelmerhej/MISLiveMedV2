namespace MISLiveMed.Models.Models.Accounting.Reports.Statements
{
    public class TrialBalanceModel
    {
	    public string Number { get; set; }
	    public string AccountHeaderName { get; set; }
	    public string Serial { get; set; }
	    public string Currency { get; set; }
	    public string AccountNumber { get; set; }
	    public string AccountName { get; set; }
	    public string AccountTitle { get; set; }
	    public decimal AmountD { get; set; }
	    public decimal AmountC { get; set; }
	    public decimal LAmountD { get; set; }
	    public decimal LAmountC { get; set; }
	    public decimal FAmountD { get; set; }
	    public decimal FAmountC { get; set; }

	}
}
