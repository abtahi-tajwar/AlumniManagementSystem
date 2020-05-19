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
        DatabaseManager manager;
        public AlumniDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            session = new Session();
            manager = new DatabaseManager();
            UserNameText.Text = Session.fname + " " + Session.lname;
            SubtitleText.Text = Session.subtitle;
            EmailText.Text = Session.email;
            DetailsText.Text = Session.desc;

            Console.WriteLine(manager.getLastEvent("name"));
            Console.WriteLine(manager.getLastEvent("date"));
            Console.WriteLine(manager.checkEventGoing(Session.id));

            if (manager.checkEventGoing(Session.id) == true)
            {
                GoingTrue.Visible = true;
            }
            else {
                GoingFalse.Visible = true;
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        //Close icon clicked
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Logout button clicked
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            LoginForm loginFrom = new LoginForm();
            loginFrom.Show();
            this.Hide();
        }

        private void GoingFalse_Click(object sender, EventArgs e)
        {
            manager.updateEventCount(Session.id);
            GoingTrue.Visible = true;
            GoingFalse.Visible = false;
        }
    }
}
