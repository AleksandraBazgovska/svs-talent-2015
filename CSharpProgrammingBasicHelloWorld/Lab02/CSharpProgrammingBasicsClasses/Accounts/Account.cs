using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpProgrammingBasics.Classes.Interfaces;
using CSharpProgrammingBasics.Classes.Common;


namespace CSharpProgrammingBasics.Classes.Accounts
{
   public class Account : IAccount
    {
        /// <summary>
        /// Definiranje na fields
        /// </summary>
        public long m_Id;
        public string m_Number;
        public string m_Currency;
        public Common.CurrencyAmount m_Balance;
        

        /// <summary>
        /// Definiranje na svojstva za gorenavedenite fields
        /// </summary>
        public long ID
        {
            get { return m_Id; }
           private set { m_Id = value; }
        }
               

        public string Number
        {
            get { return m_Number; }
          private  set { m_Number = value; }
        }


        public string Currency { get; set; } // auto-implemented property for Currency

       
        public Common.CurrencyAmount Balance // Mozno e da se pojavi problem ? 
        {
            get { return m_Balance; }
            set {
                

                m_Balance = value; }
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
            this.Balance = new Common.CurrencyAmount(100000, currency);
        }
        /// <summary>
        /// Definiranje na konstruktor so eden parametar pri shto se povikuva drug konstruktor od istava klasa so this
        /// </summary>
        /// <param name="currency"></param>
        public Account(string currency) : this(-1, "X", currency)
        {
            this.Currency = currency;
            
        }

        /// <summary>
        /// Debitna smetka, namalkuvanje na nejzinata vrednost so daden iznos
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual Common.TransactionStatus DebitAmount(Common.CurrencyAmount amount)
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
                return Common.TransactionStatus.Failed;
            }
        }

        public virtual Common.TransactionStatus CreditAmount(Common.CurrencyAmount amount)
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
                return Common.TransactionStatus.Failed;
            }
        }

        public override string ToString()
        {
            return this.ID + " " + this.Number + " Account"; 
        }




    }
}
