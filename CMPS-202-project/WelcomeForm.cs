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
    public partial class WelcomeForm : Form
    {
        ListForm list;
        RateForm rate;
        Controller controllerobj= new Controller();
        public string username;

        public WelcomeForm(string username ="")
        {
            InitializeComponent();
            ListForm list = new ListForm(this);
            RateForm rate = new RateForm(this,username);
            label2.Text = "Welcome " + controllerobj.GetNameFromEmail(username);
            this.username= username;
            dataGridView1.Hide();
            DataTable dt = controllerobj.getAllist(username);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "list";
            comboBox1.SelectedIndex = -1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.getShows(username,comboBox1.SelectedText);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            // TODO:: Show data in dataGridView1
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (list == null || list.IsDisposed)
            {
                list = new ListForm(this);
            }
            this.Hide();
            list.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rate == null || rate.IsDisposed)
            {
                list = new ListForm(this);
            }
            this.Hide();
            rate.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
