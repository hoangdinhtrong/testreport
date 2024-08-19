using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace testreport.DAL
{
    public class DataProvider
    {
        private static volatile DataProvider _instance;
        private static readonly object lockObject = new object();

        private string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private DataProvider() { }

        public static DataProvider GetInstance()
        {
            if (_instance == null)
            {
                lock (lockObject)
                {
                    if (_instance == null)
                    {
                        var random = new Random();

                        _instance = new DataProvider();
                    }
                }
            }
            return _instance;
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    command.Parameters.AddRange(parameter);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    command.Parameters.AddRange(parameter);
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, SqlParameter[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    command.Parameters.AddRange(parameter);
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
