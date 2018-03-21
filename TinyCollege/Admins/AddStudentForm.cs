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

namespace TinyCollege.Admins
{
    public partial class AddStudentForm : Form
    {
        private readonly ModelRepository _repo;

        public AddStudentForm(ModelRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidInputs())
            {
                Student student = BuildStudent();
                _repo.Students.Add(student);
                MessageBox.Show("Student added.");
            }
            ClearInputs();
        }

        private void ClearInputs()
        {
            idBox.Text = string.Empty;
            firstBox.Text = string.Empty;
            lastBox.Text = string.Empty;
        }

        private bool ValidInputs() =>
            IdCorrectLength()
            && FirstNameIsCorrectLength()
            && LastNameIsCorrectLength()
            && NewStudent();

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

        private bool FirstNameIsCorrectLength()
        {
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

        private bool NewStudent()
        {
            bool newStudent = true;
            foreach (Student i in _repo.Students)
            {
                if (i.Id == idBox.Text)
                {
                    newStudent = false;
                    MessageBox.Show("Student with that ID already exists.");
                }

            }
            return newStudent;
        }

        private Student BuildStudent() =>
           new Student
           {
               Id = idBox.Text,
               FirstName = firstBox.Text,
               LastName = lastBox.Text
           };

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}