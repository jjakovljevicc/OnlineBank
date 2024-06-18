using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatJMMDonlinebanking
{
    public partial class Withdraw : Form
    {
        private User user;
        public Withdraw(User user)
        {
            InitializeComponent();
            this.user = user; 
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string cardnumber = user.cardnumber;
            string cardcode = user.cardcode;
            string mysqlCon = "server=127.0.0.1;user=root;database=onlinebank;password=";

            if (String.IsNullOrEmpty(tbAmount.Text) || String.IsNullOrEmpty(tbCardCode.Text))
            {
                MessageBox.Show("Fill with information!");
                return;
            }

            if (!double.TryParse(tbAmount.Text, out double withdrawAmount) || withdrawAmount <= 0)
            {
                MessageBox.Show("Enter a valid withdrawal amount.");
                return;
            }

            if (!cardcode.Equals(tbCardCode.Text))
            {
                MessageBox.Show("Incorrect card code.");
                return;
            }

            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                try
                {
                    mySqlConnection.Open(); 

                    string selectQuery = "SELECT balance FROM user WHERE cardNumber = @cardNumber";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, mySqlConnection);
                    selectCommand.Parameters.AddWithValue("@cardNumber", cardnumber);

                    double currentBalance = 0;
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentBalance = reader.GetDouble("balance");
                        }
                        else
                        {
                            MessageBox.Show("Card number not found.");
                            return;
                        }
                    }

                    if (currentBalance < withdrawAmount)
                    {
                        MessageBox.Show("Insufficient balance.");
                        return;
                    }

                    double newBalance = currentBalance - withdrawAmount;
                    string updateQuery = "UPDATE user SET balance = @balance WHERE cardNumber = @cardNumber";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, mySqlConnection);
                    updateCommand.Parameters.AddWithValue("@balance", newBalance);
                    updateCommand.Parameters.AddWithValue("@cardNumber", cardnumber);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Withdrawal successful!");
                    }
                    else
                    {
                        MessageBox.Show("Withdrawal failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options o = new Options(user);
            o.ShowDialog(); 
            this.Close();
        }
    }
}
