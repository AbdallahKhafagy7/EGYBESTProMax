using DBapplication;
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
    public partial class Admin_With_User : Form
    {
        Controller controllerObj = new Controller();
        public Admin_With_User()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label2.Show();
                return;
            }
            else
            {
                label2.Hide();
                DataTable dataTable = controllerObj.GetUsersByName(textBox1.Text);
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
