CREATE VIEW AllEmployees
AS
Select E.Emp_Id, E.FName, E.LName, E.Zip, Z.City, D.Dept_Name, M.Manager
FROM  EX62_Employee AS E

JOIN EX62_Manager AS M 
ON E.Emp_Id = M.Dep_Id

JOIN EX62_ZipCity AS Z
On E.Zip = Z.Zip

JOIN EX62_Department AS D
on E.Dep_Id = D.Dep_Id

SELECT * FROM AllEmployees