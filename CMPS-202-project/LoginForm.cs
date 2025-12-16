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
        public LoginForm()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
            label6.Hide();
            label7.Hide();
            label8.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Email = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // 1. Basic Validation: Don't allow empty inputs
            if (string.IsNullOrEmpty(Email))
            {
                label6.Show();
                return;
            }
            else
            {
                label6.Hide();
            }

            int result = controllerObj.IsEmailExists(Email); // TODO:: Make this


            if (result == 0)
            {
                label8.Show();
            }
            else
            {
                    
                if (!controllerObj.CheckPassword(Email, password))
                {
                    label7.Show();
                }
                else
                {
                    if (controllerObj.GetUserType(Email) == "EndUser")
                    {
                        WelcomeForm welcome = new WelcomeForm(Email);
                        welcome.Show();
                        this.Hide();
                    }
                    else if (controllerObj.GetUserType(Email) == "Administrator")
                    {
                        AdminForm adminForm = new AdminForm(Email);
                        adminForm.Show();
                        this.Hide();
                    }
                    else if (controllerObj.GetUserType(Email) == "Publisher")
                    {
                        PublisherForm PublisherList = new PublisherForm(Email);
                        PublisherList.Show();
                        this.Hide();
                    }
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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            SignUpForm signIn = new SignUpForm(this);
            signIn.Show();
            this.Hide();

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
