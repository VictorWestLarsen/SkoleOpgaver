CREATE PROC GetPets
AS
Select PetID, PetName, PetType, PetBreed, PetDOB, PetWeight, OwnerID
From PET