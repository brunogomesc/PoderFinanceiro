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

        private static void CreateTableCategory()
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

        private static void CreateTableSubCategory()
        {
            try
            {
                using (var cmd = DataAccess.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS subcategory(id UNIQUEIDENTIFIER NOT NULL, IdCategory UNIQUEIDENTIFIER NOT NULL, NameSubCategory Varchar(50), NameIconSubCategory Varchar(80), CreatedAt Datetime, UpdatedAt Datetime)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void CreateTableEarning()
        {
            try
            {
                using (var cmd = DataAccess.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS earning(id UNIQUEIDENTIFIER NOT NULL, IdCategory UNIQUEIDENTIFIER NOT NULL, IdSubCategory UNIQUEIDENTIFIER NOT NULL, TypeEarning Varchar(50), Name Varchar(80), Value decimal, DateEarning Datetime, Observation Varchar(300), CreatedAt Datetime, UpdatedAt Datetime)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void CreateTableExpense()
        {
            try
            {
                using (var cmd = DataAccess.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS expense(id UNIQUEIDENTIFIER NOT NULL, IdCategory UNIQUEIDENTIFIER NOT NULL, IdSubCategory UNIQUEIDENTIFIER NOT NULL, TypeEarning Varchar(50), QuantityInstallments int, Name Varchar(80), Value decimal, DateEarning Datetime, Observation Varchar(300), CreatedAt Datetime, UpdatedAt Datetime)";
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
            CreateTableSubCategory();
            CreateTableEarning();
            CreateTableExpense();
        }

    }
}
