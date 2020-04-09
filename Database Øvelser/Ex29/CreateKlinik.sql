CREATE TABLE Klinik(
	KlinikId	int		identity(1,1),
	AdresseId	int		NOT NULL,
--
CONSTRAINT			KLINIK_PK			PRIMARY KEY(KlinikId),
CONSTRAINT			ADRESSID_FK			FOREIGN KEY(AdresseId)
					REFERENCES			Adresse(AdresseId)	
)
