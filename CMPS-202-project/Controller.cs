using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan = new DBManager();

        // Function to get the Name associated with an Email
        public string GetNameFromEmail(string email)
        {
            string query = "SELECT Name FROM [User] WHERE Email = '" + email + "'";
            object result = dbMan.ExecuteScalar(query);

            if (result == null)
            {
                return ""; // Or return null if you prefer
            }

            return result.ToString();
        }
        public object GetAdminPassword(string username)
        {
            // Simple query to get password. Assumes 'User' table exists.
            string query = "SELECT Password FROM [User] WHERE Name = '" + username + "'";
            return dbMan.ExecuteScalar(query);
        }
        // Function to get the User Type (Admin, Publisher, or EndUser)
        public string GetUserType(string email)
        {
            // 1. Get UserID first
            string queryId = "SELECT UserID FROM [User] WHERE Email = '" + email + "'";
            object resultId = dbMan.ExecuteScalar(queryId);

            if (resultId == null) return "NotFound";
            int userId = Convert.ToInt32(resultId);

            // 2. Check Administrator Table
            string queryAdmin = "SELECT COUNT(*) FROM [Administrator] WHERE UserID = " + userId;
            if ((int)dbMan.ExecuteScalar(queryAdmin) > 0) return "Administrator";

            // 3. Check Publisher Table
            string queryPub = "SELECT COUNT(*) FROM [Publisher] WHERE UserID = " + userId;
            if ((int)dbMan.ExecuteScalar(queryPub) > 0) return "Publisher";

            // 4. Check EndUser Table
            string queryEnd = "SELECT COUNT(*) FROM [EndUser] WHERE UserID = " + userId;
            if ((int)dbMan.ExecuteScalar(queryEnd) > 0) return "EndUser";

            return "Unknown";
        }
        // 2. Add New User (Sign Up)

        // 1. Search for EndUsers by Name (Partial Match)
        // Useful for: Admin_With_User form
        public DataTable GetUsersByName(string name)
        {
            string query = "SELECT U.UserID, U.Name, U.Email " +
                           "FROM [User] U " +
                           "JOIN EndUser E ON U.UserID = E.UserID " +
                           "WHERE U.Name LIKE '%" + name + "%'";
            return dbMan.ExecuteReader(query);
        }
        // Function to Search for Shows by Name (Partial Match)
        public DataTable GetShowsByName(string subName)
        {
            // The '%' allows finding any name that *contains* the text entered
            string query = "SELECT M.Name, M.NumOfFavs, M.Finished " +
                           "FROM Media M " +
                           "JOIN Show S ON M.MediaID = S.MediaID " +
                           "WHERE M.Name LIKE '%" + subName + "%'";

            return dbMan.ExecuteReader(query);
        }
        // 2. Search for Publishers by Name (Partial Match)
        // Useful for: Admin_with_publisher form
        public DataTable GetPublishersByName(string name)
        {
            string query = "SELECT U.UserID, U.Name, U.Email, P.Website " +
                           "FROM [User] U " +
                           "JOIN Publisher P ON U.UserID = P.UserID " +
                           "WHERE U.Name LIKE '%" + name + "%'";
            return dbMan.ExecuteReader(query);
        }
        private int GetNextUserId()
        {
            string query = "SELECT ISNULL(MAX(UserID), 0) + 1 FROM [User]";
            object result = dbMan.ExecuteScalar(query);

            if (result == null || result == DBNull.Value)
            {
                return 1;
            }
            return Convert.ToInt32(result);
        }

        // 2. Add New User (Sign Up)
        public int IsEmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE Email = '" + email + "';";
            int count = (int)dbMan.ExecuteScalar(query);
            if (count > 0) return 1; // Email found
            return 0;                // Email not found
        }

        // FUNCTION B: Check Password
        // Returns true if password matches, false otherwise.
        public bool CheckPassword(string email, string password)
        {
            string query = "SELECT Password FROM [User] WHERE Email = '" + email + "'";
            object result = dbMan.ExecuteScalar(query);

            if (result == null) return false; // User not found

            string dbPassword = result.ToString();
            return (dbPassword == password);
        }

       

        // Modified AddUser to use the Email check first
        public int addUser(string Email,string username,string password)
        {
            // Step 1: Check if the email already exists
            if (IsEmailExists(Email) == 1)
            {
                return 0; // Failure: Email already taken
            }

            // Step 2: Generate ID and Insert
            int newId = GetNextUserId();

            string queryUser = "INSERT INTO [User] (UserID, Email, Name, Password) VALUES (" +
                               newId + ", '" + Email + "', '" + username + "', '" + password + "');";

            int result1 = dbMan.ExecuteNonQuery(queryUser);

            if (result1 > 0)
            {
                // Insert into EndUser table
                string queryEndUser = "INSERT INTO [EndUser] (UserID) VALUES (" + newId + ");";
                return dbMan.ExecuteNonQuery(queryEndUser);
            }
            return 0;
        }

        public DataTable getShows(string username, string listName)
        {
            // If a list is selected, show items in that list.
            // If no list is selected ("" or null), show ALL shows.

            string query;
            if (string.IsNullOrEmpty(listName))
            {
                // Show all media that are Shows
                query = "SELECT M.Name, M.NumOfFavs, M.Finished " +
                        "FROM Media as M " +
                        "JOIN Show S ON M.MediaID = S.MediaID";
            }
            else
            {
                // Show items in a specific list for this user
                // Joins: User -> List -> ListItems -> Media -> Show
                query = "SELECT M.Name, M.NumOfFavs, M.Finished " +
                        "FROM Media M " +
                        "JOIN Show S ON M.MediaID = S.MediaID " +
                        "JOIN ListItems LI ON M.MediaID = LI.MediaID " +
                        "JOIN List L ON LI.ListID = L.ListID " +
                        "JOIN [User] U ON L.UserID = U.UserID " +
                        "WHERE U.Name = '" + username + "' AND L.ListName = '" + listName + "'";
            }
            return dbMan.ExecuteReader(query);
        }

        // 4. Update Rating
        public int UpdateRating(string showName, string rating, string username)
        {
            // Logic: Find MediaID from Name, Find UserID from Name, then Insert/Update
            // This is complex because we need IDs. 
            // Simplified logic: Assume we can subquery IDs.

            // Check if rating exists to decide between INSERT or UPDATE
            string checkQuery = "SELECT COUNT(*) FROM MediaRating MR " +
                                "JOIN Media M ON MR.MediaID = M.MediaID " +
                                "JOIN [User] U ON MR.UserID = U.UserID " +
                                "WHERE M.Name = '" + showName + "' AND U.Name = '" + username + "'";

            int exists = (int)dbMan.ExecuteScalar(checkQuery);

            if (exists > 0)
            {
                // UPDATE
                string updateQuery = "UPDATE MR SET MR.Rating = " + rating + " " +
                                     "FROM MediaRating MR " +
                                     "JOIN Media M ON MR.MediaID = M.MediaID " +
                                     "JOIN [User] U ON MR.UserID = U.UserID " +
                                     "WHERE M.Name = '" + showName + "' AND U.Name = '" + username + "'";
                return dbMan.ExecuteNonQuery(updateQuery);
            }
            else
            {
                // INSERT
                // We need to fetch IDs first or use subqueries in INSERT
                string insertQuery = "INSERT INTO MediaRating (MediaID, UserID, Rating) " +
                                     "SELECT M.MediaID, U.UserID, " + rating + " " +
                                     "FROM Media M, [User] U " +
                                     "WHERE M.Name = '" + showName + "' AND U.Name = '" + username + "'";
                return dbMan.ExecuteNonQuery(insertQuery);
            }
        }

        // 5. Get All Lists for a User
        public DataTable getAllist(string email)
        {
            string query = "SELECT ListName AS list FROM List L " +
                           "JOIN [User] U ON L.UserID = U.UserID " +
                           "WHERE U.Email = '" + email + "'";  // CHANGED U.Name TO U.Email
            return dbMan.ExecuteReader(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}

