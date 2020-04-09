CREATE PROC InsertOwner(
	@OwnerLastName		Nvarchar(30)	= 'No Name',
	@OwnerFirstName		Nvarchar(30)	= 'No Name',
	@OwnerPhone			Nvarchar(12)	= NULL,
	@OwnerEmail			Nvarchar(100)
)
as
Insert into PET_OWNER (OwnerLastName, OwnerFirstName,OwnerPhone, OwnerEmail)
Values (@OwnerLastName, @OwnerFirstName, @OwnerPhone, @OwnerEmail)