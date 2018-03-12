namespace TinyCollege.Admin
{
    partial class AdminPortalForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.instructorButton = new System.Windows.Forms.Button();
            this.courseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(823, 658);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(196, 87);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.Location = new System.Drawing.Point(135, 261);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(223, 85);
            this.studentButton.TabIndex = 1;
            this.studentButton.Text = "Add &Student";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // instructorButton
            // 
            this.instructorButton.Location = new System.Drawing.Point(135, 132);
            this.instructorButton.Name = "instructorButton";
            this.instructorButton.Size = new System.Drawing.Size(223, 85);
            this.instructorButton.TabIndex = 2;
            this.instructorButton.Text = "Add &Instructor";
            this.instructorButton.UseVisualStyleBackColor = true;
            this.instructorButton.Click += new System.EventHandler(this.instructorButton_Click);
            // 
            // courseButton
            // 
            this.courseButton.Location = new System.Drawing.Point(135, 392);
            this.courseButton.Name = "courseButton";
            this.courseButton.Size = new System.Drawing.Size(223, 85);
            this.courseButton.TabIndex = 3;
            this.courseButton.Text = "Add &Course";
            this.courseButton.UseVisualStyleBackColor = true;
            this.courseButton.Click += new System.EventHandler(this.courseButton_Click);
            // 
            // AdminPortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 785);
            this.Controls.Add(this.courseButton);
            this.Controls.Add(this.instructorButton);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.closeButton);
            this.Name = "AdminPortalForm";
            this.Text = "AdminPortalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button instructorButton;
        private System.Windows.Forms.Button courseButton;
    }
}