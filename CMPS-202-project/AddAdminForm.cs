using DBapplication;
using System;
﻿using System;
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
    public partial class AddAdminForm : Form
    {

        Controller controllerObj = new Controller();


        public AddAdminForm()
        {
            InitializeComponent();
            GUIHelper.ApplyModernStyle(this);
        }

        private void buttonCreateAdmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxEmail.Text) ||
                string.IsNullOrEmpty(textBoxPassword.Text) ||
                string.IsNullOrEmpty(textBoxConfirm.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (textBoxPassword.Text != textBoxConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            int rows = controllerObj.AddAdmin(email, name, password);

            if (rows > 0)
            {
                MessageBox.Show("Admin account created successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create admin.\nEmail may already exist.");
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = checkBoxShowPassword.Checked;
            textBoxPassword.UseSystemPasswordChar = !show;
            textBoxConfirm.UseSystemPasswordChar = !show;
        }

        private void AddAdminForm_Load(object sender, EventArgs e)
        {

        }
        private void buttonAddAdmin_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) ||
               string.IsNullOrEmpty(textBoxEmail.Text) ||
               string.IsNullOrEmpty(textBoxPassword.Text) ||
               string.IsNullOrEmpty(textBoxConfirm.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (textBoxPassword.Text != textBoxConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            int rows = controllerObj.AddAdmin(email, name, password);

            if (rows > 0)
            {
                MessageBox.Show("Admin added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add admin. Email may already exist.");
            }
        }

    }
}
