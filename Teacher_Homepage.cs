using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTestApp
{
    public partial class Teacher_Homepage : Form
    {
        public Teacher_Homepage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMiniMax_Click(object sender, EventArgs e)
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

        private void Teacher_Homepage_Load(object sender, EventArgs e)
        {
            TeacherAddExam.Hide();
            TeacherCorrectExam.Hide();
            TeacherStatistics.Hide();
            TeacherClassManagement.Hide();
            TeacherCalendar.Hide();
            TeacherProfile.Hide();
        }

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            TeacherAddExam.Show();
            TeacherCorrectExam.Hide();
            TeacherStatistics.Hide();
            TeacherClassManagement.Hide();
            TeacherCalendar.Hide();
            TeacherProfile.Hide();

            TeacherAddExam.BringToFront();
        }

        private void btnCorrectExams_Click(object sender, EventArgs e)
        {
            TeacherAddExam.Hide();
            TeacherCorrectExam.Show();
            TeacherStatistics.Hide();
            TeacherClassManagement.Hide();
            TeacherCalendar.Hide();
            TeacherProfile.Hide();

            TeacherCorrectExam.BringToFront();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            TeacherAddExam.Hide();
            TeacherCorrectExam.Hide();
            TeacherStatistics.Show();
            TeacherClassManagement.Hide();
            TeacherCalendar.Hide();
            TeacherProfile.Hide();

            TeacherStatistics.BringToFront();
        }

        private void btnClassManagement_Click(object sender, EventArgs e)
        {
            TeacherAddExam.Hide();
            TeacherCorrectExam.Hide();
            TeacherStatistics.Hide();
            TeacherClassManagement.Show();
            TeacherCalendar.Hide();
            TeacherProfile.Hide();

            TeacherClassManagement.BringToFront();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            TeacherAddExam.Hide();
            TeacherCorrectExam.Hide();
            TeacherStatistics.Hide();
            TeacherClassManagement.Hide();
            TeacherCalendar.Show();
            TeacherProfile.Hide();

            TeacherCalendar.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            TeacherAddExam.Hide();
            TeacherCorrectExam.Hide();
            TeacherStatistics.Hide();
            TeacherClassManagement.Hide();
            TeacherCalendar.Hide();
            TeacherProfile.Show();
            TeacherProfile.BringToFront();
        }
    }
}
