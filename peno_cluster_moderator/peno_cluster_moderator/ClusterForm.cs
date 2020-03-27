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
    public partial class ClusterForm : Form
    {
        private ClusterForm creator;

        public ClusterForm()
        {
            InitializeComponent();
        }

        internal ClusterForm Creator { get => creator; set => creator = value; }

        private void ClusterForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Open the creator form, if any.
        /// </summary>
        internal void ShowCreator()
        {
            if (this.Creator != null)
            {
                this.Creator.Show();
            }
        }
    }
}
