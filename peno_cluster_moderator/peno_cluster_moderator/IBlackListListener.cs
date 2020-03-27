using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peno_cluster_moderator
{
    public interface IBlackListListener
    {
        /// <summary>
        /// Perform an action on a "remove word" event.
        /// </summary>
        /// <param name="word">The removed word.</param>
        void RemoveEvent(string word);

        /// <summary>
        /// Perform an action on a "add word" event.
        /// </summary>
        /// <param name="word">The added word.</param>
        void AddEvent(string word);
    }
}
