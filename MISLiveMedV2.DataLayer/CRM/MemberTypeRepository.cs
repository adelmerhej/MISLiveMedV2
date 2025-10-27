using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Members;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.CRM
{
    public class MemberTypeRepository : IDisposable
    {
        public IList<MembersTypeModel> SelectMembersType()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var membersType =
                        connection.Query<MembersTypeModel>("SELECT * FROM MembersType WHERE Active = 1;");
                    return membersType.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public MembersTypeModel SelectMemberTypeById(int memberTypeId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", memberTypeId);

                    var memberTypeRecord =
                        connection.QuerySingleOrDefault<MembersTypeModel>("SELECT * FROM MembersType WHERE Id = @Id;", p);
                    return memberTypeRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewMemberType(MembersTypeModel memberTypeModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@Name", memberTypeModel.Name);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Notes", memberTypeModel.Notes);
                    p.Add("@CreatedBy", CurrentUser.UserId);

                    memberTypeModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_AddNewMemberType @Name, @CompanyId, @Notes, @CreatedBy", p);

                    return memberTypeModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int UpdateMemberType(MembersTypeModel memberTypeModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", memberTypeModel.Id);
                    p.Add("@Name", memberTypeModel.Name);
                    p.Add("@Notes", memberTypeModel.Notes);
                    p.Add("@LastModifiedBy", memberTypeModel.LastModifiedBy);
                    p.Add("@LastModifiedDate", memberTypeModel.LastModifiedDate);
                    p.Add("@Active", memberTypeModel.Active);

                    _ = connection.ExecuteScalar<int>(
                        "dbo.job_UpdateMemberType @Id, @Name, @Notes, @LastModifiedBy, @LastModifiedDate, @Active", p);

                    return memberTypeModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteMemberType(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM MembersType WHERE Id = @Id", p);
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
