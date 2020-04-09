CREATE TABLE Packaging(
PackID			INT				Identity(1,1), --Surrogate Key
Type			Nvarchar(50)	NOT NULL,
Size			Nvarchar(50)	NOT NULL,
Amount			int				NOT NULL,
--
CONSTRAINT		Packaging_PK		PRIMARY KEY(PackID)
)