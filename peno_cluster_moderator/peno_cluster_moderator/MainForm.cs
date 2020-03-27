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
            BlacklistClusterForm blacklistForm = new BlacklistClusterForm(ModeratorPanel.GetBlackList());
            blacklistForm.AddListener(BlackListListener);
            blacklistForm.Show();
        }

        private void btnReportedQA_Click(object sender, EventArgs e)
        {
            ReportedClusterForm reportedForm = new ReportedClusterForm();
            reportedForm.Show();
        }

        private void btnFlaggedQA_Click(object sender, EventArgs e)
        {
            FlaggedClusterForm flaggedForm = new FlaggedClusterForm();
            flaggedForm.Show();
        }

        private void btnBlockedUsers_Click(object sender, EventArgs e)
        {
            BlockedClusterForm blockedForm = new BlockedClusterForm();
            blockedForm.Show();
        }
    }
}
