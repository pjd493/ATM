namespace ATM
{
    partial class SavingsForm
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
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.ShowBalanceButton = new System.Windows.Forms.Button();
            this.BalanceRemainingLabel = new System.Windows.Forms.Label();
            this.DepositEnterBox = new System.Windows.Forms.TextBox();
            this.WithdrawEnterBox = new System.Windows.Forms.TextBox();
            this.BalanceRemainingDisplayBox = new System.Windows.Forms.ListBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EnterDepositButton = new System.Windows.Forms.Button();
            this.EnterWithdrawButton = new System.Windows.Forms.Button();
            this.TransferToChequingButton = new System.Windows.Forms.Button();
            this.TransferToChequingBox = new System.Windows.Forms.TextBox();
            this.EnterTransferButton = new System.Windows.Forms.Button();
            this.GoToChequingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WithdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.WithdrawButton.Location = new System.Drawing.Point(16, 15);
            this.WithdrawButton.Margin = new System.Windows.Forms.Padding(4);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(251, 64);
            this.WithdrawButton.TabIndex = 3;
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
            this.DepositButton.Size = new System.Drawing.Size(251, 64);
            this.DepositButton.TabIndex = 4;
            this.DepositButton.Text = "DEPOSIT";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositClick_Click);
            // 
            // ShowBalanceButton
            // 
            this.ShowBalanceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowBalanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowBalanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBalanceButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ShowBalanceButton.Location = new System.Drawing.Point(16, 158);
            this.ShowBalanceButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowBalanceButton.Name = "ShowBalanceButton";
            this.ShowBalanceButton.Size = new System.Drawing.Size(251, 64);
            this.ShowBalanceButton.TabIndex = 5;
            this.ShowBalanceButton.Text = "SHOW BALANCE";
            this.ShowBalanceButton.UseVisualStyleBackColor = true;
            this.ShowBalanceButton.Click += new System.EventHandler(this.DisplayClick_Click);
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
            this.BalanceRemainingLabel.TabIndex = 6;
            this.BalanceRemainingLabel.Text = "Balance Remaining";
            // 
            // DepositEnterBox
            // 
            this.DepositEnterBox.BackColor = System.Drawing.Color.Black;
            this.DepositEnterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositEnterBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.DepositEnterBox.Location = new System.Drawing.Point(341, 277);
            this.DepositEnterBox.Margin = new System.Windows.Forms.Padding(4);
            this.DepositEnterBox.Name = "DepositEnterBox";
            this.DepositEnterBox.Size = new System.Drawing.Size(419, 45);
            this.DepositEnterBox.TabIndex = 10;
            // 
            // WithdrawEnterBox
            // 
            this.WithdrawEnterBox.BackColor = System.Drawing.Color.Black;
            this.WithdrawEnterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawEnterBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.WithdrawEnterBox.Location = new System.Drawing.Point(341, 277);
            this.WithdrawEnterBox.Margin = new System.Windows.Forms.Padding(4);
            this.WithdrawEnterBox.Name = "WithdrawEnterBox";
            this.WithdrawEnterBox.Size = new System.Drawing.Size(419, 45);
            this.WithdrawEnterBox.TabIndex = 11;
            // 
            // BalanceRemainingDisplayBox
            // 
            this.BalanceRemainingDisplayBox.BackColor = System.Drawing.Color.Black;
            this.BalanceRemainingDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceRemainingDisplayBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BalanceRemainingDisplayBox.FormattingEnabled = true;
            this.BalanceRemainingDisplayBox.ItemHeight = 39;
            this.BalanceRemainingDisplayBox.Location = new System.Drawing.Point(341, 277);
            this.BalanceRemainingDisplayBox.Margin = new System.Windows.Forms.Padding(4);
            this.BalanceRemainingDisplayBox.Name = "BalanceRemainingDisplayBox";
            this.BalanceRemainingDisplayBox.Size = new System.Drawing.Size(419, 43);
            this.BalanceRemainingDisplayBox.TabIndex = 12;
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
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EnterDepositButton
            // 
            this.EnterDepositButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnterDepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterDepositButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.EnterDepositButton.Location = new System.Drawing.Point(449, 331);
            this.EnterDepositButton.Margin = new System.Windows.Forms.Padding(4);
            this.EnterDepositButton.Name = "EnterDepositButton";
            this.EnterDepositButton.Size = new System.Drawing.Size(189, 64);
            this.EnterDepositButton.TabIndex = 14;
            this.EnterDepositButton.Text = "ENTER";
            this.EnterDepositButton.UseVisualStyleBackColor = true;
            this.EnterDepositButton.Click += new System.EventHandler(this.EnterDeposit_Click);
            // 
            // EnterWithdrawButton
            // 
            this.EnterWithdrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnterWithdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterWithdrawButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.EnterWithdrawButton.Location = new System.Drawing.Point(449, 330);
            this.EnterWithdrawButton.Margin = new System.Windows.Forms.Padding(4);
            this.EnterWithdrawButton.Name = "EnterWithdrawButton";
            this.EnterWithdrawButton.Size = new System.Drawing.Size(189, 64);
            this.EnterWithdrawButton.TabIndex = 15;
            this.EnterWithdrawButton.Text = "ENTER";
            this.EnterWithdrawButton.UseVisualStyleBackColor = true;
            this.EnterWithdrawButton.Click += new System.EventHandler(this.EnterWithdraw_Click);
            // 
            // TransferToChequingButton
            // 
            this.TransferToChequingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TransferToChequingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferToChequingButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TransferToChequingButton.Location = new System.Drawing.Point(16, 229);
            this.TransferToChequingButton.Margin = new System.Windows.Forms.Padding(4);
            this.TransferToChequingButton.Name = "TransferToChequingButton";
            this.TransferToChequingButton.Size = new System.Drawing.Size(251, 64);
            this.TransferToChequingButton.TabIndex = 16;
            this.TransferToChequingButton.Text = "TRANSFER TO CHEQUING";
            this.TransferToChequingButton.UseVisualStyleBackColor = true;
            this.TransferToChequingButton.Click += new System.EventHandler(this.TransferToChequingButton_Click);
            // 
            // TransferToChequingBox
            // 
            this.TransferToChequingBox.BackColor = System.Drawing.Color.Black;
            this.TransferToChequingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferToChequingBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TransferToChequingBox.Location = new System.Drawing.Point(341, 278);
            this.TransferToChequingBox.Margin = new System.Windows.Forms.Padding(4);
            this.TransferToChequingBox.Name = "TransferToChequingBox";
            this.TransferToChequingBox.Size = new System.Drawing.Size(419, 45);
            this.TransferToChequingBox.TabIndex = 17;
            // 
            // EnterTransferButton
            // 
            this.EnterTransferButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnterTransferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterTransferButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.EnterTransferButton.Location = new System.Drawing.Point(449, 330);
            this.EnterTransferButton.Margin = new System.Windows.Forms.Padding(4);
            this.EnterTransferButton.Name = "EnterTransferButton";
            this.EnterTransferButton.Size = new System.Drawing.Size(189, 64);
            this.EnterTransferButton.TabIndex = 18;
            this.EnterTransferButton.Text = "ENTER";
            this.EnterTransferButton.UseVisualStyleBackColor = true;
            this.EnterTransferButton.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // GoToChequingButton
            // 
            this.GoToChequingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoToChequingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToChequingButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.GoToChequingButton.Location = new System.Drawing.Point(861, 339);
            this.GoToChequingButton.Margin = new System.Windows.Forms.Padding(4);
            this.GoToChequingButton.Name = "GoToChequingButton";
            this.GoToChequingButton.Size = new System.Drawing.Size(189, 64);
            this.GoToChequingButton.TabIndex = 19;
            this.GoToChequingButton.Text = "Go To Chequing";
            this.GoToChequingButton.UseVisualStyleBackColor = true;
            this.GoToChequingButton.Click += new System.EventHandler(this.GoToChequingButton_Click);
            // 
            // SavingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1067, 416);
            this.ControlBox = false;
            this.Controls.Add(this.GoToChequingButton);
            this.Controls.Add(this.EnterTransferButton);
            this.Controls.Add(this.TransferToChequingBox);
            this.Controls.Add(this.TransferToChequingButton);
            this.Controls.Add(this.EnterWithdrawButton);
            this.Controls.Add(this.EnterDepositButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BalanceRemainingDisplayBox);
            this.Controls.Add(this.WithdrawEnterBox);
            this.Controls.Add(this.DepositEnterBox);
            this.Controls.Add(this.BalanceRemainingLabel);
            this.Controls.Add(this.ShowBalanceButton);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.WithdrawButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SavingsForm";
            this.Text = "SAVINGS ACCOUNT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Button ShowBalanceButton;
        private System.Windows.Forms.Label BalanceRemainingLabel;
        private System.Windows.Forms.TextBox DepositEnterBox;
        private System.Windows.Forms.TextBox WithdrawEnterBox;
        private System.Windows.Forms.ListBox BalanceRemainingDisplayBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button EnterDepositButton;
        private System.Windows.Forms.Button EnterWithdrawButton;
        private System.Windows.Forms.Button TransferToChequingButton;
        private System.Windows.Forms.TextBox TransferToChequingBox;
        private System.Windows.Forms.Button EnterTransferButton;
        private System.Windows.Forms.Button GoToChequingButton;
    }
}