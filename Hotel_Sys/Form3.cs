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
    public partial class Form3 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public Form3()
        {
            InitializeComponent();
        }

        private void Load_Info_Click(object sender, EventArgs e)
        {
            string constr = "Data source=orcl;User Id=scott; Password=tiger;";
            string cmdstr = "";
            if (rdo_customer.Checked)
                cmdstr = "select * from customer";
            else if (rdo_employee.Checked)
                cmdstr = "select * from employee";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            new Home().Show();
        }
    }
}
