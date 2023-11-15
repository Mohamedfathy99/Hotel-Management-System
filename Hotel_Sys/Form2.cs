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
    public partial class Form2 : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            txt_start.Text = DateTime.Now.ToString();
            txt_end.Text = DateTime.Now.AddDays(3).ToString();

        }

        private void showrooms_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "get_avilable_rooms2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("kind",txt_kind.Text);
            cmd.Parameters.Add("id", OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                cmb_rooms.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxID, newID;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Get_Reservation_id";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                maxID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                newID = maxID + 1;

            }
            catch
            {
                newID = 1;
            }
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "insert_reservation";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("RID",newID);
            c.Parameters.Add("CID",txt_customer.Text);
            c.Parameters.Add("Fname", txt_firstname.Text);
            c.Parameters.Add("lname", txt_lastname.Text);
            c.Parameters.Add("startreserv",Convert.ToDateTime(txt_start.Text));
            c.Parameters.Add("endreserv", Convert.ToDateTime(txt_end.Text));
            c.ExecuteNonQuery();
            MessageBox.Show("Reservation info  stored successfuly");
            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;
            c2.CommandText = "update_status";
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("id", cmb_rooms.SelectedItem.ToString());
            c2.ExecuteNonQuery();
            MessageBox.Show("Room Status  updated successfuly");






        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            new Home().Show();
        }
    }
}
