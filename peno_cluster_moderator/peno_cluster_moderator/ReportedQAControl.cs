using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace peno_cluster_moderator
{
    public partial class ReportedQAControl : peno_cluster_moderator.ClusterControl
    {
        private readonly List<IReportListener> reportListeners =
            new List<IReportListener>();

        public ReportedQAControl()
        {
            InitializeComponent();
        }

        private List<IReportListener> ReportListeners => reportListeners;

        /// <summary>
        /// Fill the reported QA listview of this user control with some values.
        /// </summary>
        /// <param name="reportedQA">Some values.</param>
        public void InsertReportedQA(List<List<String>> reportedQA)
        {
            // Add the reported QA to the list view, duplicates are only shown once
            if (reportedQA != null)
            {
                // Clear the old values
                reportedListView.Items.Clear();

                // Replace them with the new values
                foreach (List<string> row in reportedQA)
                {
                    reportedListView.Items.Add(
                        new ListViewItem(
                            new string[] { row[0], row[1], row[2] }));
                }
            }
            // Add some styling
            reportedListView.GridLines = true;
        }

        /// <summary>
        /// Add an IReportListener.
        /// </summary>
        /// <param name="listener">The listener to add.</param>
        public void AddListener(IReportListener listener)
        {
            this.ReportListeners.Add(listener);
        }

        /// <summary>
        /// Remove an IReportListener.
        /// </summary>
        /// <param name="listener">The listener to remove.</param>
        public void RemoveListener(IReportListener listener)
        {
            this.ReportListeners.Remove(listener);
        }

        /// <summary>
        /// Show the full answer and question pair in their textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportedListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reportedListView.SelectedItems.Count > 0)
            {
                txtID.Text = reportedListView.SelectedItems[0].SubItems[0].Text;
                txtAnswer.Text = reportedListView.SelectedItems[0].SubItems[2].Text;
                txtQuestion.Text = reportedListView.SelectedItems[0].SubItems[1].Text;
            }
        }

        /// <summary>
        /// Check whether the ID is in the listview and if so, fill in the answer and question textboxes. If the ID is not in the listview, the
        /// answer and question textboxes are cleared.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            bool isInView = false;
            foreach (ListViewItem item in reportedListView.Items)
            {
                if (item.SubItems[0].Text == txtID.Text)
                {
                    txtAnswer.Text = item.SubItems[2].Text;
                    txtQuestion.Text = item.SubItems[1].Text;
                    isInView = true;
                    break;
                }
            }

            if (!isInView)
            {
                txtAnswer.Clear();
                txtQuestion.Clear();
            }
        }

        /// <summary>
        /// Flag the id,question,answer tuple in the textboxes as offensive and remove it from the listview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOffensive_Click(object sender, EventArgs e)
        {
            // Get the word in the "id", "answer", and "questino" textboxes
            string id = this.txtID.Text;
            string q = this.txtQuestion.Text;
            string ans = this.txtAnswer.Text;
            List<string> msg = new List<string> { id, q, ans };

            // Notify all the listeners
            foreach (IReportListener listener in this.ReportListeners)
            {
                listener.AddEvent(msg);
            }

            // Remove the id,q,ans row from the list view
            foreach (ListViewItem item in this.reportedListView.Items)
            {
                if (item.SubItems[0].Text == id && item.SubItems[1].Text == q &&
                    item.SubItems[2].Text == ans)
                {
                    this.reportedListView.Items.Remove(item);
                }
            }
        }

        /// <summary>
        /// Flag the id,question,answer tuple in the textboxes as safe and remove it from the listview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSafe_Click(object sender, EventArgs e)
        {
            // Get the word in the "id", "answer", and "questino" textboxes
            string id = this.txtID.Text;
            string q = this.txtQuestion.Text;
            string ans = this.txtAnswer.Text;
            List<string> msg = new List<string> { id, q, ans };

            // Notify all the listeners
            foreach (IReportListener listener in this.ReportListeners)
            {
                listener.RemoveEvent(msg);
            }

            // Remove the id,q,ans row from the list view
            foreach (ListViewItem item in this.reportedListView.Items)
            {
                if (item.SubItems[0].Text == id && item.SubItems[1].Text == q &&
                    item.SubItems[2].Text == ans)
                {
                    this.reportedListView.Items.Remove(item);
                }
            }
        }
    }
}
