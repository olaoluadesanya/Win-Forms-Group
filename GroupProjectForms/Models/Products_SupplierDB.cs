using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectForms.Models
{
    /// <summary>
    /// Products_Suppliers DB
    /// Josh McNabb SAIT 2018
    /// Performs Crud Operation on the Product_Suppliers table in the Travel Experts Database
    /// Edits By Olaoluwa Adesanya
    /// </summary>
    class Products_SupplierDB
    {
        /// <summary>
        /// Gets all products suppliers and returns a list
        /// </summary>
        /// <returns></returns>
        public static List<Products_Supplier> GetAllProduct_Suppliers()
        {
            List<Products_Supplier> products_Suppliers = new List<Products_Supplier>();
            Products_Supplier prod_supp = null; ;
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string selectStatement = "SELECT ProductSupplierId, Products_Suppliers.SupplierId, Products_Suppliers.ProductId, SupName, ProdName " +
                                     "From Products_Suppliers, Suppliers, Products " +
                                     "Where Products_Suppliers.ProductId = Products.ProductId " +
                                     "AND Products_Suppliers.SupplierId = Suppliers.SupplierId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader dr = selectCommand.ExecuteReader();
                while (dr.Read())
                {
                    prod_supp = new Products_Supplier();
                    prod_supp.ProductSupplierId = (int)dr["ProductSupplierId"];
                    prod_supp.SupplierId = (int)dr["SupplierId"];
                    prod_supp.ProductId = (int)dr["ProductId"];
                    prod_supp.ProdName = dr["ProdName"].ToString();
                    prod_supp.SupName = dr["SupName"].ToString();
                    products_Suppliers.Add(prod_supp);

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
            return products_Suppliers;

        }

        /// <summary>
        /// Get unique products suppliers with passed product supplier ID
        /// </summary>
        /// <param name="prodId"></param>
        /// <returns></returns>
        public static List<Products_Supplier> GetUniqueProduct_Suppliers(int prodId)
        {
            List<Products_Supplier> products_Suppliers = new List<Products_Supplier>();
            Products_Supplier prod_supp = null; ;
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string selectStatement = "select SupName, Products_Suppliers.SupplierId, ProductSupplierId " +
                                     "from Products_Suppliers, Suppliers " +
                                     "where ProductId = @ProdId " +
                                     "and Suppliers.SupplierId = Products_Suppliers.SupplierId " +
                                     "order by SupName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProdId", prodId);

            try
            {
                connection.Open();
                SqlDataReader dr = selectCommand.ExecuteReader();
                while (dr.Read())
                {
                    prod_supp = new Products_Supplier();
                    prod_supp.ProductSupplierId = (int)dr["ProductSupplierId"];
                    prod_supp.SupplierId = (int)dr["SupplierId"];
                    prod_supp.SupName = dr["SupName"].ToString();
                    products_Suppliers.Add(prod_supp);

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
            return products_Suppliers;

        }
        /// <summary>
        /// Add product Suppliier by linking a passed products and supplier ID
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="supp"></param>
        /// <returns></returns>
        public static int AddProduct_Supplier(Products prod, Suppliers supp)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string insertStatement = "INSERT INTO Products_Suppliers (ProductId, SupplierId) " +
                                     "VALUES(@ProductId, @SupplierId)";
            SqlCommand cmd = new SqlCommand(insertStatement, connection);
            cmd.Parameters.AddWithValue("@ProductId", prod.ProductId);
            cmd.Parameters.AddWithValue("@SupplierId", supp.SupplierId);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery(); // run the insert command
                                       // get the generated ID - current identity value for  Products_Supplier table
                string selectQuery = "SELECT IDENT_CURRENT('Products_Suppliers') FROM Products_Suppliers";
                SqlCommand selectCmd = new SqlCommand(selectQuery, connection);
                int ProductSupplierId = Convert.ToInt32(selectCmd.ExecuteScalar()); // single value
                                                                             // typecase (int) does NOT work!
                return ProductSupplierId;
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
        /// Delete Product Supplier
        /// </summary>
        /// <param name="prod_supp"></param>
        /// <returns></returns>
        public static bool DeleteProdSupplier(Products_Supplier prod_supp)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string deleteStatement = "DELETE FROM Products_Suppliers " +
                                     "WHERE ProductSupplierId = @ProductSupplierId " + // to identify the product to be  deleted
                                     "AND SupplierId = @SupplierId " +
                                     "AND ProductId = @ProductId "; // remaining conditions - to ensure optimistic concurrency


            SqlCommand cmd = new SqlCommand(deleteStatement, connection);
            cmd.Parameters.AddWithValue("@ProductSupplierId", prod_supp.ProductSupplierId);
            cmd.Parameters.AddWithValue("@SupplierId", prod_supp.SupplierId);
            cmd.Parameters.AddWithValue("@ProductId", prod_supp.ProductId);

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
        /// Updates existing supplier
        /// </summary>
        /// <param name="oldSup">data before update</param>
        /// <param name="newSup">new data for the update</param>
        /// <returns>indicator of success</returns>
        public static bool UpdateSupplier(Products_Supplier oldProdSupp, Products_Supplier newProdSupp)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string updateStatement = "UPDATE Products_Suppliers " +
                                     "SET SupplierId = @NewSupplierId, " +
                                         "ProductId = @NewProductId " +
                                     "WHERE ProductSupplierId = @OldProductSupplierId" +
                                     "AND SupplierId = @OldSupplierId " +
                                     "AND ProductId = @OldProductId";  // remaining conditions - to ensure optimistic concurrency
            SqlCommand cmd = new SqlCommand(updateStatement, connection);
            cmd.Parameters.AddWithValue("@NewSupplierId", newProdSupp.SupplierId);
            cmd.Parameters.AddWithValue("@NewProductId", newProdSupp.ProductId);
            cmd.Parameters.AddWithValue("@OldProductSupplierId", oldProdSupp.ProductSupplierId);
            cmd.Parameters.AddWithValue("@OldProductId", oldProdSupp.ProductId);
            cmd.Parameters.AddWithValue("@OldSupplierId", oldProdSupp.SupplierId);

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
