CREATE TABLE L�ge(
	L�geId		INT			identity(1,1),
	AdresseId	INT			NOT NULL,
	KlinikId	INT			NOT NULL,
	L�nrammeId	Char(1)		NOT NULL,

--
CONSTRAINT		L�GE_PK		PRIMARY KEY(L�geId),
CONSTRAINT		ADRES_FK	FOREIGN KEY(AdresseId)
				REFERENCES	Adresse(AdresseId),
CONSTRAINT		KLINIK_FK	FOREIGN KEY(KlinikId)
				REFERENCES	Klinik(KlinikId),
CONSTRAINT		L�N_FK		FOREIGN KEY(L�nrammeId)
				REFERENCES	L�nramme(L�nrammeId)
)