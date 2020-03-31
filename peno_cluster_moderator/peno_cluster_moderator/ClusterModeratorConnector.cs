using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace peno_cluster_moderator
{
    /// <summary>
    /// The Cluster Moderator Connector allows GUI or Command Line Moderator User Applications to connect with
    /// cluster.
    /// </summary>
    public class ClusterModeratorConnector : IModeratorPanel
    {
        /// <summary>
        /// The connection to cluster.
        /// </summary>
        private string ClusterConnection { get; set; }

        /// <summary>
        /// Create a new Cluster Moderator Connector instance using the username and password of some user.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <exception cref="ArgumentException">Thrown when the username of password were incorrect or the
        /// connection to cluster failed.</exception>
        public ClusterModeratorConnector(string username, string password) {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "clusterbot.database.windows.net";
            builder.UserID = username;
            builder.Password = password;
            builder.InitialCatalog = "Cluster";

            this.ClusterConnection = builder.ConnectionString;

            // Test the connection
            try
            {
                using (SqlConnection connection = new SqlConnection(this.ClusterConnection))
                {
                    connection.Open();
                }
            }
            catch (SqlException e)
            {
                throw new ArgumentException(e.ToString());
            }
        }

        public List<string> GetBlackList()
        {
            throw new NotImplementedException();
        }

        public void AddWord(string word)
        {
            throw new NotImplementedException();
        }

        public void RemoveWord(string word)
        {
            throw new NotImplementedException();
        }

        public List<List<string>> GetReportedQA()
        {
            throw new NotImplementedException();
        }

        public void SafeReportedQA(List<string> reportedQA)
        {
            throw new NotImplementedException();
        }

        public void OffensiveReportedQA(List<string> reportedQ)
        {
            throw new NotImplementedException();
        }

        public List<(string, DateTime)> GetBlockedUsers()
        {
            throw new NotImplementedException();
        }

        public void BlockUser(string userId, DateTime date)
        {
            throw new NotImplementedException();
        }

        public void UnblockUser(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
