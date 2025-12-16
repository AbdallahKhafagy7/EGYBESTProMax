using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPS_202_project
{
    public partial class AdminForm : Form
    {
        string username;
        Admin_with_publisher Admin_With_Publisher = new Admin_with_publisher();
        Admin_With_User Admin_With_User = new Admin_With_User();
        StatsForm statsForm = new StatsForm();
        public AdminForm(string username)
        {
            InitializeComponent();
            GUIHelper.ApplyModernStyle(this);
            this.username = username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_With_User.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_With_Publisher.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            statsForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddAdminForm f = new AddAdminForm();
            f.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            MessageBox.Show("Logged out successfully.");
            this.Close();
        }
    }
}
