using System;
using System.Windows.Forms;
using TinyCollege.Utilities;

namespace TinyCollege.Students
{
    public partial class StudentPortalForm : Form
    {
        private readonly ModelRepository _repo;

        public StudentPortalForm(ModelRepository repo)
        {
            InitializeComponent();
            _repo = repo;
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
