USE [project_egybestpromax]
GO


INSERT INTO [User] (UserID, Email, Name, Password) VALUES
(1, 'alice@example.com', 'Alice Smith', 'pass123'),  -- EndUser
(2, 'bob@example.com', 'Bob Jones', 'pass456'),      -- EndUser
(3, 'charlie@example.com', 'Charlie Day', 'pass789'),-- EndUser
(4, 'admin1@egybest.com', 'Admin One', 'adminpass'), -- Admin
(5, 'admin2@egybest.com', 'Admin Two', 'adminpass'), -- Admin
(6, 'admin3@egybest.com', 'Admin Three', 'adminpass'),-- Admin
(7, 'hbo@network.com', 'HBO Official', 'pubpass1'),  -- Publisher
(8, 'netflix@network.com', 'Netflix', 'pubpass2'),   -- Publisher
(9, 'amc@network.com', 'AMC Network', 'pubpass3'),   -- Publisher
(10, 'david@example.com', 'David Miller', 'pass321'), -- EndUser
(11, 'sara@example.com', 'Sara Wilson', 'pass654'), -- EndUser
(12, 'linda@example.com', 'Linda Carter', 'pass987'), -- EndUser
(13, 'mark@example.com', 'Mark Hall', 'pass741'),  -- EndUser
(14, 'noor@example.com', 'Noor Ahmed', 'pass852'), -- EndUser
(15, 'admin4@egybest.com', 'Admin Four', 'adminpass'), -- Admin
(16, 'admin5@egybest.com', 'Admin Five', 'adminpass'), -- Admin
(17, 'paramount@network.com', 'Paramount Studios', 'pubpass4'),  -- Publisher
(18, 'disney@network.com', 'Disney Plus', 'pubpass5'), -- Publisher
(19, 'apple@network.com', 'Apple TV', 'pubpass6'), -- Publisher
(20, 'starz@network.com', 'Starz Media', 'pubpass7');  -- Publisher


-- EndUsers
INSERT INTO [EndUser] (UserID) VALUES (1), (2), (3), (10),(11),(12),(13),(14);

-- Administrators
INSERT INTO [Administrator] (UserID) VALUES (4), (5), (6), (15), (16);

-- Publishers (Note: They have their own PublisherID + link to UserID)
INSERT INTO Publisher (PublisherID, Website, UserID) VALUES
(101, 'www.hbo.com', 7),
(102, 'www.netflix.com', 8),
(103, 'www.amc.com', 9),
(104, 'paramount@network.com',17),
(105, 'disney@network.com',18),
(106, 'apple@netorwk.com',19),
(107, 'starz@netorwk.com',20);

INSERT INTO Media (Name, Finished, NumOfFavs, PublisherID) VALUES
('Game of Thrones', 1, 5000, 101),
('Stranger Things', 0, 8000, 102),
('Breaking Bad', 1, 9000, 103),
('The Crown', 0, 3000, 102),
('Better Call Saul', 1, 4500, 103),
('Westworld', 0, 2700, 101),
('The Last of Us', 0, 6200, 101),
('Narcos', 1, 5400, 102),
('Dark', 1, 7600, 102),
('Ozark', 1, 4100, 102),
('The Walking Dead', 1, 8800, 103),
('Mad Men', 1, 4200, 103),
('Sherlock', 1, 9500, 104),
('Peaky Blinders', 1, 7000, 104),
('The Mandalorian', 0, 10000, 105),
('Loki', 0, 8500, 105),
('The Morning Show', 0, 3600, 106),
('See', 1, 2800, 106),
('Halo', 0, 2000, 107),
('Yellowstone', 1, 6500, 107);

INSERT INTO Show (MediaID) VALUES
(1),(2),(3),(4),(5),(6),(7),(8),(9),(10),
(11),(12),(13),(14),(15),(16),(17),(18),(19),(20);



INSERT INTO MediaGenre (MediaID, GenreName) VALUES
(1, 'Fantasy'),
(1, 'Drama'),
(2, 'Sci-Fi'),
(2, 'Horror'),
(3, 'Crime'),
(3, 'Thriller'),
(4, 'Drama'),
(4, 'Historical'),
(5, 'Crime'),
(5, 'Legal'),
(6, 'Sci-Fi'),
(6, 'Drama'),
(7, 'Drama'),
(7, 'Post-Apocalyptic'),
(8, 'Crime'),
(8, 'Drama'),
(9, 'Sci-Fi'),
(9, 'Mystery'),
(10, 'Crime'),
(10, 'Thriller'),
(11, 'Horror'),
(11, 'Drama'),
(12, 'Drama'),
(12, 'Historical'),
(13, 'Mystery'),
(13, 'Crime'),
(14, 'Crime'),
(14, 'Drama'),
(15, 'Sci-Fi'),
(15, 'Adventure'),
(16, 'Fantasy'),
(16, 'Adventure'),
(17, 'Drama'),
(17, 'Mystery'),
(18, 'Sci-Fi'),
(18, 'Action'),
(19, 'Sci-Fi'),
(19, 'Action'),
(20, 'Drama'),
(20, 'Western');



