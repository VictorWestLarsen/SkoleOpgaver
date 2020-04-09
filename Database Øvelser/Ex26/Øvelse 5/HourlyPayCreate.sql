CREATE TABLE HourlyPay(
TelephoneNo				Nvarchar(50)	NOT NULL,
SalaryForTheYear		Money			NOT NULL,
TaxForTheYear			Money			NOT NULL,
WeeklyDeduction			Money			NOT NULL,
TaxPercentage			Decimal(5,5)	NOT NULL,
--
CONSTRAINT			HOURLYPAY_PK		PRIMARY KEY(TelephoneNo),
CONSTRAINT			EMPLOYEET_FK		FOREIGN KEY(TelephoneNo)
					REFERENCES			Employees(TelephoneNo)
)