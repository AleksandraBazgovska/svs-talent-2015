using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;

namespace CSharpProgrammingBasics.Classes.Processors
{
    public class TransactionProcessor : ITransactionProcessor
    {
        /// <summary>
        /// Metod koj go pretstavuva procesot na transfer na pari od edna na druga smetka spored tipot na transakcijata
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="currencyAmount"></param>
        /// <param name="accountFrom"></param>
        /// <param name="accountTo"></param>
        /// <returns></returns>
        public TransactionStatus processTransaction(TransactionType transactionType, CurrencyAmount currencyAmount, IAccount accountFrom, IAccount accountTo)
        {
            switch (transactionType)
            {
                case TransactionType.Credit:
                    {
                       return accountFrom.CreditAmount(currencyAmount);
                        
                    }
                case TransactionType.Debit:
                    {
                       return accountFrom.DebitAmount(currencyAmount);
                      
                    }

                case TransactionType.Transfer:
                    {
                        if(accountFrom.DebitAmount(currencyAmount) == TransactionStatus.Completed && accountTo.CreditAmount(currencyAmount)== TransactionStatus.Completed)
                        {
                            return TransactionStatus.Completed;
                        }
                        else if(accountFrom.DebitAmount(currencyAmount)== TransactionStatus.Failed && accountTo.CreditAmount(currencyAmount)== TransactionStatus.Completed)
                        {
                            accountTo.DebitAmount(currencyAmount);
                            return TransactionStatus.Failed;
                        }
                        else
                            if(accountFrom.DebitAmount(currencyAmount) == TransactionStatus.Completed && accountTo.CreditAmount(currencyAmount) == TransactionStatus.Failed)
                        {
                            accountFrom.CreditAmount(currencyAmount);
                            return TransactionStatus.Failed;
                        }
                          else
                        {
                            return TransactionStatus.Failed;
                        }

                    }
                default:
                    return TransactionStatus.Failed;

                 
            }
           
        }
    }
}
