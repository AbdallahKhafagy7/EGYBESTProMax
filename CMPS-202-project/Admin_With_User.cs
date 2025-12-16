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
        DBManager dbMan = new DBManager();
        public Admin_With_User()
        {
            InitializeComponent();
            GUIHelper.ApplyModernStyle(this);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            int userID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                int rows = controllerObj.DeleteUser(userID);

                if (rows > 0)
                {
                    MessageBox.Show("User deleted successfully.");
                    dataGridView1.DataSource = controllerObj.GetUsersByName(textBox1.Text); // Refresh grid
                }
                else
                {
                    MessageBox.Show("Failed to delete user.");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user.");
                return;
            }
            object cellValue = dataGridView1.SelectedRows[0].Cells["UserID"].Value;
            if (cellValue == null)
            {
                MessageBox.Show("UserID is not valid.");
                return;
            }

            int userID = 0;
            if (!int.TryParse(cellValue.ToString(), out userID))
            {
                MessageBox.Show("Failed to read UserID.");
                return;
            }

            string defaultPassword = "123456";

            int rows = controllerObj.ResetUserPassword(userID, defaultPassword);

            if (rows > 0)
            {
                MessageBox.Show("Password reset successfully.\nNew password: 123456");
            }
            else
            {
                MessageBox.Show("Failed to reset password. Make sure the user exists.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_With_User_Load(object sender, EventArgs e)
        {

        }

        private void Admin_With_User_Load_1(object sender, EventArgs e)
        {

        }
    }
}