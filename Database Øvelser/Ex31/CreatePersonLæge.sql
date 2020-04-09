CREATE TABLE Ex31Person(
	PersonId		int				identity(1,1),
	Navn			Nvarchar(MAX)	NOT NULL,

--
CONSTRAINT		PERSON_PK		PRIMARY KEY(PersonId)
)

CREATE TABLE Ex31Læge(
	Lønramme		char(1)			Not NUll,
	PersonId		INT				Not Null,

--
CONSTRAINT			LÆGEN_PK			PRIMARY KEY(PersonId),
CONSTRAINT			LÆGEN_FK			FOREIGN KEY(PersonId)
					References			Ex31Person(PersonId)
					ON UPDATE CASCADE
					ON DELETE CASCADE

)