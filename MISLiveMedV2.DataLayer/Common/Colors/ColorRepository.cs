using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Colors;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.Colors
{
    public class ColorRepository : IDisposable
    {
        public IList<ColorModel> SelectColors()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var records =
                        connection.Query<ColorModel>("SELECT * FROM Colors WHERE CompanyId = @CompanyId;", p);
                    return records.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ColorModel SelectColorById(int colorId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", colorId);

                    var record =
                        connection.QuerySingleOrDefault<ColorModel>("SELECT * FROM Colors WHERE Id = @Id;", p);
                    return record;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ColorModel SelectColorByName(string colorName)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Name", colorName);

                    var record =
                        connection.QuerySingleOrDefault<ColorModel>("SELECT * FROM Colors WHERE Name = @Name;", p);
                    return record;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewColor(ColorModel colorModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@Name", colorModel.Name);

                    p.Add("@Notes", colorModel.Notes);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@CreatedBy", CurrentUser.UserId);
                    p.Add("@IsDefault", colorModel.IsDefault);

                    colorModel.Id = connection.ExecuteScalar<int>(
                        "INSERT INTO Colors (Name, CompanyId, Notes, CreatedBy, IsDefault)" +
                        "VALUES (@Name, @CompanyId, @Notes, @CreatedBy, @IsDefault);", p);

                    return colorModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateColor(ColorModel colorModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", colorModel.Id);
                    p.Add("@Name", colorModel.Name);

                    p.Add("@Notes", colorModel.Notes);
                    p.Add("@LastModifiedBy", CurrentUser.UserId);
                    p.Add("@Active", colorModel.Active);
                    p.Add("@IsDefault", colorModel.IsDefault);

                    _ = connection.ExecuteScalar<int>(
                        "UPDATE Colors SET name = @Name, Notes = @Notes, LastModifiedBy = @LastModifiedBy, " +
                        "LastModifiedDate = getdate(), Active = @Active, IsdDefault = @IsDefault WHERE Id = @Id;", p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteColor(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM Colors WHERE Id = @Id", p);
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
