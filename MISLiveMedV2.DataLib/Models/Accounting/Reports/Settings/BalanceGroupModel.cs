using System;

namespace MISLiveMed.Models.Models.Accounting.Reports.Settings
{
	public class BalanceGroupModel : EntityObject, ICloneable
	{
		public string Description { get; set; }

		#region Implementation of ICloneable

		/// <summary>Creates a new object that is a copy of the current instance.</summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone()
		{
			var companyModel = (BalanceGroupModel)MemberwiseClone();
			return companyModel;
		}

		#endregion
	}
}
