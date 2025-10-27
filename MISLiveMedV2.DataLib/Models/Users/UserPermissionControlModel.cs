using System;

namespace MISLiveMed.Models.Models.Users
{
	public class UserPermissionControlModel : EntityObject, ICloneable
	{
		public string ControlName { get; set; }

		#region Implementation of ICloneable

		public virtual object Clone()
		{
			var newModel = (UserPermissionControlModel)MemberwiseClone();
			return newModel;
		}

		#endregion
	}
}
