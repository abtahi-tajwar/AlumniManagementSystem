using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSFinalProject_University_
{
    public partial class LoginForm : Form
    {
        bool studentIdPlaceholderText = true;
        string id, password;

        Session session;
        DatabaseManager manager;

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            manager = new DatabaseManager();
            session = new Session();
            Console.WriteLine(manager.authUser("19-40281-1", "1234"));
            Console.WriteLine(manager.authUser("abtahitajwar@gmail.com", "2222"));
            Console.WriteLine(Session.subtitle);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Student ID") 
            { 
                
            }
        }

        void passwordReset(object sender, EventArgs e)
        {
            if (!txtPassword.UseSystemPasswordChar) {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
            }
            
        }
        void passwordPlaceholder(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        void studentIdReset(object sender, EventArgs e)
        {
            if (studentIdPlaceholderText) {
                txtUsername.Text = "";
                studentIdPlaceholderText = false;
            }
            
        }
        void studentIdPlaceholder(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Student Id";
                studentIdPlaceholderText = true;
            }
        }

        

        private void LoginHover(object sender, EventArgs e)
        {
            loginButton.Image = CSFinalProject_University_.Properties.Resources.LoginButtonHover2;
        }

        private void LoginMouseOut(object sender, EventArgs e)
        {
            loginButton.Image = CSFinalProject_University_.Properties.Resources.LoginButton;
        }

        private void formClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationPageOne rPage = new RegistrationPageOne();
            rPage.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        //Login Button Clicked
        private void loginButton_Click(object sender, EventArgs e)
        {
            id = txtUsername.Text;
            password = txtPassword.Text;
            if (id[2].Equals('-'))
            {                
                if (manager.authUser(id, password) == true)
                {                    
                    AlumniDashboard alumniDashboard = new AlumniDashboard();
                    alumniDashboard.Show();
                    this.Hide();
                }
                else
                {
                    warning.Visible = true;
                }
            }
            else {
                if (manager.authAdmin(id, password) == true)
                {
                    AdminDasboard adminDashboard = new AdminDasboard();
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    warning.Visible = true;
                }

            }
            
        }
    }
}
