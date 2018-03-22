using System;
using System.Linq;
using System.Windows.Forms;
using TinyCollege.Models;
using TinyCollege.Utilities;

namespace TinyCollege.Instructors
{
    public partial class InstructorPortalForm : Form
    {
        private readonly ModelRepository _repo;
        private Instructor Instructor{ get; set; }


        public InstructorPortalForm(ModelRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InstructorPortalForm_Load(object sender, EventArgs e)
        {

        }

        private void selectCourseButton_Click(object sender, EventArgs e)
        {
            SelectCourseForm form = new SelectCourseForm(_repo, Instructor);
            form.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Instructor = _repo.Instructors.FirstOrDefault(s => s.Id == idBox.Text);
            if (Instructor != null)
            {
                selectCourseButton.Enabled = true;
                loginButton.Enabled = false;
                MessageBox.Show("You have logged in successfully");

            }
            else
            {
                MessageBox.Show("Student with that ID not found");
            }
        }
    }
}
