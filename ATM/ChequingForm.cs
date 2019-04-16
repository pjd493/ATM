﻿using System;
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

    public partial class ChequingForm : Form
    {
        /// <summary>
        /// Initializes Chequing Form. Sets variables. 
        /// </summary>
        public Account Customer { get; set; }
        public ChequingForm()
        {
            InitializeComponent();
            DepositEnterBox.Hide();
            WithdrawEnterBox.Hide();
            BalanceRemainingDisplayBox.Hide();
            BalanceRemainingLabel.Hide();
            EnterDepositButton.Hide();
            WithdrawEnterButton.Hide();
            TransferToSavingsBox.Hide();
            EnterTransferButton.Hide();
        }
        /// <summary>
        /// Displayes Withdraw form.
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
            WithdrawEnterButton.Show();
            EnterDepositButton.Hide();
            TransferToSavingsBox.Hide();

        }
        /// <summary>
        /// Displays Deposit Form.
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
            WithdrawEnterButton.Hide();
            TransferToSavingsBox.Hide();
            EnterTransferButton.Hide();
        }
        /// <summary>
        /// Displays Balance Remaining Form.
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
            WithdrawEnterButton.Hide();
            TransferToSavingsBox.Hide();
            EnterTransferButton.Hide();
            BalanceRemainingDisplayBox.Items.Clear();
            BalanceRemainingDisplayBox.Items.Add (SqlHelper.CheckChequingfunds());
        }
        /// <summary>
        /// Exits Application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Takes user inputed Deposit and updates SQL Datatable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterDeposit_Click(object sender, EventArgs e)
        {
           
            decimal chequingFunds = SqlHelper.CheckChequingfunds();

            Chequing UpdatedChequingAccount = new Chequing();

            UpdatedChequingAccount.customerID = Customer.customerID;
            UpdatedChequingAccount.accountTotal = chequingFunds + (Convert.ToDecimal(DepositEnterBox.Text));
            SqlHelper.UpdateChequing(UpdatedChequingAccount);
            BalanceRemainingDisplayBox.Items.Clear();
            
        }
        /// <summary>
        /// Takes User inputed withdraw and updates SQL Datatable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterWithdraw_Click(object sender, EventArgs e)
        {
            decimal chequingFunds = SqlHelper.CheckChequingfunds();
            Chequing UpdatedChequingAccount = new Chequing();

            UpdatedChequingAccount.customerID = Customer.customerID;
            UpdatedChequingAccount.accountTotal = chequingFunds - (Convert.ToDecimal(WithdrawEnterBox.Text));
            if (UpdatedChequingAccount.accountTotal < 0)
            {
                decimal savingsFunds = SqlHelper.CheckSavingsfunds();
                Savings CustomerSavings = new Savings();

                CustomerSavings.customerID = Customer.customerID;
                CustomerSavings.accountTotal = chequingFunds + UpdatedChequingAccount.accountTotal;
                UpdatedChequingAccount.accountTotal = 0;
                SqlHelper.UpdateSavings(CustomerSavings);
                BalanceRemainingDisplayBox.Items.Clear();
                SqlHelper.UpdateChequing(UpdatedChequingAccount);
            }
            else
            {
                SqlHelper.UpdateChequing(UpdatedChequingAccount);
                BalanceRemainingDisplayBox.Items.Clear();
            }
        }

        /// <summary>
        /// Displays Transfer to Savings form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Trasnfer_Click_1(object sender, EventArgs e)
        {
            BalanceRemainingLabel.Text = "Enter Transfer Amount";
            BalanceRemainingLabel.Show();
            WithdrawEnterBox.Hide();
            DepositEnterBox.Hide();
            BalanceRemainingDisplayBox.Hide();
            WithdrawEnterButton.Hide();
            EnterDepositButton.Hide();
            TransferToSavingsBox.Show();
            EnterTransferButton.Show();
        }
        /// <summary>
        /// Transfers user inputed amount to Savings from Chequing. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Transferbutton_Click(object sender, EventArgs e)
        {
                decimal currentSavings = SqlHelper.CheckSavingsfunds();
                decimal currentChequing = SqlHelper.CheckChequingfunds();
                Chequing UpdatedChequingAccount = new Chequing();
                Savings UpdatedSavingsAccount = new Savings();

            UpdatedChequingAccount.customerID = Customer.customerID;
            UpdatedSavingsAccount.customerID = Customer.customerID;
            UpdatedSavingsAccount.accountTotal = currentSavings + (Convert.ToDecimal(TransferToSavingsBox.Text));
            UpdatedChequingAccount.accountTotal = currentChequing - (Convert.ToDecimal(TransferToSavingsBox.Text));
            if (UpdatedChequingAccount.accountTotal < 0)
            {
                decimal savingsFunds = SqlHelper.CheckSavingsfunds();
                Savings CustomerSavings = new Savings();

                CustomerSavings.customerID = Customer.customerID;
                CustomerSavings.accountTotal = savingsFunds + UpdatedChequingAccount.accountTotal + currentChequing;
                UpdatedChequingAccount.accountTotal = 0;
                SqlHelper.UpdateSavings(CustomerSavings);
                BalanceRemainingDisplayBox.Items.Clear();
                SqlHelper.UpdateChequing(UpdatedChequingAccount);
            }
            else
            {

                SqlHelper.UpdateSavings(UpdatedSavingsAccount);
                SqlHelper.UpdateChequing(UpdatedChequingAccount);
                BalanceRemainingDisplayBox.Items.Clear();
            }

            
        }
        /// <summary>
        /// Opens Savings Account Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToSavingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SavingsForm SavingsAccount = new SavingsForm();
            SavingsAccount.Show();
            SavingsAccount.Customer = Customer;
        }
    }
}
