CREATE TABLE Machine(
VIN			NvarChar(50)		NOT NULL,
Brand		NvarChar(20)		NULL,
Model		Nvarchar(20)		NULL,
Year		int					NULL,
--
CONSTRAINT		MACHINE_PK		PRIMARY KEY(VIN),
)