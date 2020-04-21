using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSFinalProject_University_
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void aboutusbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutForm af = new AboutForm();
            af.Show();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateForm uf = new UpdateForm();
            uf.Show();

        }
    }
}
