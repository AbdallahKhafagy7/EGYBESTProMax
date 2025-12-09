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
    public partial class PublisherForm : Form
    {
        string email;
        public PublisherForm(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void Publisher_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
