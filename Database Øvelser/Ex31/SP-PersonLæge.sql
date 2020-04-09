CREATE PROC INDSÆT_LÆGE
@Navn			Nvarchar(max),
@Lønramme		Char(1)
AS
Begin
DECLARE @LastValue AS int

INSERT INTO EX31Person(Navn) values (@Navn)
SET @LastValue =(SELECT SCOPE_IDENTITY());

Insert into Ex31Læge (Lønramme, PersonId)
VALUES(@Lønramme, @LastValue)

END