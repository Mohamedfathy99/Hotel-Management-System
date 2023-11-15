using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Hotel_Sys
{
    public partial class Report2 : Form
         
    {
        CrystalReport2 CR;
        public Report2()
        {
            InitializeComponent();
        }

        private void Report2_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport2();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                room_cmb.Items.Add(v.Value);
        }

        private void report2_btn_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, room_cmb.Text);
            crystalReportViewer2.ReportSource = CR;
        }
    }
}
