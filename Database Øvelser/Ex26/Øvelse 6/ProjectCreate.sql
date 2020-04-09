CREATE TABLE Project(
MaxGroupSize		int				Not null,
ExaminationTime		Decimal(3,2)	Not null,
Maxpages			Decimal(3,2)	Not Null,
ExamID				int				Not NUll,
--
CONSTRAINT			PROJECT_PK		PRIMARY KEY(ExamID),
CONSTRAINT			EXAMSS_FK		FOREIGN KEY(ExamID)
					REFERENCES		Exam(ExamID)
)