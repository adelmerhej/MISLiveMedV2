using System;

namespace MISLiveMed.Models.Models.Users
{
	public class SuperAdminUserModel : ICloneable
	{
		public string Id { get; set; }

		public string CompanyId { get; set; }

		public string Notes { get; set; }

		public string CreatedBy { get; set; }

		public DateTime? CreatedDate { get; set; }

		public string LastModifiedBy { get; set; }

		public DateTime? LastModifiedDate { get; set; }

		public bool IsDefault { get; set; }

		public bool Active { get; set; }

		public bool Deleted { get; set; }
		public bool IsProtected { get; set; }

		public string UserName { get; set; }

		public string PasswordHash { get; set; }

		public string SecurityStamp { get; set; }

		public string Email { get; set; }

		public bool EmailConfirmed { get; set; }

		public string MobileNumber { get; set; }

		public bool MobileNumberConfirmed { get; set; }

		public bool TwoFactorEnabled { get; set; }

		public DateTime? LockoutEndDate { get; set; }

		public bool LockoutEnabled { get; set; }

		public int AccessFailedCount { get; set; }

		public bool ChangePasswordNextLogon { get; set; }

		public int SecurityLevel { get; set; }


		#region Implementation of ICloneable

		public virtual object Clone()
		{
			var newModel = (UserModel)MemberwiseClone();
			return newModel;
		}

		#endregion
	}
}
