using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace peno_cluster_moderator
{
    /// <summary>
    /// A login form is used to verify the credentials of a user of the moderator panel, and is the main entry point to the application.
    /// </summary>
    public partial class LoginForm : peno_cluster_moderator.ClusterForm
    {
        /// <summary>
        /// Create a login form.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Try to login to the moderatorpanel and display the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Try to login to the moderator panel and open up a main form.
                IModeratorPanel moderatorPanel = new ClusterModeratorConnector(txtUsername.Text, txtPassword.Text);
                MainForm main = new MainForm(moderatorPanel, txtUsername.Text);
                // Open up the main menu and hide the login form. Also configure the main menu to close the login form whenever the main menu is closed.
                this.Hide();
                main.Closed += (s, args) => this.Close();
                main.Show();
            }
            catch (ArgumentException)
            {
                // Show an error msg when the user enters a wrong username or password.
                lblErrorMsg.Show();
            }
        }

        /// <summary>
        /// Hide the error msg when the user enters a new username.
        /// </summary>
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblErrorMsg.Hide();
        }

        /// <summary>
        /// Hide the error msg when the user enters a new password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblErrorMsg.Hide();
        }
    }
}
