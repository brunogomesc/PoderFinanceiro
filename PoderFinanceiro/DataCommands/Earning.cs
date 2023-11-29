using PoderFinanceiro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoderFinanceiro.DataCommands
{
    public class Earning
    {

        public static void SaveEarning(Model.Earning earning)
        {
            try
            {
                using (var cmd = DataAccess.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO earning(id, IdCategory, IdSubCategory, TypeEarning, Name, Value, DateEarning, Observation, CreatedAt, UpdatedAt)" +
                       "values (@id, @IdCategory, @IdSubCategory, @TypeEarning, @Name, @Value, @DateEarning, @Observation, @CreatedAt, @UpdatedAt)";
                    cmd.Parameters.AddWithValue("@id", earning.Id);
                    cmd.Parameters.AddWithValue("@IdCategory", earning.IdCategory);
                    cmd.Parameters.AddWithValue("@IdSubCategory", earning.IdSubCategory);
                    cmd.Parameters.AddWithValue("@TypeEarning", earning.TypeEarning);
                    cmd.Parameters.AddWithValue("@Name", earning.Name);
                    cmd.Parameters.AddWithValue("@Value", earning.Value);
                    cmd.Parameters.AddWithValue("@DateEarning", earning.DateEarning);
                    cmd.Parameters.AddWithValue("@Observation", earning.Observation);
                    cmd.Parameters.AddWithValue("@CreatedAt", earning.CreatedAt);
                    cmd.Parameters.AddWithValue("@UpdatedAt", earning.UpdatedAt);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
