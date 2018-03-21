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

namespace TinyCollege.Students
{
    public partial class ViewCoursesForm : Form
    {
        private readonly ModelRepository _repo;
        private readonly Student _student;
        private readonly IEnumerable<Enrollment> _enrollments;

        public ViewCoursesForm(ModelRepository repo, Student student)
        {
            InitializeComponent();
            _repo = repo;
            _student = student;
            _enrollments = _repo.Enrollments.Where(e => e.Student == _student);
            PopulateDataGridView(_enrollments);
            PopulateHoursCompleted(_enrollments);
        }


        private void PopulateDataGridView(IEnumerable<Enrollment> enrollments)
        {
            dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].Name = "Course";
            dataGridView.Columns[1].Name = "Grade";

            foreach (Enrollment enrollment in enrollments)
            {
                string[] row = new string[] { enrollment.Course.Name, enrollment.Grade.ToString() };
                dataGridView.Rows.Add(row);
            }
        }

        private void PopulateHoursCompleted(IEnumerable<Enrollment> enrollments)
        {
            int hours = enrollments
                .Where(e => e.Grade >= .7)
                .Count() * 3;
            TotalHoursLabel.Text = hours.ToString();
            if (hours >= 120)
                MessageBox.Show("Congratulations, you graduated. Now find a job.");
        }

        private void ViewCoursesForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
