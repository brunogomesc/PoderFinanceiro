using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoderFinanceiro.Service
{
    public class Earnings
    {

        public static void SaveEarning(string nameCategory, string nameIconCatregory)
        {
            Ear category = new Category();

            category.Id = Guid.NewGuid();
            category.NameCategory = nameCategory;
            category.NameIconCategory = nameIconCatregory;
            category.CreatedAt = DateTime.Now;
            category.UpdatedAt = DateTime.Now;

            DataCommands.Category.SaveCategory(category);

        }

    }
}
