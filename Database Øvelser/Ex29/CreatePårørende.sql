CREATE TABLE P�r�rende(
	P�r�rendeId	int					identity(1,1),
	L�geId		int					NOT NULL,
	Navn		NvarChar(MAX)		NOT NULL,
	AdresseId	int					NOT NULL,
	Dato		datetime2			NOT NULL,
--
CONSTRAINT		P�R�RENDE_PK		PRIMARY KEY(P�r�rendeId),
CONSTRAINT		L�GE_FK				FOREIGN KEY(L�geId)
				REFERENCES			L�ge(L�geId)

)