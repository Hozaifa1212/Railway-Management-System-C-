using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Railway_Ticketing_Management_System
{
    public partial class Clerk : Form
    {
        public Clerk()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void exit2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=VIVOBOOK-8AFSTV\SQLSERVER;Initial Catalog=RTMSDB;Integrated Security=True");
            connection.Open();
            string query = "select Id, Name, Phone from Passenger";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            SqlDataAdapter Sqladp = new SqlDataAdapter(cmd);
            //connection.Close();
            DataSet ds = new DataSet();
            Sqladp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=VIVOBOOK-8AFSTV\SQLSERVER;Initial Catalog=RTMSDB;Integrated Security=True");
            connection.Open();
            string query = "select * from TrainInfo";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            SqlDataAdapter Sqladp = new SqlDataAdapter(cmd);
            //connection.Close();
            DataSet ds = new DataSet();
            Sqladp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void btnsave2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=VIVOBOOK-8AFSTV\SQLSERVER;Initial Catalog=RTMSDB;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand(" insert into Passenger values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'); ", con);
            object ob = sc.ExecuteNonQuery();
            MessageBox.Show(ob + " :Record has been inserted");
            con.Close();
        }

        private void dataGridViewReserv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=VIVOBOOK-8AFSTV\SQLSERVER;Initial Catalog=RTMSDB;Integrated Security=True");
            connection.Open();
            string query = "select * from TrainInfo";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            SqlDataAdapter Sqladp = new SqlDataAdapter(cmd);
            //connection.Close();
            DataSet ds = new DataSet();
            Sqladp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridViewReserv.AutoGenerateColumns = false;
            dataGridViewReserv.DataSource = dt;
            dataGridViewReserv.Refresh();
        }

       

   
    }
}
