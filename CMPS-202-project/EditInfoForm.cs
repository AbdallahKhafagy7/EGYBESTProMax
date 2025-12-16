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
    public partial class EditInfoForm : Form
    {
        string username;
        Controller controllerObj = new Controller();
        string email;
        public EditInfoForm(string username, string email)
        {
            this.username = username;
            InitializeComponent();
            this.email = email;
            GUIHelper.ApplyModernStyle(this);
        }

        private void EditInfoForm_Load(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm(email); 
            welcomeForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                label4.Show();
                return;
            }
            else
            {
                int k = controllerObj.UpdateName(email,textBox3.Text);
                if (k == -1)
                {
                    MessageBox.Show("error, user not found");
                    return;
                }
                else
                if (k > 0)
                {
                    MessageBox.Show("updated sucessfully");
                }
                else
                {
                    MessageBox.Show("update failed");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string currentPassword = controllerObj.GetAdminPassword(username).ToString();// If you want to verify first
            string newPassword = textBox2.Text;
            string confirmPassword = textBox1.Text;

            // 1. Verify inputs
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New passwords do not match!");
                return;
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Password cannot be empty.");
                return;
            }

            // Optional: Verify current password first using CheckPassword logic
            if (!controllerObj.CheckPassword(email, currentPassword))
            {
                MessageBox.Show("Current password is incorrect.");
                return;
            }

            // 2. Call Controller to Update
            int result = controllerObj.UpdatePassword(email, newPassword);

            if (result > 0)
            {
                MessageBox.Show("Password updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to update password.");
            }
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
