using System;

namespace MISLiveMed.Models.Models.JobModels
{
	public class RequiredDocumentModel : EntityObject, ICloneable
	{
		public int SortingLineNo { get; set; }
		public string ReferenceNo { get; set; }
		public int JobNo { get; set; }
		public int DepartmentId { get; set; }
		public int ConditionId { get; set; }
		public int ConditionDetailId { get; set; }
		public bool IsRequired { get; set; }
		public bool IsFulFilled { get; set; }

		#region Implementation of ICloneable

		/// <summary>Creates a new object that is a copy of the current instance.</summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone()
		{
			var recordModel = (RequiredDocumentModel)MemberwiseClone();
			return recordModel;
		}

		#endregion
	}
}
