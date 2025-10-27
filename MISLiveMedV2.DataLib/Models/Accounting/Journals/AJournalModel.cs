using System;

namespace MISLiveMed.Models.Models.Accounting.Journals
{
    public class AJournalModel
    {
	    public string code { get; set; }
	    public DateTime date { get; set; }
	    public string reference { get; set; }
	    public float rate { get; set; }
	    public string jotype { get; set; }
	    public string creator { get; set; }
	    public string cr_time { get; set; }
	    public string lasteditor { get; set; }
	    public string le_time { get; set; }
    }
}
