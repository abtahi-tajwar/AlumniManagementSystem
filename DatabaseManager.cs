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
        public static int EventCount = 0;
        Session session = new Session();
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

            //Event Count Init
            EventCount = getLatestEventNumber();

        }
        //Function for making query and get data table
        public DataTable Query(string sql)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            return dt;

        }
        //Function for making query to update data table
        public int NonQuery(string sql)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            return cmd.ExecuteNonQuery();
        }
        public void UpdateCount() {
            Count++;
            string sql = "UPDATE AlumniCount SET Count='" + Count + "' WHERE ID = 0";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            int rowCount = cmd.ExecuteNonQuery();
            if (rowCount == 0) {
                MessageBox.Show("Count didn't update");
            }
            cmd.Connection.Close();
        }
        public string getAlumni(string col, int id) {
            string sql = string.Format("SELECT {0} FROM Alumni WHERE Id={1}", col, id);
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            if (col.Equals("Age") || col.Equals("Verified")) {
                return Convert.ToInt32(dt.Rows[0][col]).ToString();
            }
            return (string)dt.Rows[0][col];
        }
        public bool authUser(string id, string password) { 

            string sql = string.Format("SELECT * FROM Alumni WHERE StudentID='{0}'", id);
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());            
            Console.WriteLine("BB"+dt.ToString());
            if (dt.Rows.Count > 0) {
                if (password.Equals(dt.Rows[0]["Password"]))
                {
                    Session.id = Convert.ToInt32(dt.Rows[0]["Id"]);
                    Session.createSession();
                    return true;
                }
            }            
            return false;
        }
        public bool authAdmin(string id, string password)
        {
            string sql = string.Format("SELECT * FROM Admin WHERE AdminID='{0}'", id);
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Console.WriteLine("BB" + dt.ToString());
            if (dt.Rows.Count > 0)
            {
                if (password.Equals(dt.Rows[0]["Password"]))
                {
                    Session.id = Convert.ToInt32(dt.Rows[0]["Id"]);
                    Session.createSession();
                    return true;
                }
            }
            return false;
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
        public void updateAlumni(int id, string feature, string value)
        {
            NonQuery("UPDATE Alumni SET " + feature + " = '" + value + "' WHERE Id = " + id);
        }

        /////////
        //Events
        /// <summary>
        /// Here all event code goes
        /// </summary>
        /// <returns></returns>
        
        public int getLatestEventNumber() {
            int eventNumber;
            DataTable dt = Query("SELECT * FROM AlumniCount WHERE Id = 1");            
            eventNumber = Convert.ToInt32(dt.Rows[0]["Count"]);
            return eventNumber;
        }
        public void updateEventNumber() {
            EventCount++;
            int result = NonQuery("UPDATE AlumniCount SET Count='" + EventCount + "' WHERE ID = 1");
        }
        public void createEvent(string eventDesc, string date)
        {
            NonQuery(string.Format("INSERT INTO Events (Id, EventName, EventDate, Perticipants) VALUES ({0}, '{1}', '{2}', {3})", EventCount, eventDesc, date, 0));
            updateEventNumber();
        }
        public string getLastEvent(string type)
        {
            if (type.ToLower().Equals("name"))
            {
                DataTable dt = Query("SELECT EventName FROM Events ORDER BY Id DESC");
                return dt.Rows[0]["EventName"].ToString();

            }
            else if (type.ToLower().Equals("date"))
            {
                DataTable dt = Query("SELECT EventDate FROM Events ORDER BY Id DESC");
                return dt.Rows[0]["EventDate"].ToString();
            }
            else {
                return "Error";
            }
        }
        public void updateEventCount(int id)
        {
            DataTable dt = Query("SELECT * FROM Events ORDER BY Id DESC");
            int num = Convert.ToInt32(dt.Rows[0]["Perticipants"]);
            int EventID = Convert.ToInt32(dt.Rows[0]["Id"]);
            num = num + 1;
            NonQuery("UPDATE Events SET Perticipants = " + num + "WHERE Id = " + EventID);
            NonQuery(String.Format("INSERT INTO EventPerticipants (EventID, AlumniID) VALUES ({0}, {1})", EventID, id));
        }
        public bool checkEventGoing(int id)
        {
            DataTable dt = Query("SELECT * FROM EventPerticipants WHERE AlumniID = " + id);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
