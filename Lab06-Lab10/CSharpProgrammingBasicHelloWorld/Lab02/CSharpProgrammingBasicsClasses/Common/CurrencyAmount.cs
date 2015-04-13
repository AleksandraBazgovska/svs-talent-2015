using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Common
{
    public struct CurrencyAmount
    {
        /// <summary>
        /// Definiranje na svojstva vo strukturata 
        /// </summary>
        public decimal Amount;
        public string Currency;

        public CurrencyAmount(decimal amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }
    }
}
