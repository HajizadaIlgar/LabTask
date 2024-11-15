--CREATE DATABASE Academy
--USE Academy

--CREATE TABLE Students
--(
--	Id INT IDENTITY PRIMARY KEY,
--	FirstName NVARCHAR(128) DEFAULT'Boş',
--	LastName NVARCHAR(128) DEFAULT'Boş',
--	DateOfBirth DATE,
--	UserName NVARCHAR(128),
--	Password NVARCHAR(255),
--	EnrollmentDate DATE
--)
--INSERT INTO Students VALUES
--(N'Ilqar',N'Hacizade','2005/06/10',N'17Ilqarrr',N'12424412','2024/10/01')

--CREATE PROCEDURE InsertStudents
--	@FirstName NVARCHAR(128),
--	@LastName NVARCHAR(128),
--	@DateOfBirth DATE,
--	@UserName NVARCHAR(128),
--	@Password NVARCHAR(255),
--	@EnrollmentDate DATE
--	AS 
--	BEGIN
--	INSERT INTO Students(FirstName,LastName,DateOfBirth,UserName,
--	Password,EnrollmentDate)
--	VALUES(@FirstName,@LastName,@DateOfBirth,@UserName,
--	@Password,@EnrollmentDate)
--	END
--	EXEC InsertStudents N'Musa',N'Abdullazada','2005/11/09',N'Mouseskinges',
--	N'musa777','2024/10/01'
CREATE TABLE Departments
(
	Id INT IDENTITY PRIMARY KEY,
	DepartmentName NVARCHAR(128)
)
--INSERT INTO Departments VALUES
--(N'Code Academy'),(N'DiV Academy'),(N'It Brains')

SELECT * FROM INSTRUCTORS
CREATE TABLE Instructors
(
	Id INT IDENTITY PRIMARY KEY,
	FirstName NVARCHAR(128) DEFAULT'Boş',
	LastName NVARCHAR(128) DEFAULT'Boş',
	HireDate DATE,
	DepartmentId INT REFERENCES Departments(Id),
	UserName NVARCHAR(128),
	Password NVARCHAR(128),
	PIN NVARCHAR(20) UNIQUE
)
--INSERT INTO Instructors VALUES
----(N'VILAYAT',N'ALIYEV','2023/10/01',1,N'VILAYAT_ALIYEV',N'CODDE19827',N'6WW7OBM')
--(N'ULVI',N'ABDULLAZADA','2020/09/01',3,N'U1vi',N'IT8723',N'2TGB2OP')

CREATE TABLE Groups
(
	Id INT IDENTITY PRIMARY KEY,
	GroupName NVARCHAR(64) NOT NULL,
	DepartmentId INT REFERENCES Departments(Id),
	StartDate DATE DEFAULT'YY-MM-DD',
	EndDate DATE DEFAULT'YY-MM-DD'
)
SELECT * FROM GROUPS
--INSERT INTO Groups VALUES
--(N'AB108',1,'2024/10/01','2025/01/10')

CREATE TABLE Enrollments
(
	Id INT IDENTITY PRIMARY KEY,
	StudentId INT REFERENCES Students(Id),
	GroupId INT REFERENCES Groups(Id)
)
SELECT * FROM STUDENTS
SELECT * FROM GROUPS

--INSERT INTO Enrollments VALUES(1,1),(2,1)

CREATE TABLE ClassesTable
(
	Id INT IDENTITY PRIMARY KEY,
	GroupId INT REFERENCES Groups(Id),
	StudentId INT REFERENCES Students(Id),
	Schedule NVARCHAR(124) NOT NULL,
	RoomName NVARCHAR(64) NOT NULL
)

INSERT INTO ClassesTable VALUES
(1,1,N'Mon/Wed/Fri 09:00-13:00',N'Mars')

SELECT s.FirstName,s.LastName,g.GroupName,cls.Schedule,cls.RoomName FROM ClassesTable AS cls
JOIN Groups AS g
ON cls.GroupId=g.Id
JOIN Students AS s
ON cls.StudentId=s.Id
