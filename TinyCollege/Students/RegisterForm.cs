using System;
using System.Windows.Forms;
using TinyCollege.Utilities;

namespace TinyCollege.Students
{
    public partial class RegisterForm : Form
    {
        private readonly ModelRepository _repo;

        public RegisterForm(Utilities.ModelRepository repo)
        {
            InitializeComponent();
            _repo = repo;

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
