using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatJMMDonlinebanking
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
            string mysqlCon = "server=127.0.0.1; user=root; database=onlinebank; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Connection success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.tbName.Text) || String.IsNullOrEmpty(this.tbLastName.Text) || String.IsNullOrEmpty(this.tbCardCode.Text) || String.IsNullOrEmpty(this.tbCardNumber.Text) || String.IsNullOrEmpty(this.dateTimePicker1.Text)) 
            {
                MessageBox.Show("Fill with informations!");
            }
            else
            {
                string connectionString = "server=127.0.0.1; user=root; database=onlinebank; password=";
                string selectQuery = "SELECT COUNT(*) FROM user WHERE cardNumber = @cardNumber";

                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);

                try
                {
                    connection.Open();
                    selectCommand.Parameters.AddWithValue("@cardNumber", tbCardNumber.Text);
                    int existingCount = Convert.ToInt32(selectCommand.ExecuteScalar());

                    if (existingCount > 0)
                    {
                        MessageBox.Show("User with this card number already exists! Make sure your information is correct!");
                        return;
                    }

                    string insertQuery = "INSERT INTO user (firstName, lastName, birthDate, cardCode, cardNumber) VALUES (@firstName, @lastName, @birthDate, @cardCode, @cardNumber)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    {
                        insertCommand.Parameters.AddWithValue("@firstName", tbName.Text);
                        insertCommand.Parameters.AddWithValue("@lastName", tbLastName.Text);
                        insertCommand.Parameters.AddWithValue("@birthDate", dateTimePicker1.Value.ToString("d.M.yyyy"));
                        insertCommand.Parameters.AddWithValue("@cardCode", tbCardCode.Text);
                        insertCommand.Parameters.AddWithValue("@cardNumber", tbCardNumber.Text);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data successfully inserted to database");
                        }
                        else
                        {
                            MessageBox.Show("Data unsuccessfully inserted to database");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
                

                this.Hide();
                login login = new login();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
