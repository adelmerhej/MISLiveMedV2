using System;

namespace MISLiveMed.Models.Models.Accounting.Banks
{
    public class BankModel: EntityObject, ICloneable
	{
		public string Code { get; set; }
		public string Name { get; set; }

		#region Implementation of ICloneable

		/// <summary>Creates a new object that is a copy of the current instance.</summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone()
		{
			var newModel = (BankModel)MemberwiseClone();
			return newModel;
		}

		#endregion
	}
}
