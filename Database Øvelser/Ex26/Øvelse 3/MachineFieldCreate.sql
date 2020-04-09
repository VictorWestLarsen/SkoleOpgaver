CREATE TABLE Machine_Field(
VIN				NvarChar(50)	NOT NULL,
FieldID			int				NOT NULL,
--
CONSTRAINT		MACHINE_FIELD_PK	PRIMARY KEY(VIN,FieldID),
CONSTRAINT		MACHINE_FIELD_FK	FOREIGN KEY(VIN)
				REFERENCES			Machine(VIN),
CONSTRAINT		FIELD_MACHINE_FK	FOREIGN KEY(FieldID)
				REFERENCES			Field(FieldID),
)
