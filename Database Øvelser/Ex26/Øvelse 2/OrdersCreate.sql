CREATE TABLE Orders(
OrderID		INT				Identity(1,1),
Date		Date			Not NUll,
Amount		int				Not NUll,
PackID		INT				NOT NULL,
--
CONSTRAINT		ORDERS_PK			Primary Key(OrderID),
CONSTRAINT		PACKING_FK			FOREIGN KEY(PackID)
				REFERENCES			Packaging(PackID)
	
)