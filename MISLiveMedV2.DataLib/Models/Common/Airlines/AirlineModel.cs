using System;

namespace MISLiveMed.Models.Models.Common.Airlines
{
    public class AirlineModel : EntityObject, ICloneable
    {
	    public string AirlineName { get; set; }
	    public string IntegerCode { get; set; }
	    public string AbbreviationCode { get; set; }
	    public string FlightCode { get; set; }
	    public string AirlineNameAWB { get; set; }
	    public int Nationality { get; set; }
	    public string GSAAgent { get; set; }
	    public string GSAAgentId { get; set; }
	    public string ReportId { get; set; }
	    public DateTime? AirlineDate { get; set; }
	    public DateTime? ActivationDate { get; set; }
	    public string IataCode { get; set; }
	    public string AwbPrefix { get; set; }


		#region Implementation of ICloneable

		/// <summary>Creates a new object that is a copy of the current instance.</summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone()
        {
            var airlineModel = (AirlineModel)MemberwiseClone();
            return airlineModel;
        }

        #endregion
    }
}
