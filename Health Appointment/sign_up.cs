using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Health_Appointment
{
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

      

        private void sign_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=booking;";
                string query = "INSERT INTO log_in(`user`, `password`) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "')";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                Console.WriteLine("SUCCESFULLY APPOINTED");

                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                databaseConnection.Close();
            }

            else
            {
                MessageBox.Show("creating account failed!!");
            }
        }

        private void Log_in_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.ShowDialog();
            this.Close();
        }
    }
}
