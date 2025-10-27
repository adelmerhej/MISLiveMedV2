using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.JobModels.Import.SeaFreight.Jobs;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.DataLayers.JobData.SeaImport    
{
    public class JobSeaImportDetailRepository : IDisposable
    {
        public IList<JobSeaImportDetailModel> JobsSeaImportDetail(bool showProtected = false)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@CompanyId", CurrentUser.CompanyId);
                    p.Add("@IsProtected", showProtected);

					var jobsList =
                        connection.Query<JobSeaImportDetailModel>("SELECT * FROM JobSImportDetail " +
                                                                  "WHERE (@IsProtected = 1 OR IsProtected = @IsProtected) " +
                                                                  "AND CompanyId = @CompanyId;", p);

                    return jobsList.ToList();
                }
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

        public IList<JobSeaImportDetailModel> JobsSeaImportDetailByJobNo(int jobNo)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@jobNo", jobNo);
                    p.Add("@CompanyId", CurrentUser.CompanyId);

                    var jobsList =
                        connection.Query<JobSeaImportDetailModel>("SELECT * FROM JobSImportDetail " +
                                                                  "WHERE CompanyId = @CompanyId AND JobId = @jobNo;", p);

                    return jobsList.ToList();
                }
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
			}
        }

        public int AddNewJobSeaImportDetail(JobSeaImportDetailModel model)
        {
	        try
	        {
	            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
	            {
	                var p = new DynamicParameters();
	                p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
	                p.Add("@JobId", model.JobId);
	                p.Add("@Hbl", model.Hbl);
	                p.Add("@OriginId", model.OriginId);
	                p.Add("@SupplierId", model.SupplierId);
	                p.Add("@ContainerNo", model.ContainerNo);
	                p.Add("@Quantities", model.Quantities);
	                p.Add("@UnitId", model.UnitId);
	                p.Add("@Pieces", model.Pieces);
	                p.Add("@UnitOfMeasureId", model.UnitOfMeasureId);
	                p.Add("@Packages", model.Packages);
	                p.Add("@Weight", model.Weight);
	                p.Add("@ValueOfGoods", model.ValueOfGoods);
	                p.Add("@Terms", model.Terms);
	                p.Add("@CcAmount", model.CcAmount);
	                p.Add("@Original", model.Original);
	                p.Add("@Photo", model.Photo);
	                p.Add("@Pl", model.Pl);
	                p.Add("@Pop", model.Pop);
	                p.Add("@Commodity", model.Commodity);
	                p.Add("@Notify", model.Notify);

					p.Add("@Notes", model.Notes);
	                p.Add("@CompanyId", model.CompanyId);
	                p.Add("@CreatedBy", model.CreatedBy);
	                p.Add("@IsProtected", model.IsProtected);
	                
	                model.Id = connection.ExecuteScalar<int>("dbo.job_AddNewJobSeaImportDetail @JobId, @Hbl, @OriginId, @SupplierId, @ContainerNo, " +
									"@Quantities, @UnitId, @Pieces, @UnitOfMeasureId, @Packages, @Weight, @ValueOfGoods, @Terms, @CcAmount, @Original, " +
	                                "@Photo, @Pl, @Pop, @Commodity, @Notify, @Notes, @CompanyId, @CreatedBy, @IsProtected;", p);

	                return model.Id;
	            }
	        }
	        catch (Exception e)
	        {
		        throw new Exception(e.Message);
			}
        }

        public void UpdateJobSeaImportDetail(JobSeaImportDetailModel model)
        {
	        try
	        {
	            using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
	            {
	                var p = new DynamicParameters();
	                p.Add("@Id", model.Id);
	                p.Add("@JobId", model.JobId);
	                p.Add("@Hbl", model.Hbl);
	                p.Add("@OriginId", model.OriginId);
	                p.Add("@SupplierId", model.SupplierId);
	                p.Add("@ContainerNo", model.ContainerNo);
	                p.Add("@Quantities", model.Quantities);
	                p.Add("@UnitId", model.UnitId);
	                p.Add("@Pieces", model.Pieces);
	                p.Add("@UnitOfMeasureId", model.UnitOfMeasureId);
	                p.Add("@Packages", model.Packages);
	                p.Add("@Weight", model.Weight);
	                p.Add("@ValueOfGoods", model.ValueOfGoods);
	                p.Add("@Terms", model.Terms);
	                p.Add("@CcAmount", model.CcAmount);
	                p.Add("@Original", model.Original);
	                p.Add("@Photo", model.Photo);
	                p.Add("@Pl", model.Pl);
	                p.Add("@Pop", model.Pop);
	                p.Add("@Commodity", model.Commodity);
	                p.Add("@Notify", model.Notify);

	                p.Add("@Notes", model.Notes);
	                p.Add("@LastModifiedBy", model.LastModifiedBy);
	                p.Add("@IsProtected", model.IsProtected);
	                p.Add("@Active", model.Active);

	                _ = connection.ExecuteScalar("dbo.job_UpdateJobSeaImportDetail @Id, @JobId, @Hbl, @OriginId, @SupplierId, @ContainerNo, " +
											"@Quantities, @UnitId, @Pieces, @UnitOfMeasureId, @Packages, @Weight, @ValueOfGoods, @Terms, @CcAmount, @Original, " +
											"@Photo, @Pl, @Pop, @Commodity, @Notify, @Notes, @LastModifiedBy, @IsProtected, @Active;", p);

	            }
	        }
	        catch (Exception e)
	        {
		        throw new Exception(e.Message);
			}
        }

        public bool DeleteJobSeaImportDetail(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("DELETE FROM JobSImportDetail WHERE Id = @Id;", p);
                }

                return true;
            }
            catch (Exception e)
            {
	            throw new Exception(e.Message);
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
