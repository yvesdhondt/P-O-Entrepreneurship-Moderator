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
            try
            {
                using (SqlConnection connection = new SqlConnection(this.ClusterConnection))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT bl.forbidden_word ");
                    sb.Append("FROM Blacklist bl;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        List<string> blockedUsers = new List<string>();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                blockedUsers.Add(reader.GetString(0));
                            }
                        }
                        Console.WriteLine("Successfully Fetched the blacklist.");
                        return blockedUsers;
                    }
                }
            }
            catch (SqlException e)
            {
                throw new ApplicationException(e.ToString());
            }
        }

        public void AddWord(string word)
        {
            // Do not add empty strings to the db
            if (! string.IsNullOrEmpty(word))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(this.ClusterConnection))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append("INSERT INTO Blacklist (forbidden_word) ");
                        sb.Append("VALUES (@word);");
                        String sql = sb.ToString();

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@word", word);
                            command.ExecuteNonQuery();
                            Console.WriteLine("Successfully added {0} to the blacklist.", word);
                        }
                    }
                }
                catch (SqlException e)
                {
                    throw new ApplicationException(e.ToString());
                }
            }
        }

        public void RemoveWord(string word)
        {
            // Do not waste time removing empty words from the db.
            if (!string.IsNullOrEmpty(word))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(this.ClusterConnection))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append("DELETE FROM Blacklist ");
                        sb.Append("WHERE forbidden_word = @word;");
                        String sql = sb.ToString();

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@word", word);
                            command.ExecuteNonQuery();
                            Console.WriteLine("Successfully deleted {0} from the blacklist.", word);
                        }
                    }
                }
                catch (SqlException e)
                {
                    throw e;
                }
            }
        }

        /// <summary>
        /// Get the reported Q&A from Cluster.
        /// </summary>
        /// <returns>The reported Q&A from Cluster.</returns>
        /// <exception cref="ApplicationException">There was an error while fetching the reported Q&A.</exception>
        public List<(string,string,string)> GetReportedQA()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.ClusterConnection))
                {
                    // Get all the answers with more negative feedback than positive feedback that haven't been approved.
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT a.user_id as id, q.question as question, a.answer as answer ");
                    sb.Append("FROM Answers a INNER JOIN Questions q ON a.answer_id = q.answer_id ");
                    sb.Append("WHERE a.negative_feedback > a.positive_feedback AND a.approved = 0; ");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        List<(string, string, string)> reportedQA = new List<(string, string, string)>();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                reportedQA.Add((reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                            }
                        }
                        Console.WriteLine("Successfully Fetched the reported Q&A.");
                        return reportedQA;
                    }
                }
            }
            catch (SqlException e)
            {
                throw new ApplicationException(e.ToString());
            }
        }

        public void SafeReportedQA((string, string, string) reportedQA)
        {
            try
            {
                string userId = reportedQA.Item1;
                string question = reportedQA.Item2;
                string ans = reportedQA.Item3;

                Int32 qId;
                Int32 aId;

                // Get the question and answer ids from the db.
                using (SqlConnection connection = new SqlConnection(this.ClusterConnection))
                {
                    connection.Open();

                    StringBuilder sb1 = new StringBuilder();
                    sb1.Append("SELECT question_id, answer_id ");
                    sb1.Append("FROM Questions ");
                    sb1.Append("WHERE question = @question; ");
                    String sql1 = sb1.ToString();

                    using (SqlCommand command = new SqlCommand(sql1, connection))
                    {
                        command.Parameters.AddWithValue("@question", question);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            qId = reader.GetInt32(0);
                            aId = reader.GetInt32(1);
                        }
                        Console.WriteLine("Successfully Fetched the reported Q&A ids.");
                    }

                // Approve the answer
                    StringBuilder sb2 = new StringBuilder();
                    sb2.Append("UPDATE Answers ");
                    sb2.Append("SET approved = 1, last_moderated = @now ");
                    sb2.Append("WHERE answer_id = @aid;");
                    String sql2 = sb2.ToString();

                    using (SqlCommand command = new SqlCommand(sql2, connection))
                    {
                        command.Parameters.AddWithValue("@now", DateTime.Now);
                        command.Parameters.AddWithValue("@aid", aId);
                        command.ExecuteNonQuery();
                        Console.WriteLine("Successfully approved {0}.", ans);
                    }
                }
            }
            catch (SqlException e)
            {
                throw new ApplicationException(e.ToString());
            }
        }

        public void OffensiveReportedQA((string, string, string) reportedQA)
        {
            string userId = reportedQA.Item1;
            string question = reportedQA.Item2;
            string ans = reportedQA.Item3;

            Int32 qId;
            Int32 aId;

            try
            {
                // Get the question and answer ids from the db.
                using (SqlConnection connection = new SqlConnection(this.ClusterConnection))
                {
                    connection.Open();

                    StringBuilder sb1 = new StringBuilder();
                    sb1.Append("SELECT question_id, answer_id ");
                    sb1.Append("FROM Questions ");
                    sb1.Append("WHERE question = @question; ");
                    String sql1 = sb1.ToString();

                    using (SqlCommand command = new SqlCommand(sql1, connection))
                    {
                        command.Parameters.AddWithValue("@question", question);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            qId = reader.GetInt32(0);
                            aId = reader.GetInt32(1);
                        }
                        Console.WriteLine("Successfully Fetched the reported Q&A ids.");
                    }
                // Remove the bad answer from the list of questions.
                    StringBuilder sb2 = new StringBuilder();
                    sb2.Append("UPDATE Questions ");
                    sb2.Append("SET answer_id = NULL ");
                    sb2.Append("WHERE question_id = @qid;");
                    String sql2 = sb2.ToString();

                    using (SqlCommand command = new SqlCommand(sql2, connection))
                    {
                        command.Parameters.AddWithValue("@qid", qId);
                        command.ExecuteNonQuery();
                        Console.WriteLine("Successfully removed the answer from {0}.", question);
                    }
                // Remove the bad answer from the list of answers.
                    StringBuilder sb3 = new StringBuilder();
                    sb3.Append("DELETE FROM Answers ");
                    sb3.Append("WHERE answer_id = @aid;");
                    String sql3 = sb3.ToString();

                    using (SqlCommand command = new SqlCommand(sql3, connection))
                    {
                        command.Parameters.AddWithValue("@aid", aId);
                        command.ExecuteNonQuery();
                        Console.WriteLine("Successfully removed {0} from the good answers.", ans);
                    }
                // Remember the bad answer.
                    StringBuilder sb4 = new StringBuilder();
                    sb4.Append("INSERT INTO BadAnswers ");
                    sb4.Append("VALUES (@ans, @qid, @userid);");
                    String sql4 = sb4.ToString();

                    using (SqlCommand command = new SqlCommand(sql4, connection))
                    {
                        command.Parameters.AddWithValue("@ans", ans);
                        command.Parameters.AddWithValue("@qid", qId);
                        command.Parameters.AddWithValue("@userid", userId);
                        command.ExecuteNonQuery();
                        Console.WriteLine("Successfully added {0} to the bad answers.", ans);
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public List<(string, DateTime)> GetBlockedUsers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.ClusterConnection))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT bu.user_id as id, bu.blocked_date ");
                    sb.Append("FROM BlockedUsers bu;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        List<(string, DateTime)> blockedUsers = new List<(string, DateTime)>();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                blockedUsers.Add((reader.GetString(0), reader.GetDateTime(1)));
                            }
                        }
                        Console.WriteLine("Successfully Fetched the blocked users.");
                        return blockedUsers;
                    }
                }
            }
            catch (SqlException e)
            {
                throw new ApplicationException(e.ToString());
            }
        }

        public void BlockUser(string userId, DateTime date)
        {
            if (string.IsNullOrEmpty(userId) || date == null)
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(this.ClusterConnection))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO BlockedUsers (user_id, blocked_date) ");
                    sb.Append("VALUES (@uid, @date);");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@uid", userId);
                        command.Parameters.AddWithValue("@date", date);
                        command.ExecuteNonQuery();
                        Console.WriteLine("Successfully blocked user {0}.", userId);
                    }
                }
            }
            catch (SqlException e)
            {
                throw new ApplicationException(e.ToString());
            }
        }

        public void UnblockUser(string userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.ClusterConnection))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("DELETE FROM BlockedUsers ");
                    sb.Append("WHERE user_id = @userId;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@userId", userId);
                        command.ExecuteNonQuery();
                        Console.WriteLine("Successfully unblocked user {0}.", userId);
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
