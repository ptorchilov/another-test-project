CREATE TABLE [dbo].[Enrollment]
(
	[EnrollmentId] INT NOT NULL PRIMARY KEY,
	[CourseId] INT NOT NULL,
	[StudentId] INT NOT NULL,
	[Grade] DATETIME
)
