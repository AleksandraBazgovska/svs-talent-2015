using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Helpers;
using CSharpProgrammingBasics.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Accounts
{
    [AccountMetadata]
    public sealed class LoanAccount : DepositAccount, ILoanAccount
    {
      
        /// <summary>
        /// Konstruktor koj gi prima soodvetnite parametri za da go povika konstruktorot na Deposit Account klasata 
        /// </summary>
        /// <param name="valuta"></param>
        /// <param name="timePeriod"></param>
        /// <param name="interestRate"></param>
        /// <param name="stratDate"></param>
        /// <param name="endDate"></param>
        /// <param name="account"></param>
        public LoanAccount(string valuta, TimePeriod timePeriod, InterestRate interestRate, DateTime stratDate, DateTime endDate, ITransactionAccount account) : base(valuta,timePeriod,interestRate,stratDate,endDate,account)
        {

        }

        
        /// <summary>
        /// Override na metodot CreditAmount pri shto vo ovoj sliucaj ima obratno svojstvo ( ja namaluva Balance)
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>

        public override TransactionStatus CreditAmount(CurrencyAmount amount)
        {
            if (Balance.Currency.Equals(amount.Currency))
            {
                decimal rez = Balance.Amount - amount.Amount;

                if (rez > 0)
                {
                    CurrencyAmount temp = new CurrencyAmount(rez, Balance.Currency);
                    Balance = temp;

                    return Common.TransactionStatus.Completed;
                }
                else
                {
                   return Common.TransactionStatus.Failed;
                }
            }
            else
            {
                return Common.TransactionStatus.Failed;
            }
        }

        /// <summary>
        /// Override na DebitAmount metodot pri shto  vo ovj slucaj ima obratno svojstvo go zgolemuva Balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override TransactionStatus DebitAmount(CurrencyAmount amount)
        {
            if (Balance.Currency == amount.Currency)
            {
                decimal rez = Balance.Amount + amount.Amount;
                             
                
                    CurrencyAmount temp = new CurrencyAmount(rez, Balance.Currency);
                    Balance = temp;
                    
                    return Common.TransactionStatus.Completed;

           }
            else
            {
                return Common.TransactionStatus.Failed;
            }
        }

        protected override string GenerateAccountNumber()
        {
            return AccountHelper.GenerateAccountNumber<LoanAccount>(ID);
        }
    }
}
