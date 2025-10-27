using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Members.Categories;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.CRM.Customers
{
    public class MemberCategoryRepository : IDisposable
    {
        public IEnumerable<MemberCategoryModel> SelectMembersCategory()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {

                    var membersCategoryRecord =
                        connection.Query<MemberCategoryModel>("SELECT * FROM MemberCategory WHERE Active = 1;");
                    return membersCategoryRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public MemberCategoryModel SelectMemberCategoryById(int memberCategoryId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", memberCategoryId);

                    var memberCategoryRecord =
                        connection.QuerySingleOrDefault<MemberCategoryModel>("SELECT * FROM MemberCategory WHERE Id = @Id;", p);
                    return memberCategoryRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewMemberCategory(MemberCategoryModel memberCategoryModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@Description", memberCategoryModel.Description);
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@Notes", memberCategoryModel.Notes);
                    p.Add("@CreatedBy", CurrentUser.UserId);

                    memberCategoryModel.Id = connection.ExecuteScalar<int>(
                        "dbo.job_InsertMemberCategory @Description, @CompanyId, @Notes, @CreatedBy", p);

                    return memberCategoryModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateMemberCategory(MemberCategoryModel memberCategoryModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", memberCategoryModel.Id);
                    p.Add("@Description", memberCategoryModel.Description);
                    p.Add("@Notes", memberCategoryModel.Notes);
                    p.Add("@LastModifiedBy", memberCategoryModel.LastModifiedBy);
                    p.Add("@LastModifiedDate", memberCategoryModel.LastModifiedDate);
                    p.Add("@Active", memberCategoryModel.Active);

                    _ = connection.ExecuteScalar<int>(
                        "dbo.job_UpdateMemberCategory @Id, @Description, @Notes, @LastModifiedBy, @LastModifiedDate, @Active",
                        p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteMemberCategory(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM MemberCategory WHERE Id = @Id", p);
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void Dispose()
        {

        }
    }
}
