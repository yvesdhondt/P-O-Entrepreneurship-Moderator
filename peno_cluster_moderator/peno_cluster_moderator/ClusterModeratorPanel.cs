using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peno_cluster_moderator
{
    class ClusterModeratorPanel : IModeratorPanel
    {
        /// <summary>
        /// Create a new moderator panel for Cluster.
        /// </summary>
        public ClusterModeratorPanel()
        {
            this.BlackList = new List<string> { "Lindseytje", "Peter Pompoen", "Sjareltje",
                "Kimchiwinchi", "FooBar", "BarFoo", "cacatoo", "Gandalf", "Lill' Ernie",
                "Big Debby", "Debby the Canonball", "Carlalita", "Frodo", "Gremlin", "Shwoof",
                "godverdomme", "kutwouten", "Arschloch", "Asshole", "Cunty McCuntface", "Sir Cuntalot"};
            this.ReportedQA = new List<List<string>>
            {
                new List<string> { "23", "How can I refill the coffee machine?", "You can't, the cleaning personel does that once a week." },
                new List<string> { "28", "How can I refill the coffee machine?", "You can't, the cleaning ladies do that once a week." },
                new List<string> { "90", "How can I refill the fucking coffee machine?", "" },
                new List<string> { "895", "Should I ask HR for sick leave or should I ask my boss?", "Idk." }
            };
            this.BlockedUsers = new List<(string, DateTime)>
            {
                ("234", new DateTime(2016, 7, 8, 3, 15, 0)),
                ("24", new DateTime(2018, 5, 12, 3, 5, 0)),
                ("284", new DateTime(2019, 7, 15, 3, 15, 0)),
                ("934", new DateTime(2018, 4, 15, 3, 18, 0)),
                ("234", new DateTime(2019, 7, 15, 3, 15, 0)),
                ("2324", new DateTime(2018, 4, 15, 3, 5, 0)),
                ("144", new DateTime(2019, 1, 21, 3, 14, 0)),
                ("23484", new DateTime(2019, 7, 12, 3, 15, 0)),
                ("340", new DateTime(2018, 9, 16, 3, 10, 0)),
                ("4", new DateTime(2019, 7, 1, 3, 6, 0)),
                ("2", new DateTime(2018, 2, 5, 3, 5, 0))
            };
        }

        private List<string> BlackList { get; set; }
        private List<List<string>> ReportedQA { get; set; }
        private List<(string, DateTime)> BlockedUsers { get; set; }

        public void AddWord(string word)
        {
            if (! (String.IsNullOrEmpty(word)
                || this.BlackList.Contains(word))) {
                this.BlackList.Add(word);
            }
        }

        public List<string> GetBlackList()
        {
            return this.BlackList;
        }

        public void RemoveWord(string word)
        {
            if (! String.IsNullOrEmpty(word))
            {
                this.BlackList.RemoveAll(x => x == word);
            }
        }

        public List<List<string>> GetReportedQA()
        {
            return this.ReportedQA;
        }

        public void OffensiveReportedQA(List<string> reportedQA)
        {
            if (reportedQA != null || reportedQA.Count == 3)
            {
                this.ReportedQA.RemoveAll(x => x.SequenceEqual<string>(reportedQA));
            }
        }

        public void SafeReportedQA(List<string> reportedQA)
        {
            if (reportedQA != null || reportedQA.Count == 3)
            {
                this.ReportedQA.RemoveAll(x => x.SequenceEqual<string>(reportedQA));
            }
        }

        public List<(string, DateTime)> GetBlockedUsers()
        {
            return this.BlockedUsers;
        }

        public void BlockUser(string userId, DateTime date)
        {
            if (userId != null && date != null)
            {
                bool alreadyBlocked = false;
                foreach ((string,DateTime) item in this.BlockedUsers)
                {
                    alreadyBlocked = alreadyBlocked || item.Item1 == userId;
                }
                if (!alreadyBlocked)
                {
                    this.BlockedUsers.Add((userId, date));
                }
            }
        }

        public void UnblockUser(string userId)
        {
            if (userId != null)
            {
                this.BlockedUsers.RemoveAll(x => x.Item1 == userId);
            }
        }
    }
}
