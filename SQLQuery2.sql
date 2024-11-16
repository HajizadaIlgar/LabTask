CREATE DATABASE Hospital
USE Hospital

CREATE TABLE Doctors
(
	Id INT IDENTITY PRIMARY KEY,
	FirstName NVARCHAR(16),
	LastName NVARCHAR(20),
	Email NVARCHAR(128),
	PhoneNum NVARCHAR(128) UNIQUE DEFAULT 'XXX-XXX-XX-XX',
	IsDelete BIT DEFAULT 0,
	Created_at DATE,
	LastModifiedDate DATE
)

CREATE PROCEDURE dbo.DoctorsInsert
@FirstName NVARCHAR(16),
@LastName NVARCHAR(20),
@Email NVARCHAR(128),
@PhoneNum NVARCHAR(128) ,
@IsDelete BIT,
@Created_at DATE,
@LastModifiedDate DATE
AS 
BEGIN
INSERT INTO dbo.Doctors 
(
FirstName ,
LastName ,
Email ,
PhoneNum ,
IsDelete ,
Created_at ,
LastModifiedDate 
)
VALUES 
(
@FirstName ,
@LastName ,
@Email ,
@PhoneNum ,
@IsDelete ,
@Created_at ,
@LastModifiedDate 
)
END

EXEC dbo.DoctorsInsert N'Ilqar',N'Hacizade','HajiyevIlgar8@gamil.com',
'050-234-23-32',0,'2024-11-14','2024-12-14'

--ALTER TABLE Doctors
--ADD  LastModifiedDate DATE
SELECT * FROM Doctors
