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
    public partial class Form2 : Form
    {
        Controller controllerObj = new Controller();
        bool isReady;

        public Form2()
        {
            InitializeComponent();
            isReady = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            isReady = false;
            RefreshCombos();
            isReady = true;
        }

        private void UpdateActorComboBox(DataTable dt)
        {
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ActorID";
            comboBox1.SelectedIndex = -1;
        }

        private void UpdateMediaComboBox(DataTable dt)
        {
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "MediaID";
            comboBox2.SelectedIndex = -1;
        }

        private void RefreshCombos()
        {
            DataTable dtMedia = controllerObj.GetAllMedia();
            UpdateMediaComboBox(dtMedia);

            DataTable dtActors = controllerObj.GetAllActors();
            UpdateActorComboBox(dtActors);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text.Trim();
            string ageStr = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ageStr))
            {
                MessageBox.Show("Please enter Name and Age.");
                return;
            }

            if (int.TryParse(ageStr, out int age))
            {
                int result = controllerObj.AddActor(name, age);
                if (result > 0)
                {
                    MessageBox.Show("Actor added successfully!");

                    // Refresh everything (including the ComboBox to show the new actor)
                    isReady = false;
                    RefreshCombos();
                    isReady = true;

   
                }
                else
                {
                    MessageBox.Show("Failed to add actor.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Age.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Media item.");
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Actor.");
                return;
            }

            int mediaId = Convert.ToInt32(comboBox2.SelectedValue);
            int actorId = Convert.ToInt32(comboBox1.SelectedValue);

            int result = controllerObj.AddActorToMedia(mediaId, actorId);

            if (result > 0)
            {
                MessageBox.Show("Actor linked to Media successfully!");
            }
            else if (result == -1)
            {
                MessageBox.Show("This actor is already linked to this media.");
            }
            else
            {
                MessageBox.Show("Failed to link.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!isReady) return;

            string searchText = textBox6.Text;
            DataTable dt;

            if (string.IsNullOrEmpty(searchText))
            {
                dt = controllerObj.GetAllActors();
            }
            else
            {
                dt = controllerObj.GetActorsByName(searchText);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (!isReady) return;

            string searchText = textBox7.Text; // Assuming you added this TextBox
            DataTable dt;

            if (string.IsNullOrEmpty(searchText))
            {
                dt = controllerObj.GetAllMedia();
            }
            else
            {
                dt = controllerObj.GetMediaByName(searchText);
            }

            UpdateMediaComboBox(dt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox8.Text.Trim();
            string email = textBox4.Text.Trim();
            string pass = textBox5.Text.Trim();
            string site = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(site))
            {
                MessageBox.Show("Please fill in all Publisher fields.");
                return;
            }

            int result = controllerObj.AddPublisherUser(email, name, pass, site);

            if (result > 0)
            {
                MessageBox.Show("Publisher added successfully!");
                textBox8.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add publisher. (Email might already exist).");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
