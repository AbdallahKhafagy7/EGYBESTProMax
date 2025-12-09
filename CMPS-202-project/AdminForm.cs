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
        public AdminForm(string username)
        {
            InitializeComponent();
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
    }
}
