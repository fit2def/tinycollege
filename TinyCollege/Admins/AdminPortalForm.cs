﻿using System;
using System.Windows.Forms;
using TinyCollege.Utilities;

namespace TinyCollege.Admins
{
    public partial class AdminPortalForm : Form
    {
        private readonly ModelRepository _repo;

        public AdminPortalForm(ModelRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void instructorButton_Click(object sender, EventArgs e)
        {
            AddInstructorForm form = new AddInstructorForm(_repo);
            form.ShowDialog();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm(_repo);
            form.ShowDialog();
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            AddCourseForm form = new AddCourseForm(_repo);
            form.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
