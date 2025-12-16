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
        string mail;

        
        public RateForm(string mail)
        {
            InitializeComponent();
            label3.Hide();
            this.mail = mail;
            dataGridView1.MultiSelect = false;
            GUIHelper.ApplyModernStyle(this);
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
                label2.Show();
            }
            else
            {
                label2.Hide();
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                label5.Hide();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string showName = selectedRow.Cells["Name"].Value.ToString();
                int rating = Convert.ToInt32(textBox2.Text);
                // update rating
                int status = controllerobj.RateShow(mail, showName, rating);
                if (status == 0)
                {
                    MessageBox.Show("Error updating rating.");
                }
                else
                {
                    MessageBox.Show("Rating updated successfully.");
                }
            }
            else
            {
                label5.Show();
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            DataTable dt = controllerobj.GetShowsByName(name);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm(mail);
            welcomeForm.Show();
            this.Close();
        }
    }
}
