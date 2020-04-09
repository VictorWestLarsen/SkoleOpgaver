CREATE TABLE Subjects(
SubjectID		INT				IDENTITY(1,1),
Title			Nvarchar(100)	Not Null,
NoOfLesson		INT				NOT NULL,
--
CONSTRAINT		SUBJECT_PK		PRIMARY KEY(SubjectID)
)