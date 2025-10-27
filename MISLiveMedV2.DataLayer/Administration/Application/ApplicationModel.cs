using System;
using MISLiveMed.Models.Models;

namespace MISLiveMed.DataLayers.Administration.Application
{
	public class ApplicationModel : EntityObject, ICloneable
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int FormCategoryId { get; set; }

		#region Implementation of ICloneable

		public virtual object Clone()
		{
			var newModel = (ApplicationModel)MemberwiseClone();
			return newModel;
		}

		#endregion
	}
}
