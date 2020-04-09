CREATE TABLE Læge(
	LægeId		INT			identity(1,1),
	AdresseId	INT			NOT NULL,
	KlinikId	INT			NOT NULL,
	LønrammeId	Char(1)		NOT NULL,

--
CONSTRAINT		LÆGE_PK		PRIMARY KEY(LægeId),
CONSTRAINT		ADRES_FK	FOREIGN KEY(AdresseId)
				REFERENCES	Adresse(AdresseId),
CONSTRAINT		KLINIK_FK	FOREIGN KEY(KlinikId)
				REFERENCES	Klinik(KlinikId),
CONSTRAINT		LØN_FK		FOREIGN KEY(LønrammeId)
				REFERENCES	Lønramme(LønrammeId)
)