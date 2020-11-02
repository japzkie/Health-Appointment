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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection Connection = new MySqlConnection ("datasource=127.0.0.1;port=3306;username=root;password=;database=booking;");

        MySqlDataAdapter adapter;
        DataTable table = new DataTable();

        private void log_in_Click(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("SELECT `user`, `password` FROM `log_in` WHERE `user` = '" + textBox1.Text + "' AND `password` = '" + textBox2.Text + "'", Connection);
            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
             
                MessageBox.Show ( "Username Or Password Are Invalid");
                textBox1.Clear();
                textBox2.Clear();
            
            }
            else
            {
                mainmenu main = new mainmenu();
                main.ShowDialog();
                this.Close();
            }

        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            sign_up sign = new sign_up();
            sign.ShowDialog();
            this.Close();
        }
    }
}
