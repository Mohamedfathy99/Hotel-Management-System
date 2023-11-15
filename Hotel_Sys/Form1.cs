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
    public partial class Form1 : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select CUSTOMER_ID from CUSTOMER";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_id.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select FIRST_NAME,LAST_NAME,ADDRESS,PHONE,EMAIL,CUSTOMER_PASSWORD  from CUSTOMER where CUSTOMER_ID =:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", cmb_id.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                txtFirstName.Text = dr[0].ToString();
                txtLastName.Text = dr[1].ToString();
                txtAddress.Text = dr[2].ToString();
                txtPhone.Text = dr[3].ToString();
                txtEmail.Text = dr[4].ToString();
                txtPassword.Text = dr[5].ToString();
            }
            dr.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into CUSTOMER values(:id,:firstname,:lastname,:address,:phone,:email,:password)";
            cmd.Parameters.Add("id", cmb_id.Text);
            cmd.Parameters.Add("firstname", txtFirstName.Text);
            cmd.Parameters.Add("lastname", txtLastName.Text);
            cmd.Parameters.Add("address", txtAddress.Text);
            cmd.Parameters.Add("phone", txtPhone.Text);
            cmd.Parameters.Add("email", txtEmail.Text);
            cmd.Parameters.Add("password", txtPassword.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                cmb_id.Items.Add(cmb_id.Text);
                MessageBox.Show("New Customer is added");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText= "update CUSTOMER set FIRST_NAME =:firstname,LAST_NAME =:lastname ,ADDRESS=:address,PHONE=:phone,EMAIL=:email,CUSTOMER_PASSWORD=:password where CUSTOMER_ID =:id";
            c.Parameters.Add("firstname", txtFirstName.Text);
            c.Parameters.Add("lastname", txtLastName.Text);
            c.Parameters.Add("address", txtAddress.Text);
            c.Parameters.Add("phone", txtPhone.Text);
            c.Parameters.Add("email", txtEmail.Text);
            c.Parameters.Add("password", txtPassword.Text);
            c.Parameters.Add("id", cmb_id.SelectedItem.ToString());
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
               
                MessageBox.Show(" Customer is modified");
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText= "Delete from CUSTOMER  where CUSTOMER_ID =:id";
            c.Parameters.Add("id", cmb_id.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show(" Customer is deleted");
                cmb_id.Items.RemoveAt(cmb_id.SelectedIndex);
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";

            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            new Home().Show();
        }
    }
}
