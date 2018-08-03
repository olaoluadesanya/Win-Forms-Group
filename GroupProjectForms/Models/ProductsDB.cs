using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectForms.Models
{
    /// <summary>
    /// Products DB
    /// Kyle Hinton SAIT 2018
    /// Performs Crud Operation on the Products table in the Travel Experts Database
    /// Minor Edits By Olaoluwa Adesanya
    /// </summary>
    public static class ProductDB
    { 
        
        public static List<Products> GetAllProducts()
        {
            List<Products> products = new List<Products>();
            Products prod = null; ;
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string selectStatement = "SELECT ProductID, ProdName " +
                                     "From Products ORDER By ProductID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader dr = selectCommand.ExecuteReader();
                while (dr.Read())
                {
                    prod = new Products();
                    prod.ProductId = (int)dr["ProductID"];
                    prod.ProdName = (string)dr["ProdName"];
                    prod.Suppliers = Products_SupplierDB.GetUniqueProduct_Suppliers(prod.ProductId);
                    products.Add(prod);

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
            return products;

        }
        /// <summary>
        /// Gets unique product based on passed product ID
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public static List<Products> GetProducts(int productId)
        {
            List<Products> products = new List<Products>();
            Products prod = null; ;
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string selectStatement = "SELECT ProductID, ProdName " +
                                     "From Products " +
                                     "WHERE ProductId = @ProductId " +
                                     "ORDER By ProductID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductId", productId);

            try
            {
                connection.Open();
                SqlDataReader dr = selectCommand.ExecuteReader();
                while (dr.Read())
                {
                    prod = new Products();
                    prod.ProductId = (int)dr["ProductID"];
                    prod.ProdName = (string)dr["ProdName"];
                    products.Add(prod);

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
            return products;

        }
        /// <summary>
        /// Add passed product to products DB
        /// </summary>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static int AddProducts(Products prod)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string insertStatement = "INSERT INTO Products (ProdName) " +
                                     "VALUES(@ProdName)";
            SqlCommand cmd = new SqlCommand(insertStatement, connection);
            cmd.Parameters.AddWithValue("@ProdName", prod.ProdName);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery(); // run the insert command
                                       // get the generated ID - current identity value for  Products table
                string selectQuery = "SELECT IDENT_CURRENT('Products') FROM Products";
                SqlCommand selectCmd = new SqlCommand(selectQuery, connection);
                int ProductID = Convert.ToInt32(selectCmd.ExecuteScalar()); // single value
                                                                            // typecase (int) does NOT work!
                return ProductID;
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
/// Delete passed products from datatabse
/// </summary>
/// <param name="prod"></param>
/// <returns></returns>
        public static bool DeleteProduct(Products prod)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string deleteStatement = "delete Products_Suppliers from Products_Suppliers " +
                                     "inner join Products on Products_Suppliers.ProductId = Products.ProductId " +
                                     "inner join Suppliers on Products_Suppliers.SupplierId = Suppliers.SupplierId " +
                                     "where Products.ProductId = @ProductId " +
                                     //first part deletes the link to product supplier table if it exists
                                     //second part deltes the actual product
                                     "delete from Products " +
                                     "where ProductId = @ProductId " +
                                     "and ProdName = @ProdName";


            SqlCommand cmd = new SqlCommand(deleteStatement, connection);
            cmd.Parameters.AddWithValue("@ProductID", prod.ProductId);
            cmd.Parameters.AddWithValue("@ProdName", prod.ProdName);

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
        /// Updates existing product
        /// </summary>
        /// <param name="oldProd">data before update</param>
        /// <param name="newrod">new data for the update</param>
        /// <returns>indicator of success</returns>
        public static bool UpdateProduct(Products oldProd, Products newProd)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string updateStatement = "UPDATE Products " +
                                     "SET ProdName = @NewProdName " +
                                     "WHERE ProductID = @OldProdID " +
                                     "AND ProdName = @OldProdName";  // remaining conditions - to ensure optimistic concurrency
            SqlCommand cmd = new SqlCommand(updateStatement, connection);
            cmd.Parameters.AddWithValue("@NewProdName", newProd.ProdName);
            cmd.Parameters.AddWithValue("@OldProdID", oldProd.ProductId);
            cmd.Parameters.AddWithValue("@OldProdName", oldProd.ProdName);

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
