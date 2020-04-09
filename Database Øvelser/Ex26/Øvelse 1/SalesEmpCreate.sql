CREATE TABLE SalesEmp(
Telephonenumber		Nvarchar(20)		NOT NULL,
Costumersegment		Nvarchar(50)		NOT NULL,
Budget				Money				NOT NULL,
--
CONSTRAINT			SalesEmp_PK			PRIMARY KEY(Telephonenumber),
CONSTRAINT			Sale_Employee_FK	FOREIGN	KEY(Telephonenumber)
					REFERENCES			Employee(Telephonenumber)
)