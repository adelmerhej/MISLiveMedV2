using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Members.Agents.Shippers;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.CRM.Agents.Shippers
{
    public class ShipperRepository : IDisposable
    {
        public IList<ShipperModel> SelectShippers()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var continentsRecords =
                        connection.Query<ShipperModel>("SELECT * FROM Shippers WHERE CompanyId = @CompanyId;", p);
                    return continentsRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<ShipperModel> SelectShippersByCustomerId(int customerId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@CustomerId", customerId);

                    var continentsRecords =
                        connection.Query<ShipperModel>("SELECT * FROM Shippers " +
                                                       "WHERE CompanyId = @CompanyId AND CustomerId = @CustomerId AND IsProtected = 0;", p);
                    return continentsRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ShipperModel SelectShipperById(int cityId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", cityId);

                    var record =
                        connection.QuerySingleOrDefault<ShipperModel>("SELECT * FROM Shippers WHERE Id = @Id;", p);
                    return record;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewShipper(ShipperModel model)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@Name", model.Name);
                    p.Add("@CustomerId", model.CustomerId);
                    p.Add("@CountryId", model.CountryId);
                    p.Add("@CityId", model.CityId);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Notes", model.Notes);
                    p.Add("@CreatedBy", CurrentUser.UserId);
                    p.Add("@IsProtected", model.IsProtected);

                    model.Id = connection.ExecuteScalar<int>(
                        "INSERT INTO Shippers (Name, CustomerId, CountryId, CityId, CompanyId, Notes, CreatedBy, IsProtected) " +
                        "VALUES (@Name, @CustomerId, @CountryId, @CityId, @CompanyId, @Notes, @CreatedBy, @IsProtected) ", p);

                    return model.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateShipper(ShipperModel model)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", model.Id);
                    p.Add("@Name", model.Name);
                    p.Add("@CustomerId", model.CustomerId);
                    p.Add("@CountryId", model.CountryId);
                    p.Add("@CityId", model.CityId); p.Add("@Notes", model.Notes);
                    p.Add("@LastModifiedBy", model.LastModifiedBy);
                    p.Add("@LastModifiedDate", model.LastModifiedDate);
                    p.Add("@Active", model.Active);
                    p.Add("@IsProtected", model.IsProtected);

                    _ = connection.ExecuteScalar<int>(
                        "UPDATE Shippers SET Name = @Name, CustomerId = @CustomerId, CountryId = @CountryId, CityId = @CityId, " +
                        "Notes = @Notes, LastModifiedBy = @LastModifiedBy, LastModifiedDate = GETDATE(), " +
                        "Active = @Active, IsProtected = @IsProtected WHERE Id = @Id;",
                        p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteShipper(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM Shippers WHERE Id = @Id", p);
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
