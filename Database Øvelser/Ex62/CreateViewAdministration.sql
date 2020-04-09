CREATE VIEW Administration
AS
SELECT E.FName, E.LName, E.Zip
FROM EX62_Employee AS E

JOIN EX62_ZipCity AS Z
ON E.Zip = Z.Zip

JOIN EX62_Department AS D
ON E.Dep_Id = D.Dep_Id
WHERE D.Dep_Id = 1;