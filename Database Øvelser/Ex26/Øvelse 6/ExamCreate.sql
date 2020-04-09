CREATE TABLE Exam(
ExamID			int				identity(1,1),
SubjectID		int				Not null,
Level			int				not null,
gradingType		NvarChar(100)	Not null,
--
CONSTRAINT		EXAM_PK			PRIMARY KEY(ExamID),
CONSTRAINT		SUBJECT_FK		FOREIGN KEY(SubjectID)
				REFERENCES		Subjects(SubjectID)
)