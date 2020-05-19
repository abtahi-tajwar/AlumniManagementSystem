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
    public partial class RegistrationPageOne : Form
    {
        private string fname, lname, sid, age, pyear, present_address, permanent_address, father, mother, work;

        private void backButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public RegistrationPageOne()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        public RegistrationPageOne(string fname, string lname, string sid, string age, string pyear, string present_address, string permanent_address, string father, string mother, string work) {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            firstName.Text = fname;
            lastName.Text = lname;
            StudentID.Text = sid;
            Age.Text = age;
            PassingYear.Text = pyear;
            PresentAddress.Text = present_address;
            PermanentAddress.Text = permanent_address;
            FatherName.Text = father;
            MotherName.Text = mother;
            Work.Text = work;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            fname = firstName.Text;
            lname = lastName.Text;
            sid = StudentID.Text;
            age = Age.Text;
            pyear = PassingYear.Text;
            present_address = PresentAddress.Text;
            permanent_address = PermanentAddress.Text;
            father = FatherName.Text;
            mother = MotherName.Text;
            work = Work.Text;

           // if (fname == "" || lname == "" || sid == "" || age == "" || pyear == "" || father == "" || mother == "")
           if(!string.IsNullOrEmpty(fname) && !string.IsNullOrEmpty(lname) && !string.IsNullOrEmpty(sid) && !string.IsNullOrEmpty(age)
                && !string.IsNullOrEmpty(pyear) && !string.IsNullOrEmpty(present_address) && !string.IsNullOrEmpty(permanent_address)
                && !string.IsNullOrEmpty(father) && !string.IsNullOrEmpty(mother) && !string.IsNullOrEmpty(work))
            {
                warning.Visible = true;
                this.Hide();
                RegistrationFormTwo rFormTwo = new RegistrationFormTwo(fname, lname, sid, age, pyear, present_address, permanent_address, father, mother, work);
                rFormTwo.Show();
            }
            else 
            {
                MessageBox.Show("Please fill up all info..");
            }

        }
    }
}
