using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectForms.Models
{
    /// <summary>
    /// Supplier DB
    /// Josh McNabb SAIT 2018
    /// Performs Crud Operation on the Supplier table in the Travel Experts Database
    /// Edits By Olaoluwa Adesanya
    /// </summary>
    public static class SuppliersDB
    {
        public static List<Suppliers> GetAllSuppliers()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            Suppliers supp = null; ;
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string selectStatement = "SELECT SupplierID, SupName " +
                                     "From Suppliers ORDER By SupplierID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader dr = selectCommand.ExecuteReader();
                while (dr.Read())
                {
                    supp = new Suppliers();
                    supp.SupplierId = (int)dr["SupplierID"];
                    supp.SupName = (string)dr["SupName"];
                    suppliers.Add(supp);

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
            return suppliers;

        }


        /// <summary>
        /// Add passed  supplier to DB
        /// </summary>
        /// <param name="supp"></param>
        /// <returns></returns>
        public static bool AddSuppliers(Suppliers supp)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string insertStatement = "INSERT INTO Suppliers (SupplierId, SupName) " +
                                     "VALUES(@SupplierId, @SupName)";
            SqlCommand cmd = new SqlCommand(insertStatement, connection);
            cmd.Parameters.AddWithValue("@SupplierId", supp.SupplierId);
            cmd.Parameters.AddWithValue("@SupName", supp.SupName);


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
        /// Delete PAssed Supplier from DB
        /// </summary>
        /// <param name="supp"></param>
        /// <returns></returns>
        public static bool DeleteSupplier(Suppliers supp)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string deleteStatement = "delete Products_Suppliers from Products_Suppliers " +
                                     "inner join Suppliers on Products_Suppliers.SupplierId = Suppliers.SupplierId " +
                                     "inner join Products on Products_Suppliers.ProductId = Products.ProductId " +                                   
                                     "where Suppliers.SupplierId = @SupplierId " +
                                     //first part deletes the link to product supplier table if it exists
                                     //Second part deletes the actual supplier
                                     "DELETE FROM Suppliers " +
                                     "WHERE SupplierId = @SupplierId " + // to identify the supplier to be  deleted
                                     "AND SupName = @SupName"; // remaining conditions - to ensure optimistic concurrency


            SqlCommand cmd = new SqlCommand(deleteStatement, connection);
            cmd.Parameters.AddWithValue("@SupplierId", supp.SupplierId);
            cmd.Parameters.AddWithValue("@SupName", supp.SupName);

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
        public static bool UpdateSupplier(Suppliers oldSup, Suppliers newSup)
        {
            SqlConnection connection = TravelExpertConnect.GetConnection();
            string updateStatement = "UPDATE Suppliers " +
                                     "SET SupName = @NewSupName " +
                                     "WHERE SupplierID = @OldSupID " +
                                     "AND SupName = @OldSupName";  // remaining conditions - to ensure optimistic concurrency
            SqlCommand cmd = new SqlCommand(updateStatement, connection);
            cmd.Parameters.AddWithValue("@NewSupName", newSup.SupName);
            cmd.Parameters.AddWithValue("@OldSupID", oldSup.SupplierId);
            cmd.Parameters.AddWithValue("@OldSupName", oldSup.SupName);

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
