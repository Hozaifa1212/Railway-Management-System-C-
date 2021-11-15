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
    public partial class Railway_System : Form
    {
       
        public Railway_System()
        {
            InitializeComponent();
        }

        private void exit2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
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
            dataGridViewR1.AutoGenerateColumns = false;
            dataGridViewR1.DataSource = dt;
            dataGridViewR1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=VIVOBOOK-8AFSTV\SQLSERVER;Initial Catalog=RTMSDB;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand(" insert into TrainInfo values('" + textBoxTname.Text + "','" + textBoxTrainid + "','" + textBoxTcap.Text + "''" + textBoxTs.Text + "'); ", con);
            object ob = sc.ExecuteNonQuery();
            MessageBox.Show(ob + " :Record has been inserted");
            con.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=VIVOBOOK-8AFSTV\SQLSERVER;Initial Catalog=RTMSDB;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand(" insert into travel values('" +textBox12.Text + "','" + textBox11.Text + "''" + textBox10.Text + "','" + textBox9.Text + "',); ", con);
            object ob = sc.ExecuteNonQuery();
            MessageBox.Show(ob + " :Record has been inserted");
            con.Close();
        }

        private void dataGridViewR1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=VIVOBOOK-8AFSTV\SQLSERVER;Initial Catalog=RTMSDB;Integrated Security=True");
            connection.Open();
            string query = "select * from travel";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            SqlDataAdapter Sqladp = new SqlDataAdapter(cmd);
            //connection.Close();
            DataSet ds = new DataSet();
            Sqladp.Fill(ds);
            DataTable dt = ds.Tables[0];
            //dataGridViewtr.AutoGenerateColumns = false;
            dataGridViewtr.DataSource = dt;
            dataGridViewtr.Refresh();
        }

        
    }
}
