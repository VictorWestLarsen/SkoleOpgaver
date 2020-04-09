CREATE PROC InsertPet(
@PetName	Nvarchar(30),
@PetType	Nvarchar(20),
@PetBreed	Nvarchar(20),
@PetDOB		DateTime2(7),
@PetWeight	float,
@OwnerID	int
)
AS
Insert into PET(PetName, PetType, PetBreed, PetDOB, PetWeight, OwnerID)
Values(@PetName, @PetType, @PetBreed, @PetDOB, @PetWeight, @OwnerID)