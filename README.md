# EGYBEST ProMax

## Project Overview
This project is a **Database Management System (DBMS) simulation** of a media streaming platform.  
The focus is on **database design, entity relationships, normalization, and role-based data management** rather than full platform functionality.

The system supports three types of users:
- **End-User (Viewer)**  
- **Administrator (Admin)**  
- **Publisher (Content Provider)**  

It tracks **media content, subscriptions, watch history, ratings**, and enables **analytics queries** for the platform.

---

## Database Explanation

The database is designed to handle all aspects of a **media streaming platform**. Here’s an overview of the key tables and their purpose:

### 1. Users and Roles
- **User**: Superclass representing anyone accessing the platform (name, email, password).  
- **EndUser**: Subclass for viewers/subscribers; tracks subscription plans and watch history.  
- **Administrator**: Subclass for system managers; can manage users, content, and view statistics.  
- **Publisher**: Subclass for content providers; can upload media, add seasons/episodes, and manage their profile.

### 2. Media Content
- **Media**: Core table for all movies and shows (title, status, number of favorites).  
- **Show**: Subclass of Media that contains multiple seasons.  
- **Season**: Collection of episodes within a show.  
- **Episode**: Individual content unit within a season.  
- **Actor**: Stores performers and their roles; connected to Media.  
- **MediaGenre**: Categorizes media into genres (e.g., Action, Drama).

### 3. User Interactions
- **Payment**: Tracks subscription transactions for EndUsers.  
- **WatchHistory**: Logs when a user watches a piece of media.  
- **List**: Custom collections created by EndUsers (e.g., Favorites, Watch Later).

### 4. Relationships
- **Inheritance**: EndUser, Admin, and Publisher inherit from User.  
- **One-to-many**: Publisher → Media, Show → Season → Episode.  
- **Many-to-many**: Media ↔ Actor, EndUser ↔ List ↔ Media.  
- Ensures **data integrity** and supports complex queries for analytics.

### 5. Analytics & Features
- Easily retrieve top-rated shows, most watched media, or active subscribers.  
- Allows monitoring of publisher activity and user engagement.  
- Normalized tables reduce redundancy and simplify maintenance.  

---

## How to Run the Project

1. **Open the Solution File:**  
   Open `CMPS-202-project.slnx` in **Visual Studio** (or your preferred IDE that supports .slnx).  
   This file contains the project setup and references needed to run the application.

2. **Setup the Database:**  
   Inside the `Database` folder, you have:  
   - **Database Creation.sql** – defines all tables, keys, and relationships.  
   - **Database Insertion.sql** – populates the database with sample data.  
   - **Database Diagram.jpeg** – visual ER diagram showing the database structure.  

3. **Steps to Prepare the Database:**  
   - Open your SQL platform (MySQL, SQL Server, or PostgreSQL).  
   - Run `Database Creation.sql` first to create all tables and relationships.  
   - Run `Database Insertion.sql` to populate the database with sample data.  
   - Refer to `Database Diagram.jpeg` to understand the schema and relationships.  

4. **Run the Project:**  
   Once the database is set up, run the `CMPS-202-project.slnx` solution.  
   The project will connect to the database and allow you to perform queries, view media, and simulate user interactions according to the roles (End-User, Admin, Publisher).
