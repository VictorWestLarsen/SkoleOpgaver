CREATE TABLE Journalist(
Subject			Nvarchar(100)		NOT NULL,
Part_Time		Binary				NOT NULL,
Telephonenumber	NvarChar(20)		NOT NULL,
	
--
CONSTRAINT		JOURNALIST_PK		PRIMARY KEY(Telephonenumber),
CONSTRAINT		EMPLOYEE_FK			FOREIGN KEY(Telephonenumber)
REFERENCES		Employee(Telephonenumber)
)