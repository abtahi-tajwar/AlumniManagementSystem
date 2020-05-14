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
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Student ID") { 
                
            }
        }

        void passwordReset(object sender, EventArgs e)
        {
            if (!password.UseSystemPasswordChar) {
                password.UseSystemPasswordChar = true;
                password.Text = "";
            }
            
        }
        void passwordPlaceholder(object sender, EventArgs e)
        {
            if (password.Text == "") {
                password.Text = "Password";
                password.UseSystemPasswordChar = false;
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
    }
}
