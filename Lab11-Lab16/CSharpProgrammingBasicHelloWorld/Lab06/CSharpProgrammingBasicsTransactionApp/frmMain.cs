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
using CSharpProgrammingBasics.Classes.Extensions;

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
            ITransactionAccount transAccount = CreateTransactionAccount();
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
            if (account != null)
            {
                lblID.Text = account.ID.ToString();
                lblNumber.Text = account.Number.ToString();
                lblCurrency.Text = account.Currency.ToString();
                lblBalance.Text = account.Balance.Amount.ToString() + " " + account.Balance.Currency.ToString();
            }
        }


        /// <summary>
        /// Ovoj metod proveruva dali stanuva zbor za Transaction Account i ako  e takva gi popolnuva soodvetnite labeli za nea
        /// </summary>
        /// <param name="account"></param>
        private void CheckTransactionAccount(IAccount account)
        {
            if (account != null)
            {
                if (account is ITransactionAccount)
                {
                    TransactionAccount tran = (TransactionAccount)account;
                    lblLimitCurrency.Text = tran.Limit.Currency.ToString();
                    lblLimit.Text = tran.Limit.Amount.ToString();
                }
                else
                {
                    lblLimitCurrency.Text = "";
                    lblLimit.Text = "";
                }
            }
        }


        private void CheckDepositAccount(IAccount account)
        {
            if (account != null)
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
        }

        #endregion

#region Second Account Details
        /// <summary>
        /// Ovoj metod gi popolnuva polinjata koi se zaednichki za site Account
        /// </summary>
        /// <param name="account"></param>
        private void accountCommonLabelSecond(IAccount account)
        {
            if(account!=null)
            {
                lblID_To.Text = account.ID.ToString();
                lblNumber_To.Text = account.Number.ToString();
                lblCurrency_To.Text = account.Currency.ToString();
                lblBalance_To.Text = account.Balance.Amount.ToString() + " " + account.Balance.Currency.ToString();
            }
            

        }

        /// <summary>
        /// Ovoj metod proveruva dali stanuva zbor za Transaction Account i ako  e takva gi popolnuva soodvetnite labeli za nea
        /// </summary>
        /// <param name="account"></param>
        private void CheckTransactionAccountSecond(IAccount account)
        {
            if (account != null)
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
        }


        private void CheckDepositAccountSecond(IAccount account)
        {
            if (account != null)
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
        }
