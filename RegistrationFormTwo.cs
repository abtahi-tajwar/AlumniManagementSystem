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
    public partial class RegistrationFormTwo : Form
    {
        private string fname, lname, sid, age, pyear, present_address, permanent_address, father, mother, work;

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if(PasswordText.Text=="")
            {
                PasswordText.Text = "Enter Password";
            }
        }

        private void CPasswordText_Click(object sender, EventArgs e)
        {
            CPasswordText.Clear();
        }

        private void CPasswordText_Leave(object sender, EventArgs e)
        {
            if(CPasswordText.Text=="")
            {
                CPasswordText.Text = "Confirm Password";
            }
        }

        private void SubtitleText_Click(object sender, EventArgs e)
        {
            SubtitleText.Clear();
        }

        private void SubtitleText_Leave(object sender, EventArgs e)
        {
            if(SubtitleText.Text=="")
            {
                SubtitleText.Text = "Profile Subtitle";
            }
        }

        private void DescriptionText_Click(object sender, EventArgs e)
        {
            DescriptionText.Clear();
        }

        private void DescriptionText_Leave(object sender, EventArgs e)
        {
            if(DescriptionText.Text=="")
            {
                DescriptionText.Text = "Description";
            }
        }

        private void PasswordText_Click(object sender, EventArgs e)
        {
            PasswordText.Clear();
        }

        private void EmailText_Click(object sender, EventArgs e)
        {
            EmailText.Clear();
        }
        private void EmailText_Leave(object sender, EventArgs e)
        {
            if(EmailText.Text=="")
            {
                EmailText.Text = "Enter Email";
            }
        }


        //Registration form click back button
        private void BackButton_Click(object sender, EventArgs e)
        {
            RegistrationPageOne pageOne = new RegistrationPageOne(fname, lname, sid, age, pyear, present_address, permanent_address, father, mother, work);
            pageOne.Show();
            this.Hide();
        }

        private string email, password, cpassword, subtitle, desc;

        private void Register_Click(object sender, EventArgs e)
        {
            email = EmailText.Text;
            password = PasswordText.Text;
            cpassword = CPasswordText.Text;
            subtitle = SubtitleText.Text;
            desc = DescriptionText.Text;

            if (email != "" || password != "" || cpassword != "")
            {
                if (password.Equals(cpassword))
                {
                    DatabaseManager manager = new DatabaseManager();
                    manager.createAlumni(DatabaseManager.Count
                        , fname, lname, sid, age, pyear, present_address, permanent_address, father, mother, work, email, password, subtitle, desc);
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your both password have to match");
                }
            }
            else {
                MessageBox.Show("Please fill up all the necessary fields");
            }
        }

        


        public RegistrationFormTwo()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        public RegistrationFormTwo(string fname, string lname, string sid, string age, string pyear, string present_address, string permanent_address, string father, string mother, string work)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.fname = fname;
            this.lname = lname;
            this.sid = sid;
            this.age = age;
            this.pyear = pyear;
            this.present_address = present_address;
            this.permanent_address = permanent_address;
            this.father = father;
            this.mother = mother;
            this.work = work;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
