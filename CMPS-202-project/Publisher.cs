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

namespace CMPS_202_project
{
    public partial class PublisherForm : Form
    {
        string email;
        Controller controllerObj = new Controller();
        public PublisherForm(string email)
        {
            InitializeComponent();
            this.email = email;
            //label4.Hide();
            dataGridView1.AllowUserToAddRows = false;
            GUIHelper.ApplyModernStyle(this);
        }

        private void Publisher_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.GetPublisherByEmail(email);
            int id = Convert.ToInt32(dt1.Rows[0][0]);

            DataTable dt2 = controllerObj.GetShowsByPublisherId(id);
            if (dt2 != null)
            {
                if (dt2.Rows.Count == 0)
                {
                    MessageBox.Show("No shows found for you");
                }
                else
                {
                    dataGridView1.DataSource = dt2;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 1. Validate show name
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a show name.");
                return;
            }

            // 2. Validate episode count
            if (!int.TryParse(textBox3.Text, out int episodesCount) || episodesCount <= 0)
            {
                MessageBox.Show("Please enter a valid episode count (positive integer).");
                return;
            }

            // validate genre
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a genre.");
                return;
            }

            string genre = textBox1.Text;
            string showName = textBox2.Text;

            // 3. Get publisher
            DataTable dtPublisher = controllerObj.GetPublisherByEmail(email);
            if (dtPublisher.Rows.Count == 0)
            {
                MessageBox.Show("Publisher not found.");
                return;
            }

            int publisherID = Convert.ToInt32(dtPublisher.Rows[0][0]);

            // 4. Check if show already exists by name
            DataTable dtShow = controllerObj.GetShowByName(showName); // just by name
            int mediaId;

            if (dtShow.Rows.Count == 0)
            {
                // Show does not exist → insert new show with first season
                mediaId = controllerObj.InsertShow(publisherID, showName, episodesCount, genre);
                if (mediaId == 0)
                {
                    MessageBox.Show("Error adding show.");
                    return;
                }
                MessageBox.Show("Show added successfully with Season 1.");
            }
            else
            {
                // Show exists → add new season
                mediaId = Convert.ToInt32(dtShow.Rows[0]["MediaID"]);
                int result = controllerObj.AddSeason(mediaId, episodesCount);
                if (result == 0)
                {
                    MessageBox.Show("Error adding new season.");
                    return;
                }
                MessageBox.Show("New season added successfully.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            MessageBox.Show("Logged out successfully.");
            this.Hide();
        }
    }
    }
