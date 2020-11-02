using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Appointment
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Booking Book = new Booking();
            Book.ShowDialog();
            this.Close();
        }
        private void list_appointment_Click(object sender, EventArgs e)
        {
            health_appointment HA = new health_appointment();
            HA.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.ShowDialog();
            this.Close();
        }
    }
}
