using PoderFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoderFinanceiro.Service
{
    public class Earnings
    {

        public static void SaveEarning(Guid categorySelected, Guid subCategorySelected, string typeEarning, string nameEarning, decimal valueEarning, DateTime earningDate, string observation)
        {
            Earning earning = new Earning();

            earning.Id = Guid.NewGuid();
            earning.IdCategory = categorySelected;
            earning.IdSubCategory = subCategorySelected;
            earning.TypeEarning = typeEarning;
            earning.Name = nameEarning;
            earning.Value = valueEarning;
            earning.DateEarning = earningDate;
            earning.Observation = observation;
            earning.CreatedAt = DateTime.Now;
            earning.UpdatedAt = DateTime.Now;

            DataCommands.Earning.SaveEarning(earning);

        }

    }
}
