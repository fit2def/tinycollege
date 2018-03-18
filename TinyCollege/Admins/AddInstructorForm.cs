using System;
using System.Windows.Forms;
using TinyCollege.Models;
using TinyCollege.Utilities;

namespace TinyCollege.Admins
{
    public partial class AddInstructorForm : Form
    {
        private readonly ModelRepository _repo;

        public AddInstructorForm(ModelRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidInputs())
            {
                Instructor instructor = BuildInstructor();
                _repo.Instructors.Add(instructor);
            }     
        }

        private bool ValidInputs() =>
            IdCorrectLength()
            && FirstNameIsCorrectLength() 
            && LastNameIsCorrectLength()
            && NewInstructor();

        private bool IdCorrectLength()
        {
            if (idBox.Text.Length <= 10 && idBox.Text.Length > 0)
                return true;
            else
            {
                MessageBox.Show("Length of ID needs to be greater than 0 and no greater than 10.");
                return false;
            }
        }

        private bool FirstNameIsCorrectLength() {
            if (firstBox.Text.Length > 0 && firstBox.Text.Length <= 100)
                return true;
            else
            {
                MessageBox.Show("Name has to have a length greater than 0 and no greater than 100");
                return false;
            }
            
        }
       
        private bool LastNameIsCorrectLength()
        {
            if (lastBox.Text.Length > 0 && lastBox.Text.Length <= 100)
                return true;
            else
            {
                MessageBox.Show("Name has to have a length greater than 0 and no greater than 100");
                return false;
            }
        }

        private bool NewInstructor()
        {
            bool newInstructor = true;
            foreach (Instructor i in _repo.Instructors)
            {
                if (i.Id == idBox.Text)
                    newInstructor = false;
            }
            return newInstructor;
        }

        private Instructor BuildInstructor() =>
           new Instructor
            {
                Id = idBox.Text,
                FirstName = firstBox.Text,
                LastName = lastBox.Text
            };
    }
}
