using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace EasyTestApp
{
	public partial class TeacherCorrectExamBot : UserControl
	{
		public TeacherCorrectExamBot()
		{
			InitializeComponent();
			Bitmap img1 = new Bitmap("./ExtractTextFromPhoto_Bot/1.jpg");
			TesseractEngine engine = new TesseractEngine("./ExtractTextFromPhoto_Bot/trainedData", "eng", EngineMode.Default);
			Page page1 = engine.Process(img1, PageSegMode.Auto);
			string res1 = page1.GetText();
			result.Text = res1;
		}

		private void Next_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
