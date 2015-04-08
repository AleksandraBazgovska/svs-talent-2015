using CSharpProgrammingBasics.Classes.Accounts;
using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Processors
{
    public class TransactionLogEntry
    {

        /// <summary>
        /// Svojstvata koi gi poseduva klasata 
        /// </summary>
        public TransactionType TransactionType { get; set; }
        public CurrencyAmount Amount { get; set; }
        public IAccount[] Accounts { get; set; }
        public TransactionStatus Status { get; set; }

        public TransactionLogEntry(TransactionType transType,CurrencyAmount currency, IAccount[] accounts, TransactionStatus status)
        {
            TransactionType = transType;
            Amount = currency;
            Accounts = accounts;
            Status = status;
        }

        public TransactionLogEntry()
        {

        }
        

    }
}
