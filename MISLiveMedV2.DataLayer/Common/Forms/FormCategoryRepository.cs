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
	public class FormCategoryRepository : IDisposable

	{
	private const string _schema = "_application";

	public IList<FormCategoryModel> SelectDefaultFormsCategories()
	{
		try
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			{
				var p = new DynamicParameters();
				p.Add("@CompanyId", 1);

				var records =
					connection.Query<FormCategoryModel>($@"SELECT * FROM {_schema}.FormsCategories WHERE CompanyId = @CompanyId;", p);
				return records.ToList();
			}
		}
		catch (Exception e)
		{
			throw new Exception(e.Message);
		}
	}

		public IList<FormCategoryModel> SelectFormsCategories()
	{
		try
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			{
				var p = new DynamicParameters();
				p.Add("@CompanyId", CurrentUser.CompanyId);

				var records =
					connection.Query<FormCategoryModel>(
						$@"SELECT * FROM {_schema}.FormsCategories WHERE CompanyId = @CompanyId;", p);
				return records.ToList();
			}
		}
		catch (Exception e)
		{
			throw new Exception(e.Message);
		}
	}

	public FormCategoryModel SelectFormCategoryById(int formId)
	{
		try
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			{
				var p = new DynamicParameters();
				p.Add("@Id", formId);

				var record =
					connection.QuerySingleOrDefault<FormCategoryModel>(
						$@"SELECT * FROM {_schema}.FormsCategories WHERE Id = @Id;", p);
				return record;
			}
		}
		catch (Exception e)
		{
			throw new Exception(e.Message);
		}
	}

	public int SelectFormCategoryByName(string formName)
	{
		try
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			{
				int returnFormId;

				var p = new DynamicParameters();
				p.Add("@FormName", formName);

				var record =
					connection.QuerySingleOrDefault<FormCategoryModel>(
						$@"SELECT Id FROM {_schema}.FormsCategories WHERE Name = @FormName;", p);

				returnFormId = record?.Id ?? 0;
				return returnFormId;
			}
		}
		catch (Exception e)
		{
			throw new Exception(e.Message);
		}
	}
	public int SelectFormCategoryByName(string formName, int companyId)
	{
		try
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			{
				int returnFormId;

				var p = new DynamicParameters();
				p.Add("@FormName", formName);
				p.Add("@CompanyId", companyId);

				var record =
					connection.QuerySingleOrDefault<FormCategoryModel>($"SELECT Id FROM {_schema}.FormsCategories " +
					                                                   $"WHERE Name = @FormName AND CompanyId = @CompanyId;", p);

				returnFormId = record?.Id ?? 0;
				return returnFormId;
			}
		}
		catch (Exception e)
		{
			throw new Exception(e.Message);
		}
	}

		public int AddNewFormCategory(FormCategoryModel data)
	{
		try
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			{
				var p = new DynamicParameters();
				p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
				p.Add("@Name", data.Name);

				p.Add("@Notes", data.Notes);
				p.Add("@CompanyId", data.CompanyId);
				p.Add("@BranchId", data.BranchId);
				p.Add("@CreatedBy", data.CreatedBy);
				p.Add("@IsProtected", data.IsProtected);
				p.Add("@IsDefault", data.IsDefault);

				data.Id = connection.ExecuteScalar<int>(
					$@"INSERT INTO {_schema}.FormsCategories (Name, Notes, CompanyId, BranchId, CreatedBy, IsProtected, IsDefault) " +
					"VALUES (@Name, @Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected, @IsDefault)", p);

				return data.Id;
			}
		}
		catch (Exception e)
		{
			throw new Exception(e.Message);
		}
	}

	public void UpdateFormCategory(FormCategoryModel data)
	{
		try
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			{
				var p = new DynamicParameters();
				p.Add("@Id", data.Id);
				p.Add("@Name", data.Name);

				p.Add("@Notes", data.Notes);
				p.Add("@CompanyId", data.CompanyId);
				p.Add("@BranchId", data.BranchId);
				p.Add("@LastModifiedBy", data.LastModifiedBy);
				p.Add("@IsProtected", data.IsProtected);
				p.Add("@IsDefault", data.IsDefault);
				p.Add("@Active", data.Active);
				p.Add("@Locked", data.Locked);

				_ = connection.ExecuteScalar<int>(
					$@"UPDATE {_schema}.FormsCategories SET Name = @Name, Notes = @Notes, CompanyId = @CompanyId, " +
					"BranchId = BranchId, LastModifiedBy = @LastModifiedBy, IsProtected = @IsProtected, IsDefault = @IsDefault, " +
					"Active = @Active, Locked = @Locked", p);
			}
		}
		catch (Exception e)
		{
			throw new Exception(e.Message);
		}
	}

	public bool DeleteFormCategory(int id)
	{
		try
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
			{
				var p = new DynamicParameters();
				p.Add("@Id", id);

				_ = connection.ExecuteScalar($@"DELETE FROM {_schema}.FormsCategories WHERE Id = @Id", p);
			}

			return true;
		}
		catch (Exception e)
		{
			throw new Exception(e.Message);
		}
	}

	#region override Dispose

	public void Dispose()
	{

	}

	#endregion

	}
}
