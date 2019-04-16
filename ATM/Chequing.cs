using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Chequing : Account
{
    public string accountType = "Chequing";
    public decimal accountTotal;
    public decimal accuredTime;

    public Chequing()
    {

    }

    public Chequing(int customerID, string owner, string cardNumber, string accountType, decimal accountTotal) : base(customerID, owner, cardNumber)
    {
        this.accountType = accountType;
        this.accountTotal = accountTotal;

    }

    public override decimal CalculateInterest()
    {
        decimal interestAmount = accountTotal + accountTotal * (accuredTime * 1.03m);
        return interestAmount;
    }
}
