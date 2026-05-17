using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gorselodev
{
    internal class DbManager
    {
       
        private static string _connectionString = @"Server=.\SQLEXPRESS;Database=NetflixDB;Trusted_Connection=True;TrustServerCertificate=True;";

        // Bu metod bize her seferinde açık/hazır bir bağlantı nesnesi dönecek
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
