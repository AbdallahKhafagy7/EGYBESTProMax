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
        EditInfoForm edit;
        Controller controllerobj= new Controller();
        public string email;

        public WelcomeForm(string email ="")
        {
            InitializeComponent();
            this.list = new ListForm(email);
            this.rate = new RateForm(email);
            this.edit = new EditInfoForm(controllerobj.GetNameFromEmail(email),email);
            label2.Text = "Welcome " + controllerobj.GetNameFromEmail(email);
            this.email= email;
            dataGridView1.Hide();
            DataTable dt = controllerobj.getAllist(email);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "list";
            comboBox1.SelectedIndex = -1;
            GUIHelper.ApplyModernStyle(this);
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
            DataTable dt = controllerobj.getShows(email,comboBox1.SelectedText);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            // TODO:: Show data in dataGridView1
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (list == null || list.IsDisposed)
            {
                list = new ListForm(email);
                this.Close();
            }
            this.Close();
            list.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rate == null || rate.IsDisposed)
            {
                rate = new RateForm(email);
                this.Close();
                return;
            }
            this.Close();
            rate.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rate == null || rate.IsDisposed)
            {
                edit = new EditInfoForm(controllerobj.GetNameFromEmail(email),email);
                this.Close();
                return;
            }
            edit.Show();
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
