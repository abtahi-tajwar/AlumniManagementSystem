using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFinalProject_University_
{
    class Session
    {
        public static int id = -1;
        public static string fname, lname, sid, email, password, pyear, present_address, permanent_address, father, mother, work, subtitle, desc, picture;
        public static int age, verified;
        public static void createSession()
        {
            DatabaseManager database = new DatabaseManager();
            
            fname = database.getAlumni("FirstName", id);          
            lname = database.getAlumni("LastName", id);
            sid = database.getAlumni("StudentID", id);
            email = database.getAlumni("Email", id);
            password = database.getAlumni("Password", id);
            age = Convert.ToInt32(database.getAlumni("Age", id));            
            pyear = database.getAlumni("PassingYear", id);
            present_address = database.getAlumni("PresentAddress", id);
            permanent_address = database.getAlumni("PermanentAddress", id);
            father = database.getAlumni("FathersName", id);
            mother = database.getAlumni("MothersName", id);
            work = database.getAlumni("WorkPlace", id);
            subtitle = database.getAlumni("ProfileSubtitle", id);
            desc = database.getAlumni("ProfileDescription", id);
            picture = database.getAlumni("ProfilePicture", id);
            verified = Convert.ToInt32(database.getAlumni("Verified", id));
            
        }
        public static void clearSession()
        {
            id = -1;
        }
    }
    
}
