using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Sys
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void insertion_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void hotel_btn_Click(object sender, EventArgs e)
        {
            new Reportcs().Show();
        }

        private void room_btn_Click(object sender, EventArgs e)
        {
            new Report2().Show();
        }
    }
}
