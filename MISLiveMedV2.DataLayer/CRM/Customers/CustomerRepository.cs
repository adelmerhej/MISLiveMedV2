using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common;
using MISLiveMed.Models.Models.Members.Customers;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.CRM.Customers
{
	public class CustomerRepository : IDisposable
	{
		public IList<InitDataObjectModel> SelectMembers(bool showProtected = false, bool isLimitedView = false)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@UserId", isLimitedView ? CurrentUser.UserId : 0);
					p.Add("@IsProtected", showProtected);

					var customersRecords =
						connection.Query<InitDataObjectModel>("SELECT Id as Value, CustomerName as Name FROM Customers " +
															  "WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
															  "AND (UserId = 0 OR SalesId = @UserId) " +
															  "AND CompanyId = @CompanyId;", p);
					return customersRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<CustomerModel> SelectCustomers(bool showProtected = false, bool isLimitedView = false)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@UserId", isLimitedView ? CurrentUser.UserId : 0);
					p.Add("@IsProtected", showProtected);

					var customersRecords =
						connection.Query<CustomerModel>("SELECT * FROM Customers " +
														"WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
														//"AND (@UserId = 0 OR ResponsibleId = @UserId) " +
														"AND CompanyId = @CompanyId;", p);
					return customersRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		//GetSalesPersonByCustomerId
		public int GetSalesPersonByCustomerId(int customerId, bool showProtected = false)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CustomerId", customerId);
					p.Add("@IsProtected", showProtected);

					var returnRecord =
						connection.QuerySingleOrDefault("SELECT SalesId FROM Customers " +
													"WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
													"AND Id = @CustomerId;", p);

					if (returnRecord == null)
						return 0;

					return (int?)returnRecord.SalesId ?? 0;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<CustomerModel> SelectCustomersBySalesId(int salesId, bool showProtected = false)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@SalesId", salesId);
					p.Add("@IsProtected", showProtected);

					var customerRecord =
						connection.Query<CustomerModel>("SELECT * FROM Customers " +
														"WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
														"AND SalesId = @SalesId;", p);
					return customerRecord.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<CustomerModel> SelectCustomersByRating(bool showProtected = false, bool isLimitedView = false, int rating = 0)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@IsProtected", showProtected);
					p.Add("@UserId", isLimitedView ? CurrentUser.UserId : 0);
					p.Add("@Rating", rating);
					p.Add("@CompanyId", CurrentUser.CompanyId);

					var customerRecord =
						connection.Query<CustomerModel>("SELECT * FROM Customers " +
															"WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
																"AND (UserId = 0 OR ResponsibleId = @UserId) " +
																"AND Rating = @Rating " +
																"AND CompanyId = @CompanyId;", p);
					return customerRecord.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public CustomerModel SelectCustomerById(int customerId, bool showProtected = false)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", customerId);
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@IsProtected", showProtected);

					var customerRecord =
						connection.QuerySingleOrDefault<CustomerModel>("SELECT * FROM Customers " +
																	   "WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
																	   "AND Id = @Id;", p);
					return customerRecord;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public IList<CustomerHistoryModel> SelectCustomerHistoryById(int customerId, bool showProtected = false)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@CompanyId", CurrentUser.CompanyId);
					p.Add("@CustomerId", customerId);

					var customerHistoryRecords =
						connection.Query<CustomerHistoryModel>("dbo.job_CustomerHistory @CustomerId, @CompanyId;", p);
					return customerHistoryRecords.ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}


		public int AddNewCustomer(CustomerModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@CustomerName", dataModel.CustomerName);
					p.Add("@MemberOfId", dataModel.MemberOfId);
					p.Add("@ActiveDate", dataModel.ActiveDate);
					p.Add("@FollowupDate", dataModel.FollowupDate);
					p.Add("@CNSSExpiryDate", dataModel.CNSSExpiryDate);
					p.Add("@CountryId", dataModel.CountryId);
					p.Add("@CityId", dataModel.CityId);
					p.Add("@Address", dataModel.Address);
					p.Add("@PhoneNumber1", dataModel.PhoneNumber1);
					p.Add("@PhoneNumber2", dataModel.PhoneNumber2);
					p.Add("@PhoneNumber3", dataModel.PhoneNumber3);
					p.Add("@FaxNumber", dataModel.FaxNumber);
					p.Add("@Website", dataModel.Website);
					p.Add("@MofNo", dataModel.MofNo);
					p.Add("@Email", dataModel.Email);
					p.Add("@Activity", dataModel.Activity);
					p.Add("@IsSales", dataModel.IsSales);
					p.Add("@ResponsibleId", dataModel.ResponsibleId);
					p.Add("@SalesId", dataModel.SalesId);
					p.Add("@PaymentId", dataModel.PaymentId);
					p.Add("@Days", dataModel.Days);
					p.Add("@Amount", dataModel.Amount);
					p.Add("@CustomsDays", dataModel.CustomsDays);
					p.Add("@PaymentStatus", dataModel.PaymentStatus);
					p.Add("@Rating", dataModel.Rating);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);
					p.Add("@IsProtected", dataModel.IsProtected);

					dataModel.Id = connection.ExecuteScalar<int>(
						"dbo.job_AddNewCustomer_V002 @CustomerName, @MemberOfId, @ActiveDate, @FollowupDate, @CNSSExpiryDate, " +
						"@CountryId, @CityId, @Address, @PhoneNumber1, @PhoneNumber2, @PhoneNumber3, @FaxNumber, " +
						"@Website, @MofNo, @Email, @Activity, @IsSales, @ResponsibleId, @SalesId, @PaymentId, @Days, " +
						"@Amount, @CustomsDays, @PaymentStatus, @Rating, " +
						"@Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected", p);

					return dataModel.Id;
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public void UpdateCustomer(CustomerModel dataModel)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@CustomerName", dataModel.CustomerName);
					p.Add("@MemberOfId", dataModel.MemberOfId);
					p.Add("@ActiveDate", dataModel.ActiveDate);
					p.Add("@FollowupDate", dataModel.FollowupDate);
					p.Add("@CNSSExpiryDate", dataModel.CNSSExpiryDate);
					p.Add("@CountryId", dataModel.CountryId);
					p.Add("@CityId", dataModel.CityId);
					p.Add("@Address", dataModel.Address);
					p.Add("@PhoneNumber1", dataModel.PhoneNumber1);
					p.Add("@PhoneNumber2", dataModel.PhoneNumber2);
					p.Add("@PhoneNumber3", dataModel.PhoneNumber3);
					p.Add("@FaxNumber", dataModel.FaxNumber);
					p.Add("@Website", dataModel.Website);
					p.Add("@MofNo", dataModel.MofNo);
					p.Add("@Email", dataModel.Email);
					p.Add("@Activity", dataModel.Activity);
					p.Add("@IsSales", dataModel.IsSales);
					p.Add("@ResponsibleId", dataModel.ResponsibleId);
					p.Add("@SalesId", dataModel.SalesId);
					p.Add("@PaymentId", dataModel.PaymentId);
					p.Add("@Days", dataModel.Days);
					p.Add("@Amount", dataModel.Amount);
					p.Add("@CustomsDays", dataModel.CustomsDays);
					p.Add("@PaymentStatus", dataModel.PaymentStatus);
					p.Add("@Rating", dataModel.Rating);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@Active", dataModel.Active);

					_ = connection.ExecuteScalar<int>(
						"dbo.job_UpdateCustomer_V002 @Id, @CustomerName, @MemberOfId, @ActiveDate, @FollowupDate, @CNSSExpiryDate, " +
						"@CountryId, @CityId, @Address, @PhoneNumber1, @PhoneNumber2, @PhoneNumber3, @FaxNumber, " +
						"@Website, @MofNo, @Email, @Activity, @IsSales, @ResponsibleId, @SalesId, @PaymentId, @Days, " +
						"@Amount, @CustomsDays, @PaymentStatus, @Rating, " +
						"@Notes, @LastModifiedBy, @IsProtected, @Active", p);
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public bool DeleteCustomer(int id)
		{
			try
			{
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", id);

					_ = connection.ExecuteScalar("DELETE FROM Customers WHERE Id = @Id", p);
				}

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		#region Implementation of IDisposable

		public void Dispose()
		{

		}

		#endregion
	}
}
