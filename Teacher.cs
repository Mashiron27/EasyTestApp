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
	public partial class Teacher : Form
	{
		public Teacher()
		{
			InitializeComponent();
			teacherUserControl11.Visible = true;

		}

		private void Teacher_Load(object sender, EventArgs e)
		{
			label1.Text = DateTime.Now.ToLongDateString();
			label2.Text = DateTime.Now.ToLongTimeString();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			teacherAddExam1.Visible = false;
			teacherUserControl11.Visible = false;
			teacherAddExam1.Visible = true;
			teacherStatisticsStudent1.Visible = false;
			teacherStatisticsExam1.Visible = false;
			teacherStatistics1.Visible = false;
			teacherCreateExamTime1.Visible = false;
			teacherCalendar1.Visible = false;
			teacherCorrectExamManually1.Visible = false;
			teacherCorrectExamBot1.Visible = false;
			teacherCorrectExam1.Visible = false;
			teacherAddExamSave1.Visible = false;
			teacherAddExam21.Visible = false;
			teacherAddExam11.Visible = false;
			teacherClassManangementViewStudents1.Visible = false;
			teacherClassManangementChooseStudent1.Visible = false;
			teacherClassManagement1.Visible = false;


		}

		private void button2_Click(object sender, EventArgs e)
		{
			teacherAddExam1.Visible = false;
			teacherUserControl11.Visible = false;
			teacherAddExam1.Visible = false;
			teacherStatisticsStudent1.Visible = false;
			teacherStatisticsExam1.Visible = false;
			teacherStatistics1.Visible = false;
			teacherCreateExamTime1.Visible = false;
			teacherCalendar1.Visible = false;
			teacherCorrectExamManually1.Visible = false;
			teacherCorrectExamBot1.Visible = false;
			teacherCorrectExam1.Visible = true;
			teacherAddExamSave1.Visible = false;
			teacherAddExam21.Visible = false;
			teacherAddExam11.Visible = false;
			teacherClassManangementViewStudents1.Visible = false;
			teacherClassManangementChooseStudent1.Visible = false;
			teacherClassManagement1.Visible = false;



		}

		private void button3_Click(object sender, EventArgs e)
		{
			teacherAddExam1.Visible = false;
			teacherUserControl11.Visible = false;
			teacherAddExam1.Visible = false;
			teacherStatisticsStudent1.Visible = false;
			teacherStatisticsExam1.Visible = false;
			teacherStatistics1.Visible = true;
			teacherCreateExamTime1.Visible = false;
			teacherCalendar1.Visible = false;
			teacherCorrectExamManually1.Visible = false;
			teacherCorrectExamBot1.Visible = false;
			teacherCorrectExam1.Visible = true;
			teacherAddExamSave1.Visible = false;
			teacherAddExam21.Visible = false;
			teacherAddExam11.Visible = false;
			teacherClassManangementViewStudents1.Visible = false;
			teacherClassManangementChooseStudent1.Visible = false;
			teacherClassManagement1.Visible = false;


		}

		private void button4_Click(object sender, EventArgs e)
		{

			teacherAddExam1.Visible = false;
			teacherUserControl11.Visible = false;
			teacherAddExam1.Visible = false;
			teacherStatisticsStudent1.Visible = false;
			teacherStatisticsExam1.Visible = false;
			teacherStatistics1.Visible = false;
			teacherCreateExamTime1.Visible = false;
			teacherCalendar1.Visible = false;
			teacherCorrectExamManually1.Visible = false;
			teacherCorrectExamBot1.Visible = false;
			teacherCorrectExam1.Visible = false;
			teacherAddExamSave1.Visible = false;
			teacherAddExam21.Visible = false;
			teacherAddExam11.Visible = false;
			teacherClassManangementViewStudents1.Visible = false;
			teacherClassManangementChooseStudent1.Visible = false;
			teacherClassManagement1.Visible = true;



		}

		private void button5_Click(object sender, EventArgs e)
		{

			teacherAddExam1.Visible = false;
			teacherUserControl11.Visible = false;
			teacherAddExam1.Visible = false;
			teacherStatisticsStudent1.Visible = false;
			teacherStatisticsExam1.Visible = false;
			teacherStatistics1.Visible = true;
			teacherCreateExamTime1.Visible = false;
			teacherCalendar1.Visible = false;
			teacherCorrectExamManually1.Visible = false;
			teacherCorrectExamBot1.Visible = false;
			teacherCorrectExam1.Visible = false;
			teacherAddExamSave1.Visible = false;
			teacherAddExam21.Visible = false;
			teacherAddExam11.Visible = false;
			teacherClassManangementViewStudents1.Visible = false;
			teacherClassManangementChooseStudent1.Visible = false;
			teacherClassManagement1.Visible = false;

		}

		private void teacherClassManangementViewStudents1_Load(object sender, EventArgs e)
		{

		}

		private void teacherAddExam1_Load(object sender, EventArgs e)
		{

		}

		private void btnProfile_Click(object sender, EventArgs e)
		{

		}
	}
}
