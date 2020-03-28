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

        public MainForm(IModeratorPanel moderatorPanel)
        {
            InitializeComponent();
            // Set the moderator panel
            this.ModeratorPanel = moderatorPanel;

            // Add the blacklist to the blacklistControl panel
            this.blacklistControl.InsertBlacklist(this.ModeratorPanel.GetBlackList());
            // Create a listener for the blacklistControl panel and add it to the control
            this.BlackListListener = new BlackListListener(moderatorPanel);
            this.blacklistControl.AddListener(this.BlackListListener);

            // Add the reported qa to the reported QA panel
            this.reportedQAControl.InsertReportedQA(this.ModeratorPanel.GetReportedQA());
            // Create a listener for the reportedQAControl panel and add it to the control
            this.ReportListener = new ReportListener(moderatorPanel);
            this.reportedQAControl.AddListener(this.ReportListener);
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

            this.reportedQAControl.Visible = !this.reportedQAControl.Visible;
            if (this.reportedQAControl.Visible)
            {
                this.reportedQAControl.InsertReportedQA(this.ModeratorPanel.GetReportedQA());
            }
        }

        private void btnFlaggedQA_Click(object sender, EventArgs e)
        {
        }

        private void btnBlockedUsers_Click(object sender, EventArgs e)
        {
        }
    }
}
