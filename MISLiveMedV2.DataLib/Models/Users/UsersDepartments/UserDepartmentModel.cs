using System;

namespace MISLiveMed.Models.Models.Users.UsersDepartments
{
	public class UserDepartmentModel : EntityObject, ICloneable
	{
		public string Name { get; set; }
		
		#region Implementation of ICloneable

		/// <summary>Creates a new object that is a copy of the current instance.</summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone()
		{
			var recordModel = (UserDepartmentModel)MemberwiseClone();
			return recordModel;
		}

		#endregion
	}
}
