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

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public RegistrationPageOne()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
