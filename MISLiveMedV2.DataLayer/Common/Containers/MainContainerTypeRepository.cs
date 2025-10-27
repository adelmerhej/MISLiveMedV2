using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Containers;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.Common.Containers
{
	public class MainContainerTypeRepository : IDisposable
	{
		public IList<MainContainerTypeModel> SelectMainContainersType()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<MainContainerTypeModel>("SELECT * FROM ContainerTypeMain WHERE CompanyId = @CompanyId;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public MainContainerTypeModel SelectMainContainerTypeById(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					var record =
						connection.QuerySingleOrDefault<MainContainerTypeModel>("SELECT * FROM ContainerTypeMain WHERE Id = @Id;", p);
					return record;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewMainContainerType(MainContainerTypeModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@Description", dataModel.Description);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);
					p.Add("@IsProtected", dataModel.IsProtected);

					dataModel.Id = connection.ExecuteScalar<int>(
						"INSERT INTO ContainerTypeMain (Description, Notes, CompanyId, BranchId, CreatedBy, IsProtected)" +
						"VALUES (@Description, @Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected)", p);

					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public bool UpdateMainContainerType(MainContainerTypeModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@Description", dataModel.Description);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@Active", dataModel.Active);
					p.Add("@IsProtected", dataModel.IsProtected);

					_ = connection.ExecuteScalar<int>(
						"UPDATE ContainerTypeMain SET Description = @Description, Notes = @Notes, LastModifiedBy = @LastModifiedBy, " +
						"Active = @Active, IsProtected = @IsProtected " +
						"WHERE Id = @Id", p);

					return true;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public bool DeleteMainContainerType(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM ContainerTypeMain WHERE Id = @Id", p);
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
