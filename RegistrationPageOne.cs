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
       // bool place = true;
        private string fname, lname, sid, age, pyear, present_address, permanent_address, father, mother, work;

      
        private void Age_Click(object sender, EventArgs e)
        {
            Age.Clear();
        }
        private void Age_Leave(object sender, EventArgs e)
        {
            if (Age.Text == "")
            {
                Age.Text = "Age";
               //lace = true;
            }

        }
        private void firstName_Click(object sender, EventArgs e)
        {
            firstName.Clear();
        }
        
        private void firstName_Leave(object sender, EventArgs e)

        { 
               
                if(string.IsNullOrEmpty(firstName.Text))
                {
                    errorProvider1.SetError(firstName, $"Give First Name!");
                }
                    
               
            }

        

       
        private void lastName_Click(object sender, EventArgs e)
        {
            lastName.Clear();
        }

        private void lastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastName.Text))
            {

                //lastName.Text = "Last Name";
                errorProvider2.SetError(lastName, $"Give Last Name!");

            }
        }

       
        private void StudentID_Click(object sender, EventArgs e)
        {
            StudentID.Clear();
        }

        private void StudentID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StudentID.Text))
            {
                //StudentID.Text = "Student ID";
                errorProvider3.SetError(StudentID, $"Give Your ID!");

            }
        }

       
        private void PassingYear_Click(object sender, EventArgs e)
        {
            PassingYear.Clear();
        }
        private void PassingYear_Leave(object sender, EventArgs e)
        {
            if (PassingYear.Text == "")
            {
                PassingYear.Text = "Passing Year";
                
            }
        }

        
        private void PresentAddress_Click(object sender, EventArgs e)
        {
            PresentAddress.Clear();
        }

        private void PresentAddress_Leave(object sender, EventArgs e)
        {
            if (PresentAddress.Text == "")
            {
                PresentAddress.Text = "Present Address";
                
            }
        }

        
        private void PermanentAddress_Click(object sender, EventArgs e)
        {
            PermanentAddress.Clear();
        }
        private void PermanentAddress_Leave(object sender, EventArgs e)
        {
            if (PermanentAddress.Text == "")
            {
                PermanentAddress.Text = "Permanent Address";
                
            }
        }

       
        private void FatherName_Click(object sender, EventArgs e)
        {
            FatherName.Clear();
        }

        private void FatherName_Leave(object sender, EventArgs e)
        {
            if (FatherName.Text == "")
            {
                FatherName.Text = "Father's Name";
                
            }
        }

       
        private void MotherName_Click(object sender, EventArgs e)
        {
            MotherName.Clear();
        }

        private void MotherName_Leave(object sender, EventArgs e)
        {
            if (MotherName.Text == "")
            {
                MotherName.Text = "Mother's Name";
                
            }
        }

        private void Work_Click(object sender, EventArgs e)
        {
            Work.Clear();
        }

        private void Work_Leave(object sender, EventArgs e)
        {
            if (Work.Text == "")
            {
                Work.Text = "Add Work";
               
            }
        }











        private void StudentID_Validating(object sender, CancelEventArgs e)
        {
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
                errorProvider2.SetError(lastName, "");
            }
        }

     
        
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

            if (fname == "" || lname == "" || sid == "" || age == "" || pyear == "" || father == "" || mother == "")
            {
                warning.Visible = true;
            }
            else {
                this.Hide();
                RegistrationFormTwo rFormTwo = new RegistrationFormTwo(fname, lname, sid, age, pyear, present_address, permanent_address, father, mother, work);
                rFormTwo.Show();
            }

        }

    }
}
