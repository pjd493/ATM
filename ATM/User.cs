using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class User
{
    public string cardNumber;
    public string cardPin;
    

    public User()
    {

    }
    public User(string cardNumber)
    {

    }

    public User(string cardNumber, string cardPin)
    {
        this.cardNumber = cardNumber;
        this.cardPin = cardPin;
    }

}

