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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\Alumni.mdf;Integrated Security=True;Connect Timeout=30"; ;
            string sql = string.Format("insert into Student(Name,UniversityId,Password,Department,Batch,BloodGroup,Email,Contact,PlaceOfWork,Address)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",Nametxt.Text,Idtxt.Text,Passwordtxt.Text,Depttxt.Text,batchtxt.Text,bloodtxt.Text,Emailtxt.Text,Contxt.Text,Placetxt.Text,Addresstxt.Text);

            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);
            sqlCmd.Connection.Open();
            int rowsAffected = sqlCmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Saved Successfully!!");

            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
            sqlCmd.Connection.Close();
        }
    }
}
