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
    public partial class Transfer : Form
    {
        private User user;

        public Transfer(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options o = new Options(user); 
            o.ShowDialog();
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string senderCardCode = user.cardcode;
            string recipientCardNumber = tbRecipientCardNumber.Text;
            string transferAmountText = tbAmount.Text;
            string enteredSenderCardCode = tbSenderCardCode.Text;
            string mysqlCon = "server=127.0.0.1;user=root;database=onlinebank;password=";

            if (String.IsNullOrEmpty(transferAmountText) || String.IsNullOrEmpty(recipientCardNumber) || String.IsNullOrEmpty(enteredSenderCardCode))
            {
                MessageBox.Show("Fill in all the information!");
                return;
            }

            if (!double.TryParse(transferAmountText, out double transferAmount) || transferAmount <= 0)
            {
                MessageBox.Show("Enter a valid transfer amount.");
                return;
            }

            if (!senderCardCode.Equals(enteredSenderCardCode))
            {
                MessageBox.Show("Incorrect sender card code.");
                return;
            }

            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                try
                {
                    mySqlConnection.Open(); 

                    
                    string senderBalanceQuery = "SELECT cardNumber, balance FROM user WHERE cardCode = @cardCode";
                    MySqlCommand senderBalanceCommand = new MySqlCommand(senderBalanceQuery, mySqlConnection);
                    senderBalanceCommand.Parameters.AddWithValue("@cardCode", senderCardCode);

                    string senderCardNumber = null;
                    double senderCurrentBalance = 0;
                    using (MySqlDataReader reader = senderBalanceCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            senderCardNumber = reader.GetString("cardNumber");
                            senderCurrentBalance = reader.GetDouble("balance");
                        }
                        else
                        {
                            MessageBox.Show("Sender not found.");
                            return;
                        }
                    }

                    if (senderCurrentBalance < transferAmount)
                    {
                        MessageBox.Show("Insufficient balance.");
                        return;
                    }

                    string recipientQuery = "SELECT balance FROM user WHERE cardNumber = @cardNumber";
                    MySqlCommand recipientCommand = new MySqlCommand(recipientQuery, mySqlConnection);
                    recipientCommand.Parameters.AddWithValue("@cardNumber", recipientCardNumber);

                    double recipientCurrentBalance = 0;
                    using (MySqlDataReader reader = recipientCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            recipientCurrentBalance = reader.GetDouble("balance");
                        }
                        else
                        {
                            MessageBox.Show("Recipient card number not found.");
                            return;
                        }
                    }

                    MySqlTransaction transaction = mySqlConnection.BeginTransaction();

                    try
                    {
                        string updateSenderQuery = "UPDATE user SET balance = @balance WHERE cardNumber = @cardNumber";
                        MySqlCommand updateSenderCommand = new MySqlCommand(updateSenderQuery, mySqlConnection);
                        updateSenderCommand.Parameters.AddWithValue("@balance", senderCurrentBalance - transferAmount);
                        updateSenderCommand.Parameters.AddWithValue("@cardNumber", senderCardNumber);
                        updateSenderCommand.Transaction = transaction;
                        updateSenderCommand.ExecuteNonQuery();

                        string updateRecipientQuery = "UPDATE user SET balance = @balance WHERE cardNumber = @cardNumber";
                        MySqlCommand updateRecipientCommand = new MySqlCommand(updateRecipientQuery, mySqlConnection);
                        updateRecipientCommand.Parameters.AddWithValue("@balance", recipientCurrentBalance + transferAmount);
                        updateRecipientCommand.Parameters.AddWithValue("@cardNumber", recipientCardNumber);
                        updateRecipientCommand.Transaction = transaction;
                        updateRecipientCommand.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Transfer successful!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"An error occurred during the transfer: {ex.Message}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
