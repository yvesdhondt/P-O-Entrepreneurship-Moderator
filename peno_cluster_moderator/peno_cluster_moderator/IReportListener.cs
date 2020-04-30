using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peno_cluster_moderator
{
    /// <summary>
    /// A listener to a list of reported Q&amp;As.
    /// </summary>
    public interface IReportListener : IUpdateListener<(string, string, string)>
    {
    }
}
