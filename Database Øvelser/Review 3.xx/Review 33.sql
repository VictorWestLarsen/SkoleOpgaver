SELECT PetBreed, AVG(PetWeight) From PET
GROUP BY PetBreed 
HAVING COUNT(*) > 1