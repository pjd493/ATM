using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Account : User
{
    public int customerID;
    public string owner;



    public Account()
    {

    }
    public Account(int customerID, string owner, string cardNumber) : base(cardNumber)
    {
        this.cardNumber = cardNumber;
        this.customerID= customerID;
        this.owner = owner;

    }

    public virtual decimal CalculateInterest()
    {
        return 0;
        //We do not yet know what kind of account this is. 
    }



}
