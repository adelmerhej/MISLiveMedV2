using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.JobModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MISLiveMed.DataLayers.JobData.Common
{
	public class RequiredDocumentRepository : IDisposable
	{
		public IList<RequiredDocumentModel> JobRequiredDocumentsList(int conditionId, int companyId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@ConditionId", companyId);
					p.Add("@CompanyId", conditionId);

					var requiredDocumentsRecords =
						connection.Query<RequiredDocumentModel>(
							"SELECT rd.Id, SortingLineNo, ReferenceNo, JobNo, DepartmemtId, rd.ConditionId, ConditionDetailId, cd.Description, " +
							"rd.IsRequired, IsFulFilled, rd.Notes, rd.CompanyId, " +
							"rd.BranchId, rd.CreatedBy, rd.CreatedDate, rd.LastModifiedBy, rd.LastModifiedDate, rd.WorkingYear, " +
							"rd.IsProtected, rd.IsDefault, rd.Active, rd.Locked " +
							"FROM RequiredDocuments rd " +
							"INNER JOIN ConditionDetails cd on cd.Id = rd.ConditionDetailId " +
							" WHERE rd.ConditionId = @ConditionId AND rd.CompanyId = @CompanyId;", p);
					return requiredDocumentsRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<RequiredDocumentModel> JobRequiredDocumentsList(int jobNo, int departmentId, int conditionId, int companyId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@JobNo", jobNo);
					p.Add("@DepartmentId", departmentId);
					p.Add("@ConditionId", conditionId);
					p.Add("@CompanyId", companyId);

					var requiredDocumentsRecords =
						connection.Query<RequiredDocumentModel>(
							"SELECT rd.Id, SortingLineNo, ReferenceNo, JobNo, rd.DepartmentId, rd.ConditionId, ConditionDetailId, cd.Description, " +
							"rd.IsRequired, IsFulFilled, rd.Notes, rd.CompanyId, " +
							"rd.BranchId, rd.CreatedBy, rd.CreatedDate, rd.LastModifiedBy, rd.LastModifiedDate, rd.WorkingYear, " +
							"rd.IsProtected, rd.IsDefault, rd.Active, rd.Locked " +
							"FROM RequiredDocuments rd " +
							"INNER JOIN ConditionDetails cd on cd.Id = rd.ConditionDetailId " +
							" WHERE rd.JobNo = @jobNo AND rd.DepartmentId = @DepartmentId AND rd.ConditionId = @ConditionId AND rd.CompanyId = @CompanyId;", p);
					return requiredDocumentsRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<RequiredDocumentModel> JobRequiredDocumentsList(int referenceNo, int jobNo, int departmentId,
			int conditionId, int companyId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@ReferenceNo", referenceNo);
					p.Add("@JobNo", jobNo);
					p.Add("@DepartmentId", departmentId);
					p.Add("@ConditionId", companyId);
					p.Add("@CompanyId", conditionId);

					var requiredDocumentsRecords =
						connection.Query<RequiredDocumentModel>(
							"SELECT rd.Id, SortingLineNo, ReferenceNo, JobNo, DepartmemtId, rd.ConditionId, ConditionDetailId, cd.Description, " +
							"rd.IsRequired, IsFulFilled, rd.Notes, rd.CompanyId, " +
							"rd.BranchId, rd.CreatedBy, rd.CreatedDate, rd.LastModifiedBy, rd.LastModifiedDate, rd.WorkingYear, " +
							"rd.IsProtected, rd.IsDefault, rd.Active, rd.Locked " +
							"FROM RequiredDocuments rd " +
							"INNER JOIN ConditionDetails cd on cd.Id = rd.ConditionDetailId " +
							" WHERE ReferenceNo = @ReferenceNo AND rd.JobNo = @jobNo AND rd.DepartmentId = @DepartmentId AND rd.ConditionId = @ConditionId AND rd.CompanyId = @CompanyId;", p);
					return requiredDocumentsRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public RequiredDocumentModel JobRequiredDocumentById(int conditionId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", conditionId);

					var requiredDocumentRecord =
						connection.QuerySingleOrDefault<RequiredDocumentModel>("SELECT * FROM RequiredDocuments WHERE Id = @Id;", p);
					return requiredDocumentRecord;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewRequiredDocument(RequiredDocumentModel requiredDocumentRecord)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@SortingLineNo", requiredDocumentRecord.SortingLineNo);
					p.Add("@ReferenceNo", requiredDocumentRecord.ReferenceNo);
					p.Add("@JobNo", requiredDocumentRecord.JobNo);

					p.Add("@DepartmentId", requiredDocumentRecord.DepartmentId);
					p.Add("@ConditionId", requiredDocumentRecord.ConditionId);
					p.Add("@ConditionDetailId", requiredDocumentRecord.ConditionDetailId);
					p.Add("@IsRequired", requiredDocumentRecord.IsRequired);
					p.Add("@IsFulFilled", requiredDocumentRecord.IsFulFilled);

					// Preserved from EntityObject
					p.Add("@Notes", requiredDocumentRecord.Notes);
					p.Add("@CompanyId", requiredDocumentRecord.CompanyId);
					p.Add("@BranchId", requiredDocumentRecord.BranchId);
					p.Add("@CreatedBy", requiredDocumentRecord.CreatedBy);
					p.Add("@IsProtected", requiredDocumentRecord.IsProtected);
					p.Add("@Locked", requiredDocumentRecord.Locked);

					requiredDocumentRecord.Id = connection.ExecuteScalar<int>(
						"_operation.sp_AddNewRequiredDocument @SortingLineNo, @ReferenceNo, @JobNo, @DepartmentId, " +
						"@ConditionId, @ConditionDetailId, @IsRequired, @IsFulFilled, " +
						"@Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected, @Locked ", p);

					return requiredDocumentRecord.Id;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public void UpdateRequiredDocument(RequiredDocumentModel requiredDocumentRecord)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", requiredDocumentRecord.Id);
					p.Add("@SortingLineNo", requiredDocumentRecord.SortingLineNo);
					p.Add("@ReferenceNo", requiredDocumentRecord.ReferenceNo);
					p.Add("@JobNo", requiredDocumentRecord.JobNo);
					p.Add("@DepartmentId", requiredDocumentRecord.DepartmentId);
					p.Add("@ConditionId", requiredDocumentRecord.ConditionId);
					p.Add("@ConditionDetailId", requiredDocumentRecord.ConditionDetailId);
					p.Add("@IsRequired", requiredDocumentRecord.IsRequired);
					p.Add("@IsFulFilled", requiredDocumentRecord.IsFulFilled);

					// Preserved from EntityObject
					p.Add("@Notes", requiredDocumentRecord.Notes);
					p.Add("@LastModifiedBy", requiredDocumentRecord.LastModifiedBy);
					p.Add("@Active", requiredDocumentRecord.Active);
					p.Add("@IsProtected", requiredDocumentRecord.IsProtected);
					p.Add("@Locked", requiredDocumentRecord.Locked);

					_ = connection.ExecuteScalar<int>(
						"_operation.sp_UpdateRequiredDocument @Id, @SortingLineNo, @ReferenceNo, @JobNo, @DepartmentId, " +
						"@ConditionId, @ConditionDetailId, @IsRequired, @IsFulFilled, " +
						"@Notes, @LastModifiedBy,@Active, @IsProtected, @Locked ",
						p);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public bool DeleteRequiredDocument(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM RequiredDocuments WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		#region Implementation of IDisposable

		/// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
		public void Dispose()
		{

		}

		#endregion
	}
}
