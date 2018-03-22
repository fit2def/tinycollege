namespace TinyCollege.Students
{
    partial class StudentPortalForm
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
            this.registerButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.idbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(349, 314);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(92, 43);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Enabled = false;
            this.registerButton.Location = new System.Drawing.Point(98, 225);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(84, 38);
            this.registerButton.TabIndex = 1;
            this.registerButton.Text = "&Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Enabled = false;
            this.viewButton.Location = new System.Drawing.Point(258, 225);
            this.viewButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(84, 38);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "&View All Courses";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(165, 40);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 20);
            this.idbox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.idbox);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(165, 99);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Id";
            // 
            // StudentPortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.closeButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentPortalForm";
            this.Text = "StudentPortalForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
    }
}