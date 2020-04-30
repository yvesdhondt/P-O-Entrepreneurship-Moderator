# Cluster Moderator

##  What is this?
The moderator is the person who manages Cluster's forum. He/she has the ability to view questions and answers, resolve conflicting reports and control user's access to the forum. The moderator does this with an application called the _Moderator Panel_. The source code for this application can be found at: [this repo](https://github.com/yvesdhondt/P-O-Entrepreneurship-Moderator). To gain access to this repo, contact Yves.

##  How is the Moderator Panel implemented?
The Moderator Panel is implemented using C# and Microsoft WinForms.

## What does the Moderator Panel expect from the clusterbot server?
The external server application is hidden behind an interface called `IModeratorPanel`. Any implementation of this interface, be it a connection to a server, to a local SQLite database, or to a temporary in-memory placeholder, will work with the user interface. Concretely, the interface looks as follows:

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
        List<(string,string,string)> GetReportedQA();

        /// <summary>
        /// Decide that the QA-pair is safe.
        /// </summary>
        /// <param name="reportedQA">The QA-pair to mark as safe, a 3-tuple (id,question,answer).</param>
        void SafeReportedQA((string,string,string) reportedQA);

        /// <summary>
        /// Decide that the QA-pair is offensive.
        /// </summary>
        /// <param name="reportedQA">The QA-pair to mark as offensive, a 3-tuple (id,question,answer).</param>
        void OffensiveReportedQA((string,string,string) reportedQ);

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

## `IModeratorPanel`, discussion
For the `IModeratorPanel` to work, the data that it needs will need to be stored permanently in a database table. 3 different **conceptual** tables seem to originate from the interface, although they need not be exactly as suggested here as long as they can be translated to the correct output of the interface functions:
1. Blacklist
   * This table consists of exactly one column, "word", of arbitrary strings. Every string stands for a word that was blacklisted, e.g. forbidden to use in the chatbot.
   * A unique row-id is NOT asked for by the `IModeratorPanel` so this is optional.
1. ReportedQA
   * This table consists of three columns, "user_id", "question", and "answer", of arbitrary strings. This table stores all the question-answer pairs that were reported by other users, as well as the person who posted the answer. (Since the NLP tools aren't perfect, offensive answers will still be able to make their way to the forum, so the users of the chatbot need to be able to _report_ a question-answer pair as offensive)
   * If integers are chosen for the "user_id" column, they need to be translated to strings in the `IModeratorPanel`.
   * A unique row-id is NOT asked for by the `IModeratorPanel` so this is optional.
1. BlockedUsers
   * This table consists of two columns, "user_id" and "blocked_datetime". This table stores all the users that were blocked from the forum (**UNABLE TO** post answers and questions, **STILL ABLE TO** ask questions) and the date & time when they were blocked from the forum.
   * If integers are chosen for the "user_id" column, they need to be translated to strings in the `IModeratorPanel`.
   * The `IModeratorPanel` expects C# `DateTime` objects for the "blocked_datetime". Therefore this column will need to be stored in some other format, such as SQL's `datetime` or some formatted string or perhaps even a JSON string. In the `IModeratorPanel` implementation, a translation will happen from the internal representation of the "blocked_datetime" to C# `DateTime`.
   * A unique row-id is NOT asked for by the `IModeratorPanel` so this is optional.

Keep in mind that this is only a **conceptual** description of these tables. In a real SQL database these tables need to be organized to minimize duplication and avoid inconsistent database states, by use of foreign keys, etc.

## `IModeratorPanel` Implementation
Unlike the NLP tools the `IModeratorPanel` implementation will directly communicate with the database, instead of using a `cluster.Connector`-like class. The user will be able to enter his/her username and password (the same usernames and passwords that have access to the database) to connect with the database. The `IModeratorPanel` will then connect to the database with the given username and password and send queries to fetch and update the information when necessary. The `IModeratorPanel` will be notified that it needs to fetch/update something by multiple _listeners_ that are activated when the user performs an action on the UI.

## Version Log
### V1.0
An implementation of the `IModeratorPanel` interface is created to work with the first release of the clusterbot.
### V0.2
The moderator panel is now secure by use of usernames and passwords. The placeholder `IModeratorPanel` is gradually being replaced by a connector to the Cluster Forum.
### V0.1
Fully implemented UI, connection to a placeholder `IModeratorPanel`.
### V0.0
Raw sketch of the UI, creation of the `IModeratorPanel` interface.
