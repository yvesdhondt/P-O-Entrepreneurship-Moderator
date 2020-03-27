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
    public partial class MainForm : peno_cluster_moderator.ClusterForm
    {
        private IModeratorPanel ModeratorPanel { get; set; }

        public MainForm(IModeratorPanel moderatorPanel)
        {
            InitializeComponent();
            this.ModeratorPanel = moderatorPanel;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReportedQA_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Clicking on the Blacklist button pops-up a new window with the black list
        /// </summary>
        private void btnBlacklist_Click(object sender, EventArgs e)
        {
            BlacklistClusterForm blacklistForm = new BlacklistClusterForm(ModeratorPanel.GetBlackList());
            blacklistForm.Show();
        }
    }
}
