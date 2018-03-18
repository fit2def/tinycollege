using System;
using System.Windows.Forms;
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

        private void AddInstructorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
