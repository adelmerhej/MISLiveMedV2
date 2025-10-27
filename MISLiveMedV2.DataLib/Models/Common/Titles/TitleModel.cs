using System;

namespace MISLiveMed.Models.Models.Common.Titles
{
	public class TitleModel : EntityObject, ICloneable
	{
		public string Prefix { get; set; }
		public string ImageId { get; set; }

		#region Implementation of ICloneable

		/// <summary>Creates a new object that is a copy of the current instance.</summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone()
		{
			var newModel = (TitleModel)MemberwiseClone();
			return newModel;
		}

		#endregion
	}
}
