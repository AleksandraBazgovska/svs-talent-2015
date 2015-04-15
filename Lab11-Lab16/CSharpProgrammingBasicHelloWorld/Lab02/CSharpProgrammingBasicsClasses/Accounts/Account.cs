using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpProgrammingBasics.Classes.Interfaces;
using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Helpers;



namespace CSharpProgrammingBasics.Classes.Accounts
{
   public abstract class Account : IAccount
    {
        /// <summary>
        /// Definiranje na fields
        /// </summary>
        public long m_Id;
        public string m_Number;
        public string m_Currency;
        public CurrencyAmount m_Balance;

        public event EventHandler<BalanceChangedEventArguments> BalanceChanged = delegate { };

        /// <summary>
        /// Definiranje na svojstva za gorenavedenite fields
        /// </summary>
        public long ID
        {
            get { return m_Id; }
          set { m_Id = value; }
        }
               
        /// <summary>
        /// Upotreba na atribut 
        /// </summary>
        [FormatRestriction (FormatString = "credit card format (XXXX-XXXX-XXXX-XXXX)",MaxLength =16)]
        public string Number
        {
            get { return m_Number; }
          private  set { m_Number = value; }
        }


        public string Currency { get; set; } // auto-implemented property for Currency

       
        public CurrencyAmount Balance 
        {
            get { return m_Balance; }
            set {
             

                if (value.Amount != m_Balance.Amount)
                {
                    m_Balance = value;
                    BalanceChangedEventArguments args = new BalanceChangedEventArguments();
                    args.Account =this;
                    args.Change = new CurrencyAmount(m_Balance.Amount, m_Balance.Currency);
                    BalanceChanged += new EventHandler<BalanceChangedEventArguments>(OnBalanceChange_Handler);
                    OnBalanceChange(args);


                }

                

            }
        }


        /// <summary>
        /// Definiranje na konstruktor so tri parametri
        /// </summary>
        /// <param name="id"></param>
        /// <param name="number"></param>
        /// <param name="currency"></param>
        public Account(long id, string number, string currency)
        {
            this.ID = id;
            this.Number = number;
            this.Currency = currency;
            this.Balance = new CurrencyAmount(10000,currency);
        }
        /// <summary>
        /// Definiranje na konstruktor so eden parametar pri shto se povikuva drug konstruktor od istava klasa so this
        /// </summary>
        /// <param name="currency"></param>
        public Account(string currency) : this(-1, "X", currency)
        {
            this.Currency = currency;
            this.ID = AccountHelper.GenerateAccountId();
            this.Number = GenerateAccountNumber();
        }


        /// <summary>
        /// protected method OnBalanceChange koj proveruva dali e inicijaliziran eventot, ako ne e go povikuva so (this,e) kade (e) e instanca od custom klasata koja nasleduva od EventArgs
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnBalanceChange(BalanceChangedEventArguments e)
        {
         
            if(BalanceChanged != null)
            {
                BalanceChanged(this,e);
                BalanceChanged.Invoke(this, e);
            }
        }

        private static void OnBalanceChange_Handler(object sender, BalanceChangedEventArguments eventArgs)
        {

            Console.WriteLine("Details for the Account " + eventArgs.Account.ToString() + " Change " + eventArgs.Change.Amount + " " + eventArgs.Change.Currency);
            //Environment.Exit(0);
        }

        /// <summary>
        /// Debitna smetka, namalkuvanje na nejzinata vrednost so daden iznos
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual TransactionStatus DebitAmount(Common.CurrencyAmount amount)
        {
            if(Balance.Currency == amount.Currency)
            {
                decimal rez = Balance.Amount - amount.Amount;
                
                if(rez > 0) {
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
                throw new ApplicationException("The amount you want to transact is not with the same currrency as the balance of this account");
                throw new CurrencyMismatchException();
                //return Common.TransactionStatus.Failed;
            }
        }

        public virtual TransactionStatus CreditAmount(Common.CurrencyAmount amount)
        {
            if(Balance.Currency.Equals(amount.Currency))
            {
                decimal rez = Balance.Amount + amount.Amount;
                CurrencyAmount temp = new CurrencyAmount(rez, Balance.Currency);
                Balance = temp;

                return Common.TransactionStatus.Completed;
            }
            else
            {
                throw new ApplicationException("The amount you want to transact is not with the same currrency as the balance of this account");
                throw new CurrencyMismatchException();
                //return Common.TransactionStatus.Failed;
            }
        }

        public override string ToString()
        {
            return this.ID + " " + this.Number + " Account"; 
        }

        protected abstract string GenerateAccountNumber();
        
        



    }
}
