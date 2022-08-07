CREATE DATABASE PTSProject;
USE PTSProject;

CREATE TABLE project
(
ProjectID uniqueidentifier UNIQUE NOT NULL,
ProjectName nvarchar(50) NOT NULL,
ExpectedStartDate datetime,
ExpectedEndDate datetime,
ActualStartDate datetime,
ActualEndDate nchar(10),
Completed bit,
CustomerID int NOT NULL,
AdministartorID int NOT NULL,
PRIMARY KEY (ProjectID)
);

CREATE TABLE task
(
TaskID uniqueidentifier UNIQUE NOT NULL,
TaskName nvarchar(50) NOT NULL,
ExpectedStartDate datetime NOT NULL,
ExpectedEndDate datetime NOT NULL,
ActualStartDate datetime,
ActualEndDate datetime,
ProjectID uniqueidentifier NOT NULL,
TeamID int NOT NULL,
StatusID int NOT NULL,
PercentageCompleted tinyint,
PRIMARY KEY (TaskID)
);

CREATE TABLE subtask
(
SubTaskID int IDENTITY(1, 1) UNIQUE NOT NULL,
SubTaskName nvarchar(50),
StatusID int NOT NULL,
PercentageCompleted tinyint,
TaskID uniqueidentifier NOT NULL,
TeamMemberID int

PRIMARY KEY (SubTaskID)
);

CREATE TABLE projectStatus
(
StatusID int IDENTITY(1, 1) NOT NULL,
ProjectName nvarchar(50) NOT NULL

PRIMARY KEY (StatusID)
);

CREATE TABLE predecessor
(
TaskID uniqueidentifier NOT NULL,
PredecessorID uniqueidentifier NOT NULL
CONSTRAINT Two_PrimaryKeys UNIQUE(TaskID, PredecessorID)
);

CREATE TABLE customer
(
CustomerID int IDENTITY(1, 1) UNIQUE NOT NULL,
CustomerName nvarchar(50),
Username nvarchar(50),
Customer_Password nvarchar(50),
Email nvarchar(50),
Telephone_NO nvarchar(50),
Company nvarchar(50),
Customer_Address nvarchar(200),
Country nvarchar(50)

PRIMARY KEY (CustomerID)
);

CREATE TABLE team
(
TeamID int IDENTITY(1, 1) UNIQUE NOT NULL,
TeamName nvarchar(50) NOT NULL,
Team_Location nvarchar(50) NOT NULL,
TeamLeaderID int,
Is_External bit

PRIMARY KEY (TeamID)
);

CREATE TABLE person
(
UserID int IDENTITY(1, 1) UNIQUE NOT NULL,
Persons_Name nvarchar(50) NOT NULL,
Username nvarchar(50) NOT NULL,
Persons_Password nvarchar(50) NOT NULL,
Email nvarchar(50),
Telephone_NO nvarchar(50),
Is_Administrator bit

PRIMARY KEY (UserID)
);

CREATE TABLE TEAMMEMBER
(
UserID int NOT NULL,
TeamID int NOT NULL
CONSTRAINT TeamMembers_PrimaryKeys UNIQUE (UserID, TeamID)
);