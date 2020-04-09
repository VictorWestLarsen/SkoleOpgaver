SELECT PetBreed, AVG(PetWeight) From PET
WHERE PetBreed != 'Unknown'
GROUP BY PetBreed 
HAVING COUNT(*) > 1
