CREATE TABLE BREED(
BreedName				NVARChar(20)	NOT NULL,
MinWeight				Decimal(18,1)	NULL,
MaxWeight				Decimal(18,1)	NULL,
AverageLifeExpectancy	int				NULL,
--
CONSTRAINT				BREED_PK		PRIMARY KEY(BreedName)
)