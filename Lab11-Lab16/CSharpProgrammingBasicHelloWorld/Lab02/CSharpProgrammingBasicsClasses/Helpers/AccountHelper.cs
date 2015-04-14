using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpProgrammingBasics.Classes.Accounts;
using CSharpProgrammingBasics.Classes.Interfaces;
using CSharpProgrammingBasics.Classes.Common;

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

        /// <summary>
        /// Generichki metod za generiranje na AccountNumber
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public static string GenerateAccountNumber<T>(long accountID) where T : IAccount
        {
            Type typeParametar = typeof(T);
            return GenerateAccountNumber(typeParametar, accountID);
        }

        /// <summary>
        /// Metod koj se povikuva dokolku sumata na transakcija e pogolema od 20 000 MKD
        /// </summary>
        /// <param name="account"></param>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        public static void LogTransaction(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            if(amount.Amount >= 20000 && amount.Currency == "MKD")
            {
                Console.WriteLine("Account number " + account.Number + " Transaction type " + transactionType);
                Console.WriteLine("Amount " + amount.Amount + " Amount currency " + amount.Currency);
            }
        }

        public static void NotifyNationalBank(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            if (amount.Amount >= 25000 && amount.Currency == "MKD")
            {
                Console.WriteLine("Notification for transaction which exceeds 250000 MKD");
            }
        }


    }
}
