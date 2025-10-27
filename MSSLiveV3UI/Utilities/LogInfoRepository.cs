using MISLiveMed.Models.Models;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.UI.Utilities
{
	internal class LogInfoRepository
	{
		#region Update user activity log
		public void CreateLogInfo<T>(T obj) where T : EntityObject
		{
			obj.CreatedBy = CurrentUser.UserId;
			obj.CompanyId = CurrentUser.CompanyId;
			if (CurrentUser.BranchId != null) obj.BranchId = (int)CurrentUser.BranchId;
		}

		public void UpdateLogInfo<T>(T obj) where T : EntityObject
		{
			obj.LastModifiedBy = CurrentUser.UserId;
			obj.CompanyId = CurrentUser.CompanyId;
			if (CurrentUser.BranchId != null) obj.BranchId = (int)CurrentUser.BranchId;
		}

		#endregion
	}
}
