using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TinyCollege.Models;
using TinyCollege.Utilities;

namespace TinyCollege.Students
{
    public partial class RegisterForm : Form
    {
        private readonly ModelRepository _repo;
        private readonly Student _student;

        public RegisterForm(ModelRepository repo, Student student)
        {
            InitializeComponent();
            _repo = repo;
            _student = student;
            Text =  "Register courses for " + _student.FirstName + " " + _student.LastName;
            RefreshCourses();
        }

        private void RefreshCourses()
        {
            coursesBox.Items.Clear();
            List<Course> validCourses = GetValidCourses(_student.Id);
            PopulateListBox(validCourses);
        }

        private List<Course> GetValidCourses(string studentId)
        {
            List<Course> activeCourses = _repo.Courses.Where(c => c.IsActive).ToList();
            List<Course> coursesWithSeatsAvailable = activeCourses.Where(c => c.SeatsAvailable > 0).ToList();
            List<Course> coursesAlreadyEnrolledIn = _repo
                .Enrollments
                .Where(e => e.Student.Id == studentId)
                .Select(e => e.Course)
                .ToList();
            List<Course> goodCourses =  coursesWithSeatsAvailable
                .Where(c => !coursesAlreadyEnrolledIn.Exists(c2 => c2 == c))
                .ToList();
            return goodCourses;
        }

        private void PopulateListBox(List<Course> validCourses)
        {
            foreach (Course c in validCourses)
            {
                coursesBox.Items.Add(c);
            }
        }



        private void registerButton_Click(object sender, EventArgs e)
        {
            if (coursesBox.Items.Count == 0)
            {
                MessageBox.Show("You didn't select any courses.");
            }
            else
            {
                foreach (Course c in coursesBox.SelectedItems)
                {
                    _repo.Enrollments.Add(new Enrollment
                    {
                        Course = c,
                        Student = _student
                    });
                    c.SeatsAvailable--;
                }
                MessageBox.Show("Registration successful.");
                RefreshCourses();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
