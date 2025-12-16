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
    public partial class publisher_actor : Form
    {
        Controller controllerObj = new Controller();
        bool isReady;

        public publisher_actor()
        {
            InitializeComponent();
            isReady = false;
            GUIHelper.ApplyModernStyle(this);

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
        private void UpdateActorComboBox3(DataTable dt)
        {
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "ActorID";
            comboBox3.SelectedIndex = -1;
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

        private void button4_Click(object sender, EventArgs e)
        {
            // 1. Check if an actor is selected
            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an actor to update.");
                return;
            }

            int actorId = Convert.ToInt32(comboBox3.SelectedValue);

            string newName = textBox11.Text.Trim();
            string ageStr = textBox10.Text.Trim();

            bool nameUpdated = false;
            bool ageUpdated = false;

            // 2. Check Name Input (Update if not empty)
            if (!string.IsNullOrEmpty(newName))
            {
                int result = controllerObj.UpdateActorName(actorId, newName);
                if (result > 0) nameUpdated = true;
                else MessageBox.Show("Failed to update Name.");
            }

            // 3. Check Age Input (Update if not empty)
            if (!string.IsNullOrEmpty(ageStr))
            {
                if (int.TryParse(ageStr, out int newAge))
                {
                    int result = controllerObj.UpdateActorAge(actorId, newAge);
                    if (result > 0) ageUpdated = true;
                    else MessageBox.Show("Failed to update Age.");
                }
                else
                {
                    MessageBox.Show("Invalid Age format. Age not updated.");
                }
            }

            // 4. Feedback & Refresh
            if (nameUpdated || ageUpdated)
            {
                MessageBox.Show("Actor updated successfully!");

                // Refresh lists to reflect changes
                isReady = false;
                RefreshCombos();
                isReady = true;

                // Clear inputs
                textBox11.Clear();
                textBox10.Clear();
            }
            else if (string.IsNullOrEmpty(newName) && string.IsNullOrEmpty(ageStr))
            {
                MessageBox.Show("Please enter a Name or Age to update.");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            UpdateActorComboBox3(controllerObj.GetActorsByName(textBox9.Text.Trim()));
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            UpdateActorComboBox(controllerObj.GetActorsByName(textBox6.Text.Trim()));
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            UpdateMediaComboBox(controllerObj.GetMediaByName(textBox7.Text.Trim()));
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_with_publisher adminForm = new Admin_with_publisher();
            adminForm.Show();
            this.Close();
        }
    }
}
