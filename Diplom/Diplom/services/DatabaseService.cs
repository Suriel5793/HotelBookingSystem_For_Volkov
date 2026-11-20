using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Services
{
    public class DatabaseService
    {
        private string _host = "localhost";
        private int _port = 5432;
        private string _username = "postgres";
        private string _password = "nixneris5";
        private string _databaseName = "HotelDB";

        private string MasterConnectionString => $"Host={_host};Port={_port};Username={_username};Password={_password};Database=postgres";
        private string DbConnectionString => $"Host={_host};Port={_port};Username={_username};Password={_password};Database={_databaseName}";
    }

            public bool DatabaseExists()
        {
            try
            {
                using (var conn = new NpgsqlConnection(MasterConnectionString))
                {
                    conn.Open();
                    string sql = "SELECT 1 FROM pg_database WHERE datname = @dbname";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@dbname", _databaseName);
                        return cmd.ExecuteScalar() != null;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public void CreateDatabase()
        {
            using (var conn = new NpgsqlConnection(MasterConnectionString))
            {
                conn.Open();
                string sql = $"CREATE DATABASE {_databaseName}";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
