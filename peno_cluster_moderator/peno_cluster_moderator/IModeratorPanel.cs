using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peno_cluster_moderator
{
    public interface IModeratorPanel
    {
        List<String> GetBlackList();
    }
}
