CREATE TABLE BeerBottling(
BottleId			INT			Identity(1,1),
Bottling_Date		Date		NOT NULL,
Amount				INT			NOT NULL,
PackID				INT			NOT NULL,
--
CONSTRAINT			BEERBOTTLING_PK		PRIMARY KEY(BottleId),
CONSTRAINT			PACK_FK				FOREIGN KEY(PackID)
					REFERENCES			Packaging(PackID)		
)