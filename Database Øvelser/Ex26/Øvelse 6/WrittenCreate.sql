CREATE TABLE Written(
PreparationTime		DECIMAL(3,2)		NOT NULL,
ExaminationTime		Decimal(3,2)		Not null,
Aids				NvarChar(500)		Not nUll,
ExamID				int					Not null,
--
CONSTRAINT			WRITTEN_PK			PRIMARY KEY(ExamID),
CONSTRAINT			EXAMS1_FK			FOREIGN KEY(ExamID)
					REFERENCES			Exam(ExamID)
)