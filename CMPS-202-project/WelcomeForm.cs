using DBapplication;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CMPS_202_project
{
    public partial class WelcomeForm : Form
    {
        // Class-level variables
        ListForm list;
        RateForm rate;
        EditInfoForm edit;
        WatchForm watch;
        Controller controllerobj = new Controller();
        public string email;

        public WelcomeForm(string email = "")
        {
            InitializeComponent();
            this.email = email;

            // 1. Apply Modern Theme
            GUIHelper.ApplyModernStyle(this);

            // 2. FIX: Assign directly to class variables (removed 'ListForm' and 'RateForm' types here)
            list = new ListForm(email);
            rate = new RateForm(email);
            watch = new WatchForm(email);
            edit = new EditInfoForm(controllerobj.GetNameFromEmail(email), email);
            // 3. Set Welcome Message
            label2.Text = "Welcome " + controllerobj.GetNameFromEmail(email);

            // 4. Setup Data
            int userId = controllerobj.GetUserIDFromEmail(email);
            DataTable dt = controllerobj.GetUserLists(userId);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ListName";
            comboBox1.SelectedIndex = -1;
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            // Optional: Any extra load logic
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            int userId = controllerobj.GetUserIDFromEmail(email);
            string listName = comboBox1.Text;
            DataTable dt = controllerobj.GetListShows(userId, listName);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // FIX: Ensure 'rate' is initialized correctly
            if (rate == null || rate.IsDisposed)
            {
                rate = new RateForm(email); // Fixed: Was creating ListForm before
            }
            this.Close();
            rate.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Open List Form
            if (list == null || list.IsDisposed)
            {
                list = new ListForm(email);
            }
            this.Close();
            list.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (watch == null || watch.IsDisposed)
            {
                watch = new WatchForm(email);
            }
            this.Close();
            watch.Show();
        }

        // Empty events kept to prevent designer errors
        private void label2_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (edit == null || edit.IsDisposed)
            {
                edit = new EditInfoForm(controllerobj.GetNameFromEmail(email), email);
            }
            this.Close();
            edit.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            MessageBox.Show("Logged out successfully.");
            this.Close();
        }
    }
}