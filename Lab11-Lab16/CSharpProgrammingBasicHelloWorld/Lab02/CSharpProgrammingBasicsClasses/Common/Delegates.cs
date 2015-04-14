using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;

public delegate void TransactionLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount); 

public class BalanceChangedEventArguments : System.EventArgs
{
    public IAccount Account { get;  set; }
    public  CurrencyAmount Change { get; set; }

    public BalanceChangedEventArguments(IAccount account,CurrencyAmount change)
    {
        this.Account = account;
        this.Change = change;
    }

    public BalanceChangedEventArguments()
    {

    }

}


public delegate void BalanceChangedEventHandler(object sender, BalanceChangedEventArguments eventArgs);
