using CSharpProgrammingBasics.Classes.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Interfaces
{
   public interface IDepositAccount : IAccount
    {
        Common.TimePeriod Period
        {
            get;
        }

        Common.InterestRate Interest
        {
            get;
        }

         DateTime StartDate
        {
            get;
        }

         DateTime EndDate
        {
            get;
        }

        ITransactionAccount TransactionAccount
        {
            get;
        }


    }
}
