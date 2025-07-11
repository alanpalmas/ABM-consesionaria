using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace ABMConcesionaria
{
    public class ConexionConBD
    {
        private string connectionString = "Data Source=NTBK-TECH1237\\SQLEXPRESS;initial Catalog=Concesionaria;integrated Security=True;TrustServerCertificate=True";

        public DataTable LeerSQL(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void EjecutarSQL(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }

        }

    }

}
    

