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
	public class ContainerTypeRepository : IDisposable
	{
		public IList<ContainerTypeModel> SelectContainersType()
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var records =
						connection.Query<ContainerTypeModel>("SELECT * FROM ContainerType WHERE CompanyId = @CompanyId;", p);
					return records.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public ContainerTypeModel SelectContainerTypeById(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					var record =
						connection.QuerySingleOrDefault<ContainerTypeModel>("SELECT * FROM ContainerType WHERE Id = @Id;", p);
					return record;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public int AddNewContainerType(ContainerTypeModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@Description", dataModel.Description);
					p.Add("@ContainerTypeId", dataModel.ContainerTypeId);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);
					p.Add("@IsProtected", dataModel.IsProtected);

					dataModel.Id = connection.ExecuteScalar<int>(
						"INSERT INTO ContainerType (Description, ContainerTypeId, Notes, CompanyId, BranchId, CreatedBy, IsProtected)" +
						"VALUES (@Description, @ContainerTypeId, @Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected)", p);

					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public bool UpdateContainerType(ContainerTypeModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@Description", dataModel.Description);
					p.Add("@ContainerTypeId", dataModel.ContainerTypeId);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@Active", dataModel.Active);
					p.Add("@IsProtected", dataModel.IsProtected);

					_ = connection.ExecuteScalar<int>(
						"UPDATE ContainerType SET Description = @Description, ContainerTypeId = @ContainerTypeId, " +
						"Notes = @Notes, LastModifiedBy = @LastModifiedBy, " +
						"Active = @Active, IsProtected = @IsProtected WHERE Id = @Id", p);

					return true;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public bool DeleteContainerType(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM ContainerType WHERE Id = @Id", p);
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
