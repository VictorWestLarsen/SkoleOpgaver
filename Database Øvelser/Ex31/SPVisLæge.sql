CREATE PROC VisLæge
@PersonId		int
AS
BEGIN
SELECT Navn, Ex31Person.PersonId, Ex31Læge.Lønramme FROM Ex31Person
INNER JOIN Ex31Læge 
ON Ex31Person.PersonId = Ex31Læge.PersonId
Where Ex31Person.PersonId = @PersonId
END