using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumniManagement
{
    public partial class StudentRegistration : Form
    {
        string ConnectionString;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        public StudentRegistration()
        {
            InitializeComponent();
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\AlumniManagement\AlumniManagement\Registration.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(ConnectionString);
            sqlCommand = new SqlCommand("", sqlConnection);

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

                if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text)
                   && !string.IsNullOrEmpty(txtUId.Text) && !string.IsNullOrEmpty(txtMailAdd.Text)
                   && !string.IsNullOrEmpty(txtBloodGroup.Text) && !string.IsNullOrEmpty(txtBatchNo.Text)
                   && !string.IsNullOrEmpty(txtContactNo.Text) && !string.IsNullOrEmpty(txtWorkPlace.Text)
                   && !string.IsNullOrEmpty(txtPreAdd.Text) && !string.IsNullOrEmpty(txtPermAdd.Text))
                {

                    var sql = "INSERT INTO [Registration] ([UniversityId],[UserName],[UserPassword],[BloodGroup],[BatchNo],[MailAdd]," +
                        "[WorkPlace],[PreAddress],[PermAddress]) VALUES (@UI,@UN,@UP,@BG,@BN,@MA,@WP,@PreAdd,@PermAdd)";
                    SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@UI", txtUId.Text);
                    sqlCommand.Parameters.AddWithValue("@UN", txtUserName.Text);
                    sqlCommand.Parameters.AddWithValue("@UP", txtPassword.Text);
                    sqlCommand.Parameters.AddWithValue("@BG", txtBloodGroup.Text);
                    sqlCommand.Parameters.AddWithValue("@BN", txtBatchNo.Text);
                    sqlCommand.Parameters.AddWithValue("@Ma", txtMailAdd.Text);
                    sqlCommand.Parameters.AddWithValue("@WP", txtWorkPlace.Text);
                    sqlCommand.Parameters.AddWithValue("@PreAdd", txtPreAdd.Text);
                    sqlCommand.Parameters.AddWithValue("@PermAdd", txtPermAdd.Text);



                    sqlCommand.Connection.Open();
                    var affectedRowCount = sqlCommand.ExecuteNonQuery();
                    sqlCommand.Connection.Close();

                    if (affectedRowCount > 0)
                    {
                        MessageBox.Show("Registration Done,Please smile..");

                    }
                    else 
                    {
                        MessageBox.Show("Something Went Wrong,please check whats wrong is going on!!");
                    }


                    DataTable datatable = new DataTable();
                    sqlCommand.CommandText = "Select * From Registration";
                    sqlCommand.Connection.Open();
                    datatable.Load(sqlCommand.ExecuteReader());
                    sqlCommand.Connection.Close();

               }
               
                

           
            else
                {
                    MessageBox.Show("Plese give all Info Which Required!");
                }
            
        }

        private void txtUId_Validating(object sender, CancelEventArgs e)
        {
            var text = (sender as TextBox).Text;
            if (String.IsNullOrEmpty(text))
            {
                e.Cancel = true;
                txtUId.Focus();
                errorProvider1.SetError(txtUId, $"User name should not be left blink!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUId, "");
            }

        }

        private void txtUseName_Validating(object sender, CancelEventArgs e)
        {
            var text = (sender as TextBox).Text;
            if (String.IsNullOrEmpty(text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider2.SetError(txtUserName, $"User name should not be left blink!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtUserName, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            var text = (sender as TextBox).Text;
            if (String.IsNullOrEmpty(text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider3.SetError(txtPassword, $"User name should not be left blink!");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(txtPassword, "");
            }
        }
    }
}

