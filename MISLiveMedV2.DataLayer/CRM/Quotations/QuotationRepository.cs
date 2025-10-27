using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.JobModels.Quotations;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.CRM.Quotations
{
    public class QuotationRepository : IDisposable
    {
        public IList<QuotationModel> SelectQuotations(bool showProtected)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@IsProtected", showProtected);
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var quotationsRecords =
                        connection.Query<QuotationModel>("SELECT * FROM Quotations " +
                                                         "WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
                                                         "AND CompanyId = @CompanyId;", p); 
                    return quotationsRecords.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public QuotationModel SelectQuotationById(int quotationId, bool showProtected)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", quotationId);
                    p.Add("@IsProtected", showProtected);
                    p.Add("@CompanyId", CurrentUser.CompanyId);

					var quotationRecords =
                        connection.QuerySingleOrDefault<QuotationModel>("SELECT * FROM Quotations " +
                                                                        "WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
																		"AND Id = @Id " +
                                                                        "AND CompanyId = @CompanyId;", p); return quotationRecords;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewQuotation(QuotationModel dataModel)
        {
            try
            {
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@ReferenceNo", 0, DbType.Int32, ParameterDirection.Output);
					p.Add("@DepartmentPrefix", dataModel.DepartmentPrefix);
					p.Add("@DepartmentId", dataModel.DepartmentId);
					p.Add("@QuotationDate", dataModel.QuotationDate);
					p.Add("@MemberId", dataModel.MemberId);
					p.Add("@ConsigneeId", dataModel.ConsigneeId);
					p.Add("@UserId", dataModel.UserId);
					p.Add("@SalesId", dataModel.SalesId);
					p.Add("@Vol", dataModel.Vol);
					p.Add("@Pol", dataModel.Pol);
					p.Add("@Pod", dataModel.Pod);
					p.Add("@Status", dataModel.Status);
					p.Add("@AgentId", dataModel.AgentId);
					p.Add("@CarrierId", dataModel.CarrierId);
					p.Add("@Attention", dataModel.Attention);
					p.Add("@FollowupDate", dataModel.FollowupDate);
					p.Add("@Booked", dataModel.Booked);
					p.Add("@BookedDate", dataModel.BookedDate);
					p.Add("@QuotedDate", dataModel.QuotedDate);
					p.Add("@Lost", dataModel.Lost);
					p.Add("@LostDate", dataModel.LostDate);
					p.Add("@Canceled", dataModel.Canceled);
					p.Add("@CanceledDate", dataModel.CanceledDate);
					p.Add("@Reason", dataModel.Reason);
					p.Add("@Urgent", dataModel.Urgent);
					p.Add("@UrgentDate", dataModel.UrgentDate);
					p.Add("@ShipperName", dataModel.ShipperName);
					p.Add("@TermsId", dataModel.TermsId);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@CompanyId", dataModel.CompanyId);
					p.Add("@BranchId", dataModel.BranchId);
					p.Add("@CreatedBy", dataModel.CreatedBy);
					p.Add("@IsProtected", dataModel.IsProtected);

					dataModel.Id = connection.ExecuteScalar<int>(
						"dbo.job_AddNewQuotations @DepartmentPrefix, @DepartmentId, @QuotationDate, @MemberId, @ConsigneeId, @UserId, " +
						"@SalesId, @Vol, @Pol, @Pod, @Status, @AgentId, @CarrierId, @Attention, @FollowupDate, @Booked, @BookedDate, " +
						"@QuotedDate, @Lost, @LostDate, @Canceled, @CanceledDate, @Reason, @Urgent, @UrgentDate, @ShipperName, @TermsId, " +
						"@Notes, @CompanyId, @BranchId, @CreatedBy, @IsProtected", p);

					return dataModel.Id;
				}
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

        public bool UpdateQuotation(QuotationModel dataModel)
        {
            try
            {
				using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
				{
					var p = new DynamicParameters();
					p.Add("@Id", dataModel.Id);
					p.Add("@DepartmentPrefix", dataModel.DepartmentPrefix);
					p.Add("@ReferenceNo", dataModel.ReferenceNo);
					p.Add("@DepartmentId", dataModel.DepartmentId);
					p.Add("@QuotationDate", dataModel.QuotationDate);
					p.Add("@MemberId", dataModel.MemberId);
					p.Add("@ConsigneeId", dataModel.ConsigneeId);
					p.Add("@UserId", dataModel.UserId);
					p.Add("@SalesId", dataModel.SalesId);
					p.Add("@Vol", dataModel.Vol);
					p.Add("@Pol", dataModel.Pol);
					p.Add("@Pod", dataModel.Pod);
					p.Add("@Status", dataModel.Status);
					p.Add("@AgentId", dataModel.AgentId);
					p.Add("@CarrierId", dataModel.CarrierId);
					p.Add("@Attention", dataModel.Attention);
					p.Add("@FollowupDate", dataModel.FollowupDate);
					p.Add("@Booked", dataModel.Booked);
					p.Add("@BookedDate", dataModel.BookedDate);
					p.Add("@QuotedDate", dataModel.QuotedDate);
					p.Add("@Lost", dataModel.Lost);
					p.Add("@LostDate", dataModel.LostDate);
					p.Add("@Canceled", dataModel.Canceled);
					p.Add("@CanceledDate", dataModel.CanceledDate);
					p.Add("@Reason", dataModel.Reason);
					p.Add("@Urgent", dataModel.Urgent);
					p.Add("@UrgentDate", dataModel.UrgentDate);
					p.Add("@ShipperName", dataModel.ShipperName);
					p.Add("@TermsId", dataModel.TermsId);

					p.Add("@Notes", dataModel.Notes);
					p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
					p.Add("@IsProtected", dataModel.IsProtected);
					p.Add("@Active", dataModel.Active);

					_ = connection.ExecuteScalar<int>(
						"dbo.job_UpdateQuotations @Id, @DepartmentPrefix, @ReferenceNo, @DepartmentId, @QuotationDate, @MemberId, @ConsigneeId, @UserId, " +
						"@SalesId, @Vol, @Pol, @Pod, @Status, @AgentId, @CarrierId, @Attention, @FollowupDate, @Booked, @BookedDate, @QuotedDate, @Lost, " +
						"@LostDate, @Canceled, @CanceledDate, @Reason, @Urgent, @UrgentDate, @ShipperName, @TermsId, " +
						"@Notes, @LastModifiedBy, @IsProtected, @Active", p);
				}

				return true;
			}
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

        public bool CancelQuotation(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("UPDATE Quotations SET Canceled = 1, CanceledDate = getdate() WHERE Id = @Id;", p);
                }

                return true;
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

        public bool DeleteQuotation(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("Delete Quotations WHERE Id = @Id;", p);
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
