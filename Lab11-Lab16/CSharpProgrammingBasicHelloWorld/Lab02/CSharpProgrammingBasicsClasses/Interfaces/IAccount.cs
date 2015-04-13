using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Interfaces
{
    public interface IAccount
    {
        long ID
        {
            get;
        }

         string Number
        {
            get;
        }


        string Currency { get;  } // auto-implemented property for Currency

        Common.CurrencyAmount Balance 
        {
            get;
        }

         Common.TransactionStatus DebitAmount(Common.CurrencyAmount amount);

         Common.TransactionStatus CreditAmount(Common.CurrencyAmount amount);

         event BalanceChanged OnBalanceChanged;
    }
}
