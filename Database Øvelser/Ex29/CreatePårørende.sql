CREATE TABLE Pårørende(
	PårørendeId	int					identity(1,1),
	LægeId		int					NOT NULL,
	Navn		NvarChar(MAX)		NOT NULL,
	AdresseId	int					NOT NULL,
	Dato		datetime2			NOT NULL,
--
CONSTRAINT		PÅRØRENDE_PK		PRIMARY KEY(PårørendeId),
CONSTRAINT		LÆGE_FK				FOREIGN KEY(LægeId)
				REFERENCES			Læge(LægeId)

)