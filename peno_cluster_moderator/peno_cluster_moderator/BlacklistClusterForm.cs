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
    public partial class BlacklistClusterForm : peno_cluster_moderator.ClusterForm
    {
        public BlacklistClusterForm(List<string> blacklist)
        {
            InitializeComponent();

            // Get the list view
            blacklistListView.View = View.Details;
            // Add the blacklist to the list view
            foreach (string word in blacklist)
            {
                blacklistListView.Items.Add(new ListViewItem(new string[] { word }));
            }
            // Add some styling
            blacklistListView.GridLines = true;
        }

        private void BlacklistClusterForm_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
