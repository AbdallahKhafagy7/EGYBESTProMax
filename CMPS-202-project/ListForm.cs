using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CMPS_202_project
{
    public partial class ListForm : Form
    {
        Controller controllerObj = new Controller();
        string mail;

        public ListForm(string mail)
        {
            this.mail = mail;
            InitializeComponent();
            label2.Hide();
            label3.Hide();
            label4.Hide();

            int userId = controllerObj.GetUserIDFromEmail(mail);

            DataTable dt = controllerObj.GetUserLists(userId);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ListName";
            comboBox1.SelectedIndex = -1;

            GUIHelper.ApplyModernStyle(this);
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
            label4.Hide();

            if (comboBox1.SelectedIndex == -1)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Please select a list.";
                label4.Show();
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Please select a show from the list.";
                label4.Show();
                return;
            }

            // Get the selected list name
            string listName = comboBox1.Text;

            // Get the selected show name from DataGridView
            string showName = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();

            // Get MediaID from show name
            int mediaId = controllerObj.GetMediaIDByName(showName);
            if (mediaId == 0)
            {
                MessageBox.Show("Selected show not found in database.");
                return;
            }

            // Get UserID
            int userId = controllerObj.GetUserIDFromEmail(mail);

            // Insert into ListItems
            int result = controllerObj.InsertListItem(listName, userId, mediaId);

            if (result == 0)
            {
                MessageBox.Show("Error adding the show to the list.");
            }
            else
            {
                MessageBox.Show("Show added successfully to the list.");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label2.Hide();
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                label2.ForeColor = Color.Red;
                label2.Text = "The Show name Can't Be empty";
                label2.Show();
                return;
            }
            DataTable dt = controllerObj.GetShowsByName(textBox1.Text);
            dataGridView1.DataSource = dt;
            return;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm(mail);
            welcomeForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Hide();
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                label3.ForeColor = Color.Red;
                label3.Text = "The List name Can't Be empty";
                label3.Show();
                return;
            }
            else
            {
                string listName = textBox2.Text;
                int userId = controllerObj.GetUserIDFromEmail(mail);

                int result = controllerObj.InsertList(listName, userId);
                if (result == 0)
                {
                    MessageBox.Show("Error adding the list.");
                }
                else
                {
                    MessageBox.Show("List added successfully.");
                }

                DataTable dt = controllerObj.GetUserLists(userId);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "ListName";
                comboBox1.SelectedIndex = -1;
            }
        }
    }
}
