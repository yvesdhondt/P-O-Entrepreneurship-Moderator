using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peno_cluster_moderator
{
    class BlackListListener : peno_cluster_moderator.IBlackListListener
    {
        private IModeratorPanel ModeratorPanel { get; set; }

        /// <summary>
        /// Create a new BlackListListener that knows about an IModeratorPanel
        /// </summary>
        /// <param name="moderatorPanel">An IModeratorPanel with a blacklist in it.</param>
        public BlackListListener(IModeratorPanel moderatorPanel)
        {
            this.ModeratorPanel = moderatorPanel;
        }

        /// <summary>
        /// Add the given word to the blacklist.
        /// </summary>
        /// <param name="word">The word to add.</param>
        public void AddEvent(string word)
        {
            this.ModeratorPanel.AddWord(word);
        }

        /// <summary>
        /// Remove the given word from the blacklist.
        /// </summary>
        /// <param name="word">The word to remove.</param>
        public void RemoveEvent(string word)
        {
            this.ModeratorPanel.RemoveWord(word);
        }
    }
}
