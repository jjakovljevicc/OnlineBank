namespace ProjekatJMMDonlinebanking
{
    partial class Transfer
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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSenderCardCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRecipientCardNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeposit.Font = new System.Drawing.Font("Ballega", 9.75F);
            this.btnDeposit.Location = new System.Drawing.Point(182, 528);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(98, 30);
            this.btnDeposit.TabIndex = 37;
            this.btnDeposit.Text = "Transfer";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Thistle;
            this.btnBack.Font = new System.Drawing.Font("Ballega", 9.75F);
            this.btnBack.Location = new System.Drawing.Point(76, 528);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 30);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(77, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Card code";
            // 
            // tbSenderCardCode
            // 
            this.tbSenderCardCode.Location = new System.Drawing.Point(80, 390);
            this.tbSenderCardCode.Name = "tbSenderCardCode";
            this.tbSenderCardCode.PasswordChar = '●';
            this.tbSenderCardCode.Size = new System.Drawing.Size(200, 20);
            this.tbSenderCardCode.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(77, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Insert amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(80, 317);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(200, 20);
            this.tbAmount.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(77, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Recipient card number";
            // 
            // tbRecipientCardNumber
            // 
            this.tbRecipientCardNumber.Location = new System.Drawing.Point(80, 467);
            this.tbRecipientCardNumber.Name = "tbRecipientCardNumber";
            this.tbRecipientCardNumber.PasswordChar = '●';
            this.tbRecipientCardNumber.Size = new System.Drawing.Size(200, 20);
            this.tbRecipientCardNumber.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Neue Mail Medium", 54.75F);
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 86);
            this.label2.TabIndex = 40;
            this.label2.Text = "ONLINE BANK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ballega", 20.25F);
            this.label6.Location = new System.Drawing.Point(70, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 33);
            this.label6.TabIndex = 41;
            this.label6.Text = "Transfer";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjekatJMMDonlinebanking.Properties.Resources.FORMAPOZADINA;
            this.ClientSize = new System.Drawing.Size(885, 621);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRecipientCardNumber);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSenderCardCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAmount);
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSenderCardCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRecipientCardNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}