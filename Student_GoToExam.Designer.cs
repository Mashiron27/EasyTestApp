namespace EasyTestApp
{
    partial class Student_GoToExam
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
            this.chooseExamTitleLabel = new System.Windows.Forms.Label();
            this.examListDropdown = new System.Windows.Forms.ComboBox();
            this.goToExamNextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseExamTitleLabel
            // 
            this.chooseExamTitleLabel.AutoSize = true;
            this.chooseExamTitleLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.chooseExamTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.chooseExamTitleLabel.Location = new System.Drawing.Point(226, 136);
            this.chooseExamTitleLabel.Name = "chooseExamTitleLabel";
            this.chooseExamTitleLabel.Size = new System.Drawing.Size(180, 17);
            this.chooseExamTitleLabel.TabIndex = 1;
            this.chooseExamTitleLabel.Text = "Please choose the exam:";
            // 
            // examListDropdown
            // 
            this.examListDropdown.FormattingEnabled = true;
            this.examListDropdown.Location = new System.Drawing.Point(128, 198);
            this.examListDropdown.Name = "examListDropdown";
            this.examListDropdown.Size = new System.Drawing.Size(399, 21);
            this.examListDropdown.TabIndex = 2;
            // 
            // goToExamNextButton
            // 
            this.goToExamNextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
            this.goToExamNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goToExamNextButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.goToExamNextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.goToExamNextButton.Location = new System.Drawing.Point(250, 256);
            this.goToExamNextButton.Name = "goToExamNextButton";
            this.goToExamNextButton.Size = new System.Drawing.Size(116, 35);
            this.goToExamNextButton.TabIndex = 3;
            this.goToExamNextButton.Text = "Enter Exam!";
            this.goToExamNextButton.UseVisualStyleBackColor = false;
            this.goToExamNextButton.Click += new System.EventHandler(this.goToExamNextButton_Click);
            // 
            // Student_GoToExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.goToExamNextButton);
            this.Controls.Add(this.examListDropdown);
            this.Controls.Add(this.chooseExamTitleLabel);
            this.Name = "Student_GoToExam";
            this.Size = new System.Drawing.Size(679, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseExamTitleLabel;
        private System.Windows.Forms.ComboBox examListDropdown;
        private System.Windows.Forms.Button goToExamNextButton;
    }
}
