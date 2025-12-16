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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CMPS_202_project
{
    public partial class Admin_with_publisher : Form
    {
        Controller controllerObj = new Controller();
        // DBManager dbMan = new DBManager(); // Not used directly, Controller handles DB

        public Admin_with_publisher()
        {
            InitializeComponent();
            GUIHelper.ApplyModernStyle(this);
        }

        private void Admin_with_publisher_Load(object sender, EventArgs e)
        {
            // Optional: Auto-load data when form opens
            // button3_Click(sender, e); // Load Publishers
            // button4_Click(sender, e); // Load Shows
        }

        // --- Publisher Management ---

        private void button3_Click(object sender, EventArgs e) // Load Publishers
        {
            DataTable dt = controllerObj.GetAllPublishers();
            dataGridView2.DataSource = dt;
        }

        private void btnAddPublisher_Click(object sender, EventArgs e) // Add Publisher
        {
            // Logic to add publisher is handled in Form2 usually, 
            // but if you want a dialog here later, this is the placeholder.
            MessageBox.Show("This feature will be implemented soon.");
        }

        private void button1_Click(object sender, EventArgs e) // Delete Publisher
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a publisher to delete.");
                return;
            }

            // Ensure 'UserID' column exists in your GetAllPublishers query
            if (dataGridView2.SelectedRows[0].Cells["UserID"] == null)
            {
                MessageBox.Show("Error: UserID column not found.");
                return;
            }

            int userID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["UserID"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this publisher?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                int rows = controllerObj.DeletePublisher(userID);
                if (rows > 0)
                {
                    MessageBox.Show("Publisher deleted successfully.");
                    // Refresh list
                    button3_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to delete publisher.");
                }
            }
        }

        // --- Show Management ---

        private void button4_Click(object sender, EventArgs e) // Load Shows
        {
            DataTable dt = controllerObj.GetAllShows();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e) // Delete Show
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a show to delete.");
                return;
            }

            // Ensure 'MediaID' column exists
            if (dataGridView1.SelectedRows[0].Cells["MediaID"] == null)
            {
                MessageBox.Show("Error: MediaID column not found.");
                return;
            }

            int mediaID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MediaID"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this show?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                int rows = controllerObj.DeleteShow(mediaID);
                if (rows > 0)
                {
                    MessageBox.Show("Show deleted successfully.");
                    // Refresh list
                    button4_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to delete show.");
                }
            }
        }

        // --- Navigation ---

        private void button5_Click(object sender, EventArgs e) // Go to Data Entry (Form2)
        {
            publisher_actor form = new publisher_actor();
            form.Show();
        }

        // Unused events
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}