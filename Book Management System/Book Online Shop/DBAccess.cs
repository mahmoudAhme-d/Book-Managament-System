using System;
using System.Data;
using System.Data.SqlClient;

namespace Book_Online_Shop
{
    internal class DBAccess
    {
        private readonly string connectionString;
        private SqlConnection conn;

        public DBAccess()
        {
            connectionString = "server=.;Database=Book Store app;Integrated Security=True;";
            conn = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddRange(parameters);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            int affectedRows = 0;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddRange(parameters);
                    affectedRows = command.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
            return affectedRows;
        }
    }
}
