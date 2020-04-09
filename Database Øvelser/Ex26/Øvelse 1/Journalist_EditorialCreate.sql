CREATE TABLE Journalist_Editorial(
Telephonenumber		Nvarchar(20)		NOT NULL,
EditorialID			int					NOT NULL,
--
CONSTRAINT			JOURNEDIT_PK		PRIMARY KEY(Telephonenumber, EditorialID),
CONSTRAINT			Journalist_FK		FOREIGN KEY(Telephonenumber)
					REFERENCES			Journalist(Telephonenumber),
CONSTRAINT			EDITORIAL_FK		FOREIGN KEY(EditorialID)
					REFERENCES			Editorial(EditorialID)
)