#endregion


        /// <summary>
        /// Kreiranje na deposit Account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
           IDepositAccount deposit = CreateDepositAccount();

            //deposit.BalanceChanged += OnBalanceChange_Handler;
           

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
            IDepositAccount deposit = new DepositAccount(txtCurrency.Text, new TimePeriod(Convert.ToInt32(txtPeriod.Text), myTime),
                new InterestRate(Convert.ToDecimal(txtPercent.Text), myInterest), dateTimePicker1.Value, dateTimePicker2.Value, trans);




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

            //Za poednostavuvanje na detalite za prikaz

           // ShowTransactionDetails(transaction, deposit);



            //Transfer from ITransactionaccount to ILoanAccount II primer

            ILoanAccount loan = CreateLoanAccount(); //Kreiranje na instanca od LoanAccount so pomosh na veke gotov metod
            ITransactionAccount transAccount = CreateTransactionAccount(); //Kreiranje na instanca od TransactionAccount so pomosh na veke gotov metod
            CurrencyAmount amount = new CurrencyAmount(Convert.ToDecimal(txtTransactionAmount.Text), txtTransactionCurrency.Text);

            #region Try/Catch/Finally block za fakjanje na ApplicationExeption

            bool _errorOccurred = false;
            string _errorMsg = "";
            try
            {
                transferProcessor.ProcessTransaction(TransactionType.Transfer, amount, transAccount, loan);
            }

            catch(CurrencyMismatchException exep)
            {
                _errorOccurred = true;
                Console.WriteLine(exep.Message);
                _errorMsg = exep.Message;
            }
            catch(ApplicationException exepction)
            {
                //throw new ApplicationException(exepction.Message);
                _errorOccurred = true;
                Console.WriteLine(exepction.Message);
                _errorMsg = exepction.Message;
            }
            finally
            {
                if(_errorOccurred==true)
                {
                    MessageBox.Show(_errorMsg);
                }
            }

            #endregion
           
            ShowTransactionDetails(transAccount, loan);

            lblTotalTransactionCount.Text = transferProcessor.TransactionCount.ToString();

            DisplayLastTransactionDetails();
           // loan.BalanceChanged += new BalanceChangedEventHandler(OnBalanceChange_Handler);
            ///transAccount.BalanceChanged += new BalanceChangedEventHandler(OnBalanceChange_Handler);

            //Transfer from ILoanAccount to IDepositAccount III primer
            //transferProcessor.processTransaction(TransactionType.Transfer,amount,loan,transaction);
            

            // ShowTransactionDetails(loan, transaction);
        }

        /// <summary>
        /// Metod koj go poednostavuva prikazot na detali za transakcijata od accountFrom to accountTo
        /// </summary>
        /// <param name="account1"></param>
        /// <param name="account2"></param>
        private void ShowTransactionDetails(IAccount account1, IAccount account2)
        {
            accountCommonLabel(account1);
            CheckDepositAccount(account1);
            CheckTransactionAccount(account1);

            accountCommonLabelSecond(account2);
            CheckDepositAccountSecond(account2);
            CheckTransactionAccountSecond(account2);
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
             IDepositAccount deposit = CreateDepositAccount();

            deposit.BalanceChanged += OnBalanceChange_Handler;
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
            Dictionary<CreateAccountType, IAccount> dict = new Dictionary<CreateAccountType, IAccount>();
            CreateAccountType type = CreateAccountType.DepositAccount | CreateAccountType.LoanAccount; // zbir od vrednostite na dvete enum clenovi
            dict = CreateAccounts(type);
            IDepositAccount deposit =(DepositAccount) dict[CreateAccountType.DepositAccount]; //CreateDepositAccount();
            ILoanAccount loan = (LoanAccount)dict[CreateAccountType.LoanAccount]; //CreateLoanAccount();
            accountArray[0] = deposit;
            accountArray[1] = loan;

            ITransactionProcessor transProcessor = TransactionProcessor.GetTransactionProcessor();

            transProcessor.ProcessGroupTransaction(TransactionType.Debit, new CurrencyAmount(25000, "MKD"), accountArray);

            
            ShowTransactionDetails(deposit, loan); //Prikaz na detali na poednostaven nachin 

            lblTotalTransactionCount.Text = transProcessor.TransactionCount.ToString();

            DisplayLastTransactionDetails();

            //deposit.BalanceChanged += OnBalanceChange_Handler;



        }

        /// <summary>
        /// Metod so koj se prikazuvaat detalite za Last Transaction Log vo labeli 
        /// </summary>
        /// <param name="account"></param>
        private void transactionLogEntryLabel(TransactionLogEntry account)
        {
            if (account != null) { 
            lblTransType.Text = account.TransactionType.ToString();
            lblAmount.Text = account.Amount.Amount.ToString() +" " + account.Amount.Currency.ToString();
            lblStatus.Text = account.Status.ToString();
            }


        }

        /// <summary>
        /// Metod koj gi prikazuva detalite za poslednata transakcija
        /// </summary>
        private void DisplayLastTransactionDetails()
        {
            ITransactionProcessor transProcessor = TransactionProcessor.GetTransactionProcessor();

            //Koristenje na svojstvoto LastTransaction za vrakjanje na poslednata TransactionLogEntry
            //TransactionLogEntry lastLog = transProcessor.LastTransaction;

            //Koristenje na indekser za da se vrati poslednata TransactionLogEntry
            TransactionLogEntry lastLog = transProcessor[transProcessor.TransactionCount - 1];

            transactionLogEntryLabel(lastLog);


        }

        /// <summary>
        /// Metod koj se povikuva od strana na eventot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private static void OnBalanceChange_Handler(object sender, BalanceChangedEventArguments eventArgs)
        {

            Console.WriteLine("Details for the Account " + eventArgs.Account.ToString() + " Change " + eventArgs.Change.Amount + " " + eventArgs.Change.Currency);
            //Environment.Exit(0);
        }


        /// <summary>
        /// Metod koj vrakja dictionary od CreateAccountType kako kluc i IAccount kako vrednost
        /// </summary>
        /// <param name="accountTypesToCreate"></param>
        /// <param name="transactionAccount"></param>
        /// <returns></returns>

        private Dictionary<CreateAccountType, IAccount> CreateAccounts(CreateAccountType accountTypesToCreate)
        {
            Dictionary<CreateAccountType, IAccount> dictionary = new Dictionary<CreateAccountType, IAccount>();

            if((accountTypesToCreate  & CreateAccountType.DepositAccount) == CreateAccountType.DepositAccount)
            {
                IDepositAccount dep = CreateDepositAccount();
                dictionary.Add(CreateAccountType.DepositAccount, dep);
            }

            if((accountTypesToCreate & CreateAccountType.TransactionAccount) == CreateAccountType.TransactionAccount)
            {
                
                ITransactionAccount trans = CreateTransactionAccount();
                dictionary.Add(CreateAccountType.TransactionAccount, trans);
            }

            if((accountTypesToCreate & CreateAccountType.LoanAccount) == CreateAccountType.LoanAccount)
            {
                ILoanAccount loan = CreateLoanAccount();
                dictionary.Add(CreateAccountType.LoanAccount, loan);
            }
            else
            {
                dictionary.Add(CreateAccountType.None, null);
            }

            return dictionary;
        }

        /// <summary>
        /// Dodava dopolnitelni 15 denari kon balansot na Deposit i Loan account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChargeFee_Click(object sender, EventArgs e)
        {
            ITransactionProcessor proces = TransactionProcessor.GetTransactionProcessor();
            IDepositAccount deposit = CreateDepositAccount();
            ILoanAccount loan = CreateLoanAccount();
            IEnumerable<IAccount> accounts = new List<IAccount>() { deposit ,loan };


            proces.ChargeProcessingFee(new CurrencyAmount(15, "MKD"), accounts);

            ShowTransactionDetails(deposit, loan);
            lblTotalTransactionCount.Text = proces.TransactionCount.ToString();

            DisplayLastTransactionDetails();


        }
    }
}
