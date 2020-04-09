SELECT OwnerFirstName, OwnerLastName, OwnerEmail From PET_OWNER
WHERE OwnerID IN (Select OwnerID From PET WHERE PetType='Cat' AND PetName = 'Teddy')