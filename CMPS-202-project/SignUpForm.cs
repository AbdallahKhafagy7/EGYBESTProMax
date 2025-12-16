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
    public partial class SignUpForm : Form
    {
        LoginForm loginForm;
        Controller controllerObj = new Controller();

        public SignUpForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;

            // 1. Apply Modern Theme
            GUIHelper.ApplyModernStyle(this);

            // 2. Hide Error Labels initially
            lblErrorEmail.Hide();
            lblErrorName.Hide();
            lblErrorPass.Hide();
            lblErrorConfirm.Hide();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            // Style the "Login" link manually since it's a Label acting as a button
            lblLoginLink.ForeColor = Color.FromArgb(220, 20, 60); // Modern Red
            lblLoginLink.Cursor = Cursors.Hand;

            // Add Hover Effects
            lblLoginLink.MouseEnter += (s, ev) => lblLoginLink.ForeColor = Color.Red;
            lblLoginLink.MouseLeave += (s, ev) => lblLoginLink.ForeColor = Color.FromArgb(220, 20, 60);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Reset Errors
            lblErrorEmail.Hide();
            lblErrorName.Hide();
            lblErrorPass.Hide();
            lblErrorConfirm.Hide();

            string email = txtEmail.Text.Trim();
            string name = txtUsername.Text.Trim();
            string pass = txtPassword.Text;
            string confirm = txtConfirm.Text;

            // 1. Validation
            bool isValid = true;

            if (string.IsNullOrEmpty(email))
            {
                lblErrorEmail.Show();
                isValid = false;
            }
            if (string.IsNullOrEmpty(name))
            {
                lblErrorName.Show();
                isValid = false;
            }
            if (string.IsNullOrEmpty(pass))
            {
                lblErrorPass.Show();
                isValid = false;
            }
            if (pass != confirm)
            {
                lblErrorConfirm.Show();
                isValid = false;
            }

            if (!isValid) return;

            // 2. Call Controller
            // Note: Ensure Controller.addUser signature is (Email, Name, Password)
            int result = controllerObj.addUser(email, name, pass);

            if (result == 0)
            {
                MessageBox.Show("Sign Up Failed: This email already exists.");
            }
            else
            {
                MessageBox.Show("Account created successfully!");
                this.Close();
                loginForm.Show();
            }
        }

        private void lblLoginLink_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle visibility for both password fields
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
            txtConfirm.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        // Prevent app closing if user clicks 'X'
        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }
    }
}