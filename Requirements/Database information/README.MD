# Database Information
## Table of Contents
1. [Entity Relationship Diagram](https://github.com/jonathan-f-gomez/unnamed-time-application/tree/main/Requirements/Database%20information#entity-relationship-diagram)
2.  [Database Script](https://github.com/jonathan-f-gomez/unnamed-time-application/tree/main/Requirements/Database%20information#database-script)
3.   [Database Diagram](https://github.com/jonathan-f-gomez/unnamed-time-application/tree/main/Requirements/Database%20information#database-diagram)

## Entity Relationship Diagram
![ERD](https://github.com/jonathan-f-gomez/unnamed-time-application/blob/main/Requirements/Database%20information/ERD.png)


## Database Script

````
DROP DATABASE IF EXISTS UnnamedApplication;

CREATE DATABASE UnnamedApplication;

Use UnnamedApplication

CREATE TABLE Users 
(
	UserID int NOT NULL IDENTITY PRIMARY KEY, ---Auto-Increment UserID 
    FirstName nvarchar(50), ---Going off data I read on stack Overflow for inclusive names
	LastName nvarchar(50) -----^^^^
    
);

----This Table differs from my ER diagram. My 3rd table in my ERD was 
----reduntant when i could put it all in my tasks table.

CREATE TABLE Tasks 
(
	TaskID int NOT NULL IDENTITY PRIMARY KEY, 
	TaskName nvarchar (100), --About 20 words
	TaskInfo ntext, 
	TaskPrority int,
	DateCreated datetime DEFAULT GETDATE(),
	DueDate datetime,
	IsComplete bit NOT NULL DEFAULT 0, --0 for false, 1 for true
	UserID INT NOT NULL REFERENCES Users(UserID)
);

CREATE TABLE PomoTimerSettings
(	--Data for Count Down Timers--
	WorkTimer time DEFAULT '00:25:00', 
	LongTimer time DEFAULT '00:15:00',
	ShortTimer time DEFAULT '00:05:00',
	UserID int NOT NULL REFERENCES Users(UserID)
);
````

## Database Diagram
![DbD](https://github.com/jonathan-f-gomez/unnamed-time-application/blob/main/Requirements/Database%20information/DatabaseDiagram.png)


