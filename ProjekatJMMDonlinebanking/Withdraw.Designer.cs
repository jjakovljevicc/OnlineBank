namespace ProjekatJMMDonlinebanking
{
    partial class Withdraw
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
            this.tbCardCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeposit.Font = new System.Drawing.Font("Ballega", 9.75F);
            this.btnDeposit.Location = new System.Drawing.Point(175, 465);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(98, 35);
            this.btnDeposit.TabIndex = 29;
            this.btnDeposit.Text = "Withdraw";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Thistle;
            this.btnBack.Font = new System.Drawing.Font("Ballega", 9.75F);
            this.btnBack.Location = new System.Drawing.Point(71, 465);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 35);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(68, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Card code";
            // 
            // tbCardCode
            // 
            this.tbCardCode.Location = new System.Drawing.Point(71, 412);
            this.tbCardCode.Name = "tbCardCode";
            this.tbCardCode.PasswordChar = '●';
            this.tbCardCode.Size = new System.Drawing.Size(200, 20);
            this.tbCardCode.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(68, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Insert amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(71, 339);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(200, 20);
            this.tbAmount.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ballega", 20.25F);
            this.label3.Location = new System.Drawing.Point(108, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 33);
            this.label3.TabIndex = 23;
            this.label3.Text = "Withdraw";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Neue Mail Medium", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(353, 86);
            this.label8.TabIndex = 30;
            this.label8.Text = "ONLINE BANK";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjekatJMMDonlinebanking.Properties.Resources.FORMAPOZADINA;
            this.ClientSize = new System.Drawing.Size(885, 621);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCardCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label3);
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCardCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}