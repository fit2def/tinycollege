using System;
using System.Linq;
using System.Windows.Forms;
using TinyCollege.Models;
using TinyCollege.Utilities;

namespace TinyCollege.Students
{
    public partial class StudentPortalForm : Form
    {
        private readonly ModelRepository _repo;
        private Student Student { get; set; }

        public StudentPortalForm(ModelRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm(_repo, Student);
            form.ShowDialog();
        }
        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewCoursesForm form = new ViewCoursesForm(_repo, Student);
            form.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Student = _repo.Students.FirstOrDefault(s => s.Id == idbox.Text);
            if (Student != null)
            {
                viewButton.Enabled = true;
                registerButton.Enabled = true;
                loginButton.Enabled = false;
                MessageBox.Show("You have logged in successfully");

            }
            else
            {
                MessageBox.Show("Instructor with that ID not found");
            }
        }

    }
}
