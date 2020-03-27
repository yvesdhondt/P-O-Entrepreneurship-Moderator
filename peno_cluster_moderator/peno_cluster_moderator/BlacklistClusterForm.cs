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
    /// A class displaying the blacklist for the moderator.
    /// </summary>
    public partial class BlacklistClusterForm : ClusterForm
    {
        private readonly List<IBlackListListener> BlackListListeners =
            new List<IBlackListListener>();

        public BlacklistClusterForm(List<string> blacklist, ClusterForm creator)
        {
            InitializeComponent();

            // Set the creator
            this.Creator = creator;

            // Get the list view
            blacklistListView.View = View.Details;
            // Add the blacklist to the list view, duplicates are only shown once
            foreach (string word in blacklist.Distinct())
            {
                blacklistListView.Items.Add(new ListViewItem(new string[] { word }));
            }
            // Add some styling
            blacklistListView.GridLines = true;
        }

        private void BlacklistClusterForm_Load(object sender, EventArgs e)
        {

        }

        private void BlacklistClusterForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            base.ShowCreator();
        }

        /// <summary>
        /// Add an IBlackListListener.
        /// </summary>
        /// <param name="listener">The listener to add.</param>
        public void AddListener(IBlackListListener listener)
        {
            this.BlackListListeners.Add(listener);
        }

        /// <summary>
        /// Remove an IBlackListListener.
        /// </summary>
        /// <param name="listener">The listener to remove.</param>
        public void RemoveListener(IBlackListListener listener)
        {
            this.BlackListListeners.Remove(listener);
        }

        /// <summary>
        /// Set the txtRemoveWord box to the text in the selected cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blacklistListView.SelectedItems.Count > 0)
            {
                this.txtRemoveWord.Text = blacklistListView.SelectedItems[0].Text;
            }
        }

        /// <summary>
        /// Remove the word in the txtRemoveWord box from the blacklistListView as well as from the blacklist itself.
        /// Also notify all the IBlacklistListeners that a word was removed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveWord_Click(object sender, EventArgs e)
        {
            // Get the word in the "removed" textbox
            string removedWord = this.txtRemoveWord.Text;

            // Notify all the listeners
            foreach (IBlackListListener listener in this.BlackListListeners)
            {
                listener.RemoveEvent(removedWord);
            }

            // Remove the word from the listview
            foreach (ListViewItem item in this.blacklistListView.Items)
            {
                if (item.Text == removedWord)
                {
                    this.blacklistListView.Items.Remove(item);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the word in the "add" textbox
            string addedWord = this.txtAddWord.Text;

            // Notify all the listeners
            foreach (IBlackListListener listener in this.BlackListListeners)
            {
                listener.AddEvent(addedWord);
            }

            // Add the word to the listview if it is not already in it
            bool inListView = false;
            foreach (ListViewItem item in this.blacklistListView.Items)
            {
                if (item.Text == addedWord)
                {
                    inListView = true;
                    break;
                }
            }
            if (! inListView)
            {
                this.blacklistListView.Items.Add(new ListViewItem(new string[] { addedWord }));
            }
        }
    }
}
