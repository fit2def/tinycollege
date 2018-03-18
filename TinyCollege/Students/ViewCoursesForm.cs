using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyCollege.Utilities;

namespace TinyCollege.Students
{
    public partial class ViewCoursesForm : Form
    {
        private readonly ModelRepository _repo;

        public ViewCoursesForm(ModelRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void ViewCoursesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
