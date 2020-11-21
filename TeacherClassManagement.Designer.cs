
namespace EasyTestApp
{
	partial class TeacherClassManagement
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.courses = new System.Windows.Forms.ListBox();
			this.classes = new System.Windows.Forms.ListBox();
			this.Next = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// courses
			// 
			this.courses.FormattingEnabled = true;
			this.courses.ItemHeight = 16;
			this.courses.Location = new System.Drawing.Point(229, 110);
			this.courses.Name = "courses";
			this.courses.Size = new System.Drawing.Size(244, 20);
			this.courses.TabIndex = 8;
			this.courses.SelectedIndexChanged += new System.EventHandler(this.courses_SelectedIndexChanged);
			// 
			// classes
			// 
			this.classes.FormattingEnabled = true;
			this.classes.ItemHeight = 16;
			this.classes.Location = new System.Drawing.Point(229, 196);
			this.classes.Name = "classes";
			this.classes.Size = new System.Drawing.Size(244, 20);
			this.classes.TabIndex = 10;
			// 
			// Next
			// 
			this.Next.Location = new System.Drawing.Point(692, 401);
			this.Next.Name = "Next";
			this.Next.Size = new System.Drawing.Size(75, 23);
			this.Next.TabIndex = 16;
			this.Next.Text = "Next";
			this.Next.UseVisualStyleBackColor = true;
			this.Next.Click += new System.EventHandler(this.Next_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
			this.label1.Location = new System.Drawing.Point(265, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 20);
			this.label1.TabIndex = 20;
			this.label1.Text = "Choose a course";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
			this.label2.Location = new System.Drawing.Point(252, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(192, 20);
			this.label2.TabIndex = 21;
			this.label2.Text = "Choose a class/group";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
			this.button5.Location = new System.Drawing.Point(69, 273);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(177, 35);
			this.button5.TabIndex = 22;
			this.button5.Text = "View all students";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
			this.button4.Location = new System.Drawing.Point(269, 273);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(166, 35);
			this.button4.TabIndex = 23;
			this.button4.Text = "Add a student";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
			this.button6.Location = new System.Drawing.Point(465, 273);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(169, 35);
			this.button6.TabIndex = 24;
			this.button6.Text = "Remove a student";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// TeacherClassManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Next);
			this.Controls.Add(this.classes);
			this.Controls.Add(this.courses);
			this.Name = "TeacherClassManagement";
			this.Size = new System.Drawing.Size(679, 463);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox courses;
		private System.Windows.Forms.ListBox classes;
		private System.Windows.Forms.Button Next;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button6;
	}
}
