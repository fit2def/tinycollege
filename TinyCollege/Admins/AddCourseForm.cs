using System;
using System.Linq;
using System.Windows.Forms;
using TinyCollege.Models;
using TinyCollege.Utilities;

namespace TinyCollege.Admins
{
    public partial class AddCourseForm : Form
    {
        private readonly ModelRepository _repo;

        public AddCourseForm(ModelRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {

        }


        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidInputs())
            {
                Course course = BuildCourse();
                _repo.Courses.Add(course);
                MessageBox.Show("Course added.");
            }
            ClearInputs();
        }


        private bool ValidInputs() =>
            CourseIdCorrectLength()
            && NewCourse()
            && InstructorIdCorrectLength()
            && InstructorExists()
            && TitleIsCorrectLength()
            && SeatsAreAppropriate();

        private bool NewCourse()
        {
            bool newCourse = !_repo.Courses.Exists(c => c.Id.ToLowerInvariant() == courseIdBox.Text.ToLowerInvariant());
            if (newCourse)
                return true;
            else
            {
                MessageBox.Show("Course with that ID already exists.");
                return false;
            }

        }
        

        private bool InstructorExists()
        {
            Instructor instructor = FindInstructor(instructorIdBox.Text);
            if (instructor == null)
            {
                MessageBox.Show("Instructor does not exist. Please add it.");
                return false;
            }
            return true;
        }

        private bool CourseIdCorrectLength()
        {
            if (courseIdBox.Text.Length <= 6 && courseIdBox.Text.Length > 0)
                return true;
            else
            {
                MessageBox.Show("Length of Course ID needs to be greater than 0 and no greater than 6.");
                return false;
            }
        }

        private bool InstructorIdCorrectLength()
        {
            if (instructorIdBox.Text.Length <= 10 && instructorIdBox.Text.Length > 0)
                return true;
            else
            {
                MessageBox.Show("Length of Instructor ID needs to be greater than 0 and no greater than 10.");
                return false;
            }
        }

        private bool TitleIsCorrectLength()
        {
            if (titleBox.Text.Length > 0 && titleBox.Text.Length <= 100)
                return true;
            else
            {
                MessageBox.Show("Course Title must have length greater than 0 and no greater than 100");
                return false;
            }
        }



        private bool SeatsAreAppropriate()
        {
            int number;
            bool isNumber = int.TryParse(seatsBox.Text, out number);
            if (isNumber)
            {
                if (number > 0)
                    return true;
                else
                {
                    MessageBox.Show("Must be positive number");
                    return false;
                }
            }

            else
            {
                MessageBox.Show("Must enter a whole number");
                return false;
            }
        }

        private Course BuildCourse() =>
           new Course
           {
               Id = courseIdBox.Text,
               SeatsAvailable = int.Parse(seatsBox.Text),
               Name = titleBox.Text,
               Instructor = FindInstructor(instructorIdBox.Text),
               IsActive = activeCheckBox.Checked
           };

        private Instructor FindInstructor(string id)
        {
            return _repo.Instructors.FirstOrDefault(i => i.Id == id);
        }

        private void ClearInputs()
        {
            courseIdBox.Text = string.Empty;
            seatsBox.Text = string.Empty;
            titleBox.Text = string.Empty;
            instructorIdBox.Text = string.Empty;
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
