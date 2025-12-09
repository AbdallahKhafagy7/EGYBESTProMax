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
        Controller Controllerobj =new Controller();
        public SignUpForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (String.IsNullOrEmpty(textBox2.Text)) 
            {
                label7.ForeColor = Color.Red;
                label7.Text = "the E-mail Can't Be empty";
                label7.Show();
                return;
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                label9.ForeColor = Color.Red;
                label9.Text = "Please enter your name";
                label9.Show();
                return;
            }
            if (String.IsNullOrEmpty(textBox4.Text)) {

                label10.ForeColor = Color.Red;
                label10.Text = "Must enter a password";
                label10.Show();
                return;
            }
            if (string.IsNullOrEmpty(textBox5.Text) && !(textBox4.Text == textBox5.Text) )
            { 
                label10.ForeColor = Color.Red;
                label10.Text = "the Passwords Must match";
                label10.Show();
                return;
            }

            int k = Controllerobj.addUser(textBox2.Text,textBox3.Text,textBox4.Text);
            if (k == 0)
            {
                label10.Text = "sign- failed : the email already exists";
            
            }
            else
            {
                MessageBox.Show("login successful");
                this.Close();
                loginForm.Show();
            }



        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
