using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBapplication; // Add namespace for AdminForm etc.

namespace CMPS_202_project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Run Login Form as a Dialog (Modal)
            LoginForm login = new LoginForm();
            DialogResult result = login.ShowDialog();

            // 2. If Login was successful (DialogResult.OK), run the main app
            if (result == DialogResult.OK)
            {
                // Retrieve the data stored in the Login Form
                string userEmail = login.LoggedInEmail;
                string userType = login.LoggedInUserType;

                // Explicitly Dispose the login form to free resources and close it
                login.Dispose();

                // 3. Open the appropriate Dashboard
                if (userType == "EndUser")
                {
                    Application.Run(new WelcomeForm(userEmail));
                }
                else if (userType == "Administrator")
                {
                    Application.Run(new AdminForm(userEmail));
                }
                else if (userType == "Publisher")
                {
                    Application.Run(new PublisherForm(userEmail));
                }
            }
            // If DialogResult was Cancel (user closed the window), the app simply exits here.
        }
    }
}