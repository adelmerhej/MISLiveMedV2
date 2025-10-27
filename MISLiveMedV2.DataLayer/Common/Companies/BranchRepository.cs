using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Companies;

namespace MISLiveMed.DataLayers.Common.Companies
{
	public class BranchRepository : IDisposable
	{
		public IList<BranchModel> SelectBranches()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var records =
						connection.Query<BranchModel>("Select * from Branches WHERE Active = 1;");
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public BranchModel SelectBranchByCompanyId(int companyId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", companyId);

					var record =
						connection.QuerySingleOrDefault<BranchModel>("SELECT * FROM Branches WHERE CompanyId = @CompanyId;", p);
					return record;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public BranchModel SelectBranchById(int companyId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", companyId);

					var record =
						connection.QuerySingleOrDefault<BranchModel>("SELECT * FROM Branches WHERE Id = @Id;", p);
					return record;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewBranch(BranchModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@Name", dataModel.Name);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);
					p.Add("@IsProtected", dataModel.IsProtected);

					dataModel.Id = connection.ExecuteScalar<int>(
						"INSERT INTO Branches (Name, Notes, CompanyId, BranchId, CreatedBy, IsProtected)" +
						"VALUES (@Name, @Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected)", p);

					_ = connection.ExecuteScalar<int>(
						$"UPDATE Branches BranchId = {dataModel.Id} WHERE Id = {dataModel.Id}");

					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public bool UpdateBranch(BranchModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@Name", dataModel.Name);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.Id);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@Active", dataModel.Active);
					p.Add("@IsProtected", dataModel.IsProtected);

					_ = connection.ExecuteScalar<int>(
						"UPDATE Branches SET Name = @Name, CompanyId = @CompanyId, BranchId = @BranchId, " +
						"Notes = @Notes, LastModifiedBy = @LastModifiedBy, " +
						"Active = @Active, IsProtected = @IsProtected " +
						"WHERE Id = @Id", p);

					return true;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public bool DeleteBranch(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM Branches WHERE Id = @Id", p);
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

		public void Dispose()
		{

		}

		#endregion
	}
}
