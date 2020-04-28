using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace peno_cluster_moderator
{
    /// <summary>
    /// A BlockedUsersControl is a ClusterControl used to display and modify the blocked users.
    /// </summary>
    public partial class BlockedUsersControl : peno_cluster_moderator.ClusterControl
    {
        /// <summary>
        /// A list of listeners to notify when an event happens on this control.
        /// </summary>
        private readonly List<IBlockedListener> blockedListeners =
            new List<IBlockedListener>();

        /// <summary>
        /// A list of listeners to notify when an event happens on this control.
        /// </summary>
        private List<IBlockedListener> BlockedListeners => blockedListeners;

        /// <summary>
        /// Create a new blocked users control to display blocked users.
        /// </summary>
        public BlockedUsersControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fill the blocked users listview of this user control with some values.
        /// </summary>
        /// <param name="reportedQA">Some values.</param>
        public void InsertBlockedUsers(List<(string,DateTime)> blockedUsers)
        {
            // Add the reported QA to the list view, duplicates are only shown once
            if (blockedUsers != null)
            {
                // Clear the old values
                blockedListView.Items.Clear();

                // Replace them with the new values
                foreach ((string, DateTime) row in blockedUsers)
                {
                    blockedListView.Items.Add(
                        new ListViewItem(
                            new string[] { row.Item1, row.Item2.ToString() }));
                }
            }
            // Add some styling
            blockedListView.GridLines = true;
        }

        /// <summary>
        /// Add an IBlockedListener.
        /// </summary>
        /// <param name="listener">The listener to add.</param>
        public void AddListener(IBlockedListener listener)
        {
            this.BlockedListeners.Add(listener);
        }

        /// <summary>
        /// Remove an IBlockedListener.
        /// </summary>
        /// <param name="listener">The listener to remove.</param>
        public void RemoveListener(IBlockedListener listener)
        {
            this.BlockedListeners.Remove(listener);
        }

        /// <summary>
        /// Show the id and last violation in their textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void blockedListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blockedListView.SelectedItems.Count > 0)
            {
                txtID.Text = blockedListView.SelectedItems[0].SubItems[0].Text;
                txtNbViolations.Text = blockedListView.SelectedItems[0].SubItems[1].Text;
            }
        }

        /// <summary>
        /// Check whether the ID is in the listview and if so, fill in the last violation textbox. If the entered
        /// ID is not in the listview, the last violation textbox is cleared.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            bool isBlocked = false;
            foreach (ListViewItem item in blockedListView.Items)
            {
                if (item.SubItems[0].Text == txtID.Text)
                {
                    txtNbViolations.Text = item.SubItems[1].Text;
                    isBlocked = true;
                    break;
                }
            }
            if (!isBlocked)
            {
                txtNbViolations.Text = "";
            }
        }

        /// <summary>
        /// Block the entered user (by notifying the listeners) and add him/her to the listview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlock_Click(object sender, EventArgs e)
        {
            // Get the id
            string id = txtID.Text;
            
            // Notify the listeners
            foreach (IBlockedListener listener in BlockedListeners)
            {
                listener.AddEvent(id);
            }

            // Add the user to the listview with the current date if the id is not empty and it is not a duplicate
            if (!string.IsNullOrEmpty(id))
            {
                bool isBlocked = false;
                foreach (ListViewItem item in blockedListView.Items)
                {
                    if (item.SubItems[0].Text == id)
                    {
                        isBlocked = true;
                        break;
                    }
                }
                if (!isBlocked)
                {
                    string now = DateTime.Now.ToString();
                    // Add the id to the listview
                    blockedListView.Items.Add(new ListViewItem(new string[] { id, now }));
                    // Also update the last violation field
                    txtNbViolations.Text = now;
                }
            }
        }

        /// <summary>
        /// Unblock the entered user (by notifying the listeners) and remove him/her from the listview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnblock_Click(object sender, EventArgs e)
        {
            // Get the id
            string id = txtID.Text;

            // Notify the listeners
            foreach (IBlockedListener listener in BlockedListeners)
            {
                listener.RemoveEvent(id);
            }

            // Remove the user from the listview
            foreach (ListViewItem item in blockedListView.Items)
            {
                if (item.SubItems[0].Text == id)
                {
                    blockedListView.Items.Remove(item);
                }
            }

            // Clear the last violation field
            txtNbViolations.Clear();
        }
    }
}
