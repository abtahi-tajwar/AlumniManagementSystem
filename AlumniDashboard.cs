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
        DatabaseManager manager;
        public AlumniDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //Rubaia Apu Code //

            manager = new DatabaseManager();

            UserNameText.Text = Session.fname + " " + Session.lname;
            SubtitleText.Text = Session.subtitle;
            EmailText.Text = Session.email;
            DetailsText.Text = Session.desc;
            EventNameText.Text = manager.getLastEvent("name");
            EventDateText.Text = manager.getLastEvent("date");
            profilePicture.ImageLocation = Session.picture;
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;


            if (manager.checkEventGoing(Session.id))
            {
                GoingTrue.Visible = true;
            }
            else {
                GoingFalse.Visible = false;
            }

            ////////////////////
            

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

        //Rubaia Apu Code
        //Settings Icon Click
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AlumniSettings settings = new AlumniSettings();
            settings.Show();
            this.Hide();
        }
        /////////////////////

        //Change profile picture button
        private void changePicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Session.picture = openFileDialog1.FileName;

            profilePicture.ImageLocation = Session.picture;
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;

            manager.updateAlumni(Session.id, "ProfilePicture", Session.picture);
        }
        



    }
}
