using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Trucks;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.Trucks
{
	public class TruckRepository : IDisposable
	{
		public IList<TruckModel> SelectTrucks()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<TruckModel>("SELECT * FROM Trucks WHERE CompanyId = @CompanyId;", parameters);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public static TruckModel GetTruckById(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					var truckRecord =
						connection.QuerySingleOrDefault<TruckModel>("SELECT * FROM Trucks WHERE Id = @Id;", p);

					return truckRecord;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw new Exception(e.Message);
			}
		}

		public int AddNewTruck(TruckModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					parameters.Add("@Plate1", dataModel.Plate1);
					parameters.Add("@Plate2", dataModel.Plate2);
					parameters.Add("@RegistrationCountryId", dataModel.RegistrationCountryId);
					parameters.Add("@DriverName", dataModel.DriverName);
					parameters.Add("@DriverNationalityId", dataModel.DriverNationalityId);
					parameters.Add("@IsMultiTruck", dataModel.IsMultiTruck);
					parameters.Add("@DriverId", dataModel.DriverId);
					parameters.Add("@TruckRemarks", dataModel.TruckRemarks);
					parameters.Add("@Remarks", dataModel.Remarks);
					parameters.Add("@Tir", dataModel.Tir);
					parameters.Add("@TruckDate", dataModel.TruckDate);

					parameters.Add("@Notes", dataModel.Notes);
					parameters.Add("@CompanyId", dataModel.CompanyId);
					parameters.Add("@BranchId", dataModel.BranchId);
					parameters.Add("@CreatedBy", dataModel.CreatedBy);
					parameters.Add("@WorkingYear", dataModel.WorkingYear);
					parameters.Add("@IsProtected", dataModel.IsProtected);
					parameters.Add("@IsDefault", dataModel.IsDefault);
					parameters.Add("@Locked", dataModel.Locked);

					dataModel.Id = connection.ExecuteScalar<int>(
						"INSERT INTO Trucks (Name, Plate1, Plate2, RegistrationCountryId, DriverName, DriverNationalityId, " +
						"IsMultiTruck, DriverId, TruckRemarks, Remarks, Tir, TruckDate, " +
						"Notes, CompanyId, BranchId, CreatedBy, WorkingYear, IsProtected, IsDefault, Locked) " +
						"OUTPUT Inserted.Id " +
						"VALUES (@Plate1, @Plate2, @RegistrationCountryId, @DriverName, @DriverNationalityId, " +
						"@IsMultiTruck, @DriverId, @TruckRemarks, @Remarks, @Tir, @TruckDate, " +
						"@Notes, @CompanyId, @BranchId, @CreatedBy, @WorkingYear, @IsProtected, @IsDefault, @Locked)",
						parameters);
						;
					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateTruck(TruckModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", dataModel.Id);
					parameters.Add("@Plate1", dataModel.Plate1);
					parameters.Add("@Plate2", dataModel.Plate2);
					parameters.Add("@RegistrationCountryId", dataModel.RegistrationCountryId);
					parameters.Add("@DriverName", dataModel.DriverName);
					parameters.Add("@DriverNationalityId", dataModel.DriverNationalityId);
					parameters.Add("@IsMultiTruck", dataModel.IsMultiTruck);
					parameters.Add("@DriverId", dataModel.DriverId);
					parameters.Add("@TruckRemarks", dataModel.TruckRemarks);
					parameters.Add("@Remarks", dataModel.Remarks);
					parameters.Add("@Tir", dataModel.Tir);
					parameters.Add("@TruckDate", dataModel.TruckDate);

					parameters.Add("@Notes", dataModel.Notes);
					parameters.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					parameters.Add("@WorkingYear", dataModel.WorkingYear);
					parameters.Add("@IsProtected", dataModel.IsProtected);
					parameters.Add("@IsDefault", dataModel.IsDefault);
					parameters.Add("@Active", dataModel.Active);
					parameters.Add("@Locked", dataModel.Locked);

					_ = connection.ExecuteScalar<int>("UPDATE Trucks SET " +
									"Plate1 = @Plate1, Plate2 = @Plate2, RegistrationCountryId = @RegistrationCountryId, DriverName = @DriverName, " +
									"DriverNationalityId = @DriverNationalityId, IsMultiTruck = @IsMultiTruck, DriverId = @DriverId, " +
									"TruckRemarks = @TruckRemarks, Remarks = @Remarks, Tir = @Tir, TruckDate = @TruckDate, " +
									"Notes = @Notes, LastModifiedBy = @LastModifiedBy, LastModifiedDate= GETDATE(), " +
									"WorkingYear = @WorkingYear, IsProtected = @IsProtected, IsDefault = @IsDefault, " +
									"Active = @Active, Locked = @Locked WHERE Id = @Id", parameters);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool DeleteTruck(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var parameters = new DynamicParameters();
					parameters.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM Trucks WHERE Id = @Id", parameters);
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
