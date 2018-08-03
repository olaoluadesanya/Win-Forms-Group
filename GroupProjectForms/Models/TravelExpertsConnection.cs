using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectForms.Models
{
    /// <summary>
    /// TravelExpertsConnection
    /// Kyle Hinton SAIT 2018
    /// Gets a connection to the Travel Experts Database
    /// </summary>
    public static class TravelExpertConnect
    {

        //Connection object
        //Returns the sql connection object
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            return con;
        }
    }

}
