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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            RefreshListComboBox();
            GUIHelper.ApplyModernStyle(this);
        }

        private void RefreshListComboBox()
        {
            comboBox1.DisplayMember = "list";
            DataTable dt = controllerObj.getAllist(username);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "list";
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
            label2.Hide();

            if (comboBox1.SelectedIndex == -1)
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Please select a list.";
                label2.Show();
                return;
            }


            string showName = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();

            DataTable dt = controllerObj.GetShowByName(showName);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Show not found.");
                return;
            }

            int mediaId = Convert.ToInt32(dt.Rows[0]["MediaID"]);

            string listName = comboBox1.Text;
                
            string userName = controllerObj.GetNameFromEmail(username);

            int result = controllerObj.AddShowToList(listName, mediaId, userName);

            if (result == 0)
            {
                MessageBox.Show("Error adding the show to the list.");
            }
            else
            {
                MessageBox.Show("Show added successfully to the list.");
            }
        }
        

        // Search by Show Name
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

        private void btnCreateList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewListName.Text))
            {
                MessageBox.Show("Please enter a name for the new list.");
                return;
            }

            // Use the Controller to get the correct UserID from the email (stored in 'username' variable)
            int userId = controllerObj.GetUserIDFromEmail(username);

            if (userId == -1)
            {
                MessageBox.Show("Error: User not found.");
                return;
            }

            int result = controllerObj.InsertList(txtNewListName.Text, userId);

            if (result > 0)
            {
                MessageBox.Show("List created successfully!");
                txtNewListName.Clear();
                RefreshListComboBox();
            }
            else
            {
                MessageBox.Show("Failed to create list. It might already exist.");
            }
        }

        private void btnSearchActor_Click_1(object sender, EventArgs e)
        {
            // Ensure you have a textbox named 'txtSearchActor' in your Designer
            if (string.IsNullOrWhiteSpace(txtSearchActor.Text))
            {
                MessageBox.Show("Please enter an actor name.");
                return;
            }

            // Call the specific controller method for Actor Search
            DataTable dt = controllerObj.GetShowsByActor(txtSearchActor.Text);

            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No shows found for this actor.");
            }
        }

        private void txtSearchActor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}