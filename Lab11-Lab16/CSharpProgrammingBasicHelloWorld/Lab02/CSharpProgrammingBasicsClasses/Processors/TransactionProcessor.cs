using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;
using System.Collections;
using CSharpProgrammingBasics.Classes.Helpers;

namespace CSharpProgrammingBasics.Classes.Processors
{
    public class TransactionProcessor : ITransactionProcessor
    {
        //field za inicijaliziranje na svojstvoto ExternalLogger
        public TransactionLogger externalLogger = null;

        #region Primena na Singleton Pattern
        //Static promenliva 
        private static ITransactionProcessor sTransactinProcessor;

        static  TransactionProcessor()
        {
            sTransactinProcessor = new TransactionProcessor();
            sTransactinProcessor.ExternalLogger += AccountHelper.LogTransaction;
            sTransactinProcessor.ExternalLogger += AccountHelper.NotifyNationalBank;



        }

        /// <summary>
        /// Metod koj vrakja instanca od TransactionProcessor 
        /// </summary>
        /// <returns></returns>

        public static ITransactionProcessor GetTransactionProcessor()
        {
            return sTransactinProcessor;
        }
        #endregion


        //Kolekcija od TransactionLogentry
        public IList<TransactionLogEntry> _transactionLog;


        /// <summary>
        /// LastTRansaction implementacija , ja vrakja poslednata transakcija od _transactionLog listata
        /// </summary>
        public TransactionLogEntry LastTransaction
        {
            get
            {
                if(_transactionLog.Count == 0)
                {
                    return null;
                }
                else
                {
                    return _transactionLog[_transactionLog.Count - 1];
                }
                
            }
        }

        /// <summary>
        /// Broi kolku transakcii se registrirani do sega
        /// </summary>
        public int TransactionCount
        {
            get
            {
                return _transactionLog.Count;
            }
        }

        //Metod koj go povikuva External Logger delegatot 
        private void CallExternalLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            ExternalLogger(account, transactionType, amount);
        }

        /// <summary>
        /// Delegate svojstvo
        /// </summary>
        public  TransactionLogger ExternalLogger
        { 
            get
            {
                return externalLogger;
            }

            set
            {
                externalLogger = value;
            }
        }


        /// <summary>
        /// Indekser vrakja TransactionLogEntry na soodvetna pozicija spored index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public TransactionLogEntry this[int index]
        {
            get
            {
                TransactionLogEntry tmp;

                if(index >=0 && index <= _transactionLog.Count-1)
                {
                    tmp = _transactionLog[index];
                }

                else
                {
                    tmp = null;
                }

                return (tmp);
               
            }
        }



        /// <summary>
        /// Konstruktor bes parametri koj se koristi za inicijaliziranje na listata
        /// </summary>
        private TransactionProcessor()
        {
            _transactionLog = new List<TransactionLogEntry>();
        }


