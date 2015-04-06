using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpProgrammingBasics.Classes.Interfaces;
using CSharpProgrammingBasics.Classes.Helpers;

namespace CSharpProgrammingBasics.Classes.Accounts
{
  public class TransactionAccount : Account, ITransactionAccount
    {
        /// <summary>
        /// Definiranje na field i svojstvo Limit od tip CurrencyAmount
        /// </summary>
        public Common.CurrencyAmount m_Limit;
        
        public Common.CurrencyAmount Limit
        {
            get { return m_Limit; }
            set { m_Limit = value; }
        }

        /// <summary>
        /// Definiranje na konstruktor
        /// </summary>
        /// <param name="currency"></param>
        /// <param name="limitAmount"></param>
        public TransactionAccount(string currency, decimal limitAmount) : base(currency)
        {
            this.Limit = new Common.CurrencyAmount(limitAmount, currency);
        }

        public override string ToString()
        {
            return this.ID + " " + this.Number + "  Transaction Account"; 
        }

        protected override string GenerateAccountNumber()
        {
           

            return AccountHelper.GenerateAccountNumber(GetType(), this.ID);
        }
    }
}
