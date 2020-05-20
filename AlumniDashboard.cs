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
    public partial class AlumniDashboard : Form
    {
        DatabaseManager manager;
        public AlumniDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
            

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        //Close icon clicked
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Logout button clicked
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            LoginForm loginFrom = new LoginForm();
            loginFrom.Show();
            this.Hide();
        }

        private void GoingFalse_Click(object sender, EventArgs e)
        {
            manager.updateEventCount(Session.id);
            GoingTrue.Visible = true;
            GoingFalse.Visible = false;
        }
        
        //Rubaia Apu Code
        
    }
}
