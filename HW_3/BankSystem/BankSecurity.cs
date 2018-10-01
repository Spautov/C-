using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class BankSecurity
    {
        public static bool IsUniquenessLogin(string login, Bank bank)
        {
            for (int i = 0; i < bank.CountClient; ++i )
            {
                if (Equals(bank.clients[i].Login, login))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsReliablePassword(string login)
        {
            if (String.IsNullOrEmpty(login))
            {
                return false;
            }
            if (login.Length<8)
            {
                return false;
            }
            return true;
        }
    }
}
