namespace MISLiveMed.Models.Models.Accounting.Reports.Statements
{
    public class SpecialIncomeStatementModel
    {
        public int AccountGroup { get; set; }
        public string AccountNumber { get; set; }
        public string Description { get; set; }
        public int OrderInList { get; set; }
        public int ColumnList { get; set; }
        public int Section { get; set; }
        public bool IsTotal { get; set; }
        public decimal Amount1 { get; set; }
        public decimal Amount2 { get; set; }
        public decimal Amount3 { get; set; }
        public decimal Amount4 { get; set; }
        public int CurrencyId { get; set; }
    }
}
