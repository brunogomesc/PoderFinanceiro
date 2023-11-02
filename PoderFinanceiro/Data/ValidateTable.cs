using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoderFinanceiro.Data
{
    public class ValidateTable
    {

        public static void CreateTableCategory()
        {
            try
            {
                using (var cmd = DataAccess.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS category(id UNIQUEIDENTIFIER NOT NULL, NameCategory Varchar(50), NameIconCategory Varchar(80), CreatedAt Datetime, UpdatedAt Datetime)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CreateTables()
        {
            CreateTableCategory();
        }

    }
}
