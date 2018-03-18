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
    }
}
