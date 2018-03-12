﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TinyCollege.Admin
{
    public partial class AdminPortalForm : Form
    {
        public AdminPortalForm()
        {
            InitializeComponent();
        }

        private void instructorButton_Click(object sender, EventArgs e)
        {
            AddInstructorForm form = new AddInstructorForm();
            form.ShowDialog();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm();
            form.ShowDialog();
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            AddCourseForm form = new AddCourseForm();
            form.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}