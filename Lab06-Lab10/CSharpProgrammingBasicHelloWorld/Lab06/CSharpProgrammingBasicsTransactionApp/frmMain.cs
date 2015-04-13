using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpProgrammingBasics.Classes.Accounts;
using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;
using CSharpProgrammingBasics.Classes.Processors;

namespace CSharpProgrammingBasicsTransactionApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Se kreira instanca od tip Transaction Account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            ITransactionAccount transAccount = new TransactionAccount(txtCurrency.Text,Convert.ToDecimal(txtLimit.Text));
            accountCommonLabel(transAccount);
            CheckDepositAccount(transAccount);
            CheckTransactionAccount(transAccount);           
           
        }

#region First Account Details
        /// <summary>
        /// Ovoj metod gi popolnuva polinjata koi se zaednichki za site Account
        /// </summary>
        /// <param name="account"></param>
        private void accountCommonLabel(IAccount account)
        {
            lblID.Text = account.ID.ToString();
            lblNumber.Text = account.Number.ToString();
            lblCurrency.Text = account.Currency.ToString();
            lblBalance.Text = account.Balance.Amount.ToString() + " " + account.Balance.Currency.ToString();
            
        }


        /// <summary>
        /// Ovoj metod proveruva dali stanuva zbor za Transaction Account i ako  e takva gi popolnuva soodvetnite labeli za nea
        /// </summary>
        /// <param name="account"></param>
        private void CheckTransactionAccount(IAccount account)
        {
            if(account is ITransactionAccount)
            {
                TransactionAccount tran =(TransactionAccount)account;
                lblLimitCurrency.Text = tran.Limit.Currency.ToString();
                lblLimit.Text = tran.Limit.Amount.ToString();
            }
            else
            {
                lblLimitCurrency.Text = "";
                lblLimit.Text = "";
            }
        }


        private void CheckDepositAccount(IAccount account)
        {
            if (account is IDepositAccount)
            {
                DepositAccount dep = (DepositAccount)account;
                lblPeriod.Text = dep.Period.Period.ToString() + " " + dep.Period.Unit.ToString();
                lblInterest.Text = dep.Interest.Percent.ToString() + " " + dep.Interest.Unit.ToString();
                lblStartdate.Text = dep.StartDate.ToString();
                lblEndDate.Text = dep.EndDate.ToString();
            }
            else
            {
                lblPeriod.Text = "";
                lblInterest.Text = "";
                lblStartdate.Text = "";
                lblEndDate.Text = "";
            }
        }

        #endregion

#region Second Account Details
        /// <summary>
        /// Ovoj metod gi popolnuva polinjata koi se zaednichki za site Account
        /// </summary>
        /// <param name="account"></param>
        private void accountCommonLabelSecond(IAccount account)
        {
            lblID_To.Text = account.ID.ToString();
            lblNumber_To.Text = account.Number.ToString();
            lblCurrency_To.Text = account.Currency.ToString();
            lblBalance_To.Text = account.Balance.Amount.ToString() + " " + account.Balance.Currency.ToString();

        }

        /// <summary>
        /// Ovoj metod proveruva dali stanuva zbor za Transaction Account i ako  e takva gi popolnuva soodvetnite labeli za nea
        /// </summary>
        /// <param name="account"></param>
        private void CheckTransactionAccountSecond(IAccount account)
        {
            if (account is ITransactionAccount)
            {
                TransactionAccount tran = (TransactionAccount)account;
                lblLimitCurrency_To.Text = tran.Limit.Currency.ToString();
                lblLimit_To.Text = tran.Limit.Amount.ToString();
            }
            else
            {
                lblLimitCurrency_To.Text = "";
                lblLimit_To.Text = "";
            }
        }


        private void CheckDepositAccountSecond(IAccount account)
        {
            if (account is IDepositAccount)
            {
                DepositAccount dep = (DepositAccount)account;
                lblPeriod_To.Text = dep.Period.Period.ToString() + " " + dep.Period.Unit.ToString();
                lblInterest_To.Text = dep.Interest.Percent.ToString() + " " + dep.Interest.Unit.ToString();
                lblStartDate_To.Text = dep.StartDate.ToString();
                lblEndDate_To.Text = dep.EndDate.ToString();
            }
            else
            {
                lblPeriod_To.Text = "";
                lblInterest_To.Text = "";
                lblStartDate_To.Text = "";
                lblEndDate_To.Text = "";
            }
        }
