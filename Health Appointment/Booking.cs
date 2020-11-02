using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Health_Appointment
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        [DllImport("MyDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern string submit(string PN, string Phone, string EA, string birthdate, string disease, string appointdate);
        private void Submit_Click(object sender, EventArgs e)
        {
            string PN = textBox1.Text;
            string Phone = textBox2.Text;
            string EA = textBox3.Text;
            string birthdate = textBox4.Text;
            string disease = textBox5.Text;
            string appointdate = textBox6.Text;
            
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=booking;";
                string query = "INSERT INTO appointment(`Patient_Name`, `Phone`, `Email_address`,`Date_Of_Birth`,`Disease_Type`,`Appointment_Date`) VALUES ('" + textBox1.Text + "', " +
                "'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;


                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                databaseConnection.Close();
                MessageBox.Show("SUCCESFULLY APPOINTED");
             

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            health_appointment HA = new health_appointment();
            HA.ShowDialog();
        }
    }
}