INSERT INTO Actors (ActorID, Age, Name) VALUES
(301, 35, 'Emilia Clarke'),
(302, 19, 'Millie Bobby Brown'),
(303, 65, 'Bryan Cranston'),
(304, 40, 'Aaron Paul'),
(305, 47, 'Kit Harington'),
(306, 34, 'Sophie Turner'),
(307, 51, 'Pedro Pascal'),
(308, 41, 'Evan Rachel Wood'),
(309, 56, 'Gillian Anderson'),
(310, 29, 'Anya Taylor-Joy'),
(311, 54, 'Norman Reedus'),
(312, 48, 'Jon Hamm'),
(313, 48, 'Benedict Cumberbatch'),
(314, 46, 'Cillian Murphy'),
(315, 53, 'Pedro Pascal'),
(316, 35, 'Tom Hiddleston'),
(317, 47, 'Jennifer Aniston'),
(318, 44, 'Jason Momoa'),
(319, 46, 'Pablo Schreiber'),
(320, 68, 'Kevin Costner');


INSERT INTO MediaActors (MediaID, ActorID) VALUES
(1, 301),
(1, 305),
(2, 302),
(2, 310),
(3, 303),
(3, 304),
(4, 309),
(4, 306),
(5, 304),
(5, 312),
(6, 308),
(6, 307),
(7, 307),
(7, 314),
(8, 314),
(8, 311),
(9, 310),
(9, 313),
(10, 312),
(10, 309),
(11, 311),
(11, 318),
(12, 312),
(12, 317),
(13, 313),
(13, 309),
(14, 314),
(14, 307),
(15, 318),
(15, 315),
(16, 316),
(16, 309),
(17, 317),
(17, 316),
(18, 318),
(18, 310),
(19, 319),
(19, 318),
(20, 320),
(20, 319);


INSERT INTO Seasons (MediaID, EpisodeCount, Name) VALUES
(1, 10, 'Season 1'),
(1, 10, 'Season 2'),
(2, 8, 'Season 1'),
(2, 9, 'Season 2'),
(3, 7, 'Season 1'),
(3, 13, 'Season 2'),
(3, 16, 'Season 3'),
(4, 10, 'Season 1'),
(5, 10, 'Season 1'),
(5, 10, 'Season 2'),
(6, 8, 'Season 1'),
(6, 10, 'Season 2'),
(7, 9, 'Season 1'),
(8, 10, 'Season 1'),
(8, 10, 'Season 2'),
(9, 8, 'Season 1'),
(10, 10, 'Season 1'),
(11, 16, 'Season 1'),
(12, 13, 'Season 1'),
(12, 14, 'Season 2'),
(13, 3, 'Season 1'),
(14, 6, 'Season 1'),
(14, 6, 'Season 2'),
(15, 8, 'Season 1'),
(16, 6, 'Season 1'),
(17, 10, 'Season 1'),
(18, 8, 'Season 1'),
(19, 9, 'Season 1'),
(19, 9, 'Season 2'),
(20, 10, 'Season 1'),
(20, 10, 'Season 2');



INSERT INTO Episodes (Duration, Name, SeasonName, EpisodeNumber, MediaID) VALUES
(60, 'Winter Is Coming', 'Season 1', 1, 1),
(62, 'The North Remembers', 'Season 2', 1, 1),
(50, 'The Vanishing of Will Byers', 'Season 1', 1, 2),
(54, 'Chapter Three: Holly, Jolly', 'Season 2', 1, 2),
(58, 'Pilot', 'Season 1', 1, 3),
(55, '...And the Bag''s in the River', 'Season 2', 1, 3),
(60, 'Wolferton Splash', 'Season 1', 1, 4),
(55, 'Uno', 'Season 1', 1, 5),
(48, 'The Original', 'Season 1', 1, 6),
(50, 'Chestnut', 'Season 2', 1, 6),
(52, 'When You Got Good', 'Season 1', 1, 7),
(54, 'Narcos', 'Season 1', 1, 8),
(48, 'Secrets', 'Season 1', 1, 9),
(55, 'Sugarwood', 'Season 1', 1, 10),
(60, 'Days Gone Bye', 'Season 1', 1, 11),
(58, 'Smoke Gets in Your Eyes', 'Season 1', 1, 12),
(50, 'My Coffee with Jesus', 'Season 2', 1, 12),
(52, 'A Study in Pink', 'Season 1', 1, 13),
(50, 'Red Right Hand', 'Season 1', 1, 14),
(52, 'Episode Two', 'Season 2', 1, 14);

