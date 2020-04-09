CREATE TABLE Education(
EducationID			int				IDENTITY(1,1),
Name				Nvarchar(100)	NOT NULL,
Category			Nvarchar(200)	Not NUll,
--
CONSTRAINT			EDUCATION_PK		PRIMARY KEY(EducationID)
)