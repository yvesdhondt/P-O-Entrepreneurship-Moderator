using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peno_cluster_moderator
{
    /// <summary>
    /// A class displaying the main menu for the moderator.
    /// </summary>
    public partial class MainForm : peno_cluster_moderator.ClusterForm
    {
        private IModeratorPanel ModeratorPanel { get; set; }
        private IBlackListListener BlackListListener { get; set; }

        public MainForm(IModeratorPanel moderatorPanel)
        {
            InitializeComponent();
            this.ModeratorPanel = moderatorPanel;
            this.BlackListListener = new BlackListListener(moderatorPanel);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Clicking on the Blacklist button pops-up a new window with the black list
        /// </summary>
        private void btnBlacklist_Click(object sender, EventArgs e)
        {
            BlacklistClusterForm blacklistForm = new BlacklistClusterForm(ModeratorPanel.GetBlackList(), this);
            blacklistForm.AddListener(BlackListListener);
            // Show the new form and hide this form
            blacklistForm.Show();
            this.Hide();
        }

        private void btnReportedQA_Click(object sender, EventArgs e)
        {
            ReportedClusterForm reportedForm = new ReportedClusterForm(this);
            // Show the new form and hide this form
            reportedForm.Show();
            this.Hide();
        }

        private void btnFlaggedQA_Click(object sender, EventArgs e)
        {
            FlaggedClusterForm flaggedForm = new FlaggedClusterForm(this);
            // Show the new form and hide this form
            flaggedForm.Show();
            this.Hide();
        }

        private void btnBlockedUsers_Click(object sender, EventArgs e)
        {
            BlockedClusterForm blockedForm = new BlockedClusterForm(this);
            // Show the new form and hide this form
            blockedForm.Show();
            this.Hide();
        }
    }
}
