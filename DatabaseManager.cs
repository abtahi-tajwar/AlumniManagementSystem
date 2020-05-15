using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFinalProject_University_
{
    class DatabaseManager
    {
        public DatabaseManager() {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\University\C#\Final\CSFinalProject(University)\CSFinalProject(University)\Database1.mdf;Integrated Security=True";

        }
        public string getAlumni(string col, string id) {
            string sql = string.Format("SELECT {1} FROM ")
            return null;
        }
    }
}
