using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PoderFinanceiro.Model
{
    public class Expense
    {

        public Guid Id { get; set; }

        public Guid IdCategory { get; set; }

        public Guid IdSubCategory { get; set; }

        public string TypeExpense { get; set; }

        public int QuantityInstallments { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }

        public DateTime DateExpense { get; set; }

        public string Observation { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

    }
}