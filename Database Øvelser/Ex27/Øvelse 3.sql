alter PROC GetOwnersByLastName(
	@LastName Nvarchar(25)
)
AS
SELECT OwnerID, OwnerLastName, OwnerFirstName, OwnerPhone, OwnerEmail
FROM PET_OWNER
where OwnerLastName = @LastName