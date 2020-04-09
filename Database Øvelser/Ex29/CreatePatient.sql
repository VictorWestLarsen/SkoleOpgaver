CREATE TABLE Patient(
	PatientId		int				Identity(1,1),
	AdresseId		int				NOT NULL,
	LægeId			int				NOT NULL,
	Navn			NVARCHAR(MAX)	NULL,

--
CONSTRAINT			PATEINT_PK		PRIMARY KEY(PatientId),
CONSTRAINT			Adress_FK		FOREIGN KEY(AdresseId)
					REFERENCES		Adresse(AdresseId),
CONSTRAINT			LægeId_PK		FOREIGN KEY(LægeId)
					REFERENCES		Læge(LægeId)
)