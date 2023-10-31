using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoderFinanceiro.Data
{
    public static class DataAccess
    {

        private static SQLiteConnection _connection;
        private static string db = "PoderFinanceiroDB.sqlite";

        private static SQLiteConnection DbConnection()
        {
            _connection = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\{db}; Version=3;");
            _connection.Open();
            return _connection;
        }

        public static void CreateDatabaseSqlite()
        {
            try
            {
                SQLiteConnection.CreateFile($"{Directory.GetCurrentDirectory()}\\{db}");
            }
            catch
            {
                throw;
            }
        }

    }
}
