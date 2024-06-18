namespace ProjekatJMMDonlinebanking
{
    partial class Options
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewBalance = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Neue Mail Medium", 54.75F);
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 86);
            this.label2.TabIndex = 2;
            this.label2.Text = "ONLINE BANK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ballega", 20.25F);
            this.label3.Location = new System.Drawing.Point(22, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select one option";
            // 
            // btnViewBalance
            // 
            this.btnViewBalance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnViewBalance.Font = new System.Drawing.Font("Ballega", 9.75F);
            this.btnViewBalance.Location = new System.Drawing.Point(61, 361);
            this.btnViewBalance.Name = "btnViewBalance";
            this.btnViewBalance.Size = new System.Drawing.Size(167, 30);
            this.btnViewBalance.TabIndex = 20;
            this.btnViewBalance.Text = "View Balance";
            this.btnViewBalance.UseVisualStyleBackColor = false;
            this.btnViewBalance.Click += new System.EventHandler(this.btnViewBalance_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeposit.Font = new System.Drawing.Font("Ballega", 9.75F);
            this.btnDeposit.Location = new System.Drawing.Point(61, 420);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(167, 30);
            this.btnDeposit.TabIndex = 21;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnWithdraw.Font = new System.Drawing.Font("Ballega", 9.75F);
            this.btnWithdraw.Location = new System.Drawing.Point(249, 361);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(167, 30);
            this.btnWithdraw.TabIndex = 22;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTransfer.Font = new System.Drawing.Font("Ballega", 9.75F);
            this.btnTransfer.Location = new System.Drawing.Point(249, 420);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(167, 30);
            this.btnTransfer.TabIndex = 23;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Thistle;
            this.btnBack.Font = new System.Drawing.Font("Ballega", 9.75F);
            this.btnBack.Location = new System.Drawing.Point(158, 499);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(167, 30);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjekatJMMDonlinebanking.Properties.Resources.FORMAPOZADINA;
            this.ClientSize = new System.Drawing.Size(885, 621);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnViewBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewBalance;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnBack;
    }
}