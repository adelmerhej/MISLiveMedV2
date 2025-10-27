using System;

namespace MISLiveMed.Models.Models.Common.Forms
{
	public class FormModel : EntityObject, ICloneable
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Menu { get; set; }


		#region Implementation of ICloneable

		/// <summary>Creates a new object that is a copy of the current instance.</summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone()
		{
			var continentModel = (FormModel)MemberwiseClone();
			return continentModel;
		}

		#endregion
	}
}
