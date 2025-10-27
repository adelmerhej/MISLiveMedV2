using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Accounting.Banks;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Accounting.Banks
{
    public class BankRepository
    {
	    public IList<BankModel> SelectBanks()
	    {
		    try
		    {
			    using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			    {
				    var p = new DynamicParameters();
				    p.Add("@CompanyId", CurrentUser.CompanyId);

				    var records =
					    connection.Query<BankModel>("SELECT * FROM Banks WHERE CompanyId = @CompanyId;", p);
				    return records.ToList();
			    }
		    }
		    catch (Exception e)
		    {
			    throw new Exception(e.Message);
		    }
	    }

	    public BankModel SelectBankById(int id)
	    {
		    try
		    {
			    using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			    {
				    var p = new DynamicParameters();
				    p.Add("@Id", id);
				    p.Add("@CompanyId", CurrentUser.CompanyId);

				    var record =
					    connection.QueryFirstOrDefault<BankModel>("SELECT * FROM Banks WHERE Id = @Id AND CompanyId = @CompanyId;", p);
				    return record;
			    }
		    }
		    catch (Exception e)
		    {
			    throw new Exception(e.Message);
		    }
	    }
		public int AddNewBank(BankModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@Code", dataModel.Code);
					p.Add("@Name", dataModel.Name);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);

					dataModel.Id = connection.ExecuteScalar<int>(
						"INSERT INTO Banks (Code, Name, Notes, CompanyId, BranchId, CreatedBy, IsProtected) " +
							"OUTPUT Inserted.Id " +
							"VALUES(@Code, @Name, @AccountName, @Name, @Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected)", p);

					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool UpdateBank(BankModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@Code", dataModel.Code);
					p.Add("@Name", dataModel.Name);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@Active", dataModel.Active);

					_ = connection.ExecuteScalar<int>("UPDATE Banks SET " +
											"Code = @Code, Name = @Name, Notes = @Notes, LastModifiedBy = @LastModifiedBy, " +
					                        "LastModifiedDate= GETDATE(), IsProtected = @IsProtected, Active = @Active WHERE Id = @Id", p);
				}
				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool DeleteBank(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM Banks WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
	}
}
