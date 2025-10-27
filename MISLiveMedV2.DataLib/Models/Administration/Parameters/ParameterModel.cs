namespace MISLiveMed.Models.Models.Administration.Parameters
{
    public class ParameterModel : EntityObject
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }
        public string TextValue { get; set; }
    }
}
