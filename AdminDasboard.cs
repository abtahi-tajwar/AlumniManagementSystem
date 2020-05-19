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
    public partial class AdminDasboard : Form
    {
        DatabaseManager databaseManager;
        public AdminDasboard()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            databaseManager = new DatabaseManager();
        }

        //Create Event button clicked
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            DateTime date = System.DateTime.Now;
            databaseManager.createEvent(EventText.Text, date.ToString("MM/dd/yyyy HH:mm:ss"));
            EventText.Text = "";
        }
    }
}
