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
    public class SubCategories
    {

        public static void SaveCategory(string nameSubCategory, string nameIconSubCatregory)
        {
            SubCategory subcategory = new SubCategory();

            subcategory.Id = Guid.NewGuid();
            subcategory.NameSubCategory = nameSubCategory;
            subcategory.NameIconSubCategory = nameIconSubCatregory;
            subcategory.CreatedAt = DateTime.Now;
            subcategory.UpdatedAt = DateTime.Now;

            DataCommands.SubCategory.SaveSubCategory(subcategory);

        }

        public static List<SubCategory> GetAllSubCategories()
        {
            DataTable categoriesDt = new DataTable();
            List<SubCategory> categories = new List<SubCategory>();

            categoriesDt = DataCommands.Category.GetAllCategories();

            categories = Converter.ConvertToList<SubCategory>(categoriesDt);

            return categories;
        }

    }
}
