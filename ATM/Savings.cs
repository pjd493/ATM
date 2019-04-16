using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Savings : Account
{
    public string type = "Savings";
    public decimal accountTotal;
    public decimal time;
    
    
   public Savings()
    {

    }

    public Savings(int customerID, string owner, string cardNumber, string accountType, decimal accountTotal) : base(customerID, owner, cardNumber)
    {
        this.type = accountType;
        this.accountTotal = accountTotal;

    }

    public override decimal CalculateInterest()
    {
        decimal interestAmount = accountTotal + accountTotal*(time * 1.03m);
        return interestAmount;
    }
}

