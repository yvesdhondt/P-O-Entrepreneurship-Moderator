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
                "Kimchiwinchi", "FooBar", "BarFoo", "Peter Pompoen", "Sjareltje", "Kimchiwinchi",
                "FooBar", "BarFoo", "Peter Pompoen", "Sjareltje", "Kimchiwinchi", "FooBar", "BarFoo",
                "Peter Pompoen", "Sjareltje", "Kimchiwinchi", "FooBar", "BarFoo", "Peter Pompoen",
                "Sjareltje", "Kimchiwinchi", "FooBar", "BarFoo" };
        }

        private List<string> BlackList { get; set; }

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
    }
}
