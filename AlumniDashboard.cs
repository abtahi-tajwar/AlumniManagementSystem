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
    public partial class AlumniDashboard : Form
    {
        Session session;
        public AlumniDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            session = new Session();
            UserNameText.Text = Session.fname + " " + Session.lname + " \n" ;
            label9.Text = Session.subtitle+"\n";
            label15.Text = Session.email + "\n";

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void UserNameText_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
