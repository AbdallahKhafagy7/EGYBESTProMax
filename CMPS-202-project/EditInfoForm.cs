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
        public EditInfoForm(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void EditInfoForm_Load(object sender, EventArgs e)
        {
            
        }
        private void EditInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        { 
         
        }

        private void EditInfoForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm(username);
            welcomeForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm(username); 
            welcomeForm.Show();
            this.Close();
        }
    }
}
