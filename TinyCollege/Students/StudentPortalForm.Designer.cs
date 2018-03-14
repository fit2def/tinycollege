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
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(703, 608);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(184, 82);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(121, 180);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(169, 74);
            this.registerButton.TabIndex = 1;
            this.registerButton.Text = "&Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(121, 383);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(169, 74);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "&ViewAll";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // StudentPortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 732);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.closeButton);
            this.Name = "StudentPortalForm";
            this.Text = "StudentPortalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button viewButton;
    }
}