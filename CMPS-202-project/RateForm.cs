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
    public partial class RateForm : Form
    {
        Controller controllerobj =new Controller();
        string username;

        
        public RateForm(string username)
        {
            InitializeComponent();
            label3.Hide();
            this.username = username;
        }

        private void RateForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                label4.Show();
            }
            else
            {
                label4.Hide();
            }

            if (dataGridView1.SelectedRows[0].Cells[0].Value == null)
            {
                label5.Show();
            }
            else
            {
                label5.Hide();
            }

            int k = controllerobj.UpdateRating(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),textBox2.Text,username);
            if (k == 0)
            {
                   
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm(username);
            welcomeForm.Show();
            this.Close();
        }
    }
}
