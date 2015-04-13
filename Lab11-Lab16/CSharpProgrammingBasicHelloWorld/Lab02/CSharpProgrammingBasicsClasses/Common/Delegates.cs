using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;

public delegate void TransactionLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount); 

public class BalanceChangedEventArguments : System.EventArgs
{
    public IAccount Account { get;  private set; }
    public  CurrencyAmount Change { get; set; }

    public BalanceChangedEventArguments(IAccount account,CurrencyAmount change)
    {
        this.Account = account;
        this.Change = change;
    }

}


public delegate void BalanceChanged(object sender, BalanceChangedEventArguments eventArgs);
