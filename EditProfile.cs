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
    public partial class EditProfile : Form
    {
        bool isActive = false;
        DatabaseManager manager;
        public EditProfile()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            manager = new DatabaseManager();

            FirstNameText.Text = Session.fname;
            LastNameText.Text = Session.lname;
            IDText.Text = Session.id.ToString();
            AgeText.Text = Session.age.ToString();
            PassingYearText.Text = Session.pyear;
            PresentAddressText.Text = Session.present_address;
            PermanentAddressText.Text = Session.permanent_address;
            FathersNameText.Text = Session.father;
            MothersNameText.Text = Session.mother;
            WorkPlaceText.Text = Session.work;
        }

        //Edit profile clicked
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            
            if (isActive)
            {
                ButtonText.Text = "Edit Profile";
                isActive = false;
                FirstNameText.Enabled = LastNameText.Enabled = IDText.Enabled = AgeText.Enabled = PassingYearText.Enabled = PresentAddressText.Enabled = PermanentAddressText.Enabled = FathersNameText.Enabled = MothersNameText.Enabled = WorkPlaceText.Enabled = false;

                manager.updateAlumni(Session.id, "FirstName", FirstNameText.Text);
                manager.updateAlumni(Session.id, "LastName", LastNameText.Text);
                manager.updateAlumni(Session.id, "StudentID", IDText.Text);
                manager.updateAlumni(Session.id, "Age", AgeText.Text);
                manager.updateAlumni(Session.id, "PassingYear", PassingYearText.Text);
                manager.updateAlumni(Session.id, "PresentAddress", PresentAddressText.Text);
                manager.updateAlumni(Session.id, "PermanentAddress", PermanentAddressText.Text);
                manager.updateAlumni(Session.id, "FathersName", FathersNameText.Text);
                manager.updateAlumni(Session.id, "MothersName", MothersNameText.Text);
                manager.updateAlumni(Session.id, "WorkPlace", WorkPlaceText.Text);
            }
            else {
                ButtonText.Text = "Save Profile";
                isActive = true;
                FirstNameText.Enabled = LastNameText.Enabled = IDText.Enabled = AgeText.Enabled = PassingYearText.Enabled = PresentAddressText.Enabled = PermanentAddressText.Enabled = FathersNameText.Enabled = MothersNameText.Enabled = WorkPlaceText.Enabled = true;
            }
            
        }

        //Alumni Dashboard click
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AlumniDashboard dashboard = new AlumniDashboard();
            dashboard.Show();
            this.Hide();
        }

        //Alumni Settings Click
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AlumniSettings settings = new AlumniSettings();
            settings.Show();
            this.Hide();
        }

        //Close button Click
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Back Button Clicke
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            AlumniSettings settings = new AlumniSettings();
            settings.Show();
            this.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();
                
                
        }
    }
}
