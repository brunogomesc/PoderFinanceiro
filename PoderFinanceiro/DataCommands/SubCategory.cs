using PoderFinanceiro.Data;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoderFinanceiro.Model;

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
                    cmd.CommandText = "INSERT INTO subcategory(id, IdCategory, NameSubCategory, NameIconSubCategory, CreatedAt, UpdatedAt) " +
                        "values (@id, @idCategory, @nameSubCategory, @nameIconSubCategory, @createdAt, @updatedAt)";
                    cmd.Parameters.AddWithValue("@id", subcategory.Id);
                    cmd.Parameters.AddWithValue("@idCategory", subcategory.IdCategory);
                    cmd.Parameters.AddWithValue("@nameSubCategory", subcategory.NameSubCategory);
                    cmd.Parameters.AddWithValue("@nameIconSubCategory", subcategory.NameIconSubCategory);
                    cmd.Parameters.AddWithValue("@createdAt", subcategory.CreatedAt);
                    cmd.Parameters.AddWithValue("@updatedAt", subcategory.UpdatedAt);
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
