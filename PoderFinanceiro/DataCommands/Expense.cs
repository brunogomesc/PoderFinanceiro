using PoderFinanceiro.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PoderFinanceiro.DataCommands
{
    public class Expense
    {

        public static void SaveExpense(Model.Expense expense)
        {
            try
            {
                using (var cmd = DataAccess.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO expense(id, IdCategory, IdSubCategory, TypeEarning, QuantityInstallments, Name, Value, DateEarning, Observation, CreatedAt, UpdatedAt)" +
                       "values (@id, @IdCategory, @IdSubCategory, @TypeEarning, @QuantityInstallments, @Name, @Value, @DateEarning, @Observation, @CreatedAt, @UpdatedAt)";
                    cmd.Parameters.AddWithValue("@id", expense.Id);
                    cmd.Parameters.AddWithValue("@IdCategory", expense.IdCategory);
                    cmd.Parameters.AddWithValue("@IdSubCategory", expense.IdSubCategory);
                    cmd.Parameters.AddWithValue("@TypeEarning", expense.TypeExpense);
                    cmd.Parameters.AddWithValue("@QuantityInstallments", expense.QuantityInstallments);
                    cmd.Parameters.AddWithValue("@Name", expense.Name);
                    cmd.Parameters.AddWithValue("@Value", expense.Value);
                    cmd.Parameters.AddWithValue("@DateEarning", expense.DateExpense);
                    cmd.Parameters.AddWithValue("@Observation", expense.Observation);
                    cmd.Parameters.AddWithValue("@CreatedAt", expense.CreatedAt);
                    cmd.Parameters.AddWithValue("@UpdatedAt", expense.UpdatedAt);
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