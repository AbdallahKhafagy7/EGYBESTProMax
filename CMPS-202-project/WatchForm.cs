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
    public partial class WatchForm : Form
    {
        Controller controllerObj;
        string currentEmail;

        // This flag prevents "Auto-Adding" when the form loads or search updates
        bool isReady = false;

        public WatchForm(string email)
        {
            InitializeComponent();
            controllerObj = new Controller();
            currentEmail = email;

            // 1. SETUP IN CONSTRUCTOR
            isReady = false;

            // Load ComboBox
            DataTable dtMedia = controllerObj.GetAllMedia();
            UpdateComboBox(dtMedia);

            // Load Grid
            RefreshGrid();

            // Enable the event logic now that everything is ready
            isReady = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Empty because we moved logic to Constructor
        }

        private void RefreshGrid()
        {
            DataTable dtHistory = controllerObj.GetWatchHistory(currentEmail);
            dataGridView1.DataSource = dtHistory;
            dataGridView1.Refresh();
        }

        private void UpdateComboBox(DataTable dt)
        {
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "MediaID";
            comboBox1.SelectedIndex = -1; // Ensure nothing is selected by default
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // STOP if we are currently loading/searching (Safety Check)
            if (isReady == false) return;

            // STOP if nothing is actually selected (Index -1)
            if (comboBox1.SelectedIndex == -1) return;

            // CRITICAL FIX: Check for null
            if (comboBox1.SelectedValue == null) return;

            int mediaId = 0;
            bool isNumber = false;

            // Robust Check: Is SelectedValue an int directly?
            if (comboBox1.SelectedValue is int value)
            {
                mediaId = value;
                isNumber = true;
            }
            // Fallback: Is it a RowView? (Happens sometimes in data binding)
            else if (comboBox1.SelectedValue is DataRowView row)
            {
                // If ValueMember failed, we grab it manually from the row
                if (row["MediaID"] != DBNull.Value)
                {
                    mediaId = Convert.ToInt32(row["MediaID"]);
                    isNumber = true;
                }
            }
            // Fallback: Try parsing string (Safest last resort)
            else
            {
                isNumber = int.TryParse(comboBox1.SelectedValue.ToString(), out mediaId);
            }

            if (isNumber)
            {
                // 2. Add to History
                int result = controllerObj.AddToWatchHistory(mediaId, currentEmail);

                // 3. Refresh Grid Immediately
                if (result > 0)
                {
                    RefreshGrid();
                }
            }
        }

        // Search Box Logic
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Disable event so typing doesn't accidentally add movies
            isReady = false;

            string searchText = textBox1.Text;
            DataTable dt;

            if (string.IsNullOrEmpty(searchText))
            {
                dt = controllerObj.GetAllMedia();
            }
            else
            {
                dt = controllerObj.GetMediaByName(searchText);
            }

            UpdateComboBox(dt);

            // Re-enable event
            isReady = true;
        }

     

    }
}