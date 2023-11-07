using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoderFinanceiro.Model
{
    public class SubCategory
    {

        public Guid Id { get; set; }

        public Guid IdCategory { get; set; }

        public string NameSubCategory { get; set; }

        public string NameIconSubCategory { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

    }
}
