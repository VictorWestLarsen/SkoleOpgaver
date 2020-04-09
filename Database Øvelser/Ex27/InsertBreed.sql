ALTER PROC InsertBreed(
	@BreedName						Nvarchar(20),
	@MinWeight						Decimal(18,1)	=0.0,
	@MaxWeight						Decimal(18,1)	=0.0,
	@AverageLifeExpectancy			int				= NULL
)
as
insert into BREED(BreedName, MinWeight, MaxWeight, AverageLifeExpectancy)
VALUES (@BreedName, @MinWeight,@MaxWeight,@AverageLifeExpectancy)