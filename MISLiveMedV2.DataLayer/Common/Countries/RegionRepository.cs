using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Countries;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.Countries
{
	public class RegionRepository : IDisposable
	{
		public IList<RegionModel> SelectRegions()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@CompanyId", CurrentUser.CompanyId);

					var regionsRecords =
						connection.Query<RegionModel>("SELECT * FROM Regions WHERE CompanyId = @CompanyId;", parameters);
					return regionsRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<RegionModel> SelectRegionsByCompanyId(int companyId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@CompanyId", companyId);

					var regionsRecords =
						connection.Query<RegionModel>("SELECT * FROM Regions WHERE CompanyId = @CompanyId;", parameters);
					return regionsRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<RegionModel> SelectRegionsByContinentId(int continentId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@ContinentId", continentId);

					var regionsRecords =
						connection.Query<RegionModel>("SELECT * FROM Regions WHERE ContinentId = @ContinentId;", parameters);
					return regionsRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public RegionModel SelectRegionById(int regionId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", regionId);

					var regionRecord =
						connection.QuerySingleOrDefault<RegionModel>("SELECT * FROM Regions WHERE Id = @Id;", parameters);
					return regionRecord;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewRegion(RegionModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					parameters.Add("@Name", dataModel.Name);
					parameters.Add("@ContinentId", dataModel.ContinentId);

					parameters.Add("@Notes", dataModel.Notes);
					parameters.Add("@CompanyId", dataModel.CompanyId);
					parameters.Add("@BranchId", dataModel.BranchId);
					parameters.Add("@CreatedBy", dataModel.CreatedBy);
					parameters.Add("@WorkingYear", dataModel.WorkingYear);
					parameters.Add("@IsProtected", dataModel.IsProtected);
					parameters.Add("@IsDefault", dataModel.IsDefault);
					parameters.Add("@Locked", dataModel.Locked);

					dataModel.Id = connection.ExecuteScalar<int>(
						"INSERT INTO Regions (Name, ContinentId, Notes, CompanyId, BranchId, CreatedBy, WorkingYear, IsProtected, IsDefault, Locked) " +
							"OUTPUT Inserted.Id " +
							"VALUES (@Name, @ContinentId, @Notes, @CompanyId, @BranchId, @CreatedBy, @WorkingYear, @IsProtected, @IsDefault, @Locked)", parameters)
						;
					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateRegion(RegionModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", dataModel.Id);
					parameters.Add("@Name", dataModel.Name);
					parameters.Add("@ContinentId", dataModel.ContinentId);

					parameters.Add("@Notes", dataModel.Notes);
					parameters.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					parameters.Add("@WorkingYear", dataModel.WorkingYear);
					parameters.Add("@IsProtected", dataModel.IsProtected);
					parameters.Add("@IsDefault", dataModel.IsDefault);
					parameters.Add("@Active", dataModel.Active);
					parameters.Add("@Locked", dataModel.Locked);

					_ = connection.ExecuteScalar<int>(
						"UPDATE Regions SET " +
								"Name = @Name, ContinentId= @ContinentId, " +
								"Notes = @Notes, LastModifiedBy = @LastModifiedBy, LastModifiedDate= GETDATE(), " +
								"WorkingYear = @WorkingYear, IsProtected = @IsProtected, IsDefault = @IsDefault, " +
								"Active = @Active, Locked = @Locked " +
								"WHERE Id = @Id", parameters);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool DeleteRegion(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM Regions WHERE Id = @Id", parameters);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public void Dispose()
		{

		}
	}
}
