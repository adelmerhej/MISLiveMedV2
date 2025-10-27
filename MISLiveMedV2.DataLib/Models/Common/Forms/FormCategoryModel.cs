using System;

namespace MISLiveMed.Models.Models.Common.Forms
{
	public class FormCategoryModel : EntityObject, ICloneable
	{
		public string Name { get; set; }

		#region Implementation of ICloneable

		/// <summary>Creates a new object that is a copy of the current instance.</summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone()
		{
			var newModel = (FormCategoryModel)MemberwiseClone();
			return newModel;
		}

		#endregion
	}
}
