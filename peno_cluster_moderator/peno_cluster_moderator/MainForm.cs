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
        private IReportListener ReportListener { get; set; }
        private IBlockedListener BlockedListener { get; set; }

        public MainForm(IModeratorPanel moderatorPanel)
        {
            InitializeComponent();
            // Set the moderator panel
            this.ModeratorPanel = moderatorPanel;

            // Create a listener for the blacklistControl panel and add it to the control
            this.BlackListListener = new BlackListListener(moderatorPanel);
            this.blacklistControl.AddListener(this.BlackListListener);

            // Create a listener for the reportedQAControl panel and add it to the control
            this.ReportListener = new ReportListener(moderatorPanel);
            this.reportedQAControl.AddListener(this.ReportListener);

            // Create a listener for the blockedUsersControl panel and add it to the control
            this.BlockedListener = new BlockedListener(moderatorPanel);
            this.blockedUsersControl.AddListener(this.BlockedListener);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Switch the visibility of the blacklist control. If the control is visible, also fetch the most up-to-date blacklist from the
        /// moderator panel. Also make all the other controls invisible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlacklist_Click(object sender, EventArgs e)
        {
            this.reportedQAControl.Visible = false;
            this.blockedUsersControl.Visible = false;

            this.blacklistControl.Visible = ! this.blacklistControl.Visible;
            if (this.blacklistControl.Visible)
            {
                this.blacklistControl.InsertBlacklist(this.ModeratorPanel.GetBlackList());
            }
        }

        /// <summary>
        /// Switch the visibility of the reported QA control. If the control is visible, also fetch the most up-to-date reported QAs from the
        /// moderator panel. Also make all the other controls invisible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReportedQA_Click(object sender, EventArgs e)
        {
            this.blacklistControl.Visible = false;
            this.blockedUsersControl.Visible = false;

            this.reportedQAControl.Visible = !this.reportedQAControl.Visible;
            if (this.reportedQAControl.Visible)
            {
                this.reportedQAControl.InsertReportedQA(this.ModeratorPanel.GetReportedQA());
            }
        }

        /// <summary>
        /// Switch the visibility of the blocked users control. If the control is visible, also fetch the most up-to-date blocked users from the
        /// moderator panel. Also make all the other controls invisible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlockedUsers_Click(object sender, EventArgs e)
        {
            this.blacklistControl.Visible = false;
            this.reportedQAControl.Visible = false;

            this.blockedUsersControl.Visible = !this.blockedUsersControl.Visible;
            if (this.blockedUsersControl.Visible)
            {
                this.blockedUsersControl.InsertBlockedUsers(this.ModeratorPanel.GetBlockedUsers());
            }
        }
    }
}
