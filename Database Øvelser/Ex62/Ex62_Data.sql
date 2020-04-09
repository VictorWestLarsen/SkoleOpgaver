BEGIN
	SET NOCOUNT ON
	
	DELETE FROM EX62_Manager;
	DELETE FROM EX62_OrderLine;
	DELETE FROM EX62_Product;
	DELETE FROM EX62_Order;
	DELETE FROM EX62_Customer;
	DELETE FROM EX62_Department;
	DELETE FROM EX62_Employee;
	DELETE FROM EX62_ZipCity;

	INSERT INTO EX62_ZipCity VALUES (N'5000', N'Odense');
	INSERT INTO EX62_ZipCity VALUES (N'8000', N'Aarhus');
	INSERT INTO EX62_ZipCity VALUES (N'3900', N'Nuuk');
	INSERT INTO EX62_ZipCity VALUES (N'5320', N'Agedrup')
		
	INSERT INTO EX62_Department(Dept_Name) VALUES (N'Administration')
	INSERT INTO EX62_Department(Dept_Name) VALUES (N'Sales_Food')
	INSERT INTO EX62_Department(Dept_Name) VALUES (N'Sales_Clothing')

	INSERT INTO EX62_Employee(FName, LName, Dep_Id, Zip) VALUES (N'Ib', N'Ibsen', 1, N'5000');
	INSERT INTO EX62_Employee(FName, LName, Dep_Id, Zip) VALUES (N'Pia', N'Larsen', 2, N'5320');
	INSERT INTO EX62_Employee(FName, LName, Dep_Id, Zip) VALUES (N'Knud', N'Rasmussen', 2, N'3900');
	INSERT INTO EX62_Employee(FName, LName, Dep_Id, Zip) VALUES (N'Jacob', N'Haugaard', 3, N'8000');
	INSERT INTO EX62_Employee(FName, LName, Dep_Id, Zip) VALUES (N'Ronja', N'Røverdatter', 3, N'5000');

	
	INSERT INTO EX62_Customer VALUES(N'Kurt', N'Kurtsen', N'5000');
	INSERT INTO EX62_Customer VALUES(N'Niels', N'Nielsen', N'3900');
	INSERT INTO EX62_Customer VALUES(N'Lars', N'Larsen', N'5320');
	INSERT INTO EX62_Customer VALUES(N'Ea', N'Easen', N'8000');
	INSERT INTO EX62_Customer VALUES(N'Lotte', N'Lottesen', N'8000');

	INSERT INTO EX62_Order(Customer, Order_Date, Paid) VALUES (1, '2-JAN-2017', 0);
	INSERT INTO EX62_Order(Customer, Order_Date, Paid) VALUES (1, '7-APR-2017', 0);
	INSERT INTO EX62_Order(Customer, Order_Date, Paid) VALUES (2, '16-JUN-2017', 1);
	INSERT INTO EX62_Order(Customer, Order_Date, Paid) VALUES (2, '18-JUL-2017', 0);
	INSERT INTO EX62_Order(Customer, Order_Date, Paid) VALUES (3, '13-AUG-2017', 0);
	INSERT INTO EX62_Order(Customer, Order_Date, Paid) VALUES (4, '5-SEP-2017', 0);
	INSERT INTO EX62_Order(Customer, Order_Date, Paid) VALUES (4, '15-SEP-2017', 1);
	INSERT INTO EX62_Order(Customer, Order_Date, Paid) VALUES (5, '23-NOV-2017', 0);
	
	INSERT INTO EX62_Product VALUES('Cake', 107.44);
	INSERT INTO EX62_Product VALUES('Jeans', 759.35);
	INSERT INTO EX62_Product VALUES('Shirt', 173.90);
	INSERT INTO EX62_Product VALUES('Meat', 99.55);
	INSERT INTO EX62_Product VALUES('Potato', 17.59);

	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (1, 1, 3);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (1, 3, 1);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (2, 2, 1);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (2, 3, 2);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (2, 5, 1);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (3, 4, 2);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (4, 2, 2);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (4, 4, 1);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (4, 5, 1);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (5, 1, 1);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (6, 2, 1);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (6, 3, 2);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (6, 5, 1);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (7, 1, 3);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (7, 4, 4);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (8, 2, 2);
	INSERT INTO EX62_OrderLine(Order_Id, Product_Id, Amount) VALUES (8, 4, 1);

	INSERT INTO EX62_Manager VALUES (1, 1);
	INSERT INTO EX62_Manager VALUES (2, 1);
	INSERT INTO EX62_Manager VALUES (3, 4);

	SET NOCOUNT OFF
END
