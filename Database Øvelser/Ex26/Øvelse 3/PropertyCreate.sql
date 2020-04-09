CREATE TABLE Property(
PropertyID	INT					IDENTITY(1,1),
Name		Nvarchar(100)		NULL,
Size		Decimal(18,18)		NULL,
Address		NvarChar(100)		NULL,
--
CONSTRAINT		PROP_PK			PRIMARY KEY(PropertyID),
)