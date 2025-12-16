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
        DBManager dbMan = new DBManager();
        public Admin_with_publisher()
        {
            InitializeComponent();
            GUIHelper.ApplyModernStyle(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a publisher to delete.");
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
                    dataGridView2.DataSource = controllerObj.GetAllPublishers();
                }
                else
                {
                    MessageBox.Show("Failed to delete publisher.");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetAllPublishers();
            dataGridView2.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a show to delete.");
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
                    dataGridView1.DataSource = controllerObj.GetAllShows();
                }
                else
                {
                    MessageBox.Show("Failed to delete show.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetAllShows();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_with_publisher_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
