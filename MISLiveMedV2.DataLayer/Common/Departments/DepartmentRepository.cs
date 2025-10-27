using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Departments;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.Departments
{
	public class DepartmentRepository : IDisposable
	{
		public IList<DepartmentModel> SelectDepartments(bool showProtected = false)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@IsAdmin", CurrentUser.UserName.ToLower() == "admin");
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@IsProtected", showProtected);

					var departmentsRecords =
						connection.Query<DepartmentModel>("SELECT * FROM Departments " +
						                                  "WHERE (@IsAdmin = 1 " +
						                                  "OR (@IsProtected = 1 OR IsProtected = @IsProtected) " +
						                                  "OR (CompanyId = @CompanyId));", p);

					return departmentsRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public DepartmentModel SelectDepartmentById(int continentId, bool showProtected = false)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", continentId);
					p.Add("@IsAdmin", CurrentUser.UserName.ToLower() == "admin");
					p.Add("@IsProtected", showProtected);

					var departmentRecord =
						connection.QuerySingleOrDefault<DepartmentModel>("SELECT * FROM Departments " +
																"WHERE Id = @Id " +
																"AND (@IsAdmin = 1 OR (@IsProtected = 1 OR IsProtected = @IsProtected));", p);
					return departmentRecord;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewDepartment(DepartmentModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@DepartmentName", dataModel.DepartmentName);
					p.Add("@ShortCode", dataModel.ShortCode);
					p.Add("@Prefix", dataModel.Prefix);
					p.Add("@StartingNo", dataModel.StartingNo);
					p.Add("@JobActive", dataModel.JobActive);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);
					p.Add("@IsProtected", dataModel.IsProtected);

					dataModel.Id = connection.ExecuteScalar<int>(
						"INSERT INTO Departments (DepartmentName, ShortCode, Prefix, StartingNo, JobActive, Notes, CompanyId, BranchId, CreatedBy, IsProtected) " +
							"OUTPUT Inserted.Id " +
							"VALUES (@DepartmentName, @ShortCode, @Prefix, @StartingNo, @JobActive, @Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected)", p);

					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateDepartment(DepartmentModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@DepartmentName", dataModel.DepartmentName);
					p.Add("@ShortCode", dataModel.ShortCode);
					p.Add("@Prefix", dataModel.Prefix);
					p.Add("@StartingNo", dataModel.StartingNo);
					p.Add("@JobActive", dataModel.JobActive);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@Active", dataModel.Active);

					_ = connection.ExecuteScalar<int>(
									"UPDATE Departments SET " +
											"DepartmentName = @DepartmentName, ShortCode = @ShortCode, Prefix = @Prefix, StartingNo = @StartingNo, " +
											"JobActive = @JobActive, Notes = @Notes, LastModifiedBy = @LastModifiedBy, " +
											"IsProtected = @IsProtected, Active = @Active " +
											"WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool DeleteDepartment(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM Departments WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
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
