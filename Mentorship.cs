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
    public partial class Mentorship : Form
    {
        Form PreviousForm;
        public Mentorship(Form pf)
        {
            InitializeComponent();
            PreviousForm = pf;
        }

        private void Mentorship_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PreviousForm.Show();
        }
    }
}
