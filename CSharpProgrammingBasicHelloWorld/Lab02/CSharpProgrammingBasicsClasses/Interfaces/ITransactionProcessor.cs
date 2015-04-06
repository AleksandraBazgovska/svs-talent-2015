using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Accounts;

namespace CSharpProgrammingBasics.Classes.Interfaces
{
   public interface ITransactionProcessor
    {
        TransactionStatus processTransaction(TransactionType transactionType, CurrencyAmount currencyAmount, IAccount accountFrom, IAccount accountTo);

    }
}
