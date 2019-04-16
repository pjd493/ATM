using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

public class SqlHelper
{
    public static String conString = ATM.Properties.Settings.Default.CS;
    public Account Customer = new Account();
   
    /// <summary>
    /// Finds where SQL Datatable has a row that contains both the user inputed cardNumber and cardPin. 
    /// </summary>
    /// <param name="LoginCredentials"></param>
    /// <returns>Cutomer ... Account(customerID, owner, cardNumber)</returns>
    public static Account GetAccountInfo(User LoginCredentials)
      {
        int customerID = 0;
        string owner = null;
        string cardNumber = null;
        using (SqlConnection connection = new SqlConnection(conString))
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM cardverification WHERE cardnumber=@cardnumber AND pin=@pin", connection);

            cmd.Parameters.AddWithValue("@cardnumber", LoginCredentials.cardNumber);
            cmd.Parameters.AddWithValue("@pin", LoginCredentials.cardPin);
            connection.Open();

            SqlDataReader Reader = cmd.ExecuteReader(); 
           
                while (Reader.Read())
                {
                    customerID = Convert.ToInt16(Reader["Id"].ToString());
                    owner = Reader["name"].ToString();
                    cardNumber = Reader["cardnumber"].ToString();
                    
                }
             Account Customer = new Account(customerID, owner, cardNumber);
             return Customer; 
        }
         }
    /// <summary>
    /// Updates the SQL Table chequingtotal value with the most recent Chequing Account Balance.
    /// </summary>
    /// <param name="updateaccount"></param>
    public static void UpdateChequing(Chequing updateaccount)
    {
        using (SqlConnection connection = new SqlConnection(conString))
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Accounts SET chequingtotal=@total WHERE Id = @Id", connection);

            cmd.Parameters.AddWithValue("@Id", updateaccount.customerID);
            cmd.Parameters.AddWithValue("@total", updateaccount.accountTotal);

            cmd.ExecuteNonQuery();
        }

    }

    /// <summary>
    /// Updates the SQL Table savingstotal value with the most recent Savings Account Balance.
    /// </summary>
    /// <param name="user"></param>
    public static void UpdateSavings(Savings user)
    {
        using (SqlConnection connection = new SqlConnection(conString))
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Accounts SET savingstotal=@total WHERE Id = @Id", connection);

            cmd.Parameters.AddWithValue("@Id", user.customerID);
            cmd.Parameters.AddWithValue("@total", user.accountTotal);

            cmd.ExecuteNonQuery();
        }

    }
 /// <summary>
 /// Gets current Chequing Account Balance from SQL Datatable.
 /// </summary>
 /// <returns>total, which is current chequingtotal from SQL Table.</returns>
    public static decimal CheckChequingfunds()
    {
        using (SqlConnection connection = new SqlConnection(conString))
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Accounts", connection);
            
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            decimal total = Convert.ToDecimal(reader.GetSqlValue(4).ToString());

            return total;
        }
    }
    /// <summary>
    /// Gets current Savings Account Balance from SQL Datatable.
    /// </summary>
    /// <returns>total, which is current savingstotal from SQL Table.</returns>
    public static decimal CheckSavingsfunds()
    {
        using (SqlConnection connection = new SqlConnection(conString))
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Accounts", connection);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            decimal total = Convert.ToDecimal(reader.GetSqlValue(3).ToString());

            return total;
        }
    }
    


}



