CREATE TABLE Field(
FieldID			INT					Identity(1,1),
PropertyID		INT					NOT NULL,
Location		NvarChar(100)		NULL,
Size			Decimal(18,18)		NULL,
SoilQuality		INT					NULL,
--
CONSTRAINT		FIELD_PK		PRIMARY KEY(FieldID),
CONSTRAINT		PROP_FK			FOREIGN KEY(PropertyID)
				REFERENCES		Property(PropertyID)

)