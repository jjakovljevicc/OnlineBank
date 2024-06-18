namespace ProjekatJMMDonlinebanking
{
    partial class Admin
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
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Location = new System.Drawing.Point(104, 367);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.PasswordChar = '●';
            this.tbCardNumber.Size = new System.Drawing.Size(200, 20);
            this.tbCardNumber.TabIndex = 36;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeposit.Font = new System.Drawing.Font("Ballega", 9.75F);
            this.btnDeposit.Location = new System.Drawing.Point(206, 408);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(98, 30);
            this.btnDeposit.TabIndex = 39;
            this.btnDeposit.Text = "Delete user";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Thistle;
            this.btnBack.Font = new System.Drawing.Font("Ballega", 9.75F);
            this.btnBack.Location = new System.Drawing.Point(102, 408);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 30);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Neue Mail Medium", 54.75F);
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 86);
            this.label2.TabIndex = 41;
            this.label2.Text = "ONLINE BANK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ballega", 20.25F);
            this.label6.Location = new System.Drawing.Point(98, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 33);
            this.label6.TabIndex = 42;
            this.label6.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(101, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Card code";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjekatJMMDonlinebanking.Properties.Resources.FORMAPOZADINA;
            this.ClientSize = new System.Drawing.Size(885, 621);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbCardNumber);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}