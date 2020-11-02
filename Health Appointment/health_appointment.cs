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
    public partial class health_appointment : Form
    {
        public health_appointment()
        {
            InitializeComponent();
        }
        private void health_appointment_Load(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=;database=booking;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM appointment", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Booking book = new Booking();
            book.ShowDialog();
            this.Close();
        }
    }
}
