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
        Controller controllerObj = new Controller();
        string username;

        public ListForm(string username)
        {
            this.username = username;
            InitializeComponent();
            comboBox1.DisplayMember = "list";
            DataTable dt = controllerObj.getAllist(username);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "list";
            GUIHelper.ApplyModernStyle(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Standardized Load method
        private void ListForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a list to add the show to.");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a show from the table.");
                return;
            }

            // Ensure your query returns a column named 'MediaID'
            if (dataGridView1.SelectedRows[0].Cells["MediaID"] == null)
            {
                MessageBox.Show("Error: MediaID column not found.");
                return;
            }

            string mediaIdString = dataGridView1.SelectedRows[0].Cells["MediaID"].Value.ToString();
            int mediaId = int.Parse(mediaIdString);
            string listName = comboBox1.Text;

            int result = controllerObj.AddShowToList(listName, mediaId, username);

            if (result > 0)
            {
                MessageBox.Show("Show added to list successfully!");
            }
            else if (result == -1)
            {
                MessageBox.Show("This show is already in that list!");
            }
            else
            {
                MessageBox.Show("Failed to add show.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                label2.ForeColor = Color.Red;
                label2.Text = "The Show name Can't Be empty";
                label2.Show();
                return;
            }
            label2.Hide();
            DataTable dt = controllerObj.GetShowsByName(textBox1.Text);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm(username);
            welcomeForm.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}