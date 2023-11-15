using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Hotel_Sys
{
    public partial class Reportcs : Form
    {
        CrystalReport1 CR;
        public Reportcs()
        {
            InitializeComponent();
        }

        private void Reportcs_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
        }

        private void report1_btn_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
