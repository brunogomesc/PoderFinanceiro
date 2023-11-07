using PoderFinanceiro.Data;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoderFinanceiro.DataCommands
{
    public class SubCategory
    {

        public static void SaveSubCategory(Model.SubCategory subcategory)
        {
            try
            {
                using (var cmd = DataAccess.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO category(id, NameCategory, NameIconCategory, CreatedAt, UpdatedAt ) " +
                        "values (@id, @nameCategory, @nameIconCategory, @createdAt, @updatedAt)";
                    cmd.Parameters.AddWithValue("@id", category.Id);
                    cmd.Parameters.AddWithValue("@nameCategory", category.NameCategory);
                    cmd.Parameters.AddWithValue("@nameIconCategory", category.NameIconCategory);
                    cmd.Parameters.AddWithValue("@createdAt", category.CreatedAt);
                    cmd.Parameters.AddWithValue("@updatedAt", category.UpdatedAt);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetAllSubCategories()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DataAccess.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM subcategory";
                    da = new SQLiteDataAdapter(cmd.CommandText, DataAccess.DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
