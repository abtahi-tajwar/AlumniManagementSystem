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
    public partial class AdminSettings : Form
    {
        public AdminSettings()
        {
            InitializeComponent();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            var text = (sender as TextBox).Text;
            if (String.IsNullOrEmpty(text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, $"Enter password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
           
        }
    }
}
