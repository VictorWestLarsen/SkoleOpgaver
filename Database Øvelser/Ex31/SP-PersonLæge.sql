CREATE PROC INDS�T_L�GE
@Navn			Nvarchar(max),
@L�nramme		Char(1)
AS
Begin
DECLARE @LastValue AS int

INSERT INTO EX31Person(Navn) values (@Navn)
SET @LastValue =(SELECT SCOPE_IDENTITY());

Insert into Ex31L�ge (L�nramme, PersonId)
VALUES(@L�nramme, @LastValue)

END