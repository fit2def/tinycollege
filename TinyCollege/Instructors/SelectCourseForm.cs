using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyCollege.Models;
using TinyCollege.Utilities;

namespace TinyCollege.Instructors
{
    public partial class SelectCourseForm : Form
    {
        private readonly ModelRepository _repo;
        private readonly Instructor _instructor;
        private IEnumerable<Enrollment> _enrollments;

        public SelectCourseForm(ModelRepository repo, Instructor instructor)
        {
            InitializeComponent();
            _repo = repo;
            _instructor = instructor;
            _enrollments = _repo.Enrollments.Where(e => e.Course.Instructor == _instructor);
            RefreshCourses();

        }

        private void RefreshCourses()
        {
            courseComboBox.Items.Clear();
            List<Course> validCourses = GetValidCourses(_instructor.Id);
            PopulateCourseListBox(validCourses);
        }

        private void RefreshForm()
        {
            // courseComboBox.Items.Clear();
            //studentComboBox.Clear();
            studentComboBox.SelectedIndex = -1;
            dataGridView.Rows.Clear();
           // List<Course> validCourses = GetValidCourses(_instructor.Id);
           // PopulateCourseListBox(validCourses);
           PopulateDataGridView(_enrollments);
           gradeBox.Clear();
        }

        private List<Course> GetValidCourses(string instructorId)
        {
            List<Course> instructorCourses = _repo.Courses.Where(c => c.Instructor.Id == instructorId).ToList();
            return instructorCourses;
        }

        private void PopulateCourseListBox(List<Course> validCourses)
        {
            foreach (Course c in validCourses)
            {
                courseComboBox.Items.Add(c.Id);
            }
        }

        private void SelectCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selecCourseButton_Click(object sender, EventArgs e)
        {
            List<Enrollment> validEnrollments = GetValidEnrollments(courseComboBox.Text);
            PopulateDataGridView(validEnrollments);

        }

        private List<Enrollment> GetValidEnrollments(string courseId)
        {
            List<Enrollment> validEnrollments = _repo.Enrollments.Where(e => e.Course.Id == courseId).ToList();
            return validEnrollments;
        }

        private void PopulateDataGridView(IEnumerable<Enrollment> enrollments)
        {
            dataGridView.ColumnCount = 3;
            dataGridView.Columns[0].Name = "Student Id";
            dataGridView.Columns[1].Name = "Student Name";
            dataGridView.Columns[2].Name = "Grade";

            foreach (Enrollment enrollment in enrollments)
            {
                string[] row = new string[] { enrollment.Student.Id
                    , enrollment.Student.FirstName + ' ' + enrollment.Student.LastName
                    , enrollment.Grade.ToString() };
                dataGridView.Rows.Add(row);
            }

            PopulateStudentListBox(enrollments);

        }

        private void PopulateStudentListBox(IEnumerable<Enrollment> enrollments)
        {
            studentComboBox.Items.Clear();
            foreach (Enrollment e in enrollments)
            {
                studentComboBox.Items.Add(e.Student.Id);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (ValidateGrade(gradeBox.Text))
            {
                foreach(Enrollment enrollment in _enrollments)
                {
                    if(enrollment.Student.Id.ToString() == studentComboBox.Text)
                    {
                        enrollment.Grade = double.Parse(gradeBox.Text);
                    }
                }
            }
            RefreshForm();
        }

        private bool ValidateGrade(string grade)
        {
            double validGrade;
            if (double.TryParse(grade, out validGrade))
            {
                if (validGrade >= 0 && validGrade <= 4)
                    return true;
                else
                {
                    MessageBox.Show("Grade must be between 0 and 4.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Grade must be a double numeric.");
                return false;
            }
        }
    }
}
