SELECT DISTINCT OwnerLastName, OwnerFirstName, OwnerEmail FROM PET_OWNER AS OWN
JOIN PET AS P
ON OWN.OwnerID = P.OwnerID
INNER JOIN BREED
ON P.PetBreed = BREED.BreedName
Where BREED.AverageLifeExpectancy > 15 