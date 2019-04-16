using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    /// <summary>
    /// Initialization of App Form. Declare variables and initial form. 
    /// </summary>
    public partial class SelectAccount : Form
    {
        public string cardnumber;
        public string cardPin;
        public Account Customer{ get; set; }

        public SelectAccount()
        {
            InitializeComponent();
            ChequingsButton.Hide();
            SavingsButton.Hide();
            PleaseSelectLabel.Hide();

        }
        /// <summary>
        /// Shows Chequing Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChequingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChequingForm chequingaccount = new ChequingForm();
            chequingaccount.Customer = Customer;
            chequingaccount.Show();
        }
        /// <summary>
        /// Show's Savings Form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SavingsForm savingsaccount = new SavingsForm();
            savingsaccount.Customer = Customer;
            savingsaccount.Show();
        }
        /// <summary>
        /// Exits Applciation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Validates user information. Takes user inputed cardNumber and cardPin and sends it to the SQLHelper to compare to SQL Datatable. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EnterCardButton_Click(object sender, EventArgs e)
        {
            User LoginCredentials = new User(cardnumber, cardPin);

            LoginCredentials.cardNumber = CardNumberBox.Text;
            LoginCredentials.cardPin = CardPinBox.Text;

            if (SqlHelper.GetAccountInfo(LoginCredentials).customerID > 0)
            {
                Customer = SqlHelper.GetAccountInfo(LoginCredentials);
                EnterCardBox.Hide();
                InstructionTopLabel.Hide();
                welcomelabel2.Hide();
                Pinlabel.Hide();
                CardNumberBox.Hide();
                CardPinBox.Hide();
                cardnumberlabel.Hide();

                ChequingsButton.Show();
                SavingsButton.Show();
                PleaseSelectLabel.Show();
                


            }
            else
            {
                InstructionTopLabel.Text = "Hahahahaah.... Wrong!";
                welcomelabel2.Text = "Sorry.. Please try again.";
            }

        }
    }

}
