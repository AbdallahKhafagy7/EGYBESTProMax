USE [project_egybestpromax]
GO

-- 1. User Table
-- Added: NOT NULL for Name and Password
CREATE TABLE [User] 
(
    UserID INT PRIMARY KEY,
    Email VARCHAR(50) UNIQUE NOT NULL,
    Name VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL
);

-- 2. EndUser Table (Inheritance)
CREATE TABLE [EndUser]
(
    UserID INT PRIMARY KEY, 
    FOREIGN KEY (UserID) REFERENCES [User](UserID)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

-- 3. Administrator Table (Inheritance)
CREATE TABLE [Administrator]
(
    UserID INT PRIMARY KEY,
    FOREIGN KEY (UserID) REFERENCES [User](UserID)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

-- 4. Publisher Table
-- Added: NOT NULL for Website
CREATE TABLE Publisher 
(
    PublisherID INT PRIMARY KEY,
    Website VARCHAR(255) NOT NULL,
    UserID INT FOREIGN KEY REFERENCES [User](UserID)
);

-- 5. Media Table
-- Added: NOT NULL for Name
-- Added: DEFAULT 0 for Finished (False by default)
-- Added: DEFAULT 0 for NumOfFavs and CHECK constraint to prevent negative numbers
CREATE TABLE Media 
(
    MediaID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Finished BIT DEFAULT 0, 
    NumOfFavs INT DEFAULT 0 CHECK (NumOfFavs >= 0),
    PublisherID INT FOREIGN KEY REFERENCES PUBLISHER (PublisherID)
);

-- 6. Show Table (Inheritance)
CREATE TABLE Show
(
    MediaID INT PRIMARY KEY,
    FOREIGN KEY(MediaID) REFERENCES Media(MediaID)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

-- 7. MediaGenre Table
CREATE TABLE MediaGenre
(
    MediaID INT,
    GenreName VARCHAR(50),
    PRIMARY KEY (MediaID, GenreName),
    FOREIGN KEY (MediaID) REFERENCES Media (MediaID)
    ON DELETE CASCADE
    ON UPDATE CASCADE 
);

-- 8. Actors Table
-- Added: NOT NULL for Name
-- Added: CHECK constraint to ensure Age is positive
CREATE TABLE Actors
(
    ActorID INT PRIMARY KEY,
    Age INT CHECK (Age > 0),
    Name VARCHAR(50) NOT NULL
);

-- 9. MediaActors Table (Junction)
CREATE TABLE MediaActors (
    MediaID INT,
    ActorID INT,
    PRIMARY KEY (MediaID, ActorID),
    FOREIGN KEY (MediaID) REFERENCES Media (MediaID)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
    FOREIGN KEY (ActorID) REFERENCES Actors (ActorID)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

-- 10. Seasons Table
-- Added: CHECK constraint for EpisodeCount (must be positive)
CREATE TABLE Seasons 
(
    MediaID INT,
    EpisodeCount INT CHECK (EpisodeCount >= 0),
    Name VARCHAR(50) NOT NULL,
    PRIMARY KEY (MediaID, Name),
    FOREIGN KEY (MediaID) REFERENCES Media (MediaID)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

-- 11. Episodes Table
-- Added: CHECK constraint for Duration (must be positive)
-- Added: CHECK constraint for EpisodeNumber (must be positive)
CREATE TABLE Episodes
(
    Duration INT CHECK (Duration > 0),
    Name VARCHAR(50) NOT NULL,
    SeasonName VARCHAR(50), 
    EpisodeNumber INT CHECK (EpisodeNumber > 0),
    MediaID INT,
    PRIMARY KEY (MediaID, SeasonName, Name),
    FOREIGN KEY (MediaID, SeasonName) REFERENCES Seasons (MediaID, Name)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

-- 12. Payment Table
-- Added: NOT NULL for Price and Subscription
-- Added: CHECK constraint to prevent negative Prices
CREATE TABLE Payment
(
    PaymentID INT PRIMARY KEY,
    Price DECIMAL(10,2) NOT NULL CHECK (Price >= 0), 
    Subscription VARCHAR(50) NOT NULL,
    UserID INT FOREIGN KEY REFERENCES [EndUser](UserID)
);

-- 13. List Table
-- Added: NOT NULL for ListName
CREATE TABLE List
(
    ListID INT IDENTITY(1,1) PRIMARY KEY,
    ListName VARCHAR(100) NOT NULL,
    UserID INT FOREIGN KEY REFERENCES [EndUser](UserID)
);

-- 14. MediaRating Table
-- Added: CHECK constraint for Rating (Between 1 and 5 stars)
CREATE TABLE MediaRating(
    MediaId INT,
    UserID INT,
    Rating INT CHECK (Rating >= 1 AND Rating <= 5),
    PRIMARY KEY (MediaID, UserID),
    FOREIGN KEY(MediaID) REFERENCES Media(MediaID),
    FOREIGN KEY(UserID) REFERENCES [EndUser](UserID)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

-- 15. WatchHistory Table
-- Added: DEFAULT GETDATE() for WatchDate (Automatically sets current time if not provided)
CREATE TABLE WatchHistory (
    MediaID INT,
    UserID INT,
    WatchDate DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (MediaID, UserID, WatchDate),
    FOREIGN KEY (MediaID) REFERENCES Media (MediaID),
    FOREIGN KEY (UserID) REFERENCES [EndUser] (UserID)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

-- 16. ListItems Table (Junction)
CREATE TABLE ListItems (
    ListID INT,
    MediaID INT,
    PRIMARY KEY (ListID, MediaID),
    FOREIGN KEY (ListID) REFERENCES [List] (ListID),
    FOREIGN KEY (MediaID) REFERENCES Media (MediaID)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);



