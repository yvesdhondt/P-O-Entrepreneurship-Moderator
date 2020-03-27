using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peno_cluster_moderator
{
    public interface IModeratorPanel
    {
        /// <summary>
        /// Get a list of strings with all the blacklisted words.
        /// </summary>
        /// <returns>A list of all the blacklisted words.</returns>
        List<String> GetBlackList();

        /// <summary>
        /// Add the given word to the blacklisted words.
        /// </summary>
        /// <param name="word">The word to add.</param>
        void AddWord(string word);

        /// <summary>
        /// Remove the given word from the blacklisted words.
        /// </summary>
        /// <param name="word">The word to remove from the blacklisted words.</param>
        void RemoveWord(string word);
    }
}