        /// <summary>
        /// Metod koj kreira instanca od tip TransactionLogEnrty i ja dodava vo _transactionLog kolekcijata
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        /// <param name="accounts"></param>
        /// <param name="status"></param>
        private void LogTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts,TransactionStatus status)
        {
            TransactionLogEntry logTransaction = new TransactionLogEntry(transactionType, amount, accounts, status);
            _transactionLog.Add(logTransaction);
        }

        /// <summary>
        /// Metod koj proveruva dali niza od smetki e Credit ili Debit i gi povikuva soodvetnite metodi
        /// Dopolnitelno e vovedena logika da ja registrira sekoja transakcija vo _transactionLog listata
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="amount"></param>
        /// <param name="accounts"></param>
        /// <returns></returns>
        public TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts)
        {
            if(accounts.Length == 0)
            {
                LogTransaction(transactionType, amount, accounts, TransactionStatus.Failed);

                return TransactionStatus.Failed;
            }
            foreach (IAccount item in accounts)
            {
                if(item == null)
                {
                    LogTransaction(transactionType, amount, accounts, TransactionStatus.Failed);

                    return TransactionStatus.Failed;
                }
            }
            //Pomoshna promenliva koj sluzi kako flag da proveruva dali site transakcii pominale ili ne 
            int flag = 0;
            if(transactionType == TransactionType.Credit || transactionType == TransactionType.Debit)
            {
                if (transactionType == TransactionType.Credit)
                {
                    foreach (IAccount item in accounts)
                    {
                     
                        if(item.CreditAmount(amount) == TransactionStatus.Completed)
                        {
                            CallExternalLogger(item, transactionType, amount);
                            flag += 1;
                        }
                        else if(item.CreditAmount(amount) == TransactionStatus.Failed)
                        {
                            CallExternalLogger(item, transactionType, amount);
                        }
                        
                    }

                    if(flag==accounts.Length)//Ako e ispolnet uslovot znaci site transakcii pominale uspeshno
                    {
                        LogTransaction(transactionType, amount, accounts, TransactionStatus.Completed);
                        return TransactionStatus.Completed;
                    }

                    else
                    {
                        Console.WriteLine("Site transakcii ne pominale uspeshno");
                        LogTransaction(transactionType, amount, accounts, TransactionStatus.CompletedWithWarning);
                        return TransactionStatus.Failed;
                    }
                }

                else
                {
                    foreach (IAccount item in accounts)
                    {

                        if (item.DebitAmount(amount) == TransactionStatus.Completed)
                        {
                            CallExternalLogger(item, transactionType, amount);
                            flag += 1;
                        }
                        else if(item.DebitAmount(amount) == TransactionStatus.Failed)
                        {
                            CallExternalLogger(item, transactionType, amount);
                        }

                    }

                    if (flag == accounts.Length)
                    {
                        LogTransaction(transactionType, amount, accounts, TransactionStatus.Completed);
                        return TransactionStatus.Completed;
                    }

                    else
                    {
                        LogTransaction(transactionType, amount, accounts, TransactionStatus.CompletedWithWarning);
                        return TransactionStatus.Failed;
                    }
                }


            }
            else
            {
                return TransactionStatus.Failed;
            }

        }

        /// <summary>
        /// Metod koj go pretstavuva procesot na transfer na pari od edna na druga smetka spored tipot na transakcijata
        /// Dopolnitelno e vovedena logika da ja registrira sekoja transakcija vo _transactionLog listata
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="currencyAmount"></param>
        /// <param name="accountFrom"></param>
        /// <param name="accountTo"></param>
        /// <returns></returns>
        public TransactionStatus ProcessTransaction(TransactionType transactionType, CurrencyAmount currencyAmount, IAccount accountFrom, IAccount accountTo)
        {

            IAccount[] accounts = new IAccount[2];
            accounts[0] = accountFrom;
            accounts[1] = accountTo;
            switch (transactionType)
            {
                case TransactionType.Credit:
                    {
                        LogTransaction(transactionType, currencyAmount, accounts, accountFrom.CreditAmount(currencyAmount));
                        CallExternalLogger(accountFrom, transactionType, currencyAmount);
                        return accountFrom.CreditAmount(currencyAmount);
                        
                    }
                case TransactionType.Debit:
                    {
                        LogTransaction(transactionType, currencyAmount, accounts, accountFrom.DebitAmount(currencyAmount));
                        CallExternalLogger(accountFrom, transactionType, currencyAmount);

                        return accountFrom.DebitAmount(currencyAmount);
                      
                    }

                case TransactionType.Transfer:
                    {
                        if(accountFrom.DebitAmount(currencyAmount) == TransactionStatus.Completed && accountTo.CreditAmount(currencyAmount)== TransactionStatus.Completed)
                        {
                            CallExternalLogger(accountFrom, transactionType, currencyAmount);
                            CallExternalLogger(accountTo, transactionType, currencyAmount);

                            LogTransaction(transactionType, currencyAmount, accounts, TransactionStatus.Completed);

                            return TransactionStatus.Completed;
                        }
                        else if(accountFrom.DebitAmount(currencyAmount)== TransactionStatus.Failed && accountTo.CreditAmount(currencyAmount)== TransactionStatus.Completed)
                        {
                            accountTo.DebitAmount(currencyAmount);
                            CallExternalLogger(accountFrom, transactionType, currencyAmount);
                            CallExternalLogger(accountTo, transactionType, currencyAmount);

                            LogTransaction(transactionType, currencyAmount, accounts, TransactionStatus.Failed);
                            return TransactionStatus.Failed;
                        }
                        else
                            if(accountFrom.DebitAmount(currencyAmount) == TransactionStatus.Completed && accountTo.CreditAmount(currencyAmount) == TransactionStatus.Failed)
                        {
                            accountFrom.CreditAmount(currencyAmount);
                            CallExternalLogger(accountFrom, transactionType, currencyAmount);
                            CallExternalLogger(accountTo, transactionType, currencyAmount);

                            LogTransaction(transactionType, currencyAmount, accounts, TransactionStatus.Failed);
                            return TransactionStatus.Failed;
                        }
                          else
                        {
                            LogTransaction(transactionType, currencyAmount, accounts, TransactionStatus.Failed);
                            return TransactionStatus.Failed;
                        }

                    }
                default:
                    LogTransaction(transactionType, currencyAmount, accounts, TransactionStatus.Failed);
                    return TransactionStatus.Failed;

                 
            }
           
        }

        public TransactionStatus ChargeProcessingFee(ITransactionProcessor processor, CurrencyAmount amount, IEnumerable<IAccount> accounts)
        {
            throw new NotImplementedException();
        }
    }
}
