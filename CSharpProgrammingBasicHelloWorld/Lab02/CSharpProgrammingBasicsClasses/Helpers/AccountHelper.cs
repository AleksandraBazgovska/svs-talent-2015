using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpProgrammingBasics.Classes.Accounts;

namespace CSharpProgrammingBasics.Classes.Helpers
{
   public static class AccountHelper
    {

        private static int s_AccountId;

       static AccountHelper()
        {
            s_AccountId = 0;
        }

        /// <summary>
        /// Generate Account ID metod za generiranje na ID za smetka
        /// </summary>
        /// <returns></returns>
        public static int  GenerateAccountId()
        {
            return s_AccountId++;
        }

        public static string GenerateAccountNumber(Type accountType,long accountId)
        {
            if (accountType == typeof(TransactionAccount))
            {

                return "TR" + (0000 + accountId);
            }

            else if (accountType == typeof(DepositAccount))
            {

                return "DP" + (0000 + accountId);
            }
            else if (accountType == typeof(LoanAccount))
            {

                return "LN" + (0000 + accountId);
            }
            else
                return "";
        }
    }
}
