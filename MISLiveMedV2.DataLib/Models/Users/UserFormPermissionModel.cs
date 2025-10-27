using System;

namespace MISLiveMed.Models.Models.Users
{
	public class UserFormPermissionModel : EntityObject, ICloneable
	{
		public int FormId { get; set; }
		public int UserId { get; set; }


		#region Implementation of ICloneable

		public virtual object Clone()
		{
			var newModel = (UserFormPermissionModel)MemberwiseClone();
			return newModel;
		}

		#endregion
	}
}
