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
    public partial class AlumniSettings : Form
    {
        DatabaseManager manager;
        public AlumniSettings()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            manager = new DatabaseManager();

            NameText.Text = Session.fname + " " + Session.lname;
            SubtitleText.Text = Session.subtitle;
            EmailText.Text = Session.email;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Change Password Click
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (newPassword.Text.Equals(newPasswordConfirm.Text))
            {
                if (oldPassword.Text.Equals(Session.password))
                {
                    manager.updateAlumni(Session.id, "Password", newPassword.Text);
                    warning.Text = "Password has successfully changed";
                }
                else
                {
                    warning.Text = "Please enter your old password correctly";
                }
            }
            else {
                warning.Text = "Your both password doesn't match";
            }
        }

        //Alumin Dashboard Icon clicked
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AlumniDashboard dashboard = new AlumniDashboard();
            dashboard.Show();
            this.Hide();
        }

        //Edit profile button clicked
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
            this.Hide();
        }

        //Application Close
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
