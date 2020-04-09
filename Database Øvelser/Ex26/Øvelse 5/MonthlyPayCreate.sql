CREATE TABLE MonthlyPay(
SalaryForTheYear		Money			NOT NULL,
TaxForTheYear			Money			NOT NULL,
MonthlyDeduction		Money			NOT NULL,
TaxPercentage			Decimal(5,5)	NOT NULL,
TelephoneNo				NvarChar(50)	NOT NULL,
--	
CONSTRAINT			MONTHLYPAY_PK		PRIMARY KEY(TelephoneNo),
CONSTRAINT			EMPLOY_FK			FOREIGN KEY(TelephoneNo)
					REFERENCES			Employees(TelephoneNo)
)