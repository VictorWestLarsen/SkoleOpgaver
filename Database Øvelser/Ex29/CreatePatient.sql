CREATE TABLE Patient(
	PatientId		int				Identity(1,1),
	AdresseId		int				NOT NULL,
	L�geId			int				NOT NULL,
	Navn			NVARCHAR(MAX)	NULL,

--
CONSTRAINT			PATEINT_PK		PRIMARY KEY(PatientId),
CONSTRAINT			Adress_FK		FOREIGN KEY(AdresseId)
					REFERENCES		Adresse(AdresseId),
CONSTRAINT			L�geId_PK		FOREIGN KEY(L�geId)
					REFERENCES		L�ge(L�geId)
)