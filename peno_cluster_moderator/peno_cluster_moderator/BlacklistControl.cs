using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peno_cluster_moderator
{
    /// <summary>
    /// A BlacklistControl is a ClusterControl used to display and modify the blacklist.
    /// </summary>
    public partial class BlacklistControl : ClusterControl
    {
        /// <summary>
        /// The listeners to this blacklist.
        /// </summary>
        private readonly List<IBlackListListener> BlackListListeners =
            new List<IBlackListListener>();

        /// <summary>
        /// Create a new blacklist.
        /// </summary>
        public BlacklistControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Override the pressed keys so that the "update" button is clicked when the
        /// "enter" key is pressed.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnUpdate.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Display a new blacklist onto this GUI user control. If it is null, nothing happens.
        /// </summary>
        /// <param name="blacklist">The blacklist to display.</param>
        public void InsertBlacklist(List<string> blacklist)
        {
            // Add the blacklist to the list view, duplicates are only shown once
            if (blacklist != null)
            {
                // Clear the old values
                blacklistListView.Items.Clear();

                // Replace them with the new values
                foreach (string word in blacklist.Distinct())
                {
                    blacklistListView.Items.Add(new ListViewItem(new string[] { word }));
                }
            }
            // Add some styling
            blacklistListView.GridLines = true;
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
        private void blacklistListView_SelectedIndexChanged(object sender, EventArgs e)
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

        /// <summary>
        /// Add the word in the txtAddWord box to the blacklistListView, as long as it is not already in the view.
        /// Also notify all the IBlacklistListeners that a word was removed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the word in the "add" textbox
            string addedWord = this.txtAddWord.Text;

            // Notify all the listeners
            foreach (IBlackListListener listener in this.BlackListListeners)
            {
                listener.AddEvent(addedWord);
            }

            // Add the word to the listview if it is not already in it and it is not empty
            if (!string.IsNullOrEmpty(addedWord))
            {
                bool inListView = false;
                foreach (ListViewItem item in this.blacklistListView.Items)
                {
                    if (item.Text == addedWord)
                    {
                        inListView = true;
                        break;
                    }
                }
                if (!inListView)
                {
                    this.blacklistListView.Items.Add(new ListViewItem(new string[] { addedWord }));
                }
            }
        }

        /// <summary>
        /// Remove and add, respectively, the words in the "remove" and "add" textboxes from the
        /// listview and notify the listeners. After doing that, the textboxes are cleared.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.btnRemoveWord_Click(sender, e);
            this.btnAdd_Click(sender, e);
            this.txtRemoveWord.Clear();
            this.txtAddWord.Clear();
        }

        private void txtRemoveWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
