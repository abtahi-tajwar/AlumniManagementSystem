using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSFinalProject_University_
{
    class DatabaseManager
    {
        string connectionString;
        public static int Count = 0;
        public DatabaseManager() {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\University\C#\Final\CSFinalProject(University)\CSFinalProject(University)\Database1.mdf;Integrated Security=True";
            string sql = "SELECT Count FROM AlumniCount";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Count = Convert.ToInt32(dt.Rows[0]["Count"]);
            cmd.Connection.Close();

        }
        public void UpdateCount() {
            Count++;
            string sql = "UPDATE AlumniCount SET Count='" + Count + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            int rowCount = cmd.ExecuteNonQuery();
            if (rowCount == 0) {
                MessageBox.Show("Count didn't update");
            }
            cmd.Connection.Close();
        }
        public string getAlumni(string col, string id) {
            string sql = string.Format("SELECT {0} FROM Alumni WHERE Id='{1}'", col, id);
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            return (string)dt.Rows[0][col];
        }
        public void createAlumni(int id, string fname, string lname, string sid, string age, string pyear, string present_address, string permanent_address, string father, string mother, string work, string email, string password, string subtitle, string desc) {
            string sql = string.Format("INSERT INTO Alumni (Id, FirstName,LastName, StudentID, Email, Password, Age, PassingYear, PresentAddress, PermanentAddress, FathersName, MothersName, WorkPlace, ProfileSubtitle, ProfileDescription, Verified) VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', {15});", id, fname, lname, sid, email, password, Convert.ToInt32(age), pyear, present_address, permanent_address, father, mother, work, subtitle, desc, 0);            

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            int rowCount = cmd.ExecuteNonQuery();
            if (rowCount == 0)
            {
                MessageBox.Show("Something went wrong");
            }
            else {
                UpdateCount();
            }
            cmd.Connection.Close();

        }
    }
}
