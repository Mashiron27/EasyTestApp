using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SignupForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void picMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtCPassword.Text && txtUsername.Text != "" && txtPrivileges.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=//enterhere;Initial Catalog=//;Persist Security Info = True;UserID = //");
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From database_name where Username = '" + txtUsername.Text + "'", con)
                DataTable dt = new DataTable();
                sda.Fill(dt)


                if (dt.Rows[0][0].ToString == "1")
                {
                    this.Hide();

                    MessageBox.Show("You have registered!");

                }

                string newcom = "insert into db_name(v1,v2.v3...) VALUES ('" + txtUsername.Text + "','" + txtPrivileges + "','" + txtPassword + "')";
                SqlCommand cmd = new SqlCommand(newcom, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfuly sign up!");
                Clear();
            }
            else
            {
                MessageBox.Show("Invalid information!");
                Clear();
            }
        }

        void Clear()
        {
            txtUsername.Text = txtPrivileges.Text = txtPassword.Text = txtCPassword.Text = "";
        }
        private void linklblSignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 m = new Form2;
            m.Show();
            this.Hide();
        }
    }
}
