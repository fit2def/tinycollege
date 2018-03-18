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
    }
}
