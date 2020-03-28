using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peno_cluster_moderator
{
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