#endregion


        /// <summary>
        /// Kreiranje na deposit Account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            //Konverzija na enum vo string za Period svojstvoto 
            UnitOfTime myTime;
            Enum.TryParse(comboBox1.SelectedItem.ToString(), out myTime);

            //KOnverzija na enum vo string za Interest svojstvoto 
            UnitOfTime myInterest;
            Enum.TryParse(comboBox2.SelectedItem.ToString(), out myInterest);

            //Kretiranje na Transaction Account
            ITransactionAccount trans = new TransactionAccount(txtCurrency.Text, Convert.ToDecimal(txtLimit.Text));

            IDepositAccount deposit = new DepositAccount(txtCurrency.Text, new TimePeriod(Convert.ToInt32(txtPeriod.Text), myTime),
                new InterestRate(Convert.ToDecimal(txtPercent.Text), myInterest), dateTimePicker1.Value, dateTimePicker2.Value, trans);


            accountCommonLabel(deposit);
            CheckDepositAccount(deposit);
            CheckTransactionAccount(deposit);


        }

        /// <summary>
        /// So ovoj metod se kreira instanca od tip Loan Account
        /// </summary>

        private ILoanAccount CreateLoanAccount()
        {
            UnitOfTime myTime;
            Enum.TryParse(comboBox1.SelectedItem.ToString(), out myTime);

            //Konverzija na enum vo string za Interest svojstvoto 
            UnitOfTime myInterest;
            Enum.TryParse(comboBox2.SelectedItem.ToString(), out myInterest);

            //Kretiranje na Transaction Account
            ITransactionAccount trans = new TransactionAccount(txtCurrency.Text, Convert.ToDecimal(txtLimit.Text));
            LoanAccount loan = new LoanAccount(txtCurrency.Text, new TimePeriod(Convert.ToInt32(txtPeriod.Text), myTime),
                new InterestRate(Convert.ToDecimal(txtPercent.Text), myInterest), dateTimePicker1.Value, dateTimePicker2.Value, trans);


            return loan;
        }

        /// <summary>
        /// Metod za kreiranje na Deposit Account
        /// </summary>
        /// <returns></returns>
        private IDepositAccount CreateDepositAccount()
        {
            UnitOfTime myTime;
            Enum.TryParse(comboBox1.SelectedItem.ToString(), out myTime);

            //Konverzija na enum vo string za Interest svojstvoto 
            UnitOfTime myInterest;
            Enum.TryParse(comboBox2.SelectedItem.ToString(), out myInterest);

            //Kretiranje na Transaction Account
            ITransactionAccount trans = new TransactionAccount(txtCurrency.Text, Convert.ToDecimal(txtLimit.Text));
            IDepositAccount deposit = new DepositAccount(txtCurrency.Text, new CSharpProgrammingBasics.Classes.Common.TimePeriod(Convert.ToInt32(txtPeriod.Text), myTime),
                new CSharpProgrammingBasics.Classes.Common.InterestRate(Convert.ToDecimal(txtPercent.Text), myInterest), dateTimePicker1.Value, dateTimePicker2.Value, trans);


            return deposit;
        }

        //Pomoshen metod za kreiranje na instanca od TransactionAccount
        private  ITransactionAccount CreateTransactionAccount()
        {
            ITransactionAccount transAccount = new TransactionAccount(txtCurrency.Text, Convert.ToDecimal(txtLimit.Text));
            accountCommonLabel(transAccount);
            CheckDepositAccount(transAccount);
            CheckTransactionAccount(transAccount);
            return transAccount;
        }
        

        private void frmMain_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Metod koj go pretstavuva transferot na pari od edna na druga smetka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            // Prviot primer pri transakcija od Transaction Account na Deposit Account
            //Kreiranje na instanca od tip Transaction Account
            ITransactionAccount transaction = new TransactionAccount("MKD", 50000);     
            
            //Definiranje na pomoshni promenlivi za kreiranje na instanca od soodvetna struktura
            TimePeriod timePeriod = new TimePeriod(20, UnitOfTime.Day);
            InterestRate interestRate = new InterestRate(15, UnitOfTime.Day);

            //Kreiranje na instanca od tip Deposit Account
            IDepositAccount deposit = new DepositAccount("MKD", timePeriod, interestRate, DateTime.Now, DateTime.Now, transaction);

            //Keriranje na instanca od tip TransactionProcessor
            ITransactionProcessor transferProcessor = TransactionProcessor.GetTransactionProcessor();

            //Izvrshuvanje na transfer na pari od edna smetka na druga I primer

            //CurrencyAmount amount = new CurrencyAmount(20000, "MKD");
            //transferProcessor.processTransaction(TransactionType.Transfer, amount, transaction, deposit);

            //accountCommonLabel(transaction);
            //CheckDepositAccount(transaction);
            //CheckTransactionAccount(transaction);

            //accountCommonLabelSecond(deposit);
            //CheckDepositAccountSecond(deposit);
            //CheckTransactionAccountSecond(deposit);

            //CheckTransactionAccountSecond(deposit.TransactionAccount);


            //Transfer from ITransactionaccount to ILoanAccount II primer

            ILoanAccount loan = CreateLoanAccount(); //Kreiranje na instanca od LoanAccount so pomosh na veke gotov metod
            ITransactionAccount transAccount = CreateTransactionAccount(); //Kreiranje na instanca od TransactionAccount so pomosh na veke gotov metod
            CurrencyAmount amount = new CurrencyAmount(20000, "MKD");
            transferProcessor.ProcessTransaction(TransactionType.Transfer, amount, transAccount, loan);

            accountCommonLabel(transAccount);
            CheckDepositAccount(transAccount);
            CheckTransactionAccount(transAccount);

            accountCommonLabelSecond(loan);
            CheckDepositAccountSecond(loan);
            CheckTransactionAccountSecond(loan);



            //Transfer from ILoanAccount to IDepositAccount III primer
            //transferProcessor.processTransaction(TransactionType.Transfer,amount,loan,transaction);
            //accountCommonLabel(loan);
            //CheckDepositAccount(loan);
            //CheckTransactionAccount(loan);

            //accountCommonLabelSecond(transaction);
            //CheckDepositAccountSecond(transaction);
            //CheckTransactionAccountSecond(transaction);
        }


        /// <summary>
        /// Metodite se definirani po vtor pat zatoa shto ne rabotea prethodno 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTransactionAccount_Click_1(object sender, EventArgs e)
        {
            ITransactionAccount transAccount = new TransactionAccount(txtCurrency.Text, Convert.ToDecimal(txtLimit.Text));
            accountCommonLabel(transAccount);
            CheckDepositAccount(transAccount);
            CheckTransactionAccount(transAccount);

        }

        private void btnCreateDepositAccount_Click_1(object sender, EventArgs e)
        {
            //Konverzija na enum vo string za Period svojstvoto 
            UnitOfTime myTime;
            Enum.TryParse(comboBox1.SelectedItem.ToString(), out myTime);

            //KOnverzija na enum vo string za Interest svojstvoto 
            UnitOfTime myInterest;
            Enum.TryParse(comboBox2.SelectedItem.ToString(), out myInterest);

            //Kretiranje na Transaction Account
            ITransactionAccount trans = new TransactionAccount(txtCurrency.Text, Convert.ToDecimal(txtLimit.Text));

            IDepositAccount deposit = new DepositAccount(txtCurrency.Text, new TimePeriod(Convert.ToInt32(txtPeriod.Text), myTime),
                new InterestRate(Convert.ToDecimal(txtPercent.Text), myInterest), dateTimePicker1.Value, dateTimePicker2.Value, trans);


            accountCommonLabel(deposit);
            CheckDepositAccount(deposit);
            CheckTransactionAccount(deposit);
        }


        /// <summary>
        /// Ovoj metod ovozmozuva na klik na kopcheto MakeGroupTransaction da se napravi grupna transakcija an poveke smetki odednash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeGroupTransaction_Click(object sender, EventArgs e)
        {
            IAccount[] accountArray = new Account[2];
            IDepositAccount deposit = CreateDepositAccount();
            ILoanAccount loan = CreateLoanAccount();
            accountArray[0] = deposit;
            accountArray[1] = loan;

            ITransactionProcessor transProcessor = TransactionProcessor.GetTransactionProcessor();

            transProcessor.ProccessGroupTransaction(TransactionType.Debit, new CurrencyAmount(25000, "MKD"), accountArray);

            accountCommonLabel(deposit);
            CheckDepositAccount(deposit);
            CheckTransactionAccount(deposit);

            accountCommonLabelSecond(loan);
            CheckDepositAccountSecond(loan);
            CheckTransactionAccountSecond(loan);

            lblTotalTransactionCount.Text = transProcessor.TransactionCount.ToString();

            DisplayLastTransactionDetails();

            //TODO Potrebno e refaktoriranje so cel da se povika null array, i array inicijalizirana so null vrednosti



        }

        private void transactionLogEntryLabel(TransactionLogEntry account)
        {
            lblTransType.Text = account.TransactionType.ToString();
            lblAmount.Text = account.Amount.Amount.ToString() + account.Amount.Currency.ToString();
            lblStatus.Text = account.Status.ToString();


        }

        private void DisplayLastTransactionDetails()
        {
            ITransactionProcessor transProcessor = TransactionProcessor.GetTransactionProcessor();
            TransactionLogEntry lastLog = transProcessor.LastTransaction;

            transactionLogEntryLabel(lastLog);


        }
    }
}
