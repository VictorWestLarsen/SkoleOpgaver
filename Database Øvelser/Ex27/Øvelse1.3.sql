Alter PROC InsertPet(
@PetName	Nvarchar(30)	= 'No name',
@PetType	Nvarchar(20)	= 'Dog',
@PetBreed	Nvarchar(20)	= 'Unknown',
@PetDOB		DateTime2(7)	= Null,
@PetWeight	float			= 0.0,
@OwnerID	int
)
AS
Insert into PET(PetName, PetType, PetBreed, PetDOB, PetWeight, OwnerID)
Values(@PetName, @PetType, @PetBreed, @PetDOB, @PetWeight, @OwnerID)