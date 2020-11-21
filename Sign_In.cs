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
using System.Data.Sql;
using System.Data.SqlTypes;

namespace EasyTestApp
{
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMiniMax_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Signupform signup = new Signupform(); // open a new sign up window
            signup.Show();

            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB);Initial Catalog=EasyTestDB");//again, db properties
            string query = "Select * from Users Where username = '" + txtUsername.Text.Trim() + "' and password = '"+txtPassword.Text.Trim()+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                Student_Homepage objHome = new Student_Homepage();
                this.Hide();
                objHome.Show(); // go to the homepage
            }
            else
            {
                MessageBox.Show("The password or username does not match!");
            }

        }
    }
}
