using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyCollege.Admin;

namespace TinyCollege
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }


        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminPortalForm form = new AdminPortalForm();
            form.ShowDialog();
        }

        private void instructorButton_Click(object sender, EventArgs e)
        {
            InstructorPortalForm form = new InstructorPortalForm();
            form.ShowDialog();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            StudentPortalForm form = new StudentPortalForm();
            form.ShowDialog();
        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
