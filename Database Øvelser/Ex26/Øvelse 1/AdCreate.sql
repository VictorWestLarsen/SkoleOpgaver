CREATE TABLE Ad(
AdId				Int						Identity(1,1),
Telephonenumber		Nvarchar(20)			NOT NULL,
Costumer			Nvarchar(50)			NOT NULL,
Size				Nvarchar(50)			NOT NULL,
Price				Money					NOT NULL,
--
CONSTRAINT			AD_PK					PRIMARY KEY(AdId),
CONSTRAINT			SALESMP_FK				FOREIGN KEY(Telephonenumber)	
					REFERENCES				SalesEmp(Telephonenumber)		
)