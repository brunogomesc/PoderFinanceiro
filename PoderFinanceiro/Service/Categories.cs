using PoderFinanceiro.Data;
using PoderFinanceiro.Model;
using PoderFinanceiro.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoderFinanceiro.Service
{
    public class Categories
    {

        public static void SaveCategory(string nameCategory, string nameIconCatregory)
        {
            Category category = new Category();

            category.Id = Guid.NewGuid();
            category.NameCategory = nameCategory;
            category.NameIconCategory = nameIconCatregory;
            category.CreatedAt = DateTime.Now;
            category.UpdatedAt = DateTime.Now;

            DataCommands.Category.SaveCategory(category);

        }

        public static List<Category> GetAllCategories()
        {
            DataTable categoriesDt = new DataTable();
            List<Category> categories = new List<Category>();

            categoriesDt = DataCommands.Category.GetAllCategories();

            categories = Converter.ConvertToList<Category>(categoriesDt);

            return categories;
        }

    }
}
