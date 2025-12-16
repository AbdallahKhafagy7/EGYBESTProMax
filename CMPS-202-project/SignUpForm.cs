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
        // Removed LoginForm dependency
        Controller controllerObj = new Controller();

        public SignUpForm()
        {
            InitializeComponent();

            GUIHelper.ApplyModernStyle(this);

            lblErrorEmail.Hide();
            lblErrorName.Hide();
            lblErrorPass.Hide();
            lblErrorConfirm.Hide();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            lblLoginLink.ForeColor = Color.FromArgb(220, 20, 60);
            lblLoginLink.Cursor = Cursors.Hand;
            lblLoginLink.MouseEnter += (s, ev) => lblLoginLink.ForeColor = Color.Red;
            lblLoginLink.MouseLeave += (s, ev) => lblLoginLink.ForeColor = Color.FromArgb(220, 20, 60);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            lblErrorEmail.Hide();
            lblErrorName.Hide();
            lblErrorPass.Hide();
            lblErrorConfirm.Hide();

            string email = txtEmail.Text.Trim();
            string name = txtUsername.Text.Trim();
            string pass = txtPassword.Text;
            string confirm = txtConfirm.Text;

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

            // Controller hashes the password internally now
            int result = controllerObj.addUser(email, name, pass);

            if (result == 0)
            {
                MessageBox.Show("Sign Up Failed: This email already exists.");
            }
            else
            {
                MessageBox.Show("Account created successfully!");
                this.Close(); // Just close. LoginForm is waiting in background.
            }
        }

        private void lblLoginLink_Click(object sender, EventArgs e)
        {
            this.Close(); // Return to Login
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
            txtConfirm.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // No action needed, parent form (Login) handles re-showing
        }
    }
}