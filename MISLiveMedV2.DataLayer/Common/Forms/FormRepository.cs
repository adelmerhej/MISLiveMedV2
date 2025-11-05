using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Forms;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.Forms
{
	public class FormRepository : IDisposable
	{
		private const string _schema = "_application";

		public IList<FormModel> SelectDefaultForms()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", 1);

					var formsModel =
						connection.Query<FormModel>($@"SELECT * FROM {_schema}.Forms WHERE CompanyId = @CompanyId;", p);
					return formsModel.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<FormModel> SelectForms()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var formsModel =
						connection.Query<FormModel>($@"SELECT * FROM {_schema}.Forms WHERE CompanyId = @CompanyId;", p);
					return formsModel.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public FormModel SelectFormById(int formId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", formId);

					var formModel =
						connection.QuerySingleOrDefault<FormModel>($@"SELECT * FROM {_schema}.Forms WHERE Id = @Id;", p);
					return formModel;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int SelectFormByName(string formName)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					int returnFormId = 0;

					var p = new DynamicParameters();
					p.Add("@FormName", formName);

					var formModel =
						connection.QuerySingleOrDefault<FormModel>($@"SELECT Id FROM {_schema}.Forms WHERE Name = @FormName;", p);

					returnFormId = formModel?.Id ?? 0;
					return returnFormId;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int SelectFormByName(string formName, int companyId)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@FormName", formName);
					p.Add("@CompanyId", companyId);

					var formModel =
						connection.QuerySingleOrDefault<FormModel>($"SELECT Id FROM {_schema}.Forms " +
						                                           $"WHERE Name = @FormName AND CompanyId = @CompanyId;", p);

					var returnFormId = formModel?.Id ?? 0;
					return returnFormId;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
		public int AddNewForm(FormModel data)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@Name", data.Name);
					p.Add("@Description", data.Description);

					p.Add("@Notes", data.Notes);
					p.Add("@CompanyId", data.CompanyId);
					p.Add("@BranchId", data.BranchId);
					p.Add("@CreatedBy", data.CreatedBy);
					p.Add("@IsProtected", data.IsProtected);
					p.Add("@IsDefault", data.IsDefault);

					data.Id = connection.ExecuteScalar<int>(
						$@"INSERT INTO {_schema}.Forms (Name, Description, Notes, CompanyId, BranchId, CreatedBy, IsProtected, IsDefault) " +
					    "VALUES (@Name, @Description, @Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected, @IsDefault)", p);

					return data.Id;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public void UpdateForm(FormModel data)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", data.Id);
					p.Add("@Name", data.Name);
					p.Add("@Description", data.Description);

					p.Add("@Notes", data.Notes);
					p.Add("@CompanyId", data.CompanyId);
					p.Add("@BranchId", data.BranchId);
					p.Add("@LastModifiedBy", data.LastModifiedBy);
					p.Add("@IsProtected", data.IsProtected);
					p.Add("@IsDefault", data.IsDefault);
					p.Add("@Active", data.Active);
					p.Add("@Locked", data.Locked);

					_ = connection.ExecuteScalar<int>(
						$@"UPDATE {_schema}.Forms SET Name = @Name, Description = @Description, Notes = @Notes, CompanyId = @CompanyId, " +
							"BranchId = BranchId, LastModifiedBy = @LastModifiedBy, IsProtected = @IsProtected, IsDefault = @IsDefault, " +
							"Active = @Active, Locked = @Locked WHERE Id = @Id", p);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public bool DeleteForm(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar($@"DELETE FROM {_schema}.Forms WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		#region override Dispose

		public void Dispose()
		{

		}

		#endregion

	}
}