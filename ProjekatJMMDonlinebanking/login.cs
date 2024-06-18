using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjekatJMMDonlinebanking
{
    public partial class login : Form
    {
        public static User currentUser = new User();
        public login()
        {
            InitializeComponent();


            string mysqlCon = "server=127.0.0.1; user=root; database=onlinebank; password="; 
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Connection success");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signin Signin = new signin(); 
            Signin.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=onlinebank; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Connection success");
                if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Fill with informations!");

                }
                else
                {
                    currentUser.cardnumber = textBox1.Text;
                    currentUser.cardcode = textBox2.Text;

                    MySqlCommand selectcommand = new MySqlCommand("select * from user", mySqlConnection);
                    MySqlDataReader reader = selectcommand.ExecuteReader();

                    while (reader.Read())
                    {
                        if (currentUser.cardnumber.Equals(reader.GetString("cardNumber")) && currentUser.cardcode.Equals(reader.GetString("cardCode")))
                        {
                            MessageBox.Show("Successful log in!" + "\n" + reader.GetString("firstName") + "\n" + reader.GetString("lastName") + "\n" + reader.GetString("birthDate"));

                            this.Hide();
                            Options options = new Options(currentUser);
                            options.ShowDialog();
                            this.Close();
                            break; 
                        }
                    }
                    MessageBox.Show("Wrong information try again");
                    
                }
                mySqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mySqlConnection.Close();
            }

            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox1.Text == "AdminiJMMD" && textBox2.Text == "JMMDbank1234")
            {
                MessageBox.Show("SUCCESSFUL ADMIN LOG IN");

                this.Hide();
                Admin a = new Admin();
                a.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("FIll with admin informations"); 
            }
        }

        
    }
}
