using System;

namespace MISLiveMed.Models.Models.Accounting.Journals
{
	public class AdetailModel
	{
		public string code { get; set; }
		public string line { get; set; }
		public string number { get; set; }
		public string serial { get; set; }
		public string centre { get; set; }
		public string currency { get; set; }
		public string label { get; set; }
		public string type { get; set; }
		public DateTime vdate { get; set; }
		public string dbcr { get; set; }
		public float am { get; set; }
		public float amlc1 { get; set; }
		public float amlc2 { get; set; }
		public bool posted { get; set; }
		public string period { get; set; }
		public string document { get; set; }
		public string setelled { get; set; }
		public string newset { get; set; }
		public int JobNo { get; set; }
		public int DepartmentId { get; set; }
		public int WorkingYear { get; set; }

	}
}
