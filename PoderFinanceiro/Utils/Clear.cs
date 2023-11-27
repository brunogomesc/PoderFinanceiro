using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoderFinanceiro.Utils
{
    public class Clear
    {

        public static string ClearMaskValue(string value)
        {

            string valueFormat = value.Replace("R","").Replace(" ","").Replace("$","").Replace(",",".");

            return valueFormat;

        }

    }
}
