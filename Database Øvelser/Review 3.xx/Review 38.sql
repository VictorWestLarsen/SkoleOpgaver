SELECT DISTINCT OwnerLastName, OwnerFirstName, OwnerEmail 
FROM PET_OWNER INNER JOIN PET ON PET_OWNER.OwnerID = PET.OwnerID and PetType = 'Cat'
