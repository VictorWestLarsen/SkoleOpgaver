CREATE TABLE Adresse(
	AdresseId		int				identity(1,1),
	Gade			NVARCHAR(MAX)	NOT NULL,
	HuseNr			NVARCHAR(MAX)	NOT NULL,
	PostNr			NVARCHAR(MAX)	NOT NULL,
	ByNavn			NVARCHAR(MAX)	NOT NULL,

--
CONSTRAINT			ADRESSE_PK		PRIMARY KEY(AdresseId),
)