namespace TinyCollege.Admins
{
    partial class AddCourseForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.seatsBox = new System.Windows.Forms.TextBox();
            this.courseIdBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.instructorIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(105, 384);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(151, 66);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "&Add Course";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(458, 384);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(135, 66);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // seatsBox
            // 
            this.seatsBox.Location = new System.Drawing.Point(278, 121);
            this.seatsBox.Name = "seatsBox";
            this.seatsBox.Size = new System.Drawing.Size(100, 26);
            this.seatsBox.TabIndex = 2;
            // 
            // courseIdBox
            // 
            this.courseIdBox.Location = new System.Drawing.Point(278, 71);
            this.courseIdBox.Name = "courseIdBox";
            this.courseIdBox.Size = new System.Drawing.Size(100, 26);
            this.courseIdBox.TabIndex = 3;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(278, 168);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(100, 26);
            this.titleBox.TabIndex = 4;
            // 
            // instructorIdBox
            // 
            this.instructorIdBox.Location = new System.Drawing.Point(278, 218);
            this.instructorIdBox.Name = "instructorIdBox";
            this.instructorIdBox.Size = new System.Drawing.Size(100, 26);
            this.instructorIdBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Course Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seats Available";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Course Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Instructor ID";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(190, 277);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Active?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 539);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instructorIdBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.courseIdBox);
            this.Controls.Add(this.seatsBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox seatsBox;
        private System.Windows.Forms.TextBox courseIdBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox instructorIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}