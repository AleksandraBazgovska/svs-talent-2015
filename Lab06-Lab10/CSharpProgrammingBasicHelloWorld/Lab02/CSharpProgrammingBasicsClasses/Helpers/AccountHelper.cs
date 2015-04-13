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
        //promenliva za Id na Account 
        private static int s_AccountId;

        //Static konstruktor
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

        /// <summary>
        /// Static metod za generiranje na Account Number
        /// </summary>
        /// <param name="accountType"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static string GenerateAccountNumber(Type accountType,long accountId)
        {
            if (accountType == typeof(TransactionAccount))
            {

                return "TR" + accountId.ToString("D6");
            }

            else if (accountType == typeof(DepositAccount))
            {

                return "DP" + accountId.ToString("D6");
            }
            else if (accountType == typeof(LoanAccount))
            {

                return "LN" + accountId.ToString("D6");
            }
            else
                return "";
        }
    }
}
