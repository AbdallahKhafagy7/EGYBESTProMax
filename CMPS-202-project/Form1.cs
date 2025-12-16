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
    public partial class Form1 : Form
    {
        Controller controllerObj;
        string currentEmail;
        public Form1(string email)
        {
            InitializeComponent();
            InitializeComponent();
            controllerObj = new Controller();
            currentEmail = email;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Free Plan");
            comboBox1.Items.Add("Basic Plan");
            comboBox1.Items.Add("Standard Plan");
            comboBox1.Items.Add("Premium Plan");

            // 2. Load Current Plan
            LoadCurrentPlan();

        }
        private void LoadCurrentPlan()
        {
            string currentPlan = controllerObj.GetSubscriptionPlan(currentEmail);

            // If the database returns null or empty, default to "Free Plan"
            if (string.IsNullOrEmpty(currentPlan))
            {
                currentPlan = "Free Plan";
            }

            label1.Text = "Current Plan: " + currentPlan;

            // Optional: Set the ComboBox to match the current plan
            if (comboBox1.Items.Contains(currentPlan))
            {
                comboBox1.SelectedItem = currentPlan;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a plan from the list.");
                return;
            }
            string enteredPassword = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Please enter your password to confirm subscription change.");
                return;
            }
            bool isPasswordCorrect = controllerObj.CheckPassword(currentEmail, enteredPassword);

            if (!isPasswordCorrect)
            {
                MessageBox.Show("Incorrect Password! Subscription not changed.");
                return;
            }

            string newPlan = comboBox1.SelectedItem.ToString();
            decimal price = 0;

            // Determine Price based on plan (Mock logic)
            switch (newPlan)
            {
                case "Free Plan": price = 0; break;
                case "Basic Plan": price = 9.99M; break;
                case "Standard Plan": price = 15.99m; break;
                case "Premium Plan": price = 19.99m; break;
            }

            int result = controllerObj.UpdateSubscription(currentEmail, newPlan, price);

            if (result > 0)
            {
                MessageBox.Show("Subscription updated successfully!");
                LoadCurrentPlan(); // Refresh label to reflect change
            }
            else
            {
                MessageBox.Show("Failed to update subscription.");
            }
        }
    }
}
