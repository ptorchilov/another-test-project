CREATE TABLE [dbo].[Students]
(
	[StudentId] INT NOT NULL PRIMARY KEY,
	[LastName] NVARCHAR(255) NOT NULL,
	[FirstName] NVARCHAR(255) NOT NULL,
	[EnrollmentDate] DATETIME NOT NULL
)
