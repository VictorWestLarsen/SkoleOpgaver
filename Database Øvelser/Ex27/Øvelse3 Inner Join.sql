Alter PROC GetOwnerByID(
		@OwnerID	int
)
AS
SELECT PetName, PetType, PetBreed, AverageLifeExpectancy 
FROM PET_OWNER AS Owner
-- Inner Joins Med Pet
INNER JOIN PET As Pet
ON Owner.OwnerID = Pet.OwnerID
-- Inner Joins med Breed
INNER JOIN BREED as Breed
On Breed.BreedName = Pet.PetBreed
Where @OwnerID = Owner.OwnerID