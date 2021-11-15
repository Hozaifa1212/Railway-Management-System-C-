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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void exitbtn2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=VIVOBOOK-8AFSTV\SQLSERVER;Initial Catalog=RTMSDB;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand(" insert into Reg values('" +textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'); ", con);
            object ob = sc.ExecuteNonQuery();
            MessageBox.Show(ob + " :Record has been inserted");
            con.Close();
        }
        public static void main(string[] args)
        {
            Application.Run(new Register());
        }

        private void Register_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=VIVOBOOK-8AFSTV\SQLSERVER;Initial Catalog=RTMSDB;Integrated Security=True");
            connection.Open();
            string query = "select Id, Username, Email from Reg";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
