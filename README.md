# EGYBEST ProMax – Database Management Project 🎬💾

## Project Overview 🌟

**EGYBEST ProMax** is a **database management project** simulating an online media streaming system. The focus is on **database design, entity relationships, and management** rather than full platform functionality.

The system supports three types of users: **End-User (Viewer)**, **Administrator (Admin)**, and **Publisher (Content Provider)**, all inheriting from a central `User` entity.

---

## System Users 👥

| User Type                    | Description                                                               |
| ---------------------------- | ------------------------------------------------------------------------- |
| Viewer (End-User)            | Subscribes to plans, creates lists, rates media, generates watch history. |
| Administrator (Admin)        | Manages users, content, and platform statistics.                          |
| Publisher (Content Provider) | Uploads media, updates metadata, and manages profile.                     |

---

## User Functionalities (Database Perspective) 🔍

### End-User 🎥

* Manage profile and subscription plans.
* Create custom lists (Favorites, Watch Later) stored in the database.
* Rate movies and shows.
* Watch history logged in `WatchHistory` table.

### Administrator 🛠️

* Create, update, or delete users and media in the database.
* Access platform-wide statistics: total users, media counts, and ratings.
* Ensure data integrity through controlled operations.

### Publisher ✨

* Manage profile including website links.
* Upload movies or shows, add seasons and episodes.
* Update media metadata and track statistics.
* Directly linked to media through `Publishes` relationship.

---

## Database Entities and Relationships 📊

| Entity            | Description              | Key Attributes                                         | Relationships                               |
| ----------------- | ------------------------ | ------------------------------------------------------ | ------------------------------------------- |
| **User**          | Superclass for all users | UserID (PK), Name, Email, Password                     | EndUser, Admin, Publisher inherit from User |
| **EndUser**       | Viewers/subscribers      | UserID (FK), SubscriptionLevel                         | Has WatchHistory, Lists, Payments           |
| **Administrator** | System manager           | UserID (FK), AdminLevel                                | Can manage Users and Media                  |
| **Publisher**     | Content provider         | UserID (FK), Website                                   | Publishes Media                             |
| **Media**         | Movies or Shows          | MediaID (PK), Name, FinishedStatus, NumberOfFavorites  | Related to Publisher, Show, Actor, Genre    |
| **Show**          | Subclass of Media        | MediaID (FK), NumberOfSeasons                          | Contains Seasons                            |
| **Season**        | Collection of episodes   | SeasonID (PK), ShowID (FK), SeasonNumber               | Contains Episodes                           |
| **Episode**       | Single unit of content   | EpisodeID (PK), SeasonID (FK), EpisodeNumber, Duration | Belongs to Season                           |
| **Actor**         | Media performer          | ActorID (PK), Name                                     | Appears in Media                            |
| **Payment**       | Subscription transaction | PaymentID (PK), UserID (FK), Plan, Date                | Linked to EndUser                           |
| **List**          | User-defined collection  | ListID (PK), UserID (FK), Name                         | Contains Media via ListItems                |
| **WatchHistory**  | Tracks watched media     | HistoryID (PK), UserID (FK), MediaID (FK), Timestamp   | Belongs to EndUser                          |
| **MediaGenre**    | Media category           | GenreID (PK), Name                                     | Linked to Media                             |

---

## Database Design Highlights 💡

* **Inheritance**: `User` table is the superclass for `EndUser`, `Admin`, and `Publisher`. 🏷️
* **Normalization**: Tables structured to reduce redundancy. 📚
* **Relationships**:

  * One-to-many: Publisher → Media, Show → Season → Episode 🔗
  * Many-to-many: Media ↔ Actor, EndUser ↔ List ↔ Media 🔄
* **Transaction Management**: Payments table ensures subscription integrity 💳
* **Logs**: WatchHistory table records user activity for analytics 📝

---

## Project Goals (Database-Focused) 🎯

* Design a **normalized relational database** for users, subscriptions, media, and interactions.
* Demonstrate **entity relationships, inheritance, and referential integrity**.
* Enable **role-based data management** through database operations.
* Support **analytics queries** for ratings, favorites, and media statistics.

---

*This project highlights database design and management excellence, making it ideal for academic demonstration of DBMS concepts.* ✅

