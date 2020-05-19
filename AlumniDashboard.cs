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
            UserNameText.Text = Session.fname + " " + Session.lname;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
