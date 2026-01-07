# EGYBEST ProMax 🎬💾

## Project Overview 🌟
This project is a **Database Management System (DBMS) simulation** of a media streaming platform.  
The focus is on **database design, entity relationships, normalization, and role-based data management** rather than full platform functionality.

The system supports three types of users:
- **End-User (Viewer)**  
- **Administrator (Admin)**  
- **Publisher (Content Provider)**  

It tracks **media content, subscriptions, watch history, ratings**, and enables **analytics queries** for the platform.

---

## How to Run the Project ⚡

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

---

## Database Overview 📊

The database contains the following **core entities**:  
- **User hierarchy:** User → EndUser / Admin / Publisher  
- **Media content:** Media, Show, Season, Episode  
- **Metadata:** Actor, MediaGenre  
- **User interactions:** Payment, WatchHistory, List  

### Key Features:
- Normalized tables to reduce redundancy.  
- Role-based data access and relationships.  
- Analytics capabilities through SQL queries for favorites, ratings, and subscriptions.  

---

*This project demonstrates best practices in database design, role-based management, and analytics queries, making it ideal for academic DBMS coursework.* ✅
