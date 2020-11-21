
namespace EasyTestApp
{
	partial class TeacherStatistics
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
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
			this.label1.Location = new System.Drawing.Point(264, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 20);
			this.label1.TabIndex = 21;
			this.label1.Text = "Show statistics for";
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.radioButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
			this.radioButton4.Location = new System.Drawing.Point(403, 216);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(102, 24);
			this.radioButton4.TabIndex = 31;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "An exam";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
			this.radioButton3.Location = new System.Drawing.Point(186, 216);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(110, 24);
			this.radioButton3.TabIndex = 32;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "A student";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
			this.button5.Location = new System.Drawing.Point(470, 380);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(116, 35);
			this.button5.TabIndex = 33;
			this.button5.Text = "Next";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// TeacherStatistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
			this.Controls.Add(this.button5);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton4);
			this.Controls.Add(this.label1);
			this.Name = "TeacherStatistics";
			this.Size = new System.Drawing.Size(679, 463);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Button button5;
	}
}
