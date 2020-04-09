CREATE TABLE Editorial(
EditorialID		int				Identity(1,1),
Title			NvarChar(50)	NOT	NULL,
Priority		int				NOT NULL,
--
CONSTRAINT		EDITORIAL_PK	PRIMARY KEY(EditorialID)
)