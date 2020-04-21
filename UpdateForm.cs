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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm sf = new StudentForm();
            sf.Show();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            LoadUserGridData();
        }
        void LoadUserGridData()
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\Alumni.mdf;Integrated Security=True;Connect Timeout=30"; 
            string sql="UPDATE Student SET Name='" + Nametxt.Text + "',Password='" + Passtxt.Text + "', Email ='" + Emailtxt.Text + "',Place Of Work ='" + Placetxt.Text + "', Address='" + Addresstxt.Text + "' WHERE Id =" +Idtxt.Text+ "";

            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            DataTable dt = new DataTable();

            sqlCmd.Connection.Open();
            dt.Load(sqlCmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            sqlCmd.Connection.Close();
        }
    }
}
