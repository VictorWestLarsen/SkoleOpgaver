CREATE PROC VisL�ge
@PersonId		int
AS
BEGIN
SELECT Navn, Ex31Person.PersonId, Ex31L�ge.L�nramme FROM Ex31Person
INNER JOIN Ex31L�ge 
ON Ex31Person.PersonId = Ex31L�ge.PersonId
Where Ex31Person.PersonId = @PersonId
END