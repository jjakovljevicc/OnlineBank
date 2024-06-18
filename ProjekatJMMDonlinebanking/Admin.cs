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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.ShowDialog();
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string cardnumber = tbCardNumber.Text;
            string mysqlCon = "server=127.0.0.1;user=root;database=onlinebank;password=";

            if (String.IsNullOrEmpty(cardnumber))
            {
                MessageBox.Show("Please enter a card number!");
                return;
            }

            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                try
                {
                    mySqlConnection.Open(); 

                    string checkUserQuery = "SELECT COUNT(*) FROM user WHERE cardNumber = @cardNumber";
                    MySqlCommand checkUserCommand = new MySqlCommand(checkUserQuery, mySqlConnection);
                    checkUserCommand.Parameters.AddWithValue("@cardNumber", cardnumber);

                    int userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());
                    if (userCount == 0)
                    {
                        MessageBox.Show("User with this card number does not exist.");
                        return;
                    }

                    string deleteUserQuery = "DELETE FROM user WHERE cardNumber = @cardNumber";
                    MySqlCommand deleteUserCommand = new MySqlCommand(deleteUserQuery, mySqlConnection);
                    deleteUserCommand.Parameters.AddWithValue("@cardNumber", cardnumber);

                    int rowsAffected = deleteUserCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user.");
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
