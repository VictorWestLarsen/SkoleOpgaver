CREATE VIEW AllOrderLines
AS 
SELECT O.Order_Id, C.FName, C.LName, O.Order_Date, P.Prod_Name, P.Price, OL.Amount
FROM EX62_Order AS O

JOIN EX62_Customer AS C
ON O.Customer = C.Customer_Id

JOIN EX62_OrderLine AS OL
ON OL.Order_Id = O.Order_Id

JOIN EX62_Product AS P
ON P.Product_Id = OL.Product_Id


