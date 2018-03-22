namespace TinyCollege.Instructors
{
    partial class SelectCourseForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gradeBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.selecCourseButton = new System.Windows.Forms.Button();
            this.selectStudentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Course";
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(206, 58);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(151, 21);
            this.courseComboBox.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(75, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(354, 107);
            this.dataGridView.TabIndex = 2;
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(206, 231);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(151, 21);
            this.studentComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter a Grade";
            // 
            // gradeBox
            // 
            this.gradeBox.Location = new System.Drawing.Point(206, 276);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(100, 20);
            this.gradeBox.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(331, 327);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 41);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(83, 327);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 41);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // selecCourseButton
            // 
            this.selecCourseButton.Location = new System.Drawing.Point(398, 50);
            this.selecCourseButton.Name = "selecCourseButton";
            this.selecCourseButton.Size = new System.Drawing.Size(75, 35);
            this.selecCourseButton.TabIndex = 9;
            this.selecCourseButton.Text = "Select Course";
            this.selecCourseButton.UseVisualStyleBackColor = true;
            this.selecCourseButton.Click += new System.EventHandler(this.selecCourseButton_Click);
            // 
            // selectStudentButton
            // 
            this.selectStudentButton.Location = new System.Drawing.Point(398, 222);
            this.selectStudentButton.Name = "selectStudentButton";
            this.selectStudentButton.Size = new System.Drawing.Size(75, 37);
            this.selectStudentButton.TabIndex = 10;
            this.selectStudentButton.Text = "Select Sutdent";
            this.selectStudentButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a Student";
            // 
            // SelectCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 389);
            this.Controls.Add(this.selectStudentButton);
            this.Controls.Add(this.selecCourseButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.label1);
            this.Name = "SelectCourseForm";
            this.Text = "SelectCourseForm";
            this.Load += new System.EventHandler(this.SelectCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gradeBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button selecCourseButton;
        private System.Windows.Forms.Button selectStudentButton;
        private System.Windows.Forms.Label label2;
    }
}