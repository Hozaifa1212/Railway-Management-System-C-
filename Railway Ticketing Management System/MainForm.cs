using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Railway_Ticketing_Management_System
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clerk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clerk clr = new Clerk();
            clr.Show();
        }

        private void Railwaysys_Click(object sender, EventArgs e)
        {
            this.Hide();
            Railway_System rs = new Railway_System();
            rs.Show();
        }

        private void exit2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void clerk_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Clerk clr = new Clerk();
            clr.Show();

        }

        private void Railwaysys_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Railway_System rs = new Railway_System();
            rs.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
