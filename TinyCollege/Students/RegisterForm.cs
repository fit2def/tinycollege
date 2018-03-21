using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TinyCollege.Models;
using TinyCollege.Utilities;
using static System.Windows.Forms.CheckedListBox;

namespace TinyCollege.Students
{
    public partial class RegisterForm : Form
    {
        private readonly ModelRepository _repo;

        public RegisterForm(Utilities.ModelRepository repo)
        {
            InitializeComponent();
            _repo = repo;

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void findCoursesButton_Click(object sender, EventArgs e)
        {
            string studentId = studentIdBox.Text;
            if (ValidStudentId(studentId))
            {
                List<Course> validCourses = GetValidCourses(studentId);
                PopulateListBox(validCourses);
            }
            else
            {
                MessageBox.Show("Student with that ID not found.");
            }


        }


        private bool ValidStudentId(string text)
        {
            return _repo.Students.Exists(s => s.Id == text);
        }

        private List<Course> GetValidCourses(string studentId)
        {
            var activeCourses = _repo.Courses.Where(c => c.IsActive);
            var availableCourses = activeCourses.Where(c => c.SeatsAvailable > 0);
            var enrollmentCourses = _repo
                .Enrollments
                .Where(e => e.Student.Id != studentId)
                .Select(e => e.Course);
            List<string> ids = enrollmentCourses.Select(c => c.Id).ToList();
            var courses = availableCourses.Where(c => !ids.Exists(i => i == studentId));
            return availableCourses.ToList();
        }

        private void PopulateListBox(List<Course> validCourses)
        {
            foreach(Course c in validCourses)
            {
                coursesBox.Items.Add(c.Id + " - " + c.Name);
            }
        }



        private void registerButton_Click(object sender, EventArgs e)
        {
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
