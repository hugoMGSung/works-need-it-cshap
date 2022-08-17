USE master;
GO

CREATE DATABASE MvvmDB;
GO

USE MvvmDB;
GO

CREATE TABLE dbo.PeopleTbl(
	Idx int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	FirstName nvarchar(30) NOT NULL,
	LastName nvarchar(30) NOT NULL
);
GO

SET IDENTITY_INSERT dbo.PeopleTbl ON 
GO
INSERT dbo.PeopleTbl (Idx, FirstName, LastName) VALUES (1, N'Ashley', N'Park');
INSERT dbo.PeopleTbl (Idx, FirstName, LastName) VALUES (2, N'Hugo MG ', N'Sung');
INSERT dbo.PeopleTbl (Idx, FirstName, LastName) VALUES (3, N'Bill', N'Gates');
INSERT dbo.PeopleTbl (Idx, FirstName, LastName) VALUES (4, N'Steve', N'Jobs');
INSERT dbo.PeopleTbl (Idx, FirstName, LastName) VALUES (5, N'Tony', N'Stark');
GO
SET IDENTITY_INSERT dbo.PeopleTbl OFF
GO


