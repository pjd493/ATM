namespace ATM
{
    partial class SelectAccount
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
            this.ChequingsButton = new System.Windows.Forms.Button();
            this.SavingsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PleaseSelectLabel = new System.Windows.Forms.Label();
            this.InstructionTopLabel = new System.Windows.Forms.Label();
            this.welcomelabel2 = new System.Windows.Forms.Label();
            this.CardNumberBox = new System.Windows.Forms.TextBox();
            this.CardPinBox = new System.Windows.Forms.TextBox();
            this.cardnumberlabel = new System.Windows.Forms.Label();
            this.Pinlabel = new System.Windows.Forms.Label();
            this.EnterCardBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChequingsButton
            // 
            this.ChequingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChequingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChequingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChequingsButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ChequingsButton.Location = new System.Drawing.Point(16, 15);
            this.ChequingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChequingsButton.Name = "ChequingsButton";
            this.ChequingsButton.Size = new System.Drawing.Size(240, 64);
            this.ChequingsButton.TabIndex = 0;
            this.ChequingsButton.Text = "CHEQUINGS";
            this.ChequingsButton.UseVisualStyleBackColor = true;
            this.ChequingsButton.Click += new System.EventHandler(this.ChequingsButton_Click);
            // 
            // SavingsButton
            // 
            this.SavingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SavingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SavingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.SavingsButton.Location = new System.Drawing.Point(16, 86);
            this.SavingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SavingsButton.Name = "SavingsButton";
            this.SavingsButton.Size = new System.Drawing.Size(240, 64);
            this.SavingsButton.TabIndex = 1;
            this.SavingsButton.Text = "SAVINGS";
            this.SavingsButton.UseVisualStyleBackColor = true;
            this.SavingsButton.Click += new System.EventHandler(this.SavingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ExitButton.Location = new System.Drawing.Point(861, 15);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(189, 64);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PleaseSelectLabel
            // 
            this.PleaseSelectLabel.AutoSize = true;
            this.PleaseSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PleaseSelectLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PleaseSelectLabel.Location = new System.Drawing.Point(193, 359);
            this.PleaseSelectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PleaseSelectLabel.Name = "PleaseSelectLabel";
            this.PleaseSelectLabel.Size = new System.Drawing.Size(668, 46);
            this.PleaseSelectLabel.TabIndex = 3;
            this.PleaseSelectLabel.Text = "PLEASE SELECT ACCOUNT TYPE";
            // 
            // InstructionTopLabel
            // 
            this.InstructionTopLabel.AutoSize = true;
            this.InstructionTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionTopLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InstructionTopLabel.Location = new System.Drawing.Point(48, 11);
            this.InstructionTopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstructionTopLabel.Name = "InstructionTopLabel";
            this.InstructionTopLabel.Size = new System.Drawing.Size(760, 46);
            this.InstructionTopLabel.TabIndex = 4;
            this.InstructionTopLabel.Text = "PLEASE ENTER YOUR CARD NUMBER";
            // 
            // welcomelabel2
            // 
            this.welcomelabel2.AutoSize = true;
            this.welcomelabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcomelabel2.Location = new System.Drawing.Point(180, 57);
            this.welcomelabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomelabel2.Name = "welcomelabel2";
            this.welcomelabel2.Size = new System.Drawing.Size(511, 46);
            this.welcomelabel2.TabIndex = 5;
            this.welcomelabel2.Text = "FOLLOWED BY YOUR PIN";
            // 
            // CardNumberBox
            // 
            this.CardNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberBox.Location = new System.Drawing.Point(375, 202);
            this.CardNumberBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CardNumberBox.Name = "CardNumberBox";
            this.CardNumberBox.Size = new System.Drawing.Size(432, 46);
            this.CardNumberBox.TabIndex = 6;
            // 
            // CardPinBox
            // 
            this.CardPinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardPinBox.Location = new System.Drawing.Point(375, 256);
            this.CardPinBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CardPinBox.Name = "CardPinBox";
            this.CardPinBox.Size = new System.Drawing.Size(432, 46);
            this.CardPinBox.TabIndex = 7;
            // 
            // cardnumberlabel
            // 
            this.cardnumberlabel.AutoSize = true;
            this.cardnumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardnumberlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cardnumberlabel.Location = new System.Drawing.Point(29, 203);
            this.cardnumberlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardnumberlabel.Name = "cardnumberlabel";
            this.cardnumberlabel.Size = new System.Drawing.Size(319, 46);
            this.cardnumberlabel.TabIndex = 8;
            this.cardnumberlabel.Text = "CARD NUMBER";
            // 
            // Pinlabel
            // 
            this.Pinlabel.AutoSize = true;
            this.Pinlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pinlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pinlabel.Location = new System.Drawing.Point(257, 257);
            this.Pinlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pinlabel.Name = "Pinlabel";
            this.Pinlabel.Size = new System.Drawing.Size(86, 46);
            this.Pinlabel.TabIndex = 9;
            this.Pinlabel.Text = "PIN";
            // 
            // EnterCardBox
            // 
            this.EnterCardBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnterCardBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnterCardBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterCardBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.EnterCardBox.Location = new System.Drawing.Point(493, 310);
            this.EnterCardBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterCardBox.Name = "EnterCardBox";
            this.EnterCardBox.Size = new System.Drawing.Size(189, 64);
            this.EnterCardBox.TabIndex = 10;
            this.EnterCardBox.Text = "ENTER";
            this.EnterCardBox.UseVisualStyleBackColor = true;
            this.EnterCardBox.Click += new System.EventHandler(this.EnterCardButton_Click);
            // 
            // SelectAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1067, 416);
            this.ControlBox = false;
            this.Controls.Add(this.EnterCardBox);
            this.Controls.Add(this.Pinlabel);
            this.Controls.Add(this.cardnumberlabel);
            this.Controls.Add(this.CardPinBox);
            this.Controls.Add(this.CardNumberBox);
            this.Controls.Add(this.welcomelabel2);
            this.Controls.Add(this.InstructionTopLabel);
            this.Controls.Add(this.PleaseSelectLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SavingsButton);
            this.Controls.Add(this.ChequingsButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelectAccount";
            this.Text = "Please Enter Credentials and then Select an Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChequingsButton;
        private System.Windows.Forms.Button SavingsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label PleaseSelectLabel;
        private System.Windows.Forms.Label InstructionTopLabel;
        private System.Windows.Forms.Label welcomelabel2;
        private System.Windows.Forms.TextBox CardNumberBox;
        private System.Windows.Forms.TextBox CardPinBox;
        private System.Windows.Forms.Label cardnumberlabel;
        private System.Windows.Forms.Label Pinlabel;
        private System.Windows.Forms.Button EnterCardBox;
    }
}