INSERT INTO MediaRating (MediaID, UserID, Rating) VALUES
(1, 1, 5),    -- Alice rates GoT
(1, 10, 4),   -- David rates GoT
(2, 2, 4),    -- Bob rates Stranger Things
(2, 11, 5),   -- Sara rates Stranger Things
(3, 3, 5),    -- Charlie rates Breaking Bad
(3, 1, 5),    -- Alice rates Breaking Bad
(4, 2, 4),    -- Bob rates The Crown
(5, 3, 5),    -- Charlie rates Better Call Saul
(6, 10, 4),   -- David rates Westworld
(7, 11, 5),   -- Sara rates The Last of Us
(8, 12, 5),   -- Linda rates Narcos
(9, 13, 4),   -- Mark rates Dark
(10, 14, 5),  -- Noor rates Ozark
(11, 1, 5),   -- Alice rates The Walking Dead
(12, 2, 4),   -- Bob rates Mad Men
(13, 3, 5),   -- Charlie rates Sherlock
(14, 10, 5),  -- David rates Peaky Blinders
(15, 11, 5),  -- Sara rates The Mandalorian
(16, 12, 4),  -- Linda rates Loki
(17, 13, 4),  -- Mark rates The Morning Show
(18, 14, 5),  -- Noor rates See
(19, 1, 4),   -- Alice rates Halo
(20, 2, 5);   -- Bob rates Yellowstone






INSERT INTO Payment (PaymentID, Price, Subscription, UserID) VALUES
(401, 9.99, 'Basic Plan', 1),
(402, 15.99, 'Standard Plan', 2),
(403, 19.99, 'Premium Plan', 3),
(404, 9.99, 'Basic Plan', 10),
(405, 15.99, 'Standard Plan', 11),
(406, 19.99, 'Premium Plan', 12),
(407, 9.99, 'Basic Plan', 13),
(408, 15.99, 'Standard Plan', 14);

INSERT INTO List (ListName, UserID)
VALUES 
('My Favorites', 1),
('Watch Later', 2),
('Weekend Binge', 3),
('Top Picks', 10),
('Binge List', 11),
('Must Watch', 12),
('Favorite Shows', 13),
('Watch Soon', 14);


INSERT INTO ListItems (ListID, MediaID) VALUES
(1, 1),  -- Alice adds Game of Thrones
(1, 3),  -- Alice adds Breaking Bad
(1, 5),  -- Alice adds Better Call Saul
(2, 2),  -- Bob adds Stranger Things
(2, 4),  -- Bob adds The Crown
(2, 8),  -- Bob adds Narcos
(3, 1),  -- Charlie adds Game of Thrones
(3, 6),  -- Charlie adds Westworld
(3, 7),  -- Charlie adds The Last of Us
(4, 9),  -- David adds Dark
(4, 10), -- David adds Ozark
(4, 11), -- David adds The Walking Dead
(5, 12), -- Sara adds Mad Men
(5, 13), -- Sara adds Sherlock
(5, 14), -- Sara adds Peaky Blinders
(6, 15), -- Linda adds The Mandalorian
(6, 16), -- Linda adds Loki
(7, 17), -- Mark adds The Morning Show
(7, 18), -- Mark adds See
(8, 19), -- Noor adds Halo
(8, 20); -- Noor adds Yellowstone


-- =======================================================
-- 14. Insert WatchHistory
-- =======================================================
INSERT INTO WatchHistory (MediaID, UserID, WatchDate) VALUES
(1, 1, '2023-11-01 20:30:00'),
(1, 1, '2023-11-04 22:00:00'),
(2, 2, '2023-11-02 21:00:00'),
(3, 3, '2023-11-03 19:15:00'),
(4, 2, '2023-11-05 20:00:00'),
(5, 3, '2023-11-06 21:30:00'),
(6, 10, '2023-11-07 19:45:00'),
(7, 11, '2023-11-08 22:15:00'),
(8, 12, '2023-11-09 20:30:00'),
(9, 13, '2023-11-10 21:00:00'),
(10, 14, '2023-11-11 19:50:00'),
(11, 1, '2023-11-12 22:20:00'),
(12, 2, '2023-11-13 20:10:00'),
(13, 3, '2023-11-14 21:40:00'),
(14, 10, '2023-11-15 19:30:00'),
(15, 11, '2023-11-16 20:50:00'),
(16, 12, '2023-11-17 21:15:00'),
(17, 13, '2023-11-18 22:05:00'),
(18, 14, '2023-11-19 20:45:00'),
(19, 1, '2023-11-20 21:25:00');
GO