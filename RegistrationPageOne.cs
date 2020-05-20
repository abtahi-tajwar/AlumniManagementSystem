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
        bool place = true;
        private string fname, lname, sid, age, pyear, present_address, permanent_address, father, mother, work;

        private void Age_Enter(object sender, EventArgs e)
        {
            if (Age.Text == "Age")
            {
                if (place)
                {
                    Age.Text = "";
                    place = false;
                }
            }
        }
        private void Age_Leave(object sender, EventArgs e)
        {
            if (Age.Text == "")
            {
                Age.Text = "Age";
                place = true;
            }

        }
        private void firstName_Enter(object sender, EventArgs e)
        {
            if (firstName.Text == "First Name")
            {
                if (place)
                {
                    firstName.Text = "";
                    place = false;
                }

            }

        }
        private void firstName_Leave(object sender, EventArgs e)
        {
            if (firstName.Text == "")
            {
                firstName.Text = "First Name";
                place = true;
            }

        }

        private void lastName_Enter(object sender, EventArgs e)
        {
            if (lastName.Text == "Last Name")
            {
                if (place)
                {
                    lastName.Text = "";
                    place = false;
                }

            }

        }

        private void lastName_Leave(object sender, EventArgs e)
        {
            if (lastName.Text == "")
            {
                lastName.Text = "Last Name";
                place = true;
            }
        }

        private void StudentID_Enter(object sender, EventArgs e)
        {
            if (StudentID.Text == "Student ID")
            {
                if (place)
                {
                    StudentID.Text = "";
                    place = false;
                }

            }

        }

        private void StudentID_Leave(object sender, EventArgs e)
        {
            if (StudentID.Text == "")
            {
                StudentID.Text = "Student ID";
                place = true;
            }
        }

        private void PassingYear_Enter(object sender, EventArgs e)
        {
            if (PassingYear.Text == "Passing Year")
            {
                if (place)
                {
                    PassingYear.Text = "";
                    place = false;
                }

            }

        }
        private void PassingYear_Leave(object sender, EventArgs e)
        {
            if (PassingYear.Text == "")
            {
                PassingYear.Text = "Passing Year";
                place = true;
            }
        }

        private void PresentAddress_Enter(object sender, EventArgs e)
        {
            if (PresentAddress.Text == "Present Address")
            {
                if (place)
                {
                    PresentAddress.Text = "";
                    place = false;
                }
            }
        }

        private void PresentAddress_Leave(object sender, EventArgs e)
        {
            if (PresentAddress.Text == "")
            {
                PresentAddress.Text = "Present Address";
                place = true;
            }
        }

        private void PermanentAddress_Enter(object sender, EventArgs e)
        {
            if (PermanentAddress.Text == "Permanent Address")
            {
                if (place)
                {
                    PermanentAddress.Text = "";
                    place = false;
                }
            }
        }
        private void PermanentAddress_Leave(object sender, EventArgs e)
        {
            if (PermanentAddress.Text == "")
            {
                PermanentAddress.Text = "Permanent Address";
                place = true;
            }
        }

        private void FatherName_Enter(object sender, EventArgs e)
        {
            if (FatherName.Text == "Father's Name")
            {
                if (place)
                {
                    FatherName.Text = "";
                    place = false;
                }
            }
        }

        private void FatherName_Leave(object sender, EventArgs e)
        {
            if (FatherName.Text == "")
            {
                FatherName.Text = "Father's Name";
                place = true;
            }
        }

        private void MotherName_Enter(object sender, EventArgs e)
        {
            if (MotherName.Text == "Mother's Name")
            {
                if (place)
                {
                    FatherName.Text = "";
                    place = false;
                }
            }
        }

        private void MotherName_Leave(object sender, EventArgs e)
        {
            if (MotherName.Text == "")
            {
                MotherName.Text = "Mother's Name";
                place = true;
            }
        }

        private void Work_Enter(object sender, EventArgs e)
        {
            if (Work.Text == "Add Work")
            {
                if (place)
                {
                    Work.Text = "";
                    place = false;
                }
            }
        }

        private void Work_Leave(object sender, EventArgs e)
        {
            if (Work.Text == "")
            {
                Work.Text = "Add Work";
                place = true;
            }
        }











        private void StudentID_Validating(object sender, CancelEventArgs e)
        {
            if (place == true)
            { var text = (sender as TextBox).Text;
                if (String.IsNullOrEmpty(text))
                {
                    e.Cancel = true;
                    StudentID.Focus();
                    errorProvider3.SetError(StudentID, $"Give Your ID!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider3.SetError(StudentID, "");
                }
            }

        }

        private void lastName_Validating(object sender, CancelEventArgs e)
        {
            var text = (sender as TextBox).Text;
            if (String.IsNullOrEmpty(text))
            {
                e.Cancel = true;
                lastName.Focus();
                errorProvider2.SetError(lastName, $"Give Last Name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(lastName, "");
            }
        }

       // if(string.IsNullOrEmpty(firstName.Text))
        
        private void firstName_Validating(object sender, CancelEventArgs e)
        {

            var text = (sender as TextBox).Text;
            if (String.IsNullOrEmpty(text))
            {
                e.Cancel = true;
                firstName.Focus();
                errorProvider1.SetError(firstName, $"Give First Name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(firstName, "");
            }

        }
        

        
    

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
