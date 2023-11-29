using PoderFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PoderFinanceiro.Service
{
    public class Expenses
    {

        public static void SaveExpense(Guid categorySelected, Guid subCategorySelected, string typeExpense, int quantityInstallments, string nameExpense, decimal valueExpense, DateTime expenseDate, string observation)
        {
            Expense expense = new Expense();

            expense.Id = Guid.NewGuid();
            expense.IdCategory = categorySelected;
            expense.IdSubCategory = subCategorySelected;
            expense.TypeExpense = typeExpense;
            expense.QuantityInstallments = quantityInstallments;
            expense.Name = nameExpense;
            expense.Value = valueExpense;
            expense.DateExpense = expenseDate;
            expense.Observation = observation;
            expense.CreatedAt = DateTime.Now;
            expense.UpdatedAt = DateTime.Now;

            DataCommands.Expense.SaveExpense(expense);

        }

    }
}