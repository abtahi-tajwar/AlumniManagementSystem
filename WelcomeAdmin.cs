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
    public partial class WelcomeAdmin : Form
    {
        public WelcomeAdmin()
        {
            InitializeComponent();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            EventOrganizer eventOrganizer = new EventOrganizer(this);
            this.Hide();
            eventOrganizer.Show();
        }

        private void btnMentor_Click(object sender, EventArgs e)
        {
            Mentorship mentorship = new Mentorship(this);
            this.Hide();
            mentorship.Show();
        }
    }
}
