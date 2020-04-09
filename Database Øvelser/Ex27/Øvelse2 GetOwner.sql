CREATE PROC GetOwners
AS
Select OwnerID, OwnerFirstName, OwnerLastName, OwnerPhone, OwnerEmail 
FROM PET_OWNER