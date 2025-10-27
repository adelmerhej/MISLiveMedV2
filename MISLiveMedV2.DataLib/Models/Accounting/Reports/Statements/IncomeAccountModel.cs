namespace MISLiveMed.Models.Models.Accounting.Reports.Statements
{
    public class IncomeAccountModel : EntityObject
    {
        public int AccountGroup { get; set; }
        public string AccountNumber { get; set; }
        public string AccountSerial { get; set; }
        public string Description { get; set; }
        public int BalanceGroupId { get; set; }
        public int Section { get; set; }
        public int ColumnList { get; set; }
        public int OrderInList { get; set; }
        public bool IsTotal { get; set; }
    }
}
