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
    public partial class ListForm : Form
    {
        WelcomeForm welcomeForm;
        Controller controllerObj = new Controller();
        public ListForm(WelcomeForm welcomeForm)
        {
            this.welcomeForm = welcomeForm;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                label2.ForeColor = Color.Red;
                label2.Text = "the Show name Can't Be empty";
                label2.Show();
                return;
            }
            label2.Hide();
            DataTable dt = controllerObj.GetShowsByName(textBox1.Text);
            dataGridView1.DataSource = dt;
            return;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
