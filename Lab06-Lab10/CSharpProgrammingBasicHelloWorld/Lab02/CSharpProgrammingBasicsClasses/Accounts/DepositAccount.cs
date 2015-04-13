using CSharpProgrammingBasics.Classes.Helpers;
using CSharpProgrammingBasics.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpProgrammingBasics.Classes.Accounts
{
   public class DepositAccount : Account, IDepositAccount
    {
        /// <summary>
        /// Definiranje na fields za klasata
        /// </summary>
        public Common.TimePeriod m_Period;
        public Common.InterestRate m_Interest;
        public DateTime m_StartDate;
        public DateTime m_EndDate;
        public ITransactionAccount m_TransactionAccount;

        /// <summary>
        /// Definiranje na svojstva za klasata
        /// </summary>
        public  Common.TimePeriod Period    
        {
            get { return m_Period; }
           private set { m_Period = value; }
        }

        public Common.InterestRate Interest
        {
            get { return m_Interest; }
           private set { m_Interest = value; }
        }

        public DateTime StartDate
        {
            get { return m_StartDate; }
           private set { m_StartDate = value; }
        }

        public DateTime EndDate
        {
            get { return m_EndDate; }
           private set { m_EndDate = value; }
        }

        public ITransactionAccount TransactionAccount
        {
            get { return m_TransactionAccount; }
           private set { m_TransactionAccount = value; }
        }

        /// <summary>
        /// Definiranje na konstruktor 
        /// </summary>
        /// <param name="currency"></param>
        /// <param name="depositPeriod"></param>
        /// <param name="interestRate"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="transactionAccount"></param>
        public DepositAccount(string currency, Common.TimePeriod depositPeriod, Common.InterestRate interestRate, 
            DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount) : base(currency)
        {
            this.Period = depositPeriod;
            this.Interest = interestRate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TransactionAccount = transactionAccount;
        }

        

        public override string ToString()
        {
            return base.ToString() + " Deposit Account"; 
        }

        protected override string GenerateAccountNumber()
        {
          return  AccountHelper.GenerateAccountNumber(GetType(), this.ID);
        }
    }
}
