namespace ATM
{
    partial class ChequingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BalanceRemainingLabel = new System.Windows.Forms.Label();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.ShowBalanceButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BalanceRemainingDisplayBox = new System.Windows.Forms.ListBox();
            this.WithdrawEnterBox = new System.Windows.Forms.TextBox();
            this.DepositEnterBox = new System.Windows.Forms.TextBox();
            this.WithdrawEnterButton = new System.Windows.Forms.Button();
            this.EnterDepositButton = new System.Windows.Forms.Button();
            this.TransferToSavingsButton = new System.Windows.Forms.Button();
            this.TransferToSavingsBox = new System.Windows.Forms.TextBox();
            this.EnterTransferButton = new System.Windows.Forms.Button();
            this.GoToSavingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BalanceRemainingLabel
            // 
            this.BalanceRemainingLabel.AutoSize = true;
            this.BalanceRemainingLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceRemainingLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BalanceRemainingLabel.Location = new System.Drawing.Point(333, 234);
            this.BalanceRemainingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BalanceRemainingLabel.Name = "BalanceRemainingLabel";
            this.BalanceRemainingLabel.Size = new System.Drawing.Size(329, 45);
            this.BalanceRemainingLabel.TabIndex = 0;
            this.BalanceRemainingLabel.Text = "Balance Remaining";
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WithdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.WithdrawButton.Location = new System.Drawing.Point(16, 15);
            this.WithdrawButton.Margin = new System.Windows.Forms.Padding(4);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(252, 64);
            this.WithdrawButton.TabIndex = 2;
            this.WithdrawButton.Text = "WITHDRAW";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawClick_Click);
            // 
            // DepositButton
            // 
            this.DepositButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.DepositButton.Location = new System.Drawing.Point(16, 86);
            this.DepositButton.Margin = new System.Windows.Forms.Padding(4);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(252, 64);
            this.DepositButton.TabIndex = 3;
            this.DepositButton.Text = "DEPOSIT";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositClick_Click);
            // 
            // ShowBalanceButton
            // 
            this.ShowBalanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowBalanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBalanceButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ShowBalanceButton.Location = new System.Drawing.Point(16, 158);
            this.ShowBalanceButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowBalanceButton.Name = "ShowBalanceButton";
            this.ShowBalanceButton.Size = new System.Drawing.Size(252, 64);
            this.ShowBalanceButton.TabIndex = 4;
            this.ShowBalanceButton.Text = "SHOW BALANCE";
            this.ShowBalanceButton.UseVisualStyleBackColor = true;
            this.ShowBalanceButton.Click += new System.EventHandler(this.DisplayClick_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ExitButton.Location = new System.Drawing.Point(861, 15);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(189, 64);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BalanceRemainingDisplayBox
            // 
            this.BalanceRemainingDisplayBox.BackColor = System.Drawing.Color.Black;
            this.BalanceRemainingDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceRemainingDisplayBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BalanceRemainingDisplayBox.FormattingEnabled = true;
            this.BalanceRemainingDisplayBox.ItemHeight = 39;
            this.BalanceRemainingDisplayBox.Location = new System.Drawing.Point(341, 283);
            this.BalanceRemainingDisplayBox.Margin = new System.Windows.Forms.Padding(4);
            this.BalanceRemainingDisplayBox.Name = "BalanceRemainingDisplayBox";
            this.BalanceRemainingDisplayBox.Size = new System.Drawing.Size(419, 43);
            this.BalanceRemainingDisplayBox.TabIndex = 7;
            // 
            // WithdrawEnterBox
            // 
            this.WithdrawEnterBox.BackColor = System.Drawing.Color.Black;
            this.WithdrawEnterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawEnterBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.WithdrawEnterBox.Location = new System.Drawing.Point(341, 279);
            this.WithdrawEnterBox.Margin = new System.Windows.Forms.Padding(4);
            this.WithdrawEnterBox.Name = "WithdrawEnterBox";
            this.WithdrawEnterBox.Size = new System.Drawing.Size(419, 45);
            this.WithdrawEnterBox.TabIndex = 8;
            // 
            // DepositEnterBox
            // 
            this.DepositEnterBox.BackColor = System.Drawing.Color.Black;
            this.DepositEnterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositEnterBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.DepositEnterBox.Location = new System.Drawing.Point(341, 279);
            this.DepositEnterBox.Margin = new System.Windows.Forms.Padding(4);
            this.DepositEnterBox.Name = "DepositEnterBox";
            this.DepositEnterBox.Size = new System.Drawing.Size(419, 45);
            this.DepositEnterBox.TabIndex = 9;
            // 
            // WithdrawEnterButton
            // 
            this.WithdrawEnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WithdrawEnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawEnterButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.WithdrawEnterButton.Location = new System.Drawing.Point(446, 332);
            this.WithdrawEnterButton.Margin = new System.Windows.Forms.Padding(4);
            this.WithdrawEnterButton.Name = "WithdrawEnterButton";
            this.WithdrawEnterButton.Size = new System.Drawing.Size(189, 64);
            this.WithdrawEnterButton.TabIndex = 10;
            this.WithdrawEnterButton.Text = "ENTER";
            this.WithdrawEnterButton.UseVisualStyleBackColor = true;
            this.WithdrawEnterButton.Click += new System.EventHandler(this.EnterWithdraw_Click);
            // 
            // EnterDepositButton
            // 
            this.EnterDepositButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnterDepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterDepositButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.EnterDepositButton.Location = new System.Drawing.Point(446, 332);
            this.EnterDepositButton.Margin = new System.Windows.Forms.Padding(4);
            this.EnterDepositButton.Name = "EnterDepositButton";
            this.EnterDepositButton.Size = new System.Drawing.Size(189, 64);
            this.EnterDepositButton.TabIndex = 11;
            this.EnterDepositButton.Text = "ENTER";
            this.EnterDepositButton.UseVisualStyleBackColor = true;
            this.EnterDepositButton.Click += new System.EventHandler(this.EnterDeposit_Click);
            // 
            // TransferToSavingsButton
            // 
            this.TransferToSavingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TransferToSavingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferToSavingsButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TransferToSavingsButton.Location = new System.Drawing.Point(16, 234);
            this.TransferToSavingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.TransferToSavingsButton.Name = "TransferToSavingsButton";
            this.TransferToSavingsButton.Size = new System.Drawing.Size(252, 64);
            this.TransferToSavingsButton.TabIndex = 12;
            this.TransferToSavingsButton.Text = "TRANSFER TO SAVINGS";
            this.TransferToSavingsButton.UseVisualStyleBackColor = true;
            this.TransferToSavingsButton.Click += new System.EventHandler(this.Trasnfer_Click_1);
            // 
            // TransferToSavingsBox
            // 
            this.TransferToSavingsBox.BackColor = System.Drawing.Color.Black;
            this.TransferToSavingsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferToSavingsBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TransferToSavingsBox.Location = new System.Drawing.Point(341, 281);
            this.TransferToSavingsBox.Margin = new System.Windows.Forms.Padding(4);
            this.TransferToSavingsBox.Name = "TransferToSavingsBox";
            this.TransferToSavingsBox.Size = new System.Drawing.Size(419, 45);
            this.TransferToSavingsBox.TabIndex = 13;
            // 
            // EnterTransferButton
            // 
            this.EnterTransferButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnterTransferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterTransferButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.EnterTransferButton.Location = new System.Drawing.Point(446, 332);
            this.EnterTransferButton.Margin = new System.Windows.Forms.Padding(4);
            this.EnterTransferButton.Name = "EnterTransferButton";
            this.EnterTransferButton.Size = new System.Drawing.Size(189, 64);
            this.EnterTransferButton.TabIndex = 14;
            this.EnterTransferButton.Text = "ENTER";
            this.EnterTransferButton.UseVisualStyleBackColor = true;
            this.EnterTransferButton.Click += new System.EventHandler(this.Transferbutton_Click);
            // 
            // GoToSavingsButton
            // 
            this.GoToSavingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoToSavingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToSavingsButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.GoToSavingsButton.Location = new System.Drawing.Point(861, 339);
            this.GoToSavingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.GoToSavingsButton.Name = "GoToSavingsButton";
            this.GoToSavingsButton.Size = new System.Drawing.Size(189, 64);
            this.GoToSavingsButton.TabIndex = 15;
            this.GoToSavingsButton.Text = "Go To Savings";
            this.GoToSavingsButton.UseVisualStyleBackColor = true;
            this.GoToSavingsButton.Click += new System.EventHandler(this.GoToSavingsButton_Click);
            // 
            // ChequingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1067, 416);
            this.ControlBox = false;
            this.Controls.Add(this.GoToSavingsButton);
            this.Controls.Add(this.EnterTransferButton);
            this.Controls.Add(this.TransferToSavingsBox);
            this.Controls.Add(this.TransferToSavingsButton);
            this.Controls.Add(this.EnterDepositButton);
            this.Controls.Add(this.WithdrawEnterButton);
            this.Controls.Add(this.DepositEnterBox);
            this.Controls.Add(this.WithdrawEnterBox);
            this.Controls.Add(this.BalanceRemainingDisplayBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ShowBalanceButton);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.BalanceRemainingLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChequingForm";
            this.Text = "CHEQUING ACCOUNT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BalanceRemainingLabel;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Button ShowBalanceButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListBox BalanceRemainingDisplayBox;
        private System.Windows.Forms.TextBox WithdrawEnterBox;
        private System.Windows.Forms.TextBox DepositEnterBox;
        private System.Windows.Forms.Button WithdrawEnterButton;
        private System.Windows.Forms.Button EnterDepositButton;
        private System.Windows.Forms.Button TransferToSavingsButton;
        private System.Windows.Forms.TextBox TransferToSavingsBox;
        private System.Windows.Forms.Button EnterTransferButton;
        private System.Windows.Forms.Button GoToSavingsButton;
    }
}