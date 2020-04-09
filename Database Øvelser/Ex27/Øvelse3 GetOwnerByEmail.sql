CREATE PROC GetOwnerByEmail(
	@Email		Nvarchar(100),
	@FirstName	Nvarchar(30)
)

AS
SELECT OwnerID, OwnerFirstName, OwnerLastName, OwnerPhone, OwnerEmail
FROM PET_OWNER
WHERE OwnerFirstName = @FirstName AND OwnerEmail = @Email