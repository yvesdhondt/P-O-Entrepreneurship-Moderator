using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peno_cluster_moderator
{
    class ClusterModeratorPanel : IModeratorPanel
    {
        public ClusterModeratorPanel()
        {
            this.BlackList = new List<string> { "Lindseytje", "Peter Pompoen", "Sjareltje",
                "Kimchiwinchi", "FooBar", "BarFoo", "Peter Pompoen", "Sjareltje", "Kimchiwinchi",
                "FooBar", "BarFoo", "Peter Pompoen", "Sjareltje", "Kimchiwinchi", "FooBar", "BarFoo",
                "Peter Pompoen", "Sjareltje", "Kimchiwinchi", "FooBar", "BarFoo", "Peter Pompoen",
                "Sjareltje", "Kimchiwinchi", "FooBar", "BarFoo" };
        }

        private List<string> BlackList { get; set; }

        public List<string> GetBlackList()
        {
            return this.BlackList;
        }
    }
}
