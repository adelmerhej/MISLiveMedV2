using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Carriers;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.Carriers
{
	public class VesselRepository : IDisposable
	{
		public IList<VesselModel> SeaVessels(bool showOnlyActive = false, bool showProtected = false)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@ShowOnlyActive", showOnlyActive);
					p.Add("@ShowProtected", showProtected);

					var seaCarriersRecords =
						connection.Query<VesselModel>("SELECT * FROM Vessels " +
													  "WHERE (@ShowOnlyActive = 0 OR Active = 1) AND (@ShowProtected = 1 OR IsProtected = 0) " +
													  "AND CompanyId = @CompanyId;", p);
					return seaCarriersRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<VesselModel> SeaVesselByCategoryId(bool isFeederVessel, bool showProtected = false)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@ShowProtected", showProtected);
					p.Add("@IsFeederVessel", isFeederVessel);

					var seaCarrierRecord =
						connection.Query<VesselModel>("SELECT * FROM Vessels " +
													  "WHERE (@ShowProtected = 1 OR IsProtected = 0) AND FeederVessel = @IsFeederVessel;", p);
					return seaCarrierRecord.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<VesselModel> SeaVesselById(int vesselId, bool showProtected = false)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@ShowProtected", showProtected);
					p.Add("@VesselId", vesselId);

					var seaCarrierRecord =
						connection.Query<VesselModel>("SELECT * FROM Vessels " +
													  "WHERE (@ShowProtected = 1 OR IsProtected = 0) AND Id = @VesselId;", p);
					return seaCarrierRecord.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewVessel(VesselModel seaCarrierModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@Name", seaCarrierModel.Name);
					p.Add("@ArabicName", seaCarrierModel.ArabicName);
					p.Add("@CaptainName", seaCarrierModel.CaptainName);
					p.Add("@Flag", seaCarrierModel.Flag);
					p.Add("@ShipLineAgentId", seaCarrierModel.ShipLineAgentId);
					p.Add("@NationalityId", seaCarrierModel.NationalityId);
					p.Add("@IMONumber", seaCarrierModel.IMONumber);
					p.Add("@FeederVessel", seaCarrierModel.FeederVessel);
					p.Add("@Notes", seaCarrierModel.Notes);
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@CreatedBy", CurrentUser.UserId);
					p.Add("@IsProtected", seaCarrierModel.IsProtected);
					p.Add("@IsDefault", seaCarrierModel.IsDefault);

					seaCarrierModel.Id = connection.ExecuteScalar<int>(
									"dbo.job_AddNewVessel @Name, @ArabicName, @CaptainName, @Flag, @ShipLineAgentId, @NationalityId,  " +
										"@IMONumber, @FeederVessel, @Notes, @CompanyId, @CreatedBy, @IsProtected, @IsDefault;", p);

					return seaCarrierModel.Id;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public void UpdateVessel(VesselModel seaCarrierModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", seaCarrierModel.Id);
					p.Add("@Name", seaCarrierModel.Name);
					p.Add("@ArabicName", seaCarrierModel.ArabicName);
					p.Add("@CaptainName", seaCarrierModel.CaptainName);
					p.Add("@Flag", seaCarrierModel.Flag);
					p.Add("@ShipLineAgentId", seaCarrierModel.ShipLineAgentId);
					p.Add("@NationalityId", seaCarrierModel.NationalityId);
					p.Add("@IMONumber", seaCarrierModel.IMONumber);
					p.Add("@FeederVessel", seaCarrierModel.FeederVessel);
					p.Add("@Notes", seaCarrierModel.Notes);
					p.Add("@LastModifiedBy", seaCarrierModel.LastModifiedBy);
					p.Add("@Active", seaCarrierModel.Active);
					p.Add("@IsProtected", seaCarrierModel.IsProtected);
					p.Add("@IsDefault", seaCarrierModel.IsDefault);

					_ = connection.ExecuteScalar<int>(
									"dbo.job_UpdateVessel @Id, @Name, @ArabicName, @CaptainName, @Flag, @ShipLineAgentId, @NationalityId,  " +
										"@IMONumber, @FeederVessel, @Notes, @LastModifiedBy, @Active, @IsProtected, @IsDefault;", p);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public bool DeleteVessel(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM Vessels WHERE Id = @Id", p);
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
