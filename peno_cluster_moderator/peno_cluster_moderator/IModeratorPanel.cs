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
        List<string> GetBlackList();

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

        /// <summary>
        /// Get a list of 3-tuples (id,question,answer) with all the reported QA-pairs.
        /// </summary>
        /// <returns>A list of 3-tuples (id,question,answer) with all the reported QA-pairs.</returns>
        List<List<string>> GetReportedQA();

        /// <summary>
        /// Decide that the QA-pair is safe.
        /// </summary>
        /// <param name="reportedQA">The QA-pair to mark as safe, a 3-tuple (id,question,answer).</param>
        void SafeReportedQA(List<string> reportedQA);

        /// <summary>
        /// Decide that the QA-pair is offensive.
        /// </summary>
        /// <param name="reportedQA">The QA-pair to mark as offensive, a 3-tuple (id,question,answer).</param>
        void OffensiveReportedQA(List<string> reportedQ);

        /// <summary>
        /// Get a list of 2-tuples (id,date) with all the blocked users.
        /// </summary>
        /// <returns>A list of 2-tuples (id,date) with all the blocked users.</returns>
        List<(string, DateTime)> GetBlockedUsers();

        /// <summary>
        /// Block the user with the given id and remember the data at which he/she was blocked.
        /// </summary>
        /// <param name="userId">The id of the user.</param>
        /// <param name="date">The time of blocking the user.</param>
        void BlockUser(string userId, DateTime date);

        /// <summary>
        /// Unblock the user with the given id.
        /// </summary>
        /// <param name="userId">The id of the user.</param>
        void UnblockUser(string userId);
    }
}
