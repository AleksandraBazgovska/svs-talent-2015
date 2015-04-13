using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Accounts;
using CSharpProgrammingBasics.Classes.Processors;

namespace CSharpProgrammingBasics.Classes.Interfaces
{
   public interface ITransactionProcessor
    {

        TransactionLogger ExternalLogger { get; set; } // Svojstvo od tip delegate
        TransactionLogEntry LastTransaction { get; }

        int TransactionCount { get;  }

        TransactionLogEntry this[int index] { get; }

        TransactionStatus ProcessTransaction(TransactionType transactionType, CurrencyAmount currencyAmount, IAccount accountFrom, IAccount accountTo);
        TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts);
        TransactionStatus ChargeProcessingFee(ITransactionProcessor processor, CurrencyAmount amount, IEnumerable<IAccount> accounts);
    }
}
