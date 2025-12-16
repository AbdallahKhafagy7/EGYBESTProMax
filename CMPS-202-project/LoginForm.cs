using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPS_202_project
{
    public partial class LoginForm : Form
    {
        Controller controllerObj = new Controller();

        // Properties to pass data to Program.cs
        public string LoggedInEmail { get; private set; }
        public string LoggedInUserType { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            GUIHelper.ApplyModernStyle(this);
            textBox2.UseSystemPasswordChar = true;
            label6.Hide();
            label7.Hide();
            label8.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(220, 20, 60);
            label3.Cursor = Cursors.Hand;
            label3.MouseEnter += (s, ev) => label3.ForeColor = Color.Red;
            label3.MouseLeave += (s, ev) => label3.ForeColor = Color.FromArgb(220, 20, 60);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Email = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(Email))
            {
                label6.Show();
                return;
            }
            else
            {
                label6.Hide();
            }

            int result = controllerObj.IsEmailExists(Email);

            if (result == 0)
            {
                label8.Show();
            }
            else
            {
                // Controller now handles hashing inside CheckPassword
                if (!controllerObj.CheckPassword(Email, password))
                {
                    label7.Show();
                }
                else
                {
                    // LOGIN SUCCESS
                    // 1. Store info for Program.cs
                    LoggedInEmail = Email;
                    LoggedInUserType = controllerObj.GetUserType(Email);

                    // 2. Set Result to OK so Program.cs knows to proceed
                    this.DialogResult = DialogResult.OK;

                    // 3. Close this form
                    this.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Open SignUpForm as a modal dialog
            this.Hide();
            SignUpForm signIn = new SignUpForm();
            signIn.ShowDialog();
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}