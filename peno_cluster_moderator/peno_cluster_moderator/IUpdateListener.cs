using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peno_cluster_moderator
{
    /// <summary>
    /// A standard listener interface (used in a listener-subscriber pattern) used to update some collection stored at a remote location.
    /// </summary>
    /// <typeparam name="T">The type of object stored, or mapped onto an item, in the collection.</typeparam>
    public interface IUpdateListener<T>
    {
        /// <summary>
        /// Perform an action on a "remove T" event.
        /// </summary>
        /// <param name="word">The removed T-object.</param>
        void RemoveEvent(T word);

        /// <summary>
        /// Perform an action on a "add T" event.
        /// </summary>
        /// <param name="word">The added T-object.</param>
        void AddEvent(T word);
    }
}
