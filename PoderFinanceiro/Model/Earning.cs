using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoderFinanceiro.Model
{
    public class Earning
    {

        public Guid Id { get; set; }

        public Guid IdCategory { get; set; }

        public Guid IdSubCategory { get; set; }

        public string TypeEarning { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }

        public DateTime DateEarning { get; set; }

        public string Observation { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

    }
}
