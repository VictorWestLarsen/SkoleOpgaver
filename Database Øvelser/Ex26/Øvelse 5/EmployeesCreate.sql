CREATE TABLE Employees(
Name		NvarChar(100)		NULL,
Address		NvarChar(100)		NULL,
Zipcode		INT					NULL,
Department	NvarChar(50)		NULL,
TelephoneNo	NvarChar(50)		NOT NULL,
--
CONSTRAINT		EMPLOYEES_PK		PRIMARY KEY(TelephoneNo)
)