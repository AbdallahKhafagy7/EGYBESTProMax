using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan = new DBManager();

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
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

        public int UpdatePassword(string email, string newPassword)
        {
          
            string query = "UPDATE [User] SET Password = '" + newPassword + "' WHERE Email = '" + email + "'";
            return dbMan.ExecuteNonQuery(query);
        }
        public object GetAdminPassword(string username)
        {
            string query = "SELECT Password FROM [User] WHERE Name = '" + username + "'";
            return dbMan.ExecuteScalar(query);
        }
        public string GetUserType(string email)
        {
            string queryId = "SELECT UserID FROM [User] WHERE Email = '" + email + "'";
            object resultId = dbMan.ExecuteScalar(queryId);

            if (resultId == null) return "NotFound";
            int userId = Convert.ToInt32(resultId);

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
        // Function to Add a Show to a User's List
        //15. AddAdmin
        public int AddAdmin(string email, string name, string password)
        {
            string checkQuery = $"SELECT COUNT(*) FROM [User] WHERE Email = '{email}'";
            int exists = Convert.ToInt32(dbMan.ExecuteScalar(checkQuery));
            if (exists > 0)
                return 0;

            string idQuery = "SELECT ISNULL(MAX(UserID),0) + 1 FROM [User]";
            int newID = Convert.ToInt32(dbMan.ExecuteScalar(idQuery));

            string insertUser =
                $"INSERT INTO [User] (UserID, Email, Name, Password) VALUES ({newID}, '{email}', '{name}', '{password}')";
            int r1 = dbMan.ExecuteNonQuery(insertUser);
            if (r1 == 0) return 0;

            string insertAdmin =
                $"INSERT INTO Administrator (UserID) VALUES ({newID})";

            return dbMan.ExecuteNonQuery(insertAdmin);
        }
        //  16. temp pass 
        public string ResetUserPasswordTemp(int userID)
        {
            string tempPassword = Guid.NewGuid().ToString().Substring(0, 8);

            string query = $"UPDATE [User] SET Password = '{tempPassword}' WHERE UserID = {userID}";
            int rows = dbMan.ExecuteNonQuery(query);

            if (rows > 0)
                return tempPassword;
            else
                return null;
        }
        public int AddShowToList(string listName, int mediaId, string username)
        {
            // 1. Get the ListID based on ListName and Username
            string getListIdQuery = "SELECT L.ListID FROM List L " +
                                    "JOIN [User] U ON L.UserID = U.UserID " +
                                    "WHERE L.ListName = '" + listName + "' AND U.Name = '" + username + "'";

            object result = dbMan.ExecuteScalar(getListIdQuery);

            if (result == null) return 0; // List not found or User mismatch

            int listId = Convert.ToInt32(result);

            // 2. Check if the show is already in the list to avoid duplicates (Optional but recommended)
            string checkQuery = "SELECT COUNT(*) FROM ListItems WHERE ListID = " + listId + " AND MediaID = " + mediaId;
            if ((int)dbMan.ExecuteScalar(checkQuery) > 0)
            {
                return -1; // Specific code for "Already Exists"
            }

            // 3. Insert into ListItems
            string insertQuery = "INSERT INTO ListItems (ListID, MediaID) VALUES (" + listId + ", " + mediaId + ")";
            return dbMan.ExecuteNonQuery(insertQuery);
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
        // 6. Delete User
        // Function to Update User Name
        public int UpdateName(string email, string newName)
        {
            string query = "UPDATE [User] SET Name = '" + newName + "' WHERE Email = '" + email + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteUser(int userID)
        {
            string deleteWatchHistoryQuery = "DELETE FROM WatchHistory WHERE UserID = " + userID;
            dbMan.ExecuteNonQuery(deleteWatchHistoryQuery);

            string deleteRatingsQuery = "DELETE FROM MediaRating WHERE UserID = " + userID;
            dbMan.ExecuteNonQuery(deleteRatingsQuery);

            string deleteListItemsQuery = "DELETE FROM ListItems WHERE ListID IN (SELECT ListID FROM List WHERE UserID = " + userID + ")";
            dbMan.ExecuteNonQuery(deleteListItemsQuery);

            string deleteListsQuery = "DELETE FROM List WHERE UserID = " + userID;
            dbMan.ExecuteNonQuery(deleteListsQuery);

            string deletePaymentsQuery = "DELETE FROM Payment WHERE UserID = " + userID;
            dbMan.ExecuteNonQuery(deletePaymentsQuery);

            string deleteEndUserQuery = "DELETE FROM EndUser WHERE UserID = " + userID;
            dbMan.ExecuteNonQuery(deleteEndUserQuery);

            string deleteAdminQuery = "DELETE FROM Administrator WHERE UserID = " + userID;
            dbMan.ExecuteNonQuery(deleteAdminQuery);

            string deletePublisherQuery = "DELETE FROM Publisher WHERE UserID = " + userID;
            dbMan.ExecuteNonQuery(deletePublisherQuery);

            string deleteUserQuery = "DELETE FROM [User] WHERE UserID = " + userID;
            return dbMan.ExecuteNonQuery(deleteUserQuery);
        }


        // 7. Reset User Pass
        public int ResetUserPassword(int userID, string newPassword)
        {
            if (userID <= 0 || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Invalid UserID or password.");
                return 0;
            }

            string checkUserQuery = "SELECT COUNT(*) FROM [User] WHERE UserID = " + userID;
            object exists = dbMan.ExecuteScalar(checkUserQuery);
            if (Convert.ToInt32(exists) == 0)
            {
                MessageBox.Show("User not found in database.");
                return 0;
            }

            string updatePasswordQuery = "UPDATE [User] SET Password = '" + newPassword + "' WHERE UserID = " + userID;
            int rowsAffected = dbMan.ExecuteNonQuery(updatePasswordQuery);

            return rowsAffected;
        }


        // 8. Delete Publisher
        public int DeletePublisher(int userID)
        {
            string deleteWatchHistoryQuery = "DELETE FROM WatchHistory WHERE MediaID IN " +
                                             "(SELECT MediaID FROM Media WHERE PublisherID = (SELECT PublisherID FROM Publisher WHERE UserID = " + userID + "))";
            dbMan.ExecuteNonQuery(deleteWatchHistoryQuery);

            string deleteRatingsQuery = "DELETE FROM MediaRating WHERE MediaID IN " +
                                        "(SELECT MediaID FROM Media WHERE PublisherID = (SELECT PublisherID FROM Publisher WHERE UserID = " + userID + "))";
            dbMan.ExecuteNonQuery(deleteRatingsQuery);

            string deleteListItemsQuery = "DELETE FROM ListItems WHERE MediaID IN " +
                                         "(SELECT MediaID FROM Media WHERE PublisherID = (SELECT PublisherID FROM Publisher WHERE UserID = " + userID + "))";
            dbMan.ExecuteNonQuery(deleteListItemsQuery);

            string deleteShowQuery = "DELETE FROM Show WHERE MediaID IN " +
                                     "(SELECT MediaID FROM Media WHERE PublisherID = (SELECT PublisherID FROM Publisher WHERE UserID = " + userID + "))";
            dbMan.ExecuteNonQuery(deleteShowQuery);

            string deleteMediaQuery = "DELETE FROM Media WHERE PublisherID = (SELECT PublisherID FROM Publisher WHERE UserID = " + userID + ")";
            dbMan.ExecuteNonQuery(deleteMediaQuery);

            string deletePublisherQuery = "DELETE FROM Publisher WHERE UserID = " + userID;
            dbMan.ExecuteNonQuery(deletePublisherQuery);

            string deleteListItemsUserQuery = "DELETE FROM ListItems WHERE ListID IN (SELECT ListID FROM List WHERE UserID = " + userID + ")";
            dbMan.ExecuteNonQuery(deleteListItemsUserQuery);

            string deleteListsQuery = "DELETE FROM List WHERE UserID = " + userID;
            dbMan.ExecuteNonQuery(deleteListsQuery);

            string deleteUserQuery = "DELETE FROM [User] WHERE UserID = " + userID;
            return dbMan.ExecuteNonQuery(deleteUserQuery);
        }


        // 9. Delete a Show
        public int DeleteShow(int mediaID)
        {
            string deleteWatchHistoryQuery = "DELETE FROM WatchHistory WHERE MediaID = " + mediaID;
            dbMan.ExecuteNonQuery(deleteWatchHistoryQuery);

            string deleteRatingsQuery = "DELETE FROM MediaRating WHERE MediaID = " + mediaID;
            dbMan.ExecuteNonQuery(deleteRatingsQuery);

            string deleteListItemsQuery = "DELETE FROM ListItems WHERE MediaID = " + mediaID;
            dbMan.ExecuteNonQuery(deleteListItemsQuery);

            string deleteShowQuery = "DELETE FROM Show WHERE MediaID = " + mediaID;
            dbMan.ExecuteNonQuery(deleteShowQuery);

            string deleteMediaQuery = "DELETE FROM Media WHERE MediaID = " + mediaID;
            return dbMan.ExecuteNonQuery(deleteMediaQuery);
        }

        // 10. Get All Shows
        public DataTable GetAllShows()
        {
            string query = "SELECT M.MediaID, M.Name, M.NumOfFavs, M.Finished " +
                           "FROM Media M " +
                           "JOIN Show S ON M.MediaID = S.MediaID";
            return dbMan.ExecuteReader(query);
        }

        // 11. Get All Publishers
        public DataTable GetAllPublishers()
        {
            string query = "SELECT U.UserID, U.Name, U.Email, P.Website " +
                           "FROM [User] U " +
                           "JOIN Publisher P ON U.UserID = P.UserID";
            return dbMan.ExecuteReader(query);
        }
        // 12. Get No. of Shows Per Publisher
        public DataTable GetShowCountPerPublisher()
        {
            string query = @"SELECT U.Name AS Publisher, COUNT(M.MediaID) AS NumOfShows
                     FROM Publisher P
                     JOIN [User] U ON P.UserID = U.UserID
                     LEFT JOIN Media M ON P.PublisherID = M.PublisherID
                     GROUP BY U.Name";
            return dbMan.ExecuteReader(query);
        }
        // 13. Get Avg Rating 
        public DataTable GetShowRatings()
        {
            string query = @"SELECT M.Name AS ShowName, ISNULL(AVG(MR.Rating),0) AS AvgRating
                     FROM Media M
                     LEFT JOIN MediaRating MR ON M.MediaID = MR.MediaID
                     JOIN Show S ON M.MediaID = S.MediaID
                     GROUP BY M.Name";
            return dbMan.ExecuteReader(query);
        }

        //14. Get top fav shows
        public DataTable GetTopFavorites(int topN)
        {
            string query = $@"SELECT TOP {topN} M.Name AS ShowName, M.NumOfFavs
                      FROM Media M
                      JOIN Show S ON M.MediaID = S.MediaID
                      ORDER BY M.NumOfFavs DESC";
            return dbMan.ExecuteReader(query);
        }

        //----------------------------

        // get publisher by email
        public DataTable GetPublisherByEmail(string email)
        {
            string query = "SELECT P.* " +
                            "FROM Publisher P, [User] U " +
                            "WHERE P.UserID = U.UserID " +
                            "AND U.Email = '" + email + "'";
            return dbMan.ExecuteReader(query);
        }

        // get shows by publisher id
        public DataTable GetShowsByPublisherId(int publisherId)
        {
            string query = @"SELECT
                                M.Name AS ShowName,
                                M.NumOfFavs,
                                SE.EpisodeCount,
                                SE.Name AS SeasonName
                            FROM Media M
                            JOIN Seasons SE ON M.MediaID = SE.MediaID
                            WHERE M.PublisherID = " + publisherId;

            return dbMan.ExecuteReader(query);
        }

        // insert show
        public int InsertShow(int publisherId, string showName, int episodesCount, string genre)
        {
            // 1. Insert into Media
            string insertMediaQuery =
                "INSERT INTO Media (Name, Finished, NumOfFavs, PublisherID) " +
                "VALUES ('" + showName + "', 0, 0, " + publisherId + ")";

            int result = dbMan.ExecuteNonQuery(insertMediaQuery);
            if (result == 0) return 0;

            // 2. Get newly inserted MediaID
            string getMediaIdQuery = "SELECT MAX(MediaID) FROM Media";
            int mediaId = Convert.ToInt32(dbMan.ExecuteScalar(getMediaIdQuery));

            // 3. Insert into Show (inheritance)
            string insertShowQuery =
                "INSERT INTO Show (MediaID) VALUES (" + mediaId + ")";
            dbMan.ExecuteNonQuery(insertShowQuery);

            // 4. Insert Season 1 with provided episodes count
            string insertSeasonQuery =
                "INSERT INTO Seasons (MediaID, EpisodeCount, Name) " +
                "VALUES (" + mediaId + ", " + episodesCount + ", 'Season 1')";
            dbMan.ExecuteNonQuery(insertSeasonQuery);

            // 5. Insert Genre
            string insertGenreQuery =
                "INSERT INTO MediaGenre (MediaID, GenreName) " +
                "VALUES (" + mediaId + ", '" + genre + "')";
            dbMan.ExecuteNonQuery(insertGenreQuery);

            return mediaId;
        }

        // For adding a new season to an existing show
        public int AddSeason(int mediaId, int episodesCount)
        {
            // Count existing seasons
            string countSeasonsQuery = "SELECT COUNT(*) FROM Seasons WHERE MediaID = " + mediaId;
            int currentSeasons = Convert.ToInt32(dbMan.ExecuteScalar(countSeasonsQuery));
            int newSeasonNumber = currentSeasons + 1;
            string newSeasonName = "Season " + newSeasonNumber;

            // Insert new season
            string insertSeasonQuery = "INSERT INTO Seasons (MediaID, EpisodeCount, Name) " +
                                       "VALUES (" + mediaId + ", " + episodesCount + ", '" + newSeasonName + "')";
            return dbMan.ExecuteNonQuery(insertSeasonQuery);
        }

        // rate show
        public int RateShow(string mail, string showName, int rating)
        {
            // 1. Get UserID
            string getUserIdQuery = "SELECT UserID FROM [User] WHERE Email = '" + mail + "'";
            object userIdObj = dbMan.ExecuteScalar(getUserIdQuery);
            if (userIdObj == null) return 0;
            int userId = Convert.ToInt32(userIdObj);

            // 2. Get MediaID
            string getMediaIdQuery = "SELECT MediaID FROM Media WHERE Name LIKE '%" + showName + "%'";
            object mediaIdObj = dbMan.ExecuteScalar(getMediaIdQuery);
            if (mediaIdObj == null) return 0;
            int mediaId = Convert.ToInt32(mediaIdObj);

            // 3. Insert or Update Rating
            string checkExistingQuery = "SELECT COUNT(*) FROM MediaRating WHERE UserID = " + userId + " AND MediaID = " + mediaId;
            int count = (int)dbMan.ExecuteScalar(checkExistingQuery);
            string rateQuery;
            if (count > 0)
            {
                // Update existing rating
                rateQuery = "UPDATE MediaRating SET Rating = " + rating + " WHERE UserID = " + userId + " AND MediaID = " + mediaId;
            }
            else
            {
                // Insert new rating
                rateQuery = "INSERT INTO MediaRating (UserID, MediaID, Rating) VALUES (" + userId + ", " + mediaId + ", " + rating + ")";
            }
            return dbMan.ExecuteNonQuery(rateQuery);
        }

        // get user id by email
        public int GetUserIDFromEmail(string email)
        {
            string query = "SELECT UserID FROM [User] WHERE Email = '" + email + "'";
            object result = dbMan.ExecuteScalar(query);
            if (result != null)
                return Convert.ToInt32(result);
            return -1;
        }

        // get user name by email

        public string GetUserNameFromEmail(string email)
        {
            string query = "SELECT Name FROM [User] WHERE Email = '" + email + "'";
            object result = dbMan.ExecuteScalar(query);
            if (result != null)
                return result.ToString();
            return "";
        }


        // get all list for user id
        public DataTable GetUserLists(int userId)
        {
            string query = "SELECT * FROM [List] WHERE UserID = " + userId;
            return dbMan.ExecuteReader(query);
        }
        // create new list
        public int InsertList(string listName, int userId)
        {
            string query = "INSERT INTO List (ListName, UserID) " +
                           "VALUES ('" + listName + "', " + userId + ")";
            return dbMan.ExecuteNonQuery(query);
        }

        // get MediaID by show name
        public int GetMediaIDByName(string showName)
        {
            string query = "SELECT MediaID FROM Media WHERE Name = '" + showName + "'";
            object mediaIdObj = dbMan.ExecuteScalar(query);
            return (mediaIdObj == null) ? 0 : Convert.ToInt32(mediaIdObj);
        }

        // insert item into list
        public int InsertListItem(string listName, int userId, int mediaId)
        {
            // Get ListID from listName and userId
            string query = "SELECT ListID FROM List WHERE ListName = '" + listName + "' AND UserID = " + userId;
            object listIdObj = dbMan.ExecuteScalar(query);
            if (listIdObj == null) return 0;
            int listId = Convert.ToInt32(listIdObj);

            // Insert into ListItems
            string insertQuery = "INSERT INTO ListItems (ListID, MediaID) VALUES (" + listId + ", " + mediaId + ")";
            return dbMan.ExecuteNonQuery(insertQuery);
        }

        // get all shows in a list for a user
        public DataTable GetListShows(int userId, string listName)
        {
            // 1. Get ListID for this user and list name
            string listIdQuery = "SELECT ListID FROM List WHERE UserID = " + userId + " AND ListName = '" + listName + "'";
            object listIdObj = dbMan.ExecuteScalar(listIdQuery);

            if (listIdObj == null)
                return new DataTable(); // Return empty DataTable if list doesn't exist

            int listId = Convert.ToInt32(listIdObj);

            // 2. Get all shows in this list
            string query = "SELECT M.MediaID, M.Name AS [ShowName], M.NumOfFavs, M.Finished FROM ListItems LI INNER JOIN Media M ON LI.MediaID = M.MediaID WHERE LI.ListID = " + listId;

            return dbMan.ExecuteReader(query);
        }

        //-----------------
        public DataTable GetWatchHistory(string email)
        {
            string query = "SELECT M.Name AS 'Media Name', WH.WatchDate " +
                           "FROM WatchHistory WH " +
                           "JOIN Media M ON WH.MediaID = M.MediaID " +
                           "JOIN [User] U ON WH.UserID = U.UserID " +
                           "WHERE U.Email = '" + email + "' " +
                           "ORDER BY WH.WatchDate DESC";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAllMedia()
        {
            string query = "SELECT MediaID, Name FROM Media";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMediaByName(string name)
        {
            string query = "SELECT MediaID, Name FROM Media WHERE Name LIKE '%" + name + "%'";
            return dbMan.ExecuteReader(query);
        }
        public int AddToWatchHistory(int mediaId, string email)
        {
            string query = "INSERT INTO WatchHistory (MediaID, UserID, WatchDate) " +
                           "SELECT " + mediaId + ", UserID, GETDATE() " +
                           "FROM [User] WHERE Email = '" + email + "'";
            return dbMan.ExecuteNonQuery(query);
        }
        public string GetSubscriptionPlan(string email)
        {
            string query = "SELECT TOP 1 Subscription FROM Payment P " +
                           "JOIN [User] U ON P.UserID = U.UserID " +
                           "WHERE U.Email = '" + email + "' " +
                           "ORDER BY PaymentID DESC";

            object result = dbMan.ExecuteScalar(query);
            if (result == null) return "Free Plan";
            return result.ToString();
        }

        public int UpdateSubscription(string email, string newPlan, decimal price)
        {
            // 1. Get UserID
            string userIdQuery = "SELECT UserID FROM [User] WHERE Email = '" + email + "'";
            object result = dbMan.ExecuteScalar(userIdQuery);
            if (result == null) return 0;
            int userId = Convert.ToInt32(result);

            // 2. Check if user has ANY payment record
            string checkQuery = "SELECT COUNT(*) FROM Payment WHERE UserID = " + userId;
            int count = (int)dbMan.ExecuteScalar(checkQuery);

            if (count > 0)
            {
                // UPDATE the LATEST record for this user
                string updateQuery = "UPDATE Payment SET Subscription = '" + newPlan + "', Price = " + price +
                                     " WHERE PaymentID = (SELECT MAX(PaymentID) FROM Payment WHERE UserID = " + userId + ")";
                return dbMan.ExecuteNonQuery(updateQuery);
            }
            else
            {
                // INSERT new record
                string maxIdQuery = "SELECT ISNULL(MAX(PaymentID), 0) + 1 FROM Payment";
                int newPaymentId = (int)dbMan.ExecuteScalar(maxIdQuery);

                string insertQuery = "INSERT INTO Payment (PaymentID, Price, Subscription, UserID) " +
                                     "VALUES (" + newPaymentId + ", " + price + ", '" + newPlan + "', " + userId + ")";
                return dbMan.ExecuteNonQuery(insertQuery);
            }
        }
        public int UpdateActorName(int actorId, string newName)
        {
            string query = "UPDATE Actors SET Name = '" + newName + "' WHERE ActorID = " + actorId;
            return dbMan.ExecuteNonQuery(query);
        }

        // Update Actor Age
        public int UpdateActorAge(int actorId, int newAge)
        {
            string query = "UPDATE Actors SET Age = " + newAge + " WHERE ActorID = " + actorId;
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetMoviesByActor(string actorName)
        {
            string query = "SELECT M.MediaID, M.Name AS MediaName, A.Name AS ActorName " +
                           "FROM Media M " +
                           "JOIN MediaActors MA ON M.MediaID = MA.MediaID " +
                           "JOIN Actors A ON MA.ActorID = A.ActorID " +
                           "WHERE A.Name LIKE '%" + actorName + "'";
            return dbMan.ExecuteReader(query);
        }
        // Search Movies by Actor Name (distinct movies only)
        // Function to Search for Shows by Actor Name
        public DataTable GetShowsByActor(string actorName)
        {
            // Corrected Query using your specific table names: 'MediaActors' and 'Actors'
            string query = "SELECT M.Name, M.NumOfFavs, M.Finished " +
                           "FROM Media M " +
                           "JOIN MediaActors MA ON M.MediaID = MA.MediaID " +
                           "JOIN Actors A ON MA.ActorID = A.ActorID " +
                           "WHERE A.Name LIKE '%" + actorName + "%'";

            return dbMan.ExecuteReader(query);
        }
        // get show by name if exits
        public DataTable GetShowByName(string showName)
        {
            string query = "SELECT * FROM Media WHERE Name = '" + showName + "'";
            DataTable dt = dbMan.ExecuteReader(query);

            if (dt == null)
                return new DataTable();

            return dt;
        }
        public int AddActor(string name, int age)
        {
            // Generate ID
            string maxIdQuery = "SELECT ISNULL(MAX(ActorID), 0) + 1 FROM Actors";
            int newId = (int)dbMan.ExecuteScalar(maxIdQuery);

            string query = "INSERT INTO Actors (ActorID, Name, Age) VALUES (" + newId + ", '" + name + "', " + age + ")";
            return dbMan.ExecuteNonQuery(query);
        }

        // Link Actor to Media
        public int AddActorToMedia(int mediaId, int actorId)
        {
            // Check if exists
            string checkQuery = "SELECT COUNT(*) FROM MediaActors WHERE MediaID = " + mediaId + " AND ActorID = " + actorId;
            if ((int)dbMan.ExecuteScalar(checkQuery) > 0) return -1; 

            string query = "INSERT INTO MediaActors (MediaID, ActorID) VALUES (" + mediaId + ", " + actorId + ")";
            return dbMan.ExecuteNonQuery(query);
        }

        // Get All Actors
        public DataTable GetAllActors()
        {
            return dbMan.ExecuteReader("SELECT ActorID, Name FROM Actors");
        }
        public int AddPublisherUser(string email, string name, string password, string website)
        {
            if (IsEmailExists(email) == 1) return 0;

            int userId = GetNextUserId();
            string queryUser = "INSERT INTO [User] (UserID, Email, Name, Password) VALUES (" +
                               userId + ", '" + email + "', '" + name + "', '" + password + "')";
            dbMan.ExecuteNonQuery(queryUser);

            string maxPubId = "SELECT ISNULL(MAX(PublisherID), 0) + 1 FROM Publisher";
            int pubId = (int)dbMan.ExecuteScalar(maxPubId);

            string queryPub = "INSERT INTO Publisher (PublisherID, Website, UserID) VALUES (" +
                              pubId + ", '" + website + "', " + userId + ")";
            return dbMan.ExecuteNonQuery(queryPub);
        }
        public DataTable GetActorsByName(string name)
        {
            string query = "SELECT ActorID, Name FROM Actors WHERE Name LIKE '%" + name + "%'";
            return dbMan.ExecuteReader(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}

