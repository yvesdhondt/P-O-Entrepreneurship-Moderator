using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peno_cluster_moderator
{
    /// <summary>
    /// A listener used to notify an event onto a collection of reported Q&amp;As.
    /// </summary>
    public class ReportListener : IReportListener
    {
        /// <summary>
        /// The moderator panel used to access the remote data stored on Cluster.
        /// </summary>
        private IModeratorPanel ModeratorPanel { get; set; }

        /// <summary>
        /// Create a new ReportListener that knows about an IModeratorPanel
        /// </summary>
        /// <param name="moderatorPanel">An IModeratorPanel with reported QAs in it.</param>
        public ReportListener(IModeratorPanel moderatorPanel)
        {
            this.ModeratorPanel = moderatorPanel;
        }

        /// <summary>
        /// Flag the given word (3-tuple (id,question,answer)) as offensive.
        /// </summary>
        /// <param name="word">The word to flag.</param>
        public void AddEvent((string, string, string) word)
        {
            this.ModeratorPanel.OffensiveReportedQA(word);
        }

        /// <summary>
        /// Flag the given word (3-tuple (id,question,answer)) as safe.
        /// </summary>
        /// <param name="word">The word to flag.</param>
        public void RemoveEvent((string, string, string) word)
        {
            this.ModeratorPanel.SafeReportedQA(word);
        }
    }
}
