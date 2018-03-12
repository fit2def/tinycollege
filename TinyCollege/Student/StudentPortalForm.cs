using System;
using System.Windows.Forms;


namespace TinyCollege.Student
{
    public partial class StudentPortalForm : Form
    {
        public StudentPortalForm()
        {
            InitializeComponent();
        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }
        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewCoursesForm form = new ViewCoursesForm();
            form.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
