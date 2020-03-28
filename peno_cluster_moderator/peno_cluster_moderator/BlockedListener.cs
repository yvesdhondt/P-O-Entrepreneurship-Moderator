using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peno_cluster_moderator
{
    public class BlockedListener : IBlockedListener
    {
        private IModeratorPanel ModeratorPanel { get; set; }

        /// <summary>
        /// Create a new BlockedListener that knows about an IModeratorPanel
        /// </summary>
        /// <param name="moderatorPanel">An IModeratorPanel with blocked users in it.</param>
        public BlockedListener(IModeratorPanel moderatorPanel)
        {
            this.ModeratorPanel = moderatorPanel;
        }

        /// <summary>
        /// Block the given user.
        /// </summary>
        /// <param name="userId">The user to block.</param>
        public void AddEvent(string userId)
        {
            this.ModeratorPanel.BlockUser(userId, DateTime.Now);
        }

        /// <summary>
        /// Unblock the given user.
        /// </summary>
        /// <param name="userId">The user to unblock.</param>
        public void RemoveEvent(string userId)
        {
            this.ModeratorPanel.UnblockUser(userId);
        }
    }
}
