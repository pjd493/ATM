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
    public partial class SavingsForm : Form
    {
        public Account Customer { get; set; }
        /// <summary>
        /// Show's Savings Account Form.
        /// </summary>
        public SavingsForm()
        {
            
            InitializeComponent();
            DepositEnterBox.Hide();
            WithdrawEnterBox.Hide();
            BalanceRemainingDisplayBox.Hide();
            BalanceRemainingLabel.Hide();
            EnterDepositButton.Hide();
            EnterWithdrawButton.Hide();
            TransferToChequingBox.Hide();
            EnterTransferButton.Hide();

        }
        /// <summary>
        /// Event, occurs when user clicks Withdraw. Withdraw Form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WithdrawClick_Click(object sender, EventArgs e)
        {
            BalanceRemainingLabel.Text = "Enter Desired Amount";
            BalanceRemainingLabel.Show();
            WithdrawEnterBox.Show();
            DepositEnterBox.Hide();
            BalanceRemainingDisplayBox.Hide();
            EnterWithdrawButton.Show();
            EnterDepositButton.Hide();
            TransferToChequingBox.Hide();
            EnterTransferButton.Hide();
        }
        /// <summary>
        /// Event, occurs when user clicks Deposit. Deposit Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepositClick_Click(object sender, EventArgs e)
        {
            BalanceRemainingLabel.Text = "Enter Deposit Amount";
            BalanceRemainingLabel.Show();
            DepositEnterBox.Show();
            WithdrawEnterBox.Hide();
            BalanceRemainingDisplayBox.Hide();
            EnterDepositButton.Show();
            EnterWithdrawButton.Hide();
            TransferToChequingBox.Hide();
            EnterTransferButton.Hide();

        }
        /// <summary>
        /// Event, occurs when user clicks View Balance. Displays Account Balance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayClick_Click(object sender, EventArgs e)
        {
            BalanceRemainingLabel.Text = "Balance Remaining";
            BalanceRemainingLabel.Show();
            BalanceRemainingDisplayBox.Show();
            DepositEnterBox.Hide();
            WithdrawEnterBox.Hide();
            EnterDepositButton.Hide();
            EnterWithdrawButton.Hide();
            TransferToChequingBox.Hide();
            EnterTransferButton.Hide();
            BalanceRemainingDisplayBox.Items.Clear();
            BalanceRemainingDisplayBox.Items.Add(SqlHelper.CheckSavingsfunds());

        }
        /// <summary>
        /// Event, exit button. Exit Application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Sends user inputed deposit value into SQL Datatable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterDeposit_Click(object sender, EventArgs e)
        {

            decimal currentFunds = SqlHelper.CheckSavingsfunds();
            Savings UpdatedAccount = new Savings();

            UpdatedAccount.customerID = Customer.customerID;
            UpdatedAccount.accountTotal = currentFunds + (Convert.ToDecimal(DepositEnterBox.Text));
            SqlHelper.UpdateSavings(UpdatedAccount);
            BalanceRemainingDisplayBox.Items.Clear();

        }
        /// <summary>
        /// Sends user inputed withdraw value into SQL Datatable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterWithdraw_Click(object sender, EventArgs e)
        {
            decimal currentFunds = SqlHelper.CheckSavingsfunds();
            Savings UpdatedAccount = new Savings();

            UpdatedAccount.customerID = Customer.customerID;
            UpdatedAccount.accountTotal = currentFunds - (Convert.ToDecimal(WithdrawEnterBox.Text));
            SqlHelper.UpdateSavings(UpdatedAccount);
            BalanceRemainingDisplayBox.Items.Clear();

        }

        
        /// <summary>
        /// Transfers user inputed amount from Savings Account to Chequings Account. Reflects in SQL Datatable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Transfer_Click(object sender, EventArgs e)
        {
           

            decimal currentChequing = SqlHelper.CheckChequingfunds();
            decimal currentSavings = SqlHelper.CheckSavingsfunds();
            Savings UpdatedSavingsAccount = new Savings();
            Chequing UpdatedChequingAccount = new Chequing();

            UpdatedSavingsAccount.customerID = Customer.customerID;
            UpdatedChequingAccount.customerID = Customer.customerID;
            UpdatedChequingAccount.accountTotal = currentChequing + (Convert.ToDecimal(TransferToChequingBox.Text));
            UpdatedSavingsAccount.accountTotal = currentSavings - (Convert.ToDecimal(TransferToChequingBox.Text));
            if (UpdatedSavingsAccount.accountTotal < 0)
            {
                MessageBox.Show("You have Insufficent funds to make this transaction");
                UpdatedSavingsAccount.accountTotal = currentSavings;
                UpdatedChequingAccount.accountTotal = currentChequing;
            }
            else
            {
                SqlHelper.UpdateChequing(UpdatedChequingAccount);
                SqlHelper.UpdateSavings(UpdatedSavingsAccount);
                BalanceRemainingDisplayBox.Items.Clear();
            }
        }
        /// <summary>
        /// Brings you to the Chequings Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToChequingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChequingForm ChequingAccount = new ChequingForm();
            ChequingAccount.Customer = Customer;
            ChequingAccount.Show();
        }
        /// <summary>
        /// Displays Transfer to Chequing form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransferToChequingButton_Click(object sender, EventArgs e)
        {
            BalanceRemainingLabel.Text = "Enter Transfer Amount";
            BalanceRemainingLabel.Show();
            WithdrawEnterBox.Hide();
            DepositEnterBox.Hide();
            BalanceRemainingDisplayBox.Hide();
            EnterWithdrawButton.Hide();
            EnterDepositButton.Hide();
            TransferToChequingBox.Show();
            EnterTransferButton.Show();
        }
    }

}
