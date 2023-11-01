using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoderFinanceiro.Model
{
    public class Category
    {

        public Guid Id { get; set; }

        public string NameCategory { get; set; }

        public string NameIconCategory { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

    }
}
