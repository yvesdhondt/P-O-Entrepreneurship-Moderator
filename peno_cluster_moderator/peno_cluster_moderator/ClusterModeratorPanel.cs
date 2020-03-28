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
        }

        private List<string> BlackList { get; set; }
        private List<List<string>> ReportedQA { get; set; }

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
    }
}
