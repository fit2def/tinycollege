namespace TinyCollege
{
    partial class MainForm
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
            this.adminButton = new System.Windows.Forms.Button();
            this.instructorButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(78, 94);
            this.adminButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(152, 62);
            this.adminButton.TabIndex = 0;
            this.adminButton.Text = "&Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // instructorButton
            // 
            this.instructorButton.Location = new System.Drawing.Point(78, 227);
            this.instructorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.instructorButton.Name = "instructorButton";
            this.instructorButton.Size = new System.Drawing.Size(152, 62);
            this.instructorButton.TabIndex = 1;
            this.instructorButton.Text = "&Instructor";
            this.instructorButton.UseVisualStyleBackColor = true;
            this.instructorButton.Click += new System.EventHandler(this.instructorButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.Location = new System.Drawing.Point(78, 374);
            this.studentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(152, 62);
            this.studentButton.TabIndex = 2;
            this.studentButton.Text = "&Student";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(480, 491);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(152, 62);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(399, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 298);
            this.label1.TabIndex = 4;
            this.label1.Text = "TINY COLLEGE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.instructorButton);
            this.Controls.Add(this.adminButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Tiny College";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button instructorButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
    }
}

