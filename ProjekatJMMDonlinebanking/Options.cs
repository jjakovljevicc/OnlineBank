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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjekatJMMDonlinebanking
{
    public partial class Options : Form
    {
        private User user;  
        public Options(User user)
        {
            InitializeComponent();
            this.user = user; 
        }

        private void btnViewBalance_Click(object sender, EventArgs e)
        {
            string cardnum = user.cardnumber;

            string mysqlCon = "server=127.0.0.1; user=root; database=onlinebank; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Connection success");

                MySqlCommand selectcommand = new MySqlCommand("select * from user", mySqlConnection);
                MySqlDataReader reader = selectcommand.ExecuteReader();

                while (reader.Read()) 
                {
                    if(cardnum.Equals(reader.GetString("cardNumber")))
                    {
                        MessageBox.Show(reader.GetDouble("balance").ToString());
                    }
                }
                mySqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mySqlConnection.Close();
            }
            mySqlConnection.Close(); 
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
            this.Hide();
            Deposit d = new Deposit(user);
            d.ShowDialog();
            this.Close();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Withdraw w = new Withdraw(user);
            w.ShowDialog();
            this.Close();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer t = new Transfer(user); 
            t.ShowDialog();
            this.Close();   
        }
    }
}
