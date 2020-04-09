CREATE TABLE Timesheet(
SheetID		int				identity(1,1),
Hours		Decimal(3,2)	Not null,
TelephoneNo	Nvarchar(50)	Not NUll,
--
CONSTRAINT		TIMESHEET_PK	PRIMARY KEY(SheetID),
CONSTRAINT		HOURLY_FK		FOREIGN KEY(TelephoneNo)
				REFERENCES		HourlyPay(TelephoneNo)	
)