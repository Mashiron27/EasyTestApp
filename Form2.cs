using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SignupForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void picMaximize_Click(object sender, EventArgs e)
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

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabelSign_Up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 r = new Form3;
            r.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@'copy from database property');
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From database_name where Username = '"+txtUsername.Text+"' and Password = '"+txtPassword.Text+"'",con)
            DataTable dt = new DataTable();
            sda.Fill(dt)
                
            if(dt.Rows[0][0].ToString == "1")
            {
                this.Hide();

                //Home home = new Home;
                //home.Show();

            }
            else
            {
                MessageBox.Show("Please check your username and your password!");
            }
        }
    }
}
