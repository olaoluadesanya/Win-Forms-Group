using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectForms.Models
{
    /// <summary>
    ///  Package Product Supplier DB
    /// Farshid Papaei SAIT 2018
    /// Performs Crud Operation on the Package Product Supplier table in the Travel Experts Database
    /// Minor Edits By Olaoluwa Adesanya
    /// </summary>
    class Packages_Products_SuppliersDB
    {
        /// <summary>
        /// Selects all package products suppliers
        /// </summary>
        /// <returns>A list of existing package products suppliers</returns>
        public static List<Packages_Products_Supplier> GetAllPackages_Product_Suppliers()
        {
            List<Packages_Products_Supplier> packages_Products_Suppliers = new List<Packages_Products_Supplier>();
            Packages_Products_Supplier pack_prod_supp = null; ;
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string selectStatement = "SELECT PkgName, Packages_Products_Suppliers.PackageId, ProductSupplierId " +
                                     "From Packages_Products_Suppliers, Packages " +
                                     "where Packages_Products_Suppliers.PackageId = Packages.PackageId " +
                                     "ORDER BY PkgName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader dr = selectCommand.ExecuteReader();
                while (dr.Read())
                {
                    pack_prod_supp = new Packages_Products_Supplier();
                    pack_prod_supp.PackageId = (int)dr["PackageId"];
                    pack_prod_supp.ProductSupplierId = (int)dr["ProductSupplierId"];
                    packages_Products_Suppliers.Add(pack_prod_supp);

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
            return packages_Products_Suppliers;

        }
/// <summary>
/// Gets packages product suppliers with a specific package ID
/// </summary>
/// <param name="packageId"></param>
/// <returns></returns>
        public static List<Packages_Products_Supplier> GetPackages_Product_Suppliers(int packageId)
        {
            List<Packages_Products_Supplier> packages_Products_Suppliers = new List<Packages_Products_Supplier>();
            Packages_Products_Supplier pack_prod_supp = null; ;
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string selectStatement = "SELECT Packages_Products_Suppliers.PackageId, Products_Suppliers.ProductSupplierId, ProdName, SupName " +
                                     "From Packages_Products_Suppliers, Products_Suppliers, Products, Suppliers " +
                                     "where Packages_Products_Suppliers.PackageId = @PackageId " +
                                     "And Packages_Products_Suppliers.ProductSupplierId = Products_Suppliers.ProductSupplierId " +
                                     "and Products_Suppliers.ProductId = Products.ProductId " +
                                     "and Products_Suppliers.SupplierId = Suppliers.SupplierId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PackageId", packageId);

            try
            {
                connection.Open();
                SqlDataReader dr = selectCommand.ExecuteReader();
                while (dr.Read())
                {
                    pack_prod_supp = new Packages_Products_Supplier();
                    pack_prod_supp.PackageId = (int)dr["PackageId"];
                    pack_prod_supp.ProductSupplierId = (int)dr["ProductSupplierId"];
                    pack_prod_supp.ProdName = dr["ProdName"].ToString();
                    pack_prod_supp.SupName = dr["SupName"].ToString();
                    packages_Products_Suppliers.Add(pack_prod_supp);

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
            return packages_Products_Suppliers;

        }
        /// <summary>
        /// Inserts a new packaage product supplier 
        /// from an existing package and product supplier
        /// </summary>
        /// <param name="pack"></param>
        /// <param name="prod_supp"></param>
        /// <returns>Indicator of success</returns>
        public static bool AddPackages_Products_Supplier(Package pack, Products_Supplier prod_supp)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string insertStatement = "INSERT INTO Packages_Products_Suppliers(PackageId, ProductSupplierId) " +
                                     "VALUES(@PackageId, @ProductSupplierId)";
            SqlCommand cmd = new SqlCommand(insertStatement, connection);
            cmd.Parameters.AddWithValue("@PackageId", pack.PackageId);
            cmd.Parameters.AddWithValue("@ProductSupplierId", prod_supp.ProductSupplierId);

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
        /// Deletes a package product supplier
        /// </summary>
        /// <param name="pack_prod_supp"></param>
        /// <returns>Indicator of success</returns>
        public static bool DeletePackages_Products_Supplier(Packages_Products_Supplier pack_prod_supp)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string deleteStatement = "DELETE FROM Packages_Products_Suppliers " +
                                     "WHERE PackageId = @PackageId " + // to identify the product to be  deleted
                                     "AND ProductSupplierId = @ProductSupplierId"; 


            SqlCommand cmd = new SqlCommand(deleteStatement, connection);
            cmd.Parameters.AddWithValue("@ProductSupplierId", pack_prod_supp.ProductSupplierId);
            cmd.Parameters.AddWithValue("@PackageId", pack_prod_supp.PackageId);

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
        /// Updates existing package_product_supplier
        /// </summary>
        /// <param name="oldPackProdSupp">data before update</param>
        /// <param name="newPackProdSupp">new data for the update</param>
        /// <returns>indicator of success</returns>
        public static bool UpdateSupplier(Packages_Products_Supplier oldPackProdSupp, Packages_Products_Supplier newPackProdSupp)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string updateStatement = "UPDATE Packages_Products_Suppliers " +
                                     "SET PackageId = @NewPackageId, " +
                                         "ProductSupplierId = @NewProductSupplierId " +
                                     "WHERE PackageId = @OldPackageId " +
                                     "AND ProductSupplierId = @OldProductSupplierId";
            SqlCommand cmd = new SqlCommand(updateStatement, connection);
            cmd.Parameters.AddWithValue("@NewProductSupplierId", newPackProdSupp.ProductSupplierId);
            cmd.Parameters.AddWithValue("@NewPackageId", newPackProdSupp.PackageId);
            cmd.Parameters.AddWithValue("@OldProductSupplierId", oldPackProdSupp.ProductSupplierId);
            cmd.Parameters.AddWithValue("@OldPackageId", oldPackProdSupp.PackageId);

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
