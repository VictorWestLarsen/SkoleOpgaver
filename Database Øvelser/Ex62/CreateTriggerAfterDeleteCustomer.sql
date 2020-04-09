CREATE TRIGGER AfterDeleteCustomer ON [dbo].[EX62_Customer]
AFTER DELETE

AS
	DECLARE @CustomerID		int;
	DECLARE @CustomerFName	NvarChar(40);
	DECLARE @CustomerLName	Nvarchar(40);
	DECLARE @CustomerZip	NvarChar(4);

	SELECT @CustomerID = C.Customer_Id FROM deleted C;
	SELECT @CustomerFName = C.FName FROM deleted C;
	SELECT @CustomerLName = C.LName FROM deleted C;
	SELECT @CustomerZip = C.Zip FROM deleted C;


	insert into EX62_DeletedCustomer
	(Id, FName, LName, Zip)
	values(@CustomerID, @CustomerFName, @CustomerLName, @CustomerZip)

	PRINT'Well done M8!'

GO