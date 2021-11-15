using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
//using System.Data.SqlClient.SqlDataAdapter;
//using System.Data.SqlClient.SqlException;
namespace Railway_Ticketing_Management_System
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }
        //private static string con = "Data Source=VIVOBOOK-8AFSTV\SQLSERVER;Initial Catalog=RTMSDB;Integrated Security=True";
        SqlConnection sqlc = new SqlConnection(@"Data Source=VIVOBOOK-8AFSTV\SQLSERVER;Initial Catalog=RTMSDB;Integrated Security=True");
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(@"Data Source=VIVOBOOK-8AFSTV\SQLSERVER;Initial Catalog=RTMSDB;Integrated Security=True");
            sqlc.Open(); { }
        }
        //public SqlDataAdapter Show()
        //{
        //    SqlConnection connection = new SqlConnection(con);
        //    connection.Open();
        //    string Login = "INSERT INTO login VALUES ('" + unamebox.Text + "','" + passbox.Text + "')";
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Login, connection);
        //    connection.Close();
        //    return sqlDataAdapter;

        //}
        private void button1_Click(object sender, EventArgs e)
        {
            

           // SqlConnection connection = new SqlConnection();
            sqlc.Open();
            string Username = unamebox.Text;
            string Password = passbox.Text;
            string query = "select * from Reg where Username ='" + unamebox.Text + "'and Password ='" + passbox.Text + "'";
            SqlCommand cmd = new SqlCommand(query, sqlc);
            cmd.ExecuteNonQuery();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            SqlDataAdapter Sqladp = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            Sqladp.Fill(ds);
            DataTable dt = ds.Tables[0];
            //if (dt.Rows.Count >0)
            //{

                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();
                MessageBox.Show("Login Successfully!");

            //}
            //else
            //{
            //    MessageBox.Show("Invalid! Please enter correct name and password.");
            //}
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Show();
        }

        
    }
}
