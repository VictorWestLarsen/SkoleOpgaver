CREATE TABLE Tractor(
Horsepower		INT				Null,
VIN				NvarCHar(50)	NOT NULL,
--
CONSTRAINT		TRACTOR_PK		PRIMARY KEY(VIN),
CONSTRAINT		VINTRACTOR_FK	FOREIGN KEY(VIN)
				REFERENCES		Machine(VIN)
)
CREATE TABLE Harvester(
Performance		Decimal(5,5)	Null,
VIN				NvarCHar(50)	NOT NULL,
--
CONSTRAINT		HARVESTER_PK	PRIMARY KEY(VIN),
CONSTRAINT		VINHARVESTER_FK	FOREIGN KEY(VIN)
				REFERENCES		Machine(VIN)
)
CREATE TABLE Plow(
No_of_Chisels	int				Null,
VIN				NvarCHar(50)	NOT NULL,
--
CONSTRAINT		PLOW_PK		PRIMARY KEY(VIN),
CONSTRAINT		VINCPLOW_FK	FOREIGN KEY(VIN)
				REFERENCES		Machine(VIN)
)