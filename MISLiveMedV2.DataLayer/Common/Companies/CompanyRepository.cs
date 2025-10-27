using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MISLiveMed.DataLayers.DataUtilities;
using MISLiveMed.Models.Models.Common.Companies;

namespace MISLiveMed.DataLayers.Common.Companies
{
    public class CompanyRepository : IDisposable
    {
	    //TODO: We need to add companies to ACCESS CONTROL LIST (ACL)
		public IList<CompanyModel> SelectCompanies()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var companies =
                        connection.Query<CompanyModel>("Select * from Companies WHERE Active = 1;");
                    return companies.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public CompanyModel SelectCompanyById(int companyId)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", companyId);

                    var companyRecord =
                        connection.QuerySingleOrDefault<CompanyModel>("SELECT * FROM Companies WHERE Id = @Id;", p);
                    return companyRecord;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int AddNewCompany(CompanyModel dataModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                    p.Add("@CompanyName", dataModel.CompanyName);
                    p.Add("@ShortName", dataModel.ShortName);
                    p.Add("@DirectoryPath", dataModel.DirectoryPath);
                    p.Add("@Address", dataModel.Address);
                    p.Add("@CityId", dataModel.CityId);
                    p.Add("@CountryId", dataModel.CountryId);
                    p.Add("@PhoneNumber1", dataModel.PhoneNumber1);
                    p.Add("@PhoneNumber2", dataModel.PhoneNumber2);
                    p.Add("@PhoneNumber3", dataModel.PhoneNumber3);
                    p.Add("@FaxNumber", dataModel.FaxNumber);
                    p.Add("@Email", dataModel.Email);
                    p.Add("@Website", dataModel.Website);
                    p.Add("@PoBox", dataModel.PoBox);
                    p.Add("@CompanyDisclaimer", dataModel.CompanyDisclaimer);
                    p.Add("@LocalCurrency", dataModel.LocalCurrency);
                    p.Add("@ForeignCurrency", dataModel.ForeignCurrency);
                    p.Add("@VatInfo", dataModel.VatInfo);
                    p.Add("@BankAccount", dataModel.BankAccount);
                    p.Add("@IATAName", dataModel.IATAName);
                    p.Add("@IATACode", dataModel.IATACode);
                    p.Add("@CustomsCode", dataModel.CustomsCode);
                    p.Add("@CompanyLogo", dataModel.CompanyLogo);
                    p.Add("@ChangeCompanyName", dataModel.ChangeCompanyName);

                    p.Add("@Notes", dataModel.Notes);
                    p.Add("@CompanyId", dataModel.CompanyId);
                    p.Add("@BranchId", dataModel.BranchId);
                    p.Add("@CreatedBy", dataModel.CreatedBy);
                    p.Add("@WorkingYear", dataModel.WorkingYear);
                    p.Add("@IsProtected", dataModel.IsProtected);
                    p.Add("@IsDefault", dataModel.IsDefault);
                    p.Add("@Locked", dataModel.Locked);

					dataModel.Id = connection.ExecuteScalar<int>(
						"dbo.job_AddNewCompany @CompanyName, @ShortName, @DirectoryPath, @Address, @CityId, @CountryId, @PhoneNumber1, @PhoneNumber2, " +
                                    "@PhoneNumber3, @FaxNumber, @Email, @Website, @PoBox, @CompanyDisclaimer, @LocalCurrency, @ForeignCurrency, @VatInfo, " +
									 "@BankAccount, @IATAName, @IATACode, @CustomsCode, @CompanyLogo, @ChangeCompanyName, " +
									 "@Notes, @CompanyId, @BranchId, @CreatedBy, @WorkingYear, @IsProtected, @IsDefault, @Locked;", p);

                    return dataModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int UpdateCompany(CompanyModel dataModel)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", dataModel.Id);
                    p.Add("@CompanyName", dataModel.CompanyName);
                    p.Add("@ShortName", dataModel.ShortName);
                    p.Add("@DirectoryPath", dataModel.DirectoryPath);
                    p.Add("@Address", dataModel.Address);
                    p.Add("@CityId", dataModel.CityId);
                    p.Add("@CountryId", dataModel.CountryId);
                    p.Add("@PhoneNumber1", dataModel.PhoneNumber1);
                    p.Add("@PhoneNumber2", dataModel.PhoneNumber2);
                    p.Add("@PhoneNumber3", dataModel.PhoneNumber3);
                    p.Add("@FaxNumber", dataModel.FaxNumber);
                    p.Add("@Email", dataModel.Email);
                    p.Add("@Website", dataModel.Website);
                    p.Add("@PoBox", dataModel.PoBox);
                    p.Add("@CompanyDisclaimer", dataModel.CompanyDisclaimer);
                    p.Add("@LocalCurrency", dataModel.LocalCurrency);
                    p.Add("@ForeignCurrency", dataModel.ForeignCurrency);
                    p.Add("@VatInfo", dataModel.VatInfo);
                    p.Add("@BankAccount", dataModel.BankAccount);
                    p.Add("@IATAName", dataModel.IATAName);
                    p.Add("@IATACode", dataModel.IATACode);
                    p.Add("@CustomsCode", dataModel.CustomsCode);
                    p.Add("@CompanyLogo", dataModel.CompanyLogo);
                    p.Add("@ChangeCompanyName", dataModel.ChangeCompanyName);

                    p.Add("@Notes", dataModel.Notes);
                    p.Add("@LastModifiedBy", dataModel.LastModifiedBy);
                    p.Add("@WorkingYear", dataModel.WorkingYear);
                    p.Add("@IsProtected", dataModel.IsProtected);
                    p.Add("@IsDefault", dataModel.IsDefault);
                    p.Add("@Active", dataModel.Active);
                    p.Add("@Locked", dataModel.Locked);

					_ = connection.ExecuteScalar<int>(
						"dbo.job_UpdateCompany @Id, @CompanyName, @ShortName, @DirectoryPath, @Address, @CityId, @CountryId, @PhoneNumber1, @PhoneNumber2, " +
                                "@PhoneNumber3, @FaxNumber, @Email, @Website, @PoBox, @CompanyDisclaimer, @LocalCurrency, @ForeignCurrency, @VatInfo, " +
								"@BankAccount, @IATAName, @IATACode, @CustomsCode, @CompanyLogo, @ChangeCompanyName, " +
								"@Notes, @LastModifiedBy, @WorkingYear, @IsProtected, @IsDefault, @Active, @Locked;", p);

                    return dataModel.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool DeleteCompany(int id)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.BuildConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@Id", id);

                    _ = connection.ExecuteScalar("dbo.job_CleanAndDeleteCompany @Id", p);

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
