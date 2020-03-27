using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace peno_cluster_moderator
{
    public partial class FlaggedClusterForm : ClusterForm
    {
        public FlaggedClusterForm(ClusterForm creator)
        {
            InitializeComponent();

            // Set the creator
            this.Creator = creator;
        }

        private void FlaggedClusterForm_Load(object sender, EventArgs e)
        {

        }

        private void FlaggedClusterForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            base.ShowCreator();
        }
    }
}
