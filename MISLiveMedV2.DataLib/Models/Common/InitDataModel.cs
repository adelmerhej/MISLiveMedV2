using System.Collections.Generic;

namespace MISLiveMed.Models.Models.Common
{
    public class InitDataModel
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class InitCheckModel
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class InitDataModelExtended
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public IList<InitCheckModel> ValuesList { get; set; } = new List<InitCheckModel>();
    }

    public class InitSummaryModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
    }

    public class TypeDataModel
    {
	    public int Id { get; set; }
	    public string Type { get; set; }
    }
}
