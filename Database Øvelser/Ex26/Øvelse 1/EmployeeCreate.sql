CREATE TABLE Employee(
Name				NvarChar(50)	NOT NULL,
Address				NvarChar(50)	NULL,
Zipcode				Nvarchar(20)	NULL,
City				NvarChar(50)	NULL,
Telephonenumber		Nvarchar(20)	NOT NULL,
Department			NvarChar(50)	NOT NULL,
--
CONSTRAINT			EMPLOYEE_PK	PRIMARY KEY(Telephonenumber)
)