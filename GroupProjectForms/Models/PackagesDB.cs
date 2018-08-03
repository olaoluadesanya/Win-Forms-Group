using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Package DB
/// Olaoluwa Adesanya SAIT 2018
/// Performs Crud Operation on the Package table in the Travel Experts Database
/// </summary>
namespace GroupProjectForms.Models
{
    public static class PackagesDB
    {
        /// <summary>
        /// Get package with a specific id
        /// </summary>
        /// <param name="packageId"></param>
        /// <returns></returns>
        public static Package GetPackage(int packageId)
        {
            Package pack = null;
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string selectStatement = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                                     "FROM Packages " +
                                     "WHERE PackageId = @PackageId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PackageId", packageId);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read()) // found a package
                {
                    pack = new Package();
                    pack.PackageId = (int)reader["PackageId"];
                    pack.Name = reader["PkgName"].ToString();
                    pack.StartDate = reader["PkgStartDate"] as DateTime?;
                    pack.EndDate = reader["PkgEndDate"] as DateTime?;
                    pack.Desc = reader["PkgDesc"].ToString();
                    pack.BasePrice = (Decimal)reader["PkgBasePrice"];
                    pack.AgencyCommission = reader["PkgAgencyCommission"] as Decimal?;
                    

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return pack;
        }
        /// <summary>
        /// Get all packages
        /// </summary>
        /// <param name="packageId"></param>
        /// <returns>List of Packages</returns>
        public static List<Package> GetAllPackages()
        {
            List<Package> packages = new List<Package>();
            Package pack = null;
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string selectStatement = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                                     "FROM Packages ORDER BY PackageId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read()) // found a package
                {
                    pack = new Package();
                    pack.PackageId = (int)reader["PackageId"];
                    pack.Name = reader["PkgName"].ToString();
                    pack.StartDate = reader["PkgStartDate"] as DateTime?;
                    pack.EndDate = reader["PkgEndDate"] as DateTime?;
                    pack.Desc = reader["PkgDesc"].ToString();
                    pack.BasePrice = (Decimal)reader["PkgBasePrice"];
                    pack.AgencyCommission = reader["PkgAgencyCommission"] as Decimal?;
                    pack.packProd = Packages_Products_SuppliersDB.GetPackages_Product_Suppliers(pack.PackageId);
                    packages.Add(pack);

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return packages;
        }

        /// <summary>
        /// Adds a new packages to the Packages Table in Travel Experts Database
        /// </summary>
        /// <param name="pack"> Package object that cotaing data for the new record</param>
        /// <returns>generated PackageId</returns>
        public static int AddPackage(Package pack)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string insertStatement = "INSERT INTO Packages (PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                                     "VALUES(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";
            SqlCommand cmd = new SqlCommand(insertStatement, connection);
            cmd.Parameters.AddWithValue("@PkgName", pack.Name);
            cmd.Parameters.AddWithValue("@PkgDesc", pack.Desc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", pack.BasePrice);

            //This block of code specifies passing a nullable type as a parameter to SQL for StartDate
            SqlParameter startDateParam = new SqlParameter("@PkgStartDate", pack.StartDate == null ?
                (Object)DBNull.Value : pack.StartDate);
            startDateParam.IsNullable = true;
            startDateParam.Direction = ParameterDirection.Input;
            startDateParam.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(startDateParam);

            //This block of code specifies passing a nullable type as a parameter to SQL for endDate
            SqlParameter endDateParam = new SqlParameter("@PkgEndDate", pack.EndDate == null ?
                (Object)DBNull.Value : pack.EndDate);
            endDateParam.IsNullable = true;
            endDateParam.Direction = ParameterDirection.Input;
            endDateParam.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(endDateParam);

            //This block of code specifies passing a nullable type as a parameter to SQL for Agencycommision
            SqlParameter pkgAgencyParam = new SqlParameter("@PkgAgencyCommission", pack.AgencyCommission == null ?
                (Object)DBNull.Value : pack.AgencyCommission);
            pkgAgencyParam.IsNullable = true;
            pkgAgencyParam.Direction = ParameterDirection.Input;
            pkgAgencyParam.SqlDbType = SqlDbType.Money;
            cmd.Parameters.Add(pkgAgencyParam);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery(); // run the insert command
                                       // get the generated Id - current Identity value for  Packages table
                string selectQuery = "SELECT IdENT_CURRENT('Packages') FROM Packages";
                SqlCommand selectCmd = new SqlCommand(selectQuery, connection);
                int PackageId = Convert.ToInt32(selectCmd.ExecuteScalar()); // single value
                                                                             // typecase (int) does NOT work!
                return PackageId;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Deletes the passed package from the database
        /// </summary>
        /// <param name="pack"></param>
        /// <returns></returns>
        public static bool DeletePackage(Package pack)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string deleteStatement =
                                     "delete Packages_Products_Suppliers from Packages_Products_Suppliers " +
                                     "inner join Products_Suppliers on Products_Suppliers.ProductSupplierId = Packages_Products_Suppliers.ProductSupplierId " +
                                     "inner join Suppliers on Products_Suppliers.SupplierId = Suppliers.SupplierId " +
                                     "where Packages_Products_Suppliers.PackageId = @PackageId " +
                                     //first part deletes the link to package product supplier table if it exists
                                     //second part deltes the actual package
                                     "DELETE FROM Packages " +
                                     "WHERE PackageId = @PackageId " + // to Identify the package to be  deleted
                                     "AND PkgName = @PkgName " + // remaining conditions - to ensure optimistic concurrency
                                     "AND (PkgStartDate = @PkgStartDate " + 
                                     "OR PkgStartDate IS NULL) " + //Database null values can only be tested with IS NULL
                                     "AND (PkgStartDate = @PkgStartDate " +
                                     "OR PkgStartDate IS NULL) " + //Database null values can only be tested with IS NULL
                                     "AND PkgDesc = @PkgDesc " +
                                     "AND PkgBasePrice = @PkgBasePrice " +
                                     "AND (PkgAgencyCommission = @PkgAgencyCommission " +
                                     "OR PkgAgencyCommission IS NULL)"; //Database null values can only be tested with IS NULL

            SqlCommand cmd = new SqlCommand(deleteStatement, connection);
            cmd.Parameters.AddWithValue("@PackageId", pack.PackageId);
            cmd.Parameters.AddWithValue("@PkgName", pack.Name);
            cmd.Parameters.AddWithValue("@PkgDesc", pack.Desc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", pack.BasePrice);

            //This block of code specifies passing a nullable type as a parameter to SQL for StartDate
            SqlParameter startDateParam = new SqlParameter("@PkgStartDate", pack.StartDate == null ?
                (Object)DBNull.Value : pack.StartDate);
            startDateParam.IsNullable = true;
            startDateParam.Direction = ParameterDirection.Input;
            startDateParam.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(startDateParam);

            //This block of code specifies passing a nullable type as a parameter to SQL for endDate
            SqlParameter endDateParam = new SqlParameter("@PkgEndDate", pack.EndDate == null ?
                (Object)DBNull.Value : pack.EndDate);
            endDateParam.IsNullable = true;
            endDateParam.Direction = ParameterDirection.Input;
            endDateParam.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(endDateParam);

            //This block of code specifies passing a nullable type as a parameter to SQL for Agencycommision
            SqlParameter pkgAgencyParam = new SqlParameter("@PkgAgencyCommission", pack.AgencyCommission == null ?
                (Object)DBNull.Value : pack.AgencyCommission);
            pkgAgencyParam.IsNullable = true;
            pkgAgencyParam.Direction = ParameterDirection.Input;
            pkgAgencyParam.SqlDbType = SqlDbType.Decimal;
            cmd.Parameters.Add(pkgAgencyParam);

            try
            {
                connection.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Updates existing package
        /// </summary>
        /// <param name="oldPack">data before update</param>
        /// <param name="newPack">new data for the update</param>
        /// <returns>indicator of success</returns>
        public static bool UpdatePackage(Package oldPack, Package newPack)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string updateStatement = "UPDATE Packages " +
                                     "SET PkgName = @NewName, " +
                                     "    PkgStartDate = @NewPkgStartDate, " +
                                     "    PkgEndDate = @NewPkgEndDate, " +
                                     "    PkgDesc = @NewPkgDesc, " +
                                     "    PkgBasePrice = @NewPkgBasePrice, " +
                                     "    PkgAgencyCommission = @NewPkgAgencyCommission " +
                                     "WHERE PackageId = @OldPackageId " +
                                     "AND PkgName = @OldPkgName " + // remaining conditions - to ensure optimistic concurrency
                                     "AND (PkgStartDate = @OldPkgStartDate " +
                                     "OR PkgStartDate IS NULL) " + //Database null values can only be tested with IS NULL
                                     "AND (PkgEndDate = @OldPkgEndDate " +
                                     "OR PkgEndDate IS NULL) " + //Database null values can only be tested with IS NULL
                                     "AND PkgDesc = @OldPkgDesc " +
                                     "AND PkgBasePrice = @OldPkgBasePrice " +
                                     "AND (PkgAgencyCommission = @OldPkgAgencyCommission " +
                                     "OR PkgAgencyCommission IS NULL)"; //Database null values can only be tested with IS NULL
            SqlCommand cmd = new SqlCommand(updateStatement, connection);
            cmd.Parameters.AddWithValue("@NewName", newPack.Name);
            cmd.Parameters.AddWithValue("@NewPkgDesc", newPack.Desc);
            cmd.Parameters.AddWithValue("@NewPkgBasePrice", newPack.BasePrice);
            cmd.Parameters.AddWithValue("@OldPackageId", oldPack.PackageId);
            cmd.Parameters.AddWithValue("@OldPkgName", oldPack.Name);
            cmd.Parameters.AddWithValue("@OldPkgDesc", oldPack.Desc);
            cmd.Parameters.AddWithValue("@OldPkgBasePrice", oldPack.BasePrice);

            //This block of code specifies passing a nullable type as a parameter to SQL for StartDate
            SqlParameter newStartDateParam = new SqlParameter("@NewPkgStartDate", newPack.StartDate == null ?
                (Object)DBNull.Value : newPack.StartDate);
            newStartDateParam.IsNullable = true;
            newStartDateParam.Direction = ParameterDirection.Input;
            newStartDateParam.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(newStartDateParam);

            //This block of code specifies passing a nullable type as a parameter to SQL for endDate
            SqlParameter newEndDateParam = new SqlParameter("@NewPkgEndDate", newPack.EndDate == null ?
                (Object)DBNull.Value : newPack.EndDate);
            newEndDateParam.IsNullable = true;
            newEndDateParam.Direction = ParameterDirection.Input;
            newEndDateParam.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(newEndDateParam);

            //This block of code specifies passing a nullable type as a parameter to SQL for Agencycommision
            SqlParameter newPkgAgencyParam = new SqlParameter("@NewPkgAgencyCommission", newPack.AgencyCommission == null ?
                (Object)DBNull.Value : newPack.AgencyCommission);
            newPkgAgencyParam.IsNullable = true;
            newPkgAgencyParam.Direction = ParameterDirection.Input;
            newPkgAgencyParam.SqlDbType = SqlDbType.Money;
            cmd.Parameters.Add(newPkgAgencyParam);

            //This block of code specifies passing a nullable type as a parameter to SQL for StartDate
            SqlParameter oldStartDateParam = new SqlParameter("@OldPkgStartDate", oldPack.StartDate == null ?
                (Object)DBNull.Value : oldPack.StartDate);
            oldStartDateParam.IsNullable = true;
            oldStartDateParam.Direction = ParameterDirection.Input;
            oldStartDateParam.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(oldStartDateParam);

            //This block of code specifies passing a nullable type as a parameter to SQL for endDate
            SqlParameter oldEndDateParam = new SqlParameter("@OldPkgEndDate", oldPack.EndDate == null ?
                (Object)DBNull.Value : oldPack.EndDate);
            oldEndDateParam.IsNullable = true;
            oldEndDateParam.Direction = ParameterDirection.Input;
            oldEndDateParam.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(oldEndDateParam);

            //This block of code specifies passing a nullable type as a parameter to SQL for Agencycommision
            SqlParameter oldPkgAgencyParam = new SqlParameter("@OldPkgAgencyCommission", oldPack.AgencyCommission == null ?
                (Object)DBNull.Value : oldPack.AgencyCommission);
            oldPkgAgencyParam.IsNullable = true;
            oldPkgAgencyParam.Direction = ParameterDirection.Input;
            oldPkgAgencyParam.SqlDbType = SqlDbType.Money;
            cmd.Parameters.Add(oldPkgAgencyParam);

            try
            {
                connection.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }

}
