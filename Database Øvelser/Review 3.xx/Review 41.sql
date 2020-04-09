SELECT OwnerFirstName, OwnerLastName, OwnerEmail, PetName, PetType, PetBreed 
FROM PET_OWNER as OWN INNER JOIN PET AS P ON OWN.OwnerID = P.OwnerID
INNER JOIN BREED AS B ON P.PetBreed = B.BreedName
Where P.PetBreed != 'Unknown'

