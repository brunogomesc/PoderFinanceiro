using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoderFinanceiro.Services
{
    public class Authentication
    {

        #region User Authentication
        public static bool IsAuthenticateUser(string username, string password)
        {

            if (username == "admin" && password == "admin")
                return true;
            else
                return false;
        }
        #endregion



    }
}
