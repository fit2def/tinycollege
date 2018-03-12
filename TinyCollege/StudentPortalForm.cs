using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyCollege.Student;

namespace TinyCollege
{
    public partial class StudentPortalForm : Form
    {
        public StudentPortalForm()
        {
            InitializeComponent();
        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }
        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewCoursesForm form = new ViewCoursesForm();
            form.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
