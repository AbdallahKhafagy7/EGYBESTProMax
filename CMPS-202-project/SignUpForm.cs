using DBapplication;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CMPS_202_project
{
    public partial class SignUpForm : Form
    {
        Controller controllerObj = new Controller();
        LoginForm loginForm;

        public SignUpForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;

            // 1. Apply Modern Dark/Red Theme
            GUIHelper.ApplyModernStyle(this);

            // 2. Configure Password Field
            textBox3.UseSystemPasswordChar = true;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            // Force the "Login" link to be Red and clickable
            label5.ForeColor = Color.FromArgb(220, 20, 60);
            label5.Cursor = Cursors.Hand;

            // Hover Effects for Link
            label5.MouseEnter += (s, ev) => label5.ForeColor = Color.Red;
            label5.MouseLeave += (s, ev) => label5.ForeColor = Color.FromArgb(220, 20, 60);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string password = textBox3.Text.Trim();

            // 1. Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // 2. Call Controller to Add User
            // Note: controllerObj.addUser returns 1 if success, 0 if failed (e.g., email exists)
            int result = controllerObj.addUser(email, username, password);

            if (result > 0)
            {
                MessageBox.Show("Account created successfully!");

                // Go back to Login
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. This email might already represent an account.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Back to Login
            loginForm.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle Password Visibility
            textBox3.UseSystemPasswordChar = !checkBox1.Checked;
        }

        // Prevent crashes if these events are linked in designer
        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }
    }
}